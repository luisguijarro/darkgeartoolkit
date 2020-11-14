// OpenGL Extension's Methods.
// File Created with OpenGL Parser 3.
// Developed by Luis Guijarro Pérez.

using System;

namespace dgtk.OpenGL
{
	public static partial class GL
	{
		public static class _3DFX
		{
			public static void glTbufferMask3DFX(uint mask)
			{
				internalGL.glTbufferMask3DFX(mask);
			}
		}

		public static class AMD
		{
			public static void glBlendEquationIndexedAMD(uint buf, BlendEquationModeEXT mode)
			{
				internalGL.glBlendEquationIndexedAMD(buf, mode);
			}

			public static void glBlendEquationSeparateIndexedAMD(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha)
			{
				internalGL.glBlendEquationSeparateIndexedAMD(buf, modeRGB, modeAlpha);
			}

			public static void glBlendFuncIndexedAMD(uint buf, uint src, uint dst)
			{
				internalGL.glBlendFuncIndexedAMD(buf, src, dst);
			}

			public static void glBlendFuncSeparateIndexedAMD(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha)
			{
				internalGL.glBlendFuncSeparateIndexedAMD(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
			}

			public static void glDebugMessageCallbackAMD(Delegate callback, IntPtr userParam)
			{
				internalGL.glDebugMessageCallbackAMD(callback, userParam);
			}

			public static unsafe void glDebugMessageEnableAMD(uint category, DebugSeverity severity, int count, uint* ids, Boolean enabled)
			{
				internalGL.glDebugMessageEnableAMD(category, severity, count, ids, enabled);
			}

			public static unsafe void glDebugMessageInsertAMD(uint category, DebugSeverity severity, uint id, int length, sbyte* buf)
			{
				internalGL.glDebugMessageInsertAMD(category, severity, id, length, buf);
			}

			public static unsafe void glDeleteNamesAMD(uint identifier, uint num, uint* names)
			{
				internalGL.glDeleteNamesAMD(identifier, num, names);
			}

			public static unsafe void glFramebufferSamplePositionsfvAMD(FramebufferTarget target, uint numsamples, uint pixelindex, float* values)
			{
				internalGL.glFramebufferSamplePositionsfvAMD(target, numsamples, pixelindex, values);
			}

			public static unsafe void glGenNamesAMD(uint identifier, uint num, uint* names)
			{
				internalGL.glGenNamesAMD(identifier, num, names);
			}

			public static unsafe uint glGetDebugMessageLogAMD(uint count, int bufSize, uint* categories, DebugSeverity* severities, uint* ids, int* lengths, sbyte* message)
			{
				return internalGL.glGetDebugMessageLogAMD(count, bufSize, categories, severities, ids, lengths, message);
			}

			public static unsafe void glGetFramebufferParameterfvAMD(FramebufferTarget target, FramebufferAttachmentParameterName pname, uint numsamples, uint pixelindex, int size, float* values)
			{
				internalGL.glGetFramebufferParameterfvAMD(target, pname, numsamples, pixelindex, size, values);
			}

			public static unsafe void glGetNamedFramebufferParameterfvAMD(uint framebuffer, uint pname, uint numsamples, uint pixelindex, int size, float* values)
			{
				internalGL.glGetNamedFramebufferParameterfvAMD(framebuffer, pname, numsamples, pixelindex, size, values);
			}

			public static unsafe void glGetUniformi64vNV(uint program, int location, long* @params)
			{
				internalGL.glGetUniformi64vNV(program, location, @params);
			}

			public static unsafe void glGetUniformui64vNV(uint program, int location, ulong* @params)
			{
				internalGL.glGetUniformui64vNV(program, location, @params);
			}

			public static bool glIsNameAMD(uint identifier, uint name)
			{
				return internalGL.glIsNameAMD(identifier, name);
			}

			public static void glMultiDrawArraysIndirectAMD(PrimitiveType mode, IntPtr indirect, int primcount, int stride)
			{
				internalGL.glMultiDrawArraysIndirectAMD(mode, indirect, primcount, stride);
			}

			public static void glMultiDrawElementsIndirectAMD(PrimitiveType mode, DrawElementsType type, IntPtr indirect, int primcount, int stride)
			{
				internalGL.glMultiDrawElementsIndirectAMD(mode, type, indirect, primcount, stride);
			}

			public static unsafe void glNamedFramebufferSamplePositionsfvAMD(uint framebuffer, uint numsamples, uint pixelindex, float* values)
			{
				internalGL.glNamedFramebufferSamplePositionsfvAMD(framebuffer, numsamples, pixelindex, values);
			}

			public static void glProgramUniform1i64NV(uint program, int location, long x)
			{
				internalGL.glProgramUniform1i64NV(program, location, x);
			}

			public static unsafe void glProgramUniform1i64vNV(uint program, int location, int count, long* value)
			{
				internalGL.glProgramUniform1i64vNV(program, location, count, value);
			}

			public static void glProgramUniform1ui64NV(uint program, int location, ulong x)
			{
				internalGL.glProgramUniform1ui64NV(program, location, x);
			}

			public static unsafe void glProgramUniform1ui64vNV(uint program, int location, int count, ulong* value)
			{
				internalGL.glProgramUniform1ui64vNV(program, location, count, value);
			}

			public static void glProgramUniform2i64NV(uint program, int location, long x, long y)
			{
				internalGL.glProgramUniform2i64NV(program, location, x, y);
			}

			public static unsafe void glProgramUniform2i64vNV(uint program, int location, int count, long* value)
			{
				internalGL.glProgramUniform2i64vNV(program, location, count, value);
			}

			public static void glProgramUniform2ui64NV(uint program, int location, ulong x, ulong y)
			{
				internalGL.glProgramUniform2ui64NV(program, location, x, y);
			}

			public static unsafe void glProgramUniform2ui64vNV(uint program, int location, int count, ulong* value)
			{
				internalGL.glProgramUniform2ui64vNV(program, location, count, value);
			}

			public static void glProgramUniform3i64NV(uint program, int location, long x, long y, long z)
			{
				internalGL.glProgramUniform3i64NV(program, location, x, y, z);
			}

			public static unsafe void glProgramUniform3i64vNV(uint program, int location, int count, long* value)
			{
				internalGL.glProgramUniform3i64vNV(program, location, count, value);
			}

			public static void glProgramUniform3ui64NV(uint program, int location, ulong x, ulong y, ulong z)
			{
				internalGL.glProgramUniform3ui64NV(program, location, x, y, z);
			}

			public static unsafe void glProgramUniform3ui64vNV(uint program, int location, int count, ulong* value)
			{
				internalGL.glProgramUniform3ui64vNV(program, location, count, value);
			}

			public static void glProgramUniform4i64NV(uint program, int location, long x, long y, long z, long w)
			{
				internalGL.glProgramUniform4i64NV(program, location, x, y, z, w);
			}

			public static unsafe void glProgramUniform4i64vNV(uint program, int location, int count, long* value)
			{
				internalGL.glProgramUniform4i64vNV(program, location, count, value);
			}

			public static void glProgramUniform4ui64NV(uint program, int location, ulong x, ulong y, ulong z, ulong w)
			{
				internalGL.glProgramUniform4ui64NV(program, location, x, y, z, w);
			}

			public static unsafe void glProgramUniform4ui64vNV(uint program, int location, int count, ulong* value)
			{
				internalGL.glProgramUniform4ui64vNV(program, location, count, value);
			}

			public static void glQueryObjectParameteruiAMD(QueryTarget target, uint id, uint pname, OcclusionQueryEventMaskAMD param)
			{
				internalGL.glQueryObjectParameteruiAMD(target, id, pname, param);
			}

			public static unsafe void glSetMultisamplefvAMD(uint pname, uint index, float* val)
			{
				internalGL.glSetMultisamplefvAMD(pname, index, val);
			}

			public static void glStencilOpValueAMD(StencilFaceDirection face, uint value)
			{
				internalGL.glStencilOpValueAMD(face, value);
			}

			public static void glTessellationFactorAMD(float factor)
			{
				internalGL.glTessellationFactorAMD(factor);
			}

			public static void glTessellationModeAMD(uint mode)
			{
				internalGL.glTessellationModeAMD(mode);
			}

			public static void glTexStorageSparseAMD(TextureTarget target, InternalFormat internalFormat, int width, int height, int depth, int layers, TextureStorageMaskAMD flags)
			{
				internalGL.glTexStorageSparseAMD(target, internalFormat, width, height, depth, layers, flags);
			}

			public static void glTextureStorageSparseAMD(uint texture, uint target, InternalFormat internalFormat, int width, int height, int depth, int layers, TextureStorageMaskAMD flags)
			{
				internalGL.glTextureStorageSparseAMD(texture, target, internalFormat, width, height, depth, layers, flags);
			}

			public static void glUniform1i64NV(int location, long x)
			{
				internalGL.glUniform1i64NV(location, x);
			}

			public static unsafe void glUniform1i64vNV(int location, int count, long* value)
			{
				internalGL.glUniform1i64vNV(location, count, value);
			}

			public static void glUniform1ui64NV(int location, ulong x)
			{
				internalGL.glUniform1ui64NV(location, x);
			}

			public static unsafe void glUniform1ui64vNV(int location, int count, ulong* value)
			{
				internalGL.glUniform1ui64vNV(location, count, value);
			}

			public static void glUniform2i64NV(int location, long x, long y)
			{
				internalGL.glUniform2i64NV(location, x, y);
			}

			public static unsafe void glUniform2i64vNV(int location, int count, long* value)
			{
				internalGL.glUniform2i64vNV(location, count, value);
			}

			public static void glUniform2ui64NV(int location, ulong x, ulong y)
			{
				internalGL.glUniform2ui64NV(location, x, y);
			}

			public static unsafe void glUniform2ui64vNV(int location, int count, ulong* value)
			{
				internalGL.glUniform2ui64vNV(location, count, value);
			}

			public static void glUniform3i64NV(int location, long x, long y, long z)
			{
				internalGL.glUniform3i64NV(location, x, y, z);
			}

			public static unsafe void glUniform3i64vNV(int location, int count, long* value)
			{
				internalGL.glUniform3i64vNV(location, count, value);
			}

			public static void glUniform3ui64NV(int location, ulong x, ulong y, ulong z)
			{
				internalGL.glUniform3ui64NV(location, x, y, z);
			}

			public static unsafe void glUniform3ui64vNV(int location, int count, ulong* value)
			{
				internalGL.glUniform3ui64vNV(location, count, value);
			}

			public static void glUniform4i64NV(int location, long x, long y, long z, long w)
			{
				internalGL.glUniform4i64NV(location, x, y, z, w);
			}

			public static unsafe void glUniform4i64vNV(int location, int count, long* value)
			{
				internalGL.glUniform4i64vNV(location, count, value);
			}

			public static void glUniform4ui64NV(int location, ulong x, ulong y, ulong z, ulong w)
			{
				internalGL.glUniform4ui64NV(location, x, y, z, w);
			}

			public static unsafe void glUniform4ui64vNV(int location, int count, ulong* value)
			{
				internalGL.glUniform4ui64vNV(location, count, value);
			}

			public static void glVertexAttribParameteriAMD(uint index, uint pname, int param)
			{
				internalGL.glVertexAttribParameteriAMD(index, pname, param);
			}
		}

		public static class APPLE
		{
			public static void glBindVertexArrayAPPLE(uint array)
			{
				internalGL.glBindVertexArrayAPPLE(array);
			}

			public static void glBufferParameteriAPPLE(uint target, uint pname, int param)
			{
				internalGL.glBufferParameteriAPPLE(target, pname, param);
			}

			public static unsafe void glDeleteFencesAPPLE(int n, uint* fences)
			{
				internalGL.glDeleteFencesAPPLE(n, fences);
			}

			public static unsafe void glDeleteVertexArraysAPPLE(int n, uint* arrays)
			{
				internalGL.glDeleteVertexArraysAPPLE(n, arrays);
			}

			public static void glDisableVertexAttribAPPLE(uint index, uint pname)
			{
				internalGL.glDisableVertexAttribAPPLE(index, pname);
			}

			public static void glDrawElementArrayAPPLE(PrimitiveType mode, int first, int count)
			{
				internalGL.glDrawElementArrayAPPLE(mode, first, count);
			}

			public static void glDrawRangeElementArrayAPPLE(PrimitiveType mode, uint start, uint end, int first, int count)
			{
				internalGL.glDrawRangeElementArrayAPPLE(mode, start, end, first, count);
			}

			public static void glElementPointerAPPLE(ElementPointerTypeATI type, IntPtr pointer)
			{
				internalGL.glElementPointerAPPLE(type, pointer);
			}

			public static void glEnableVertexAttribAPPLE(uint index, uint pname)
			{
				internalGL.glEnableVertexAttribAPPLE(index, pname);
			}

			public static void glFinishFenceAPPLE(uint fence)
			{
				internalGL.glFinishFenceAPPLE(fence);
			}

			public static void glFinishObjectAPPLE(ObjectTypeAPPLE @object, int name)
			{
				internalGL.glFinishObjectAPPLE(@object, name);
			}

			public static void glFlushMappedBufferRangeAPPLE(BufferTargetARB target, IntPtr offset, int size)
			{
				internalGL.glFlushMappedBufferRangeAPPLE(target, offset, size);
			}

			public static void glFlushVertexArrayRangeAPPLE(int length, IntPtr pointer)
			{
				internalGL.glFlushVertexArrayRangeAPPLE(length, pointer);
			}

			public static unsafe void glGenFencesAPPLE(int n, uint* fences)
			{
				internalGL.glGenFencesAPPLE(n, fences);
			}

			public static unsafe void glGenVertexArraysAPPLE(int n, uint* arrays)
			{
				internalGL.glGenVertexArraysAPPLE(n, arrays);
			}

			public static unsafe void glGetObjectParameterivAPPLE(uint objectType, uint name, uint pname, int* @params)
			{
				internalGL.glGetObjectParameterivAPPLE(objectType, name, pname, @params);
			}

			public static void glGetTexParameterPointervAPPLE(uint target, uint pname, IntPtr @params)
			{
				internalGL.glGetTexParameterPointervAPPLE(target, pname, @params);
			}

			public static bool glIsFenceAPPLE(uint fence)
			{
				return internalGL.glIsFenceAPPLE(fence);
			}

			public static bool glIsVertexArrayAPPLE(uint array)
			{
				return internalGL.glIsVertexArrayAPPLE(array);
			}

			public static bool glIsVertexAttribEnabledAPPLE(uint index, uint pname)
			{
				return internalGL.glIsVertexAttribEnabledAPPLE(index, pname);
			}

			public static unsafe void glMapVertexAttrib1dAPPLE(uint index, uint size, double u1, double u2, int stride, int order, double* points)
			{
				internalGL.glMapVertexAttrib1dAPPLE(index, size, u1, u2, stride, order, points);
			}

			public static unsafe void glMapVertexAttrib1fAPPLE(uint index, uint size, float u1, float u2, int stride, int order, float* points)
			{
				internalGL.glMapVertexAttrib1fAPPLE(index, size, u1, u2, stride, order, points);
			}

			public static unsafe void glMapVertexAttrib2dAPPLE(uint index, uint size, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double* points)
			{
				internalGL.glMapVertexAttrib2dAPPLE(index, size, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
			}

			public static unsafe void glMapVertexAttrib2fAPPLE(uint index, uint size, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float* points)
			{
				internalGL.glMapVertexAttrib2fAPPLE(index, size, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
			}

			public static unsafe void glMultiDrawElementArrayAPPLE(PrimitiveType mode, int* first, int* count, int primcount)
			{
				internalGL.glMultiDrawElementArrayAPPLE(mode, first, count, primcount);
			}

			public static unsafe void glMultiDrawRangeElementArrayAPPLE(PrimitiveType mode, uint start, uint end, int* first, int* count, int primcount)
			{
				internalGL.glMultiDrawRangeElementArrayAPPLE(mode, start, end, first, count, primcount);
			}

			public static uint glObjectPurgeableAPPLE(uint objectType, uint name, uint option)
			{
				return internalGL.glObjectPurgeableAPPLE(objectType, name, option);
			}

			public static uint glObjectUnpurgeableAPPLE(uint objectType, uint name, uint option)
			{
				return internalGL.glObjectUnpurgeableAPPLE(objectType, name, option);
			}

			public static void glSetFenceAPPLE(uint fence)
			{
				internalGL.glSetFenceAPPLE(fence);
			}

			public static bool glTestFenceAPPLE(uint fence)
			{
				return internalGL.glTestFenceAPPLE(fence);
			}

			public static bool glTestObjectAPPLE(ObjectTypeAPPLE @object, uint name)
			{
				return internalGL.glTestObjectAPPLE(@object, name);
			}

			public static void glTextureRangeAPPLE(uint target, int length, IntPtr pointer)
			{
				internalGL.glTextureRangeAPPLE(target, length, pointer);
			}

			public static void glVertexArrayParameteriAPPLE(VertexArrayPNameAPPLE pname, int param)
			{
				internalGL.glVertexArrayParameteriAPPLE(pname, param);
			}

			public static void glVertexArrayRangeAPPLE(int length, IntPtr pointer)
			{
				internalGL.glVertexArrayRangeAPPLE(length, pointer);
			}
		}

		public static class ARB
		{
			public static void glActiveTextureARB(TextureUnit texture)
			{
				internalGL.glActiveTextureARB(texture);
			}

			public static void glAttachObjectARB(uint containerObj, uint obj)
			{
				internalGL.glAttachObjectARB(containerObj, obj);
			}

			public static void glBeginQueryARB(QueryTarget target, uint id)
			{
				internalGL.glBeginQueryARB(target, id);
			}

			public static unsafe void glBindAttribLocationARB(uint programObj, uint index, sbyte* name)
			{
				internalGL.glBindAttribLocationARB(programObj, index, name);
			}

			public static void glBindBufferARB(BufferTargetARB target, uint buffer)
			{
				internalGL.glBindBufferARB(target, buffer);
			}

			public static void glBindProgramARB(ProgramTarget target, uint program)
			{
				internalGL.glBindProgramARB(target, program);
			}

			public static void glBufferDataARB(BufferTargetARB target, int size, IntPtr data, BufferUsageARB usage)
			{
				internalGL.glBufferDataARB(target, size, data, usage);
			}

			public static void glBufferSubDataARB(BufferTargetARB target, IntPtr offset, int size, IntPtr data)
			{
				internalGL.glBufferSubDataARB(target, offset, size, data);
			}

			public static void glClampColorARB(ClampColorTargetARB target, ClampColorModeARB clamp)
			{
				internalGL.glClampColorARB(target, clamp);
			}

			public static void glClientActiveTextureARB(TextureUnit texture)
			{
				internalGL.glClientActiveTextureARB(texture);
			}

			public static void glCompileShaderARB(uint shaderObj)
			{
				internalGL.glCompileShaderARB(shaderObj);
			}

			public static void glCompressedTexImage1DARB(TextureTarget target, int level, InternalFormat internalformat, int width, int border, int imageSize, IntPtr data)
			{
				internalGL.glCompressedTexImage1DARB(target, level, internalformat, width, border, imageSize, data);
			}

			public static void glCompressedTexImage2DARB(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, IntPtr data)
			{
				internalGL.glCompressedTexImage2DARB(target, level, internalformat, width, height, border, imageSize, data);
			}

			public static void glCompressedTexImage3DARB(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data)
			{
				internalGL.glCompressedTexImage3DARB(target, level, internalformat, width, height, depth, border, imageSize, data);
			}

			public static void glCompressedTexSubImage1DARB(TextureTarget target, int level, int xoffset, int width, PixelFormat format, int imageSize, IntPtr data)
			{
				internalGL.glCompressedTexSubImage1DARB(target, level, xoffset, width, format, imageSize, data);
			}

			public static void glCompressedTexSubImage2DARB(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, IntPtr data)
			{
				internalGL.glCompressedTexSubImage2DARB(target, level, xoffset, yoffset, width, height, format, imageSize, data);
			}

			public static void glCompressedTexSubImage3DARB(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, IntPtr data)
			{
				internalGL.glCompressedTexSubImage3DARB(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
			}

			public static uint glCreateProgramObjectARB()
			{
				return internalGL.glCreateProgramObjectARB();
			}

			public static uint glCreateShaderObjectARB(ShaderType shaderType)
			{
				return internalGL.glCreateShaderObjectARB(shaderType);
			}

			public static void glCurrentPaletteMatrixARB(int index)
			{
				internalGL.glCurrentPaletteMatrixARB(index);
			}

			public static unsafe void glDeleteBuffersARB(int n, uint* buffers)
			{
				internalGL.glDeleteBuffersARB(n, buffers);
			}

			public static void glDeleteObjectARB(uint obj)
			{
				internalGL.glDeleteObjectARB(obj);
			}

			public static unsafe void glDeleteProgramsARB(int n, uint* programs)
			{
				internalGL.glDeleteProgramsARB(n, programs);
			}

			public static unsafe void glDeleteQueriesARB(int n, uint* ids)
			{
				internalGL.glDeleteQueriesARB(n, ids);
			}

			public static void glDetachObjectARB(uint containerObj, uint attachedObj)
			{
				internalGL.glDetachObjectARB(containerObj, attachedObj);
			}

			public static void glDisableVertexAttribArrayARB(uint index)
			{
				internalGL.glDisableVertexAttribArrayARB(index);
			}

			public static unsafe void glDrawBuffersARB(int n, DrawBufferMode* bufs)
			{
				internalGL.glDrawBuffersARB(n, bufs);
			}

			public static void glEnableVertexAttribArrayARB(uint index)
			{
				internalGL.glEnableVertexAttribArrayARB(index);
			}

			public static void glEndQueryARB(QueryTarget target)
			{
				internalGL.glEndQueryARB(target);
			}

			public static unsafe void glGenBuffersARB(int n, uint* buffers)
			{
				internalGL.glGenBuffersARB(n, buffers);
			}

			public static unsafe void glGenProgramsARB(int n, uint* programs)
			{
				internalGL.glGenProgramsARB(n, programs);
			}

			public static unsafe void glGenQueriesARB(int n, uint* ids)
			{
				internalGL.glGenQueriesARB(n, ids);
			}

			public static unsafe void glGetActiveAttribARB(uint programObj, uint index, int maxLength, int* length, int* size, AttributeType* type, sbyte* name)
			{
				internalGL.glGetActiveAttribARB(programObj, index, maxLength, length, size, type, name);
			}

			public static unsafe void glGetActiveUniformARB(uint programObj, uint index, int maxLength, int* length, int* size, UniformType* type, sbyte* name)
			{
				internalGL.glGetActiveUniformARB(programObj, index, maxLength, length, size, type, name);
			}

			public static unsafe void glGetAttachedObjectsARB(uint containerObj, int maxCount, int* count, uint* obj)
			{
				internalGL.glGetAttachedObjectsARB(containerObj, maxCount, count, obj);
			}

			public static unsafe int glGetAttribLocationARB(uint programObj, sbyte* name)
			{
				return internalGL.glGetAttribLocationARB(programObj, name);
			}

			public static unsafe void glGetBufferParameterivARB(BufferTargetARB target, BufferPNameARB pname, int* @params)
			{
				internalGL.glGetBufferParameterivARB(target, pname, @params);
			}

			public static void glGetBufferPointervARB(BufferTargetARB target, BufferPointerNameARB pname, IntPtr @params)
			{
				internalGL.glGetBufferPointervARB(target, pname, @params);
			}

			public static void glGetBufferSubDataARB(BufferTargetARB target, IntPtr offset, int size, IntPtr data)
			{
				internalGL.glGetBufferSubDataARB(target, offset, size, data);
			}

			public static void glGetCompressedTexImageARB(TextureTarget target, int level, IntPtr img)
			{
				internalGL.glGetCompressedTexImageARB(target, level, img);
			}

			public static uint glGetHandleARB(uint pname)
			{
				return internalGL.glGetHandleARB(pname);
			}

			public static unsafe void glGetInfoLogARB(uint obj, int maxLength, int* length, sbyte* infoLog)
			{
				internalGL.glGetInfoLogARB(obj, maxLength, length, infoLog);
			}

			public static unsafe void glGetObjectParameterfvARB(uint obj, uint pname, float* @params)
			{
				internalGL.glGetObjectParameterfvARB(obj, pname, @params);
			}

			public static unsafe void glGetObjectParameterivARB(uint obj, uint pname, int* @params)
			{
				internalGL.glGetObjectParameterivARB(obj, pname, @params);
			}

			public static unsafe void glGetProgramEnvParameterdvARB(ProgramTarget target, uint index, double* @params)
			{
				internalGL.glGetProgramEnvParameterdvARB(target, index, @params);
			}

			public static unsafe void glGetProgramEnvParameterfvARB(ProgramTarget target, uint index, float* @params)
			{
				internalGL.glGetProgramEnvParameterfvARB(target, index, @params);
			}

			public static unsafe void glGetProgramivARB(ProgramTarget target, ProgramPropertyARB pname, int* @params)
			{
				internalGL.glGetProgramivARB(target, pname, @params);
			}

			public static unsafe void glGetProgramLocalParameterdvARB(ProgramTarget target, uint index, double* @params)
			{
				internalGL.glGetProgramLocalParameterdvARB(target, index, @params);
			}

			public static unsafe void glGetProgramLocalParameterfvARB(ProgramTarget target, uint index, float* @params)
			{
				internalGL.glGetProgramLocalParameterfvARB(target, index, @params);
			}

			public static void glGetProgramStringARB(ProgramTarget target, ProgramStringProperty pname, IntPtr @string)
			{
				internalGL.glGetProgramStringARB(target, pname, @string);
			}

			public static unsafe void glGetQueryivARB(QueryTarget target, QueryParameterName pname, int* @params)
			{
				internalGL.glGetQueryivARB(target, pname, @params);
			}

			public static unsafe void glGetQueryObjectivARB(uint id, QueryObjectParameterName pname, int* @params)
			{
				internalGL.glGetQueryObjectivARB(id, pname, @params);
			}

			public static unsafe void glGetQueryObjectuivARB(uint id, QueryObjectParameterName pname, uint* @params)
			{
				internalGL.glGetQueryObjectuivARB(id, pname, @params);
			}

			public static unsafe void glGetShaderSourceARB(uint obj, int maxLength, int* length, sbyte* source)
			{
				internalGL.glGetShaderSourceARB(obj, maxLength, length, source);
			}

			public static unsafe void glGetUniformfvARB(uint programObj, int location, float* @params)
			{
				internalGL.glGetUniformfvARB(programObj, location, @params);
			}

			public static unsafe void glGetUniformivARB(uint programObj, int location, int* @params)
			{
				internalGL.glGetUniformivARB(programObj, location, @params);
			}

			public static unsafe int glGetUniformLocationARB(uint programObj, sbyte* name)
			{
				return internalGL.glGetUniformLocationARB(programObj, name);
			}

			public static unsafe void glGetVertexAttribdvARB(uint index, VertexAttribPropertyARB pname, double* @params)
			{
				internalGL.glGetVertexAttribdvARB(index, pname, @params);
			}

			public static unsafe void glGetVertexAttribfvARB(uint index, VertexAttribPropertyARB pname, float* @params)
			{
				internalGL.glGetVertexAttribfvARB(index, pname, @params);
			}

			public static unsafe void glGetVertexAttribivARB(uint index, VertexAttribPropertyARB pname, int* @params)
			{
				internalGL.glGetVertexAttribivARB(index, pname, @params);
			}

			public static void glGetVertexAttribPointervARB(uint index, VertexAttribPointerPropertyARB pname, IntPtr pointer)
			{
				internalGL.glGetVertexAttribPointervARB(index, pname, pointer);
			}

			public static bool glIsBufferARB(uint buffer)
			{
				return internalGL.glIsBufferARB(buffer);
			}

			public static bool glIsProgramARB(uint program)
			{
				return internalGL.glIsProgramARB(program);
			}

			public static bool glIsQueryARB(uint id)
			{
				return internalGL.glIsQueryARB(id);
			}

			public static void glLinkProgramARB(uint programObj)
			{
				internalGL.glLinkProgramARB(programObj);
			}

			public static unsafe void glLoadTransposeMatrixdARB(double* m)
			{
				internalGL.glLoadTransposeMatrixdARB(m);
			}

			public static unsafe void glLoadTransposeMatrixfARB(float* m)
			{
				internalGL.glLoadTransposeMatrixfARB(m);
			}

			public static unsafe IntPtr* glMapBufferARB(BufferTargetARB target, BufferAccessARB access)
			{
				return internalGL.glMapBufferARB(target, access);
			}

			public static void glMatrixIndexPointerARB(int size, MatrixIndexPointerTypeARB type, int stride, IntPtr pointer)
			{
				internalGL.glMatrixIndexPointerARB(size, type, stride, pointer);
			}

			public static unsafe void glMatrixIndexubvARB(int size, byte* indices)
			{
				internalGL.glMatrixIndexubvARB(size, indices);
			}

			public static unsafe void glMatrixIndexuivARB(int size, uint* indices)
			{
				internalGL.glMatrixIndexuivARB(size, indices);
			}

			public static unsafe void glMatrixIndexusvARB(int size, ushort* indices)
			{
				internalGL.glMatrixIndexusvARB(size, indices);
			}

			public static void glMultiTexCoord1dARB(TextureUnit target, double s)
			{
				internalGL.glMultiTexCoord1dARB(target, s);
			}

			public static unsafe void glMultiTexCoord1dvARB(TextureUnit target, double* v)
			{
				internalGL.glMultiTexCoord1dvARB(target, v);
			}

			public static void glMultiTexCoord1fARB(TextureUnit target, float s)
			{
				internalGL.glMultiTexCoord1fARB(target, s);
			}

			public static unsafe void glMultiTexCoord1fvARB(TextureUnit target, float* v)
			{
				internalGL.glMultiTexCoord1fvARB(target, v);
			}

			public static void glMultiTexCoord1iARB(TextureUnit target, int s)
			{
				internalGL.glMultiTexCoord1iARB(target, s);
			}

			public static unsafe void glMultiTexCoord1ivARB(TextureUnit target, int* v)
			{
				internalGL.glMultiTexCoord1ivARB(target, v);
			}

			public static void glMultiTexCoord1sARB(TextureUnit target, short s)
			{
				internalGL.glMultiTexCoord1sARB(target, s);
			}

			public static unsafe void glMultiTexCoord1svARB(TextureUnit target, short* v)
			{
				internalGL.glMultiTexCoord1svARB(target, v);
			}

			public static void glMultiTexCoord2dARB(TextureUnit target, double s, double t)
			{
				internalGL.glMultiTexCoord2dARB(target, s, t);
			}

			public static unsafe void glMultiTexCoord2dvARB(TextureUnit target, double* v)
			{
				internalGL.glMultiTexCoord2dvARB(target, v);
			}

			public static void glMultiTexCoord2fARB(TextureUnit target, float s, float t)
			{
				internalGL.glMultiTexCoord2fARB(target, s, t);
			}

			public static unsafe void glMultiTexCoord2fvARB(TextureUnit target, float* v)
			{
				internalGL.glMultiTexCoord2fvARB(target, v);
			}

			public static void glMultiTexCoord2iARB(TextureUnit target, int s, int t)
			{
				internalGL.glMultiTexCoord2iARB(target, s, t);
			}

			public static unsafe void glMultiTexCoord2ivARB(TextureUnit target, int* v)
			{
				internalGL.glMultiTexCoord2ivARB(target, v);
			}

			public static void glMultiTexCoord2sARB(TextureUnit target, short s, short t)
			{
				internalGL.glMultiTexCoord2sARB(target, s, t);
			}

			public static unsafe void glMultiTexCoord2svARB(TextureUnit target, short* v)
			{
				internalGL.glMultiTexCoord2svARB(target, v);
			}

			public static void glMultiTexCoord3dARB(TextureUnit target, double s, double t, double r)
			{
				internalGL.glMultiTexCoord3dARB(target, s, t, r);
			}

			public static unsafe void glMultiTexCoord3dvARB(TextureUnit target, double* v)
			{
				internalGL.glMultiTexCoord3dvARB(target, v);
			}

			public static void glMultiTexCoord3fARB(TextureUnit target, float s, float t, float r)
			{
				internalGL.glMultiTexCoord3fARB(target, s, t, r);
			}

			public static unsafe void glMultiTexCoord3fvARB(TextureUnit target, float* v)
			{
				internalGL.glMultiTexCoord3fvARB(target, v);
			}

			public static void glMultiTexCoord3iARB(TextureUnit target, int s, int t, int r)
			{
				internalGL.glMultiTexCoord3iARB(target, s, t, r);
			}

			public static unsafe void glMultiTexCoord3ivARB(TextureUnit target, int* v)
			{
				internalGL.glMultiTexCoord3ivARB(target, v);
			}

			public static void glMultiTexCoord3sARB(TextureUnit target, short s, short t, short r)
			{
				internalGL.glMultiTexCoord3sARB(target, s, t, r);
			}

			public static unsafe void glMultiTexCoord3svARB(TextureUnit target, short* v)
			{
				internalGL.glMultiTexCoord3svARB(target, v);
			}

			public static void glMultiTexCoord4dARB(TextureUnit target, double s, double t, double r, double q)
			{
				internalGL.glMultiTexCoord4dARB(target, s, t, r, q);
			}

			public static unsafe void glMultiTexCoord4dvARB(TextureUnit target, double* v)
			{
				internalGL.glMultiTexCoord4dvARB(target, v);
			}

			public static void glMultiTexCoord4fARB(TextureUnit target, float s, float t, float r, float q)
			{
				internalGL.glMultiTexCoord4fARB(target, s, t, r, q);
			}

			public static unsafe void glMultiTexCoord4fvARB(TextureUnit target, float* v)
			{
				internalGL.glMultiTexCoord4fvARB(target, v);
			}

			public static void glMultiTexCoord4iARB(TextureUnit target, int s, int t, int r, int q)
			{
				internalGL.glMultiTexCoord4iARB(target, s, t, r, q);
			}

			public static unsafe void glMultiTexCoord4ivARB(TextureUnit target, int* v)
			{
				internalGL.glMultiTexCoord4ivARB(target, v);
			}

			public static void glMultiTexCoord4sARB(TextureUnit target, short s, short t, short r, short q)
			{
				internalGL.glMultiTexCoord4sARB(target, s, t, r, q);
			}

			public static unsafe void glMultiTexCoord4svARB(TextureUnit target, short* v)
			{
				internalGL.glMultiTexCoord4svARB(target, v);
			}

			public static unsafe void glMultTransposeMatrixdARB(double* m)
			{
				internalGL.glMultTransposeMatrixdARB(m);
			}

			public static unsafe void glMultTransposeMatrixfARB(float* m)
			{
				internalGL.glMultTransposeMatrixfARB(m);
			}

			public static void glPointParameterfARB(PointParameterNameARB pname, float param)
			{
				internalGL.glPointParameterfARB(pname, param);
			}

			public static unsafe void glPointParameterfvARB(PointParameterNameARB pname, float* @params)
			{
				internalGL.glPointParameterfvARB(pname, @params);
			}

			public static void glProgramEnvParameter4dARB(ProgramTarget target, uint index, double x, double y, double z, double w)
			{
				internalGL.glProgramEnvParameter4dARB(target, index, x, y, z, w);
			}

			public static unsafe void glProgramEnvParameter4dvARB(ProgramTarget target, uint index, double* @params)
			{
				internalGL.glProgramEnvParameter4dvARB(target, index, @params);
			}

			public static void glProgramEnvParameter4fARB(ProgramTarget target, uint index, float x, float y, float z, float w)
			{
				internalGL.glProgramEnvParameter4fARB(target, index, x, y, z, w);
			}

			public static unsafe void glProgramEnvParameter4fvARB(ProgramTarget target, uint index, float* @params)
			{
				internalGL.glProgramEnvParameter4fvARB(target, index, @params);
			}

			public static void glProgramLocalParameter4dARB(ProgramTarget target, uint index, double x, double y, double z, double w)
			{
				internalGL.glProgramLocalParameter4dARB(target, index, x, y, z, w);
			}

			public static unsafe void glProgramLocalParameter4dvARB(ProgramTarget target, uint index, double* @params)
			{
				internalGL.glProgramLocalParameter4dvARB(target, index, @params);
			}

			public static void glProgramLocalParameter4fARB(ProgramTarget target, uint index, float x, float y, float z, float w)
			{
				internalGL.glProgramLocalParameter4fARB(target, index, x, y, z, w);
			}

			public static unsafe void glProgramLocalParameter4fvARB(ProgramTarget target, uint index, float* @params)
			{
				internalGL.glProgramLocalParameter4fvARB(target, index, @params);
			}

			public static void glProgramStringARB(ProgramTarget target, ProgramFormat format, int len, IntPtr @string)
			{
				internalGL.glProgramStringARB(target, format, len, @string);
			}

			public static void glSampleCoverageARB(float value, Boolean invert)
			{
				internalGL.glSampleCoverageARB(value, invert);
			}

			public static unsafe void glShaderSourceARB(uint shaderObj, int count, sbyte* @string, int* length)
			{
				internalGL.glShaderSourceARB(shaderObj, count, @string, length);
			}

			public static void glUniform1fARB(int location, float v0)
			{
				internalGL.glUniform1fARB(location, v0);
			}

			public static unsafe void glUniform1fvARB(int location, int count, float* value)
			{
				internalGL.glUniform1fvARB(location, count, value);
			}

			public static void glUniform1iARB(int location, int v0)
			{
				internalGL.glUniform1iARB(location, v0);
			}

			public static unsafe void glUniform1ivARB(int location, int count, int* value)
			{
				internalGL.glUniform1ivARB(location, count, value);
			}

			public static void glUniform2fARB(int location, float v0, float v1)
			{
				internalGL.glUniform2fARB(location, v0, v1);
			}

			public static unsafe void glUniform2fvARB(int location, int count, float* value)
			{
				internalGL.glUniform2fvARB(location, count, value);
			}

			public static void glUniform2iARB(int location, int v0, int v1)
			{
				internalGL.glUniform2iARB(location, v0, v1);
			}

			public static unsafe void glUniform2ivARB(int location, int count, int* value)
			{
				internalGL.glUniform2ivARB(location, count, value);
			}

			public static void glUniform3fARB(int location, float v0, float v1, float v2)
			{
				internalGL.glUniform3fARB(location, v0, v1, v2);
			}

			public static unsafe void glUniform3fvARB(int location, int count, float* value)
			{
				internalGL.glUniform3fvARB(location, count, value);
			}

			public static void glUniform3iARB(int location, int v0, int v1, int v2)
			{
				internalGL.glUniform3iARB(location, v0, v1, v2);
			}

			public static unsafe void glUniform3ivARB(int location, int count, int* value)
			{
				internalGL.glUniform3ivARB(location, count, value);
			}

			public static void glUniform4fARB(int location, float v0, float v1, float v2, float v3)
			{
				internalGL.glUniform4fARB(location, v0, v1, v2, v3);
			}

			public static unsafe void glUniform4fvARB(int location, int count, float* value)
			{
				internalGL.glUniform4fvARB(location, count, value);
			}

			public static void glUniform4iARB(int location, int v0, int v1, int v2, int v3)
			{
				internalGL.glUniform4iARB(location, v0, v1, v2, v3);
			}

			public static unsafe void glUniform4ivARB(int location, int count, int* value)
			{
				internalGL.glUniform4ivARB(location, count, value);
			}

			public static unsafe void glUniformMatrix2fvARB(int location, int count, Boolean transpose, float* value)
			{
				internalGL.glUniformMatrix2fvARB(location, count, transpose, value);
			}

			public static unsafe void glUniformMatrix3fvARB(int location, int count, Boolean transpose, float* value)
			{
				internalGL.glUniformMatrix3fvARB(location, count, transpose, value);
			}

			public static unsafe void glUniformMatrix4fvARB(int location, int count, Boolean transpose, float* value)
			{
				internalGL.glUniformMatrix4fvARB(location, count, transpose, value);
			}

			public static bool glUnmapBufferARB(BufferTargetARB target)
			{
				return internalGL.glUnmapBufferARB(target);
			}

			public static void glUseProgramObjectARB(uint programObj)
			{
				internalGL.glUseProgramObjectARB(programObj);
			}

			public static void glValidateProgramARB(uint programObj)
			{
				internalGL.glValidateProgramARB(programObj);
			}

			public static void glVertexAttrib1dARB(uint index, double x)
			{
				internalGL.glVertexAttrib1dARB(index, x);
			}

			public static unsafe void glVertexAttrib1dvARB(uint index, double* v)
			{
				internalGL.glVertexAttrib1dvARB(index, v);
			}

			public static void glVertexAttrib1fARB(uint index, float x)
			{
				internalGL.glVertexAttrib1fARB(index, x);
			}

			public static unsafe void glVertexAttrib1fvARB(uint index, float* v)
			{
				internalGL.glVertexAttrib1fvARB(index, v);
			}

			public static void glVertexAttrib1sARB(uint index, short x)
			{
				internalGL.glVertexAttrib1sARB(index, x);
			}

			public static unsafe void glVertexAttrib1svARB(uint index, short* v)
			{
				internalGL.glVertexAttrib1svARB(index, v);
			}

			public static void glVertexAttrib2dARB(uint index, double x, double y)
			{
				internalGL.glVertexAttrib2dARB(index, x, y);
			}

			public static unsafe void glVertexAttrib2dvARB(uint index, double* v)
			{
				internalGL.glVertexAttrib2dvARB(index, v);
			}

			public static void glVertexAttrib2fARB(uint index, float x, float y)
			{
				internalGL.glVertexAttrib2fARB(index, x, y);
			}

			public static unsafe void glVertexAttrib2fvARB(uint index, float* v)
			{
				internalGL.glVertexAttrib2fvARB(index, v);
			}

			public static void glVertexAttrib2sARB(uint index, short x, short y)
			{
				internalGL.glVertexAttrib2sARB(index, x, y);
			}

			public static unsafe void glVertexAttrib2svARB(uint index, short* v)
			{
				internalGL.glVertexAttrib2svARB(index, v);
			}

			public static void glVertexAttrib3dARB(uint index, double x, double y, double z)
			{
				internalGL.glVertexAttrib3dARB(index, x, y, z);
			}

			public static unsafe void glVertexAttrib3dvARB(uint index, double* v)
			{
				internalGL.glVertexAttrib3dvARB(index, v);
			}

			public static void glVertexAttrib3fARB(uint index, float x, float y, float z)
			{
				internalGL.glVertexAttrib3fARB(index, x, y, z);
			}

			public static unsafe void glVertexAttrib3fvARB(uint index, float* v)
			{
				internalGL.glVertexAttrib3fvARB(index, v);
			}

			public static void glVertexAttrib3sARB(uint index, short x, short y, short z)
			{
				internalGL.glVertexAttrib3sARB(index, x, y, z);
			}

			public static unsafe void glVertexAttrib3svARB(uint index, short* v)
			{
				internalGL.glVertexAttrib3svARB(index, v);
			}

			public static unsafe void glVertexAttrib4bvARB(uint index, sbyte* v)
			{
				internalGL.glVertexAttrib4bvARB(index, v);
			}

			public static void glVertexAttrib4dARB(uint index, double x, double y, double z, double w)
			{
				internalGL.glVertexAttrib4dARB(index, x, y, z, w);
			}

			public static unsafe void glVertexAttrib4dvARB(uint index, double* v)
			{
				internalGL.glVertexAttrib4dvARB(index, v);
			}

			public static void glVertexAttrib4fARB(uint index, float x, float y, float z, float w)
			{
				internalGL.glVertexAttrib4fARB(index, x, y, z, w);
			}

			public static unsafe void glVertexAttrib4fvARB(uint index, float* v)
			{
				internalGL.glVertexAttrib4fvARB(index, v);
			}

			public static unsafe void glVertexAttrib4ivARB(uint index, int* v)
			{
				internalGL.glVertexAttrib4ivARB(index, v);
			}

			public static unsafe void glVertexAttrib4NbvARB(uint index, sbyte* v)
			{
				internalGL.glVertexAttrib4NbvARB(index, v);
			}

			public static unsafe void glVertexAttrib4NivARB(uint index, int* v)
			{
				internalGL.glVertexAttrib4NivARB(index, v);
			}

			public static unsafe void glVertexAttrib4NsvARB(uint index, short* v)
			{
				internalGL.glVertexAttrib4NsvARB(index, v);
			}

			public static void glVertexAttrib4NubARB(uint index, byte x, byte y, byte z, byte w)
			{
				internalGL.glVertexAttrib4NubARB(index, x, y, z, w);
			}

			public static unsafe void glVertexAttrib4NubvARB(uint index, byte* v)
			{
				internalGL.glVertexAttrib4NubvARB(index, v);
			}

			public static unsafe void glVertexAttrib4NuivARB(uint index, uint* v)
			{
				internalGL.glVertexAttrib4NuivARB(index, v);
			}

			public static unsafe void glVertexAttrib4NusvARB(uint index, ushort* v)
			{
				internalGL.glVertexAttrib4NusvARB(index, v);
			}

			public static void glVertexAttrib4sARB(uint index, short x, short y, short z, short w)
			{
				internalGL.glVertexAttrib4sARB(index, x, y, z, w);
			}

			public static unsafe void glVertexAttrib4svARB(uint index, short* v)
			{
				internalGL.glVertexAttrib4svARB(index, v);
			}

			public static unsafe void glVertexAttrib4ubvARB(uint index, byte* v)
			{
				internalGL.glVertexAttrib4ubvARB(index, v);
			}

			public static unsafe void glVertexAttrib4uivARB(uint index, uint* v)
			{
				internalGL.glVertexAttrib4uivARB(index, v);
			}

			public static unsafe void glVertexAttrib4usvARB(uint index, ushort* v)
			{
				internalGL.glVertexAttrib4usvARB(index, v);
			}

			public static void glVertexAttribPointerARB(uint index, int size, VertexAttribPointerType type, Boolean normalized, int stride, IntPtr pointer)
			{
				internalGL.glVertexAttribPointerARB(index, size, type, normalized, stride, pointer);
			}

			public static void glVertexBlendARB(int count)
			{
				internalGL.glVertexBlendARB(count);
			}

			public static unsafe void glWeightbvARB(int size, sbyte* weights)
			{
				internalGL.glWeightbvARB(size, weights);
			}

			public static unsafe void glWeightdvARB(int size, double* weights)
			{
				internalGL.glWeightdvARB(size, weights);
			}

			public static unsafe void glWeightfvARB(int size, float* weights)
			{
				internalGL.glWeightfvARB(size, weights);
			}

			public static unsafe void glWeightivARB(int size, int* weights)
			{
				internalGL.glWeightivARB(size, weights);
			}

			public static void glWeightPointerARB(int size, WeightPointerTypeARB type, int stride, IntPtr pointer)
			{
				internalGL.glWeightPointerARB(size, type, stride, pointer);
			}

			public static unsafe void glWeightsvARB(int size, short* weights)
			{
				internalGL.glWeightsvARB(size, weights);
			}

			public static unsafe void glWeightubvARB(int size, byte* weights)
			{
				internalGL.glWeightubvARB(size, weights);
			}

			public static unsafe void glWeightuivARB(int size, uint* weights)
			{
				internalGL.glWeightuivARB(size, weights);
			}

			public static unsafe void glWeightusvARB(int size, ushort* weights)
			{
				internalGL.glWeightusvARB(size, weights);
			}

			public static void glWindowPos2dARB(double x, double y)
			{
				internalGL.glWindowPos2dARB(x, y);
			}

			public static unsafe void glWindowPos2dvARB(double* v)
			{
				internalGL.glWindowPos2dvARB(v);
			}

			public static void glWindowPos2fARB(float x, float y)
			{
				internalGL.glWindowPos2fARB(x, y);
			}

			public static unsafe void glWindowPos2fvARB(float* v)
			{
				internalGL.glWindowPos2fvARB(v);
			}

			public static void glWindowPos2iARB(int x, int y)
			{
				internalGL.glWindowPos2iARB(x, y);
			}

			public static unsafe void glWindowPos2ivARB(int* v)
			{
				internalGL.glWindowPos2ivARB(v);
			}

			public static void glWindowPos2sARB(short x, short y)
			{
				internalGL.glWindowPos2sARB(x, y);
			}

			public static unsafe void glWindowPos2svARB(short* v)
			{
				internalGL.glWindowPos2svARB(v);
			}

			public static void glWindowPos3dARB(double x, double y, double z)
			{
				internalGL.glWindowPos3dARB(x, y, z);
			}

			public static unsafe void glWindowPos3dvARB(double* v)
			{
				internalGL.glWindowPos3dvARB(v);
			}

			public static void glWindowPos3fARB(float x, float y, float z)
			{
				internalGL.glWindowPos3fARB(x, y, z);
			}

			public static unsafe void glWindowPos3fvARB(float* v)
			{
				internalGL.glWindowPos3fvARB(v);
			}

			public static void glWindowPos3iARB(int x, int y, int z)
			{
				internalGL.glWindowPos3iARB(x, y, z);
			}

			public static unsafe void glWindowPos3ivARB(int* v)
			{
				internalGL.glWindowPos3ivARB(v);
			}

			public static void glWindowPos3sARB(short x, short y, short z)
			{
				internalGL.glWindowPos3sARB(x, y, z);
			}

			public static unsafe void glWindowPos3svARB(short* v)
			{
				internalGL.glWindowPos3svARB(v);
			}
		}

		public static class ATI
		{
			public static void glAlphaFragmentOp1ATI(FragmentOpATI op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod)
			{
				internalGL.glAlphaFragmentOp1ATI(op, dst, dstMod, arg1, arg1Rep, arg1Mod);
			}

			public static void glAlphaFragmentOp2ATI(FragmentOpATI op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod)
			{
				internalGL.glAlphaFragmentOp2ATI(op, dst, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod);
			}

			public static void glAlphaFragmentOp3ATI(FragmentOpATI op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod, uint arg3, uint arg3Rep, uint arg3Mod)
			{
				internalGL.glAlphaFragmentOp3ATI(op, dst, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod, arg3, arg3Rep, arg3Mod);
			}

			public static void glArrayObjectATI(EnableCap array, int size, ScalarType type, int stride, uint buffer, uint offset)
			{
				internalGL.glArrayObjectATI(array, size, type, stride, buffer, offset);
			}

			public static void glBeginFragmentShaderATI()
			{
				internalGL.glBeginFragmentShaderATI();
			}

			public static void glBindFragmentShaderATI(uint id)
			{
				internalGL.glBindFragmentShaderATI(id);
			}

			public static void glClientActiveVertexStreamATI(VertexStreamATI stream)
			{
				internalGL.glClientActiveVertexStreamATI(stream);
			}

			public static void glColorFragmentOp1ATI(FragmentOpATI op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod)
			{
				internalGL.glColorFragmentOp1ATI(op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod);
			}

			public static void glColorFragmentOp2ATI(FragmentOpATI op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod)
			{
				internalGL.glColorFragmentOp2ATI(op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod);
			}

			public static void glColorFragmentOp3ATI(FragmentOpATI op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod, uint arg3, uint arg3Rep, uint arg3Mod)
			{
				internalGL.glColorFragmentOp3ATI(op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod, arg3, arg3Rep, arg3Mod);
			}

			public static void glDeleteFragmentShaderATI(uint id)
			{
				internalGL.glDeleteFragmentShaderATI(id);
			}

			public static unsafe void glDrawBuffersATI(int n, DrawBufferMode* bufs)
			{
				internalGL.glDrawBuffersATI(n, bufs);
			}

			public static void glDrawElementArrayATI(PrimitiveType mode, int count)
			{
				internalGL.glDrawElementArrayATI(mode, count);
			}

			public static void glDrawRangeElementArrayATI(PrimitiveType mode, uint start, uint end, int count)
			{
				internalGL.glDrawRangeElementArrayATI(mode, start, end, count);
			}

			public static void glElementPointerATI(ElementPointerTypeATI type, IntPtr pointer)
			{
				internalGL.glElementPointerATI(type, pointer);
			}

			public static void glEndFragmentShaderATI()
			{
				internalGL.glEndFragmentShaderATI();
			}

			public static void glFreeObjectBufferATI(uint buffer)
			{
				internalGL.glFreeObjectBufferATI(buffer);
			}

			public static uint glGenFragmentShadersATI(uint range)
			{
				return internalGL.glGenFragmentShadersATI(range);
			}

			public static unsafe void glGetArrayObjectfvATI(EnableCap array, ArrayObjectPNameATI pname, float* @params)
			{
				internalGL.glGetArrayObjectfvATI(array, pname, @params);
			}

			public static unsafe void glGetArrayObjectivATI(EnableCap array, ArrayObjectPNameATI pname, int* @params)
			{
				internalGL.glGetArrayObjectivATI(array, pname, @params);
			}

			public static unsafe void glGetObjectBufferfvATI(uint buffer, ArrayObjectPNameATI pname, float* @params)
			{
				internalGL.glGetObjectBufferfvATI(buffer, pname, @params);
			}

			public static unsafe void glGetObjectBufferivATI(uint buffer, ArrayObjectPNameATI pname, int* @params)
			{
				internalGL.glGetObjectBufferivATI(buffer, pname, @params);
			}

			public static unsafe void glGetTexBumpParameterfvATI(GetTexBumpParameterATI pname, float* param)
			{
				internalGL.glGetTexBumpParameterfvATI(pname, param);
			}

			public static unsafe void glGetTexBumpParameterivATI(GetTexBumpParameterATI pname, int* param)
			{
				internalGL.glGetTexBumpParameterivATI(pname, param);
			}

			public static unsafe void glGetVariantArrayObjectfvATI(uint id, ArrayObjectPNameATI pname, float* @params)
			{
				internalGL.glGetVariantArrayObjectfvATI(id, pname, @params);
			}

			public static unsafe void glGetVariantArrayObjectivATI(uint id, ArrayObjectPNameATI pname, int* @params)
			{
				internalGL.glGetVariantArrayObjectivATI(id, pname, @params);
			}

			public static unsafe void glGetVertexAttribArrayObjectfvATI(uint index, ArrayObjectPNameATI pname, float* @params)
			{
				internalGL.glGetVertexAttribArrayObjectfvATI(index, pname, @params);
			}

			public static unsafe void glGetVertexAttribArrayObjectivATI(uint index, ArrayObjectPNameATI pname, int* @params)
			{
				internalGL.glGetVertexAttribArrayObjectivATI(index, pname, @params);
			}

			public static bool glIsObjectBufferATI(uint buffer)
			{
				return internalGL.glIsObjectBufferATI(buffer);
			}

			public static unsafe IntPtr* glMapObjectBufferATI(uint buffer)
			{
				return internalGL.glMapObjectBufferATI(buffer);
			}

			public static uint glNewObjectBufferATI(int size, IntPtr pointer, ArrayObjectUsageATI usage)
			{
				return internalGL.glNewObjectBufferATI(size, pointer, usage);
			}

			public static void glNormalStream3bATI(VertexStreamATI stream, sbyte nx, sbyte ny, sbyte nz)
			{
				internalGL.glNormalStream3bATI(stream, nx, ny, nz);
			}

			public static unsafe void glNormalStream3bvATI(VertexStreamATI stream, sbyte* coords)
			{
				internalGL.glNormalStream3bvATI(stream, coords);
			}

			public static void glNormalStream3dATI(VertexStreamATI stream, double nx, double ny, double nz)
			{
				internalGL.glNormalStream3dATI(stream, nx, ny, nz);
			}

			public static unsafe void glNormalStream3dvATI(VertexStreamATI stream, double* coords)
			{
				internalGL.glNormalStream3dvATI(stream, coords);
			}

			public static void glNormalStream3fATI(VertexStreamATI stream, float nx, float ny, float nz)
			{
				internalGL.glNormalStream3fATI(stream, nx, ny, nz);
			}

			public static unsafe void glNormalStream3fvATI(VertexStreamATI stream, float* coords)
			{
				internalGL.glNormalStream3fvATI(stream, coords);
			}

			public static void glNormalStream3iATI(VertexStreamATI stream, int nx, int ny, int nz)
			{
				internalGL.glNormalStream3iATI(stream, nx, ny, nz);
			}

			public static unsafe void glNormalStream3ivATI(VertexStreamATI stream, int* coords)
			{
				internalGL.glNormalStream3ivATI(stream, coords);
			}

			public static void glNormalStream3sATI(VertexStreamATI stream, short nx, short ny, short nz)
			{
				internalGL.glNormalStream3sATI(stream, nx, ny, nz);
			}

			public static unsafe void glNormalStream3svATI(VertexStreamATI stream, short* coords)
			{
				internalGL.glNormalStream3svATI(stream, coords);
			}

			public static void glPassTexCoordATI(uint dst, uint coord, SwizzleOpATI swizzle)
			{
				internalGL.glPassTexCoordATI(dst, coord, swizzle);
			}

			public static void glPNTrianglesfATI(PNTrianglesPNameATI pname, float param)
			{
				internalGL.glPNTrianglesfATI(pname, param);
			}

			public static void glPNTrianglesiATI(PNTrianglesPNameATI pname, int param)
			{
				internalGL.glPNTrianglesiATI(pname, param);
			}

			public static void glSampleMapATI(uint dst, uint interp, SwizzleOpATI swizzle)
			{
				internalGL.glSampleMapATI(dst, interp, swizzle);
			}

			public static unsafe void glSetFragmentShaderConstantATI(uint dst, float* value)
			{
				internalGL.glSetFragmentShaderConstantATI(dst, value);
			}

			public static void glStencilFuncSeparateATI(StencilFunction frontfunc, StencilFunction backfunc, int @ref, uint mask)
			{
				internalGL.glStencilFuncSeparateATI(frontfunc, backfunc, @ref, mask);
			}

			public static void glStencilOpSeparateATI(StencilFaceDirection face, StencilOp sfail, StencilOp dpfail, StencilOp dppass)
			{
				internalGL.glStencilOpSeparateATI(face, sfail, dpfail, dppass);
			}

			public static unsafe void glTexBumpParameterfvATI(TexBumpParameterATI pname, float* param)
			{
				internalGL.glTexBumpParameterfvATI(pname, param);
			}

			public static unsafe void glTexBumpParameterivATI(TexBumpParameterATI pname, int* param)
			{
				internalGL.glTexBumpParameterivATI(pname, param);
			}

			public static void glUnmapObjectBufferATI(uint buffer)
			{
				internalGL.glUnmapObjectBufferATI(buffer);
			}

			public static void glUpdateObjectBufferATI(uint buffer, uint offset, int size, IntPtr pointer, PreserveModeATI preserve)
			{
				internalGL.glUpdateObjectBufferATI(buffer, offset, size, pointer, preserve);
			}

			public static void glVariantArrayObjectATI(uint id, ScalarType type, int stride, uint buffer, uint offset)
			{
				internalGL.glVariantArrayObjectATI(id, type, stride, buffer, offset);
			}

			public static void glVertexAttribArrayObjectATI(uint index, int size, VertexAttribPointerType type, Boolean normalized, int stride, uint buffer, uint offset)
			{
				internalGL.glVertexAttribArrayObjectATI(index, size, type, normalized, stride, buffer, offset);
			}

			public static void glVertexBlendEnvfATI(VertexStreamATI pname, float param)
			{
				internalGL.glVertexBlendEnvfATI(pname, param);
			}

			public static void glVertexBlendEnviATI(VertexStreamATI pname, int param)
			{
				internalGL.glVertexBlendEnviATI(pname, param);
			}

			public static void glVertexStream1dATI(VertexStreamATI stream, double x)
			{
				internalGL.glVertexStream1dATI(stream, x);
			}

			public static unsafe void glVertexStream1dvATI(VertexStreamATI stream, double* coords)
			{
				internalGL.glVertexStream1dvATI(stream, coords);
			}

			public static void glVertexStream1fATI(VertexStreamATI stream, float x)
			{
				internalGL.glVertexStream1fATI(stream, x);
			}

			public static unsafe void glVertexStream1fvATI(VertexStreamATI stream, float* coords)
			{
				internalGL.glVertexStream1fvATI(stream, coords);
			}

			public static void glVertexStream1iATI(VertexStreamATI stream, int x)
			{
				internalGL.glVertexStream1iATI(stream, x);
			}

			public static unsafe void glVertexStream1ivATI(VertexStreamATI stream, int* coords)
			{
				internalGL.glVertexStream1ivATI(stream, coords);
			}

			public static void glVertexStream1sATI(VertexStreamATI stream, short x)
			{
				internalGL.glVertexStream1sATI(stream, x);
			}

			public static unsafe void glVertexStream1svATI(VertexStreamATI stream, short* coords)
			{
				internalGL.glVertexStream1svATI(stream, coords);
			}

			public static void glVertexStream2dATI(VertexStreamATI stream, double x, double y)
			{
				internalGL.glVertexStream2dATI(stream, x, y);
			}

			public static unsafe void glVertexStream2dvATI(VertexStreamATI stream, double* coords)
			{
				internalGL.glVertexStream2dvATI(stream, coords);
			}

			public static void glVertexStream2fATI(VertexStreamATI stream, float x, float y)
			{
				internalGL.glVertexStream2fATI(stream, x, y);
			}

			public static unsafe void glVertexStream2fvATI(VertexStreamATI stream, float* coords)
			{
				internalGL.glVertexStream2fvATI(stream, coords);
			}

			public static void glVertexStream2iATI(VertexStreamATI stream, int x, int y)
			{
				internalGL.glVertexStream2iATI(stream, x, y);
			}

			public static unsafe void glVertexStream2ivATI(VertexStreamATI stream, int* coords)
			{
				internalGL.glVertexStream2ivATI(stream, coords);
			}

			public static void glVertexStream2sATI(VertexStreamATI stream, short x, short y)
			{
				internalGL.glVertexStream2sATI(stream, x, y);
			}

			public static unsafe void glVertexStream2svATI(VertexStreamATI stream, short* coords)
			{
				internalGL.glVertexStream2svATI(stream, coords);
			}

			public static void glVertexStream3dATI(VertexStreamATI stream, double x, double y, double z)
			{
				internalGL.glVertexStream3dATI(stream, x, y, z);
			}

			public static unsafe void glVertexStream3dvATI(VertexStreamATI stream, double* coords)
			{
				internalGL.glVertexStream3dvATI(stream, coords);
			}

			public static void glVertexStream3fATI(VertexStreamATI stream, float x, float y, float z)
			{
				internalGL.glVertexStream3fATI(stream, x, y, z);
			}

			public static unsafe void glVertexStream3fvATI(VertexStreamATI stream, float* coords)
			{
				internalGL.glVertexStream3fvATI(stream, coords);
			}

			public static void glVertexStream3iATI(VertexStreamATI stream, int x, int y, int z)
			{
				internalGL.glVertexStream3iATI(stream, x, y, z);
			}

			public static unsafe void glVertexStream3ivATI(VertexStreamATI stream, int* coords)
			{
				internalGL.glVertexStream3ivATI(stream, coords);
			}

			public static void glVertexStream3sATI(VertexStreamATI stream, short x, short y, short z)
			{
				internalGL.glVertexStream3sATI(stream, x, y, z);
			}

			public static unsafe void glVertexStream3svATI(VertexStreamATI stream, short* coords)
			{
				internalGL.glVertexStream3svATI(stream, coords);
			}

			public static void glVertexStream4dATI(VertexStreamATI stream, double x, double y, double z, double w)
			{
				internalGL.glVertexStream4dATI(stream, x, y, z, w);
			}

			public static unsafe void glVertexStream4dvATI(VertexStreamATI stream, double* coords)
			{
				internalGL.glVertexStream4dvATI(stream, coords);
			}

			public static void glVertexStream4fATI(VertexStreamATI stream, float x, float y, float z, float w)
			{
				internalGL.glVertexStream4fATI(stream, x, y, z, w);
			}

			public static unsafe void glVertexStream4fvATI(VertexStreamATI stream, float* coords)
			{
				internalGL.glVertexStream4fvATI(stream, coords);
			}

			public static void glVertexStream4iATI(VertexStreamATI stream, int x, int y, int z, int w)
			{
				internalGL.glVertexStream4iATI(stream, x, y, z, w);
			}

			public static unsafe void glVertexStream4ivATI(VertexStreamATI stream, int* coords)
			{
				internalGL.glVertexStream4ivATI(stream, coords);
			}

			public static void glVertexStream4sATI(VertexStreamATI stream, short x, short y, short z, short w)
			{
				internalGL.glVertexStream4sATI(stream, x, y, z, w);
			}

			public static unsafe void glVertexStream4svATI(VertexStreamATI stream, short* coords)
			{
				internalGL.glVertexStream4svATI(stream, coords);
			}
		}

		public static class EXT
		{
			public static void glActiveStencilFaceEXT(StencilFaceDirection face)
			{
				internalGL.glActiveStencilFaceEXT(face);
			}

			public static void glApplyTextureEXT(LightTextureModeEXT mode)
			{
				internalGL.glApplyTextureEXT(mode);
			}

			public static unsafe bool glAreTexturesResidentEXT(int n, uint* textures, Boolean* residences)
			{
				return internalGL.glAreTexturesResidentEXT(n, textures, residences);
			}

			public static void glArrayElementEXT(int i)
			{
				internalGL.glArrayElementEXT(i);
			}

			public static void glBeginTransformFeedbackEXT(PrimitiveType primitiveMode)
			{
				internalGL.glBeginTransformFeedbackEXT(primitiveMode);
			}

			public static void glBeginVertexShaderEXT()
			{
				internalGL.glBeginVertexShaderEXT();
			}

			public static void glBindBufferBaseEXT(BufferTargetARB target, uint index, uint buffer)
			{
				internalGL.glBindBufferBaseEXT(target, index, buffer);
			}

			public static void glBindBufferOffsetEXT(BufferTargetARB target, uint index, uint buffer, IntPtr offset)
			{
				internalGL.glBindBufferOffsetEXT(target, index, buffer, offset);
			}

			public static void glBindBufferRangeEXT(BufferTargetARB target, uint index, uint buffer, IntPtr offset, int size)
			{
				internalGL.glBindBufferRangeEXT(target, index, buffer, offset, size);
			}

			public static unsafe void glBindFragDataLocationEXT(uint program, uint color, sbyte* name)
			{
				internalGL.glBindFragDataLocationEXT(program, color, name);
			}

			public static void glBindFramebufferEXT(FramebufferTarget target, uint framebuffer)
			{
				internalGL.glBindFramebufferEXT(target, framebuffer);
			}

			public static void glBindImageTextureEXT(uint index, uint texture, int level, Boolean layered, int layer, BufferAccessARB access, int format)
			{
				internalGL.glBindImageTextureEXT(index, texture, level, layered, layer, access, format);
			}

			public static uint glBindLightParameterEXT(LightName light, LightParameter value)
			{
				return internalGL.glBindLightParameterEXT(light, value);
			}

			public static uint glBindMaterialParameterEXT(MaterialFace face, MaterialParameter value)
			{
				return internalGL.glBindMaterialParameterEXT(face, value);
			}

			public static uint glBindParameterEXT(VertexShaderParameterEXT value)
			{
				return internalGL.glBindParameterEXT(value);
			}

			public static void glBindRenderbufferEXT(RenderbufferTarget target, uint renderbuffer)
			{
				internalGL.glBindRenderbufferEXT(target, renderbuffer);
			}

			public static uint glBindTexGenParameterEXT(TextureUnit unit, TextureCoordName coord, TextureGenParameter value)
			{
				return internalGL.glBindTexGenParameterEXT(unit, coord, value);
			}

			public static void glBindTextureEXT(TextureTarget target, uint texture)
			{
				internalGL.glBindTextureEXT(target, texture);
			}

			public static uint glBindTextureUnitParameterEXT(TextureUnit unit, VertexShaderTextureUnitParameter value)
			{
				return internalGL.glBindTextureUnitParameterEXT(unit, value);
			}

			public static void glBindVertexShaderEXT(uint id)
			{
				internalGL.glBindVertexShaderEXT(id);
			}

			public static void glBinormal3bEXT(sbyte bx, sbyte by, sbyte bz)
			{
				internalGL.glBinormal3bEXT(bx, by, bz);
			}

			public static unsafe void glBinormal3bvEXT(sbyte* v)
			{
				internalGL.glBinormal3bvEXT(v);
			}

			public static void glBinormal3dEXT(double bx, double by, double bz)
			{
				internalGL.glBinormal3dEXT(bx, by, bz);
			}

			public static unsafe void glBinormal3dvEXT(double* v)
			{
				internalGL.glBinormal3dvEXT(v);
			}

			public static void glBinormal3fEXT(float bx, float by, float bz)
			{
				internalGL.glBinormal3fEXT(bx, by, bz);
			}

			public static unsafe void glBinormal3fvEXT(float* v)
			{
				internalGL.glBinormal3fvEXT(v);
			}

			public static void glBinormal3iEXT(int bx, int by, int bz)
			{
				internalGL.glBinormal3iEXT(bx, by, bz);
			}

			public static unsafe void glBinormal3ivEXT(int* v)
			{
				internalGL.glBinormal3ivEXT(v);
			}

			public static void glBinormal3sEXT(short bx, short by, short bz)
			{
				internalGL.glBinormal3sEXT(bx, by, bz);
			}

			public static unsafe void glBinormal3svEXT(short* v)
			{
				internalGL.glBinormal3svEXT(v);
			}

			public static void glBinormalPointerEXT(BinormalPointerTypeEXT type, int stride, IntPtr pointer)
			{
				internalGL.glBinormalPointerEXT(type, stride, pointer);
			}

			public static void glBlendColorEXT(float red, float green, float blue, float alpha)
			{
				internalGL.glBlendColorEXT(red, green, blue, alpha);
			}

			public static void glBlendEquationSeparateEXT(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha)
			{
				internalGL.glBlendEquationSeparateEXT(modeRGB, modeAlpha);
			}

			public static void glBlendFuncSeparateEXT(BlendingFactor sfactorRGB, BlendingFactor dfactorRGB, BlendingFactor sfactorAlpha, BlendingFactor dfactorAlpha)
			{
				internalGL.glBlendFuncSeparateEXT(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
			}

			public static void glBlitFramebufferEXT(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter)
			{
				internalGL.glBlitFramebufferEXT(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
			}

			public static uint glCheckFramebufferStatusEXT(FramebufferTarget target)
			{
				return internalGL.glCheckFramebufferStatusEXT(target);
			}

			public static void glClearColorIiEXT(int red, int green, int blue, int alpha)
			{
				internalGL.glClearColorIiEXT(red, green, blue, alpha);
			}

			public static void glClearColorIuiEXT(uint red, uint green, uint blue, uint alpha)
			{
				internalGL.glClearColorIuiEXT(red, green, blue, alpha);
			}

			public static void glColorMaskIndexedEXT(uint index, Boolean r, Boolean g, Boolean b, Boolean a)
			{
				internalGL.glColorMaskIndexedEXT(index, r, g, b, a);
			}

			public static void glColorPointerEXT(int size, ColorPointerType type, int stride, int count, IntPtr pointer)
			{
				internalGL.glColorPointerEXT(size, type, stride, count, pointer);
			}

			public static void glColorSubTableEXT(ColorTableTarget target, int start, int count, PixelFormat format, PixelType type, IntPtr data)
			{
				internalGL.glColorSubTableEXT(target, start, count, format, type, data);
			}

			public static void glColorTableEXT(ColorTableTarget target, InternalFormat internalFormat, int width, PixelFormat format, PixelType type, IntPtr table)
			{
				internalGL.glColorTableEXT(target, internalFormat, width, format, type, table);
			}

			public static void glConvolutionFilter1DEXT(ConvolutionTargetEXT target, InternalFormat internalformat, int width, PixelFormat format, PixelType type, IntPtr image)
			{
				internalGL.glConvolutionFilter1DEXT(target, internalformat, width, format, type, image);
			}

			public static void glConvolutionFilter2DEXT(ConvolutionTargetEXT target, InternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, IntPtr image)
			{
				internalGL.glConvolutionFilter2DEXT(target, internalformat, width, height, format, type, image);
			}

			public static void glConvolutionParameterfEXT(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, float @params)
			{
				internalGL.glConvolutionParameterfEXT(target, pname, @params);
			}

			public static unsafe void glConvolutionParameterfvEXT(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, float* @params)
			{
				internalGL.glConvolutionParameterfvEXT(target, pname, @params);
			}

			public static void glConvolutionParameteriEXT(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, int @params)
			{
				internalGL.glConvolutionParameteriEXT(target, pname, @params);
			}

			public static unsafe void glConvolutionParameterivEXT(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, int* @params)
			{
				internalGL.glConvolutionParameterivEXT(target, pname, @params);
			}

			public static void glCopyColorSubTableEXT(ColorTableTarget target, int start, int x, int y, int width)
			{
				internalGL.glCopyColorSubTableEXT(target, start, x, y, width);
			}

			public static void glCopyConvolutionFilter1DEXT(ConvolutionTargetEXT target, InternalFormat internalformat, int x, int y, int width)
			{
				internalGL.glCopyConvolutionFilter1DEXT(target, internalformat, x, y, width);
			}

			public static void glCopyConvolutionFilter2DEXT(ConvolutionTargetEXT target, InternalFormat internalformat, int x, int y, int width, int height)
			{
				internalGL.glCopyConvolutionFilter2DEXT(target, internalformat, x, y, width, height);
			}

			public static void glCopyTexImage1DEXT(TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int border)
			{
				internalGL.glCopyTexImage1DEXT(target, level, internalformat, x, y, width, border);
			}

			public static void glCopyTexImage2DEXT(TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int height, int border)
			{
				internalGL.glCopyTexImage2DEXT(target, level, internalformat, x, y, width, height, border);
			}

			public static void glCopyTexSubImage1DEXT(TextureTarget target, int level, int xoffset, int x, int y, int width)
			{
				internalGL.glCopyTexSubImage1DEXT(target, level, xoffset, x, y, width);
			}

			public static void glCopyTexSubImage2DEXT(TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height)
			{
				internalGL.glCopyTexSubImage2DEXT(target, level, xoffset, yoffset, x, y, width, height);
			}

			public static void glCopyTexSubImage3DEXT(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
			{
				internalGL.glCopyTexSubImage3DEXT(target, level, xoffset, yoffset, zoffset, x, y, width, height);
			}

			public static unsafe void glCullParameterdvEXT(CullParameterEXT pname, double* @params)
			{
				internalGL.glCullParameterdvEXT(pname, @params);
			}

			public static unsafe void glCullParameterfvEXT(CullParameterEXT pname, float* @params)
			{
				internalGL.glCullParameterfvEXT(pname, @params);
			}

			public static unsafe void glDeleteFramebuffersEXT(int n, uint* framebuffers)
			{
				internalGL.glDeleteFramebuffersEXT(n, framebuffers);
			}

			public static unsafe void glDeleteRenderbuffersEXT(int n, uint* renderbuffers)
			{
				internalGL.glDeleteRenderbuffersEXT(n, renderbuffers);
			}

			public static unsafe void glDeleteTexturesEXT(int n, uint* textures)
			{
				internalGL.glDeleteTexturesEXT(n, textures);
			}

			public static void glDeleteVertexShaderEXT(uint id)
			{
				internalGL.glDeleteVertexShaderEXT(id);
			}

			public static void glDepthBoundsEXT(double zmin, double zmax)
			{
				internalGL.glDepthBoundsEXT(zmin, zmax);
			}

			public static void glDisableIndexedEXT(EnableCap target, uint index)
			{
				internalGL.glDisableIndexedEXT(target, index);
			}

			public static void glDisableVariantClientStateEXT(uint id)
			{
				internalGL.glDisableVariantClientStateEXT(id);
			}

			public static void glDrawArraysEXT(PrimitiveType mode, int first, int count)
			{
				internalGL.glDrawArraysEXT(mode, first, count);
			}

			public static void glDrawRangeElementsEXT(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, IntPtr indices)
			{
				internalGL.glDrawRangeElementsEXT(mode, start, end, count, type, indices);
			}

			public static unsafe void glEdgeFlagPointerEXT(int stride, int count, Boolean* pointer)
			{
				internalGL.glEdgeFlagPointerEXT(stride, count, pointer);
			}

			public static void glEnableIndexedEXT(EnableCap target, uint index)
			{
				internalGL.glEnableIndexedEXT(target, index);
			}

			public static void glEnableVariantClientStateEXT(uint id)
			{
				internalGL.glEnableVariantClientStateEXT(id);
			}

			public static void glEndTransformFeedbackEXT()
			{
				internalGL.glEndTransformFeedbackEXT();
			}

			public static void glEndVertexShaderEXT()
			{
				internalGL.glEndVertexShaderEXT();
			}

			public static void glExtractComponentEXT(uint res, uint src, uint num)
			{
				internalGL.glExtractComponentEXT(res, src, num);
			}

			public static void glFogCoorddEXT(double coord)
			{
				internalGL.glFogCoorddEXT(coord);
			}

			public static unsafe void glFogCoorddvEXT(double* coord)
			{
				internalGL.glFogCoorddvEXT(coord);
			}

			public static void glFogCoordfEXT(float coord)
			{
				internalGL.glFogCoordfEXT(coord);
			}

			public static unsafe void glFogCoordfvEXT(float* coord)
			{
				internalGL.glFogCoordfvEXT(coord);
			}

			public static void glFogCoordPointerEXT(FogPointerTypeEXT type, int stride, IntPtr pointer)
			{
				internalGL.glFogCoordPointerEXT(type, stride, pointer);
			}

			public static void glFramebufferRenderbufferEXT(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, uint renderbuffer)
			{
				internalGL.glFramebufferRenderbufferEXT(target, attachment, renderbuffertarget, renderbuffer);
			}

			public static void glFramebufferTexture1DEXT(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level)
			{
				internalGL.glFramebufferTexture1DEXT(target, attachment, textarget, texture, level);
			}

			public static void glFramebufferTexture2DEXT(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level)
			{
				internalGL.glFramebufferTexture2DEXT(target, attachment, textarget, texture, level);
			}

			public static void glFramebufferTexture3DEXT(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level, int zoffset)
			{
				internalGL.glFramebufferTexture3DEXT(target, attachment, textarget, texture, level, zoffset);
			}

			public static void glFramebufferTextureLayerEXT(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, int layer)
			{
				internalGL.glFramebufferTextureLayerEXT(target, attachment, texture, level, layer);
			}

			public static void glGenerateMipmapEXT(TextureTarget target)
			{
				internalGL.glGenerateMipmapEXT(target);
			}

			public static unsafe void glGenFramebuffersEXT(int n, uint* framebuffers)
			{
				internalGL.glGenFramebuffersEXT(n, framebuffers);
			}

			public static unsafe void glGenRenderbuffersEXT(int n, uint* renderbuffers)
			{
				internalGL.glGenRenderbuffersEXT(n, renderbuffers);
			}

			public static uint glGenSymbolsEXT(DataTypeEXT datatype, VertexShaderStorageTypeEXT storagetype, ParameterRangeEXT range, uint components)
			{
				return internalGL.glGenSymbolsEXT(datatype, storagetype, range, components);
			}

			public static unsafe void glGenTexturesEXT(int n, uint* textures)
			{
				internalGL.glGenTexturesEXT(n, textures);
			}

			public static uint glGenVertexShadersEXT(uint range)
			{
				return internalGL.glGenVertexShadersEXT(range);
			}

			public static unsafe void glGetBooleanIndexedvEXT(BufferTargetARB target, uint index, Boolean* data)
			{
				internalGL.glGetBooleanIndexedvEXT(target, index, data);
			}

			public static void glGetColorTableEXT(ColorTableTarget target, PixelFormat format, PixelType type, IntPtr data)
			{
				internalGL.glGetColorTableEXT(target, format, type, data);
			}

			public static unsafe void glGetColorTableParameterfvEXT(ColorTableTarget target, GetColorTableParameterPNameSGI pname, float* @params)
			{
				internalGL.glGetColorTableParameterfvEXT(target, pname, @params);
			}

			public static unsafe void glGetColorTableParameterivEXT(ColorTableTarget target, GetColorTableParameterPNameSGI pname, int* @params)
			{
				internalGL.glGetColorTableParameterivEXT(target, pname, @params);
			}

			public static void glGetConvolutionFilterEXT(ConvolutionTargetEXT target, PixelFormat format, PixelType type, IntPtr image)
			{
				internalGL.glGetConvolutionFilterEXT(target, format, type, image);
			}

			public static unsafe void glGetConvolutionParameterfvEXT(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, float* @params)
			{
				internalGL.glGetConvolutionParameterfvEXT(target, pname, @params);
			}

			public static unsafe void glGetConvolutionParameterivEXT(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, int* @params)
			{
				internalGL.glGetConvolutionParameterivEXT(target, pname, @params);
			}

			public static unsafe int glGetFragDataLocationEXT(uint program, sbyte* name)
			{
				return internalGL.glGetFragDataLocationEXT(program, name);
			}

			public static unsafe void glGetFramebufferAttachmentParameterivEXT(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int* @params)
			{
				internalGL.glGetFramebufferAttachmentParameterivEXT(target, attachment, pname, @params);
			}

			public static void glGetHistogramEXT(HistogramTargetEXT target, Boolean reset, PixelFormat format, PixelType type, IntPtr values)
			{
				internalGL.glGetHistogramEXT(target, reset, format, type, values);
			}

			public static unsafe void glGetHistogramParameterfvEXT(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, float* @params)
			{
				internalGL.glGetHistogramParameterfvEXT(target, pname, @params);
			}

			public static unsafe void glGetHistogramParameterivEXT(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, int* @params)
			{
				internalGL.glGetHistogramParameterivEXT(target, pname, @params);
			}

			public static unsafe void glGetIntegerIndexedvEXT(GetPName target, uint index, int* data)
			{
				internalGL.glGetIntegerIndexedvEXT(target, index, data);
			}

			public static unsafe void glGetInvariantBooleanvEXT(uint id, GetVariantValueEXT value, Boolean* data)
			{
				internalGL.glGetInvariantBooleanvEXT(id, value, data);
			}

			public static unsafe void glGetInvariantFloatvEXT(uint id, GetVariantValueEXT value, float* data)
			{
				internalGL.glGetInvariantFloatvEXT(id, value, data);
			}

			public static unsafe void glGetInvariantIntegervEXT(uint id, GetVariantValueEXT value, int* data)
			{
				internalGL.glGetInvariantIntegervEXT(id, value, data);
			}

			public static unsafe void glGetLocalConstantBooleanvEXT(uint id, GetVariantValueEXT value, Boolean* data)
			{
				internalGL.glGetLocalConstantBooleanvEXT(id, value, data);
			}

			public static unsafe void glGetLocalConstantFloatvEXT(uint id, GetVariantValueEXT value, float* data)
			{
				internalGL.glGetLocalConstantFloatvEXT(id, value, data);
			}

			public static unsafe void glGetLocalConstantIntegervEXT(uint id, GetVariantValueEXT value, int* data)
			{
				internalGL.glGetLocalConstantIntegervEXT(id, value, data);
			}

			public static void glGetMinmaxEXT(MinmaxTargetEXT target, Boolean reset, PixelFormat format, PixelType type, IntPtr values)
			{
				internalGL.glGetMinmaxEXT(target, reset, format, type, values);
			}

			public static unsafe void glGetMinmaxParameterfvEXT(MinmaxTargetEXT target, GetMinmaxParameterPNameEXT pname, float* @params)
			{
				internalGL.glGetMinmaxParameterfvEXT(target, pname, @params);
			}

			public static unsafe void glGetMinmaxParameterivEXT(MinmaxTargetEXT target, GetMinmaxParameterPNameEXT pname, int* @params)
			{
				internalGL.glGetMinmaxParameterivEXT(target, pname, @params);
			}

			public static unsafe void glGetPixelTransformParameterfvEXT(uint target, uint pname, float* @params)
			{
				internalGL.glGetPixelTransformParameterfvEXT(target, pname, @params);
			}

			public static unsafe void glGetPixelTransformParameterivEXT(uint target, uint pname, int* @params)
			{
				internalGL.glGetPixelTransformParameterivEXT(target, pname, @params);
			}

			public static void glGetPointervEXT(GetPointervPName pname, IntPtr @params)
			{
				internalGL.glGetPointervEXT(pname, @params);
			}

			public static unsafe void glGetQueryObjecti64vEXT(uint id, QueryObjectParameterName pname, long* @params)
			{
				internalGL.glGetQueryObjecti64vEXT(id, pname, @params);
			}

			public static unsafe void glGetQueryObjectui64vEXT(uint id, QueryObjectParameterName pname, ulong* @params)
			{
				internalGL.glGetQueryObjectui64vEXT(id, pname, @params);
			}

			public static unsafe void glGetRenderbufferParameterivEXT(RenderbufferTarget target, RenderbufferParameterName pname, int* @params)
			{
				internalGL.glGetRenderbufferParameterivEXT(target, pname, @params);
			}

			public static void glGetSeparableFilterEXT(SeparableTargetEXT target, PixelFormat format, PixelType type, IntPtr row, IntPtr column, IntPtr span)
			{
				internalGL.glGetSeparableFilterEXT(target, format, type, row, column, span);
			}

			public static unsafe void glGetTexParameterIivEXT(TextureTarget target, GetTextureParameter pname, int* @params)
			{
				internalGL.glGetTexParameterIivEXT(target, pname, @params);
			}

			public static unsafe void glGetTexParameterIuivEXT(TextureTarget target, GetTextureParameter pname, uint* @params)
			{
				internalGL.glGetTexParameterIuivEXT(target, pname, @params);
			}

			public static unsafe void glGetTransformFeedbackVaryingEXT(uint program, uint index, int bufSize, int* length, int* size, AttributeType* type, sbyte* name)
			{
				internalGL.glGetTransformFeedbackVaryingEXT(program, index, bufSize, length, size, type, name);
			}

			public static int glGetUniformBufferSizeEXT(uint program, int location)
			{
				return internalGL.glGetUniformBufferSizeEXT(program, location);
			}

			public static IntPtr glGetUniformOffsetEXT(uint program, int location)
			{
				return internalGL.glGetUniformOffsetEXT(program, location);
			}

			public static unsafe void glGetUniformuivEXT(uint program, int location, uint* @params)
			{
				internalGL.glGetUniformuivEXT(program, location, @params);
			}

			public static unsafe void glGetVariantBooleanvEXT(uint id, GetVariantValueEXT value, Boolean* data)
			{
				internalGL.glGetVariantBooleanvEXT(id, value, data);
			}

			public static unsafe void glGetVariantFloatvEXT(uint id, GetVariantValueEXT value, float* data)
			{
				internalGL.glGetVariantFloatvEXT(id, value, data);
			}

			public static unsafe void glGetVariantIntegervEXT(uint id, GetVariantValueEXT value, int* data)
			{
				internalGL.glGetVariantIntegervEXT(id, value, data);
			}

			public static void glGetVariantPointervEXT(uint id, GetVariantValueEXT value, IntPtr data)
			{
				internalGL.glGetVariantPointervEXT(id, value, data);
			}

			public static unsafe void glGetVertexAttribLdvEXT(uint index, VertexAttribEnum pname, double* @params)
			{
				internalGL.glGetVertexAttribLdvEXT(index, pname, @params);
			}

			public static void glHistogramEXT(HistogramTargetEXT target, int width, InternalFormat internalformat, Boolean sink)
			{
				internalGL.glHistogramEXT(target, width, internalformat, sink);
			}

			public static IntPtr glImportSyncEXT(uint external_sync_type, IntPtr external_sync, uint flags)
			{
				return internalGL.glImportSyncEXT(external_sync_type, external_sync, flags);
			}

			public static void glIndexFuncEXT(IndexFunctionEXT func, float @ref)
			{
				internalGL.glIndexFuncEXT(func, @ref);
			}

			public static void glIndexMaterialEXT(MaterialFace face, IndexMaterialParameterEXT mode)
			{
				internalGL.glIndexMaterialEXT(face, mode);
			}

			public static void glIndexPointerEXT(IndexPointerType type, int stride, int count, IntPtr pointer)
			{
				internalGL.glIndexPointerEXT(type, stride, count, pointer);
			}

			public static void glInsertComponentEXT(uint res, uint src, uint num)
			{
				internalGL.glInsertComponentEXT(res, src, num);
			}

			public static bool glIsEnabledIndexedEXT(EnableCap target, uint index)
			{
				return internalGL.glIsEnabledIndexedEXT(target, index);
			}

			public static bool glIsFramebufferEXT(uint framebuffer)
			{
				return internalGL.glIsFramebufferEXT(framebuffer);
			}

			public static bool glIsRenderbufferEXT(uint renderbuffer)
			{
				return internalGL.glIsRenderbufferEXT(renderbuffer);
			}

			public static bool glIsTextureEXT(uint texture)
			{
				return internalGL.glIsTextureEXT(texture);
			}

			public static bool glIsVariantEnabledEXT(uint id, VariantCapEXT cap)
			{
				return internalGL.glIsVariantEnabledEXT(id, cap);
			}

			public static void glLockArraysEXT(int first, int count)
			{
				internalGL.glLockArraysEXT(first, count);
			}

			public static void glMemoryBarrierEXT(MemoryBarrierMask barriers)
			{
				internalGL.glMemoryBarrierEXT(barriers);
			}

			public static void glMinmaxEXT(MinmaxTargetEXT target, InternalFormat internalformat, Boolean sink)
			{
				internalGL.glMinmaxEXT(target, internalformat, sink);
			}

			public static void glNormalPointerEXT(NormalPointerType type, int stride, int count, IntPtr pointer)
			{
				internalGL.glNormalPointerEXT(type, stride, count, pointer);
			}

			public static void glPixelTransformParameterfEXT(PixelTransformTargetEXT target, PixelTransformPNameEXT pname, float param)
			{
				internalGL.glPixelTransformParameterfEXT(target, pname, param);
			}

			public static unsafe void glPixelTransformParameterfvEXT(PixelTransformTargetEXT target, PixelTransformPNameEXT pname, float* @params)
			{
				internalGL.glPixelTransformParameterfvEXT(target, pname, @params);
			}

			public static void glPixelTransformParameteriEXT(PixelTransformTargetEXT target, PixelTransformPNameEXT pname, int param)
			{
				internalGL.glPixelTransformParameteriEXT(target, pname, param);
			}

			public static unsafe void glPixelTransformParameterivEXT(PixelTransformTargetEXT target, PixelTransformPNameEXT pname, int* @params)
			{
				internalGL.glPixelTransformParameterivEXT(target, pname, @params);
			}

			public static void glPointParameterfEXT(PointParameterNameARB pname, float param)
			{
				internalGL.glPointParameterfEXT(pname, param);
			}

			public static unsafe void glPointParameterfvEXT(PointParameterNameARB pname, float* @params)
			{
				internalGL.glPointParameterfvEXT(pname, @params);
			}

			public static void glPolygonOffsetEXT(float factor, float bias)
			{
				internalGL.glPolygonOffsetEXT(factor, bias);
			}

			public static unsafe void glPrioritizeTexturesEXT(int n, uint* textures, float* priorities)
			{
				internalGL.glPrioritizeTexturesEXT(n, textures, priorities);
			}

			public static unsafe void glProgramEnvParameters4fvEXT(ProgramTarget target, uint index, int count, float* @params)
			{
				internalGL.glProgramEnvParameters4fvEXT(target, index, count, @params);
			}

			public static unsafe void glProgramLocalParameters4fvEXT(ProgramTarget target, uint index, int count, float* @params)
			{
				internalGL.glProgramLocalParameters4fvEXT(target, index, count, @params);
			}

			public static void glProgramParameteriEXT(uint program, ProgramParameterPName pname, int value)
			{
				internalGL.glProgramParameteriEXT(program, pname, value);
			}

			public static void glProvokingVertexEXT(VertexProvokingMode mode)
			{
				internalGL.glProvokingVertexEXT(mode);
			}

			public static void glRenderbufferStorageEXT(RenderbufferTarget target, InternalFormat internalformat, int width, int height)
			{
				internalGL.glRenderbufferStorageEXT(target, internalformat, width, height);
			}

			public static void glRenderbufferStorageMultisampleEXT(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height)
			{
				internalGL.glRenderbufferStorageMultisampleEXT(target, samples, internalformat, width, height);
			}

			public static void glResetHistogramEXT(HistogramTargetEXT target)
			{
				internalGL.glResetHistogramEXT(target);
			}

			public static void glResetMinmaxEXT(MinmaxTargetEXT target)
			{
				internalGL.glResetMinmaxEXT(target);
			}

			public static void glSampleMaskEXT(float value, Boolean invert)
			{
				internalGL.glSampleMaskEXT(value, invert);
			}

			public static void glSamplePatternEXT(SamplePatternEXT pattern)
			{
				internalGL.glSamplePatternEXT(pattern);
			}

			public static void glSecondaryColor3bEXT(sbyte red, sbyte green, sbyte blue)
			{
				internalGL.glSecondaryColor3bEXT(red, green, blue);
			}

			public static unsafe void glSecondaryColor3bvEXT(sbyte* v)
			{
				internalGL.glSecondaryColor3bvEXT(v);
			}

			public static void glSecondaryColor3dEXT(double red, double green, double blue)
			{
				internalGL.glSecondaryColor3dEXT(red, green, blue);
			}

			public static unsafe void glSecondaryColor3dvEXT(double* v)
			{
				internalGL.glSecondaryColor3dvEXT(v);
			}

			public static void glSecondaryColor3fEXT(float red, float green, float blue)
			{
				internalGL.glSecondaryColor3fEXT(red, green, blue);
			}

			public static unsafe void glSecondaryColor3fvEXT(float* v)
			{
				internalGL.glSecondaryColor3fvEXT(v);
			}

			public static void glSecondaryColor3iEXT(int red, int green, int blue)
			{
				internalGL.glSecondaryColor3iEXT(red, green, blue);
			}

			public static unsafe void glSecondaryColor3ivEXT(int* v)
			{
				internalGL.glSecondaryColor3ivEXT(v);
			}

			public static void glSecondaryColor3sEXT(short red, short green, short blue)
			{
				internalGL.glSecondaryColor3sEXT(red, green, blue);
			}

			public static unsafe void glSecondaryColor3svEXT(short* v)
			{
				internalGL.glSecondaryColor3svEXT(v);
			}

			public static void glSecondaryColor3ubEXT(byte red, byte green, byte blue)
			{
				internalGL.glSecondaryColor3ubEXT(red, green, blue);
			}

			public static unsafe void glSecondaryColor3ubvEXT(byte* v)
			{
				internalGL.glSecondaryColor3ubvEXT(v);
			}

			public static void glSecondaryColor3uiEXT(uint red, uint green, uint blue)
			{
				internalGL.glSecondaryColor3uiEXT(red, green, blue);
			}

			public static unsafe void glSecondaryColor3uivEXT(uint* v)
			{
				internalGL.glSecondaryColor3uivEXT(v);
			}

			public static void glSecondaryColor3usEXT(ushort red, ushort green, ushort blue)
			{
				internalGL.glSecondaryColor3usEXT(red, green, blue);
			}

			public static unsafe void glSecondaryColor3usvEXT(ushort* v)
			{
				internalGL.glSecondaryColor3usvEXT(v);
			}

			public static void glSecondaryColorPointerEXT(int size, ColorPointerType type, int stride, IntPtr pointer)
			{
				internalGL.glSecondaryColorPointerEXT(size, type, stride, pointer);
			}

			public static void glSeparableFilter2DEXT(SeparableTargetEXT target, InternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, IntPtr row, IntPtr column)
			{
				internalGL.glSeparableFilter2DEXT(target, internalformat, width, height, format, type, row, column);
			}

			public static void glSetInvariantEXT(uint id, ScalarType type, IntPtr addr)
			{
				internalGL.glSetInvariantEXT(id, type, addr);
			}

			public static void glSetLocalConstantEXT(uint id, ScalarType type, IntPtr addr)
			{
				internalGL.glSetLocalConstantEXT(id, type, addr);
			}

			public static void glShaderOp1EXT(VertexShaderOpEXT op, uint res, uint arg1)
			{
				internalGL.glShaderOp1EXT(op, res, arg1);
			}

			public static void glShaderOp2EXT(VertexShaderOpEXT op, uint res, uint arg1, uint arg2)
			{
				internalGL.glShaderOp2EXT(op, res, arg1, arg2);
			}

			public static void glShaderOp3EXT(VertexShaderOpEXT op, uint res, uint arg1, uint arg2, uint arg3)
			{
				internalGL.glShaderOp3EXT(op, res, arg1, arg2, arg3);
			}

			public static void glStencilClearTagEXT(int stencilTagBits, uint stencilClearTag)
			{
				internalGL.glStencilClearTagEXT(stencilTagBits, stencilClearTag);
			}

			public static void glSwizzleEXT(uint res, uint @in, VertexShaderCoordOutEXT outX, VertexShaderCoordOutEXT outY, VertexShaderCoordOutEXT outZ, VertexShaderCoordOutEXT outW)
			{
				internalGL.glSwizzleEXT(res, @in, outX, outY, outZ, outW);
			}

			public static void glTangent3bEXT(sbyte tx, sbyte ty, sbyte tz)
			{
				internalGL.glTangent3bEXT(tx, ty, tz);
			}

			public static unsafe void glTangent3bvEXT(sbyte* v)
			{
				internalGL.glTangent3bvEXT(v);
			}

			public static void glTangent3dEXT(double tx, double ty, double tz)
			{
				internalGL.glTangent3dEXT(tx, ty, tz);
			}

			public static unsafe void glTangent3dvEXT(double* v)
			{
				internalGL.glTangent3dvEXT(v);
			}

			public static void glTangent3fEXT(float tx, float ty, float tz)
			{
				internalGL.glTangent3fEXT(tx, ty, tz);
			}

			public static unsafe void glTangent3fvEXT(float* v)
			{
				internalGL.glTangent3fvEXT(v);
			}

			public static void glTangent3iEXT(int tx, int ty, int tz)
			{
				internalGL.glTangent3iEXT(tx, ty, tz);
			}

			public static unsafe void glTangent3ivEXT(int* v)
			{
				internalGL.glTangent3ivEXT(v);
			}

			public static void glTangent3sEXT(short tx, short ty, short tz)
			{
				internalGL.glTangent3sEXT(tx, ty, tz);
			}

			public static unsafe void glTangent3svEXT(short* v)
			{
				internalGL.glTangent3svEXT(v);
			}

			public static void glTangentPointerEXT(TangentPointerTypeEXT type, int stride, IntPtr pointer)
			{
				internalGL.glTangentPointerEXT(type, stride, pointer);
			}

			public static void glTexBufferEXT(TextureTarget target, InternalFormat internalformat, uint buffer)
			{
				internalGL.glTexBufferEXT(target, internalformat, buffer);
			}

			public static void glTexCoordPointerEXT(int size, TexCoordPointerType type, int stride, int count, IntPtr pointer)
			{
				internalGL.glTexCoordPointerEXT(size, type, stride, count, pointer);
			}

			public static void glTexImage3DEXT(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, IntPtr pixels)
			{
				internalGL.glTexImage3DEXT(target, level, internalformat, width, height, depth, border, format, type, pixels);
			}

			public static unsafe void glTexParameterIivEXT(TextureTarget target, TextureParameterName pname, int* @params)
			{
				internalGL.glTexParameterIivEXT(target, pname, @params);
			}

			public static unsafe void glTexParameterIuivEXT(TextureTarget target, TextureParameterName pname, uint* @params)
			{
				internalGL.glTexParameterIuivEXT(target, pname, @params);
			}

			public static void glTexSubImage1DEXT(TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, IntPtr pixels)
			{
				internalGL.glTexSubImage1DEXT(target, level, xoffset, width, format, type, pixels);
			}

			public static void glTexSubImage2DEXT(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, IntPtr pixels)
			{
				internalGL.glTexSubImage2DEXT(target, level, xoffset, yoffset, width, height, format, type, pixels);
			}

			public static void glTexSubImage3DEXT(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels)
			{
				internalGL.glTexSubImage3DEXT(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
			}

			public static void glTextureLightEXT(LightTexturePNameEXT pname)
			{
				internalGL.glTextureLightEXT(pname);
			}

			public static void glTextureMaterialEXT(MaterialFace face, MaterialParameter mode)
			{
				internalGL.glTextureMaterialEXT(face, mode);
			}

			public static void glTextureNormalEXT(TextureNormalModeEXT mode)
			{
				internalGL.glTextureNormalEXT(mode);
			}

			public static unsafe void glTransformFeedbackVaryingsEXT(uint program, int count, sbyte* varyings, uint bufferMode)
			{
				internalGL.glTransformFeedbackVaryingsEXT(program, count, varyings, bufferMode);
			}

			public static void glUniform1uiEXT(int location, uint v0)
			{
				internalGL.glUniform1uiEXT(location, v0);
			}

			public static unsafe void glUniform1uivEXT(int location, int count, uint* value)
			{
				internalGL.glUniform1uivEXT(location, count, value);
			}

			public static void glUniform2uiEXT(int location, uint v0, uint v1)
			{
				internalGL.glUniform2uiEXT(location, v0, v1);
			}

			public static unsafe void glUniform2uivEXT(int location, int count, uint* value)
			{
				internalGL.glUniform2uivEXT(location, count, value);
			}

			public static void glUniform3uiEXT(int location, uint v0, uint v1, uint v2)
			{
				internalGL.glUniform3uiEXT(location, v0, v1, v2);
			}

			public static unsafe void glUniform3uivEXT(int location, int count, uint* value)
			{
				internalGL.glUniform3uivEXT(location, count, value);
			}

			public static void glUniform4uiEXT(int location, uint v0, uint v1, uint v2, uint v3)
			{
				internalGL.glUniform4uiEXT(location, v0, v1, v2, v3);
			}

			public static unsafe void glUniform4uivEXT(int location, int count, uint* value)
			{
				internalGL.glUniform4uivEXT(location, count, value);
			}

			public static void glUniformBufferEXT(uint program, int location, uint buffer)
			{
				internalGL.glUniformBufferEXT(program, location, buffer);
			}

			public static void glUnlockArraysEXT()
			{
				internalGL.glUnlockArraysEXT();
			}

			public static unsafe void glVariantbvEXT(uint id, sbyte* addr)
			{
				internalGL.glVariantbvEXT(id, addr);
			}

			public static unsafe void glVariantdvEXT(uint id, double* addr)
			{
				internalGL.glVariantdvEXT(id, addr);
			}

			public static unsafe void glVariantfvEXT(uint id, float* addr)
			{
				internalGL.glVariantfvEXT(id, addr);
			}

			public static unsafe void glVariantivEXT(uint id, int* addr)
			{
				internalGL.glVariantivEXT(id, addr);
			}

			public static void glVariantPointerEXT(uint id, ScalarType type, uint stride, IntPtr addr)
			{
				internalGL.glVariantPointerEXT(id, type, stride, addr);
			}

			public static unsafe void glVariantsvEXT(uint id, short* addr)
			{
				internalGL.glVariantsvEXT(id, addr);
			}

			public static unsafe void glVariantubvEXT(uint id, byte* addr)
			{
				internalGL.glVariantubvEXT(id, addr);
			}

			public static unsafe void glVariantuivEXT(uint id, uint* addr)
			{
				internalGL.glVariantuivEXT(id, addr);
			}

			public static unsafe void glVariantusvEXT(uint id, ushort* addr)
			{
				internalGL.glVariantusvEXT(id, addr);
			}

			public static void glVertexAttribL1dEXT(uint index, double x)
			{
				internalGL.glVertexAttribL1dEXT(index, x);
			}

			public static unsafe void glVertexAttribL1dvEXT(uint index, double* v)
			{
				internalGL.glVertexAttribL1dvEXT(index, v);
			}

			public static void glVertexAttribL2dEXT(uint index, double x, double y)
			{
				internalGL.glVertexAttribL2dEXT(index, x, y);
			}

			public static unsafe void glVertexAttribL2dvEXT(uint index, double* v)
			{
				internalGL.glVertexAttribL2dvEXT(index, v);
			}

			public static void glVertexAttribL3dEXT(uint index, double x, double y, double z)
			{
				internalGL.glVertexAttribL3dEXT(index, x, y, z);
			}

			public static unsafe void glVertexAttribL3dvEXT(uint index, double* v)
			{
				internalGL.glVertexAttribL3dvEXT(index, v);
			}

			public static void glVertexAttribL4dEXT(uint index, double x, double y, double z, double w)
			{
				internalGL.glVertexAttribL4dEXT(index, x, y, z, w);
			}

			public static unsafe void glVertexAttribL4dvEXT(uint index, double* v)
			{
				internalGL.glVertexAttribL4dvEXT(index, v);
			}

			public static void glVertexAttribLPointerEXT(uint index, int size, VertexAttribLType type, int stride, IntPtr pointer)
			{
				internalGL.glVertexAttribLPointerEXT(index, size, type, stride, pointer);
			}

			public static void glVertexPointerEXT(int size, VertexPointerType type, int stride, int count, IntPtr pointer)
			{
				internalGL.glVertexPointerEXT(size, type, stride, count, pointer);
			}

			public static void glVertexWeightfEXT(float weight)
			{
				internalGL.glVertexWeightfEXT(weight);
			}

			public static unsafe void glVertexWeightfvEXT(float* weight)
			{
				internalGL.glVertexWeightfvEXT(weight);
			}

			public static void glVertexWeightPointerEXT(int size, VertexWeightPointerTypeEXT type, int stride, IntPtr pointer)
			{
				internalGL.glVertexWeightPointerEXT(size, type, stride, pointer);
			}

			public static void glWriteMaskEXT(uint res, uint @in, VertexShaderWriteMaskEXT outX, VertexShaderWriteMaskEXT outY, VertexShaderWriteMaskEXT outZ, VertexShaderWriteMaskEXT outW)
			{
				internalGL.glWriteMaskEXT(res, @in, outX, outY, outZ, outW);
			}
		}

		public static class GREMEDY
		{
			public static void glFrameTerminatorGREMEDY()
			{
				internalGL.glFrameTerminatorGREMEDY();
			}

			public static void glStringMarkerGREMEDY(int len, IntPtr @string)
			{
				internalGL.glStringMarkerGREMEDY(len, @string);
			}
		}

		public static class HP
		{
			public static unsafe void glGetImageTransformParameterfvHP(ImageTransformTargetHP target, ImageTransformPNameHP pname, float* @params)
			{
				internalGL.glGetImageTransformParameterfvHP(target, pname, @params);
			}

			public static unsafe void glGetImageTransformParameterivHP(ImageTransformTargetHP target, ImageTransformPNameHP pname, int* @params)
			{
				internalGL.glGetImageTransformParameterivHP(target, pname, @params);
			}

			public static void glImageTransformParameterfHP(ImageTransformTargetHP target, ImageTransformPNameHP pname, float param)
			{
				internalGL.glImageTransformParameterfHP(target, pname, param);
			}

			public static unsafe void glImageTransformParameterfvHP(ImageTransformTargetHP target, ImageTransformPNameHP pname, float* @params)
			{
				internalGL.glImageTransformParameterfvHP(target, pname, @params);
			}

			public static void glImageTransformParameteriHP(ImageTransformTargetHP target, ImageTransformPNameHP pname, int param)
			{
				internalGL.glImageTransformParameteriHP(target, pname, param);
			}

			public static unsafe void glImageTransformParameterivHP(ImageTransformTargetHP target, ImageTransformPNameHP pname, int* @params)
			{
				internalGL.glImageTransformParameterivHP(target, pname, @params);
			}
		}

		public static class IBM
		{
			public static void glColorPointerListIBM(int size, ColorPointerType type, int stride, IntPtr pointer, int ptrstride)
			{
				internalGL.glColorPointerListIBM(size, type, stride, pointer, ptrstride);
			}

			public static unsafe void glEdgeFlagPointerListIBM(int stride, bool* pointer, int ptrstride)
			{
				internalGL.glEdgeFlagPointerListIBM(stride, pointer, ptrstride);
			}

			public static void glFlushStaticDataIBM(uint target)
			{
				internalGL.glFlushStaticDataIBM(target);
			}

			public static void glFogCoordPointerListIBM(FogPointerTypeIBM type, int stride, IntPtr pointer, int ptrstride)
			{
				internalGL.glFogCoordPointerListIBM(type, stride, pointer, ptrstride);
			}

			public static void glIndexPointerListIBM(IndexPointerType type, int stride, IntPtr pointer, int ptrstride)
			{
				internalGL.glIndexPointerListIBM(type, stride, pointer, ptrstride);
			}

			public static unsafe void glMultiModeDrawArraysIBM(PrimitiveType* mode, int* first, int* count, int primcount, int modestride)
			{
				internalGL.glMultiModeDrawArraysIBM(mode, first, count, primcount, modestride);
			}

			public static unsafe void glMultiModeDrawElementsIBM(PrimitiveType* mode, int* count, DrawElementsType type, IntPtr indices, int primcount, int modestride)
			{
				internalGL.glMultiModeDrawElementsIBM(mode, count, type, indices, primcount, modestride);
			}

			public static void glNormalPointerListIBM(NormalPointerType type, int stride, IntPtr pointer, int ptrstride)
			{
				internalGL.glNormalPointerListIBM(type, stride, pointer, ptrstride);
			}

			public static void glSecondaryColorPointerListIBM(int size, SecondaryColorPointerTypeIBM type, int stride, IntPtr pointer, int ptrstride)
			{
				internalGL.glSecondaryColorPointerListIBM(size, type, stride, pointer, ptrstride);
			}

			public static void glTexCoordPointerListIBM(int size, TexCoordPointerType type, int stride, IntPtr pointer, int ptrstride)
			{
				internalGL.glTexCoordPointerListIBM(size, type, stride, pointer, ptrstride);
			}

			public static void glVertexPointerListIBM(int size, VertexPointerType type, int stride, IntPtr pointer, int ptrstride)
			{
				internalGL.glVertexPointerListIBM(size, type, stride, pointer, ptrstride);
			}
		}

		public static class INGR
		{
			public static void glBlendFuncSeparateINGR(BlendingFactor sfactorRGB, BlendingFactor dfactorRGB, BlendingFactor sfactorAlpha, BlendingFactor dfactorAlpha)
			{
				internalGL.glBlendFuncSeparateINGR(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
			}
		}

		public static class INTEL
		{
			public static void glColorPointervINTEL(int size, VertexPointerType type, IntPtr pointer)
			{
				internalGL.glColorPointervINTEL(size, type, pointer);
			}

			public static unsafe IntPtr* glMapTexture2DINTEL(uint texture, int level, uint access, int* stride, uint* layout)
			{
				return internalGL.glMapTexture2DINTEL(texture, level, access, stride, layout);
			}

			public static void glNormalPointervINTEL(NormalPointerType type, IntPtr pointer)
			{
				internalGL.glNormalPointervINTEL(type, pointer);
			}

			public static void glSyncTextureINTEL(uint texture)
			{
				internalGL.glSyncTextureINTEL(texture);
			}

			public static void glTexCoordPointervINTEL(int size, VertexPointerType type, IntPtr pointer)
			{
				internalGL.glTexCoordPointervINTEL(size, type, pointer);
			}

			public static void glUnmapTexture2DINTEL(uint texture, int level)
			{
				internalGL.glUnmapTexture2DINTEL(texture, level);
			}

			public static void glVertexPointervINTEL(int size, VertexPointerType type, IntPtr pointer)
			{
				internalGL.glVertexPointervINTEL(size, type, pointer);
			}
		}

		public static class MESA
		{
			public static void glResizeBuffersMESA()
			{
				internalGL.glResizeBuffersMESA();
			}

			public static void glWindowPos2dMESA(double x, double y)
			{
				internalGL.glWindowPos2dMESA(x, y);
			}

			public static unsafe void glWindowPos2dvMESA(double* v)
			{
				internalGL.glWindowPos2dvMESA(v);
			}

			public static void glWindowPos2fMESA(float x, float y)
			{
				internalGL.glWindowPos2fMESA(x, y);
			}

			public static unsafe void glWindowPos2fvMESA(float* v)
			{
				internalGL.glWindowPos2fvMESA(v);
			}

			public static void glWindowPos2iMESA(int x, int y)
			{
				internalGL.glWindowPos2iMESA(x, y);
			}

			public static unsafe void glWindowPos2ivMESA(int* v)
			{
				internalGL.glWindowPos2ivMESA(v);
			}

			public static void glWindowPos2sMESA(short x, short y)
			{
				internalGL.glWindowPos2sMESA(x, y);
			}

			public static unsafe void glWindowPos2svMESA(short* v)
			{
				internalGL.glWindowPos2svMESA(v);
			}

			public static void glWindowPos3dMESA(double x, double y, double z)
			{
				internalGL.glWindowPos3dMESA(x, y, z);
			}

			public static unsafe void glWindowPos3dvMESA(double* v)
			{
				internalGL.glWindowPos3dvMESA(v);
			}

			public static void glWindowPos3fMESA(float x, float y, float z)
			{
				internalGL.glWindowPos3fMESA(x, y, z);
			}

			public static unsafe void glWindowPos3fvMESA(float* v)
			{
				internalGL.glWindowPos3fvMESA(v);
			}

			public static void glWindowPos3iMESA(int x, int y, int z)
			{
				internalGL.glWindowPos3iMESA(x, y, z);
			}

			public static unsafe void glWindowPos3ivMESA(int* v)
			{
				internalGL.glWindowPos3ivMESA(v);
			}

			public static void glWindowPos3sMESA(short x, short y, short z)
			{
				internalGL.glWindowPos3sMESA(x, y, z);
			}

			public static unsafe void glWindowPos3svMESA(short* v)
			{
				internalGL.glWindowPos3svMESA(v);
			}

			public static void glWindowPos4dMESA(double x, double y, double z, double w)
			{
				internalGL.glWindowPos4dMESA(x, y, z, w);
			}

			public static unsafe void glWindowPos4dvMESA(double* v)
			{
				internalGL.glWindowPos4dvMESA(v);
			}

			public static void glWindowPos4fMESA(float x, float y, float z, float w)
			{
				internalGL.glWindowPos4fMESA(x, y, z, w);
			}

			public static unsafe void glWindowPos4fvMESA(float* v)
			{
				internalGL.glWindowPos4fvMESA(v);
			}

			public static void glWindowPos4iMESA(int x, int y, int z, int w)
			{
				internalGL.glWindowPos4iMESA(x, y, z, w);
			}

			public static unsafe void glWindowPos4ivMESA(int* v)
			{
				internalGL.glWindowPos4ivMESA(v);
			}

			public static void glWindowPos4sMESA(short x, short y, short z, short w)
			{
				internalGL.glWindowPos4sMESA(x, y, z, w);
			}

			public static unsafe void glWindowPos4svMESA(short* v)
			{
				internalGL.glWindowPos4svMESA(v);
			}
		}

		public static class NV
		{
			public static unsafe void glActiveVaryingNV(uint program, sbyte* name)
			{
				internalGL.glActiveVaryingNV(program, name);
			}

			public static void glAlphaToCoverageDitherControlNV(uint mode)
			{
				internalGL.glAlphaToCoverageDitherControlNV(mode);
			}

			public static unsafe bool glAreProgramsResidentNV(int n, uint* programs, Boolean* residences)
			{
				return internalGL.glAreProgramsResidentNV(n, programs, residences);
			}

			public static void glBeginOcclusionQueryNV(uint id)
			{
				internalGL.glBeginOcclusionQueryNV(id);
			}

			public static void glBeginTransformFeedbackNV(PrimitiveType primitiveMode)
			{
				internalGL.glBeginTransformFeedbackNV(primitiveMode);
			}

			public static void glBeginVideoCaptureNV(uint video_capture_slot)
			{
				internalGL.glBeginVideoCaptureNV(video_capture_slot);
			}

			public static void glBindBufferBaseNV(BufferTargetARB target, uint index, uint buffer)
			{
				internalGL.glBindBufferBaseNV(target, index, buffer);
			}

			public static void glBindBufferOffsetNV(BufferTargetARB target, uint index, uint buffer, IntPtr offset)
			{
				internalGL.glBindBufferOffsetNV(target, index, buffer, offset);
			}

			public static void glBindBufferRangeNV(BufferTargetARB target, uint index, uint buffer, IntPtr offset, int size)
			{
				internalGL.glBindBufferRangeNV(target, index, buffer, offset, size);
			}

			public static void glBindProgramNV(VertexAttribEnumNV target, uint id)
			{
				internalGL.glBindProgramNV(target, id);
			}

			public static void glBindTransformFeedbackNV(BufferTargetARB target, uint id)
			{
				internalGL.glBindTransformFeedbackNV(target, id);
			}

			public static void glBindVideoCaptureStreamBufferNV(uint video_capture_slot, uint stream, uint frame_region, IntPtr offset)
			{
				internalGL.glBindVideoCaptureStreamBufferNV(video_capture_slot, stream, frame_region, offset);
			}

			public static void glBindVideoCaptureStreamTextureNV(uint video_capture_slot, uint stream, uint frame_region, uint target, uint texture)
			{
				internalGL.glBindVideoCaptureStreamTextureNV(video_capture_slot, stream, frame_region, target, texture);
			}

			public static void glColor3hNV(ushort red, ushort green, ushort blue)
			{
				internalGL.glColor3hNV(red, green, blue);
			}

			public static unsafe void glColor3hvNV(ushort* v)
			{
				internalGL.glColor3hvNV(v);
			}

			public static void glColor4hNV(ushort red, ushort green, ushort blue, ushort alpha)
			{
				internalGL.glColor4hNV(red, green, blue, alpha);
			}

			public static unsafe void glColor4hvNV(ushort* v)
			{
				internalGL.glColor4hvNV(v);
			}

			public static void glCombinerInputNV(CombinerStageNV stage, CombinerPortionNV portion, CombinerVariableNV variable, CombinerRegisterNV input, CombinerMappingNV mapping, CombinerComponentUsageNV componentUsage)
			{
				internalGL.glCombinerInputNV(stage, portion, variable, input, mapping, componentUsage);
			}

			public static void glCombinerOutputNV(CombinerStageNV stage, CombinerPortionNV portion, CombinerRegisterNV abOutput, CombinerRegisterNV cdOutput, CombinerRegisterNV sumOutput, CombinerScaleNV scale, CombinerBiasNV bias, Boolean abDotProduct, Boolean cdDotProduct, Boolean muxSum)
			{
				internalGL.glCombinerOutputNV(stage, portion, abOutput, cdOutput, sumOutput, scale, bias, abDotProduct, cdDotProduct, muxSum);
			}

			public static void glCombinerParameterfNV(CombinerParameterNV pname, float param)
			{
				internalGL.glCombinerParameterfNV(pname, param);
			}

			public static unsafe void glCombinerParameterfvNV(CombinerParameterNV pname, float* @params)
			{
				internalGL.glCombinerParameterfvNV(pname, @params);
			}

			public static void glCombinerParameteriNV(CombinerParameterNV pname, int param)
			{
				internalGL.glCombinerParameteriNV(pname, param);
			}

			public static unsafe void glCombinerParameterivNV(CombinerParameterNV pname, int* @params)
			{
				internalGL.glCombinerParameterivNV(pname, @params);
			}

			public static unsafe void glCombinerStageParameterfvNV(CombinerStageNV stage, CombinerParameterNV pname, float* @params)
			{
				internalGL.glCombinerStageParameterfvNV(stage, pname, @params);
			}

			public static void glCopyImageSubDataNV(uint srcName, CopyBufferSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyBufferSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth)
			{
				internalGL.glCopyImageSubDataNV(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth);
			}

			public static unsafe void glDeleteOcclusionQueriesNV(int n, uint* ids)
			{
				internalGL.glDeleteOcclusionQueriesNV(n, ids);
			}

			public static unsafe void glDeleteProgramsNV(int n, uint* programs)
			{
				internalGL.glDeleteProgramsNV(n, programs);
			}

			public static unsafe void glDeleteQueryResourceTagNV(int n, int* tagIds)
			{
				internalGL.glDeleteQueryResourceTagNV(n, tagIds);
			}

			public static unsafe void glDeleteTransformFeedbacksNV(int n, uint* ids)
			{
				internalGL.glDeleteTransformFeedbacksNV(n, ids);
			}

			public static void glDrawTextureNV(uint texture, uint sampler, float x0, float y0, float x1, float y1, float z, float s0, float t0, float s1, float t1)
			{
				internalGL.glDrawTextureNV(texture, sampler, x0, y0, x1, y1, z, s0, t0, s1, t1);
			}

			public static void glDrawTransformFeedbackNV(PrimitiveType mode, uint id)
			{
				internalGL.glDrawTransformFeedbackNV(mode, id);
			}

			public static void glEndOcclusionQueryNV()
			{
				internalGL.glEndOcclusionQueryNV();
			}

			public static void glEndTransformFeedbackNV()
			{
				internalGL.glEndTransformFeedbackNV();
			}

			public static void glEndVideoCaptureNV(uint video_capture_slot)
			{
				internalGL.glEndVideoCaptureNV(video_capture_slot);
			}

			public static void glEvalMapsNV(EvalTargetNV target, EvalMapsModeNV mode)
			{
				internalGL.glEvalMapsNV(target, mode);
			}

			public static unsafe void glExecuteProgramNV(VertexAttribEnumNV target, uint id, float* @params)
			{
				internalGL.glExecuteProgramNV(target, id, @params);
			}

			public static void glFinalCombinerInputNV(CombinerVariableNV variable, CombinerRegisterNV input, CombinerMappingNV mapping, CombinerComponentUsageNV componentUsage)
			{
				internalGL.glFinalCombinerInputNV(variable, input, mapping, componentUsage);
			}

			public static void glFlushPixelDataRangeNV(PixelDataRangeTargetNV target)
			{
				internalGL.glFlushPixelDataRangeNV(target);
			}

			public static void glFlushVertexArrayRangeNV()
			{
				internalGL.glFlushVertexArrayRangeNV();
			}

			public static void glFogCoordhNV(ushort fog)
			{
				internalGL.glFogCoordhNV(fog);
			}

			public static unsafe void glFogCoordhvNV(ushort* fog)
			{
				internalGL.glFogCoordhvNV(fog);
			}

			public static void glFramebufferTextureEXT(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level)
			{
				internalGL.glFramebufferTextureEXT(target, attachment, texture, level);
			}

			public static void glFramebufferTextureFaceEXT(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, TextureTarget face)
			{
				internalGL.glFramebufferTextureFaceEXT(target, attachment, texture, level, face);
			}

			public static void glFramebufferTextureLayerEXT(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, int layer)
			{
				internalGL.glFramebufferTextureLayerEXT(target, attachment, texture, level, layer);
			}

			public static unsafe void glGenOcclusionQueriesNV(int n, uint* ids)
			{
				internalGL.glGenOcclusionQueriesNV(n, ids);
			}

			public static unsafe void glGenProgramsNV(int n, uint* programs)
			{
				internalGL.glGenProgramsNV(n, programs);
			}

			public static unsafe void glGenQueryResourceTagNV(int n, int* tagIds)
			{
				internalGL.glGenQueryResourceTagNV(n, tagIds);
			}

			public static unsafe void glGenTransformFeedbacksNV(int n, uint* ids)
			{
				internalGL.glGenTransformFeedbacksNV(n, ids);
			}

			public static unsafe void glGetActiveVaryingNV(uint program, uint index, int bufSize, int* length, int* size, uint* type, sbyte* name)
			{
				internalGL.glGetActiveVaryingNV(program, index, bufSize, length, size, type, name);
			}

			public static unsafe void glGetCombinerInputParameterfvNV(CombinerStageNV stage, CombinerPortionNV portion, CombinerVariableNV variable, CombinerParameterNV pname, float* @params)
			{
				internalGL.glGetCombinerInputParameterfvNV(stage, portion, variable, pname, @params);
			}

			public static unsafe void glGetCombinerInputParameterivNV(CombinerStageNV stage, CombinerPortionNV portion, CombinerVariableNV variable, CombinerParameterNV pname, int* @params)
			{
				internalGL.glGetCombinerInputParameterivNV(stage, portion, variable, pname, @params);
			}

			public static unsafe void glGetCombinerOutputParameterfvNV(CombinerStageNV stage, CombinerPortionNV portion, CombinerParameterNV pname, float* @params)
			{
				internalGL.glGetCombinerOutputParameterfvNV(stage, portion, pname, @params);
			}

			public static unsafe void glGetCombinerOutputParameterivNV(CombinerStageNV stage, CombinerPortionNV portion, CombinerParameterNV pname, int* @params)
			{
				internalGL.glGetCombinerOutputParameterivNV(stage, portion, pname, @params);
			}

			public static unsafe void glGetCombinerStageParameterfvNV(CombinerStageNV stage, CombinerParameterNV pname, float* @params)
			{
				internalGL.glGetCombinerStageParameterfvNV(stage, pname, @params);
			}

			public static unsafe void glGetFinalCombinerInputParameterfvNV(CombinerVariableNV variable, CombinerParameterNV pname, float* @params)
			{
				internalGL.glGetFinalCombinerInputParameterfvNV(variable, pname, @params);
			}

			public static unsafe void glGetFinalCombinerInputParameterivNV(CombinerVariableNV variable, CombinerParameterNV pname, int* @params)
			{
				internalGL.glGetFinalCombinerInputParameterivNV(variable, pname, @params);
			}

			public static unsafe void glGetMapAttribParameterfvNV(EvalTargetNV target, uint index, MapAttribParameterNV pname, float* @params)
			{
				internalGL.glGetMapAttribParameterfvNV(target, index, pname, @params);
			}

			public static unsafe void glGetMapAttribParameterivNV(EvalTargetNV target, uint index, MapAttribParameterNV pname, int* @params)
			{
				internalGL.glGetMapAttribParameterivNV(target, index, pname, @params);
			}

			public static void glGetMapControlPointsNV(EvalTargetNV target, uint index, MapTypeNV type, int ustride, int vstride, Boolean packed, IntPtr points)
			{
				internalGL.glGetMapControlPointsNV(target, index, type, ustride, vstride, packed, points);
			}

			public static unsafe void glGetMapParameterfvNV(EvalTargetNV target, MapParameterNV pname, float* @params)
			{
				internalGL.glGetMapParameterfvNV(target, pname, @params);
			}

			public static unsafe void glGetMapParameterivNV(EvalTargetNV target, MapParameterNV pname, int* @params)
			{
				internalGL.glGetMapParameterivNV(target, pname, @params);
			}

			public static unsafe void glGetMultisamplefvNV(GetMultisamplePNameNV pname, uint index, float* val)
			{
				internalGL.glGetMultisamplefvNV(pname, index, val);
			}

			public static unsafe void glGetOcclusionQueryivNV(uint id, OcclusionQueryParameterNameNV pname, int* @params)
			{
				internalGL.glGetOcclusionQueryivNV(id, pname, @params);
			}

			public static unsafe void glGetOcclusionQueryuivNV(uint id, OcclusionQueryParameterNameNV pname, uint* @params)
			{
				internalGL.glGetOcclusionQueryuivNV(id, pname, @params);
			}

			public static unsafe void glGetProgramEnvParameterIivNV(ProgramTarget target, uint index, int* @params)
			{
				internalGL.glGetProgramEnvParameterIivNV(target, index, @params);
			}

			public static unsafe void glGetProgramEnvParameterIuivNV(ProgramTarget target, uint index, uint* @params)
			{
				internalGL.glGetProgramEnvParameterIuivNV(target, index, @params);
			}

			public static unsafe void glGetProgramivNV(uint id, VertexAttribEnumNV pname, int* @params)
			{
				internalGL.glGetProgramivNV(id, pname, @params);
			}

			public static unsafe void glGetProgramLocalParameterIivNV(ProgramTarget target, uint index, int* @params)
			{
				internalGL.glGetProgramLocalParameterIivNV(target, index, @params);
			}

			public static unsafe void glGetProgramLocalParameterIuivNV(ProgramTarget target, uint index, uint* @params)
			{
				internalGL.glGetProgramLocalParameterIuivNV(target, index, @params);
			}

			public static unsafe void glGetProgramNamedParameterdvNV(uint id, int len, byte* name, double* @params)
			{
				internalGL.glGetProgramNamedParameterdvNV(id, len, name, @params);
			}

			public static unsafe void glGetProgramNamedParameterfvNV(uint id, int len, byte* name, float* @params)
			{
				internalGL.glGetProgramNamedParameterfvNV(id, len, name, @params);
			}

			public static unsafe void glGetProgramParameterdvNV(VertexAttribEnumNV target, uint index, VertexAttribEnumNV pname, double* @params)
			{
				internalGL.glGetProgramParameterdvNV(target, index, pname, @params);
			}

			public static unsafe void glGetProgramParameterfvNV(VertexAttribEnumNV target, uint index, VertexAttribEnumNV pname, float* @params)
			{
				internalGL.glGetProgramParameterfvNV(target, index, pname, @params);
			}

			public static unsafe void glGetProgramStringNV(uint id, VertexAttribEnumNV pname, byte* program)
			{
				internalGL.glGetProgramStringNV(id, pname, program);
			}

			public static unsafe void glGetProgramSubroutineParameteruivNV(uint target, uint index, uint* param)
			{
				internalGL.glGetProgramSubroutineParameteruivNV(target, index, param);
			}

			public static unsafe void glGetTrackMatrixivNV(VertexAttribEnumNV target, uint address, VertexAttribEnumNV pname, int* @params)
			{
				internalGL.glGetTrackMatrixivNV(target, address, pname, @params);
			}

			public static unsafe void glGetTransformFeedbackVaryingNV(uint program, uint index, int* location)
			{
				internalGL.glGetTransformFeedbackVaryingNV(program, index, location);
			}

			public static unsafe int glGetVaryingLocationNV(uint program, sbyte* name)
			{
				return internalGL.glGetVaryingLocationNV(program, name);
			}

			public static unsafe void glGetVertexAttribdvNV(uint index, VertexAttribEnumNV pname, double* @params)
			{
				internalGL.glGetVertexAttribdvNV(index, pname, @params);
			}

			public static unsafe void glGetVertexAttribfvNV(uint index, VertexAttribEnumNV pname, float* @params)
			{
				internalGL.glGetVertexAttribfvNV(index, pname, @params);
			}

			public static unsafe void glGetVertexAttribIivEXT(uint index, VertexAttribEnum pname, int* @params)
			{
				internalGL.glGetVertexAttribIivEXT(index, pname, @params);
			}

			public static unsafe void glGetVertexAttribIuivEXT(uint index, VertexAttribEnum pname, uint* @params)
			{
				internalGL.glGetVertexAttribIuivEXT(index, pname, @params);
			}

			public static unsafe void glGetVertexAttribivNV(uint index, VertexAttribEnumNV pname, int* @params)
			{
				internalGL.glGetVertexAttribivNV(index, pname, @params);
			}

			public static void glGetVertexAttribPointervNV(uint index, VertexAttribEnumNV pname, IntPtr pointer)
			{
				internalGL.glGetVertexAttribPointervNV(index, pname, pointer);
			}

			public static unsafe void glGetVideoCaptureivNV(uint video_capture_slot, uint pname, int* @params)
			{
				internalGL.glGetVideoCaptureivNV(video_capture_slot, pname, @params);
			}

			public static unsafe void glGetVideoCaptureStreamdvNV(uint video_capture_slot, uint stream, uint pname, double* @params)
			{
				internalGL.glGetVideoCaptureStreamdvNV(video_capture_slot, stream, pname, @params);
			}

			public static unsafe void glGetVideoCaptureStreamfvNV(uint video_capture_slot, uint stream, uint pname, float* @params)
			{
				internalGL.glGetVideoCaptureStreamfvNV(video_capture_slot, stream, pname, @params);
			}

			public static unsafe void glGetVideoCaptureStreamivNV(uint video_capture_slot, uint stream, uint pname, int* @params)
			{
				internalGL.glGetVideoCaptureStreamivNV(video_capture_slot, stream, pname, @params);
			}

			public static unsafe void glGetVideoi64vNV(uint video_slot, uint pname, long* @params)
			{
				internalGL.glGetVideoi64vNV(video_slot, pname, @params);
			}

			public static unsafe void glGetVideoivNV(uint video_slot, uint pname, int* @params)
			{
				internalGL.glGetVideoivNV(video_slot, pname, @params);
			}

			public static unsafe void glGetVideoui64vNV(uint video_slot, uint pname, ulong* @params)
			{
				internalGL.glGetVideoui64vNV(video_slot, pname, @params);
			}

			public static unsafe void glGetVideouivNV(uint video_slot, uint pname, uint* @params)
			{
				internalGL.glGetVideouivNV(video_slot, pname, @params);
			}

			public static bool glIsOcclusionQueryNV(uint id)
			{
				return internalGL.glIsOcclusionQueryNV(id);
			}

			public static bool glIsProgramNV(uint id)
			{
				return internalGL.glIsProgramNV(id);
			}

			public static bool glIsTransformFeedbackNV(uint id)
			{
				return internalGL.glIsTransformFeedbackNV(id);
			}

			public static unsafe void glLoadProgramNV(VertexAttribEnumNV target, uint id, int len, byte* program)
			{
				internalGL.glLoadProgramNV(target, id, len, program);
			}

			public static void glMapControlPointsNV(EvalTargetNV target, uint index, MapTypeNV type, int ustride, int vstride, int uorder, int vorder, Boolean packed, IntPtr points)
			{
				internalGL.glMapControlPointsNV(target, index, type, ustride, vstride, uorder, vorder, packed, points);
			}

			public static unsafe void glMapParameterfvNV(EvalTargetNV target, MapParameterNV pname, float* @params)
			{
				internalGL.glMapParameterfvNV(target, pname, @params);
			}

			public static unsafe void glMapParameterivNV(EvalTargetNV target, MapParameterNV pname, int* @params)
			{
				internalGL.glMapParameterivNV(target, pname, @params);
			}

			public static void glMulticastBarrierNV()
			{
				internalGL.glMulticastBarrierNV();
			}

			public static void glMulticastBlitFramebufferNV(uint srcGpu, uint dstGpu, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, uint filter)
			{
				internalGL.glMulticastBlitFramebufferNV(srcGpu, dstGpu, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
			}

			public static void glMulticastBufferSubDataNV(uint gpuMask, uint buffer, IntPtr offset, int size, IntPtr data)
			{
				internalGL.glMulticastBufferSubDataNV(gpuMask, buffer, offset, size, data);
			}

			public static void glMulticastCopyBufferSubDataNV(uint readGpu, uint writeGpuMask, uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, int size)
			{
				internalGL.glMulticastCopyBufferSubDataNV(readGpu, writeGpuMask, readBuffer, writeBuffer, readOffset, writeOffset, size);
			}

			public static void glMulticastCopyImageSubDataNV(uint srcGpu, uint dstGpuMask, uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth)
			{
				internalGL.glMulticastCopyImageSubDataNV(srcGpu, dstGpuMask, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
			}

			public static unsafe void glMulticastFramebufferSampleLocationsfvNV(uint gpu, uint framebuffer, uint start, int count, float* v)
			{
				internalGL.glMulticastFramebufferSampleLocationsfvNV(gpu, framebuffer, start, count, v);
			}

			public static unsafe void glMulticastGetQueryObjecti64vNV(uint gpu, uint id, uint pname, long* @params)
			{
				internalGL.glMulticastGetQueryObjecti64vNV(gpu, id, pname, @params);
			}

			public static unsafe void glMulticastGetQueryObjectivNV(uint gpu, uint id, uint pname, int* @params)
			{
				internalGL.glMulticastGetQueryObjectivNV(gpu, id, pname, @params);
			}

			public static unsafe void glMulticastGetQueryObjectui64vNV(uint gpu, uint id, uint pname, ulong* @params)
			{
				internalGL.glMulticastGetQueryObjectui64vNV(gpu, id, pname, @params);
			}

			public static unsafe void glMulticastGetQueryObjectuivNV(uint gpu, uint id, uint pname, uint* @params)
			{
				internalGL.glMulticastGetQueryObjectuivNV(gpu, id, pname, @params);
			}

			public static void glMulticastWaitSyncNV(uint signalGpu, uint waitGpuMask)
			{
				internalGL.glMulticastWaitSyncNV(signalGpu, waitGpuMask);
			}

			public static void glMultiTexCoord1hNV(TextureUnit target, ushort s)
			{
				internalGL.glMultiTexCoord1hNV(target, s);
			}

			public static unsafe void glMultiTexCoord1hvNV(TextureUnit target, ushort* v)
			{
				internalGL.glMultiTexCoord1hvNV(target, v);
			}

			public static void glMultiTexCoord2hNV(TextureUnit target, ushort s, ushort t)
			{
				internalGL.glMultiTexCoord2hNV(target, s, t);
			}

			public static unsafe void glMultiTexCoord2hvNV(TextureUnit target, ushort* v)
			{
				internalGL.glMultiTexCoord2hvNV(target, v);
			}

			public static void glMultiTexCoord3hNV(TextureUnit target, ushort s, ushort t, ushort r)
			{
				internalGL.glMultiTexCoord3hNV(target, s, t, r);
			}

			public static unsafe void glMultiTexCoord3hvNV(TextureUnit target, ushort* v)
			{
				internalGL.glMultiTexCoord3hvNV(target, v);
			}

			public static void glMultiTexCoord4hNV(TextureUnit target, ushort s, ushort t, ushort r, ushort q)
			{
				internalGL.glMultiTexCoord4hNV(target, s, t, r, q);
			}

			public static unsafe void glMultiTexCoord4hvNV(TextureUnit target, ushort* v)
			{
				internalGL.glMultiTexCoord4hvNV(target, v);
			}

			public static void glNormal3hNV(ushort nx, ushort ny, ushort nz)
			{
				internalGL.glNormal3hNV(nx, ny, nz);
			}

			public static unsafe void glNormal3hvNV(ushort* v)
			{
				internalGL.glNormal3hvNV(v);
			}

			public static void glPauseTransformFeedbackNV()
			{
				internalGL.glPauseTransformFeedbackNV();
			}

			public static void glPixelDataRangeNV(PixelDataRangeTargetNV target, int length, IntPtr pointer)
			{
				internalGL.glPixelDataRangeNV(target, length, pointer);
			}

			public static void glPointParameteriNV(PointParameterNameARB pname, int param)
			{
				internalGL.glPointParameteriNV(pname, param);
			}

			public static unsafe void glPointParameterivNV(PointParameterNameARB pname, int* @params)
			{
				internalGL.glPointParameterivNV(pname, @params);
			}

			public static void glPresentFrameDualFillNV(uint video_slot, ulong minPresentTime, uint beginPresentTimeId, uint presentDurationId, uint type, uint target0, uint fill0, uint target1, uint fill1, uint target2, uint fill2, uint target3, uint fill3)
			{
				internalGL.glPresentFrameDualFillNV(video_slot, minPresentTime, beginPresentTimeId, presentDurationId, type, target0, fill0, target1, fill1, target2, fill2, target3, fill3);
			}

			public static void glPresentFrameKeyedNV(uint video_slot, ulong minPresentTime, uint beginPresentTimeId, uint presentDurationId, uint type, uint target0, uint fill0, uint key0, uint target1, uint fill1, uint key1)
			{
				internalGL.glPresentFrameKeyedNV(video_slot, minPresentTime, beginPresentTimeId, presentDurationId, type, target0, fill0, key0, target1, fill1, key1);
			}

			public static void glPrimitiveRestartIndexNV(uint index)
			{
				internalGL.glPrimitiveRestartIndexNV(index);
			}

			public static void glPrimitiveRestartNV()
			{
				internalGL.glPrimitiveRestartNV();
			}

			public static unsafe void glProgramBufferParametersfvNV(ProgramTarget target, uint bindingIndex, uint wordIndex, int count, float* @params)
			{
				internalGL.glProgramBufferParametersfvNV(target, bindingIndex, wordIndex, count, @params);
			}

			public static unsafe void glProgramBufferParametersIivNV(ProgramTarget target, uint bindingIndex, uint wordIndex, int count, int* @params)
			{
				internalGL.glProgramBufferParametersIivNV(target, bindingIndex, wordIndex, count, @params);
			}

			public static unsafe void glProgramBufferParametersIuivNV(ProgramTarget target, uint bindingIndex, uint wordIndex, int count, uint* @params)
			{
				internalGL.glProgramBufferParametersIuivNV(target, bindingIndex, wordIndex, count, @params);
			}

			public static void glProgramEnvParameterI4iNV(ProgramTarget target, uint index, int x, int y, int z, int w)
			{
				internalGL.glProgramEnvParameterI4iNV(target, index, x, y, z, w);
			}

			public static unsafe void glProgramEnvParameterI4ivNV(ProgramTarget target, uint index, int* @params)
			{
				internalGL.glProgramEnvParameterI4ivNV(target, index, @params);
			}

			public static void glProgramEnvParameterI4uiNV(ProgramTarget target, uint index, uint x, uint y, uint z, uint w)
			{
				internalGL.glProgramEnvParameterI4uiNV(target, index, x, y, z, w);
			}

			public static unsafe void glProgramEnvParameterI4uivNV(ProgramTarget target, uint index, uint* @params)
			{
				internalGL.glProgramEnvParameterI4uivNV(target, index, @params);
			}

			public static unsafe void glProgramEnvParametersI4ivNV(ProgramTarget target, uint index, int count, int* @params)
			{
				internalGL.glProgramEnvParametersI4ivNV(target, index, count, @params);
			}

			public static unsafe void glProgramEnvParametersI4uivNV(ProgramTarget target, uint index, int count, uint* @params)
			{
				internalGL.glProgramEnvParametersI4uivNV(target, index, count, @params);
			}

			public static void glProgramLocalParameterI4iNV(ProgramTarget target, uint index, int x, int y, int z, int w)
			{
				internalGL.glProgramLocalParameterI4iNV(target, index, x, y, z, w);
			}

			public static unsafe void glProgramLocalParameterI4ivNV(ProgramTarget target, uint index, int* @params)
			{
				internalGL.glProgramLocalParameterI4ivNV(target, index, @params);
			}

			public static void glProgramLocalParameterI4uiNV(ProgramTarget target, uint index, uint x, uint y, uint z, uint w)
			{
				internalGL.glProgramLocalParameterI4uiNV(target, index, x, y, z, w);
			}

			public static unsafe void glProgramLocalParameterI4uivNV(ProgramTarget target, uint index, uint* @params)
			{
				internalGL.glProgramLocalParameterI4uivNV(target, index, @params);
			}

			public static unsafe void glProgramLocalParametersI4ivNV(ProgramTarget target, uint index, int count, int* @params)
			{
				internalGL.glProgramLocalParametersI4ivNV(target, index, count, @params);
			}

			public static unsafe void glProgramLocalParametersI4uivNV(ProgramTarget target, uint index, int count, uint* @params)
			{
				internalGL.glProgramLocalParametersI4uivNV(target, index, count, @params);
			}

			public static unsafe void glProgramNamedParameter4dNV(uint id, int len, byte* name, double x, double y, double z, double w)
			{
				internalGL.glProgramNamedParameter4dNV(id, len, name, x, y, z, w);
			}

			public static unsafe void glProgramNamedParameter4dvNV(uint id, int len, byte* name, double* v)
			{
				internalGL.glProgramNamedParameter4dvNV(id, len, name, v);
			}

			public static unsafe void glProgramNamedParameter4fNV(uint id, int len, byte* name, float x, float y, float z, float w)
			{
				internalGL.glProgramNamedParameter4fNV(id, len, name, x, y, z, w);
			}

			public static unsafe void glProgramNamedParameter4fvNV(uint id, int len, byte* name, float* v)
			{
				internalGL.glProgramNamedParameter4fvNV(id, len, name, v);
			}

			public static void glProgramParameter4dNV(VertexAttribEnumNV target, uint index, double x, double y, double z, double w)
			{
				internalGL.glProgramParameter4dNV(target, index, x, y, z, w);
			}

			public static unsafe void glProgramParameter4dvNV(VertexAttribEnumNV target, uint index, double* v)
			{
				internalGL.glProgramParameter4dvNV(target, index, v);
			}

			public static void glProgramParameter4fNV(VertexAttribEnumNV target, uint index, float x, float y, float z, float w)
			{
				internalGL.glProgramParameter4fNV(target, index, x, y, z, w);
			}

			public static unsafe void glProgramParameter4fvNV(VertexAttribEnumNV target, uint index, float* v)
			{
				internalGL.glProgramParameter4fvNV(target, index, v);
			}

			public static unsafe void glProgramParameters4dvNV(VertexAttribEnumNV target, uint index, int count, double* v)
			{
				internalGL.glProgramParameters4dvNV(target, index, count, v);
			}

			public static unsafe void glProgramParameters4fvNV(VertexAttribEnumNV target, uint index, int count, float* v)
			{
				internalGL.glProgramParameters4fvNV(target, index, count, v);
			}

			public static unsafe void glProgramSubroutineParametersuivNV(uint target, int count, uint* @params)
			{
				internalGL.glProgramSubroutineParametersuivNV(target, count, @params);
			}

			public static void glProgramVertexLimitNV(ProgramTarget target, int limit)
			{
				internalGL.glProgramVertexLimitNV(target, limit);
			}

			public static unsafe int glQueryResourceNV(uint queryType, int tagId, uint count, int* buffer)
			{
				return internalGL.glQueryResourceNV(queryType, tagId, count, buffer);
			}

			public static unsafe void glQueryResourceTagNV(int tagId, sbyte* tagString)
			{
				internalGL.glQueryResourceTagNV(tagId, tagString);
			}

			public static void glRenderGpuMaskNV(uint mask)
			{
				internalGL.glRenderGpuMaskNV(mask);
			}

			public static unsafe void glRequestResidentProgramsNV(int n, uint* programs)
			{
				internalGL.glRequestResidentProgramsNV(n, programs);
			}

			public static void glResumeTransformFeedbackNV()
			{
				internalGL.glResumeTransformFeedbackNV();
			}

			public static void glSampleMaskIndexedNV(uint index, uint mask)
			{
				internalGL.glSampleMaskIndexedNV(index, mask);
			}

			public static void glSecondaryColor3hNV(ushort red, ushort green, ushort blue)
			{
				internalGL.glSecondaryColor3hNV(red, green, blue);
			}

			public static unsafe void glSecondaryColor3hvNV(ushort* v)
			{
				internalGL.glSecondaryColor3hvNV(v);
			}

			public static void glTexCoord1hNV(ushort s)
			{
				internalGL.glTexCoord1hNV(s);
			}

			public static unsafe void glTexCoord1hvNV(ushort* v)
			{
				internalGL.glTexCoord1hvNV(v);
			}

			public static void glTexCoord2hNV(ushort s, ushort t)
			{
				internalGL.glTexCoord2hNV(s, t);
			}

			public static unsafe void glTexCoord2hvNV(ushort* v)
			{
				internalGL.glTexCoord2hvNV(v);
			}

			public static void glTexCoord3hNV(ushort s, ushort t, ushort r)
			{
				internalGL.glTexCoord3hNV(s, t, r);
			}

			public static unsafe void glTexCoord3hvNV(ushort* v)
			{
				internalGL.glTexCoord3hvNV(v);
			}

			public static void glTexCoord4hNV(ushort s, ushort t, ushort r, ushort q)
			{
				internalGL.glTexCoord4hNV(s, t, r, q);
			}

			public static unsafe void glTexCoord4hvNV(ushort* v)
			{
				internalGL.glTexCoord4hvNV(v);
			}

			public static void glTexImage2DMultisampleCoverageNV(TextureTarget target, int coverageSamples, int colorSamples, int internalFormat, int width, int height, Boolean fixedSampleLocations)
			{
				internalGL.glTexImage2DMultisampleCoverageNV(target, coverageSamples, colorSamples, internalFormat, width, height, fixedSampleLocations);
			}

			public static void glTexImage3DMultisampleCoverageNV(TextureTarget target, int coverageSamples, int colorSamples, int internalFormat, int width, int height, int depth, Boolean fixedSampleLocations)
			{
				internalGL.glTexImage3DMultisampleCoverageNV(target, coverageSamples, colorSamples, internalFormat, width, height, depth, fixedSampleLocations);
			}

			public static void glTexRenderbufferNV(TextureTarget target, uint renderbuffer)
			{
				internalGL.glTexRenderbufferNV(target, renderbuffer);
			}

			public static void glTextureImage2DMultisampleCoverageNV(uint texture, TextureTarget target, int coverageSamples, int colorSamples, int internalFormat, int width, int height, Boolean fixedSampleLocations)
			{
				internalGL.glTextureImage2DMultisampleCoverageNV(texture, target, coverageSamples, colorSamples, internalFormat, width, height, fixedSampleLocations);
			}

			public static void glTextureImage2DMultisampleNV(uint texture, TextureTarget target, int samples, int internalFormat, int width, int height, Boolean fixedSampleLocations)
			{
				internalGL.glTextureImage2DMultisampleNV(texture, target, samples, internalFormat, width, height, fixedSampleLocations);
			}

			public static void glTextureImage3DMultisampleCoverageNV(uint texture, TextureTarget target, int coverageSamples, int colorSamples, int internalFormat, int width, int height, int depth, Boolean fixedSampleLocations)
			{
				internalGL.glTextureImage3DMultisampleCoverageNV(texture, target, coverageSamples, colorSamples, internalFormat, width, height, depth, fixedSampleLocations);
			}

			public static void glTextureImage3DMultisampleNV(uint texture, TextureTarget target, int samples, int internalFormat, int width, int height, int depth, Boolean fixedSampleLocations)
			{
				internalGL.glTextureImage3DMultisampleNV(texture, target, samples, internalFormat, width, height, depth, fixedSampleLocations);
			}

			public static void glTrackMatrixNV(VertexAttribEnumNV target, uint address, VertexAttribEnumNV matrix, VertexAttribEnumNV transform)
			{
				internalGL.glTrackMatrixNV(target, address, matrix, transform);
			}

			public static unsafe void glTransformFeedbackAttribsNV(int count, int* attribs, uint bufferMode)
			{
				internalGL.glTransformFeedbackAttribsNV(count, attribs, bufferMode);
			}

			public static unsafe void glTransformFeedbackStreamAttribsNV(int count, int* attribs, int nbuffers, int* bufstreams, uint bufferMode)
			{
				internalGL.glTransformFeedbackStreamAttribsNV(count, attribs, nbuffers, bufstreams, bufferMode);
			}

			public static unsafe void glTransformFeedbackVaryingsNV(uint program, int count, int* locations, uint bufferMode)
			{
				internalGL.glTransformFeedbackVaryingsNV(program, count, locations, bufferMode);
			}

			public static void glVDPAUFiniNV()
			{
				internalGL.glVDPAUFiniNV();
			}

			public static unsafe void glVDPAUGetSurfaceivNV(IntPtr surface, uint pname, int count, int* length, int* values)
			{
				internalGL.glVDPAUGetSurfaceivNV(surface, pname, count, length, values);
			}

			public static void glVDPAUInitNV(IntPtr vdpDevice, IntPtr getProcAddress)
			{
				internalGL.glVDPAUInitNV(vdpDevice, getProcAddress);
			}

			public static bool glVDPAUIsSurfaceNV(IntPtr surface)
			{
				return internalGL.glVDPAUIsSurfaceNV(surface);
			}

			public static unsafe void glVDPAUMapSurfacesNV(int numSurfaces, IntPtr* surfaces)
			{
				internalGL.glVDPAUMapSurfacesNV(numSurfaces, surfaces);
			}

			public static unsafe IntPtr glVDPAURegisterOutputSurfaceNV(IntPtr vdpSurface, uint target, int numTextureNames, uint* textureNames)
			{
				return internalGL.glVDPAURegisterOutputSurfaceNV(vdpSurface, target, numTextureNames, textureNames);
			}

			public static unsafe IntPtr glVDPAURegisterVideoSurfaceNV(IntPtr vdpSurface, uint target, int numTextureNames, uint* textureNames)
			{
				return internalGL.glVDPAURegisterVideoSurfaceNV(vdpSurface, target, numTextureNames, textureNames);
			}

			public static unsafe IntPtr glVDPAURegisterVideoSurfaceWithPictureStructureNV(IntPtr vdpSurface, uint target, int numTextureNames, uint* textureNames, Boolean isFrameStructure)
			{
				return internalGL.glVDPAURegisterVideoSurfaceWithPictureStructureNV(vdpSurface, target, numTextureNames, textureNames, isFrameStructure);
			}

			public static void glVDPAUSurfaceAccessNV(IntPtr surface, uint access)
			{
				internalGL.glVDPAUSurfaceAccessNV(surface, access);
			}

			public static unsafe void glVDPAUUnmapSurfacesNV(int numSurface, IntPtr* surfaces)
			{
				internalGL.glVDPAUUnmapSurfacesNV(numSurface, surfaces);
			}

			public static void glVDPAUUnregisterSurfaceNV(IntPtr surface)
			{
				internalGL.glVDPAUUnregisterSurfaceNV(surface);
			}

			public static void glVertex2hNV(ushort x, ushort y)
			{
				internalGL.glVertex2hNV(x, y);
			}

			public static unsafe void glVertex2hvNV(ushort* v)
			{
				internalGL.glVertex2hvNV(v);
			}

			public static void glVertex3hNV(ushort x, ushort y, ushort z)
			{
				internalGL.glVertex3hNV(x, y, z);
			}

			public static unsafe void glVertex3hvNV(ushort* v)
			{
				internalGL.glVertex3hvNV(v);
			}

			public static void glVertex4hNV(ushort x, ushort y, ushort z, ushort w)
			{
				internalGL.glVertex4hNV(x, y, z, w);
			}

			public static unsafe void glVertex4hvNV(ushort* v)
			{
				internalGL.glVertex4hvNV(v);
			}

			public static void glVertexArrayRangeNV(int length, IntPtr pointer)
			{
				internalGL.glVertexArrayRangeNV(length, pointer);
			}

			public static void glVertexAttrib1dNV(uint index, double x)
			{
				internalGL.glVertexAttrib1dNV(index, x);
			}

			public static unsafe void glVertexAttrib1dvNV(uint index, double* v)
			{
				internalGL.glVertexAttrib1dvNV(index, v);
			}

			public static void glVertexAttrib1fNV(uint index, float x)
			{
				internalGL.glVertexAttrib1fNV(index, x);
			}

			public static unsafe void glVertexAttrib1fvNV(uint index, float* v)
			{
				internalGL.glVertexAttrib1fvNV(index, v);
			}

			public static void glVertexAttrib1hNV(uint index, ushort x)
			{
				internalGL.glVertexAttrib1hNV(index, x);
			}

			public static unsafe void glVertexAttrib1hvNV(uint index, ushort* v)
			{
				internalGL.glVertexAttrib1hvNV(index, v);
			}

			public static void glVertexAttrib1sNV(uint index, short x)
			{
				internalGL.glVertexAttrib1sNV(index, x);
			}

			public static unsafe void glVertexAttrib1svNV(uint index, short* v)
			{
				internalGL.glVertexAttrib1svNV(index, v);
			}

			public static void glVertexAttrib2dNV(uint index, double x, double y)
			{
				internalGL.glVertexAttrib2dNV(index, x, y);
			}

			public static unsafe void glVertexAttrib2dvNV(uint index, double* v)
			{
				internalGL.glVertexAttrib2dvNV(index, v);
			}

			public static void glVertexAttrib2fNV(uint index, float x, float y)
			{
				internalGL.glVertexAttrib2fNV(index, x, y);
			}

			public static unsafe void glVertexAttrib2fvNV(uint index, float* v)
			{
				internalGL.glVertexAttrib2fvNV(index, v);
			}

			public static void glVertexAttrib2hNV(uint index, ushort x, ushort y)
			{
				internalGL.glVertexAttrib2hNV(index, x, y);
			}

			public static unsafe void glVertexAttrib2hvNV(uint index, ushort* v)
			{
				internalGL.glVertexAttrib2hvNV(index, v);
			}

			public static void glVertexAttrib2sNV(uint index, short x, short y)
			{
				internalGL.glVertexAttrib2sNV(index, x, y);
			}

			public static unsafe void glVertexAttrib2svNV(uint index, short* v)
			{
				internalGL.glVertexAttrib2svNV(index, v);
			}

			public static void glVertexAttrib3dNV(uint index, double x, double y, double z)
			{
				internalGL.glVertexAttrib3dNV(index, x, y, z);
			}

			public static unsafe void glVertexAttrib3dvNV(uint index, double* v)
			{
				internalGL.glVertexAttrib3dvNV(index, v);
			}

			public static void glVertexAttrib3fNV(uint index, float x, float y, float z)
			{
				internalGL.glVertexAttrib3fNV(index, x, y, z);
			}

			public static unsafe void glVertexAttrib3fvNV(uint index, float* v)
			{
				internalGL.glVertexAttrib3fvNV(index, v);
			}

			public static void glVertexAttrib3hNV(uint index, ushort x, ushort y, ushort z)
			{
				internalGL.glVertexAttrib3hNV(index, x, y, z);
			}

			public static unsafe void glVertexAttrib3hvNV(uint index, ushort* v)
			{
				internalGL.glVertexAttrib3hvNV(index, v);
			}

			public static void glVertexAttrib3sNV(uint index, short x, short y, short z)
			{
				internalGL.glVertexAttrib3sNV(index, x, y, z);
			}

			public static unsafe void glVertexAttrib3svNV(uint index, short* v)
			{
				internalGL.glVertexAttrib3svNV(index, v);
			}

			public static void glVertexAttrib4dNV(uint index, double x, double y, double z, double w)
			{
				internalGL.glVertexAttrib4dNV(index, x, y, z, w);
			}

			public static unsafe void glVertexAttrib4dvNV(uint index, double* v)
			{
				internalGL.glVertexAttrib4dvNV(index, v);
			}

			public static void glVertexAttrib4fNV(uint index, float x, float y, float z, float w)
			{
				internalGL.glVertexAttrib4fNV(index, x, y, z, w);
			}

			public static unsafe void glVertexAttrib4fvNV(uint index, float* v)
			{
				internalGL.glVertexAttrib4fvNV(index, v);
			}

			public static void glVertexAttrib4hNV(uint index, ushort x, ushort y, ushort z, ushort w)
			{
				internalGL.glVertexAttrib4hNV(index, x, y, z, w);
			}

			public static unsafe void glVertexAttrib4hvNV(uint index, ushort* v)
			{
				internalGL.glVertexAttrib4hvNV(index, v);
			}

			public static void glVertexAttrib4sNV(uint index, short x, short y, short z, short w)
			{
				internalGL.glVertexAttrib4sNV(index, x, y, z, w);
			}

			public static unsafe void glVertexAttrib4svNV(uint index, short* v)
			{
				internalGL.glVertexAttrib4svNV(index, v);
			}

			public static void glVertexAttrib4ubNV(uint index, byte x, byte y, byte z, byte w)
			{
				internalGL.glVertexAttrib4ubNV(index, x, y, z, w);
			}

			public static unsafe void glVertexAttrib4ubvNV(uint index, byte* v)
			{
				internalGL.glVertexAttrib4ubvNV(index, v);
			}

			public static void glVertexAttribI1iEXT(uint index, int x)
			{
				internalGL.glVertexAttribI1iEXT(index, x);
			}

			public static unsafe void glVertexAttribI1ivEXT(uint index, int* v)
			{
				internalGL.glVertexAttribI1ivEXT(index, v);
			}

			public static void glVertexAttribI1uiEXT(uint index, uint x)
			{
				internalGL.glVertexAttribI1uiEXT(index, x);
			}

			public static unsafe void glVertexAttribI1uivEXT(uint index, uint* v)
			{
				internalGL.glVertexAttribI1uivEXT(index, v);
			}

			public static void glVertexAttribI2iEXT(uint index, int x, int y)
			{
				internalGL.glVertexAttribI2iEXT(index, x, y);
			}

			public static unsafe void glVertexAttribI2ivEXT(uint index, int* v)
			{
				internalGL.glVertexAttribI2ivEXT(index, v);
			}

			public static void glVertexAttribI2uiEXT(uint index, uint x, uint y)
			{
				internalGL.glVertexAttribI2uiEXT(index, x, y);
			}

			public static unsafe void glVertexAttribI2uivEXT(uint index, uint* v)
			{
				internalGL.glVertexAttribI2uivEXT(index, v);
			}

			public static void glVertexAttribI3iEXT(uint index, int x, int y, int z)
			{
				internalGL.glVertexAttribI3iEXT(index, x, y, z);
			}

			public static unsafe void glVertexAttribI3ivEXT(uint index, int* v)
			{
				internalGL.glVertexAttribI3ivEXT(index, v);
			}

			public static void glVertexAttribI3uiEXT(uint index, uint x, uint y, uint z)
			{
				internalGL.glVertexAttribI3uiEXT(index, x, y, z);
			}

			public static unsafe void glVertexAttribI3uivEXT(uint index, uint* v)
			{
				internalGL.glVertexAttribI3uivEXT(index, v);
			}

			public static unsafe void glVertexAttribI4bvEXT(uint index, sbyte* v)
			{
				internalGL.glVertexAttribI4bvEXT(index, v);
			}

			public static void glVertexAttribI4iEXT(uint index, int x, int y, int z, int w)
			{
				internalGL.glVertexAttribI4iEXT(index, x, y, z, w);
			}

			public static unsafe void glVertexAttribI4ivEXT(uint index, int* v)
			{
				internalGL.glVertexAttribI4ivEXT(index, v);
			}

			public static unsafe void glVertexAttribI4svEXT(uint index, short* v)
			{
				internalGL.glVertexAttribI4svEXT(index, v);
			}

			public static unsafe void glVertexAttribI4ubvEXT(uint index, byte* v)
			{
				internalGL.glVertexAttribI4ubvEXT(index, v);
			}

			public static void glVertexAttribI4uiEXT(uint index, uint x, uint y, uint z, uint w)
			{
				internalGL.glVertexAttribI4uiEXT(index, x, y, z, w);
			}

			public static unsafe void glVertexAttribI4uivEXT(uint index, uint* v)
			{
				internalGL.glVertexAttribI4uivEXT(index, v);
			}

			public static unsafe void glVertexAttribI4usvEXT(uint index, ushort* v)
			{
				internalGL.glVertexAttribI4usvEXT(index, v);
			}

			public static void glVertexAttribIPointerEXT(uint index, int size, VertexAttribIType type, int stride, IntPtr pointer)
			{
				internalGL.glVertexAttribIPointerEXT(index, size, type, stride, pointer);
			}

			public static void glVertexAttribPointerNV(uint index, int fsize, VertexAttribEnumNV type, int stride, IntPtr pointer)
			{
				internalGL.glVertexAttribPointerNV(index, fsize, type, stride, pointer);
			}

			public static unsafe void glVertexAttribs1dvNV(uint index, int count, double* v)
			{
				internalGL.glVertexAttribs1dvNV(index, count, v);
			}

			public static unsafe void glVertexAttribs1fvNV(uint index, int count, float* v)
			{
				internalGL.glVertexAttribs1fvNV(index, count, v);
			}

			public static unsafe void glVertexAttribs1hvNV(uint index, int n, ushort* v)
			{
				internalGL.glVertexAttribs1hvNV(index, n, v);
			}

			public static unsafe void glVertexAttribs1svNV(uint index, int count, short* v)
			{
				internalGL.glVertexAttribs1svNV(index, count, v);
			}

			public static unsafe void glVertexAttribs2dvNV(uint index, int count, double* v)
			{
				internalGL.glVertexAttribs2dvNV(index, count, v);
			}

			public static unsafe void glVertexAttribs2fvNV(uint index, int count, float* v)
			{
				internalGL.glVertexAttribs2fvNV(index, count, v);
			}

			public static unsafe void glVertexAttribs2hvNV(uint index, int n, ushort* v)
			{
				internalGL.glVertexAttribs2hvNV(index, n, v);
			}

			public static unsafe void glVertexAttribs2svNV(uint index, int count, short* v)
			{
				internalGL.glVertexAttribs2svNV(index, count, v);
			}

			public static unsafe void glVertexAttribs3dvNV(uint index, int count, double* v)
			{
				internalGL.glVertexAttribs3dvNV(index, count, v);
			}

			public static unsafe void glVertexAttribs3fvNV(uint index, int count, float* v)
			{
				internalGL.glVertexAttribs3fvNV(index, count, v);
			}

			public static unsafe void glVertexAttribs3hvNV(uint index, int n, ushort* v)
			{
				internalGL.glVertexAttribs3hvNV(index, n, v);
			}

			public static unsafe void glVertexAttribs3svNV(uint index, int count, short* v)
			{
				internalGL.glVertexAttribs3svNV(index, count, v);
			}

			public static unsafe void glVertexAttribs4dvNV(uint index, int count, double* v)
			{
				internalGL.glVertexAttribs4dvNV(index, count, v);
			}

			public static unsafe void glVertexAttribs4fvNV(uint index, int count, float* v)
			{
				internalGL.glVertexAttribs4fvNV(index, count, v);
			}

			public static unsafe void glVertexAttribs4hvNV(uint index, int n, ushort* v)
			{
				internalGL.glVertexAttribs4hvNV(index, n, v);
			}

			public static unsafe void glVertexAttribs4svNV(uint index, int count, short* v)
			{
				internalGL.glVertexAttribs4svNV(index, count, v);
			}

			public static unsafe void glVertexAttribs4ubvNV(uint index, int count, byte* v)
			{
				internalGL.glVertexAttribs4ubvNV(index, count, v);
			}

			public static void glVertexWeighthNV(ushort weight)
			{
				internalGL.glVertexWeighthNV(weight);
			}

			public static unsafe void glVertexWeighthvNV(ushort* weight)
			{
				internalGL.glVertexWeighthvNV(weight);
			}

			public static unsafe uint glVideoCaptureNV(uint video_capture_slot, uint* sequence_num, ulong* capture_time)
			{
				return internalGL.glVideoCaptureNV(video_capture_slot, sequence_num, capture_time);
			}

			public static unsafe void glVideoCaptureStreamParameterdvNV(uint video_capture_slot, uint stream, uint pname, double* @params)
			{
				internalGL.glVideoCaptureStreamParameterdvNV(video_capture_slot, stream, pname, @params);
			}

			public static unsafe void glVideoCaptureStreamParameterfvNV(uint video_capture_slot, uint stream, uint pname, float* @params)
			{
				internalGL.glVideoCaptureStreamParameterfvNV(video_capture_slot, stream, pname, @params);
			}

			public static unsafe void glVideoCaptureStreamParameterivNV(uint video_capture_slot, uint stream, uint pname, int* @params)
			{
				internalGL.glVideoCaptureStreamParameterivNV(video_capture_slot, stream, pname, @params);
			}
		}

		public static class NVX
		{
			public static unsafe uint glAsyncCopyBufferSubDataNVX(int waitSemaphoreCount, uint* waitSemaphoreArray, ulong* fenceValueArray, uint readGpu, uint writeGpuMask, uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, int size, int signalSemaphoreCount, uint* signalSemaphoreArray, ulong* signalValueArray)
			{
				return internalGL.glAsyncCopyBufferSubDataNVX(waitSemaphoreCount, waitSemaphoreArray, fenceValueArray, readGpu, writeGpuMask, readBuffer, writeBuffer, readOffset, writeOffset, size, signalSemaphoreCount, signalSemaphoreArray, signalValueArray);
			}

			public static unsafe uint glAsyncCopyImageSubDataNVX(int waitSemaphoreCount, uint* waitSemaphoreArray, ulong* waitValueArray, uint srcGpu, uint dstGpuMask, uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth, int signalSemaphoreCount, uint* signalSemaphoreArray, ulong* signalValueArray)
			{
				return internalGL.glAsyncCopyImageSubDataNVX(waitSemaphoreCount, waitSemaphoreArray, waitValueArray, srcGpu, dstGpuMask, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth, signalSemaphoreCount, signalSemaphoreArray, signalValueArray);
			}

			public static void glBeginConditionalRenderNVX(uint id)
			{
				internalGL.glBeginConditionalRenderNVX(id);
			}

			public static unsafe void glClientWaitSemaphoreui64NVX(int fenceObjectCount, uint* semaphoreArray, ulong* fenceValueArray)
			{
				internalGL.glClientWaitSemaphoreui64NVX(fenceObjectCount, semaphoreArray, fenceValueArray);
			}

			public static uint glCreateProgressFenceNVX()
			{
				return internalGL.glCreateProgressFenceNVX();
			}

			public static void glEndConditionalRenderNVX()
			{
				internalGL.glEndConditionalRenderNVX();
			}

			public static void glLGPUCopyImageSubDataNVX(uint sourceGpu, uint destinationGpuMask, uint srcName, uint srcTarget, int srcLevel, int srcX, int srxY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth)
			{
				internalGL.glLGPUCopyImageSubDataNVX(sourceGpu, destinationGpuMask, srcName, srcTarget, srcLevel, srcX, srxY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth);
			}

			public static void glLGPUInterlockNVX()
			{
				internalGL.glLGPUInterlockNVX();
			}

			public static void glLGPUNamedBufferSubDataNVX(uint gpuMask, uint buffer, IntPtr offset, int size, IntPtr data)
			{
				internalGL.glLGPUNamedBufferSubDataNVX(gpuMask, buffer, offset, size, data);
			}

			public static unsafe void glMulticastScissorArrayvNVX(uint gpu, uint first, int count, int* v)
			{
				internalGL.glMulticastScissorArrayvNVX(gpu, first, count, v);
			}

			public static unsafe void glMulticastViewportArrayvNVX(uint gpu, uint first, int count, float* v)
			{
				internalGL.glMulticastViewportArrayvNVX(gpu, first, count, v);
			}

			public static void glMulticastViewportPositionWScaleNVX(uint gpu, uint index, float xcoeff, float ycoeff)
			{
				internalGL.glMulticastViewportPositionWScaleNVX(gpu, index, xcoeff, ycoeff);
			}

			public static unsafe void glSignalSemaphoreui64NVX(uint signalGpu, int fenceObjectCount, uint* semaphoreArray, ulong* fenceValueArray)
			{
				internalGL.glSignalSemaphoreui64NVX(signalGpu, fenceObjectCount, semaphoreArray, fenceValueArray);
			}

			public static void glUploadGpuMaskNVX(uint mask)
			{
				internalGL.glUploadGpuMaskNVX(mask);
			}

			public static unsafe void glWaitSemaphoreui64NVX(uint waitGpu, int fenceObjectCount, uint* semaphoreArray, ulong* fenceValueArray)
			{
				internalGL.glWaitSemaphoreui64NVX(waitGpu, fenceObjectCount, semaphoreArray, fenceValueArray);
			}
		}

		public static class PGI
		{
			public static void glHintPGI(HintTargetPGI target, int mode)
			{
				internalGL.glHintPGI(target, mode);
			}
		}

		public static class SGI
		{
			public static unsafe void glColorTableParameterfvSGI(ColorTableTargetSGI target, ColorTableParameterPNameSGI pname, float* @params)
			{
				internalGL.glColorTableParameterfvSGI(target, pname, @params);
			}

			public static unsafe void glColorTableParameterivSGI(ColorTableTargetSGI target, ColorTableParameterPNameSGI pname, int* @params)
			{
				internalGL.glColorTableParameterivSGI(target, pname, @params);
			}

			public static void glColorTableSGI(ColorTableTargetSGI target, InternalFormat internalformat, int width, PixelFormat format, PixelType type, IntPtr table)
			{
				internalGL.glColorTableSGI(target, internalformat, width, format, type, table);
			}

			public static void glCopyColorTableSGI(ColorTableTargetSGI target, InternalFormat internalformat, int x, int y, int width)
			{
				internalGL.glCopyColorTableSGI(target, internalformat, x, y, width);
			}

			public static unsafe void glGetColorTableParameterfvSGI(ColorTableTargetSGI target, GetColorTableParameterPNameSGI pname, float* @params)
			{
				internalGL.glGetColorTableParameterfvSGI(target, pname, @params);
			}

			public static unsafe void glGetColorTableParameterivSGI(ColorTableTargetSGI target, GetColorTableParameterPNameSGI pname, int* @params)
			{
				internalGL.glGetColorTableParameterivSGI(target, pname, @params);
			}

			public static void glGetColorTableSGI(ColorTableTargetSGI target, PixelFormat format, PixelType type, IntPtr table)
			{
				internalGL.glGetColorTableSGI(target, format, type, table);
			}
		}

		public static class SGIS
		{
			public static unsafe void glDetailTexFuncSGIS(TextureTarget target, int n, float* points)
			{
				internalGL.glDetailTexFuncSGIS(target, n, points);
			}

			public static unsafe void glFogFuncSGIS(int n, float* points)
			{
				internalGL.glFogFuncSGIS(n, points);
			}

			public static unsafe void glGetDetailTexFuncSGIS(TextureTarget target, float* points)
			{
				internalGL.glGetDetailTexFuncSGIS(target, points);
			}

			public static unsafe void glGetFogFuncSGIS(float* points)
			{
				internalGL.glGetFogFuncSGIS(points);
			}

			public static unsafe void glGetPixelTexGenParameterfvSGIS(PixelTexGenParameterNameSGIS pname, float* @params)
			{
				internalGL.glGetPixelTexGenParameterfvSGIS(pname, @params);
			}

			public static unsafe void glGetPixelTexGenParameterivSGIS(PixelTexGenParameterNameSGIS pname, int* @params)
			{
				internalGL.glGetPixelTexGenParameterivSGIS(pname, @params);
			}

			public static unsafe void glGetSharpenTexFuncSGIS(TextureTarget target, float* points)
			{
				internalGL.glGetSharpenTexFuncSGIS(target, points);
			}

			public static unsafe void glGetTexFilterFuncSGIS(TextureTarget target, TextureFilterSGIS filter, float* weights)
			{
				internalGL.glGetTexFilterFuncSGIS(target, filter, weights);
			}

			public static void glPixelTexGenParameterfSGIS(PixelTexGenParameterNameSGIS pname, float param)
			{
				internalGL.glPixelTexGenParameterfSGIS(pname, param);
			}

			public static unsafe void glPixelTexGenParameterfvSGIS(PixelTexGenParameterNameSGIS pname, float* @params)
			{
				internalGL.glPixelTexGenParameterfvSGIS(pname, @params);
			}

			public static void glPixelTexGenParameteriSGIS(PixelTexGenParameterNameSGIS pname, int param)
			{
				internalGL.glPixelTexGenParameteriSGIS(pname, param);
			}

			public static unsafe void glPixelTexGenParameterivSGIS(PixelTexGenParameterNameSGIS pname, int* @params)
			{
				internalGL.glPixelTexGenParameterivSGIS(pname, @params);
			}

			public static void glPointParameterfSGIS(PointParameterNameARB pname, float param)
			{
				internalGL.glPointParameterfSGIS(pname, param);
			}

			public static unsafe void glPointParameterfvSGIS(PointParameterNameARB pname, float* @params)
			{
				internalGL.glPointParameterfvSGIS(pname, @params);
			}

			public static void glSampleMaskSGIS(float value, Boolean invert)
			{
				internalGL.glSampleMaskSGIS(value, invert);
			}

			public static void glSamplePatternSGIS(SamplePatternSGIS pattern)
			{
				internalGL.glSamplePatternSGIS(pattern);
			}

			public static unsafe void glSharpenTexFuncSGIS(TextureTarget target, int n, float* points)
			{
				internalGL.glSharpenTexFuncSGIS(target, n, points);
			}

			public static unsafe void glTexFilterFuncSGIS(TextureTarget target, TextureFilterSGIS filter, int n, float* weights)
			{
				internalGL.glTexFilterFuncSGIS(target, filter, n, weights);
			}

			public static void glTexImage4DSGIS(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int size4d, int border, PixelFormat format, PixelType type, IntPtr pixels)
			{
				internalGL.glTexImage4DSGIS(target, level, internalformat, width, height, depth, size4d, border, format, type, pixels);
			}

			public static void glTexSubImage4DSGIS(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int woffset, int width, int height, int depth, int size4d, PixelFormat format, PixelType type, IntPtr pixels)
			{
				internalGL.glTexSubImage4DSGIS(target, level, xoffset, yoffset, zoffset, woffset, width, height, depth, size4d, format, type, pixels);
			}

			public static void glTextureColorMaskSGIS(Boolean red, Boolean green, Boolean blue, Boolean alpha)
			{
				internalGL.glTextureColorMaskSGIS(red, green, blue, alpha);
			}
		}

		public static class SGIX
		{
			public static void glAsyncMarkerSGIX(uint marker)
			{
				internalGL.glAsyncMarkerSGIX(marker);
			}

			public static unsafe void glDeformationMap3dSGIX(FfdTargetSGIX target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double w1, double w2, int wstride, int worder, double* points)
			{
				internalGL.glDeformationMap3dSGIX(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, w1, w2, wstride, worder, points);
			}

			public static unsafe void glDeformationMap3fSGIX(FfdTargetSGIX target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float w1, float w2, int wstride, int worder, float* points)
			{
				internalGL.glDeformationMap3fSGIX(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, w1, w2, wstride, worder, points);
			}

			public static void glDeformSGIX(FfdMaskSGIX mask)
			{
				internalGL.glDeformSGIX(mask);
			}

			public static void glDeleteAsyncMarkersSGIX(uint marker, int range)
			{
				internalGL.glDeleteAsyncMarkersSGIX(marker, range);
			}

			public static unsafe int glFinishAsyncSGIX(uint* markerp)
			{
				return internalGL.glFinishAsyncSGIX(markerp);
			}

			public static void glFlushRasterSGIX()
			{
				internalGL.glFlushRasterSGIX();
			}

			public static void glFragmentColorMaterialSGIX(MaterialFace face, MaterialParameter mode)
			{
				internalGL.glFragmentColorMaterialSGIX(face, mode);
			}

			public static void glFragmentLightfSGIX(FragmentLightNameSGIX light, FragmentLightParameterSGIX pname, float param)
			{
				internalGL.glFragmentLightfSGIX(light, pname, param);
			}

			public static unsafe void glFragmentLightfvSGIX(FragmentLightNameSGIX light, FragmentLightParameterSGIX pname, float* @params)
			{
				internalGL.glFragmentLightfvSGIX(light, pname, @params);
			}

			public static void glFragmentLightiSGIX(FragmentLightNameSGIX light, FragmentLightParameterSGIX pname, int param)
			{
				internalGL.glFragmentLightiSGIX(light, pname, param);
			}

			public static unsafe void glFragmentLightivSGIX(FragmentLightNameSGIX light, FragmentLightParameterSGIX pname, int* @params)
			{
				internalGL.glFragmentLightivSGIX(light, pname, @params);
			}

			public static void glFragmentLightModelfSGIX(FragmentLightModelParameterSGIX pname, float param)
			{
				internalGL.glFragmentLightModelfSGIX(pname, param);
			}

			public static unsafe void glFragmentLightModelfvSGIX(FragmentLightModelParameterSGIX pname, float* @params)
			{
				internalGL.glFragmentLightModelfvSGIX(pname, @params);
			}

			public static void glFragmentLightModeliSGIX(FragmentLightModelParameterSGIX pname, int param)
			{
				internalGL.glFragmentLightModeliSGIX(pname, param);
			}

			public static unsafe void glFragmentLightModelivSGIX(FragmentLightModelParameterSGIX pname, int* @params)
			{
				internalGL.glFragmentLightModelivSGIX(pname, @params);
			}

			public static void glFragmentMaterialfSGIX(MaterialFace face, MaterialParameter pname, float param)
			{
				internalGL.glFragmentMaterialfSGIX(face, pname, param);
			}

			public static unsafe void glFragmentMaterialfvSGIX(MaterialFace face, MaterialParameter pname, float* @params)
			{
				internalGL.glFragmentMaterialfvSGIX(face, pname, @params);
			}

			public static void glFragmentMaterialiSGIX(MaterialFace face, MaterialParameter pname, int param)
			{
				internalGL.glFragmentMaterialiSGIX(face, pname, param);
			}

			public static unsafe void glFragmentMaterialivSGIX(MaterialFace face, MaterialParameter pname, int* @params)
			{
				internalGL.glFragmentMaterialivSGIX(face, pname, @params);
			}

			public static void glFrameZoomSGIX(int factor)
			{
				internalGL.glFrameZoomSGIX(factor);
			}

			public static uint glGenAsyncMarkersSGIX(int range)
			{
				return internalGL.glGenAsyncMarkersSGIX(range);
			}

			public static unsafe void glGetFragmentLightfvSGIX(FragmentLightNameSGIX light, FragmentLightParameterSGIX pname, float* @params)
			{
				internalGL.glGetFragmentLightfvSGIX(light, pname, @params);
			}

			public static unsafe void glGetFragmentLightivSGIX(FragmentLightNameSGIX light, FragmentLightParameterSGIX pname, int* @params)
			{
				internalGL.glGetFragmentLightivSGIX(light, pname, @params);
			}

			public static unsafe void glGetFragmentMaterialfvSGIX(MaterialFace face, MaterialParameter pname, float* @params)
			{
				internalGL.glGetFragmentMaterialfvSGIX(face, pname, @params);
			}

			public static unsafe void glGetFragmentMaterialivSGIX(MaterialFace face, MaterialParameter pname, int* @params)
			{
				internalGL.glGetFragmentMaterialivSGIX(face, pname, @params);
			}

			public static int glGetInstrumentsSGIX()
			{
				return internalGL.glGetInstrumentsSGIX();
			}

			public static unsafe void glGetListParameterfvSGIX(uint list, ListParameterName pname, float* @params)
			{
				internalGL.glGetListParameterfvSGIX(list, pname, @params);
			}

			public static unsafe void glGetListParameterivSGIX(uint list, ListParameterName pname, int* @params)
			{
				internalGL.glGetListParameterivSGIX(list, pname, @params);
			}

			public static void glIglooInterfaceSGIX(uint pname, IntPtr @params)
			{
				internalGL.glIglooInterfaceSGIX(pname, @params);
			}

			public static unsafe void glInstrumentsBufferSGIX(int size, int* buffer)
			{
				internalGL.glInstrumentsBufferSGIX(size, buffer);
			}

			public static bool glIsAsyncMarkerSGIX(uint marker)
			{
				return internalGL.glIsAsyncMarkerSGIX(marker);
			}

			public static void glLightEnviSGIX(LightEnvParameterSGIX pname, int param)
			{
				internalGL.glLightEnviSGIX(pname, param);
			}

			public static void glListParameterfSGIX(uint list, ListParameterName pname, float param)
			{
				internalGL.glListParameterfSGIX(list, pname, param);
			}

			public static unsafe void glListParameterfvSGIX(uint list, ListParameterName pname, float* @params)
			{
				internalGL.glListParameterfvSGIX(list, pname, @params);
			}

			public static void glListParameteriSGIX(uint list, ListParameterName pname, int param)
			{
				internalGL.glListParameteriSGIX(list, pname, param);
			}

			public static unsafe void glListParameterivSGIX(uint list, ListParameterName pname, int* @params)
			{
				internalGL.glListParameterivSGIX(list, pname, @params);
			}

			public static void glLoadIdentityDeformationMapSGIX(FfdMaskSGIX mask)
			{
				internalGL.glLoadIdentityDeformationMapSGIX(mask);
			}

			public static void glPixelTexGenSGIX(PixelTexGenModeSGIX mode)
			{
				internalGL.glPixelTexGenSGIX(mode);
			}

			public static unsafe int glPollAsyncSGIX(uint* markerp)
			{
				return internalGL.glPollAsyncSGIX(markerp);
			}

			public static unsafe int glPollInstrumentsSGIX(int* marker_p)
			{
				return internalGL.glPollInstrumentsSGIX(marker_p);
			}

			public static void glReadInstrumentsSGIX(int marker)
			{
				internalGL.glReadInstrumentsSGIX(marker);
			}

			public static unsafe void glReferencePlaneSGIX(double* equation)
			{
				internalGL.glReferencePlaneSGIX(equation);
			}

			public static void glSpriteParameterfSGIX(SpriteParameterNameSGIX pname, float param)
			{
				internalGL.glSpriteParameterfSGIX(pname, param);
			}

			public static unsafe void glSpriteParameterfvSGIX(SpriteParameterNameSGIX pname, float* @params)
			{
				internalGL.glSpriteParameterfvSGIX(pname, @params);
			}

			public static void glSpriteParameteriSGIX(SpriteParameterNameSGIX pname, int param)
			{
				internalGL.glSpriteParameteriSGIX(pname, param);
			}

			public static unsafe void glSpriteParameterivSGIX(SpriteParameterNameSGIX pname, int* @params)
			{
				internalGL.glSpriteParameterivSGIX(pname, @params);
			}

			public static void glStartInstrumentsSGIX()
			{
				internalGL.glStartInstrumentsSGIX();
			}

			public static void glStopInstrumentsSGIX(int marker)
			{
				internalGL.glStopInstrumentsSGIX(marker);
			}

			public static void glTagSampleBufferSGIX()
			{
				internalGL.glTagSampleBufferSGIX();
			}
		}

		public static class SUN
		{
			public static void glColor3fVertex3fSUN(float r, float g, float b, float x, float y, float z)
			{
				internalGL.glColor3fVertex3fSUN(r, g, b, x, y, z);
			}

			public static unsafe void glColor3fVertex3fvSUN(float* c, float* v)
			{
				internalGL.glColor3fVertex3fvSUN(c, v);
			}

			public static void glColor4fNormal3fVertex3fSUN(float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z)
			{
				internalGL.glColor4fNormal3fVertex3fSUN(r, g, b, a, nx, ny, nz, x, y, z);
			}

			public static unsafe void glColor4fNormal3fVertex3fvSUN(float* c, float* n, float* v)
			{
				internalGL.glColor4fNormal3fVertex3fvSUN(c, n, v);
			}

			public static void glColor4ubVertex2fSUN(byte r, byte g, byte b, byte a, float x, float y)
			{
				internalGL.glColor4ubVertex2fSUN(r, g, b, a, x, y);
			}

			public static unsafe void glColor4ubVertex2fvSUN(byte* c, float* v)
			{
				internalGL.glColor4ubVertex2fvSUN(c, v);
			}

			public static void glColor4ubVertex3fSUN(byte r, byte g, byte b, byte a, float x, float y, float z)
			{
				internalGL.glColor4ubVertex3fSUN(r, g, b, a, x, y, z);
			}

			public static unsafe void glColor4ubVertex3fvSUN(byte* c, float* v)
			{
				internalGL.glColor4ubVertex3fvSUN(c, v);
			}

			public static void glDrawMeshArraysSUN(PrimitiveType mode, int first, int count, int width)
			{
				internalGL.glDrawMeshArraysSUN(mode, first, count, width);
			}

			public static void glGlobalAlphaFactorbSUN(sbyte factor)
			{
				internalGL.glGlobalAlphaFactorbSUN(factor);
			}

			public static void glGlobalAlphaFactordSUN(double factor)
			{
				internalGL.glGlobalAlphaFactordSUN(factor);
			}

			public static void glGlobalAlphaFactorfSUN(float factor)
			{
				internalGL.glGlobalAlphaFactorfSUN(factor);
			}

			public static void glGlobalAlphaFactoriSUN(int factor)
			{
				internalGL.glGlobalAlphaFactoriSUN(factor);
			}

			public static void glGlobalAlphaFactorsSUN(short factor)
			{
				internalGL.glGlobalAlphaFactorsSUN(factor);
			}

			public static void glGlobalAlphaFactorubSUN(byte factor)
			{
				internalGL.glGlobalAlphaFactorubSUN(factor);
			}

			public static void glGlobalAlphaFactoruiSUN(uint factor)
			{
				internalGL.glGlobalAlphaFactoruiSUN(factor);
			}

			public static void glGlobalAlphaFactorusSUN(ushort factor)
			{
				internalGL.glGlobalAlphaFactorusSUN(factor);
			}

			public static void glNormal3fVertex3fSUN(float nx, float ny, float nz, float x, float y, float z)
			{
				internalGL.glNormal3fVertex3fSUN(nx, ny, nz, x, y, z);
			}

			public static unsafe void glNormal3fVertex3fvSUN(float* n, float* v)
			{
				internalGL.glNormal3fVertex3fvSUN(n, v);
			}

			public static void glReplacementCodePointerSUN(ReplacementCodeTypeSUN type, int stride, IntPtr pointer)
			{
				internalGL.glReplacementCodePointerSUN(type, stride, pointer);
			}

			public static void glReplacementCodeubSUN(byte code)
			{
				internalGL.glReplacementCodeubSUN(code);
			}

			public static unsafe void glReplacementCodeubvSUN(byte* code)
			{
				internalGL.glReplacementCodeubvSUN(code);
			}

			public static void glReplacementCodeuiColor3fVertex3fSUN(uint rc, float r, float g, float b, float x, float y, float z)
			{
				internalGL.glReplacementCodeuiColor3fVertex3fSUN(rc, r, g, b, x, y, z);
			}

			public static unsafe void glReplacementCodeuiColor3fVertex3fvSUN(uint* rc, float* c, float* v)
			{
				internalGL.glReplacementCodeuiColor3fVertex3fvSUN(rc, c, v);
			}

			public static void glReplacementCodeuiColor4fNormal3fVertex3fSUN(uint rc, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z)
			{
				internalGL.glReplacementCodeuiColor4fNormal3fVertex3fSUN(rc, r, g, b, a, nx, ny, nz, x, y, z);
			}

			public static unsafe void glReplacementCodeuiColor4fNormal3fVertex3fvSUN(uint* rc, float* c, float* n, float* v)
			{
				internalGL.glReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c, n, v);
			}

			public static void glReplacementCodeuiColor4ubVertex3fSUN(uint rc, byte r, byte g, byte b, byte a, float x, float y, float z)
			{
				internalGL.glReplacementCodeuiColor4ubVertex3fSUN(rc, r, g, b, a, x, y, z);
			}

			public static unsafe void glReplacementCodeuiColor4ubVertex3fvSUN(uint* rc, byte* c, float* v)
			{
				internalGL.glReplacementCodeuiColor4ubVertex3fvSUN(rc, c, v);
			}

			public static void glReplacementCodeuiNormal3fVertex3fSUN(uint rc, float nx, float ny, float nz, float x, float y, float z)
			{
				internalGL.glReplacementCodeuiNormal3fVertex3fSUN(rc, nx, ny, nz, x, y, z);
			}

			public static unsafe void glReplacementCodeuiNormal3fVertex3fvSUN(uint* rc, float* n, float* v)
			{
				internalGL.glReplacementCodeuiNormal3fVertex3fvSUN(rc, n, v);
			}

			public static void glReplacementCodeuiSUN(uint code)
			{
				internalGL.glReplacementCodeuiSUN(code);
			}

			public static void glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(uint rc, float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z)
			{
				internalGL.glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(rc, s, t, r, g, b, a, nx, ny, nz, x, y, z);
			}

			public static unsafe void glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(uint* rc, float* tc, float* c, float* n, float* v)
			{
				internalGL.glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c, n, v);
			}

			public static void glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(uint rc, float s, float t, float nx, float ny, float nz, float x, float y, float z)
			{
				internalGL.glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(rc, s, t, nx, ny, nz, x, y, z);
			}

			public static unsafe void glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(uint* rc, float* tc, float* n, float* v)
			{
				internalGL.glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc, n, v);
			}

			public static void glReplacementCodeuiTexCoord2fVertex3fSUN(uint rc, float s, float t, float x, float y, float z)
			{
				internalGL.glReplacementCodeuiTexCoord2fVertex3fSUN(rc, s, t, x, y, z);
			}

			public static unsafe void glReplacementCodeuiTexCoord2fVertex3fvSUN(uint* rc, float* tc, float* v)
			{
				internalGL.glReplacementCodeuiTexCoord2fVertex3fvSUN(rc, tc, v);
			}

			public static void glReplacementCodeuiVertex3fSUN(uint rc, float x, float y, float z)
			{
				internalGL.glReplacementCodeuiVertex3fSUN(rc, x, y, z);
			}

			public static unsafe void glReplacementCodeuiVertex3fvSUN(uint* rc, float* v)
			{
				internalGL.glReplacementCodeuiVertex3fvSUN(rc, v);
			}

			public static unsafe void glReplacementCodeuivSUN(uint* code)
			{
				internalGL.glReplacementCodeuivSUN(code);
			}

			public static void glReplacementCodeusSUN(ushort code)
			{
				internalGL.glReplacementCodeusSUN(code);
			}

			public static unsafe void glReplacementCodeusvSUN(ushort* code)
			{
				internalGL.glReplacementCodeusvSUN(code);
			}

			public static void glTexCoord2fColor3fVertex3fSUN(float s, float t, float r, float g, float b, float x, float y, float z)
			{
				internalGL.glTexCoord2fColor3fVertex3fSUN(s, t, r, g, b, x, y, z);
			}

			public static unsafe void glTexCoord2fColor3fVertex3fvSUN(float* tc, float* c, float* v)
			{
				internalGL.glTexCoord2fColor3fVertex3fvSUN(tc, c, v);
			}

			public static void glTexCoord2fColor4fNormal3fVertex3fSUN(float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z)
			{
				internalGL.glTexCoord2fColor4fNormal3fVertex3fSUN(s, t, r, g, b, a, nx, ny, nz, x, y, z);
			}

			public static unsafe void glTexCoord2fColor4fNormal3fVertex3fvSUN(float* tc, float* c, float* n, float* v)
			{
				internalGL.glTexCoord2fColor4fNormal3fVertex3fvSUN(tc, c, n, v);
			}

			public static void glTexCoord2fColor4ubVertex3fSUN(float s, float t, byte r, byte g, byte b, byte a, float x, float y, float z)
			{
				internalGL.glTexCoord2fColor4ubVertex3fSUN(s, t, r, g, b, a, x, y, z);
			}

			public static unsafe void glTexCoord2fColor4ubVertex3fvSUN(float* tc, byte* c, float* v)
			{
				internalGL.glTexCoord2fColor4ubVertex3fvSUN(tc, c, v);
			}

			public static void glTexCoord2fNormal3fVertex3fSUN(float s, float t, float nx, float ny, float nz, float x, float y, float z)
			{
				internalGL.glTexCoord2fNormal3fVertex3fSUN(s, t, nx, ny, nz, x, y, z);
			}

			public static unsafe void glTexCoord2fNormal3fVertex3fvSUN(float* tc, float* n, float* v)
			{
				internalGL.glTexCoord2fNormal3fVertex3fvSUN(tc, n, v);
			}

			public static void glTexCoord2fVertex3fSUN(float s, float t, float x, float y, float z)
			{
				internalGL.glTexCoord2fVertex3fSUN(s, t, x, y, z);
			}

			public static unsafe void glTexCoord2fVertex3fvSUN(float* tc, float* v)
			{
				internalGL.glTexCoord2fVertex3fvSUN(tc, v);
			}

			public static void glTexCoord4fColor4fNormal3fVertex4fSUN(float s, float t, float p, float q, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z, float w)
			{
				internalGL.glTexCoord4fColor4fNormal3fVertex4fSUN(s, t, p, q, r, g, b, a, nx, ny, nz, x, y, z, w);
			}

			public static unsafe void glTexCoord4fColor4fNormal3fVertex4fvSUN(float* tc, float* c, float* n, float* v)
			{
				internalGL.glTexCoord4fColor4fNormal3fVertex4fvSUN(tc, c, n, v);
			}

			public static void glTexCoord4fVertex4fSUN(float s, float t, float p, float q, float x, float y, float z, float w)
			{
				internalGL.glTexCoord4fVertex4fSUN(s, t, p, q, x, y, z, w);
			}

			public static unsafe void glTexCoord4fVertex4fvSUN(float* tc, float* v)
			{
				internalGL.glTexCoord4fVertex4fvSUN(tc, v);
			}
		}

		public static class SUNX
		{
			public static void glFinishTextureSUNX()
			{
				internalGL.glFinishTextureSUNX();
			}
		}
	}
}

