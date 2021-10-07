using System;
using System.Runtime.InteropServices;

namespace dgtk.Platforms.X11
{
    internal static class OGLPreparation
    {
        public static void PreparationOGLContext(IntPtr ptr_display, int ScreenId, ref IntPtr FBConfig, out XVisualInfo visual, out IntPtr P_Visual)//, IntPtr SharedContext, bool Direct)
        {
			dgtk.OpenGL.InternalTool.GetOS();
            int glx_mayor=0; int glx_minor=0;
            if(!glx.glXQueryVersion(ptr_display, ref glx_mayor, ref glx_minor))
			{
				Console.WriteLine("GLX : glXQueryVersion FAIL!");
			}

            if ((glx_mayor >= 1) && (glx_minor >= 3))  //OpenGL >= 1.2
			{
				unsafe
				{
					int[] VisualFBAttributes = new int[] {
							(int)glxVisualFBAttributes.GLX_X_RENDERABLE, 1,
							(int)glxVisualFBAttributes.GLX_RENDER_TYPE, (int)glxVisualFBAttributes.GLX_RGBA_BIT,
							(int)glxVisualFBAttributes.GLX_DRAWABLE_TYPE, (int)glxVisualFBAttributes.GLX_WINDOW_BIT,
							(int)glxVisualFBAttributes.GLX_X_VISUAL_TYPE, (int)glxVisualFBAttributes.GLX_TRUE_COLOR,
							(int)glxVisualAttributes.GLX_RED_SIZE, 8,
							(int)glxVisualAttributes.GLX_GREEN_SIZE, 8,
							(int)glxVisualAttributes.GLX_BLUE_SIZE, 8,
							(int)glxVisualAttributes.GLX_ALPHA_SIZE, 8,
							(int)glxVisualAttributes.GLX_DEPTH_SIZE, 16,
							(int)glxVisualAttributes.GLX_STENCIL_SIZE, 8,
							(int)glxVisualFBAttributes.GLX_DOUBLEBUFFER, 1,
							0
						};
					int n_items;
					IntPtr* glFBConfigptr = glx.glXChooseFBConfig (ptr_display, ScreenId, VisualFBAttributes, out n_items);

					int best_fbc = 0, best_num_samp = -1, buf_num_samp = -1;
					//int depth = 0, bits_R = 0, bits_G = 0, bits_B = 0, bits_A = 0, renderable = 0, ID=0;
					for (int i=0;i<n_items;i++)
					{
						IntPtr vi = glx.glXGetVisualFromFBConfig( ptr_display, glFBConfigptr[i] );
						
						if (vi != IntPtr.Zero)
						{
							XVisualInfo tempvisual = (XVisualInfo)Marshal.PtrToStructure (vi, typeof(XVisualInfo));	
							int samp_buf, samples; //, bits_R, bits_G, bits_B, bits_A, depth, rederable;
							glx.glXGetFBConfigAttrib( ptr_display, glFBConfigptr[i], (int)glxVisualFBAttributes.GLX_SAMPLE_BUFFERS, out samp_buf );
							glx.glXGetFBConfigAttrib( ptr_display, glFBConfigptr[i], (int)glxVisualFBAttributes.GLX_SAMPLES, out samples  );
							/*
							glx.glXGetFBConfigAttrib( ptr_display, glFBConfigptr[i], (int)glxVisualFBAttributes.GLX_FBCONFIG_ID, out ID);
							glx.glXGetFBConfigAttrib( ptr_display, glFBConfigptr[i], (int)glxVisualFBAttributes.GLX_DEPTH_BUFFER_BIT, out depth  );
							glx.glXGetFBConfigAttrib( ptr_display, glFBConfigptr[i], (int)glxVisualAttributes.GLX_RED_SIZE, out bits_R  );
							glx.glXGetFBConfigAttrib( ptr_display, glFBConfigptr[i], (int)glxVisualAttributes.GLX_GREEN_SIZE, out bits_G  );
							glx.glXGetFBConfigAttrib( ptr_display, glFBConfigptr[i], (int)glxVisualAttributes.GLX_BLUE_SIZE, out bits_B  );
							glx.glXGetFBConfigAttrib( ptr_display, glFBConfigptr[i], (int)glxVisualAttributes.GLX_ALPHA_SIZE, out bits_A  );
							glx.glXGetFBConfigAttrib( ptr_display, glFBConfigptr[i], (int)glxVisualFBAttributes.GLX_X_RENDERABLE, out renderable  );
							*/
							//Console.WriteLine("Index: "+i+" | ID: "+ID+" | SampleBuffers: "+samp_buf+" | Samples: "+samples+" | Depth: "+ depth +" | R: "+bits_R+" | G: "+bits_G+" | B: "+bits_B+" | A: "+bits_A+ " | RENDERABLE: " + (renderable==1 ? "true" : "false"));
							
							if (tempvisual.depth == 24)
							{
								if ((samp_buf >= buf_num_samp && samples >= best_num_samp ))
								{
									best_fbc = i; best_num_samp = samples; buf_num_samp = samp_buf;
								}
							}
							/*if ( worst_fbc < 0 || (samp_buf < worst_num_samp || samples < worst_num_samp ))
							{
								worst_fbc = i; worst_num_samp = samples;
							}	*/		
							//XVisualInfo temp_visual = (XVisualInfo)Marshal.PtrToStructure (vi, typeof(XVisualInfo));
							//Console.WriteLine("Depth: "+temp_visual.depth+" | "+temp_visual.screen)	;	
						}
						Imports.XFree( vi );
					}

					Console.WriteLine("Best FBC: "+best_fbc);

					FBConfig = glFBConfigptr[best_fbc];
					Imports.XFree( glFBConfigptr );
				}
				//Imports.XLockDisplay(ptr_display);
				P_Visual = glx.glXGetVisualFromFBConfig (ptr_display, FBConfig);
				//Imports.XUnlockDisplay(ptr_display);				

				visual = (XVisualInfo)Marshal.PtrToStructure (P_Visual, typeof(XVisualInfo));	
				//visual.BitsPerRGB = 24;
				//Console.WriteLine("OpenGL >= 1.2");			
            }
            else
            {
				unsafe 
				{
					int[] glxVisualAttribs = new int[] {
							(int)glxVisualAttributes.GLX_RGBA, 
							(int)glxVisualAttributes.GLX_DOUBLEBUFFER,
							(int)glxVisualAttributes.GLX_RED_SIZE, 1, 
							(int)glxVisualAttributes.GLX_GREEN_SIZE, 1, 
							(int)glxVisualAttributes.GLX_BLUE_SIZE, 1,
							0
						};
					fixed (int* attr = glxVisualAttribs)
					{
						Imports.XLockDisplay(ptr_display);
						P_Visual = glx.glXChooseVisual (ptr_display, ScreenId, (IntPtr)attr);
						Imports.XUnlockDisplay(ptr_display);
					}
				}	
				visual = (XVisualInfo)Marshal.PtrToStructure(P_Visual, typeof(XVisualInfo));
				
            }
			//Console.WriteLine("PreparationOGLContext");
        }

		public static IntPtr Getglxwin(IntPtr ptr_display, IntPtr FBConfig, IntPtr WinHandle)
		{
			IntPtr xglwin = WinHandle;
			int glx_mayor=0; int glx_minor=0;
            if(!glx.glXQueryVersion(ptr_display, ref glx_mayor, ref glx_minor))
			{
				Console.WriteLine("GLX : glXQueryVersion FAIL!");
			}
			if ((glx_mayor >= 1) && (glx_minor >= 3))  //OpenGL >= 1.2
			{
				xglwin = glx.glXCreateWindow(ptr_display, FBConfig, WinHandle, new IntPtr(0)); //Fail with WinForms
			}
			return xglwin;
		}

		public static OpenGL.OGL_Context GenerateOGL_Context(IntPtr ptr_display, IntPtr xglwin, ref XVisualInfo visual, IntPtr SharedContext, bool Direct)
		{
			OpenGL.OGL_Context ret;
			IntPtr cntxt = glx.glXCreateContext(ptr_display, ref visual, SharedContext, Direct);

			ret = new OpenGL.OGL_Context(ptr_display, xglwin, cntxt);
			ret.X11MakeCurrent();
			dgtk.OpenGL.DelegastesInitGL.InitDelegates();
			ret.X11UnMakeCurrent();
			return ret;
		}

		[DllImport("opengl32.dll", EntryPoint = "glGetIntegerv", SetLastError = true)]
		private static extern void glGetInteger(uint name, out int major);
    }
}
