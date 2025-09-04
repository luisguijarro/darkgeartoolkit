// OpenGL|ES Delegates Initializer for Extensions.
// File Created with OpenGL Parser 3.
// Developed by Luis Guijarro Pérez.

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace dgtk.OpenGL
{
	internal static partial class DelegastesInitGLes
	{
		private static List<string> SuportedExt;

		internal static void InitdelegatesGLESExts()
		{
			SuportedExt = new List<string>();
			int oglVer = int.Parse(oglGetString(dgtk.OpenGL.StringName.GL_VERSION).Split('.')[0]);
			if (oglVer<3)
			{
				string[] oglExts = oglGetString(dgtk.OpenGL.StringName.GL_EXTENSIONS).Split(' ');
				SuportedExt.AddRange(oglExts);
			}
			else
			{
				glGetIntegerv = (dglGetIntegerv)dgtk.OpenGL.InternalGLesTool.GetGLesMethodAdress("glGetIntegerv", typeof(dglGetIntegerv));
				glGetStringi = (dglGetStringi)dgtk.OpenGL.InternalGLesTool.GetGLesMethodAdress("glGetStringi", typeof(dglGetStringi));
				int Extnum = oglGetIntegerv(dgtk.OpenGL.GetPName.GL_NUM_EXTENSIONS);
				for (int i=0;i<Extnum;i++)
				{
					string oglExts = oglGetStringi(dgtk.OpenGL.StringName.GL_EXTENSIONS, i);
					SuportedExt.Add(oglExts);
				}
			}
			#region A:

			if (SuportedExt.Contains("glAccumxOES"))
			{
				dgtk.OpenGL.internalGLES.glAccumxOES = (dgtk.OpenGL.delegatesGLES.glAccumxOES) InternalGLesTool.GetGLesMethodAdress("glAccumxOES", typeof(dgtk.OpenGL.delegatesGLES.glAccumxOES));
			}
			if (SuportedExt.Contains("glAcquireKeyedMutexWin32EXT"))
			{
				dgtk.OpenGL.internalGLES.glAcquireKeyedMutexWin32EXT = (dgtk.OpenGL.delegatesGLES.glAcquireKeyedMutexWin32EXT) InternalGLesTool.GetGLesMethodAdress("glAcquireKeyedMutexWin32EXT", typeof(dgtk.OpenGL.delegatesGLES.glAcquireKeyedMutexWin32EXT));
			}
			if (SuportedExt.Contains("glActiveProgramEXT"))
			{
				dgtk.OpenGL.internalGLES.glActiveProgramEXT = (dgtk.OpenGL.delegatesGLES.glActiveProgramEXT) InternalGLesTool.GetGLesMethodAdress("glActiveProgramEXT", typeof(dgtk.OpenGL.delegatesGLES.glActiveProgramEXT));
			}
			if (SuportedExt.Contains("glActiveShaderProgramEXT"))
			{
				dgtk.OpenGL.internalGLES.glActiveShaderProgramEXT = (dgtk.OpenGL.delegatesGLES.glActiveShaderProgramEXT) InternalGLesTool.GetGLesMethodAdress("glActiveShaderProgramEXT", typeof(dgtk.OpenGL.delegatesGLES.glActiveShaderProgramEXT));
			}
			if (SuportedExt.Contains("glAlphaFuncQCOM"))
			{
				dgtk.OpenGL.internalGLES.glAlphaFuncQCOM = (dgtk.OpenGL.delegatesGLES.glAlphaFuncQCOM) InternalGLesTool.GetGLesMethodAdress("glAlphaFuncQCOM", typeof(dgtk.OpenGL.delegatesGLES.glAlphaFuncQCOM));
			}
			if (SuportedExt.Contains("glAlphaFuncxOES"))
			{
				dgtk.OpenGL.internalGLES.glAlphaFuncxOES = (dgtk.OpenGL.delegatesGLES.glAlphaFuncxOES) InternalGLesTool.GetGLesMethodAdress("glAlphaFuncxOES", typeof(dgtk.OpenGL.delegatesGLES.glAlphaFuncxOES));
			}
			if (SuportedExt.Contains("glApplyFramebufferAttachmentCMAAINTEL"))
			{
				dgtk.OpenGL.internalGLES.glApplyFramebufferAttachmentCMAAINTEL = (dgtk.OpenGL.delegatesGLES.glApplyFramebufferAttachmentCMAAINTEL) InternalGLesTool.GetGLesMethodAdress("glApplyFramebufferAttachmentCMAAINTEL", typeof(dgtk.OpenGL.delegatesGLES.glApplyFramebufferAttachmentCMAAINTEL));
			}
			#endregion

			#region B:

			if (SuportedExt.Contains("glBeginConditionalRenderNV"))
			{
				dgtk.OpenGL.internalGLES.glBeginConditionalRenderNV = (dgtk.OpenGL.delegatesGLES.glBeginConditionalRenderNV) InternalGLesTool.GetGLesMethodAdress("glBeginConditionalRenderNV", typeof(dgtk.OpenGL.delegatesGLES.glBeginConditionalRenderNV));
			}
			if (SuportedExt.Contains("glBeginPerfMonitorAMD"))
			{
				dgtk.OpenGL.internalGLES.glBeginPerfMonitorAMD = (dgtk.OpenGL.delegatesGLES.glBeginPerfMonitorAMD) InternalGLesTool.GetGLesMethodAdress("glBeginPerfMonitorAMD", typeof(dgtk.OpenGL.delegatesGLES.glBeginPerfMonitorAMD));
			}
			if (SuportedExt.Contains("glBeginPerfQueryINTEL"))
			{
				dgtk.OpenGL.internalGLES.glBeginPerfQueryINTEL = (dgtk.OpenGL.delegatesGLES.glBeginPerfQueryINTEL) InternalGLesTool.GetGLesMethodAdress("glBeginPerfQueryINTEL", typeof(dgtk.OpenGL.delegatesGLES.glBeginPerfQueryINTEL));
			}
			if (SuportedExt.Contains("glBeginQueryEXT"))
			{
				dgtk.OpenGL.internalGLES.glBeginQueryEXT = (dgtk.OpenGL.delegatesGLES.glBeginQueryEXT) InternalGLesTool.GetGLesMethodAdress("glBeginQueryEXT", typeof(dgtk.OpenGL.delegatesGLES.glBeginQueryEXT));
			}
			if (SuportedExt.Contains("glBindFragDataLocationEXT"))
			{
				dgtk.OpenGL.internalGLES.glBindFragDataLocationEXT = (dgtk.OpenGL.delegatesGLES.glBindFragDataLocationEXT) InternalGLesTool.GetGLesMethodAdress("glBindFragDataLocationEXT", typeof(dgtk.OpenGL.delegatesGLES.glBindFragDataLocationEXT));
			}
			if (SuportedExt.Contains("glBindFragDataLocationIndexedEXT"))
			{
				dgtk.OpenGL.internalGLES.glBindFragDataLocationIndexedEXT = (dgtk.OpenGL.delegatesGLES.glBindFragDataLocationIndexedEXT) InternalGLesTool.GetGLesMethodAdress("glBindFragDataLocationIndexedEXT", typeof(dgtk.OpenGL.delegatesGLES.glBindFragDataLocationIndexedEXT));
			}
			if (SuportedExt.Contains("glBindFramebufferOES"))
			{
				dgtk.OpenGL.internalGLES.glBindFramebufferOES = (dgtk.OpenGL.delegatesGLES.glBindFramebufferOES) InternalGLesTool.GetGLesMethodAdress("glBindFramebufferOES", typeof(dgtk.OpenGL.delegatesGLES.glBindFramebufferOES));
			}
			if (SuportedExt.Contains("glBindProgramPipelineEXT"))
			{
				dgtk.OpenGL.internalGLES.glBindProgramPipelineEXT = (dgtk.OpenGL.delegatesGLES.glBindProgramPipelineEXT) InternalGLesTool.GetGLesMethodAdress("glBindProgramPipelineEXT", typeof(dgtk.OpenGL.delegatesGLES.glBindProgramPipelineEXT));
			}
			if (SuportedExt.Contains("glBindRenderbufferOES"))
			{
				dgtk.OpenGL.internalGLES.glBindRenderbufferOES = (dgtk.OpenGL.delegatesGLES.glBindRenderbufferOES) InternalGLesTool.GetGLesMethodAdress("glBindRenderbufferOES", typeof(dgtk.OpenGL.delegatesGLES.glBindRenderbufferOES));
			}
			if (SuportedExt.Contains("glBindShadingRateImageNV"))
			{
				dgtk.OpenGL.internalGLES.glBindShadingRateImageNV = (dgtk.OpenGL.delegatesGLES.glBindShadingRateImageNV) InternalGLesTool.GetGLesMethodAdress("glBindShadingRateImageNV", typeof(dgtk.OpenGL.delegatesGLES.glBindShadingRateImageNV));
			}
			if (SuportedExt.Contains("glBindVertexArrayOES"))
			{
				dgtk.OpenGL.internalGLES.glBindVertexArrayOES = (dgtk.OpenGL.delegatesGLES.glBindVertexArrayOES) InternalGLesTool.GetGLesMethodAdress("glBindVertexArrayOES", typeof(dgtk.OpenGL.delegatesGLES.glBindVertexArrayOES));
			}
			if (SuportedExt.Contains("glBitmapxOES"))
			{
				dgtk.OpenGL.internalGLES.glBitmapxOES = (dgtk.OpenGL.delegatesGLES.glBitmapxOES) InternalGLesTool.GetGLesMethodAdress("glBitmapxOES", typeof(dgtk.OpenGL.delegatesGLES.glBitmapxOES));
			}
			if (SuportedExt.Contains("glBlendBarrierKHR"))
			{
				dgtk.OpenGL.internalGLES.glBlendBarrierKHR = (dgtk.OpenGL.delegatesGLES.glBlendBarrierKHR) InternalGLesTool.GetGLesMethodAdress("glBlendBarrierKHR", typeof(dgtk.OpenGL.delegatesGLES.glBlendBarrierKHR));
			}
			if (SuportedExt.Contains("glBlendBarrierNV"))
			{
				dgtk.OpenGL.internalGLES.glBlendBarrierNV = (dgtk.OpenGL.delegatesGLES.glBlendBarrierNV) InternalGLesTool.GetGLesMethodAdress("glBlendBarrierNV", typeof(dgtk.OpenGL.delegatesGLES.glBlendBarrierNV));
			}
			if (SuportedExt.Contains("glBlendColorxOES"))
			{
				dgtk.OpenGL.internalGLES.glBlendColorxOES = (dgtk.OpenGL.delegatesGLES.glBlendColorxOES) InternalGLesTool.GetGLesMethodAdress("glBlendColorxOES", typeof(dgtk.OpenGL.delegatesGLES.glBlendColorxOES));
			}
			if (SuportedExt.Contains("glBlendEquationEXT"))
			{
				dgtk.OpenGL.internalGLES.glBlendEquationEXT = (dgtk.OpenGL.delegatesGLES.glBlendEquationEXT) InternalGLesTool.GetGLesMethodAdress("glBlendEquationEXT", typeof(dgtk.OpenGL.delegatesGLES.glBlendEquationEXT));
			}
			if (SuportedExt.Contains("glBlendEquationiEXT"))
			{
				dgtk.OpenGL.internalGLES.glBlendEquationiEXT = (dgtk.OpenGL.delegatesGLES.glBlendEquationiEXT) InternalGLesTool.GetGLesMethodAdress("glBlendEquationiEXT", typeof(dgtk.OpenGL.delegatesGLES.glBlendEquationiEXT));
			}
			if (SuportedExt.Contains("glBlendEquationiOES"))
			{
				dgtk.OpenGL.internalGLES.glBlendEquationiOES = (dgtk.OpenGL.delegatesGLES.glBlendEquationiOES) InternalGLesTool.GetGLesMethodAdress("glBlendEquationiOES", typeof(dgtk.OpenGL.delegatesGLES.glBlendEquationiOES));
			}
			if (SuportedExt.Contains("glBlendEquationOES"))
			{
				dgtk.OpenGL.internalGLES.glBlendEquationOES = (dgtk.OpenGL.delegatesGLES.glBlendEquationOES) InternalGLesTool.GetGLesMethodAdress("glBlendEquationOES", typeof(dgtk.OpenGL.delegatesGLES.glBlendEquationOES));
			}
			if (SuportedExt.Contains("glBlendEquationSeparateiEXT"))
			{
				dgtk.OpenGL.internalGLES.glBlendEquationSeparateiEXT = (dgtk.OpenGL.delegatesGLES.glBlendEquationSeparateiEXT) InternalGLesTool.GetGLesMethodAdress("glBlendEquationSeparateiEXT", typeof(dgtk.OpenGL.delegatesGLES.glBlendEquationSeparateiEXT));
			}
			if (SuportedExt.Contains("glBlendEquationSeparateiOES"))
			{
				dgtk.OpenGL.internalGLES.glBlendEquationSeparateiOES = (dgtk.OpenGL.delegatesGLES.glBlendEquationSeparateiOES) InternalGLesTool.GetGLesMethodAdress("glBlendEquationSeparateiOES", typeof(dgtk.OpenGL.delegatesGLES.glBlendEquationSeparateiOES));
			}
			if (SuportedExt.Contains("glBlendEquationSeparateOES"))
			{
				dgtk.OpenGL.internalGLES.glBlendEquationSeparateOES = (dgtk.OpenGL.delegatesGLES.glBlendEquationSeparateOES) InternalGLesTool.GetGLesMethodAdress("glBlendEquationSeparateOES", typeof(dgtk.OpenGL.delegatesGLES.glBlendEquationSeparateOES));
			}
			if (SuportedExt.Contains("glBlendFunciEXT"))
			{
				dgtk.OpenGL.internalGLES.glBlendFunciEXT = (dgtk.OpenGL.delegatesGLES.glBlendFunciEXT) InternalGLesTool.GetGLesMethodAdress("glBlendFunciEXT", typeof(dgtk.OpenGL.delegatesGLES.glBlendFunciEXT));
			}
			if (SuportedExt.Contains("glBlendFunciOES"))
			{
				dgtk.OpenGL.internalGLES.glBlendFunciOES = (dgtk.OpenGL.delegatesGLES.glBlendFunciOES) InternalGLesTool.GetGLesMethodAdress("glBlendFunciOES", typeof(dgtk.OpenGL.delegatesGLES.glBlendFunciOES));
			}
			if (SuportedExt.Contains("glBlendFuncSeparateiEXT"))
			{
				dgtk.OpenGL.internalGLES.glBlendFuncSeparateiEXT = (dgtk.OpenGL.delegatesGLES.glBlendFuncSeparateiEXT) InternalGLesTool.GetGLesMethodAdress("glBlendFuncSeparateiEXT", typeof(dgtk.OpenGL.delegatesGLES.glBlendFuncSeparateiEXT));
			}
			if (SuportedExt.Contains("glBlendFuncSeparateiOES"))
			{
				dgtk.OpenGL.internalGLES.glBlendFuncSeparateiOES = (dgtk.OpenGL.delegatesGLES.glBlendFuncSeparateiOES) InternalGLesTool.GetGLesMethodAdress("glBlendFuncSeparateiOES", typeof(dgtk.OpenGL.delegatesGLES.glBlendFuncSeparateiOES));
			}
			if (SuportedExt.Contains("glBlendFuncSeparateOES"))
			{
				dgtk.OpenGL.internalGLES.glBlendFuncSeparateOES = (dgtk.OpenGL.delegatesGLES.glBlendFuncSeparateOES) InternalGLesTool.GetGLesMethodAdress("glBlendFuncSeparateOES", typeof(dgtk.OpenGL.delegatesGLES.glBlendFuncSeparateOES));
			}
			if (SuportedExt.Contains("glBlendParameteriNV"))
			{
				dgtk.OpenGL.internalGLES.glBlendParameteriNV = (dgtk.OpenGL.delegatesGLES.glBlendParameteriNV) InternalGLesTool.GetGLesMethodAdress("glBlendParameteriNV", typeof(dgtk.OpenGL.delegatesGLES.glBlendParameteriNV));
			}
			if (SuportedExt.Contains("glBlitFramebufferANGLE"))
			{
				dgtk.OpenGL.internalGLES.glBlitFramebufferANGLE = (dgtk.OpenGL.delegatesGLES.glBlitFramebufferANGLE) InternalGLesTool.GetGLesMethodAdress("glBlitFramebufferANGLE", typeof(dgtk.OpenGL.delegatesGLES.glBlitFramebufferANGLE));
			}
			if (SuportedExt.Contains("glBlitFramebufferLayerEXT"))
			{
				dgtk.OpenGL.internalGLES.glBlitFramebufferLayerEXT = (dgtk.OpenGL.delegatesGLES.glBlitFramebufferLayerEXT) InternalGLesTool.GetGLesMethodAdress("glBlitFramebufferLayerEXT", typeof(dgtk.OpenGL.delegatesGLES.glBlitFramebufferLayerEXT));
			}
			if (SuportedExt.Contains("glBlitFramebufferLayersEXT"))
			{
				dgtk.OpenGL.internalGLES.glBlitFramebufferLayersEXT = (dgtk.OpenGL.delegatesGLES.glBlitFramebufferLayersEXT) InternalGLesTool.GetGLesMethodAdress("glBlitFramebufferLayersEXT", typeof(dgtk.OpenGL.delegatesGLES.glBlitFramebufferLayersEXT));
			}
			if (SuportedExt.Contains("glBlitFramebufferNV"))
			{
				dgtk.OpenGL.internalGLES.glBlitFramebufferNV = (dgtk.OpenGL.delegatesGLES.glBlitFramebufferNV) InternalGLesTool.GetGLesMethodAdress("glBlitFramebufferNV", typeof(dgtk.OpenGL.delegatesGLES.glBlitFramebufferNV));
			}
			if (SuportedExt.Contains("glBufferAttachMemoryNV"))
			{
				dgtk.OpenGL.internalGLES.glBufferAttachMemoryNV = (dgtk.OpenGL.delegatesGLES.glBufferAttachMemoryNV) InternalGLesTool.GetGLesMethodAdress("glBufferAttachMemoryNV", typeof(dgtk.OpenGL.delegatesGLES.glBufferAttachMemoryNV));
			}
			if (SuportedExt.Contains("glBufferPageCommitmentMemNV"))
			{
				dgtk.OpenGL.internalGLES.glBufferPageCommitmentMemNV = (dgtk.OpenGL.delegatesGLES.glBufferPageCommitmentMemNV) InternalGLesTool.GetGLesMethodAdress("glBufferPageCommitmentMemNV", typeof(dgtk.OpenGL.delegatesGLES.glBufferPageCommitmentMemNV));
			}
			if (SuportedExt.Contains("glBufferStorageEXT"))
			{
				dgtk.OpenGL.internalGLES.glBufferStorageEXT = (dgtk.OpenGL.delegatesGLES.glBufferStorageEXT) InternalGLesTool.GetGLesMethodAdress("glBufferStorageEXT", typeof(dgtk.OpenGL.delegatesGLES.glBufferStorageEXT));
			}
			if (SuportedExt.Contains("glBufferStorageExternalEXT"))
			{
				dgtk.OpenGL.internalGLES.glBufferStorageExternalEXT = (dgtk.OpenGL.delegatesGLES.glBufferStorageExternalEXT) InternalGLesTool.GetGLesMethodAdress("glBufferStorageExternalEXT", typeof(dgtk.OpenGL.delegatesGLES.glBufferStorageExternalEXT));
			}
			if (SuportedExt.Contains("glBufferStorageMemEXT"))
			{
				dgtk.OpenGL.internalGLES.glBufferStorageMemEXT = (dgtk.OpenGL.delegatesGLES.glBufferStorageMemEXT) InternalGLesTool.GetGLesMethodAdress("glBufferStorageMemEXT", typeof(dgtk.OpenGL.delegatesGLES.glBufferStorageMemEXT));
			}
			#endregion

			#region C:

			if (SuportedExt.Contains("glCheckFramebufferStatusOES"))
			{
				dgtk.OpenGL.internalGLES.glCheckFramebufferStatusOES = (dgtk.OpenGL.delegatesGLES.glCheckFramebufferStatusOES) InternalGLesTool.GetGLesMethodAdress("glCheckFramebufferStatusOES", typeof(dgtk.OpenGL.delegatesGLES.glCheckFramebufferStatusOES));
			}
			if (SuportedExt.Contains("glClearAccumxOES"))
			{
				dgtk.OpenGL.internalGLES.glClearAccumxOES = (dgtk.OpenGL.delegatesGLES.glClearAccumxOES) InternalGLesTool.GetGLesMethodAdress("glClearAccumxOES", typeof(dgtk.OpenGL.delegatesGLES.glClearAccumxOES));
			}
			if (SuportedExt.Contains("glClearColorxOES"))
			{
				dgtk.OpenGL.internalGLES.glClearColorxOES = (dgtk.OpenGL.delegatesGLES.glClearColorxOES) InternalGLesTool.GetGLesMethodAdress("glClearColorxOES", typeof(dgtk.OpenGL.delegatesGLES.glClearColorxOES));
			}
			if (SuportedExt.Contains("glClearDepthfOES"))
			{
				dgtk.OpenGL.internalGLES.glClearDepthfOES = (dgtk.OpenGL.delegatesGLES.glClearDepthfOES) InternalGLesTool.GetGLesMethodAdress("glClearDepthfOES", typeof(dgtk.OpenGL.delegatesGLES.glClearDepthfOES));
			}
			if (SuportedExt.Contains("glClearDepthxOES"))
			{
				dgtk.OpenGL.internalGLES.glClearDepthxOES = (dgtk.OpenGL.delegatesGLES.glClearDepthxOES) InternalGLesTool.GetGLesMethodAdress("glClearDepthxOES", typeof(dgtk.OpenGL.delegatesGLES.glClearDepthxOES));
			}
			if (SuportedExt.Contains("glClearPixelLocalStorageuiEXT"))
			{
				dgtk.OpenGL.internalGLES.glClearPixelLocalStorageuiEXT = (dgtk.OpenGL.delegatesGLES.glClearPixelLocalStorageuiEXT) InternalGLesTool.GetGLesMethodAdress("glClearPixelLocalStorageuiEXT", typeof(dgtk.OpenGL.delegatesGLES.glClearPixelLocalStorageuiEXT));
			}
			if (SuportedExt.Contains("glClearTexImageEXT"))
			{
				dgtk.OpenGL.internalGLES.glClearTexImageEXT = (dgtk.OpenGL.delegatesGLES.glClearTexImageEXT) InternalGLesTool.GetGLesMethodAdress("glClearTexImageEXT", typeof(dgtk.OpenGL.delegatesGLES.glClearTexImageEXT));
			}
			if (SuportedExt.Contains("glClearTexSubImageEXT"))
			{
				dgtk.OpenGL.internalGLES.glClearTexSubImageEXT = (dgtk.OpenGL.delegatesGLES.glClearTexSubImageEXT) InternalGLesTool.GetGLesMethodAdress("glClearTexSubImageEXT", typeof(dgtk.OpenGL.delegatesGLES.glClearTexSubImageEXT));
			}
			if (SuportedExt.Contains("glClientWaitSyncAPPLE"))
			{
				dgtk.OpenGL.internalGLES.glClientWaitSyncAPPLE = (dgtk.OpenGL.delegatesGLES.glClientWaitSyncAPPLE) InternalGLesTool.GetGLesMethodAdress("glClientWaitSyncAPPLE", typeof(dgtk.OpenGL.delegatesGLES.glClientWaitSyncAPPLE));
			}
			if (SuportedExt.Contains("glClipControlEXT"))
			{
				dgtk.OpenGL.internalGLES.glClipControlEXT = (dgtk.OpenGL.delegatesGLES.glClipControlEXT) InternalGLesTool.GetGLesMethodAdress("glClipControlEXT", typeof(dgtk.OpenGL.delegatesGLES.glClipControlEXT));
			}
			if (SuportedExt.Contains("glClipPlanefIMG"))
			{
				dgtk.OpenGL.internalGLES.glClipPlanefIMG = (dgtk.OpenGL.delegatesGLES.glClipPlanefIMG) InternalGLesTool.GetGLesMethodAdress("glClipPlanefIMG", typeof(dgtk.OpenGL.delegatesGLES.glClipPlanefIMG));
			}
			if (SuportedExt.Contains("glClipPlanefOES"))
			{
				dgtk.OpenGL.internalGLES.glClipPlanefOES = (dgtk.OpenGL.delegatesGLES.glClipPlanefOES) InternalGLesTool.GetGLesMethodAdress("glClipPlanefOES", typeof(dgtk.OpenGL.delegatesGLES.glClipPlanefOES));
			}
			if (SuportedExt.Contains("glClipPlanexIMG"))
			{
				dgtk.OpenGL.internalGLES.glClipPlanexIMG = (dgtk.OpenGL.delegatesGLES.glClipPlanexIMG) InternalGLesTool.GetGLesMethodAdress("glClipPlanexIMG", typeof(dgtk.OpenGL.delegatesGLES.glClipPlanexIMG));
			}
			if (SuportedExt.Contains("glClipPlanexOES"))
			{
				dgtk.OpenGL.internalGLES.glClipPlanexOES = (dgtk.OpenGL.delegatesGLES.glClipPlanexOES) InternalGLesTool.GetGLesMethodAdress("glClipPlanexOES", typeof(dgtk.OpenGL.delegatesGLES.glClipPlanexOES));
			}
			if (SuportedExt.Contains("glColor3xOES"))
			{
				dgtk.OpenGL.internalGLES.glColor3xOES = (dgtk.OpenGL.delegatesGLES.glColor3xOES) InternalGLesTool.GetGLesMethodAdress("glColor3xOES", typeof(dgtk.OpenGL.delegatesGLES.glColor3xOES));
			}
			if (SuportedExt.Contains("glColor3xvOES"))
			{
				dgtk.OpenGL.internalGLES.glColor3xvOES = (dgtk.OpenGL.delegatesGLES.glColor3xvOES) InternalGLesTool.GetGLesMethodAdress("glColor3xvOES", typeof(dgtk.OpenGL.delegatesGLES.glColor3xvOES));
			}
			if (SuportedExt.Contains("glColor4xOES"))
			{
				dgtk.OpenGL.internalGLES.glColor4xOES = (dgtk.OpenGL.delegatesGLES.glColor4xOES) InternalGLesTool.GetGLesMethodAdress("glColor4xOES", typeof(dgtk.OpenGL.delegatesGLES.glColor4xOES));
			}
			if (SuportedExt.Contains("glColor4xvOES"))
			{
				dgtk.OpenGL.internalGLES.glColor4xvOES = (dgtk.OpenGL.delegatesGLES.glColor4xvOES) InternalGLesTool.GetGLesMethodAdress("glColor4xvOES", typeof(dgtk.OpenGL.delegatesGLES.glColor4xvOES));
			}
			if (SuportedExt.Contains("glColorMaskiEXT"))
			{
				dgtk.OpenGL.internalGLES.glColorMaskiEXT = (dgtk.OpenGL.delegatesGLES.glColorMaskiEXT) InternalGLesTool.GetGLesMethodAdress("glColorMaskiEXT", typeof(dgtk.OpenGL.delegatesGLES.glColorMaskiEXT));
			}
			if (SuportedExt.Contains("glColorMaskiOES"))
			{
				dgtk.OpenGL.internalGLES.glColorMaskiOES = (dgtk.OpenGL.delegatesGLES.glColorMaskiOES) InternalGLesTool.GetGLesMethodAdress("glColorMaskiOES", typeof(dgtk.OpenGL.delegatesGLES.glColorMaskiOES));
			}
			if (SuportedExt.Contains("glCompressedTexImage3DOES"))
			{
				dgtk.OpenGL.internalGLES.glCompressedTexImage3DOES = (dgtk.OpenGL.delegatesGLES.glCompressedTexImage3DOES) InternalGLesTool.GetGLesMethodAdress("glCompressedTexImage3DOES", typeof(dgtk.OpenGL.delegatesGLES.glCompressedTexImage3DOES));
			}
			if (SuportedExt.Contains("glCompressedTexSubImage3DOES"))
			{
				dgtk.OpenGL.internalGLES.glCompressedTexSubImage3DOES = (dgtk.OpenGL.delegatesGLES.glCompressedTexSubImage3DOES) InternalGLesTool.GetGLesMethodAdress("glCompressedTexSubImage3DOES", typeof(dgtk.OpenGL.delegatesGLES.glCompressedTexSubImage3DOES));
			}
			if (SuportedExt.Contains("glConservativeRasterParameteriNV"))
			{
				dgtk.OpenGL.internalGLES.glConservativeRasterParameteriNV = (dgtk.OpenGL.delegatesGLES.glConservativeRasterParameteriNV) InternalGLesTool.GetGLesMethodAdress("glConservativeRasterParameteriNV", typeof(dgtk.OpenGL.delegatesGLES.glConservativeRasterParameteriNV));
			}
			if (SuportedExt.Contains("glConvolutionParameterxOES"))
			{
				dgtk.OpenGL.internalGLES.glConvolutionParameterxOES = (dgtk.OpenGL.delegatesGLES.glConvolutionParameterxOES) InternalGLesTool.GetGLesMethodAdress("glConvolutionParameterxOES", typeof(dgtk.OpenGL.delegatesGLES.glConvolutionParameterxOES));
			}
			if (SuportedExt.Contains("glConvolutionParameterxvOES"))
			{
				dgtk.OpenGL.internalGLES.glConvolutionParameterxvOES = (dgtk.OpenGL.delegatesGLES.glConvolutionParameterxvOES) InternalGLesTool.GetGLesMethodAdress("glConvolutionParameterxvOES", typeof(dgtk.OpenGL.delegatesGLES.glConvolutionParameterxvOES));
			}
			if (SuportedExt.Contains("glCopyBufferSubDataNV"))
			{
				dgtk.OpenGL.internalGLES.glCopyBufferSubDataNV = (dgtk.OpenGL.delegatesGLES.glCopyBufferSubDataNV) InternalGLesTool.GetGLesMethodAdress("glCopyBufferSubDataNV", typeof(dgtk.OpenGL.delegatesGLES.glCopyBufferSubDataNV));
			}
			if (SuportedExt.Contains("glCopyImageSubDataEXT"))
			{
				dgtk.OpenGL.internalGLES.glCopyImageSubDataEXT = (dgtk.OpenGL.delegatesGLES.glCopyImageSubDataEXT) InternalGLesTool.GetGLesMethodAdress("glCopyImageSubDataEXT", typeof(dgtk.OpenGL.delegatesGLES.glCopyImageSubDataEXT));
			}
			if (SuportedExt.Contains("glCopyImageSubDataOES"))
			{
				dgtk.OpenGL.internalGLES.glCopyImageSubDataOES = (dgtk.OpenGL.delegatesGLES.glCopyImageSubDataOES) InternalGLesTool.GetGLesMethodAdress("glCopyImageSubDataOES", typeof(dgtk.OpenGL.delegatesGLES.glCopyImageSubDataOES));
			}
			if (SuportedExt.Contains("glCopyPathNV"))
			{
				dgtk.OpenGL.internalGLES.glCopyPathNV = (dgtk.OpenGL.delegatesGLES.glCopyPathNV) InternalGLesTool.GetGLesMethodAdress("glCopyPathNV", typeof(dgtk.OpenGL.delegatesGLES.glCopyPathNV));
			}
			if (SuportedExt.Contains("glCopyTexSubImage3DOES"))
			{
				dgtk.OpenGL.internalGLES.glCopyTexSubImage3DOES = (dgtk.OpenGL.delegatesGLES.glCopyTexSubImage3DOES) InternalGLesTool.GetGLesMethodAdress("glCopyTexSubImage3DOES", typeof(dgtk.OpenGL.delegatesGLES.glCopyTexSubImage3DOES));
			}
			if (SuportedExt.Contains("glCopyTextureLevelsAPPLE"))
			{
				dgtk.OpenGL.internalGLES.glCopyTextureLevelsAPPLE = (dgtk.OpenGL.delegatesGLES.glCopyTextureLevelsAPPLE) InternalGLesTool.GetGLesMethodAdress("glCopyTextureLevelsAPPLE", typeof(dgtk.OpenGL.delegatesGLES.glCopyTextureLevelsAPPLE));
			}
			if (SuportedExt.Contains("glCoverageMaskNV"))
			{
				dgtk.OpenGL.internalGLES.glCoverageMaskNV = (dgtk.OpenGL.delegatesGLES.glCoverageMaskNV) InternalGLesTool.GetGLesMethodAdress("glCoverageMaskNV", typeof(dgtk.OpenGL.delegatesGLES.glCoverageMaskNV));
			}
			if (SuportedExt.Contains("glCoverageModulationNV"))
			{
				dgtk.OpenGL.internalGLES.glCoverageModulationNV = (dgtk.OpenGL.delegatesGLES.glCoverageModulationNV) InternalGLesTool.GetGLesMethodAdress("glCoverageModulationNV", typeof(dgtk.OpenGL.delegatesGLES.glCoverageModulationNV));
			}
			if (SuportedExt.Contains("glCoverageModulationTableNV"))
			{
				dgtk.OpenGL.internalGLES.glCoverageModulationTableNV = (dgtk.OpenGL.delegatesGLES.glCoverageModulationTableNV) InternalGLesTool.GetGLesMethodAdress("glCoverageModulationTableNV", typeof(dgtk.OpenGL.delegatesGLES.glCoverageModulationTableNV));
			}
			if (SuportedExt.Contains("glCoverageOperationNV"))
			{
				dgtk.OpenGL.internalGLES.glCoverageOperationNV = (dgtk.OpenGL.delegatesGLES.glCoverageOperationNV) InternalGLesTool.GetGLesMethodAdress("glCoverageOperationNV", typeof(dgtk.OpenGL.delegatesGLES.glCoverageOperationNV));
			}
			if (SuportedExt.Contains("glCoverFillPathInstancedNV"))
			{
				dgtk.OpenGL.internalGLES.glCoverFillPathInstancedNV = (dgtk.OpenGL.delegatesGLES.glCoverFillPathInstancedNV) InternalGLesTool.GetGLesMethodAdress("glCoverFillPathInstancedNV", typeof(dgtk.OpenGL.delegatesGLES.glCoverFillPathInstancedNV));
			}
			if (SuportedExt.Contains("glCoverFillPathNV"))
			{
				dgtk.OpenGL.internalGLES.glCoverFillPathNV = (dgtk.OpenGL.delegatesGLES.glCoverFillPathNV) InternalGLesTool.GetGLesMethodAdress("glCoverFillPathNV", typeof(dgtk.OpenGL.delegatesGLES.glCoverFillPathNV));
			}
			if (SuportedExt.Contains("glCoverStrokePathInstancedNV"))
			{
				dgtk.OpenGL.internalGLES.glCoverStrokePathInstancedNV = (dgtk.OpenGL.delegatesGLES.glCoverStrokePathInstancedNV) InternalGLesTool.GetGLesMethodAdress("glCoverStrokePathInstancedNV", typeof(dgtk.OpenGL.delegatesGLES.glCoverStrokePathInstancedNV));
			}
			if (SuportedExt.Contains("glCoverStrokePathNV"))
			{
				dgtk.OpenGL.internalGLES.glCoverStrokePathNV = (dgtk.OpenGL.delegatesGLES.glCoverStrokePathNV) InternalGLesTool.GetGLesMethodAdress("glCoverStrokePathNV", typeof(dgtk.OpenGL.delegatesGLES.glCoverStrokePathNV));
			}
			if (SuportedExt.Contains("glCreateMemoryObjectsEXT"))
			{
				dgtk.OpenGL.internalGLES.glCreateMemoryObjectsEXT = (dgtk.OpenGL.delegatesGLES.glCreateMemoryObjectsEXT) InternalGLesTool.GetGLesMethodAdress("glCreateMemoryObjectsEXT", typeof(dgtk.OpenGL.delegatesGLES.glCreateMemoryObjectsEXT));
			}
			if (SuportedExt.Contains("glCreatePerfQueryINTEL"))
			{
				dgtk.OpenGL.internalGLES.glCreatePerfQueryINTEL = (dgtk.OpenGL.delegatesGLES.glCreatePerfQueryINTEL) InternalGLesTool.GetGLesMethodAdress("glCreatePerfQueryINTEL", typeof(dgtk.OpenGL.delegatesGLES.glCreatePerfQueryINTEL));
			}
			if (SuportedExt.Contains("glCreateSemaphoresNV"))
			{
				dgtk.OpenGL.internalGLES.glCreateSemaphoresNV = (dgtk.OpenGL.delegatesGLES.glCreateSemaphoresNV) InternalGLesTool.GetGLesMethodAdress("glCreateSemaphoresNV", typeof(dgtk.OpenGL.delegatesGLES.glCreateSemaphoresNV));
			}
			if (SuportedExt.Contains("glCreateShaderProgramEXT"))
			{
				dgtk.OpenGL.internalGLES.glCreateShaderProgramEXT = (dgtk.OpenGL.delegatesGLES.glCreateShaderProgramEXT) InternalGLesTool.GetGLesMethodAdress("glCreateShaderProgramEXT", typeof(dgtk.OpenGL.delegatesGLES.glCreateShaderProgramEXT));
			}
			if (SuportedExt.Contains("glCreateShaderProgramvEXT"))
			{
				dgtk.OpenGL.internalGLES.glCreateShaderProgramvEXT = (dgtk.OpenGL.delegatesGLES.glCreateShaderProgramvEXT) InternalGLesTool.GetGLesMethodAdress("glCreateShaderProgramvEXT", typeof(dgtk.OpenGL.delegatesGLES.glCreateShaderProgramvEXT));
			}
			if (SuportedExt.Contains("glCurrentPaletteMatrixOES"))
			{
				dgtk.OpenGL.internalGLES.glCurrentPaletteMatrixOES = (dgtk.OpenGL.delegatesGLES.glCurrentPaletteMatrixOES) InternalGLesTool.GetGLesMethodAdress("glCurrentPaletteMatrixOES", typeof(dgtk.OpenGL.delegatesGLES.glCurrentPaletteMatrixOES));
			}
			#endregion

			#region D:

			if (SuportedExt.Contains("glDebugMessageCallbackKHR"))
			{
				dgtk.OpenGL.internalGLES.glDebugMessageCallbackKHR = (dgtk.OpenGL.delegatesGLES.glDebugMessageCallbackKHR) InternalGLesTool.GetGLesMethodAdress("glDebugMessageCallbackKHR", typeof(dgtk.OpenGL.delegatesGLES.glDebugMessageCallbackKHR));
			}
			if (SuportedExt.Contains("glDebugMessageControlKHR"))
			{
				dgtk.OpenGL.internalGLES.glDebugMessageControlKHR = (dgtk.OpenGL.delegatesGLES.glDebugMessageControlKHR) InternalGLesTool.GetGLesMethodAdress("glDebugMessageControlKHR", typeof(dgtk.OpenGL.delegatesGLES.glDebugMessageControlKHR));
			}
			if (SuportedExt.Contains("glDebugMessageInsertKHR"))
			{
				dgtk.OpenGL.internalGLES.glDebugMessageInsertKHR = (dgtk.OpenGL.delegatesGLES.glDebugMessageInsertKHR) InternalGLesTool.GetGLesMethodAdress("glDebugMessageInsertKHR", typeof(dgtk.OpenGL.delegatesGLES.glDebugMessageInsertKHR));
			}
			if (SuportedExt.Contains("glDeleteFencesNV"))
			{
				dgtk.OpenGL.internalGLES.glDeleteFencesNV = (dgtk.OpenGL.delegatesGLES.glDeleteFencesNV) InternalGLesTool.GetGLesMethodAdress("glDeleteFencesNV", typeof(dgtk.OpenGL.delegatesGLES.glDeleteFencesNV));
			}
			if (SuportedExt.Contains("glDeleteFramebuffersOES"))
			{
				dgtk.OpenGL.internalGLES.glDeleteFramebuffersOES = (dgtk.OpenGL.delegatesGLES.glDeleteFramebuffersOES) InternalGLesTool.GetGLesMethodAdress("glDeleteFramebuffersOES", typeof(dgtk.OpenGL.delegatesGLES.glDeleteFramebuffersOES));
			}
			if (SuportedExt.Contains("glDeleteMemoryObjectsEXT"))
			{
				dgtk.OpenGL.internalGLES.glDeleteMemoryObjectsEXT = (dgtk.OpenGL.delegatesGLES.glDeleteMemoryObjectsEXT) InternalGLesTool.GetGLesMethodAdress("glDeleteMemoryObjectsEXT", typeof(dgtk.OpenGL.delegatesGLES.glDeleteMemoryObjectsEXT));
			}
			if (SuportedExt.Contains("glDeletePathsNV"))
			{
				dgtk.OpenGL.internalGLES.glDeletePathsNV = (dgtk.OpenGL.delegatesGLES.glDeletePathsNV) InternalGLesTool.GetGLesMethodAdress("glDeletePathsNV", typeof(dgtk.OpenGL.delegatesGLES.glDeletePathsNV));
			}
			if (SuportedExt.Contains("glDeletePerfMonitorsAMD"))
			{
				dgtk.OpenGL.internalGLES.glDeletePerfMonitorsAMD = (dgtk.OpenGL.delegatesGLES.glDeletePerfMonitorsAMD) InternalGLesTool.GetGLesMethodAdress("glDeletePerfMonitorsAMD", typeof(dgtk.OpenGL.delegatesGLES.glDeletePerfMonitorsAMD));
			}
			if (SuportedExt.Contains("glDeletePerfQueryINTEL"))
			{
				dgtk.OpenGL.internalGLES.glDeletePerfQueryINTEL = (dgtk.OpenGL.delegatesGLES.glDeletePerfQueryINTEL) InternalGLesTool.GetGLesMethodAdress("glDeletePerfQueryINTEL", typeof(dgtk.OpenGL.delegatesGLES.glDeletePerfQueryINTEL));
			}
			if (SuportedExt.Contains("glDeleteProgramPipelinesEXT"))
			{
				dgtk.OpenGL.internalGLES.glDeleteProgramPipelinesEXT = (dgtk.OpenGL.delegatesGLES.glDeleteProgramPipelinesEXT) InternalGLesTool.GetGLesMethodAdress("glDeleteProgramPipelinesEXT", typeof(dgtk.OpenGL.delegatesGLES.glDeleteProgramPipelinesEXT));
			}
			if (SuportedExt.Contains("glDeleteQueriesEXT"))
			{
				dgtk.OpenGL.internalGLES.glDeleteQueriesEXT = (dgtk.OpenGL.delegatesGLES.glDeleteQueriesEXT) InternalGLesTool.GetGLesMethodAdress("glDeleteQueriesEXT", typeof(dgtk.OpenGL.delegatesGLES.glDeleteQueriesEXT));
			}
			if (SuportedExt.Contains("glDeleteRenderbuffersOES"))
			{
				dgtk.OpenGL.internalGLES.glDeleteRenderbuffersOES = (dgtk.OpenGL.delegatesGLES.glDeleteRenderbuffersOES) InternalGLesTool.GetGLesMethodAdress("glDeleteRenderbuffersOES", typeof(dgtk.OpenGL.delegatesGLES.glDeleteRenderbuffersOES));
			}
			if (SuportedExt.Contains("glDeleteSemaphoresEXT"))
			{
				dgtk.OpenGL.internalGLES.glDeleteSemaphoresEXT = (dgtk.OpenGL.delegatesGLES.glDeleteSemaphoresEXT) InternalGLesTool.GetGLesMethodAdress("glDeleteSemaphoresEXT", typeof(dgtk.OpenGL.delegatesGLES.glDeleteSemaphoresEXT));
			}
			if (SuportedExt.Contains("glDeleteSyncAPPLE"))
			{
				dgtk.OpenGL.internalGLES.glDeleteSyncAPPLE = (dgtk.OpenGL.delegatesGLES.glDeleteSyncAPPLE) InternalGLesTool.GetGLesMethodAdress("glDeleteSyncAPPLE", typeof(dgtk.OpenGL.delegatesGLES.glDeleteSyncAPPLE));
			}
			if (SuportedExt.Contains("glDeleteVertexArraysOES"))
			{
				dgtk.OpenGL.internalGLES.glDeleteVertexArraysOES = (dgtk.OpenGL.delegatesGLES.glDeleteVertexArraysOES) InternalGLesTool.GetGLesMethodAdress("glDeleteVertexArraysOES", typeof(dgtk.OpenGL.delegatesGLES.glDeleteVertexArraysOES));
			}
			if (SuportedExt.Contains("glDepthRangeArrayfvNV"))
			{
				dgtk.OpenGL.internalGLES.glDepthRangeArrayfvNV = (dgtk.OpenGL.delegatesGLES.glDepthRangeArrayfvNV) InternalGLesTool.GetGLesMethodAdress("glDepthRangeArrayfvNV", typeof(dgtk.OpenGL.delegatesGLES.glDepthRangeArrayfvNV));
			}
			if (SuportedExt.Contains("glDepthRangeArrayfvOES"))
			{
				dgtk.OpenGL.internalGLES.glDepthRangeArrayfvOES = (dgtk.OpenGL.delegatesGLES.glDepthRangeArrayfvOES) InternalGLesTool.GetGLesMethodAdress("glDepthRangeArrayfvOES", typeof(dgtk.OpenGL.delegatesGLES.glDepthRangeArrayfvOES));
			}
			if (SuportedExt.Contains("glDepthRangefOES"))
			{
				dgtk.OpenGL.internalGLES.glDepthRangefOES = (dgtk.OpenGL.delegatesGLES.glDepthRangefOES) InternalGLesTool.GetGLesMethodAdress("glDepthRangefOES", typeof(dgtk.OpenGL.delegatesGLES.glDepthRangefOES));
			}
			if (SuportedExt.Contains("glDepthRangeIndexedfNV"))
			{
				dgtk.OpenGL.internalGLES.glDepthRangeIndexedfNV = (dgtk.OpenGL.delegatesGLES.glDepthRangeIndexedfNV) InternalGLesTool.GetGLesMethodAdress("glDepthRangeIndexedfNV", typeof(dgtk.OpenGL.delegatesGLES.glDepthRangeIndexedfNV));
			}
			if (SuportedExt.Contains("glDepthRangeIndexedfOES"))
			{
				dgtk.OpenGL.internalGLES.glDepthRangeIndexedfOES = (dgtk.OpenGL.delegatesGLES.glDepthRangeIndexedfOES) InternalGLesTool.GetGLesMethodAdress("glDepthRangeIndexedfOES", typeof(dgtk.OpenGL.delegatesGLES.glDepthRangeIndexedfOES));
			}
			if (SuportedExt.Contains("glDepthRangexOES"))
			{
				dgtk.OpenGL.internalGLES.glDepthRangexOES = (dgtk.OpenGL.delegatesGLES.glDepthRangexOES) InternalGLesTool.GetGLesMethodAdress("glDepthRangexOES", typeof(dgtk.OpenGL.delegatesGLES.glDepthRangexOES));
			}
			if (SuportedExt.Contains("glDisableDriverControlQCOM"))
			{
				dgtk.OpenGL.internalGLES.glDisableDriverControlQCOM = (dgtk.OpenGL.delegatesGLES.glDisableDriverControlQCOM) InternalGLesTool.GetGLesMethodAdress("glDisableDriverControlQCOM", typeof(dgtk.OpenGL.delegatesGLES.glDisableDriverControlQCOM));
			}
			if (SuportedExt.Contains("glDisableiEXT"))
			{
				dgtk.OpenGL.internalGLES.glDisableiEXT = (dgtk.OpenGL.delegatesGLES.glDisableiEXT) InternalGLesTool.GetGLesMethodAdress("glDisableiEXT", typeof(dgtk.OpenGL.delegatesGLES.glDisableiEXT));
			}
			if (SuportedExt.Contains("glDisableiNV"))
			{
				dgtk.OpenGL.internalGLES.glDisableiNV = (dgtk.OpenGL.delegatesGLES.glDisableiNV) InternalGLesTool.GetGLesMethodAdress("glDisableiNV", typeof(dgtk.OpenGL.delegatesGLES.glDisableiNV));
			}
			if (SuportedExt.Contains("glDisableiOES"))
			{
				dgtk.OpenGL.internalGLES.glDisableiOES = (dgtk.OpenGL.delegatesGLES.glDisableiOES) InternalGLesTool.GetGLesMethodAdress("glDisableiOES", typeof(dgtk.OpenGL.delegatesGLES.glDisableiOES));
			}
			if (SuportedExt.Contains("glDiscardFramebufferEXT"))
			{
				dgtk.OpenGL.internalGLES.glDiscardFramebufferEXT = (dgtk.OpenGL.delegatesGLES.glDiscardFramebufferEXT) InternalGLesTool.GetGLesMethodAdress("glDiscardFramebufferEXT", typeof(dgtk.OpenGL.delegatesGLES.glDiscardFramebufferEXT));
			}
			if (SuportedExt.Contains("glDrawArraysInstancedANGLE"))
			{
				dgtk.OpenGL.internalGLES.glDrawArraysInstancedANGLE = (dgtk.OpenGL.delegatesGLES.glDrawArraysInstancedANGLE) InternalGLesTool.GetGLesMethodAdress("glDrawArraysInstancedANGLE", typeof(dgtk.OpenGL.delegatesGLES.glDrawArraysInstancedANGLE));
			}
			if (SuportedExt.Contains("glDrawArraysInstancedBaseInstanceEXT"))
			{
				dgtk.OpenGL.internalGLES.glDrawArraysInstancedBaseInstanceEXT = (dgtk.OpenGL.delegatesGLES.glDrawArraysInstancedBaseInstanceEXT) InternalGLesTool.GetGLesMethodAdress("glDrawArraysInstancedBaseInstanceEXT", typeof(dgtk.OpenGL.delegatesGLES.glDrawArraysInstancedBaseInstanceEXT));
			}
			if (SuportedExt.Contains("glDrawArraysInstancedEXT"))
			{
				dgtk.OpenGL.internalGLES.glDrawArraysInstancedEXT = (dgtk.OpenGL.delegatesGLES.glDrawArraysInstancedEXT) InternalGLesTool.GetGLesMethodAdress("glDrawArraysInstancedEXT", typeof(dgtk.OpenGL.delegatesGLES.glDrawArraysInstancedEXT));
			}
			if (SuportedExt.Contains("glDrawArraysInstancedNV"))
			{
				dgtk.OpenGL.internalGLES.glDrawArraysInstancedNV = (dgtk.OpenGL.delegatesGLES.glDrawArraysInstancedNV) InternalGLesTool.GetGLesMethodAdress("glDrawArraysInstancedNV", typeof(dgtk.OpenGL.delegatesGLES.glDrawArraysInstancedNV));
			}
			if (SuportedExt.Contains("glDrawBuffersEXT"))
			{
				dgtk.OpenGL.internalGLES.glDrawBuffersEXT = (dgtk.OpenGL.delegatesGLES.glDrawBuffersEXT) InternalGLesTool.GetGLesMethodAdress("glDrawBuffersEXT", typeof(dgtk.OpenGL.delegatesGLES.glDrawBuffersEXT));
			}
			if (SuportedExt.Contains("glDrawBuffersIndexedEXT"))
			{
				dgtk.OpenGL.internalGLES.glDrawBuffersIndexedEXT = (dgtk.OpenGL.delegatesGLES.glDrawBuffersIndexedEXT) InternalGLesTool.GetGLesMethodAdress("glDrawBuffersIndexedEXT", typeof(dgtk.OpenGL.delegatesGLES.glDrawBuffersIndexedEXT));
			}
			if (SuportedExt.Contains("glDrawBuffersNV"))
			{
				dgtk.OpenGL.internalGLES.glDrawBuffersNV = (dgtk.OpenGL.delegatesGLES.glDrawBuffersNV) InternalGLesTool.GetGLesMethodAdress("glDrawBuffersNV", typeof(dgtk.OpenGL.delegatesGLES.glDrawBuffersNV));
			}
			if (SuportedExt.Contains("glDrawElementsBaseVertexEXT"))
			{
				dgtk.OpenGL.internalGLES.glDrawElementsBaseVertexEXT = (dgtk.OpenGL.delegatesGLES.glDrawElementsBaseVertexEXT) InternalGLesTool.GetGLesMethodAdress("glDrawElementsBaseVertexEXT", typeof(dgtk.OpenGL.delegatesGLES.glDrawElementsBaseVertexEXT));
			}
			if (SuportedExt.Contains("glDrawElementsBaseVertexOES"))
			{
				dgtk.OpenGL.internalGLES.glDrawElementsBaseVertexOES = (dgtk.OpenGL.delegatesGLES.glDrawElementsBaseVertexOES) InternalGLesTool.GetGLesMethodAdress("glDrawElementsBaseVertexOES", typeof(dgtk.OpenGL.delegatesGLES.glDrawElementsBaseVertexOES));
			}
			if (SuportedExt.Contains("glDrawElementsInstancedANGLE"))
			{
				dgtk.OpenGL.internalGLES.glDrawElementsInstancedANGLE = (dgtk.OpenGL.delegatesGLES.glDrawElementsInstancedANGLE) InternalGLesTool.GetGLesMethodAdress("glDrawElementsInstancedANGLE", typeof(dgtk.OpenGL.delegatesGLES.glDrawElementsInstancedANGLE));
			}
			if (SuportedExt.Contains("glDrawElementsInstancedBaseInstanceEXT"))
			{
				dgtk.OpenGL.internalGLES.glDrawElementsInstancedBaseInstanceEXT = (dgtk.OpenGL.delegatesGLES.glDrawElementsInstancedBaseInstanceEXT) InternalGLesTool.GetGLesMethodAdress("glDrawElementsInstancedBaseInstanceEXT", typeof(dgtk.OpenGL.delegatesGLES.glDrawElementsInstancedBaseInstanceEXT));
			}
			if (SuportedExt.Contains("glDrawElementsInstancedBaseVertexBaseInstanceEXT"))
			{
				dgtk.OpenGL.internalGLES.glDrawElementsInstancedBaseVertexBaseInstanceEXT = (dgtk.OpenGL.delegatesGLES.glDrawElementsInstancedBaseVertexBaseInstanceEXT) InternalGLesTool.GetGLesMethodAdress("glDrawElementsInstancedBaseVertexBaseInstanceEXT", typeof(dgtk.OpenGL.delegatesGLES.glDrawElementsInstancedBaseVertexBaseInstanceEXT));
			}
			if (SuportedExt.Contains("glDrawElementsInstancedBaseVertexEXT"))
			{
				dgtk.OpenGL.internalGLES.glDrawElementsInstancedBaseVertexEXT = (dgtk.OpenGL.delegatesGLES.glDrawElementsInstancedBaseVertexEXT) InternalGLesTool.GetGLesMethodAdress("glDrawElementsInstancedBaseVertexEXT", typeof(dgtk.OpenGL.delegatesGLES.glDrawElementsInstancedBaseVertexEXT));
			}
			if (SuportedExt.Contains("glDrawElementsInstancedBaseVertexOES"))
			{
				dgtk.OpenGL.internalGLES.glDrawElementsInstancedBaseVertexOES = (dgtk.OpenGL.delegatesGLES.glDrawElementsInstancedBaseVertexOES) InternalGLesTool.GetGLesMethodAdress("glDrawElementsInstancedBaseVertexOES", typeof(dgtk.OpenGL.delegatesGLES.glDrawElementsInstancedBaseVertexOES));
			}
			if (SuportedExt.Contains("glDrawElementsInstancedEXT"))
			{
				dgtk.OpenGL.internalGLES.glDrawElementsInstancedEXT = (dgtk.OpenGL.delegatesGLES.glDrawElementsInstancedEXT) InternalGLesTool.GetGLesMethodAdress("glDrawElementsInstancedEXT", typeof(dgtk.OpenGL.delegatesGLES.glDrawElementsInstancedEXT));
			}
			if (SuportedExt.Contains("glDrawElementsInstancedNV"))
			{
				dgtk.OpenGL.internalGLES.glDrawElementsInstancedNV = (dgtk.OpenGL.delegatesGLES.glDrawElementsInstancedNV) InternalGLesTool.GetGLesMethodAdress("glDrawElementsInstancedNV", typeof(dgtk.OpenGL.delegatesGLES.glDrawElementsInstancedNV));
			}
			if (SuportedExt.Contains("glDrawMeshTasksIndirectNV"))
			{
				dgtk.OpenGL.internalGLES.glDrawMeshTasksIndirectNV = (dgtk.OpenGL.delegatesGLES.glDrawMeshTasksIndirectNV) InternalGLesTool.GetGLesMethodAdress("glDrawMeshTasksIndirectNV", typeof(dgtk.OpenGL.delegatesGLES.glDrawMeshTasksIndirectNV));
			}
			if (SuportedExt.Contains("glDrawMeshTasksNV"))
			{
				dgtk.OpenGL.internalGLES.glDrawMeshTasksNV = (dgtk.OpenGL.delegatesGLES.glDrawMeshTasksNV) InternalGLesTool.GetGLesMethodAdress("glDrawMeshTasksNV", typeof(dgtk.OpenGL.delegatesGLES.glDrawMeshTasksNV));
			}
			if (SuportedExt.Contains("glDrawRangeElementsBaseVertexEXT"))
			{
				dgtk.OpenGL.internalGLES.glDrawRangeElementsBaseVertexEXT = (dgtk.OpenGL.delegatesGLES.glDrawRangeElementsBaseVertexEXT) InternalGLesTool.GetGLesMethodAdress("glDrawRangeElementsBaseVertexEXT", typeof(dgtk.OpenGL.delegatesGLES.glDrawRangeElementsBaseVertexEXT));
			}
			if (SuportedExt.Contains("glDrawRangeElementsBaseVertexOES"))
			{
				dgtk.OpenGL.internalGLES.glDrawRangeElementsBaseVertexOES = (dgtk.OpenGL.delegatesGLES.glDrawRangeElementsBaseVertexOES) InternalGLesTool.GetGLesMethodAdress("glDrawRangeElementsBaseVertexOES", typeof(dgtk.OpenGL.delegatesGLES.glDrawRangeElementsBaseVertexOES));
			}
			if (SuportedExt.Contains("glDrawTexfOES"))
			{
				dgtk.OpenGL.internalGLES.glDrawTexfOES = (dgtk.OpenGL.delegatesGLES.glDrawTexfOES) InternalGLesTool.GetGLesMethodAdress("glDrawTexfOES", typeof(dgtk.OpenGL.delegatesGLES.glDrawTexfOES));
			}
			if (SuportedExt.Contains("glDrawTexfvOES"))
			{
				dgtk.OpenGL.internalGLES.glDrawTexfvOES = (dgtk.OpenGL.delegatesGLES.glDrawTexfvOES) InternalGLesTool.GetGLesMethodAdress("glDrawTexfvOES", typeof(dgtk.OpenGL.delegatesGLES.glDrawTexfvOES));
			}
			if (SuportedExt.Contains("glDrawTexiOES"))
			{
				dgtk.OpenGL.internalGLES.glDrawTexiOES = (dgtk.OpenGL.delegatesGLES.glDrawTexiOES) InternalGLesTool.GetGLesMethodAdress("glDrawTexiOES", typeof(dgtk.OpenGL.delegatesGLES.glDrawTexiOES));
			}
			if (SuportedExt.Contains("glDrawTexivOES"))
			{
				dgtk.OpenGL.internalGLES.glDrawTexivOES = (dgtk.OpenGL.delegatesGLES.glDrawTexivOES) InternalGLesTool.GetGLesMethodAdress("glDrawTexivOES", typeof(dgtk.OpenGL.delegatesGLES.glDrawTexivOES));
			}
			if (SuportedExt.Contains("glDrawTexsOES"))
			{
				dgtk.OpenGL.internalGLES.glDrawTexsOES = (dgtk.OpenGL.delegatesGLES.glDrawTexsOES) InternalGLesTool.GetGLesMethodAdress("glDrawTexsOES", typeof(dgtk.OpenGL.delegatesGLES.glDrawTexsOES));
			}
			if (SuportedExt.Contains("glDrawTexsvOES"))
			{
				dgtk.OpenGL.internalGLES.glDrawTexsvOES = (dgtk.OpenGL.delegatesGLES.glDrawTexsvOES) InternalGLesTool.GetGLesMethodAdress("glDrawTexsvOES", typeof(dgtk.OpenGL.delegatesGLES.glDrawTexsvOES));
			}
			if (SuportedExt.Contains("glDrawTexxOES"))
			{
				dgtk.OpenGL.internalGLES.glDrawTexxOES = (dgtk.OpenGL.delegatesGLES.glDrawTexxOES) InternalGLesTool.GetGLesMethodAdress("glDrawTexxOES", typeof(dgtk.OpenGL.delegatesGLES.glDrawTexxOES));
			}
			if (SuportedExt.Contains("glDrawTexxvOES"))
			{
				dgtk.OpenGL.internalGLES.glDrawTexxvOES = (dgtk.OpenGL.delegatesGLES.glDrawTexxvOES) InternalGLesTool.GetGLesMethodAdress("glDrawTexxvOES", typeof(dgtk.OpenGL.delegatesGLES.glDrawTexxvOES));
			}
			if (SuportedExt.Contains("glDrawTransformFeedbackEXT"))
			{
				dgtk.OpenGL.internalGLES.glDrawTransformFeedbackEXT = (dgtk.OpenGL.delegatesGLES.glDrawTransformFeedbackEXT) InternalGLesTool.GetGLesMethodAdress("glDrawTransformFeedbackEXT", typeof(dgtk.OpenGL.delegatesGLES.glDrawTransformFeedbackEXT));
			}
			if (SuportedExt.Contains("glDrawTransformFeedbackInstancedEXT"))
			{
				dgtk.OpenGL.internalGLES.glDrawTransformFeedbackInstancedEXT = (dgtk.OpenGL.delegatesGLES.glDrawTransformFeedbackInstancedEXT) InternalGLesTool.GetGLesMethodAdress("glDrawTransformFeedbackInstancedEXT", typeof(dgtk.OpenGL.delegatesGLES.glDrawTransformFeedbackInstancedEXT));
			}
			if (SuportedExt.Contains("glDrawVkImageNV"))
			{
				dgtk.OpenGL.internalGLES.glDrawVkImageNV = (dgtk.OpenGL.delegatesGLES.glDrawVkImageNV) InternalGLesTool.GetGLesMethodAdress("glDrawVkImageNV", typeof(dgtk.OpenGL.delegatesGLES.glDrawVkImageNV));
			}
			#endregion

			#region E:

			if (SuportedExt.Contains("glEGLImageTargetRenderbufferStorageOES"))
			{
				dgtk.OpenGL.internalGLES.glEGLImageTargetRenderbufferStorageOES = (dgtk.OpenGL.delegatesGLES.glEGLImageTargetRenderbufferStorageOES) InternalGLesTool.GetGLesMethodAdress("glEGLImageTargetRenderbufferStorageOES", typeof(dgtk.OpenGL.delegatesGLES.glEGLImageTargetRenderbufferStorageOES));
			}
			if (SuportedExt.Contains("glEGLImageTargetTexStorageEXT"))
			{
				dgtk.OpenGL.internalGLES.glEGLImageTargetTexStorageEXT = (dgtk.OpenGL.delegatesGLES.glEGLImageTargetTexStorageEXT) InternalGLesTool.GetGLesMethodAdress("glEGLImageTargetTexStorageEXT", typeof(dgtk.OpenGL.delegatesGLES.glEGLImageTargetTexStorageEXT));
			}
			if (SuportedExt.Contains("glEGLImageTargetTexture2DOES"))
			{
				dgtk.OpenGL.internalGLES.glEGLImageTargetTexture2DOES = (dgtk.OpenGL.delegatesGLES.glEGLImageTargetTexture2DOES) InternalGLesTool.GetGLesMethodAdress("glEGLImageTargetTexture2DOES", typeof(dgtk.OpenGL.delegatesGLES.glEGLImageTargetTexture2DOES));
			}
			if (SuportedExt.Contains("glEGLImageTargetTextureStorageEXT"))
			{
				dgtk.OpenGL.internalGLES.glEGLImageTargetTextureStorageEXT = (dgtk.OpenGL.delegatesGLES.glEGLImageTargetTextureStorageEXT) InternalGLesTool.GetGLesMethodAdress("glEGLImageTargetTextureStorageEXT", typeof(dgtk.OpenGL.delegatesGLES.glEGLImageTargetTextureStorageEXT));
			}
			if (SuportedExt.Contains("glEnableDriverControlQCOM"))
			{
				dgtk.OpenGL.internalGLES.glEnableDriverControlQCOM = (dgtk.OpenGL.delegatesGLES.glEnableDriverControlQCOM) InternalGLesTool.GetGLesMethodAdress("glEnableDriverControlQCOM", typeof(dgtk.OpenGL.delegatesGLES.glEnableDriverControlQCOM));
			}
			if (SuportedExt.Contains("glEnableiEXT"))
			{
				dgtk.OpenGL.internalGLES.glEnableiEXT = (dgtk.OpenGL.delegatesGLES.glEnableiEXT) InternalGLesTool.GetGLesMethodAdress("glEnableiEXT", typeof(dgtk.OpenGL.delegatesGLES.glEnableiEXT));
			}
			if (SuportedExt.Contains("glEnableiNV"))
			{
				dgtk.OpenGL.internalGLES.glEnableiNV = (dgtk.OpenGL.delegatesGLES.glEnableiNV) InternalGLesTool.GetGLesMethodAdress("glEnableiNV", typeof(dgtk.OpenGL.delegatesGLES.glEnableiNV));
			}
			if (SuportedExt.Contains("glEnableiOES"))
			{
				dgtk.OpenGL.internalGLES.glEnableiOES = (dgtk.OpenGL.delegatesGLES.glEnableiOES) InternalGLesTool.GetGLesMethodAdress("glEnableiOES", typeof(dgtk.OpenGL.delegatesGLES.glEnableiOES));
			}
			if (SuportedExt.Contains("glEndConditionalRenderNV"))
			{
				dgtk.OpenGL.internalGLES.glEndConditionalRenderNV = (dgtk.OpenGL.delegatesGLES.glEndConditionalRenderNV) InternalGLesTool.GetGLesMethodAdress("glEndConditionalRenderNV", typeof(dgtk.OpenGL.delegatesGLES.glEndConditionalRenderNV));
			}
			if (SuportedExt.Contains("glEndPerfMonitorAMD"))
			{
				dgtk.OpenGL.internalGLES.glEndPerfMonitorAMD = (dgtk.OpenGL.delegatesGLES.glEndPerfMonitorAMD) InternalGLesTool.GetGLesMethodAdress("glEndPerfMonitorAMD", typeof(dgtk.OpenGL.delegatesGLES.glEndPerfMonitorAMD));
			}
			if (SuportedExt.Contains("glEndPerfQueryINTEL"))
			{
				dgtk.OpenGL.internalGLES.glEndPerfQueryINTEL = (dgtk.OpenGL.delegatesGLES.glEndPerfQueryINTEL) InternalGLesTool.GetGLesMethodAdress("glEndPerfQueryINTEL", typeof(dgtk.OpenGL.delegatesGLES.glEndPerfQueryINTEL));
			}
			if (SuportedExt.Contains("glEndQueryEXT"))
			{
				dgtk.OpenGL.internalGLES.glEndQueryEXT = (dgtk.OpenGL.delegatesGLES.glEndQueryEXT) InternalGLesTool.GetGLesMethodAdress("glEndQueryEXT", typeof(dgtk.OpenGL.delegatesGLES.glEndQueryEXT));
			}
			if (SuportedExt.Contains("glEndTilingQCOM"))
			{
				dgtk.OpenGL.internalGLES.glEndTilingQCOM = (dgtk.OpenGL.delegatesGLES.glEndTilingQCOM) InternalGLesTool.GetGLesMethodAdress("glEndTilingQCOM", typeof(dgtk.OpenGL.delegatesGLES.glEndTilingQCOM));
			}
			if (SuportedExt.Contains("glEvalCoord1xOES"))
			{
				dgtk.OpenGL.internalGLES.glEvalCoord1xOES = (dgtk.OpenGL.delegatesGLES.glEvalCoord1xOES) InternalGLesTool.GetGLesMethodAdress("glEvalCoord1xOES", typeof(dgtk.OpenGL.delegatesGLES.glEvalCoord1xOES));
			}
			if (SuportedExt.Contains("glEvalCoord1xvOES"))
			{
				dgtk.OpenGL.internalGLES.glEvalCoord1xvOES = (dgtk.OpenGL.delegatesGLES.glEvalCoord1xvOES) InternalGLesTool.GetGLesMethodAdress("glEvalCoord1xvOES", typeof(dgtk.OpenGL.delegatesGLES.glEvalCoord1xvOES));
			}
			if (SuportedExt.Contains("glEvalCoord2xOES"))
			{
				dgtk.OpenGL.internalGLES.glEvalCoord2xOES = (dgtk.OpenGL.delegatesGLES.glEvalCoord2xOES) InternalGLesTool.GetGLesMethodAdress("glEvalCoord2xOES", typeof(dgtk.OpenGL.delegatesGLES.glEvalCoord2xOES));
			}
			if (SuportedExt.Contains("glEvalCoord2xvOES"))
			{
				dgtk.OpenGL.internalGLES.glEvalCoord2xvOES = (dgtk.OpenGL.delegatesGLES.glEvalCoord2xvOES) InternalGLesTool.GetGLesMethodAdress("glEvalCoord2xvOES", typeof(dgtk.OpenGL.delegatesGLES.glEvalCoord2xvOES));
			}
			if (SuportedExt.Contains("glExtGetBufferPointervQCOM"))
			{
				dgtk.OpenGL.internalGLES.glExtGetBufferPointervQCOM = (dgtk.OpenGL.delegatesGLES.glExtGetBufferPointervQCOM) InternalGLesTool.GetGLesMethodAdress("glExtGetBufferPointervQCOM", typeof(dgtk.OpenGL.delegatesGLES.glExtGetBufferPointervQCOM));
			}
			if (SuportedExt.Contains("glExtGetBuffersQCOM"))
			{
				dgtk.OpenGL.internalGLES.glExtGetBuffersQCOM = (dgtk.OpenGL.delegatesGLES.glExtGetBuffersQCOM) InternalGLesTool.GetGLesMethodAdress("glExtGetBuffersQCOM", typeof(dgtk.OpenGL.delegatesGLES.glExtGetBuffersQCOM));
			}
			if (SuportedExt.Contains("glExtGetFramebuffersQCOM"))
			{
				dgtk.OpenGL.internalGLES.glExtGetFramebuffersQCOM = (dgtk.OpenGL.delegatesGLES.glExtGetFramebuffersQCOM) InternalGLesTool.GetGLesMethodAdress("glExtGetFramebuffersQCOM", typeof(dgtk.OpenGL.delegatesGLES.glExtGetFramebuffersQCOM));
			}
			if (SuportedExt.Contains("glExtGetProgramBinarySourceQCOM"))
			{
				dgtk.OpenGL.internalGLES.glExtGetProgramBinarySourceQCOM = (dgtk.OpenGL.delegatesGLES.glExtGetProgramBinarySourceQCOM) InternalGLesTool.GetGLesMethodAdress("glExtGetProgramBinarySourceQCOM", typeof(dgtk.OpenGL.delegatesGLES.glExtGetProgramBinarySourceQCOM));
			}
			if (SuportedExt.Contains("glExtGetProgramsQCOM"))
			{
				dgtk.OpenGL.internalGLES.glExtGetProgramsQCOM = (dgtk.OpenGL.delegatesGLES.glExtGetProgramsQCOM) InternalGLesTool.GetGLesMethodAdress("glExtGetProgramsQCOM", typeof(dgtk.OpenGL.delegatesGLES.glExtGetProgramsQCOM));
			}
			if (SuportedExt.Contains("glExtGetRenderbuffersQCOM"))
			{
				dgtk.OpenGL.internalGLES.glExtGetRenderbuffersQCOM = (dgtk.OpenGL.delegatesGLES.glExtGetRenderbuffersQCOM) InternalGLesTool.GetGLesMethodAdress("glExtGetRenderbuffersQCOM", typeof(dgtk.OpenGL.delegatesGLES.glExtGetRenderbuffersQCOM));
			}
			if (SuportedExt.Contains("glExtGetShadersQCOM"))
			{
				dgtk.OpenGL.internalGLES.glExtGetShadersQCOM = (dgtk.OpenGL.delegatesGLES.glExtGetShadersQCOM) InternalGLesTool.GetGLesMethodAdress("glExtGetShadersQCOM", typeof(dgtk.OpenGL.delegatesGLES.glExtGetShadersQCOM));
			}
			if (SuportedExt.Contains("glExtGetTexLevelParameterivQCOM"))
			{
				dgtk.OpenGL.internalGLES.glExtGetTexLevelParameterivQCOM = (dgtk.OpenGL.delegatesGLES.glExtGetTexLevelParameterivQCOM) InternalGLesTool.GetGLesMethodAdress("glExtGetTexLevelParameterivQCOM", typeof(dgtk.OpenGL.delegatesGLES.glExtGetTexLevelParameterivQCOM));
			}
			if (SuportedExt.Contains("glExtGetTexSubImageQCOM"))
			{
				dgtk.OpenGL.internalGLES.glExtGetTexSubImageQCOM = (dgtk.OpenGL.delegatesGLES.glExtGetTexSubImageQCOM) InternalGLesTool.GetGLesMethodAdress("glExtGetTexSubImageQCOM", typeof(dgtk.OpenGL.delegatesGLES.glExtGetTexSubImageQCOM));
			}
			if (SuportedExt.Contains("glExtGetTexturesQCOM"))
			{
				dgtk.OpenGL.internalGLES.glExtGetTexturesQCOM = (dgtk.OpenGL.delegatesGLES.glExtGetTexturesQCOM) InternalGLesTool.GetGLesMethodAdress("glExtGetTexturesQCOM", typeof(dgtk.OpenGL.delegatesGLES.glExtGetTexturesQCOM));
			}
			if (SuportedExt.Contains("glExtIsProgramBinaryQCOM"))
			{
				dgtk.OpenGL.internalGLES.glExtIsProgramBinaryQCOM = (dgtk.OpenGL.delegatesGLES.glExtIsProgramBinaryQCOM) InternalGLesTool.GetGLesMethodAdress("glExtIsProgramBinaryQCOM", typeof(dgtk.OpenGL.delegatesGLES.glExtIsProgramBinaryQCOM));
			}
			if (SuportedExt.Contains("glExtrapolateTex2DQCOM"))
			{
				dgtk.OpenGL.internalGLES.glExtrapolateTex2DQCOM = (dgtk.OpenGL.delegatesGLES.glExtrapolateTex2DQCOM) InternalGLesTool.GetGLesMethodAdress("glExtrapolateTex2DQCOM", typeof(dgtk.OpenGL.delegatesGLES.glExtrapolateTex2DQCOM));
			}
			if (SuportedExt.Contains("glExtTexObjectStateOverrideiQCOM"))
			{
				dgtk.OpenGL.internalGLES.glExtTexObjectStateOverrideiQCOM = (dgtk.OpenGL.delegatesGLES.glExtTexObjectStateOverrideiQCOM) InternalGLesTool.GetGLesMethodAdress("glExtTexObjectStateOverrideiQCOM", typeof(dgtk.OpenGL.delegatesGLES.glExtTexObjectStateOverrideiQCOM));
			}
			#endregion

			#region F:

			if (SuportedExt.Contains("glFeedbackBufferxOES"))
			{
				dgtk.OpenGL.internalGLES.glFeedbackBufferxOES = (dgtk.OpenGL.delegatesGLES.glFeedbackBufferxOES) InternalGLesTool.GetGLesMethodAdress("glFeedbackBufferxOES", typeof(dgtk.OpenGL.delegatesGLES.glFeedbackBufferxOES));
			}
			if (SuportedExt.Contains("glFenceSyncAPPLE"))
			{
				dgtk.OpenGL.internalGLES.glFenceSyncAPPLE = (dgtk.OpenGL.delegatesGLES.glFenceSyncAPPLE) InternalGLesTool.GetGLesMethodAdress("glFenceSyncAPPLE", typeof(dgtk.OpenGL.delegatesGLES.glFenceSyncAPPLE));
			}
			if (SuportedExt.Contains("glFinishFenceNV"))
			{
				dgtk.OpenGL.internalGLES.glFinishFenceNV = (dgtk.OpenGL.delegatesGLES.glFinishFenceNV) InternalGLesTool.GetGLesMethodAdress("glFinishFenceNV", typeof(dgtk.OpenGL.delegatesGLES.glFinishFenceNV));
			}
			if (SuportedExt.Contains("glFlushMappedBufferRangeEXT"))
			{
				dgtk.OpenGL.internalGLES.glFlushMappedBufferRangeEXT = (dgtk.OpenGL.delegatesGLES.glFlushMappedBufferRangeEXT) InternalGLesTool.GetGLesMethodAdress("glFlushMappedBufferRangeEXT", typeof(dgtk.OpenGL.delegatesGLES.glFlushMappedBufferRangeEXT));
			}
			if (SuportedExt.Contains("glFogxOES"))
			{
				dgtk.OpenGL.internalGLES.glFogxOES = (dgtk.OpenGL.delegatesGLES.glFogxOES) InternalGLesTool.GetGLesMethodAdress("glFogxOES", typeof(dgtk.OpenGL.delegatesGLES.glFogxOES));
			}
			if (SuportedExt.Contains("glFogxvOES"))
			{
				dgtk.OpenGL.internalGLES.glFogxvOES = (dgtk.OpenGL.delegatesGLES.glFogxvOES) InternalGLesTool.GetGLesMethodAdress("glFogxvOES", typeof(dgtk.OpenGL.delegatesGLES.glFogxvOES));
			}
			if (SuportedExt.Contains("glFragmentCoverageColorNV"))
			{
				dgtk.OpenGL.internalGLES.glFragmentCoverageColorNV = (dgtk.OpenGL.delegatesGLES.glFragmentCoverageColorNV) InternalGLesTool.GetGLesMethodAdress("glFragmentCoverageColorNV", typeof(dgtk.OpenGL.delegatesGLES.glFragmentCoverageColorNV));
			}
			if (SuportedExt.Contains("glFramebufferFetchBarrierEXT"))
			{
				dgtk.OpenGL.internalGLES.glFramebufferFetchBarrierEXT = (dgtk.OpenGL.delegatesGLES.glFramebufferFetchBarrierEXT) InternalGLesTool.GetGLesMethodAdress("glFramebufferFetchBarrierEXT", typeof(dgtk.OpenGL.delegatesGLES.glFramebufferFetchBarrierEXT));
			}
			if (SuportedExt.Contains("glFramebufferFetchBarrierQCOM"))
			{
				dgtk.OpenGL.internalGLES.glFramebufferFetchBarrierQCOM = (dgtk.OpenGL.delegatesGLES.glFramebufferFetchBarrierQCOM) InternalGLesTool.GetGLesMethodAdress("glFramebufferFetchBarrierQCOM", typeof(dgtk.OpenGL.delegatesGLES.glFramebufferFetchBarrierQCOM));
			}
			if (SuportedExt.Contains("glFramebufferFoveationConfigQCOM"))
			{
				dgtk.OpenGL.internalGLES.glFramebufferFoveationConfigQCOM = (dgtk.OpenGL.delegatesGLES.glFramebufferFoveationConfigQCOM) InternalGLesTool.GetGLesMethodAdress("glFramebufferFoveationConfigQCOM", typeof(dgtk.OpenGL.delegatesGLES.glFramebufferFoveationConfigQCOM));
			}
			if (SuportedExt.Contains("glFramebufferFoveationParametersQCOM"))
			{
				dgtk.OpenGL.internalGLES.glFramebufferFoveationParametersQCOM = (dgtk.OpenGL.delegatesGLES.glFramebufferFoveationParametersQCOM) InternalGLesTool.GetGLesMethodAdress("glFramebufferFoveationParametersQCOM", typeof(dgtk.OpenGL.delegatesGLES.glFramebufferFoveationParametersQCOM));
			}
			if (SuportedExt.Contains("glFramebufferParameteriMESA"))
			{
				dgtk.OpenGL.internalGLES.glFramebufferParameteriMESA = (dgtk.OpenGL.delegatesGLES.glFramebufferParameteriMESA) InternalGLesTool.GetGLesMethodAdress("glFramebufferParameteriMESA", typeof(dgtk.OpenGL.delegatesGLES.glFramebufferParameteriMESA));
			}
			if (SuportedExt.Contains("glFramebufferPixelLocalStorageSizeEXT"))
			{
				dgtk.OpenGL.internalGLES.glFramebufferPixelLocalStorageSizeEXT = (dgtk.OpenGL.delegatesGLES.glFramebufferPixelLocalStorageSizeEXT) InternalGLesTool.GetGLesMethodAdress("glFramebufferPixelLocalStorageSizeEXT", typeof(dgtk.OpenGL.delegatesGLES.glFramebufferPixelLocalStorageSizeEXT));
			}
			if (SuportedExt.Contains("glFramebufferRenderbufferOES"))
			{
				dgtk.OpenGL.internalGLES.glFramebufferRenderbufferOES = (dgtk.OpenGL.delegatesGLES.glFramebufferRenderbufferOES) InternalGLesTool.GetGLesMethodAdress("glFramebufferRenderbufferOES", typeof(dgtk.OpenGL.delegatesGLES.glFramebufferRenderbufferOES));
			}
			if (SuportedExt.Contains("glFramebufferSampleLocationsfvNV"))
			{
				dgtk.OpenGL.internalGLES.glFramebufferSampleLocationsfvNV = (dgtk.OpenGL.delegatesGLES.glFramebufferSampleLocationsfvNV) InternalGLesTool.GetGLesMethodAdress("glFramebufferSampleLocationsfvNV", typeof(dgtk.OpenGL.delegatesGLES.glFramebufferSampleLocationsfvNV));
			}
			if (SuportedExt.Contains("glFramebufferShadingRateEXT"))
			{
				dgtk.OpenGL.internalGLES.glFramebufferShadingRateEXT = (dgtk.OpenGL.delegatesGLES.glFramebufferShadingRateEXT) InternalGLesTool.GetGLesMethodAdress("glFramebufferShadingRateEXT", typeof(dgtk.OpenGL.delegatesGLES.glFramebufferShadingRateEXT));
			}
			if (SuportedExt.Contains("glFramebufferTexture2DDownsampleIMG"))
			{
				dgtk.OpenGL.internalGLES.glFramebufferTexture2DDownsampleIMG = (dgtk.OpenGL.delegatesGLES.glFramebufferTexture2DDownsampleIMG) InternalGLesTool.GetGLesMethodAdress("glFramebufferTexture2DDownsampleIMG", typeof(dgtk.OpenGL.delegatesGLES.glFramebufferTexture2DDownsampleIMG));
			}
			if (SuportedExt.Contains("glFramebufferTexture2DMultisampleEXT"))
			{
				dgtk.OpenGL.internalGLES.glFramebufferTexture2DMultisampleEXT = (dgtk.OpenGL.delegatesGLES.glFramebufferTexture2DMultisampleEXT) InternalGLesTool.GetGLesMethodAdress("glFramebufferTexture2DMultisampleEXT", typeof(dgtk.OpenGL.delegatesGLES.glFramebufferTexture2DMultisampleEXT));
			}
			if (SuportedExt.Contains("glFramebufferTexture2DMultisampleIMG"))
			{
				dgtk.OpenGL.internalGLES.glFramebufferTexture2DMultisampleIMG = (dgtk.OpenGL.delegatesGLES.glFramebufferTexture2DMultisampleIMG) InternalGLesTool.GetGLesMethodAdress("glFramebufferTexture2DMultisampleIMG", typeof(dgtk.OpenGL.delegatesGLES.glFramebufferTexture2DMultisampleIMG));
			}
			if (SuportedExt.Contains("glFramebufferTexture2DOES"))
			{
				dgtk.OpenGL.internalGLES.glFramebufferTexture2DOES = (dgtk.OpenGL.delegatesGLES.glFramebufferTexture2DOES) InternalGLesTool.GetGLesMethodAdress("glFramebufferTexture2DOES", typeof(dgtk.OpenGL.delegatesGLES.glFramebufferTexture2DOES));
			}
			if (SuportedExt.Contains("glFramebufferTexture3DOES"))
			{
				dgtk.OpenGL.internalGLES.glFramebufferTexture3DOES = (dgtk.OpenGL.delegatesGLES.glFramebufferTexture3DOES) InternalGLesTool.GetGLesMethodAdress("glFramebufferTexture3DOES", typeof(dgtk.OpenGL.delegatesGLES.glFramebufferTexture3DOES));
			}
			if (SuportedExt.Contains("glFramebufferTextureEXT"))
			{
				dgtk.OpenGL.internalGLES.glFramebufferTextureEXT = (dgtk.OpenGL.delegatesGLES.glFramebufferTextureEXT) InternalGLesTool.GetGLesMethodAdress("glFramebufferTextureEXT", typeof(dgtk.OpenGL.delegatesGLES.glFramebufferTextureEXT));
			}
			if (SuportedExt.Contains("glFramebufferTextureLayerDownsampleIMG"))
			{
				dgtk.OpenGL.internalGLES.glFramebufferTextureLayerDownsampleIMG = (dgtk.OpenGL.delegatesGLES.glFramebufferTextureLayerDownsampleIMG) InternalGLesTool.GetGLesMethodAdress("glFramebufferTextureLayerDownsampleIMG", typeof(dgtk.OpenGL.delegatesGLES.glFramebufferTextureLayerDownsampleIMG));
			}
			if (SuportedExt.Contains("glFramebufferTextureMultisampleMultiviewOVR"))
			{
				dgtk.OpenGL.internalGLES.glFramebufferTextureMultisampleMultiviewOVR = (dgtk.OpenGL.delegatesGLES.glFramebufferTextureMultisampleMultiviewOVR) InternalGLesTool.GetGLesMethodAdress("glFramebufferTextureMultisampleMultiviewOVR", typeof(dgtk.OpenGL.delegatesGLES.glFramebufferTextureMultisampleMultiviewOVR));
			}
			if (SuportedExt.Contains("glFramebufferTextureMultiviewOVR"))
			{
				dgtk.OpenGL.internalGLES.glFramebufferTextureMultiviewOVR = (dgtk.OpenGL.delegatesGLES.glFramebufferTextureMultiviewOVR) InternalGLesTool.GetGLesMethodAdress("glFramebufferTextureMultiviewOVR", typeof(dgtk.OpenGL.delegatesGLES.glFramebufferTextureMultiviewOVR));
			}
			if (SuportedExt.Contains("glFramebufferTextureOES"))
			{
				dgtk.OpenGL.internalGLES.glFramebufferTextureOES = (dgtk.OpenGL.delegatesGLES.glFramebufferTextureOES) InternalGLesTool.GetGLesMethodAdress("glFramebufferTextureOES", typeof(dgtk.OpenGL.delegatesGLES.glFramebufferTextureOES));
			}
			if (SuportedExt.Contains("glFrustumfOES"))
			{
				dgtk.OpenGL.internalGLES.glFrustumfOES = (dgtk.OpenGL.delegatesGLES.glFrustumfOES) InternalGLesTool.GetGLesMethodAdress("glFrustumfOES", typeof(dgtk.OpenGL.delegatesGLES.glFrustumfOES));
			}
			if (SuportedExt.Contains("glFrustumxOES"))
			{
				dgtk.OpenGL.internalGLES.glFrustumxOES = (dgtk.OpenGL.delegatesGLES.glFrustumxOES) InternalGLesTool.GetGLesMethodAdress("glFrustumxOES", typeof(dgtk.OpenGL.delegatesGLES.glFrustumxOES));
			}
			#endregion

			#region G:

			if (SuportedExt.Contains("glGenerateMipmapOES"))
			{
				dgtk.OpenGL.internalGLES.glGenerateMipmapOES = (dgtk.OpenGL.delegatesGLES.glGenerateMipmapOES) InternalGLesTool.GetGLesMethodAdress("glGenerateMipmapOES", typeof(dgtk.OpenGL.delegatesGLES.glGenerateMipmapOES));
			}
			if (SuportedExt.Contains("glGenFencesNV"))
			{
				dgtk.OpenGL.internalGLES.glGenFencesNV = (dgtk.OpenGL.delegatesGLES.glGenFencesNV) InternalGLesTool.GetGLesMethodAdress("glGenFencesNV", typeof(dgtk.OpenGL.delegatesGLES.glGenFencesNV));
			}
			if (SuportedExt.Contains("glGenFramebuffersOES"))
			{
				dgtk.OpenGL.internalGLES.glGenFramebuffersOES = (dgtk.OpenGL.delegatesGLES.glGenFramebuffersOES) InternalGLesTool.GetGLesMethodAdress("glGenFramebuffersOES", typeof(dgtk.OpenGL.delegatesGLES.glGenFramebuffersOES));
			}
			if (SuportedExt.Contains("glGenPathsNV"))
			{
				dgtk.OpenGL.internalGLES.glGenPathsNV = (dgtk.OpenGL.delegatesGLES.glGenPathsNV) InternalGLesTool.GetGLesMethodAdress("glGenPathsNV", typeof(dgtk.OpenGL.delegatesGLES.glGenPathsNV));
			}
			if (SuportedExt.Contains("glGenPerfMonitorsAMD"))
			{
				dgtk.OpenGL.internalGLES.glGenPerfMonitorsAMD = (dgtk.OpenGL.delegatesGLES.glGenPerfMonitorsAMD) InternalGLesTool.GetGLesMethodAdress("glGenPerfMonitorsAMD", typeof(dgtk.OpenGL.delegatesGLES.glGenPerfMonitorsAMD));
			}
			if (SuportedExt.Contains("glGenProgramPipelinesEXT"))
			{
				dgtk.OpenGL.internalGLES.glGenProgramPipelinesEXT = (dgtk.OpenGL.delegatesGLES.glGenProgramPipelinesEXT) InternalGLesTool.GetGLesMethodAdress("glGenProgramPipelinesEXT", typeof(dgtk.OpenGL.delegatesGLES.glGenProgramPipelinesEXT));
			}
			if (SuportedExt.Contains("glGenQueriesEXT"))
			{
				dgtk.OpenGL.internalGLES.glGenQueriesEXT = (dgtk.OpenGL.delegatesGLES.glGenQueriesEXT) InternalGLesTool.GetGLesMethodAdress("glGenQueriesEXT", typeof(dgtk.OpenGL.delegatesGLES.glGenQueriesEXT));
			}
			if (SuportedExt.Contains("glGenRenderbuffersOES"))
			{
				dgtk.OpenGL.internalGLES.glGenRenderbuffersOES = (dgtk.OpenGL.delegatesGLES.glGenRenderbuffersOES) InternalGLesTool.GetGLesMethodAdress("glGenRenderbuffersOES", typeof(dgtk.OpenGL.delegatesGLES.glGenRenderbuffersOES));
			}
			if (SuportedExt.Contains("glGenSemaphoresEXT"))
			{
				dgtk.OpenGL.internalGLES.glGenSemaphoresEXT = (dgtk.OpenGL.delegatesGLES.glGenSemaphoresEXT) InternalGLesTool.GetGLesMethodAdress("glGenSemaphoresEXT", typeof(dgtk.OpenGL.delegatesGLES.glGenSemaphoresEXT));
			}
			if (SuportedExt.Contains("glGenVertexArraysOES"))
			{
				dgtk.OpenGL.internalGLES.glGenVertexArraysOES = (dgtk.OpenGL.delegatesGLES.glGenVertexArraysOES) InternalGLesTool.GetGLesMethodAdress("glGenVertexArraysOES", typeof(dgtk.OpenGL.delegatesGLES.glGenVertexArraysOES));
			}
			if (SuportedExt.Contains("glGetBufferPointervOES"))
			{
				dgtk.OpenGL.internalGLES.glGetBufferPointervOES = (dgtk.OpenGL.delegatesGLES.glGetBufferPointervOES) InternalGLesTool.GetGLesMethodAdress("glGetBufferPointervOES", typeof(dgtk.OpenGL.delegatesGLES.glGetBufferPointervOES));
			}
			if (SuportedExt.Contains("glGetClipPlanefOES"))
			{
				dgtk.OpenGL.internalGLES.glGetClipPlanefOES = (dgtk.OpenGL.delegatesGLES.glGetClipPlanefOES) InternalGLesTool.GetGLesMethodAdress("glGetClipPlanefOES", typeof(dgtk.OpenGL.delegatesGLES.glGetClipPlanefOES));
			}
			if (SuportedExt.Contains("glGetClipPlanexOES"))
			{
				dgtk.OpenGL.internalGLES.glGetClipPlanexOES = (dgtk.OpenGL.delegatesGLES.glGetClipPlanexOES) InternalGLesTool.GetGLesMethodAdress("glGetClipPlanexOES", typeof(dgtk.OpenGL.delegatesGLES.glGetClipPlanexOES));
			}
			if (SuportedExt.Contains("glGetConvolutionParameterxvOES"))
			{
				dgtk.OpenGL.internalGLES.glGetConvolutionParameterxvOES = (dgtk.OpenGL.delegatesGLES.glGetConvolutionParameterxvOES) InternalGLesTool.GetGLesMethodAdress("glGetConvolutionParameterxvOES", typeof(dgtk.OpenGL.delegatesGLES.glGetConvolutionParameterxvOES));
			}
			if (SuportedExt.Contains("glGetCoverageModulationTableNV"))
			{
				dgtk.OpenGL.internalGLES.glGetCoverageModulationTableNV = (dgtk.OpenGL.delegatesGLES.glGetCoverageModulationTableNV) InternalGLesTool.GetGLesMethodAdress("glGetCoverageModulationTableNV", typeof(dgtk.OpenGL.delegatesGLES.glGetCoverageModulationTableNV));
			}
			if (SuportedExt.Contains("glGetDebugMessageLogKHR"))
			{
				dgtk.OpenGL.internalGLES.glGetDebugMessageLogKHR = (dgtk.OpenGL.delegatesGLES.glGetDebugMessageLogKHR) InternalGLesTool.GetGLesMethodAdress("glGetDebugMessageLogKHR", typeof(dgtk.OpenGL.delegatesGLES.glGetDebugMessageLogKHR));
			}
			if (SuportedExt.Contains("glGetDriverControlsQCOM"))
			{
				dgtk.OpenGL.internalGLES.glGetDriverControlsQCOM = (dgtk.OpenGL.delegatesGLES.glGetDriverControlsQCOM) InternalGLesTool.GetGLesMethodAdress("glGetDriverControlsQCOM", typeof(dgtk.OpenGL.delegatesGLES.glGetDriverControlsQCOM));
			}
			if (SuportedExt.Contains("glGetDriverControlStringQCOM"))
			{
				dgtk.OpenGL.internalGLES.glGetDriverControlStringQCOM = (dgtk.OpenGL.delegatesGLES.glGetDriverControlStringQCOM) InternalGLesTool.GetGLesMethodAdress("glGetDriverControlStringQCOM", typeof(dgtk.OpenGL.delegatesGLES.glGetDriverControlStringQCOM));
			}
			if (SuportedExt.Contains("glGetFenceivNV"))
			{
				dgtk.OpenGL.internalGLES.glGetFenceivNV = (dgtk.OpenGL.delegatesGLES.glGetFenceivNV) InternalGLesTool.GetGLesMethodAdress("glGetFenceivNV", typeof(dgtk.OpenGL.delegatesGLES.glGetFenceivNV));
			}
			if (SuportedExt.Contains("glGetFirstPerfQueryIdINTEL"))
			{
				dgtk.OpenGL.internalGLES.glGetFirstPerfQueryIdINTEL = (dgtk.OpenGL.delegatesGLES.glGetFirstPerfQueryIdINTEL) InternalGLesTool.GetGLesMethodAdress("glGetFirstPerfQueryIdINTEL", typeof(dgtk.OpenGL.delegatesGLES.glGetFirstPerfQueryIdINTEL));
			}
			if (SuportedExt.Contains("glGetFixedvOES"))
			{
				dgtk.OpenGL.internalGLES.glGetFixedvOES = (dgtk.OpenGL.delegatesGLES.glGetFixedvOES) InternalGLesTool.GetGLesMethodAdress("glGetFixedvOES", typeof(dgtk.OpenGL.delegatesGLES.glGetFixedvOES));
			}
			if (SuportedExt.Contains("glGetFloati_vNV"))
			{
				dgtk.OpenGL.internalGLES.glGetFloati_vNV = (dgtk.OpenGL.delegatesGLES.glGetFloati_vNV) InternalGLesTool.GetGLesMethodAdress("glGetFloati_vNV", typeof(dgtk.OpenGL.delegatesGLES.glGetFloati_vNV));
			}
			if (SuportedExt.Contains("glGetFloati_vOES"))
			{
				dgtk.OpenGL.internalGLES.glGetFloati_vOES = (dgtk.OpenGL.delegatesGLES.glGetFloati_vOES) InternalGLesTool.GetGLesMethodAdress("glGetFloati_vOES", typeof(dgtk.OpenGL.delegatesGLES.glGetFloati_vOES));
			}
			if (SuportedExt.Contains("glGetFragDataIndexEXT"))
			{
				dgtk.OpenGL.internalGLES.glGetFragDataIndexEXT = (dgtk.OpenGL.delegatesGLES.glGetFragDataIndexEXT) InternalGLesTool.GetGLesMethodAdress("glGetFragDataIndexEXT", typeof(dgtk.OpenGL.delegatesGLES.glGetFragDataIndexEXT));
			}
			if (SuportedExt.Contains("glGetFragmentShadingRatesEXT"))
			{
				dgtk.OpenGL.internalGLES.glGetFragmentShadingRatesEXT = (dgtk.OpenGL.delegatesGLES.glGetFragmentShadingRatesEXT) InternalGLesTool.GetGLesMethodAdress("glGetFragmentShadingRatesEXT", typeof(dgtk.OpenGL.delegatesGLES.glGetFragmentShadingRatesEXT));
			}
			if (SuportedExt.Contains("glGetFramebufferAttachmentParameterivOES"))
			{
				dgtk.OpenGL.internalGLES.glGetFramebufferAttachmentParameterivOES = (dgtk.OpenGL.delegatesGLES.glGetFramebufferAttachmentParameterivOES) InternalGLesTool.GetGLesMethodAdress("glGetFramebufferAttachmentParameterivOES", typeof(dgtk.OpenGL.delegatesGLES.glGetFramebufferAttachmentParameterivOES));
			}
			if (SuportedExt.Contains("glGetFramebufferParameterivMESA"))
			{
				dgtk.OpenGL.internalGLES.glGetFramebufferParameterivMESA = (dgtk.OpenGL.delegatesGLES.glGetFramebufferParameterivMESA) InternalGLesTool.GetGLesMethodAdress("glGetFramebufferParameterivMESA", typeof(dgtk.OpenGL.delegatesGLES.glGetFramebufferParameterivMESA));
			}
			if (SuportedExt.Contains("glGetFramebufferPixelLocalStorageSizeEXT"))
			{
				dgtk.OpenGL.internalGLES.glGetFramebufferPixelLocalStorageSizeEXT = (dgtk.OpenGL.delegatesGLES.glGetFramebufferPixelLocalStorageSizeEXT) InternalGLesTool.GetGLesMethodAdress("glGetFramebufferPixelLocalStorageSizeEXT", typeof(dgtk.OpenGL.delegatesGLES.glGetFramebufferPixelLocalStorageSizeEXT));
			}
			if (SuportedExt.Contains("glGetGraphicsResetStatusEXT"))
			{
				dgtk.OpenGL.internalGLES.glGetGraphicsResetStatusEXT = (dgtk.OpenGL.delegatesGLES.glGetGraphicsResetStatusEXT) InternalGLesTool.GetGLesMethodAdress("glGetGraphicsResetStatusEXT", typeof(dgtk.OpenGL.delegatesGLES.glGetGraphicsResetStatusEXT));
			}
			if (SuportedExt.Contains("glGetGraphicsResetStatusKHR"))
			{
				dgtk.OpenGL.internalGLES.glGetGraphicsResetStatusKHR = (dgtk.OpenGL.delegatesGLES.glGetGraphicsResetStatusKHR) InternalGLesTool.GetGLesMethodAdress("glGetGraphicsResetStatusKHR", typeof(dgtk.OpenGL.delegatesGLES.glGetGraphicsResetStatusKHR));
			}
			if (SuportedExt.Contains("glGetHistogramParameterxvOES"))
			{
				dgtk.OpenGL.internalGLES.glGetHistogramParameterxvOES = (dgtk.OpenGL.delegatesGLES.glGetHistogramParameterxvOES) InternalGLesTool.GetGLesMethodAdress("glGetHistogramParameterxvOES", typeof(dgtk.OpenGL.delegatesGLES.glGetHistogramParameterxvOES));
			}
			if (SuportedExt.Contains("glGetImageHandleNV"))
			{
				dgtk.OpenGL.internalGLES.glGetImageHandleNV = (dgtk.OpenGL.delegatesGLES.glGetImageHandleNV) InternalGLesTool.GetGLesMethodAdress("glGetImageHandleNV", typeof(dgtk.OpenGL.delegatesGLES.glGetImageHandleNV));
			}
			if (SuportedExt.Contains("glGetInteger64vAPPLE"))
			{
				dgtk.OpenGL.internalGLES.glGetInteger64vAPPLE = (dgtk.OpenGL.delegatesGLES.glGetInteger64vAPPLE) InternalGLesTool.GetGLesMethodAdress("glGetInteger64vAPPLE", typeof(dgtk.OpenGL.delegatesGLES.glGetInteger64vAPPLE));
			}
			if (SuportedExt.Contains("glGetInteger64vEXT"))
			{
				dgtk.OpenGL.internalGLES.glGetInteger64vEXT = (dgtk.OpenGL.delegatesGLES.glGetInteger64vEXT) InternalGLesTool.GetGLesMethodAdress("glGetInteger64vEXT", typeof(dgtk.OpenGL.delegatesGLES.glGetInteger64vEXT));
			}
			if (SuportedExt.Contains("glGetIntegeri_vEXT"))
			{
				dgtk.OpenGL.internalGLES.glGetIntegeri_vEXT = (dgtk.OpenGL.delegatesGLES.glGetIntegeri_vEXT) InternalGLesTool.GetGLesMethodAdress("glGetIntegeri_vEXT", typeof(dgtk.OpenGL.delegatesGLES.glGetIntegeri_vEXT));
			}
			if (SuportedExt.Contains("glGetInternalformatSampleivNV"))
			{
				dgtk.OpenGL.internalGLES.glGetInternalformatSampleivNV = (dgtk.OpenGL.delegatesGLES.glGetInternalformatSampleivNV) InternalGLesTool.GetGLesMethodAdress("glGetInternalformatSampleivNV", typeof(dgtk.OpenGL.delegatesGLES.glGetInternalformatSampleivNV));
			}
			if (SuportedExt.Contains("glGetLightxOES"))
			{
				dgtk.OpenGL.internalGLES.glGetLightxOES = (dgtk.OpenGL.delegatesGLES.glGetLightxOES) InternalGLesTool.GetGLesMethodAdress("glGetLightxOES", typeof(dgtk.OpenGL.delegatesGLES.glGetLightxOES));
			}
			if (SuportedExt.Contains("glGetLightxvOES"))
			{
				dgtk.OpenGL.internalGLES.glGetLightxvOES = (dgtk.OpenGL.delegatesGLES.glGetLightxvOES) InternalGLesTool.GetGLesMethodAdress("glGetLightxvOES", typeof(dgtk.OpenGL.delegatesGLES.glGetLightxvOES));
			}
			if (SuportedExt.Contains("glGetMapxvOES"))
			{
				dgtk.OpenGL.internalGLES.glGetMapxvOES = (dgtk.OpenGL.delegatesGLES.glGetMapxvOES) InternalGLesTool.GetGLesMethodAdress("glGetMapxvOES", typeof(dgtk.OpenGL.delegatesGLES.glGetMapxvOES));
			}
			if (SuportedExt.Contains("glGetMaterialxOES"))
			{
				dgtk.OpenGL.internalGLES.glGetMaterialxOES = (dgtk.OpenGL.delegatesGLES.glGetMaterialxOES) InternalGLesTool.GetGLesMethodAdress("glGetMaterialxOES", typeof(dgtk.OpenGL.delegatesGLES.glGetMaterialxOES));
			}
			if (SuportedExt.Contains("glGetMaterialxvOES"))
			{
				dgtk.OpenGL.internalGLES.glGetMaterialxvOES = (dgtk.OpenGL.delegatesGLES.glGetMaterialxvOES) InternalGLesTool.GetGLesMethodAdress("glGetMaterialxvOES", typeof(dgtk.OpenGL.delegatesGLES.glGetMaterialxvOES));
			}
			if (SuportedExt.Contains("glGetMemoryObjectDetachedResourcesuivNV"))
			{
				dgtk.OpenGL.internalGLES.glGetMemoryObjectDetachedResourcesuivNV = (dgtk.OpenGL.delegatesGLES.glGetMemoryObjectDetachedResourcesuivNV) InternalGLesTool.GetGLesMethodAdress("glGetMemoryObjectDetachedResourcesuivNV", typeof(dgtk.OpenGL.delegatesGLES.glGetMemoryObjectDetachedResourcesuivNV));
			}
			if (SuportedExt.Contains("glGetMemoryObjectParameterivEXT"))
			{
				dgtk.OpenGL.internalGLES.glGetMemoryObjectParameterivEXT = (dgtk.OpenGL.delegatesGLES.glGetMemoryObjectParameterivEXT) InternalGLesTool.GetGLesMethodAdress("glGetMemoryObjectParameterivEXT", typeof(dgtk.OpenGL.delegatesGLES.glGetMemoryObjectParameterivEXT));
			}
			if (SuportedExt.Contains("glGetNextPerfQueryIdINTEL"))
			{
				dgtk.OpenGL.internalGLES.glGetNextPerfQueryIdINTEL = (dgtk.OpenGL.delegatesGLES.glGetNextPerfQueryIdINTEL) InternalGLesTool.GetGLesMethodAdress("glGetNextPerfQueryIdINTEL", typeof(dgtk.OpenGL.delegatesGLES.glGetNextPerfQueryIdINTEL));
			}
			if (SuportedExt.Contains("glGetnUniformfvEXT"))
			{
				dgtk.OpenGL.internalGLES.glGetnUniformfvEXT = (dgtk.OpenGL.delegatesGLES.glGetnUniformfvEXT) InternalGLesTool.GetGLesMethodAdress("glGetnUniformfvEXT", typeof(dgtk.OpenGL.delegatesGLES.glGetnUniformfvEXT));
			}
			if (SuportedExt.Contains("glGetnUniformfvKHR"))
			{
				dgtk.OpenGL.internalGLES.glGetnUniformfvKHR = (dgtk.OpenGL.delegatesGLES.glGetnUniformfvKHR) InternalGLesTool.GetGLesMethodAdress("glGetnUniformfvKHR", typeof(dgtk.OpenGL.delegatesGLES.glGetnUniformfvKHR));
			}
			if (SuportedExt.Contains("glGetnUniformivEXT"))
			{
				dgtk.OpenGL.internalGLES.glGetnUniformivEXT = (dgtk.OpenGL.delegatesGLES.glGetnUniformivEXT) InternalGLesTool.GetGLesMethodAdress("glGetnUniformivEXT", typeof(dgtk.OpenGL.delegatesGLES.glGetnUniformivEXT));
			}
			if (SuportedExt.Contains("glGetnUniformivKHR"))
			{
				dgtk.OpenGL.internalGLES.glGetnUniformivKHR = (dgtk.OpenGL.delegatesGLES.glGetnUniformivKHR) InternalGLesTool.GetGLesMethodAdress("glGetnUniformivKHR", typeof(dgtk.OpenGL.delegatesGLES.glGetnUniformivKHR));
			}
			if (SuportedExt.Contains("glGetnUniformuivKHR"))
			{
				dgtk.OpenGL.internalGLES.glGetnUniformuivKHR = (dgtk.OpenGL.delegatesGLES.glGetnUniformuivKHR) InternalGLesTool.GetGLesMethodAdress("glGetnUniformuivKHR", typeof(dgtk.OpenGL.delegatesGLES.glGetnUniformuivKHR));
			}
			if (SuportedExt.Contains("glGetObjectLabelEXT"))
			{
				dgtk.OpenGL.internalGLES.glGetObjectLabelEXT = (dgtk.OpenGL.delegatesGLES.glGetObjectLabelEXT) InternalGLesTool.GetGLesMethodAdress("glGetObjectLabelEXT", typeof(dgtk.OpenGL.delegatesGLES.glGetObjectLabelEXT));
			}
			if (SuportedExt.Contains("glGetObjectLabelKHR"))
			{
				dgtk.OpenGL.internalGLES.glGetObjectLabelKHR = (dgtk.OpenGL.delegatesGLES.glGetObjectLabelKHR) InternalGLesTool.GetGLesMethodAdress("glGetObjectLabelKHR", typeof(dgtk.OpenGL.delegatesGLES.glGetObjectLabelKHR));
			}
			if (SuportedExt.Contains("glGetObjectPtrLabelKHR"))
			{
				dgtk.OpenGL.internalGLES.glGetObjectPtrLabelKHR = (dgtk.OpenGL.delegatesGLES.glGetObjectPtrLabelKHR) InternalGLesTool.GetGLesMethodAdress("glGetObjectPtrLabelKHR", typeof(dgtk.OpenGL.delegatesGLES.glGetObjectPtrLabelKHR));
			}
			if (SuportedExt.Contains("glGetPathColorGenfvNV"))
			{
				dgtk.OpenGL.internalGLES.glGetPathColorGenfvNV = (dgtk.OpenGL.delegatesGLES.glGetPathColorGenfvNV) InternalGLesTool.GetGLesMethodAdress("glGetPathColorGenfvNV", typeof(dgtk.OpenGL.delegatesGLES.glGetPathColorGenfvNV));
			}
			if (SuportedExt.Contains("glGetPathColorGenivNV"))
			{
				dgtk.OpenGL.internalGLES.glGetPathColorGenivNV = (dgtk.OpenGL.delegatesGLES.glGetPathColorGenivNV) InternalGLesTool.GetGLesMethodAdress("glGetPathColorGenivNV", typeof(dgtk.OpenGL.delegatesGLES.glGetPathColorGenivNV));
			}
			if (SuportedExt.Contains("glGetPathCommandsNV"))
			{
				dgtk.OpenGL.internalGLES.glGetPathCommandsNV = (dgtk.OpenGL.delegatesGLES.glGetPathCommandsNV) InternalGLesTool.GetGLesMethodAdress("glGetPathCommandsNV", typeof(dgtk.OpenGL.delegatesGLES.glGetPathCommandsNV));
			}
			if (SuportedExt.Contains("glGetPathCoordsNV"))
			{
				dgtk.OpenGL.internalGLES.glGetPathCoordsNV = (dgtk.OpenGL.delegatesGLES.glGetPathCoordsNV) InternalGLesTool.GetGLesMethodAdress("glGetPathCoordsNV", typeof(dgtk.OpenGL.delegatesGLES.glGetPathCoordsNV));
			}
			if (SuportedExt.Contains("glGetPathDashArrayNV"))
			{
				dgtk.OpenGL.internalGLES.glGetPathDashArrayNV = (dgtk.OpenGL.delegatesGLES.glGetPathDashArrayNV) InternalGLesTool.GetGLesMethodAdress("glGetPathDashArrayNV", typeof(dgtk.OpenGL.delegatesGLES.glGetPathDashArrayNV));
			}
			if (SuportedExt.Contains("glGetPathLengthNV"))
			{
				dgtk.OpenGL.internalGLES.glGetPathLengthNV = (dgtk.OpenGL.delegatesGLES.glGetPathLengthNV) InternalGLesTool.GetGLesMethodAdress("glGetPathLengthNV", typeof(dgtk.OpenGL.delegatesGLES.glGetPathLengthNV));
			}
			if (SuportedExt.Contains("glGetPathMetricRangeNV"))
			{
				dgtk.OpenGL.internalGLES.glGetPathMetricRangeNV = (dgtk.OpenGL.delegatesGLES.glGetPathMetricRangeNV) InternalGLesTool.GetGLesMethodAdress("glGetPathMetricRangeNV", typeof(dgtk.OpenGL.delegatesGLES.glGetPathMetricRangeNV));
			}
			if (SuportedExt.Contains("glGetPathMetricsNV"))
			{
				dgtk.OpenGL.internalGLES.glGetPathMetricsNV = (dgtk.OpenGL.delegatesGLES.glGetPathMetricsNV) InternalGLesTool.GetGLesMethodAdress("glGetPathMetricsNV", typeof(dgtk.OpenGL.delegatesGLES.glGetPathMetricsNV));
			}
			if (SuportedExt.Contains("glGetPathParameterfvNV"))
			{
				dgtk.OpenGL.internalGLES.glGetPathParameterfvNV = (dgtk.OpenGL.delegatesGLES.glGetPathParameterfvNV) InternalGLesTool.GetGLesMethodAdress("glGetPathParameterfvNV", typeof(dgtk.OpenGL.delegatesGLES.glGetPathParameterfvNV));
			}
			if (SuportedExt.Contains("glGetPathParameterivNV"))
			{
				dgtk.OpenGL.internalGLES.glGetPathParameterivNV = (dgtk.OpenGL.delegatesGLES.glGetPathParameterivNV) InternalGLesTool.GetGLesMethodAdress("glGetPathParameterivNV", typeof(dgtk.OpenGL.delegatesGLES.glGetPathParameterivNV));
			}
			if (SuportedExt.Contains("glGetPathSpacingNV"))
			{
				dgtk.OpenGL.internalGLES.glGetPathSpacingNV = (dgtk.OpenGL.delegatesGLES.glGetPathSpacingNV) InternalGLesTool.GetGLesMethodAdress("glGetPathSpacingNV", typeof(dgtk.OpenGL.delegatesGLES.glGetPathSpacingNV));
			}
			if (SuportedExt.Contains("glGetPathTexGenfvNV"))
			{
				dgtk.OpenGL.internalGLES.glGetPathTexGenfvNV = (dgtk.OpenGL.delegatesGLES.glGetPathTexGenfvNV) InternalGLesTool.GetGLesMethodAdress("glGetPathTexGenfvNV", typeof(dgtk.OpenGL.delegatesGLES.glGetPathTexGenfvNV));
			}
			if (SuportedExt.Contains("glGetPathTexGenivNV"))
			{
				dgtk.OpenGL.internalGLES.glGetPathTexGenivNV = (dgtk.OpenGL.delegatesGLES.glGetPathTexGenivNV) InternalGLesTool.GetGLesMethodAdress("glGetPathTexGenivNV", typeof(dgtk.OpenGL.delegatesGLES.glGetPathTexGenivNV));
			}
			if (SuportedExt.Contains("glGetPerfCounterInfoINTEL"))
			{
				dgtk.OpenGL.internalGLES.glGetPerfCounterInfoINTEL = (dgtk.OpenGL.delegatesGLES.glGetPerfCounterInfoINTEL) InternalGLesTool.GetGLesMethodAdress("glGetPerfCounterInfoINTEL", typeof(dgtk.OpenGL.delegatesGLES.glGetPerfCounterInfoINTEL));
			}
			if (SuportedExt.Contains("glGetPerfMonitorCounterDataAMD"))
			{
				dgtk.OpenGL.internalGLES.glGetPerfMonitorCounterDataAMD = (dgtk.OpenGL.delegatesGLES.glGetPerfMonitorCounterDataAMD) InternalGLesTool.GetGLesMethodAdress("glGetPerfMonitorCounterDataAMD", typeof(dgtk.OpenGL.delegatesGLES.glGetPerfMonitorCounterDataAMD));
			}
			if (SuportedExt.Contains("glGetPerfMonitorCounterInfoAMD"))
			{
				dgtk.OpenGL.internalGLES.glGetPerfMonitorCounterInfoAMD = (dgtk.OpenGL.delegatesGLES.glGetPerfMonitorCounterInfoAMD) InternalGLesTool.GetGLesMethodAdress("glGetPerfMonitorCounterInfoAMD", typeof(dgtk.OpenGL.delegatesGLES.glGetPerfMonitorCounterInfoAMD));
			}
			if (SuportedExt.Contains("glGetPerfMonitorCountersAMD"))
			{
				dgtk.OpenGL.internalGLES.glGetPerfMonitorCountersAMD = (dgtk.OpenGL.delegatesGLES.glGetPerfMonitorCountersAMD) InternalGLesTool.GetGLesMethodAdress("glGetPerfMonitorCountersAMD", typeof(dgtk.OpenGL.delegatesGLES.glGetPerfMonitorCountersAMD));
			}
			if (SuportedExt.Contains("glGetPerfMonitorCounterStringAMD"))
			{
				dgtk.OpenGL.internalGLES.glGetPerfMonitorCounterStringAMD = (dgtk.OpenGL.delegatesGLES.glGetPerfMonitorCounterStringAMD) InternalGLesTool.GetGLesMethodAdress("glGetPerfMonitorCounterStringAMD", typeof(dgtk.OpenGL.delegatesGLES.glGetPerfMonitorCounterStringAMD));
			}
			if (SuportedExt.Contains("glGetPerfMonitorGroupsAMD"))
			{
				dgtk.OpenGL.internalGLES.glGetPerfMonitorGroupsAMD = (dgtk.OpenGL.delegatesGLES.glGetPerfMonitorGroupsAMD) InternalGLesTool.GetGLesMethodAdress("glGetPerfMonitorGroupsAMD", typeof(dgtk.OpenGL.delegatesGLES.glGetPerfMonitorGroupsAMD));
			}
			if (SuportedExt.Contains("glGetPerfMonitorGroupStringAMD"))
			{
				dgtk.OpenGL.internalGLES.glGetPerfMonitorGroupStringAMD = (dgtk.OpenGL.delegatesGLES.glGetPerfMonitorGroupStringAMD) InternalGLesTool.GetGLesMethodAdress("glGetPerfMonitorGroupStringAMD", typeof(dgtk.OpenGL.delegatesGLES.glGetPerfMonitorGroupStringAMD));
			}
			if (SuportedExt.Contains("glGetPerfQueryDataINTEL"))
			{
				dgtk.OpenGL.internalGLES.glGetPerfQueryDataINTEL = (dgtk.OpenGL.delegatesGLES.glGetPerfQueryDataINTEL) InternalGLesTool.GetGLesMethodAdress("glGetPerfQueryDataINTEL", typeof(dgtk.OpenGL.delegatesGLES.glGetPerfQueryDataINTEL));
			}
			if (SuportedExt.Contains("glGetPerfQueryIdByNameINTEL"))
			{
				dgtk.OpenGL.internalGLES.glGetPerfQueryIdByNameINTEL = (dgtk.OpenGL.delegatesGLES.glGetPerfQueryIdByNameINTEL) InternalGLesTool.GetGLesMethodAdress("glGetPerfQueryIdByNameINTEL", typeof(dgtk.OpenGL.delegatesGLES.glGetPerfQueryIdByNameINTEL));
			}
			if (SuportedExt.Contains("glGetPerfQueryInfoINTEL"))
			{
				dgtk.OpenGL.internalGLES.glGetPerfQueryInfoINTEL = (dgtk.OpenGL.delegatesGLES.glGetPerfQueryInfoINTEL) InternalGLesTool.GetGLesMethodAdress("glGetPerfQueryInfoINTEL", typeof(dgtk.OpenGL.delegatesGLES.glGetPerfQueryInfoINTEL));
			}
			if (SuportedExt.Contains("glGetPixelMapxv"))
			{
				dgtk.OpenGL.internalGLES.glGetPixelMapxv = (dgtk.OpenGL.delegatesGLES.glGetPixelMapxv) InternalGLesTool.GetGLesMethodAdress("glGetPixelMapxv", typeof(dgtk.OpenGL.delegatesGLES.glGetPixelMapxv));
			}
			if (SuportedExt.Contains("glGetPointervKHR"))
			{
				dgtk.OpenGL.internalGLES.glGetPointervKHR = (dgtk.OpenGL.delegatesGLES.glGetPointervKHR) InternalGLesTool.GetGLesMethodAdress("glGetPointervKHR", typeof(dgtk.OpenGL.delegatesGLES.glGetPointervKHR));
			}
			if (SuportedExt.Contains("glGetProgramBinaryOES"))
			{
				dgtk.OpenGL.internalGLES.glGetProgramBinaryOES = (dgtk.OpenGL.delegatesGLES.glGetProgramBinaryOES) InternalGLesTool.GetGLesMethodAdress("glGetProgramBinaryOES", typeof(dgtk.OpenGL.delegatesGLES.glGetProgramBinaryOES));
			}
			if (SuportedExt.Contains("glGetProgramPipelineInfoLogEXT"))
			{
				dgtk.OpenGL.internalGLES.glGetProgramPipelineInfoLogEXT = (dgtk.OpenGL.delegatesGLES.glGetProgramPipelineInfoLogEXT) InternalGLesTool.GetGLesMethodAdress("glGetProgramPipelineInfoLogEXT", typeof(dgtk.OpenGL.delegatesGLES.glGetProgramPipelineInfoLogEXT));
			}
			if (SuportedExt.Contains("glGetProgramPipelineivEXT"))
			{
				dgtk.OpenGL.internalGLES.glGetProgramPipelineivEXT = (dgtk.OpenGL.delegatesGLES.glGetProgramPipelineivEXT) InternalGLesTool.GetGLesMethodAdress("glGetProgramPipelineivEXT", typeof(dgtk.OpenGL.delegatesGLES.glGetProgramPipelineivEXT));
			}
			if (SuportedExt.Contains("glGetProgramResourcefvNV"))
			{
				dgtk.OpenGL.internalGLES.glGetProgramResourcefvNV = (dgtk.OpenGL.delegatesGLES.glGetProgramResourcefvNV) InternalGLesTool.GetGLesMethodAdress("glGetProgramResourcefvNV", typeof(dgtk.OpenGL.delegatesGLES.glGetProgramResourcefvNV));
			}
			if (SuportedExt.Contains("glGetProgramResourceLocationIndexEXT"))
			{
				dgtk.OpenGL.internalGLES.glGetProgramResourceLocationIndexEXT = (dgtk.OpenGL.delegatesGLES.glGetProgramResourceLocationIndexEXT) InternalGLesTool.GetGLesMethodAdress("glGetProgramResourceLocationIndexEXT", typeof(dgtk.OpenGL.delegatesGLES.glGetProgramResourceLocationIndexEXT));
			}
			if (SuportedExt.Contains("glGetQueryivEXT"))
			{
				dgtk.OpenGL.internalGLES.glGetQueryivEXT = (dgtk.OpenGL.delegatesGLES.glGetQueryivEXT) InternalGLesTool.GetGLesMethodAdress("glGetQueryivEXT", typeof(dgtk.OpenGL.delegatesGLES.glGetQueryivEXT));
			}
			if (SuportedExt.Contains("glGetQueryObjecti64vEXT"))
			{
				dgtk.OpenGL.internalGLES.glGetQueryObjecti64vEXT = (dgtk.OpenGL.delegatesGLES.glGetQueryObjecti64vEXT) InternalGLesTool.GetGLesMethodAdress("glGetQueryObjecti64vEXT", typeof(dgtk.OpenGL.delegatesGLES.glGetQueryObjecti64vEXT));
			}
			if (SuportedExt.Contains("glGetQueryObjectivEXT"))
			{
				dgtk.OpenGL.internalGLES.glGetQueryObjectivEXT = (dgtk.OpenGL.delegatesGLES.glGetQueryObjectivEXT) InternalGLesTool.GetGLesMethodAdress("glGetQueryObjectivEXT", typeof(dgtk.OpenGL.delegatesGLES.glGetQueryObjectivEXT));
			}
			if (SuportedExt.Contains("glGetQueryObjectui64vEXT"))
			{
				dgtk.OpenGL.internalGLES.glGetQueryObjectui64vEXT = (dgtk.OpenGL.delegatesGLES.glGetQueryObjectui64vEXT) InternalGLesTool.GetGLesMethodAdress("glGetQueryObjectui64vEXT", typeof(dgtk.OpenGL.delegatesGLES.glGetQueryObjectui64vEXT));
			}
			if (SuportedExt.Contains("glGetQueryObjectuivEXT"))
			{
				dgtk.OpenGL.internalGLES.glGetQueryObjectuivEXT = (dgtk.OpenGL.delegatesGLES.glGetQueryObjectuivEXT) InternalGLesTool.GetGLesMethodAdress("glGetQueryObjectuivEXT", typeof(dgtk.OpenGL.delegatesGLES.glGetQueryObjectuivEXT));
			}
			if (SuportedExt.Contains("glGetRenderbufferParameterivOES"))
			{
				dgtk.OpenGL.internalGLES.glGetRenderbufferParameterivOES = (dgtk.OpenGL.delegatesGLES.glGetRenderbufferParameterivOES) InternalGLesTool.GetGLesMethodAdress("glGetRenderbufferParameterivOES", typeof(dgtk.OpenGL.delegatesGLES.glGetRenderbufferParameterivOES));
			}
			if (SuportedExt.Contains("glGetSamplerParameterIivEXT"))
			{
				dgtk.OpenGL.internalGLES.glGetSamplerParameterIivEXT = (dgtk.OpenGL.delegatesGLES.glGetSamplerParameterIivEXT) InternalGLesTool.GetGLesMethodAdress("glGetSamplerParameterIivEXT", typeof(dgtk.OpenGL.delegatesGLES.glGetSamplerParameterIivEXT));
			}
			if (SuportedExt.Contains("glGetSamplerParameterIivOES"))
			{
				dgtk.OpenGL.internalGLES.glGetSamplerParameterIivOES = (dgtk.OpenGL.delegatesGLES.glGetSamplerParameterIivOES) InternalGLesTool.GetGLesMethodAdress("glGetSamplerParameterIivOES", typeof(dgtk.OpenGL.delegatesGLES.glGetSamplerParameterIivOES));
			}
			if (SuportedExt.Contains("glGetSamplerParameterIuivEXT"))
			{
				dgtk.OpenGL.internalGLES.glGetSamplerParameterIuivEXT = (dgtk.OpenGL.delegatesGLES.glGetSamplerParameterIuivEXT) InternalGLesTool.GetGLesMethodAdress("glGetSamplerParameterIuivEXT", typeof(dgtk.OpenGL.delegatesGLES.glGetSamplerParameterIuivEXT));
			}
			if (SuportedExt.Contains("glGetSamplerParameterIuivOES"))
			{
				dgtk.OpenGL.internalGLES.glGetSamplerParameterIuivOES = (dgtk.OpenGL.delegatesGLES.glGetSamplerParameterIuivOES) InternalGLesTool.GetGLesMethodAdress("glGetSamplerParameterIuivOES", typeof(dgtk.OpenGL.delegatesGLES.glGetSamplerParameterIuivOES));
			}
			if (SuportedExt.Contains("glGetSemaphoreParameterivNV"))
			{
				dgtk.OpenGL.internalGLES.glGetSemaphoreParameterivNV = (dgtk.OpenGL.delegatesGLES.glGetSemaphoreParameterivNV) InternalGLesTool.GetGLesMethodAdress("glGetSemaphoreParameterivNV", typeof(dgtk.OpenGL.delegatesGLES.glGetSemaphoreParameterivNV));
			}
			if (SuportedExt.Contains("glGetSemaphoreParameterui64vEXT"))
			{
				dgtk.OpenGL.internalGLES.glGetSemaphoreParameterui64vEXT = (dgtk.OpenGL.delegatesGLES.glGetSemaphoreParameterui64vEXT) InternalGLesTool.GetGLesMethodAdress("glGetSemaphoreParameterui64vEXT", typeof(dgtk.OpenGL.delegatesGLES.glGetSemaphoreParameterui64vEXT));
			}
			if (SuportedExt.Contains("glGetShadingRateImagePaletteNV"))
			{
				dgtk.OpenGL.internalGLES.glGetShadingRateImagePaletteNV = (dgtk.OpenGL.delegatesGLES.glGetShadingRateImagePaletteNV) InternalGLesTool.GetGLesMethodAdress("glGetShadingRateImagePaletteNV", typeof(dgtk.OpenGL.delegatesGLES.glGetShadingRateImagePaletteNV));
			}
			if (SuportedExt.Contains("glGetShadingRateSampleLocationivNV"))
			{
				dgtk.OpenGL.internalGLES.glGetShadingRateSampleLocationivNV = (dgtk.OpenGL.delegatesGLES.glGetShadingRateSampleLocationivNV) InternalGLesTool.GetGLesMethodAdress("glGetShadingRateSampleLocationivNV", typeof(dgtk.OpenGL.delegatesGLES.glGetShadingRateSampleLocationivNV));
			}
			if (SuportedExt.Contains("glGetSyncivAPPLE"))
			{
				dgtk.OpenGL.internalGLES.glGetSyncivAPPLE = (dgtk.OpenGL.delegatesGLES.glGetSyncivAPPLE) InternalGLesTool.GetGLesMethodAdress("glGetSyncivAPPLE", typeof(dgtk.OpenGL.delegatesGLES.glGetSyncivAPPLE));
			}
			if (SuportedExt.Contains("glGetTexEnvxvOES"))
			{
				dgtk.OpenGL.internalGLES.glGetTexEnvxvOES = (dgtk.OpenGL.delegatesGLES.glGetTexEnvxvOES) InternalGLesTool.GetGLesMethodAdress("glGetTexEnvxvOES", typeof(dgtk.OpenGL.delegatesGLES.glGetTexEnvxvOES));
			}
			if (SuportedExt.Contains("glGetTexGenfvOES"))
			{
				dgtk.OpenGL.internalGLES.glGetTexGenfvOES = (dgtk.OpenGL.delegatesGLES.glGetTexGenfvOES) InternalGLesTool.GetGLesMethodAdress("glGetTexGenfvOES", typeof(dgtk.OpenGL.delegatesGLES.glGetTexGenfvOES));
			}
			if (SuportedExt.Contains("glGetTexGenivOES"))
			{
				dgtk.OpenGL.internalGLES.glGetTexGenivOES = (dgtk.OpenGL.delegatesGLES.glGetTexGenivOES) InternalGLesTool.GetGLesMethodAdress("glGetTexGenivOES", typeof(dgtk.OpenGL.delegatesGLES.glGetTexGenivOES));
			}
			if (SuportedExt.Contains("glGetTexGenxvOES"))
			{
				dgtk.OpenGL.internalGLES.glGetTexGenxvOES = (dgtk.OpenGL.delegatesGLES.glGetTexGenxvOES) InternalGLesTool.GetGLesMethodAdress("glGetTexGenxvOES", typeof(dgtk.OpenGL.delegatesGLES.glGetTexGenxvOES));
			}
			if (SuportedExt.Contains("glGetTexLevelParameterxvOES"))
			{
				dgtk.OpenGL.internalGLES.glGetTexLevelParameterxvOES = (dgtk.OpenGL.delegatesGLES.glGetTexLevelParameterxvOES) InternalGLesTool.GetGLesMethodAdress("glGetTexLevelParameterxvOES", typeof(dgtk.OpenGL.delegatesGLES.glGetTexLevelParameterxvOES));
			}
			if (SuportedExt.Contains("glGetTexParameterIivEXT"))
			{
				dgtk.OpenGL.internalGLES.glGetTexParameterIivEXT = (dgtk.OpenGL.delegatesGLES.glGetTexParameterIivEXT) InternalGLesTool.GetGLesMethodAdress("glGetTexParameterIivEXT", typeof(dgtk.OpenGL.delegatesGLES.glGetTexParameterIivEXT));
			}
			if (SuportedExt.Contains("glGetTexParameterIivOES"))
			{
				dgtk.OpenGL.internalGLES.glGetTexParameterIivOES = (dgtk.OpenGL.delegatesGLES.glGetTexParameterIivOES) InternalGLesTool.GetGLesMethodAdress("glGetTexParameterIivOES", typeof(dgtk.OpenGL.delegatesGLES.glGetTexParameterIivOES));
			}
			if (SuportedExt.Contains("glGetTexParameterIuivEXT"))
			{
				dgtk.OpenGL.internalGLES.glGetTexParameterIuivEXT = (dgtk.OpenGL.delegatesGLES.glGetTexParameterIuivEXT) InternalGLesTool.GetGLesMethodAdress("glGetTexParameterIuivEXT", typeof(dgtk.OpenGL.delegatesGLES.glGetTexParameterIuivEXT));
			}
			if (SuportedExt.Contains("glGetTexParameterIuivOES"))
			{
				dgtk.OpenGL.internalGLES.glGetTexParameterIuivOES = (dgtk.OpenGL.delegatesGLES.glGetTexParameterIuivOES) InternalGLesTool.GetGLesMethodAdress("glGetTexParameterIuivOES", typeof(dgtk.OpenGL.delegatesGLES.glGetTexParameterIuivOES));
			}
			if (SuportedExt.Contains("glGetTexParameterxvOES"))
			{
				dgtk.OpenGL.internalGLES.glGetTexParameterxvOES = (dgtk.OpenGL.delegatesGLES.glGetTexParameterxvOES) InternalGLesTool.GetGLesMethodAdress("glGetTexParameterxvOES", typeof(dgtk.OpenGL.delegatesGLES.glGetTexParameterxvOES));
			}
			if (SuportedExt.Contains("glGetTextureHandleIMG"))
			{
				dgtk.OpenGL.internalGLES.glGetTextureHandleIMG = (dgtk.OpenGL.delegatesGLES.glGetTextureHandleIMG) InternalGLesTool.GetGLesMethodAdress("glGetTextureHandleIMG", typeof(dgtk.OpenGL.delegatesGLES.glGetTextureHandleIMG));
			}
			if (SuportedExt.Contains("glGetTextureHandleNV"))
			{
				dgtk.OpenGL.internalGLES.glGetTextureHandleNV = (dgtk.OpenGL.delegatesGLES.glGetTextureHandleNV) InternalGLesTool.GetGLesMethodAdress("glGetTextureHandleNV", typeof(dgtk.OpenGL.delegatesGLES.glGetTextureHandleNV));
			}
			if (SuportedExt.Contains("glGetTextureSamplerHandleIMG"))
			{
				dgtk.OpenGL.internalGLES.glGetTextureSamplerHandleIMG = (dgtk.OpenGL.delegatesGLES.glGetTextureSamplerHandleIMG) InternalGLesTool.GetGLesMethodAdress("glGetTextureSamplerHandleIMG", typeof(dgtk.OpenGL.delegatesGLES.glGetTextureSamplerHandleIMG));
			}
			if (SuportedExt.Contains("glGetTextureSamplerHandleNV"))
			{
				dgtk.OpenGL.internalGLES.glGetTextureSamplerHandleNV = (dgtk.OpenGL.delegatesGLES.glGetTextureSamplerHandleNV) InternalGLesTool.GetGLesMethodAdress("glGetTextureSamplerHandleNV", typeof(dgtk.OpenGL.delegatesGLES.glGetTextureSamplerHandleNV));
			}
			if (SuportedExt.Contains("glGetTranslatedShaderSourceANGLE"))
			{
				dgtk.OpenGL.internalGLES.glGetTranslatedShaderSourceANGLE = (dgtk.OpenGL.delegatesGLES.glGetTranslatedShaderSourceANGLE) InternalGLesTool.GetGLesMethodAdress("glGetTranslatedShaderSourceANGLE", typeof(dgtk.OpenGL.delegatesGLES.glGetTranslatedShaderSourceANGLE));
			}
			if (SuportedExt.Contains("glGetUniformi64vNV"))
			{
				dgtk.OpenGL.internalGLES.glGetUniformi64vNV = (dgtk.OpenGL.delegatesGLES.glGetUniformi64vNV) InternalGLesTool.GetGLesMethodAdress("glGetUniformi64vNV", typeof(dgtk.OpenGL.delegatesGLES.glGetUniformi64vNV));
			}
			if (SuportedExt.Contains("glGetUnsignedBytei_vEXT"))
			{
				dgtk.OpenGL.internalGLES.glGetUnsignedBytei_vEXT = (dgtk.OpenGL.delegatesGLES.glGetUnsignedBytei_vEXT) InternalGLesTool.GetGLesMethodAdress("glGetUnsignedBytei_vEXT", typeof(dgtk.OpenGL.delegatesGLES.glGetUnsignedBytei_vEXT));
			}
			if (SuportedExt.Contains("glGetUnsignedBytevEXT"))
			{
				dgtk.OpenGL.internalGLES.glGetUnsignedBytevEXT = (dgtk.OpenGL.delegatesGLES.glGetUnsignedBytevEXT) InternalGLesTool.GetGLesMethodAdress("glGetUnsignedBytevEXT", typeof(dgtk.OpenGL.delegatesGLES.glGetUnsignedBytevEXT));
			}
			if (SuportedExt.Contains("glGetVkProcAddrNV"))
			{
				dgtk.OpenGL.internalGLES.glGetVkProcAddrNV = (dgtk.OpenGL.delegatesGLES.glGetVkProcAddrNV) InternalGLesTool.GetGLesMethodAdress("glGetVkProcAddrNV", typeof(dgtk.OpenGL.delegatesGLES.glGetVkProcAddrNV));
			}
			#endregion

			#region I:

			if (SuportedExt.Contains("glImportMemoryFdEXT"))
			{
				dgtk.OpenGL.internalGLES.glImportMemoryFdEXT = (dgtk.OpenGL.delegatesGLES.glImportMemoryFdEXT) InternalGLesTool.GetGLesMethodAdress("glImportMemoryFdEXT", typeof(dgtk.OpenGL.delegatesGLES.glImportMemoryFdEXT));
			}
			if (SuportedExt.Contains("glImportMemoryWin32HandleEXT"))
			{
				dgtk.OpenGL.internalGLES.glImportMemoryWin32HandleEXT = (dgtk.OpenGL.delegatesGLES.glImportMemoryWin32HandleEXT) InternalGLesTool.GetGLesMethodAdress("glImportMemoryWin32HandleEXT", typeof(dgtk.OpenGL.delegatesGLES.glImportMemoryWin32HandleEXT));
			}
			if (SuportedExt.Contains("glImportMemoryWin32NameEXT"))
			{
				dgtk.OpenGL.internalGLES.glImportMemoryWin32NameEXT = (dgtk.OpenGL.delegatesGLES.glImportMemoryWin32NameEXT) InternalGLesTool.GetGLesMethodAdress("glImportMemoryWin32NameEXT", typeof(dgtk.OpenGL.delegatesGLES.glImportMemoryWin32NameEXT));
			}
			if (SuportedExt.Contains("glImportSemaphoreFdEXT"))
			{
				dgtk.OpenGL.internalGLES.glImportSemaphoreFdEXT = (dgtk.OpenGL.delegatesGLES.glImportSemaphoreFdEXT) InternalGLesTool.GetGLesMethodAdress("glImportSemaphoreFdEXT", typeof(dgtk.OpenGL.delegatesGLES.glImportSemaphoreFdEXT));
			}
			if (SuportedExt.Contains("glImportSemaphoreWin32HandleEXT"))
			{
				dgtk.OpenGL.internalGLES.glImportSemaphoreWin32HandleEXT = (dgtk.OpenGL.delegatesGLES.glImportSemaphoreWin32HandleEXT) InternalGLesTool.GetGLesMethodAdress("glImportSemaphoreWin32HandleEXT", typeof(dgtk.OpenGL.delegatesGLES.glImportSemaphoreWin32HandleEXT));
			}
			if (SuportedExt.Contains("glImportSemaphoreWin32NameEXT"))
			{
				dgtk.OpenGL.internalGLES.glImportSemaphoreWin32NameEXT = (dgtk.OpenGL.delegatesGLES.glImportSemaphoreWin32NameEXT) InternalGLesTool.GetGLesMethodAdress("glImportSemaphoreWin32NameEXT", typeof(dgtk.OpenGL.delegatesGLES.glImportSemaphoreWin32NameEXT));
			}
			if (SuportedExt.Contains("glIndexxOES"))
			{
				dgtk.OpenGL.internalGLES.glIndexxOES = (dgtk.OpenGL.delegatesGLES.glIndexxOES) InternalGLesTool.GetGLesMethodAdress("glIndexxOES", typeof(dgtk.OpenGL.delegatesGLES.glIndexxOES));
			}
			if (SuportedExt.Contains("glIndexxvOES"))
			{
				dgtk.OpenGL.internalGLES.glIndexxvOES = (dgtk.OpenGL.delegatesGLES.glIndexxvOES) InternalGLesTool.GetGLesMethodAdress("glIndexxvOES", typeof(dgtk.OpenGL.delegatesGLES.glIndexxvOES));
			}
			if (SuportedExt.Contains("glInsertEventMarkerEXT"))
			{
				dgtk.OpenGL.internalGLES.glInsertEventMarkerEXT = (dgtk.OpenGL.delegatesGLES.glInsertEventMarkerEXT) InternalGLesTool.GetGLesMethodAdress("glInsertEventMarkerEXT", typeof(dgtk.OpenGL.delegatesGLES.glInsertEventMarkerEXT));
			}
			if (SuportedExt.Contains("glInterpolatePathsNV"))
			{
				dgtk.OpenGL.internalGLES.glInterpolatePathsNV = (dgtk.OpenGL.delegatesGLES.glInterpolatePathsNV) InternalGLesTool.GetGLesMethodAdress("glInterpolatePathsNV", typeof(dgtk.OpenGL.delegatesGLES.glInterpolatePathsNV));
			}
			if (SuportedExt.Contains("glIsEnablediEXT"))
			{
				dgtk.OpenGL.internalGLES.glIsEnablediEXT = (dgtk.OpenGL.delegatesGLES.glIsEnablediEXT) InternalGLesTool.GetGLesMethodAdress("glIsEnablediEXT", typeof(dgtk.OpenGL.delegatesGLES.glIsEnablediEXT));
			}
			if (SuportedExt.Contains("glIsEnablediNV"))
			{
				dgtk.OpenGL.internalGLES.glIsEnablediNV = (dgtk.OpenGL.delegatesGLES.glIsEnablediNV) InternalGLesTool.GetGLesMethodAdress("glIsEnablediNV", typeof(dgtk.OpenGL.delegatesGLES.glIsEnablediNV));
			}
			if (SuportedExt.Contains("glIsEnablediOES"))
			{
				dgtk.OpenGL.internalGLES.glIsEnablediOES = (dgtk.OpenGL.delegatesGLES.glIsEnablediOES) InternalGLesTool.GetGLesMethodAdress("glIsEnablediOES", typeof(dgtk.OpenGL.delegatesGLES.glIsEnablediOES));
			}
			if (SuportedExt.Contains("glIsFenceNV"))
			{
				dgtk.OpenGL.internalGLES.glIsFenceNV = (dgtk.OpenGL.delegatesGLES.glIsFenceNV) InternalGLesTool.GetGLesMethodAdress("glIsFenceNV", typeof(dgtk.OpenGL.delegatesGLES.glIsFenceNV));
			}
			if (SuportedExt.Contains("glIsFramebufferOES"))
			{
				dgtk.OpenGL.internalGLES.glIsFramebufferOES = (dgtk.OpenGL.delegatesGLES.glIsFramebufferOES) InternalGLesTool.GetGLesMethodAdress("glIsFramebufferOES", typeof(dgtk.OpenGL.delegatesGLES.glIsFramebufferOES));
			}
			if (SuportedExt.Contains("glIsImageHandleResidentNV"))
			{
				dgtk.OpenGL.internalGLES.glIsImageHandleResidentNV = (dgtk.OpenGL.delegatesGLES.glIsImageHandleResidentNV) InternalGLesTool.GetGLesMethodAdress("glIsImageHandleResidentNV", typeof(dgtk.OpenGL.delegatesGLES.glIsImageHandleResidentNV));
			}
			if (SuportedExt.Contains("glIsMemoryObjectEXT"))
			{
				dgtk.OpenGL.internalGLES.glIsMemoryObjectEXT = (dgtk.OpenGL.delegatesGLES.glIsMemoryObjectEXT) InternalGLesTool.GetGLesMethodAdress("glIsMemoryObjectEXT", typeof(dgtk.OpenGL.delegatesGLES.glIsMemoryObjectEXT));
			}
			if (SuportedExt.Contains("glIsPathNV"))
			{
				dgtk.OpenGL.internalGLES.glIsPathNV = (dgtk.OpenGL.delegatesGLES.glIsPathNV) InternalGLesTool.GetGLesMethodAdress("glIsPathNV", typeof(dgtk.OpenGL.delegatesGLES.glIsPathNV));
			}
			if (SuportedExt.Contains("glIsPointInFillPathNV"))
			{
				dgtk.OpenGL.internalGLES.glIsPointInFillPathNV = (dgtk.OpenGL.delegatesGLES.glIsPointInFillPathNV) InternalGLesTool.GetGLesMethodAdress("glIsPointInFillPathNV", typeof(dgtk.OpenGL.delegatesGLES.glIsPointInFillPathNV));
			}
			if (SuportedExt.Contains("glIsPointInStrokePathNV"))
			{
				dgtk.OpenGL.internalGLES.glIsPointInStrokePathNV = (dgtk.OpenGL.delegatesGLES.glIsPointInStrokePathNV) InternalGLesTool.GetGLesMethodAdress("glIsPointInStrokePathNV", typeof(dgtk.OpenGL.delegatesGLES.glIsPointInStrokePathNV));
			}
			if (SuportedExt.Contains("glIsProgramPipelineEXT"))
			{
				dgtk.OpenGL.internalGLES.glIsProgramPipelineEXT = (dgtk.OpenGL.delegatesGLES.glIsProgramPipelineEXT) InternalGLesTool.GetGLesMethodAdress("glIsProgramPipelineEXT", typeof(dgtk.OpenGL.delegatesGLES.glIsProgramPipelineEXT));
			}
			if (SuportedExt.Contains("glIsQueryEXT"))
			{
				dgtk.OpenGL.internalGLES.glIsQueryEXT = (dgtk.OpenGL.delegatesGLES.glIsQueryEXT) InternalGLesTool.GetGLesMethodAdress("glIsQueryEXT", typeof(dgtk.OpenGL.delegatesGLES.glIsQueryEXT));
			}
			if (SuportedExt.Contains("glIsRenderbufferOES"))
			{
				dgtk.OpenGL.internalGLES.glIsRenderbufferOES = (dgtk.OpenGL.delegatesGLES.glIsRenderbufferOES) InternalGLesTool.GetGLesMethodAdress("glIsRenderbufferOES", typeof(dgtk.OpenGL.delegatesGLES.glIsRenderbufferOES));
			}
			if (SuportedExt.Contains("glIsSemaphoreEXT"))
			{
				dgtk.OpenGL.internalGLES.glIsSemaphoreEXT = (dgtk.OpenGL.delegatesGLES.glIsSemaphoreEXT) InternalGLesTool.GetGLesMethodAdress("glIsSemaphoreEXT", typeof(dgtk.OpenGL.delegatesGLES.glIsSemaphoreEXT));
			}
			if (SuportedExt.Contains("glIsSyncAPPLE"))
			{
				dgtk.OpenGL.internalGLES.glIsSyncAPPLE = (dgtk.OpenGL.delegatesGLES.glIsSyncAPPLE) InternalGLesTool.GetGLesMethodAdress("glIsSyncAPPLE", typeof(dgtk.OpenGL.delegatesGLES.glIsSyncAPPLE));
			}
			if (SuportedExt.Contains("glIsTextureHandleResidentNV"))
			{
				dgtk.OpenGL.internalGLES.glIsTextureHandleResidentNV = (dgtk.OpenGL.delegatesGLES.glIsTextureHandleResidentNV) InternalGLesTool.GetGLesMethodAdress("glIsTextureHandleResidentNV", typeof(dgtk.OpenGL.delegatesGLES.glIsTextureHandleResidentNV));
			}
			if (SuportedExt.Contains("glIsVertexArrayOES"))
			{
				dgtk.OpenGL.internalGLES.glIsVertexArrayOES = (dgtk.OpenGL.delegatesGLES.glIsVertexArrayOES) InternalGLesTool.GetGLesMethodAdress("glIsVertexArrayOES", typeof(dgtk.OpenGL.delegatesGLES.glIsVertexArrayOES));
			}
			#endregion

			#region L:

			if (SuportedExt.Contains("glLabelObjectEXT"))
			{
				dgtk.OpenGL.internalGLES.glLabelObjectEXT = (dgtk.OpenGL.delegatesGLES.glLabelObjectEXT) InternalGLesTool.GetGLesMethodAdress("glLabelObjectEXT", typeof(dgtk.OpenGL.delegatesGLES.glLabelObjectEXT));
			}
			if (SuportedExt.Contains("glLightModelxOES"))
			{
				dgtk.OpenGL.internalGLES.glLightModelxOES = (dgtk.OpenGL.delegatesGLES.glLightModelxOES) InternalGLesTool.GetGLesMethodAdress("glLightModelxOES", typeof(dgtk.OpenGL.delegatesGLES.glLightModelxOES));
			}
			if (SuportedExt.Contains("glLightModelxvOES"))
			{
				dgtk.OpenGL.internalGLES.glLightModelxvOES = (dgtk.OpenGL.delegatesGLES.glLightModelxvOES) InternalGLesTool.GetGLesMethodAdress("glLightModelxvOES", typeof(dgtk.OpenGL.delegatesGLES.glLightModelxvOES));
			}
			if (SuportedExt.Contains("glLightxOES"))
			{
				dgtk.OpenGL.internalGLES.glLightxOES = (dgtk.OpenGL.delegatesGLES.glLightxOES) InternalGLesTool.GetGLesMethodAdress("glLightxOES", typeof(dgtk.OpenGL.delegatesGLES.glLightxOES));
			}
			if (SuportedExt.Contains("glLightxvOES"))
			{
				dgtk.OpenGL.internalGLES.glLightxvOES = (dgtk.OpenGL.delegatesGLES.glLightxvOES) InternalGLesTool.GetGLesMethodAdress("glLightxvOES", typeof(dgtk.OpenGL.delegatesGLES.glLightxvOES));
			}
			if (SuportedExt.Contains("glLineWidthxOES"))
			{
				dgtk.OpenGL.internalGLES.glLineWidthxOES = (dgtk.OpenGL.delegatesGLES.glLineWidthxOES) InternalGLesTool.GetGLesMethodAdress("glLineWidthxOES", typeof(dgtk.OpenGL.delegatesGLES.glLineWidthxOES));
			}
			if (SuportedExt.Contains("glLoadMatrixxOES"))
			{
				dgtk.OpenGL.internalGLES.glLoadMatrixxOES = (dgtk.OpenGL.delegatesGLES.glLoadMatrixxOES) InternalGLesTool.GetGLesMethodAdress("glLoadMatrixxOES", typeof(dgtk.OpenGL.delegatesGLES.glLoadMatrixxOES));
			}
			if (SuportedExt.Contains("glLoadPaletteFromModelViewMatrixOES"))
			{
				dgtk.OpenGL.internalGLES.glLoadPaletteFromModelViewMatrixOES = (dgtk.OpenGL.delegatesGLES.glLoadPaletteFromModelViewMatrixOES) InternalGLesTool.GetGLesMethodAdress("glLoadPaletteFromModelViewMatrixOES", typeof(dgtk.OpenGL.delegatesGLES.glLoadPaletteFromModelViewMatrixOES));
			}
			if (SuportedExt.Contains("glLoadTransposeMatrixxOES"))
			{
				dgtk.OpenGL.internalGLES.glLoadTransposeMatrixxOES = (dgtk.OpenGL.delegatesGLES.glLoadTransposeMatrixxOES) InternalGLesTool.GetGLesMethodAdress("glLoadTransposeMatrixxOES", typeof(dgtk.OpenGL.delegatesGLES.glLoadTransposeMatrixxOES));
			}
			#endregion

			#region M:

			if (SuportedExt.Contains("glMakeImageHandleNonResidentNV"))
			{
				dgtk.OpenGL.internalGLES.glMakeImageHandleNonResidentNV = (dgtk.OpenGL.delegatesGLES.glMakeImageHandleNonResidentNV) InternalGLesTool.GetGLesMethodAdress("glMakeImageHandleNonResidentNV", typeof(dgtk.OpenGL.delegatesGLES.glMakeImageHandleNonResidentNV));
			}
			if (SuportedExt.Contains("glMakeImageHandleResidentNV"))
			{
				dgtk.OpenGL.internalGLES.glMakeImageHandleResidentNV = (dgtk.OpenGL.delegatesGLES.glMakeImageHandleResidentNV) InternalGLesTool.GetGLesMethodAdress("glMakeImageHandleResidentNV", typeof(dgtk.OpenGL.delegatesGLES.glMakeImageHandleResidentNV));
			}
			if (SuportedExt.Contains("glMakeTextureHandleNonResidentNV"))
			{
				dgtk.OpenGL.internalGLES.glMakeTextureHandleNonResidentNV = (dgtk.OpenGL.delegatesGLES.glMakeTextureHandleNonResidentNV) InternalGLesTool.GetGLesMethodAdress("glMakeTextureHandleNonResidentNV", typeof(dgtk.OpenGL.delegatesGLES.glMakeTextureHandleNonResidentNV));
			}
			if (SuportedExt.Contains("glMakeTextureHandleResidentNV"))
			{
				dgtk.OpenGL.internalGLES.glMakeTextureHandleResidentNV = (dgtk.OpenGL.delegatesGLES.glMakeTextureHandleResidentNV) InternalGLesTool.GetGLesMethodAdress("glMakeTextureHandleResidentNV", typeof(dgtk.OpenGL.delegatesGLES.glMakeTextureHandleResidentNV));
			}
			if (SuportedExt.Contains("glMap1xOES"))
			{
				dgtk.OpenGL.internalGLES.glMap1xOES = (dgtk.OpenGL.delegatesGLES.glMap1xOES) InternalGLesTool.GetGLesMethodAdress("glMap1xOES", typeof(dgtk.OpenGL.delegatesGLES.glMap1xOES));
			}
			if (SuportedExt.Contains("glMap2xOES"))
			{
				dgtk.OpenGL.internalGLES.glMap2xOES = (dgtk.OpenGL.delegatesGLES.glMap2xOES) InternalGLesTool.GetGLesMethodAdress("glMap2xOES", typeof(dgtk.OpenGL.delegatesGLES.glMap2xOES));
			}
			if (SuportedExt.Contains("glMapBufferOES"))
			{
				dgtk.OpenGL.internalGLES.glMapBufferOES = (dgtk.OpenGL.delegatesGLES.glMapBufferOES) InternalGLesTool.GetGLesMethodAdress("glMapBufferOES", typeof(dgtk.OpenGL.delegatesGLES.glMapBufferOES));
			}
			if (SuportedExt.Contains("glMapBufferRangeEXT"))
			{
				dgtk.OpenGL.internalGLES.glMapBufferRangeEXT = (dgtk.OpenGL.delegatesGLES.glMapBufferRangeEXT) InternalGLesTool.GetGLesMethodAdress("glMapBufferRangeEXT", typeof(dgtk.OpenGL.delegatesGLES.glMapBufferRangeEXT));
			}
			if (SuportedExt.Contains("glMapGrid1xOES"))
			{
				dgtk.OpenGL.internalGLES.glMapGrid1xOES = (dgtk.OpenGL.delegatesGLES.glMapGrid1xOES) InternalGLesTool.GetGLesMethodAdress("glMapGrid1xOES", typeof(dgtk.OpenGL.delegatesGLES.glMapGrid1xOES));
			}
			if (SuportedExt.Contains("glMapGrid2xOES"))
			{
				dgtk.OpenGL.internalGLES.glMapGrid2xOES = (dgtk.OpenGL.delegatesGLES.glMapGrid2xOES) InternalGLesTool.GetGLesMethodAdress("glMapGrid2xOES", typeof(dgtk.OpenGL.delegatesGLES.glMapGrid2xOES));
			}
			if (SuportedExt.Contains("glMaterialxOES"))
			{
				dgtk.OpenGL.internalGLES.glMaterialxOES = (dgtk.OpenGL.delegatesGLES.glMaterialxOES) InternalGLesTool.GetGLesMethodAdress("glMaterialxOES", typeof(dgtk.OpenGL.delegatesGLES.glMaterialxOES));
			}
			if (SuportedExt.Contains("glMaterialxvOES"))
			{
				dgtk.OpenGL.internalGLES.glMaterialxvOES = (dgtk.OpenGL.delegatesGLES.glMaterialxvOES) InternalGLesTool.GetGLesMethodAdress("glMaterialxvOES", typeof(dgtk.OpenGL.delegatesGLES.glMaterialxvOES));
			}
			if (SuportedExt.Contains("glMatrixFrustumEXT"))
			{
				dgtk.OpenGL.internalGLES.glMatrixFrustumEXT = (dgtk.OpenGL.delegatesGLES.glMatrixFrustumEXT) InternalGLesTool.GetGLesMethodAdress("glMatrixFrustumEXT", typeof(dgtk.OpenGL.delegatesGLES.glMatrixFrustumEXT));
			}
			if (SuportedExt.Contains("glMatrixIndexPointerOES"))
			{
				dgtk.OpenGL.internalGLES.glMatrixIndexPointerOES = (dgtk.OpenGL.delegatesGLES.glMatrixIndexPointerOES) InternalGLesTool.GetGLesMethodAdress("glMatrixIndexPointerOES", typeof(dgtk.OpenGL.delegatesGLES.glMatrixIndexPointerOES));
			}
			if (SuportedExt.Contains("glMatrixLoad3x2fNV"))
			{
				dgtk.OpenGL.internalGLES.glMatrixLoad3x2fNV = (dgtk.OpenGL.delegatesGLES.glMatrixLoad3x2fNV) InternalGLesTool.GetGLesMethodAdress("glMatrixLoad3x2fNV", typeof(dgtk.OpenGL.delegatesGLES.glMatrixLoad3x2fNV));
			}
			if (SuportedExt.Contains("glMatrixLoad3x3fNV"))
			{
				dgtk.OpenGL.internalGLES.glMatrixLoad3x3fNV = (dgtk.OpenGL.delegatesGLES.glMatrixLoad3x3fNV) InternalGLesTool.GetGLesMethodAdress("glMatrixLoad3x3fNV", typeof(dgtk.OpenGL.delegatesGLES.glMatrixLoad3x3fNV));
			}
			if (SuportedExt.Contains("glMatrixLoaddEXT"))
			{
				dgtk.OpenGL.internalGLES.glMatrixLoaddEXT = (dgtk.OpenGL.delegatesGLES.glMatrixLoaddEXT) InternalGLesTool.GetGLesMethodAdress("glMatrixLoaddEXT", typeof(dgtk.OpenGL.delegatesGLES.glMatrixLoaddEXT));
			}
			if (SuportedExt.Contains("glMatrixLoadfEXT"))
			{
				dgtk.OpenGL.internalGLES.glMatrixLoadfEXT = (dgtk.OpenGL.delegatesGLES.glMatrixLoadfEXT) InternalGLesTool.GetGLesMethodAdress("glMatrixLoadfEXT", typeof(dgtk.OpenGL.delegatesGLES.glMatrixLoadfEXT));
			}
			if (SuportedExt.Contains("glMatrixLoadIdentityEXT"))
			{
				dgtk.OpenGL.internalGLES.glMatrixLoadIdentityEXT = (dgtk.OpenGL.delegatesGLES.glMatrixLoadIdentityEXT) InternalGLesTool.GetGLesMethodAdress("glMatrixLoadIdentityEXT", typeof(dgtk.OpenGL.delegatesGLES.glMatrixLoadIdentityEXT));
			}
			if (SuportedExt.Contains("glMatrixLoadTranspose3x3fNV"))
			{
				dgtk.OpenGL.internalGLES.glMatrixLoadTranspose3x3fNV = (dgtk.OpenGL.delegatesGLES.glMatrixLoadTranspose3x3fNV) InternalGLesTool.GetGLesMethodAdress("glMatrixLoadTranspose3x3fNV", typeof(dgtk.OpenGL.delegatesGLES.glMatrixLoadTranspose3x3fNV));
			}
			if (SuportedExt.Contains("glMatrixLoadTransposedEXT"))
			{
				dgtk.OpenGL.internalGLES.glMatrixLoadTransposedEXT = (dgtk.OpenGL.delegatesGLES.glMatrixLoadTransposedEXT) InternalGLesTool.GetGLesMethodAdress("glMatrixLoadTransposedEXT", typeof(dgtk.OpenGL.delegatesGLES.glMatrixLoadTransposedEXT));
			}
			if (SuportedExt.Contains("glMatrixLoadTransposefEXT"))
			{
				dgtk.OpenGL.internalGLES.glMatrixLoadTransposefEXT = (dgtk.OpenGL.delegatesGLES.glMatrixLoadTransposefEXT) InternalGLesTool.GetGLesMethodAdress("glMatrixLoadTransposefEXT", typeof(dgtk.OpenGL.delegatesGLES.glMatrixLoadTransposefEXT));
			}
			if (SuportedExt.Contains("glMatrixMult3x2fNV"))
			{
				dgtk.OpenGL.internalGLES.glMatrixMult3x2fNV = (dgtk.OpenGL.delegatesGLES.glMatrixMult3x2fNV) InternalGLesTool.GetGLesMethodAdress("glMatrixMult3x2fNV", typeof(dgtk.OpenGL.delegatesGLES.glMatrixMult3x2fNV));
			}
			if (SuportedExt.Contains("glMatrixMult3x3fNV"))
			{
				dgtk.OpenGL.internalGLES.glMatrixMult3x3fNV = (dgtk.OpenGL.delegatesGLES.glMatrixMult3x3fNV) InternalGLesTool.GetGLesMethodAdress("glMatrixMult3x3fNV", typeof(dgtk.OpenGL.delegatesGLES.glMatrixMult3x3fNV));
			}
			if (SuportedExt.Contains("glMatrixMultdEXT"))
			{
				dgtk.OpenGL.internalGLES.glMatrixMultdEXT = (dgtk.OpenGL.delegatesGLES.glMatrixMultdEXT) InternalGLesTool.GetGLesMethodAdress("glMatrixMultdEXT", typeof(dgtk.OpenGL.delegatesGLES.glMatrixMultdEXT));
			}
			if (SuportedExt.Contains("glMatrixMultfEXT"))
			{
				dgtk.OpenGL.internalGLES.glMatrixMultfEXT = (dgtk.OpenGL.delegatesGLES.glMatrixMultfEXT) InternalGLesTool.GetGLesMethodAdress("glMatrixMultfEXT", typeof(dgtk.OpenGL.delegatesGLES.glMatrixMultfEXT));
			}
			if (SuportedExt.Contains("glMatrixMultTranspose3x3fNV"))
			{
				dgtk.OpenGL.internalGLES.glMatrixMultTranspose3x3fNV = (dgtk.OpenGL.delegatesGLES.glMatrixMultTranspose3x3fNV) InternalGLesTool.GetGLesMethodAdress("glMatrixMultTranspose3x3fNV", typeof(dgtk.OpenGL.delegatesGLES.glMatrixMultTranspose3x3fNV));
			}
			if (SuportedExt.Contains("glMatrixMultTransposedEXT"))
			{
				dgtk.OpenGL.internalGLES.glMatrixMultTransposedEXT = (dgtk.OpenGL.delegatesGLES.glMatrixMultTransposedEXT) InternalGLesTool.GetGLesMethodAdress("glMatrixMultTransposedEXT", typeof(dgtk.OpenGL.delegatesGLES.glMatrixMultTransposedEXT));
			}
			if (SuportedExt.Contains("glMatrixMultTransposefEXT"))
			{
				dgtk.OpenGL.internalGLES.glMatrixMultTransposefEXT = (dgtk.OpenGL.delegatesGLES.glMatrixMultTransposefEXT) InternalGLesTool.GetGLesMethodAdress("glMatrixMultTransposefEXT", typeof(dgtk.OpenGL.delegatesGLES.glMatrixMultTransposefEXT));
			}
			if (SuportedExt.Contains("glMatrixOrthoEXT"))
			{
				dgtk.OpenGL.internalGLES.glMatrixOrthoEXT = (dgtk.OpenGL.delegatesGLES.glMatrixOrthoEXT) InternalGLesTool.GetGLesMethodAdress("glMatrixOrthoEXT", typeof(dgtk.OpenGL.delegatesGLES.glMatrixOrthoEXT));
			}
			if (SuportedExt.Contains("glMatrixPopEXT"))
			{
				dgtk.OpenGL.internalGLES.glMatrixPopEXT = (dgtk.OpenGL.delegatesGLES.glMatrixPopEXT) InternalGLesTool.GetGLesMethodAdress("glMatrixPopEXT", typeof(dgtk.OpenGL.delegatesGLES.glMatrixPopEXT));
			}
			if (SuportedExt.Contains("glMatrixPushEXT"))
			{
				dgtk.OpenGL.internalGLES.glMatrixPushEXT = (dgtk.OpenGL.delegatesGLES.glMatrixPushEXT) InternalGLesTool.GetGLesMethodAdress("glMatrixPushEXT", typeof(dgtk.OpenGL.delegatesGLES.glMatrixPushEXT));
			}
			if (SuportedExt.Contains("glMatrixRotatedEXT"))
			{
				dgtk.OpenGL.internalGLES.glMatrixRotatedEXT = (dgtk.OpenGL.delegatesGLES.glMatrixRotatedEXT) InternalGLesTool.GetGLesMethodAdress("glMatrixRotatedEXT", typeof(dgtk.OpenGL.delegatesGLES.glMatrixRotatedEXT));
			}
			if (SuportedExt.Contains("glMatrixRotatefEXT"))
			{
				dgtk.OpenGL.internalGLES.glMatrixRotatefEXT = (dgtk.OpenGL.delegatesGLES.glMatrixRotatefEXT) InternalGLesTool.GetGLesMethodAdress("glMatrixRotatefEXT", typeof(dgtk.OpenGL.delegatesGLES.glMatrixRotatefEXT));
			}
			if (SuportedExt.Contains("glMatrixScaledEXT"))
			{
				dgtk.OpenGL.internalGLES.glMatrixScaledEXT = (dgtk.OpenGL.delegatesGLES.glMatrixScaledEXT) InternalGLesTool.GetGLesMethodAdress("glMatrixScaledEXT", typeof(dgtk.OpenGL.delegatesGLES.glMatrixScaledEXT));
			}
			if (SuportedExt.Contains("glMatrixScalefEXT"))
			{
				dgtk.OpenGL.internalGLES.glMatrixScalefEXT = (dgtk.OpenGL.delegatesGLES.glMatrixScalefEXT) InternalGLesTool.GetGLesMethodAdress("glMatrixScalefEXT", typeof(dgtk.OpenGL.delegatesGLES.glMatrixScalefEXT));
			}
			if (SuportedExt.Contains("glMatrixTranslatedEXT"))
			{
				dgtk.OpenGL.internalGLES.glMatrixTranslatedEXT = (dgtk.OpenGL.delegatesGLES.glMatrixTranslatedEXT) InternalGLesTool.GetGLesMethodAdress("glMatrixTranslatedEXT", typeof(dgtk.OpenGL.delegatesGLES.glMatrixTranslatedEXT));
			}
			if (SuportedExt.Contains("glMatrixTranslatefEXT"))
			{
				dgtk.OpenGL.internalGLES.glMatrixTranslatefEXT = (dgtk.OpenGL.delegatesGLES.glMatrixTranslatefEXT) InternalGLesTool.GetGLesMethodAdress("glMatrixTranslatefEXT", typeof(dgtk.OpenGL.delegatesGLES.glMatrixTranslatefEXT));
			}
			if (SuportedExt.Contains("glMaxActiveShaderCoresARM"))
			{
				dgtk.OpenGL.internalGLES.glMaxActiveShaderCoresARM = (dgtk.OpenGL.delegatesGLES.glMaxActiveShaderCoresARM) InternalGLesTool.GetGLesMethodAdress("glMaxActiveShaderCoresARM", typeof(dgtk.OpenGL.delegatesGLES.glMaxActiveShaderCoresARM));
			}
			if (SuportedExt.Contains("glMaxShaderCompilerThreadsKHR"))
			{
				dgtk.OpenGL.internalGLES.glMaxShaderCompilerThreadsKHR = (dgtk.OpenGL.delegatesGLES.glMaxShaderCompilerThreadsKHR) InternalGLesTool.GetGLesMethodAdress("glMaxShaderCompilerThreadsKHR", typeof(dgtk.OpenGL.delegatesGLES.glMaxShaderCompilerThreadsKHR));
			}
			if (SuportedExt.Contains("glMemoryObjectParameterivEXT"))
			{
				dgtk.OpenGL.internalGLES.glMemoryObjectParameterivEXT = (dgtk.OpenGL.delegatesGLES.glMemoryObjectParameterivEXT) InternalGLesTool.GetGLesMethodAdress("glMemoryObjectParameterivEXT", typeof(dgtk.OpenGL.delegatesGLES.glMemoryObjectParameterivEXT));
			}
			if (SuportedExt.Contains("glMinSampleShadingOES"))
			{
				dgtk.OpenGL.internalGLES.glMinSampleShadingOES = (dgtk.OpenGL.delegatesGLES.glMinSampleShadingOES) InternalGLesTool.GetGLesMethodAdress("glMinSampleShadingOES", typeof(dgtk.OpenGL.delegatesGLES.glMinSampleShadingOES));
			}
			if (SuportedExt.Contains("glMultiDrawArraysEXT"))
			{
				dgtk.OpenGL.internalGLES.glMultiDrawArraysEXT = (dgtk.OpenGL.delegatesGLES.glMultiDrawArraysEXT) InternalGLesTool.GetGLesMethodAdress("glMultiDrawArraysEXT", typeof(dgtk.OpenGL.delegatesGLES.glMultiDrawArraysEXT));
			}
			if (SuportedExt.Contains("glMultiDrawArraysIndirectEXT"))
			{
				dgtk.OpenGL.internalGLES.glMultiDrawArraysIndirectEXT = (dgtk.OpenGL.delegatesGLES.glMultiDrawArraysIndirectEXT) InternalGLesTool.GetGLesMethodAdress("glMultiDrawArraysIndirectEXT", typeof(dgtk.OpenGL.delegatesGLES.glMultiDrawArraysIndirectEXT));
			}
			if (SuportedExt.Contains("glMultiDrawElementsBaseVertexEXT"))
			{
				dgtk.OpenGL.internalGLES.glMultiDrawElementsBaseVertexEXT = (dgtk.OpenGL.delegatesGLES.glMultiDrawElementsBaseVertexEXT) InternalGLesTool.GetGLesMethodAdress("glMultiDrawElementsBaseVertexEXT", typeof(dgtk.OpenGL.delegatesGLES.glMultiDrawElementsBaseVertexEXT));
			}
			if (SuportedExt.Contains("glMultiDrawElementsEXT"))
			{
				dgtk.OpenGL.internalGLES.glMultiDrawElementsEXT = (dgtk.OpenGL.delegatesGLES.glMultiDrawElementsEXT) InternalGLesTool.GetGLesMethodAdress("glMultiDrawElementsEXT", typeof(dgtk.OpenGL.delegatesGLES.glMultiDrawElementsEXT));
			}
			if (SuportedExt.Contains("glMultiDrawElementsIndirectEXT"))
			{
				dgtk.OpenGL.internalGLES.glMultiDrawElementsIndirectEXT = (dgtk.OpenGL.delegatesGLES.glMultiDrawElementsIndirectEXT) InternalGLesTool.GetGLesMethodAdress("glMultiDrawElementsIndirectEXT", typeof(dgtk.OpenGL.delegatesGLES.glMultiDrawElementsIndirectEXT));
			}
			if (SuportedExt.Contains("glMultiDrawMeshTasksIndirectCountNV"))
			{
				dgtk.OpenGL.internalGLES.glMultiDrawMeshTasksIndirectCountNV = (dgtk.OpenGL.delegatesGLES.glMultiDrawMeshTasksIndirectCountNV) InternalGLesTool.GetGLesMethodAdress("glMultiDrawMeshTasksIndirectCountNV", typeof(dgtk.OpenGL.delegatesGLES.glMultiDrawMeshTasksIndirectCountNV));
			}
			if (SuportedExt.Contains("glMultiDrawMeshTasksIndirectNV"))
			{
				dgtk.OpenGL.internalGLES.glMultiDrawMeshTasksIndirectNV = (dgtk.OpenGL.delegatesGLES.glMultiDrawMeshTasksIndirectNV) InternalGLesTool.GetGLesMethodAdress("glMultiDrawMeshTasksIndirectNV", typeof(dgtk.OpenGL.delegatesGLES.glMultiDrawMeshTasksIndirectNV));
			}
			if (SuportedExt.Contains("glMultiTexCoord1bOES"))
			{
				dgtk.OpenGL.internalGLES.glMultiTexCoord1bOES = (dgtk.OpenGL.delegatesGLES.glMultiTexCoord1bOES) InternalGLesTool.GetGLesMethodAdress("glMultiTexCoord1bOES", typeof(dgtk.OpenGL.delegatesGLES.glMultiTexCoord1bOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord1bvOES"))
			{
				dgtk.OpenGL.internalGLES.glMultiTexCoord1bvOES = (dgtk.OpenGL.delegatesGLES.glMultiTexCoord1bvOES) InternalGLesTool.GetGLesMethodAdress("glMultiTexCoord1bvOES", typeof(dgtk.OpenGL.delegatesGLES.glMultiTexCoord1bvOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord1xOES"))
			{
				dgtk.OpenGL.internalGLES.glMultiTexCoord1xOES = (dgtk.OpenGL.delegatesGLES.glMultiTexCoord1xOES) InternalGLesTool.GetGLesMethodAdress("glMultiTexCoord1xOES", typeof(dgtk.OpenGL.delegatesGLES.glMultiTexCoord1xOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord1xvOES"))
			{
				dgtk.OpenGL.internalGLES.glMultiTexCoord1xvOES = (dgtk.OpenGL.delegatesGLES.glMultiTexCoord1xvOES) InternalGLesTool.GetGLesMethodAdress("glMultiTexCoord1xvOES", typeof(dgtk.OpenGL.delegatesGLES.glMultiTexCoord1xvOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord2bOES"))
			{
				dgtk.OpenGL.internalGLES.glMultiTexCoord2bOES = (dgtk.OpenGL.delegatesGLES.glMultiTexCoord2bOES) InternalGLesTool.GetGLesMethodAdress("glMultiTexCoord2bOES", typeof(dgtk.OpenGL.delegatesGLES.glMultiTexCoord2bOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord2bvOES"))
			{
				dgtk.OpenGL.internalGLES.glMultiTexCoord2bvOES = (dgtk.OpenGL.delegatesGLES.glMultiTexCoord2bvOES) InternalGLesTool.GetGLesMethodAdress("glMultiTexCoord2bvOES", typeof(dgtk.OpenGL.delegatesGLES.glMultiTexCoord2bvOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord2xOES"))
			{
				dgtk.OpenGL.internalGLES.glMultiTexCoord2xOES = (dgtk.OpenGL.delegatesGLES.glMultiTexCoord2xOES) InternalGLesTool.GetGLesMethodAdress("glMultiTexCoord2xOES", typeof(dgtk.OpenGL.delegatesGLES.glMultiTexCoord2xOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord2xvOES"))
			{
				dgtk.OpenGL.internalGLES.glMultiTexCoord2xvOES = (dgtk.OpenGL.delegatesGLES.glMultiTexCoord2xvOES) InternalGLesTool.GetGLesMethodAdress("glMultiTexCoord2xvOES", typeof(dgtk.OpenGL.delegatesGLES.glMultiTexCoord2xvOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord3bOES"))
			{
				dgtk.OpenGL.internalGLES.glMultiTexCoord3bOES = (dgtk.OpenGL.delegatesGLES.glMultiTexCoord3bOES) InternalGLesTool.GetGLesMethodAdress("glMultiTexCoord3bOES", typeof(dgtk.OpenGL.delegatesGLES.glMultiTexCoord3bOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord3bvOES"))
			{
				dgtk.OpenGL.internalGLES.glMultiTexCoord3bvOES = (dgtk.OpenGL.delegatesGLES.glMultiTexCoord3bvOES) InternalGLesTool.GetGLesMethodAdress("glMultiTexCoord3bvOES", typeof(dgtk.OpenGL.delegatesGLES.glMultiTexCoord3bvOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord3xOES"))
			{
				dgtk.OpenGL.internalGLES.glMultiTexCoord3xOES = (dgtk.OpenGL.delegatesGLES.glMultiTexCoord3xOES) InternalGLesTool.GetGLesMethodAdress("glMultiTexCoord3xOES", typeof(dgtk.OpenGL.delegatesGLES.glMultiTexCoord3xOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord3xvOES"))
			{
				dgtk.OpenGL.internalGLES.glMultiTexCoord3xvOES = (dgtk.OpenGL.delegatesGLES.glMultiTexCoord3xvOES) InternalGLesTool.GetGLesMethodAdress("glMultiTexCoord3xvOES", typeof(dgtk.OpenGL.delegatesGLES.glMultiTexCoord3xvOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord4bOES"))
			{
				dgtk.OpenGL.internalGLES.glMultiTexCoord4bOES = (dgtk.OpenGL.delegatesGLES.glMultiTexCoord4bOES) InternalGLesTool.GetGLesMethodAdress("glMultiTexCoord4bOES", typeof(dgtk.OpenGL.delegatesGLES.glMultiTexCoord4bOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord4bvOES"))
			{
				dgtk.OpenGL.internalGLES.glMultiTexCoord4bvOES = (dgtk.OpenGL.delegatesGLES.glMultiTexCoord4bvOES) InternalGLesTool.GetGLesMethodAdress("glMultiTexCoord4bvOES", typeof(dgtk.OpenGL.delegatesGLES.glMultiTexCoord4bvOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord4xOES"))
			{
				dgtk.OpenGL.internalGLES.glMultiTexCoord4xOES = (dgtk.OpenGL.delegatesGLES.glMultiTexCoord4xOES) InternalGLesTool.GetGLesMethodAdress("glMultiTexCoord4xOES", typeof(dgtk.OpenGL.delegatesGLES.glMultiTexCoord4xOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord4xvOES"))
			{
				dgtk.OpenGL.internalGLES.glMultiTexCoord4xvOES = (dgtk.OpenGL.delegatesGLES.glMultiTexCoord4xvOES) InternalGLesTool.GetGLesMethodAdress("glMultiTexCoord4xvOES", typeof(dgtk.OpenGL.delegatesGLES.glMultiTexCoord4xvOES));
			}
			if (SuportedExt.Contains("glMultMatrixxOES"))
			{
				dgtk.OpenGL.internalGLES.glMultMatrixxOES = (dgtk.OpenGL.delegatesGLES.glMultMatrixxOES) InternalGLesTool.GetGLesMethodAdress("glMultMatrixxOES", typeof(dgtk.OpenGL.delegatesGLES.glMultMatrixxOES));
			}
			if (SuportedExt.Contains("glMultTransposeMatrixxOES"))
			{
				dgtk.OpenGL.internalGLES.glMultTransposeMatrixxOES = (dgtk.OpenGL.delegatesGLES.glMultTransposeMatrixxOES) InternalGLesTool.GetGLesMethodAdress("glMultTransposeMatrixxOES", typeof(dgtk.OpenGL.delegatesGLES.glMultTransposeMatrixxOES));
			}
			#endregion

			#region N:

			if (SuportedExt.Contains("glNamedBufferAttachMemoryNV"))
			{
				dgtk.OpenGL.internalGLES.glNamedBufferAttachMemoryNV = (dgtk.OpenGL.delegatesGLES.glNamedBufferAttachMemoryNV) InternalGLesTool.GetGLesMethodAdress("glNamedBufferAttachMemoryNV", typeof(dgtk.OpenGL.delegatesGLES.glNamedBufferAttachMemoryNV));
			}
			if (SuportedExt.Contains("glNamedBufferPageCommitmentMemNV"))
			{
				dgtk.OpenGL.internalGLES.glNamedBufferPageCommitmentMemNV = (dgtk.OpenGL.delegatesGLES.glNamedBufferPageCommitmentMemNV) InternalGLesTool.GetGLesMethodAdress("glNamedBufferPageCommitmentMemNV", typeof(dgtk.OpenGL.delegatesGLES.glNamedBufferPageCommitmentMemNV));
			}
			if (SuportedExt.Contains("glNamedBufferStorageExternalEXT"))
			{
				dgtk.OpenGL.internalGLES.glNamedBufferStorageExternalEXT = (dgtk.OpenGL.delegatesGLES.glNamedBufferStorageExternalEXT) InternalGLesTool.GetGLesMethodAdress("glNamedBufferStorageExternalEXT", typeof(dgtk.OpenGL.delegatesGLES.glNamedBufferStorageExternalEXT));
			}
			if (SuportedExt.Contains("glNamedBufferStorageMemEXT"))
			{
				dgtk.OpenGL.internalGLES.glNamedBufferStorageMemEXT = (dgtk.OpenGL.delegatesGLES.glNamedBufferStorageMemEXT) InternalGLesTool.GetGLesMethodAdress("glNamedBufferStorageMemEXT", typeof(dgtk.OpenGL.delegatesGLES.glNamedBufferStorageMemEXT));
			}
			if (SuportedExt.Contains("glNamedFramebufferSampleLocationsfvNV"))
			{
				dgtk.OpenGL.internalGLES.glNamedFramebufferSampleLocationsfvNV = (dgtk.OpenGL.delegatesGLES.glNamedFramebufferSampleLocationsfvNV) InternalGLesTool.GetGLesMethodAdress("glNamedFramebufferSampleLocationsfvNV", typeof(dgtk.OpenGL.delegatesGLES.glNamedFramebufferSampleLocationsfvNV));
			}
			if (SuportedExt.Contains("glNamedFramebufferTextureMultiviewOVR"))
			{
				dgtk.OpenGL.internalGLES.glNamedFramebufferTextureMultiviewOVR = (dgtk.OpenGL.delegatesGLES.glNamedFramebufferTextureMultiviewOVR) InternalGLesTool.GetGLesMethodAdress("glNamedFramebufferTextureMultiviewOVR", typeof(dgtk.OpenGL.delegatesGLES.glNamedFramebufferTextureMultiviewOVR));
			}
			if (SuportedExt.Contains("glNamedRenderbufferStorageMultisampleAdvancedAMD"))
			{
				dgtk.OpenGL.internalGLES.glNamedRenderbufferStorageMultisampleAdvancedAMD = (dgtk.OpenGL.delegatesGLES.glNamedRenderbufferStorageMultisampleAdvancedAMD) InternalGLesTool.GetGLesMethodAdress("glNamedRenderbufferStorageMultisampleAdvancedAMD", typeof(dgtk.OpenGL.delegatesGLES.glNamedRenderbufferStorageMultisampleAdvancedAMD));
			}
			if (SuportedExt.Contains("glNormal3xOES"))
			{
				dgtk.OpenGL.internalGLES.glNormal3xOES = (dgtk.OpenGL.delegatesGLES.glNormal3xOES) InternalGLesTool.GetGLesMethodAdress("glNormal3xOES", typeof(dgtk.OpenGL.delegatesGLES.glNormal3xOES));
			}
			if (SuportedExt.Contains("glNormal3xvOES"))
			{
				dgtk.OpenGL.internalGLES.glNormal3xvOES = (dgtk.OpenGL.delegatesGLES.glNormal3xvOES) InternalGLesTool.GetGLesMethodAdress("glNormal3xvOES", typeof(dgtk.OpenGL.delegatesGLES.glNormal3xvOES));
			}
			#endregion

			#region O:

			if (SuportedExt.Contains("glObjectLabelKHR"))
			{
				dgtk.OpenGL.internalGLES.glObjectLabelKHR = (dgtk.OpenGL.delegatesGLES.glObjectLabelKHR) InternalGLesTool.GetGLesMethodAdress("glObjectLabelKHR", typeof(dgtk.OpenGL.delegatesGLES.glObjectLabelKHR));
			}
			if (SuportedExt.Contains("glObjectPtrLabelKHR"))
			{
				dgtk.OpenGL.internalGLES.glObjectPtrLabelKHR = (dgtk.OpenGL.delegatesGLES.glObjectPtrLabelKHR) InternalGLesTool.GetGLesMethodAdress("glObjectPtrLabelKHR", typeof(dgtk.OpenGL.delegatesGLES.glObjectPtrLabelKHR));
			}
			if (SuportedExt.Contains("glOrthofOES"))
			{
				dgtk.OpenGL.internalGLES.glOrthofOES = (dgtk.OpenGL.delegatesGLES.glOrthofOES) InternalGLesTool.GetGLesMethodAdress("glOrthofOES", typeof(dgtk.OpenGL.delegatesGLES.glOrthofOES));
			}
			if (SuportedExt.Contains("glOrthoxOES"))
			{
				dgtk.OpenGL.internalGLES.glOrthoxOES = (dgtk.OpenGL.delegatesGLES.glOrthoxOES) InternalGLesTool.GetGLesMethodAdress("glOrthoxOES", typeof(dgtk.OpenGL.delegatesGLES.glOrthoxOES));
			}
			#endregion

			#region P:

			if (SuportedExt.Contains("glPassThroughxOES"))
			{
				dgtk.OpenGL.internalGLES.glPassThroughxOES = (dgtk.OpenGL.delegatesGLES.glPassThroughxOES) InternalGLesTool.GetGLesMethodAdress("glPassThroughxOES", typeof(dgtk.OpenGL.delegatesGLES.glPassThroughxOES));
			}
			if (SuportedExt.Contains("glPatchParameteriEXT"))
			{
				dgtk.OpenGL.internalGLES.glPatchParameteriEXT = (dgtk.OpenGL.delegatesGLES.glPatchParameteriEXT) InternalGLesTool.GetGLesMethodAdress("glPatchParameteriEXT", typeof(dgtk.OpenGL.delegatesGLES.glPatchParameteriEXT));
			}
			if (SuportedExt.Contains("glPatchParameteriOES"))
			{
				dgtk.OpenGL.internalGLES.glPatchParameteriOES = (dgtk.OpenGL.delegatesGLES.glPatchParameteriOES) InternalGLesTool.GetGLesMethodAdress("glPatchParameteriOES", typeof(dgtk.OpenGL.delegatesGLES.glPatchParameteriOES));
			}
			if (SuportedExt.Contains("glPathColorGenNV"))
			{
				dgtk.OpenGL.internalGLES.glPathColorGenNV = (dgtk.OpenGL.delegatesGLES.glPathColorGenNV) InternalGLesTool.GetGLesMethodAdress("glPathColorGenNV", typeof(dgtk.OpenGL.delegatesGLES.glPathColorGenNV));
			}
			if (SuportedExt.Contains("glPathCommandsNV"))
			{
				dgtk.OpenGL.internalGLES.glPathCommandsNV = (dgtk.OpenGL.delegatesGLES.glPathCommandsNV) InternalGLesTool.GetGLesMethodAdress("glPathCommandsNV", typeof(dgtk.OpenGL.delegatesGLES.glPathCommandsNV));
			}
			if (SuportedExt.Contains("glPathCoordsNV"))
			{
				dgtk.OpenGL.internalGLES.glPathCoordsNV = (dgtk.OpenGL.delegatesGLES.glPathCoordsNV) InternalGLesTool.GetGLesMethodAdress("glPathCoordsNV", typeof(dgtk.OpenGL.delegatesGLES.glPathCoordsNV));
			}
			if (SuportedExt.Contains("glPathCoverDepthFuncNV"))
			{
				dgtk.OpenGL.internalGLES.glPathCoverDepthFuncNV = (dgtk.OpenGL.delegatesGLES.glPathCoverDepthFuncNV) InternalGLesTool.GetGLesMethodAdress("glPathCoverDepthFuncNV", typeof(dgtk.OpenGL.delegatesGLES.glPathCoverDepthFuncNV));
			}
			if (SuportedExt.Contains("glPathDashArrayNV"))
			{
				dgtk.OpenGL.internalGLES.glPathDashArrayNV = (dgtk.OpenGL.delegatesGLES.glPathDashArrayNV) InternalGLesTool.GetGLesMethodAdress("glPathDashArrayNV", typeof(dgtk.OpenGL.delegatesGLES.glPathDashArrayNV));
			}
			if (SuportedExt.Contains("glPathFogGenNV"))
			{
				dgtk.OpenGL.internalGLES.glPathFogGenNV = (dgtk.OpenGL.delegatesGLES.glPathFogGenNV) InternalGLesTool.GetGLesMethodAdress("glPathFogGenNV", typeof(dgtk.OpenGL.delegatesGLES.glPathFogGenNV));
			}
			if (SuportedExt.Contains("glPathGlyphIndexArrayNV"))
			{
				dgtk.OpenGL.internalGLES.glPathGlyphIndexArrayNV = (dgtk.OpenGL.delegatesGLES.glPathGlyphIndexArrayNV) InternalGLesTool.GetGLesMethodAdress("glPathGlyphIndexArrayNV", typeof(dgtk.OpenGL.delegatesGLES.glPathGlyphIndexArrayNV));
			}
			if (SuportedExt.Contains("glPathGlyphIndexRangeNV"))
			{
				dgtk.OpenGL.internalGLES.glPathGlyphIndexRangeNV = (dgtk.OpenGL.delegatesGLES.glPathGlyphIndexRangeNV) InternalGLesTool.GetGLesMethodAdress("glPathGlyphIndexRangeNV", typeof(dgtk.OpenGL.delegatesGLES.glPathGlyphIndexRangeNV));
			}
			if (SuportedExt.Contains("glPathGlyphRangeNV"))
			{
				dgtk.OpenGL.internalGLES.glPathGlyphRangeNV = (dgtk.OpenGL.delegatesGLES.glPathGlyphRangeNV) InternalGLesTool.GetGLesMethodAdress("glPathGlyphRangeNV", typeof(dgtk.OpenGL.delegatesGLES.glPathGlyphRangeNV));
			}
			if (SuportedExt.Contains("glPathGlyphsNV"))
			{
				dgtk.OpenGL.internalGLES.glPathGlyphsNV = (dgtk.OpenGL.delegatesGLES.glPathGlyphsNV) InternalGLesTool.GetGLesMethodAdress("glPathGlyphsNV", typeof(dgtk.OpenGL.delegatesGLES.glPathGlyphsNV));
			}
			if (SuportedExt.Contains("glPathMemoryGlyphIndexArrayNV"))
			{
				dgtk.OpenGL.internalGLES.glPathMemoryGlyphIndexArrayNV = (dgtk.OpenGL.delegatesGLES.glPathMemoryGlyphIndexArrayNV) InternalGLesTool.GetGLesMethodAdress("glPathMemoryGlyphIndexArrayNV", typeof(dgtk.OpenGL.delegatesGLES.glPathMemoryGlyphIndexArrayNV));
			}
			if (SuportedExt.Contains("glPathParameterfNV"))
			{
				dgtk.OpenGL.internalGLES.glPathParameterfNV = (dgtk.OpenGL.delegatesGLES.glPathParameterfNV) InternalGLesTool.GetGLesMethodAdress("glPathParameterfNV", typeof(dgtk.OpenGL.delegatesGLES.glPathParameterfNV));
			}
			if (SuportedExt.Contains("glPathParameterfvNV"))
			{
				dgtk.OpenGL.internalGLES.glPathParameterfvNV = (dgtk.OpenGL.delegatesGLES.glPathParameterfvNV) InternalGLesTool.GetGLesMethodAdress("glPathParameterfvNV", typeof(dgtk.OpenGL.delegatesGLES.glPathParameterfvNV));
			}
			if (SuportedExt.Contains("glPathParameteriNV"))
			{
				dgtk.OpenGL.internalGLES.glPathParameteriNV = (dgtk.OpenGL.delegatesGLES.glPathParameteriNV) InternalGLesTool.GetGLesMethodAdress("glPathParameteriNV", typeof(dgtk.OpenGL.delegatesGLES.glPathParameteriNV));
			}
			if (SuportedExt.Contains("glPathParameterivNV"))
			{
				dgtk.OpenGL.internalGLES.glPathParameterivNV = (dgtk.OpenGL.delegatesGLES.glPathParameterivNV) InternalGLesTool.GetGLesMethodAdress("glPathParameterivNV", typeof(dgtk.OpenGL.delegatesGLES.glPathParameterivNV));
			}
			if (SuportedExt.Contains("glPathStencilDepthOffsetNV"))
			{
				dgtk.OpenGL.internalGLES.glPathStencilDepthOffsetNV = (dgtk.OpenGL.delegatesGLES.glPathStencilDepthOffsetNV) InternalGLesTool.GetGLesMethodAdress("glPathStencilDepthOffsetNV", typeof(dgtk.OpenGL.delegatesGLES.glPathStencilDepthOffsetNV));
			}
			if (SuportedExt.Contains("glPathStencilFuncNV"))
			{
				dgtk.OpenGL.internalGLES.glPathStencilFuncNV = (dgtk.OpenGL.delegatesGLES.glPathStencilFuncNV) InternalGLesTool.GetGLesMethodAdress("glPathStencilFuncNV", typeof(dgtk.OpenGL.delegatesGLES.glPathStencilFuncNV));
			}
			if (SuportedExt.Contains("glPathStringNV"))
			{
				dgtk.OpenGL.internalGLES.glPathStringNV = (dgtk.OpenGL.delegatesGLES.glPathStringNV) InternalGLesTool.GetGLesMethodAdress("glPathStringNV", typeof(dgtk.OpenGL.delegatesGLES.glPathStringNV));
			}
			if (SuportedExt.Contains("glPathSubCommandsNV"))
			{
				dgtk.OpenGL.internalGLES.glPathSubCommandsNV = (dgtk.OpenGL.delegatesGLES.glPathSubCommandsNV) InternalGLesTool.GetGLesMethodAdress("glPathSubCommandsNV", typeof(dgtk.OpenGL.delegatesGLES.glPathSubCommandsNV));
			}
			if (SuportedExt.Contains("glPathSubCoordsNV"))
			{
				dgtk.OpenGL.internalGLES.glPathSubCoordsNV = (dgtk.OpenGL.delegatesGLES.glPathSubCoordsNV) InternalGLesTool.GetGLesMethodAdress("glPathSubCoordsNV", typeof(dgtk.OpenGL.delegatesGLES.glPathSubCoordsNV));
			}
			if (SuportedExt.Contains("glPathTexGenNV"))
			{
				dgtk.OpenGL.internalGLES.glPathTexGenNV = (dgtk.OpenGL.delegatesGLES.glPathTexGenNV) InternalGLesTool.GetGLesMethodAdress("glPathTexGenNV", typeof(dgtk.OpenGL.delegatesGLES.glPathTexGenNV));
			}
			if (SuportedExt.Contains("glPixelMapx"))
			{
				dgtk.OpenGL.internalGLES.glPixelMapx = (dgtk.OpenGL.delegatesGLES.glPixelMapx) InternalGLesTool.GetGLesMethodAdress("glPixelMapx", typeof(dgtk.OpenGL.delegatesGLES.glPixelMapx));
			}
			if (SuportedExt.Contains("glPixelStorex"))
			{
				dgtk.OpenGL.internalGLES.glPixelStorex = (dgtk.OpenGL.delegatesGLES.glPixelStorex) InternalGLesTool.GetGLesMethodAdress("glPixelStorex", typeof(dgtk.OpenGL.delegatesGLES.glPixelStorex));
			}
			if (SuportedExt.Contains("glPixelTransferxOES"))
			{
				dgtk.OpenGL.internalGLES.glPixelTransferxOES = (dgtk.OpenGL.delegatesGLES.glPixelTransferxOES) InternalGLesTool.GetGLesMethodAdress("glPixelTransferxOES", typeof(dgtk.OpenGL.delegatesGLES.glPixelTransferxOES));
			}
			if (SuportedExt.Contains("glPixelZoomxOES"))
			{
				dgtk.OpenGL.internalGLES.glPixelZoomxOES = (dgtk.OpenGL.delegatesGLES.glPixelZoomxOES) InternalGLesTool.GetGLesMethodAdress("glPixelZoomxOES", typeof(dgtk.OpenGL.delegatesGLES.glPixelZoomxOES));
			}
			if (SuportedExt.Contains("glPointAlongPathNV"))
			{
				dgtk.OpenGL.internalGLES.glPointAlongPathNV = (dgtk.OpenGL.delegatesGLES.glPointAlongPathNV) InternalGLesTool.GetGLesMethodAdress("glPointAlongPathNV", typeof(dgtk.OpenGL.delegatesGLES.glPointAlongPathNV));
			}
			if (SuportedExt.Contains("glPointParameterxOES"))
			{
				dgtk.OpenGL.internalGLES.glPointParameterxOES = (dgtk.OpenGL.delegatesGLES.glPointParameterxOES) InternalGLesTool.GetGLesMethodAdress("glPointParameterxOES", typeof(dgtk.OpenGL.delegatesGLES.glPointParameterxOES));
			}
			if (SuportedExt.Contains("glPointParameterxvOES"))
			{
				dgtk.OpenGL.internalGLES.glPointParameterxvOES = (dgtk.OpenGL.delegatesGLES.glPointParameterxvOES) InternalGLesTool.GetGLesMethodAdress("glPointParameterxvOES", typeof(dgtk.OpenGL.delegatesGLES.glPointParameterxvOES));
			}
			if (SuportedExt.Contains("glPointSizePointerOES"))
			{
				dgtk.OpenGL.internalGLES.glPointSizePointerOES = (dgtk.OpenGL.delegatesGLES.glPointSizePointerOES) InternalGLesTool.GetGLesMethodAdress("glPointSizePointerOES", typeof(dgtk.OpenGL.delegatesGLES.glPointSizePointerOES));
			}
			if (SuportedExt.Contains("glPointSizexOES"))
			{
				dgtk.OpenGL.internalGLES.glPointSizexOES = (dgtk.OpenGL.delegatesGLES.glPointSizexOES) InternalGLesTool.GetGLesMethodAdress("glPointSizexOES", typeof(dgtk.OpenGL.delegatesGLES.glPointSizexOES));
			}
			if (SuportedExt.Contains("glPolygonModeNV"))
			{
				dgtk.OpenGL.internalGLES.glPolygonModeNV = (dgtk.OpenGL.delegatesGLES.glPolygonModeNV) InternalGLesTool.GetGLesMethodAdress("glPolygonModeNV", typeof(dgtk.OpenGL.delegatesGLES.glPolygonModeNV));
			}
			if (SuportedExt.Contains("glPolygonOffsetClampEXT"))
			{
				dgtk.OpenGL.internalGLES.glPolygonOffsetClampEXT = (dgtk.OpenGL.delegatesGLES.glPolygonOffsetClampEXT) InternalGLesTool.GetGLesMethodAdress("glPolygonOffsetClampEXT", typeof(dgtk.OpenGL.delegatesGLES.glPolygonOffsetClampEXT));
			}
			if (SuportedExt.Contains("glPolygonOffsetxOES"))
			{
				dgtk.OpenGL.internalGLES.glPolygonOffsetxOES = (dgtk.OpenGL.delegatesGLES.glPolygonOffsetxOES) InternalGLesTool.GetGLesMethodAdress("glPolygonOffsetxOES", typeof(dgtk.OpenGL.delegatesGLES.glPolygonOffsetxOES));
			}
			if (SuportedExt.Contains("glPopDebugGroupKHR"))
			{
				dgtk.OpenGL.internalGLES.glPopDebugGroupKHR = (dgtk.OpenGL.delegatesGLES.glPopDebugGroupKHR) InternalGLesTool.GetGLesMethodAdress("glPopDebugGroupKHR", typeof(dgtk.OpenGL.delegatesGLES.glPopDebugGroupKHR));
			}
			if (SuportedExt.Contains("glPopGroupMarkerEXT"))
			{
				dgtk.OpenGL.internalGLES.glPopGroupMarkerEXT = (dgtk.OpenGL.delegatesGLES.glPopGroupMarkerEXT) InternalGLesTool.GetGLesMethodAdress("glPopGroupMarkerEXT", typeof(dgtk.OpenGL.delegatesGLES.glPopGroupMarkerEXT));
			}
			if (SuportedExt.Contains("glPrimitiveBoundingBoxEXT"))
			{
				dgtk.OpenGL.internalGLES.glPrimitiveBoundingBoxEXT = (dgtk.OpenGL.delegatesGLES.glPrimitiveBoundingBoxEXT) InternalGLesTool.GetGLesMethodAdress("glPrimitiveBoundingBoxEXT", typeof(dgtk.OpenGL.delegatesGLES.glPrimitiveBoundingBoxEXT));
			}
			if (SuportedExt.Contains("glPrimitiveBoundingBoxOES"))
			{
				dgtk.OpenGL.internalGLES.glPrimitiveBoundingBoxOES = (dgtk.OpenGL.delegatesGLES.glPrimitiveBoundingBoxOES) InternalGLesTool.GetGLesMethodAdress("glPrimitiveBoundingBoxOES", typeof(dgtk.OpenGL.delegatesGLES.glPrimitiveBoundingBoxOES));
			}
			if (SuportedExt.Contains("glPrioritizeTexturesxOES"))
			{
				dgtk.OpenGL.internalGLES.glPrioritizeTexturesxOES = (dgtk.OpenGL.delegatesGLES.glPrioritizeTexturesxOES) InternalGLesTool.GetGLesMethodAdress("glPrioritizeTexturesxOES", typeof(dgtk.OpenGL.delegatesGLES.glPrioritizeTexturesxOES));
			}
			if (SuportedExt.Contains("glProgramBinaryOES"))
			{
				dgtk.OpenGL.internalGLES.glProgramBinaryOES = (dgtk.OpenGL.delegatesGLES.glProgramBinaryOES) InternalGLesTool.GetGLesMethodAdress("glProgramBinaryOES", typeof(dgtk.OpenGL.delegatesGLES.glProgramBinaryOES));
			}
			if (SuportedExt.Contains("glProgramParameteriEXT"))
			{
				dgtk.OpenGL.internalGLES.glProgramParameteriEXT = (dgtk.OpenGL.delegatesGLES.glProgramParameteriEXT) InternalGLesTool.GetGLesMethodAdress("glProgramParameteriEXT", typeof(dgtk.OpenGL.delegatesGLES.glProgramParameteriEXT));
			}
			if (SuportedExt.Contains("glProgramPathFragmentInputGenNV"))
			{
				dgtk.OpenGL.internalGLES.glProgramPathFragmentInputGenNV = (dgtk.OpenGL.delegatesGLES.glProgramPathFragmentInputGenNV) InternalGLesTool.GetGLesMethodAdress("glProgramPathFragmentInputGenNV", typeof(dgtk.OpenGL.delegatesGLES.glProgramPathFragmentInputGenNV));
			}
			if (SuportedExt.Contains("glProgramUniform1fEXT"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform1fEXT = (dgtk.OpenGL.delegatesGLES.glProgramUniform1fEXT) InternalGLesTool.GetGLesMethodAdress("glProgramUniform1fEXT", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform1fEXT));
			}
			if (SuportedExt.Contains("glProgramUniform1fvEXT"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform1fvEXT = (dgtk.OpenGL.delegatesGLES.glProgramUniform1fvEXT) InternalGLesTool.GetGLesMethodAdress("glProgramUniform1fvEXT", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform1fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniform1i64NV"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform1i64NV = (dgtk.OpenGL.delegatesGLES.glProgramUniform1i64NV) InternalGLesTool.GetGLesMethodAdress("glProgramUniform1i64NV", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform1i64NV));
			}
			if (SuportedExt.Contains("glProgramUniform1i64vNV"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform1i64vNV = (dgtk.OpenGL.delegatesGLES.glProgramUniform1i64vNV) InternalGLesTool.GetGLesMethodAdress("glProgramUniform1i64vNV", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform1i64vNV));
			}
			if (SuportedExt.Contains("glProgramUniform1iEXT"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform1iEXT = (dgtk.OpenGL.delegatesGLES.glProgramUniform1iEXT) InternalGLesTool.GetGLesMethodAdress("glProgramUniform1iEXT", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform1iEXT));
			}
			if (SuportedExt.Contains("glProgramUniform1ivEXT"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform1ivEXT = (dgtk.OpenGL.delegatesGLES.glProgramUniform1ivEXT) InternalGLesTool.GetGLesMethodAdress("glProgramUniform1ivEXT", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform1ivEXT));
			}
			if (SuportedExt.Contains("glProgramUniform1ui64NV"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform1ui64NV = (dgtk.OpenGL.delegatesGLES.glProgramUniform1ui64NV) InternalGLesTool.GetGLesMethodAdress("glProgramUniform1ui64NV", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform1ui64NV));
			}
			if (SuportedExt.Contains("glProgramUniform1ui64vNV"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform1ui64vNV = (dgtk.OpenGL.delegatesGLES.glProgramUniform1ui64vNV) InternalGLesTool.GetGLesMethodAdress("glProgramUniform1ui64vNV", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform1ui64vNV));
			}
			if (SuportedExt.Contains("glProgramUniform1uiEXT"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform1uiEXT = (dgtk.OpenGL.delegatesGLES.glProgramUniform1uiEXT) InternalGLesTool.GetGLesMethodAdress("glProgramUniform1uiEXT", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform1uiEXT));
			}
			if (SuportedExt.Contains("glProgramUniform1uivEXT"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform1uivEXT = (dgtk.OpenGL.delegatesGLES.glProgramUniform1uivEXT) InternalGLesTool.GetGLesMethodAdress("glProgramUniform1uivEXT", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform1uivEXT));
			}
			if (SuportedExt.Contains("glProgramUniform2fEXT"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform2fEXT = (dgtk.OpenGL.delegatesGLES.glProgramUniform2fEXT) InternalGLesTool.GetGLesMethodAdress("glProgramUniform2fEXT", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform2fEXT));
			}
			if (SuportedExt.Contains("glProgramUniform2fvEXT"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform2fvEXT = (dgtk.OpenGL.delegatesGLES.glProgramUniform2fvEXT) InternalGLesTool.GetGLesMethodAdress("glProgramUniform2fvEXT", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform2fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniform2i64NV"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform2i64NV = (dgtk.OpenGL.delegatesGLES.glProgramUniform2i64NV) InternalGLesTool.GetGLesMethodAdress("glProgramUniform2i64NV", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform2i64NV));
			}
			if (SuportedExt.Contains("glProgramUniform2i64vNV"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform2i64vNV = (dgtk.OpenGL.delegatesGLES.glProgramUniform2i64vNV) InternalGLesTool.GetGLesMethodAdress("glProgramUniform2i64vNV", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform2i64vNV));
			}
			if (SuportedExt.Contains("glProgramUniform2iEXT"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform2iEXT = (dgtk.OpenGL.delegatesGLES.glProgramUniform2iEXT) InternalGLesTool.GetGLesMethodAdress("glProgramUniform2iEXT", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform2iEXT));
			}
			if (SuportedExt.Contains("glProgramUniform2ivEXT"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform2ivEXT = (dgtk.OpenGL.delegatesGLES.glProgramUniform2ivEXT) InternalGLesTool.GetGLesMethodAdress("glProgramUniform2ivEXT", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform2ivEXT));
			}
			if (SuportedExt.Contains("glProgramUniform2ui64NV"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform2ui64NV = (dgtk.OpenGL.delegatesGLES.glProgramUniform2ui64NV) InternalGLesTool.GetGLesMethodAdress("glProgramUniform2ui64NV", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform2ui64NV));
			}
			if (SuportedExt.Contains("glProgramUniform2ui64vNV"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform2ui64vNV = (dgtk.OpenGL.delegatesGLES.glProgramUniform2ui64vNV) InternalGLesTool.GetGLesMethodAdress("glProgramUniform2ui64vNV", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform2ui64vNV));
			}
			if (SuportedExt.Contains("glProgramUniform2uiEXT"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform2uiEXT = (dgtk.OpenGL.delegatesGLES.glProgramUniform2uiEXT) InternalGLesTool.GetGLesMethodAdress("glProgramUniform2uiEXT", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform2uiEXT));
			}
			if (SuportedExt.Contains("glProgramUniform2uivEXT"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform2uivEXT = (dgtk.OpenGL.delegatesGLES.glProgramUniform2uivEXT) InternalGLesTool.GetGLesMethodAdress("glProgramUniform2uivEXT", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform2uivEXT));
			}
			if (SuportedExt.Contains("glProgramUniform3fEXT"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform3fEXT = (dgtk.OpenGL.delegatesGLES.glProgramUniform3fEXT) InternalGLesTool.GetGLesMethodAdress("glProgramUniform3fEXT", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform3fEXT));
			}
			if (SuportedExt.Contains("glProgramUniform3fvEXT"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform3fvEXT = (dgtk.OpenGL.delegatesGLES.glProgramUniform3fvEXT) InternalGLesTool.GetGLesMethodAdress("glProgramUniform3fvEXT", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform3fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniform3i64NV"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform3i64NV = (dgtk.OpenGL.delegatesGLES.glProgramUniform3i64NV) InternalGLesTool.GetGLesMethodAdress("glProgramUniform3i64NV", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform3i64NV));
			}
			if (SuportedExt.Contains("glProgramUniform3i64vNV"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform3i64vNV = (dgtk.OpenGL.delegatesGLES.glProgramUniform3i64vNV) InternalGLesTool.GetGLesMethodAdress("glProgramUniform3i64vNV", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform3i64vNV));
			}
			if (SuportedExt.Contains("glProgramUniform3iEXT"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform3iEXT = (dgtk.OpenGL.delegatesGLES.glProgramUniform3iEXT) InternalGLesTool.GetGLesMethodAdress("glProgramUniform3iEXT", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform3iEXT));
			}
			if (SuportedExt.Contains("glProgramUniform3ivEXT"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform3ivEXT = (dgtk.OpenGL.delegatesGLES.glProgramUniform3ivEXT) InternalGLesTool.GetGLesMethodAdress("glProgramUniform3ivEXT", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform3ivEXT));
			}
			if (SuportedExt.Contains("glProgramUniform3ui64NV"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform3ui64NV = (dgtk.OpenGL.delegatesGLES.glProgramUniform3ui64NV) InternalGLesTool.GetGLesMethodAdress("glProgramUniform3ui64NV", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform3ui64NV));
			}
			if (SuportedExt.Contains("glProgramUniform3ui64vNV"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform3ui64vNV = (dgtk.OpenGL.delegatesGLES.glProgramUniform3ui64vNV) InternalGLesTool.GetGLesMethodAdress("glProgramUniform3ui64vNV", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform3ui64vNV));
			}
			if (SuportedExt.Contains("glProgramUniform3uiEXT"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform3uiEXT = (dgtk.OpenGL.delegatesGLES.glProgramUniform3uiEXT) InternalGLesTool.GetGLesMethodAdress("glProgramUniform3uiEXT", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform3uiEXT));
			}
			if (SuportedExt.Contains("glProgramUniform3uivEXT"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform3uivEXT = (dgtk.OpenGL.delegatesGLES.glProgramUniform3uivEXT) InternalGLesTool.GetGLesMethodAdress("glProgramUniform3uivEXT", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform3uivEXT));
			}
			if (SuportedExt.Contains("glProgramUniform4fEXT"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform4fEXT = (dgtk.OpenGL.delegatesGLES.glProgramUniform4fEXT) InternalGLesTool.GetGLesMethodAdress("glProgramUniform4fEXT", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform4fEXT));
			}
			if (SuportedExt.Contains("glProgramUniform4fvEXT"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform4fvEXT = (dgtk.OpenGL.delegatesGLES.glProgramUniform4fvEXT) InternalGLesTool.GetGLesMethodAdress("glProgramUniform4fvEXT", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform4fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniform4i64NV"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform4i64NV = (dgtk.OpenGL.delegatesGLES.glProgramUniform4i64NV) InternalGLesTool.GetGLesMethodAdress("glProgramUniform4i64NV", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform4i64NV));
			}
			if (SuportedExt.Contains("glProgramUniform4i64vNV"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform4i64vNV = (dgtk.OpenGL.delegatesGLES.glProgramUniform4i64vNV) InternalGLesTool.GetGLesMethodAdress("glProgramUniform4i64vNV", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform4i64vNV));
			}
			if (SuportedExt.Contains("glProgramUniform4iEXT"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform4iEXT = (dgtk.OpenGL.delegatesGLES.glProgramUniform4iEXT) InternalGLesTool.GetGLesMethodAdress("glProgramUniform4iEXT", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform4iEXT));
			}
			if (SuportedExt.Contains("glProgramUniform4ivEXT"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform4ivEXT = (dgtk.OpenGL.delegatesGLES.glProgramUniform4ivEXT) InternalGLesTool.GetGLesMethodAdress("glProgramUniform4ivEXT", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform4ivEXT));
			}
			if (SuportedExt.Contains("glProgramUniform4ui64NV"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform4ui64NV = (dgtk.OpenGL.delegatesGLES.glProgramUniform4ui64NV) InternalGLesTool.GetGLesMethodAdress("glProgramUniform4ui64NV", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform4ui64NV));
			}
			if (SuportedExt.Contains("glProgramUniform4ui64vNV"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform4ui64vNV = (dgtk.OpenGL.delegatesGLES.glProgramUniform4ui64vNV) InternalGLesTool.GetGLesMethodAdress("glProgramUniform4ui64vNV", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform4ui64vNV));
			}
			if (SuportedExt.Contains("glProgramUniform4uiEXT"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform4uiEXT = (dgtk.OpenGL.delegatesGLES.glProgramUniform4uiEXT) InternalGLesTool.GetGLesMethodAdress("glProgramUniform4uiEXT", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform4uiEXT));
			}
			if (SuportedExt.Contains("glProgramUniform4uivEXT"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniform4uivEXT = (dgtk.OpenGL.delegatesGLES.glProgramUniform4uivEXT) InternalGLesTool.GetGLesMethodAdress("glProgramUniform4uivEXT", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniform4uivEXT));
			}
			if (SuportedExt.Contains("glProgramUniformHandleui64IMG"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniformHandleui64IMG = (dgtk.OpenGL.delegatesGLES.glProgramUniformHandleui64IMG) InternalGLesTool.GetGLesMethodAdress("glProgramUniformHandleui64IMG", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniformHandleui64IMG));
			}
			if (SuportedExt.Contains("glProgramUniformHandleui64NV"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniformHandleui64NV = (dgtk.OpenGL.delegatesGLES.glProgramUniformHandleui64NV) InternalGLesTool.GetGLesMethodAdress("glProgramUniformHandleui64NV", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniformHandleui64NV));
			}
			if (SuportedExt.Contains("glProgramUniformHandleui64vIMG"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniformHandleui64vIMG = (dgtk.OpenGL.delegatesGLES.glProgramUniformHandleui64vIMG) InternalGLesTool.GetGLesMethodAdress("glProgramUniformHandleui64vIMG", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniformHandleui64vIMG));
			}
			if (SuportedExt.Contains("glProgramUniformHandleui64vNV"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniformHandleui64vNV = (dgtk.OpenGL.delegatesGLES.glProgramUniformHandleui64vNV) InternalGLesTool.GetGLesMethodAdress("glProgramUniformHandleui64vNV", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniformHandleui64vNV));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix2fvEXT"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniformMatrix2fvEXT = (dgtk.OpenGL.delegatesGLES.glProgramUniformMatrix2fvEXT) InternalGLesTool.GetGLesMethodAdress("glProgramUniformMatrix2fvEXT", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniformMatrix2fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix2x3fvEXT"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniformMatrix2x3fvEXT = (dgtk.OpenGL.delegatesGLES.glProgramUniformMatrix2x3fvEXT) InternalGLesTool.GetGLesMethodAdress("glProgramUniformMatrix2x3fvEXT", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniformMatrix2x3fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix2x4fvEXT"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniformMatrix2x4fvEXT = (dgtk.OpenGL.delegatesGLES.glProgramUniformMatrix2x4fvEXT) InternalGLesTool.GetGLesMethodAdress("glProgramUniformMatrix2x4fvEXT", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniformMatrix2x4fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix3fvEXT"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniformMatrix3fvEXT = (dgtk.OpenGL.delegatesGLES.glProgramUniformMatrix3fvEXT) InternalGLesTool.GetGLesMethodAdress("glProgramUniformMatrix3fvEXT", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniformMatrix3fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix3x2fvEXT"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniformMatrix3x2fvEXT = (dgtk.OpenGL.delegatesGLES.glProgramUniformMatrix3x2fvEXT) InternalGLesTool.GetGLesMethodAdress("glProgramUniformMatrix3x2fvEXT", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniformMatrix3x2fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix3x4fvEXT"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniformMatrix3x4fvEXT = (dgtk.OpenGL.delegatesGLES.glProgramUniformMatrix3x4fvEXT) InternalGLesTool.GetGLesMethodAdress("glProgramUniformMatrix3x4fvEXT", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniformMatrix3x4fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix4fvEXT"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniformMatrix4fvEXT = (dgtk.OpenGL.delegatesGLES.glProgramUniformMatrix4fvEXT) InternalGLesTool.GetGLesMethodAdress("glProgramUniformMatrix4fvEXT", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniformMatrix4fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix4x2fvEXT"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniformMatrix4x2fvEXT = (dgtk.OpenGL.delegatesGLES.glProgramUniformMatrix4x2fvEXT) InternalGLesTool.GetGLesMethodAdress("glProgramUniformMatrix4x2fvEXT", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniformMatrix4x2fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix4x3fvEXT"))
			{
				dgtk.OpenGL.internalGLES.glProgramUniformMatrix4x3fvEXT = (dgtk.OpenGL.delegatesGLES.glProgramUniformMatrix4x3fvEXT) InternalGLesTool.GetGLesMethodAdress("glProgramUniformMatrix4x3fvEXT", typeof(dgtk.OpenGL.delegatesGLES.glProgramUniformMatrix4x3fvEXT));
			}
			if (SuportedExt.Contains("glPushDebugGroupKHR"))
			{
				dgtk.OpenGL.internalGLES.glPushDebugGroupKHR = (dgtk.OpenGL.delegatesGLES.glPushDebugGroupKHR) InternalGLesTool.GetGLesMethodAdress("glPushDebugGroupKHR", typeof(dgtk.OpenGL.delegatesGLES.glPushDebugGroupKHR));
			}
			if (SuportedExt.Contains("glPushGroupMarkerEXT"))
			{
				dgtk.OpenGL.internalGLES.glPushGroupMarkerEXT = (dgtk.OpenGL.delegatesGLES.glPushGroupMarkerEXT) InternalGLesTool.GetGLesMethodAdress("glPushGroupMarkerEXT", typeof(dgtk.OpenGL.delegatesGLES.glPushGroupMarkerEXT));
			}
			#endregion

			#region Q:

			if (SuportedExt.Contains("glQueryCounterEXT"))
			{
				dgtk.OpenGL.internalGLES.glQueryCounterEXT = (dgtk.OpenGL.delegatesGLES.glQueryCounterEXT) InternalGLesTool.GetGLesMethodAdress("glQueryCounterEXT", typeof(dgtk.OpenGL.delegatesGLES.glQueryCounterEXT));
			}
			if (SuportedExt.Contains("glQueryMatrixxOES"))
			{
				dgtk.OpenGL.internalGLES.glQueryMatrixxOES = (dgtk.OpenGL.delegatesGLES.glQueryMatrixxOES) InternalGLesTool.GetGLesMethodAdress("glQueryMatrixxOES", typeof(dgtk.OpenGL.delegatesGLES.glQueryMatrixxOES));
			}
			#endregion

			#region R:

			if (SuportedExt.Contains("glRasterPos2xOES"))
			{
				dgtk.OpenGL.internalGLES.glRasterPos2xOES = (dgtk.OpenGL.delegatesGLES.glRasterPos2xOES) InternalGLesTool.GetGLesMethodAdress("glRasterPos2xOES", typeof(dgtk.OpenGL.delegatesGLES.glRasterPos2xOES));
			}
			if (SuportedExt.Contains("glRasterPos2xvOES"))
			{
				dgtk.OpenGL.internalGLES.glRasterPos2xvOES = (dgtk.OpenGL.delegatesGLES.glRasterPos2xvOES) InternalGLesTool.GetGLesMethodAdress("glRasterPos2xvOES", typeof(dgtk.OpenGL.delegatesGLES.glRasterPos2xvOES));
			}
			if (SuportedExt.Contains("glRasterPos3xOES"))
			{
				dgtk.OpenGL.internalGLES.glRasterPos3xOES = (dgtk.OpenGL.delegatesGLES.glRasterPos3xOES) InternalGLesTool.GetGLesMethodAdress("glRasterPos3xOES", typeof(dgtk.OpenGL.delegatesGLES.glRasterPos3xOES));
			}
			if (SuportedExt.Contains("glRasterPos3xvOES"))
			{
				dgtk.OpenGL.internalGLES.glRasterPos3xvOES = (dgtk.OpenGL.delegatesGLES.glRasterPos3xvOES) InternalGLesTool.GetGLesMethodAdress("glRasterPos3xvOES", typeof(dgtk.OpenGL.delegatesGLES.glRasterPos3xvOES));
			}
			if (SuportedExt.Contains("glRasterPos4xOES"))
			{
				dgtk.OpenGL.internalGLES.glRasterPos4xOES = (dgtk.OpenGL.delegatesGLES.glRasterPos4xOES) InternalGLesTool.GetGLesMethodAdress("glRasterPos4xOES", typeof(dgtk.OpenGL.delegatesGLES.glRasterPos4xOES));
			}
			if (SuportedExt.Contains("glRasterPos4xvOES"))
			{
				dgtk.OpenGL.internalGLES.glRasterPos4xvOES = (dgtk.OpenGL.delegatesGLES.glRasterPos4xvOES) InternalGLesTool.GetGLesMethodAdress("glRasterPos4xvOES", typeof(dgtk.OpenGL.delegatesGLES.glRasterPos4xvOES));
			}
			if (SuportedExt.Contains("glRasterSamplesEXT"))
			{
				dgtk.OpenGL.internalGLES.glRasterSamplesEXT = (dgtk.OpenGL.delegatesGLES.glRasterSamplesEXT) InternalGLesTool.GetGLesMethodAdress("glRasterSamplesEXT", typeof(dgtk.OpenGL.delegatesGLES.glRasterSamplesEXT));
			}
			if (SuportedExt.Contains("glReadBufferIndexedEXT"))
			{
				dgtk.OpenGL.internalGLES.glReadBufferIndexedEXT = (dgtk.OpenGL.delegatesGLES.glReadBufferIndexedEXT) InternalGLesTool.GetGLesMethodAdress("glReadBufferIndexedEXT", typeof(dgtk.OpenGL.delegatesGLES.glReadBufferIndexedEXT));
			}
			if (SuportedExt.Contains("glReadBufferNV"))
			{
				dgtk.OpenGL.internalGLES.glReadBufferNV = (dgtk.OpenGL.delegatesGLES.glReadBufferNV) InternalGLesTool.GetGLesMethodAdress("glReadBufferNV", typeof(dgtk.OpenGL.delegatesGLES.glReadBufferNV));
			}
			if (SuportedExt.Contains("glReadnPixelsEXT"))
			{
				dgtk.OpenGL.internalGLES.glReadnPixelsEXT = (dgtk.OpenGL.delegatesGLES.glReadnPixelsEXT) InternalGLesTool.GetGLesMethodAdress("glReadnPixelsEXT", typeof(dgtk.OpenGL.delegatesGLES.glReadnPixelsEXT));
			}
			if (SuportedExt.Contains("glReadnPixelsKHR"))
			{
				dgtk.OpenGL.internalGLES.glReadnPixelsKHR = (dgtk.OpenGL.delegatesGLES.glReadnPixelsKHR) InternalGLesTool.GetGLesMethodAdress("glReadnPixelsKHR", typeof(dgtk.OpenGL.delegatesGLES.glReadnPixelsKHR));
			}
			if (SuportedExt.Contains("glRectxOES"))
			{
				dgtk.OpenGL.internalGLES.glRectxOES = (dgtk.OpenGL.delegatesGLES.glRectxOES) InternalGLesTool.GetGLesMethodAdress("glRectxOES", typeof(dgtk.OpenGL.delegatesGLES.glRectxOES));
			}
			if (SuportedExt.Contains("glRectxvOES"))
			{
				dgtk.OpenGL.internalGLES.glRectxvOES = (dgtk.OpenGL.delegatesGLES.glRectxvOES) InternalGLesTool.GetGLesMethodAdress("glRectxvOES", typeof(dgtk.OpenGL.delegatesGLES.glRectxvOES));
			}
			if (SuportedExt.Contains("glReleaseKeyedMutexWin32EXT"))
			{
				dgtk.OpenGL.internalGLES.glReleaseKeyedMutexWin32EXT = (dgtk.OpenGL.delegatesGLES.glReleaseKeyedMutexWin32EXT) InternalGLesTool.GetGLesMethodAdress("glReleaseKeyedMutexWin32EXT", typeof(dgtk.OpenGL.delegatesGLES.glReleaseKeyedMutexWin32EXT));
			}
			if (SuportedExt.Contains("glRenderbufferStorageMultisampleAdvancedAMD"))
			{
				dgtk.OpenGL.internalGLES.glRenderbufferStorageMultisampleAdvancedAMD = (dgtk.OpenGL.delegatesGLES.glRenderbufferStorageMultisampleAdvancedAMD) InternalGLesTool.GetGLesMethodAdress("glRenderbufferStorageMultisampleAdvancedAMD", typeof(dgtk.OpenGL.delegatesGLES.glRenderbufferStorageMultisampleAdvancedAMD));
			}
			if (SuportedExt.Contains("glRenderbufferStorageMultisampleANGLE"))
			{
				dgtk.OpenGL.internalGLES.glRenderbufferStorageMultisampleANGLE = (dgtk.OpenGL.delegatesGLES.glRenderbufferStorageMultisampleANGLE) InternalGLesTool.GetGLesMethodAdress("glRenderbufferStorageMultisampleANGLE", typeof(dgtk.OpenGL.delegatesGLES.glRenderbufferStorageMultisampleANGLE));
			}
			if (SuportedExt.Contains("glRenderbufferStorageMultisampleAPPLE"))
			{
				dgtk.OpenGL.internalGLES.glRenderbufferStorageMultisampleAPPLE = (dgtk.OpenGL.delegatesGLES.glRenderbufferStorageMultisampleAPPLE) InternalGLesTool.GetGLesMethodAdress("glRenderbufferStorageMultisampleAPPLE", typeof(dgtk.OpenGL.delegatesGLES.glRenderbufferStorageMultisampleAPPLE));
			}
			if (SuportedExt.Contains("glRenderbufferStorageMultisampleEXT"))
			{
				dgtk.OpenGL.internalGLES.glRenderbufferStorageMultisampleEXT = (dgtk.OpenGL.delegatesGLES.glRenderbufferStorageMultisampleEXT) InternalGLesTool.GetGLesMethodAdress("glRenderbufferStorageMultisampleEXT", typeof(dgtk.OpenGL.delegatesGLES.glRenderbufferStorageMultisampleEXT));
			}
			if (SuportedExt.Contains("glRenderbufferStorageMultisampleIMG"))
			{
				dgtk.OpenGL.internalGLES.glRenderbufferStorageMultisampleIMG = (dgtk.OpenGL.delegatesGLES.glRenderbufferStorageMultisampleIMG) InternalGLesTool.GetGLesMethodAdress("glRenderbufferStorageMultisampleIMG", typeof(dgtk.OpenGL.delegatesGLES.glRenderbufferStorageMultisampleIMG));
			}
			if (SuportedExt.Contains("glRenderbufferStorageMultisampleNV"))
			{
				dgtk.OpenGL.internalGLES.glRenderbufferStorageMultisampleNV = (dgtk.OpenGL.delegatesGLES.glRenderbufferStorageMultisampleNV) InternalGLesTool.GetGLesMethodAdress("glRenderbufferStorageMultisampleNV", typeof(dgtk.OpenGL.delegatesGLES.glRenderbufferStorageMultisampleNV));
			}
			if (SuportedExt.Contains("glRenderbufferStorageOES"))
			{
				dgtk.OpenGL.internalGLES.glRenderbufferStorageOES = (dgtk.OpenGL.delegatesGLES.glRenderbufferStorageOES) InternalGLesTool.GetGLesMethodAdress("glRenderbufferStorageOES", typeof(dgtk.OpenGL.delegatesGLES.glRenderbufferStorageOES));
			}
			if (SuportedExt.Contains("glResetMemoryObjectParameterNV"))
			{
				dgtk.OpenGL.internalGLES.glResetMemoryObjectParameterNV = (dgtk.OpenGL.delegatesGLES.glResetMemoryObjectParameterNV) InternalGLesTool.GetGLesMethodAdress("glResetMemoryObjectParameterNV", typeof(dgtk.OpenGL.delegatesGLES.glResetMemoryObjectParameterNV));
			}
			if (SuportedExt.Contains("glResolveDepthValuesNV"))
			{
				dgtk.OpenGL.internalGLES.glResolveDepthValuesNV = (dgtk.OpenGL.delegatesGLES.glResolveDepthValuesNV) InternalGLesTool.GetGLesMethodAdress("glResolveDepthValuesNV", typeof(dgtk.OpenGL.delegatesGLES.glResolveDepthValuesNV));
			}
			if (SuportedExt.Contains("glResolveMultisampleFramebufferAPPLE"))
			{
				dgtk.OpenGL.internalGLES.glResolveMultisampleFramebufferAPPLE = (dgtk.OpenGL.delegatesGLES.glResolveMultisampleFramebufferAPPLE) InternalGLesTool.GetGLesMethodAdress("glResolveMultisampleFramebufferAPPLE", typeof(dgtk.OpenGL.delegatesGLES.glResolveMultisampleFramebufferAPPLE));
			}
			if (SuportedExt.Contains("glRotatexOES"))
			{
				dgtk.OpenGL.internalGLES.glRotatexOES = (dgtk.OpenGL.delegatesGLES.glRotatexOES) InternalGLesTool.GetGLesMethodAdress("glRotatexOES", typeof(dgtk.OpenGL.delegatesGLES.glRotatexOES));
			}
			#endregion

			#region S:

			if (SuportedExt.Contains("glSampleCoveragexOES"))
			{
				dgtk.OpenGL.internalGLES.glSampleCoveragexOES = (dgtk.OpenGL.delegatesGLES.glSampleCoveragexOES) InternalGLesTool.GetGLesMethodAdress("glSampleCoveragexOES", typeof(dgtk.OpenGL.delegatesGLES.glSampleCoveragexOES));
			}
			if (SuportedExt.Contains("glSamplerParameterIivEXT"))
			{
				dgtk.OpenGL.internalGLES.glSamplerParameterIivEXT = (dgtk.OpenGL.delegatesGLES.glSamplerParameterIivEXT) InternalGLesTool.GetGLesMethodAdress("glSamplerParameterIivEXT", typeof(dgtk.OpenGL.delegatesGLES.glSamplerParameterIivEXT));
			}
			if (SuportedExt.Contains("glSamplerParameterIivOES"))
			{
				dgtk.OpenGL.internalGLES.glSamplerParameterIivOES = (dgtk.OpenGL.delegatesGLES.glSamplerParameterIivOES) InternalGLesTool.GetGLesMethodAdress("glSamplerParameterIivOES", typeof(dgtk.OpenGL.delegatesGLES.glSamplerParameterIivOES));
			}
			if (SuportedExt.Contains("glSamplerParameterIuivEXT"))
			{
				dgtk.OpenGL.internalGLES.glSamplerParameterIuivEXT = (dgtk.OpenGL.delegatesGLES.glSamplerParameterIuivEXT) InternalGLesTool.GetGLesMethodAdress("glSamplerParameterIuivEXT", typeof(dgtk.OpenGL.delegatesGLES.glSamplerParameterIuivEXT));
			}
			if (SuportedExt.Contains("glSamplerParameterIuivOES"))
			{
				dgtk.OpenGL.internalGLES.glSamplerParameterIuivOES = (dgtk.OpenGL.delegatesGLES.glSamplerParameterIuivOES) InternalGLesTool.GetGLesMethodAdress("glSamplerParameterIuivOES", typeof(dgtk.OpenGL.delegatesGLES.glSamplerParameterIuivOES));
			}
			if (SuportedExt.Contains("glScalexOES"))
			{
				dgtk.OpenGL.internalGLES.glScalexOES = (dgtk.OpenGL.delegatesGLES.glScalexOES) InternalGLesTool.GetGLesMethodAdress("glScalexOES", typeof(dgtk.OpenGL.delegatesGLES.glScalexOES));
			}
			if (SuportedExt.Contains("glScissorArrayvNV"))
			{
				dgtk.OpenGL.internalGLES.glScissorArrayvNV = (dgtk.OpenGL.delegatesGLES.glScissorArrayvNV) InternalGLesTool.GetGLesMethodAdress("glScissorArrayvNV", typeof(dgtk.OpenGL.delegatesGLES.glScissorArrayvNV));
			}
			if (SuportedExt.Contains("glScissorArrayvOES"))
			{
				dgtk.OpenGL.internalGLES.glScissorArrayvOES = (dgtk.OpenGL.delegatesGLES.glScissorArrayvOES) InternalGLesTool.GetGLesMethodAdress("glScissorArrayvOES", typeof(dgtk.OpenGL.delegatesGLES.glScissorArrayvOES));
			}
			if (SuportedExt.Contains("glScissorExclusiveArrayvNV"))
			{
				dgtk.OpenGL.internalGLES.glScissorExclusiveArrayvNV = (dgtk.OpenGL.delegatesGLES.glScissorExclusiveArrayvNV) InternalGLesTool.GetGLesMethodAdress("glScissorExclusiveArrayvNV", typeof(dgtk.OpenGL.delegatesGLES.glScissorExclusiveArrayvNV));
			}
			if (SuportedExt.Contains("glScissorExclusiveNV"))
			{
				dgtk.OpenGL.internalGLES.glScissorExclusiveNV = (dgtk.OpenGL.delegatesGLES.glScissorExclusiveNV) InternalGLesTool.GetGLesMethodAdress("glScissorExclusiveNV", typeof(dgtk.OpenGL.delegatesGLES.glScissorExclusiveNV));
			}
			if (SuportedExt.Contains("glScissorIndexedNV"))
			{
				dgtk.OpenGL.internalGLES.glScissorIndexedNV = (dgtk.OpenGL.delegatesGLES.glScissorIndexedNV) InternalGLesTool.GetGLesMethodAdress("glScissorIndexedNV", typeof(dgtk.OpenGL.delegatesGLES.glScissorIndexedNV));
			}
			if (SuportedExt.Contains("glScissorIndexedOES"))
			{
				dgtk.OpenGL.internalGLES.glScissorIndexedOES = (dgtk.OpenGL.delegatesGLES.glScissorIndexedOES) InternalGLesTool.GetGLesMethodAdress("glScissorIndexedOES", typeof(dgtk.OpenGL.delegatesGLES.glScissorIndexedOES));
			}
			if (SuportedExt.Contains("glScissorIndexedvNV"))
			{
				dgtk.OpenGL.internalGLES.glScissorIndexedvNV = (dgtk.OpenGL.delegatesGLES.glScissorIndexedvNV) InternalGLesTool.GetGLesMethodAdress("glScissorIndexedvNV", typeof(dgtk.OpenGL.delegatesGLES.glScissorIndexedvNV));
			}
			if (SuportedExt.Contains("glScissorIndexedvOES"))
			{
				dgtk.OpenGL.internalGLES.glScissorIndexedvOES = (dgtk.OpenGL.delegatesGLES.glScissorIndexedvOES) InternalGLesTool.GetGLesMethodAdress("glScissorIndexedvOES", typeof(dgtk.OpenGL.delegatesGLES.glScissorIndexedvOES));
			}
			if (SuportedExt.Contains("glSelectPerfMonitorCountersAMD"))
			{
				dgtk.OpenGL.internalGLES.glSelectPerfMonitorCountersAMD = (dgtk.OpenGL.delegatesGLES.glSelectPerfMonitorCountersAMD) InternalGLesTool.GetGLesMethodAdress("glSelectPerfMonitorCountersAMD", typeof(dgtk.OpenGL.delegatesGLES.glSelectPerfMonitorCountersAMD));
			}
			if (SuportedExt.Contains("glSemaphoreParameterivNV"))
			{
				dgtk.OpenGL.internalGLES.glSemaphoreParameterivNV = (dgtk.OpenGL.delegatesGLES.glSemaphoreParameterivNV) InternalGLesTool.GetGLesMethodAdress("glSemaphoreParameterivNV", typeof(dgtk.OpenGL.delegatesGLES.glSemaphoreParameterivNV));
			}
			if (SuportedExt.Contains("glSemaphoreParameterui64vEXT"))
			{
				dgtk.OpenGL.internalGLES.glSemaphoreParameterui64vEXT = (dgtk.OpenGL.delegatesGLES.glSemaphoreParameterui64vEXT) InternalGLesTool.GetGLesMethodAdress("glSemaphoreParameterui64vEXT", typeof(dgtk.OpenGL.delegatesGLES.glSemaphoreParameterui64vEXT));
			}
			if (SuportedExt.Contains("glSetFenceNV"))
			{
				dgtk.OpenGL.internalGLES.glSetFenceNV = (dgtk.OpenGL.delegatesGLES.glSetFenceNV) InternalGLesTool.GetGLesMethodAdress("glSetFenceNV", typeof(dgtk.OpenGL.delegatesGLES.glSetFenceNV));
			}
			if (SuportedExt.Contains("glShadingRateCombinerOpsEXT"))
			{
				dgtk.OpenGL.internalGLES.glShadingRateCombinerOpsEXT = (dgtk.OpenGL.delegatesGLES.glShadingRateCombinerOpsEXT) InternalGLesTool.GetGLesMethodAdress("glShadingRateCombinerOpsEXT", typeof(dgtk.OpenGL.delegatesGLES.glShadingRateCombinerOpsEXT));
			}
			if (SuportedExt.Contains("glShadingRateEXT"))
			{
				dgtk.OpenGL.internalGLES.glShadingRateEXT = (dgtk.OpenGL.delegatesGLES.glShadingRateEXT) InternalGLesTool.GetGLesMethodAdress("glShadingRateEXT", typeof(dgtk.OpenGL.delegatesGLES.glShadingRateEXT));
			}
			if (SuportedExt.Contains("glShadingRateImageBarrierNV"))
			{
				dgtk.OpenGL.internalGLES.glShadingRateImageBarrierNV = (dgtk.OpenGL.delegatesGLES.glShadingRateImageBarrierNV) InternalGLesTool.GetGLesMethodAdress("glShadingRateImageBarrierNV", typeof(dgtk.OpenGL.delegatesGLES.glShadingRateImageBarrierNV));
			}
			if (SuportedExt.Contains("glShadingRateImagePaletteNV"))
			{
				dgtk.OpenGL.internalGLES.glShadingRateImagePaletteNV = (dgtk.OpenGL.delegatesGLES.glShadingRateImagePaletteNV) InternalGLesTool.GetGLesMethodAdress("glShadingRateImagePaletteNV", typeof(dgtk.OpenGL.delegatesGLES.glShadingRateImagePaletteNV));
			}
			if (SuportedExt.Contains("glShadingRateQCOM"))
			{
				dgtk.OpenGL.internalGLES.glShadingRateQCOM = (dgtk.OpenGL.delegatesGLES.glShadingRateQCOM) InternalGLesTool.GetGLesMethodAdress("glShadingRateQCOM", typeof(dgtk.OpenGL.delegatesGLES.glShadingRateQCOM));
			}
			if (SuportedExt.Contains("glShadingRateSampleOrderCustomNV"))
			{
				dgtk.OpenGL.internalGLES.glShadingRateSampleOrderCustomNV = (dgtk.OpenGL.delegatesGLES.glShadingRateSampleOrderCustomNV) InternalGLesTool.GetGLesMethodAdress("glShadingRateSampleOrderCustomNV", typeof(dgtk.OpenGL.delegatesGLES.glShadingRateSampleOrderCustomNV));
			}
			if (SuportedExt.Contains("glShadingRateSampleOrderNV"))
			{
				dgtk.OpenGL.internalGLES.glShadingRateSampleOrderNV = (dgtk.OpenGL.delegatesGLES.glShadingRateSampleOrderNV) InternalGLesTool.GetGLesMethodAdress("glShadingRateSampleOrderNV", typeof(dgtk.OpenGL.delegatesGLES.glShadingRateSampleOrderNV));
			}
			if (SuportedExt.Contains("glSignalSemaphoreEXT"))
			{
				dgtk.OpenGL.internalGLES.glSignalSemaphoreEXT = (dgtk.OpenGL.delegatesGLES.glSignalSemaphoreEXT) InternalGLesTool.GetGLesMethodAdress("glSignalSemaphoreEXT", typeof(dgtk.OpenGL.delegatesGLES.glSignalSemaphoreEXT));
			}
			if (SuportedExt.Contains("glSignalVkFenceNV"))
			{
				dgtk.OpenGL.internalGLES.glSignalVkFenceNV = (dgtk.OpenGL.delegatesGLES.glSignalVkFenceNV) InternalGLesTool.GetGLesMethodAdress("glSignalVkFenceNV", typeof(dgtk.OpenGL.delegatesGLES.glSignalVkFenceNV));
			}
			if (SuportedExt.Contains("glSignalVkSemaphoreNV"))
			{
				dgtk.OpenGL.internalGLES.glSignalVkSemaphoreNV = (dgtk.OpenGL.delegatesGLES.glSignalVkSemaphoreNV) InternalGLesTool.GetGLesMethodAdress("glSignalVkSemaphoreNV", typeof(dgtk.OpenGL.delegatesGLES.glSignalVkSemaphoreNV));
			}
			if (SuportedExt.Contains("glStartTilingQCOM"))
			{
				dgtk.OpenGL.internalGLES.glStartTilingQCOM = (dgtk.OpenGL.delegatesGLES.glStartTilingQCOM) InternalGLesTool.GetGLesMethodAdress("glStartTilingQCOM", typeof(dgtk.OpenGL.delegatesGLES.glStartTilingQCOM));
			}
			if (SuportedExt.Contains("glStencilFillPathInstancedNV"))
			{
				dgtk.OpenGL.internalGLES.glStencilFillPathInstancedNV = (dgtk.OpenGL.delegatesGLES.glStencilFillPathInstancedNV) InternalGLesTool.GetGLesMethodAdress("glStencilFillPathInstancedNV", typeof(dgtk.OpenGL.delegatesGLES.glStencilFillPathInstancedNV));
			}
			if (SuportedExt.Contains("glStencilFillPathNV"))
			{
				dgtk.OpenGL.internalGLES.glStencilFillPathNV = (dgtk.OpenGL.delegatesGLES.glStencilFillPathNV) InternalGLesTool.GetGLesMethodAdress("glStencilFillPathNV", typeof(dgtk.OpenGL.delegatesGLES.glStencilFillPathNV));
			}
			if (SuportedExt.Contains("glStencilStrokePathInstancedNV"))
			{
				dgtk.OpenGL.internalGLES.glStencilStrokePathInstancedNV = (dgtk.OpenGL.delegatesGLES.glStencilStrokePathInstancedNV) InternalGLesTool.GetGLesMethodAdress("glStencilStrokePathInstancedNV", typeof(dgtk.OpenGL.delegatesGLES.glStencilStrokePathInstancedNV));
			}
			if (SuportedExt.Contains("glStencilStrokePathNV"))
			{
				dgtk.OpenGL.internalGLES.glStencilStrokePathNV = (dgtk.OpenGL.delegatesGLES.glStencilStrokePathNV) InternalGLesTool.GetGLesMethodAdress("glStencilStrokePathNV", typeof(dgtk.OpenGL.delegatesGLES.glStencilStrokePathNV));
			}
			if (SuportedExt.Contains("glStencilThenCoverFillPathInstancedNV"))
			{
				dgtk.OpenGL.internalGLES.glStencilThenCoverFillPathInstancedNV = (dgtk.OpenGL.delegatesGLES.glStencilThenCoverFillPathInstancedNV) InternalGLesTool.GetGLesMethodAdress("glStencilThenCoverFillPathInstancedNV", typeof(dgtk.OpenGL.delegatesGLES.glStencilThenCoverFillPathInstancedNV));
			}
			if (SuportedExt.Contains("glStencilThenCoverFillPathNV"))
			{
				dgtk.OpenGL.internalGLES.glStencilThenCoverFillPathNV = (dgtk.OpenGL.delegatesGLES.glStencilThenCoverFillPathNV) InternalGLesTool.GetGLesMethodAdress("glStencilThenCoverFillPathNV", typeof(dgtk.OpenGL.delegatesGLES.glStencilThenCoverFillPathNV));
			}
			if (SuportedExt.Contains("glStencilThenCoverStrokePathInstancedNV"))
			{
				dgtk.OpenGL.internalGLES.glStencilThenCoverStrokePathInstancedNV = (dgtk.OpenGL.delegatesGLES.glStencilThenCoverStrokePathInstancedNV) InternalGLesTool.GetGLesMethodAdress("glStencilThenCoverStrokePathInstancedNV", typeof(dgtk.OpenGL.delegatesGLES.glStencilThenCoverStrokePathInstancedNV));
			}
			if (SuportedExt.Contains("glStencilThenCoverStrokePathNV"))
			{
				dgtk.OpenGL.internalGLES.glStencilThenCoverStrokePathNV = (dgtk.OpenGL.delegatesGLES.glStencilThenCoverStrokePathNV) InternalGLesTool.GetGLesMethodAdress("glStencilThenCoverStrokePathNV", typeof(dgtk.OpenGL.delegatesGLES.glStencilThenCoverStrokePathNV));
			}
			if (SuportedExt.Contains("glSubpixelPrecisionBiasNV"))
			{
				dgtk.OpenGL.internalGLES.glSubpixelPrecisionBiasNV = (dgtk.OpenGL.delegatesGLES.glSubpixelPrecisionBiasNV) InternalGLesTool.GetGLesMethodAdress("glSubpixelPrecisionBiasNV", typeof(dgtk.OpenGL.delegatesGLES.glSubpixelPrecisionBiasNV));
			}
			#endregion

			#region T:

			if (SuportedExt.Contains("glTestFenceNV"))
			{
				dgtk.OpenGL.internalGLES.glTestFenceNV = (dgtk.OpenGL.delegatesGLES.glTestFenceNV) InternalGLesTool.GetGLesMethodAdress("glTestFenceNV", typeof(dgtk.OpenGL.delegatesGLES.glTestFenceNV));
			}
			if (SuportedExt.Contains("glTexAttachMemoryNV"))
			{
				dgtk.OpenGL.internalGLES.glTexAttachMemoryNV = (dgtk.OpenGL.delegatesGLES.glTexAttachMemoryNV) InternalGLesTool.GetGLesMethodAdress("glTexAttachMemoryNV", typeof(dgtk.OpenGL.delegatesGLES.glTexAttachMemoryNV));
			}
			if (SuportedExt.Contains("glTexBufferEXT"))
			{
				dgtk.OpenGL.internalGLES.glTexBufferEXT = (dgtk.OpenGL.delegatesGLES.glTexBufferEXT) InternalGLesTool.GetGLesMethodAdress("glTexBufferEXT", typeof(dgtk.OpenGL.delegatesGLES.glTexBufferEXT));
			}
			if (SuportedExt.Contains("glTexBufferOES"))
			{
				dgtk.OpenGL.internalGLES.glTexBufferOES = (dgtk.OpenGL.delegatesGLES.glTexBufferOES) InternalGLesTool.GetGLesMethodAdress("glTexBufferOES", typeof(dgtk.OpenGL.delegatesGLES.glTexBufferOES));
			}
			if (SuportedExt.Contains("glTexBufferRangeEXT"))
			{
				dgtk.OpenGL.internalGLES.glTexBufferRangeEXT = (dgtk.OpenGL.delegatesGLES.glTexBufferRangeEXT) InternalGLesTool.GetGLesMethodAdress("glTexBufferRangeEXT", typeof(dgtk.OpenGL.delegatesGLES.glTexBufferRangeEXT));
			}
			if (SuportedExt.Contains("glTexBufferRangeOES"))
			{
				dgtk.OpenGL.internalGLES.glTexBufferRangeOES = (dgtk.OpenGL.delegatesGLES.glTexBufferRangeOES) InternalGLesTool.GetGLesMethodAdress("glTexBufferRangeOES", typeof(dgtk.OpenGL.delegatesGLES.glTexBufferRangeOES));
			}
			if (SuportedExt.Contains("glTexCoord1bOES"))
			{
				dgtk.OpenGL.internalGLES.glTexCoord1bOES = (dgtk.OpenGL.delegatesGLES.glTexCoord1bOES) InternalGLesTool.GetGLesMethodAdress("glTexCoord1bOES", typeof(dgtk.OpenGL.delegatesGLES.glTexCoord1bOES));
			}
			if (SuportedExt.Contains("glTexCoord1bvOES"))
			{
				dgtk.OpenGL.internalGLES.glTexCoord1bvOES = (dgtk.OpenGL.delegatesGLES.glTexCoord1bvOES) InternalGLesTool.GetGLesMethodAdress("glTexCoord1bvOES", typeof(dgtk.OpenGL.delegatesGLES.glTexCoord1bvOES));
			}
			if (SuportedExt.Contains("glTexCoord1xOES"))
			{
				dgtk.OpenGL.internalGLES.glTexCoord1xOES = (dgtk.OpenGL.delegatesGLES.glTexCoord1xOES) InternalGLesTool.GetGLesMethodAdress("glTexCoord1xOES", typeof(dgtk.OpenGL.delegatesGLES.glTexCoord1xOES));
			}
			if (SuportedExt.Contains("glTexCoord1xvOES"))
			{
				dgtk.OpenGL.internalGLES.glTexCoord1xvOES = (dgtk.OpenGL.delegatesGLES.glTexCoord1xvOES) InternalGLesTool.GetGLesMethodAdress("glTexCoord1xvOES", typeof(dgtk.OpenGL.delegatesGLES.glTexCoord1xvOES));
			}
			if (SuportedExt.Contains("glTexCoord2bOES"))
			{
				dgtk.OpenGL.internalGLES.glTexCoord2bOES = (dgtk.OpenGL.delegatesGLES.glTexCoord2bOES) InternalGLesTool.GetGLesMethodAdress("glTexCoord2bOES", typeof(dgtk.OpenGL.delegatesGLES.glTexCoord2bOES));
			}
			if (SuportedExt.Contains("glTexCoord2bvOES"))
			{
				dgtk.OpenGL.internalGLES.glTexCoord2bvOES = (dgtk.OpenGL.delegatesGLES.glTexCoord2bvOES) InternalGLesTool.GetGLesMethodAdress("glTexCoord2bvOES", typeof(dgtk.OpenGL.delegatesGLES.glTexCoord2bvOES));
			}
			if (SuportedExt.Contains("glTexCoord2xOES"))
			{
				dgtk.OpenGL.internalGLES.glTexCoord2xOES = (dgtk.OpenGL.delegatesGLES.glTexCoord2xOES) InternalGLesTool.GetGLesMethodAdress("glTexCoord2xOES", typeof(dgtk.OpenGL.delegatesGLES.glTexCoord2xOES));
			}
			if (SuportedExt.Contains("glTexCoord2xvOES"))
			{
				dgtk.OpenGL.internalGLES.glTexCoord2xvOES = (dgtk.OpenGL.delegatesGLES.glTexCoord2xvOES) InternalGLesTool.GetGLesMethodAdress("glTexCoord2xvOES", typeof(dgtk.OpenGL.delegatesGLES.glTexCoord2xvOES));
			}
			if (SuportedExt.Contains("glTexCoord3bOES"))
			{
				dgtk.OpenGL.internalGLES.glTexCoord3bOES = (dgtk.OpenGL.delegatesGLES.glTexCoord3bOES) InternalGLesTool.GetGLesMethodAdress("glTexCoord3bOES", typeof(dgtk.OpenGL.delegatesGLES.glTexCoord3bOES));
			}
			if (SuportedExt.Contains("glTexCoord3bvOES"))
			{
				dgtk.OpenGL.internalGLES.glTexCoord3bvOES = (dgtk.OpenGL.delegatesGLES.glTexCoord3bvOES) InternalGLesTool.GetGLesMethodAdress("glTexCoord3bvOES", typeof(dgtk.OpenGL.delegatesGLES.glTexCoord3bvOES));
			}
			if (SuportedExt.Contains("glTexCoord3xOES"))
			{
				dgtk.OpenGL.internalGLES.glTexCoord3xOES = (dgtk.OpenGL.delegatesGLES.glTexCoord3xOES) InternalGLesTool.GetGLesMethodAdress("glTexCoord3xOES", typeof(dgtk.OpenGL.delegatesGLES.glTexCoord3xOES));
			}
			if (SuportedExt.Contains("glTexCoord3xvOES"))
			{
				dgtk.OpenGL.internalGLES.glTexCoord3xvOES = (dgtk.OpenGL.delegatesGLES.glTexCoord3xvOES) InternalGLesTool.GetGLesMethodAdress("glTexCoord3xvOES", typeof(dgtk.OpenGL.delegatesGLES.glTexCoord3xvOES));
			}
			if (SuportedExt.Contains("glTexCoord4bOES"))
			{
				dgtk.OpenGL.internalGLES.glTexCoord4bOES = (dgtk.OpenGL.delegatesGLES.glTexCoord4bOES) InternalGLesTool.GetGLesMethodAdress("glTexCoord4bOES", typeof(dgtk.OpenGL.delegatesGLES.glTexCoord4bOES));
			}
			if (SuportedExt.Contains("glTexCoord4bvOES"))
			{
				dgtk.OpenGL.internalGLES.glTexCoord4bvOES = (dgtk.OpenGL.delegatesGLES.glTexCoord4bvOES) InternalGLesTool.GetGLesMethodAdress("glTexCoord4bvOES", typeof(dgtk.OpenGL.delegatesGLES.glTexCoord4bvOES));
			}
			if (SuportedExt.Contains("glTexCoord4xOES"))
			{
				dgtk.OpenGL.internalGLES.glTexCoord4xOES = (dgtk.OpenGL.delegatesGLES.glTexCoord4xOES) InternalGLesTool.GetGLesMethodAdress("glTexCoord4xOES", typeof(dgtk.OpenGL.delegatesGLES.glTexCoord4xOES));
			}
			if (SuportedExt.Contains("glTexCoord4xvOES"))
			{
				dgtk.OpenGL.internalGLES.glTexCoord4xvOES = (dgtk.OpenGL.delegatesGLES.glTexCoord4xvOES) InternalGLesTool.GetGLesMethodAdress("glTexCoord4xvOES", typeof(dgtk.OpenGL.delegatesGLES.glTexCoord4xvOES));
			}
			if (SuportedExt.Contains("glTexEnvxOES"))
			{
				dgtk.OpenGL.internalGLES.glTexEnvxOES = (dgtk.OpenGL.delegatesGLES.glTexEnvxOES) InternalGLesTool.GetGLesMethodAdress("glTexEnvxOES", typeof(dgtk.OpenGL.delegatesGLES.glTexEnvxOES));
			}
			if (SuportedExt.Contains("glTexEnvxvOES"))
			{
				dgtk.OpenGL.internalGLES.glTexEnvxvOES = (dgtk.OpenGL.delegatesGLES.glTexEnvxvOES) InternalGLesTool.GetGLesMethodAdress("glTexEnvxvOES", typeof(dgtk.OpenGL.delegatesGLES.glTexEnvxvOES));
			}
			if (SuportedExt.Contains("glTexEstimateMotionQCOM"))
			{
				dgtk.OpenGL.internalGLES.glTexEstimateMotionQCOM = (dgtk.OpenGL.delegatesGLES.glTexEstimateMotionQCOM) InternalGLesTool.GetGLesMethodAdress("glTexEstimateMotionQCOM", typeof(dgtk.OpenGL.delegatesGLES.glTexEstimateMotionQCOM));
			}
			if (SuportedExt.Contains("glTexEstimateMotionRegionsQCOM"))
			{
				dgtk.OpenGL.internalGLES.glTexEstimateMotionRegionsQCOM = (dgtk.OpenGL.delegatesGLES.glTexEstimateMotionRegionsQCOM) InternalGLesTool.GetGLesMethodAdress("glTexEstimateMotionRegionsQCOM", typeof(dgtk.OpenGL.delegatesGLES.glTexEstimateMotionRegionsQCOM));
			}
			if (SuportedExt.Contains("glTexGenfOES"))
			{
				dgtk.OpenGL.internalGLES.glTexGenfOES = (dgtk.OpenGL.delegatesGLES.glTexGenfOES) InternalGLesTool.GetGLesMethodAdress("glTexGenfOES", typeof(dgtk.OpenGL.delegatesGLES.glTexGenfOES));
			}
			if (SuportedExt.Contains("glTexGenfvOES"))
			{
				dgtk.OpenGL.internalGLES.glTexGenfvOES = (dgtk.OpenGL.delegatesGLES.glTexGenfvOES) InternalGLesTool.GetGLesMethodAdress("glTexGenfvOES", typeof(dgtk.OpenGL.delegatesGLES.glTexGenfvOES));
			}
			if (SuportedExt.Contains("glTexGeniOES"))
			{
				dgtk.OpenGL.internalGLES.glTexGeniOES = (dgtk.OpenGL.delegatesGLES.glTexGeniOES) InternalGLesTool.GetGLesMethodAdress("glTexGeniOES", typeof(dgtk.OpenGL.delegatesGLES.glTexGeniOES));
			}
			if (SuportedExt.Contains("glTexGenivOES"))
			{
				dgtk.OpenGL.internalGLES.glTexGenivOES = (dgtk.OpenGL.delegatesGLES.glTexGenivOES) InternalGLesTool.GetGLesMethodAdress("glTexGenivOES", typeof(dgtk.OpenGL.delegatesGLES.glTexGenivOES));
			}
			if (SuportedExt.Contains("glTexGenxOES"))
			{
				dgtk.OpenGL.internalGLES.glTexGenxOES = (dgtk.OpenGL.delegatesGLES.glTexGenxOES) InternalGLesTool.GetGLesMethodAdress("glTexGenxOES", typeof(dgtk.OpenGL.delegatesGLES.glTexGenxOES));
			}
			if (SuportedExt.Contains("glTexGenxvOES"))
			{
				dgtk.OpenGL.internalGLES.glTexGenxvOES = (dgtk.OpenGL.delegatesGLES.glTexGenxvOES) InternalGLesTool.GetGLesMethodAdress("glTexGenxvOES", typeof(dgtk.OpenGL.delegatesGLES.glTexGenxvOES));
			}
			if (SuportedExt.Contains("glTexImage3DOES"))
			{
				dgtk.OpenGL.internalGLES.glTexImage3DOES = (dgtk.OpenGL.delegatesGLES.glTexImage3DOES) InternalGLesTool.GetGLesMethodAdress("glTexImage3DOES", typeof(dgtk.OpenGL.delegatesGLES.glTexImage3DOES));
			}
			if (SuportedExt.Contains("glTexPageCommitmentEXT"))
			{
				dgtk.OpenGL.internalGLES.glTexPageCommitmentEXT = (dgtk.OpenGL.delegatesGLES.glTexPageCommitmentEXT) InternalGLesTool.GetGLesMethodAdress("glTexPageCommitmentEXT", typeof(dgtk.OpenGL.delegatesGLES.glTexPageCommitmentEXT));
			}
			if (SuportedExt.Contains("glTexPageCommitmentMemNV"))
			{
				dgtk.OpenGL.internalGLES.glTexPageCommitmentMemNV = (dgtk.OpenGL.delegatesGLES.glTexPageCommitmentMemNV) InternalGLesTool.GetGLesMethodAdress("glTexPageCommitmentMemNV", typeof(dgtk.OpenGL.delegatesGLES.glTexPageCommitmentMemNV));
			}
			if (SuportedExt.Contains("glTexParameterIivEXT"))
			{
				dgtk.OpenGL.internalGLES.glTexParameterIivEXT = (dgtk.OpenGL.delegatesGLES.glTexParameterIivEXT) InternalGLesTool.GetGLesMethodAdress("glTexParameterIivEXT", typeof(dgtk.OpenGL.delegatesGLES.glTexParameterIivEXT));
			}
			if (SuportedExt.Contains("glTexParameterIivOES"))
			{
				dgtk.OpenGL.internalGLES.glTexParameterIivOES = (dgtk.OpenGL.delegatesGLES.glTexParameterIivOES) InternalGLesTool.GetGLesMethodAdress("glTexParameterIivOES", typeof(dgtk.OpenGL.delegatesGLES.glTexParameterIivOES));
			}
			if (SuportedExt.Contains("glTexParameterIuivEXT"))
			{
				dgtk.OpenGL.internalGLES.glTexParameterIuivEXT = (dgtk.OpenGL.delegatesGLES.glTexParameterIuivEXT) InternalGLesTool.GetGLesMethodAdress("glTexParameterIuivEXT", typeof(dgtk.OpenGL.delegatesGLES.glTexParameterIuivEXT));
			}
			if (SuportedExt.Contains("glTexParameterIuivOES"))
			{
				dgtk.OpenGL.internalGLES.glTexParameterIuivOES = (dgtk.OpenGL.delegatesGLES.glTexParameterIuivOES) InternalGLesTool.GetGLesMethodAdress("glTexParameterIuivOES", typeof(dgtk.OpenGL.delegatesGLES.glTexParameterIuivOES));
			}
			if (SuportedExt.Contains("glTexParameterxOES"))
			{
				dgtk.OpenGL.internalGLES.glTexParameterxOES = (dgtk.OpenGL.delegatesGLES.glTexParameterxOES) InternalGLesTool.GetGLesMethodAdress("glTexParameterxOES", typeof(dgtk.OpenGL.delegatesGLES.glTexParameterxOES));
			}
			if (SuportedExt.Contains("glTexParameterxvOES"))
			{
				dgtk.OpenGL.internalGLES.glTexParameterxvOES = (dgtk.OpenGL.delegatesGLES.glTexParameterxvOES) InternalGLesTool.GetGLesMethodAdress("glTexParameterxvOES", typeof(dgtk.OpenGL.delegatesGLES.glTexParameterxvOES));
			}
			if (SuportedExt.Contains("glTexStorage1DEXT"))
			{
				dgtk.OpenGL.internalGLES.glTexStorage1DEXT = (dgtk.OpenGL.delegatesGLES.glTexStorage1DEXT) InternalGLesTool.GetGLesMethodAdress("glTexStorage1DEXT", typeof(dgtk.OpenGL.delegatesGLES.glTexStorage1DEXT));
			}
			if (SuportedExt.Contains("glTexStorage2DEXT"))
			{
				dgtk.OpenGL.internalGLES.glTexStorage2DEXT = (dgtk.OpenGL.delegatesGLES.glTexStorage2DEXT) InternalGLesTool.GetGLesMethodAdress("glTexStorage2DEXT", typeof(dgtk.OpenGL.delegatesGLES.glTexStorage2DEXT));
			}
			if (SuportedExt.Contains("glTexStorage3DEXT"))
			{
				dgtk.OpenGL.internalGLES.glTexStorage3DEXT = (dgtk.OpenGL.delegatesGLES.glTexStorage3DEXT) InternalGLesTool.GetGLesMethodAdress("glTexStorage3DEXT", typeof(dgtk.OpenGL.delegatesGLES.glTexStorage3DEXT));
			}
			if (SuportedExt.Contains("glTexStorage3DMultisampleOES"))
			{
				dgtk.OpenGL.internalGLES.glTexStorage3DMultisampleOES = (dgtk.OpenGL.delegatesGLES.glTexStorage3DMultisampleOES) InternalGLesTool.GetGLesMethodAdress("glTexStorage3DMultisampleOES", typeof(dgtk.OpenGL.delegatesGLES.glTexStorage3DMultisampleOES));
			}
			if (SuportedExt.Contains("glTexStorageAttribs2DEXT"))
			{
				dgtk.OpenGL.internalGLES.glTexStorageAttribs2DEXT = (dgtk.OpenGL.delegatesGLES.glTexStorageAttribs2DEXT) InternalGLesTool.GetGLesMethodAdress("glTexStorageAttribs2DEXT", typeof(dgtk.OpenGL.delegatesGLES.glTexStorageAttribs2DEXT));
			}
			if (SuportedExt.Contains("glTexStorageAttribs3DEXT"))
			{
				dgtk.OpenGL.internalGLES.glTexStorageAttribs3DEXT = (dgtk.OpenGL.delegatesGLES.glTexStorageAttribs3DEXT) InternalGLesTool.GetGLesMethodAdress("glTexStorageAttribs3DEXT", typeof(dgtk.OpenGL.delegatesGLES.glTexStorageAttribs3DEXT));
			}
			if (SuportedExt.Contains("glTexStorageMem1DEXT"))
			{
				dgtk.OpenGL.internalGLES.glTexStorageMem1DEXT = (dgtk.OpenGL.delegatesGLES.glTexStorageMem1DEXT) InternalGLesTool.GetGLesMethodAdress("glTexStorageMem1DEXT", typeof(dgtk.OpenGL.delegatesGLES.glTexStorageMem1DEXT));
			}
			if (SuportedExt.Contains("glTexStorageMem2DEXT"))
			{
				dgtk.OpenGL.internalGLES.glTexStorageMem2DEXT = (dgtk.OpenGL.delegatesGLES.glTexStorageMem2DEXT) InternalGLesTool.GetGLesMethodAdress("glTexStorageMem2DEXT", typeof(dgtk.OpenGL.delegatesGLES.glTexStorageMem2DEXT));
			}
			if (SuportedExt.Contains("glTexStorageMem2DMultisampleEXT"))
			{
				dgtk.OpenGL.internalGLES.glTexStorageMem2DMultisampleEXT = (dgtk.OpenGL.delegatesGLES.glTexStorageMem2DMultisampleEXT) InternalGLesTool.GetGLesMethodAdress("glTexStorageMem2DMultisampleEXT", typeof(dgtk.OpenGL.delegatesGLES.glTexStorageMem2DMultisampleEXT));
			}
			if (SuportedExt.Contains("glTexStorageMem3DEXT"))
			{
				dgtk.OpenGL.internalGLES.glTexStorageMem3DEXT = (dgtk.OpenGL.delegatesGLES.glTexStorageMem3DEXT) InternalGLesTool.GetGLesMethodAdress("glTexStorageMem3DEXT", typeof(dgtk.OpenGL.delegatesGLES.glTexStorageMem3DEXT));
			}
			if (SuportedExt.Contains("glTexStorageMem3DMultisampleEXT"))
			{
				dgtk.OpenGL.internalGLES.glTexStorageMem3DMultisampleEXT = (dgtk.OpenGL.delegatesGLES.glTexStorageMem3DMultisampleEXT) InternalGLesTool.GetGLesMethodAdress("glTexStorageMem3DMultisampleEXT", typeof(dgtk.OpenGL.delegatesGLES.glTexStorageMem3DMultisampleEXT));
			}
			if (SuportedExt.Contains("glTexSubImage3DOES"))
			{
				dgtk.OpenGL.internalGLES.glTexSubImage3DOES = (dgtk.OpenGL.delegatesGLES.glTexSubImage3DOES) InternalGLesTool.GetGLesMethodAdress("glTexSubImage3DOES", typeof(dgtk.OpenGL.delegatesGLES.glTexSubImage3DOES));
			}
			if (SuportedExt.Contains("glTextureAttachMemoryNV"))
			{
				dgtk.OpenGL.internalGLES.glTextureAttachMemoryNV = (dgtk.OpenGL.delegatesGLES.glTextureAttachMemoryNV) InternalGLesTool.GetGLesMethodAdress("glTextureAttachMemoryNV", typeof(dgtk.OpenGL.delegatesGLES.glTextureAttachMemoryNV));
			}
			if (SuportedExt.Contains("glTextureBarrierNV"))
			{
				dgtk.OpenGL.internalGLES.glTextureBarrierNV = (dgtk.OpenGL.delegatesGLES.glTextureBarrierNV) InternalGLesTool.GetGLesMethodAdress("glTextureBarrierNV", typeof(dgtk.OpenGL.delegatesGLES.glTextureBarrierNV));
			}
			if (SuportedExt.Contains("glTextureFoveationParametersQCOM"))
			{
				dgtk.OpenGL.internalGLES.glTextureFoveationParametersQCOM = (dgtk.OpenGL.delegatesGLES.glTextureFoveationParametersQCOM) InternalGLesTool.GetGLesMethodAdress("glTextureFoveationParametersQCOM", typeof(dgtk.OpenGL.delegatesGLES.glTextureFoveationParametersQCOM));
			}
			if (SuportedExt.Contains("glTexturePageCommitmentMemNV"))
			{
				dgtk.OpenGL.internalGLES.glTexturePageCommitmentMemNV = (dgtk.OpenGL.delegatesGLES.glTexturePageCommitmentMemNV) InternalGLesTool.GetGLesMethodAdress("glTexturePageCommitmentMemNV", typeof(dgtk.OpenGL.delegatesGLES.glTexturePageCommitmentMemNV));
			}
			if (SuportedExt.Contains("glTextureStorage1DEXT"))
			{
				dgtk.OpenGL.internalGLES.glTextureStorage1DEXT = (dgtk.OpenGL.delegatesGLES.glTextureStorage1DEXT) InternalGLesTool.GetGLesMethodAdress("glTextureStorage1DEXT", typeof(dgtk.OpenGL.delegatesGLES.glTextureStorage1DEXT));
			}
			if (SuportedExt.Contains("glTextureStorage2DEXT"))
			{
				dgtk.OpenGL.internalGLES.glTextureStorage2DEXT = (dgtk.OpenGL.delegatesGLES.glTextureStorage2DEXT) InternalGLesTool.GetGLesMethodAdress("glTextureStorage2DEXT", typeof(dgtk.OpenGL.delegatesGLES.glTextureStorage2DEXT));
			}
			if (SuportedExt.Contains("glTextureStorage3DEXT"))
			{
				dgtk.OpenGL.internalGLES.glTextureStorage3DEXT = (dgtk.OpenGL.delegatesGLES.glTextureStorage3DEXT) InternalGLesTool.GetGLesMethodAdress("glTextureStorage3DEXT", typeof(dgtk.OpenGL.delegatesGLES.glTextureStorage3DEXT));
			}
			if (SuportedExt.Contains("glTextureStorageMem1DEXT"))
			{
				dgtk.OpenGL.internalGLES.glTextureStorageMem1DEXT = (dgtk.OpenGL.delegatesGLES.glTextureStorageMem1DEXT) InternalGLesTool.GetGLesMethodAdress("glTextureStorageMem1DEXT", typeof(dgtk.OpenGL.delegatesGLES.glTextureStorageMem1DEXT));
			}
			if (SuportedExt.Contains("glTextureStorageMem2DEXT"))
			{
				dgtk.OpenGL.internalGLES.glTextureStorageMem2DEXT = (dgtk.OpenGL.delegatesGLES.glTextureStorageMem2DEXT) InternalGLesTool.GetGLesMethodAdress("glTextureStorageMem2DEXT", typeof(dgtk.OpenGL.delegatesGLES.glTextureStorageMem2DEXT));
			}
			if (SuportedExt.Contains("glTextureStorageMem2DMultisampleEXT"))
			{
				dgtk.OpenGL.internalGLES.glTextureStorageMem2DMultisampleEXT = (dgtk.OpenGL.delegatesGLES.glTextureStorageMem2DMultisampleEXT) InternalGLesTool.GetGLesMethodAdress("glTextureStorageMem2DMultisampleEXT", typeof(dgtk.OpenGL.delegatesGLES.glTextureStorageMem2DMultisampleEXT));
			}
			if (SuportedExt.Contains("glTextureStorageMem3DEXT"))
			{
				dgtk.OpenGL.internalGLES.glTextureStorageMem3DEXT = (dgtk.OpenGL.delegatesGLES.glTextureStorageMem3DEXT) InternalGLesTool.GetGLesMethodAdress("glTextureStorageMem3DEXT", typeof(dgtk.OpenGL.delegatesGLES.glTextureStorageMem3DEXT));
			}
			if (SuportedExt.Contains("glTextureStorageMem3DMultisampleEXT"))
			{
				dgtk.OpenGL.internalGLES.glTextureStorageMem3DMultisampleEXT = (dgtk.OpenGL.delegatesGLES.glTextureStorageMem3DMultisampleEXT) InternalGLesTool.GetGLesMethodAdress("glTextureStorageMem3DMultisampleEXT", typeof(dgtk.OpenGL.delegatesGLES.glTextureStorageMem3DMultisampleEXT));
			}
			if (SuportedExt.Contains("glTextureViewEXT"))
			{
				dgtk.OpenGL.internalGLES.glTextureViewEXT = (dgtk.OpenGL.delegatesGLES.glTextureViewEXT) InternalGLesTool.GetGLesMethodAdress("glTextureViewEXT", typeof(dgtk.OpenGL.delegatesGLES.glTextureViewEXT));
			}
			if (SuportedExt.Contains("glTextureViewOES"))
			{
				dgtk.OpenGL.internalGLES.glTextureViewOES = (dgtk.OpenGL.delegatesGLES.glTextureViewOES) InternalGLesTool.GetGLesMethodAdress("glTextureViewOES", typeof(dgtk.OpenGL.delegatesGLES.glTextureViewOES));
			}
			if (SuportedExt.Contains("glTransformPathNV"))
			{
				dgtk.OpenGL.internalGLES.glTransformPathNV = (dgtk.OpenGL.delegatesGLES.glTransformPathNV) InternalGLesTool.GetGLesMethodAdress("glTransformPathNV", typeof(dgtk.OpenGL.delegatesGLES.glTransformPathNV));
			}
			if (SuportedExt.Contains("glTranslatexOES"))
			{
				dgtk.OpenGL.internalGLES.glTranslatexOES = (dgtk.OpenGL.delegatesGLES.glTranslatexOES) InternalGLesTool.GetGLesMethodAdress("glTranslatexOES", typeof(dgtk.OpenGL.delegatesGLES.glTranslatexOES));
			}
			#endregion

			#region U:

			if (SuportedExt.Contains("glUniform1i64NV"))
			{
				dgtk.OpenGL.internalGLES.glUniform1i64NV = (dgtk.OpenGL.delegatesGLES.glUniform1i64NV) InternalGLesTool.GetGLesMethodAdress("glUniform1i64NV", typeof(dgtk.OpenGL.delegatesGLES.glUniform1i64NV));
			}
			if (SuportedExt.Contains("glUniform1i64vNV"))
			{
				dgtk.OpenGL.internalGLES.glUniform1i64vNV = (dgtk.OpenGL.delegatesGLES.glUniform1i64vNV) InternalGLesTool.GetGLesMethodAdress("glUniform1i64vNV", typeof(dgtk.OpenGL.delegatesGLES.glUniform1i64vNV));
			}
			if (SuportedExt.Contains("glUniform1ui64NV"))
			{
				dgtk.OpenGL.internalGLES.glUniform1ui64NV = (dgtk.OpenGL.delegatesGLES.glUniform1ui64NV) InternalGLesTool.GetGLesMethodAdress("glUniform1ui64NV", typeof(dgtk.OpenGL.delegatesGLES.glUniform1ui64NV));
			}
			if (SuportedExt.Contains("glUniform1ui64vNV"))
			{
				dgtk.OpenGL.internalGLES.glUniform1ui64vNV = (dgtk.OpenGL.delegatesGLES.glUniform1ui64vNV) InternalGLesTool.GetGLesMethodAdress("glUniform1ui64vNV", typeof(dgtk.OpenGL.delegatesGLES.glUniform1ui64vNV));
			}
			if (SuportedExt.Contains("glUniform2i64NV"))
			{
				dgtk.OpenGL.internalGLES.glUniform2i64NV = (dgtk.OpenGL.delegatesGLES.glUniform2i64NV) InternalGLesTool.GetGLesMethodAdress("glUniform2i64NV", typeof(dgtk.OpenGL.delegatesGLES.glUniform2i64NV));
			}
			if (SuportedExt.Contains("glUniform2i64vNV"))
			{
				dgtk.OpenGL.internalGLES.glUniform2i64vNV = (dgtk.OpenGL.delegatesGLES.glUniform2i64vNV) InternalGLesTool.GetGLesMethodAdress("glUniform2i64vNV", typeof(dgtk.OpenGL.delegatesGLES.glUniform2i64vNV));
			}
			if (SuportedExt.Contains("glUniform2ui64NV"))
			{
				dgtk.OpenGL.internalGLES.glUniform2ui64NV = (dgtk.OpenGL.delegatesGLES.glUniform2ui64NV) InternalGLesTool.GetGLesMethodAdress("glUniform2ui64NV", typeof(dgtk.OpenGL.delegatesGLES.glUniform2ui64NV));
			}
			if (SuportedExt.Contains("glUniform2ui64vNV"))
			{
				dgtk.OpenGL.internalGLES.glUniform2ui64vNV = (dgtk.OpenGL.delegatesGLES.glUniform2ui64vNV) InternalGLesTool.GetGLesMethodAdress("glUniform2ui64vNV", typeof(dgtk.OpenGL.delegatesGLES.glUniform2ui64vNV));
			}
			if (SuportedExt.Contains("glUniform3i64NV"))
			{
				dgtk.OpenGL.internalGLES.glUniform3i64NV = (dgtk.OpenGL.delegatesGLES.glUniform3i64NV) InternalGLesTool.GetGLesMethodAdress("glUniform3i64NV", typeof(dgtk.OpenGL.delegatesGLES.glUniform3i64NV));
			}
			if (SuportedExt.Contains("glUniform3i64vNV"))
			{
				dgtk.OpenGL.internalGLES.glUniform3i64vNV = (dgtk.OpenGL.delegatesGLES.glUniform3i64vNV) InternalGLesTool.GetGLesMethodAdress("glUniform3i64vNV", typeof(dgtk.OpenGL.delegatesGLES.glUniform3i64vNV));
			}
			if (SuportedExt.Contains("glUniform3ui64NV"))
			{
				dgtk.OpenGL.internalGLES.glUniform3ui64NV = (dgtk.OpenGL.delegatesGLES.glUniform3ui64NV) InternalGLesTool.GetGLesMethodAdress("glUniform3ui64NV", typeof(dgtk.OpenGL.delegatesGLES.glUniform3ui64NV));
			}
			if (SuportedExt.Contains("glUniform3ui64vNV"))
			{
				dgtk.OpenGL.internalGLES.glUniform3ui64vNV = (dgtk.OpenGL.delegatesGLES.glUniform3ui64vNV) InternalGLesTool.GetGLesMethodAdress("glUniform3ui64vNV", typeof(dgtk.OpenGL.delegatesGLES.glUniform3ui64vNV));
			}
			if (SuportedExt.Contains("glUniform4i64NV"))
			{
				dgtk.OpenGL.internalGLES.glUniform4i64NV = (dgtk.OpenGL.delegatesGLES.glUniform4i64NV) InternalGLesTool.GetGLesMethodAdress("glUniform4i64NV", typeof(dgtk.OpenGL.delegatesGLES.glUniform4i64NV));
			}
			if (SuportedExt.Contains("glUniform4i64vNV"))
			{
				dgtk.OpenGL.internalGLES.glUniform4i64vNV = (dgtk.OpenGL.delegatesGLES.glUniform4i64vNV) InternalGLesTool.GetGLesMethodAdress("glUniform4i64vNV", typeof(dgtk.OpenGL.delegatesGLES.glUniform4i64vNV));
			}
			if (SuportedExt.Contains("glUniform4ui64NV"))
			{
				dgtk.OpenGL.internalGLES.glUniform4ui64NV = (dgtk.OpenGL.delegatesGLES.glUniform4ui64NV) InternalGLesTool.GetGLesMethodAdress("glUniform4ui64NV", typeof(dgtk.OpenGL.delegatesGLES.glUniform4ui64NV));
			}
			if (SuportedExt.Contains("glUniform4ui64vNV"))
			{
				dgtk.OpenGL.internalGLES.glUniform4ui64vNV = (dgtk.OpenGL.delegatesGLES.glUniform4ui64vNV) InternalGLesTool.GetGLesMethodAdress("glUniform4ui64vNV", typeof(dgtk.OpenGL.delegatesGLES.glUniform4ui64vNV));
			}
			if (SuportedExt.Contains("glUniformHandleui64IMG"))
			{
				dgtk.OpenGL.internalGLES.glUniformHandleui64IMG = (dgtk.OpenGL.delegatesGLES.glUniformHandleui64IMG) InternalGLesTool.GetGLesMethodAdress("glUniformHandleui64IMG", typeof(dgtk.OpenGL.delegatesGLES.glUniformHandleui64IMG));
			}
			if (SuportedExt.Contains("glUniformHandleui64NV"))
			{
				dgtk.OpenGL.internalGLES.glUniformHandleui64NV = (dgtk.OpenGL.delegatesGLES.glUniformHandleui64NV) InternalGLesTool.GetGLesMethodAdress("glUniformHandleui64NV", typeof(dgtk.OpenGL.delegatesGLES.glUniformHandleui64NV));
			}
			if (SuportedExt.Contains("glUniformHandleui64vIMG"))
			{
				dgtk.OpenGL.internalGLES.glUniformHandleui64vIMG = (dgtk.OpenGL.delegatesGLES.glUniformHandleui64vIMG) InternalGLesTool.GetGLesMethodAdress("glUniformHandleui64vIMG", typeof(dgtk.OpenGL.delegatesGLES.glUniformHandleui64vIMG));
			}
			if (SuportedExt.Contains("glUniformHandleui64vNV"))
			{
				dgtk.OpenGL.internalGLES.glUniformHandleui64vNV = (dgtk.OpenGL.delegatesGLES.glUniformHandleui64vNV) InternalGLesTool.GetGLesMethodAdress("glUniformHandleui64vNV", typeof(dgtk.OpenGL.delegatesGLES.glUniformHandleui64vNV));
			}
			if (SuportedExt.Contains("glUniformMatrix2x3fvNV"))
			{
				dgtk.OpenGL.internalGLES.glUniformMatrix2x3fvNV = (dgtk.OpenGL.delegatesGLES.glUniformMatrix2x3fvNV) InternalGLesTool.GetGLesMethodAdress("glUniformMatrix2x3fvNV", typeof(dgtk.OpenGL.delegatesGLES.glUniformMatrix2x3fvNV));
			}
			if (SuportedExt.Contains("glUniformMatrix2x4fvNV"))
			{
				dgtk.OpenGL.internalGLES.glUniformMatrix2x4fvNV = (dgtk.OpenGL.delegatesGLES.glUniformMatrix2x4fvNV) InternalGLesTool.GetGLesMethodAdress("glUniformMatrix2x4fvNV", typeof(dgtk.OpenGL.delegatesGLES.glUniformMatrix2x4fvNV));
			}
			if (SuportedExt.Contains("glUniformMatrix3x2fvNV"))
			{
				dgtk.OpenGL.internalGLES.glUniformMatrix3x2fvNV = (dgtk.OpenGL.delegatesGLES.glUniformMatrix3x2fvNV) InternalGLesTool.GetGLesMethodAdress("glUniformMatrix3x2fvNV", typeof(dgtk.OpenGL.delegatesGLES.glUniformMatrix3x2fvNV));
			}
			if (SuportedExt.Contains("glUniformMatrix3x4fvNV"))
			{
				dgtk.OpenGL.internalGLES.glUniformMatrix3x4fvNV = (dgtk.OpenGL.delegatesGLES.glUniformMatrix3x4fvNV) InternalGLesTool.GetGLesMethodAdress("glUniformMatrix3x4fvNV", typeof(dgtk.OpenGL.delegatesGLES.glUniformMatrix3x4fvNV));
			}
			if (SuportedExt.Contains("glUniformMatrix4x2fvNV"))
			{
				dgtk.OpenGL.internalGLES.glUniformMatrix4x2fvNV = (dgtk.OpenGL.delegatesGLES.glUniformMatrix4x2fvNV) InternalGLesTool.GetGLesMethodAdress("glUniformMatrix4x2fvNV", typeof(dgtk.OpenGL.delegatesGLES.glUniformMatrix4x2fvNV));
			}
			if (SuportedExt.Contains("glUniformMatrix4x3fvNV"))
			{
				dgtk.OpenGL.internalGLES.glUniformMatrix4x3fvNV = (dgtk.OpenGL.delegatesGLES.glUniformMatrix4x3fvNV) InternalGLesTool.GetGLesMethodAdress("glUniformMatrix4x3fvNV", typeof(dgtk.OpenGL.delegatesGLES.glUniformMatrix4x3fvNV));
			}
			if (SuportedExt.Contains("glUnmapBufferOES"))
			{
				dgtk.OpenGL.internalGLES.glUnmapBufferOES = (dgtk.OpenGL.delegatesGLES.glUnmapBufferOES) InternalGLesTool.GetGLesMethodAdress("glUnmapBufferOES", typeof(dgtk.OpenGL.delegatesGLES.glUnmapBufferOES));
			}
			if (SuportedExt.Contains("glUseProgramStagesEXT"))
			{
				dgtk.OpenGL.internalGLES.glUseProgramStagesEXT = (dgtk.OpenGL.delegatesGLES.glUseProgramStagesEXT) InternalGLesTool.GetGLesMethodAdress("glUseProgramStagesEXT", typeof(dgtk.OpenGL.delegatesGLES.glUseProgramStagesEXT));
			}
			if (SuportedExt.Contains("glUseShaderProgramEXT"))
			{
				dgtk.OpenGL.internalGLES.glUseShaderProgramEXT = (dgtk.OpenGL.delegatesGLES.glUseShaderProgramEXT) InternalGLesTool.GetGLesMethodAdress("glUseShaderProgramEXT", typeof(dgtk.OpenGL.delegatesGLES.glUseShaderProgramEXT));
			}
			#endregion

			#region V:

			if (SuportedExt.Contains("glValidateProgramPipelineEXT"))
			{
				dgtk.OpenGL.internalGLES.glValidateProgramPipelineEXT = (dgtk.OpenGL.delegatesGLES.glValidateProgramPipelineEXT) InternalGLesTool.GetGLesMethodAdress("glValidateProgramPipelineEXT", typeof(dgtk.OpenGL.delegatesGLES.glValidateProgramPipelineEXT));
			}
			if (SuportedExt.Contains("glVertex2bOES"))
			{
				dgtk.OpenGL.internalGLES.glVertex2bOES = (dgtk.OpenGL.delegatesGLES.glVertex2bOES) InternalGLesTool.GetGLesMethodAdress("glVertex2bOES", typeof(dgtk.OpenGL.delegatesGLES.glVertex2bOES));
			}
			if (SuportedExt.Contains("glVertex2bvOES"))
			{
				dgtk.OpenGL.internalGLES.glVertex2bvOES = (dgtk.OpenGL.delegatesGLES.glVertex2bvOES) InternalGLesTool.GetGLesMethodAdress("glVertex2bvOES", typeof(dgtk.OpenGL.delegatesGLES.glVertex2bvOES));
			}
			if (SuportedExt.Contains("glVertex2xOES"))
			{
				dgtk.OpenGL.internalGLES.glVertex2xOES = (dgtk.OpenGL.delegatesGLES.glVertex2xOES) InternalGLesTool.GetGLesMethodAdress("glVertex2xOES", typeof(dgtk.OpenGL.delegatesGLES.glVertex2xOES));
			}
			if (SuportedExt.Contains("glVertex2xvOES"))
			{
				dgtk.OpenGL.internalGLES.glVertex2xvOES = (dgtk.OpenGL.delegatesGLES.glVertex2xvOES) InternalGLesTool.GetGLesMethodAdress("glVertex2xvOES", typeof(dgtk.OpenGL.delegatesGLES.glVertex2xvOES));
			}
			if (SuportedExt.Contains("glVertex3bOES"))
			{
				dgtk.OpenGL.internalGLES.glVertex3bOES = (dgtk.OpenGL.delegatesGLES.glVertex3bOES) InternalGLesTool.GetGLesMethodAdress("glVertex3bOES", typeof(dgtk.OpenGL.delegatesGLES.glVertex3bOES));
			}
			if (SuportedExt.Contains("glVertex3bvOES"))
			{
				dgtk.OpenGL.internalGLES.glVertex3bvOES = (dgtk.OpenGL.delegatesGLES.glVertex3bvOES) InternalGLesTool.GetGLesMethodAdress("glVertex3bvOES", typeof(dgtk.OpenGL.delegatesGLES.glVertex3bvOES));
			}
			if (SuportedExt.Contains("glVertex3xOES"))
			{
				dgtk.OpenGL.internalGLES.glVertex3xOES = (dgtk.OpenGL.delegatesGLES.glVertex3xOES) InternalGLesTool.GetGLesMethodAdress("glVertex3xOES", typeof(dgtk.OpenGL.delegatesGLES.glVertex3xOES));
			}
			if (SuportedExt.Contains("glVertex3xvOES"))
			{
				dgtk.OpenGL.internalGLES.glVertex3xvOES = (dgtk.OpenGL.delegatesGLES.glVertex3xvOES) InternalGLesTool.GetGLesMethodAdress("glVertex3xvOES", typeof(dgtk.OpenGL.delegatesGLES.glVertex3xvOES));
			}
			if (SuportedExt.Contains("glVertex4bOES"))
			{
				dgtk.OpenGL.internalGLES.glVertex4bOES = (dgtk.OpenGL.delegatesGLES.glVertex4bOES) InternalGLesTool.GetGLesMethodAdress("glVertex4bOES", typeof(dgtk.OpenGL.delegatesGLES.glVertex4bOES));
			}
			if (SuportedExt.Contains("glVertex4bvOES"))
			{
				dgtk.OpenGL.internalGLES.glVertex4bvOES = (dgtk.OpenGL.delegatesGLES.glVertex4bvOES) InternalGLesTool.GetGLesMethodAdress("glVertex4bvOES", typeof(dgtk.OpenGL.delegatesGLES.glVertex4bvOES));
			}
			if (SuportedExt.Contains("glVertex4xOES"))
			{
				dgtk.OpenGL.internalGLES.glVertex4xOES = (dgtk.OpenGL.delegatesGLES.glVertex4xOES) InternalGLesTool.GetGLesMethodAdress("glVertex4xOES", typeof(dgtk.OpenGL.delegatesGLES.glVertex4xOES));
			}
			if (SuportedExt.Contains("glVertex4xvOES"))
			{
				dgtk.OpenGL.internalGLES.glVertex4xvOES = (dgtk.OpenGL.delegatesGLES.glVertex4xvOES) InternalGLesTool.GetGLesMethodAdress("glVertex4xvOES", typeof(dgtk.OpenGL.delegatesGLES.glVertex4xvOES));
			}
			if (SuportedExt.Contains("glVertexAttribDivisorANGLE"))
			{
				dgtk.OpenGL.internalGLES.glVertexAttribDivisorANGLE = (dgtk.OpenGL.delegatesGLES.glVertexAttribDivisorANGLE) InternalGLesTool.GetGLesMethodAdress("glVertexAttribDivisorANGLE", typeof(dgtk.OpenGL.delegatesGLES.glVertexAttribDivisorANGLE));
			}
			if (SuportedExt.Contains("glVertexAttribDivisorEXT"))
			{
				dgtk.OpenGL.internalGLES.glVertexAttribDivisorEXT = (dgtk.OpenGL.delegatesGLES.glVertexAttribDivisorEXT) InternalGLesTool.GetGLesMethodAdress("glVertexAttribDivisorEXT", typeof(dgtk.OpenGL.delegatesGLES.glVertexAttribDivisorEXT));
			}
			if (SuportedExt.Contains("glVertexAttribDivisorNV"))
			{
				dgtk.OpenGL.internalGLES.glVertexAttribDivisorNV = (dgtk.OpenGL.delegatesGLES.glVertexAttribDivisorNV) InternalGLesTool.GetGLesMethodAdress("glVertexAttribDivisorNV", typeof(dgtk.OpenGL.delegatesGLES.glVertexAttribDivisorNV));
			}
			if (SuportedExt.Contains("glViewportArrayvNV"))
			{
				dgtk.OpenGL.internalGLES.glViewportArrayvNV = (dgtk.OpenGL.delegatesGLES.glViewportArrayvNV) InternalGLesTool.GetGLesMethodAdress("glViewportArrayvNV", typeof(dgtk.OpenGL.delegatesGLES.glViewportArrayvNV));
			}
			if (SuportedExt.Contains("glViewportArrayvOES"))
			{
				dgtk.OpenGL.internalGLES.glViewportArrayvOES = (dgtk.OpenGL.delegatesGLES.glViewportArrayvOES) InternalGLesTool.GetGLesMethodAdress("glViewportArrayvOES", typeof(dgtk.OpenGL.delegatesGLES.glViewportArrayvOES));
			}
			if (SuportedExt.Contains("glViewportIndexedfNV"))
			{
				dgtk.OpenGL.internalGLES.glViewportIndexedfNV = (dgtk.OpenGL.delegatesGLES.glViewportIndexedfNV) InternalGLesTool.GetGLesMethodAdress("glViewportIndexedfNV", typeof(dgtk.OpenGL.delegatesGLES.glViewportIndexedfNV));
			}
			if (SuportedExt.Contains("glViewportIndexedfOES"))
			{
				dgtk.OpenGL.internalGLES.glViewportIndexedfOES = (dgtk.OpenGL.delegatesGLES.glViewportIndexedfOES) InternalGLesTool.GetGLesMethodAdress("glViewportIndexedfOES", typeof(dgtk.OpenGL.delegatesGLES.glViewportIndexedfOES));
			}
			if (SuportedExt.Contains("glViewportIndexedfvNV"))
			{
				dgtk.OpenGL.internalGLES.glViewportIndexedfvNV = (dgtk.OpenGL.delegatesGLES.glViewportIndexedfvNV) InternalGLesTool.GetGLesMethodAdress("glViewportIndexedfvNV", typeof(dgtk.OpenGL.delegatesGLES.glViewportIndexedfvNV));
			}
			if (SuportedExt.Contains("glViewportIndexedfvOES"))
			{
				dgtk.OpenGL.internalGLES.glViewportIndexedfvOES = (dgtk.OpenGL.delegatesGLES.glViewportIndexedfvOES) InternalGLesTool.GetGLesMethodAdress("glViewportIndexedfvOES", typeof(dgtk.OpenGL.delegatesGLES.glViewportIndexedfvOES));
			}
			if (SuportedExt.Contains("glViewportPositionWScaleNV"))
			{
				dgtk.OpenGL.internalGLES.glViewportPositionWScaleNV = (dgtk.OpenGL.delegatesGLES.glViewportPositionWScaleNV) InternalGLesTool.GetGLesMethodAdress("glViewportPositionWScaleNV", typeof(dgtk.OpenGL.delegatesGLES.glViewportPositionWScaleNV));
			}
			if (SuportedExt.Contains("glViewportSwizzleNV"))
			{
				dgtk.OpenGL.internalGLES.glViewportSwizzleNV = (dgtk.OpenGL.delegatesGLES.glViewportSwizzleNV) InternalGLesTool.GetGLesMethodAdress("glViewportSwizzleNV", typeof(dgtk.OpenGL.delegatesGLES.glViewportSwizzleNV));
			}
			#endregion

			#region W:

			if (SuportedExt.Contains("glWaitSemaphoreEXT"))
			{
				dgtk.OpenGL.internalGLES.glWaitSemaphoreEXT = (dgtk.OpenGL.delegatesGLES.glWaitSemaphoreEXT) InternalGLesTool.GetGLesMethodAdress("glWaitSemaphoreEXT", typeof(dgtk.OpenGL.delegatesGLES.glWaitSemaphoreEXT));
			}
			if (SuportedExt.Contains("glWaitSyncAPPLE"))
			{
				dgtk.OpenGL.internalGLES.glWaitSyncAPPLE = (dgtk.OpenGL.delegatesGLES.glWaitSyncAPPLE) InternalGLesTool.GetGLesMethodAdress("glWaitSyncAPPLE", typeof(dgtk.OpenGL.delegatesGLES.glWaitSyncAPPLE));
			}
			if (SuportedExt.Contains("glWaitVkSemaphoreNV"))
			{
				dgtk.OpenGL.internalGLES.glWaitVkSemaphoreNV = (dgtk.OpenGL.delegatesGLES.glWaitVkSemaphoreNV) InternalGLesTool.GetGLesMethodAdress("glWaitVkSemaphoreNV", typeof(dgtk.OpenGL.delegatesGLES.glWaitVkSemaphoreNV));
			}
			if (SuportedExt.Contains("glWeightPathsNV"))
			{
				dgtk.OpenGL.internalGLES.glWeightPathsNV = (dgtk.OpenGL.delegatesGLES.glWeightPathsNV) InternalGLesTool.GetGLesMethodAdress("glWeightPathsNV", typeof(dgtk.OpenGL.delegatesGLES.glWeightPathsNV));
			}
			if (SuportedExt.Contains("glWeightPointerOES"))
			{
				dgtk.OpenGL.internalGLES.glWeightPointerOES = (dgtk.OpenGL.delegatesGLES.glWeightPointerOES) InternalGLesTool.GetGLesMethodAdress("glWeightPointerOES", typeof(dgtk.OpenGL.delegatesGLES.glWeightPointerOES));
			}
			if (SuportedExt.Contains("glWindowRectanglesEXT"))
			{
				dgtk.OpenGL.internalGLES.glWindowRectanglesEXT = (dgtk.OpenGL.delegatesGLES.glWindowRectanglesEXT) InternalGLesTool.GetGLesMethodAdress("glWindowRectanglesEXT", typeof(dgtk.OpenGL.delegatesGLES.glWindowRectanglesEXT));
			}
			#endregion

		}
		[DllImport("opengl32.dll")]
		private static extern IntPtr glGetString(StringName name);

		internal static bool isLinux = false;

		private static string oglGetString(dgtk.OpenGL.StringName name)
		{
			if (isLinux)
			{
				return dgtk.OpenGL.GL.glGetStringh(name);
			}
			else
			{
				return Marshal.PtrToStringAnsi(glGetString(name));
			}
		}

		private unsafe delegate void dglGetIntegerv(dgtk.OpenGL.GetPName pname, out int* @params);
		private static dglGetIntegerv glGetIntegerv;

		private static unsafe int oglGetIntegerv(dgtk.OpenGL.GetPName pname)
		{
			int* pdata;
			glGetIntegerv(pname, out pdata);
			return (int)pdata;
		}

		private delegate IntPtr dglGetStringi(dgtk.OpenGL.StringName name, int num);
		private static dglGetStringi glGetStringi;

		private static string oglGetStringi(dgtk.OpenGL.StringName name, int num)
		{
			return Marshal.PtrToStringAnsi(glGetStringi(name, num));
		}

	}
}

