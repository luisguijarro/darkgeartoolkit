// OpenGL|ES Methods.
// File Created with OpenGL Parser 3.
// Developed by Luis Guijarro Pérez.

using System;
using System.Text;
using System.Runtime.InteropServices;

namespace dgtk.OpenGL
{
	public static partial class GLES
	{
		#region A:

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static void glActiveShaderProgram(uint pipeline, uint program)
		{
			internalGLES.glActiveShaderProgram(pipeline, program);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glActiveTexture(TextureUnit texture)
		{
			internalGLES.glActiveTexture(texture);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glAlphaFunc(AlphaFunction func, float @ref)
		{
			internalGLES.glAlphaFunc(func, @ref);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glAlphaFuncx(AlphaFunction func, int @ref)
		{
			internalGLES.glAlphaFuncx(func, @ref);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glAttachShader(uint program, uint shader)
		{
			internalGLES.glAttachShader(program, shader);
		}

		#endregion

		#region B:

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glBeginQuery(QueryTarget target, uint id)
		{
			internalGLES.glBeginQuery(target, id);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glBeginTransformFeedback(PrimitiveType primitiveMode)
		{
			internalGLES.glBeginTransformFeedback(primitiveMode);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe void glBindAttribLocation(uint program, uint index, [MarshalAs(UnmanagedType.LPStr)] string name)
		{
			internalGLES.glBindAttribLocation(program, index, name);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glBindBuffer(BufferTargetARB target, uint buffer)
		{
			internalGLES.glBindBuffer(target, buffer);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glBindBufferBase(BufferTargetARB target, uint index, uint buffer)
		{
			internalGLES.glBindBufferBase(target, index, buffer);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glBindBufferRange(BufferTargetARB target, uint index, uint buffer, IntPtr offset, int size)
		{
			internalGLES.glBindBufferRange(target, index, buffer, offset, size);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glBindFramebuffer(FramebufferTarget target, uint framebuffer)
		{
			internalGLES.glBindFramebuffer(target, framebuffer);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static void glBindImageTexture(uint unit, uint texture, int level, Boolean layered, int layer, BufferAccessARB access, InternalFormat format)
		{
			internalGLES.glBindImageTexture(unit, texture, level, layered, layer, access, format);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static void glBindProgramPipeline(uint pipeline)
		{
			internalGLES.glBindProgramPipeline(pipeline);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glBindRenderbuffer(RenderbufferTarget target, uint renderbuffer)
		{
			internalGLES.glBindRenderbuffer(target, renderbuffer);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glBindSampler(uint unit, uint sampler)
		{
			internalGLES.glBindSampler(unit, sampler);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glBindTexture(TextureTarget target, uint texture)
		{
			internalGLES.glBindTexture(target, texture);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glBindTransformFeedback(BindTransformFeedbackTarget target, uint id)
		{
			internalGLES.glBindTransformFeedback(target, id);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glBindVertexArray(uint array)
		{
			internalGLES.glBindVertexArray(array);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static void glBindVertexBuffer(uint bindingindex, uint buffer, IntPtr offset, int stride)
		{
			internalGLES.glBindVertexBuffer(bindingindex, buffer, offset, stride);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static void glBlendBarrier()
		{
			internalGLES.glBlendBarrier();
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glBlendColor(float red, float green, float blue, float alpha)
		{
			internalGLES.glBlendColor(red, green, blue, alpha);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glBlendEquation(BlendEquationModeEXT mode)
		{
			internalGLES.glBlendEquation(mode);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static void glBlendEquationi(uint buf, BlendEquationModeEXT mode)
		{
			internalGLES.glBlendEquationi(buf, mode);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glBlendEquationSeparate(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha)
		{
			internalGLES.glBlendEquationSeparate(modeRGB, modeAlpha);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static void glBlendEquationSeparatei(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha)
		{
			internalGLES.glBlendEquationSeparatei(buf, modeRGB, modeAlpha);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glBlendFunc(BlendingFactor sfactor, BlendingFactor dfactor)
		{
			internalGLES.glBlendFunc(sfactor, dfactor);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static void glBlendFunci(uint buf, BlendingFactor src, BlendingFactor dst)
		{
			internalGLES.glBlendFunci(buf, src, dst);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glBlendFuncSeparate(BlendingFactor sfactorRGB, BlendingFactor dfactorRGB, BlendingFactor sfactorAlpha, BlendingFactor dfactorAlpha)
		{
			internalGLES.glBlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static void glBlendFuncSeparatei(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha)
		{
			internalGLES.glBlendFuncSeparatei(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glBlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter)
		{
			internalGLES.glBlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glBufferData(BufferTargetARB target, int size, IntPtr data, BufferUsageARB usage)
		{
			internalGLES.glBufferData(target, size, data, usage);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glBufferSubData(BufferTargetARB target, IntPtr offset, int size, IntPtr data)
		{
			internalGLES.glBufferSubData(target, offset, size, data);
		}

		#endregion

		#region C:

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static uint glCheckFramebufferStatus(FramebufferTarget target)
		{
			return internalGLES.glCheckFramebufferStatus(target);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glClear(ClearBufferMask mask)
		{
			internalGLES.glClear(mask);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glClearBufferfi(Buffer buffer, int drawbuffer, float depth, int stencil)
		{
			internalGLES.glClearBufferfi(buffer, drawbuffer, depth, stencil);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glClearBufferfv(Buffer buffer, int drawbuffer, float* value)
		{
			internalGLES.glClearBufferfv(buffer, drawbuffer, value);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glClearBufferiv(Buffer buffer, int drawbuffer, int* value)
		{
			internalGLES.glClearBufferiv(buffer, drawbuffer, value);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glClearBufferuiv(Buffer buffer, int drawbuffer, uint* value)
		{
			internalGLES.glClearBufferuiv(buffer, drawbuffer, value);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glClearColor(float red, float green, float blue, float alpha)
		{
			internalGLES.glClearColor(red, green, blue, alpha);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glClearColorx(int red, int green, int blue, int alpha)
		{
			internalGLES.glClearColorx(red, green, blue, alpha);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glClearDepthf(float d)
		{
			internalGLES.glClearDepthf(d);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glClearDepthx(int depth)
		{
			internalGLES.glClearDepthx(depth);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glClearStencil(int s)
		{
			internalGLES.glClearStencil(s);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glClientActiveTexture(TextureUnit texture)
		{
			internalGLES.glClientActiveTexture(texture);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static uint glClientWaitSync(IntPtr sync, SyncObjectMask flags, ulong timeout)
		{
			return internalGLES.glClientWaitSync(sync, flags, timeout);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glClipPlanef(ClipPlaneName p, float* eqn)
		{
			internalGLES.glClipPlanef(p, eqn);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glClipPlanex(ClipPlaneName plane, int* equation)
		{
			internalGLES.glClipPlanex(plane, equation);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glColor4f(float red, float green, float blue, float alpha)
		{
			internalGLES.glColor4f(red, green, blue, alpha);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glColor4ub(byte red, byte green, byte blue, byte alpha)
		{
			internalGLES.glColor4ub(red, green, blue, alpha);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glColor4x(int red, int green, int blue, int alpha)
		{
			internalGLES.glColor4x(red, green, blue, alpha);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glColorMask(Boolean red, Boolean green, Boolean blue, Boolean alpha)
		{
			internalGLES.glColorMask(red, green, blue, alpha);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static void glColorMaski(uint index, Boolean r, Boolean g, Boolean b, Boolean a)
		{
			internalGLES.glColorMaski(index, r, g, b, a);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glColorPointer(int size, ColorPointerType type, int stride, IntPtr pointer)
		{
			internalGLES.glColorPointer(size, type, stride, pointer);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glCompileShader(uint shader)
		{
			internalGLES.glCompileShader(shader);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glCompressedTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, IntPtr data)
		{
			internalGLES.glCompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glCompressedTexImage3D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data)
		{
			internalGLES.glCompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glCompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, InternalFormat format, int imageSize, IntPtr data)
		{
			internalGLES.glCompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glCompressedTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, int imageSize, IntPtr data)
		{
			internalGLES.glCompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glCopyBufferSubData(CopyBufferSubDataTarget readTarget, CopyBufferSubDataTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, int size)
		{
			internalGLES.glCopyBufferSubData(readTarget, writeTarget, readOffset, writeOffset, size);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static void glCopyImageSubData(uint srcName, CopyImageSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyImageSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth)
		{
			internalGLES.glCopyImageSubData(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glCopyTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int height, int border)
		{
			internalGLES.glCopyTexImage2D(target, level, internalformat, x, y, width, height, border);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glCopyTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height)
		{
			internalGLES.glCopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glCopyTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
		{
			internalGLES.glCopyTexSubImage3D(target, level, xoffset, yoffset, zoffset, x, y, width, height);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static uint glCreateProgram()
		{
			return internalGLES.glCreateProgram();
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static uint glCreateShader(ShaderType type)
		{
			return internalGLES.glCreateShader(type);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static unsafe uint glCreateShaderProgramv(ShaderType type, int count, [MarshalAs(UnmanagedType.LPStr)] string[] strings)
		{
			return internalGLES.glCreateShaderProgramv(type, count, strings);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glCullFace(CullFaceMode mode)
		{
			internalGLES.glCullFace(mode);
		}

		#endregion

		#region D:

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static void glDebugMessageCallback(Delegate callback, IntPtr userParam)
		{
			internalGLES.glDebugMessageCallback(callback, userParam);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static unsafe void glDebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, Boolean enabled)
		{
			internalGLES.glDebugMessageControl(source, type, severity, count, ids, enabled);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static unsafe void glDebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, [MarshalAs(UnmanagedType.LPStr)] string buf)
		{
			internalGLES.glDebugMessageInsert(source, type, id, severity, length, buf);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glDeleteBuffers(int n, uint* buffers)
		{
			internalGLES.glDeleteBuffers(n, buffers);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe void glDeleteFramebuffers(int n, uint* framebuffers)
		{
			internalGLES.glDeleteFramebuffers(n, framebuffers);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glDeleteProgram(uint program)
		{
			internalGLES.glDeleteProgram(program);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static unsafe void glDeleteProgramPipelines(int n, uint* pipelines)
		{
			internalGLES.glDeleteProgramPipelines(n, pipelines);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glDeleteQueries(int n, uint* ids)
		{
			internalGLES.glDeleteQueries(n, ids);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe void glDeleteRenderbuffers(int n, uint* renderbuffers)
		{
			internalGLES.glDeleteRenderbuffers(n, renderbuffers);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glDeleteSamplers(int count, uint* samplers)
		{
			internalGLES.glDeleteSamplers(count, samplers);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glDeleteShader(uint shader)
		{
			internalGLES.glDeleteShader(shader);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glDeleteSync(IntPtr sync)
		{
			internalGLES.glDeleteSync(sync);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glDeleteTextures(int n, uint* textures)
		{
			internalGLES.glDeleteTextures(n, textures);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glDeleteTransformFeedbacks(int n, uint* ids)
		{
			internalGLES.glDeleteTransformFeedbacks(n, ids);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glDeleteVertexArrays(int n, uint* arrays)
		{
			internalGLES.glDeleteVertexArrays(n, arrays);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glDepthFunc(DepthFunction func)
		{
			internalGLES.glDepthFunc(func);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glDepthMask(Boolean flag)
		{
			internalGLES.glDepthMask(flag);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glDepthRangef(float n, float f)
		{
			internalGLES.glDepthRangef(n, f);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glDepthRangex(int n, int f)
		{
			internalGLES.glDepthRangex(n, f);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glDetachShader(uint program, uint shader)
		{
			internalGLES.glDetachShader(program, shader);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glDisable(EnableCap cap)
		{
			internalGLES.glDisable(cap);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glDisableClientState(EnableCap array)
		{
			internalGLES.glDisableClientState(array);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static void glDisablei(EnableCap target, uint index)
		{
			internalGLES.glDisablei(target, index);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glDisableVertexAttribArray(uint index)
		{
			internalGLES.glDisableVertexAttribArray(index);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static void glDispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z)
		{
			internalGLES.glDispatchCompute(num_groups_x, num_groups_y, num_groups_z);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static void glDispatchComputeIndirect(IntPtr indirect)
		{
			internalGLES.glDispatchComputeIndirect(indirect);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glDrawArrays(PrimitiveType mode, int first, int count)
		{
			internalGLES.glDrawArrays(mode, first, count);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static void glDrawArraysIndirect(PrimitiveType mode, IntPtr indirect)
		{
			internalGLES.glDrawArraysIndirect(mode, indirect);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glDrawArraysInstanced(PrimitiveType mode, int first, int count, int instancecount)
		{
			internalGLES.glDrawArraysInstanced(mode, first, count, instancecount);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glDrawBuffers(int n, DrawBufferMode* bufs)
		{
			internalGLES.glDrawBuffers(n, bufs);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glDrawElements(PrimitiveType mode, int count, DrawElementsType type, IntPtr indices)
		{
			internalGLES.glDrawElements(mode, count, type, indices);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static void glDrawElementsBaseVertex(PrimitiveType mode, int count, DrawElementsType type, IntPtr indices, int basevertex)
		{
			internalGLES.glDrawElementsBaseVertex(mode, count, type, indices, basevertex);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static void glDrawElementsIndirect(PrimitiveType mode, DrawElementsType type, IntPtr indirect)
		{
			internalGLES.glDrawElementsIndirect(mode, type, indirect);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glDrawElementsInstanced(PrimitiveType mode, int count, DrawElementsType type, IntPtr indices, int instancecount)
		{
			internalGLES.glDrawElementsInstanced(mode, count, type, indices, instancecount);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static void glDrawElementsInstancedBaseVertex(PrimitiveType mode, int count, DrawElementsType type, IntPtr indices, int instancecount, int basevertex)
		{
			internalGLES.glDrawElementsInstancedBaseVertex(mode, count, type, indices, instancecount, basevertex);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glDrawRangeElements(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, IntPtr indices)
		{
			internalGLES.glDrawRangeElements(mode, start, end, count, type, indices);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static void glDrawRangeElementsBaseVertex(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, IntPtr indices, int basevertex)
		{
			internalGLES.glDrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
		}

		#endregion

		#region E:

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glEnable(EnableCap cap)
		{
			internalGLES.glEnable(cap);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glEnableClientState(EnableCap array)
		{
			internalGLES.glEnableClientState(array);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static void glEnablei(EnableCap target, uint index)
		{
			internalGLES.glEnablei(target, index);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glEnableVertexAttribArray(uint index)
		{
			internalGLES.glEnableVertexAttribArray(index);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glEndQuery(QueryTarget target)
		{
			internalGLES.glEndQuery(target);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glEndTransformFeedback()
		{
			internalGLES.glEndTransformFeedback();
		}

		#endregion

		#region F:

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static IntPtr glFenceSync(SyncCondition condition, SyncBehaviorFlags flags)
		{
			return internalGLES.glFenceSync(condition, flags);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glFinish()
		{
			internalGLES.glFinish();
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glFlush()
		{
			internalGLES.glFlush();
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glFlushMappedBufferRange(BufferTargetARB target, IntPtr offset, int length)
		{
			internalGLES.glFlushMappedBufferRange(target, offset, length);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glFogf(FogParameter pname, float param)
		{
			internalGLES.glFogf(pname, param);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glFogfv(FogParameter pname, float* @params)
		{
			internalGLES.glFogfv(pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glFogx(FogPName pname, int param)
		{
			internalGLES.glFogx(pname, param);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glFogxv(FogPName pname, int* param)
		{
			internalGLES.glFogxv(pname, param);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static void glFramebufferParameteri(FramebufferTarget target, FramebufferParameterName pname, int param)
		{
			internalGLES.glFramebufferParameteri(target, pname, param);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glFramebufferRenderbuffer(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, uint renderbuffer)
		{
			internalGLES.glFramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static void glFramebufferTexture(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level)
		{
			internalGLES.glFramebufferTexture(target, attachment, texture, level);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glFramebufferTexture2D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level)
		{
			internalGLES.glFramebufferTexture2D(target, attachment, textarget, texture, level);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glFramebufferTextureLayer(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, int layer)
		{
			internalGLES.glFramebufferTextureLayer(target, attachment, texture, level, layer);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glFrontFace(FrontFaceDirection mode)
		{
			internalGLES.glFrontFace(mode);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glFrustumf(float l, float r, float b, float t, float n, float f)
		{
			internalGLES.glFrustumf(l, r, b, t, n, f);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glFrustumx(int l, int r, int b, int t, int n, int f)
		{
			internalGLES.glFrustumx(l, r, b, t, n, f);
		}

		#endregion

		#region G:

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glGenBuffers(int n, uint* buffers)
		{
			internalGLES.glGenBuffers(n, buffers);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glGenerateMipmap(TextureTarget target)
		{
			internalGLES.glGenerateMipmap(target);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe void glGenFramebuffers(int n, uint* framebuffers)
		{
			internalGLES.glGenFramebuffers(n, framebuffers);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static unsafe void glGenProgramPipelines(int n, uint* pipelines)
		{
			internalGLES.glGenProgramPipelines(n, pipelines);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glGenQueries(int n, uint* ids)
		{
			internalGLES.glGenQueries(n, ids);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe void glGenRenderbuffers(int n, uint* renderbuffers)
		{
			internalGLES.glGenRenderbuffers(n, renderbuffers);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glGenSamplers(int count, uint* samplers)
		{
			internalGLES.glGenSamplers(count, samplers);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glGenTextures(int n, uint* textures)
		{
			internalGLES.glGenTextures(n, textures);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glGenTransformFeedbacks(int n, uint* ids)
		{
			internalGLES.glGenTransformFeedbacks(n, ids);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glGenVertexArrays(int n, uint* arrays)
		{
			internalGLES.glGenVertexArrays(n, arrays);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe void glGetActiveAttrib(uint program, uint index, int bufSize, int* length, int* size, AttributeType* type, StringBuilder name)
		{
			internalGLES.glGetActiveAttrib(program, index, bufSize, length, size, type, name);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe void glGetActiveUniform(uint program, uint index, int bufSize, int* length, int* size, UniformType* type, StringBuilder name)
		{
			internalGLES.glGetActiveUniform(program, index, bufSize, length, size, type, name);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glGetActiveUniformBlockiv(uint program, uint uniformBlockIndex, UniformBlockPName pname, int* @params)
		{
			internalGLES.glGetActiveUniformBlockiv(program, uniformBlockIndex, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glGetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, int* length, StringBuilder uniformBlockName)
		{
			internalGLES.glGetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length, uniformBlockName);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glGetActiveUniformsiv(uint program, int uniformCount, uint* uniformIndices, UniformPName pname, int* @params)
		{
			internalGLES.glGetActiveUniformsiv(program, uniformCount, uniformIndices, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe void glGetAttachedShaders(uint program, int maxCount, int* count, uint* shaders)
		{
			internalGLES.glGetAttachedShaders(program, maxCount, count, shaders);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe int glGetAttribLocation(uint program, [MarshalAs(UnmanagedType.LPStr)] string name)
		{
			return internalGLES.glGetAttribLocation(program, name);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static unsafe void glGetBooleani_v(BufferTargetARB target, uint index, Boolean* data)
		{
			internalGLES.glGetBooleani_v(target, index, data);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glGetBooleanv(GetPName pname, Boolean* data)
		{
			internalGLES.glGetBooleanv(pname, data);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glGetBufferParameteri64v(BufferTargetARB target, BufferPNameARB pname, long* @params)
		{
			internalGLES.glGetBufferParameteri64v(target, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glGetBufferParameteriv(BufferTargetARB target, BufferPNameARB pname, int* @params)
		{
			internalGLES.glGetBufferParameteriv(target, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glGetBufferPointerv(BufferTargetARB target, BufferPointerNameARB pname, IntPtr @params)
		{
			internalGLES.glGetBufferPointerv(target, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glGetClipPlanef(ClipPlaneName plane, float* equation)
		{
			internalGLES.glGetClipPlanef(plane, equation);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glGetClipPlanex(ClipPlaneName plane, int* equation)
		{
			internalGLES.glGetClipPlanex(plane, equation);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static unsafe uint glGetDebugMessageLog(uint count, int bufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, StringBuilder messageLog)
		{
			return internalGLES.glGetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, messageLog);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static uint glGetError()
		{
			return internalGLES.glGetError();
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glGetFixedv(GetPName pname, int* @params)
		{
			internalGLES.glGetFixedv(pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glGetFloatv(GetPName pname, float* data)
		{
			internalGLES.glGetFloatv(pname, data);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe int glGetFragDataLocation(uint program, [MarshalAs(UnmanagedType.LPStr)] string name)
		{
			return internalGLES.glGetFragDataLocation(program, name);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe void glGetFramebufferAttachmentParameteriv(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int* @params)
		{
			internalGLES.glGetFramebufferAttachmentParameteriv(target, attachment, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static unsafe void glGetFramebufferParameteriv(FramebufferTarget target, FramebufferAttachmentParameterName pname, int* @params)
		{
			internalGLES.glGetFramebufferParameteriv(target, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static uint glGetGraphicsResetStatus()
		{
			return internalGLES.glGetGraphicsResetStatus();
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glGetInteger64i_v(GetPName target, uint index, long* data)
		{
			internalGLES.glGetInteger64i_v(target, index, data);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glGetInteger64v(GetPName pname, long* data)
		{
			internalGLES.glGetInteger64v(pname, data);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glGetIntegeri_v(GetPName target, uint index, int* data)
		{
			internalGLES.glGetIntegeri_v(target, index, data);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glGetIntegerv(GetPName pname, int* data)
		{
			internalGLES.glGetIntegerv(pname, data);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glGetInternalformativ(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, int count, int* @params)
		{
			internalGLES.glGetInternalformativ(target, internalformat, pname, count, @params);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glGetLightfv(LightName light, LightParameter pname, float* @params)
		{
			internalGLES.glGetLightfv(light, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glGetLightxv(LightName light, LightParameter pname, int* @params)
		{
			internalGLES.glGetLightxv(light, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glGetMaterialfv(MaterialFace face, MaterialParameter pname, float* @params)
		{
			internalGLES.glGetMaterialfv(face, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glGetMaterialxv(MaterialFace face, MaterialParameter pname, int* @params)
		{
			internalGLES.glGetMaterialxv(face, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static unsafe void glGetMultisamplefv(GetMultisamplePNameNV pname, uint index, float* val)
		{
			internalGLES.glGetMultisamplefv(pname, index, val);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static unsafe void glGetnUniformfv(uint program, int location, int bufSize, float* @params)
		{
			internalGLES.glGetnUniformfv(program, location, bufSize, @params);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static unsafe void glGetnUniformiv(uint program, int location, int bufSize, int* @params)
		{
			internalGLES.glGetnUniformiv(program, location, bufSize, @params);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static unsafe void glGetnUniformuiv(uint program, int location, int bufSize, uint* @params)
		{
			internalGLES.glGetnUniformuiv(program, location, bufSize, @params);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static unsafe void glGetObjectLabel(ObjectIdentifier identifier, uint name, int bufSize, int* length, StringBuilder label)
		{
			internalGLES.glGetObjectLabel(identifier, name, bufSize, length, label);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static unsafe void glGetObjectPtrLabel(IntPtr ptr, int bufSize, int* length, StringBuilder label)
		{
			internalGLES.glGetObjectPtrLabel(ptr, bufSize, length, label);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glGetPointerv(GetPointervPName pname, IntPtr @params)
		{
			internalGLES.glGetPointerv(pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glGetProgramBinary(uint program, int bufSize, int* length, uint* binaryFormat, IntPtr binary)
		{
			internalGLES.glGetProgramBinary(program, bufSize, length, binaryFormat, binary);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe void glGetProgramInfoLog(uint program, int bufSize, int* length, StringBuilder infoLog)
		{
			internalGLES.glGetProgramInfoLog(program, bufSize, length, infoLog);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static unsafe void glGetProgramInterfaceiv(uint program, ProgramInterface programInterface, ProgramInterfacePName pname, int* @params)
		{
			internalGLES.glGetProgramInterfaceiv(program, programInterface, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe void glGetProgramiv(uint program, ProgramPropertyARB pname, int* @params)
		{
			internalGLES.glGetProgramiv(program, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static unsafe void glGetProgramPipelineInfoLog(uint pipeline, int bufSize, int* length, StringBuilder infoLog)
		{
			internalGLES.glGetProgramPipelineInfoLog(pipeline, bufSize, length, infoLog);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static unsafe void glGetProgramPipelineiv(uint pipeline, PipelineParameterName pname, int* @params)
		{
			internalGLES.glGetProgramPipelineiv(pipeline, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static unsafe uint glGetProgramResourceIndex(uint program, ProgramInterface programInterface, [MarshalAs(UnmanagedType.LPStr)] string name)
		{
			return internalGLES.glGetProgramResourceIndex(program, programInterface, name);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static unsafe void glGetProgramResourceiv(uint program, ProgramInterface programInterface, uint index, int propCount, ProgramResourceProperty* props, int count, int* length, int* @params)
		{
			internalGLES.glGetProgramResourceiv(program, programInterface, index, propCount, props, count, length, @params);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static unsafe int glGetProgramResourceLocation(uint program, ProgramInterface programInterface, [MarshalAs(UnmanagedType.LPStr)] string name)
		{
			return internalGLES.glGetProgramResourceLocation(program, programInterface, name);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static unsafe void glGetProgramResourceName(uint program, ProgramInterface programInterface, uint index, int bufSize, int* length, StringBuilder name)
		{
			internalGLES.glGetProgramResourceName(program, programInterface, index, bufSize, length, name);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glGetQueryiv(QueryTarget target, QueryParameterName pname, int* @params)
		{
			internalGLES.glGetQueryiv(target, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glGetQueryObjectuiv(uint id, QueryObjectParameterName pname, uint* @params)
		{
			internalGLES.glGetQueryObjectuiv(id, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe void glGetRenderbufferParameteriv(RenderbufferTarget target, RenderbufferParameterName pname, int* @params)
		{
			internalGLES.glGetRenderbufferParameteriv(target, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glGetSamplerParameterfv(uint sampler, SamplerParameterF pname, float* @params)
		{
			internalGLES.glGetSamplerParameterfv(sampler, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static unsafe void glGetSamplerParameterIiv(uint sampler, SamplerParameterI pname, int* @params)
		{
			internalGLES.glGetSamplerParameterIiv(sampler, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static unsafe void glGetSamplerParameterIuiv(uint sampler, SamplerParameterI pname, uint* @params)
		{
			internalGLES.glGetSamplerParameterIuiv(sampler, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glGetSamplerParameteriv(uint sampler, SamplerParameterI pname, int* @params)
		{
			internalGLES.glGetSamplerParameteriv(sampler, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe void glGetShaderInfoLog(uint shader, int bufSize, int* length, StringBuilder infoLog)
		{
			internalGLES.glGetShaderInfoLog(shader, bufSize, length, infoLog);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe void glGetShaderiv(uint shader, ShaderParameterName pname, int* @params)
		{
			internalGLES.glGetShaderiv(shader, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe void glGetShaderPrecisionFormat(ShaderType shadertype, PrecisionType precisiontype, int* range, int* precision)
		{
			internalGLES.glGetShaderPrecisionFormat(shadertype, precisiontype, range, precision);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe void glGetShaderSource(uint shader, int bufSize, int* length, StringBuilder source)
		{
			internalGLES.glGetShaderSource(shader, bufSize, length, source);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe byte* glGetString(StringName name)
		{
			return internalGLES.glGetString(name);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe byte* glGetStringi(StringName name, uint index)
		{
			return internalGLES.glGetStringi(name, index);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glGetSynciv(IntPtr sync, SyncParameterName pname, int count, int* length, int* values)
		{
			internalGLES.glGetSynciv(sync, pname, count, length, values);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glGetTexEnvfv(TextureEnvTarget target, TextureEnvParameter pname, float* @params)
		{
			internalGLES.glGetTexEnvfv(target, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glGetTexEnviv(TextureEnvTarget target, TextureEnvParameter pname, int* @params)
		{
			internalGLES.glGetTexEnviv(target, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glGetTexEnvxv(TextureEnvTarget target, TextureEnvParameter pname, int* @params)
		{
			internalGLES.glGetTexEnvxv(target, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static unsafe void glGetTexLevelParameterfv(TextureTarget target, int level, GetTextureParameter pname, float* @params)
		{
			internalGLES.glGetTexLevelParameterfv(target, level, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static unsafe void glGetTexLevelParameteriv(TextureTarget target, int level, GetTextureParameter pname, int* @params)
		{
			internalGLES.glGetTexLevelParameteriv(target, level, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glGetTexParameterfv(TextureTarget target, GetTextureParameter pname, float* @params)
		{
			internalGLES.glGetTexParameterfv(target, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static unsafe void glGetTexParameterIiv(TextureTarget target, GetTextureParameter pname, int* @params)
		{
			internalGLES.glGetTexParameterIiv(target, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static unsafe void glGetTexParameterIuiv(TextureTarget target, GetTextureParameter pname, uint* @params)
		{
			internalGLES.glGetTexParameterIuiv(target, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glGetTexParameteriv(TextureTarget target, GetTextureParameter pname, int* @params)
		{
			internalGLES.glGetTexParameteriv(target, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glGetTexParameterxv(TextureTarget target, GetTextureParameter pname, int* @params)
		{
			internalGLES.glGetTexParameterxv(target, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glGetTransformFeedbackVarying(uint program, uint index, int bufSize, int* length, int* size, AttributeType* type, StringBuilder name)
		{
			internalGLES.glGetTransformFeedbackVarying(program, index, bufSize, length, size, type, name);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe uint glGetUniformBlockIndex(uint program, [MarshalAs(UnmanagedType.LPStr)] string uniformBlockName)
		{
			return internalGLES.glGetUniformBlockIndex(program, uniformBlockName);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe void glGetUniformfv(uint program, int location, float* @params)
		{
			internalGLES.glGetUniformfv(program, location, @params);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glGetUniformIndices(uint program, int uniformCount, [MarshalAs(UnmanagedType.LPStr)] string[] uniformNames, uint* uniformIndices)
		{
			internalGLES.glGetUniformIndices(program, uniformCount, uniformNames, uniformIndices);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe void glGetUniformiv(uint program, int location, int* @params)
		{
			internalGLES.glGetUniformiv(program, location, @params);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe int glGetUniformLocation(uint program, [MarshalAs(UnmanagedType.LPStr)] string name)
		{
			return internalGLES.glGetUniformLocation(program, name);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glGetUniformuiv(uint program, int location, uint* @params)
		{
			internalGLES.glGetUniformuiv(program, location, @params);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe void glGetVertexAttribfv(uint index, VertexAttribPropertyARB pname, float* @params)
		{
			internalGLES.glGetVertexAttribfv(index, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glGetVertexAttribIiv(uint index, VertexAttribEnum pname, int* @params)
		{
			internalGLES.glGetVertexAttribIiv(index, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glGetVertexAttribIuiv(uint index, VertexAttribEnum pname, uint* @params)
		{
			internalGLES.glGetVertexAttribIuiv(index, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe void glGetVertexAttribiv(uint index, VertexAttribPropertyARB pname, int* @params)
		{
			internalGLES.glGetVertexAttribiv(index, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glGetVertexAttribPointerv(uint index, VertexAttribPointerPropertyARB pname, IntPtr pointer)
		{
			internalGLES.glGetVertexAttribPointerv(index, pname, pointer);
		}

		#endregion

		#region H:

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glHint(HintTarget target, HintMode mode)
		{
			internalGLES.glHint(target, mode);
		}

		#endregion

		#region I:

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glInvalidateFramebuffer(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment* attachments)
		{
			internalGLES.glInvalidateFramebuffer(target, numAttachments, attachments);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glInvalidateSubFramebuffer(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment* attachments, int x, int y, int width, int height)
		{
			internalGLES.glInvalidateSubFramebuffer(target, numAttachments, attachments, x, y, width, height);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static bool glIsBuffer(uint buffer)
		{
			return internalGLES.glIsBuffer(buffer);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static bool glIsEnabled(EnableCap cap)
		{
			return internalGLES.glIsEnabled(cap);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static bool glIsEnabledi(EnableCap target, uint index)
		{
			return internalGLES.glIsEnabledi(target, index);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static bool glIsFramebuffer(uint framebuffer)
		{
			return internalGLES.glIsFramebuffer(framebuffer);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static bool glIsProgram(uint program)
		{
			return internalGLES.glIsProgram(program);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static bool glIsProgramPipeline(uint pipeline)
		{
			return internalGLES.glIsProgramPipeline(pipeline);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static bool glIsQuery(uint id)
		{
			return internalGLES.glIsQuery(id);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static bool glIsRenderbuffer(uint renderbuffer)
		{
			return internalGLES.glIsRenderbuffer(renderbuffer);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static bool glIsSampler(uint sampler)
		{
			return internalGLES.glIsSampler(sampler);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static bool glIsShader(uint shader)
		{
			return internalGLES.glIsShader(shader);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static bool glIsSync(IntPtr sync)
		{
			return internalGLES.glIsSync(sync);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static bool glIsTexture(uint texture)
		{
			return internalGLES.glIsTexture(texture);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static bool glIsTransformFeedback(uint id)
		{
			return internalGLES.glIsTransformFeedback(id);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static bool glIsVertexArray(uint array)
		{
			return internalGLES.glIsVertexArray(array);
		}

		#endregion

		#region L:

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glLightf(LightName light, LightParameter pname, float param)
		{
			internalGLES.glLightf(light, pname, param);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glLightfv(LightName light, LightParameter pname, float* @params)
		{
			internalGLES.glLightfv(light, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glLightModelf(LightModelParameter pname, float param)
		{
			internalGLES.glLightModelf(pname, param);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glLightModelfv(LightModelParameter pname, float* @params)
		{
			internalGLES.glLightModelfv(pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glLightModelx(LightModelParameter pname, int param)
		{
			internalGLES.glLightModelx(pname, param);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glLightModelxv(LightModelParameter pname, int* param)
		{
			internalGLES.glLightModelxv(pname, param);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glLightx(LightName light, LightParameter pname, int param)
		{
			internalGLES.glLightx(light, pname, param);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glLightxv(LightName light, LightParameter pname, int* @params)
		{
			internalGLES.glLightxv(light, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glLineWidth(float width)
		{
			internalGLES.glLineWidth(width);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glLineWidthx(int width)
		{
			internalGLES.glLineWidthx(width);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glLinkProgram(uint program)
		{
			internalGLES.glLinkProgram(program);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glLoadIdentity()
		{
			internalGLES.glLoadIdentity();
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glLoadMatrixf(float* m)
		{
			internalGLES.glLoadMatrixf(m);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glLoadMatrixx(int* m)
		{
			internalGLES.glLoadMatrixx(m);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glLogicOp(LogicOp opcode)
		{
			internalGLES.glLogicOp(opcode);
		}

		#endregion

		#region M:

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe IntPtr* glMapBufferRange(BufferTargetARB target, IntPtr offset, int length, MapBufferAccessMask access)
		{
			return internalGLES.glMapBufferRange(target, offset, length, access);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glMaterialf(MaterialFace face, MaterialParameter pname, float param)
		{
			internalGLES.glMaterialf(face, pname, param);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glMaterialfv(MaterialFace face, MaterialParameter pname, float* @params)
		{
			internalGLES.glMaterialfv(face, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glMaterialx(MaterialFace face, MaterialParameter pname, int param)
		{
			internalGLES.glMaterialx(face, pname, param);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glMaterialxv(MaterialFace face, MaterialParameter pname, int* param)
		{
			internalGLES.glMaterialxv(face, pname, param);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glMatrixMode(MatrixMode mode)
		{
			internalGLES.glMatrixMode(mode);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static void glMemoryBarrier(MemoryBarrierMask barriers)
		{
			internalGLES.glMemoryBarrier(barriers);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static void glMemoryBarrierByRegion(MemoryBarrierMask barriers)
		{
			internalGLES.glMemoryBarrierByRegion(barriers);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static void glMinSampleShading(float value)
		{
			internalGLES.glMinSampleShading(value);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glMultiTexCoord4f(TextureUnit target, float s, float t, float r, float q)
		{
			internalGLES.glMultiTexCoord4f(target, s, t, r, q);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glMultiTexCoord4x(TextureUnit texture, int s, int t, int r, int q)
		{
			internalGLES.glMultiTexCoord4x(texture, s, t, r, q);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glMultMatrixf(float* m)
		{
			internalGLES.glMultMatrixf(m);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glMultMatrixx(int* m)
		{
			internalGLES.glMultMatrixx(m);
		}

		#endregion

		#region N:

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glNormal3f(float nx, float ny, float nz)
		{
			internalGLES.glNormal3f(nx, ny, nz);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glNormal3x(int nx, int ny, int nz)
		{
			internalGLES.glNormal3x(nx, ny, nz);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glNormalPointer(NormalPointerType type, int stride, IntPtr pointer)
		{
			internalGLES.glNormalPointer(type, stride, pointer);
		}

		#endregion

		#region O:

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static unsafe void glObjectLabel(ObjectIdentifier identifier, uint name, int length, [MarshalAs(UnmanagedType.LPStr)] string label)
		{
			internalGLES.glObjectLabel(identifier, name, length, label);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static unsafe void glObjectPtrLabel(IntPtr ptr, int length, [MarshalAs(UnmanagedType.LPStr)] string label)
		{
			internalGLES.glObjectPtrLabel(ptr, length, label);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glOrthof(float l, float r, float b, float t, float n, float f)
		{
			internalGLES.glOrthof(l, r, b, t, n, f);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glOrthox(int l, int r, int b, int t, int n, int f)
		{
			internalGLES.glOrthox(l, r, b, t, n, f);
		}

		#endregion

		#region P:

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static void glPatchParameteri(PatchParameterName pname, int value)
		{
			internalGLES.glPatchParameteri(pname, value);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glPauseTransformFeedback()
		{
			internalGLES.glPauseTransformFeedback();
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glPixelStorei(PixelStoreParameter pname, int param)
		{
			internalGLES.glPixelStorei(pname, param);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glPointParameterf(PointParameterNameARB pname, float param)
		{
			internalGLES.glPointParameterf(pname, param);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glPointParameterfv(PointParameterNameARB pname, float* @params)
		{
			internalGLES.glPointParameterfv(pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glPointParameterx(PointParameterNameARB pname, int param)
		{
			internalGLES.glPointParameterx(pname, param);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glPointParameterxv(PointParameterNameARB pname, int* @params)
		{
			internalGLES.glPointParameterxv(pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glPointSize(float size)
		{
			internalGLES.glPointSize(size);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glPointSizex(int size)
		{
			internalGLES.glPointSizex(size);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glPolygonOffset(float factor, float units)
		{
			internalGLES.glPolygonOffset(factor, units);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glPolygonOffsetx(int factor, int units)
		{
			internalGLES.glPolygonOffsetx(factor, units);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static void glPopDebugGroup()
		{
			internalGLES.glPopDebugGroup();
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glPopMatrix()
		{
			internalGLES.glPopMatrix();
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static void glPrimitiveBoundingBox(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW)
		{
			internalGLES.glPrimitiveBoundingBox(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glProgramBinary(uint program, uint binaryFormat, IntPtr binary, int length)
		{
			internalGLES.glProgramBinary(program, binaryFormat, binary, length);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glProgramParameteri(uint program, ProgramParameterPName pname, int value)
		{
			internalGLES.glProgramParameteri(program, pname, value);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static void glProgramUniform1f(uint program, int location, float v0)
		{
			internalGLES.glProgramUniform1f(program, location, v0);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static unsafe void glProgramUniform1fv(uint program, int location, int count, float* value)
		{
			internalGLES.glProgramUniform1fv(program, location, count, value);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static void glProgramUniform1i(uint program, int location, int v0)
		{
			internalGLES.glProgramUniform1i(program, location, v0);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static unsafe void glProgramUniform1iv(uint program, int location, int count, int* value)
		{
			internalGLES.glProgramUniform1iv(program, location, count, value);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static void glProgramUniform1ui(uint program, int location, uint v0)
		{
			internalGLES.glProgramUniform1ui(program, location, v0);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static unsafe void glProgramUniform1uiv(uint program, int location, int count, uint* value)
		{
			internalGLES.glProgramUniform1uiv(program, location, count, value);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static void glProgramUniform2f(uint program, int location, float v0, float v1)
		{
			internalGLES.glProgramUniform2f(program, location, v0, v1);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static unsafe void glProgramUniform2fv(uint program, int location, int count, float* value)
		{
			internalGLES.glProgramUniform2fv(program, location, count, value);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static void glProgramUniform2i(uint program, int location, int v0, int v1)
		{
			internalGLES.glProgramUniform2i(program, location, v0, v1);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static unsafe void glProgramUniform2iv(uint program, int location, int count, int* value)
		{
			internalGLES.glProgramUniform2iv(program, location, count, value);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static void glProgramUniform2ui(uint program, int location, uint v0, uint v1)
		{
			internalGLES.glProgramUniform2ui(program, location, v0, v1);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static unsafe void glProgramUniform2uiv(uint program, int location, int count, uint* value)
		{
			internalGLES.glProgramUniform2uiv(program, location, count, value);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static void glProgramUniform3f(uint program, int location, float v0, float v1, float v2)
		{
			internalGLES.glProgramUniform3f(program, location, v0, v1, v2);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static unsafe void glProgramUniform3fv(uint program, int location, int count, float* value)
		{
			internalGLES.glProgramUniform3fv(program, location, count, value);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static void glProgramUniform3i(uint program, int location, int v0, int v1, int v2)
		{
			internalGLES.glProgramUniform3i(program, location, v0, v1, v2);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static unsafe void glProgramUniform3iv(uint program, int location, int count, int* value)
		{
			internalGLES.glProgramUniform3iv(program, location, count, value);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static void glProgramUniform3ui(uint program, int location, uint v0, uint v1, uint v2)
		{
			internalGLES.glProgramUniform3ui(program, location, v0, v1, v2);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static unsafe void glProgramUniform3uiv(uint program, int location, int count, uint* value)
		{
			internalGLES.glProgramUniform3uiv(program, location, count, value);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static void glProgramUniform4f(uint program, int location, float v0, float v1, float v2, float v3)
		{
			internalGLES.glProgramUniform4f(program, location, v0, v1, v2, v3);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static unsafe void glProgramUniform4fv(uint program, int location, int count, float* value)
		{
			internalGLES.glProgramUniform4fv(program, location, count, value);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static void glProgramUniform4i(uint program, int location, int v0, int v1, int v2, int v3)
		{
			internalGLES.glProgramUniform4i(program, location, v0, v1, v2, v3);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static unsafe void glProgramUniform4iv(uint program, int location, int count, int* value)
		{
			internalGLES.glProgramUniform4iv(program, location, count, value);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static void glProgramUniform4ui(uint program, int location, uint v0, uint v1, uint v2, uint v3)
		{
			internalGLES.glProgramUniform4ui(program, location, v0, v1, v2, v3);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static unsafe void glProgramUniform4uiv(uint program, int location, int count, uint* value)
		{
			internalGLES.glProgramUniform4uiv(program, location, count, value);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static unsafe void glProgramUniformMatrix2fv(uint program, int location, int count, Boolean transpose, float* value)
		{
			internalGLES.glProgramUniformMatrix2fv(program, location, count, transpose, value);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static unsafe void glProgramUniformMatrix2x3fv(uint program, int location, int count, Boolean transpose, float* value)
		{
			internalGLES.glProgramUniformMatrix2x3fv(program, location, count, transpose, value);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static unsafe void glProgramUniformMatrix2x4fv(uint program, int location, int count, Boolean transpose, float* value)
		{
			internalGLES.glProgramUniformMatrix2x4fv(program, location, count, transpose, value);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static unsafe void glProgramUniformMatrix3fv(uint program, int location, int count, Boolean transpose, float* value)
		{
			internalGLES.glProgramUniformMatrix3fv(program, location, count, transpose, value);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static unsafe void glProgramUniformMatrix3x2fv(uint program, int location, int count, Boolean transpose, float* value)
		{
			internalGLES.glProgramUniformMatrix3x2fv(program, location, count, transpose, value);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static unsafe void glProgramUniformMatrix3x4fv(uint program, int location, int count, Boolean transpose, float* value)
		{
			internalGLES.glProgramUniformMatrix3x4fv(program, location, count, transpose, value);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static unsafe void glProgramUniformMatrix4fv(uint program, int location, int count, Boolean transpose, float* value)
		{
			internalGLES.glProgramUniformMatrix4fv(program, location, count, transpose, value);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static unsafe void glProgramUniformMatrix4x2fv(uint program, int location, int count, Boolean transpose, float* value)
		{
			internalGLES.glProgramUniformMatrix4x2fv(program, location, count, transpose, value);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static unsafe void glProgramUniformMatrix4x3fv(uint program, int location, int count, Boolean transpose, float* value)
		{
			internalGLES.glProgramUniformMatrix4x3fv(program, location, count, transpose, value);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static unsafe void glPushDebugGroup(DebugSource source, uint id, int length, [MarshalAs(UnmanagedType.LPStr)] string message)
		{
			internalGLES.glPushDebugGroup(source, id, length, message);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glPushMatrix()
		{
			internalGLES.glPushMatrix();
		}

		#endregion

		#region R:

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glReadBuffer(ReadBufferMode src)
		{
			internalGLES.glReadBuffer(src);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static void glReadnPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, IntPtr data)
		{
			internalGLES.glReadnPixels(x, y, width, height, format, type, bufSize, data);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glReadPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, IntPtr pixels)
		{
			internalGLES.glReadPixels(x, y, width, height, format, type, pixels);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glReleaseShaderCompiler()
		{
			internalGLES.glReleaseShaderCompiler();
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glRenderbufferStorage(RenderbufferTarget target, InternalFormat internalformat, int width, int height)
		{
			internalGLES.glRenderbufferStorage(target, internalformat, width, height);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glRenderbufferStorageMultisample(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height)
		{
			internalGLES.glRenderbufferStorageMultisample(target, samples, internalformat, width, height);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glResumeTransformFeedback()
		{
			internalGLES.glResumeTransformFeedback();
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glRotatef(float angle, float x, float y, float z)
		{
			internalGLES.glRotatef(angle, x, y, z);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glRotatex(int angle, int x, int y, int z)
		{
			internalGLES.glRotatex(angle, x, y, z);
		}

		#endregion

		#region S:

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glSampleCoverage(float value, Boolean invert)
		{
			internalGLES.glSampleCoverage(value, invert);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glSampleCoveragex(int value, Boolean invert)
		{
			internalGLES.glSampleCoveragex(value, invert);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static void glSampleMaski(uint maskNumber, uint mask)
		{
			internalGLES.glSampleMaski(maskNumber, mask);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glSamplerParameterf(uint sampler, SamplerParameterF pname, float param)
		{
			internalGLES.glSamplerParameterf(sampler, pname, param);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glSamplerParameterfv(uint sampler, SamplerParameterF pname, float* param)
		{
			internalGLES.glSamplerParameterfv(sampler, pname, param);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glSamplerParameteri(uint sampler, SamplerParameterI pname, int param)
		{
			internalGLES.glSamplerParameteri(sampler, pname, param);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static unsafe void glSamplerParameterIiv(uint sampler, SamplerParameterI pname, int* param)
		{
			internalGLES.glSamplerParameterIiv(sampler, pname, param);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static unsafe void glSamplerParameterIuiv(uint sampler, SamplerParameterI pname, uint* param)
		{
			internalGLES.glSamplerParameterIuiv(sampler, pname, param);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glSamplerParameteriv(uint sampler, SamplerParameterI pname, int* param)
		{
			internalGLES.glSamplerParameteriv(sampler, pname, param);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glScalef(float x, float y, float z)
		{
			internalGLES.glScalef(x, y, z);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glScalex(int x, int y, int z)
		{
			internalGLES.glScalex(x, y, z);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glScissor(int x, int y, int width, int height)
		{
			internalGLES.glScissor(x, y, width, height);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glShadeModel(ShadingModel mode)
		{
			internalGLES.glShadeModel(mode);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe void glShaderBinary(int count, uint* shaders, ShaderBinaryFormat binaryFormat, IntPtr binary, int length)
		{
			internalGLES.glShaderBinary(count, shaders, binaryFormat, binary, length);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe void glShaderSource(uint shader, int count, [MarshalAs(UnmanagedType.LPStr)] string[] @string, int* length)
		{
			internalGLES.glShaderSource(shader, count, @string, length);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glStencilFunc(StencilFunction func, int @ref, uint mask)
		{
			internalGLES.glStencilFunc(func, @ref, mask);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glStencilFuncSeparate(StencilFaceDirection face, StencilFunction func, int @ref, uint mask)
		{
			internalGLES.glStencilFuncSeparate(face, func, @ref, mask);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glStencilMask(uint mask)
		{
			internalGLES.glStencilMask(mask);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glStencilMaskSeparate(StencilFaceDirection face, uint mask)
		{
			internalGLES.glStencilMaskSeparate(face, mask);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glStencilOp(StencilOp fail, StencilOp zfail, StencilOp zpass)
		{
			internalGLES.glStencilOp(fail, zfail, zpass);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glStencilOpSeparate(StencilFaceDirection face, StencilOp sfail, StencilOp dpfail, StencilOp dppass)
		{
			internalGLES.glStencilOpSeparate(face, sfail, dpfail, dppass);
		}

		#endregion

		#region T:

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static void glTexBuffer(TextureTarget target, SizedInternalFormat internalformat, uint buffer)
		{
			internalGLES.glTexBuffer(target, internalformat, buffer);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static void glTexBufferRange(TextureTarget target, SizedInternalFormat internalformat, uint buffer, IntPtr offset, int size)
		{
			internalGLES.glTexBufferRange(target, internalformat, buffer, offset, size);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glTexCoordPointer(int size, TexCoordPointerType type, int stride, IntPtr pointer)
		{
			internalGLES.glTexCoordPointer(size, type, stride, pointer);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glTexEnvf(TextureEnvTarget target, TextureEnvParameter pname, float param)
		{
			internalGLES.glTexEnvf(target, pname, param);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glTexEnvfv(TextureEnvTarget target, TextureEnvParameter pname, float* @params)
		{
			internalGLES.glTexEnvfv(target, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glTexEnvi(TextureEnvTarget target, TextureEnvParameter pname, int param)
		{
			internalGLES.glTexEnvi(target, pname, param);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glTexEnviv(TextureEnvTarget target, TextureEnvParameter pname, int* @params)
		{
			internalGLES.glTexEnviv(target, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glTexEnvx(TextureEnvTarget target, TextureEnvParameter pname, int param)
		{
			internalGLES.glTexEnvx(target, pname, param);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glTexEnvxv(TextureEnvTarget target, TextureEnvParameter pname, int* @params)
		{
			internalGLES.glTexEnvxv(target, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			internalGLES.glTexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glTexImage3D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			internalGLES.glTexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glTexParameterf(TextureTarget target, TextureParameterName pname, float param)
		{
			internalGLES.glTexParameterf(target, pname, param);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glTexParameterfv(TextureTarget target, TextureParameterName pname, float* @params)
		{
			internalGLES.glTexParameterfv(target, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glTexParameteri(TextureTarget target, TextureParameterName pname, int param)
		{
			internalGLES.glTexParameteri(target, pname, param);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static unsafe void glTexParameterIiv(TextureTarget target, TextureParameterName pname, int* @params)
		{
			internalGLES.glTexParameterIiv(target, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static unsafe void glTexParameterIuiv(TextureTarget target, TextureParameterName pname, uint* @params)
		{
			internalGLES.glTexParameterIuiv(target, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glTexParameteriv(TextureTarget target, TextureParameterName pname, int* @params)
		{
			internalGLES.glTexParameteriv(target, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glTexParameterx(TextureTarget target, GetTextureParameter pname, int param)
		{
			internalGLES.glTexParameterx(target, pname, param);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static unsafe void glTexParameterxv(TextureTarget target, GetTextureParameter pname, int* @params)
		{
			internalGLES.glTexParameterxv(target, pname, @params);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glTexStorage2D(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height)
		{
			internalGLES.glTexStorage2D(target, levels, internalformat, width, height);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static void glTexStorage2DMultisample(TextureTarget target, int samples, SizedInternalFormat internalformat, int width, int height, Boolean fixedsamplelocations)
		{
			internalGLES.glTexStorage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glTexStorage3D(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height, int depth)
		{
			internalGLES.glTexStorage3D(target, levels, internalformat, width, height, depth);
		}

		///<sumary> Available from OpenGL|ES version 3.2</sumary>
		public static void glTexStorage3DMultisample(TextureTarget target, int samples, SizedInternalFormat internalformat, int width, int height, int depth, Boolean fixedsamplelocations)
		{
			internalGLES.glTexStorage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, IntPtr pixels)
		{
			internalGLES.glTexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels)
		{
			internalGLES.glTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glTransformFeedbackVaryings(uint program, int count, [MarshalAs(UnmanagedType.LPStr)] string[] varyings, TransformFeedbackBufferMode bufferMode)
		{
			internalGLES.glTransformFeedbackVaryings(program, count, varyings, bufferMode);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glTranslatef(float x, float y, float z)
		{
			internalGLES.glTranslatef(x, y, z);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glTranslatex(int x, int y, int z)
		{
			internalGLES.glTranslatex(x, y, z);
		}

		#endregion

		#region U:

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glUniform1f(int location, float v0)
		{
			internalGLES.glUniform1f(location, v0);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe void glUniform1fv(int location, int count, float* value)
		{
			internalGLES.glUniform1fv(location, count, value);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glUniform1i(int location, int v0)
		{
			internalGLES.glUniform1i(location, v0);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe void glUniform1iv(int location, int count, int* value)
		{
			internalGLES.glUniform1iv(location, count, value);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glUniform1ui(int location, uint v0)
		{
			internalGLES.glUniform1ui(location, v0);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glUniform1uiv(int location, int count, uint* value)
		{
			internalGLES.glUniform1uiv(location, count, value);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glUniform2f(int location, float v0, float v1)
		{
			internalGLES.glUniform2f(location, v0, v1);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe void glUniform2fv(int location, int count, float* value)
		{
			internalGLES.glUniform2fv(location, count, value);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glUniform2i(int location, int v0, int v1)
		{
			internalGLES.glUniform2i(location, v0, v1);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe void glUniform2iv(int location, int count, int* value)
		{
			internalGLES.glUniform2iv(location, count, value);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glUniform2ui(int location, uint v0, uint v1)
		{
			internalGLES.glUniform2ui(location, v0, v1);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glUniform2uiv(int location, int count, uint* value)
		{
			internalGLES.glUniform2uiv(location, count, value);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glUniform3f(int location, float v0, float v1, float v2)
		{
			internalGLES.glUniform3f(location, v0, v1, v2);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe void glUniform3fv(int location, int count, float* value)
		{
			internalGLES.glUniform3fv(location, count, value);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glUniform3i(int location, int v0, int v1, int v2)
		{
			internalGLES.glUniform3i(location, v0, v1, v2);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe void glUniform3iv(int location, int count, int* value)
		{
			internalGLES.glUniform3iv(location, count, value);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glUniform3ui(int location, uint v0, uint v1, uint v2)
		{
			internalGLES.glUniform3ui(location, v0, v1, v2);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glUniform3uiv(int location, int count, uint* value)
		{
			internalGLES.glUniform3uiv(location, count, value);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glUniform4f(int location, float v0, float v1, float v2, float v3)
		{
			internalGLES.glUniform4f(location, v0, v1, v2, v3);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe void glUniform4fv(int location, int count, float* value)
		{
			internalGLES.glUniform4fv(location, count, value);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glUniform4i(int location, int v0, int v1, int v2, int v3)
		{
			internalGLES.glUniform4i(location, v0, v1, v2, v3);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe void glUniform4iv(int location, int count, int* value)
		{
			internalGLES.glUniform4iv(location, count, value);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glUniform4ui(int location, uint v0, uint v1, uint v2, uint v3)
		{
			internalGLES.glUniform4ui(location, v0, v1, v2, v3);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glUniform4uiv(int location, int count, uint* value)
		{
			internalGLES.glUniform4uiv(location, count, value);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glUniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding)
		{
			internalGLES.glUniformBlockBinding(program, uniformBlockIndex, uniformBlockBinding);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe void glUniformMatrix2fv(int location, int count, Boolean transpose, float* value)
		{
			internalGLES.glUniformMatrix2fv(location, count, transpose, value);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glUniformMatrix2x3fv(int location, int count, Boolean transpose, float* value)
		{
			internalGLES.glUniformMatrix2x3fv(location, count, transpose, value);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glUniformMatrix2x4fv(int location, int count, Boolean transpose, float* value)
		{
			internalGLES.glUniformMatrix2x4fv(location, count, transpose, value);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe void glUniformMatrix3fv(int location, int count, Boolean transpose, float* value)
		{
			internalGLES.glUniformMatrix3fv(location, count, transpose, value);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glUniformMatrix3x2fv(int location, int count, Boolean transpose, float* value)
		{
			internalGLES.glUniformMatrix3x2fv(location, count, transpose, value);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glUniformMatrix3x4fv(int location, int count, Boolean transpose, float* value)
		{
			internalGLES.glUniformMatrix3x4fv(location, count, transpose, value);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe void glUniformMatrix4fv(int location, int count, Boolean transpose, float* value)
		{
			internalGLES.glUniformMatrix4fv(location, count, transpose, value);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glUniformMatrix4x2fv(int location, int count, Boolean transpose, float* value)
		{
			internalGLES.glUniformMatrix4x2fv(location, count, transpose, value);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glUniformMatrix4x3fv(int location, int count, Boolean transpose, float* value)
		{
			internalGLES.glUniformMatrix4x3fv(location, count, transpose, value);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static bool glUnmapBuffer(BufferTargetARB target)
		{
			return internalGLES.glUnmapBuffer(target);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glUseProgram(uint program)
		{
			internalGLES.glUseProgram(program);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static void glUseProgramStages(uint pipeline, UseProgramStageMask stages, uint program)
		{
			internalGLES.glUseProgramStages(pipeline, stages, program);
		}

		#endregion

		#region V:

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glValidateProgram(uint program)
		{
			internalGLES.glValidateProgram(program);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static void glValidateProgramPipeline(uint pipeline)
		{
			internalGLES.glValidateProgramPipeline(pipeline);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glVertexAttrib1f(uint index, float x)
		{
			internalGLES.glVertexAttrib1f(index, x);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe void glVertexAttrib1fv(uint index, float* v)
		{
			internalGLES.glVertexAttrib1fv(index, v);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glVertexAttrib2f(uint index, float x, float y)
		{
			internalGLES.glVertexAttrib2f(index, x, y);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe void glVertexAttrib2fv(uint index, float* v)
		{
			internalGLES.glVertexAttrib2fv(index, v);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glVertexAttrib3f(uint index, float x, float y, float z)
		{
			internalGLES.glVertexAttrib3f(index, x, y, z);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe void glVertexAttrib3fv(uint index, float* v)
		{
			internalGLES.glVertexAttrib3fv(index, v);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glVertexAttrib4f(uint index, float x, float y, float z, float w)
		{
			internalGLES.glVertexAttrib4f(index, x, y, z, w);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static unsafe void glVertexAttrib4fv(uint index, float* v)
		{
			internalGLES.glVertexAttrib4fv(index, v);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static void glVertexAttribBinding(uint attribindex, uint bindingindex)
		{
			internalGLES.glVertexAttribBinding(attribindex, bindingindex);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glVertexAttribDivisor(uint index, uint divisor)
		{
			internalGLES.glVertexAttribDivisor(index, divisor);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static void glVertexAttribFormat(uint attribindex, int size, VertexAttribType type, Boolean normalized, uint relativeoffset)
		{
			internalGLES.glVertexAttribFormat(attribindex, size, type, normalized, relativeoffset);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glVertexAttribI4i(uint index, int x, int y, int z, int w)
		{
			internalGLES.glVertexAttribI4i(index, x, y, z, w);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glVertexAttribI4iv(uint index, int* v)
		{
			internalGLES.glVertexAttribI4iv(index, v);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glVertexAttribI4ui(uint index, uint x, uint y, uint z, uint w)
		{
			internalGLES.glVertexAttribI4ui(index, x, y, z, w);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static unsafe void glVertexAttribI4uiv(uint index, uint* v)
		{
			internalGLES.glVertexAttribI4uiv(index, v);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static void glVertexAttribIFormat(uint attribindex, int size, VertexAttribIType type, uint relativeoffset)
		{
			internalGLES.glVertexAttribIFormat(attribindex, size, type, relativeoffset);
		}

		///<sumary> Available from OpenGL|ES version 3.0</sumary>
		public static void glVertexAttribIPointer(uint index, int size, VertexAttribIType type, int stride, IntPtr pointer)
		{
			internalGLES.glVertexAttribIPointer(index, size, type, stride, pointer);
		}

		///<sumary> Available from OpenGL|ES version 2.0</sumary>
		public static void glVertexAttribPointer(uint index, int size, VertexAttribPointerType type, Boolean normalized, int stride, IntPtr pointer)
		{
			internalGLES.glVertexAttribPointer(index, size, type, normalized, stride, pointer);
		}

		///<sumary> Available from OpenGL|ES version 3.1</sumary>
		public static void glVertexBindingDivisor(uint bindingindex, uint divisor)
		{
			internalGLES.glVertexBindingDivisor(bindingindex, divisor);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glVertexPointer(int size, VertexPointerType type, int stride, IntPtr pointer)
		{
			internalGLES.glVertexPointer(size, type, stride, pointer);
		}

		///<sumary> Available from OpenGL|ES version 1.0</sumary>
		public static void glViewport(int x, int y, int width, int height)
		{
			internalGLES.glViewport(x, y, width, height);
		}

		#endregion

		#region W:

		