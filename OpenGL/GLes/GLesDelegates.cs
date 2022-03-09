// OpenGL|ES Delegates.
// File Created with OpenGL Parser 3.
// Developed by Luis Guijarro Pérez.

using System;
using System.Text;
using System.Runtime.InteropServices;

namespace dgtk.OpenGL
{
	internal static class delegatesGLES
	{
		#region A:

		internal delegate void glActiveShaderProgram(uint pipeline, uint program);
		internal delegate void glActiveTexture(TextureUnit texture);
		internal delegate void glAlphaFunc(AlphaFunction func, float @ref);
		internal delegate void glAlphaFuncx(AlphaFunction func, int @ref);
		internal delegate void glAttachShader(uint program, uint shader);
		#endregion

		#region B:

		internal delegate void glBeginQuery(QueryTarget target, uint id);
		internal delegate void glBeginTransformFeedback(PrimitiveType primitiveMode);
		internal unsafe delegate void glBindAttribLocation(uint program, uint index, string name);
		internal delegate void glBindBuffer(BufferTargetARB target, uint buffer);
		internal delegate void glBindBufferBase(BufferTargetARB target, uint index, uint buffer);
		internal delegate void glBindBufferRange(BufferTargetARB target, uint index, uint buffer, IntPtr offset, int size);
		internal delegate void glBindFramebuffer(FramebufferTarget target, uint framebuffer);
		internal delegate void glBindImageTexture(uint unit, uint texture, int level, Boolean layered, int layer, BufferAccessARB access, InternalFormat format);
		internal delegate void glBindProgramPipeline(uint pipeline);
		internal delegate void glBindRenderbuffer(RenderbufferTarget target, uint renderbuffer);
		internal delegate void glBindSampler(uint unit, uint sampler);
		internal delegate void glBindTexture(TextureTarget target, uint texture);
		internal delegate void glBindTransformFeedback(BindTransformFeedbackTarget target, uint id);
		internal delegate void glBindVertexArray(uint array);
		internal delegate void glBindVertexBuffer(uint bindingindex, uint buffer, IntPtr offset, int stride);
		internal delegate void glBlendBarrier();
		internal delegate void glBlendColor(float red, float green, float blue, float alpha);
		internal delegate void glBlendEquation(BlendEquationModeEXT mode);
		internal delegate void glBlendEquationi(uint buf, BlendEquationModeEXT mode);
		internal delegate void glBlendEquationSeparate(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha);
		internal delegate void glBlendEquationSeparatei(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha);
		internal delegate void glBlendFunc(BlendingFactor sfactor, BlendingFactor dfactor);
		internal delegate void glBlendFunci(uint buf, BlendingFactor src, BlendingFactor dst);
		internal delegate void glBlendFuncSeparate(BlendingFactor sfactorRGB, BlendingFactor dfactorRGB, BlendingFactor sfactorAlpha, BlendingFactor dfactorAlpha);
		internal delegate void glBlendFuncSeparatei(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha);
		internal delegate void glBlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter);
		internal delegate void glBufferData(BufferTargetARB target, int size, IntPtr data, BufferUsageARB usage);
		internal delegate void glBufferSubData(BufferTargetARB target, IntPtr offset, int size, IntPtr data);
		#endregion

		#region C:

		internal delegate uint glCheckFramebufferStatus(FramebufferTarget target);
		internal delegate void glClear(ClearBufferMask mask);
		internal delegate void glClearBufferfi(Buffer buffer, int drawbuffer, float depth, int stencil);
		internal unsafe delegate void glClearBufferfv(Buffer buffer, int drawbuffer, float* value);
		internal unsafe delegate void glClearBufferiv(Buffer buffer, int drawbuffer, int* value);
		internal unsafe delegate void glClearBufferuiv(Buffer buffer, int drawbuffer, uint* value);
		internal delegate void glClearColor(float red, float green, float blue, float alpha);
		internal delegate void glClearColorx(int red, int green, int blue, int alpha);
		internal delegate void glClearDepthf(float d);
		internal delegate void glClearDepthx(int depth);
		internal delegate void glClearStencil(int s);
		internal delegate void glClientActiveTexture(TextureUnit texture);
		internal delegate uint glClientWaitSync(IntPtr sync, SyncObjectMask flags, ulong timeout);
		internal unsafe delegate void glClipPlanef(ClipPlaneName p, float* eqn);
		internal unsafe delegate void glClipPlanex(ClipPlaneName plane, int* equation);
		internal delegate void glColor4f(float red, float green, float blue, float alpha);
		internal delegate void glColor4ub(byte red, byte green, byte blue, byte alpha);
		internal delegate void glColor4x(int red, int green, int blue, int alpha);
		internal delegate void glColorMask(Boolean red, Boolean green, Boolean blue, Boolean alpha);
		internal delegate void glColorMaski(uint index, Boolean r, Boolean g, Boolean b, Boolean a);
		internal delegate void glColorPointer(int size, ColorPointerType type, int stride, IntPtr pointer);
		internal delegate void glCompileShader(uint shader);
		internal delegate void glCompressedTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, IntPtr data);
		internal delegate void glCompressedTexImage3D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data);
		internal delegate void glCompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, InternalFormat format, int imageSize, IntPtr data);
		internal delegate void glCompressedTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, int imageSize, IntPtr data);
		internal delegate void glCopyBufferSubData(CopyBufferSubDataTarget readTarget, CopyBufferSubDataTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, int size);
		internal delegate void glCopyImageSubData(uint srcName, CopyImageSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyImageSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth);
		internal delegate void glCopyTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int height, int border);
		internal delegate void glCopyTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
		internal delegate void glCopyTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
		internal delegate uint glCreateProgram();
		internal delegate uint glCreateShader(ShaderType type);
		internal unsafe delegate uint glCreateShaderProgramv(ShaderType type, int count, string[] strings);
		internal delegate void glCullFace(CullFaceMode mode);
		#endregion

		#region D:

		internal delegate void glDebugMessageCallback(Delegate callback, IntPtr userParam);
		internal unsafe delegate void glDebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, Boolean enabled);
		internal unsafe delegate void glDebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, string buf);
		internal unsafe delegate void glDeleteBuffers(int n, uint* buffers);
		internal unsafe delegate void glDeleteFramebuffers(int n, uint* framebuffers);
		internal delegate void glDeleteProgram(uint program);
		internal unsafe delegate void glDeleteProgramPipelines(int n, uint* pipelines);
		internal unsafe delegate void glDeleteQueries(int n, uint* ids);
		internal unsafe delegate void glDeleteRenderbuffers(int n, uint* renderbuffers);
		internal unsafe delegate void glDeleteSamplers(int count, uint* samplers);
		internal delegate void glDeleteShader(uint shader);
		internal delegate void glDeleteSync(IntPtr sync);
		internal unsafe delegate void glDeleteTextures(int n, uint* textures);
		internal unsafe delegate void glDeleteTransformFeedbacks(int n, uint* ids);
		internal unsafe delegate void glDeleteVertexArrays(int n, uint* arrays);
		internal delegate void glDepthFunc(DepthFunction func);
		internal delegate void glDepthMask(Boolean flag);
		internal delegate void glDepthRangef(float n, float f);
		internal delegate void glDepthRangex(int n, int f);
		internal delegate void glDetachShader(uint program, uint shader);
		internal delegate void glDisable(EnableCap cap);
		internal delegate void glDisableClientState(EnableCap array);
		internal delegate void glDisablei(EnableCap target, uint index);
		internal delegate void glDisableVertexAttribArray(uint index);
		internal delegate void glDispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z);
		internal delegate void glDispatchComputeIndirect(IntPtr indirect);
		internal delegate void glDrawArrays(PrimitiveType mode, int first, int count);
		internal delegate void glDrawArraysIndirect(PrimitiveType mode, IntPtr indirect);
		internal delegate void glDrawArraysInstanced(PrimitiveType mode, int first, int count, int instancecount);
		internal unsafe delegate void glDrawBuffers(int n, DrawBufferMode* bufs);
		internal delegate void glDrawElements(PrimitiveType mode, int count, DrawElementsType type, IntPtr indices);
		internal delegate void glDrawElementsBaseVertex(PrimitiveType mode, int count, DrawElementsType type, IntPtr indices, int basevertex);
		internal delegate void glDrawElementsIndirect(PrimitiveType mode, DrawElementsType type, IntPtr indirect);
		internal delegate void glDrawElementsInstanced(PrimitiveType mode, int count, DrawElementsType type, IntPtr indices, int instancecount);
		internal delegate void glDrawElementsInstancedBaseVertex(PrimitiveType mode, int count, DrawElementsType type, IntPtr indices, int instancecount, int basevertex);
		internal delegate void glDrawRangeElements(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, IntPtr indices);
		internal delegate void glDrawRangeElementsBaseVertex(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, IntPtr indices, int basevertex);
		#endregion

		#region E:

		internal delegate void glEnable(EnableCap cap);
		internal delegate void glEnableClientState(EnableCap array);
		internal delegate void glEnablei(EnableCap target, uint index);
		internal delegate void glEnableVertexAttribArray(uint index);
		internal delegate void glEndQuery(QueryTarget target);
		internal delegate void glEndTransformFeedback();
		#endregion

		#region F:

		internal delegate IntPtr glFenceSync(SyncCondition condition, SyncBehaviorFlags flags);
		internal delegate void glFinish();
		internal delegate void glFlush();
		internal delegate void glFlushMappedBufferRange(BufferTargetARB target, IntPtr offset, int length);
		internal delegate void glFogf(FogParameter pname, float param);
		internal unsafe delegate void glFogfv(FogParameter pname, float* @params);
		internal delegate void glFogx(FogPName pname, int param);
		internal unsafe delegate void glFogxv(FogPName pname, int* param);
		internal delegate void glFramebufferParameteri(FramebufferTarget target, FramebufferParameterName pname, int param);
		internal delegate void glFramebufferRenderbuffer(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, uint renderbuffer);
		internal delegate void glFramebufferTexture(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level);
		internal delegate void glFramebufferTexture2D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level);
		internal delegate void glFramebufferTextureLayer(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, int layer);
		internal delegate void glFrontFace(FrontFaceDirection mode);
		internal delegate void glFrustumf(float l, float r, float b, float t, float n, float f);
		internal delegate void glFrustumx(int l, int r, int b, int t, int n, int f);
		#endregion

		#region G:

		internal unsafe delegate void glGenBuffers(int n, uint* buffers);
		internal delegate void glGenerateMipmap(TextureTarget target);
		internal unsafe delegate void glGenFramebuffers(int n, uint* framebuffers);
		internal unsafe delegate void glGenProgramPipelines(int n, uint* pipelines);
		internal unsafe delegate void glGenQueries(int n, uint* ids);
		internal unsafe delegate void glGenRenderbuffers(int n, uint* renderbuffers);
		internal unsafe delegate void glGenSamplers(int count, uint* samplers);
		internal unsafe delegate void glGenTextures(int n, uint* textures);
		internal unsafe delegate void glGenTransformFeedbacks(int n, uint* ids);
		internal unsafe delegate void glGenVertexArrays(int n, uint* arrays);
		internal unsafe delegate void glGetActiveAttrib(uint program, uint index, int bufSize, int* length, int* size, AttributeType* type, StringBuilder name);
		internal unsafe delegate void glGetActiveUniform(uint program, uint index, int bufSize, int* length, int* size, UniformType* type, StringBuilder name);
		internal unsafe delegate void glGetActiveUniformBlockiv(uint program, uint uniformBlockIndex, UniformBlockPName pname, int* @params);
		internal unsafe delegate void glGetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, int* length, StringBuilder uniformBlockName);
		internal unsafe delegate void glGetActiveUniformsiv(uint program, int uniformCount, uint* uniformIndices, UniformPName pname, int* @params);
		internal unsafe delegate void glGetAttachedShaders(uint program, int maxCount, int* count, uint* shaders);
		internal unsafe delegate int glGetAttribLocation(uint program, string name);
		internal unsafe delegate void glGetBooleani_v(BufferTargetARB target, uint index, Boolean* data);
		internal unsafe delegate void glGetBooleanv(GetPName pname, Boolean* data);
		internal unsafe delegate void glGetBufferParameteri64v(BufferTargetARB target, BufferPNameARB pname, long* @params);
		internal unsafe delegate void glGetBufferParameteriv(BufferTargetARB target, BufferPNameARB pname, int* @params);
		internal delegate void glGetBufferPointerv(BufferTargetARB target, BufferPointerNameARB pname, IntPtr @params);
		internal unsafe delegate void glGetClipPlanef(ClipPlaneName plane, float* equation);
		internal unsafe delegate void glGetClipPlanex(ClipPlaneName plane, int* equation);
		internal unsafe delegate uint glGetDebugMessageLog(uint count, int bufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, StringBuilder messageLog);
		internal delegate uint glGetError();
		internal unsafe delegate void glGetFixedv(GetPName pname, int* @params);
		internal unsafe delegate void glGetFloatv(GetPName pname, float* data);
		internal unsafe delegate int glGetFragDataLocation(uint program, string name);
		internal unsafe delegate void glGetFramebufferAttachmentParameteriv(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int* @params);
		internal unsafe delegate void glGetFramebufferParameteriv(FramebufferTarget target, FramebufferAttachmentParameterName pname, int* @params);
		internal delegate uint glGetGraphicsResetStatus();
		internal unsafe delegate void glGetInteger64i_v(GetPName target, uint index, long* data);
		internal unsafe delegate void glGetInteger64v(GetPName pname, long* data);
		internal unsafe delegate void glGetIntegeri_v(GetPName target, uint index, int* data);
		internal unsafe delegate void glGetIntegerv(GetPName pname, int* data);
		internal unsafe delegate void glGetInternalformativ(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, int count, int* @params);
		internal unsafe delegate void glGetLightfv(LightName light, LightParameter pname, float* @params);
		internal unsafe delegate void glGetLightxv(LightName light, LightParameter pname, int* @params);
		internal unsafe delegate void glGetMaterialfv(MaterialFace face, MaterialParameter pname, float* @params);
		internal unsafe delegate void glGetMaterialxv(MaterialFace face, MaterialParameter pname, int* @params);
		internal unsafe delegate void glGetMultisamplefv(GetMultisamplePNameNV pname, uint index, float* val);
		internal unsafe delegate void glGetnUniformfv(uint program, int location, int bufSize, float* @params);
		internal unsafe delegate void glGetnUniformiv(uint program, int location, int bufSize, int* @params);
		internal unsafe delegate void glGetnUniformuiv(uint program, int location, int bufSize, uint* @params);
		internal unsafe delegate void glGetObjectLabel(ObjectIdentifier identifier, uint name, int bufSize, int* length, StringBuilder label);
		internal unsafe delegate void glGetObjectPtrLabel(IntPtr ptr, int bufSize, int* length, StringBuilder label);
		internal delegate void glGetPointerv(GetPointervPName pname, IntPtr @params);
		internal unsafe delegate void glGetProgramBinary(uint program, int bufSize, int* length, uint* binaryFormat, IntPtr binary);
		internal unsafe delegate void glGetProgramInfoLog(uint program, int bufSize, int* length, StringBuilder infoLog);
		internal unsafe delegate void glGetProgramInterfaceiv(uint program, ProgramInterface programInterface, ProgramInterfacePName pname, int* @params);
		internal unsafe delegate void glGetProgramiv(uint program, ProgramPropertyARB pname, int* @params);
		internal unsafe delegate void glGetProgramPipelineInfoLog(uint pipeline, int bufSize, int* length, StringBuilder infoLog);
		internal unsafe delegate void glGetProgramPipelineiv(uint pipeline, PipelineParameterName pname, int* @params);
		internal unsafe delegate uint glGetProgramResourceIndex(uint program, ProgramInterface programInterface, string name);
		internal unsafe delegate void glGetProgramResourceiv(uint program, ProgramInterface programInterface, uint index, int propCount, ProgramResourceProperty* props, int count, int* length, int* @params);
		internal unsafe delegate int glGetProgramResourceLocation(uint program, ProgramInterface programInterface, string name);
		internal unsafe delegate void glGetProgramResourceName(uint program, ProgramInterface programInterface, uint index, int bufSize, int* length, StringBuilder name);
		internal unsafe delegate void glGetQueryiv(QueryTarget target, QueryParameterName pname, int* @params);
		internal unsafe delegate void glGetQueryObjectuiv(uint id, QueryObjectParameterName pname, uint* @params);
		internal unsafe delegate void glGetRenderbufferParameteriv(RenderbufferTarget target, RenderbufferParameterName pname, int* @params);
		internal unsafe delegate void glGetSamplerParameterfv(uint sampler, SamplerParameterF pname, float* @params);
		internal unsafe delegate void glGetSamplerParameterIiv(uint sampler, SamplerParameterI pname, int* @params);
		internal unsafe delegate void glGetSamplerParameterIuiv(uint sampler, SamplerParameterI pname, uint* @params);
		internal unsafe delegate void glGetSamplerParameteriv(uint sampler, SamplerParameterI pname, int* @params);
		internal unsafe delegate void glGetShaderInfoLog(uint shader, int bufSize, int* length, StringBuilder infoLog);
		internal unsafe delegate void glGetShaderiv(uint shader, ShaderParameterName pname, int* @params);
		internal unsafe delegate void glGetShaderPrecisionFormat(ShaderType shadertype, PrecisionType precisiontype, int* range, int* precision);
		internal unsafe delegate void glGetShaderSource(uint shader, int bufSize, int* length, StringBuilder source);
		internal unsafe delegate byte* glGetString(StringName name);
		internal unsafe delegate byte* glGetStringi(StringName name, uint index);
		internal unsafe delegate void glGetSynciv(IntPtr sync, SyncParameterName pname, int count, int* length, int* values);
		internal unsafe delegate void glGetTexEnvfv(TextureEnvTarget target, TextureEnvParameter pname, float* @params);
		internal unsafe delegate void glGetTexEnviv(TextureEnvTarget target, TextureEnvParameter pname, int* @params);
		internal unsafe delegate void glGetTexEnvxv(TextureEnvTarget target, TextureEnvParameter pname, int* @params);
		internal unsafe delegate void glGetTexLevelParameterfv(TextureTarget target, int level, GetTextureParameter pname, float* @params);
		internal unsafe delegate void glGetTexLevelParameteriv(TextureTarget target, int level, GetTextureParameter pname, int* @params);
		internal unsafe delegate void glGetTexParameterfv(TextureTarget target, GetTextureParameter pname, float* @params);
		internal unsafe delegate void glGetTexParameterIiv(TextureTarget target, GetTextureParameter pname, int* @params);
		internal unsafe delegate void glGetTexParameterIuiv(TextureTarget target, GetTextureParameter pname, uint* @params);
		internal unsafe delegate void glGetTexParameteriv(TextureTarget target, GetTextureParameter pname, int* @params);
		internal unsafe delegate void glGetTexParameterxv(TextureTarget target, GetTextureParameter pname, int* @params);
		internal unsafe delegate void glGetTransformFeedbackVarying(uint program, uint index, int bufSize, int* length, int* size, AttributeType* type, StringBuilder name);
		internal unsafe delegate uint glGetUniformBlockIndex(uint program, string uniformBlockName);
		internal unsafe delegate void glGetUniformfv(uint program, int location, float* @params);
		internal unsafe delegate void glGetUniformIndices(uint program, int uniformCount, string[] uniformNames, uint* uniformIndices);
		internal unsafe delegate void glGetUniformiv(uint program, int location, int* @params);
		internal unsafe delegate int glGetUniformLocation(uint program, string name);
		internal unsafe delegate void glGetUniformuiv(uint program, int location, uint* @params);
		internal unsafe delegate void glGetVertexAttribfv(uint index, VertexAttribPropertyARB pname, float* @params);
		internal unsafe delegate void glGetVertexAttribIiv(uint index, VertexAttribEnum pname, int* @params);
		internal unsafe delegate void glGetVertexAttribIuiv(uint index, VertexAttribEnum pname, uint* @params);
		internal unsafe delegate void glGetVertexAttribiv(uint index, VertexAttribPropertyARB pname, int* @params);
		internal delegate void glGetVertexAttribPointerv(uint index, VertexAttribPointerPropertyARB pname, IntPtr pointer);
		#endregion

		#region H:

		internal delegate void glHint(HintTarget target, HintMode mode);
		#endregion

		#region I:

		internal unsafe delegate void glInvalidateFramebuffer(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment* attachments);
		internal unsafe delegate void glInvalidateSubFramebuffer(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment* attachments, int x, int y, int width, int height);
		internal delegate bool glIsBuffer(uint buffer);
		internal delegate bool glIsEnabled(EnableCap cap);
		internal delegate bool glIsEnabledi(EnableCap target, uint index);
		internal delegate bool glIsFramebuffer(uint framebuffer);
		internal delegate bool glIsProgram(uint program);
		internal delegate bool glIsProgramPipeline(uint pipeline);
		internal delegate bool glIsQuery(uint id);
		internal delegate bool glIsRenderbuffer(uint renderbuffer);
		internal delegate bool glIsSampler(uint sampler);
		internal delegate bool glIsShader(uint shader);
		internal delegate bool glIsSync(IntPtr sync);
		internal delegate bool glIsTexture(uint texture);
		internal delegate bool glIsTransformFeedback(uint id);
		internal delegate bool glIsVertexArray(uint array);
		#endregion

		#region L:

		internal delegate void glLightf(LightName light, LightParameter pname, float param);
		internal unsafe delegate void glLightfv(LightName light, LightParameter pname, float* @params);
		internal delegate void glLightModelf(LightModelParameter pname, float param);
		internal unsafe delegate void glLightModelfv(LightModelParameter pname, float* @params);
		internal delegate void glLightModelx(LightModelParameter pname, int param);
		internal unsafe delegate void glLightModelxv(LightModelParameter pname, int* param);
		internal delegate void glLightx(LightName light, LightParameter pname, int param);
		internal unsafe delegate void glLightxv(LightName light, LightParameter pname, int* @params);
		internal delegate void glLineWidth(float width);
		internal delegate void glLineWidthx(int width);
		internal delegate void glLinkProgram(uint program);
		internal delegate void glLoadIdentity();
		internal unsafe delegate void glLoadMatrixf(float* m);
		internal unsafe delegate void glLoadMatrixx(int* m);
		internal delegate void glLogicOp(LogicOp opcode);
		#endregion

		#region M:

		internal unsafe delegate IntPtr* glMapBufferRange(BufferTargetARB target, IntPtr offset, int length, MapBufferAccessMask access);
		internal delegate void glMaterialf(MaterialFace face, MaterialParameter pname, float param);
		internal unsafe delegate void glMaterialfv(MaterialFace face, MaterialParameter pname, float* @params);
		internal delegate void glMaterialx(MaterialFace face, MaterialParameter pname, int param);
		internal unsafe delegate void glMaterialxv(MaterialFace face, MaterialParameter pname, int* param);
		internal delegate void glMatrixMode(MatrixMode mode);
		internal delegate void glMemoryBarrier(MemoryBarrierMask barriers);
		internal delegate void glMemoryBarrierByRegion(MemoryBarrierMask barriers);
		internal delegate void glMinSampleShading(float value);
		internal delegate void glMultiTexCoord4f(TextureUnit target, float s, float t, float r, float q);
		internal delegate void glMultiTexCoord4x(TextureUnit texture, int s, int t, int r, int q);
		internal unsafe delegate void glMultMatrixf(float* m);
		internal unsafe delegate void glMultMatrixx(int* m);
		#endregion

		#region N:

		internal delegate void glNormal3f(float nx, float ny, float nz);
		internal delegate void glNormal3x(int nx, int ny, int nz);
		internal delegate void glNormalPointer(NormalPointerType type, int stride, IntPtr pointer);
		#endregion

		#region O:

		internal unsafe delegate void glObjectLabel(ObjectIdentifier identifier, uint name, int length, string label);
		internal unsafe delegate void glObjectPtrLabel(IntPtr ptr, int length, string label);
		internal delegate void glOrthof(float l, float r, float b, float t, float n, float f);
		internal delegate void glOrthox(int l, int r, int b, int t, int n, int f);
		#endregion

		#region P:

		internal delegate void glPatchParameteri(PatchParameterName pname, int value);
		internal delegate void glPauseTransformFeedback();
		internal delegate void glPixelStorei(PixelStoreParameter pname, int param);
		internal delegate void glPointParameterf(PointParameterNameARB pname, float param);
		internal unsafe delegate void glPointParameterfv(PointParameterNameARB pname, float* @params);
		internal delegate void glPointParameterx(PointParameterNameARB pname, int param);
		internal unsafe delegate void glPointParameterxv(PointParameterNameARB pname, int* @params);
		internal delegate void glPointSize(float size);
		internal delegate void glPointSizex(int size);
		internal delegate void glPolygonOffset(float factor, float units);
		internal delegate void glPolygonOffsetx(int factor, int units);
		internal delegate void glPopDebugGroup();
		internal delegate void glPopMatrix();
		internal delegate void glPrimitiveBoundingBox(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW);
		internal delegate void glProgramBinary(uint program, uint binaryFormat, IntPtr binary, int length);
		internal delegate void glProgramParameteri(uint program, ProgramParameterPName pname, int value);
		internal delegate void glProgramUniform1f(uint program, int location, float v0);
		internal unsafe delegate void glProgramUniform1fv(uint program, int location, int count, float* value);
		internal delegate void glProgramUniform1i(uint program, int location, int v0);
		internal unsafe delegate void glProgramUniform1iv(uint program, int location, int count, int* value);
		internal delegate void glProgramUniform1ui(uint program, int location, uint v0);
		internal unsafe delegate void glProgramUniform1uiv(uint program, int location, int count, uint* value);
		internal delegate void glProgramUniform2f(uint program, int location, float v0, float v1);
		internal unsafe delegate void glProgramUniform2fv(uint program, int location, int count, float* value);
		internal delegate void glProgramUniform2i(uint program, int location, int v0, int v1);
		internal unsafe delegate void glProgramUniform2iv(uint program, int location, int count, int* value);
		internal delegate void glProgramUniform2ui(uint program, int location, uint v0, uint v1);
		internal unsafe delegate void glProgramUniform2uiv(uint program, int location, int count, uint* value);
		internal delegate void glProgramUniform3f(uint program, int location, float v0, float v1, float v2);
		internal unsafe delegate void glProgramUniform3fv(uint program, int location, int count, float* value);
		internal delegate void glProgramUniform3i(uint program, int location, int v0, int v1, int v2);
		internal unsafe delegate void glProgramUniform3iv(uint program, int location, int count, int* value);
		internal delegate void glProgramUniform3ui(uint program, int location, uint v0, uint v1, uint v2);
		internal unsafe delegate void glProgramUniform3uiv(uint program, int location, int count, uint* value);
		internal delegate void glProgramUniform4f(uint program, int location, float v0, float v1, float v2, float v3);
		internal unsafe delegate void glProgramUniform4fv(uint program, int location, int count, float* value);
		internal delegate void glProgramUniform4i(uint program, int location, int v0, int v1, int v2, int v3);
		internal unsafe delegate void glProgramUniform4iv(uint program, int location, int count, int* value);
		internal delegate void glProgramUniform4ui(uint program, int location, uint v0, uint v1, uint v2, uint v3);
		internal unsafe delegate void glProgramUniform4uiv(uint program, int location, int count, uint* value);
		internal unsafe delegate void glProgramUniformMatrix2fv(uint program, int location, int count, Boolean transpose, float* value);
		internal unsafe delegate void glProgramUniformMatrix2x3fv(uint program, int location, int count, Boolean transpose, float* value);
		internal unsafe delegate void glProgramUniformMatrix2x4fv(uint program, int location, int count, Boolean transpose, float* value);
		internal unsafe delegate void glProgramUniformMatrix3fv(uint program, int location, int count, Boolean transpose, float* value);
		internal unsafe delegate void glProgramUniformMatrix3x2fv(uint program, int location, int count, Boolean transpose, float* value);
		internal unsafe delegate void glProgramUniformMatrix3x4fv(uint program, int location, int count, Boolean transpose, float* value);
		internal unsafe delegate void glProgramUniformMatrix4fv(uint program, int location, int count, Boolean transpose, float* value);
		internal unsafe delegate void glProgramUniformMatrix4x2fv(uint program, int location, int count, Boolean transpose, float* value);
		internal unsafe delegate void glProgramUniformMatrix4x3fv(uint program, int location, int count, Boolean transpose, float* value);
		internal unsafe delegate void glPushDebugGroup(DebugSource source, uint id, int length, string message);
		internal delegate void glPushMatrix();
		#endregion

		#region R:

		internal delegate void glReadBuffer(ReadBufferMode src);
		internal delegate void glReadnPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, IntPtr data);
		internal delegate void glReadPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, IntPtr pixels);
		internal delegate void glReleaseShaderCompiler();
		internal delegate void glRenderbufferStorage(RenderbufferTarget target, InternalFormat internalformat, int width, int height);
		internal delegate void glRenderbufferStorageMultisample(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height);
		internal delegate void glResumeTransformFeedback();
		internal delegate void glRotatef(float angle, float x, float y, float z);
		internal delegate void glRotatex(int angle, int x, int y, int z);
		#endregion

		#region S:

		internal delegate void glSampleCoverage(float value, Boolean invert);
		internal delegate void glSampleCoveragex(int value, Boolean invert);
		internal delegate void glSampleMaski(uint maskNumber, uint mask);
		internal delegate void glSamplerParameterf(uint sampler, SamplerParameterF pname, float param);
		internal unsafe delegate void glSamplerParameterfv(uint sampler, SamplerParameterF pname, float* param);
		internal delegate void glSamplerParameteri(uint sampler, SamplerParameterI pname, int param);
		internal unsafe delegate void glSamplerParameterIiv(uint sampler, SamplerParameterI pname, int* param);
		internal unsafe delegate void glSamplerParameterIuiv(uint sampler, SamplerParameterI pname, uint* param);
		internal unsafe delegate void glSamplerParameteriv(uint sampler, SamplerParameterI pname, int* param);
		internal delegate void glScalef(float x, float y, float z);
		internal delegate void glScalex(int x, int y, int z);
		internal delegate void glScissor(int x, int y, int width, int height);
		internal delegate void glShadeModel(ShadingModel mode);
		internal unsafe delegate void glShaderBinary(int count, uint* shaders, ShaderBinaryFormat binaryFormat, IntPtr binary, int length);
		internal unsafe delegate void glShaderSource(uint shader, int count, string[] @string, int* length);
		internal delegate void glStencilFunc(StencilFunction func, int @ref, uint mask);
		internal delegate void glStencilFuncSeparate(StencilFaceDirection face, StencilFunction func, int @ref, uint mask);
		internal delegate void glStencilMask(uint mask);
		internal delegate void glStencilMaskSeparate(StencilFaceDirection face, uint mask);
		internal delegate void glStencilOp(StencilOp fail, StencilOp zfail, StencilOp zpass);
		internal delegate void glStencilOpSeparate(StencilFaceDirection face, StencilOp sfail, StencilOp dpfail, StencilOp dppass);
		#endregion

		#region T:

		internal delegate void glTexBuffer(TextureTarget target, SizedInternalFormat internalformat, uint buffer);
		internal delegate void glTexBufferRange(TextureTarget target, SizedInternalFormat internalformat, uint buffer, IntPtr offset, int size);
		internal delegate void glTexCoordPointer(int size, TexCoordPointerType type, int stride, IntPtr pointer);
		internal delegate void glTexEnvf(TextureEnvTarget target, TextureEnvParameter pname, float param);
		internal unsafe delegate void glTexEnvfv(TextureEnvTarget target, TextureEnvParameter pname, float* @params);
		internal delegate void glTexEnvi(TextureEnvTarget target, TextureEnvParameter pname, int param);
		internal unsafe delegate void glTexEnviv(TextureEnvTarget target, TextureEnvParameter pname, int* @params);
		internal delegate void glTexEnvx(TextureEnvTarget target, TextureEnvParameter pname, int param);
		internal unsafe delegate void glTexEnvxv(TextureEnvTarget target, TextureEnvParameter pname, int* @params);
		internal delegate void glTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, PixelFormat format, PixelType type, IntPtr pixels);
		internal delegate void glTexImage3D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, IntPtr pixels);
		internal delegate void glTexParameterf(TextureTarget target, TextureParameterName pname, float param);
		internal unsafe delegate void glTexParameterfv(TextureTarget target, TextureParameterName pname, float* @params);
		internal delegate void glTexParameteri(TextureTarget target, TextureParameterName pname, int param);
		internal unsafe delegate void glTexParameterIiv(TextureTarget target, TextureParameterName pname, int* @params);
		internal unsafe delegate void glTexParameterIuiv(TextureTarget target, TextureParameterName pname, uint* @params);
		internal unsafe delegate void glTexParameteriv(TextureTarget target, TextureParameterName pname, int* @params);
		internal delegate void glTexParameterx(TextureTarget target, GetTextureParameter pname, int param);
		internal unsafe delegate void glTexParameterxv(TextureTarget target, GetTextureParameter pname, int* @params);
		internal delegate void glTexStorage2D(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height);
		internal delegate void glTexStorage2DMultisample(TextureTarget target, int samples, SizedInternalFormat internalformat, int width, int height, Boolean fixedsamplelocations);
		internal delegate void glTexStorage3D(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height, int depth);
		internal delegate void glTexStorage3DMultisample(TextureTarget target, int samples, SizedInternalFormat internalformat, int width, int height, int depth, Boolean fixedsamplelocations);
		internal delegate void glTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, IntPtr pixels);
		internal delegate void glTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels);
		internal unsafe delegate void glTransformFeedbackVaryings(uint program, int count, string[] varyings, TransformFeedbackBufferMode bufferMode);
		internal delegate void glTranslatef(float x, float y, float z);
		internal delegate void glTranslatex(int x, int y, int z);
		#endregion

		#region U:

		internal delegate void glUniform1f(int location, float v0);
		internal unsafe delegate void glUniform1fv(int location, int count, float* value);
		internal delegate void glUniform1i(int location, int v0);
		internal unsafe delegate void glUniform1iv(int location, int count, int* value);
		internal delegate void glUniform1ui(int location, uint v0);
		internal unsafe delegate void glUniform1uiv(int location, int count, uint* value);
		internal delegate void glUniform2f(int location, float v0, float v1);
		internal unsafe delegate void glUniform2fv(int location, int count, float* value);
		internal delegate void glUniform2i(int location, int v0, int v1);
		internal unsafe delegate void glUniform2iv(int location, int count, int* value);
		internal delegate void glUniform2ui(int location, uint v0, uint v1);
		internal unsafe delegate void glUniform2uiv(int location, int count, uint* value);
		internal delegate void glUniform3f(int location, float v0, float v1, float v2);
		internal unsafe delegate void glUniform3fv(int location, int count, float* value);
		internal delegate void glUniform3i(int location, int v0, int v1, int v2);
		internal unsafe delegate void glUniform3iv(int location, int count, int* value);
		internal delegate void glUniform3ui(int location, uint v0, uint v1, uint v2);
		internal unsafe delegate void glUniform3uiv(int location, int count, uint* value);
		internal delegate void glUniform4f(int location, float v0, float v1, float v2, float v3);
		internal unsafe delegate void glUniform4fv(int location, int count, float* value);
		internal delegate void glUniform4i(int location, int v0, int v1, int v2, int v3);
		internal unsafe delegate void glUniform4iv(int location, int count, int* value);
		internal delegate void glUniform4ui(int location, uint v0, uint v1, uint v2, uint v3);
		internal unsafe delegate void glUniform4uiv(int location, int count, uint* value);
		internal delegate void glUniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding);
		internal unsafe delegate void glUniformMatrix2fv(int location, int count, Boolean transpose, float* value);
		internal unsafe delegate void glUniformMatrix2x3fv(int location, int count, Boolean transpose, float* value);
		internal unsafe delegate void glUniformMatrix2x4fv(int location, int count, Boolean transpose, float* value);
		internal unsafe delegate void glUniformMatrix3fv(int location, int count, Boolean transpose, float* value);
		internal unsafe delegate void glUniformMatrix3x2fv(int location, int count, Boolean transpose, float* value);
		internal unsafe delegate void glUniformMatrix3x4fv(int location, int count, Boolean transpose, float* value);
		internal unsafe delegate void glUniformMatrix4fv(int location, int count, Boolean transpose, float* value);
		internal unsafe delegate void glUniformMatrix4x2fv(int location, int count, Boolean transpose, float* value);
		internal unsafe delegate void glUniformMatrix4x3fv(int location, int count, Boolean transpose, float* value);
		internal delegate bool glUnmapBuffer(BufferTargetARB target);
		internal delegate void glUseProgram(uint program);
		internal delegate void glUseProgramStages(uint pipeline, UseProgramStageMask stages, uint program);
		#endregion

		#region V:

		internal delegate void glValidateProgram(uint program);
		internal delegate void glValidateProgramPipeline(uint pipeline);
		internal delegate void glVertexAttrib1f(uint index, float x);
		internal unsafe delegate void glVertexAttrib1fv(uint index, float* v);
		internal delegate void glVertexAttrib2f(uint index, float x, float y);
		internal unsafe delegate void glVertexAttrib2fv(uint index, float* v);
		internal delegate void glVertexAttrib3f(uint index, float x, float y, float z);
		internal unsafe delegate void glVertexAttrib3fv(uint index, float* v);
		internal delegate void glVertexAttrib4f(uint index, float x, float y, float z, float w);
		internal unsafe delegate void glVertexAttrib4fv(uint index, float* v);
		internal delegate void glVertexAttribBinding(uint attribindex, uint bindingindex);
		internal delegate void glVertexAttribDivisor(uint index, uint divisor);
		internal delegate void glVertexAttribFormat(uint attribindex, int size, VertexAttribType type, Boolean normalized, uint relativeoffset);
		internal delegate void glVertexAttribI4i(uint index, int x, int y, int z, int w);
		internal unsafe delegate void glVertexAttribI4iv(uint index, int* v);
		internal delegate void glVertexAttribI4ui(uint index, uint x, uint y, uint z, uint w);
		internal unsafe delegate void glVertexAttribI4uiv(uint index, uint* v);
		internal delegate void glVertexAttribIFormat(uint attribindex, int size, VertexAttribIType type, uint relativeoffset);
		internal delegate void glVertexAttribIPointer(uint index, int size, VertexAttribIType type, int stride, IntPtr pointer);
		internal delegate void glVertexAttribPointer(uint index, int size, VertexAttribPointerType type, Boolean normalized, int stride, IntPtr pointer);
		internal delegate void glVertexBindingDivisor(uint bindingindex, uint divisor);
		internal delegate void glVertexPointer(int size, VertexPointerType type, int stride, IntPtr pointer);
		internal delegate void glViewport(int x, int y, int width, int height);
		#endregion

		#region W:

		internal delegate void glWaitSync(IntPtr sync, SyncBehaviorFlags flags, ulong timeout);
		#endregion

	}
}

