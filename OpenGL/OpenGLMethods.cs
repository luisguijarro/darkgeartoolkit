// OpenGL Methods.
// File Created with OpenGL Parser 3.
// Developed by Luis Guijarro Pérez.

using System;
using System.Text;
using System.Runtime.InteropServices;

namespace dgtk.OpenGL
{
	public static partial class GL
	{
		#region A:

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glAccum(AccumOp op, float value)
		{
			internalGL.glAccum(op, value);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static void glActiveShaderProgram(uint pipeline, uint program)
		{
			internalGL.glActiveShaderProgram(pipeline, program);
		}

		///<sumary> Available from OpenGL version 1.3</sumary>
		public static void glActiveTexture(TextureUnit texture)
		{
			internalGL.glActiveTexture(texture);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glAlphaFunc(AlphaFunction func, float @ref)
		{
			internalGL.glAlphaFunc(func, @ref);
		}

		///<sumary> Available from OpenGL version 1.1 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe bool glAreTexturesResident(int n, uint* textures, Boolean* residences)
		{
			return internalGL.glAreTexturesResident(n, textures, residences);
		}

		///<sumary> Available from OpenGL version 1.1 | Deprecated in OpenGL version 3.2</sumary>
		public static void glArrayElement(int i)
		{
			internalGL.glArrayElement(i);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static void glAttachShader(uint program, uint shader)
		{
			internalGL.glAttachShader(program, shader);
		}

		#endregion

		#region B:

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glBegin(PrimitiveType mode)
		{
			internalGL.glBegin(mode);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static void glBeginConditionalRender(uint id, ConditionalRenderMode mode)
		{
			internalGL.glBeginConditionalRender(id, mode);
		}

		///<sumary> Available from OpenGL version 1.5</sumary>
		public static void glBeginQuery(QueryTarget target, uint id)
		{
			internalGL.glBeginQuery(target, id);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static void glBeginQueryIndexed(QueryTarget target, uint index, uint id)
		{
			internalGL.glBeginQueryIndexed(target, index, id);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static void glBeginTransformFeedback(PrimitiveType primitiveMode)
		{
			internalGL.glBeginTransformFeedback(primitiveMode);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glBindAttribLocation(uint program, uint index, [MarshalAs(UnmanagedType.LPStr)] string name)
		{
			internalGL.glBindAttribLocation(program, index, name);
		}

		///<sumary> Available from OpenGL version 1.5</sumary>
		public static void glBindBuffer(BufferTargetARB target, uint buffer)
		{
			internalGL.glBindBuffer(target, buffer);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static void glBindBufferBase(BufferTargetARB target, uint index, uint buffer)
		{
			internalGL.glBindBufferBase(target, index, buffer);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static void glBindBufferRange(BufferTargetARB target, uint index, uint buffer, IntPtr offset, int size)
		{
			internalGL.glBindBufferRange(target, index, buffer, offset, size);
		}

		///<sumary> Available from OpenGL version 4.4</sumary>
		public static unsafe void glBindBuffersBase(BufferTargetARB target, uint first, int count, uint* buffers)
		{
			internalGL.glBindBuffersBase(target, first, count, buffers);
		}

		///<sumary> Available from OpenGL version 4.4</sumary>
		public static unsafe void glBindBuffersRange(BufferTargetARB target, uint first, int count, uint* buffers, IntPtr* offsets, int* sizes)
		{
			internalGL.glBindBuffersRange(target, first, count, buffers, offsets, sizes);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glBindFragDataLocation(uint program, uint color, [MarshalAs(UnmanagedType.LPStr)] string name)
		{
			internalGL.glBindFragDataLocation(program, color, name);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static unsafe void glBindFragDataLocationIndexed(uint program, uint colorNumber, uint index, [MarshalAs(UnmanagedType.LPStr)] string name)
		{
			internalGL.glBindFragDataLocationIndexed(program, colorNumber, index, name);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static void glBindFramebuffer(FramebufferTarget target, uint framebuffer)
		{
			internalGL.glBindFramebuffer(target, framebuffer);
		}

		///<sumary> Available from OpenGL version 4.2</sumary>
		public static void glBindImageTexture(uint unit, uint texture, int level, Boolean layered, int layer, BufferAccessARB access, InternalFormat format)
		{
			internalGL.glBindImageTexture(unit, texture, level, layered, layer, access, format);
		}

		///<sumary> Available from OpenGL version 4.4</sumary>
		public static unsafe void glBindImageTextures(uint first, int count, uint* textures)
		{
			internalGL.glBindImageTextures(first, count, textures);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static void glBindProgramPipeline(uint pipeline)
		{
			internalGL.glBindProgramPipeline(pipeline);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static void glBindRenderbuffer(RenderbufferTarget target, uint renderbuffer)
		{
			internalGL.glBindRenderbuffer(target, renderbuffer);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static void glBindSampler(uint unit, uint sampler)
		{
			internalGL.glBindSampler(unit, sampler);
		}

		///<sumary> Available from OpenGL version 4.4</sumary>
		public static unsafe void glBindSamplers(uint first, int count, uint* samplers)
		{
			internalGL.glBindSamplers(first, count, samplers);
		}

		///<sumary> Available from OpenGL version 1.1</sumary>
		public static void glBindTexture(TextureTarget target, uint texture)
		{
			internalGL.glBindTexture(target, texture);
		}

		///<sumary> Available from OpenGL version 4.4</sumary>
		public static unsafe void glBindTextures(uint first, int count, uint* textures)
		{
			internalGL.glBindTextures(first, count, textures);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glBindTextureUnit(uint unit, uint texture)
		{
			internalGL.glBindTextureUnit(unit, texture);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static void glBindTransformFeedback(BindTransformFeedbackTarget target, uint id)
		{
			internalGL.glBindTransformFeedback(target, id);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static void glBindVertexArray(uint array)
		{
			internalGL.glBindVertexArray(array);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static void glBindVertexBuffer(uint bindingindex, uint buffer, IntPtr offset, int stride)
		{
			internalGL.glBindVertexBuffer(bindingindex, buffer, offset, stride);
		}

		///<sumary> Available from OpenGL version 4.4</sumary>
		public static unsafe void glBindVertexBuffers(uint first, int count, uint* buffers, IntPtr* offsets, int* strides)
		{
			internalGL.glBindVertexBuffers(first, count, buffers, offsets, strides);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glBitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, byte* bitmap)
		{
			internalGL.glBitmap(width, height, xorig, yorig, xmove, ymove, bitmap);
		}

		///<sumary> Available from OpenGL version 1.4</sumary>
		public static void glBlendColor(float red, float green, float blue, float alpha)
		{
			internalGL.glBlendColor(red, green, blue, alpha);
		}

		///<sumary> Available from OpenGL version 1.4</sumary>
		public static void glBlendEquation(BlendEquationModeEXT mode)
		{
			internalGL.glBlendEquation(mode);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static void glBlendEquationi(uint buf, BlendEquationModeEXT mode)
		{
			internalGL.glBlendEquationi(buf, mode);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static void glBlendEquationSeparate(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha)
		{
			internalGL.glBlendEquationSeparate(modeRGB, modeAlpha);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static void glBlendEquationSeparatei(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha)
		{
			internalGL.glBlendEquationSeparatei(buf, modeRGB, modeAlpha);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static void glBlendFunc(BlendingFactor sfactor, BlendingFactor dfactor)
		{
			internalGL.glBlendFunc(sfactor, dfactor);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static void glBlendFunci(uint buf, BlendingFactor src, BlendingFactor dst)
		{
			internalGL.glBlendFunci(buf, src, dst);
		}

		///<sumary> Available from OpenGL version 1.4</sumary>
		public static void glBlendFuncSeparate(BlendingFactor sfactorRGB, BlendingFactor dfactorRGB, BlendingFactor sfactorAlpha, BlendingFactor dfactorAlpha)
		{
			internalGL.glBlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static void glBlendFuncSeparatei(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha)
		{
			internalGL.glBlendFuncSeparatei(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static void glBlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter)
		{
			internalGL.glBlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glBlitNamedFramebuffer(uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter)
		{
			internalGL.glBlitNamedFramebuffer(readFramebuffer, drawFramebuffer, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
		}

		///<sumary> Available from OpenGL version 1.5</sumary>
		public static void glBufferData(BufferTargetARB target, int size, IntPtr data, BufferUsageARB usage)
		{
			internalGL.glBufferData(target, size, data, usage);
		}

		///<sumary> Available from OpenGL version 4.4</sumary>
		public static void glBufferStorage(BufferStorageTarget target, int size, IntPtr data, BufferStorageMask flags)
		{
			internalGL.glBufferStorage(target, size, data, flags);
		}

		///<sumary> Available from OpenGL version 1.5</sumary>
		public static void glBufferSubData(BufferTargetARB target, IntPtr offset, int size, IntPtr data)
		{
			internalGL.glBufferSubData(target, offset, size, data);
		}

		#endregion

		#region C:

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glCallList(uint list)
		{
			internalGL.glCallList(list);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glCallLists(int n, ListNameType type, IntPtr lists)
		{
			internalGL.glCallLists(n, type, lists);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static uint glCheckFramebufferStatus(FramebufferTarget target)
		{
			return internalGL.glCheckFramebufferStatus(target);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static uint glCheckNamedFramebufferStatus(uint framebuffer, FramebufferTarget target)
		{
			return internalGL.glCheckNamedFramebufferStatus(framebuffer, target);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static void glClampColor(ClampColorTargetARB target, ClampColorModeARB clamp)
		{
			internalGL.glClampColor(target, clamp);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static void glClear(ClearBufferMask mask)
		{
			internalGL.glClear(mask);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glClearAccum(float red, float green, float blue, float alpha)
		{
			internalGL.glClearAccum(red, green, blue, alpha);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static void glClearBufferData(BufferStorageTarget target, InternalFormat internalformat, PixelFormat format, PixelType type, IntPtr data)
		{
			internalGL.glClearBufferData(target, internalformat, format, type, data);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static void glClearBufferfi(Buffer buffer, int drawbuffer, float depth, int stencil)
		{
			internalGL.glClearBufferfi(buffer, drawbuffer, depth, stencil);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glClearBufferfv(Buffer buffer, int drawbuffer, float* value)
		{
			internalGL.glClearBufferfv(buffer, drawbuffer, value);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glClearBufferiv(Buffer buffer, int drawbuffer, int* value)
		{
			internalGL.glClearBufferiv(buffer, drawbuffer, value);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static void glClearBufferSubData(BufferTargetARB target, InternalFormat internalformat, IntPtr offset, int size, PixelFormat format, PixelType type, IntPtr data)
		{
			internalGL.glClearBufferSubData(target, internalformat, offset, size, format, type, data);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glClearBufferuiv(Buffer buffer, int drawbuffer, uint* value)
		{
			internalGL.glClearBufferuiv(buffer, drawbuffer, value);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static void glClearColor(float red, float green, float blue, float alpha)
		{
			internalGL.glClearColor(red, green, blue, alpha);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static void glClearDepth(double depth)
		{
			internalGL.glClearDepth(depth);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static void glClearDepthf(float d)
		{
			internalGL.glClearDepthf(d);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glClearIndex(float c)
		{
			internalGL.glClearIndex(c);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glClearNamedBufferData(uint buffer, InternalFormat internalformat, PixelFormat format, PixelType type, IntPtr data)
		{
			internalGL.glClearNamedBufferData(buffer, internalformat, format, type, data);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glClearNamedBufferSubData(uint buffer, InternalFormat internalformat, IntPtr offset, int size, PixelFormat format, PixelType type, IntPtr data)
		{
			internalGL.glClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, data);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glClearNamedFramebufferfi(uint framebuffer, Buffer buffer, int drawbuffer, float depth, int stencil)
		{
			internalGL.glClearNamedFramebufferfi(framebuffer, buffer, drawbuffer, depth, stencil);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glClearNamedFramebufferfv(uint framebuffer, Buffer buffer, int drawbuffer, float* value)
		{
			internalGL.glClearNamedFramebufferfv(framebuffer, buffer, drawbuffer, value);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glClearNamedFramebufferiv(uint framebuffer, Buffer buffer, int drawbuffer, int* value)
		{
			internalGL.glClearNamedFramebufferiv(framebuffer, buffer, drawbuffer, value);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glClearNamedFramebufferuiv(uint framebuffer, Buffer buffer, int drawbuffer, uint* value)
		{
			internalGL.glClearNamedFramebufferuiv(framebuffer, buffer, drawbuffer, value);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static void glClearStencil(int s)
		{
			internalGL.glClearStencil(s);
		}

		///<sumary> Available from OpenGL version 4.4</sumary>
		public static void glClearTexImage(uint texture, int level, PixelFormat format, PixelType type, IntPtr data)
		{
			internalGL.glClearTexImage(texture, level, format, type, data);
		}

		///<sumary> Available from OpenGL version 4.4</sumary>
		public static void glClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr data)
		{
			internalGL.glClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data);
		}

		///<sumary> Available from OpenGL version 1.3 | Deprecated in OpenGL version 3.2</sumary>
		public static void glClientActiveTexture(TextureUnit texture)
		{
			internalGL.glClientActiveTexture(texture);
		}

		///<sumary> Available from OpenGL version 3.2</sumary>
		public static uint glClientWaitSync(IntPtr sync, SyncObjectMask flags, ulong timeout)
		{
			return internalGL.glClientWaitSync(sync, flags, timeout);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glClipControl(ClipControlOrigin origin, ClipControlDepth depth)
		{
			internalGL.glClipControl(origin, depth);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glClipPlane(ClipPlaneName plane, double* equation)
		{
			internalGL.glClipPlane(plane, equation);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glColor3b(sbyte red, sbyte green, sbyte blue)
		{
			internalGL.glColor3b(red, green, blue);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glColor3bv(sbyte* v)
		{
			internalGL.glColor3bv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glColor3d(double red, double green, double blue)
		{
			internalGL.glColor3d(red, green, blue);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glColor3dv(double* v)
		{
			internalGL.glColor3dv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glColor3f(float red, float green, float blue)
		{
			internalGL.glColor3f(red, green, blue);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glColor3fv(float* v)
		{
			internalGL.glColor3fv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glColor3i(int red, int green, int blue)
		{
			internalGL.glColor3i(red, green, blue);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glColor3iv(int* v)
		{
			internalGL.glColor3iv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glColor3s(short red, short green, short blue)
		{
			internalGL.glColor3s(red, green, blue);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glColor3sv(short* v)
		{
			internalGL.glColor3sv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glColor3ub(byte red, byte green, byte blue)
		{
			internalGL.glColor3ub(red, green, blue);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glColor3ubv(byte* v)
		{
			internalGL.glColor3ubv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glColor3ui(uint red, uint green, uint blue)
		{
			internalGL.glColor3ui(red, green, blue);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glColor3uiv(uint* v)
		{
			internalGL.glColor3uiv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glColor3us(ushort red, ushort green, ushort blue)
		{
			internalGL.glColor3us(red, green, blue);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glColor3usv(ushort* v)
		{
			internalGL.glColor3usv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glColor4b(sbyte red, sbyte green, sbyte blue, sbyte alpha)
		{
			internalGL.glColor4b(red, green, blue, alpha);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glColor4bv(sbyte* v)
		{
			internalGL.glColor4bv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glColor4d(double red, double green, double blue, double alpha)
		{
			internalGL.glColor4d(red, green, blue, alpha);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glColor4dv(double* v)
		{
			internalGL.glColor4dv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glColor4f(float red, float green, float blue, float alpha)
		{
			internalGL.glColor4f(red, green, blue, alpha);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glColor4fv(float* v)
		{
			internalGL.glColor4fv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glColor4i(int red, int green, int blue, int alpha)
		{
			internalGL.glColor4i(red, green, blue, alpha);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glColor4iv(int* v)
		{
			internalGL.glColor4iv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glColor4s(short red, short green, short blue, short alpha)
		{
			internalGL.glColor4s(red, green, blue, alpha);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glColor4sv(short* v)
		{
			internalGL.glColor4sv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glColor4ub(byte red, byte green, byte blue, byte alpha)
		{
			internalGL.glColor4ub(red, green, blue, alpha);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glColor4ubv(byte* v)
		{
			internalGL.glColor4ubv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glColor4ui(uint red, uint green, uint blue, uint alpha)
		{
			internalGL.glColor4ui(red, green, blue, alpha);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glColor4uiv(uint* v)
		{
			internalGL.glColor4uiv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glColor4us(ushort red, ushort green, ushort blue, ushort alpha)
		{
			internalGL.glColor4us(red, green, blue, alpha);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glColor4usv(ushort* v)
		{
			internalGL.glColor4usv(v);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static void glColorMask(Boolean red, Boolean green, Boolean blue, Boolean alpha)
		{
			internalGL.glColorMask(red, green, blue, alpha);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static void glColorMaski(uint index, Boolean r, Boolean g, Boolean b, Boolean a)
		{
			internalGL.glColorMaski(index, r, g, b, a);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glColorMaterial(MaterialFace face, ColorMaterialParameter mode)
		{
			internalGL.glColorMaterial(face, mode);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static void glColorP3ui(ColorPointerType type, uint color)
		{
			internalGL.glColorP3ui(type, color);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static unsafe void glColorP3uiv(ColorPointerType type, uint* color)
		{
			internalGL.glColorP3uiv(type, color);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static void glColorP4ui(ColorPointerType type, uint color)
		{
			internalGL.glColorP4ui(type, color);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static unsafe void glColorP4uiv(ColorPointerType type, uint* color)
		{
			internalGL.glColorP4uiv(type, color);
		}

		///<sumary> Available from OpenGL version 1.1 | Deprecated in OpenGL version 3.2</sumary>
		public static void glColorPointer(int size, ColorPointerType type, int stride, IntPtr pointer)
		{
			internalGL.glColorPointer(size, type, stride, pointer);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static void glCompileShader(uint shader)
		{
			internalGL.glCompileShader(shader);
		}

		///<sumary> Available from OpenGL version 1.3</sumary>
		public static void glCompressedTexImage1D(TextureTarget target, int level, InternalFormat internalformat, int width, int border, int imageSize, IntPtr data)
		{
			internalGL.glCompressedTexImage1D(target, level, internalformat, width, border, imageSize, data);
		}

		///<sumary> Available from OpenGL version 1.3</sumary>
		public static void glCompressedTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, IntPtr data)
		{
			internalGL.glCompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);
		}

		///<sumary> Available from OpenGL version 1.3</sumary>
		public static void glCompressedTexImage3D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data)
		{
			internalGL.glCompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data);
		}

		///<sumary> Available from OpenGL version 1.3</sumary>
		public static void glCompressedTexSubImage1D(TextureTarget target, int level, int xoffset, int width, PixelFormat format, int imageSize, IntPtr data)
		{
			internalGL.glCompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data);
		}

		///<sumary> Available from OpenGL version 1.3</sumary>
		public static void glCompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, IntPtr data)
		{
			internalGL.glCompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
		}

		///<sumary> Available from OpenGL version 1.3</sumary>
		public static void glCompressedTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, IntPtr data)
		{
			internalGL.glCompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glCompressedTextureSubImage1D(uint texture, int level, int xoffset, int width, PixelFormat format, int imageSize, IntPtr data)
		{
			internalGL.glCompressedTextureSubImage1D(texture, level, xoffset, width, format, imageSize, data);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glCompressedTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, IntPtr data)
		{
			internalGL.glCompressedTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, imageSize, data);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glCompressedTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, IntPtr data)
		{
			internalGL.glCompressedTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		}

		///<sumary> Available from OpenGL version 3.1</sumary>
		public static void glCopyBufferSubData(CopyBufferSubDataTarget readTarget, CopyBufferSubDataTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, int size)
		{
			internalGL.glCopyBufferSubData(readTarget, writeTarget, readOffset, writeOffset, size);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static void glCopyImageSubData(uint srcName, CopyImageSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyImageSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth)
		{
			internalGL.glCopyImageSubData(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glCopyNamedBufferSubData(uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, int size)
		{
			internalGL.glCopyNamedBufferSubData(readBuffer, writeBuffer, readOffset, writeOffset, size);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glCopyPixels(int x, int y, int width, int height, PixelCopyType type)
		{
			internalGL.glCopyPixels(x, y, width, height, type);
		}

		///<sumary> Available from OpenGL version 1.1</sumary>
		public static void glCopyTexImage1D(TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int border)
		{
			internalGL.glCopyTexImage1D(target, level, internalformat, x, y, width, border);
		}

		///<sumary> Available from OpenGL version 1.1</sumary>
		public static void glCopyTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int height, int border)
		{
			internalGL.glCopyTexImage2D(target, level, internalformat, x, y, width, height, border);
		}

		///<sumary> Available from OpenGL version 1.1</sumary>
		public static void glCopyTexSubImage1D(TextureTarget target, int level, int xoffset, int x, int y, int width)
		{
			internalGL.glCopyTexSubImage1D(target, level, xoffset, x, y, width);
		}

		///<sumary> Available from OpenGL version 1.1</sumary>
		public static void glCopyTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height)
		{
			internalGL.glCopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);
		}

		///<sumary> Available from OpenGL version 1.2</sumary>
		public static void glCopyTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
		{
			internalGL.glCopyTexSubImage3D(target, level, xoffset, yoffset, zoffset, x, y, width, height);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glCopyTextureSubImage1D(uint texture, int level, int xoffset, int x, int y, int width)
		{
			internalGL.glCopyTextureSubImage1D(texture, level, xoffset, x, y, width);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glCopyTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int x, int y, int width, int height)
		{
			internalGL.glCopyTextureSubImage2D(texture, level, xoffset, yoffset, x, y, width, height);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glCopyTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
		{
			internalGL.glCopyTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, x, y, width, height);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glCreateBuffers(int n, uint* buffers)
		{
			internalGL.glCreateBuffers(n, buffers);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glCreateFramebuffers(int n, uint* framebuffers)
		{
			internalGL.glCreateFramebuffers(n, framebuffers);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static uint glCreateProgram()
		{
			return internalGL.glCreateProgram();
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glCreateProgramPipelines(int n, uint* pipelines)
		{
			internalGL.glCreateProgramPipelines(n, pipelines);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glCreateQueries(QueryTarget target, int n, uint* ids)
		{
			internalGL.glCreateQueries(target, n, ids);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glCreateRenderbuffers(int n, uint* renderbuffers)
		{
			internalGL.glCreateRenderbuffers(n, renderbuffers);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glCreateSamplers(int n, uint* samplers)
		{
			internalGL.glCreateSamplers(n, samplers);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static uint glCreateShader(ShaderType type)
		{
			return internalGL.glCreateShader(type);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe uint glCreateShaderProgramv(ShaderType type, int count, [MarshalAs(UnmanagedType.LPStr)] string[] strings)
		{
			return internalGL.glCreateShaderProgramv(type, count, strings);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glCreateTextures(TextureTarget target, int n, uint* textures)
		{
			internalGL.glCreateTextures(target, n, textures);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glCreateTransformFeedbacks(int n, uint* ids)
		{
			internalGL.glCreateTransformFeedbacks(n, ids);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glCreateVertexArrays(int n, uint* arrays)
		{
			internalGL.glCreateVertexArrays(n, arrays);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static void glCullFace(CullFaceMode mode)
		{
			internalGL.glCullFace(mode);
		}

		#endregion

		#region D:

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static void glDebugMessageCallback(Delegate callback, IntPtr userParam)
		{
			internalGL.glDebugMessageCallback(callback, userParam);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static unsafe void glDebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, Boolean enabled)
		{
			internalGL.glDebugMessageControl(source, type, severity, count, ids, enabled);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static unsafe void glDebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, [MarshalAs(UnmanagedType.LPStr)] string buf)
		{
			internalGL.glDebugMessageInsert(source, type, id, severity, length, buf);
		}

		///<sumary> Available from OpenGL version 1.5</sumary>
		public static unsafe void glDeleteBuffers(int n, uint* buffers)
		{
			internalGL.glDeleteBuffers(n, buffers);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glDeleteFramebuffers(int n, uint* framebuffers)
		{
			internalGL.glDeleteFramebuffers(n, framebuffers);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glDeleteLists(uint list, int range)
		{
			internalGL.glDeleteLists(list, range);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static void glDeleteProgram(uint program)
		{
			internalGL.glDeleteProgram(program);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glDeleteProgramPipelines(int n, uint* pipelines)
		{
			internalGL.glDeleteProgramPipelines(n, pipelines);
		}

		///<sumary> Available from OpenGL version 1.5</sumary>
		public static unsafe void glDeleteQueries(int n, uint* ids)
		{
			internalGL.glDeleteQueries(n, ids);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glDeleteRenderbuffers(int n, uint* renderbuffers)
		{
			internalGL.glDeleteRenderbuffers(n, renderbuffers);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static unsafe void glDeleteSamplers(int count, uint* samplers)
		{
			internalGL.glDeleteSamplers(count, samplers);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static void glDeleteShader(uint shader)
		{
			internalGL.glDeleteShader(shader);
		}

		///<sumary> Available from OpenGL version 3.2</sumary>
		public static void glDeleteSync(IntPtr sync)
		{
			internalGL.glDeleteSync(sync);
		}

		///<sumary> Available from OpenGL version 1.1</sumary>
		public static unsafe void glDeleteTextures(int n, uint* textures)
		{
			internalGL.glDeleteTextures(n, textures);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static unsafe void glDeleteTransformFeedbacks(int n, uint* ids)
		{
			internalGL.glDeleteTransformFeedbacks(n, ids);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glDeleteVertexArrays(int n, uint* arrays)
		{
			internalGL.glDeleteVertexArrays(n, arrays);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static void glDepthFunc(DepthFunction func)
		{
			internalGL.glDepthFunc(func);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static void glDepthMask(Boolean flag)
		{
			internalGL.glDepthMask(flag);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static void glDepthRange(double n, double f)
		{
			internalGL.glDepthRange(n, f);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glDepthRangeArrayv(uint first, int count, double* v)
		{
			internalGL.glDepthRangeArrayv(first, count, v);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static void glDepthRangef(float n, float f)
		{
			internalGL.glDepthRangef(n, f);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static void glDepthRangeIndexed(uint index, double n, double f)
		{
			internalGL.glDepthRangeIndexed(index, n, f);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static void glDetachShader(uint program, uint shader)
		{
			internalGL.glDetachShader(program, shader);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static void glDisable(EnableCap cap)
		{
			internalGL.glDisable(cap);
		}

		///<sumary> Available from OpenGL version 1.1 | Deprecated in OpenGL version 3.2</sumary>
		public static void glDisableClientState(EnableCap array)
		{
			internalGL.glDisableClientState(array);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static void glDisablei(EnableCap target, uint index)
		{
			internalGL.glDisablei(target, index);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glDisableVertexArrayAttrib(uint vaobj, uint index)
		{
			internalGL.glDisableVertexArrayAttrib(vaobj, index);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static void glDisableVertexAttribArray(uint index)
		{
			internalGL.glDisableVertexAttribArray(index);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static void glDispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z)
		{
			internalGL.glDispatchCompute(num_groups_x, num_groups_y, num_groups_z);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static void glDispatchComputeIndirect(IntPtr indirect)
		{
			internalGL.glDispatchComputeIndirect(indirect);
		}

		///<sumary> Available from OpenGL version 1.1</sumary>
		public static void glDrawArrays(PrimitiveType mode, int first, int count)
		{
			internalGL.glDrawArrays(mode, first, count);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static void glDrawArraysIndirect(PrimitiveType mode, IntPtr indirect)
		{
			internalGL.glDrawArraysIndirect(mode, indirect);
		}

		///<sumary> Available from OpenGL version 3.1</sumary>
		public static void glDrawArraysInstanced(PrimitiveType mode, int first, int count, int instancecount)
		{
			internalGL.glDrawArraysInstanced(mode, first, count, instancecount);
		}

		///<sumary> Available from OpenGL version 4.2</sumary>
		public static void glDrawArraysInstancedBaseInstance(PrimitiveType mode, int first, int count, int instancecount, uint baseinstance)
		{
			internalGL.glDrawArraysInstancedBaseInstance(mode, first, count, instancecount, baseinstance);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static void glDrawBuffer(DrawBufferMode buf)
		{
			internalGL.glDrawBuffer(buf);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glDrawBuffers(int n, DrawBufferMode* bufs)
		{
			internalGL.glDrawBuffers(n, bufs);
		}

		///<sumary> Available from OpenGL version 1.1</sumary>
		public static void glDrawElements(PrimitiveType mode, int count, DrawElementsType type, IntPtr indices)
		{
			internalGL.glDrawElements(mode, count, type, indices);
		}

		///<sumary> Available from OpenGL version 3.2</sumary>
		public static void glDrawElementsBaseVertex(PrimitiveType mode, int count, DrawElementsType type, IntPtr indices, int basevertex)
		{
			internalGL.glDrawElementsBaseVertex(mode, count, type, indices, basevertex);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static void glDrawElementsIndirect(PrimitiveType mode, DrawElementsType type, IntPtr indirect)
		{
			internalGL.glDrawElementsIndirect(mode, type, indirect);
		}

		///<sumary> Available from OpenGL version 3.1</sumary>
		public static void glDrawElementsInstanced(PrimitiveType mode, int count, DrawElementsType type, IntPtr indices, int instancecount)
		{
			internalGL.glDrawElementsInstanced(mode, count, type, indices, instancecount);
		}

		///<sumary> Available from OpenGL version 4.2</sumary>
		public static void glDrawElementsInstancedBaseInstance(PrimitiveType mode, int count, PrimitiveType type, IntPtr indices, int instancecount, uint baseinstance)
		{
			internalGL.glDrawElementsInstancedBaseInstance(mode, count, type, indices, instancecount, baseinstance);
		}

		///<sumary> Available from OpenGL version 3.2</sumary>
		public static void glDrawElementsInstancedBaseVertex(PrimitiveType mode, int count, DrawElementsType type, IntPtr indices, int instancecount, int basevertex)
		{
			internalGL.glDrawElementsInstancedBaseVertex(mode, count, type, indices, instancecount, basevertex);
		}

		///<sumary> Available from OpenGL version 4.2</sumary>
		public static void glDrawElementsInstancedBaseVertexBaseInstance(PrimitiveType mode, int count, DrawElementsType type, IntPtr indices, int instancecount, int basevertex, uint baseinstance)
		{
			internalGL.glDrawElementsInstancedBaseVertexBaseInstance(mode, count, type, indices, instancecount, basevertex, baseinstance);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glDrawPixels(int width, int height, PixelFormat format, PixelType type, IntPtr pixels)
		{
			internalGL.glDrawPixels(width, height, format, type, pixels);
		}

		///<sumary> Available from OpenGL version 1.2</sumary>
		public static void glDrawRangeElements(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, IntPtr indices)
		{
			internalGL.glDrawRangeElements(mode, start, end, count, type, indices);
		}

		///<sumary> Available from OpenGL version 3.2</sumary>
		public static void glDrawRangeElementsBaseVertex(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, IntPtr indices, int basevertex)
		{
			internalGL.glDrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static void glDrawTransformFeedback(PrimitiveType mode, uint id)
		{
			internalGL.glDrawTransformFeedback(mode, id);
		}

		///<sumary> Available from OpenGL version 4.2</sumary>
		public static void glDrawTransformFeedbackInstanced(PrimitiveType mode, uint id, int instancecount)
		{
			internalGL.glDrawTransformFeedbackInstanced(mode, id, instancecount);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static void glDrawTransformFeedbackStream(PrimitiveType mode, uint id, uint stream)
		{
			internalGL.glDrawTransformFeedbackStream(mode, id, stream);
		}

		///<sumary> Available from OpenGL version 4.2</sumary>
		public static void glDrawTransformFeedbackStreamInstanced(PrimitiveType mode, uint id, uint stream, int instancecount)
		{
			internalGL.glDrawTransformFeedbackStreamInstanced(mode, id, stream, instancecount);
		}

		#endregion

		#region E:

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glEdgeFlag(Boolean flag)
		{
			internalGL.glEdgeFlag(flag);
		}

		///<sumary> Available from OpenGL version 1.1 | Deprecated in OpenGL version 3.2</sumary>
		public static void glEdgeFlagPointer(int stride, IntPtr pointer)
		{
			internalGL.glEdgeFlagPointer(stride, pointer);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glEdgeFlagv(Boolean* flag)
		{
			internalGL.glEdgeFlagv(flag);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static void glEnable(EnableCap cap)
		{
			internalGL.glEnable(cap);
		}

		///<sumary> Available from OpenGL version 1.1 | Deprecated in OpenGL version 3.2</sumary>
		public static void glEnableClientState(EnableCap array)
		{
			internalGL.glEnableClientState(array);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static void glEnablei(EnableCap target, uint index)
		{
			internalGL.glEnablei(target, index);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glEnableVertexArrayAttrib(uint vaobj, uint index)
		{
			internalGL.glEnableVertexArrayAttrib(vaobj, index);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static void glEnableVertexAttribArray(uint index)
		{
			internalGL.glEnableVertexAttribArray(index);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glEnd()
		{
			internalGL.glEnd();
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static void glEndConditionalRender()
		{
			internalGL.glEndConditionalRender();
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glEndList()
		{
			internalGL.glEndList();
		}

		///<sumary> Available from OpenGL version 1.5</sumary>
		public static void glEndQuery(QueryTarget target)
		{
			internalGL.glEndQuery(target);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static void glEndQueryIndexed(QueryTarget target, uint index)
		{
			internalGL.glEndQueryIndexed(target, index);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static void glEndTransformFeedback()
		{
			internalGL.glEndTransformFeedback();
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glEvalCoord1d(double u)
		{
			internalGL.glEvalCoord1d(u);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glEvalCoord1dv(double* u)
		{
			internalGL.glEvalCoord1dv(u);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glEvalCoord1f(float u)
		{
			internalGL.glEvalCoord1f(u);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glEvalCoord1fv(float* u)
		{
			internalGL.glEvalCoord1fv(u);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glEvalCoord2d(double u, double v)
		{
			internalGL.glEvalCoord2d(u, v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glEvalCoord2dv(double* u)
		{
			internalGL.glEvalCoord2dv(u);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glEvalCoord2f(float u, float v)
		{
			internalGL.glEvalCoord2f(u, v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glEvalCoord2fv(float* u)
		{
			internalGL.glEvalCoord2fv(u);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glEvalMesh1(MeshMode1 mode, int i1, int i2)
		{
			internalGL.glEvalMesh1(mode, i1, i2);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glEvalMesh2(MeshMode2 mode, int i1, int i2, int j1, int j2)
		{
			internalGL.glEvalMesh2(mode, i1, i2, j1, j2);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glEvalPoint1(int i)
		{
			internalGL.glEvalPoint1(i);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glEvalPoint2(int i, int j)
		{
			internalGL.glEvalPoint2(i, j);
		}

		#endregion

		#region F:

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glFeedbackBuffer(int size, FeedbackType type, float* buffer)
		{
			internalGL.glFeedbackBuffer(size, type, buffer);
		}

		///<sumary> Available from OpenGL version 3.2</sumary>
		public static IntPtr glFenceSync(SyncCondition condition, SyncBehaviorFlags flags)
		{
			return internalGL.glFenceSync(condition, flags);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static void glFinish()
		{
			internalGL.glFinish();
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static void glFlush()
		{
			internalGL.glFlush();
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static void glFlushMappedBufferRange(BufferTargetARB target, IntPtr offset, int length)
		{
			internalGL.glFlushMappedBufferRange(target, offset, length);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glFlushMappedNamedBufferRange(uint buffer, IntPtr offset, int length)
		{
			internalGL.glFlushMappedNamedBufferRange(buffer, offset, length);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static void glFogCoordd(double coord)
		{
			internalGL.glFogCoordd(coord);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glFogCoorddv(double* coord)
		{
			internalGL.glFogCoorddv(coord);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static void glFogCoordf(float coord)
		{
			internalGL.glFogCoordf(coord);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glFogCoordfv(float* coord)
		{
			internalGL.glFogCoordfv(coord);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static void glFogCoordPointer(FogPointerTypeEXT type, int stride, IntPtr pointer)
		{
			internalGL.glFogCoordPointer(type, stride, pointer);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glFogf(FogParameter pname, float param)
		{
			internalGL.glFogf(pname, param);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glFogfv(FogParameter pname, float* @params)
		{
			internalGL.glFogfv(pname, @params);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glFogi(FogParameter pname, int param)
		{
			internalGL.glFogi(pname, param);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glFogiv(FogParameter pname, int* @params)
		{
			internalGL.glFogiv(pname, @params);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static void glFramebufferParameteri(FramebufferTarget target, FramebufferParameterName pname, int param)
		{
			internalGL.glFramebufferParameteri(target, pname, param);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static void glFramebufferRenderbuffer(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, uint renderbuffer)
		{
			internalGL.glFramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer);
		}

		///<sumary> Available from OpenGL version 3.2</sumary>
		public static void glFramebufferTexture(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level)
		{
			internalGL.glFramebufferTexture(target, attachment, texture, level);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static void glFramebufferTexture1D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level)
		{
			internalGL.glFramebufferTexture1D(target, attachment, textarget, texture, level);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static void glFramebufferTexture2D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level)
		{
			internalGL.glFramebufferTexture2D(target, attachment, textarget, texture, level);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static void glFramebufferTexture3D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level, int zoffset)
		{
			internalGL.glFramebufferTexture3D(target, attachment, textarget, texture, level, zoffset);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static void glFramebufferTextureLayer(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, int layer)
		{
			internalGL.glFramebufferTextureLayer(target, attachment, texture, level, layer);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static void glFrontFace(FrontFaceDirection mode)
		{
			internalGL.glFrontFace(mode);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glFrustum(double left, double right, double bottom, double top, double zNear, double zFar)
		{
			internalGL.glFrustum(left, right, bottom, top, zNear, zFar);
		}

		#endregion

		#region G:

		///<sumary> Available from OpenGL version 1.5</sumary>
		public static unsafe void glGenBuffers(int n, uint* buffers)
		{
			internalGL.glGenBuffers(n, buffers);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static void glGenerateMipmap(TextureTarget target)
		{
			internalGL.glGenerateMipmap(target);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glGenerateTextureMipmap(uint texture)
		{
			internalGL.glGenerateTextureMipmap(texture);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glGenFramebuffers(int n, uint* framebuffers)
		{
			internalGL.glGenFramebuffers(n, framebuffers);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static uint glGenLists(int range)
		{
			return internalGL.glGenLists(range);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glGenProgramPipelines(int n, uint* pipelines)
		{
			internalGL.glGenProgramPipelines(n, pipelines);
		}

		///<sumary> Available from OpenGL version 1.5</sumary>
		public static unsafe void glGenQueries(int n, uint* ids)
		{
			internalGL.glGenQueries(n, ids);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glGenRenderbuffers(int n, uint* renderbuffers)
		{
			internalGL.glGenRenderbuffers(n, renderbuffers);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static unsafe void glGenSamplers(int count, uint* samplers)
		{
			internalGL.glGenSamplers(count, samplers);
		}

		///<sumary> Available from OpenGL version 1.1</sumary>
		public static unsafe void glGenTextures(int n, uint* textures)
		{
			internalGL.glGenTextures(n, textures);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static unsafe void glGenTransformFeedbacks(int n, uint* ids)
		{
			internalGL.glGenTransformFeedbacks(n, ids);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glGenVertexArrays(int n, uint* arrays)
		{
			internalGL.glGenVertexArrays(n, arrays);
		}

		///<sumary> Available from OpenGL version 4.2</sumary>
		public static unsafe void glGetActiveAtomicCounterBufferiv(uint program, uint bufferIndex, AtomicCounterBufferPName pname, int* @params)
		{
			internalGL.glGetActiveAtomicCounterBufferiv(program, bufferIndex, pname, @params);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glGetActiveAttrib(uint program, uint index, int bufSize, int* length, int* size, AttributeType* type, StringBuilder name)
		{
			internalGL.glGetActiveAttrib(program, index, bufSize, length, size, type, name);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static unsafe void glGetActiveSubroutineName(uint program, ShaderType shadertype, uint index, int bufSize, int* length, StringBuilder name)
		{
			internalGL.glGetActiveSubroutineName(program, shadertype, index, bufSize, length, name);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static unsafe void glGetActiveSubroutineUniformiv(uint program, ShaderType shadertype, uint index, SubroutineParameterName pname, int* values)
		{
			internalGL.glGetActiveSubroutineUniformiv(program, shadertype, index, pname, values);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static unsafe void glGetActiveSubroutineUniformName(uint program, ShaderType shadertype, uint index, int bufSize, int* length, StringBuilder name)
		{
			internalGL.glGetActiveSubroutineUniformName(program, shadertype, index, bufSize, length, name);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glGetActiveUniform(uint program, uint index, int bufSize, int* length, int* size, UniformType* type, StringBuilder name)
		{
			internalGL.glGetActiveUniform(program, index, bufSize, length, size, type, name);
		}

		///<sumary> Available from OpenGL version 3.1</sumary>
		public static unsafe void glGetActiveUniformBlockiv(uint program, uint uniformBlockIndex, UniformBlockPName pname, int* @params)
		{
			internalGL.glGetActiveUniformBlockiv(program, uniformBlockIndex, pname, @params);
		}

		///<sumary> Available from OpenGL version 3.1</sumary>
		public static unsafe void glGetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, int* length, StringBuilder uniformBlockName)
		{
			internalGL.glGetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length, uniformBlockName);
		}

		///<sumary> Available from OpenGL version 3.1</sumary>
		public static unsafe void glGetActiveUniformName(uint program, uint uniformIndex, int bufSize, int* length, StringBuilder uniformName)
		{
			internalGL.glGetActiveUniformName(program, uniformIndex, bufSize, length, uniformName);
		}

		///<sumary> Available from OpenGL version 3.1</sumary>
		public static unsafe void glGetActiveUniformsiv(uint program, int uniformCount, uint* uniformIndices, UniformPName pname, int* @params)
		{
			internalGL.glGetActiveUniformsiv(program, uniformCount, uniformIndices, pname, @params);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glGetAttachedShaders(uint program, int maxCount, int* count, uint* shaders)
		{
			internalGL.glGetAttachedShaders(program, maxCount, count, shaders);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe int glGetAttribLocation(uint program, [MarshalAs(UnmanagedType.LPStr)] string name)
		{
			return internalGL.glGetAttribLocation(program, name);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glGetBooleani_v(BufferTargetARB target, uint index, Boolean* data)
		{
			internalGL.glGetBooleani_v(target, index, data);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static unsafe void glGetBooleanv(GetPName pname, Boolean* data)
		{
			internalGL.glGetBooleanv(pname, data);
		}

		///<sumary> Available from OpenGL version 3.2</sumary>
		public static unsafe void glGetBufferParameteri64v(BufferTargetARB target, BufferPNameARB pname, long* @params)
		{
			internalGL.glGetBufferParameteri64v(target, pname, @params);
		}

		///<sumary> Available from OpenGL version 1.5</sumary>
		public static unsafe void glGetBufferParameteriv(BufferTargetARB target, BufferPNameARB pname, int* @params)
		{
			internalGL.glGetBufferParameteriv(target, pname, @params);
		}

		///<sumary> Available from OpenGL version 1.5</sumary>
		public static void glGetBufferPointerv(BufferTargetARB target, BufferPointerNameARB pname, IntPtr @params)
		{
			internalGL.glGetBufferPointerv(target, pname, @params);
		}

		///<sumary> Available from OpenGL version 1.5</sumary>
		public static void glGetBufferSubData(BufferTargetARB target, IntPtr offset, int size, IntPtr data)
		{
			internalGL.glGetBufferSubData(target, offset, size, data);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glGetClipPlane(ClipPlaneName plane, double* equation)
		{
			internalGL.glGetClipPlane(plane, equation);
		}

		///<sumary> Available from OpenGL version 1.3</sumary>
		public static void glGetCompressedTexImage(TextureTarget target, int level, IntPtr img)
		{
			internalGL.glGetCompressedTexImage(target, level, img);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glGetCompressedTextureImage(uint texture, int level, int bufSize, IntPtr pixels)
		{
			internalGL.glGetCompressedTextureImage(texture, level, bufSize, pixels);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glGetCompressedTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, IntPtr pixels)
		{
			internalGL.glGetCompressedTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, pixels);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static unsafe uint glGetDebugMessageLog(uint count, int bufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, StringBuilder messageLog)
		{
			return internalGL.glGetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, messageLog);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glGetDoublei_v(GetPName target, uint index, double* data)
		{
			internalGL.glGetDoublei_v(target, index, data);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static unsafe void glGetDoublev(GetPName pname, double* data)
		{
			internalGL.glGetDoublev(pname, data);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static uint glGetError()
		{
			return internalGL.glGetError();
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glGetFloati_v(GetPName target, uint index, float* data)
		{
			internalGL.glGetFloati_v(target, index, data);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static unsafe void glGetFloatv(GetPName pname, float* data)
		{
			internalGL.glGetFloatv(pname, data);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static unsafe int glGetFragDataIndex(uint program, [MarshalAs(UnmanagedType.LPStr)] string name)
		{
			return internalGL.glGetFragDataIndex(program, name);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe int glGetFragDataLocation(uint program, [MarshalAs(UnmanagedType.LPStr)] string name)
		{
			return internalGL.glGetFragDataLocation(program, name);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glGetFramebufferAttachmentParameteriv(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int* @params)
		{
			internalGL.glGetFramebufferAttachmentParameteriv(target, attachment, pname, @params);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static unsafe void glGetFramebufferParameteriv(FramebufferTarget target, FramebufferAttachmentParameterName pname, int* @params)
		{
			internalGL.glGetFramebufferParameteriv(target, pname, @params);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static uint glGetGraphicsResetStatus()
		{
			return internalGL.glGetGraphicsResetStatus();
		}

		///<sumary> Available from OpenGL version 3.2</sumary>
		public static unsafe void glGetInteger64i_v(GetPName target, uint index, long* data)
		{
			internalGL.glGetInteger64i_v(target, index, data);
		}

		///<sumary> Available from OpenGL version 3.2</sumary>
		public static unsafe void glGetInteger64v(GetPName pname, long* data)
		{
			internalGL.glGetInteger64v(pname, data);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glGetIntegeri_v(GetPName target, uint index, int* data)
		{
			internalGL.glGetIntegeri_v(target, index, data);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static unsafe void glGetIntegerv(GetPName pname, int* data)
		{
			internalGL.glGetIntegerv(pname, data);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static unsafe void glGetInternalformati64v(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, int count, long* @params)
		{
			internalGL.glGetInternalformati64v(target, internalformat, pname, count, @params);
		}

		///<sumary> Available from OpenGL version 4.2</sumary>
		public static unsafe void glGetInternalformativ(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, int count, int* @params)
		{
			internalGL.glGetInternalformativ(target, internalformat, pname, count, @params);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glGetLightfv(LightName light, LightParameter pname, float* @params)
		{
			internalGL.glGetLightfv(light, pname, @params);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glGetLightiv(LightName light, LightParameter pname, int* @params)
		{
			internalGL.glGetLightiv(light, pname, @params);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glGetMapdv(MapTarget target, GetMapQuery query, double* v)
		{
			internalGL.glGetMapdv(target, query, v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glGetMapfv(MapTarget target, GetMapQuery query, float* v)
		{
			internalGL.glGetMapfv(target, query, v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glGetMapiv(MapTarget target, GetMapQuery query, int* v)
		{
			internalGL.glGetMapiv(target, query, v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glGetMaterialfv(MaterialFace face, MaterialParameter pname, float* @params)
		{
			internalGL.glGetMaterialfv(face, pname, @params);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glGetMaterialiv(MaterialFace face, MaterialParameter pname, int* @params)
		{
			internalGL.glGetMaterialiv(face, pname, @params);
		}

		///<sumary> Available from OpenGL version 3.2</sumary>
		public static unsafe void glGetMultisamplefv(GetMultisamplePNameNV pname, uint index, float* val)
		{
			internalGL.glGetMultisamplefv(pname, index, val);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glGetNamedBufferParameteri64v(uint buffer, BufferPNameARB pname, long* @params)
		{
			internalGL.glGetNamedBufferParameteri64v(buffer, pname, @params);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glGetNamedBufferParameteriv(uint buffer, BufferPNameARB pname, int* @params)
		{
			internalGL.glGetNamedBufferParameteriv(buffer, pname, @params);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glGetNamedBufferPointerv(uint buffer, BufferPointerNameARB pname, IntPtr @params)
		{
			internalGL.glGetNamedBufferPointerv(buffer, pname, @params);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glGetNamedBufferSubData(uint buffer, IntPtr offset, int size, IntPtr data)
		{
			internalGL.glGetNamedBufferSubData(buffer, offset, size, data);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glGetNamedFramebufferAttachmentParameteriv(uint framebuffer, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int* @params)
		{
			internalGL.glGetNamedFramebufferAttachmentParameteriv(framebuffer, attachment, pname, @params);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glGetNamedFramebufferParameteriv(uint framebuffer, GetFramebufferParameter pname, int* param)
		{
			internalGL.glGetNamedFramebufferParameteriv(framebuffer, pname, param);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glGetNamedRenderbufferParameteriv(uint renderbuffer, RenderbufferParameterName pname, int* @params)
		{
			internalGL.glGetNamedRenderbufferParameteriv(renderbuffer, pname, @params);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glGetnColorTable(ColorTableTarget target, PixelFormat format, PixelType type, int bufSize, IntPtr table)
		{
			internalGL.glGetnColorTable(target, format, type, bufSize, table);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glGetnCompressedTexImage(TextureTarget target, int lod, int bufSize, IntPtr pixels)
		{
			internalGL.glGetnCompressedTexImage(target, lod, bufSize, pixels);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glGetnConvolutionFilter(ConvolutionTarget target, PixelFormat format, PixelType type, int bufSize, IntPtr image)
		{
			internalGL.glGetnConvolutionFilter(target, format, type, bufSize, image);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glGetnHistogram(HistogramTarget target, Boolean reset, PixelFormat format, PixelType type, int bufSize, IntPtr values)
		{
			internalGL.glGetnHistogram(target, reset, format, type, bufSize, values);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glGetnMapdv(MapTarget target, MapQuery query, int bufSize, double* v)
		{
			internalGL.glGetnMapdv(target, query, bufSize, v);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glGetnMapfv(MapTarget target, MapQuery query, int bufSize, float* v)
		{
			internalGL.glGetnMapfv(target, query, bufSize, v);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glGetnMapiv(MapTarget target, MapQuery query, int bufSize, int* v)
		{
			internalGL.glGetnMapiv(target, query, bufSize, v);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glGetnMinmax(MinmaxTarget target, Boolean reset, PixelFormat format, PixelType type, int bufSize, IntPtr values)
		{
			internalGL.glGetnMinmax(target, reset, format, type, bufSize, values);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glGetnPixelMapfv(PixelMap map, int bufSize, float* values)
		{
			internalGL.glGetnPixelMapfv(map, bufSize, values);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glGetnPixelMapuiv(PixelMap map, int bufSize, uint* values)
		{
			internalGL.glGetnPixelMapuiv(map, bufSize, values);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glGetnPixelMapusv(PixelMap map, int bufSize, ushort* values)
		{
			internalGL.glGetnPixelMapusv(map, bufSize, values);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glGetnPolygonStipple(int bufSize, byte* pattern)
		{
			internalGL.glGetnPolygonStipple(bufSize, pattern);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glGetnSeparableFilter(SeparableTarget target, PixelFormat format, PixelType type, int rowBufSize, IntPtr row, int columnBufSize, IntPtr column, IntPtr span)
		{
			internalGL.glGetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, column, span);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glGetnTexImage(TextureTarget target, int level, PixelFormat format, PixelType type, int bufSize, IntPtr pixels)
		{
			internalGL.glGetnTexImage(target, level, format, type, bufSize, pixels);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glGetnUniformdv(uint program, int location, int bufSize, double* @params)
		{
			internalGL.glGetnUniformdv(program, location, bufSize, @params);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glGetnUniformfv(uint program, int location, int bufSize, float* @params)
		{
			internalGL.glGetnUniformfv(program, location, bufSize, @params);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glGetnUniformiv(uint program, int location, int bufSize, int* @params)
		{
			internalGL.glGetnUniformiv(program, location, bufSize, @params);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glGetnUniformuiv(uint program, int location, int bufSize, uint* @params)
		{
			internalGL.glGetnUniformuiv(program, location, bufSize, @params);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static unsafe void glGetObjectLabel(ObjectIdentifier identifier, uint name, int bufSize, int* length, StringBuilder label)
		{
			internalGL.glGetObjectLabel(identifier, name, bufSize, length, label);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static unsafe void glGetObjectPtrLabel(IntPtr ptr, int bufSize, int* length, StringBuilder label)
		{
			internalGL.glGetObjectPtrLabel(ptr, bufSize, length, label);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glGetPixelMapfv(PixelMap map, float* values)
		{
			internalGL.glGetPixelMapfv(map, values);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glGetPixelMapuiv(PixelMap map, uint* values)
		{
			internalGL.glGetPixelMapuiv(map, values);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glGetPixelMapusv(PixelMap map, ushort* values)
		{
			internalGL.glGetPixelMapusv(map, values);
		}

		///<sumary> Available from OpenGL version 1.1 | Deprecated in OpenGL version 3.2</sumary>
		public static void glGetPointerv(GetPointervPName pname, IntPtr @params)
		{
			internalGL.glGetPointerv(pname, @params);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glGetPolygonStipple(byte* mask)
		{
			internalGL.glGetPolygonStipple(mask);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glGetProgramBinary(uint program, int bufSize, int* length, uint* binaryFormat, IntPtr binary)
		{
			internalGL.glGetProgramBinary(program, bufSize, length, binaryFormat, binary);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glGetProgramInfoLog(uint program, int bufSize, int* length, StringBuilder infoLog)
		{
			internalGL.glGetProgramInfoLog(program, bufSize, length, infoLog);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static unsafe void glGetProgramInterfaceiv(uint program, ProgramInterface programInterface, ProgramInterfacePName pname, int* @params)
		{
			internalGL.glGetProgramInterfaceiv(program, programInterface, pname, @params);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glGetProgramiv(uint program, ProgramPropertyARB pname, int* @params)
		{
			internalGL.glGetProgramiv(program, pname, @params);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glGetProgramPipelineInfoLog(uint pipeline, int bufSize, int* length, StringBuilder infoLog)
		{
			internalGL.glGetProgramPipelineInfoLog(pipeline, bufSize, length, infoLog);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glGetProgramPipelineiv(uint pipeline, PipelineParameterName pname, int* @params)
		{
			internalGL.glGetProgramPipelineiv(pipeline, pname, @params);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static unsafe uint glGetProgramResourceIndex(uint program, ProgramInterface programInterface, [MarshalAs(UnmanagedType.LPStr)] string name)
		{
			return internalGL.glGetProgramResourceIndex(program, programInterface, name);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static unsafe void glGetProgramResourceiv(uint program, ProgramInterface programInterface, uint index, int propCount, ProgramResourceProperty* props, int count, int* length, int* @params)
		{
			internalGL.glGetProgramResourceiv(program, programInterface, index, propCount, props, count, length, @params);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static unsafe int glGetProgramResourceLocation(uint program, ProgramInterface programInterface, [MarshalAs(UnmanagedType.LPStr)] string name)
		{
			return internalGL.glGetProgramResourceLocation(program, programInterface, name);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static unsafe int glGetProgramResourceLocationIndex(uint program, ProgramInterface programInterface, [MarshalAs(UnmanagedType.LPStr)] string name)
		{
			return internalGL.glGetProgramResourceLocationIndex(program, programInterface, name);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static unsafe void glGetProgramResourceName(uint program, ProgramInterface programInterface, uint index, int bufSize, int* length, StringBuilder name)
		{
			internalGL.glGetProgramResourceName(program, programInterface, index, bufSize, length, name);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static unsafe void glGetProgramStageiv(uint program, ShaderType shadertype, ProgramStagePName pname, int* values)
		{
			internalGL.glGetProgramStageiv(program, shadertype, pname, values);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glGetQueryBufferObjecti64v(uint id, uint buffer, QueryObjectParameterName pname, IntPtr offset)
		{
			internalGL.glGetQueryBufferObjecti64v(id, buffer, pname, offset);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glGetQueryBufferObjectiv(uint id, uint buffer, QueryObjectParameterName pname, IntPtr offset)
		{
			internalGL.glGetQueryBufferObjectiv(id, buffer, pname, offset);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glGetQueryBufferObjectui64v(uint id, uint buffer, QueryObjectParameterName pname, IntPtr offset)
		{
			internalGL.glGetQueryBufferObjectui64v(id, buffer, pname, offset);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glGetQueryBufferObjectuiv(uint id, uint buffer, QueryObjectParameterName pname, IntPtr offset)
		{
			internalGL.glGetQueryBufferObjectuiv(id, buffer, pname, offset);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static unsafe void glGetQueryIndexediv(QueryTarget target, uint index, QueryParameterName pname, int* @params)
		{
			internalGL.glGetQueryIndexediv(target, index, pname, @params);
		}

		///<sumary> Available from OpenGL version 1.5</sumary>
		public static unsafe void glGetQueryiv(QueryTarget target, QueryParameterName pname, int* @params)
		{
			internalGL.glGetQueryiv(target, pname, @params);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static unsafe void glGetQueryObjecti64v(uint id, QueryObjectParameterName pname, long* @params)
		{
			internalGL.glGetQueryObjecti64v(id, pname, @params);
		}

		///<sumary> Available from OpenGL version 1.5</sumary>
		public static unsafe void glGetQueryObjectiv(uint id, QueryObjectParameterName pname, int* @params)
		{
			internalGL.glGetQueryObjectiv(id, pname, @params);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static unsafe void glGetQueryObjectui64v(uint id, QueryObjectParameterName pname, ulong* @params)
		{
			internalGL.glGetQueryObjectui64v(id, pname, @params);
		}

		///<sumary> Available from OpenGL version 1.5</sumary>
		public static unsafe void glGetQueryObjectuiv(uint id, QueryObjectParameterName pname, uint* @params)
		{
			internalGL.glGetQueryObjectuiv(id, pname, @params);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glGetRenderbufferParameteriv(RenderbufferTarget target, RenderbufferParameterName pname, int* @params)
		{
			internalGL.glGetRenderbufferParameteriv(target, pname, @params);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static unsafe void glGetSamplerParameterfv(uint sampler, SamplerParameterF pname, float* @params)
		{
			internalGL.glGetSamplerParameterfv(sampler, pname, @params);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static unsafe void glGetSamplerParameterIiv(uint sampler, SamplerParameterI pname, int* @params)
		{
			internalGL.glGetSamplerParameterIiv(sampler, pname, @params);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static unsafe void glGetSamplerParameterIuiv(uint sampler, SamplerParameterI pname, uint* @params)
		{
			internalGL.glGetSamplerParameterIuiv(sampler, pname, @params);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static unsafe void glGetSamplerParameteriv(uint sampler, SamplerParameterI pname, int* @params)
		{
			internalGL.glGetSamplerParameteriv(sampler, pname, @params);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glGetShaderInfoLog(uint shader, int bufSize, int* length, StringBuilder infoLog)
		{
			internalGL.glGetShaderInfoLog(shader, bufSize, length, infoLog);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glGetShaderiv(uint shader, ShaderParameterName pname, int* @params)
		{
			internalGL.glGetShaderiv(shader, pname, @params);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glGetShaderPrecisionFormat(ShaderType shadertype, PrecisionType precisiontype, int* range, int* precision)
		{
			internalGL.glGetShaderPrecisionFormat(shadertype, precisiontype, range, precision);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glGetShaderSource(uint shader, int bufSize, int* length, StringBuilder source)
		{
			internalGL.glGetShaderSource(shader, bufSize, length, source);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static unsafe byte* glGetString(StringName name)
		{
			return internalGL.glGetString(name);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe byte* glGetStringi(StringName name, uint index)
		{
			return internalGL.glGetStringi(name, index);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static unsafe uint glGetSubroutineIndex(uint program, ShaderType shadertype, [MarshalAs(UnmanagedType.LPStr)] string name)
		{
			return internalGL.glGetSubroutineIndex(program, shadertype, name);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static unsafe int glGetSubroutineUniformLocation(uint program, ShaderType shadertype, [MarshalAs(UnmanagedType.LPStr)] string name)
		{
			return internalGL.glGetSubroutineUniformLocation(program, shadertype, name);
		}

		///<sumary> Available from OpenGL version 3.2</sumary>
		public static unsafe void glGetSynciv(IntPtr sync, SyncParameterName pname, int count, int* length, int* values)
		{
			internalGL.glGetSynciv(sync, pname, count, length, values);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glGetTexEnvfv(TextureEnvTarget target, TextureEnvParameter pname, float* @params)
		{
			internalGL.glGetTexEnvfv(target, pname, @params);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glGetTexEnviv(TextureEnvTarget target, TextureEnvParameter pname, int* @params)
		{
			internalGL.glGetTexEnviv(target, pname, @params);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glGetTexGendv(TextureCoordName coord, TextureGenParameter pname, double* @params)
		{
			internalGL.glGetTexGendv(coord, pname, @params);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glGetTexGenfv(TextureCoordName coord, TextureGenParameter pname, float* @params)
		{
			internalGL.glGetTexGenfv(coord, pname, @params);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glGetTexGeniv(TextureCoordName coord, TextureGenParameter pname, int* @params)
		{
			internalGL.glGetTexGeniv(coord, pname, @params);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static void glGetTexImage(TextureTarget target, int level, PixelFormat format, PixelType type, IntPtr pixels)
		{
			internalGL.glGetTexImage(target, level, format, type, pixels);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static unsafe void glGetTexLevelParameterfv(TextureTarget target, int level, GetTextureParameter pname, float* @params)
		{
			internalGL.glGetTexLevelParameterfv(target, level, pname, @params);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static unsafe void glGetTexLevelParameteriv(TextureTarget target, int level, GetTextureParameter pname, int* @params)
		{
			internalGL.glGetTexLevelParameteriv(target, level, pname, @params);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static unsafe void glGetTexParameterfv(TextureTarget target, GetTextureParameter pname, float* @params)
		{
			internalGL.glGetTexParameterfv(target, pname, @params);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glGetTexParameterIiv(TextureTarget target, GetTextureParameter pname, int* @params)
		{
			internalGL.glGetTexParameterIiv(target, pname, @params);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glGetTexParameterIuiv(TextureTarget target, GetTextureParameter pname, uint* @params)
		{
			internalGL.glGetTexParameterIuiv(target, pname, @params);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static unsafe void glGetTexParameteriv(TextureTarget target, GetTextureParameter pname, int* @params)
		{
			internalGL.glGetTexParameteriv(target, pname, @params);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glGetTextureImage(uint texture, int level, PixelFormat format, PixelType type, int bufSize, IntPtr pixels)
		{
			internalGL.glGetTextureImage(texture, level, format, type, bufSize, pixels);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glGetTextureLevelParameterfv(uint texture, int level, GetTextureParameter pname, float* @params)
		{
			internalGL.glGetTextureLevelParameterfv(texture, level, pname, @params);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glGetTextureLevelParameteriv(uint texture, int level, GetTextureParameter pname, int* @params)
		{
			internalGL.glGetTextureLevelParameteriv(texture, level, pname, @params);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glGetTextureParameterfv(uint texture, GetTextureParameter pname, float* @params)
		{
			internalGL.glGetTextureParameterfv(texture, pname, @params);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glGetTextureParameterIiv(uint texture, GetTextureParameter pname, int* @params)
		{
			internalGL.glGetTextureParameterIiv(texture, pname, @params);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glGetTextureParameterIuiv(uint texture, GetTextureParameter pname, uint* @params)
		{
			internalGL.glGetTextureParameterIuiv(texture, pname, @params);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glGetTextureParameteriv(uint texture, GetTextureParameter pname, int* @params)
		{
			internalGL.glGetTextureParameteriv(texture, pname, @params);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glGetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, int bufSize, IntPtr pixels)
		{
			internalGL.glGetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, pixels);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glGetTransformFeedbacki_v(uint xfb, TransformFeedbackPName pname, uint index, int* param)
		{
			internalGL.glGetTransformFeedbacki_v(xfb, pname, index, param);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glGetTransformFeedbacki64_v(uint xfb, TransformFeedbackPName pname, uint index, long* param)
		{
			internalGL.glGetTransformFeedbacki64_v(xfb, pname, index, param);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glGetTransformFeedbackiv(uint xfb, TransformFeedbackPName pname, int* param)
		{
			internalGL.glGetTransformFeedbackiv(xfb, pname, param);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glGetTransformFeedbackVarying(uint program, uint index, int bufSize, int* length, int* size, AttributeType* type, StringBuilder name)
		{
			internalGL.glGetTransformFeedbackVarying(program, index, bufSize, length, size, type, name);
		}

		///<sumary> Available from OpenGL version 3.1</sumary>
		public static unsafe uint glGetUniformBlockIndex(uint program, [MarshalAs(UnmanagedType.LPStr)] string uniformBlockName)
		{
			return internalGL.glGetUniformBlockIndex(program, uniformBlockName);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static unsafe void glGetUniformdv(uint program, int location, double* @params)
		{
			internalGL.glGetUniformdv(program, location, @params);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glGetUniformfv(uint program, int location, float* @params)
		{
			internalGL.glGetUniformfv(program, location, @params);
		}

		///<sumary> Available from OpenGL version 3.1</sumary>
		public static unsafe void glGetUniformIndices(uint program, int uniformCount, [MarshalAs(UnmanagedType.LPStr)] string[] uniformNames, uint* uniformIndices)
		{
			internalGL.glGetUniformIndices(program, uniformCount, uniformNames, uniformIndices);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glGetUniformiv(uint program, int location, int* @params)
		{
			internalGL.glGetUniformiv(program, location, @params);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe int glGetUniformLocation(uint program, [MarshalAs(UnmanagedType.LPStr)] string name)
		{
			return internalGL.glGetUniformLocation(program, name);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static unsafe void glGetUniformSubroutineuiv(ShaderType shadertype, int location, uint* @params)
		{
			internalGL.glGetUniformSubroutineuiv(shadertype, location, @params);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glGetUniformuiv(uint program, int location, uint* @params)
		{
			internalGL.glGetUniformuiv(program, location, @params);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glGetVertexArrayIndexed64iv(uint vaobj, uint index, VertexArrayPName pname, long* param)
		{
			internalGL.glGetVertexArrayIndexed64iv(vaobj, index, pname, param);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glGetVertexArrayIndexediv(uint vaobj, uint index, VertexArrayPName pname, int* param)
		{
			internalGL.glGetVertexArrayIndexediv(vaobj, index, pname, param);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glGetVertexArrayiv(uint vaobj, VertexArrayPName pname, int* param)
		{
			internalGL.glGetVertexArrayiv(vaobj, pname, param);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glGetVertexAttribdv(uint index, VertexAttribPropertyARB pname, double* @params)
		{
			internalGL.glGetVertexAttribdv(index, pname, @params);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glGetVertexAttribfv(uint index, VertexAttribPropertyARB pname, float* @params)
		{
			internalGL.glGetVertexAttribfv(index, pname, @params);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glGetVertexAttribIiv(uint index, VertexAttribEnum pname, int* @params)
		{
			internalGL.glGetVertexAttribIiv(index, pname, @params);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glGetVertexAttribIuiv(uint index, VertexAttribEnum pname, uint* @params)
		{
			internalGL.glGetVertexAttribIuiv(index, pname, @params);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glGetVertexAttribiv(uint index, VertexAttribPropertyARB pname, int* @params)
		{
			internalGL.glGetVertexAttribiv(index, pname, @params);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glGetVertexAttribLdv(uint index, VertexAttribEnum pname, double* @params)
		{
			internalGL.glGetVertexAttribLdv(index, pname, @params);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static void glGetVertexAttribPointerv(uint index, VertexAttribPointerPropertyARB pname, IntPtr pointer)
		{
			internalGL.glGetVertexAttribPointerv(index, pname, pointer);
		}

		#endregion

		#region H:

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static void glHint(HintTarget target, HintMode mode)
		{
			internalGL.glHint(target, mode);
		}

		#endregion

		#region I:

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glIndexd(double c)
		{
			internalGL.glIndexd(c);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glIndexdv(double* c)
		{
			internalGL.glIndexdv(c);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glIndexf(float c)
		{
			internalGL.glIndexf(c);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glIndexfv(float* c)
		{
			internalGL.glIndexfv(c);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glIndexi(int c)
		{
			internalGL.glIndexi(c);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glIndexiv(int* c)
		{
			internalGL.glIndexiv(c);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glIndexMask(uint mask)
		{
			internalGL.glIndexMask(mask);
		}

		///<sumary> Available from OpenGL version 1.1 | Deprecated in OpenGL version 3.2</sumary>
		public static void glIndexPointer(IndexPointerType type, int stride, IntPtr pointer)
		{
			internalGL.glIndexPointer(type, stride, pointer);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glIndexs(short c)
		{
			internalGL.glIndexs(c);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glIndexsv(short* c)
		{
			internalGL.glIndexsv(c);
		}

		///<sumary> Available from OpenGL version 1.1 | Deprecated in OpenGL version 3.2</sumary>
		public static void glIndexub(byte c)
		{
			internalGL.glIndexub(c);
		}

		///<sumary> Available from OpenGL version 1.1 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glIndexubv(byte* c)
		{
			internalGL.glIndexubv(c);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glInitNames()
		{
			internalGL.glInitNames();
		}

		///<sumary> Available from OpenGL version 1.1 | Deprecated in OpenGL version 3.2</sumary>
		public static void glInterleavedArrays(InterleavedArrayFormat format, int stride, IntPtr pointer)
		{
			internalGL.glInterleavedArrays(format, stride, pointer);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static void glInvalidateBufferData(uint buffer)
		{
			internalGL.glInvalidateBufferData(buffer);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static void glInvalidateBufferSubData(uint buffer, IntPtr offset, int length)
		{
			internalGL.glInvalidateBufferSubData(buffer, offset, length);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static unsafe void glInvalidateFramebuffer(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment* attachments)
		{
			internalGL.glInvalidateFramebuffer(target, numAttachments, attachments);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glInvalidateNamedFramebufferData(uint framebuffer, int numAttachments, FramebufferAttachment* attachments)
		{
			internalGL.glInvalidateNamedFramebufferData(framebuffer, numAttachments, attachments);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glInvalidateNamedFramebufferSubData(uint framebuffer, int numAttachments, FramebufferAttachment* attachments, int x, int y, int width, int height)
		{
			internalGL.glInvalidateNamedFramebufferSubData(framebuffer, numAttachments, attachments, x, y, width, height);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static unsafe void glInvalidateSubFramebuffer(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment* attachments, int x, int y, int width, int height)
		{
			internalGL.glInvalidateSubFramebuffer(target, numAttachments, attachments, x, y, width, height);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static void glInvalidateTexImage(uint texture, int level)
		{
			internalGL.glInvalidateTexImage(texture, level);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static void glInvalidateTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth)
		{
			internalGL.glInvalidateTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth);
		}

		///<sumary> Available from OpenGL version 1.5</sumary>
		public static bool glIsBuffer(uint buffer)
		{
			return internalGL.glIsBuffer(buffer);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static bool glIsEnabled(EnableCap cap)
		{
			return internalGL.glIsEnabled(cap);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static bool glIsEnabledi(EnableCap target, uint index)
		{
			return internalGL.glIsEnabledi(target, index);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static bool glIsFramebuffer(uint framebuffer)
		{
			return internalGL.glIsFramebuffer(framebuffer);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static bool glIsList(uint list)
		{
			return internalGL.glIsList(list);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static bool glIsProgram(uint program)
		{
			return internalGL.glIsProgram(program);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static bool glIsProgramPipeline(uint pipeline)
		{
			return internalGL.glIsProgramPipeline(pipeline);
		}

		///<sumary> Available from OpenGL version 1.5</sumary>
		public static bool glIsQuery(uint id)
		{
			return internalGL.glIsQuery(id);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static bool glIsRenderbuffer(uint renderbuffer)
		{
			return internalGL.glIsRenderbuffer(renderbuffer);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static bool glIsSampler(uint sampler)
		{
			return internalGL.glIsSampler(sampler);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static bool glIsShader(uint shader)
		{
			return internalGL.glIsShader(shader);
		}

		///<sumary> Available from OpenGL version 3.2</sumary>
		public static bool glIsSync(IntPtr sync)
		{
			return internalGL.glIsSync(sync);
		}

		///<sumary> Available from OpenGL version 1.1</sumary>
		public static bool glIsTexture(uint texture)
		{
			return internalGL.glIsTexture(texture);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static bool glIsTransformFeedback(uint id)
		{
			return internalGL.glIsTransformFeedback(id);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static bool glIsVertexArray(uint array)
		{
			return internalGL.glIsVertexArray(array);
		}

		#endregion

		#region L:

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glLightf(LightName light, LightParameter pname, float param)
		{
			internalGL.glLightf(light, pname, param);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glLightfv(LightName light, LightParameter pname, float* @params)
		{
			internalGL.glLightfv(light, pname, @params);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glLighti(LightName light, LightParameter pname, int param)
		{
			internalGL.glLighti(light, pname, param);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glLightiv(LightName light, LightParameter pname, int* @params)
		{
			internalGL.glLightiv(light, pname, @params);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glLightModelf(LightModelParameter pname, float param)
		{
			internalGL.glLightModelf(pname, param);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glLightModelfv(LightModelParameter pname, float* @params)
		{
			internalGL.glLightModelfv(pname, @params);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glLightModeli(LightModelParameter pname, int param)
		{
			internalGL.glLightModeli(pname, param);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glLightModeliv(LightModelParameter pname, int* @params)
		{
			internalGL.glLightModeliv(pname, @params);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glLineStipple(int factor, ushort pattern)
		{
			internalGL.glLineStipple(factor, pattern);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static void glLineWidth(float width)
		{
			internalGL.glLineWidth(width);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static void glLinkProgram(uint program)
		{
			internalGL.glLinkProgram(program);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glListBase(uint @base)
		{
			internalGL.glListBase(@base);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glLoadIdentity()
		{
			internalGL.glLoadIdentity();
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glLoadMatrixd(double* m)
		{
			internalGL.glLoadMatrixd(m);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glLoadMatrixf(float* m)
		{
			internalGL.glLoadMatrixf(m);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glLoadName(uint name)
		{
			internalGL.glLoadName(name);
		}

		///<sumary> Available from OpenGL version 1.3 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glLoadTransposeMatrixd(double* m)
		{
			internalGL.glLoadTransposeMatrixd(m);
		}

		///<sumary> Available from OpenGL version 1.3 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glLoadTransposeMatrixf(float* m)
		{
			internalGL.glLoadTransposeMatrixf(m);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static void glLogicOp(LogicOp opcode)
		{
			internalGL.glLogicOp(opcode);
		}

		#endregion

		#region M:

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glMap1d(MapTarget target, double u1, double u2, int stride, int order, double* points)
		{
			internalGL.glMap1d(target, u1, u2, stride, order, points);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glMap1f(MapTarget target, float u1, float u2, int stride, int order, float* points)
		{
			internalGL.glMap1f(target, u1, u2, stride, order, points);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glMap2d(MapTarget target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double* points)
		{
			internalGL.glMap2d(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glMap2f(MapTarget target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float* points)
		{
			internalGL.glMap2f(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
		}

		///<sumary> Available from OpenGL version 1.5</sumary>
		public static IntPtr glMapBuffer(BufferTargetARB target, BufferAccessARB access)
		{
			return internalGL.glMapBuffer(target, access);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static IntPtr glMapBufferRange(BufferTargetARB target, IntPtr offset, int length, MapBufferAccessMask access)
		{
			return internalGL.glMapBufferRange(target, offset, length, access);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glMapGrid1d(int un, double u1, double u2)
		{
			internalGL.glMapGrid1d(un, u1, u2);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glMapGrid1f(int un, float u1, float u2)
		{
			internalGL.glMapGrid1f(un, u1, u2);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glMapGrid2d(int un, double u1, double u2, int vn, double v1, double v2)
		{
			internalGL.glMapGrid2d(un, u1, u2, vn, v1, v2);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glMapGrid2f(int un, float u1, float u2, int vn, float v1, float v2)
		{
			internalGL.glMapGrid2f(un, u1, u2, vn, v1, v2);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe IntPtr* glMapNamedBuffer(uint buffer, BufferAccessARB access)
		{
			return internalGL.glMapNamedBuffer(buffer, access);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe IntPtr* glMapNamedBufferRange(uint buffer, IntPtr offset, int length, MapBufferAccessMask access)
		{
			return internalGL.glMapNamedBufferRange(buffer, offset, length, access);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glMaterialf(MaterialFace face, MaterialParameter pname, float param)
		{
			internalGL.glMaterialf(face, pname, param);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glMaterialfv(MaterialFace face, MaterialParameter pname, float* @params)
		{
			internalGL.glMaterialfv(face, pname, @params);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glMateriali(MaterialFace face, MaterialParameter pname, int param)
		{
			internalGL.glMateriali(face, pname, param);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glMaterialiv(MaterialFace face, MaterialParameter pname, int* @params)
		{
			internalGL.glMaterialiv(face, pname, @params);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glMatrixMode(MatrixMode mode)
		{
			internalGL.glMatrixMode(mode);
		}

		///<sumary> Available from OpenGL version 4.2</sumary>
		public static void glMemoryBarrier(MemoryBarrierMask barriers)
		{
			internalGL.glMemoryBarrier(barriers);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glMemoryBarrierByRegion(MemoryBarrierMask barriers)
		{
			internalGL.glMemoryBarrierByRegion(barriers);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static void glMinSampleShading(float value)
		{
			internalGL.glMinSampleShading(value);
		}

		///<sumary> Available from OpenGL version 1.4</sumary>
		public static unsafe void glMultiDrawArrays(PrimitiveType mode, int* first, int* count, int drawcount)
		{
			internalGL.glMultiDrawArrays(mode, first, count, drawcount);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static void glMultiDrawArraysIndirect(PrimitiveType mode, IntPtr indirect, int drawcount, int stride)
		{
			internalGL.glMultiDrawArraysIndirect(mode, indirect, drawcount, stride);
		}

		///<sumary> Available from OpenGL version 4.6</sumary>
		public static void glMultiDrawArraysIndirectCount(PrimitiveType mode, IntPtr indirect, IntPtr drawcount, int maxdrawcount, int stride)
		{
			internalGL.glMultiDrawArraysIndirectCount(mode, indirect, drawcount, maxdrawcount, stride);
		}

		///<sumary> Available from OpenGL version 1.4</sumary>
		public static unsafe void glMultiDrawElements(PrimitiveType mode, int* count, DrawElementsType type, IntPtr indices, int drawcount)
		{
			internalGL.glMultiDrawElements(mode, count, type, indices, drawcount);
		}

		///<sumary> Available from OpenGL version 3.2</sumary>
		public static unsafe void glMultiDrawElementsBaseVertex(PrimitiveType mode, int* count, DrawElementsType type, IntPtr indices, int drawcount, int* basevertex)
		{
			internalGL.glMultiDrawElementsBaseVertex(mode, count, type, indices, drawcount, basevertex);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static void glMultiDrawElementsIndirect(PrimitiveType mode, DrawElementsType type, IntPtr indirect, int drawcount, int stride)
		{
			internalGL.glMultiDrawElementsIndirect(mode, type, indirect, drawcount, stride);
		}

		///<sumary> Available from OpenGL version 4.6</sumary>
		public static void glMultiDrawElementsIndirectCount(PrimitiveType mode, DrawElementsType type, IntPtr indirect, IntPtr drawcount, int maxdrawcount, int stride)
		{
			internalGL.glMultiDrawElementsIndirectCount(mode, type, indirect, drawcount, maxdrawcount, stride);
		}

		///<sumary> Available from OpenGL version 1.3 | Deprecated in OpenGL version 3.2</sumary>
		public static void glMultiTexCoord1d(TextureUnit target, double s)
		{
			internalGL.glMultiTexCoord1d(target, s);
		}

		///<sumary> Available from OpenGL version 1.3 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glMultiTexCoord1dv(TextureUnit target, double* v)
		{
			internalGL.glMultiTexCoord1dv(target, v);
		}

		///<sumary> Available from OpenGL version 1.3 | Deprecated in OpenGL version 3.2</sumary>
		public static void glMultiTexCoord1f(TextureUnit target, float s)
		{
			internalGL.glMultiTexCoord1f(target, s);
		}

		///<sumary> Available from OpenGL version 1.3 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glMultiTexCoord1fv(TextureUnit target, float* v)
		{
			internalGL.glMultiTexCoord1fv(target, v);
		}

		///<sumary> Available from OpenGL version 1.3 | Deprecated in OpenGL version 3.2</sumary>
		public static void glMultiTexCoord1i(TextureUnit target, int s)
		{
			internalGL.glMultiTexCoord1i(target, s);
		}

		///<sumary> Available from OpenGL version 1.3 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glMultiTexCoord1iv(TextureUnit target, int* v)
		{
			internalGL.glMultiTexCoord1iv(target, v);
		}

		///<sumary> Available from OpenGL version 1.3 | Deprecated in OpenGL version 3.2</sumary>
		public static void glMultiTexCoord1s(TextureUnit target, short s)
		{
			internalGL.glMultiTexCoord1s(target, s);
		}

		///<sumary> Available from OpenGL version 1.3 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glMultiTexCoord1sv(TextureUnit target, short* v)
		{
			internalGL.glMultiTexCoord1sv(target, v);
		}

		///<sumary> Available from OpenGL version 1.3 | Deprecated in OpenGL version 3.2</sumary>
		public static void glMultiTexCoord2d(TextureUnit target, double s, double t)
		{
			internalGL.glMultiTexCoord2d(target, s, t);
		}

		///<sumary> Available from OpenGL version 1.3 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glMultiTexCoord2dv(TextureUnit target, double* v)
		{
			internalGL.glMultiTexCoord2dv(target, v);
		}

		///<sumary> Available from OpenGL version 1.3 | Deprecated in OpenGL version 3.2</sumary>
		public static void glMultiTexCoord2f(TextureUnit target, float s, float t)
		{
			internalGL.glMultiTexCoord2f(target, s, t);
		}

		///<sumary> Available from OpenGL version 1.3 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glMultiTexCoord2fv(TextureUnit target, float* v)
		{
			internalGL.glMultiTexCoord2fv(target, v);
		}

		///<sumary> Available from OpenGL version 1.3 | Deprecated in OpenGL version 3.2</sumary>
		public static void glMultiTexCoord2i(TextureUnit target, int s, int t)
		{
			internalGL.glMultiTexCoord2i(target, s, t);
		}

		///<sumary> Available from OpenGL version 1.3 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glMultiTexCoord2iv(TextureUnit target, int* v)
		{
			internalGL.glMultiTexCoord2iv(target, v);
		}

		///<sumary> Available from OpenGL version 1.3 | Deprecated in OpenGL version 3.2</sumary>
		public static void glMultiTexCoord2s(TextureUnit target, short s, short t)
		{
			internalGL.glMultiTexCoord2s(target, s, t);
		}

		///<sumary> Available from OpenGL version 1.3 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glMultiTexCoord2sv(TextureUnit target, short* v)
		{
			internalGL.glMultiTexCoord2sv(target, v);
		}

		///<sumary> Available from OpenGL version 1.3 | Deprecated in OpenGL version 3.2</sumary>
		public static void glMultiTexCoord3d(TextureUnit target, double s, double t, double r)
		{
			internalGL.glMultiTexCoord3d(target, s, t, r);
		}

		///<sumary> Available from OpenGL version 1.3 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glMultiTexCoord3dv(TextureUnit target, double* v)
		{
			internalGL.glMultiTexCoord3dv(target, v);
		}

		///<sumary> Available from OpenGL version 1.3 | Deprecated in OpenGL version 3.2</sumary>
		public static void glMultiTexCoord3f(TextureUnit target, float s, float t, float r)
		{
			internalGL.glMultiTexCoord3f(target, s, t, r);
		}

		///<sumary> Available from OpenGL version 1.3 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glMultiTexCoord3fv(TextureUnit target, float* v)
		{
			internalGL.glMultiTexCoord3fv(target, v);
		}

		///<sumary> Available from OpenGL version 1.3 | Deprecated in OpenGL version 3.2</sumary>
		public static void glMultiTexCoord3i(TextureUnit target, int s, int t, int r)
		{
			internalGL.glMultiTexCoord3i(target, s, t, r);
		}

		///<sumary> Available from OpenGL version 1.3 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glMultiTexCoord3iv(TextureUnit target, int* v)
		{
			internalGL.glMultiTexCoord3iv(target, v);
		}

		///<sumary> Available from OpenGL version 1.3 | Deprecated in OpenGL version 3.2</sumary>
		public static void glMultiTexCoord3s(TextureUnit target, short s, short t, short r)
		{
			internalGL.glMultiTexCoord3s(target, s, t, r);
		}

		///<sumary> Available from OpenGL version 1.3 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glMultiTexCoord3sv(TextureUnit target, short* v)
		{
			internalGL.glMultiTexCoord3sv(target, v);
		}

		///<sumary> Available from OpenGL version 1.3 | Deprecated in OpenGL version 3.2</sumary>
		public static void glMultiTexCoord4d(TextureUnit target, double s, double t, double r, double q)
		{
			internalGL.glMultiTexCoord4d(target, s, t, r, q);
		}

		///<sumary> Available from OpenGL version 1.3 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glMultiTexCoord4dv(TextureUnit target, double* v)
		{
			internalGL.glMultiTexCoord4dv(target, v);
		}

		///<sumary> Available from OpenGL version 1.3 | Deprecated in OpenGL version 3.2</sumary>
		public static void glMultiTexCoord4f(TextureUnit target, float s, float t, float r, float q)
		{
			internalGL.glMultiTexCoord4f(target, s, t, r, q);
		}

		///<sumary> Available from OpenGL version 1.3 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glMultiTexCoord4fv(TextureUnit target, float* v)
		{
			internalGL.glMultiTexCoord4fv(target, v);
		}

		///<sumary> Available from OpenGL version 1.3 | Deprecated in OpenGL version 3.2</sumary>
		public static void glMultiTexCoord4i(TextureUnit target, int s, int t, int r, int q)
		{
			internalGL.glMultiTexCoord4i(target, s, t, r, q);
		}

		///<sumary> Available from OpenGL version 1.3 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glMultiTexCoord4iv(TextureUnit target, int* v)
		{
			internalGL.glMultiTexCoord4iv(target, v);
		}

		///<sumary> Available from OpenGL version 1.3 | Deprecated in OpenGL version 3.2</sumary>
		public static void glMultiTexCoord4s(TextureUnit target, short s, short t, short r, short q)
		{
			internalGL.glMultiTexCoord4s(target, s, t, r, q);
		}

		///<sumary> Available from OpenGL version 1.3 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glMultiTexCoord4sv(TextureUnit target, short* v)
		{
			internalGL.glMultiTexCoord4sv(target, v);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static void glMultiTexCoordP1ui(TextureUnit texture, TexCoordPointerType type, uint coords)
		{
			internalGL.glMultiTexCoordP1ui(texture, type, coords);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static unsafe void glMultiTexCoordP1uiv(TextureUnit texture, TexCoordPointerType type, uint* coords)
		{
			internalGL.glMultiTexCoordP1uiv(texture, type, coords);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static void glMultiTexCoordP2ui(TextureUnit texture, TexCoordPointerType type, uint coords)
		{
			internalGL.glMultiTexCoordP2ui(texture, type, coords);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static unsafe void glMultiTexCoordP2uiv(TextureUnit texture, TexCoordPointerType type, uint* coords)
		{
			internalGL.glMultiTexCoordP2uiv(texture, type, coords);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static void glMultiTexCoordP3ui(TextureUnit texture, TexCoordPointerType type, uint coords)
		{
			internalGL.glMultiTexCoordP3ui(texture, type, coords);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static unsafe void glMultiTexCoordP3uiv(TextureUnit texture, TexCoordPointerType type, uint* coords)
		{
			internalGL.glMultiTexCoordP3uiv(texture, type, coords);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static void glMultiTexCoordP4ui(TextureUnit texture, TexCoordPointerType type, uint coords)
		{
			internalGL.glMultiTexCoordP4ui(texture, type, coords);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static unsafe void glMultiTexCoordP4uiv(TextureUnit texture, TexCoordPointerType type, uint* coords)
		{
			internalGL.glMultiTexCoordP4uiv(texture, type, coords);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glMultMatrixd(double* m)
		{
			internalGL.glMultMatrixd(m);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glMultMatrixf(float* m)
		{
			internalGL.glMultMatrixf(m);
		}

		///<sumary> Available from OpenGL version 1.3 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glMultTransposeMatrixd(double* m)
		{
			internalGL.glMultTransposeMatrixd(m);
		}

		///<sumary> Available from OpenGL version 1.3 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glMultTransposeMatrixf(float* m)
		{
			internalGL.glMultTransposeMatrixf(m);
		}

		#endregion

		#region N:

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glNamedBufferData(uint buffer, int size, IntPtr data, VertexBufferObjectUsage usage)
		{
			internalGL.glNamedBufferData(buffer, size, data, usage);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glNamedBufferStorage(uint buffer, int size, IntPtr data, BufferStorageMask flags)
		{
			internalGL.glNamedBufferStorage(buffer, size, data, flags);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glNamedBufferSubData(uint buffer, IntPtr offset, int size, IntPtr data)
		{
			internalGL.glNamedBufferSubData(buffer, offset, size, data);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glNamedFramebufferDrawBuffer(uint framebuffer, ColorBuffer buf)
		{
			internalGL.glNamedFramebufferDrawBuffer(framebuffer, buf);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glNamedFramebufferDrawBuffers(uint framebuffer, int n, ColorBuffer* bufs)
		{
			internalGL.glNamedFramebufferDrawBuffers(framebuffer, n, bufs);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glNamedFramebufferParameteri(uint framebuffer, FramebufferParameterName pname, int param)
		{
			internalGL.glNamedFramebufferParameteri(framebuffer, pname, param);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glNamedFramebufferReadBuffer(uint framebuffer, ColorBuffer src)
		{
			internalGL.glNamedFramebufferReadBuffer(framebuffer, src);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glNamedFramebufferRenderbuffer(uint framebuffer, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, uint renderbuffer)
		{
			internalGL.glNamedFramebufferRenderbuffer(framebuffer, attachment, renderbuffertarget, renderbuffer);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glNamedFramebufferTexture(uint framebuffer, FramebufferAttachment attachment, uint texture, int level)
		{
			internalGL.glNamedFramebufferTexture(framebuffer, attachment, texture, level);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glNamedFramebufferTextureLayer(uint framebuffer, FramebufferAttachment attachment, uint texture, int level, int layer)
		{
			internalGL.glNamedFramebufferTextureLayer(framebuffer, attachment, texture, level, layer);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glNamedRenderbufferStorage(uint renderbuffer, InternalFormat internalformat, int width, int height)
		{
			internalGL.glNamedRenderbufferStorage(renderbuffer, internalformat, width, height);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glNamedRenderbufferStorageMultisample(uint renderbuffer, int samples, InternalFormat internalformat, int width, int height)
		{
			internalGL.glNamedRenderbufferStorageMultisample(renderbuffer, samples, internalformat, width, height);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glNewList(uint list, ListMode mode)
		{
			internalGL.glNewList(list, mode);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glNormal3b(sbyte nx, sbyte ny, sbyte nz)
		{
			internalGL.glNormal3b(nx, ny, nz);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glNormal3bv(sbyte* v)
		{
			internalGL.glNormal3bv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glNormal3d(double nx, double ny, double nz)
		{
			internalGL.glNormal3d(nx, ny, nz);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glNormal3dv(double* v)
		{
			internalGL.glNormal3dv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glNormal3f(float nx, float ny, float nz)
		{
			internalGL.glNormal3f(nx, ny, nz);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glNormal3fv(float* v)
		{
			internalGL.glNormal3fv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glNormal3i(int nx, int ny, int nz)
		{
			internalGL.glNormal3i(nx, ny, nz);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glNormal3iv(int* v)
		{
			internalGL.glNormal3iv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glNormal3s(short nx, short ny, short nz)
		{
			internalGL.glNormal3s(nx, ny, nz);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glNormal3sv(short* v)
		{
			internalGL.glNormal3sv(v);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static void glNormalP3ui(NormalPointerType type, uint coords)
		{
			internalGL.glNormalP3ui(type, coords);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static unsafe void glNormalP3uiv(NormalPointerType type, uint* coords)
		{
			internalGL.glNormalP3uiv(type, coords);
		}

		///<sumary> Available from OpenGL version 1.1 | Deprecated in OpenGL version 3.2</sumary>
		public static void glNormalPointer(NormalPointerType type, int stride, IntPtr pointer)
		{
			internalGL.glNormalPointer(type, stride, pointer);
		}

		#endregion

		#region O:

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static unsafe void glObjectLabel(ObjectIdentifier identifier, uint name, int length, [MarshalAs(UnmanagedType.LPStr)] string label)
		{
			internalGL.glObjectLabel(identifier, name, length, label);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static unsafe void glObjectPtrLabel(IntPtr ptr, int length, [MarshalAs(UnmanagedType.LPStr)] string label)
		{
			internalGL.glObjectPtrLabel(ptr, length, label);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glOrtho(double left, double right, double bottom, double top, double zNear, double zFar)
		{
			internalGL.glOrtho(left, right, bottom, top, zNear, zFar);
		}

		#endregion

		#region P:

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glPassThrough(float token)
		{
			internalGL.glPassThrough(token);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static unsafe void glPatchParameterfv(PatchParameterName pname, float* values)
		{
			internalGL.glPatchParameterfv(pname, values);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static void glPatchParameteri(PatchParameterName pname, int value)
		{
			internalGL.glPatchParameteri(pname, value);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static void glPauseTransformFeedback()
		{
			internalGL.glPauseTransformFeedback();
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glPixelMapfv(PixelMap map, int mapsize, float* values)
		{
			internalGL.glPixelMapfv(map, mapsize, values);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glPixelMapuiv(PixelMap map, int mapsize, uint* values)
		{
			internalGL.glPixelMapuiv(map, mapsize, values);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glPixelMapusv(PixelMap map, int mapsize, ushort* values)
		{
			internalGL.glPixelMapusv(map, mapsize, values);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static void glPixelStoref(PixelStoreParameter pname, float param)
		{
			internalGL.glPixelStoref(pname, param);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static void glPixelStorei(PixelStoreParameter pname, int param)
		{
			internalGL.glPixelStorei(pname, param);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glPixelTransferf(PixelTransferParameter pname, float param)
		{
			internalGL.glPixelTransferf(pname, param);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glPixelTransferi(PixelTransferParameter pname, int param)
		{
			internalGL.glPixelTransferi(pname, param);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glPixelZoom(float xfactor, float yfactor)
		{
			internalGL.glPixelZoom(xfactor, yfactor);
		}

		///<sumary> Available from OpenGL version 1.4</sumary>
		public static void glPointParameterf(PointParameterNameARB pname, float param)
		{
			internalGL.glPointParameterf(pname, param);
		}

		///<sumary> Available from OpenGL version 1.4</sumary>
		public static unsafe void glPointParameterfv(PointParameterNameARB pname, float* @params)
		{
			internalGL.glPointParameterfv(pname, @params);
		}

		///<sumary> Available from OpenGL version 1.4</sumary>
		public static void glPointParameteri(PointParameterNameARB pname, int param)
		{
			internalGL.glPointParameteri(pname, param);
		}

		///<sumary> Available from OpenGL version 1.4</sumary>
		public static unsafe void glPointParameteriv(PointParameterNameARB pname, int* @params)
		{
			internalGL.glPointParameteriv(pname, @params);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static void glPointSize(float size)
		{
			internalGL.glPointSize(size);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static void glPolygonMode(MaterialFace face, PolygonMode mode)
		{
			internalGL.glPolygonMode(face, mode);
		}

		///<sumary> Available from OpenGL version 1.1</sumary>
		public static void glPolygonOffset(float factor, float units)
		{
			internalGL.glPolygonOffset(factor, units);
		}

		///<sumary> Available from OpenGL version 4.6</sumary>
		public static void glPolygonOffsetClamp(float factor, float units, float clamp)
		{
			internalGL.glPolygonOffsetClamp(factor, units, clamp);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glPolygonStipple(byte* mask)
		{
			internalGL.glPolygonStipple(mask);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glPopAttrib()
		{
			internalGL.glPopAttrib();
		}

		///<sumary> Available from OpenGL version 1.1 | Deprecated in OpenGL version 3.2</sumary>
		public static void glPopClientAttrib()
		{
			internalGL.glPopClientAttrib();
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static void glPopDebugGroup()
		{
			internalGL.glPopDebugGroup();
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glPopMatrix()
		{
			internalGL.glPopMatrix();
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glPopName()
		{
			internalGL.glPopName();
		}

		///<sumary> Available from OpenGL version 3.1</sumary>
		public static void glPrimitiveRestartIndex(uint index)
		{
			internalGL.glPrimitiveRestartIndex(index);
		}

		///<sumary> Available from OpenGL version 1.1 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glPrioritizeTextures(int n, uint* textures, float* priorities)
		{
			internalGL.glPrioritizeTextures(n, textures, priorities);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static void glProgramBinary(uint program, uint binaryFormat, IntPtr binary, int length)
		{
			internalGL.glProgramBinary(program, binaryFormat, binary, length);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static void glProgramParameteri(uint program, ProgramParameterPName pname, int value)
		{
			internalGL.glProgramParameteri(program, pname, value);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static void glProgramUniform1d(uint program, int location, double v0)
		{
			internalGL.glProgramUniform1d(program, location, v0);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glProgramUniform1dv(uint program, int location, int count, double* value)
		{
			internalGL.glProgramUniform1dv(program, location, count, value);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static void glProgramUniform1f(uint program, int location, float v0)
		{
			internalGL.glProgramUniform1f(program, location, v0);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glProgramUniform1fv(uint program, int location, int count, float* value)
		{
			internalGL.glProgramUniform1fv(program, location, count, value);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static void glProgramUniform1i(uint program, int location, int v0)
		{
			internalGL.glProgramUniform1i(program, location, v0);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glProgramUniform1iv(uint program, int location, int count, int* value)
		{
			internalGL.glProgramUniform1iv(program, location, count, value);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static void glProgramUniform1ui(uint program, int location, uint v0)
		{
			internalGL.glProgramUniform1ui(program, location, v0);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glProgramUniform1uiv(uint program, int location, int count, uint* value)
		{
			internalGL.glProgramUniform1uiv(program, location, count, value);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static void glProgramUniform2d(uint program, int location, double v0, double v1)
		{
			internalGL.glProgramUniform2d(program, location, v0, v1);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glProgramUniform2dv(uint program, int location, int count, double* value)
		{
			internalGL.glProgramUniform2dv(program, location, count, value);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static void glProgramUniform2f(uint program, int location, float v0, float v1)
		{
			internalGL.glProgramUniform2f(program, location, v0, v1);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glProgramUniform2fv(uint program, int location, int count, float* value)
		{
			internalGL.glProgramUniform2fv(program, location, count, value);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static void glProgramUniform2i(uint program, int location, int v0, int v1)
		{
			internalGL.glProgramUniform2i(program, location, v0, v1);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glProgramUniform2iv(uint program, int location, int count, int* value)
		{
			internalGL.glProgramUniform2iv(program, location, count, value);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static void glProgramUniform2ui(uint program, int location, uint v0, uint v1)
		{
			internalGL.glProgramUniform2ui(program, location, v0, v1);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glProgramUniform2uiv(uint program, int location, int count, uint* value)
		{
			internalGL.glProgramUniform2uiv(program, location, count, value);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static void glProgramUniform3d(uint program, int location, double v0, double v1, double v2)
		{
			internalGL.glProgramUniform3d(program, location, v0, v1, v2);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glProgramUniform3dv(uint program, int location, int count, double* value)
		{
			internalGL.glProgramUniform3dv(program, location, count, value);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static void glProgramUniform3f(uint program, int location, float v0, float v1, float v2)
		{
			internalGL.glProgramUniform3f(program, location, v0, v1, v2);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glProgramUniform3fv(uint program, int location, int count, float* value)
		{
			internalGL.glProgramUniform3fv(program, location, count, value);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static void glProgramUniform3i(uint program, int location, int v0, int v1, int v2)
		{
			internalGL.glProgramUniform3i(program, location, v0, v1, v2);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glProgramUniform3iv(uint program, int location, int count, int* value)
		{
			internalGL.glProgramUniform3iv(program, location, count, value);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static void glProgramUniform3ui(uint program, int location, uint v0, uint v1, uint v2)
		{
			internalGL.glProgramUniform3ui(program, location, v0, v1, v2);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glProgramUniform3uiv(uint program, int location, int count, uint* value)
		{
			internalGL.glProgramUniform3uiv(program, location, count, value);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static void glProgramUniform4d(uint program, int location, double v0, double v1, double v2, double v3)
		{
			internalGL.glProgramUniform4d(program, location, v0, v1, v2, v3);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glProgramUniform4dv(uint program, int location, int count, double* value)
		{
			internalGL.glProgramUniform4dv(program, location, count, value);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static void glProgramUniform4f(uint program, int location, float v0, float v1, float v2, float v3)
		{
			internalGL.glProgramUniform4f(program, location, v0, v1, v2, v3);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glProgramUniform4fv(uint program, int location, int count, float* value)
		{
			internalGL.glProgramUniform4fv(program, location, count, value);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static void glProgramUniform4i(uint program, int location, int v0, int v1, int v2, int v3)
		{
			internalGL.glProgramUniform4i(program, location, v0, v1, v2, v3);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glProgramUniform4iv(uint program, int location, int count, int* value)
		{
			internalGL.glProgramUniform4iv(program, location, count, value);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static void glProgramUniform4ui(uint program, int location, uint v0, uint v1, uint v2, uint v3)
		{
			internalGL.glProgramUniform4ui(program, location, v0, v1, v2, v3);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glProgramUniform4uiv(uint program, int location, int count, uint* value)
		{
			internalGL.glProgramUniform4uiv(program, location, count, value);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glProgramUniformMatrix2dv(uint program, int location, int count, Boolean transpose, double* value)
		{
			internalGL.glProgramUniformMatrix2dv(program, location, count, transpose, value);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glProgramUniformMatrix2fv(uint program, int location, int count, Boolean transpose, float* value)
		{
			internalGL.glProgramUniformMatrix2fv(program, location, count, transpose, value);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glProgramUniformMatrix2x3dv(uint program, int location, int count, Boolean transpose, double* value)
		{
			internalGL.glProgramUniformMatrix2x3dv(program, location, count, transpose, value);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glProgramUniformMatrix2x3fv(uint program, int location, int count, Boolean transpose, float* value)
		{
			internalGL.glProgramUniformMatrix2x3fv(program, location, count, transpose, value);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glProgramUniformMatrix2x4dv(uint program, int location, int count, Boolean transpose, double* value)
		{
			internalGL.glProgramUniformMatrix2x4dv(program, location, count, transpose, value);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glProgramUniformMatrix2x4fv(uint program, int location, int count, Boolean transpose, float* value)
		{
			internalGL.glProgramUniformMatrix2x4fv(program, location, count, transpose, value);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glProgramUniformMatrix3dv(uint program, int location, int count, Boolean transpose, double* value)
		{
			internalGL.glProgramUniformMatrix3dv(program, location, count, transpose, value);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glProgramUniformMatrix3fv(uint program, int location, int count, Boolean transpose, float* value)
		{
			internalGL.glProgramUniformMatrix3fv(program, location, count, transpose, value);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glProgramUniformMatrix3x2dv(uint program, int location, int count, Boolean transpose, double* value)
		{
			internalGL.glProgramUniformMatrix3x2dv(program, location, count, transpose, value);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glProgramUniformMatrix3x2fv(uint program, int location, int count, Boolean transpose, float* value)
		{
			internalGL.glProgramUniformMatrix3x2fv(program, location, count, transpose, value);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glProgramUniformMatrix3x4dv(uint program, int location, int count, Boolean transpose, double* value)
		{
			internalGL.glProgramUniformMatrix3x4dv(program, location, count, transpose, value);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glProgramUniformMatrix3x4fv(uint program, int location, int count, Boolean transpose, float* value)
		{
			internalGL.glProgramUniformMatrix3x4fv(program, location, count, transpose, value);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glProgramUniformMatrix4dv(uint program, int location, int count, Boolean transpose, double* value)
		{
			internalGL.glProgramUniformMatrix4dv(program, location, count, transpose, value);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glProgramUniformMatrix4fv(uint program, int location, int count, Boolean transpose, float* value)
		{
			internalGL.glProgramUniformMatrix4fv(program, location, count, transpose, value);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glProgramUniformMatrix4x2dv(uint program, int location, int count, Boolean transpose, double* value)
		{
			internalGL.glProgramUniformMatrix4x2dv(program, location, count, transpose, value);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glProgramUniformMatrix4x2fv(uint program, int location, int count, Boolean transpose, float* value)
		{
			internalGL.glProgramUniformMatrix4x2fv(program, location, count, transpose, value);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glProgramUniformMatrix4x3dv(uint program, int location, int count, Boolean transpose, double* value)
		{
			internalGL.glProgramUniformMatrix4x3dv(program, location, count, transpose, value);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glProgramUniformMatrix4x3fv(uint program, int location, int count, Boolean transpose, float* value)
		{
			internalGL.glProgramUniformMatrix4x3fv(program, location, count, transpose, value);
		}

		///<sumary> Available from OpenGL version 3.2</sumary>
		public static void glProvokingVertex(VertexProvokingMode mode)
		{
			internalGL.glProvokingVertex(mode);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glPushAttrib(AttribMask mask)
		{
			internalGL.glPushAttrib(mask);
		}

		///<sumary> Available from OpenGL version 1.1 | Deprecated in OpenGL version 3.2</sumary>
		public static void glPushClientAttrib(ClientAttribMask mask)
		{
			internalGL.glPushClientAttrib(mask);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static unsafe void glPushDebugGroup(DebugSource source, uint id, int length, [MarshalAs(UnmanagedType.LPStr)] string message)
		{
			internalGL.glPushDebugGroup(source, id, length, message);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glPushMatrix()
		{
			internalGL.glPushMatrix();
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glPushName(uint name)
		{
			internalGL.glPushName(name);
		}

		#endregion

		#region Q:

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static void glQueryCounter(uint id, QueryCounterTarget target)
		{
			internalGL.glQueryCounter(id, target);
		}

		#endregion

		#region R:

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glRasterPos2d(double x, double y)
		{
			internalGL.glRasterPos2d(x, y);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glRasterPos2dv(double* v)
		{
			internalGL.glRasterPos2dv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glRasterPos2f(float x, float y)
		{
			internalGL.glRasterPos2f(x, y);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glRasterPos2fv(float* v)
		{
			internalGL.glRasterPos2fv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glRasterPos2i(int x, int y)
		{
			internalGL.glRasterPos2i(x, y);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glRasterPos2iv(int* v)
		{
			internalGL.glRasterPos2iv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glRasterPos2s(short x, short y)
		{
			internalGL.glRasterPos2s(x, y);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glRasterPos2sv(short* v)
		{
			internalGL.glRasterPos2sv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glRasterPos3d(double x, double y, double z)
		{
			internalGL.glRasterPos3d(x, y, z);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glRasterPos3dv(double* v)
		{
			internalGL.glRasterPos3dv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glRasterPos3f(float x, float y, float z)
		{
			internalGL.glRasterPos3f(x, y, z);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glRasterPos3fv(float* v)
		{
			internalGL.glRasterPos3fv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glRasterPos3i(int x, int y, int z)
		{
			internalGL.glRasterPos3i(x, y, z);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glRasterPos3iv(int* v)
		{
			internalGL.glRasterPos3iv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glRasterPos3s(short x, short y, short z)
		{
			internalGL.glRasterPos3s(x, y, z);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glRasterPos3sv(short* v)
		{
			internalGL.glRasterPos3sv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glRasterPos4d(double x, double y, double z, double w)
		{
			internalGL.glRasterPos4d(x, y, z, w);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glRasterPos4dv(double* v)
		{
			internalGL.glRasterPos4dv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glRasterPos4f(float x, float y, float z, float w)
		{
			internalGL.glRasterPos4f(x, y, z, w);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glRasterPos4fv(float* v)
		{
			internalGL.glRasterPos4fv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glRasterPos4i(int x, int y, int z, int w)
		{
			internalGL.glRasterPos4i(x, y, z, w);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glRasterPos4iv(int* v)
		{
			internalGL.glRasterPos4iv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glRasterPos4s(short x, short y, short z, short w)
		{
			internalGL.glRasterPos4s(x, y, z, w);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glRasterPos4sv(short* v)
		{
			internalGL.glRasterPos4sv(v);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static void glReadBuffer(ReadBufferMode src)
		{
			internalGL.glReadBuffer(src);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glReadnPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, IntPtr data)
		{
			internalGL.glReadnPixels(x, y, width, height, format, type, bufSize, data);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static void glReadPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, IntPtr pixels)
		{
			internalGL.glReadPixels(x, y, width, height, format, type, pixels);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glRectd(double x1, double y1, double x2, double y2)
		{
			internalGL.glRectd(x1, y1, x2, y2);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glRectdv(double* v1, double* v2)
		{
			internalGL.glRectdv(v1, v2);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glRectf(float x1, float y1, float x2, float y2)
		{
			internalGL.glRectf(x1, y1, x2, y2);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glRectfv(float* v1, float* v2)
		{
			internalGL.glRectfv(v1, v2);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glRecti(int x1, int y1, int x2, int y2)
		{
			internalGL.glRecti(x1, y1, x2, y2);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glRectiv(int* v1, int* v2)
		{
			internalGL.glRectiv(v1, v2);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glRects(short x1, short y1, short x2, short y2)
		{
			internalGL.glRects(x1, y1, x2, y2);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glRectsv(short* v1, short* v2)
		{
			internalGL.glRectsv(v1, v2);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static void glReleaseShaderCompiler()
		{
			internalGL.glReleaseShaderCompiler();
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static void glRenderbufferStorage(RenderbufferTarget target, InternalFormat internalformat, int width, int height)
		{
			internalGL.glRenderbufferStorage(target, internalformat, width, height);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static void glRenderbufferStorageMultisample(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height)
		{
			internalGL.glRenderbufferStorageMultisample(target, samples, internalformat, width, height);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static int glRenderMode(RenderingMode mode)
		{
			return internalGL.glRenderMode(mode);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static void glResumeTransformFeedback()
		{
			internalGL.glResumeTransformFeedback();
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glRotated(double angle, double x, double y, double z)
		{
			internalGL.glRotated(angle, x, y, z);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glRotatef(float angle, float x, float y, float z)
		{
			internalGL.glRotatef(angle, x, y, z);
		}

		#endregion

		#region S:

		///<sumary> Available from OpenGL version 1.3</sumary>
		public static void glSampleCoverage(float value, Boolean invert)
		{
			internalGL.glSampleCoverage(value, invert);
		}

		///<sumary> Available from OpenGL version 3.2</sumary>
		public static void glSampleMaski(uint maskNumber, uint mask)
		{
			internalGL.glSampleMaski(maskNumber, mask);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static void glSamplerParameterf(uint sampler, SamplerParameterF pname, float param)
		{
			internalGL.glSamplerParameterf(sampler, pname, param);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static unsafe void glSamplerParameterfv(uint sampler, SamplerParameterF pname, float* param)
		{
			internalGL.glSamplerParameterfv(sampler, pname, param);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static void glSamplerParameteri(uint sampler, SamplerParameterI pname, int param)
		{
			internalGL.glSamplerParameteri(sampler, pname, param);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static unsafe void glSamplerParameterIiv(uint sampler, SamplerParameterI pname, int* param)
		{
			internalGL.glSamplerParameterIiv(sampler, pname, param);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static unsafe void glSamplerParameterIuiv(uint sampler, SamplerParameterI pname, uint* param)
		{
			internalGL.glSamplerParameterIuiv(sampler, pname, param);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static unsafe void glSamplerParameteriv(uint sampler, SamplerParameterI pname, int* param)
		{
			internalGL.glSamplerParameteriv(sampler, pname, param);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glScaled(double x, double y, double z)
		{
			internalGL.glScaled(x, y, z);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glScalef(float x, float y, float z)
		{
			internalGL.glScalef(x, y, z);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static void glScissor(int x, int y, int width, int height)
		{
			internalGL.glScissor(x, y, width, height);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glScissorArrayv(uint first, int count, int* v)
		{
			internalGL.glScissorArrayv(first, count, v);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static void glScissorIndexed(uint index, int left, int bottom, int width, int height)
		{
			internalGL.glScissorIndexed(index, left, bottom, width, height);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glScissorIndexedv(uint index, int* v)
		{
			internalGL.glScissorIndexedv(index, v);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static void glSecondaryColor3b(sbyte red, sbyte green, sbyte blue)
		{
			internalGL.glSecondaryColor3b(red, green, blue);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glSecondaryColor3bv(sbyte* v)
		{
			internalGL.glSecondaryColor3bv(v);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static void glSecondaryColor3d(double red, double green, double blue)
		{
			internalGL.glSecondaryColor3d(red, green, blue);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glSecondaryColor3dv(double* v)
		{
			internalGL.glSecondaryColor3dv(v);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static void glSecondaryColor3f(float red, float green, float blue)
		{
			internalGL.glSecondaryColor3f(red, green, blue);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glSecondaryColor3fv(float* v)
		{
			internalGL.glSecondaryColor3fv(v);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static void glSecondaryColor3i(int red, int green, int blue)
		{
			internalGL.glSecondaryColor3i(red, green, blue);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glSecondaryColor3iv(int* v)
		{
			internalGL.glSecondaryColor3iv(v);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static void glSecondaryColor3s(short red, short green, short blue)
		{
			internalGL.glSecondaryColor3s(red, green, blue);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glSecondaryColor3sv(short* v)
		{
			internalGL.glSecondaryColor3sv(v);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static void glSecondaryColor3ub(byte red, byte green, byte blue)
		{
			internalGL.glSecondaryColor3ub(red, green, blue);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glSecondaryColor3ubv(byte* v)
		{
			internalGL.glSecondaryColor3ubv(v);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static void glSecondaryColor3ui(uint red, uint green, uint blue)
		{
			internalGL.glSecondaryColor3ui(red, green, blue);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glSecondaryColor3uiv(uint* v)
		{
			internalGL.glSecondaryColor3uiv(v);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static void glSecondaryColor3us(ushort red, ushort green, ushort blue)
		{
			internalGL.glSecondaryColor3us(red, green, blue);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glSecondaryColor3usv(ushort* v)
		{
			internalGL.glSecondaryColor3usv(v);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static void glSecondaryColorP3ui(ColorPointerType type, uint color)
		{
			internalGL.glSecondaryColorP3ui(type, color);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static unsafe void glSecondaryColorP3uiv(ColorPointerType type, uint* color)
		{
			internalGL.glSecondaryColorP3uiv(type, color);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static void glSecondaryColorPointer(int size, ColorPointerType type, int stride, IntPtr pointer)
		{
			internalGL.glSecondaryColorPointer(size, type, stride, pointer);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glSelectBuffer(int size, uint* buffer)
		{
			internalGL.glSelectBuffer(size, buffer);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glShadeModel(ShadingModel mode)
		{
			internalGL.glShadeModel(mode);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glShaderBinary(int count, uint* shaders, ShaderBinaryFormat binaryFormat, IntPtr binary, int length)
		{
			internalGL.glShaderBinary(count, shaders, binaryFormat, binary, length);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glShaderSource(uint shader, int count, [MarshalAs(UnmanagedType.LPStr)] string[] @string, int* length)
		{
			internalGL.glShaderSource(shader, count, @string, length);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static void glShaderStorageBlockBinding(uint program, uint storageBlockIndex, uint storageBlockBinding)
		{
			internalGL.glShaderStorageBlockBinding(program, storageBlockIndex, storageBlockBinding);
		}

		///<sumary> Available from OpenGL version 4.6</sumary>
		public static unsafe void glSpecializeShader(uint shader, [MarshalAs(UnmanagedType.LPStr)] string pEntryPoint, uint numSpecializationConstants, uint* pConstantIndex, uint* pConstantValue)
		{
			internalGL.glSpecializeShader(shader, pEntryPoint, numSpecializationConstants, pConstantIndex, pConstantValue);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static void glStencilFunc(StencilFunction func, int @ref, uint mask)
		{
			internalGL.glStencilFunc(func, @ref, mask);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static void glStencilFuncSeparate(StencilFaceDirection face, StencilFunction func, int @ref, uint mask)
		{
			internalGL.glStencilFuncSeparate(face, func, @ref, mask);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static void glStencilMask(uint mask)
		{
			internalGL.glStencilMask(mask);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static void glStencilMaskSeparate(StencilFaceDirection face, uint mask)
		{
			internalGL.glStencilMaskSeparate(face, mask);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static void glStencilOp(StencilOp fail, StencilOp zfail, StencilOp zpass)
		{
			internalGL.glStencilOp(fail, zfail, zpass);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static void glStencilOpSeparate(StencilFaceDirection face, StencilOp sfail, StencilOp dpfail, StencilOp dppass)
		{
			internalGL.glStencilOpSeparate(face, sfail, dpfail, dppass);
		}

		#endregion

		#region T:

		///<sumary> Available from OpenGL version 3.1</sumary>
		public static void glTexBuffer(TextureTarget target, InternalFormat internalformat, uint buffer)
		{
			internalGL.glTexBuffer(target, internalformat, buffer);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static void glTexBufferRange(TextureTarget target, InternalFormat internalformat, uint buffer, IntPtr offset, int size)
		{
			internalGL.glTexBufferRange(target, internalformat, buffer, offset, size);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glTexCoord1d(double s)
		{
			internalGL.glTexCoord1d(s);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glTexCoord1dv(double* v)
		{
			internalGL.glTexCoord1dv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glTexCoord1f(float s)
		{
			internalGL.glTexCoord1f(s);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glTexCoord1fv(float* v)
		{
			internalGL.glTexCoord1fv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glTexCoord1i(int s)
		{
			internalGL.glTexCoord1i(s);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glTexCoord1iv(int* v)
		{
			internalGL.glTexCoord1iv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glTexCoord1s(short s)
		{
			internalGL.glTexCoord1s(s);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glTexCoord1sv(short* v)
		{
			internalGL.glTexCoord1sv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glTexCoord2d(double s, double t)
		{
			internalGL.glTexCoord2d(s, t);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glTexCoord2dv(double* v)
		{
			internalGL.glTexCoord2dv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glTexCoord2f(float s, float t)
		{
			internalGL.glTexCoord2f(s, t);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glTexCoord2fv(float* v)
		{
			internalGL.glTexCoord2fv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glTexCoord2i(int s, int t)
		{
			internalGL.glTexCoord2i(s, t);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glTexCoord2iv(int* v)
		{
			internalGL.glTexCoord2iv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glTexCoord2s(short s, short t)
		{
			internalGL.glTexCoord2s(s, t);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glTexCoord2sv(short* v)
		{
			internalGL.glTexCoord2sv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glTexCoord3d(double s, double t, double r)
		{
			internalGL.glTexCoord3d(s, t, r);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glTexCoord3dv(double* v)
		{
			internalGL.glTexCoord3dv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glTexCoord3f(float s, float t, float r)
		{
			internalGL.glTexCoord3f(s, t, r);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glTexCoord3fv(float* v)
		{
			internalGL.glTexCoord3fv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glTexCoord3i(int s, int t, int r)
		{
			internalGL.glTexCoord3i(s, t, r);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glTexCoord3iv(int* v)
		{
			internalGL.glTexCoord3iv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glTexCoord3s(short s, short t, short r)
		{
			internalGL.glTexCoord3s(s, t, r);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glTexCoord3sv(short* v)
		{
			internalGL.glTexCoord3sv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glTexCoord4d(double s, double t, double r, double q)
		{
			internalGL.glTexCoord4d(s, t, r, q);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glTexCoord4dv(double* v)
		{
			internalGL.glTexCoord4dv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glTexCoord4f(float s, float t, float r, float q)
		{
			internalGL.glTexCoord4f(s, t, r, q);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glTexCoord4fv(float* v)
		{
			internalGL.glTexCoord4fv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glTexCoord4i(int s, int t, int r, int q)
		{
			internalGL.glTexCoord4i(s, t, r, q);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glTexCoord4iv(int* v)
		{
			internalGL.glTexCoord4iv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glTexCoord4s(short s, short t, short r, short q)
		{
			internalGL.glTexCoord4s(s, t, r, q);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glTexCoord4sv(short* v)
		{
			internalGL.glTexCoord4sv(v);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static void glTexCoordP1ui(TexCoordPointerType type, uint coords)
		{
			internalGL.glTexCoordP1ui(type, coords);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static unsafe void glTexCoordP1uiv(TexCoordPointerType type, uint* coords)
		{
			internalGL.glTexCoordP1uiv(type, coords);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static void glTexCoordP2ui(TexCoordPointerType type, uint coords)
		{
			internalGL.glTexCoordP2ui(type, coords);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static unsafe void glTexCoordP2uiv(TexCoordPointerType type, uint* coords)
		{
			internalGL.glTexCoordP2uiv(type, coords);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static void glTexCoordP3ui(TexCoordPointerType type, uint coords)
		{
			internalGL.glTexCoordP3ui(type, coords);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static unsafe void glTexCoordP3uiv(TexCoordPointerType type, uint* coords)
		{
			internalGL.glTexCoordP3uiv(type, coords);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static void glTexCoordP4ui(TexCoordPointerType type, uint coords)
		{
			internalGL.glTexCoordP4ui(type, coords);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static unsafe void glTexCoordP4uiv(TexCoordPointerType type, uint* coords)
		{
			internalGL.glTexCoordP4uiv(type, coords);
		}

		///<sumary> Available from OpenGL version 1.1 | Deprecated in OpenGL version 3.2</sumary>
		public static void glTexCoordPointer(int size, TexCoordPointerType type, int stride, IntPtr pointer)
		{
			internalGL.glTexCoordPointer(size, type, stride, pointer);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glTexEnvf(TextureEnvTarget target, TextureEnvParameter pname, float param)
		{
			internalGL.glTexEnvf(target, pname, param);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glTexEnvfv(TextureEnvTarget target, TextureEnvParameter pname, float* @params)
		{
			internalGL.glTexEnvfv(target, pname, @params);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glTexEnvi(TextureEnvTarget target, TextureEnvParameter pname, int param)
		{
			internalGL.glTexEnvi(target, pname, param);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glTexEnviv(TextureEnvTarget target, TextureEnvParameter pname, int* @params)
		{
			internalGL.glTexEnviv(target, pname, @params);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glTexGend(TextureCoordName coord, TextureGenParameter pname, double param)
		{
			internalGL.glTexGend(coord, pname, param);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glTexGendv(TextureCoordName coord, TextureGenParameter pname, double* @params)
		{
			internalGL.glTexGendv(coord, pname, @params);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glTexGenf(TextureCoordName coord, TextureGenParameter pname, float param)
		{
			internalGL.glTexGenf(coord, pname, param);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glTexGenfv(TextureCoordName coord, TextureGenParameter pname, float* @params)
		{
			internalGL.glTexGenfv(coord, pname, @params);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glTexGeni(TextureCoordName coord, TextureGenParameter pname, int param)
		{
			internalGL.glTexGeni(coord, pname, param);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glTexGeniv(TextureCoordName coord, TextureGenParameter pname, int* @params)
		{
			internalGL.glTexGeniv(coord, pname, @params);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static void glTexImage1D(TextureTarget target, int level, InternalFormat internalformat, int width, int border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			internalGL.glTexImage1D(target, level, internalformat, width, border, format, type, pixels);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static void glTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			internalGL.glTexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
		}

		///<sumary> Available from OpenGL version 3.2</sumary>
		public static void glTexImage2DMultisample(TextureTarget target, int samples, InternalFormat internalformat, int width, int height, Boolean fixedsamplelocations)
		{
			internalGL.glTexImage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);
		}

		///<sumary> Available from OpenGL version 1.2</sumary>
		public static void glTexImage3D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			internalGL.glTexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels);
		}

		///<sumary> Available from OpenGL version 3.2</sumary>
		public static void glTexImage3DMultisample(TextureTarget target, int samples, InternalFormat internalformat, int width, int height, int depth, Boolean fixedsamplelocations)
		{
			internalGL.glTexImage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static void glTexParameterf(TextureTarget target, TextureParameterName pname, float param)
		{
			internalGL.glTexParameterf(target, pname, param);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static unsafe void glTexParameterfv(TextureTarget target, TextureParameterName pname, float* @params)
		{
			internalGL.glTexParameterfv(target, pname, @params);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static void glTexParameteri(TextureTarget target, TextureParameterName pname, int param)
		{
			internalGL.glTexParameteri(target, pname, param);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glTexParameterIiv(TextureTarget target, TextureParameterName pname, int* @params)
		{
			internalGL.glTexParameterIiv(target, pname, @params);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glTexParameterIuiv(TextureTarget target, TextureParameterName pname, uint* @params)
		{
			internalGL.glTexParameterIuiv(target, pname, @params);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static unsafe void glTexParameteriv(TextureTarget target, TextureParameterName pname, int* @params)
		{
			internalGL.glTexParameteriv(target, pname, @params);
		}

		///<sumary> Available from OpenGL version 4.2</sumary>
		public static void glTexStorage1D(TextureTarget target, int levels, InternalFormat internalformat, int width)
		{
			internalGL.glTexStorage1D(target, levels, internalformat, width);
		}

		///<sumary> Available from OpenGL version 4.2</sumary>
		public static void glTexStorage2D(TextureTarget target, int levels, InternalFormat internalformat, int width, int height)
		{
			internalGL.glTexStorage2D(target, levels, internalformat, width, height);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static void glTexStorage2DMultisample(TextureTarget target, int samples, InternalFormat internalformat, int width, int height, Boolean fixedsamplelocations)
		{
			internalGL.glTexStorage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);
		}

		///<sumary> Available from OpenGL version 4.2</sumary>
		public static void glTexStorage3D(TextureTarget target, int levels, InternalFormat internalformat, int width, int height, int depth)
		{
			internalGL.glTexStorage3D(target, levels, internalformat, width, height, depth);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static void glTexStorage3DMultisample(TextureTarget target, int samples, InternalFormat internalformat, int width, int height, int depth, Boolean fixedsamplelocations)
		{
			internalGL.glTexStorage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);
		}

		///<sumary> Available from OpenGL version 1.1</sumary>
		public static void glTexSubImage1D(TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, IntPtr pixels)
		{
			internalGL.glTexSubImage1D(target, level, xoffset, width, format, type, pixels);
		}

		///<sumary> Available from OpenGL version 1.1</sumary>
		public static void glTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, IntPtr pixels)
		{
			internalGL.glTexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
		}

		///<sumary> Available from OpenGL version 1.2</sumary>
		public static void glTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels)
		{
			internalGL.glTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glTextureBarrier()
		{
			internalGL.glTextureBarrier();
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glTextureBuffer(uint texture, InternalFormat internalformat, uint buffer)
		{
			internalGL.glTextureBuffer(texture, internalformat, buffer);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glTextureBufferRange(uint texture, InternalFormat internalformat, uint buffer, IntPtr offset, int size)
		{
			internalGL.glTextureBufferRange(texture, internalformat, buffer, offset, size);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glTextureParameterf(uint texture, TextureParameterName pname, float param)
		{
			internalGL.glTextureParameterf(texture, pname, param);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glTextureParameterfv(uint texture, TextureParameterName pname, float* param)
		{
			internalGL.glTextureParameterfv(texture, pname, param);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glTextureParameteri(uint texture, TextureParameterName pname, int param)
		{
			internalGL.glTextureParameteri(texture, pname, param);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glTextureParameterIiv(uint texture, TextureParameterName pname, int* @params)
		{
			internalGL.glTextureParameterIiv(texture, pname, @params);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glTextureParameterIuiv(uint texture, TextureParameterName pname, uint* @params)
		{
			internalGL.glTextureParameterIuiv(texture, pname, @params);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glTextureParameteriv(uint texture, TextureParameterName pname, int* param)
		{
			internalGL.glTextureParameteriv(texture, pname, param);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glTextureStorage1D(uint texture, int levels, InternalFormat internalformat, int width)
		{
			internalGL.glTextureStorage1D(texture, levels, internalformat, width);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glTextureStorage2D(uint texture, int levels, InternalFormat internalformat, int width, int height)
		{
			internalGL.glTextureStorage2D(texture, levels, internalformat, width, height);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glTextureStorage2DMultisample(uint texture, int samples, InternalFormat internalformat, int width, int height, Boolean fixedsamplelocations)
		{
			internalGL.glTextureStorage2DMultisample(texture, samples, internalformat, width, height, fixedsamplelocations);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glTextureStorage3D(uint texture, int levels, InternalFormat internalformat, int width, int height, int depth)
		{
			internalGL.glTextureStorage3D(texture, levels, internalformat, width, height, depth);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glTextureStorage3DMultisample(uint texture, int samples, InternalFormat internalformat, int width, int height, int depth, Boolean fixedsamplelocations)
		{
			internalGL.glTextureStorage3DMultisample(texture, samples, internalformat, width, height, depth, fixedsamplelocations);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glTextureSubImage1D(uint texture, int level, int xoffset, int width, PixelFormat format, PixelType type, IntPtr pixels)
		{
			internalGL.glTextureSubImage1D(texture, level, xoffset, width, format, type, pixels);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, IntPtr pixels)
		{
			internalGL.glTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, pixels);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels)
		{
			internalGL.glTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static void glTextureView(uint texture, TextureTarget target, uint origtexture, InternalFormat internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers)
		{
			internalGL.glTextureView(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glTransformFeedbackBufferBase(uint xfb, uint index, uint buffer)
		{
			internalGL.glTransformFeedbackBufferBase(xfb, index, buffer);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glTransformFeedbackBufferRange(uint xfb, uint index, uint buffer, IntPtr offset, int size)
		{
			internalGL.glTransformFeedbackBufferRange(xfb, index, buffer, offset, size);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glTransformFeedbackVaryings(uint program, int count, [MarshalAs(UnmanagedType.LPStr)] string[] varyings, TransformFeedbackBufferMode bufferMode)
		{
			internalGL.glTransformFeedbackVaryings(program, count, varyings, bufferMode);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glTranslated(double x, double y, double z)
		{
			internalGL.glTranslated(x, y, z);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glTranslatef(float x, float y, float z)
		{
			internalGL.glTranslatef(x, y, z);
		}

		#endregion

		#region U:

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static void glUniform1d(int location, double x)
		{
			internalGL.glUniform1d(location, x);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static unsafe void glUniform1dv(int location, int count, double* value)
		{
			internalGL.glUniform1dv(location, count, value);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static void glUniform1f(int location, float v0)
		{
			internalGL.glUniform1f(location, v0);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glUniform1fv(int location, int count, float* value)
		{
			internalGL.glUniform1fv(location, count, value);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static void glUniform1i(int location, int v0)
		{
			internalGL.glUniform1i(location, v0);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glUniform1iv(int location, int count, int* value)
		{
			internalGL.glUniform1iv(location, count, value);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static void glUniform1ui(int location, uint v0)
		{
			internalGL.glUniform1ui(location, v0);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glUniform1uiv(int location, int count, uint* value)
		{
			internalGL.glUniform1uiv(location, count, value);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static void glUniform2d(int location, double x, double y)
		{
			internalGL.glUniform2d(location, x, y);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static unsafe void glUniform2dv(int location, int count, double* value)
		{
			internalGL.glUniform2dv(location, count, value);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static void glUniform2f(int location, float v0, float v1)
		{
			internalGL.glUniform2f(location, v0, v1);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glUniform2fv(int location, int count, float* value)
		{
			internalGL.glUniform2fv(location, count, value);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static void glUniform2i(int location, int v0, int v1)
		{
			internalGL.glUniform2i(location, v0, v1);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glUniform2iv(int location, int count, int* value)
		{
			internalGL.glUniform2iv(location, count, value);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static void glUniform2ui(int location, uint v0, uint v1)
		{
			internalGL.glUniform2ui(location, v0, v1);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glUniform2uiv(int location, int count, uint* value)
		{
			internalGL.glUniform2uiv(location, count, value);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static void glUniform3d(int location, double x, double y, double z)
		{
			internalGL.glUniform3d(location, x, y, z);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static unsafe void glUniform3dv(int location, int count, double* value)
		{
			internalGL.glUniform3dv(location, count, value);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static void glUniform3f(int location, float v0, float v1, float v2)
		{
			internalGL.glUniform3f(location, v0, v1, v2);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glUniform3fv(int location, int count, float* value)
		{
			internalGL.glUniform3fv(location, count, value);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static void glUniform3i(int location, int v0, int v1, int v2)
		{
			internalGL.glUniform3i(location, v0, v1, v2);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glUniform3iv(int location, int count, int* value)
		{
			internalGL.glUniform3iv(location, count, value);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static void glUniform3ui(int location, uint v0, uint v1, uint v2)
		{
			internalGL.glUniform3ui(location, v0, v1, v2);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glUniform3uiv(int location, int count, uint* value)
		{
			internalGL.glUniform3uiv(location, count, value);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static void glUniform4d(int location, double x, double y, double z, double w)
		{
			internalGL.glUniform4d(location, x, y, z, w);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static unsafe void glUniform4dv(int location, int count, double* value)
		{
			internalGL.glUniform4dv(location, count, value);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static void glUniform4f(int location, float v0, float v1, float v2, float v3)
		{
			internalGL.glUniform4f(location, v0, v1, v2, v3);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glUniform4fv(int location, int count, float* value)
		{
			internalGL.glUniform4fv(location, count, value);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static void glUniform4i(int location, int v0, int v1, int v2, int v3)
		{
			internalGL.glUniform4i(location, v0, v1, v2, v3);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glUniform4iv(int location, int count, int* value)
		{
			internalGL.glUniform4iv(location, count, value);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static void glUniform4ui(int location, uint v0, uint v1, uint v2, uint v3)
		{
			internalGL.glUniform4ui(location, v0, v1, v2, v3);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glUniform4uiv(int location, int count, uint* value)
		{
			internalGL.glUniform4uiv(location, count, value);
		}

		///<sumary> Available from OpenGL version 3.1</sumary>
		public static void glUniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding)
		{
			internalGL.glUniformBlockBinding(program, uniformBlockIndex, uniformBlockBinding);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static unsafe void glUniformMatrix2dv(int location, int count, Boolean transpose, double* value)
		{
			internalGL.glUniformMatrix2dv(location, count, transpose, value);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glUniformMatrix2fv(int location, int count, Boolean transpose, float* value)
		{
			internalGL.glUniformMatrix2fv(location, count, transpose, value);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static unsafe void glUniformMatrix2x3dv(int location, int count, Boolean transpose, double* value)
		{
			internalGL.glUniformMatrix2x3dv(location, count, transpose, value);
		}

		///<sumary> Available from OpenGL version 2.1</sumary>
		public static unsafe void glUniformMatrix2x3fv(int location, int count, Boolean transpose, float* value)
		{
			internalGL.glUniformMatrix2x3fv(location, count, transpose, value);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static unsafe void glUniformMatrix2x4dv(int location, int count, Boolean transpose, double* value)
		{
			internalGL.glUniformMatrix2x4dv(location, count, transpose, value);
		}

		///<sumary> Available from OpenGL version 2.1</sumary>
		public static unsafe void glUniformMatrix2x4fv(int location, int count, Boolean transpose, float* value)
		{
			internalGL.glUniformMatrix2x4fv(location, count, transpose, value);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static unsafe void glUniformMatrix3dv(int location, int count, Boolean transpose, double* value)
		{
			internalGL.glUniformMatrix3dv(location, count, transpose, value);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glUniformMatrix3fv(int location, int count, Boolean transpose, float* value)
		{
			internalGL.glUniformMatrix3fv(location, count, transpose, value);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static unsafe void glUniformMatrix3x2dv(int location, int count, Boolean transpose, double* value)
		{
			internalGL.glUniformMatrix3x2dv(location, count, transpose, value);
		}

		///<sumary> Available from OpenGL version 2.1</sumary>
		public static unsafe void glUniformMatrix3x2fv(int location, int count, Boolean transpose, float* value)
		{
			internalGL.glUniformMatrix3x2fv(location, count, transpose, value);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static unsafe void glUniformMatrix3x4dv(int location, int count, Boolean transpose, double* value)
		{
			internalGL.glUniformMatrix3x4dv(location, count, transpose, value);
		}

		///<sumary> Available from OpenGL version 2.1</sumary>
		public static unsafe void glUniformMatrix3x4fv(int location, int count, Boolean transpose, float* value)
		{
			internalGL.glUniformMatrix3x4fv(location, count, transpose, value);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static unsafe void glUniformMatrix4dv(int location, int count, Boolean transpose, double* value)
		{
			internalGL.glUniformMatrix4dv(location, count, transpose, value);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glUniformMatrix4fv(int location, int count, Boolean transpose, float* value)
		{
			internalGL.glUniformMatrix4fv(location, count, transpose, value);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static unsafe void glUniformMatrix4x2dv(int location, int count, Boolean transpose, double* value)
		{
			internalGL.glUniformMatrix4x2dv(location, count, transpose, value);
		}

		///<sumary> Available from OpenGL version 2.1</sumary>
		public static unsafe void glUniformMatrix4x2fv(int location, int count, Boolean transpose, float* value)
		{
			internalGL.glUniformMatrix4x2fv(location, count, transpose, value);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static unsafe void glUniformMatrix4x3dv(int location, int count, Boolean transpose, double* value)
		{
			internalGL.glUniformMatrix4x3dv(location, count, transpose, value);
		}

		///<sumary> Available from OpenGL version 2.1</sumary>
		public static unsafe void glUniformMatrix4x3fv(int location, int count, Boolean transpose, float* value)
		{
			internalGL.glUniformMatrix4x3fv(location, count, transpose, value);
		}

		///<sumary> Available from OpenGL version 4.0</sumary>
		public static unsafe void glUniformSubroutinesuiv(ShaderType shadertype, int count, uint* indices)
		{
			internalGL.glUniformSubroutinesuiv(shadertype, count, indices);
		}

		///<sumary> Available from OpenGL version 1.5</sumary>
		public static bool glUnmapBuffer(BufferTargetARB target)
		{
			return internalGL.glUnmapBuffer(target);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static bool glUnmapNamedBuffer(uint buffer)
		{
			return internalGL.glUnmapNamedBuffer(buffer);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static void glUseProgram(uint program)
		{
			internalGL.glUseProgram(program);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static void glUseProgramStages(uint pipeline, UseProgramStageMask stages, uint program)
		{
			internalGL.glUseProgramStages(pipeline, stages, program);
		}

		#endregion

		#region V:

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static void glValidateProgram(uint program)
		{
			internalGL.glValidateProgram(program);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static void glValidateProgramPipeline(uint pipeline)
		{
			internalGL.glValidateProgramPipeline(pipeline);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glVertex2d(double x, double y)
		{
			internalGL.glVertex2d(x, y);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glVertex2dv(double* v)
		{
			internalGL.glVertex2dv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glVertex2f(float x, float y)
		{
			internalGL.glVertex2f(x, y);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glVertex2fv(float* v)
		{
			internalGL.glVertex2fv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glVertex2i(int x, int y)
		{
			internalGL.glVertex2i(x, y);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glVertex2iv(int* v)
		{
			internalGL.glVertex2iv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glVertex2s(short x, short y)
		{
			internalGL.glVertex2s(x, y);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glVertex2sv(short* v)
		{
			internalGL.glVertex2sv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glVertex3d(double x, double y, double z)
		{
			internalGL.glVertex3d(x, y, z);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glVertex3dv(double* v)
		{
			internalGL.glVertex3dv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glVertex3f(float x, float y, float z)
		{
			internalGL.glVertex3f(x, y, z);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glVertex3fv(float* v)
		{
			internalGL.glVertex3fv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glVertex3i(int x, int y, int z)
		{
			internalGL.glVertex3i(x, y, z);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glVertex3iv(int* v)
		{
			internalGL.glVertex3iv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glVertex3s(short x, short y, short z)
		{
			internalGL.glVertex3s(x, y, z);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glVertex3sv(short* v)
		{
			internalGL.glVertex3sv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glVertex4d(double x, double y, double z, double w)
		{
			internalGL.glVertex4d(x, y, z, w);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glVertex4dv(double* v)
		{
			internalGL.glVertex4dv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glVertex4f(float x, float y, float z, float w)
		{
			internalGL.glVertex4f(x, y, z, w);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glVertex4fv(float* v)
		{
			internalGL.glVertex4fv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glVertex4i(int x, int y, int z, int w)
		{
			internalGL.glVertex4i(x, y, z, w);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glVertex4iv(int* v)
		{
			internalGL.glVertex4iv(v);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static void glVertex4s(short x, short y, short z, short w)
		{
			internalGL.glVertex4s(x, y, z, w);
		}

		///<sumary> Available from OpenGL version 1.0 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glVertex4sv(short* v)
		{
			internalGL.glVertex4sv(v);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glVertexArrayAttribBinding(uint vaobj, uint attribindex, uint bindingindex)
		{
			internalGL.glVertexArrayAttribBinding(vaobj, attribindex, bindingindex);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glVertexArrayAttribFormat(uint vaobj, uint attribindex, int size, VertexAttribType type, Boolean normalized, uint relativeoffset)
		{
			internalGL.glVertexArrayAttribFormat(vaobj, attribindex, size, type, normalized, relativeoffset);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glVertexArrayAttribIFormat(uint vaobj, uint attribindex, int size, VertexAttribIType type, uint relativeoffset)
		{
			internalGL.glVertexArrayAttribIFormat(vaobj, attribindex, size, type, relativeoffset);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glVertexArrayAttribLFormat(uint vaobj, uint attribindex, int size, VertexAttribLType type, uint relativeoffset)
		{
			internalGL.glVertexArrayAttribLFormat(vaobj, attribindex, size, type, relativeoffset);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glVertexArrayBindingDivisor(uint vaobj, uint bindingindex, uint divisor)
		{
			internalGL.glVertexArrayBindingDivisor(vaobj, bindingindex, divisor);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glVertexArrayElementBuffer(uint vaobj, uint buffer)
		{
			internalGL.glVertexArrayElementBuffer(vaobj, buffer);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static void glVertexArrayVertexBuffer(uint vaobj, uint bindingindex, uint buffer, IntPtr offset, int stride)
		{
			internalGL.glVertexArrayVertexBuffer(vaobj, bindingindex, buffer, offset, stride);
		}

		///<sumary> Available from OpenGL version 4.5</sumary>
		public static unsafe void glVertexArrayVertexBuffers(uint vaobj, uint first, int count, uint* buffers, IntPtr* offsets, int* strides)
		{
			internalGL.glVertexArrayVertexBuffers(vaobj, first, count, buffers, offsets, strides);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static void glVertexAttrib1d(uint index, double x)
		{
			internalGL.glVertexAttrib1d(index, x);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glVertexAttrib1dv(uint index, double* v)
		{
			internalGL.glVertexAttrib1dv(index, v);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static void glVertexAttrib1f(uint index, float x)
		{
			internalGL.glVertexAttrib1f(index, x);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glVertexAttrib1fv(uint index, float* v)
		{
			internalGL.glVertexAttrib1fv(index, v);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static void glVertexAttrib1s(uint index, short x)
		{
			internalGL.glVertexAttrib1s(index, x);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glVertexAttrib1sv(uint index, short* v)
		{
			internalGL.glVertexAttrib1sv(index, v);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static void glVertexAttrib2d(uint index, double x, double y)
		{
			internalGL.glVertexAttrib2d(index, x, y);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glVertexAttrib2dv(uint index, double* v)
		{
			internalGL.glVertexAttrib2dv(index, v);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static void glVertexAttrib2f(uint index, float x, float y)
		{
			internalGL.glVertexAttrib2f(index, x, y);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glVertexAttrib2fv(uint index, float* v)
		{
			internalGL.glVertexAttrib2fv(index, v);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static void glVertexAttrib2s(uint index, short x, short y)
		{
			internalGL.glVertexAttrib2s(index, x, y);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glVertexAttrib2sv(uint index, short* v)
		{
			internalGL.glVertexAttrib2sv(index, v);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static void glVertexAttrib3d(uint index, double x, double y, double z)
		{
			internalGL.glVertexAttrib3d(index, x, y, z);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glVertexAttrib3dv(uint index, double* v)
		{
			internalGL.glVertexAttrib3dv(index, v);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static void glVertexAttrib3f(uint index, float x, float y, float z)
		{
			internalGL.glVertexAttrib3f(index, x, y, z);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glVertexAttrib3fv(uint index, float* v)
		{
			internalGL.glVertexAttrib3fv(index, v);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static void glVertexAttrib3s(uint index, short x, short y, short z)
		{
			internalGL.glVertexAttrib3s(index, x, y, z);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glVertexAttrib3sv(uint index, short* v)
		{
			internalGL.glVertexAttrib3sv(index, v);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glVertexAttrib4bv(uint index, sbyte* v)
		{
			internalGL.glVertexAttrib4bv(index, v);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static void glVertexAttrib4d(uint index, double x, double y, double z, double w)
		{
			internalGL.glVertexAttrib4d(index, x, y, z, w);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glVertexAttrib4dv(uint index, double* v)
		{
			internalGL.glVertexAttrib4dv(index, v);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static void glVertexAttrib4f(uint index, float x, float y, float z, float w)
		{
			internalGL.glVertexAttrib4f(index, x, y, z, w);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glVertexAttrib4fv(uint index, float* v)
		{
			internalGL.glVertexAttrib4fv(index, v);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glVertexAttrib4iv(uint index, int* v)
		{
			internalGL.glVertexAttrib4iv(index, v);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glVertexAttrib4Nbv(uint index, sbyte* v)
		{
			internalGL.glVertexAttrib4Nbv(index, v);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glVertexAttrib4Niv(uint index, int* v)
		{
			internalGL.glVertexAttrib4Niv(index, v);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glVertexAttrib4Nsv(uint index, short* v)
		{
			internalGL.glVertexAttrib4Nsv(index, v);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static void glVertexAttrib4Nub(uint index, byte x, byte y, byte z, byte w)
		{
			internalGL.glVertexAttrib4Nub(index, x, y, z, w);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glVertexAttrib4Nubv(uint index, byte* v)
		{
			internalGL.glVertexAttrib4Nubv(index, v);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glVertexAttrib4Nuiv(uint index, uint* v)
		{
			internalGL.glVertexAttrib4Nuiv(index, v);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glVertexAttrib4Nusv(uint index, ushort* v)
		{
			internalGL.glVertexAttrib4Nusv(index, v);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static void glVertexAttrib4s(uint index, short x, short y, short z, short w)
		{
			internalGL.glVertexAttrib4s(index, x, y, z, w);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glVertexAttrib4sv(uint index, short* v)
		{
			internalGL.glVertexAttrib4sv(index, v);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glVertexAttrib4ubv(uint index, byte* v)
		{
			internalGL.glVertexAttrib4ubv(index, v);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glVertexAttrib4uiv(uint index, uint* v)
		{
			internalGL.glVertexAttrib4uiv(index, v);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static unsafe void glVertexAttrib4usv(uint index, ushort* v)
		{
			internalGL.glVertexAttrib4usv(index, v);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static void glVertexAttribBinding(uint attribindex, uint bindingindex)
		{
			internalGL.glVertexAttribBinding(attribindex, bindingindex);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static void glVertexAttribDivisor(uint index, uint divisor)
		{
			internalGL.glVertexAttribDivisor(index, divisor);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static void glVertexAttribFormat(uint attribindex, int size, VertexAttribType type, Boolean normalized, uint relativeoffset)
		{
			internalGL.glVertexAttribFormat(attribindex, size, type, normalized, relativeoffset);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static void glVertexAttribI1i(uint index, int x)
		{
			internalGL.glVertexAttribI1i(index, x);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glVertexAttribI1iv(uint index, int* v)
		{
			internalGL.glVertexAttribI1iv(index, v);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static void glVertexAttribI1ui(uint index, uint x)
		{
			internalGL.glVertexAttribI1ui(index, x);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glVertexAttribI1uiv(uint index, uint* v)
		{
			internalGL.glVertexAttribI1uiv(index, v);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static void glVertexAttribI2i(uint index, int x, int y)
		{
			internalGL.glVertexAttribI2i(index, x, y);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glVertexAttribI2iv(uint index, int* v)
		{
			internalGL.glVertexAttribI2iv(index, v);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static void glVertexAttribI2ui(uint index, uint x, uint y)
		{
			internalGL.glVertexAttribI2ui(index, x, y);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glVertexAttribI2uiv(uint index, uint* v)
		{
			internalGL.glVertexAttribI2uiv(index, v);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static void glVertexAttribI3i(uint index, int x, int y, int z)
		{
			internalGL.glVertexAttribI3i(index, x, y, z);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glVertexAttribI3iv(uint index, int* v)
		{
			internalGL.glVertexAttribI3iv(index, v);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static void glVertexAttribI3ui(uint index, uint x, uint y, uint z)
		{
			internalGL.glVertexAttribI3ui(index, x, y, z);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glVertexAttribI3uiv(uint index, uint* v)
		{
			internalGL.glVertexAttribI3uiv(index, v);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glVertexAttribI4bv(uint index, sbyte* v)
		{
			internalGL.glVertexAttribI4bv(index, v);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static void glVertexAttribI4i(uint index, int x, int y, int z, int w)
		{
			internalGL.glVertexAttribI4i(index, x, y, z, w);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glVertexAttribI4iv(uint index, int* v)
		{
			internalGL.glVertexAttribI4iv(index, v);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glVertexAttribI4sv(uint index, short* v)
		{
			internalGL.glVertexAttribI4sv(index, v);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glVertexAttribI4ubv(uint index, byte* v)
		{
			internalGL.glVertexAttribI4ubv(index, v);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static void glVertexAttribI4ui(uint index, uint x, uint y, uint z, uint w)
		{
			internalGL.glVertexAttribI4ui(index, x, y, z, w);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glVertexAttribI4uiv(uint index, uint* v)
		{
			internalGL.glVertexAttribI4uiv(index, v);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe void glVertexAttribI4usv(uint index, ushort* v)
		{
			internalGL.glVertexAttribI4usv(index, v);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static void glVertexAttribIFormat(uint attribindex, int size, VertexAttribIType type, uint relativeoffset)
		{
			internalGL.glVertexAttribIFormat(attribindex, size, type, relativeoffset);
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static void glVertexAttribIPointer(uint index, int size, VertexAttribIType type, int stride, IntPtr pointer)
		{
			internalGL.glVertexAttribIPointer(index, size, type, stride, pointer);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static void glVertexAttribL1d(uint index, double x)
		{
			internalGL.glVertexAttribL1d(index, x);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glVertexAttribL1dv(uint index, double* v)
		{
			internalGL.glVertexAttribL1dv(index, v);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static void glVertexAttribL2d(uint index, double x, double y)
		{
			internalGL.glVertexAttribL2d(index, x, y);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glVertexAttribL2dv(uint index, double* v)
		{
			internalGL.glVertexAttribL2dv(index, v);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static void glVertexAttribL3d(uint index, double x, double y, double z)
		{
			internalGL.glVertexAttribL3d(index, x, y, z);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glVertexAttribL3dv(uint index, double* v)
		{
			internalGL.glVertexAttribL3dv(index, v);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static void glVertexAttribL4d(uint index, double x, double y, double z, double w)
		{
			internalGL.glVertexAttribL4d(index, x, y, z, w);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glVertexAttribL4dv(uint index, double* v)
		{
			internalGL.glVertexAttribL4dv(index, v);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static void glVertexAttribLFormat(uint attribindex, int size, VertexAttribLType type, uint relativeoffset)
		{
			internalGL.glVertexAttribLFormat(attribindex, size, type, relativeoffset);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static void glVertexAttribLPointer(uint index, int size, VertexAttribLType type, int stride, IntPtr pointer)
		{
			internalGL.glVertexAttribLPointer(index, size, type, stride, pointer);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static void glVertexAttribP1ui(uint index, VertexAttribPointerType type, Boolean normalized, uint value)
		{
			internalGL.glVertexAttribP1ui(index, type, normalized, value);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static unsafe void glVertexAttribP1uiv(uint index, VertexAttribPointerType type, Boolean normalized, uint* value)
		{
			internalGL.glVertexAttribP1uiv(index, type, normalized, value);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static void glVertexAttribP2ui(uint index, VertexAttribPointerType type, Boolean normalized, uint value)
		{
			internalGL.glVertexAttribP2ui(index, type, normalized, value);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static unsafe void glVertexAttribP2uiv(uint index, VertexAttribPointerType type, Boolean normalized, uint* value)
		{
			internalGL.glVertexAttribP2uiv(index, type, normalized, value);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static void glVertexAttribP3ui(uint index, VertexAttribPointerType type, Boolean normalized, uint value)
		{
			internalGL.glVertexAttribP3ui(index, type, normalized, value);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static unsafe void glVertexAttribP3uiv(uint index, VertexAttribPointerType type, Boolean normalized, uint* value)
		{
			internalGL.glVertexAttribP3uiv(index, type, normalized, value);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static void glVertexAttribP4ui(uint index, VertexAttribPointerType type, Boolean normalized, uint value)
		{
			internalGL.glVertexAttribP4ui(index, type, normalized, value);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static unsafe void glVertexAttribP4uiv(uint index, VertexAttribPointerType type, Boolean normalized, uint* value)
		{
			internalGL.glVertexAttribP4uiv(index, type, normalized, value);
		}

		///<sumary> Available from OpenGL version 2.0</sumary>
		public static void glVertexAttribPointer(uint index, int size, VertexAttribPointerType type, Boolean normalized, int stride, IntPtr pointer)
		{
			internalGL.glVertexAttribPointer(index, size, type, normalized, stride, pointer);
		}

		///<sumary> Available from OpenGL version 4.3</sumary>
		public static void glVertexBindingDivisor(uint bindingindex, uint divisor)
		{
			internalGL.glVertexBindingDivisor(bindingindex, divisor);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static void glVertexP2ui(VertexPointerType type, uint value)
		{
			internalGL.glVertexP2ui(type, value);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static unsafe void glVertexP2uiv(VertexPointerType type, uint* value)
		{
			internalGL.glVertexP2uiv(type, value);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static void glVertexP3ui(VertexPointerType type, uint value)
		{
			internalGL.glVertexP3ui(type, value);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static unsafe void glVertexP3uiv(VertexPointerType type, uint* value)
		{
			internalGL.glVertexP3uiv(type, value);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static void glVertexP4ui(VertexPointerType type, uint value)
		{
			internalGL.glVertexP4ui(type, value);
		}

		///<sumary> Available from OpenGL version 3.3</sumary>
		public static unsafe void glVertexP4uiv(VertexPointerType type, uint* value)
		{
			internalGL.glVertexP4uiv(type, value);
		}

		///<sumary> Available from OpenGL version 1.1 | Deprecated in OpenGL version 3.2</sumary>
		public static void glVertexPointer(int size, VertexPointerType type, int stride, IntPtr pointer)
		{
			internalGL.glVertexPointer(size, type, stride, pointer);
		}

		///<sumary> Available from OpenGL version 1.0</sumary>
		public static void glViewport(int x, int y, int width, int height)
		{
			internalGL.glViewport(x, y, width, height);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glViewportArrayv(uint first, int count, float* v)
		{
			internalGL.glViewportArrayv(first, count, v);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static void glViewportIndexedf(uint index, float x, float y, float w, float h)
		{
			internalGL.glViewportIndexedf(index, x, y, w, h);
		}

		///<sumary> Available from OpenGL version 4.1</sumary>
		public static unsafe void glViewportIndexedfv(uint index, float* v)
		{
			internalGL.glViewportIndexedfv(index, v);
		}

		#endregion

		#region W:

		///<sumary> Available from OpenGL version 3.2</sumary>
		public static void glWaitSync(IntPtr sync, SyncBehaviorFlags flags, ulong timeout)
		{
			internalGL.glWaitSync(sync, flags, timeout);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static void glWindowPos2d(double x, double y)
		{
			internalGL.glWindowPos2d(x, y);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glWindowPos2dv(double* v)
		{
			internalGL.glWindowPos2dv(v);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static void glWindowPos2f(float x, float y)
		{
			internalGL.glWindowPos2f(x, y);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glWindowPos2fv(float* v)
		{
			internalGL.glWindowPos2fv(v);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static void glWindowPos2i(int x, int y)
		{
			internalGL.glWindowPos2i(x, y);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glWindowPos2iv(int* v)
		{
			internalGL.glWindowPos2iv(v);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static void glWindowPos2s(short x, short y)
		{
			internalGL.glWindowPos2s(x, y);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glWindowPos2sv(short* v)
		{
			internalGL.glWindowPos2sv(v);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static void glWindowPos3d(double x, double y, double z)
		{
			internalGL.glWindowPos3d(x, y, z);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glWindowPos3dv(double* v)
		{
			internalGL.glWindowPos3dv(v);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static void glWindowPos3f(float x, float y, float z)
		{
			internalGL.glWindowPos3f(x, y, z);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glWindowPos3fv(float* v)
		{
			internalGL.glWindowPos3fv(v);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static void glWindowPos3i(int x, int y, int z)
		{
			internalGL.glWindowPos3i(x, y, z);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glWindowPos3iv(int* v)
		{
			internalGL.glWindowPos3iv(v);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static void glWindowPos3s(short x, short y, short z)
		{
			internalGL.glWindowPos3s(x, y, z);
		}

		///<sumary> Available from OpenGL version 1.4 | Deprecated in OpenGL version 3.2</sumary>
		public static unsafe void glWindowPos3sv(short* v)
		{
			internalGL.glWindowPos3sv(v);
		}

		#endregion

	}
}

