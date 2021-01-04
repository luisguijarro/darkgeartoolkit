// OpenGL Delegates Initializer for Extensions.
// File Created with OpenGL Parser 3.
// Developed by Luis Guijarro Pérez.

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace dgtk.OpenGL
{
	internal static partial class DelegastesInitGL
	{
		private static List<string> SuportedExt;

		internal static void InitDelegatesExts()
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
				glGetIntegerv = (dglGetIntegerv)dgtk.OpenGL.InternalTool.GetGLMethodAdress("glGetIntegerv", typeof(dglGetIntegerv));
				glGetStringi = (dglGetStringi)dgtk.OpenGL.InternalTool.GetGLMethodAdress("glGetStringi", typeof(dglGetStringi));
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
				dgtk.OpenGL.internalGL.glAccumxOES = (dgtk.OpenGL.delegatesGL.glAccumxOES) InternalTool.GetGLMethodAdress("glAccumxOES", typeof(dgtk.OpenGL.delegatesGL.glAccumxOES));
			}
			if (SuportedExt.Contains("glAcquireKeyedMutexWin32EXT"))
			{
				dgtk.OpenGL.internalGL.glAcquireKeyedMutexWin32EXT = (dgtk.OpenGL.delegatesGL.glAcquireKeyedMutexWin32EXT) InternalTool.GetGLMethodAdress("glAcquireKeyedMutexWin32EXT", typeof(dgtk.OpenGL.delegatesGL.glAcquireKeyedMutexWin32EXT));
			}
			if (SuportedExt.Contains("glActiveProgramEXT"))
			{
				dgtk.OpenGL.internalGL.glActiveProgramEXT = (dgtk.OpenGL.delegatesGL.glActiveProgramEXT) InternalTool.GetGLMethodAdress("glActiveProgramEXT", typeof(dgtk.OpenGL.delegatesGL.glActiveProgramEXT));
			}
			if (SuportedExt.Contains("glActiveShaderProgramEXT"))
			{
				dgtk.OpenGL.internalGL.glActiveShaderProgramEXT = (dgtk.OpenGL.delegatesGL.glActiveShaderProgramEXT) InternalTool.GetGLMethodAdress("glActiveShaderProgramEXT", typeof(dgtk.OpenGL.delegatesGL.glActiveShaderProgramEXT));
			}
			if (SuportedExt.Contains("glActiveStencilFaceEXT"))
			{
				dgtk.OpenGL.internalGL.glActiveStencilFaceEXT = (dgtk.OpenGL.delegatesGL.glActiveStencilFaceEXT) InternalTool.GetGLMethodAdress("glActiveStencilFaceEXT", typeof(dgtk.OpenGL.delegatesGL.glActiveStencilFaceEXT));
			}
			if (SuportedExt.Contains("glActiveTextureARB"))
			{
				dgtk.OpenGL.internalGL.glActiveTextureARB = (dgtk.OpenGL.delegatesGL.glActiveTextureARB) InternalTool.GetGLMethodAdress("glActiveTextureARB", typeof(dgtk.OpenGL.delegatesGL.glActiveTextureARB));
			}
			if (SuportedExt.Contains("glActiveVaryingNV"))
			{
				dgtk.OpenGL.internalGL.glActiveVaryingNV = (dgtk.OpenGL.delegatesGL.glActiveVaryingNV) InternalTool.GetGLMethodAdress("glActiveVaryingNV", typeof(dgtk.OpenGL.delegatesGL.glActiveVaryingNV));
			}
			if (SuportedExt.Contains("glAlphaFragmentOp1ATI"))
			{
				dgtk.OpenGL.internalGL.glAlphaFragmentOp1ATI = (dgtk.OpenGL.delegatesGL.glAlphaFragmentOp1ATI) InternalTool.GetGLMethodAdress("glAlphaFragmentOp1ATI", typeof(dgtk.OpenGL.delegatesGL.glAlphaFragmentOp1ATI));
			}
			if (SuportedExt.Contains("glAlphaFragmentOp2ATI"))
			{
				dgtk.OpenGL.internalGL.glAlphaFragmentOp2ATI = (dgtk.OpenGL.delegatesGL.glAlphaFragmentOp2ATI) InternalTool.GetGLMethodAdress("glAlphaFragmentOp2ATI", typeof(dgtk.OpenGL.delegatesGL.glAlphaFragmentOp2ATI));
			}
			if (SuportedExt.Contains("glAlphaFragmentOp3ATI"))
			{
				dgtk.OpenGL.internalGL.glAlphaFragmentOp3ATI = (dgtk.OpenGL.delegatesGL.glAlphaFragmentOp3ATI) InternalTool.GetGLMethodAdress("glAlphaFragmentOp3ATI", typeof(dgtk.OpenGL.delegatesGL.glAlphaFragmentOp3ATI));
			}
			if (SuportedExt.Contains("glAlphaFuncQCOM"))
			{
				dgtk.OpenGL.internalGL.glAlphaFuncQCOM = (dgtk.OpenGL.delegatesGL.glAlphaFuncQCOM) InternalTool.GetGLMethodAdress("glAlphaFuncQCOM", typeof(dgtk.OpenGL.delegatesGL.glAlphaFuncQCOM));
			}
			if (SuportedExt.Contains("glAlphaFuncx"))
			{
				dgtk.OpenGL.internalGL.glAlphaFuncx = (dgtk.OpenGL.delegatesGL.glAlphaFuncx) InternalTool.GetGLMethodAdress("glAlphaFuncx", typeof(dgtk.OpenGL.delegatesGL.glAlphaFuncx));
			}
			if (SuportedExt.Contains("glAlphaFuncxOES"))
			{
				dgtk.OpenGL.internalGL.glAlphaFuncxOES = (dgtk.OpenGL.delegatesGL.glAlphaFuncxOES) InternalTool.GetGLMethodAdress("glAlphaFuncxOES", typeof(dgtk.OpenGL.delegatesGL.glAlphaFuncxOES));
			}
			if (SuportedExt.Contains("glAlphaToCoverageDitherControlNV"))
			{
				dgtk.OpenGL.internalGL.glAlphaToCoverageDitherControlNV = (dgtk.OpenGL.delegatesGL.glAlphaToCoverageDitherControlNV) InternalTool.GetGLMethodAdress("glAlphaToCoverageDitherControlNV", typeof(dgtk.OpenGL.delegatesGL.glAlphaToCoverageDitherControlNV));
			}
			if (SuportedExt.Contains("glApplyFramebufferAttachmentCMAAINTEL"))
			{
				dgtk.OpenGL.internalGL.glApplyFramebufferAttachmentCMAAINTEL = (dgtk.OpenGL.delegatesGL.glApplyFramebufferAttachmentCMAAINTEL) InternalTool.GetGLMethodAdress("glApplyFramebufferAttachmentCMAAINTEL", typeof(dgtk.OpenGL.delegatesGL.glApplyFramebufferAttachmentCMAAINTEL));
			}
			if (SuportedExt.Contains("glApplyTextureEXT"))
			{
				dgtk.OpenGL.internalGL.glApplyTextureEXT = (dgtk.OpenGL.delegatesGL.glApplyTextureEXT) InternalTool.GetGLMethodAdress("glApplyTextureEXT", typeof(dgtk.OpenGL.delegatesGL.glApplyTextureEXT));
			}
			if (SuportedExt.Contains("glAreProgramsResidentNV"))
			{
				dgtk.OpenGL.internalGL.glAreProgramsResidentNV = (dgtk.OpenGL.delegatesGL.glAreProgramsResidentNV) InternalTool.GetGLMethodAdress("glAreProgramsResidentNV", typeof(dgtk.OpenGL.delegatesGL.glAreProgramsResidentNV));
			}
			if (SuportedExt.Contains("glAreTexturesResidentEXT"))
			{
				dgtk.OpenGL.internalGL.glAreTexturesResidentEXT = (dgtk.OpenGL.delegatesGL.glAreTexturesResidentEXT) InternalTool.GetGLMethodAdress("glAreTexturesResidentEXT", typeof(dgtk.OpenGL.delegatesGL.glAreTexturesResidentEXT));
			}
			if (SuportedExt.Contains("glArrayElementEXT"))
			{
				dgtk.OpenGL.internalGL.glArrayElementEXT = (dgtk.OpenGL.delegatesGL.glArrayElementEXT) InternalTool.GetGLMethodAdress("glArrayElementEXT", typeof(dgtk.OpenGL.delegatesGL.glArrayElementEXT));
			}
			if (SuportedExt.Contains("glArrayObjectATI"))
			{
				dgtk.OpenGL.internalGL.glArrayObjectATI = (dgtk.OpenGL.delegatesGL.glArrayObjectATI) InternalTool.GetGLMethodAdress("glArrayObjectATI", typeof(dgtk.OpenGL.delegatesGL.glArrayObjectATI));
			}
			if (SuportedExt.Contains("glAsyncCopyBufferSubDataNVX"))
			{
				dgtk.OpenGL.internalGL.glAsyncCopyBufferSubDataNVX = (dgtk.OpenGL.delegatesGL.glAsyncCopyBufferSubDataNVX) InternalTool.GetGLMethodAdress("glAsyncCopyBufferSubDataNVX", typeof(dgtk.OpenGL.delegatesGL.glAsyncCopyBufferSubDataNVX));
			}
			if (SuportedExt.Contains("glAsyncCopyImageSubDataNVX"))
			{
				dgtk.OpenGL.internalGL.glAsyncCopyImageSubDataNVX = (dgtk.OpenGL.delegatesGL.glAsyncCopyImageSubDataNVX) InternalTool.GetGLMethodAdress("glAsyncCopyImageSubDataNVX", typeof(dgtk.OpenGL.delegatesGL.glAsyncCopyImageSubDataNVX));
			}
			if (SuportedExt.Contains("glAsyncMarkerSGIX"))
			{
				dgtk.OpenGL.internalGL.glAsyncMarkerSGIX = (dgtk.OpenGL.delegatesGL.glAsyncMarkerSGIX) InternalTool.GetGLMethodAdress("glAsyncMarkerSGIX", typeof(dgtk.OpenGL.delegatesGL.glAsyncMarkerSGIX));
			}
			if (SuportedExt.Contains("glAttachObjectARB"))
			{
				dgtk.OpenGL.internalGL.glAttachObjectARB = (dgtk.OpenGL.delegatesGL.glAttachObjectARB) InternalTool.GetGLMethodAdress("glAttachObjectARB", typeof(dgtk.OpenGL.delegatesGL.glAttachObjectARB));
			}
			#endregion

			#region B:

			if (SuportedExt.Contains("glBeginConditionalRenderNV"))
			{
				dgtk.OpenGL.internalGL.glBeginConditionalRenderNV = (dgtk.OpenGL.delegatesGL.glBeginConditionalRenderNV) InternalTool.GetGLMethodAdress("glBeginConditionalRenderNV", typeof(dgtk.OpenGL.delegatesGL.glBeginConditionalRenderNV));
			}
			if (SuportedExt.Contains("glBeginConditionalRenderNVX"))
			{
				dgtk.OpenGL.internalGL.glBeginConditionalRenderNVX = (dgtk.OpenGL.delegatesGL.glBeginConditionalRenderNVX) InternalTool.GetGLMethodAdress("glBeginConditionalRenderNVX", typeof(dgtk.OpenGL.delegatesGL.glBeginConditionalRenderNVX));
			}
			if (SuportedExt.Contains("glBeginFragmentShaderATI"))
			{
				dgtk.OpenGL.internalGL.glBeginFragmentShaderATI = (dgtk.OpenGL.delegatesGL.glBeginFragmentShaderATI) InternalTool.GetGLMethodAdress("glBeginFragmentShaderATI", typeof(dgtk.OpenGL.delegatesGL.glBeginFragmentShaderATI));
			}
			if (SuportedExt.Contains("glBeginOcclusionQueryNV"))
			{
				dgtk.OpenGL.internalGL.glBeginOcclusionQueryNV = (dgtk.OpenGL.delegatesGL.glBeginOcclusionQueryNV) InternalTool.GetGLMethodAdress("glBeginOcclusionQueryNV", typeof(dgtk.OpenGL.delegatesGL.glBeginOcclusionQueryNV));
			}
			if (SuportedExt.Contains("glBeginPerfMonitorAMD"))
			{
				dgtk.OpenGL.internalGL.glBeginPerfMonitorAMD = (dgtk.OpenGL.delegatesGL.glBeginPerfMonitorAMD) InternalTool.GetGLMethodAdress("glBeginPerfMonitorAMD", typeof(dgtk.OpenGL.delegatesGL.glBeginPerfMonitorAMD));
			}
			if (SuportedExt.Contains("glBeginPerfQueryINTEL"))
			{
				dgtk.OpenGL.internalGL.glBeginPerfQueryINTEL = (dgtk.OpenGL.delegatesGL.glBeginPerfQueryINTEL) InternalTool.GetGLMethodAdress("glBeginPerfQueryINTEL", typeof(dgtk.OpenGL.delegatesGL.glBeginPerfQueryINTEL));
			}
			if (SuportedExt.Contains("glBeginQueryARB"))
			{
				dgtk.OpenGL.internalGL.glBeginQueryARB = (dgtk.OpenGL.delegatesGL.glBeginQueryARB) InternalTool.GetGLMethodAdress("glBeginQueryARB", typeof(dgtk.OpenGL.delegatesGL.glBeginQueryARB));
			}
			if (SuportedExt.Contains("glBeginQueryEXT"))
			{
				dgtk.OpenGL.internalGL.glBeginQueryEXT = (dgtk.OpenGL.delegatesGL.glBeginQueryEXT) InternalTool.GetGLMethodAdress("glBeginQueryEXT", typeof(dgtk.OpenGL.delegatesGL.glBeginQueryEXT));
			}
			if (SuportedExt.Contains("glBeginTransformFeedbackEXT"))
			{
				dgtk.OpenGL.internalGL.glBeginTransformFeedbackEXT = (dgtk.OpenGL.delegatesGL.glBeginTransformFeedbackEXT) InternalTool.GetGLMethodAdress("glBeginTransformFeedbackEXT", typeof(dgtk.OpenGL.delegatesGL.glBeginTransformFeedbackEXT));
			}
			if (SuportedExt.Contains("glBeginTransformFeedbackNV"))
			{
				dgtk.OpenGL.internalGL.glBeginTransformFeedbackNV = (dgtk.OpenGL.delegatesGL.glBeginTransformFeedbackNV) InternalTool.GetGLMethodAdress("glBeginTransformFeedbackNV", typeof(dgtk.OpenGL.delegatesGL.glBeginTransformFeedbackNV));
			}
			if (SuportedExt.Contains("glBeginVertexShaderEXT"))
			{
				dgtk.OpenGL.internalGL.glBeginVertexShaderEXT = (dgtk.OpenGL.delegatesGL.glBeginVertexShaderEXT) InternalTool.GetGLMethodAdress("glBeginVertexShaderEXT", typeof(dgtk.OpenGL.delegatesGL.glBeginVertexShaderEXT));
			}
			if (SuportedExt.Contains("glBeginVideoCaptureNV"))
			{
				dgtk.OpenGL.internalGL.glBeginVideoCaptureNV = (dgtk.OpenGL.delegatesGL.glBeginVideoCaptureNV) InternalTool.GetGLMethodAdress("glBeginVideoCaptureNV", typeof(dgtk.OpenGL.delegatesGL.glBeginVideoCaptureNV));
			}
			if (SuportedExt.Contains("glBindAttribLocationARB"))
			{
				dgtk.OpenGL.internalGL.glBindAttribLocationARB = (dgtk.OpenGL.delegatesGL.glBindAttribLocationARB) InternalTool.GetGLMethodAdress("glBindAttribLocationARB", typeof(dgtk.OpenGL.delegatesGL.glBindAttribLocationARB));
			}
			if (SuportedExt.Contains("glBindBufferARB"))
			{
				dgtk.OpenGL.internalGL.glBindBufferARB = (dgtk.OpenGL.delegatesGL.glBindBufferARB) InternalTool.GetGLMethodAdress("glBindBufferARB", typeof(dgtk.OpenGL.delegatesGL.glBindBufferARB));
			}
			if (SuportedExt.Contains("glBindBufferBaseEXT"))
			{
				dgtk.OpenGL.internalGL.glBindBufferBaseEXT = (dgtk.OpenGL.delegatesGL.glBindBufferBaseEXT) InternalTool.GetGLMethodAdress("glBindBufferBaseEXT", typeof(dgtk.OpenGL.delegatesGL.glBindBufferBaseEXT));
			}
			if (SuportedExt.Contains("glBindBufferBaseNV"))
			{
				dgtk.OpenGL.internalGL.glBindBufferBaseNV = (dgtk.OpenGL.delegatesGL.glBindBufferBaseNV) InternalTool.GetGLMethodAdress("glBindBufferBaseNV", typeof(dgtk.OpenGL.delegatesGL.glBindBufferBaseNV));
			}
			if (SuportedExt.Contains("glBindBufferOffsetEXT"))
			{
				dgtk.OpenGL.internalGL.glBindBufferOffsetEXT = (dgtk.OpenGL.delegatesGL.glBindBufferOffsetEXT) InternalTool.GetGLMethodAdress("glBindBufferOffsetEXT", typeof(dgtk.OpenGL.delegatesGL.glBindBufferOffsetEXT));
			}
			if (SuportedExt.Contains("glBindBufferOffsetNV"))
			{
				dgtk.OpenGL.internalGL.glBindBufferOffsetNV = (dgtk.OpenGL.delegatesGL.glBindBufferOffsetNV) InternalTool.GetGLMethodAdress("glBindBufferOffsetNV", typeof(dgtk.OpenGL.delegatesGL.glBindBufferOffsetNV));
			}
			if (SuportedExt.Contains("glBindBufferRangeEXT"))
			{
				dgtk.OpenGL.internalGL.glBindBufferRangeEXT = (dgtk.OpenGL.delegatesGL.glBindBufferRangeEXT) InternalTool.GetGLMethodAdress("glBindBufferRangeEXT", typeof(dgtk.OpenGL.delegatesGL.glBindBufferRangeEXT));
			}
			if (SuportedExt.Contains("glBindBufferRangeNV"))
			{
				dgtk.OpenGL.internalGL.glBindBufferRangeNV = (dgtk.OpenGL.delegatesGL.glBindBufferRangeNV) InternalTool.GetGLMethodAdress("glBindBufferRangeNV", typeof(dgtk.OpenGL.delegatesGL.glBindBufferRangeNV));
			}
			if (SuportedExt.Contains("glBindFragDataLocationEXT"))
			{
				dgtk.OpenGL.internalGL.glBindFragDataLocationEXT = (dgtk.OpenGL.delegatesGL.glBindFragDataLocationEXT) InternalTool.GetGLMethodAdress("glBindFragDataLocationEXT", typeof(dgtk.OpenGL.delegatesGL.glBindFragDataLocationEXT));
			}
			if (SuportedExt.Contains("glBindFragDataLocationIndexedEXT"))
			{
				dgtk.OpenGL.internalGL.glBindFragDataLocationIndexedEXT = (dgtk.OpenGL.delegatesGL.glBindFragDataLocationIndexedEXT) InternalTool.GetGLMethodAdress("glBindFragDataLocationIndexedEXT", typeof(dgtk.OpenGL.delegatesGL.glBindFragDataLocationIndexedEXT));
			}
			if (SuportedExt.Contains("glBindFragmentShaderATI"))
			{
				dgtk.OpenGL.internalGL.glBindFragmentShaderATI = (dgtk.OpenGL.delegatesGL.glBindFragmentShaderATI) InternalTool.GetGLMethodAdress("glBindFragmentShaderATI", typeof(dgtk.OpenGL.delegatesGL.glBindFragmentShaderATI));
			}
			if (SuportedExt.Contains("glBindFramebufferEXT"))
			{
				dgtk.OpenGL.internalGL.glBindFramebufferEXT = (dgtk.OpenGL.delegatesGL.glBindFramebufferEXT) InternalTool.GetGLMethodAdress("glBindFramebufferEXT", typeof(dgtk.OpenGL.delegatesGL.glBindFramebufferEXT));
			}
			if (SuportedExt.Contains("glBindFramebufferOES"))
			{
				dgtk.OpenGL.internalGL.glBindFramebufferOES = (dgtk.OpenGL.delegatesGL.glBindFramebufferOES) InternalTool.GetGLMethodAdress("glBindFramebufferOES", typeof(dgtk.OpenGL.delegatesGL.glBindFramebufferOES));
			}
			if (SuportedExt.Contains("glBindImageTextureEXT"))
			{
				dgtk.OpenGL.internalGL.glBindImageTextureEXT = (dgtk.OpenGL.delegatesGL.glBindImageTextureEXT) InternalTool.GetGLMethodAdress("glBindImageTextureEXT", typeof(dgtk.OpenGL.delegatesGL.glBindImageTextureEXT));
			}
			if (SuportedExt.Contains("glBindLightParameterEXT"))
			{
				dgtk.OpenGL.internalGL.glBindLightParameterEXT = (dgtk.OpenGL.delegatesGL.glBindLightParameterEXT) InternalTool.GetGLMethodAdress("glBindLightParameterEXT", typeof(dgtk.OpenGL.delegatesGL.glBindLightParameterEXT));
			}
			if (SuportedExt.Contains("glBindMaterialParameterEXT"))
			{
				dgtk.OpenGL.internalGL.glBindMaterialParameterEXT = (dgtk.OpenGL.delegatesGL.glBindMaterialParameterEXT) InternalTool.GetGLMethodAdress("glBindMaterialParameterEXT", typeof(dgtk.OpenGL.delegatesGL.glBindMaterialParameterEXT));
			}
			if (SuportedExt.Contains("glBindMultiTextureEXT"))
			{
				dgtk.OpenGL.internalGL.glBindMultiTextureEXT = (dgtk.OpenGL.delegatesGL.glBindMultiTextureEXT) InternalTool.GetGLMethodAdress("glBindMultiTextureEXT", typeof(dgtk.OpenGL.delegatesGL.glBindMultiTextureEXT));
			}
			if (SuportedExt.Contains("glBindParameterEXT"))
			{
				dgtk.OpenGL.internalGL.glBindParameterEXT = (dgtk.OpenGL.delegatesGL.glBindParameterEXT) InternalTool.GetGLMethodAdress("glBindParameterEXT", typeof(dgtk.OpenGL.delegatesGL.glBindParameterEXT));
			}
			if (SuportedExt.Contains("glBindProgramARB"))
			{
				dgtk.OpenGL.internalGL.glBindProgramARB = (dgtk.OpenGL.delegatesGL.glBindProgramARB) InternalTool.GetGLMethodAdress("glBindProgramARB", typeof(dgtk.OpenGL.delegatesGL.glBindProgramARB));
			}
			if (SuportedExt.Contains("glBindProgramNV"))
			{
				dgtk.OpenGL.internalGL.glBindProgramNV = (dgtk.OpenGL.delegatesGL.glBindProgramNV) InternalTool.GetGLMethodAdress("glBindProgramNV", typeof(dgtk.OpenGL.delegatesGL.glBindProgramNV));
			}
			if (SuportedExt.Contains("glBindProgramPipelineEXT"))
			{
				dgtk.OpenGL.internalGL.glBindProgramPipelineEXT = (dgtk.OpenGL.delegatesGL.glBindProgramPipelineEXT) InternalTool.GetGLMethodAdress("glBindProgramPipelineEXT", typeof(dgtk.OpenGL.delegatesGL.glBindProgramPipelineEXT));
			}
			if (SuportedExt.Contains("glBindRenderbufferEXT"))
			{
				dgtk.OpenGL.internalGL.glBindRenderbufferEXT = (dgtk.OpenGL.delegatesGL.glBindRenderbufferEXT) InternalTool.GetGLMethodAdress("glBindRenderbufferEXT", typeof(dgtk.OpenGL.delegatesGL.glBindRenderbufferEXT));
			}
			if (SuportedExt.Contains("glBindRenderbufferOES"))
			{
				dgtk.OpenGL.internalGL.glBindRenderbufferOES = (dgtk.OpenGL.delegatesGL.glBindRenderbufferOES) InternalTool.GetGLMethodAdress("glBindRenderbufferOES", typeof(dgtk.OpenGL.delegatesGL.glBindRenderbufferOES));
			}
			if (SuportedExt.Contains("glBindShadingRateImageNV"))
			{
				dgtk.OpenGL.internalGL.glBindShadingRateImageNV = (dgtk.OpenGL.delegatesGL.glBindShadingRateImageNV) InternalTool.GetGLMethodAdress("glBindShadingRateImageNV", typeof(dgtk.OpenGL.delegatesGL.glBindShadingRateImageNV));
			}
			if (SuportedExt.Contains("glBindTexGenParameterEXT"))
			{
				dgtk.OpenGL.internalGL.glBindTexGenParameterEXT = (dgtk.OpenGL.delegatesGL.glBindTexGenParameterEXT) InternalTool.GetGLMethodAdress("glBindTexGenParameterEXT", typeof(dgtk.OpenGL.delegatesGL.glBindTexGenParameterEXT));
			}
			if (SuportedExt.Contains("glBindTextureEXT"))
			{
				dgtk.OpenGL.internalGL.glBindTextureEXT = (dgtk.OpenGL.delegatesGL.glBindTextureEXT) InternalTool.GetGLMethodAdress("glBindTextureEXT", typeof(dgtk.OpenGL.delegatesGL.glBindTextureEXT));
			}
			if (SuportedExt.Contains("glBindTextureUnitParameterEXT"))
			{
				dgtk.OpenGL.internalGL.glBindTextureUnitParameterEXT = (dgtk.OpenGL.delegatesGL.glBindTextureUnitParameterEXT) InternalTool.GetGLMethodAdress("glBindTextureUnitParameterEXT", typeof(dgtk.OpenGL.delegatesGL.glBindTextureUnitParameterEXT));
			}
			if (SuportedExt.Contains("glBindTransformFeedbackNV"))
			{
				dgtk.OpenGL.internalGL.glBindTransformFeedbackNV = (dgtk.OpenGL.delegatesGL.glBindTransformFeedbackNV) InternalTool.GetGLMethodAdress("glBindTransformFeedbackNV", typeof(dgtk.OpenGL.delegatesGL.glBindTransformFeedbackNV));
			}
			if (SuportedExt.Contains("glBindVertexArrayAPPLE"))
			{
				dgtk.OpenGL.internalGL.glBindVertexArrayAPPLE = (dgtk.OpenGL.delegatesGL.glBindVertexArrayAPPLE) InternalTool.GetGLMethodAdress("glBindVertexArrayAPPLE", typeof(dgtk.OpenGL.delegatesGL.glBindVertexArrayAPPLE));
			}
			if (SuportedExt.Contains("glBindVertexArrayOES"))
			{
				dgtk.OpenGL.internalGL.glBindVertexArrayOES = (dgtk.OpenGL.delegatesGL.glBindVertexArrayOES) InternalTool.GetGLMethodAdress("glBindVertexArrayOES", typeof(dgtk.OpenGL.delegatesGL.glBindVertexArrayOES));
			}
			if (SuportedExt.Contains("glBindVertexShaderEXT"))
			{
				dgtk.OpenGL.internalGL.glBindVertexShaderEXT = (dgtk.OpenGL.delegatesGL.glBindVertexShaderEXT) InternalTool.GetGLMethodAdress("glBindVertexShaderEXT", typeof(dgtk.OpenGL.delegatesGL.glBindVertexShaderEXT));
			}
			if (SuportedExt.Contains("glBindVideoCaptureStreamBufferNV"))
			{
				dgtk.OpenGL.internalGL.glBindVideoCaptureStreamBufferNV = (dgtk.OpenGL.delegatesGL.glBindVideoCaptureStreamBufferNV) InternalTool.GetGLMethodAdress("glBindVideoCaptureStreamBufferNV", typeof(dgtk.OpenGL.delegatesGL.glBindVideoCaptureStreamBufferNV));
			}
			if (SuportedExt.Contains("glBindVideoCaptureStreamTextureNV"))
			{
				dgtk.OpenGL.internalGL.glBindVideoCaptureStreamTextureNV = (dgtk.OpenGL.delegatesGL.glBindVideoCaptureStreamTextureNV) InternalTool.GetGLMethodAdress("glBindVideoCaptureStreamTextureNV", typeof(dgtk.OpenGL.delegatesGL.glBindVideoCaptureStreamTextureNV));
			}
			if (SuportedExt.Contains("glBinormal3bEXT"))
			{
				dgtk.OpenGL.internalGL.glBinormal3bEXT = (dgtk.OpenGL.delegatesGL.glBinormal3bEXT) InternalTool.GetGLMethodAdress("glBinormal3bEXT", typeof(dgtk.OpenGL.delegatesGL.glBinormal3bEXT));
			}
			if (SuportedExt.Contains("glBinormal3bvEXT"))
			{
				dgtk.OpenGL.internalGL.glBinormal3bvEXT = (dgtk.OpenGL.delegatesGL.glBinormal3bvEXT) InternalTool.GetGLMethodAdress("glBinormal3bvEXT", typeof(dgtk.OpenGL.delegatesGL.glBinormal3bvEXT));
			}
			if (SuportedExt.Contains("glBinormal3dEXT"))
			{
				dgtk.OpenGL.internalGL.glBinormal3dEXT = (dgtk.OpenGL.delegatesGL.glBinormal3dEXT) InternalTool.GetGLMethodAdress("glBinormal3dEXT", typeof(dgtk.OpenGL.delegatesGL.glBinormal3dEXT));
			}
			if (SuportedExt.Contains("glBinormal3dvEXT"))
			{
				dgtk.OpenGL.internalGL.glBinormal3dvEXT = (dgtk.OpenGL.delegatesGL.glBinormal3dvEXT) InternalTool.GetGLMethodAdress("glBinormal3dvEXT", typeof(dgtk.OpenGL.delegatesGL.glBinormal3dvEXT));
			}
			if (SuportedExt.Contains("glBinormal3fEXT"))
			{
				dgtk.OpenGL.internalGL.glBinormal3fEXT = (dgtk.OpenGL.delegatesGL.glBinormal3fEXT) InternalTool.GetGLMethodAdress("glBinormal3fEXT", typeof(dgtk.OpenGL.delegatesGL.glBinormal3fEXT));
			}
			if (SuportedExt.Contains("glBinormal3fvEXT"))
			{
				dgtk.OpenGL.internalGL.glBinormal3fvEXT = (dgtk.OpenGL.delegatesGL.glBinormal3fvEXT) InternalTool.GetGLMethodAdress("glBinormal3fvEXT", typeof(dgtk.OpenGL.delegatesGL.glBinormal3fvEXT));
			}
			if (SuportedExt.Contains("glBinormal3iEXT"))
			{
				dgtk.OpenGL.internalGL.glBinormal3iEXT = (dgtk.OpenGL.delegatesGL.glBinormal3iEXT) InternalTool.GetGLMethodAdress("glBinormal3iEXT", typeof(dgtk.OpenGL.delegatesGL.glBinormal3iEXT));
			}
			if (SuportedExt.Contains("glBinormal3ivEXT"))
			{
				dgtk.OpenGL.internalGL.glBinormal3ivEXT = (dgtk.OpenGL.delegatesGL.glBinormal3ivEXT) InternalTool.GetGLMethodAdress("glBinormal3ivEXT", typeof(dgtk.OpenGL.delegatesGL.glBinormal3ivEXT));
			}
			if (SuportedExt.Contains("glBinormal3sEXT"))
			{
				dgtk.OpenGL.internalGL.glBinormal3sEXT = (dgtk.OpenGL.delegatesGL.glBinormal3sEXT) InternalTool.GetGLMethodAdress("glBinormal3sEXT", typeof(dgtk.OpenGL.delegatesGL.glBinormal3sEXT));
			}
			if (SuportedExt.Contains("glBinormal3svEXT"))
			{
				dgtk.OpenGL.internalGL.glBinormal3svEXT = (dgtk.OpenGL.delegatesGL.glBinormal3svEXT) InternalTool.GetGLMethodAdress("glBinormal3svEXT", typeof(dgtk.OpenGL.delegatesGL.glBinormal3svEXT));
			}
			if (SuportedExt.Contains("glBinormalPointerEXT"))
			{
				dgtk.OpenGL.internalGL.glBinormalPointerEXT = (dgtk.OpenGL.delegatesGL.glBinormalPointerEXT) InternalTool.GetGLMethodAdress("glBinormalPointerEXT", typeof(dgtk.OpenGL.delegatesGL.glBinormalPointerEXT));
			}
			if (SuportedExt.Contains("glBitmapxOES"))
			{
				dgtk.OpenGL.internalGL.glBitmapxOES = (dgtk.OpenGL.delegatesGL.glBitmapxOES) InternalTool.GetGLMethodAdress("glBitmapxOES", typeof(dgtk.OpenGL.delegatesGL.glBitmapxOES));
			}
			if (SuportedExt.Contains("glBlendBarrier"))
			{
				dgtk.OpenGL.internalGL.glBlendBarrier = (dgtk.OpenGL.delegatesGL.glBlendBarrier) InternalTool.GetGLMethodAdress("glBlendBarrier", typeof(dgtk.OpenGL.delegatesGL.glBlendBarrier));
			}
			if (SuportedExt.Contains("glBlendBarrierKHR"))
			{
				dgtk.OpenGL.internalGL.glBlendBarrierKHR = (dgtk.OpenGL.delegatesGL.glBlendBarrierKHR) InternalTool.GetGLMethodAdress("glBlendBarrierKHR", typeof(dgtk.OpenGL.delegatesGL.glBlendBarrierKHR));
			}
			if (SuportedExt.Contains("glBlendBarrierNV"))
			{
				dgtk.OpenGL.internalGL.glBlendBarrierNV = (dgtk.OpenGL.delegatesGL.glBlendBarrierNV) InternalTool.GetGLMethodAdress("glBlendBarrierNV", typeof(dgtk.OpenGL.delegatesGL.glBlendBarrierNV));
			}
			if (SuportedExt.Contains("glBlendColorEXT"))
			{
				dgtk.OpenGL.internalGL.glBlendColorEXT = (dgtk.OpenGL.delegatesGL.glBlendColorEXT) InternalTool.GetGLMethodAdress("glBlendColorEXT", typeof(dgtk.OpenGL.delegatesGL.glBlendColorEXT));
			}
			if (SuportedExt.Contains("glBlendColorxOES"))
			{
				dgtk.OpenGL.internalGL.glBlendColorxOES = (dgtk.OpenGL.delegatesGL.glBlendColorxOES) InternalTool.GetGLMethodAdress("glBlendColorxOES", typeof(dgtk.OpenGL.delegatesGL.glBlendColorxOES));
			}
			if (SuportedExt.Contains("glBlendEquationEXT"))
			{
				dgtk.OpenGL.internalGL.glBlendEquationEXT = (dgtk.OpenGL.delegatesGL.glBlendEquationEXT) InternalTool.GetGLMethodAdress("glBlendEquationEXT", typeof(dgtk.OpenGL.delegatesGL.glBlendEquationEXT));
			}
			if (SuportedExt.Contains("glBlendEquationiARB"))
			{
				dgtk.OpenGL.internalGL.glBlendEquationiARB = (dgtk.OpenGL.delegatesGL.glBlendEquationiARB) InternalTool.GetGLMethodAdress("glBlendEquationiARB", typeof(dgtk.OpenGL.delegatesGL.glBlendEquationiARB));
			}
			if (SuportedExt.Contains("glBlendEquationiEXT"))
			{
				dgtk.OpenGL.internalGL.glBlendEquationiEXT = (dgtk.OpenGL.delegatesGL.glBlendEquationiEXT) InternalTool.GetGLMethodAdress("glBlendEquationiEXT", typeof(dgtk.OpenGL.delegatesGL.glBlendEquationiEXT));
			}
			if (SuportedExt.Contains("glBlendEquationIndexedAMD"))
			{
				dgtk.OpenGL.internalGL.glBlendEquationIndexedAMD = (dgtk.OpenGL.delegatesGL.glBlendEquationIndexedAMD) InternalTool.GetGLMethodAdress("glBlendEquationIndexedAMD", typeof(dgtk.OpenGL.delegatesGL.glBlendEquationIndexedAMD));
			}
			if (SuportedExt.Contains("glBlendEquationiOES"))
			{
				dgtk.OpenGL.internalGL.glBlendEquationiOES = (dgtk.OpenGL.delegatesGL.glBlendEquationiOES) InternalTool.GetGLMethodAdress("glBlendEquationiOES", typeof(dgtk.OpenGL.delegatesGL.glBlendEquationiOES));
			}
			if (SuportedExt.Contains("glBlendEquationOES"))
			{
				dgtk.OpenGL.internalGL.glBlendEquationOES = (dgtk.OpenGL.delegatesGL.glBlendEquationOES) InternalTool.GetGLMethodAdress("glBlendEquationOES", typeof(dgtk.OpenGL.delegatesGL.glBlendEquationOES));
			}
			if (SuportedExt.Contains("glBlendEquationSeparateEXT"))
			{
				dgtk.OpenGL.internalGL.glBlendEquationSeparateEXT = (dgtk.OpenGL.delegatesGL.glBlendEquationSeparateEXT) InternalTool.GetGLMethodAdress("glBlendEquationSeparateEXT", typeof(dgtk.OpenGL.delegatesGL.glBlendEquationSeparateEXT));
			}
			if (SuportedExt.Contains("glBlendEquationSeparateiARB"))
			{
				dgtk.OpenGL.internalGL.glBlendEquationSeparateiARB = (dgtk.OpenGL.delegatesGL.glBlendEquationSeparateiARB) InternalTool.GetGLMethodAdress("glBlendEquationSeparateiARB", typeof(dgtk.OpenGL.delegatesGL.glBlendEquationSeparateiARB));
			}
			if (SuportedExt.Contains("glBlendEquationSeparateiEXT"))
			{
				dgtk.OpenGL.internalGL.glBlendEquationSeparateiEXT = (dgtk.OpenGL.delegatesGL.glBlendEquationSeparateiEXT) InternalTool.GetGLMethodAdress("glBlendEquationSeparateiEXT", typeof(dgtk.OpenGL.delegatesGL.glBlendEquationSeparateiEXT));
			}
			if (SuportedExt.Contains("glBlendEquationSeparateIndexedAMD"))
			{
				dgtk.OpenGL.internalGL.glBlendEquationSeparateIndexedAMD = (dgtk.OpenGL.delegatesGL.glBlendEquationSeparateIndexedAMD) InternalTool.GetGLMethodAdress("glBlendEquationSeparateIndexedAMD", typeof(dgtk.OpenGL.delegatesGL.glBlendEquationSeparateIndexedAMD));
			}
			if (SuportedExt.Contains("glBlendEquationSeparateiOES"))
			{
				dgtk.OpenGL.internalGL.glBlendEquationSeparateiOES = (dgtk.OpenGL.delegatesGL.glBlendEquationSeparateiOES) InternalTool.GetGLMethodAdress("glBlendEquationSeparateiOES", typeof(dgtk.OpenGL.delegatesGL.glBlendEquationSeparateiOES));
			}
			if (SuportedExt.Contains("glBlendEquationSeparateOES"))
			{
				dgtk.OpenGL.internalGL.glBlendEquationSeparateOES = (dgtk.OpenGL.delegatesGL.glBlendEquationSeparateOES) InternalTool.GetGLMethodAdress("glBlendEquationSeparateOES", typeof(dgtk.OpenGL.delegatesGL.glBlendEquationSeparateOES));
			}
			if (SuportedExt.Contains("glBlendFunciARB"))
			{
				dgtk.OpenGL.internalGL.glBlendFunciARB = (dgtk.OpenGL.delegatesGL.glBlendFunciARB) InternalTool.GetGLMethodAdress("glBlendFunciARB", typeof(dgtk.OpenGL.delegatesGL.glBlendFunciARB));
			}
			if (SuportedExt.Contains("glBlendFunciEXT"))
			{
				dgtk.OpenGL.internalGL.glBlendFunciEXT = (dgtk.OpenGL.delegatesGL.glBlendFunciEXT) InternalTool.GetGLMethodAdress("glBlendFunciEXT", typeof(dgtk.OpenGL.delegatesGL.glBlendFunciEXT));
			}
			if (SuportedExt.Contains("glBlendFuncIndexedAMD"))
			{
				dgtk.OpenGL.internalGL.glBlendFuncIndexedAMD = (dgtk.OpenGL.delegatesGL.glBlendFuncIndexedAMD) InternalTool.GetGLMethodAdress("glBlendFuncIndexedAMD", typeof(dgtk.OpenGL.delegatesGL.glBlendFuncIndexedAMD));
			}
			if (SuportedExt.Contains("glBlendFunciOES"))
			{
				dgtk.OpenGL.internalGL.glBlendFunciOES = (dgtk.OpenGL.delegatesGL.glBlendFunciOES) InternalTool.GetGLMethodAdress("glBlendFunciOES", typeof(dgtk.OpenGL.delegatesGL.glBlendFunciOES));
			}
			if (SuportedExt.Contains("glBlendFuncSeparateEXT"))
			{
				dgtk.OpenGL.internalGL.glBlendFuncSeparateEXT = (dgtk.OpenGL.delegatesGL.glBlendFuncSeparateEXT) InternalTool.GetGLMethodAdress("glBlendFuncSeparateEXT", typeof(dgtk.OpenGL.delegatesGL.glBlendFuncSeparateEXT));
			}
			if (SuportedExt.Contains("glBlendFuncSeparateiARB"))
			{
				dgtk.OpenGL.internalGL.glBlendFuncSeparateiARB = (dgtk.OpenGL.delegatesGL.glBlendFuncSeparateiARB) InternalTool.GetGLMethodAdress("glBlendFuncSeparateiARB", typeof(dgtk.OpenGL.delegatesGL.glBlendFuncSeparateiARB));
			}
			if (SuportedExt.Contains("glBlendFuncSeparateiEXT"))
			{
				dgtk.OpenGL.internalGL.glBlendFuncSeparateiEXT = (dgtk.OpenGL.delegatesGL.glBlendFuncSeparateiEXT) InternalTool.GetGLMethodAdress("glBlendFuncSeparateiEXT", typeof(dgtk.OpenGL.delegatesGL.glBlendFuncSeparateiEXT));
			}
			if (SuportedExt.Contains("glBlendFuncSeparateIndexedAMD"))
			{
				dgtk.OpenGL.internalGL.glBlendFuncSeparateIndexedAMD = (dgtk.OpenGL.delegatesGL.glBlendFuncSeparateIndexedAMD) InternalTool.GetGLMethodAdress("glBlendFuncSeparateIndexedAMD", typeof(dgtk.OpenGL.delegatesGL.glBlendFuncSeparateIndexedAMD));
			}
			if (SuportedExt.Contains("glBlendFuncSeparateINGR"))
			{
				dgtk.OpenGL.internalGL.glBlendFuncSeparateINGR = (dgtk.OpenGL.delegatesGL.glBlendFuncSeparateINGR) InternalTool.GetGLMethodAdress("glBlendFuncSeparateINGR", typeof(dgtk.OpenGL.delegatesGL.glBlendFuncSeparateINGR));
			}
			if (SuportedExt.Contains("glBlendFuncSeparateiOES"))
			{
				dgtk.OpenGL.internalGL.glBlendFuncSeparateiOES = (dgtk.OpenGL.delegatesGL.glBlendFuncSeparateiOES) InternalTool.GetGLMethodAdress("glBlendFuncSeparateiOES", typeof(dgtk.OpenGL.delegatesGL.glBlendFuncSeparateiOES));
			}
			if (SuportedExt.Contains("glBlendFuncSeparateOES"))
			{
				dgtk.OpenGL.internalGL.glBlendFuncSeparateOES = (dgtk.OpenGL.delegatesGL.glBlendFuncSeparateOES) InternalTool.GetGLMethodAdress("glBlendFuncSeparateOES", typeof(dgtk.OpenGL.delegatesGL.glBlendFuncSeparateOES));
			}
			if (SuportedExt.Contains("glBlendParameteriNV"))
			{
				dgtk.OpenGL.internalGL.glBlendParameteriNV = (dgtk.OpenGL.delegatesGL.glBlendParameteriNV) InternalTool.GetGLMethodAdress("glBlendParameteriNV", typeof(dgtk.OpenGL.delegatesGL.glBlendParameteriNV));
			}
			if (SuportedExt.Contains("glBlitFramebufferANGLE"))
			{
				dgtk.OpenGL.internalGL.glBlitFramebufferANGLE = (dgtk.OpenGL.delegatesGL.glBlitFramebufferANGLE) InternalTool.GetGLMethodAdress("glBlitFramebufferANGLE", typeof(dgtk.OpenGL.delegatesGL.glBlitFramebufferANGLE));
			}
			if (SuportedExt.Contains("glBlitFramebufferEXT"))
			{
				dgtk.OpenGL.internalGL.glBlitFramebufferEXT = (dgtk.OpenGL.delegatesGL.glBlitFramebufferEXT) InternalTool.GetGLMethodAdress("glBlitFramebufferEXT", typeof(dgtk.OpenGL.delegatesGL.glBlitFramebufferEXT));
			}
			if (SuportedExt.Contains("glBlitFramebufferNV"))
			{
				dgtk.OpenGL.internalGL.glBlitFramebufferNV = (dgtk.OpenGL.delegatesGL.glBlitFramebufferNV) InternalTool.GetGLMethodAdress("glBlitFramebufferNV", typeof(dgtk.OpenGL.delegatesGL.glBlitFramebufferNV));
			}
			if (SuportedExt.Contains("glBufferAddressRangeNV"))
			{
				dgtk.OpenGL.internalGL.glBufferAddressRangeNV = (dgtk.OpenGL.delegatesGL.glBufferAddressRangeNV) InternalTool.GetGLMethodAdress("glBufferAddressRangeNV", typeof(dgtk.OpenGL.delegatesGL.glBufferAddressRangeNV));
			}
			if (SuportedExt.Contains("glBufferAttachMemoryNV"))
			{
				dgtk.OpenGL.internalGL.glBufferAttachMemoryNV = (dgtk.OpenGL.delegatesGL.glBufferAttachMemoryNV) InternalTool.GetGLMethodAdress("glBufferAttachMemoryNV", typeof(dgtk.OpenGL.delegatesGL.glBufferAttachMemoryNV));
			}
			if (SuportedExt.Contains("glBufferDataARB"))
			{
				dgtk.OpenGL.internalGL.glBufferDataARB = (dgtk.OpenGL.delegatesGL.glBufferDataARB) InternalTool.GetGLMethodAdress("glBufferDataARB", typeof(dgtk.OpenGL.delegatesGL.glBufferDataARB));
			}
			if (SuportedExt.Contains("glBufferPageCommitmentARB"))
			{
				dgtk.OpenGL.internalGL.glBufferPageCommitmentARB = (dgtk.OpenGL.delegatesGL.glBufferPageCommitmentARB) InternalTool.GetGLMethodAdress("glBufferPageCommitmentARB", typeof(dgtk.OpenGL.delegatesGL.glBufferPageCommitmentARB));
			}
			if (SuportedExt.Contains("glBufferPageCommitmentMemNV"))
			{
				dgtk.OpenGL.internalGL.glBufferPageCommitmentMemNV = (dgtk.OpenGL.delegatesGL.glBufferPageCommitmentMemNV) InternalTool.GetGLMethodAdress("glBufferPageCommitmentMemNV", typeof(dgtk.OpenGL.delegatesGL.glBufferPageCommitmentMemNV));
			}
			if (SuportedExt.Contains("glBufferParameteriAPPLE"))
			{
				dgtk.OpenGL.internalGL.glBufferParameteriAPPLE = (dgtk.OpenGL.delegatesGL.glBufferParameteriAPPLE) InternalTool.GetGLMethodAdress("glBufferParameteriAPPLE", typeof(dgtk.OpenGL.delegatesGL.glBufferParameteriAPPLE));
			}
			if (SuportedExt.Contains("glBufferStorageEXT"))
			{
				dgtk.OpenGL.internalGL.glBufferStorageEXT = (dgtk.OpenGL.delegatesGL.glBufferStorageEXT) InternalTool.GetGLMethodAdress("glBufferStorageEXT", typeof(dgtk.OpenGL.delegatesGL.glBufferStorageEXT));
			}
			if (SuportedExt.Contains("glBufferStorageExternalEXT"))
			{
				dgtk.OpenGL.internalGL.glBufferStorageExternalEXT = (dgtk.OpenGL.delegatesGL.glBufferStorageExternalEXT) InternalTool.GetGLMethodAdress("glBufferStorageExternalEXT", typeof(dgtk.OpenGL.delegatesGL.glBufferStorageExternalEXT));
			}
			if (SuportedExt.Contains("glBufferStorageMemEXT"))
			{
				dgtk.OpenGL.internalGL.glBufferStorageMemEXT = (dgtk.OpenGL.delegatesGL.glBufferStorageMemEXT) InternalTool.GetGLMethodAdress("glBufferStorageMemEXT", typeof(dgtk.OpenGL.delegatesGL.glBufferStorageMemEXT));
			}
			if (SuportedExt.Contains("glBufferSubDataARB"))
			{
				dgtk.OpenGL.internalGL.glBufferSubDataARB = (dgtk.OpenGL.delegatesGL.glBufferSubDataARB) InternalTool.GetGLMethodAdress("glBufferSubDataARB", typeof(dgtk.OpenGL.delegatesGL.glBufferSubDataARB));
			}
			#endregion

			#region C:

			if (SuportedExt.Contains("glCallCommandListNV"))
			{
				dgtk.OpenGL.internalGL.glCallCommandListNV = (dgtk.OpenGL.delegatesGL.glCallCommandListNV) InternalTool.GetGLMethodAdress("glCallCommandListNV", typeof(dgtk.OpenGL.delegatesGL.glCallCommandListNV));
			}
			if (SuportedExt.Contains("glCheckFramebufferStatusEXT"))
			{
				dgtk.OpenGL.internalGL.glCheckFramebufferStatusEXT = (dgtk.OpenGL.delegatesGL.glCheckFramebufferStatusEXT) InternalTool.GetGLMethodAdress("glCheckFramebufferStatusEXT", typeof(dgtk.OpenGL.delegatesGL.glCheckFramebufferStatusEXT));
			}
			if (SuportedExt.Contains("glCheckFramebufferStatusOES"))
			{
				dgtk.OpenGL.internalGL.glCheckFramebufferStatusOES = (dgtk.OpenGL.delegatesGL.glCheckFramebufferStatusOES) InternalTool.GetGLMethodAdress("glCheckFramebufferStatusOES", typeof(dgtk.OpenGL.delegatesGL.glCheckFramebufferStatusOES));
			}
			if (SuportedExt.Contains("glCheckNamedFramebufferStatusEXT"))
			{
				dgtk.OpenGL.internalGL.glCheckNamedFramebufferStatusEXT = (dgtk.OpenGL.delegatesGL.glCheckNamedFramebufferStatusEXT) InternalTool.GetGLMethodAdress("glCheckNamedFramebufferStatusEXT", typeof(dgtk.OpenGL.delegatesGL.glCheckNamedFramebufferStatusEXT));
			}
			if (SuportedExt.Contains("glClampColorARB"))
			{
				dgtk.OpenGL.internalGL.glClampColorARB = (dgtk.OpenGL.delegatesGL.glClampColorARB) InternalTool.GetGLMethodAdress("glClampColorARB", typeof(dgtk.OpenGL.delegatesGL.glClampColorARB));
			}
			if (SuportedExt.Contains("glClearAccumxOES"))
			{
				dgtk.OpenGL.internalGL.glClearAccumxOES = (dgtk.OpenGL.delegatesGL.glClearAccumxOES) InternalTool.GetGLMethodAdress("glClearAccumxOES", typeof(dgtk.OpenGL.delegatesGL.glClearAccumxOES));
			}
			if (SuportedExt.Contains("glClearColorIiEXT"))
			{
				dgtk.OpenGL.internalGL.glClearColorIiEXT = (dgtk.OpenGL.delegatesGL.glClearColorIiEXT) InternalTool.GetGLMethodAdress("glClearColorIiEXT", typeof(dgtk.OpenGL.delegatesGL.glClearColorIiEXT));
			}
			if (SuportedExt.Contains("glClearColorIuiEXT"))
			{
				dgtk.OpenGL.internalGL.glClearColorIuiEXT = (dgtk.OpenGL.delegatesGL.glClearColorIuiEXT) InternalTool.GetGLMethodAdress("glClearColorIuiEXT", typeof(dgtk.OpenGL.delegatesGL.glClearColorIuiEXT));
			}
			if (SuportedExt.Contains("glClearColorx"))
			{
				dgtk.OpenGL.internalGL.glClearColorx = (dgtk.OpenGL.delegatesGL.glClearColorx) InternalTool.GetGLMethodAdress("glClearColorx", typeof(dgtk.OpenGL.delegatesGL.glClearColorx));
			}
			if (SuportedExt.Contains("glClearColorxOES"))
			{
				dgtk.OpenGL.internalGL.glClearColorxOES = (dgtk.OpenGL.delegatesGL.glClearColorxOES) InternalTool.GetGLMethodAdress("glClearColorxOES", typeof(dgtk.OpenGL.delegatesGL.glClearColorxOES));
			}
			if (SuportedExt.Contains("glClearDepthdNV"))
			{
				dgtk.OpenGL.internalGL.glClearDepthdNV = (dgtk.OpenGL.delegatesGL.glClearDepthdNV) InternalTool.GetGLMethodAdress("glClearDepthdNV", typeof(dgtk.OpenGL.delegatesGL.glClearDepthdNV));
			}
			if (SuportedExt.Contains("glClearDepthfOES"))
			{
				dgtk.OpenGL.internalGL.glClearDepthfOES = (dgtk.OpenGL.delegatesGL.glClearDepthfOES) InternalTool.GetGLMethodAdress("glClearDepthfOES", typeof(dgtk.OpenGL.delegatesGL.glClearDepthfOES));
			}
			if (SuportedExt.Contains("glClearDepthx"))
			{
				dgtk.OpenGL.internalGL.glClearDepthx = (dgtk.OpenGL.delegatesGL.glClearDepthx) InternalTool.GetGLMethodAdress("glClearDepthx", typeof(dgtk.OpenGL.delegatesGL.glClearDepthx));
			}
			if (SuportedExt.Contains("glClearDepthxOES"))
			{
				dgtk.OpenGL.internalGL.glClearDepthxOES = (dgtk.OpenGL.delegatesGL.glClearDepthxOES) InternalTool.GetGLMethodAdress("glClearDepthxOES", typeof(dgtk.OpenGL.delegatesGL.glClearDepthxOES));
			}
			if (SuportedExt.Contains("glClearNamedBufferDataEXT"))
			{
				dgtk.OpenGL.internalGL.glClearNamedBufferDataEXT = (dgtk.OpenGL.delegatesGL.glClearNamedBufferDataEXT) InternalTool.GetGLMethodAdress("glClearNamedBufferDataEXT", typeof(dgtk.OpenGL.delegatesGL.glClearNamedBufferDataEXT));
			}
			if (SuportedExt.Contains("glClearNamedBufferSubDataEXT"))
			{
				dgtk.OpenGL.internalGL.glClearNamedBufferSubDataEXT = (dgtk.OpenGL.delegatesGL.glClearNamedBufferSubDataEXT) InternalTool.GetGLMethodAdress("glClearNamedBufferSubDataEXT", typeof(dgtk.OpenGL.delegatesGL.glClearNamedBufferSubDataEXT));
			}
			if (SuportedExt.Contains("glClearPixelLocalStorageuiEXT"))
			{
				dgtk.OpenGL.internalGL.glClearPixelLocalStorageuiEXT = (dgtk.OpenGL.delegatesGL.glClearPixelLocalStorageuiEXT) InternalTool.GetGLMethodAdress("glClearPixelLocalStorageuiEXT", typeof(dgtk.OpenGL.delegatesGL.glClearPixelLocalStorageuiEXT));
			}
			if (SuportedExt.Contains("glClearTexImageEXT"))
			{
				dgtk.OpenGL.internalGL.glClearTexImageEXT = (dgtk.OpenGL.delegatesGL.glClearTexImageEXT) InternalTool.GetGLMethodAdress("glClearTexImageEXT", typeof(dgtk.OpenGL.delegatesGL.glClearTexImageEXT));
			}
			if (SuportedExt.Contains("glClearTexSubImageEXT"))
			{
				dgtk.OpenGL.internalGL.glClearTexSubImageEXT = (dgtk.OpenGL.delegatesGL.glClearTexSubImageEXT) InternalTool.GetGLMethodAdress("glClearTexSubImageEXT", typeof(dgtk.OpenGL.delegatesGL.glClearTexSubImageEXT));
			}
			if (SuportedExt.Contains("glClientActiveTextureARB"))
			{
				dgtk.OpenGL.internalGL.glClientActiveTextureARB = (dgtk.OpenGL.delegatesGL.glClientActiveTextureARB) InternalTool.GetGLMethodAdress("glClientActiveTextureARB", typeof(dgtk.OpenGL.delegatesGL.glClientActiveTextureARB));
			}
			if (SuportedExt.Contains("glClientActiveVertexStreamATI"))
			{
				dgtk.OpenGL.internalGL.glClientActiveVertexStreamATI = (dgtk.OpenGL.delegatesGL.glClientActiveVertexStreamATI) InternalTool.GetGLMethodAdress("glClientActiveVertexStreamATI", typeof(dgtk.OpenGL.delegatesGL.glClientActiveVertexStreamATI));
			}
			if (SuportedExt.Contains("glClientAttribDefaultEXT"))
			{
				dgtk.OpenGL.internalGL.glClientAttribDefaultEXT = (dgtk.OpenGL.delegatesGL.glClientAttribDefaultEXT) InternalTool.GetGLMethodAdress("glClientAttribDefaultEXT", typeof(dgtk.OpenGL.delegatesGL.glClientAttribDefaultEXT));
			}
			if (SuportedExt.Contains("glClientWaitSemaphoreui64NVX"))
			{
				dgtk.OpenGL.internalGL.glClientWaitSemaphoreui64NVX = (dgtk.OpenGL.delegatesGL.glClientWaitSemaphoreui64NVX) InternalTool.GetGLMethodAdress("glClientWaitSemaphoreui64NVX", typeof(dgtk.OpenGL.delegatesGL.glClientWaitSemaphoreui64NVX));
			}
			if (SuportedExt.Contains("glClientWaitSyncAPPLE"))
			{
				dgtk.OpenGL.internalGL.glClientWaitSyncAPPLE = (dgtk.OpenGL.delegatesGL.glClientWaitSyncAPPLE) InternalTool.GetGLMethodAdress("glClientWaitSyncAPPLE", typeof(dgtk.OpenGL.delegatesGL.glClientWaitSyncAPPLE));
			}
			if (SuportedExt.Contains("glClipControlEXT"))
			{
				dgtk.OpenGL.internalGL.glClipControlEXT = (dgtk.OpenGL.delegatesGL.glClipControlEXT) InternalTool.GetGLMethodAdress("glClipControlEXT", typeof(dgtk.OpenGL.delegatesGL.glClipControlEXT));
			}
			if (SuportedExt.Contains("glClipPlanef"))
			{
				dgtk.OpenGL.internalGL.glClipPlanef = (dgtk.OpenGL.delegatesGL.glClipPlanef) InternalTool.GetGLMethodAdress("glClipPlanef", typeof(dgtk.OpenGL.delegatesGL.glClipPlanef));
			}
			if (SuportedExt.Contains("glClipPlanefIMG"))
			{
				dgtk.OpenGL.internalGL.glClipPlanefIMG = (dgtk.OpenGL.delegatesGL.glClipPlanefIMG) InternalTool.GetGLMethodAdress("glClipPlanefIMG", typeof(dgtk.OpenGL.delegatesGL.glClipPlanefIMG));
			}
			if (SuportedExt.Contains("glClipPlanefOES"))
			{
				dgtk.OpenGL.internalGL.glClipPlanefOES = (dgtk.OpenGL.delegatesGL.glClipPlanefOES) InternalTool.GetGLMethodAdress("glClipPlanefOES", typeof(dgtk.OpenGL.delegatesGL.glClipPlanefOES));
			}
			if (SuportedExt.Contains("glClipPlanex"))
			{
				dgtk.OpenGL.internalGL.glClipPlanex = (dgtk.OpenGL.delegatesGL.glClipPlanex) InternalTool.GetGLMethodAdress("glClipPlanex", typeof(dgtk.OpenGL.delegatesGL.glClipPlanex));
			}
			if (SuportedExt.Contains("glClipPlanexIMG"))
			{
				dgtk.OpenGL.internalGL.glClipPlanexIMG = (dgtk.OpenGL.delegatesGL.glClipPlanexIMG) InternalTool.GetGLMethodAdress("glClipPlanexIMG", typeof(dgtk.OpenGL.delegatesGL.glClipPlanexIMG));
			}
			if (SuportedExt.Contains("glClipPlanexOES"))
			{
				dgtk.OpenGL.internalGL.glClipPlanexOES = (dgtk.OpenGL.delegatesGL.glClipPlanexOES) InternalTool.GetGLMethodAdress("glClipPlanexOES", typeof(dgtk.OpenGL.delegatesGL.glClipPlanexOES));
			}
			if (SuportedExt.Contains("glColor3fVertex3fSUN"))
			{
				dgtk.OpenGL.internalGL.glColor3fVertex3fSUN = (dgtk.OpenGL.delegatesGL.glColor3fVertex3fSUN) InternalTool.GetGLMethodAdress("glColor3fVertex3fSUN", typeof(dgtk.OpenGL.delegatesGL.glColor3fVertex3fSUN));
			}
			if (SuportedExt.Contains("glColor3fVertex3fvSUN"))
			{
				dgtk.OpenGL.internalGL.glColor3fVertex3fvSUN = (dgtk.OpenGL.delegatesGL.glColor3fVertex3fvSUN) InternalTool.GetGLMethodAdress("glColor3fVertex3fvSUN", typeof(dgtk.OpenGL.delegatesGL.glColor3fVertex3fvSUN));
			}
			if (SuportedExt.Contains("glColor3hNV"))
			{
				dgtk.OpenGL.internalGL.glColor3hNV = (dgtk.OpenGL.delegatesGL.glColor3hNV) InternalTool.GetGLMethodAdress("glColor3hNV", typeof(dgtk.OpenGL.delegatesGL.glColor3hNV));
			}
			if (SuportedExt.Contains("glColor3hvNV"))
			{
				dgtk.OpenGL.internalGL.glColor3hvNV = (dgtk.OpenGL.delegatesGL.glColor3hvNV) InternalTool.GetGLMethodAdress("glColor3hvNV", typeof(dgtk.OpenGL.delegatesGL.glColor3hvNV));
			}
			if (SuportedExt.Contains("glColor3xOES"))
			{
				dgtk.OpenGL.internalGL.glColor3xOES = (dgtk.OpenGL.delegatesGL.glColor3xOES) InternalTool.GetGLMethodAdress("glColor3xOES", typeof(dgtk.OpenGL.delegatesGL.glColor3xOES));
			}
			if (SuportedExt.Contains("glColor3xvOES"))
			{
				dgtk.OpenGL.internalGL.glColor3xvOES = (dgtk.OpenGL.delegatesGL.glColor3xvOES) InternalTool.GetGLMethodAdress("glColor3xvOES", typeof(dgtk.OpenGL.delegatesGL.glColor3xvOES));
			}
			if (SuportedExt.Contains("glColor4fNormal3fVertex3fSUN"))
			{
				dgtk.OpenGL.internalGL.glColor4fNormal3fVertex3fSUN = (dgtk.OpenGL.delegatesGL.glColor4fNormal3fVertex3fSUN) InternalTool.GetGLMethodAdress("glColor4fNormal3fVertex3fSUN", typeof(dgtk.OpenGL.delegatesGL.glColor4fNormal3fVertex3fSUN));
			}
			if (SuportedExt.Contains("glColor4fNormal3fVertex3fvSUN"))
			{
				dgtk.OpenGL.internalGL.glColor4fNormal3fVertex3fvSUN = (dgtk.OpenGL.delegatesGL.glColor4fNormal3fVertex3fvSUN) InternalTool.GetGLMethodAdress("glColor4fNormal3fVertex3fvSUN", typeof(dgtk.OpenGL.delegatesGL.glColor4fNormal3fVertex3fvSUN));
			}
			if (SuportedExt.Contains("glColor4hNV"))
			{
				dgtk.OpenGL.internalGL.glColor4hNV = (dgtk.OpenGL.delegatesGL.glColor4hNV) InternalTool.GetGLMethodAdress("glColor4hNV", typeof(dgtk.OpenGL.delegatesGL.glColor4hNV));
			}
			if (SuportedExt.Contains("glColor4hvNV"))
			{
				dgtk.OpenGL.internalGL.glColor4hvNV = (dgtk.OpenGL.delegatesGL.glColor4hvNV) InternalTool.GetGLMethodAdress("glColor4hvNV", typeof(dgtk.OpenGL.delegatesGL.glColor4hvNV));
			}
			if (SuportedExt.Contains("glColor4ubVertex2fSUN"))
			{
				dgtk.OpenGL.internalGL.glColor4ubVertex2fSUN = (dgtk.OpenGL.delegatesGL.glColor4ubVertex2fSUN) InternalTool.GetGLMethodAdress("glColor4ubVertex2fSUN", typeof(dgtk.OpenGL.delegatesGL.glColor4ubVertex2fSUN));
			}
			if (SuportedExt.Contains("glColor4ubVertex2fvSUN"))
			{
				dgtk.OpenGL.internalGL.glColor4ubVertex2fvSUN = (dgtk.OpenGL.delegatesGL.glColor4ubVertex2fvSUN) InternalTool.GetGLMethodAdress("glColor4ubVertex2fvSUN", typeof(dgtk.OpenGL.delegatesGL.glColor4ubVertex2fvSUN));
			}
			if (SuportedExt.Contains("glColor4ubVertex3fSUN"))
			{
				dgtk.OpenGL.internalGL.glColor4ubVertex3fSUN = (dgtk.OpenGL.delegatesGL.glColor4ubVertex3fSUN) InternalTool.GetGLMethodAdress("glColor4ubVertex3fSUN", typeof(dgtk.OpenGL.delegatesGL.glColor4ubVertex3fSUN));
			}
			if (SuportedExt.Contains("glColor4ubVertex3fvSUN"))
			{
				dgtk.OpenGL.internalGL.glColor4ubVertex3fvSUN = (dgtk.OpenGL.delegatesGL.glColor4ubVertex3fvSUN) InternalTool.GetGLMethodAdress("glColor4ubVertex3fvSUN", typeof(dgtk.OpenGL.delegatesGL.glColor4ubVertex3fvSUN));
			}
			if (SuportedExt.Contains("glColor4x"))
			{
				dgtk.OpenGL.internalGL.glColor4x = (dgtk.OpenGL.delegatesGL.glColor4x) InternalTool.GetGLMethodAdress("glColor4x", typeof(dgtk.OpenGL.delegatesGL.glColor4x));
			}
			if (SuportedExt.Contains("glColor4xOES"))
			{
				dgtk.OpenGL.internalGL.glColor4xOES = (dgtk.OpenGL.delegatesGL.glColor4xOES) InternalTool.GetGLMethodAdress("glColor4xOES", typeof(dgtk.OpenGL.delegatesGL.glColor4xOES));
			}
			if (SuportedExt.Contains("glColor4xvOES"))
			{
				dgtk.OpenGL.internalGL.glColor4xvOES = (dgtk.OpenGL.delegatesGL.glColor4xvOES) InternalTool.GetGLMethodAdress("glColor4xvOES", typeof(dgtk.OpenGL.delegatesGL.glColor4xvOES));
			}
			if (SuportedExt.Contains("glColorFormatNV"))
			{
				dgtk.OpenGL.internalGL.glColorFormatNV = (dgtk.OpenGL.delegatesGL.glColorFormatNV) InternalTool.GetGLMethodAdress("glColorFormatNV", typeof(dgtk.OpenGL.delegatesGL.glColorFormatNV));
			}
			if (SuportedExt.Contains("glColorFragmentOp1ATI"))
			{
				dgtk.OpenGL.internalGL.glColorFragmentOp1ATI = (dgtk.OpenGL.delegatesGL.glColorFragmentOp1ATI) InternalTool.GetGLMethodAdress("glColorFragmentOp1ATI", typeof(dgtk.OpenGL.delegatesGL.glColorFragmentOp1ATI));
			}
			if (SuportedExt.Contains("glColorFragmentOp2ATI"))
			{
				dgtk.OpenGL.internalGL.glColorFragmentOp2ATI = (dgtk.OpenGL.delegatesGL.glColorFragmentOp2ATI) InternalTool.GetGLMethodAdress("glColorFragmentOp2ATI", typeof(dgtk.OpenGL.delegatesGL.glColorFragmentOp2ATI));
			}
			if (SuportedExt.Contains("glColorFragmentOp3ATI"))
			{
				dgtk.OpenGL.internalGL.glColorFragmentOp3ATI = (dgtk.OpenGL.delegatesGL.glColorFragmentOp3ATI) InternalTool.GetGLMethodAdress("glColorFragmentOp3ATI", typeof(dgtk.OpenGL.delegatesGL.glColorFragmentOp3ATI));
			}
			if (SuportedExt.Contains("glColorMaskiEXT"))
			{
				dgtk.OpenGL.internalGL.glColorMaskiEXT = (dgtk.OpenGL.delegatesGL.glColorMaskiEXT) InternalTool.GetGLMethodAdress("glColorMaskiEXT", typeof(dgtk.OpenGL.delegatesGL.glColorMaskiEXT));
			}
			if (SuportedExt.Contains("glColorMaskIndexedEXT"))
			{
				dgtk.OpenGL.internalGL.glColorMaskIndexedEXT = (dgtk.OpenGL.delegatesGL.glColorMaskIndexedEXT) InternalTool.GetGLMethodAdress("glColorMaskIndexedEXT", typeof(dgtk.OpenGL.delegatesGL.glColorMaskIndexedEXT));
			}
			if (SuportedExt.Contains("glColorMaskiOES"))
			{
				dgtk.OpenGL.internalGL.glColorMaskiOES = (dgtk.OpenGL.delegatesGL.glColorMaskiOES) InternalTool.GetGLMethodAdress("glColorMaskiOES", typeof(dgtk.OpenGL.delegatesGL.glColorMaskiOES));
			}
			if (SuportedExt.Contains("glColorPointerEXT"))
			{
				dgtk.OpenGL.internalGL.glColorPointerEXT = (dgtk.OpenGL.delegatesGL.glColorPointerEXT) InternalTool.GetGLMethodAdress("glColorPointerEXT", typeof(dgtk.OpenGL.delegatesGL.glColorPointerEXT));
			}
			if (SuportedExt.Contains("glColorPointerListIBM"))
			{
				dgtk.OpenGL.internalGL.glColorPointerListIBM = (dgtk.OpenGL.delegatesGL.glColorPointerListIBM) InternalTool.GetGLMethodAdress("glColorPointerListIBM", typeof(dgtk.OpenGL.delegatesGL.glColorPointerListIBM));
			}
			if (SuportedExt.Contains("glColorPointervINTEL"))
			{
				dgtk.OpenGL.internalGL.glColorPointervINTEL = (dgtk.OpenGL.delegatesGL.glColorPointervINTEL) InternalTool.GetGLMethodAdress("glColorPointervINTEL", typeof(dgtk.OpenGL.delegatesGL.glColorPointervINTEL));
			}
			if (SuportedExt.Contains("glColorSubTable"))
			{
				dgtk.OpenGL.internalGL.glColorSubTable = (dgtk.OpenGL.delegatesGL.glColorSubTable) InternalTool.GetGLMethodAdress("glColorSubTable", typeof(dgtk.OpenGL.delegatesGL.glColorSubTable));
			}
			if (SuportedExt.Contains("glColorSubTableEXT"))
			{
				dgtk.OpenGL.internalGL.glColorSubTableEXT = (dgtk.OpenGL.delegatesGL.glColorSubTableEXT) InternalTool.GetGLMethodAdress("glColorSubTableEXT", typeof(dgtk.OpenGL.delegatesGL.glColorSubTableEXT));
			}
			if (SuportedExt.Contains("glColorTable"))
			{
				dgtk.OpenGL.internalGL.glColorTable = (dgtk.OpenGL.delegatesGL.glColorTable) InternalTool.GetGLMethodAdress("glColorTable", typeof(dgtk.OpenGL.delegatesGL.glColorTable));
			}
			if (SuportedExt.Contains("glColorTableEXT"))
			{
				dgtk.OpenGL.internalGL.glColorTableEXT = (dgtk.OpenGL.delegatesGL.glColorTableEXT) InternalTool.GetGLMethodAdress("glColorTableEXT", typeof(dgtk.OpenGL.delegatesGL.glColorTableEXT));
			}
			if (SuportedExt.Contains("glColorTableParameterfv"))
			{
				dgtk.OpenGL.internalGL.glColorTableParameterfv = (dgtk.OpenGL.delegatesGL.glColorTableParameterfv) InternalTool.GetGLMethodAdress("glColorTableParameterfv", typeof(dgtk.OpenGL.delegatesGL.glColorTableParameterfv));
			}
			if (SuportedExt.Contains("glColorTableParameterfvSGI"))
			{
				dgtk.OpenGL.internalGL.glColorTableParameterfvSGI = (dgtk.OpenGL.delegatesGL.glColorTableParameterfvSGI) InternalTool.GetGLMethodAdress("glColorTableParameterfvSGI", typeof(dgtk.OpenGL.delegatesGL.glColorTableParameterfvSGI));
			}
			if (SuportedExt.Contains("glColorTableParameteriv"))
			{
				dgtk.OpenGL.internalGL.glColorTableParameteriv = (dgtk.OpenGL.delegatesGL.glColorTableParameteriv) InternalTool.GetGLMethodAdress("glColorTableParameteriv", typeof(dgtk.OpenGL.delegatesGL.glColorTableParameteriv));
			}
			if (SuportedExt.Contains("glColorTableParameterivSGI"))
			{
				dgtk.OpenGL.internalGL.glColorTableParameterivSGI = (dgtk.OpenGL.delegatesGL.glColorTableParameterivSGI) InternalTool.GetGLMethodAdress("glColorTableParameterivSGI", typeof(dgtk.OpenGL.delegatesGL.glColorTableParameterivSGI));
			}
			if (SuportedExt.Contains("glColorTableSGI"))
			{
				dgtk.OpenGL.internalGL.glColorTableSGI = (dgtk.OpenGL.delegatesGL.glColorTableSGI) InternalTool.GetGLMethodAdress("glColorTableSGI", typeof(dgtk.OpenGL.delegatesGL.glColorTableSGI));
			}
			if (SuportedExt.Contains("glCombinerInputNV"))
			{
				dgtk.OpenGL.internalGL.glCombinerInputNV = (dgtk.OpenGL.delegatesGL.glCombinerInputNV) InternalTool.GetGLMethodAdress("glCombinerInputNV", typeof(dgtk.OpenGL.delegatesGL.glCombinerInputNV));
			}
			if (SuportedExt.Contains("glCombinerOutputNV"))
			{
				dgtk.OpenGL.internalGL.glCombinerOutputNV = (dgtk.OpenGL.delegatesGL.glCombinerOutputNV) InternalTool.GetGLMethodAdress("glCombinerOutputNV", typeof(dgtk.OpenGL.delegatesGL.glCombinerOutputNV));
			}
			if (SuportedExt.Contains("glCombinerParameterfNV"))
			{
				dgtk.OpenGL.internalGL.glCombinerParameterfNV = (dgtk.OpenGL.delegatesGL.glCombinerParameterfNV) InternalTool.GetGLMethodAdress("glCombinerParameterfNV", typeof(dgtk.OpenGL.delegatesGL.glCombinerParameterfNV));
			}
			if (SuportedExt.Contains("glCombinerParameterfvNV"))
			{
				dgtk.OpenGL.internalGL.glCombinerParameterfvNV = (dgtk.OpenGL.delegatesGL.glCombinerParameterfvNV) InternalTool.GetGLMethodAdress("glCombinerParameterfvNV", typeof(dgtk.OpenGL.delegatesGL.glCombinerParameterfvNV));
			}
			if (SuportedExt.Contains("glCombinerParameteriNV"))
			{
				dgtk.OpenGL.internalGL.glCombinerParameteriNV = (dgtk.OpenGL.delegatesGL.glCombinerParameteriNV) InternalTool.GetGLMethodAdress("glCombinerParameteriNV", typeof(dgtk.OpenGL.delegatesGL.glCombinerParameteriNV));
			}
			if (SuportedExt.Contains("glCombinerParameterivNV"))
			{
				dgtk.OpenGL.internalGL.glCombinerParameterivNV = (dgtk.OpenGL.delegatesGL.glCombinerParameterivNV) InternalTool.GetGLMethodAdress("glCombinerParameterivNV", typeof(dgtk.OpenGL.delegatesGL.glCombinerParameterivNV));
			}
			if (SuportedExt.Contains("glCombinerStageParameterfvNV"))
			{
				dgtk.OpenGL.internalGL.glCombinerStageParameterfvNV = (dgtk.OpenGL.delegatesGL.glCombinerStageParameterfvNV) InternalTool.GetGLMethodAdress("glCombinerStageParameterfvNV", typeof(dgtk.OpenGL.delegatesGL.glCombinerStageParameterfvNV));
			}
			if (SuportedExt.Contains("glCommandListSegmentsNV"))
			{
				dgtk.OpenGL.internalGL.glCommandListSegmentsNV = (dgtk.OpenGL.delegatesGL.glCommandListSegmentsNV) InternalTool.GetGLMethodAdress("glCommandListSegmentsNV", typeof(dgtk.OpenGL.delegatesGL.glCommandListSegmentsNV));
			}
			if (SuportedExt.Contains("glCompileCommandListNV"))
			{
				dgtk.OpenGL.internalGL.glCompileCommandListNV = (dgtk.OpenGL.delegatesGL.glCompileCommandListNV) InternalTool.GetGLMethodAdress("glCompileCommandListNV", typeof(dgtk.OpenGL.delegatesGL.glCompileCommandListNV));
			}
			if (SuportedExt.Contains("glCompileShaderARB"))
			{
				dgtk.OpenGL.internalGL.glCompileShaderARB = (dgtk.OpenGL.delegatesGL.glCompileShaderARB) InternalTool.GetGLMethodAdress("glCompileShaderARB", typeof(dgtk.OpenGL.delegatesGL.glCompileShaderARB));
			}
			if (SuportedExt.Contains("glCompileShaderIncludeARB"))
			{
				dgtk.OpenGL.internalGL.glCompileShaderIncludeARB = (dgtk.OpenGL.delegatesGL.glCompileShaderIncludeARB) InternalTool.GetGLMethodAdress("glCompileShaderIncludeARB", typeof(dgtk.OpenGL.delegatesGL.glCompileShaderIncludeARB));
			}
			if (SuportedExt.Contains("glCompressedMultiTexImage1DEXT"))
			{
				dgtk.OpenGL.internalGL.glCompressedMultiTexImage1DEXT = (dgtk.OpenGL.delegatesGL.glCompressedMultiTexImage1DEXT) InternalTool.GetGLMethodAdress("glCompressedMultiTexImage1DEXT", typeof(dgtk.OpenGL.delegatesGL.glCompressedMultiTexImage1DEXT));
			}
			if (SuportedExt.Contains("glCompressedMultiTexImage2DEXT"))
			{
				dgtk.OpenGL.internalGL.glCompressedMultiTexImage2DEXT = (dgtk.OpenGL.delegatesGL.glCompressedMultiTexImage2DEXT) InternalTool.GetGLMethodAdress("glCompressedMultiTexImage2DEXT", typeof(dgtk.OpenGL.delegatesGL.glCompressedMultiTexImage2DEXT));
			}
			if (SuportedExt.Contains("glCompressedMultiTexImage3DEXT"))
			{
				dgtk.OpenGL.internalGL.glCompressedMultiTexImage3DEXT = (dgtk.OpenGL.delegatesGL.glCompressedMultiTexImage3DEXT) InternalTool.GetGLMethodAdress("glCompressedMultiTexImage3DEXT", typeof(dgtk.OpenGL.delegatesGL.glCompressedMultiTexImage3DEXT));
			}
			if (SuportedExt.Contains("glCompressedMultiTexSubImage1DEXT"))
			{
				dgtk.OpenGL.internalGL.glCompressedMultiTexSubImage1DEXT = (dgtk.OpenGL.delegatesGL.glCompressedMultiTexSubImage1DEXT) InternalTool.GetGLMethodAdress("glCompressedMultiTexSubImage1DEXT", typeof(dgtk.OpenGL.delegatesGL.glCompressedMultiTexSubImage1DEXT));
			}
			if (SuportedExt.Contains("glCompressedMultiTexSubImage2DEXT"))
			{
				dgtk.OpenGL.internalGL.glCompressedMultiTexSubImage2DEXT = (dgtk.OpenGL.delegatesGL.glCompressedMultiTexSubImage2DEXT) InternalTool.GetGLMethodAdress("glCompressedMultiTexSubImage2DEXT", typeof(dgtk.OpenGL.delegatesGL.glCompressedMultiTexSubImage2DEXT));
			}
			if (SuportedExt.Contains("glCompressedMultiTexSubImage3DEXT"))
			{
				dgtk.OpenGL.internalGL.glCompressedMultiTexSubImage3DEXT = (dgtk.OpenGL.delegatesGL.glCompressedMultiTexSubImage3DEXT) InternalTool.GetGLMethodAdress("glCompressedMultiTexSubImage3DEXT", typeof(dgtk.OpenGL.delegatesGL.glCompressedMultiTexSubImage3DEXT));
			}
			if (SuportedExt.Contains("glCompressedTexImage1DARB"))
			{
				dgtk.OpenGL.internalGL.glCompressedTexImage1DARB = (dgtk.OpenGL.delegatesGL.glCompressedTexImage1DARB) InternalTool.GetGLMethodAdress("glCompressedTexImage1DARB", typeof(dgtk.OpenGL.delegatesGL.glCompressedTexImage1DARB));
			}
			if (SuportedExt.Contains("glCompressedTexImage2DARB"))
			{
				dgtk.OpenGL.internalGL.glCompressedTexImage2DARB = (dgtk.OpenGL.delegatesGL.glCompressedTexImage2DARB) InternalTool.GetGLMethodAdress("glCompressedTexImage2DARB", typeof(dgtk.OpenGL.delegatesGL.glCompressedTexImage2DARB));
			}
			if (SuportedExt.Contains("glCompressedTexImage3DARB"))
			{
				dgtk.OpenGL.internalGL.glCompressedTexImage3DARB = (dgtk.OpenGL.delegatesGL.glCompressedTexImage3DARB) InternalTool.GetGLMethodAdress("glCompressedTexImage3DARB", typeof(dgtk.OpenGL.delegatesGL.glCompressedTexImage3DARB));
			}
			if (SuportedExt.Contains("glCompressedTexImage3DOES"))
			{
				dgtk.OpenGL.internalGL.glCompressedTexImage3DOES = (dgtk.OpenGL.delegatesGL.glCompressedTexImage3DOES) InternalTool.GetGLMethodAdress("glCompressedTexImage3DOES", typeof(dgtk.OpenGL.delegatesGL.glCompressedTexImage3DOES));
			}
			if (SuportedExt.Contains("glCompressedTexSubImage1DARB"))
			{
				dgtk.OpenGL.internalGL.glCompressedTexSubImage1DARB = (dgtk.OpenGL.delegatesGL.glCompressedTexSubImage1DARB) InternalTool.GetGLMethodAdress("glCompressedTexSubImage1DARB", typeof(dgtk.OpenGL.delegatesGL.glCompressedTexSubImage1DARB));
			}
			if (SuportedExt.Contains("glCompressedTexSubImage2DARB"))
			{
				dgtk.OpenGL.internalGL.glCompressedTexSubImage2DARB = (dgtk.OpenGL.delegatesGL.glCompressedTexSubImage2DARB) InternalTool.GetGLMethodAdress("glCompressedTexSubImage2DARB", typeof(dgtk.OpenGL.delegatesGL.glCompressedTexSubImage2DARB));
			}
			if (SuportedExt.Contains("glCompressedTexSubImage3DARB"))
			{
				dgtk.OpenGL.internalGL.glCompressedTexSubImage3DARB = (dgtk.OpenGL.delegatesGL.glCompressedTexSubImage3DARB) InternalTool.GetGLMethodAdress("glCompressedTexSubImage3DARB", typeof(dgtk.OpenGL.delegatesGL.glCompressedTexSubImage3DARB));
			}
			if (SuportedExt.Contains("glCompressedTexSubImage3DOES"))
			{
				dgtk.OpenGL.internalGL.glCompressedTexSubImage3DOES = (dgtk.OpenGL.delegatesGL.glCompressedTexSubImage3DOES) InternalTool.GetGLMethodAdress("glCompressedTexSubImage3DOES", typeof(dgtk.OpenGL.delegatesGL.glCompressedTexSubImage3DOES));
			}
			if (SuportedExt.Contains("glCompressedTextureImage1DEXT"))
			{
				dgtk.OpenGL.internalGL.glCompressedTextureImage1DEXT = (dgtk.OpenGL.delegatesGL.glCompressedTextureImage1DEXT) InternalTool.GetGLMethodAdress("glCompressedTextureImage1DEXT", typeof(dgtk.OpenGL.delegatesGL.glCompressedTextureImage1DEXT));
			}
			if (SuportedExt.Contains("glCompressedTextureImage2DEXT"))
			{
				dgtk.OpenGL.internalGL.glCompressedTextureImage2DEXT = (dgtk.OpenGL.delegatesGL.glCompressedTextureImage2DEXT) InternalTool.GetGLMethodAdress("glCompressedTextureImage2DEXT", typeof(dgtk.OpenGL.delegatesGL.glCompressedTextureImage2DEXT));
			}
			if (SuportedExt.Contains("glCompressedTextureImage3DEXT"))
			{
				dgtk.OpenGL.internalGL.glCompressedTextureImage3DEXT = (dgtk.OpenGL.delegatesGL.glCompressedTextureImage3DEXT) InternalTool.GetGLMethodAdress("glCompressedTextureImage3DEXT", typeof(dgtk.OpenGL.delegatesGL.glCompressedTextureImage3DEXT));
			}
			if (SuportedExt.Contains("glCompressedTextureSubImage1DEXT"))
			{
				dgtk.OpenGL.internalGL.glCompressedTextureSubImage1DEXT = (dgtk.OpenGL.delegatesGL.glCompressedTextureSubImage1DEXT) InternalTool.GetGLMethodAdress("glCompressedTextureSubImage1DEXT", typeof(dgtk.OpenGL.delegatesGL.glCompressedTextureSubImage1DEXT));
			}
			if (SuportedExt.Contains("glCompressedTextureSubImage2DEXT"))
			{
				dgtk.OpenGL.internalGL.glCompressedTextureSubImage2DEXT = (dgtk.OpenGL.delegatesGL.glCompressedTextureSubImage2DEXT) InternalTool.GetGLMethodAdress("glCompressedTextureSubImage2DEXT", typeof(dgtk.OpenGL.delegatesGL.glCompressedTextureSubImage2DEXT));
			}
			if (SuportedExt.Contains("glCompressedTextureSubImage3DEXT"))
			{
				dgtk.OpenGL.internalGL.glCompressedTextureSubImage3DEXT = (dgtk.OpenGL.delegatesGL.glCompressedTextureSubImage3DEXT) InternalTool.GetGLMethodAdress("glCompressedTextureSubImage3DEXT", typeof(dgtk.OpenGL.delegatesGL.glCompressedTextureSubImage3DEXT));
			}
			if (SuportedExt.Contains("glConservativeRasterParameterfNV"))
			{
				dgtk.OpenGL.internalGL.glConservativeRasterParameterfNV = (dgtk.OpenGL.delegatesGL.glConservativeRasterParameterfNV) InternalTool.GetGLMethodAdress("glConservativeRasterParameterfNV", typeof(dgtk.OpenGL.delegatesGL.glConservativeRasterParameterfNV));
			}
			if (SuportedExt.Contains("glConservativeRasterParameteriNV"))
			{
				dgtk.OpenGL.internalGL.glConservativeRasterParameteriNV = (dgtk.OpenGL.delegatesGL.glConservativeRasterParameteriNV) InternalTool.GetGLMethodAdress("glConservativeRasterParameteriNV", typeof(dgtk.OpenGL.delegatesGL.glConservativeRasterParameteriNV));
			}
			if (SuportedExt.Contains("glConvolutionFilter1D"))
			{
				dgtk.OpenGL.internalGL.glConvolutionFilter1D = (dgtk.OpenGL.delegatesGL.glConvolutionFilter1D) InternalTool.GetGLMethodAdress("glConvolutionFilter1D", typeof(dgtk.OpenGL.delegatesGL.glConvolutionFilter1D));
			}
			if (SuportedExt.Contains("glConvolutionFilter1DEXT"))
			{
				dgtk.OpenGL.internalGL.glConvolutionFilter1DEXT = (dgtk.OpenGL.delegatesGL.glConvolutionFilter1DEXT) InternalTool.GetGLMethodAdress("glConvolutionFilter1DEXT", typeof(dgtk.OpenGL.delegatesGL.glConvolutionFilter1DEXT));
			}
			if (SuportedExt.Contains("glConvolutionFilter2D"))
			{
				dgtk.OpenGL.internalGL.glConvolutionFilter2D = (dgtk.OpenGL.delegatesGL.glConvolutionFilter2D) InternalTool.GetGLMethodAdress("glConvolutionFilter2D", typeof(dgtk.OpenGL.delegatesGL.glConvolutionFilter2D));
			}
			if (SuportedExt.Contains("glConvolutionFilter2DEXT"))
			{
				dgtk.OpenGL.internalGL.glConvolutionFilter2DEXT = (dgtk.OpenGL.delegatesGL.glConvolutionFilter2DEXT) InternalTool.GetGLMethodAdress("glConvolutionFilter2DEXT", typeof(dgtk.OpenGL.delegatesGL.glConvolutionFilter2DEXT));
			}
			if (SuportedExt.Contains("glConvolutionParameterf"))
			{
				dgtk.OpenGL.internalGL.glConvolutionParameterf = (dgtk.OpenGL.delegatesGL.glConvolutionParameterf) InternalTool.GetGLMethodAdress("glConvolutionParameterf", typeof(dgtk.OpenGL.delegatesGL.glConvolutionParameterf));
			}
			if (SuportedExt.Contains("glConvolutionParameterfEXT"))
			{
				dgtk.OpenGL.internalGL.glConvolutionParameterfEXT = (dgtk.OpenGL.delegatesGL.glConvolutionParameterfEXT) InternalTool.GetGLMethodAdress("glConvolutionParameterfEXT", typeof(dgtk.OpenGL.delegatesGL.glConvolutionParameterfEXT));
			}
			if (SuportedExt.Contains("glConvolutionParameterfv"))
			{
				dgtk.OpenGL.internalGL.glConvolutionParameterfv = (dgtk.OpenGL.delegatesGL.glConvolutionParameterfv) InternalTool.GetGLMethodAdress("glConvolutionParameterfv", typeof(dgtk.OpenGL.delegatesGL.glConvolutionParameterfv));
			}
			if (SuportedExt.Contains("glConvolutionParameterfvEXT"))
			{
				dgtk.OpenGL.internalGL.glConvolutionParameterfvEXT = (dgtk.OpenGL.delegatesGL.glConvolutionParameterfvEXT) InternalTool.GetGLMethodAdress("glConvolutionParameterfvEXT", typeof(dgtk.OpenGL.delegatesGL.glConvolutionParameterfvEXT));
			}
			if (SuportedExt.Contains("glConvolutionParameteri"))
			{
				dgtk.OpenGL.internalGL.glConvolutionParameteri = (dgtk.OpenGL.delegatesGL.glConvolutionParameteri) InternalTool.GetGLMethodAdress("glConvolutionParameteri", typeof(dgtk.OpenGL.delegatesGL.glConvolutionParameteri));
			}
			if (SuportedExt.Contains("glConvolutionParameteriEXT"))
			{
				dgtk.OpenGL.internalGL.glConvolutionParameteriEXT = (dgtk.OpenGL.delegatesGL.glConvolutionParameteriEXT) InternalTool.GetGLMethodAdress("glConvolutionParameteriEXT", typeof(dgtk.OpenGL.delegatesGL.glConvolutionParameteriEXT));
			}
			if (SuportedExt.Contains("glConvolutionParameteriv"))
			{
				dgtk.OpenGL.internalGL.glConvolutionParameteriv = (dgtk.OpenGL.delegatesGL.glConvolutionParameteriv) InternalTool.GetGLMethodAdress("glConvolutionParameteriv", typeof(dgtk.OpenGL.delegatesGL.glConvolutionParameteriv));
			}
			if (SuportedExt.Contains("glConvolutionParameterivEXT"))
			{
				dgtk.OpenGL.internalGL.glConvolutionParameterivEXT = (dgtk.OpenGL.delegatesGL.glConvolutionParameterivEXT) InternalTool.GetGLMethodAdress("glConvolutionParameterivEXT", typeof(dgtk.OpenGL.delegatesGL.glConvolutionParameterivEXT));
			}
			if (SuportedExt.Contains("glConvolutionParameterxOES"))
			{
				dgtk.OpenGL.internalGL.glConvolutionParameterxOES = (dgtk.OpenGL.delegatesGL.glConvolutionParameterxOES) InternalTool.GetGLMethodAdress("glConvolutionParameterxOES", typeof(dgtk.OpenGL.delegatesGL.glConvolutionParameterxOES));
			}
			if (SuportedExt.Contains("glConvolutionParameterxvOES"))
			{
				dgtk.OpenGL.internalGL.glConvolutionParameterxvOES = (dgtk.OpenGL.delegatesGL.glConvolutionParameterxvOES) InternalTool.GetGLMethodAdress("glConvolutionParameterxvOES", typeof(dgtk.OpenGL.delegatesGL.glConvolutionParameterxvOES));
			}
			if (SuportedExt.Contains("glCopyBufferSubDataNV"))
			{
				dgtk.OpenGL.internalGL.glCopyBufferSubDataNV = (dgtk.OpenGL.delegatesGL.glCopyBufferSubDataNV) InternalTool.GetGLMethodAdress("glCopyBufferSubDataNV", typeof(dgtk.OpenGL.delegatesGL.glCopyBufferSubDataNV));
			}
			if (SuportedExt.Contains("glCopyColorSubTable"))
			{
				dgtk.OpenGL.internalGL.glCopyColorSubTable = (dgtk.OpenGL.delegatesGL.glCopyColorSubTable) InternalTool.GetGLMethodAdress("glCopyColorSubTable", typeof(dgtk.OpenGL.delegatesGL.glCopyColorSubTable));
			}
			if (SuportedExt.Contains("glCopyColorSubTableEXT"))
			{
				dgtk.OpenGL.internalGL.glCopyColorSubTableEXT = (dgtk.OpenGL.delegatesGL.glCopyColorSubTableEXT) InternalTool.GetGLMethodAdress("glCopyColorSubTableEXT", typeof(dgtk.OpenGL.delegatesGL.glCopyColorSubTableEXT));
			}
			if (SuportedExt.Contains("glCopyColorTable"))
			{
				dgtk.OpenGL.internalGL.glCopyColorTable = (dgtk.OpenGL.delegatesGL.glCopyColorTable) InternalTool.GetGLMethodAdress("glCopyColorTable", typeof(dgtk.OpenGL.delegatesGL.glCopyColorTable));
			}
			if (SuportedExt.Contains("glCopyColorTableSGI"))
			{
				dgtk.OpenGL.internalGL.glCopyColorTableSGI = (dgtk.OpenGL.delegatesGL.glCopyColorTableSGI) InternalTool.GetGLMethodAdress("glCopyColorTableSGI", typeof(dgtk.OpenGL.delegatesGL.glCopyColorTableSGI));
			}
			if (SuportedExt.Contains("glCopyConvolutionFilter1D"))
			{
				dgtk.OpenGL.internalGL.glCopyConvolutionFilter1D = (dgtk.OpenGL.delegatesGL.glCopyConvolutionFilter1D) InternalTool.GetGLMethodAdress("glCopyConvolutionFilter1D", typeof(dgtk.OpenGL.delegatesGL.glCopyConvolutionFilter1D));
			}
			if (SuportedExt.Contains("glCopyConvolutionFilter1DEXT"))
			{
				dgtk.OpenGL.internalGL.glCopyConvolutionFilter1DEXT = (dgtk.OpenGL.delegatesGL.glCopyConvolutionFilter1DEXT) InternalTool.GetGLMethodAdress("glCopyConvolutionFilter1DEXT", typeof(dgtk.OpenGL.delegatesGL.glCopyConvolutionFilter1DEXT));
			}
			if (SuportedExt.Contains("glCopyConvolutionFilter2D"))
			{
				dgtk.OpenGL.internalGL.glCopyConvolutionFilter2D = (dgtk.OpenGL.delegatesGL.glCopyConvolutionFilter2D) InternalTool.GetGLMethodAdress("glCopyConvolutionFilter2D", typeof(dgtk.OpenGL.delegatesGL.glCopyConvolutionFilter2D));
			}
			if (SuportedExt.Contains("glCopyConvolutionFilter2DEXT"))
			{
				dgtk.OpenGL.internalGL.glCopyConvolutionFilter2DEXT = (dgtk.OpenGL.delegatesGL.glCopyConvolutionFilter2DEXT) InternalTool.GetGLMethodAdress("glCopyConvolutionFilter2DEXT", typeof(dgtk.OpenGL.delegatesGL.glCopyConvolutionFilter2DEXT));
			}
			if (SuportedExt.Contains("glCopyImageSubDataEXT"))
			{
				dgtk.OpenGL.internalGL.glCopyImageSubDataEXT = (dgtk.OpenGL.delegatesGL.glCopyImageSubDataEXT) InternalTool.GetGLMethodAdress("glCopyImageSubDataEXT", typeof(dgtk.OpenGL.delegatesGL.glCopyImageSubDataEXT));
			}
			if (SuportedExt.Contains("glCopyImageSubDataNV"))
			{
				dgtk.OpenGL.internalGL.glCopyImageSubDataNV = (dgtk.OpenGL.delegatesGL.glCopyImageSubDataNV) InternalTool.GetGLMethodAdress("glCopyImageSubDataNV", typeof(dgtk.OpenGL.delegatesGL.glCopyImageSubDataNV));
			}
			if (SuportedExt.Contains("glCopyImageSubDataOES"))
			{
				dgtk.OpenGL.internalGL.glCopyImageSubDataOES = (dgtk.OpenGL.delegatesGL.glCopyImageSubDataOES) InternalTool.GetGLMethodAdress("glCopyImageSubDataOES", typeof(dgtk.OpenGL.delegatesGL.glCopyImageSubDataOES));
			}
			if (SuportedExt.Contains("glCopyMultiTexImage1DEXT"))
			{
				dgtk.OpenGL.internalGL.glCopyMultiTexImage1DEXT = (dgtk.OpenGL.delegatesGL.glCopyMultiTexImage1DEXT) InternalTool.GetGLMethodAdress("glCopyMultiTexImage1DEXT", typeof(dgtk.OpenGL.delegatesGL.glCopyMultiTexImage1DEXT));
			}
			if (SuportedExt.Contains("glCopyMultiTexImage2DEXT"))
			{
				dgtk.OpenGL.internalGL.glCopyMultiTexImage2DEXT = (dgtk.OpenGL.delegatesGL.glCopyMultiTexImage2DEXT) InternalTool.GetGLMethodAdress("glCopyMultiTexImage2DEXT", typeof(dgtk.OpenGL.delegatesGL.glCopyMultiTexImage2DEXT));
			}
			if (SuportedExt.Contains("glCopyMultiTexSubImage1DEXT"))
			{
				dgtk.OpenGL.internalGL.glCopyMultiTexSubImage1DEXT = (dgtk.OpenGL.delegatesGL.glCopyMultiTexSubImage1DEXT) InternalTool.GetGLMethodAdress("glCopyMultiTexSubImage1DEXT", typeof(dgtk.OpenGL.delegatesGL.glCopyMultiTexSubImage1DEXT));
			}
			if (SuportedExt.Contains("glCopyMultiTexSubImage2DEXT"))
			{
				dgtk.OpenGL.internalGL.glCopyMultiTexSubImage2DEXT = (dgtk.OpenGL.delegatesGL.glCopyMultiTexSubImage2DEXT) InternalTool.GetGLMethodAdress("glCopyMultiTexSubImage2DEXT", typeof(dgtk.OpenGL.delegatesGL.glCopyMultiTexSubImage2DEXT));
			}
			if (SuportedExt.Contains("glCopyMultiTexSubImage3DEXT"))
			{
				dgtk.OpenGL.internalGL.glCopyMultiTexSubImage3DEXT = (dgtk.OpenGL.delegatesGL.glCopyMultiTexSubImage3DEXT) InternalTool.GetGLMethodAdress("glCopyMultiTexSubImage3DEXT", typeof(dgtk.OpenGL.delegatesGL.glCopyMultiTexSubImage3DEXT));
			}
			if (SuportedExt.Contains("glCopyPathNV"))
			{
				dgtk.OpenGL.internalGL.glCopyPathNV = (dgtk.OpenGL.delegatesGL.glCopyPathNV) InternalTool.GetGLMethodAdress("glCopyPathNV", typeof(dgtk.OpenGL.delegatesGL.glCopyPathNV));
			}
			if (SuportedExt.Contains("glCopyTexImage1DEXT"))
			{
				dgtk.OpenGL.internalGL.glCopyTexImage1DEXT = (dgtk.OpenGL.delegatesGL.glCopyTexImage1DEXT) InternalTool.GetGLMethodAdress("glCopyTexImage1DEXT", typeof(dgtk.OpenGL.delegatesGL.glCopyTexImage1DEXT));
			}
			if (SuportedExt.Contains("glCopyTexImage2DEXT"))
			{
				dgtk.OpenGL.internalGL.glCopyTexImage2DEXT = (dgtk.OpenGL.delegatesGL.glCopyTexImage2DEXT) InternalTool.GetGLMethodAdress("glCopyTexImage2DEXT", typeof(dgtk.OpenGL.delegatesGL.glCopyTexImage2DEXT));
			}
			if (SuportedExt.Contains("glCopyTexSubImage1DEXT"))
			{
				dgtk.OpenGL.internalGL.glCopyTexSubImage1DEXT = (dgtk.OpenGL.delegatesGL.glCopyTexSubImage1DEXT) InternalTool.GetGLMethodAdress("glCopyTexSubImage1DEXT", typeof(dgtk.OpenGL.delegatesGL.glCopyTexSubImage1DEXT));
			}
			if (SuportedExt.Contains("glCopyTexSubImage2DEXT"))
			{
				dgtk.OpenGL.internalGL.glCopyTexSubImage2DEXT = (dgtk.OpenGL.delegatesGL.glCopyTexSubImage2DEXT) InternalTool.GetGLMethodAdress("glCopyTexSubImage2DEXT", typeof(dgtk.OpenGL.delegatesGL.glCopyTexSubImage2DEXT));
			}
			if (SuportedExt.Contains("glCopyTexSubImage3DEXT"))
			{
				dgtk.OpenGL.internalGL.glCopyTexSubImage3DEXT = (dgtk.OpenGL.delegatesGL.glCopyTexSubImage3DEXT) InternalTool.GetGLMethodAdress("glCopyTexSubImage3DEXT", typeof(dgtk.OpenGL.delegatesGL.glCopyTexSubImage3DEXT));
			}
			if (SuportedExt.Contains("glCopyTexSubImage3DOES"))
			{
				dgtk.OpenGL.internalGL.glCopyTexSubImage3DOES = (dgtk.OpenGL.delegatesGL.glCopyTexSubImage3DOES) InternalTool.GetGLMethodAdress("glCopyTexSubImage3DOES", typeof(dgtk.OpenGL.delegatesGL.glCopyTexSubImage3DOES));
			}
			if (SuportedExt.Contains("glCopyTextureImage1DEXT"))
			{
				dgtk.OpenGL.internalGL.glCopyTextureImage1DEXT = (dgtk.OpenGL.delegatesGL.glCopyTextureImage1DEXT) InternalTool.GetGLMethodAdress("glCopyTextureImage1DEXT", typeof(dgtk.OpenGL.delegatesGL.glCopyTextureImage1DEXT));
			}
			if (SuportedExt.Contains("glCopyTextureImage2DEXT"))
			{
				dgtk.OpenGL.internalGL.glCopyTextureImage2DEXT = (dgtk.OpenGL.delegatesGL.glCopyTextureImage2DEXT) InternalTool.GetGLMethodAdress("glCopyTextureImage2DEXT", typeof(dgtk.OpenGL.delegatesGL.glCopyTextureImage2DEXT));
			}
			if (SuportedExt.Contains("glCopyTextureLevelsAPPLE"))
			{
				dgtk.OpenGL.internalGL.glCopyTextureLevelsAPPLE = (dgtk.OpenGL.delegatesGL.glCopyTextureLevelsAPPLE) InternalTool.GetGLMethodAdress("glCopyTextureLevelsAPPLE", typeof(dgtk.OpenGL.delegatesGL.glCopyTextureLevelsAPPLE));
			}
			if (SuportedExt.Contains("glCopyTextureSubImage1DEXT"))
			{
				dgtk.OpenGL.internalGL.glCopyTextureSubImage1DEXT = (dgtk.OpenGL.delegatesGL.glCopyTextureSubImage1DEXT) InternalTool.GetGLMethodAdress("glCopyTextureSubImage1DEXT", typeof(dgtk.OpenGL.delegatesGL.glCopyTextureSubImage1DEXT));
			}
			if (SuportedExt.Contains("glCopyTextureSubImage2DEXT"))
			{
				dgtk.OpenGL.internalGL.glCopyTextureSubImage2DEXT = (dgtk.OpenGL.delegatesGL.glCopyTextureSubImage2DEXT) InternalTool.GetGLMethodAdress("glCopyTextureSubImage2DEXT", typeof(dgtk.OpenGL.delegatesGL.glCopyTextureSubImage2DEXT));
			}
			if (SuportedExt.Contains("glCopyTextureSubImage3DEXT"))
			{
				dgtk.OpenGL.internalGL.glCopyTextureSubImage3DEXT = (dgtk.OpenGL.delegatesGL.glCopyTextureSubImage3DEXT) InternalTool.GetGLMethodAdress("glCopyTextureSubImage3DEXT", typeof(dgtk.OpenGL.delegatesGL.glCopyTextureSubImage3DEXT));
			}
			if (SuportedExt.Contains("glCoverageMaskNV"))
			{
				dgtk.OpenGL.internalGL.glCoverageMaskNV = (dgtk.OpenGL.delegatesGL.glCoverageMaskNV) InternalTool.GetGLMethodAdress("glCoverageMaskNV", typeof(dgtk.OpenGL.delegatesGL.glCoverageMaskNV));
			}
			if (SuportedExt.Contains("glCoverageModulationNV"))
			{
				dgtk.OpenGL.internalGL.glCoverageModulationNV = (dgtk.OpenGL.delegatesGL.glCoverageModulationNV) InternalTool.GetGLMethodAdress("glCoverageModulationNV", typeof(dgtk.OpenGL.delegatesGL.glCoverageModulationNV));
			}
			if (SuportedExt.Contains("glCoverageModulationTableNV"))
			{
				dgtk.OpenGL.internalGL.glCoverageModulationTableNV = (dgtk.OpenGL.delegatesGL.glCoverageModulationTableNV) InternalTool.GetGLMethodAdress("glCoverageModulationTableNV", typeof(dgtk.OpenGL.delegatesGL.glCoverageModulationTableNV));
			}
			if (SuportedExt.Contains("glCoverageOperationNV"))
			{
				dgtk.OpenGL.internalGL.glCoverageOperationNV = (dgtk.OpenGL.delegatesGL.glCoverageOperationNV) InternalTool.GetGLMethodAdress("glCoverageOperationNV", typeof(dgtk.OpenGL.delegatesGL.glCoverageOperationNV));
			}
			if (SuportedExt.Contains("glCoverFillPathInstancedNV"))
			{
				dgtk.OpenGL.internalGL.glCoverFillPathInstancedNV = (dgtk.OpenGL.delegatesGL.glCoverFillPathInstancedNV) InternalTool.GetGLMethodAdress("glCoverFillPathInstancedNV", typeof(dgtk.OpenGL.delegatesGL.glCoverFillPathInstancedNV));
			}
			if (SuportedExt.Contains("glCoverFillPathNV"))
			{
				dgtk.OpenGL.internalGL.glCoverFillPathNV = (dgtk.OpenGL.delegatesGL.glCoverFillPathNV) InternalTool.GetGLMethodAdress("glCoverFillPathNV", typeof(dgtk.OpenGL.delegatesGL.glCoverFillPathNV));
			}
			if (SuportedExt.Contains("glCoverStrokePathInstancedNV"))
			{
				dgtk.OpenGL.internalGL.glCoverStrokePathInstancedNV = (dgtk.OpenGL.delegatesGL.glCoverStrokePathInstancedNV) InternalTool.GetGLMethodAdress("glCoverStrokePathInstancedNV", typeof(dgtk.OpenGL.delegatesGL.glCoverStrokePathInstancedNV));
			}
			if (SuportedExt.Contains("glCoverStrokePathNV"))
			{
				dgtk.OpenGL.internalGL.glCoverStrokePathNV = (dgtk.OpenGL.delegatesGL.glCoverStrokePathNV) InternalTool.GetGLMethodAdress("glCoverStrokePathNV", typeof(dgtk.OpenGL.delegatesGL.glCoverStrokePathNV));
			}
			if (SuportedExt.Contains("glCreateCommandListsNV"))
			{
				dgtk.OpenGL.internalGL.glCreateCommandListsNV = (dgtk.OpenGL.delegatesGL.glCreateCommandListsNV) InternalTool.GetGLMethodAdress("glCreateCommandListsNV", typeof(dgtk.OpenGL.delegatesGL.glCreateCommandListsNV));
			}
			if (SuportedExt.Contains("glCreateMemoryObjectsEXT"))
			{
				dgtk.OpenGL.internalGL.glCreateMemoryObjectsEXT = (dgtk.OpenGL.delegatesGL.glCreateMemoryObjectsEXT) InternalTool.GetGLMethodAdress("glCreateMemoryObjectsEXT", typeof(dgtk.OpenGL.delegatesGL.glCreateMemoryObjectsEXT));
			}
			if (SuportedExt.Contains("glCreatePerfQueryINTEL"))
			{
				dgtk.OpenGL.internalGL.glCreatePerfQueryINTEL = (dgtk.OpenGL.delegatesGL.glCreatePerfQueryINTEL) InternalTool.GetGLMethodAdress("glCreatePerfQueryINTEL", typeof(dgtk.OpenGL.delegatesGL.glCreatePerfQueryINTEL));
			}
			if (SuportedExt.Contains("glCreateProgramObjectARB"))
			{
				dgtk.OpenGL.internalGL.glCreateProgramObjectARB = (dgtk.OpenGL.delegatesGL.glCreateProgramObjectARB) InternalTool.GetGLMethodAdress("glCreateProgramObjectARB", typeof(dgtk.OpenGL.delegatesGL.glCreateProgramObjectARB));
			}
			if (SuportedExt.Contains("glCreateProgressFenceNVX"))
			{
				dgtk.OpenGL.internalGL.glCreateProgressFenceNVX = (dgtk.OpenGL.delegatesGL.glCreateProgressFenceNVX) InternalTool.GetGLMethodAdress("glCreateProgressFenceNVX", typeof(dgtk.OpenGL.delegatesGL.glCreateProgressFenceNVX));
			}
			if (SuportedExt.Contains("glCreateSemaphoresNV"))
			{
				dgtk.OpenGL.internalGL.glCreateSemaphoresNV = (dgtk.OpenGL.delegatesGL.glCreateSemaphoresNV) InternalTool.GetGLMethodAdress("glCreateSemaphoresNV", typeof(dgtk.OpenGL.delegatesGL.glCreateSemaphoresNV));
			}
			if (SuportedExt.Contains("glCreateShaderObjectARB"))
			{
				dgtk.OpenGL.internalGL.glCreateShaderObjectARB = (dgtk.OpenGL.delegatesGL.glCreateShaderObjectARB) InternalTool.GetGLMethodAdress("glCreateShaderObjectARB", typeof(dgtk.OpenGL.delegatesGL.glCreateShaderObjectARB));
			}
			if (SuportedExt.Contains("glCreateShaderProgramEXT"))
			{
				dgtk.OpenGL.internalGL.glCreateShaderProgramEXT = (dgtk.OpenGL.delegatesGL.glCreateShaderProgramEXT) InternalTool.GetGLMethodAdress("glCreateShaderProgramEXT", typeof(dgtk.OpenGL.delegatesGL.glCreateShaderProgramEXT));
			}
			if (SuportedExt.Contains("glCreateShaderProgramvEXT"))
			{
				dgtk.OpenGL.internalGL.glCreateShaderProgramvEXT = (dgtk.OpenGL.delegatesGL.glCreateShaderProgramvEXT) InternalTool.GetGLMethodAdress("glCreateShaderProgramvEXT", typeof(dgtk.OpenGL.delegatesGL.glCreateShaderProgramvEXT));
			}
			if (SuportedExt.Contains("glCreateStatesNV"))
			{
				dgtk.OpenGL.internalGL.glCreateStatesNV = (dgtk.OpenGL.delegatesGL.glCreateStatesNV) InternalTool.GetGLMethodAdress("glCreateStatesNV", typeof(dgtk.OpenGL.delegatesGL.glCreateStatesNV));
			}
			if (SuportedExt.Contains("glCreateSyncFromCLeventARB"))
			{
				dgtk.OpenGL.internalGL.glCreateSyncFromCLeventARB = (dgtk.OpenGL.delegatesGL.glCreateSyncFromCLeventARB) InternalTool.GetGLMethodAdress("glCreateSyncFromCLeventARB", typeof(dgtk.OpenGL.delegatesGL.glCreateSyncFromCLeventARB));
			}
			if (SuportedExt.Contains("glCullParameterdvEXT"))
			{
				dgtk.OpenGL.internalGL.glCullParameterdvEXT = (dgtk.OpenGL.delegatesGL.glCullParameterdvEXT) InternalTool.GetGLMethodAdress("glCullParameterdvEXT", typeof(dgtk.OpenGL.delegatesGL.glCullParameterdvEXT));
			}
			if (SuportedExt.Contains("glCullParameterfvEXT"))
			{
				dgtk.OpenGL.internalGL.glCullParameterfvEXT = (dgtk.OpenGL.delegatesGL.glCullParameterfvEXT) InternalTool.GetGLMethodAdress("glCullParameterfvEXT", typeof(dgtk.OpenGL.delegatesGL.glCullParameterfvEXT));
			}
			if (SuportedExt.Contains("glCurrentPaletteMatrixARB"))
			{
				dgtk.OpenGL.internalGL.glCurrentPaletteMatrixARB = (dgtk.OpenGL.delegatesGL.glCurrentPaletteMatrixARB) InternalTool.GetGLMethodAdress("glCurrentPaletteMatrixARB", typeof(dgtk.OpenGL.delegatesGL.glCurrentPaletteMatrixARB));
			}
			if (SuportedExt.Contains("glCurrentPaletteMatrixOES"))
			{
				dgtk.OpenGL.internalGL.glCurrentPaletteMatrixOES = (dgtk.OpenGL.delegatesGL.glCurrentPaletteMatrixOES) InternalTool.GetGLMethodAdress("glCurrentPaletteMatrixOES", typeof(dgtk.OpenGL.delegatesGL.glCurrentPaletteMatrixOES));
			}
			#endregion

			#region D:

			if (SuportedExt.Contains("glDebugMessageCallbackAMD"))
			{
				dgtk.OpenGL.internalGL.glDebugMessageCallbackAMD = (dgtk.OpenGL.delegatesGL.glDebugMessageCallbackAMD) InternalTool.GetGLMethodAdress("glDebugMessageCallbackAMD", typeof(dgtk.OpenGL.delegatesGL.glDebugMessageCallbackAMD));
			}
			if (SuportedExt.Contains("glDebugMessageCallbackARB"))
			{
				dgtk.OpenGL.internalGL.glDebugMessageCallbackARB = (dgtk.OpenGL.delegatesGL.glDebugMessageCallbackARB) InternalTool.GetGLMethodAdress("glDebugMessageCallbackARB", typeof(dgtk.OpenGL.delegatesGL.glDebugMessageCallbackARB));
			}
			if (SuportedExt.Contains("glDebugMessageCallbackKHR"))
			{
				dgtk.OpenGL.internalGL.glDebugMessageCallbackKHR = (dgtk.OpenGL.delegatesGL.glDebugMessageCallbackKHR) InternalTool.GetGLMethodAdress("glDebugMessageCallbackKHR", typeof(dgtk.OpenGL.delegatesGL.glDebugMessageCallbackKHR));
			}
			if (SuportedExt.Contains("glDebugMessageControlARB"))
			{
				dgtk.OpenGL.internalGL.glDebugMessageControlARB = (dgtk.OpenGL.delegatesGL.glDebugMessageControlARB) InternalTool.GetGLMethodAdress("glDebugMessageControlARB", typeof(dgtk.OpenGL.delegatesGL.glDebugMessageControlARB));
			}
			if (SuportedExt.Contains("glDebugMessageControlKHR"))
			{
				dgtk.OpenGL.internalGL.glDebugMessageControlKHR = (dgtk.OpenGL.delegatesGL.glDebugMessageControlKHR) InternalTool.GetGLMethodAdress("glDebugMessageControlKHR", typeof(dgtk.OpenGL.delegatesGL.glDebugMessageControlKHR));
			}
			if (SuportedExt.Contains("glDebugMessageEnableAMD"))
			{
				dgtk.OpenGL.internalGL.glDebugMessageEnableAMD = (dgtk.OpenGL.delegatesGL.glDebugMessageEnableAMD) InternalTool.GetGLMethodAdress("glDebugMessageEnableAMD", typeof(dgtk.OpenGL.delegatesGL.glDebugMessageEnableAMD));
			}
			if (SuportedExt.Contains("glDebugMessageInsertAMD"))
			{
				dgtk.OpenGL.internalGL.glDebugMessageInsertAMD = (dgtk.OpenGL.delegatesGL.glDebugMessageInsertAMD) InternalTool.GetGLMethodAdress("glDebugMessageInsertAMD", typeof(dgtk.OpenGL.delegatesGL.glDebugMessageInsertAMD));
			}
			if (SuportedExt.Contains("glDebugMessageInsertARB"))
			{
				dgtk.OpenGL.internalGL.glDebugMessageInsertARB = (dgtk.OpenGL.delegatesGL.glDebugMessageInsertARB) InternalTool.GetGLMethodAdress("glDebugMessageInsertARB", typeof(dgtk.OpenGL.delegatesGL.glDebugMessageInsertARB));
			}
			if (SuportedExt.Contains("glDebugMessageInsertKHR"))
			{
				dgtk.OpenGL.internalGL.glDebugMessageInsertKHR = (dgtk.OpenGL.delegatesGL.glDebugMessageInsertKHR) InternalTool.GetGLMethodAdress("glDebugMessageInsertKHR", typeof(dgtk.OpenGL.delegatesGL.glDebugMessageInsertKHR));
			}
			if (SuportedExt.Contains("glDeformationMap3dSGIX"))
			{
				dgtk.OpenGL.internalGL.glDeformationMap3dSGIX = (dgtk.OpenGL.delegatesGL.glDeformationMap3dSGIX) InternalTool.GetGLMethodAdress("glDeformationMap3dSGIX", typeof(dgtk.OpenGL.delegatesGL.glDeformationMap3dSGIX));
			}
			if (SuportedExt.Contains("glDeformationMap3fSGIX"))
			{
				dgtk.OpenGL.internalGL.glDeformationMap3fSGIX = (dgtk.OpenGL.delegatesGL.glDeformationMap3fSGIX) InternalTool.GetGLMethodAdress("glDeformationMap3fSGIX", typeof(dgtk.OpenGL.delegatesGL.glDeformationMap3fSGIX));
			}
			if (SuportedExt.Contains("glDeformSGIX"))
			{
				dgtk.OpenGL.internalGL.glDeformSGIX = (dgtk.OpenGL.delegatesGL.glDeformSGIX) InternalTool.GetGLMethodAdress("glDeformSGIX", typeof(dgtk.OpenGL.delegatesGL.glDeformSGIX));
			}
			if (SuportedExt.Contains("glDeleteAsyncMarkersSGIX"))
			{
				dgtk.OpenGL.internalGL.glDeleteAsyncMarkersSGIX = (dgtk.OpenGL.delegatesGL.glDeleteAsyncMarkersSGIX) InternalTool.GetGLMethodAdress("glDeleteAsyncMarkersSGIX", typeof(dgtk.OpenGL.delegatesGL.glDeleteAsyncMarkersSGIX));
			}
			if (SuportedExt.Contains("glDeleteBuffersARB"))
			{
				dgtk.OpenGL.internalGL.glDeleteBuffersARB = (dgtk.OpenGL.delegatesGL.glDeleteBuffersARB) InternalTool.GetGLMethodAdress("glDeleteBuffersARB", typeof(dgtk.OpenGL.delegatesGL.glDeleteBuffersARB));
			}
			if (SuportedExt.Contains("glDeleteCommandListsNV"))
			{
				dgtk.OpenGL.internalGL.glDeleteCommandListsNV = (dgtk.OpenGL.delegatesGL.glDeleteCommandListsNV) InternalTool.GetGLMethodAdress("glDeleteCommandListsNV", typeof(dgtk.OpenGL.delegatesGL.glDeleteCommandListsNV));
			}
			if (SuportedExt.Contains("glDeleteFencesAPPLE"))
			{
				dgtk.OpenGL.internalGL.glDeleteFencesAPPLE = (dgtk.OpenGL.delegatesGL.glDeleteFencesAPPLE) InternalTool.GetGLMethodAdress("glDeleteFencesAPPLE", typeof(dgtk.OpenGL.delegatesGL.glDeleteFencesAPPLE));
			}
			if (SuportedExt.Contains("glDeleteFencesNV"))
			{
				dgtk.OpenGL.internalGL.glDeleteFencesNV = (dgtk.OpenGL.delegatesGL.glDeleteFencesNV) InternalTool.GetGLMethodAdress("glDeleteFencesNV", typeof(dgtk.OpenGL.delegatesGL.glDeleteFencesNV));
			}
			if (SuportedExt.Contains("glDeleteFragmentShaderATI"))
			{
				dgtk.OpenGL.internalGL.glDeleteFragmentShaderATI = (dgtk.OpenGL.delegatesGL.glDeleteFragmentShaderATI) InternalTool.GetGLMethodAdress("glDeleteFragmentShaderATI", typeof(dgtk.OpenGL.delegatesGL.glDeleteFragmentShaderATI));
			}
			if (SuportedExt.Contains("glDeleteFramebuffersEXT"))
			{
				dgtk.OpenGL.internalGL.glDeleteFramebuffersEXT = (dgtk.OpenGL.delegatesGL.glDeleteFramebuffersEXT) InternalTool.GetGLMethodAdress("glDeleteFramebuffersEXT", typeof(dgtk.OpenGL.delegatesGL.glDeleteFramebuffersEXT));
			}
			if (SuportedExt.Contains("glDeleteFramebuffersOES"))
			{
				dgtk.OpenGL.internalGL.glDeleteFramebuffersOES = (dgtk.OpenGL.delegatesGL.glDeleteFramebuffersOES) InternalTool.GetGLMethodAdress("glDeleteFramebuffersOES", typeof(dgtk.OpenGL.delegatesGL.glDeleteFramebuffersOES));
			}
			if (SuportedExt.Contains("glDeleteMemoryObjectsEXT"))
			{
				dgtk.OpenGL.internalGL.glDeleteMemoryObjectsEXT = (dgtk.OpenGL.delegatesGL.glDeleteMemoryObjectsEXT) InternalTool.GetGLMethodAdress("glDeleteMemoryObjectsEXT", typeof(dgtk.OpenGL.delegatesGL.glDeleteMemoryObjectsEXT));
			}
			if (SuportedExt.Contains("glDeleteNamedStringARB"))
			{
				dgtk.OpenGL.internalGL.glDeleteNamedStringARB = (dgtk.OpenGL.delegatesGL.glDeleteNamedStringARB) InternalTool.GetGLMethodAdress("glDeleteNamedStringARB", typeof(dgtk.OpenGL.delegatesGL.glDeleteNamedStringARB));
			}
			if (SuportedExt.Contains("glDeleteNamesAMD"))
			{
				dgtk.OpenGL.internalGL.glDeleteNamesAMD = (dgtk.OpenGL.delegatesGL.glDeleteNamesAMD) InternalTool.GetGLMethodAdress("glDeleteNamesAMD", typeof(dgtk.OpenGL.delegatesGL.glDeleteNamesAMD));
			}
			if (SuportedExt.Contains("glDeleteObjectARB"))
			{
				dgtk.OpenGL.internalGL.glDeleteObjectARB = (dgtk.OpenGL.delegatesGL.glDeleteObjectARB) InternalTool.GetGLMethodAdress("glDeleteObjectARB", typeof(dgtk.OpenGL.delegatesGL.glDeleteObjectARB));
			}
			if (SuportedExt.Contains("glDeleteOcclusionQueriesNV"))
			{
				dgtk.OpenGL.internalGL.glDeleteOcclusionQueriesNV = (dgtk.OpenGL.delegatesGL.glDeleteOcclusionQueriesNV) InternalTool.GetGLMethodAdress("glDeleteOcclusionQueriesNV", typeof(dgtk.OpenGL.delegatesGL.glDeleteOcclusionQueriesNV));
			}
			if (SuportedExt.Contains("glDeletePathsNV"))
			{
				dgtk.OpenGL.internalGL.glDeletePathsNV = (dgtk.OpenGL.delegatesGL.glDeletePathsNV) InternalTool.GetGLMethodAdress("glDeletePathsNV", typeof(dgtk.OpenGL.delegatesGL.glDeletePathsNV));
			}
			if (SuportedExt.Contains("glDeletePerfMonitorsAMD"))
			{
				dgtk.OpenGL.internalGL.glDeletePerfMonitorsAMD = (dgtk.OpenGL.delegatesGL.glDeletePerfMonitorsAMD) InternalTool.GetGLMethodAdress("glDeletePerfMonitorsAMD", typeof(dgtk.OpenGL.delegatesGL.glDeletePerfMonitorsAMD));
			}
			if (SuportedExt.Contains("glDeletePerfQueryINTEL"))
			{
				dgtk.OpenGL.internalGL.glDeletePerfQueryINTEL = (dgtk.OpenGL.delegatesGL.glDeletePerfQueryINTEL) InternalTool.GetGLMethodAdress("glDeletePerfQueryINTEL", typeof(dgtk.OpenGL.delegatesGL.glDeletePerfQueryINTEL));
			}
			if (SuportedExt.Contains("glDeleteProgramPipelinesEXT"))
			{
				dgtk.OpenGL.internalGL.glDeleteProgramPipelinesEXT = (dgtk.OpenGL.delegatesGL.glDeleteProgramPipelinesEXT) InternalTool.GetGLMethodAdress("glDeleteProgramPipelinesEXT", typeof(dgtk.OpenGL.delegatesGL.glDeleteProgramPipelinesEXT));
			}
			if (SuportedExt.Contains("glDeleteProgramsARB"))
			{
				dgtk.OpenGL.internalGL.glDeleteProgramsARB = (dgtk.OpenGL.delegatesGL.glDeleteProgramsARB) InternalTool.GetGLMethodAdress("glDeleteProgramsARB", typeof(dgtk.OpenGL.delegatesGL.glDeleteProgramsARB));
			}
			if (SuportedExt.Contains("glDeleteProgramsNV"))
			{
				dgtk.OpenGL.internalGL.glDeleteProgramsNV = (dgtk.OpenGL.delegatesGL.glDeleteProgramsNV) InternalTool.GetGLMethodAdress("glDeleteProgramsNV", typeof(dgtk.OpenGL.delegatesGL.glDeleteProgramsNV));
			}
			if (SuportedExt.Contains("glDeleteQueriesARB"))
			{
				dgtk.OpenGL.internalGL.glDeleteQueriesARB = (dgtk.OpenGL.delegatesGL.glDeleteQueriesARB) InternalTool.GetGLMethodAdress("glDeleteQueriesARB", typeof(dgtk.OpenGL.delegatesGL.glDeleteQueriesARB));
			}
			if (SuportedExt.Contains("glDeleteQueriesEXT"))
			{
				dgtk.OpenGL.internalGL.glDeleteQueriesEXT = (dgtk.OpenGL.delegatesGL.glDeleteQueriesEXT) InternalTool.GetGLMethodAdress("glDeleteQueriesEXT", typeof(dgtk.OpenGL.delegatesGL.glDeleteQueriesEXT));
			}
			if (SuportedExt.Contains("glDeleteQueryResourceTagNV"))
			{
				dgtk.OpenGL.internalGL.glDeleteQueryResourceTagNV = (dgtk.OpenGL.delegatesGL.glDeleteQueryResourceTagNV) InternalTool.GetGLMethodAdress("glDeleteQueryResourceTagNV", typeof(dgtk.OpenGL.delegatesGL.glDeleteQueryResourceTagNV));
			}
			if (SuportedExt.Contains("glDeleteRenderbuffersEXT"))
			{
				dgtk.OpenGL.internalGL.glDeleteRenderbuffersEXT = (dgtk.OpenGL.delegatesGL.glDeleteRenderbuffersEXT) InternalTool.GetGLMethodAdress("glDeleteRenderbuffersEXT", typeof(dgtk.OpenGL.delegatesGL.glDeleteRenderbuffersEXT));
			}
			if (SuportedExt.Contains("glDeleteRenderbuffersOES"))
			{
				dgtk.OpenGL.internalGL.glDeleteRenderbuffersOES = (dgtk.OpenGL.delegatesGL.glDeleteRenderbuffersOES) InternalTool.GetGLMethodAdress("glDeleteRenderbuffersOES", typeof(dgtk.OpenGL.delegatesGL.glDeleteRenderbuffersOES));
			}
			if (SuportedExt.Contains("glDeleteSemaphoresEXT"))
			{
				dgtk.OpenGL.internalGL.glDeleteSemaphoresEXT = (dgtk.OpenGL.delegatesGL.glDeleteSemaphoresEXT) InternalTool.GetGLMethodAdress("glDeleteSemaphoresEXT", typeof(dgtk.OpenGL.delegatesGL.glDeleteSemaphoresEXT));
			}
			if (SuportedExt.Contains("glDeleteStatesNV"))
			{
				dgtk.OpenGL.internalGL.glDeleteStatesNV = (dgtk.OpenGL.delegatesGL.glDeleteStatesNV) InternalTool.GetGLMethodAdress("glDeleteStatesNV", typeof(dgtk.OpenGL.delegatesGL.glDeleteStatesNV));
			}
			if (SuportedExt.Contains("glDeleteSyncAPPLE"))
			{
				dgtk.OpenGL.internalGL.glDeleteSyncAPPLE = (dgtk.OpenGL.delegatesGL.glDeleteSyncAPPLE) InternalTool.GetGLMethodAdress("glDeleteSyncAPPLE", typeof(dgtk.OpenGL.delegatesGL.glDeleteSyncAPPLE));
			}
			if (SuportedExt.Contains("glDeleteTexturesEXT"))
			{
				dgtk.OpenGL.internalGL.glDeleteTexturesEXT = (dgtk.OpenGL.delegatesGL.glDeleteTexturesEXT) InternalTool.GetGLMethodAdress("glDeleteTexturesEXT", typeof(dgtk.OpenGL.delegatesGL.glDeleteTexturesEXT));
			}
			if (SuportedExt.Contains("glDeleteTransformFeedbacksNV"))
			{
				dgtk.OpenGL.internalGL.glDeleteTransformFeedbacksNV = (dgtk.OpenGL.delegatesGL.glDeleteTransformFeedbacksNV) InternalTool.GetGLMethodAdress("glDeleteTransformFeedbacksNV", typeof(dgtk.OpenGL.delegatesGL.glDeleteTransformFeedbacksNV));
			}
			if (SuportedExt.Contains("glDeleteVertexArraysAPPLE"))
			{
				dgtk.OpenGL.internalGL.glDeleteVertexArraysAPPLE = (dgtk.OpenGL.delegatesGL.glDeleteVertexArraysAPPLE) InternalTool.GetGLMethodAdress("glDeleteVertexArraysAPPLE", typeof(dgtk.OpenGL.delegatesGL.glDeleteVertexArraysAPPLE));
			}
			if (SuportedExt.Contains("glDeleteVertexArraysOES"))
			{
				dgtk.OpenGL.internalGL.glDeleteVertexArraysOES = (dgtk.OpenGL.delegatesGL.glDeleteVertexArraysOES) InternalTool.GetGLMethodAdress("glDeleteVertexArraysOES", typeof(dgtk.OpenGL.delegatesGL.glDeleteVertexArraysOES));
			}
			if (SuportedExt.Contains("glDeleteVertexShaderEXT"))
			{
				dgtk.OpenGL.internalGL.glDeleteVertexShaderEXT = (dgtk.OpenGL.delegatesGL.glDeleteVertexShaderEXT) InternalTool.GetGLMethodAdress("glDeleteVertexShaderEXT", typeof(dgtk.OpenGL.delegatesGL.glDeleteVertexShaderEXT));
			}
			if (SuportedExt.Contains("glDepthBoundsdNV"))
			{
				dgtk.OpenGL.internalGL.glDepthBoundsdNV = (dgtk.OpenGL.delegatesGL.glDepthBoundsdNV) InternalTool.GetGLMethodAdress("glDepthBoundsdNV", typeof(dgtk.OpenGL.delegatesGL.glDepthBoundsdNV));
			}
			if (SuportedExt.Contains("glDepthBoundsEXT"))
			{
				dgtk.OpenGL.internalGL.glDepthBoundsEXT = (dgtk.OpenGL.delegatesGL.glDepthBoundsEXT) InternalTool.GetGLMethodAdress("glDepthBoundsEXT", typeof(dgtk.OpenGL.delegatesGL.glDepthBoundsEXT));
			}
			if (SuportedExt.Contains("glDepthRangeArraydvNV"))
			{
				dgtk.OpenGL.internalGL.glDepthRangeArraydvNV = (dgtk.OpenGL.delegatesGL.glDepthRangeArraydvNV) InternalTool.GetGLMethodAdress("glDepthRangeArraydvNV", typeof(dgtk.OpenGL.delegatesGL.glDepthRangeArraydvNV));
			}
			if (SuportedExt.Contains("glDepthRangeArrayfvNV"))
			{
				dgtk.OpenGL.internalGL.glDepthRangeArrayfvNV = (dgtk.OpenGL.delegatesGL.glDepthRangeArrayfvNV) InternalTool.GetGLMethodAdress("glDepthRangeArrayfvNV", typeof(dgtk.OpenGL.delegatesGL.glDepthRangeArrayfvNV));
			}
			if (SuportedExt.Contains("glDepthRangeArrayfvOES"))
			{
				dgtk.OpenGL.internalGL.glDepthRangeArrayfvOES = (dgtk.OpenGL.delegatesGL.glDepthRangeArrayfvOES) InternalTool.GetGLMethodAdress("glDepthRangeArrayfvOES", typeof(dgtk.OpenGL.delegatesGL.glDepthRangeArrayfvOES));
			}
			if (SuportedExt.Contains("glDepthRangedNV"))
			{
				dgtk.OpenGL.internalGL.glDepthRangedNV = (dgtk.OpenGL.delegatesGL.glDepthRangedNV) InternalTool.GetGLMethodAdress("glDepthRangedNV", typeof(dgtk.OpenGL.delegatesGL.glDepthRangedNV));
			}
			if (SuportedExt.Contains("glDepthRangefOES"))
			{
				dgtk.OpenGL.internalGL.glDepthRangefOES = (dgtk.OpenGL.delegatesGL.glDepthRangefOES) InternalTool.GetGLMethodAdress("glDepthRangefOES", typeof(dgtk.OpenGL.delegatesGL.glDepthRangefOES));
			}
			if (SuportedExt.Contains("glDepthRangeIndexeddNV"))
			{
				dgtk.OpenGL.internalGL.glDepthRangeIndexeddNV = (dgtk.OpenGL.delegatesGL.glDepthRangeIndexeddNV) InternalTool.GetGLMethodAdress("glDepthRangeIndexeddNV", typeof(dgtk.OpenGL.delegatesGL.glDepthRangeIndexeddNV));
			}
			if (SuportedExt.Contains("glDepthRangeIndexedfNV"))
			{
				dgtk.OpenGL.internalGL.glDepthRangeIndexedfNV = (dgtk.OpenGL.delegatesGL.glDepthRangeIndexedfNV) InternalTool.GetGLMethodAdress("glDepthRangeIndexedfNV", typeof(dgtk.OpenGL.delegatesGL.glDepthRangeIndexedfNV));
			}
			if (SuportedExt.Contains("glDepthRangeIndexedfOES"))
			{
				dgtk.OpenGL.internalGL.glDepthRangeIndexedfOES = (dgtk.OpenGL.delegatesGL.glDepthRangeIndexedfOES) InternalTool.GetGLMethodAdress("glDepthRangeIndexedfOES", typeof(dgtk.OpenGL.delegatesGL.glDepthRangeIndexedfOES));
			}
			if (SuportedExt.Contains("glDepthRangex"))
			{
				dgtk.OpenGL.internalGL.glDepthRangex = (dgtk.OpenGL.delegatesGL.glDepthRangex) InternalTool.GetGLMethodAdress("glDepthRangex", typeof(dgtk.OpenGL.delegatesGL.glDepthRangex));
			}
			if (SuportedExt.Contains("glDepthRangexOES"))
			{
				dgtk.OpenGL.internalGL.glDepthRangexOES = (dgtk.OpenGL.delegatesGL.glDepthRangexOES) InternalTool.GetGLMethodAdress("glDepthRangexOES", typeof(dgtk.OpenGL.delegatesGL.glDepthRangexOES));
			}
			if (SuportedExt.Contains("glDetachObjectARB"))
			{
				dgtk.OpenGL.internalGL.glDetachObjectARB = (dgtk.OpenGL.delegatesGL.glDetachObjectARB) InternalTool.GetGLMethodAdress("glDetachObjectARB", typeof(dgtk.OpenGL.delegatesGL.glDetachObjectARB));
			}
			if (SuportedExt.Contains("glDetailTexFuncSGIS"))
			{
				dgtk.OpenGL.internalGL.glDetailTexFuncSGIS = (dgtk.OpenGL.delegatesGL.glDetailTexFuncSGIS) InternalTool.GetGLMethodAdress("glDetailTexFuncSGIS", typeof(dgtk.OpenGL.delegatesGL.glDetailTexFuncSGIS));
			}
			if (SuportedExt.Contains("glDisableClientStateiEXT"))
			{
				dgtk.OpenGL.internalGL.glDisableClientStateiEXT = (dgtk.OpenGL.delegatesGL.glDisableClientStateiEXT) InternalTool.GetGLMethodAdress("glDisableClientStateiEXT", typeof(dgtk.OpenGL.delegatesGL.glDisableClientStateiEXT));
			}
			if (SuportedExt.Contains("glDisableClientStateIndexedEXT"))
			{
				dgtk.OpenGL.internalGL.glDisableClientStateIndexedEXT = (dgtk.OpenGL.delegatesGL.glDisableClientStateIndexedEXT) InternalTool.GetGLMethodAdress("glDisableClientStateIndexedEXT", typeof(dgtk.OpenGL.delegatesGL.glDisableClientStateIndexedEXT));
			}
			if (SuportedExt.Contains("glDisableDriverControlQCOM"))
			{
				dgtk.OpenGL.internalGL.glDisableDriverControlQCOM = (dgtk.OpenGL.delegatesGL.glDisableDriverControlQCOM) InternalTool.GetGLMethodAdress("glDisableDriverControlQCOM", typeof(dgtk.OpenGL.delegatesGL.glDisableDriverControlQCOM));
			}
			if (SuportedExt.Contains("glDisableiEXT"))
			{
				dgtk.OpenGL.internalGL.glDisableiEXT = (dgtk.OpenGL.delegatesGL.glDisableiEXT) InternalTool.GetGLMethodAdress("glDisableiEXT", typeof(dgtk.OpenGL.delegatesGL.glDisableiEXT));
			}
			if (SuportedExt.Contains("glDisableIndexedEXT"))
			{
				dgtk.OpenGL.internalGL.glDisableIndexedEXT = (dgtk.OpenGL.delegatesGL.glDisableIndexedEXT) InternalTool.GetGLMethodAdress("glDisableIndexedEXT", typeof(dgtk.OpenGL.delegatesGL.glDisableIndexedEXT));
			}
			if (SuportedExt.Contains("glDisableiNV"))
			{
				dgtk.OpenGL.internalGL.glDisableiNV = (dgtk.OpenGL.delegatesGL.glDisableiNV) InternalTool.GetGLMethodAdress("glDisableiNV", typeof(dgtk.OpenGL.delegatesGL.glDisableiNV));
			}
			if (SuportedExt.Contains("glDisableiOES"))
			{
				dgtk.OpenGL.internalGL.glDisableiOES = (dgtk.OpenGL.delegatesGL.glDisableiOES) InternalTool.GetGLMethodAdress("glDisableiOES", typeof(dgtk.OpenGL.delegatesGL.glDisableiOES));
			}
			if (SuportedExt.Contains("glDisableVariantClientStateEXT"))
			{
				dgtk.OpenGL.internalGL.glDisableVariantClientStateEXT = (dgtk.OpenGL.delegatesGL.glDisableVariantClientStateEXT) InternalTool.GetGLMethodAdress("glDisableVariantClientStateEXT", typeof(dgtk.OpenGL.delegatesGL.glDisableVariantClientStateEXT));
			}
			if (SuportedExt.Contains("glDisableVertexArrayAttribEXT"))
			{
				dgtk.OpenGL.internalGL.glDisableVertexArrayAttribEXT = (dgtk.OpenGL.delegatesGL.glDisableVertexArrayAttribEXT) InternalTool.GetGLMethodAdress("glDisableVertexArrayAttribEXT", typeof(dgtk.OpenGL.delegatesGL.glDisableVertexArrayAttribEXT));
			}
			if (SuportedExt.Contains("glDisableVertexArrayEXT"))
			{
				dgtk.OpenGL.internalGL.glDisableVertexArrayEXT = (dgtk.OpenGL.delegatesGL.glDisableVertexArrayEXT) InternalTool.GetGLMethodAdress("glDisableVertexArrayEXT", typeof(dgtk.OpenGL.delegatesGL.glDisableVertexArrayEXT));
			}
			if (SuportedExt.Contains("glDisableVertexAttribAPPLE"))
			{
				dgtk.OpenGL.internalGL.glDisableVertexAttribAPPLE = (dgtk.OpenGL.delegatesGL.glDisableVertexAttribAPPLE) InternalTool.GetGLMethodAdress("glDisableVertexAttribAPPLE", typeof(dgtk.OpenGL.delegatesGL.glDisableVertexAttribAPPLE));
			}
			if (SuportedExt.Contains("glDisableVertexAttribArrayARB"))
			{
				dgtk.OpenGL.internalGL.glDisableVertexAttribArrayARB = (dgtk.OpenGL.delegatesGL.glDisableVertexAttribArrayARB) InternalTool.GetGLMethodAdress("glDisableVertexAttribArrayARB", typeof(dgtk.OpenGL.delegatesGL.glDisableVertexAttribArrayARB));
			}
			if (SuportedExt.Contains("glDiscardFramebufferEXT"))
			{
				dgtk.OpenGL.internalGL.glDiscardFramebufferEXT = (dgtk.OpenGL.delegatesGL.glDiscardFramebufferEXT) InternalTool.GetGLMethodAdress("glDiscardFramebufferEXT", typeof(dgtk.OpenGL.delegatesGL.glDiscardFramebufferEXT));
			}
			if (SuportedExt.Contains("glDispatchComputeGroupSizeARB"))
			{
				dgtk.OpenGL.internalGL.glDispatchComputeGroupSizeARB = (dgtk.OpenGL.delegatesGL.glDispatchComputeGroupSizeARB) InternalTool.GetGLMethodAdress("glDispatchComputeGroupSizeARB", typeof(dgtk.OpenGL.delegatesGL.glDispatchComputeGroupSizeARB));
			}
			if (SuportedExt.Contains("glDrawArraysEXT"))
			{
				dgtk.OpenGL.internalGL.glDrawArraysEXT = (dgtk.OpenGL.delegatesGL.glDrawArraysEXT) InternalTool.GetGLMethodAdress("glDrawArraysEXT", typeof(dgtk.OpenGL.delegatesGL.glDrawArraysEXT));
			}
			if (SuportedExt.Contains("glDrawArraysInstancedANGLE"))
			{
				dgtk.OpenGL.internalGL.glDrawArraysInstancedANGLE = (dgtk.OpenGL.delegatesGL.glDrawArraysInstancedANGLE) InternalTool.GetGLMethodAdress("glDrawArraysInstancedANGLE", typeof(dgtk.OpenGL.delegatesGL.glDrawArraysInstancedANGLE));
			}
			if (SuportedExt.Contains("glDrawArraysInstancedARB"))
			{
				dgtk.OpenGL.internalGL.glDrawArraysInstancedARB = (dgtk.OpenGL.delegatesGL.glDrawArraysInstancedARB) InternalTool.GetGLMethodAdress("glDrawArraysInstancedARB", typeof(dgtk.OpenGL.delegatesGL.glDrawArraysInstancedARB));
			}
			if (SuportedExt.Contains("glDrawArraysInstancedBaseInstanceEXT"))
			{
				dgtk.OpenGL.internalGL.glDrawArraysInstancedBaseInstanceEXT = (dgtk.OpenGL.delegatesGL.glDrawArraysInstancedBaseInstanceEXT) InternalTool.GetGLMethodAdress("glDrawArraysInstancedBaseInstanceEXT", typeof(dgtk.OpenGL.delegatesGL.glDrawArraysInstancedBaseInstanceEXT));
			}
			if (SuportedExt.Contains("glDrawArraysInstancedEXT"))
			{
				dgtk.OpenGL.internalGL.glDrawArraysInstancedEXT = (dgtk.OpenGL.delegatesGL.glDrawArraysInstancedEXT) InternalTool.GetGLMethodAdress("glDrawArraysInstancedEXT", typeof(dgtk.OpenGL.delegatesGL.glDrawArraysInstancedEXT));
			}
			if (SuportedExt.Contains("glDrawArraysInstancedNV"))
			{
				dgtk.OpenGL.internalGL.glDrawArraysInstancedNV = (dgtk.OpenGL.delegatesGL.glDrawArraysInstancedNV) InternalTool.GetGLMethodAdress("glDrawArraysInstancedNV", typeof(dgtk.OpenGL.delegatesGL.glDrawArraysInstancedNV));
			}
			if (SuportedExt.Contains("glDrawBuffersARB"))
			{
				dgtk.OpenGL.internalGL.glDrawBuffersARB = (dgtk.OpenGL.delegatesGL.glDrawBuffersARB) InternalTool.GetGLMethodAdress("glDrawBuffersARB", typeof(dgtk.OpenGL.delegatesGL.glDrawBuffersARB));
			}
			if (SuportedExt.Contains("glDrawBuffersATI"))
			{
				dgtk.OpenGL.internalGL.glDrawBuffersATI = (dgtk.OpenGL.delegatesGL.glDrawBuffersATI) InternalTool.GetGLMethodAdress("glDrawBuffersATI", typeof(dgtk.OpenGL.delegatesGL.glDrawBuffersATI));
			}
			if (SuportedExt.Contains("glDrawBuffersEXT"))
			{
				dgtk.OpenGL.internalGL.glDrawBuffersEXT = (dgtk.OpenGL.delegatesGL.glDrawBuffersEXT) InternalTool.GetGLMethodAdress("glDrawBuffersEXT", typeof(dgtk.OpenGL.delegatesGL.glDrawBuffersEXT));
			}
			if (SuportedExt.Contains("glDrawBuffersIndexedEXT"))
			{
				dgtk.OpenGL.internalGL.glDrawBuffersIndexedEXT = (dgtk.OpenGL.delegatesGL.glDrawBuffersIndexedEXT) InternalTool.GetGLMethodAdress("glDrawBuffersIndexedEXT", typeof(dgtk.OpenGL.delegatesGL.glDrawBuffersIndexedEXT));
			}
			if (SuportedExt.Contains("glDrawBuffersNV"))
			{
				dgtk.OpenGL.internalGL.glDrawBuffersNV = (dgtk.OpenGL.delegatesGL.glDrawBuffersNV) InternalTool.GetGLMethodAdress("glDrawBuffersNV", typeof(dgtk.OpenGL.delegatesGL.glDrawBuffersNV));
			}
			if (SuportedExt.Contains("glDrawCommandsAddressNV"))
			{
				dgtk.OpenGL.internalGL.glDrawCommandsAddressNV = (dgtk.OpenGL.delegatesGL.glDrawCommandsAddressNV) InternalTool.GetGLMethodAdress("glDrawCommandsAddressNV", typeof(dgtk.OpenGL.delegatesGL.glDrawCommandsAddressNV));
			}
			if (SuportedExt.Contains("glDrawCommandsNV"))
			{
				dgtk.OpenGL.internalGL.glDrawCommandsNV = (dgtk.OpenGL.delegatesGL.glDrawCommandsNV) InternalTool.GetGLMethodAdress("glDrawCommandsNV", typeof(dgtk.OpenGL.delegatesGL.glDrawCommandsNV));
			}
			if (SuportedExt.Contains("glDrawCommandsStatesAddressNV"))
			{
				dgtk.OpenGL.internalGL.glDrawCommandsStatesAddressNV = (dgtk.OpenGL.delegatesGL.glDrawCommandsStatesAddressNV) InternalTool.GetGLMethodAdress("glDrawCommandsStatesAddressNV", typeof(dgtk.OpenGL.delegatesGL.glDrawCommandsStatesAddressNV));
			}
			if (SuportedExt.Contains("glDrawCommandsStatesNV"))
			{
				dgtk.OpenGL.internalGL.glDrawCommandsStatesNV = (dgtk.OpenGL.delegatesGL.glDrawCommandsStatesNV) InternalTool.GetGLMethodAdress("glDrawCommandsStatesNV", typeof(dgtk.OpenGL.delegatesGL.glDrawCommandsStatesNV));
			}
			if (SuportedExt.Contains("glDrawElementArrayAPPLE"))
			{
				dgtk.OpenGL.internalGL.glDrawElementArrayAPPLE = (dgtk.OpenGL.delegatesGL.glDrawElementArrayAPPLE) InternalTool.GetGLMethodAdress("glDrawElementArrayAPPLE", typeof(dgtk.OpenGL.delegatesGL.glDrawElementArrayAPPLE));
			}
			if (SuportedExt.Contains("glDrawElementArrayATI"))
			{
				dgtk.OpenGL.internalGL.glDrawElementArrayATI = (dgtk.OpenGL.delegatesGL.glDrawElementArrayATI) InternalTool.GetGLMethodAdress("glDrawElementArrayATI", typeof(dgtk.OpenGL.delegatesGL.glDrawElementArrayATI));
			}
			if (SuportedExt.Contains("glDrawElementsBaseVertexEXT"))
			{
				dgtk.OpenGL.internalGL.glDrawElementsBaseVertexEXT = (dgtk.OpenGL.delegatesGL.glDrawElementsBaseVertexEXT) InternalTool.GetGLMethodAdress("glDrawElementsBaseVertexEXT", typeof(dgtk.OpenGL.delegatesGL.glDrawElementsBaseVertexEXT));
			}
			if (SuportedExt.Contains("glDrawElementsBaseVertexOES"))
			{
				dgtk.OpenGL.internalGL.glDrawElementsBaseVertexOES = (dgtk.OpenGL.delegatesGL.glDrawElementsBaseVertexOES) InternalTool.GetGLMethodAdress("glDrawElementsBaseVertexOES", typeof(dgtk.OpenGL.delegatesGL.glDrawElementsBaseVertexOES));
			}
			if (SuportedExt.Contains("glDrawElementsInstancedANGLE"))
			{
				dgtk.OpenGL.internalGL.glDrawElementsInstancedANGLE = (dgtk.OpenGL.delegatesGL.glDrawElementsInstancedANGLE) InternalTool.GetGLMethodAdress("glDrawElementsInstancedANGLE", typeof(dgtk.OpenGL.delegatesGL.glDrawElementsInstancedANGLE));
			}
			if (SuportedExt.Contains("glDrawElementsInstancedARB"))
			{
				dgtk.OpenGL.internalGL.glDrawElementsInstancedARB = (dgtk.OpenGL.delegatesGL.glDrawElementsInstancedARB) InternalTool.GetGLMethodAdress("glDrawElementsInstancedARB", typeof(dgtk.OpenGL.delegatesGL.glDrawElementsInstancedARB));
			}
			if (SuportedExt.Contains("glDrawElementsInstancedBaseInstanceEXT"))
			{
				dgtk.OpenGL.internalGL.glDrawElementsInstancedBaseInstanceEXT = (dgtk.OpenGL.delegatesGL.glDrawElementsInstancedBaseInstanceEXT) InternalTool.GetGLMethodAdress("glDrawElementsInstancedBaseInstanceEXT", typeof(dgtk.OpenGL.delegatesGL.glDrawElementsInstancedBaseInstanceEXT));
			}
			if (SuportedExt.Contains("glDrawElementsInstancedBaseVertexBaseInstanceEXT"))
			{
				dgtk.OpenGL.internalGL.glDrawElementsInstancedBaseVertexBaseInstanceEXT = (dgtk.OpenGL.delegatesGL.glDrawElementsInstancedBaseVertexBaseInstanceEXT) InternalTool.GetGLMethodAdress("glDrawElementsInstancedBaseVertexBaseInstanceEXT", typeof(dgtk.OpenGL.delegatesGL.glDrawElementsInstancedBaseVertexBaseInstanceEXT));
			}
			if (SuportedExt.Contains("glDrawElementsInstancedBaseVertexEXT"))
			{
				dgtk.OpenGL.internalGL.glDrawElementsInstancedBaseVertexEXT = (dgtk.OpenGL.delegatesGL.glDrawElementsInstancedBaseVertexEXT) InternalTool.GetGLMethodAdress("glDrawElementsInstancedBaseVertexEXT", typeof(dgtk.OpenGL.delegatesGL.glDrawElementsInstancedBaseVertexEXT));
			}
			if (SuportedExt.Contains("glDrawElementsInstancedBaseVertexOES"))
			{
				dgtk.OpenGL.internalGL.glDrawElementsInstancedBaseVertexOES = (dgtk.OpenGL.delegatesGL.glDrawElementsInstancedBaseVertexOES) InternalTool.GetGLMethodAdress("glDrawElementsInstancedBaseVertexOES", typeof(dgtk.OpenGL.delegatesGL.glDrawElementsInstancedBaseVertexOES));
			}
			if (SuportedExt.Contains("glDrawElementsInstancedEXT"))
			{
				dgtk.OpenGL.internalGL.glDrawElementsInstancedEXT = (dgtk.OpenGL.delegatesGL.glDrawElementsInstancedEXT) InternalTool.GetGLMethodAdress("glDrawElementsInstancedEXT", typeof(dgtk.OpenGL.delegatesGL.glDrawElementsInstancedEXT));
			}
			if (SuportedExt.Contains("glDrawElementsInstancedNV"))
			{
				dgtk.OpenGL.internalGL.glDrawElementsInstancedNV = (dgtk.OpenGL.delegatesGL.glDrawElementsInstancedNV) InternalTool.GetGLMethodAdress("glDrawElementsInstancedNV", typeof(dgtk.OpenGL.delegatesGL.glDrawElementsInstancedNV));
			}
			if (SuportedExt.Contains("glDrawMeshArraysSUN"))
			{
				dgtk.OpenGL.internalGL.glDrawMeshArraysSUN = (dgtk.OpenGL.delegatesGL.glDrawMeshArraysSUN) InternalTool.GetGLMethodAdress("glDrawMeshArraysSUN", typeof(dgtk.OpenGL.delegatesGL.glDrawMeshArraysSUN));
			}
			if (SuportedExt.Contains("glDrawMeshTasksIndirectNV"))
			{
				dgtk.OpenGL.internalGL.glDrawMeshTasksIndirectNV = (dgtk.OpenGL.delegatesGL.glDrawMeshTasksIndirectNV) InternalTool.GetGLMethodAdress("glDrawMeshTasksIndirectNV", typeof(dgtk.OpenGL.delegatesGL.glDrawMeshTasksIndirectNV));
			}
			if (SuportedExt.Contains("glDrawMeshTasksNV"))
			{
				dgtk.OpenGL.internalGL.glDrawMeshTasksNV = (dgtk.OpenGL.delegatesGL.glDrawMeshTasksNV) InternalTool.GetGLMethodAdress("glDrawMeshTasksNV", typeof(dgtk.OpenGL.delegatesGL.glDrawMeshTasksNV));
			}
			if (SuportedExt.Contains("glDrawRangeElementArrayAPPLE"))
			{
				dgtk.OpenGL.internalGL.glDrawRangeElementArrayAPPLE = (dgtk.OpenGL.delegatesGL.glDrawRangeElementArrayAPPLE) InternalTool.GetGLMethodAdress("glDrawRangeElementArrayAPPLE", typeof(dgtk.OpenGL.delegatesGL.glDrawRangeElementArrayAPPLE));
			}
			if (SuportedExt.Contains("glDrawRangeElementArrayATI"))
			{
				dgtk.OpenGL.internalGL.glDrawRangeElementArrayATI = (dgtk.OpenGL.delegatesGL.glDrawRangeElementArrayATI) InternalTool.GetGLMethodAdress("glDrawRangeElementArrayATI", typeof(dgtk.OpenGL.delegatesGL.glDrawRangeElementArrayATI));
			}
			if (SuportedExt.Contains("glDrawRangeElementsBaseVertexEXT"))
			{
				dgtk.OpenGL.internalGL.glDrawRangeElementsBaseVertexEXT = (dgtk.OpenGL.delegatesGL.glDrawRangeElementsBaseVertexEXT) InternalTool.GetGLMethodAdress("glDrawRangeElementsBaseVertexEXT", typeof(dgtk.OpenGL.delegatesGL.glDrawRangeElementsBaseVertexEXT));
			}
			if (SuportedExt.Contains("glDrawRangeElementsBaseVertexOES"))
			{
				dgtk.OpenGL.internalGL.glDrawRangeElementsBaseVertexOES = (dgtk.OpenGL.delegatesGL.glDrawRangeElementsBaseVertexOES) InternalTool.GetGLMethodAdress("glDrawRangeElementsBaseVertexOES", typeof(dgtk.OpenGL.delegatesGL.glDrawRangeElementsBaseVertexOES));
			}
			if (SuportedExt.Contains("glDrawRangeElementsEXT"))
			{
				dgtk.OpenGL.internalGL.glDrawRangeElementsEXT = (dgtk.OpenGL.delegatesGL.glDrawRangeElementsEXT) InternalTool.GetGLMethodAdress("glDrawRangeElementsEXT", typeof(dgtk.OpenGL.delegatesGL.glDrawRangeElementsEXT));
			}
			if (SuportedExt.Contains("glDrawTexfOES"))
			{
				dgtk.OpenGL.internalGL.glDrawTexfOES = (dgtk.OpenGL.delegatesGL.glDrawTexfOES) InternalTool.GetGLMethodAdress("glDrawTexfOES", typeof(dgtk.OpenGL.delegatesGL.glDrawTexfOES));
			}
			if (SuportedExt.Contains("glDrawTexfvOES"))
			{
				dgtk.OpenGL.internalGL.glDrawTexfvOES = (dgtk.OpenGL.delegatesGL.glDrawTexfvOES) InternalTool.GetGLMethodAdress("glDrawTexfvOES", typeof(dgtk.OpenGL.delegatesGL.glDrawTexfvOES));
			}
			if (SuportedExt.Contains("glDrawTexiOES"))
			{
				dgtk.OpenGL.internalGL.glDrawTexiOES = (dgtk.OpenGL.delegatesGL.glDrawTexiOES) InternalTool.GetGLMethodAdress("glDrawTexiOES", typeof(dgtk.OpenGL.delegatesGL.glDrawTexiOES));
			}
			if (SuportedExt.Contains("glDrawTexivOES"))
			{
				dgtk.OpenGL.internalGL.glDrawTexivOES = (dgtk.OpenGL.delegatesGL.glDrawTexivOES) InternalTool.GetGLMethodAdress("glDrawTexivOES", typeof(dgtk.OpenGL.delegatesGL.glDrawTexivOES));
			}
			if (SuportedExt.Contains("glDrawTexsOES"))
			{
				dgtk.OpenGL.internalGL.glDrawTexsOES = (dgtk.OpenGL.delegatesGL.glDrawTexsOES) InternalTool.GetGLMethodAdress("glDrawTexsOES", typeof(dgtk.OpenGL.delegatesGL.glDrawTexsOES));
			}
			if (SuportedExt.Contains("glDrawTexsvOES"))
			{
				dgtk.OpenGL.internalGL.glDrawTexsvOES = (dgtk.OpenGL.delegatesGL.glDrawTexsvOES) InternalTool.GetGLMethodAdress("glDrawTexsvOES", typeof(dgtk.OpenGL.delegatesGL.glDrawTexsvOES));
			}
			if (SuportedExt.Contains("glDrawTextureNV"))
			{
				dgtk.OpenGL.internalGL.glDrawTextureNV = (dgtk.OpenGL.delegatesGL.glDrawTextureNV) InternalTool.GetGLMethodAdress("glDrawTextureNV", typeof(dgtk.OpenGL.delegatesGL.glDrawTextureNV));
			}
			if (SuportedExt.Contains("glDrawTexxOES"))
			{
				dgtk.OpenGL.internalGL.glDrawTexxOES = (dgtk.OpenGL.delegatesGL.glDrawTexxOES) InternalTool.GetGLMethodAdress("glDrawTexxOES", typeof(dgtk.OpenGL.delegatesGL.glDrawTexxOES));
			}
			if (SuportedExt.Contains("glDrawTexxvOES"))
			{
				dgtk.OpenGL.internalGL.glDrawTexxvOES = (dgtk.OpenGL.delegatesGL.glDrawTexxvOES) InternalTool.GetGLMethodAdress("glDrawTexxvOES", typeof(dgtk.OpenGL.delegatesGL.glDrawTexxvOES));
			}
			if (SuportedExt.Contains("glDrawTransformFeedbackEXT"))
			{
				dgtk.OpenGL.internalGL.glDrawTransformFeedbackEXT = (dgtk.OpenGL.delegatesGL.glDrawTransformFeedbackEXT) InternalTool.GetGLMethodAdress("glDrawTransformFeedbackEXT", typeof(dgtk.OpenGL.delegatesGL.glDrawTransformFeedbackEXT));
			}
			if (SuportedExt.Contains("glDrawTransformFeedbackInstancedEXT"))
			{
				dgtk.OpenGL.internalGL.glDrawTransformFeedbackInstancedEXT = (dgtk.OpenGL.delegatesGL.glDrawTransformFeedbackInstancedEXT) InternalTool.GetGLMethodAdress("glDrawTransformFeedbackInstancedEXT", typeof(dgtk.OpenGL.delegatesGL.glDrawTransformFeedbackInstancedEXT));
			}
			if (SuportedExt.Contains("glDrawTransformFeedbackNV"))
			{
				dgtk.OpenGL.internalGL.glDrawTransformFeedbackNV = (dgtk.OpenGL.delegatesGL.glDrawTransformFeedbackNV) InternalTool.GetGLMethodAdress("glDrawTransformFeedbackNV", typeof(dgtk.OpenGL.delegatesGL.glDrawTransformFeedbackNV));
			}
			if (SuportedExt.Contains("glDrawVkImageNV"))
			{
				dgtk.OpenGL.internalGL.glDrawVkImageNV = (dgtk.OpenGL.delegatesGL.glDrawVkImageNV) InternalTool.GetGLMethodAdress("glDrawVkImageNV", typeof(dgtk.OpenGL.delegatesGL.glDrawVkImageNV));
			}
			#endregion

			#region E:

			if (SuportedExt.Contains("glEdgeFlagFormatNV"))
			{
				dgtk.OpenGL.internalGL.glEdgeFlagFormatNV = (dgtk.OpenGL.delegatesGL.glEdgeFlagFormatNV) InternalTool.GetGLMethodAdress("glEdgeFlagFormatNV", typeof(dgtk.OpenGL.delegatesGL.glEdgeFlagFormatNV));
			}
			if (SuportedExt.Contains("glEdgeFlagPointerEXT"))
			{
				dgtk.OpenGL.internalGL.glEdgeFlagPointerEXT = (dgtk.OpenGL.delegatesGL.glEdgeFlagPointerEXT) InternalTool.GetGLMethodAdress("glEdgeFlagPointerEXT", typeof(dgtk.OpenGL.delegatesGL.glEdgeFlagPointerEXT));
			}
			if (SuportedExt.Contains("glEdgeFlagPointerListIBM"))
			{
				dgtk.OpenGL.internalGL.glEdgeFlagPointerListIBM = (dgtk.OpenGL.delegatesGL.glEdgeFlagPointerListIBM) InternalTool.GetGLMethodAdress("glEdgeFlagPointerListIBM", typeof(dgtk.OpenGL.delegatesGL.glEdgeFlagPointerListIBM));
			}
			if (SuportedExt.Contains("glEGLImageTargetRenderbufferStorageOES"))
			{
				dgtk.OpenGL.internalGL.glEGLImageTargetRenderbufferStorageOES = (dgtk.OpenGL.delegatesGL.glEGLImageTargetRenderbufferStorageOES) InternalTool.GetGLMethodAdress("glEGLImageTargetRenderbufferStorageOES", typeof(dgtk.OpenGL.delegatesGL.glEGLImageTargetRenderbufferStorageOES));
			}
			if (SuportedExt.Contains("glEGLImageTargetTexStorageEXT"))
			{
				dgtk.OpenGL.internalGL.glEGLImageTargetTexStorageEXT = (dgtk.OpenGL.delegatesGL.glEGLImageTargetTexStorageEXT) InternalTool.GetGLMethodAdress("glEGLImageTargetTexStorageEXT", typeof(dgtk.OpenGL.delegatesGL.glEGLImageTargetTexStorageEXT));
			}
			if (SuportedExt.Contains("glEGLImageTargetTexture2DOES"))
			{
				dgtk.OpenGL.internalGL.glEGLImageTargetTexture2DOES = (dgtk.OpenGL.delegatesGL.glEGLImageTargetTexture2DOES) InternalTool.GetGLMethodAdress("glEGLImageTargetTexture2DOES", typeof(dgtk.OpenGL.delegatesGL.glEGLImageTargetTexture2DOES));
			}
			if (SuportedExt.Contains("glEGLImageTargetTextureStorageEXT"))
			{
				dgtk.OpenGL.internalGL.glEGLImageTargetTextureStorageEXT = (dgtk.OpenGL.delegatesGL.glEGLImageTargetTextureStorageEXT) InternalTool.GetGLMethodAdress("glEGLImageTargetTextureStorageEXT", typeof(dgtk.OpenGL.delegatesGL.glEGLImageTargetTextureStorageEXT));
			}
			if (SuportedExt.Contains("glElementPointerAPPLE"))
			{
				dgtk.OpenGL.internalGL.glElementPointerAPPLE = (dgtk.OpenGL.delegatesGL.glElementPointerAPPLE) InternalTool.GetGLMethodAdress("glElementPointerAPPLE", typeof(dgtk.OpenGL.delegatesGL.glElementPointerAPPLE));
			}
			if (SuportedExt.Contains("glElementPointerATI"))
			{
				dgtk.OpenGL.internalGL.glElementPointerATI = (dgtk.OpenGL.delegatesGL.glElementPointerATI) InternalTool.GetGLMethodAdress("glElementPointerATI", typeof(dgtk.OpenGL.delegatesGL.glElementPointerATI));
			}
			if (SuportedExt.Contains("glEnableClientStateiEXT"))
			{
				dgtk.OpenGL.internalGL.glEnableClientStateiEXT = (dgtk.OpenGL.delegatesGL.glEnableClientStateiEXT) InternalTool.GetGLMethodAdress("glEnableClientStateiEXT", typeof(dgtk.OpenGL.delegatesGL.glEnableClientStateiEXT));
			}
			if (SuportedExt.Contains("glEnableClientStateIndexedEXT"))
			{
				dgtk.OpenGL.internalGL.glEnableClientStateIndexedEXT = (dgtk.OpenGL.delegatesGL.glEnableClientStateIndexedEXT) InternalTool.GetGLMethodAdress("glEnableClientStateIndexedEXT", typeof(dgtk.OpenGL.delegatesGL.glEnableClientStateIndexedEXT));
			}
			if (SuportedExt.Contains("glEnableDriverControlQCOM"))
			{
				dgtk.OpenGL.internalGL.glEnableDriverControlQCOM = (dgtk.OpenGL.delegatesGL.glEnableDriverControlQCOM) InternalTool.GetGLMethodAdress("glEnableDriverControlQCOM", typeof(dgtk.OpenGL.delegatesGL.glEnableDriverControlQCOM));
			}
			if (SuportedExt.Contains("glEnableiEXT"))
			{
				dgtk.OpenGL.internalGL.glEnableiEXT = (dgtk.OpenGL.delegatesGL.glEnableiEXT) InternalTool.GetGLMethodAdress("glEnableiEXT", typeof(dgtk.OpenGL.delegatesGL.glEnableiEXT));
			}
			if (SuportedExt.Contains("glEnableIndexedEXT"))
			{
				dgtk.OpenGL.internalGL.glEnableIndexedEXT = (dgtk.OpenGL.delegatesGL.glEnableIndexedEXT) InternalTool.GetGLMethodAdress("glEnableIndexedEXT", typeof(dgtk.OpenGL.delegatesGL.glEnableIndexedEXT));
			}
			if (SuportedExt.Contains("glEnableiNV"))
			{
				dgtk.OpenGL.internalGL.glEnableiNV = (dgtk.OpenGL.delegatesGL.glEnableiNV) InternalTool.GetGLMethodAdress("glEnableiNV", typeof(dgtk.OpenGL.delegatesGL.glEnableiNV));
			}
			if (SuportedExt.Contains("glEnableiOES"))
			{
				dgtk.OpenGL.internalGL.glEnableiOES = (dgtk.OpenGL.delegatesGL.glEnableiOES) InternalTool.GetGLMethodAdress("glEnableiOES", typeof(dgtk.OpenGL.delegatesGL.glEnableiOES));
			}
			if (SuportedExt.Contains("glEnableVariantClientStateEXT"))
			{
				dgtk.OpenGL.internalGL.glEnableVariantClientStateEXT = (dgtk.OpenGL.delegatesGL.glEnableVariantClientStateEXT) InternalTool.GetGLMethodAdress("glEnableVariantClientStateEXT", typeof(dgtk.OpenGL.delegatesGL.glEnableVariantClientStateEXT));
			}
			if (SuportedExt.Contains("glEnableVertexArrayAttribEXT"))
			{
				dgtk.OpenGL.internalGL.glEnableVertexArrayAttribEXT = (dgtk.OpenGL.delegatesGL.glEnableVertexArrayAttribEXT) InternalTool.GetGLMethodAdress("glEnableVertexArrayAttribEXT", typeof(dgtk.OpenGL.delegatesGL.glEnableVertexArrayAttribEXT));
			}
			if (SuportedExt.Contains("glEnableVertexArrayEXT"))
			{
				dgtk.OpenGL.internalGL.glEnableVertexArrayEXT = (dgtk.OpenGL.delegatesGL.glEnableVertexArrayEXT) InternalTool.GetGLMethodAdress("glEnableVertexArrayEXT", typeof(dgtk.OpenGL.delegatesGL.glEnableVertexArrayEXT));
			}
			if (SuportedExt.Contains("glEnableVertexAttribAPPLE"))
			{
				dgtk.OpenGL.internalGL.glEnableVertexAttribAPPLE = (dgtk.OpenGL.delegatesGL.glEnableVertexAttribAPPLE) InternalTool.GetGLMethodAdress("glEnableVertexAttribAPPLE", typeof(dgtk.OpenGL.delegatesGL.glEnableVertexAttribAPPLE));
			}
			if (SuportedExt.Contains("glEnableVertexAttribArrayARB"))
			{
				dgtk.OpenGL.internalGL.glEnableVertexAttribArrayARB = (dgtk.OpenGL.delegatesGL.glEnableVertexAttribArrayARB) InternalTool.GetGLMethodAdress("glEnableVertexAttribArrayARB", typeof(dgtk.OpenGL.delegatesGL.glEnableVertexAttribArrayARB));
			}
			if (SuportedExt.Contains("glEndConditionalRenderNV"))
			{
				dgtk.OpenGL.internalGL.glEndConditionalRenderNV = (dgtk.OpenGL.delegatesGL.glEndConditionalRenderNV) InternalTool.GetGLMethodAdress("glEndConditionalRenderNV", typeof(dgtk.OpenGL.delegatesGL.glEndConditionalRenderNV));
			}
			if (SuportedExt.Contains("glEndConditionalRenderNVX"))
			{
				dgtk.OpenGL.internalGL.glEndConditionalRenderNVX = (dgtk.OpenGL.delegatesGL.glEndConditionalRenderNVX) InternalTool.GetGLMethodAdress("glEndConditionalRenderNVX", typeof(dgtk.OpenGL.delegatesGL.glEndConditionalRenderNVX));
			}
			if (SuportedExt.Contains("glEndFragmentShaderATI"))
			{
				dgtk.OpenGL.internalGL.glEndFragmentShaderATI = (dgtk.OpenGL.delegatesGL.glEndFragmentShaderATI) InternalTool.GetGLMethodAdress("glEndFragmentShaderATI", typeof(dgtk.OpenGL.delegatesGL.glEndFragmentShaderATI));
			}
			if (SuportedExt.Contains("glEndOcclusionQueryNV"))
			{
				dgtk.OpenGL.internalGL.glEndOcclusionQueryNV = (dgtk.OpenGL.delegatesGL.glEndOcclusionQueryNV) InternalTool.GetGLMethodAdress("glEndOcclusionQueryNV", typeof(dgtk.OpenGL.delegatesGL.glEndOcclusionQueryNV));
			}
			if (SuportedExt.Contains("glEndPerfMonitorAMD"))
			{
				dgtk.OpenGL.internalGL.glEndPerfMonitorAMD = (dgtk.OpenGL.delegatesGL.glEndPerfMonitorAMD) InternalTool.GetGLMethodAdress("glEndPerfMonitorAMD", typeof(dgtk.OpenGL.delegatesGL.glEndPerfMonitorAMD));
			}
			if (SuportedExt.Contains("glEndPerfQueryINTEL"))
			{
				dgtk.OpenGL.internalGL.glEndPerfQueryINTEL = (dgtk.OpenGL.delegatesGL.glEndPerfQueryINTEL) InternalTool.GetGLMethodAdress("glEndPerfQueryINTEL", typeof(dgtk.OpenGL.delegatesGL.glEndPerfQueryINTEL));
			}
			if (SuportedExt.Contains("glEndQueryARB"))
			{
				dgtk.OpenGL.internalGL.glEndQueryARB = (dgtk.OpenGL.delegatesGL.glEndQueryARB) InternalTool.GetGLMethodAdress("glEndQueryARB", typeof(dgtk.OpenGL.delegatesGL.glEndQueryARB));
			}
			if (SuportedExt.Contains("glEndQueryEXT"))
			{
				dgtk.OpenGL.internalGL.glEndQueryEXT = (dgtk.OpenGL.delegatesGL.glEndQueryEXT) InternalTool.GetGLMethodAdress("glEndQueryEXT", typeof(dgtk.OpenGL.delegatesGL.glEndQueryEXT));
			}
			if (SuportedExt.Contains("glEndTilingQCOM"))
			{
				dgtk.OpenGL.internalGL.glEndTilingQCOM = (dgtk.OpenGL.delegatesGL.glEndTilingQCOM) InternalTool.GetGLMethodAdress("glEndTilingQCOM", typeof(dgtk.OpenGL.delegatesGL.glEndTilingQCOM));
			}
			if (SuportedExt.Contains("glEndTransformFeedbackEXT"))
			{
				dgtk.OpenGL.internalGL.glEndTransformFeedbackEXT = (dgtk.OpenGL.delegatesGL.glEndTransformFeedbackEXT) InternalTool.GetGLMethodAdress("glEndTransformFeedbackEXT", typeof(dgtk.OpenGL.delegatesGL.glEndTransformFeedbackEXT));
			}
			if (SuportedExt.Contains("glEndTransformFeedbackNV"))
			{
				dgtk.OpenGL.internalGL.glEndTransformFeedbackNV = (dgtk.OpenGL.delegatesGL.glEndTransformFeedbackNV) InternalTool.GetGLMethodAdress("glEndTransformFeedbackNV", typeof(dgtk.OpenGL.delegatesGL.glEndTransformFeedbackNV));
			}
			if (SuportedExt.Contains("glEndVertexShaderEXT"))
			{
				dgtk.OpenGL.internalGL.glEndVertexShaderEXT = (dgtk.OpenGL.delegatesGL.glEndVertexShaderEXT) InternalTool.GetGLMethodAdress("glEndVertexShaderEXT", typeof(dgtk.OpenGL.delegatesGL.glEndVertexShaderEXT));
			}
			if (SuportedExt.Contains("glEndVideoCaptureNV"))
			{
				dgtk.OpenGL.internalGL.glEndVideoCaptureNV = (dgtk.OpenGL.delegatesGL.glEndVideoCaptureNV) InternalTool.GetGLMethodAdress("glEndVideoCaptureNV", typeof(dgtk.OpenGL.delegatesGL.glEndVideoCaptureNV));
			}
			if (SuportedExt.Contains("glEvalCoord1xOES"))
			{
				dgtk.OpenGL.internalGL.glEvalCoord1xOES = (dgtk.OpenGL.delegatesGL.glEvalCoord1xOES) InternalTool.GetGLMethodAdress("glEvalCoord1xOES", typeof(dgtk.OpenGL.delegatesGL.glEvalCoord1xOES));
			}
			if (SuportedExt.Contains("glEvalCoord1xvOES"))
			{
				dgtk.OpenGL.internalGL.glEvalCoord1xvOES = (dgtk.OpenGL.delegatesGL.glEvalCoord1xvOES) InternalTool.GetGLMethodAdress("glEvalCoord1xvOES", typeof(dgtk.OpenGL.delegatesGL.glEvalCoord1xvOES));
			}
			if (SuportedExt.Contains("glEvalCoord2xOES"))
			{
				dgtk.OpenGL.internalGL.glEvalCoord2xOES = (dgtk.OpenGL.delegatesGL.glEvalCoord2xOES) InternalTool.GetGLMethodAdress("glEvalCoord2xOES", typeof(dgtk.OpenGL.delegatesGL.glEvalCoord2xOES));
			}
			if (SuportedExt.Contains("glEvalCoord2xvOES"))
			{
				dgtk.OpenGL.internalGL.glEvalCoord2xvOES = (dgtk.OpenGL.delegatesGL.glEvalCoord2xvOES) InternalTool.GetGLMethodAdress("glEvalCoord2xvOES", typeof(dgtk.OpenGL.delegatesGL.glEvalCoord2xvOES));
			}
			if (SuportedExt.Contains("glEvalMapsNV"))
			{
				dgtk.OpenGL.internalGL.glEvalMapsNV = (dgtk.OpenGL.delegatesGL.glEvalMapsNV) InternalTool.GetGLMethodAdress("glEvalMapsNV", typeof(dgtk.OpenGL.delegatesGL.glEvalMapsNV));
			}
			if (SuportedExt.Contains("glEvaluateDepthValuesARB"))
			{
				dgtk.OpenGL.internalGL.glEvaluateDepthValuesARB = (dgtk.OpenGL.delegatesGL.glEvaluateDepthValuesARB) InternalTool.GetGLMethodAdress("glEvaluateDepthValuesARB", typeof(dgtk.OpenGL.delegatesGL.glEvaluateDepthValuesARB));
			}
			if (SuportedExt.Contains("glExecuteProgramNV"))
			{
				dgtk.OpenGL.internalGL.glExecuteProgramNV = (dgtk.OpenGL.delegatesGL.glExecuteProgramNV) InternalTool.GetGLMethodAdress("glExecuteProgramNV", typeof(dgtk.OpenGL.delegatesGL.glExecuteProgramNV));
			}
			if (SuportedExt.Contains("glExtGetBufferPointervQCOM"))
			{
				dgtk.OpenGL.internalGL.glExtGetBufferPointervQCOM = (dgtk.OpenGL.delegatesGL.glExtGetBufferPointervQCOM) InternalTool.GetGLMethodAdress("glExtGetBufferPointervQCOM", typeof(dgtk.OpenGL.delegatesGL.glExtGetBufferPointervQCOM));
			}
			if (SuportedExt.Contains("glExtGetBuffersQCOM"))
			{
				dgtk.OpenGL.internalGL.glExtGetBuffersQCOM = (dgtk.OpenGL.delegatesGL.glExtGetBuffersQCOM) InternalTool.GetGLMethodAdress("glExtGetBuffersQCOM", typeof(dgtk.OpenGL.delegatesGL.glExtGetBuffersQCOM));
			}
			if (SuportedExt.Contains("glExtGetFramebuffersQCOM"))
			{
				dgtk.OpenGL.internalGL.glExtGetFramebuffersQCOM = (dgtk.OpenGL.delegatesGL.glExtGetFramebuffersQCOM) InternalTool.GetGLMethodAdress("glExtGetFramebuffersQCOM", typeof(dgtk.OpenGL.delegatesGL.glExtGetFramebuffersQCOM));
			}
			if (SuportedExt.Contains("glExtGetProgramBinarySourceQCOM"))
			{
				dgtk.OpenGL.internalGL.glExtGetProgramBinarySourceQCOM = (dgtk.OpenGL.delegatesGL.glExtGetProgramBinarySourceQCOM) InternalTool.GetGLMethodAdress("glExtGetProgramBinarySourceQCOM", typeof(dgtk.OpenGL.delegatesGL.glExtGetProgramBinarySourceQCOM));
			}
			if (SuportedExt.Contains("glExtGetProgramsQCOM"))
			{
				dgtk.OpenGL.internalGL.glExtGetProgramsQCOM = (dgtk.OpenGL.delegatesGL.glExtGetProgramsQCOM) InternalTool.GetGLMethodAdress("glExtGetProgramsQCOM", typeof(dgtk.OpenGL.delegatesGL.glExtGetProgramsQCOM));
			}
			if (SuportedExt.Contains("glExtGetRenderbuffersQCOM"))
			{
				dgtk.OpenGL.internalGL.glExtGetRenderbuffersQCOM = (dgtk.OpenGL.delegatesGL.glExtGetRenderbuffersQCOM) InternalTool.GetGLMethodAdress("glExtGetRenderbuffersQCOM", typeof(dgtk.OpenGL.delegatesGL.glExtGetRenderbuffersQCOM));
			}
			if (SuportedExt.Contains("glExtGetShadersQCOM"))
			{
				dgtk.OpenGL.internalGL.glExtGetShadersQCOM = (dgtk.OpenGL.delegatesGL.glExtGetShadersQCOM) InternalTool.GetGLMethodAdress("glExtGetShadersQCOM", typeof(dgtk.OpenGL.delegatesGL.glExtGetShadersQCOM));
			}
			if (SuportedExt.Contains("glExtGetTexLevelParameterivQCOM"))
			{
				dgtk.OpenGL.internalGL.glExtGetTexLevelParameterivQCOM = (dgtk.OpenGL.delegatesGL.glExtGetTexLevelParameterivQCOM) InternalTool.GetGLMethodAdress("glExtGetTexLevelParameterivQCOM", typeof(dgtk.OpenGL.delegatesGL.glExtGetTexLevelParameterivQCOM));
			}
			if (SuportedExt.Contains("glExtGetTexSubImageQCOM"))
			{
				dgtk.OpenGL.internalGL.glExtGetTexSubImageQCOM = (dgtk.OpenGL.delegatesGL.glExtGetTexSubImageQCOM) InternalTool.GetGLMethodAdress("glExtGetTexSubImageQCOM", typeof(dgtk.OpenGL.delegatesGL.glExtGetTexSubImageQCOM));
			}
			if (SuportedExt.Contains("glExtGetTexturesQCOM"))
			{
				dgtk.OpenGL.internalGL.glExtGetTexturesQCOM = (dgtk.OpenGL.delegatesGL.glExtGetTexturesQCOM) InternalTool.GetGLMethodAdress("glExtGetTexturesQCOM", typeof(dgtk.OpenGL.delegatesGL.glExtGetTexturesQCOM));
			}
			if (SuportedExt.Contains("glExtIsProgramBinaryQCOM"))
			{
				dgtk.OpenGL.internalGL.glExtIsProgramBinaryQCOM = (dgtk.OpenGL.delegatesGL.glExtIsProgramBinaryQCOM) InternalTool.GetGLMethodAdress("glExtIsProgramBinaryQCOM", typeof(dgtk.OpenGL.delegatesGL.glExtIsProgramBinaryQCOM));
			}
			if (SuportedExt.Contains("glExtractComponentEXT"))
			{
				dgtk.OpenGL.internalGL.glExtractComponentEXT = (dgtk.OpenGL.delegatesGL.glExtractComponentEXT) InternalTool.GetGLMethodAdress("glExtractComponentEXT", typeof(dgtk.OpenGL.delegatesGL.glExtractComponentEXT));
			}
			if (SuportedExt.Contains("glExtTexObjectStateOverrideiQCOM"))
			{
				dgtk.OpenGL.internalGL.glExtTexObjectStateOverrideiQCOM = (dgtk.OpenGL.delegatesGL.glExtTexObjectStateOverrideiQCOM) InternalTool.GetGLMethodAdress("glExtTexObjectStateOverrideiQCOM", typeof(dgtk.OpenGL.delegatesGL.glExtTexObjectStateOverrideiQCOM));
			}
			#endregion

			#region F:

			if (SuportedExt.Contains("glFeedbackBufferxOES"))
			{
				dgtk.OpenGL.internalGL.glFeedbackBufferxOES = (dgtk.OpenGL.delegatesGL.glFeedbackBufferxOES) InternalTool.GetGLMethodAdress("glFeedbackBufferxOES", typeof(dgtk.OpenGL.delegatesGL.glFeedbackBufferxOES));
			}
			if (SuportedExt.Contains("glFenceSyncAPPLE"))
			{
				dgtk.OpenGL.internalGL.glFenceSyncAPPLE = (dgtk.OpenGL.delegatesGL.glFenceSyncAPPLE) InternalTool.GetGLMethodAdress("glFenceSyncAPPLE", typeof(dgtk.OpenGL.delegatesGL.glFenceSyncAPPLE));
			}
			if (SuportedExt.Contains("glFinalCombinerInputNV"))
			{
				dgtk.OpenGL.internalGL.glFinalCombinerInputNV = (dgtk.OpenGL.delegatesGL.glFinalCombinerInputNV) InternalTool.GetGLMethodAdress("glFinalCombinerInputNV", typeof(dgtk.OpenGL.delegatesGL.glFinalCombinerInputNV));
			}
			if (SuportedExt.Contains("glFinishAsyncSGIX"))
			{
				dgtk.OpenGL.internalGL.glFinishAsyncSGIX = (dgtk.OpenGL.delegatesGL.glFinishAsyncSGIX) InternalTool.GetGLMethodAdress("glFinishAsyncSGIX", typeof(dgtk.OpenGL.delegatesGL.glFinishAsyncSGIX));
			}
			if (SuportedExt.Contains("glFinishFenceAPPLE"))
			{
				dgtk.OpenGL.internalGL.glFinishFenceAPPLE = (dgtk.OpenGL.delegatesGL.glFinishFenceAPPLE) InternalTool.GetGLMethodAdress("glFinishFenceAPPLE", typeof(dgtk.OpenGL.delegatesGL.glFinishFenceAPPLE));
			}
			if (SuportedExt.Contains("glFinishFenceNV"))
			{
				dgtk.OpenGL.internalGL.glFinishFenceNV = (dgtk.OpenGL.delegatesGL.glFinishFenceNV) InternalTool.GetGLMethodAdress("glFinishFenceNV", typeof(dgtk.OpenGL.delegatesGL.glFinishFenceNV));
			}
			if (SuportedExt.Contains("glFinishObjectAPPLE"))
			{
				dgtk.OpenGL.internalGL.glFinishObjectAPPLE = (dgtk.OpenGL.delegatesGL.glFinishObjectAPPLE) InternalTool.GetGLMethodAdress("glFinishObjectAPPLE", typeof(dgtk.OpenGL.delegatesGL.glFinishObjectAPPLE));
			}
			if (SuportedExt.Contains("glFinishTextureSUNX"))
			{
				dgtk.OpenGL.internalGL.glFinishTextureSUNX = (dgtk.OpenGL.delegatesGL.glFinishTextureSUNX) InternalTool.GetGLMethodAdress("glFinishTextureSUNX", typeof(dgtk.OpenGL.delegatesGL.glFinishTextureSUNX));
			}
			if (SuportedExt.Contains("glFlushMappedBufferRangeAPPLE"))
			{
				dgtk.OpenGL.internalGL.glFlushMappedBufferRangeAPPLE = (dgtk.OpenGL.delegatesGL.glFlushMappedBufferRangeAPPLE) InternalTool.GetGLMethodAdress("glFlushMappedBufferRangeAPPLE", typeof(dgtk.OpenGL.delegatesGL.glFlushMappedBufferRangeAPPLE));
			}
			if (SuportedExt.Contains("glFlushMappedBufferRangeEXT"))
			{
				dgtk.OpenGL.internalGL.glFlushMappedBufferRangeEXT = (dgtk.OpenGL.delegatesGL.glFlushMappedBufferRangeEXT) InternalTool.GetGLMethodAdress("glFlushMappedBufferRangeEXT", typeof(dgtk.OpenGL.delegatesGL.glFlushMappedBufferRangeEXT));
			}
			if (SuportedExt.Contains("glFlushMappedNamedBufferRangeEXT"))
			{
				dgtk.OpenGL.internalGL.glFlushMappedNamedBufferRangeEXT = (dgtk.OpenGL.delegatesGL.glFlushMappedNamedBufferRangeEXT) InternalTool.GetGLMethodAdress("glFlushMappedNamedBufferRangeEXT", typeof(dgtk.OpenGL.delegatesGL.glFlushMappedNamedBufferRangeEXT));
			}
			if (SuportedExt.Contains("glFlushPixelDataRangeNV"))
			{
				dgtk.OpenGL.internalGL.glFlushPixelDataRangeNV = (dgtk.OpenGL.delegatesGL.glFlushPixelDataRangeNV) InternalTool.GetGLMethodAdress("glFlushPixelDataRangeNV", typeof(dgtk.OpenGL.delegatesGL.glFlushPixelDataRangeNV));
			}
			if (SuportedExt.Contains("glFlushRasterSGIX"))
			{
				dgtk.OpenGL.internalGL.glFlushRasterSGIX = (dgtk.OpenGL.delegatesGL.glFlushRasterSGIX) InternalTool.GetGLMethodAdress("glFlushRasterSGIX", typeof(dgtk.OpenGL.delegatesGL.glFlushRasterSGIX));
			}
			if (SuportedExt.Contains("glFlushStaticDataIBM"))
			{
				dgtk.OpenGL.internalGL.glFlushStaticDataIBM = (dgtk.OpenGL.delegatesGL.glFlushStaticDataIBM) InternalTool.GetGLMethodAdress("glFlushStaticDataIBM", typeof(dgtk.OpenGL.delegatesGL.glFlushStaticDataIBM));
			}
			if (SuportedExt.Contains("glFlushVertexArrayRangeAPPLE"))
			{
				dgtk.OpenGL.internalGL.glFlushVertexArrayRangeAPPLE = (dgtk.OpenGL.delegatesGL.glFlushVertexArrayRangeAPPLE) InternalTool.GetGLMethodAdress("glFlushVertexArrayRangeAPPLE", typeof(dgtk.OpenGL.delegatesGL.glFlushVertexArrayRangeAPPLE));
			}
			if (SuportedExt.Contains("glFlushVertexArrayRangeNV"))
			{
				dgtk.OpenGL.internalGL.glFlushVertexArrayRangeNV = (dgtk.OpenGL.delegatesGL.glFlushVertexArrayRangeNV) InternalTool.GetGLMethodAdress("glFlushVertexArrayRangeNV", typeof(dgtk.OpenGL.delegatesGL.glFlushVertexArrayRangeNV));
			}
			if (SuportedExt.Contains("glFogCoorddEXT"))
			{
				dgtk.OpenGL.internalGL.glFogCoorddEXT = (dgtk.OpenGL.delegatesGL.glFogCoorddEXT) InternalTool.GetGLMethodAdress("glFogCoorddEXT", typeof(dgtk.OpenGL.delegatesGL.glFogCoorddEXT));
			}
			if (SuportedExt.Contains("glFogCoorddvEXT"))
			{
				dgtk.OpenGL.internalGL.glFogCoorddvEXT = (dgtk.OpenGL.delegatesGL.glFogCoorddvEXT) InternalTool.GetGLMethodAdress("glFogCoorddvEXT", typeof(dgtk.OpenGL.delegatesGL.glFogCoorddvEXT));
			}
			if (SuportedExt.Contains("glFogCoordfEXT"))
			{
				dgtk.OpenGL.internalGL.glFogCoordfEXT = (dgtk.OpenGL.delegatesGL.glFogCoordfEXT) InternalTool.GetGLMethodAdress("glFogCoordfEXT", typeof(dgtk.OpenGL.delegatesGL.glFogCoordfEXT));
			}
			if (SuportedExt.Contains("glFogCoordFormatNV"))
			{
				dgtk.OpenGL.internalGL.glFogCoordFormatNV = (dgtk.OpenGL.delegatesGL.glFogCoordFormatNV) InternalTool.GetGLMethodAdress("glFogCoordFormatNV", typeof(dgtk.OpenGL.delegatesGL.glFogCoordFormatNV));
			}
			if (SuportedExt.Contains("glFogCoordfvEXT"))
			{
				dgtk.OpenGL.internalGL.glFogCoordfvEXT = (dgtk.OpenGL.delegatesGL.glFogCoordfvEXT) InternalTool.GetGLMethodAdress("glFogCoordfvEXT", typeof(dgtk.OpenGL.delegatesGL.glFogCoordfvEXT));
			}
			if (SuportedExt.Contains("glFogCoordhNV"))
			{
				dgtk.OpenGL.internalGL.glFogCoordhNV = (dgtk.OpenGL.delegatesGL.glFogCoordhNV) InternalTool.GetGLMethodAdress("glFogCoordhNV", typeof(dgtk.OpenGL.delegatesGL.glFogCoordhNV));
			}
			if (SuportedExt.Contains("glFogCoordhvNV"))
			{
				dgtk.OpenGL.internalGL.glFogCoordhvNV = (dgtk.OpenGL.delegatesGL.glFogCoordhvNV) InternalTool.GetGLMethodAdress("glFogCoordhvNV", typeof(dgtk.OpenGL.delegatesGL.glFogCoordhvNV));
			}
			if (SuportedExt.Contains("glFogCoordPointerEXT"))
			{
				dgtk.OpenGL.internalGL.glFogCoordPointerEXT = (dgtk.OpenGL.delegatesGL.glFogCoordPointerEXT) InternalTool.GetGLMethodAdress("glFogCoordPointerEXT", typeof(dgtk.OpenGL.delegatesGL.glFogCoordPointerEXT));
			}
			if (SuportedExt.Contains("glFogCoordPointerListIBM"))
			{
				dgtk.OpenGL.internalGL.glFogCoordPointerListIBM = (dgtk.OpenGL.delegatesGL.glFogCoordPointerListIBM) InternalTool.GetGLMethodAdress("glFogCoordPointerListIBM", typeof(dgtk.OpenGL.delegatesGL.glFogCoordPointerListIBM));
			}
			if (SuportedExt.Contains("glFogFuncSGIS"))
			{
				dgtk.OpenGL.internalGL.glFogFuncSGIS = (dgtk.OpenGL.delegatesGL.glFogFuncSGIS) InternalTool.GetGLMethodAdress("glFogFuncSGIS", typeof(dgtk.OpenGL.delegatesGL.glFogFuncSGIS));
			}
			if (SuportedExt.Contains("glFogx"))
			{
				dgtk.OpenGL.internalGL.glFogx = (dgtk.OpenGL.delegatesGL.glFogx) InternalTool.GetGLMethodAdress("glFogx", typeof(dgtk.OpenGL.delegatesGL.glFogx));
			}
			if (SuportedExt.Contains("glFogxOES"))
			{
				dgtk.OpenGL.internalGL.glFogxOES = (dgtk.OpenGL.delegatesGL.glFogxOES) InternalTool.GetGLMethodAdress("glFogxOES", typeof(dgtk.OpenGL.delegatesGL.glFogxOES));
			}
			if (SuportedExt.Contains("glFogxv"))
			{
				dgtk.OpenGL.internalGL.glFogxv = (dgtk.OpenGL.delegatesGL.glFogxv) InternalTool.GetGLMethodAdress("glFogxv", typeof(dgtk.OpenGL.delegatesGL.glFogxv));
			}
			if (SuportedExt.Contains("glFogxvOES"))
			{
				dgtk.OpenGL.internalGL.glFogxvOES = (dgtk.OpenGL.delegatesGL.glFogxvOES) InternalTool.GetGLMethodAdress("glFogxvOES", typeof(dgtk.OpenGL.delegatesGL.glFogxvOES));
			}
			if (SuportedExt.Contains("glFragmentColorMaterialSGIX"))
			{
				dgtk.OpenGL.internalGL.glFragmentColorMaterialSGIX = (dgtk.OpenGL.delegatesGL.glFragmentColorMaterialSGIX) InternalTool.GetGLMethodAdress("glFragmentColorMaterialSGIX", typeof(dgtk.OpenGL.delegatesGL.glFragmentColorMaterialSGIX));
			}
			if (SuportedExt.Contains("glFragmentCoverageColorNV"))
			{
				dgtk.OpenGL.internalGL.glFragmentCoverageColorNV = (dgtk.OpenGL.delegatesGL.glFragmentCoverageColorNV) InternalTool.GetGLMethodAdress("glFragmentCoverageColorNV", typeof(dgtk.OpenGL.delegatesGL.glFragmentCoverageColorNV));
			}
			if (SuportedExt.Contains("glFragmentLightfSGIX"))
			{
				dgtk.OpenGL.internalGL.glFragmentLightfSGIX = (dgtk.OpenGL.delegatesGL.glFragmentLightfSGIX) InternalTool.GetGLMethodAdress("glFragmentLightfSGIX", typeof(dgtk.OpenGL.delegatesGL.glFragmentLightfSGIX));
			}
			if (SuportedExt.Contains("glFragmentLightfvSGIX"))
			{
				dgtk.OpenGL.internalGL.glFragmentLightfvSGIX = (dgtk.OpenGL.delegatesGL.glFragmentLightfvSGIX) InternalTool.GetGLMethodAdress("glFragmentLightfvSGIX", typeof(dgtk.OpenGL.delegatesGL.glFragmentLightfvSGIX));
			}
			if (SuportedExt.Contains("glFragmentLightiSGIX"))
			{
				dgtk.OpenGL.internalGL.glFragmentLightiSGIX = (dgtk.OpenGL.delegatesGL.glFragmentLightiSGIX) InternalTool.GetGLMethodAdress("glFragmentLightiSGIX", typeof(dgtk.OpenGL.delegatesGL.glFragmentLightiSGIX));
			}
			if (SuportedExt.Contains("glFragmentLightivSGIX"))
			{
				dgtk.OpenGL.internalGL.glFragmentLightivSGIX = (dgtk.OpenGL.delegatesGL.glFragmentLightivSGIX) InternalTool.GetGLMethodAdress("glFragmentLightivSGIX", typeof(dgtk.OpenGL.delegatesGL.glFragmentLightivSGIX));
			}
			if (SuportedExt.Contains("glFragmentLightModelfSGIX"))
			{
				dgtk.OpenGL.internalGL.glFragmentLightModelfSGIX = (dgtk.OpenGL.delegatesGL.glFragmentLightModelfSGIX) InternalTool.GetGLMethodAdress("glFragmentLightModelfSGIX", typeof(dgtk.OpenGL.delegatesGL.glFragmentLightModelfSGIX));
			}
			if (SuportedExt.Contains("glFragmentLightModelfvSGIX"))
			{
				dgtk.OpenGL.internalGL.glFragmentLightModelfvSGIX = (dgtk.OpenGL.delegatesGL.glFragmentLightModelfvSGIX) InternalTool.GetGLMethodAdress("glFragmentLightModelfvSGIX", typeof(dgtk.OpenGL.delegatesGL.glFragmentLightModelfvSGIX));
			}
			if (SuportedExt.Contains("glFragmentLightModeliSGIX"))
			{
				dgtk.OpenGL.internalGL.glFragmentLightModeliSGIX = (dgtk.OpenGL.delegatesGL.glFragmentLightModeliSGIX) InternalTool.GetGLMethodAdress("glFragmentLightModeliSGIX", typeof(dgtk.OpenGL.delegatesGL.glFragmentLightModeliSGIX));
			}
			if (SuportedExt.Contains("glFragmentLightModelivSGIX"))
			{
				dgtk.OpenGL.internalGL.glFragmentLightModelivSGIX = (dgtk.OpenGL.delegatesGL.glFragmentLightModelivSGIX) InternalTool.GetGLMethodAdress("glFragmentLightModelivSGIX", typeof(dgtk.OpenGL.delegatesGL.glFragmentLightModelivSGIX));
			}
			if (SuportedExt.Contains("glFragmentMaterialfSGIX"))
			{
				dgtk.OpenGL.internalGL.glFragmentMaterialfSGIX = (dgtk.OpenGL.delegatesGL.glFragmentMaterialfSGIX) InternalTool.GetGLMethodAdress("glFragmentMaterialfSGIX", typeof(dgtk.OpenGL.delegatesGL.glFragmentMaterialfSGIX));
			}
			if (SuportedExt.Contains("glFragmentMaterialfvSGIX"))
			{
				dgtk.OpenGL.internalGL.glFragmentMaterialfvSGIX = (dgtk.OpenGL.delegatesGL.glFragmentMaterialfvSGIX) InternalTool.GetGLMethodAdress("glFragmentMaterialfvSGIX", typeof(dgtk.OpenGL.delegatesGL.glFragmentMaterialfvSGIX));
			}
			if (SuportedExt.Contains("glFragmentMaterialiSGIX"))
			{
				dgtk.OpenGL.internalGL.glFragmentMaterialiSGIX = (dgtk.OpenGL.delegatesGL.glFragmentMaterialiSGIX) InternalTool.GetGLMethodAdress("glFragmentMaterialiSGIX", typeof(dgtk.OpenGL.delegatesGL.glFragmentMaterialiSGIX));
			}
			if (SuportedExt.Contains("glFragmentMaterialivSGIX"))
			{
				dgtk.OpenGL.internalGL.glFragmentMaterialivSGIX = (dgtk.OpenGL.delegatesGL.glFragmentMaterialivSGIX) InternalTool.GetGLMethodAdress("glFragmentMaterialivSGIX", typeof(dgtk.OpenGL.delegatesGL.glFragmentMaterialivSGIX));
			}
			if (SuportedExt.Contains("glFramebufferDrawBufferEXT"))
			{
				dgtk.OpenGL.internalGL.glFramebufferDrawBufferEXT = (dgtk.OpenGL.delegatesGL.glFramebufferDrawBufferEXT) InternalTool.GetGLMethodAdress("glFramebufferDrawBufferEXT", typeof(dgtk.OpenGL.delegatesGL.glFramebufferDrawBufferEXT));
			}
			if (SuportedExt.Contains("glFramebufferDrawBuffersEXT"))
			{
				dgtk.OpenGL.internalGL.glFramebufferDrawBuffersEXT = (dgtk.OpenGL.delegatesGL.glFramebufferDrawBuffersEXT) InternalTool.GetGLMethodAdress("glFramebufferDrawBuffersEXT", typeof(dgtk.OpenGL.delegatesGL.glFramebufferDrawBuffersEXT));
			}
			if (SuportedExt.Contains("glFramebufferFetchBarrierEXT"))
			{
				dgtk.OpenGL.internalGL.glFramebufferFetchBarrierEXT = (dgtk.OpenGL.delegatesGL.glFramebufferFetchBarrierEXT) InternalTool.GetGLMethodAdress("glFramebufferFetchBarrierEXT", typeof(dgtk.OpenGL.delegatesGL.glFramebufferFetchBarrierEXT));
			}
			if (SuportedExt.Contains("glFramebufferFetchBarrierQCOM"))
			{
				dgtk.OpenGL.internalGL.glFramebufferFetchBarrierQCOM = (dgtk.OpenGL.delegatesGL.glFramebufferFetchBarrierQCOM) InternalTool.GetGLMethodAdress("glFramebufferFetchBarrierQCOM", typeof(dgtk.OpenGL.delegatesGL.glFramebufferFetchBarrierQCOM));
			}
			if (SuportedExt.Contains("glFramebufferFoveationConfigQCOM"))
			{
				dgtk.OpenGL.internalGL.glFramebufferFoveationConfigQCOM = (dgtk.OpenGL.delegatesGL.glFramebufferFoveationConfigQCOM) InternalTool.GetGLMethodAdress("glFramebufferFoveationConfigQCOM", typeof(dgtk.OpenGL.delegatesGL.glFramebufferFoveationConfigQCOM));
			}
			if (SuportedExt.Contains("glFramebufferFoveationParametersQCOM"))
			{
				dgtk.OpenGL.internalGL.glFramebufferFoveationParametersQCOM = (dgtk.OpenGL.delegatesGL.glFramebufferFoveationParametersQCOM) InternalTool.GetGLMethodAdress("glFramebufferFoveationParametersQCOM", typeof(dgtk.OpenGL.delegatesGL.glFramebufferFoveationParametersQCOM));
			}
			if (SuportedExt.Contains("glFramebufferParameteriMESA"))
			{
				dgtk.OpenGL.internalGL.glFramebufferParameteriMESA = (dgtk.OpenGL.delegatesGL.glFramebufferParameteriMESA) InternalTool.GetGLMethodAdress("glFramebufferParameteriMESA", typeof(dgtk.OpenGL.delegatesGL.glFramebufferParameteriMESA));
			}
			if (SuportedExt.Contains("glFramebufferPixelLocalStorageSizeEXT"))
			{
				dgtk.OpenGL.internalGL.glFramebufferPixelLocalStorageSizeEXT = (dgtk.OpenGL.delegatesGL.glFramebufferPixelLocalStorageSizeEXT) InternalTool.GetGLMethodAdress("glFramebufferPixelLocalStorageSizeEXT", typeof(dgtk.OpenGL.delegatesGL.glFramebufferPixelLocalStorageSizeEXT));
			}
			if (SuportedExt.Contains("glFramebufferReadBufferEXT"))
			{
				dgtk.OpenGL.internalGL.glFramebufferReadBufferEXT = (dgtk.OpenGL.delegatesGL.glFramebufferReadBufferEXT) InternalTool.GetGLMethodAdress("glFramebufferReadBufferEXT", typeof(dgtk.OpenGL.delegatesGL.glFramebufferReadBufferEXT));
			}
			if (SuportedExt.Contains("glFramebufferRenderbufferEXT"))
			{
				dgtk.OpenGL.internalGL.glFramebufferRenderbufferEXT = (dgtk.OpenGL.delegatesGL.glFramebufferRenderbufferEXT) InternalTool.GetGLMethodAdress("glFramebufferRenderbufferEXT", typeof(dgtk.OpenGL.delegatesGL.glFramebufferRenderbufferEXT));
			}
			if (SuportedExt.Contains("glFramebufferRenderbufferOES"))
			{
				dgtk.OpenGL.internalGL.glFramebufferRenderbufferOES = (dgtk.OpenGL.delegatesGL.glFramebufferRenderbufferOES) InternalTool.GetGLMethodAdress("glFramebufferRenderbufferOES", typeof(dgtk.OpenGL.delegatesGL.glFramebufferRenderbufferOES));
			}
			if (SuportedExt.Contains("glFramebufferSampleLocationsfvARB"))
			{
				dgtk.OpenGL.internalGL.glFramebufferSampleLocationsfvARB = (dgtk.OpenGL.delegatesGL.glFramebufferSampleLocationsfvARB) InternalTool.GetGLMethodAdress("glFramebufferSampleLocationsfvARB", typeof(dgtk.OpenGL.delegatesGL.glFramebufferSampleLocationsfvARB));
			}
			if (SuportedExt.Contains("glFramebufferSampleLocationsfvNV"))
			{
				dgtk.OpenGL.internalGL.glFramebufferSampleLocationsfvNV = (dgtk.OpenGL.delegatesGL.glFramebufferSampleLocationsfvNV) InternalTool.GetGLMethodAdress("glFramebufferSampleLocationsfvNV", typeof(dgtk.OpenGL.delegatesGL.glFramebufferSampleLocationsfvNV));
			}
			if (SuportedExt.Contains("glFramebufferSamplePositionsfvAMD"))
			{
				dgtk.OpenGL.internalGL.glFramebufferSamplePositionsfvAMD = (dgtk.OpenGL.delegatesGL.glFramebufferSamplePositionsfvAMD) InternalTool.GetGLMethodAdress("glFramebufferSamplePositionsfvAMD", typeof(dgtk.OpenGL.delegatesGL.glFramebufferSamplePositionsfvAMD));
			}
			if (SuportedExt.Contains("glFramebufferTexture1DEXT"))
			{
				dgtk.OpenGL.internalGL.glFramebufferTexture1DEXT = (dgtk.OpenGL.delegatesGL.glFramebufferTexture1DEXT) InternalTool.GetGLMethodAdress("glFramebufferTexture1DEXT", typeof(dgtk.OpenGL.delegatesGL.glFramebufferTexture1DEXT));
			}
			if (SuportedExt.Contains("glFramebufferTexture2DDownsampleIMG"))
			{
				dgtk.OpenGL.internalGL.glFramebufferTexture2DDownsampleIMG = (dgtk.OpenGL.delegatesGL.glFramebufferTexture2DDownsampleIMG) InternalTool.GetGLMethodAdress("glFramebufferTexture2DDownsampleIMG", typeof(dgtk.OpenGL.delegatesGL.glFramebufferTexture2DDownsampleIMG));
			}
			if (SuportedExt.Contains("glFramebufferTexture2DEXT"))
			{
				dgtk.OpenGL.internalGL.glFramebufferTexture2DEXT = (dgtk.OpenGL.delegatesGL.glFramebufferTexture2DEXT) InternalTool.GetGLMethodAdress("glFramebufferTexture2DEXT", typeof(dgtk.OpenGL.delegatesGL.glFramebufferTexture2DEXT));
			}
			if (SuportedExt.Contains("glFramebufferTexture2DMultisampleEXT"))
			{
				dgtk.OpenGL.internalGL.glFramebufferTexture2DMultisampleEXT = (dgtk.OpenGL.delegatesGL.glFramebufferTexture2DMultisampleEXT) InternalTool.GetGLMethodAdress("glFramebufferTexture2DMultisampleEXT", typeof(dgtk.OpenGL.delegatesGL.glFramebufferTexture2DMultisampleEXT));
			}
			if (SuportedExt.Contains("glFramebufferTexture2DMultisampleIMG"))
			{
				dgtk.OpenGL.internalGL.glFramebufferTexture2DMultisampleIMG = (dgtk.OpenGL.delegatesGL.glFramebufferTexture2DMultisampleIMG) InternalTool.GetGLMethodAdress("glFramebufferTexture2DMultisampleIMG", typeof(dgtk.OpenGL.delegatesGL.glFramebufferTexture2DMultisampleIMG));
			}
			if (SuportedExt.Contains("glFramebufferTexture2DOES"))
			{
				dgtk.OpenGL.internalGL.glFramebufferTexture2DOES = (dgtk.OpenGL.delegatesGL.glFramebufferTexture2DOES) InternalTool.GetGLMethodAdress("glFramebufferTexture2DOES", typeof(dgtk.OpenGL.delegatesGL.glFramebufferTexture2DOES));
			}
			if (SuportedExt.Contains("glFramebufferTexture3DEXT"))
			{
				dgtk.OpenGL.internalGL.glFramebufferTexture3DEXT = (dgtk.OpenGL.delegatesGL.glFramebufferTexture3DEXT) InternalTool.GetGLMethodAdress("glFramebufferTexture3DEXT", typeof(dgtk.OpenGL.delegatesGL.glFramebufferTexture3DEXT));
			}
			if (SuportedExt.Contains("glFramebufferTexture3DOES"))
			{
				dgtk.OpenGL.internalGL.glFramebufferTexture3DOES = (dgtk.OpenGL.delegatesGL.glFramebufferTexture3DOES) InternalTool.GetGLMethodAdress("glFramebufferTexture3DOES", typeof(dgtk.OpenGL.delegatesGL.glFramebufferTexture3DOES));
			}
			if (SuportedExt.Contains("glFramebufferTextureARB"))
			{
				dgtk.OpenGL.internalGL.glFramebufferTextureARB = (dgtk.OpenGL.delegatesGL.glFramebufferTextureARB) InternalTool.GetGLMethodAdress("glFramebufferTextureARB", typeof(dgtk.OpenGL.delegatesGL.glFramebufferTextureARB));
			}
			if (SuportedExt.Contains("glFramebufferTextureEXT"))
			{
				dgtk.OpenGL.internalGL.glFramebufferTextureEXT = (dgtk.OpenGL.delegatesGL.glFramebufferTextureEXT) InternalTool.GetGLMethodAdress("glFramebufferTextureEXT", typeof(dgtk.OpenGL.delegatesGL.glFramebufferTextureEXT));
			}
			if (SuportedExt.Contains("glFramebufferTextureFaceARB"))
			{
				dgtk.OpenGL.internalGL.glFramebufferTextureFaceARB = (dgtk.OpenGL.delegatesGL.glFramebufferTextureFaceARB) InternalTool.GetGLMethodAdress("glFramebufferTextureFaceARB", typeof(dgtk.OpenGL.delegatesGL.glFramebufferTextureFaceARB));
			}
			if (SuportedExt.Contains("glFramebufferTextureFaceEXT"))
			{
				dgtk.OpenGL.internalGL.glFramebufferTextureFaceEXT = (dgtk.OpenGL.delegatesGL.glFramebufferTextureFaceEXT) InternalTool.GetGLMethodAdress("glFramebufferTextureFaceEXT", typeof(dgtk.OpenGL.delegatesGL.glFramebufferTextureFaceEXT));
			}
			if (SuportedExt.Contains("glFramebufferTextureLayerARB"))
			{
				dgtk.OpenGL.internalGL.glFramebufferTextureLayerARB = (dgtk.OpenGL.delegatesGL.glFramebufferTextureLayerARB) InternalTool.GetGLMethodAdress("glFramebufferTextureLayerARB", typeof(dgtk.OpenGL.delegatesGL.glFramebufferTextureLayerARB));
			}
			if (SuportedExt.Contains("glFramebufferTextureLayerDownsampleIMG"))
			{
				dgtk.OpenGL.internalGL.glFramebufferTextureLayerDownsampleIMG = (dgtk.OpenGL.delegatesGL.glFramebufferTextureLayerDownsampleIMG) InternalTool.GetGLMethodAdress("glFramebufferTextureLayerDownsampleIMG", typeof(dgtk.OpenGL.delegatesGL.glFramebufferTextureLayerDownsampleIMG));
			}
			if (SuportedExt.Contains("glFramebufferTextureLayerEXT"))
			{
				dgtk.OpenGL.internalGL.glFramebufferTextureLayerEXT = (dgtk.OpenGL.delegatesGL.glFramebufferTextureLayerEXT) InternalTool.GetGLMethodAdress("glFramebufferTextureLayerEXT", typeof(dgtk.OpenGL.delegatesGL.glFramebufferTextureLayerEXT));
			}
			if (SuportedExt.Contains("glFramebufferTextureMultisampleMultiviewOVR"))
			{
				dgtk.OpenGL.internalGL.glFramebufferTextureMultisampleMultiviewOVR = (dgtk.OpenGL.delegatesGL.glFramebufferTextureMultisampleMultiviewOVR) InternalTool.GetGLMethodAdress("glFramebufferTextureMultisampleMultiviewOVR", typeof(dgtk.OpenGL.delegatesGL.glFramebufferTextureMultisampleMultiviewOVR));
			}
			if (SuportedExt.Contains("glFramebufferTextureMultiviewOVR"))
			{
				dgtk.OpenGL.internalGL.glFramebufferTextureMultiviewOVR = (dgtk.OpenGL.delegatesGL.glFramebufferTextureMultiviewOVR) InternalTool.GetGLMethodAdress("glFramebufferTextureMultiviewOVR", typeof(dgtk.OpenGL.delegatesGL.glFramebufferTextureMultiviewOVR));
			}
			if (SuportedExt.Contains("glFramebufferTextureOES"))
			{
				dgtk.OpenGL.internalGL.glFramebufferTextureOES = (dgtk.OpenGL.delegatesGL.glFramebufferTextureOES) InternalTool.GetGLMethodAdress("glFramebufferTextureOES", typeof(dgtk.OpenGL.delegatesGL.glFramebufferTextureOES));
			}
			if (SuportedExt.Contains("glFrameTerminatorGREMEDY"))
			{
				dgtk.OpenGL.internalGL.glFrameTerminatorGREMEDY = (dgtk.OpenGL.delegatesGL.glFrameTerminatorGREMEDY) InternalTool.GetGLMethodAdress("glFrameTerminatorGREMEDY", typeof(dgtk.OpenGL.delegatesGL.glFrameTerminatorGREMEDY));
			}
			if (SuportedExt.Contains("glFrameZoomSGIX"))
			{
				dgtk.OpenGL.internalGL.glFrameZoomSGIX = (dgtk.OpenGL.delegatesGL.glFrameZoomSGIX) InternalTool.GetGLMethodAdress("glFrameZoomSGIX", typeof(dgtk.OpenGL.delegatesGL.glFrameZoomSGIX));
			}
			if (SuportedExt.Contains("glFreeObjectBufferATI"))
			{
				dgtk.OpenGL.internalGL.glFreeObjectBufferATI = (dgtk.OpenGL.delegatesGL.glFreeObjectBufferATI) InternalTool.GetGLMethodAdress("glFreeObjectBufferATI", typeof(dgtk.OpenGL.delegatesGL.glFreeObjectBufferATI));
			}
			if (SuportedExt.Contains("glFrustumf"))
			{
				dgtk.OpenGL.internalGL.glFrustumf = (dgtk.OpenGL.delegatesGL.glFrustumf) InternalTool.GetGLMethodAdress("glFrustumf", typeof(dgtk.OpenGL.delegatesGL.glFrustumf));
			}
			if (SuportedExt.Contains("glFrustumfOES"))
			{
				dgtk.OpenGL.internalGL.glFrustumfOES = (dgtk.OpenGL.delegatesGL.glFrustumfOES) InternalTool.GetGLMethodAdress("glFrustumfOES", typeof(dgtk.OpenGL.delegatesGL.glFrustumfOES));
			}
			if (SuportedExt.Contains("glFrustumx"))
			{
				dgtk.OpenGL.internalGL.glFrustumx = (dgtk.OpenGL.delegatesGL.glFrustumx) InternalTool.GetGLMethodAdress("glFrustumx", typeof(dgtk.OpenGL.delegatesGL.glFrustumx));
			}
			if (SuportedExt.Contains("glFrustumxOES"))
			{
				dgtk.OpenGL.internalGL.glFrustumxOES = (dgtk.OpenGL.delegatesGL.glFrustumxOES) InternalTool.GetGLMethodAdress("glFrustumxOES", typeof(dgtk.OpenGL.delegatesGL.glFrustumxOES));
			}
			#endregion

			#region G:

			if (SuportedExt.Contains("glGenAsyncMarkersSGIX"))
			{
				dgtk.OpenGL.internalGL.glGenAsyncMarkersSGIX = (dgtk.OpenGL.delegatesGL.glGenAsyncMarkersSGIX) InternalTool.GetGLMethodAdress("glGenAsyncMarkersSGIX", typeof(dgtk.OpenGL.delegatesGL.glGenAsyncMarkersSGIX));
			}
			if (SuportedExt.Contains("glGenBuffersARB"))
			{
				dgtk.OpenGL.internalGL.glGenBuffersARB = (dgtk.OpenGL.delegatesGL.glGenBuffersARB) InternalTool.GetGLMethodAdress("glGenBuffersARB", typeof(dgtk.OpenGL.delegatesGL.glGenBuffersARB));
			}
			if (SuportedExt.Contains("glGenerateMipmapEXT"))
			{
				dgtk.OpenGL.internalGL.glGenerateMipmapEXT = (dgtk.OpenGL.delegatesGL.glGenerateMipmapEXT) InternalTool.GetGLMethodAdress("glGenerateMipmapEXT", typeof(dgtk.OpenGL.delegatesGL.glGenerateMipmapEXT));
			}
			if (SuportedExt.Contains("glGenerateMipmapOES"))
			{
				dgtk.OpenGL.internalGL.glGenerateMipmapOES = (dgtk.OpenGL.delegatesGL.glGenerateMipmapOES) InternalTool.GetGLMethodAdress("glGenerateMipmapOES", typeof(dgtk.OpenGL.delegatesGL.glGenerateMipmapOES));
			}
			if (SuportedExt.Contains("glGenerateMultiTexMipmapEXT"))
			{
				dgtk.OpenGL.internalGL.glGenerateMultiTexMipmapEXT = (dgtk.OpenGL.delegatesGL.glGenerateMultiTexMipmapEXT) InternalTool.GetGLMethodAdress("glGenerateMultiTexMipmapEXT", typeof(dgtk.OpenGL.delegatesGL.glGenerateMultiTexMipmapEXT));
			}
			if (SuportedExt.Contains("glGenerateTextureMipmapEXT"))
			{
				dgtk.OpenGL.internalGL.glGenerateTextureMipmapEXT = (dgtk.OpenGL.delegatesGL.glGenerateTextureMipmapEXT) InternalTool.GetGLMethodAdress("glGenerateTextureMipmapEXT", typeof(dgtk.OpenGL.delegatesGL.glGenerateTextureMipmapEXT));
			}
			if (SuportedExt.Contains("glGenFencesAPPLE"))
			{
				dgtk.OpenGL.internalGL.glGenFencesAPPLE = (dgtk.OpenGL.delegatesGL.glGenFencesAPPLE) InternalTool.GetGLMethodAdress("glGenFencesAPPLE", typeof(dgtk.OpenGL.delegatesGL.glGenFencesAPPLE));
			}
			if (SuportedExt.Contains("glGenFencesNV"))
			{
				dgtk.OpenGL.internalGL.glGenFencesNV = (dgtk.OpenGL.delegatesGL.glGenFencesNV) InternalTool.GetGLMethodAdress("glGenFencesNV", typeof(dgtk.OpenGL.delegatesGL.glGenFencesNV));
			}
			if (SuportedExt.Contains("glGenFragmentShadersATI"))
			{
				dgtk.OpenGL.internalGL.glGenFragmentShadersATI = (dgtk.OpenGL.delegatesGL.glGenFragmentShadersATI) InternalTool.GetGLMethodAdress("glGenFragmentShadersATI", typeof(dgtk.OpenGL.delegatesGL.glGenFragmentShadersATI));
			}
			if (SuportedExt.Contains("glGenFramebuffersEXT"))
			{
				dgtk.OpenGL.internalGL.glGenFramebuffersEXT = (dgtk.OpenGL.delegatesGL.glGenFramebuffersEXT) InternalTool.GetGLMethodAdress("glGenFramebuffersEXT", typeof(dgtk.OpenGL.delegatesGL.glGenFramebuffersEXT));
			}
			if (SuportedExt.Contains("glGenFramebuffersOES"))
			{
				dgtk.OpenGL.internalGL.glGenFramebuffersOES = (dgtk.OpenGL.delegatesGL.glGenFramebuffersOES) InternalTool.GetGLMethodAdress("glGenFramebuffersOES", typeof(dgtk.OpenGL.delegatesGL.glGenFramebuffersOES));
			}
			if (SuportedExt.Contains("glGenNamesAMD"))
			{
				dgtk.OpenGL.internalGL.glGenNamesAMD = (dgtk.OpenGL.delegatesGL.glGenNamesAMD) InternalTool.GetGLMethodAdress("glGenNamesAMD", typeof(dgtk.OpenGL.delegatesGL.glGenNamesAMD));
			}
			if (SuportedExt.Contains("glGenOcclusionQueriesNV"))
			{
				dgtk.OpenGL.internalGL.glGenOcclusionQueriesNV = (dgtk.OpenGL.delegatesGL.glGenOcclusionQueriesNV) InternalTool.GetGLMethodAdress("glGenOcclusionQueriesNV", typeof(dgtk.OpenGL.delegatesGL.glGenOcclusionQueriesNV));
			}
			if (SuportedExt.Contains("glGenPathsNV"))
			{
				dgtk.OpenGL.internalGL.glGenPathsNV = (dgtk.OpenGL.delegatesGL.glGenPathsNV) InternalTool.GetGLMethodAdress("glGenPathsNV", typeof(dgtk.OpenGL.delegatesGL.glGenPathsNV));
			}
			if (SuportedExt.Contains("glGenPerfMonitorsAMD"))
			{
				dgtk.OpenGL.internalGL.glGenPerfMonitorsAMD = (dgtk.OpenGL.delegatesGL.glGenPerfMonitorsAMD) InternalTool.GetGLMethodAdress("glGenPerfMonitorsAMD", typeof(dgtk.OpenGL.delegatesGL.glGenPerfMonitorsAMD));
			}
			if (SuportedExt.Contains("glGenProgramPipelinesEXT"))
			{
				dgtk.OpenGL.internalGL.glGenProgramPipelinesEXT = (dgtk.OpenGL.delegatesGL.glGenProgramPipelinesEXT) InternalTool.GetGLMethodAdress("glGenProgramPipelinesEXT", typeof(dgtk.OpenGL.delegatesGL.glGenProgramPipelinesEXT));
			}
			if (SuportedExt.Contains("glGenProgramsARB"))
			{
				dgtk.OpenGL.internalGL.glGenProgramsARB = (dgtk.OpenGL.delegatesGL.glGenProgramsARB) InternalTool.GetGLMethodAdress("glGenProgramsARB", typeof(dgtk.OpenGL.delegatesGL.glGenProgramsARB));
			}
			if (SuportedExt.Contains("glGenProgramsNV"))
			{
				dgtk.OpenGL.internalGL.glGenProgramsNV = (dgtk.OpenGL.delegatesGL.glGenProgramsNV) InternalTool.GetGLMethodAdress("glGenProgramsNV", typeof(dgtk.OpenGL.delegatesGL.glGenProgramsNV));
			}
			if (SuportedExt.Contains("glGenQueriesARB"))
			{
				dgtk.OpenGL.internalGL.glGenQueriesARB = (dgtk.OpenGL.delegatesGL.glGenQueriesARB) InternalTool.GetGLMethodAdress("glGenQueriesARB", typeof(dgtk.OpenGL.delegatesGL.glGenQueriesARB));
			}
			if (SuportedExt.Contains("glGenQueriesEXT"))
			{
				dgtk.OpenGL.internalGL.glGenQueriesEXT = (dgtk.OpenGL.delegatesGL.glGenQueriesEXT) InternalTool.GetGLMethodAdress("glGenQueriesEXT", typeof(dgtk.OpenGL.delegatesGL.glGenQueriesEXT));
			}
			if (SuportedExt.Contains("glGenQueryResourceTagNV"))
			{
				dgtk.OpenGL.internalGL.glGenQueryResourceTagNV = (dgtk.OpenGL.delegatesGL.glGenQueryResourceTagNV) InternalTool.GetGLMethodAdress("glGenQueryResourceTagNV", typeof(dgtk.OpenGL.delegatesGL.glGenQueryResourceTagNV));
			}
			if (SuportedExt.Contains("glGenRenderbuffersEXT"))
			{
				dgtk.OpenGL.internalGL.glGenRenderbuffersEXT = (dgtk.OpenGL.delegatesGL.glGenRenderbuffersEXT) InternalTool.GetGLMethodAdress("glGenRenderbuffersEXT", typeof(dgtk.OpenGL.delegatesGL.glGenRenderbuffersEXT));
			}
			if (SuportedExt.Contains("glGenRenderbuffersOES"))
			{
				dgtk.OpenGL.internalGL.glGenRenderbuffersOES = (dgtk.OpenGL.delegatesGL.glGenRenderbuffersOES) InternalTool.GetGLMethodAdress("glGenRenderbuffersOES", typeof(dgtk.OpenGL.delegatesGL.glGenRenderbuffersOES));
			}
			if (SuportedExt.Contains("glGenSemaphoresEXT"))
			{
				dgtk.OpenGL.internalGL.glGenSemaphoresEXT = (dgtk.OpenGL.delegatesGL.glGenSemaphoresEXT) InternalTool.GetGLMethodAdress("glGenSemaphoresEXT", typeof(dgtk.OpenGL.delegatesGL.glGenSemaphoresEXT));
			}
			if (SuportedExt.Contains("glGenSymbolsEXT"))
			{
				dgtk.OpenGL.internalGL.glGenSymbolsEXT = (dgtk.OpenGL.delegatesGL.glGenSymbolsEXT) InternalTool.GetGLMethodAdress("glGenSymbolsEXT", typeof(dgtk.OpenGL.delegatesGL.glGenSymbolsEXT));
			}
			if (SuportedExt.Contains("glGenTexturesEXT"))
			{
				dgtk.OpenGL.internalGL.glGenTexturesEXT = (dgtk.OpenGL.delegatesGL.glGenTexturesEXT) InternalTool.GetGLMethodAdress("glGenTexturesEXT", typeof(dgtk.OpenGL.delegatesGL.glGenTexturesEXT));
			}
			if (SuportedExt.Contains("glGenTransformFeedbacksNV"))
			{
				dgtk.OpenGL.internalGL.glGenTransformFeedbacksNV = (dgtk.OpenGL.delegatesGL.glGenTransformFeedbacksNV) InternalTool.GetGLMethodAdress("glGenTransformFeedbacksNV", typeof(dgtk.OpenGL.delegatesGL.glGenTransformFeedbacksNV));
			}
			if (SuportedExt.Contains("glGenVertexArraysAPPLE"))
			{
				dgtk.OpenGL.internalGL.glGenVertexArraysAPPLE = (dgtk.OpenGL.delegatesGL.glGenVertexArraysAPPLE) InternalTool.GetGLMethodAdress("glGenVertexArraysAPPLE", typeof(dgtk.OpenGL.delegatesGL.glGenVertexArraysAPPLE));
			}
			if (SuportedExt.Contains("glGenVertexArraysOES"))
			{
				dgtk.OpenGL.internalGL.glGenVertexArraysOES = (dgtk.OpenGL.delegatesGL.glGenVertexArraysOES) InternalTool.GetGLMethodAdress("glGenVertexArraysOES", typeof(dgtk.OpenGL.delegatesGL.glGenVertexArraysOES));
			}
			if (SuportedExt.Contains("glGenVertexShadersEXT"))
			{
				dgtk.OpenGL.internalGL.glGenVertexShadersEXT = (dgtk.OpenGL.delegatesGL.glGenVertexShadersEXT) InternalTool.GetGLMethodAdress("glGenVertexShadersEXT", typeof(dgtk.OpenGL.delegatesGL.glGenVertexShadersEXT));
			}
			if (SuportedExt.Contains("glGetActiveAttribARB"))
			{
				dgtk.OpenGL.internalGL.glGetActiveAttribARB = (dgtk.OpenGL.delegatesGL.glGetActiveAttribARB) InternalTool.GetGLMethodAdress("glGetActiveAttribARB", typeof(dgtk.OpenGL.delegatesGL.glGetActiveAttribARB));
			}
			if (SuportedExt.Contains("glGetActiveUniformARB"))
			{
				dgtk.OpenGL.internalGL.glGetActiveUniformARB = (dgtk.OpenGL.delegatesGL.glGetActiveUniformARB) InternalTool.GetGLMethodAdress("glGetActiveUniformARB", typeof(dgtk.OpenGL.delegatesGL.glGetActiveUniformARB));
			}
			if (SuportedExt.Contains("glGetActiveVaryingNV"))
			{
				dgtk.OpenGL.internalGL.glGetActiveVaryingNV = (dgtk.OpenGL.delegatesGL.glGetActiveVaryingNV) InternalTool.GetGLMethodAdress("glGetActiveVaryingNV", typeof(dgtk.OpenGL.delegatesGL.glGetActiveVaryingNV));
			}
			if (SuportedExt.Contains("glGetArrayObjectfvATI"))
			{
				dgtk.OpenGL.internalGL.glGetArrayObjectfvATI = (dgtk.OpenGL.delegatesGL.glGetArrayObjectfvATI) InternalTool.GetGLMethodAdress("glGetArrayObjectfvATI", typeof(dgtk.OpenGL.delegatesGL.glGetArrayObjectfvATI));
			}
			if (SuportedExt.Contains("glGetArrayObjectivATI"))
			{
				dgtk.OpenGL.internalGL.glGetArrayObjectivATI = (dgtk.OpenGL.delegatesGL.glGetArrayObjectivATI) InternalTool.GetGLMethodAdress("glGetArrayObjectivATI", typeof(dgtk.OpenGL.delegatesGL.glGetArrayObjectivATI));
			}
			if (SuportedExt.Contains("glGetAttachedObjectsARB"))
			{
				dgtk.OpenGL.internalGL.glGetAttachedObjectsARB = (dgtk.OpenGL.delegatesGL.glGetAttachedObjectsARB) InternalTool.GetGLMethodAdress("glGetAttachedObjectsARB", typeof(dgtk.OpenGL.delegatesGL.glGetAttachedObjectsARB));
			}
			if (SuportedExt.Contains("glGetAttribLocationARB"))
			{
				dgtk.OpenGL.internalGL.glGetAttribLocationARB = (dgtk.OpenGL.delegatesGL.glGetAttribLocationARB) InternalTool.GetGLMethodAdress("glGetAttribLocationARB", typeof(dgtk.OpenGL.delegatesGL.glGetAttribLocationARB));
			}
			if (SuportedExt.Contains("glGetBooleanIndexedvEXT"))
			{
				dgtk.OpenGL.internalGL.glGetBooleanIndexedvEXT = (dgtk.OpenGL.delegatesGL.glGetBooleanIndexedvEXT) InternalTool.GetGLMethodAdress("glGetBooleanIndexedvEXT", typeof(dgtk.OpenGL.delegatesGL.glGetBooleanIndexedvEXT));
			}
			if (SuportedExt.Contains("glGetBufferParameterivARB"))
			{
				dgtk.OpenGL.internalGL.glGetBufferParameterivARB = (dgtk.OpenGL.delegatesGL.glGetBufferParameterivARB) InternalTool.GetGLMethodAdress("glGetBufferParameterivARB", typeof(dgtk.OpenGL.delegatesGL.glGetBufferParameterivARB));
			}
			if (SuportedExt.Contains("glGetBufferParameterui64vNV"))
			{
				dgtk.OpenGL.internalGL.glGetBufferParameterui64vNV = (dgtk.OpenGL.delegatesGL.glGetBufferParameterui64vNV) InternalTool.GetGLMethodAdress("glGetBufferParameterui64vNV", typeof(dgtk.OpenGL.delegatesGL.glGetBufferParameterui64vNV));
			}
			if (SuportedExt.Contains("glGetBufferPointervARB"))
			{
				dgtk.OpenGL.internalGL.glGetBufferPointervARB = (dgtk.OpenGL.delegatesGL.glGetBufferPointervARB) InternalTool.GetGLMethodAdress("glGetBufferPointervARB", typeof(dgtk.OpenGL.delegatesGL.glGetBufferPointervARB));
			}
			if (SuportedExt.Contains("glGetBufferPointervOES"))
			{
				dgtk.OpenGL.internalGL.glGetBufferPointervOES = (dgtk.OpenGL.delegatesGL.glGetBufferPointervOES) InternalTool.GetGLMethodAdress("glGetBufferPointervOES", typeof(dgtk.OpenGL.delegatesGL.glGetBufferPointervOES));
			}
			if (SuportedExt.Contains("glGetBufferSubDataARB"))
			{
				dgtk.OpenGL.internalGL.glGetBufferSubDataARB = (dgtk.OpenGL.delegatesGL.glGetBufferSubDataARB) InternalTool.GetGLMethodAdress("glGetBufferSubDataARB", typeof(dgtk.OpenGL.delegatesGL.glGetBufferSubDataARB));
			}
			if (SuportedExt.Contains("glGetClipPlanef"))
			{
				dgtk.OpenGL.internalGL.glGetClipPlanef = (dgtk.OpenGL.delegatesGL.glGetClipPlanef) InternalTool.GetGLMethodAdress("glGetClipPlanef", typeof(dgtk.OpenGL.delegatesGL.glGetClipPlanef));
			}
			if (SuportedExt.Contains("glGetClipPlanefOES"))
			{
				dgtk.OpenGL.internalGL.glGetClipPlanefOES = (dgtk.OpenGL.delegatesGL.glGetClipPlanefOES) InternalTool.GetGLMethodAdress("glGetClipPlanefOES", typeof(dgtk.OpenGL.delegatesGL.glGetClipPlanefOES));
			}
			if (SuportedExt.Contains("glGetClipPlanex"))
			{
				dgtk.OpenGL.internalGL.glGetClipPlanex = (dgtk.OpenGL.delegatesGL.glGetClipPlanex) InternalTool.GetGLMethodAdress("glGetClipPlanex", typeof(dgtk.OpenGL.delegatesGL.glGetClipPlanex));
			}
			if (SuportedExt.Contains("glGetClipPlanexOES"))
			{
				dgtk.OpenGL.internalGL.glGetClipPlanexOES = (dgtk.OpenGL.delegatesGL.glGetClipPlanexOES) InternalTool.GetGLMethodAdress("glGetClipPlanexOES", typeof(dgtk.OpenGL.delegatesGL.glGetClipPlanexOES));
			}
			if (SuportedExt.Contains("glGetColorTable"))
			{
				dgtk.OpenGL.internalGL.glGetColorTable = (dgtk.OpenGL.delegatesGL.glGetColorTable) InternalTool.GetGLMethodAdress("glGetColorTable", typeof(dgtk.OpenGL.delegatesGL.glGetColorTable));
			}
			if (SuportedExt.Contains("glGetColorTableEXT"))
			{
				dgtk.OpenGL.internalGL.glGetColorTableEXT = (dgtk.OpenGL.delegatesGL.glGetColorTableEXT) InternalTool.GetGLMethodAdress("glGetColorTableEXT", typeof(dgtk.OpenGL.delegatesGL.glGetColorTableEXT));
			}
			if (SuportedExt.Contains("glGetColorTableParameterfv"))
			{
				dgtk.OpenGL.internalGL.glGetColorTableParameterfv = (dgtk.OpenGL.delegatesGL.glGetColorTableParameterfv) InternalTool.GetGLMethodAdress("glGetColorTableParameterfv", typeof(dgtk.OpenGL.delegatesGL.glGetColorTableParameterfv));
			}
			if (SuportedExt.Contains("glGetColorTableParameterfvEXT"))
			{
				dgtk.OpenGL.internalGL.glGetColorTableParameterfvEXT = (dgtk.OpenGL.delegatesGL.glGetColorTableParameterfvEXT) InternalTool.GetGLMethodAdress("glGetColorTableParameterfvEXT", typeof(dgtk.OpenGL.delegatesGL.glGetColorTableParameterfvEXT));
			}
			if (SuportedExt.Contains("glGetColorTableParameterfvSGI"))
			{
				dgtk.OpenGL.internalGL.glGetColorTableParameterfvSGI = (dgtk.OpenGL.delegatesGL.glGetColorTableParameterfvSGI) InternalTool.GetGLMethodAdress("glGetColorTableParameterfvSGI", typeof(dgtk.OpenGL.delegatesGL.glGetColorTableParameterfvSGI));
			}
			if (SuportedExt.Contains("glGetColorTableParameteriv"))
			{
				dgtk.OpenGL.internalGL.glGetColorTableParameteriv = (dgtk.OpenGL.delegatesGL.glGetColorTableParameteriv) InternalTool.GetGLMethodAdress("glGetColorTableParameteriv", typeof(dgtk.OpenGL.delegatesGL.glGetColorTableParameteriv));
			}
			if (SuportedExt.Contains("glGetColorTableParameterivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetColorTableParameterivEXT = (dgtk.OpenGL.delegatesGL.glGetColorTableParameterivEXT) InternalTool.GetGLMethodAdress("glGetColorTableParameterivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetColorTableParameterivEXT));
			}
			if (SuportedExt.Contains("glGetColorTableParameterivSGI"))
			{
				dgtk.OpenGL.internalGL.glGetColorTableParameterivSGI = (dgtk.OpenGL.delegatesGL.glGetColorTableParameterivSGI) InternalTool.GetGLMethodAdress("glGetColorTableParameterivSGI", typeof(dgtk.OpenGL.delegatesGL.glGetColorTableParameterivSGI));
			}
			if (SuportedExt.Contains("glGetColorTableSGI"))
			{
				dgtk.OpenGL.internalGL.glGetColorTableSGI = (dgtk.OpenGL.delegatesGL.glGetColorTableSGI) InternalTool.GetGLMethodAdress("glGetColorTableSGI", typeof(dgtk.OpenGL.delegatesGL.glGetColorTableSGI));
			}
			if (SuportedExt.Contains("glGetCombinerInputParameterfvNV"))
			{
				dgtk.OpenGL.internalGL.glGetCombinerInputParameterfvNV = (dgtk.OpenGL.delegatesGL.glGetCombinerInputParameterfvNV) InternalTool.GetGLMethodAdress("glGetCombinerInputParameterfvNV", typeof(dgtk.OpenGL.delegatesGL.glGetCombinerInputParameterfvNV));
			}
			if (SuportedExt.Contains("glGetCombinerInputParameterivNV"))
			{
				dgtk.OpenGL.internalGL.glGetCombinerInputParameterivNV = (dgtk.OpenGL.delegatesGL.glGetCombinerInputParameterivNV) InternalTool.GetGLMethodAdress("glGetCombinerInputParameterivNV", typeof(dgtk.OpenGL.delegatesGL.glGetCombinerInputParameterivNV));
			}
			if (SuportedExt.Contains("glGetCombinerOutputParameterfvNV"))
			{
				dgtk.OpenGL.internalGL.glGetCombinerOutputParameterfvNV = (dgtk.OpenGL.delegatesGL.glGetCombinerOutputParameterfvNV) InternalTool.GetGLMethodAdress("glGetCombinerOutputParameterfvNV", typeof(dgtk.OpenGL.delegatesGL.glGetCombinerOutputParameterfvNV));
			}
			if (SuportedExt.Contains("glGetCombinerOutputParameterivNV"))
			{
				dgtk.OpenGL.internalGL.glGetCombinerOutputParameterivNV = (dgtk.OpenGL.delegatesGL.glGetCombinerOutputParameterivNV) InternalTool.GetGLMethodAdress("glGetCombinerOutputParameterivNV", typeof(dgtk.OpenGL.delegatesGL.glGetCombinerOutputParameterivNV));
			}
			if (SuportedExt.Contains("glGetCombinerStageParameterfvNV"))
			{
				dgtk.OpenGL.internalGL.glGetCombinerStageParameterfvNV = (dgtk.OpenGL.delegatesGL.glGetCombinerStageParameterfvNV) InternalTool.GetGLMethodAdress("glGetCombinerStageParameterfvNV", typeof(dgtk.OpenGL.delegatesGL.glGetCombinerStageParameterfvNV));
			}
			if (SuportedExt.Contains("glGetCommandHeaderNV"))
			{
				dgtk.OpenGL.internalGL.glGetCommandHeaderNV = (dgtk.OpenGL.delegatesGL.glGetCommandHeaderNV) InternalTool.GetGLMethodAdress("glGetCommandHeaderNV", typeof(dgtk.OpenGL.delegatesGL.glGetCommandHeaderNV));
			}
			if (SuportedExt.Contains("glGetCompressedMultiTexImageEXT"))
			{
				dgtk.OpenGL.internalGL.glGetCompressedMultiTexImageEXT = (dgtk.OpenGL.delegatesGL.glGetCompressedMultiTexImageEXT) InternalTool.GetGLMethodAdress("glGetCompressedMultiTexImageEXT", typeof(dgtk.OpenGL.delegatesGL.glGetCompressedMultiTexImageEXT));
			}
			if (SuportedExt.Contains("glGetCompressedTexImageARB"))
			{
				dgtk.OpenGL.internalGL.glGetCompressedTexImageARB = (dgtk.OpenGL.delegatesGL.glGetCompressedTexImageARB) InternalTool.GetGLMethodAdress("glGetCompressedTexImageARB", typeof(dgtk.OpenGL.delegatesGL.glGetCompressedTexImageARB));
			}
			if (SuportedExt.Contains("glGetCompressedTextureImageEXT"))
			{
				dgtk.OpenGL.internalGL.glGetCompressedTextureImageEXT = (dgtk.OpenGL.delegatesGL.glGetCompressedTextureImageEXT) InternalTool.GetGLMethodAdress("glGetCompressedTextureImageEXT", typeof(dgtk.OpenGL.delegatesGL.glGetCompressedTextureImageEXT));
			}
			if (SuportedExt.Contains("glGetConvolutionFilter"))
			{
				dgtk.OpenGL.internalGL.glGetConvolutionFilter = (dgtk.OpenGL.delegatesGL.glGetConvolutionFilter) InternalTool.GetGLMethodAdress("glGetConvolutionFilter", typeof(dgtk.OpenGL.delegatesGL.glGetConvolutionFilter));
			}
			if (SuportedExt.Contains("glGetConvolutionFilterEXT"))
			{
				dgtk.OpenGL.internalGL.glGetConvolutionFilterEXT = (dgtk.OpenGL.delegatesGL.glGetConvolutionFilterEXT) InternalTool.GetGLMethodAdress("glGetConvolutionFilterEXT", typeof(dgtk.OpenGL.delegatesGL.glGetConvolutionFilterEXT));
			}
			if (SuportedExt.Contains("glGetConvolutionParameterfv"))
			{
				dgtk.OpenGL.internalGL.glGetConvolutionParameterfv = (dgtk.OpenGL.delegatesGL.glGetConvolutionParameterfv) InternalTool.GetGLMethodAdress("glGetConvolutionParameterfv", typeof(dgtk.OpenGL.delegatesGL.glGetConvolutionParameterfv));
			}
			if (SuportedExt.Contains("glGetConvolutionParameterfvEXT"))
			{
				dgtk.OpenGL.internalGL.glGetConvolutionParameterfvEXT = (dgtk.OpenGL.delegatesGL.glGetConvolutionParameterfvEXT) InternalTool.GetGLMethodAdress("glGetConvolutionParameterfvEXT", typeof(dgtk.OpenGL.delegatesGL.glGetConvolutionParameterfvEXT));
			}
			if (SuportedExt.Contains("glGetConvolutionParameteriv"))
			{
				dgtk.OpenGL.internalGL.glGetConvolutionParameteriv = (dgtk.OpenGL.delegatesGL.glGetConvolutionParameteriv) InternalTool.GetGLMethodAdress("glGetConvolutionParameteriv", typeof(dgtk.OpenGL.delegatesGL.glGetConvolutionParameteriv));
			}
			if (SuportedExt.Contains("glGetConvolutionParameterivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetConvolutionParameterivEXT = (dgtk.OpenGL.delegatesGL.glGetConvolutionParameterivEXT) InternalTool.GetGLMethodAdress("glGetConvolutionParameterivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetConvolutionParameterivEXT));
			}
			if (SuportedExt.Contains("glGetConvolutionParameterxvOES"))
			{
				dgtk.OpenGL.internalGL.glGetConvolutionParameterxvOES = (dgtk.OpenGL.delegatesGL.glGetConvolutionParameterxvOES) InternalTool.GetGLMethodAdress("glGetConvolutionParameterxvOES", typeof(dgtk.OpenGL.delegatesGL.glGetConvolutionParameterxvOES));
			}
			if (SuportedExt.Contains("glGetCoverageModulationTableNV"))
			{
				dgtk.OpenGL.internalGL.glGetCoverageModulationTableNV = (dgtk.OpenGL.delegatesGL.glGetCoverageModulationTableNV) InternalTool.GetGLMethodAdress("glGetCoverageModulationTableNV", typeof(dgtk.OpenGL.delegatesGL.glGetCoverageModulationTableNV));
			}
			if (SuportedExt.Contains("glGetDebugMessageLogAMD"))
			{
				dgtk.OpenGL.internalGL.glGetDebugMessageLogAMD = (dgtk.OpenGL.delegatesGL.glGetDebugMessageLogAMD) InternalTool.GetGLMethodAdress("glGetDebugMessageLogAMD", typeof(dgtk.OpenGL.delegatesGL.glGetDebugMessageLogAMD));
			}
			if (SuportedExt.Contains("glGetDebugMessageLogARB"))
			{
				dgtk.OpenGL.internalGL.glGetDebugMessageLogARB = (dgtk.OpenGL.delegatesGL.glGetDebugMessageLogARB) InternalTool.GetGLMethodAdress("glGetDebugMessageLogARB", typeof(dgtk.OpenGL.delegatesGL.glGetDebugMessageLogARB));
			}
			if (SuportedExt.Contains("glGetDebugMessageLogKHR"))
			{
				dgtk.OpenGL.internalGL.glGetDebugMessageLogKHR = (dgtk.OpenGL.delegatesGL.glGetDebugMessageLogKHR) InternalTool.GetGLMethodAdress("glGetDebugMessageLogKHR", typeof(dgtk.OpenGL.delegatesGL.glGetDebugMessageLogKHR));
			}
			if (SuportedExt.Contains("glGetDetailTexFuncSGIS"))
			{
				dgtk.OpenGL.internalGL.glGetDetailTexFuncSGIS = (dgtk.OpenGL.delegatesGL.glGetDetailTexFuncSGIS) InternalTool.GetGLMethodAdress("glGetDetailTexFuncSGIS", typeof(dgtk.OpenGL.delegatesGL.glGetDetailTexFuncSGIS));
			}
			if (SuportedExt.Contains("glGetDoublei_vEXT"))
			{
				dgtk.OpenGL.internalGL.glGetDoublei_vEXT = (dgtk.OpenGL.delegatesGL.glGetDoublei_vEXT) InternalTool.GetGLMethodAdress("glGetDoublei_vEXT", typeof(dgtk.OpenGL.delegatesGL.glGetDoublei_vEXT));
			}
			if (SuportedExt.Contains("glGetDoubleIndexedvEXT"))
			{
				dgtk.OpenGL.internalGL.glGetDoubleIndexedvEXT = (dgtk.OpenGL.delegatesGL.glGetDoubleIndexedvEXT) InternalTool.GetGLMethodAdress("glGetDoubleIndexedvEXT", typeof(dgtk.OpenGL.delegatesGL.glGetDoubleIndexedvEXT));
			}
			if (SuportedExt.Contains("glGetDriverControlsQCOM"))
			{
				dgtk.OpenGL.internalGL.glGetDriverControlsQCOM = (dgtk.OpenGL.delegatesGL.glGetDriverControlsQCOM) InternalTool.GetGLMethodAdress("glGetDriverControlsQCOM", typeof(dgtk.OpenGL.delegatesGL.glGetDriverControlsQCOM));
			}
			if (SuportedExt.Contains("glGetDriverControlStringQCOM"))
			{
				dgtk.OpenGL.internalGL.glGetDriverControlStringQCOM = (dgtk.OpenGL.delegatesGL.glGetDriverControlStringQCOM) InternalTool.GetGLMethodAdress("glGetDriverControlStringQCOM", typeof(dgtk.OpenGL.delegatesGL.glGetDriverControlStringQCOM));
			}
			if (SuportedExt.Contains("glGetFenceivNV"))
			{
				dgtk.OpenGL.internalGL.glGetFenceivNV = (dgtk.OpenGL.delegatesGL.glGetFenceivNV) InternalTool.GetGLMethodAdress("glGetFenceivNV", typeof(dgtk.OpenGL.delegatesGL.glGetFenceivNV));
			}
			if (SuportedExt.Contains("glGetFinalCombinerInputParameterfvNV"))
			{
				dgtk.OpenGL.internalGL.glGetFinalCombinerInputParameterfvNV = (dgtk.OpenGL.delegatesGL.glGetFinalCombinerInputParameterfvNV) InternalTool.GetGLMethodAdress("glGetFinalCombinerInputParameterfvNV", typeof(dgtk.OpenGL.delegatesGL.glGetFinalCombinerInputParameterfvNV));
			}
			if (SuportedExt.Contains("glGetFinalCombinerInputParameterivNV"))
			{
				dgtk.OpenGL.internalGL.glGetFinalCombinerInputParameterivNV = (dgtk.OpenGL.delegatesGL.glGetFinalCombinerInputParameterivNV) InternalTool.GetGLMethodAdress("glGetFinalCombinerInputParameterivNV", typeof(dgtk.OpenGL.delegatesGL.glGetFinalCombinerInputParameterivNV));
			}
			if (SuportedExt.Contains("glGetFirstPerfQueryIdINTEL"))
			{
				dgtk.OpenGL.internalGL.glGetFirstPerfQueryIdINTEL = (dgtk.OpenGL.delegatesGL.glGetFirstPerfQueryIdINTEL) InternalTool.GetGLMethodAdress("glGetFirstPerfQueryIdINTEL", typeof(dgtk.OpenGL.delegatesGL.glGetFirstPerfQueryIdINTEL));
			}
			if (SuportedExt.Contains("glGetFixedv"))
			{
				dgtk.OpenGL.internalGL.glGetFixedv = (dgtk.OpenGL.delegatesGL.glGetFixedv) InternalTool.GetGLMethodAdress("glGetFixedv", typeof(dgtk.OpenGL.delegatesGL.glGetFixedv));
			}
			if (SuportedExt.Contains("glGetFixedvOES"))
			{
				dgtk.OpenGL.internalGL.glGetFixedvOES = (dgtk.OpenGL.delegatesGL.glGetFixedvOES) InternalTool.GetGLMethodAdress("glGetFixedvOES", typeof(dgtk.OpenGL.delegatesGL.glGetFixedvOES));
			}
			if (SuportedExt.Contains("glGetFloati_vEXT"))
			{
				dgtk.OpenGL.internalGL.glGetFloati_vEXT = (dgtk.OpenGL.delegatesGL.glGetFloati_vEXT) InternalTool.GetGLMethodAdress("glGetFloati_vEXT", typeof(dgtk.OpenGL.delegatesGL.glGetFloati_vEXT));
			}
			if (SuportedExt.Contains("glGetFloati_vNV"))
			{
				dgtk.OpenGL.internalGL.glGetFloati_vNV = (dgtk.OpenGL.delegatesGL.glGetFloati_vNV) InternalTool.GetGLMethodAdress("glGetFloati_vNV", typeof(dgtk.OpenGL.delegatesGL.glGetFloati_vNV));
			}
			if (SuportedExt.Contains("glGetFloati_vOES"))
			{
				dgtk.OpenGL.internalGL.glGetFloati_vOES = (dgtk.OpenGL.delegatesGL.glGetFloati_vOES) InternalTool.GetGLMethodAdress("glGetFloati_vOES", typeof(dgtk.OpenGL.delegatesGL.glGetFloati_vOES));
			}
			if (SuportedExt.Contains("glGetFloatIndexedvEXT"))
			{
				dgtk.OpenGL.internalGL.glGetFloatIndexedvEXT = (dgtk.OpenGL.delegatesGL.glGetFloatIndexedvEXT) InternalTool.GetGLMethodAdress("glGetFloatIndexedvEXT", typeof(dgtk.OpenGL.delegatesGL.glGetFloatIndexedvEXT));
			}
			if (SuportedExt.Contains("glGetFogFuncSGIS"))
			{
				dgtk.OpenGL.internalGL.glGetFogFuncSGIS = (dgtk.OpenGL.delegatesGL.glGetFogFuncSGIS) InternalTool.GetGLMethodAdress("glGetFogFuncSGIS", typeof(dgtk.OpenGL.delegatesGL.glGetFogFuncSGIS));
			}
			if (SuportedExt.Contains("glGetFragDataIndexEXT"))
			{
				dgtk.OpenGL.internalGL.glGetFragDataIndexEXT = (dgtk.OpenGL.delegatesGL.glGetFragDataIndexEXT) InternalTool.GetGLMethodAdress("glGetFragDataIndexEXT", typeof(dgtk.OpenGL.delegatesGL.glGetFragDataIndexEXT));
			}
			if (SuportedExt.Contains("glGetFragDataLocationEXT"))
			{
				dgtk.OpenGL.internalGL.glGetFragDataLocationEXT = (dgtk.OpenGL.delegatesGL.glGetFragDataLocationEXT) InternalTool.GetGLMethodAdress("glGetFragDataLocationEXT", typeof(dgtk.OpenGL.delegatesGL.glGetFragDataLocationEXT));
			}
			if (SuportedExt.Contains("glGetFragmentLightfvSGIX"))
			{
				dgtk.OpenGL.internalGL.glGetFragmentLightfvSGIX = (dgtk.OpenGL.delegatesGL.glGetFragmentLightfvSGIX) InternalTool.GetGLMethodAdress("glGetFragmentLightfvSGIX", typeof(dgtk.OpenGL.delegatesGL.glGetFragmentLightfvSGIX));
			}
			if (SuportedExt.Contains("glGetFragmentLightivSGIX"))
			{
				dgtk.OpenGL.internalGL.glGetFragmentLightivSGIX = (dgtk.OpenGL.delegatesGL.glGetFragmentLightivSGIX) InternalTool.GetGLMethodAdress("glGetFragmentLightivSGIX", typeof(dgtk.OpenGL.delegatesGL.glGetFragmentLightivSGIX));
			}
			if (SuportedExt.Contains("glGetFragmentMaterialfvSGIX"))
			{
				dgtk.OpenGL.internalGL.glGetFragmentMaterialfvSGIX = (dgtk.OpenGL.delegatesGL.glGetFragmentMaterialfvSGIX) InternalTool.GetGLMethodAdress("glGetFragmentMaterialfvSGIX", typeof(dgtk.OpenGL.delegatesGL.glGetFragmentMaterialfvSGIX));
			}
			if (SuportedExt.Contains("glGetFragmentMaterialivSGIX"))
			{
				dgtk.OpenGL.internalGL.glGetFragmentMaterialivSGIX = (dgtk.OpenGL.delegatesGL.glGetFragmentMaterialivSGIX) InternalTool.GetGLMethodAdress("glGetFragmentMaterialivSGIX", typeof(dgtk.OpenGL.delegatesGL.glGetFragmentMaterialivSGIX));
			}
			if (SuportedExt.Contains("glGetFramebufferAttachmentParameterivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetFramebufferAttachmentParameterivEXT = (dgtk.OpenGL.delegatesGL.glGetFramebufferAttachmentParameterivEXT) InternalTool.GetGLMethodAdress("glGetFramebufferAttachmentParameterivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetFramebufferAttachmentParameterivEXT));
			}
			if (SuportedExt.Contains("glGetFramebufferAttachmentParameterivOES"))
			{
				dgtk.OpenGL.internalGL.glGetFramebufferAttachmentParameterivOES = (dgtk.OpenGL.delegatesGL.glGetFramebufferAttachmentParameterivOES) InternalTool.GetGLMethodAdress("glGetFramebufferAttachmentParameterivOES", typeof(dgtk.OpenGL.delegatesGL.glGetFramebufferAttachmentParameterivOES));
			}
			if (SuportedExt.Contains("glGetFramebufferParameterfvAMD"))
			{
				dgtk.OpenGL.internalGL.glGetFramebufferParameterfvAMD = (dgtk.OpenGL.delegatesGL.glGetFramebufferParameterfvAMD) InternalTool.GetGLMethodAdress("glGetFramebufferParameterfvAMD", typeof(dgtk.OpenGL.delegatesGL.glGetFramebufferParameterfvAMD));
			}
			if (SuportedExt.Contains("glGetFramebufferParameterivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetFramebufferParameterivEXT = (dgtk.OpenGL.delegatesGL.glGetFramebufferParameterivEXT) InternalTool.GetGLMethodAdress("glGetFramebufferParameterivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetFramebufferParameterivEXT));
			}
			if (SuportedExt.Contains("glGetFramebufferParameterivMESA"))
			{
				dgtk.OpenGL.internalGL.glGetFramebufferParameterivMESA = (dgtk.OpenGL.delegatesGL.glGetFramebufferParameterivMESA) InternalTool.GetGLMethodAdress("glGetFramebufferParameterivMESA", typeof(dgtk.OpenGL.delegatesGL.glGetFramebufferParameterivMESA));
			}
			if (SuportedExt.Contains("glGetFramebufferPixelLocalStorageSizeEXT"))
			{
				dgtk.OpenGL.internalGL.glGetFramebufferPixelLocalStorageSizeEXT = (dgtk.OpenGL.delegatesGL.glGetFramebufferPixelLocalStorageSizeEXT) InternalTool.GetGLMethodAdress("glGetFramebufferPixelLocalStorageSizeEXT", typeof(dgtk.OpenGL.delegatesGL.glGetFramebufferPixelLocalStorageSizeEXT));
			}
			if (SuportedExt.Contains("glGetGraphicsResetStatusARB"))
			{
				dgtk.OpenGL.internalGL.glGetGraphicsResetStatusARB = (dgtk.OpenGL.delegatesGL.glGetGraphicsResetStatusARB) InternalTool.GetGLMethodAdress("glGetGraphicsResetStatusARB", typeof(dgtk.OpenGL.delegatesGL.glGetGraphicsResetStatusARB));
			}
			if (SuportedExt.Contains("glGetGraphicsResetStatusEXT"))
			{
				dgtk.OpenGL.internalGL.glGetGraphicsResetStatusEXT = (dgtk.OpenGL.delegatesGL.glGetGraphicsResetStatusEXT) InternalTool.GetGLMethodAdress("glGetGraphicsResetStatusEXT", typeof(dgtk.OpenGL.delegatesGL.glGetGraphicsResetStatusEXT));
			}
			if (SuportedExt.Contains("glGetGraphicsResetStatusKHR"))
			{
				dgtk.OpenGL.internalGL.glGetGraphicsResetStatusKHR = (dgtk.OpenGL.delegatesGL.glGetGraphicsResetStatusKHR) InternalTool.GetGLMethodAdress("glGetGraphicsResetStatusKHR", typeof(dgtk.OpenGL.delegatesGL.glGetGraphicsResetStatusKHR));
			}
			if (SuportedExt.Contains("glGetHandleARB"))
			{
				dgtk.OpenGL.internalGL.glGetHandleARB = (dgtk.OpenGL.delegatesGL.glGetHandleARB) InternalTool.GetGLMethodAdress("glGetHandleARB", typeof(dgtk.OpenGL.delegatesGL.glGetHandleARB));
			}
			if (SuportedExt.Contains("glGetHistogram"))
			{
				dgtk.OpenGL.internalGL.glGetHistogram = (dgtk.OpenGL.delegatesGL.glGetHistogram) InternalTool.GetGLMethodAdress("glGetHistogram", typeof(dgtk.OpenGL.delegatesGL.glGetHistogram));
			}
			if (SuportedExt.Contains("glGetHistogramEXT"))
			{
				dgtk.OpenGL.internalGL.glGetHistogramEXT = (dgtk.OpenGL.delegatesGL.glGetHistogramEXT) InternalTool.GetGLMethodAdress("glGetHistogramEXT", typeof(dgtk.OpenGL.delegatesGL.glGetHistogramEXT));
			}
			if (SuportedExt.Contains("glGetHistogramParameterfv"))
			{
				dgtk.OpenGL.internalGL.glGetHistogramParameterfv = (dgtk.OpenGL.delegatesGL.glGetHistogramParameterfv) InternalTool.GetGLMethodAdress("glGetHistogramParameterfv", typeof(dgtk.OpenGL.delegatesGL.glGetHistogramParameterfv));
			}
			if (SuportedExt.Contains("glGetHistogramParameterfvEXT"))
			{
				dgtk.OpenGL.internalGL.glGetHistogramParameterfvEXT = (dgtk.OpenGL.delegatesGL.glGetHistogramParameterfvEXT) InternalTool.GetGLMethodAdress("glGetHistogramParameterfvEXT", typeof(dgtk.OpenGL.delegatesGL.glGetHistogramParameterfvEXT));
			}
			if (SuportedExt.Contains("glGetHistogramParameteriv"))
			{
				dgtk.OpenGL.internalGL.glGetHistogramParameteriv = (dgtk.OpenGL.delegatesGL.glGetHistogramParameteriv) InternalTool.GetGLMethodAdress("glGetHistogramParameteriv", typeof(dgtk.OpenGL.delegatesGL.glGetHistogramParameteriv));
			}
			if (SuportedExt.Contains("glGetHistogramParameterivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetHistogramParameterivEXT = (dgtk.OpenGL.delegatesGL.glGetHistogramParameterivEXT) InternalTool.GetGLMethodAdress("glGetHistogramParameterivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetHistogramParameterivEXT));
			}
			if (SuportedExt.Contains("glGetHistogramParameterxvOES"))
			{
				dgtk.OpenGL.internalGL.glGetHistogramParameterxvOES = (dgtk.OpenGL.delegatesGL.glGetHistogramParameterxvOES) InternalTool.GetGLMethodAdress("glGetHistogramParameterxvOES", typeof(dgtk.OpenGL.delegatesGL.glGetHistogramParameterxvOES));
			}
			if (SuportedExt.Contains("glGetImageHandleARB"))
			{
				dgtk.OpenGL.internalGL.glGetImageHandleARB = (dgtk.OpenGL.delegatesGL.glGetImageHandleARB) InternalTool.GetGLMethodAdress("glGetImageHandleARB", typeof(dgtk.OpenGL.delegatesGL.glGetImageHandleARB));
			}
			if (SuportedExt.Contains("glGetImageHandleNV"))
			{
				dgtk.OpenGL.internalGL.glGetImageHandleNV = (dgtk.OpenGL.delegatesGL.glGetImageHandleNV) InternalTool.GetGLMethodAdress("glGetImageHandleNV", typeof(dgtk.OpenGL.delegatesGL.glGetImageHandleNV));
			}
			if (SuportedExt.Contains("glGetImageTransformParameterfvHP"))
			{
				dgtk.OpenGL.internalGL.glGetImageTransformParameterfvHP = (dgtk.OpenGL.delegatesGL.glGetImageTransformParameterfvHP) InternalTool.GetGLMethodAdress("glGetImageTransformParameterfvHP", typeof(dgtk.OpenGL.delegatesGL.glGetImageTransformParameterfvHP));
			}
			if (SuportedExt.Contains("glGetImageTransformParameterivHP"))
			{
				dgtk.OpenGL.internalGL.glGetImageTransformParameterivHP = (dgtk.OpenGL.delegatesGL.glGetImageTransformParameterivHP) InternalTool.GetGLMethodAdress("glGetImageTransformParameterivHP", typeof(dgtk.OpenGL.delegatesGL.glGetImageTransformParameterivHP));
			}
			if (SuportedExt.Contains("glGetInfoLogARB"))
			{
				dgtk.OpenGL.internalGL.glGetInfoLogARB = (dgtk.OpenGL.delegatesGL.glGetInfoLogARB) InternalTool.GetGLMethodAdress("glGetInfoLogARB", typeof(dgtk.OpenGL.delegatesGL.glGetInfoLogARB));
			}
			if (SuportedExt.Contains("glGetInstrumentsSGIX"))
			{
				dgtk.OpenGL.internalGL.glGetInstrumentsSGIX = (dgtk.OpenGL.delegatesGL.glGetInstrumentsSGIX) InternalTool.GetGLMethodAdress("glGetInstrumentsSGIX", typeof(dgtk.OpenGL.delegatesGL.glGetInstrumentsSGIX));
			}
			if (SuportedExt.Contains("glGetInteger64vAPPLE"))
			{
				dgtk.OpenGL.internalGL.glGetInteger64vAPPLE = (dgtk.OpenGL.delegatesGL.glGetInteger64vAPPLE) InternalTool.GetGLMethodAdress("glGetInteger64vAPPLE", typeof(dgtk.OpenGL.delegatesGL.glGetInteger64vAPPLE));
			}
			if (SuportedExt.Contains("glGetInteger64vEXT"))
			{
				dgtk.OpenGL.internalGL.glGetInteger64vEXT = (dgtk.OpenGL.delegatesGL.glGetInteger64vEXT) InternalTool.GetGLMethodAdress("glGetInteger64vEXT", typeof(dgtk.OpenGL.delegatesGL.glGetInteger64vEXT));
			}
			if (SuportedExt.Contains("glGetIntegeri_vEXT"))
			{
				dgtk.OpenGL.internalGL.glGetIntegeri_vEXT = (dgtk.OpenGL.delegatesGL.glGetIntegeri_vEXT) InternalTool.GetGLMethodAdress("glGetIntegeri_vEXT", typeof(dgtk.OpenGL.delegatesGL.glGetIntegeri_vEXT));
			}
			if (SuportedExt.Contains("glGetIntegerIndexedvEXT"))
			{
				dgtk.OpenGL.internalGL.glGetIntegerIndexedvEXT = (dgtk.OpenGL.delegatesGL.glGetIntegerIndexedvEXT) InternalTool.GetGLMethodAdress("glGetIntegerIndexedvEXT", typeof(dgtk.OpenGL.delegatesGL.glGetIntegerIndexedvEXT));
			}
			if (SuportedExt.Contains("glGetIntegerui64i_vNV"))
			{
				dgtk.OpenGL.internalGL.glGetIntegerui64i_vNV = (dgtk.OpenGL.delegatesGL.glGetIntegerui64i_vNV) InternalTool.GetGLMethodAdress("glGetIntegerui64i_vNV", typeof(dgtk.OpenGL.delegatesGL.glGetIntegerui64i_vNV));
			}
			if (SuportedExt.Contains("glGetIntegerui64vNV"))
			{
				dgtk.OpenGL.internalGL.glGetIntegerui64vNV = (dgtk.OpenGL.delegatesGL.glGetIntegerui64vNV) InternalTool.GetGLMethodAdress("glGetIntegerui64vNV", typeof(dgtk.OpenGL.delegatesGL.glGetIntegerui64vNV));
			}
			if (SuportedExt.Contains("glGetInternalformatSampleivNV"))
			{
				dgtk.OpenGL.internalGL.glGetInternalformatSampleivNV = (dgtk.OpenGL.delegatesGL.glGetInternalformatSampleivNV) InternalTool.GetGLMethodAdress("glGetInternalformatSampleivNV", typeof(dgtk.OpenGL.delegatesGL.glGetInternalformatSampleivNV));
			}
			if (SuportedExt.Contains("glGetInvariantBooleanvEXT"))
			{
				dgtk.OpenGL.internalGL.glGetInvariantBooleanvEXT = (dgtk.OpenGL.delegatesGL.glGetInvariantBooleanvEXT) InternalTool.GetGLMethodAdress("glGetInvariantBooleanvEXT", typeof(dgtk.OpenGL.delegatesGL.glGetInvariantBooleanvEXT));
			}
			if (SuportedExt.Contains("glGetInvariantFloatvEXT"))
			{
				dgtk.OpenGL.internalGL.glGetInvariantFloatvEXT = (dgtk.OpenGL.delegatesGL.glGetInvariantFloatvEXT) InternalTool.GetGLMethodAdress("glGetInvariantFloatvEXT", typeof(dgtk.OpenGL.delegatesGL.glGetInvariantFloatvEXT));
			}
			if (SuportedExt.Contains("glGetInvariantIntegervEXT"))
			{
				dgtk.OpenGL.internalGL.glGetInvariantIntegervEXT = (dgtk.OpenGL.delegatesGL.glGetInvariantIntegervEXT) InternalTool.GetGLMethodAdress("glGetInvariantIntegervEXT", typeof(dgtk.OpenGL.delegatesGL.glGetInvariantIntegervEXT));
			}
			if (SuportedExt.Contains("glGetLightxOES"))
			{
				dgtk.OpenGL.internalGL.glGetLightxOES = (dgtk.OpenGL.delegatesGL.glGetLightxOES) InternalTool.GetGLMethodAdress("glGetLightxOES", typeof(dgtk.OpenGL.delegatesGL.glGetLightxOES));
			}
			if (SuportedExt.Contains("glGetLightxv"))
			{
				dgtk.OpenGL.internalGL.glGetLightxv = (dgtk.OpenGL.delegatesGL.glGetLightxv) InternalTool.GetGLMethodAdress("glGetLightxv", typeof(dgtk.OpenGL.delegatesGL.glGetLightxv));
			}
			if (SuportedExt.Contains("glGetLightxvOES"))
			{
				dgtk.OpenGL.internalGL.glGetLightxvOES = (dgtk.OpenGL.delegatesGL.glGetLightxvOES) InternalTool.GetGLMethodAdress("glGetLightxvOES", typeof(dgtk.OpenGL.delegatesGL.glGetLightxvOES));
			}
			if (SuportedExt.Contains("glGetListParameterfvSGIX"))
			{
				dgtk.OpenGL.internalGL.glGetListParameterfvSGIX = (dgtk.OpenGL.delegatesGL.glGetListParameterfvSGIX) InternalTool.GetGLMethodAdress("glGetListParameterfvSGIX", typeof(dgtk.OpenGL.delegatesGL.glGetListParameterfvSGIX));
			}
			if (SuportedExt.Contains("glGetListParameterivSGIX"))
			{
				dgtk.OpenGL.internalGL.glGetListParameterivSGIX = (dgtk.OpenGL.delegatesGL.glGetListParameterivSGIX) InternalTool.GetGLMethodAdress("glGetListParameterivSGIX", typeof(dgtk.OpenGL.delegatesGL.glGetListParameterivSGIX));
			}
			if (SuportedExt.Contains("glGetLocalConstantBooleanvEXT"))
			{
				dgtk.OpenGL.internalGL.glGetLocalConstantBooleanvEXT = (dgtk.OpenGL.delegatesGL.glGetLocalConstantBooleanvEXT) InternalTool.GetGLMethodAdress("glGetLocalConstantBooleanvEXT", typeof(dgtk.OpenGL.delegatesGL.glGetLocalConstantBooleanvEXT));
			}
			if (SuportedExt.Contains("glGetLocalConstantFloatvEXT"))
			{
				dgtk.OpenGL.internalGL.glGetLocalConstantFloatvEXT = (dgtk.OpenGL.delegatesGL.glGetLocalConstantFloatvEXT) InternalTool.GetGLMethodAdress("glGetLocalConstantFloatvEXT", typeof(dgtk.OpenGL.delegatesGL.glGetLocalConstantFloatvEXT));
			}
			if (SuportedExt.Contains("glGetLocalConstantIntegervEXT"))
			{
				dgtk.OpenGL.internalGL.glGetLocalConstantIntegervEXT = (dgtk.OpenGL.delegatesGL.glGetLocalConstantIntegervEXT) InternalTool.GetGLMethodAdress("glGetLocalConstantIntegervEXT", typeof(dgtk.OpenGL.delegatesGL.glGetLocalConstantIntegervEXT));
			}
			if (SuportedExt.Contains("glGetMapAttribParameterfvNV"))
			{
				dgtk.OpenGL.internalGL.glGetMapAttribParameterfvNV = (dgtk.OpenGL.delegatesGL.glGetMapAttribParameterfvNV) InternalTool.GetGLMethodAdress("glGetMapAttribParameterfvNV", typeof(dgtk.OpenGL.delegatesGL.glGetMapAttribParameterfvNV));
			}
			if (SuportedExt.Contains("glGetMapAttribParameterivNV"))
			{
				dgtk.OpenGL.internalGL.glGetMapAttribParameterivNV = (dgtk.OpenGL.delegatesGL.glGetMapAttribParameterivNV) InternalTool.GetGLMethodAdress("glGetMapAttribParameterivNV", typeof(dgtk.OpenGL.delegatesGL.glGetMapAttribParameterivNV));
			}
			if (SuportedExt.Contains("glGetMapControlPointsNV"))
			{
				dgtk.OpenGL.internalGL.glGetMapControlPointsNV = (dgtk.OpenGL.delegatesGL.glGetMapControlPointsNV) InternalTool.GetGLMethodAdress("glGetMapControlPointsNV", typeof(dgtk.OpenGL.delegatesGL.glGetMapControlPointsNV));
			}
			if (SuportedExt.Contains("glGetMapParameterfvNV"))
			{
				dgtk.OpenGL.internalGL.glGetMapParameterfvNV = (dgtk.OpenGL.delegatesGL.glGetMapParameterfvNV) InternalTool.GetGLMethodAdress("glGetMapParameterfvNV", typeof(dgtk.OpenGL.delegatesGL.glGetMapParameterfvNV));
			}
			if (SuportedExt.Contains("glGetMapParameterivNV"))
			{
				dgtk.OpenGL.internalGL.glGetMapParameterivNV = (dgtk.OpenGL.delegatesGL.glGetMapParameterivNV) InternalTool.GetGLMethodAdress("glGetMapParameterivNV", typeof(dgtk.OpenGL.delegatesGL.glGetMapParameterivNV));
			}
			if (SuportedExt.Contains("glGetMapxvOES"))
			{
				dgtk.OpenGL.internalGL.glGetMapxvOES = (dgtk.OpenGL.delegatesGL.glGetMapxvOES) InternalTool.GetGLMethodAdress("glGetMapxvOES", typeof(dgtk.OpenGL.delegatesGL.glGetMapxvOES));
			}
			if (SuportedExt.Contains("glGetMaterialxOES"))
			{
				dgtk.OpenGL.internalGL.glGetMaterialxOES = (dgtk.OpenGL.delegatesGL.glGetMaterialxOES) InternalTool.GetGLMethodAdress("glGetMaterialxOES", typeof(dgtk.OpenGL.delegatesGL.glGetMaterialxOES));
			}
			if (SuportedExt.Contains("glGetMaterialxv"))
			{
				dgtk.OpenGL.internalGL.glGetMaterialxv = (dgtk.OpenGL.delegatesGL.glGetMaterialxv) InternalTool.GetGLMethodAdress("glGetMaterialxv", typeof(dgtk.OpenGL.delegatesGL.glGetMaterialxv));
			}
			if (SuportedExt.Contains("glGetMaterialxvOES"))
			{
				dgtk.OpenGL.internalGL.glGetMaterialxvOES = (dgtk.OpenGL.delegatesGL.glGetMaterialxvOES) InternalTool.GetGLMethodAdress("glGetMaterialxvOES", typeof(dgtk.OpenGL.delegatesGL.glGetMaterialxvOES));
			}
			if (SuportedExt.Contains("glGetMemoryObjectDetachedResourcesuivNV"))
			{
				dgtk.OpenGL.internalGL.glGetMemoryObjectDetachedResourcesuivNV = (dgtk.OpenGL.delegatesGL.glGetMemoryObjectDetachedResourcesuivNV) InternalTool.GetGLMethodAdress("glGetMemoryObjectDetachedResourcesuivNV", typeof(dgtk.OpenGL.delegatesGL.glGetMemoryObjectDetachedResourcesuivNV));
			}
			if (SuportedExt.Contains("glGetMemoryObjectParameterivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetMemoryObjectParameterivEXT = (dgtk.OpenGL.delegatesGL.glGetMemoryObjectParameterivEXT) InternalTool.GetGLMethodAdress("glGetMemoryObjectParameterivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetMemoryObjectParameterivEXT));
			}
			if (SuportedExt.Contains("glGetMinmax"))
			{
				dgtk.OpenGL.internalGL.glGetMinmax = (dgtk.OpenGL.delegatesGL.glGetMinmax) InternalTool.GetGLMethodAdress("glGetMinmax", typeof(dgtk.OpenGL.delegatesGL.glGetMinmax));
			}
			if (SuportedExt.Contains("glGetMinmaxEXT"))
			{
				dgtk.OpenGL.internalGL.glGetMinmaxEXT = (dgtk.OpenGL.delegatesGL.glGetMinmaxEXT) InternalTool.GetGLMethodAdress("glGetMinmaxEXT", typeof(dgtk.OpenGL.delegatesGL.glGetMinmaxEXT));
			}
			if (SuportedExt.Contains("glGetMinmaxParameterfv"))
			{
				dgtk.OpenGL.internalGL.glGetMinmaxParameterfv = (dgtk.OpenGL.delegatesGL.glGetMinmaxParameterfv) InternalTool.GetGLMethodAdress("glGetMinmaxParameterfv", typeof(dgtk.OpenGL.delegatesGL.glGetMinmaxParameterfv));
			}
			if (SuportedExt.Contains("glGetMinmaxParameterfvEXT"))
			{
				dgtk.OpenGL.internalGL.glGetMinmaxParameterfvEXT = (dgtk.OpenGL.delegatesGL.glGetMinmaxParameterfvEXT) InternalTool.GetGLMethodAdress("glGetMinmaxParameterfvEXT", typeof(dgtk.OpenGL.delegatesGL.glGetMinmaxParameterfvEXT));
			}
			if (SuportedExt.Contains("glGetMinmaxParameteriv"))
			{
				dgtk.OpenGL.internalGL.glGetMinmaxParameteriv = (dgtk.OpenGL.delegatesGL.glGetMinmaxParameteriv) InternalTool.GetGLMethodAdress("glGetMinmaxParameteriv", typeof(dgtk.OpenGL.delegatesGL.glGetMinmaxParameteriv));
			}
			if (SuportedExt.Contains("glGetMinmaxParameterivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetMinmaxParameterivEXT = (dgtk.OpenGL.delegatesGL.glGetMinmaxParameterivEXT) InternalTool.GetGLMethodAdress("glGetMinmaxParameterivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetMinmaxParameterivEXT));
			}
			if (SuportedExt.Contains("glGetMultisamplefvNV"))
			{
				dgtk.OpenGL.internalGL.glGetMultisamplefvNV = (dgtk.OpenGL.delegatesGL.glGetMultisamplefvNV) InternalTool.GetGLMethodAdress("glGetMultisamplefvNV", typeof(dgtk.OpenGL.delegatesGL.glGetMultisamplefvNV));
			}
			if (SuportedExt.Contains("glGetMultiTexEnvfvEXT"))
			{
				dgtk.OpenGL.internalGL.glGetMultiTexEnvfvEXT = (dgtk.OpenGL.delegatesGL.glGetMultiTexEnvfvEXT) InternalTool.GetGLMethodAdress("glGetMultiTexEnvfvEXT", typeof(dgtk.OpenGL.delegatesGL.glGetMultiTexEnvfvEXT));
			}
			if (SuportedExt.Contains("glGetMultiTexEnvivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetMultiTexEnvivEXT = (dgtk.OpenGL.delegatesGL.glGetMultiTexEnvivEXT) InternalTool.GetGLMethodAdress("glGetMultiTexEnvivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetMultiTexEnvivEXT));
			}
			if (SuportedExt.Contains("glGetMultiTexGendvEXT"))
			{
				dgtk.OpenGL.internalGL.glGetMultiTexGendvEXT = (dgtk.OpenGL.delegatesGL.glGetMultiTexGendvEXT) InternalTool.GetGLMethodAdress("glGetMultiTexGendvEXT", typeof(dgtk.OpenGL.delegatesGL.glGetMultiTexGendvEXT));
			}
			if (SuportedExt.Contains("glGetMultiTexGenfvEXT"))
			{
				dgtk.OpenGL.internalGL.glGetMultiTexGenfvEXT = (dgtk.OpenGL.delegatesGL.glGetMultiTexGenfvEXT) InternalTool.GetGLMethodAdress("glGetMultiTexGenfvEXT", typeof(dgtk.OpenGL.delegatesGL.glGetMultiTexGenfvEXT));
			}
			if (SuportedExt.Contains("glGetMultiTexGenivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetMultiTexGenivEXT = (dgtk.OpenGL.delegatesGL.glGetMultiTexGenivEXT) InternalTool.GetGLMethodAdress("glGetMultiTexGenivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetMultiTexGenivEXT));
			}
			if (SuportedExt.Contains("glGetMultiTexImageEXT"))
			{
				dgtk.OpenGL.internalGL.glGetMultiTexImageEXT = (dgtk.OpenGL.delegatesGL.glGetMultiTexImageEXT) InternalTool.GetGLMethodAdress("glGetMultiTexImageEXT", typeof(dgtk.OpenGL.delegatesGL.glGetMultiTexImageEXT));
			}
			if (SuportedExt.Contains("glGetMultiTexLevelParameterfvEXT"))
			{
				dgtk.OpenGL.internalGL.glGetMultiTexLevelParameterfvEXT = (dgtk.OpenGL.delegatesGL.glGetMultiTexLevelParameterfvEXT) InternalTool.GetGLMethodAdress("glGetMultiTexLevelParameterfvEXT", typeof(dgtk.OpenGL.delegatesGL.glGetMultiTexLevelParameterfvEXT));
			}
			if (SuportedExt.Contains("glGetMultiTexLevelParameterivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetMultiTexLevelParameterivEXT = (dgtk.OpenGL.delegatesGL.glGetMultiTexLevelParameterivEXT) InternalTool.GetGLMethodAdress("glGetMultiTexLevelParameterivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetMultiTexLevelParameterivEXT));
			}
			if (SuportedExt.Contains("glGetMultiTexParameterfvEXT"))
			{
				dgtk.OpenGL.internalGL.glGetMultiTexParameterfvEXT = (dgtk.OpenGL.delegatesGL.glGetMultiTexParameterfvEXT) InternalTool.GetGLMethodAdress("glGetMultiTexParameterfvEXT", typeof(dgtk.OpenGL.delegatesGL.glGetMultiTexParameterfvEXT));
			}
			if (SuportedExt.Contains("glGetMultiTexParameterIivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetMultiTexParameterIivEXT = (dgtk.OpenGL.delegatesGL.glGetMultiTexParameterIivEXT) InternalTool.GetGLMethodAdress("glGetMultiTexParameterIivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetMultiTexParameterIivEXT));
			}
			if (SuportedExt.Contains("glGetMultiTexParameterIuivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetMultiTexParameterIuivEXT = (dgtk.OpenGL.delegatesGL.glGetMultiTexParameterIuivEXT) InternalTool.GetGLMethodAdress("glGetMultiTexParameterIuivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetMultiTexParameterIuivEXT));
			}
			if (SuportedExt.Contains("glGetMultiTexParameterivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetMultiTexParameterivEXT = (dgtk.OpenGL.delegatesGL.glGetMultiTexParameterivEXT) InternalTool.GetGLMethodAdress("glGetMultiTexParameterivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetMultiTexParameterivEXT));
			}
			if (SuportedExt.Contains("glGetNamedBufferParameterivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetNamedBufferParameterivEXT = (dgtk.OpenGL.delegatesGL.glGetNamedBufferParameterivEXT) InternalTool.GetGLMethodAdress("glGetNamedBufferParameterivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetNamedBufferParameterivEXT));
			}
			if (SuportedExt.Contains("glGetNamedBufferParameterui64vNV"))
			{
				dgtk.OpenGL.internalGL.glGetNamedBufferParameterui64vNV = (dgtk.OpenGL.delegatesGL.glGetNamedBufferParameterui64vNV) InternalTool.GetGLMethodAdress("glGetNamedBufferParameterui64vNV", typeof(dgtk.OpenGL.delegatesGL.glGetNamedBufferParameterui64vNV));
			}
			if (SuportedExt.Contains("glGetNamedBufferPointervEXT"))
			{
				dgtk.OpenGL.internalGL.glGetNamedBufferPointervEXT = (dgtk.OpenGL.delegatesGL.glGetNamedBufferPointervEXT) InternalTool.GetGLMethodAdress("glGetNamedBufferPointervEXT", typeof(dgtk.OpenGL.delegatesGL.glGetNamedBufferPointervEXT));
			}
			if (SuportedExt.Contains("glGetNamedBufferSubDataEXT"))
			{
				dgtk.OpenGL.internalGL.glGetNamedBufferSubDataEXT = (dgtk.OpenGL.delegatesGL.glGetNamedBufferSubDataEXT) InternalTool.GetGLMethodAdress("glGetNamedBufferSubDataEXT", typeof(dgtk.OpenGL.delegatesGL.glGetNamedBufferSubDataEXT));
			}
			if (SuportedExt.Contains("glGetNamedFramebufferAttachmentParameterivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetNamedFramebufferAttachmentParameterivEXT = (dgtk.OpenGL.delegatesGL.glGetNamedFramebufferAttachmentParameterivEXT) InternalTool.GetGLMethodAdress("glGetNamedFramebufferAttachmentParameterivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetNamedFramebufferAttachmentParameterivEXT));
			}
			if (SuportedExt.Contains("glGetNamedFramebufferParameterfvAMD"))
			{
				dgtk.OpenGL.internalGL.glGetNamedFramebufferParameterfvAMD = (dgtk.OpenGL.delegatesGL.glGetNamedFramebufferParameterfvAMD) InternalTool.GetGLMethodAdress("glGetNamedFramebufferParameterfvAMD", typeof(dgtk.OpenGL.delegatesGL.glGetNamedFramebufferParameterfvAMD));
			}
			if (SuportedExt.Contains("glGetNamedFramebufferParameterivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetNamedFramebufferParameterivEXT = (dgtk.OpenGL.delegatesGL.glGetNamedFramebufferParameterivEXT) InternalTool.GetGLMethodAdress("glGetNamedFramebufferParameterivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetNamedFramebufferParameterivEXT));
			}
			if (SuportedExt.Contains("glGetNamedProgramivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetNamedProgramivEXT = (dgtk.OpenGL.delegatesGL.glGetNamedProgramivEXT) InternalTool.GetGLMethodAdress("glGetNamedProgramivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetNamedProgramivEXT));
			}
			if (SuportedExt.Contains("glGetNamedProgramLocalParameterdvEXT"))
			{
				dgtk.OpenGL.internalGL.glGetNamedProgramLocalParameterdvEXT = (dgtk.OpenGL.delegatesGL.glGetNamedProgramLocalParameterdvEXT) InternalTool.GetGLMethodAdress("glGetNamedProgramLocalParameterdvEXT", typeof(dgtk.OpenGL.delegatesGL.glGetNamedProgramLocalParameterdvEXT));
			}
			if (SuportedExt.Contains("glGetNamedProgramLocalParameterfvEXT"))
			{
				dgtk.OpenGL.internalGL.glGetNamedProgramLocalParameterfvEXT = (dgtk.OpenGL.delegatesGL.glGetNamedProgramLocalParameterfvEXT) InternalTool.GetGLMethodAdress("glGetNamedProgramLocalParameterfvEXT", typeof(dgtk.OpenGL.delegatesGL.glGetNamedProgramLocalParameterfvEXT));
			}
			if (SuportedExt.Contains("glGetNamedProgramLocalParameterIivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetNamedProgramLocalParameterIivEXT = (dgtk.OpenGL.delegatesGL.glGetNamedProgramLocalParameterIivEXT) InternalTool.GetGLMethodAdress("glGetNamedProgramLocalParameterIivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetNamedProgramLocalParameterIivEXT));
			}
			if (SuportedExt.Contains("glGetNamedProgramLocalParameterIuivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetNamedProgramLocalParameterIuivEXT = (dgtk.OpenGL.delegatesGL.glGetNamedProgramLocalParameterIuivEXT) InternalTool.GetGLMethodAdress("glGetNamedProgramLocalParameterIuivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetNamedProgramLocalParameterIuivEXT));
			}
			if (SuportedExt.Contains("glGetNamedProgramStringEXT"))
			{
				dgtk.OpenGL.internalGL.glGetNamedProgramStringEXT = (dgtk.OpenGL.delegatesGL.glGetNamedProgramStringEXT) InternalTool.GetGLMethodAdress("glGetNamedProgramStringEXT", typeof(dgtk.OpenGL.delegatesGL.glGetNamedProgramStringEXT));
			}
			if (SuportedExt.Contains("glGetNamedRenderbufferParameterivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetNamedRenderbufferParameterivEXT = (dgtk.OpenGL.delegatesGL.glGetNamedRenderbufferParameterivEXT) InternalTool.GetGLMethodAdress("glGetNamedRenderbufferParameterivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetNamedRenderbufferParameterivEXT));
			}
			if (SuportedExt.Contains("glGetNamedStringARB"))
			{
				dgtk.OpenGL.internalGL.glGetNamedStringARB = (dgtk.OpenGL.delegatesGL.glGetNamedStringARB) InternalTool.GetGLMethodAdress("glGetNamedStringARB", typeof(dgtk.OpenGL.delegatesGL.glGetNamedStringARB));
			}
			if (SuportedExt.Contains("glGetNamedStringivARB"))
			{
				dgtk.OpenGL.internalGL.glGetNamedStringivARB = (dgtk.OpenGL.delegatesGL.glGetNamedStringivARB) InternalTool.GetGLMethodAdress("glGetNamedStringivARB", typeof(dgtk.OpenGL.delegatesGL.glGetNamedStringivARB));
			}
			if (SuportedExt.Contains("glGetnColorTableARB"))
			{
				dgtk.OpenGL.internalGL.glGetnColorTableARB = (dgtk.OpenGL.delegatesGL.glGetnColorTableARB) InternalTool.GetGLMethodAdress("glGetnColorTableARB", typeof(dgtk.OpenGL.delegatesGL.glGetnColorTableARB));
			}
			if (SuportedExt.Contains("glGetnCompressedTexImageARB"))
			{
				dgtk.OpenGL.internalGL.glGetnCompressedTexImageARB = (dgtk.OpenGL.delegatesGL.glGetnCompressedTexImageARB) InternalTool.GetGLMethodAdress("glGetnCompressedTexImageARB", typeof(dgtk.OpenGL.delegatesGL.glGetnCompressedTexImageARB));
			}
			if (SuportedExt.Contains("glGetnConvolutionFilterARB"))
			{
				dgtk.OpenGL.internalGL.glGetnConvolutionFilterARB = (dgtk.OpenGL.delegatesGL.glGetnConvolutionFilterARB) InternalTool.GetGLMethodAdress("glGetnConvolutionFilterARB", typeof(dgtk.OpenGL.delegatesGL.glGetnConvolutionFilterARB));
			}
			if (SuportedExt.Contains("glGetNextPerfQueryIdINTEL"))
			{
				dgtk.OpenGL.internalGL.glGetNextPerfQueryIdINTEL = (dgtk.OpenGL.delegatesGL.glGetNextPerfQueryIdINTEL) InternalTool.GetGLMethodAdress("glGetNextPerfQueryIdINTEL", typeof(dgtk.OpenGL.delegatesGL.glGetNextPerfQueryIdINTEL));
			}
			if (SuportedExt.Contains("glGetnHistogramARB"))
			{
				dgtk.OpenGL.internalGL.glGetnHistogramARB = (dgtk.OpenGL.delegatesGL.glGetnHistogramARB) InternalTool.GetGLMethodAdress("glGetnHistogramARB", typeof(dgtk.OpenGL.delegatesGL.glGetnHistogramARB));
			}
			if (SuportedExt.Contains("glGetnMapdvARB"))
			{
				dgtk.OpenGL.internalGL.glGetnMapdvARB = (dgtk.OpenGL.delegatesGL.glGetnMapdvARB) InternalTool.GetGLMethodAdress("glGetnMapdvARB", typeof(dgtk.OpenGL.delegatesGL.glGetnMapdvARB));
			}
			if (SuportedExt.Contains("glGetnMapfvARB"))
			{
				dgtk.OpenGL.internalGL.glGetnMapfvARB = (dgtk.OpenGL.delegatesGL.glGetnMapfvARB) InternalTool.GetGLMethodAdress("glGetnMapfvARB", typeof(dgtk.OpenGL.delegatesGL.glGetnMapfvARB));
			}
			if (SuportedExt.Contains("glGetnMapivARB"))
			{
				dgtk.OpenGL.internalGL.glGetnMapivARB = (dgtk.OpenGL.delegatesGL.glGetnMapivARB) InternalTool.GetGLMethodAdress("glGetnMapivARB", typeof(dgtk.OpenGL.delegatesGL.glGetnMapivARB));
			}
			if (SuportedExt.Contains("glGetnMinmaxARB"))
			{
				dgtk.OpenGL.internalGL.glGetnMinmaxARB = (dgtk.OpenGL.delegatesGL.glGetnMinmaxARB) InternalTool.GetGLMethodAdress("glGetnMinmaxARB", typeof(dgtk.OpenGL.delegatesGL.glGetnMinmaxARB));
			}
			if (SuportedExt.Contains("glGetnPixelMapfvARB"))
			{
				dgtk.OpenGL.internalGL.glGetnPixelMapfvARB = (dgtk.OpenGL.delegatesGL.glGetnPixelMapfvARB) InternalTool.GetGLMethodAdress("glGetnPixelMapfvARB", typeof(dgtk.OpenGL.delegatesGL.glGetnPixelMapfvARB));
			}
			if (SuportedExt.Contains("glGetnPixelMapuivARB"))
			{
				dgtk.OpenGL.internalGL.glGetnPixelMapuivARB = (dgtk.OpenGL.delegatesGL.glGetnPixelMapuivARB) InternalTool.GetGLMethodAdress("glGetnPixelMapuivARB", typeof(dgtk.OpenGL.delegatesGL.glGetnPixelMapuivARB));
			}
			if (SuportedExt.Contains("glGetnPixelMapusvARB"))
			{
				dgtk.OpenGL.internalGL.glGetnPixelMapusvARB = (dgtk.OpenGL.delegatesGL.glGetnPixelMapusvARB) InternalTool.GetGLMethodAdress("glGetnPixelMapusvARB", typeof(dgtk.OpenGL.delegatesGL.glGetnPixelMapusvARB));
			}
			if (SuportedExt.Contains("glGetnPolygonStippleARB"))
			{
				dgtk.OpenGL.internalGL.glGetnPolygonStippleARB = (dgtk.OpenGL.delegatesGL.glGetnPolygonStippleARB) InternalTool.GetGLMethodAdress("glGetnPolygonStippleARB", typeof(dgtk.OpenGL.delegatesGL.glGetnPolygonStippleARB));
			}
			if (SuportedExt.Contains("glGetnSeparableFilterARB"))
			{
				dgtk.OpenGL.internalGL.glGetnSeparableFilterARB = (dgtk.OpenGL.delegatesGL.glGetnSeparableFilterARB) InternalTool.GetGLMethodAdress("glGetnSeparableFilterARB", typeof(dgtk.OpenGL.delegatesGL.glGetnSeparableFilterARB));
			}
			if (SuportedExt.Contains("glGetnTexImageARB"))
			{
				dgtk.OpenGL.internalGL.glGetnTexImageARB = (dgtk.OpenGL.delegatesGL.glGetnTexImageARB) InternalTool.GetGLMethodAdress("glGetnTexImageARB", typeof(dgtk.OpenGL.delegatesGL.glGetnTexImageARB));
			}
			if (SuportedExt.Contains("glGetnUniformdvARB"))
			{
				dgtk.OpenGL.internalGL.glGetnUniformdvARB = (dgtk.OpenGL.delegatesGL.glGetnUniformdvARB) InternalTool.GetGLMethodAdress("glGetnUniformdvARB", typeof(dgtk.OpenGL.delegatesGL.glGetnUniformdvARB));
			}
			if (SuportedExt.Contains("glGetnUniformfvARB"))
			{
				dgtk.OpenGL.internalGL.glGetnUniformfvARB = (dgtk.OpenGL.delegatesGL.glGetnUniformfvARB) InternalTool.GetGLMethodAdress("glGetnUniformfvARB", typeof(dgtk.OpenGL.delegatesGL.glGetnUniformfvARB));
			}
			if (SuportedExt.Contains("glGetnUniformfvEXT"))
			{
				dgtk.OpenGL.internalGL.glGetnUniformfvEXT = (dgtk.OpenGL.delegatesGL.glGetnUniformfvEXT) InternalTool.GetGLMethodAdress("glGetnUniformfvEXT", typeof(dgtk.OpenGL.delegatesGL.glGetnUniformfvEXT));
			}
			if (SuportedExt.Contains("glGetnUniformfvKHR"))
			{
				dgtk.OpenGL.internalGL.glGetnUniformfvKHR = (dgtk.OpenGL.delegatesGL.glGetnUniformfvKHR) InternalTool.GetGLMethodAdress("glGetnUniformfvKHR", typeof(dgtk.OpenGL.delegatesGL.glGetnUniformfvKHR));
			}
			if (SuportedExt.Contains("glGetnUniformi64vARB"))
			{
				dgtk.OpenGL.internalGL.glGetnUniformi64vARB = (dgtk.OpenGL.delegatesGL.glGetnUniformi64vARB) InternalTool.GetGLMethodAdress("glGetnUniformi64vARB", typeof(dgtk.OpenGL.delegatesGL.glGetnUniformi64vARB));
			}
			if (SuportedExt.Contains("glGetnUniformivARB"))
			{
				dgtk.OpenGL.internalGL.glGetnUniformivARB = (dgtk.OpenGL.delegatesGL.glGetnUniformivARB) InternalTool.GetGLMethodAdress("glGetnUniformivARB", typeof(dgtk.OpenGL.delegatesGL.glGetnUniformivARB));
			}
			if (SuportedExt.Contains("glGetnUniformivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetnUniformivEXT = (dgtk.OpenGL.delegatesGL.glGetnUniformivEXT) InternalTool.GetGLMethodAdress("glGetnUniformivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetnUniformivEXT));
			}
			if (SuportedExt.Contains("glGetnUniformivKHR"))
			{
				dgtk.OpenGL.internalGL.glGetnUniformivKHR = (dgtk.OpenGL.delegatesGL.glGetnUniformivKHR) InternalTool.GetGLMethodAdress("glGetnUniformivKHR", typeof(dgtk.OpenGL.delegatesGL.glGetnUniformivKHR));
			}
			if (SuportedExt.Contains("glGetnUniformui64vARB"))
			{
				dgtk.OpenGL.internalGL.glGetnUniformui64vARB = (dgtk.OpenGL.delegatesGL.glGetnUniformui64vARB) InternalTool.GetGLMethodAdress("glGetnUniformui64vARB", typeof(dgtk.OpenGL.delegatesGL.glGetnUniformui64vARB));
			}
			if (SuportedExt.Contains("glGetnUniformuivARB"))
			{
				dgtk.OpenGL.internalGL.glGetnUniformuivARB = (dgtk.OpenGL.delegatesGL.glGetnUniformuivARB) InternalTool.GetGLMethodAdress("glGetnUniformuivARB", typeof(dgtk.OpenGL.delegatesGL.glGetnUniformuivARB));
			}
			if (SuportedExt.Contains("glGetnUniformuivKHR"))
			{
				dgtk.OpenGL.internalGL.glGetnUniformuivKHR = (dgtk.OpenGL.delegatesGL.glGetnUniformuivKHR) InternalTool.GetGLMethodAdress("glGetnUniformuivKHR", typeof(dgtk.OpenGL.delegatesGL.glGetnUniformuivKHR));
			}
			if (SuportedExt.Contains("glGetObjectBufferfvATI"))
			{
				dgtk.OpenGL.internalGL.glGetObjectBufferfvATI = (dgtk.OpenGL.delegatesGL.glGetObjectBufferfvATI) InternalTool.GetGLMethodAdress("glGetObjectBufferfvATI", typeof(dgtk.OpenGL.delegatesGL.glGetObjectBufferfvATI));
			}
			if (SuportedExt.Contains("glGetObjectBufferivATI"))
			{
				dgtk.OpenGL.internalGL.glGetObjectBufferivATI = (dgtk.OpenGL.delegatesGL.glGetObjectBufferivATI) InternalTool.GetGLMethodAdress("glGetObjectBufferivATI", typeof(dgtk.OpenGL.delegatesGL.glGetObjectBufferivATI));
			}
			if (SuportedExt.Contains("glGetObjectLabelEXT"))
			{
				dgtk.OpenGL.internalGL.glGetObjectLabelEXT = (dgtk.OpenGL.delegatesGL.glGetObjectLabelEXT) InternalTool.GetGLMethodAdress("glGetObjectLabelEXT", typeof(dgtk.OpenGL.delegatesGL.glGetObjectLabelEXT));
			}
			if (SuportedExt.Contains("glGetObjectLabelKHR"))
			{
				dgtk.OpenGL.internalGL.glGetObjectLabelKHR = (dgtk.OpenGL.delegatesGL.glGetObjectLabelKHR) InternalTool.GetGLMethodAdress("glGetObjectLabelKHR", typeof(dgtk.OpenGL.delegatesGL.glGetObjectLabelKHR));
			}
			if (SuportedExt.Contains("glGetObjectParameterfvARB"))
			{
				dgtk.OpenGL.internalGL.glGetObjectParameterfvARB = (dgtk.OpenGL.delegatesGL.glGetObjectParameterfvARB) InternalTool.GetGLMethodAdress("glGetObjectParameterfvARB", typeof(dgtk.OpenGL.delegatesGL.glGetObjectParameterfvARB));
			}
			if (SuportedExt.Contains("glGetObjectParameterivAPPLE"))
			{
				dgtk.OpenGL.internalGL.glGetObjectParameterivAPPLE = (dgtk.OpenGL.delegatesGL.glGetObjectParameterivAPPLE) InternalTool.GetGLMethodAdress("glGetObjectParameterivAPPLE", typeof(dgtk.OpenGL.delegatesGL.glGetObjectParameterivAPPLE));
			}
			if (SuportedExt.Contains("glGetObjectParameterivARB"))
			{
				dgtk.OpenGL.internalGL.glGetObjectParameterivARB = (dgtk.OpenGL.delegatesGL.glGetObjectParameterivARB) InternalTool.GetGLMethodAdress("glGetObjectParameterivARB", typeof(dgtk.OpenGL.delegatesGL.glGetObjectParameterivARB));
			}
			if (SuportedExt.Contains("glGetObjectPtrLabelKHR"))
			{
				dgtk.OpenGL.internalGL.glGetObjectPtrLabelKHR = (dgtk.OpenGL.delegatesGL.glGetObjectPtrLabelKHR) InternalTool.GetGLMethodAdress("glGetObjectPtrLabelKHR", typeof(dgtk.OpenGL.delegatesGL.glGetObjectPtrLabelKHR));
			}
			if (SuportedExt.Contains("glGetOcclusionQueryivNV"))
			{
				dgtk.OpenGL.internalGL.glGetOcclusionQueryivNV = (dgtk.OpenGL.delegatesGL.glGetOcclusionQueryivNV) InternalTool.GetGLMethodAdress("glGetOcclusionQueryivNV", typeof(dgtk.OpenGL.delegatesGL.glGetOcclusionQueryivNV));
			}
			if (SuportedExt.Contains("glGetOcclusionQueryuivNV"))
			{
				dgtk.OpenGL.internalGL.glGetOcclusionQueryuivNV = (dgtk.OpenGL.delegatesGL.glGetOcclusionQueryuivNV) InternalTool.GetGLMethodAdress("glGetOcclusionQueryuivNV", typeof(dgtk.OpenGL.delegatesGL.glGetOcclusionQueryuivNV));
			}
			if (SuportedExt.Contains("glGetPathColorGenfvNV"))
			{
				dgtk.OpenGL.internalGL.glGetPathColorGenfvNV = (dgtk.OpenGL.delegatesGL.glGetPathColorGenfvNV) InternalTool.GetGLMethodAdress("glGetPathColorGenfvNV", typeof(dgtk.OpenGL.delegatesGL.glGetPathColorGenfvNV));
			}
			if (SuportedExt.Contains("glGetPathColorGenivNV"))
			{
				dgtk.OpenGL.internalGL.glGetPathColorGenivNV = (dgtk.OpenGL.delegatesGL.glGetPathColorGenivNV) InternalTool.GetGLMethodAdress("glGetPathColorGenivNV", typeof(dgtk.OpenGL.delegatesGL.glGetPathColorGenivNV));
			}
			if (SuportedExt.Contains("glGetPathCommandsNV"))
			{
				dgtk.OpenGL.internalGL.glGetPathCommandsNV = (dgtk.OpenGL.delegatesGL.glGetPathCommandsNV) InternalTool.GetGLMethodAdress("glGetPathCommandsNV", typeof(dgtk.OpenGL.delegatesGL.glGetPathCommandsNV));
			}
			if (SuportedExt.Contains("glGetPathCoordsNV"))
			{
				dgtk.OpenGL.internalGL.glGetPathCoordsNV = (dgtk.OpenGL.delegatesGL.glGetPathCoordsNV) InternalTool.GetGLMethodAdress("glGetPathCoordsNV", typeof(dgtk.OpenGL.delegatesGL.glGetPathCoordsNV));
			}
			if (SuportedExt.Contains("glGetPathDashArrayNV"))
			{
				dgtk.OpenGL.internalGL.glGetPathDashArrayNV = (dgtk.OpenGL.delegatesGL.glGetPathDashArrayNV) InternalTool.GetGLMethodAdress("glGetPathDashArrayNV", typeof(dgtk.OpenGL.delegatesGL.glGetPathDashArrayNV));
			}
			if (SuportedExt.Contains("glGetPathLengthNV"))
			{
				dgtk.OpenGL.internalGL.glGetPathLengthNV = (dgtk.OpenGL.delegatesGL.glGetPathLengthNV) InternalTool.GetGLMethodAdress("glGetPathLengthNV", typeof(dgtk.OpenGL.delegatesGL.glGetPathLengthNV));
			}
			if (SuportedExt.Contains("glGetPathMetricRangeNV"))
			{
				dgtk.OpenGL.internalGL.glGetPathMetricRangeNV = (dgtk.OpenGL.delegatesGL.glGetPathMetricRangeNV) InternalTool.GetGLMethodAdress("glGetPathMetricRangeNV", typeof(dgtk.OpenGL.delegatesGL.glGetPathMetricRangeNV));
			}
			if (SuportedExt.Contains("glGetPathMetricsNV"))
			{
				dgtk.OpenGL.internalGL.glGetPathMetricsNV = (dgtk.OpenGL.delegatesGL.glGetPathMetricsNV) InternalTool.GetGLMethodAdress("glGetPathMetricsNV", typeof(dgtk.OpenGL.delegatesGL.glGetPathMetricsNV));
			}
			if (SuportedExt.Contains("glGetPathParameterfvNV"))
			{
				dgtk.OpenGL.internalGL.glGetPathParameterfvNV = (dgtk.OpenGL.delegatesGL.glGetPathParameterfvNV) InternalTool.GetGLMethodAdress("glGetPathParameterfvNV", typeof(dgtk.OpenGL.delegatesGL.glGetPathParameterfvNV));
			}
			if (SuportedExt.Contains("glGetPathParameterivNV"))
			{
				dgtk.OpenGL.internalGL.glGetPathParameterivNV = (dgtk.OpenGL.delegatesGL.glGetPathParameterivNV) InternalTool.GetGLMethodAdress("glGetPathParameterivNV", typeof(dgtk.OpenGL.delegatesGL.glGetPathParameterivNV));
			}
			if (SuportedExt.Contains("glGetPathSpacingNV"))
			{
				dgtk.OpenGL.internalGL.glGetPathSpacingNV = (dgtk.OpenGL.delegatesGL.glGetPathSpacingNV) InternalTool.GetGLMethodAdress("glGetPathSpacingNV", typeof(dgtk.OpenGL.delegatesGL.glGetPathSpacingNV));
			}
			if (SuportedExt.Contains("glGetPathTexGenfvNV"))
			{
				dgtk.OpenGL.internalGL.glGetPathTexGenfvNV = (dgtk.OpenGL.delegatesGL.glGetPathTexGenfvNV) InternalTool.GetGLMethodAdress("glGetPathTexGenfvNV", typeof(dgtk.OpenGL.delegatesGL.glGetPathTexGenfvNV));
			}
			if (SuportedExt.Contains("glGetPathTexGenivNV"))
			{
				dgtk.OpenGL.internalGL.glGetPathTexGenivNV = (dgtk.OpenGL.delegatesGL.glGetPathTexGenivNV) InternalTool.GetGLMethodAdress("glGetPathTexGenivNV", typeof(dgtk.OpenGL.delegatesGL.glGetPathTexGenivNV));
			}
			if (SuportedExt.Contains("glGetPerfCounterInfoINTEL"))
			{
				dgtk.OpenGL.internalGL.glGetPerfCounterInfoINTEL = (dgtk.OpenGL.delegatesGL.glGetPerfCounterInfoINTEL) InternalTool.GetGLMethodAdress("glGetPerfCounterInfoINTEL", typeof(dgtk.OpenGL.delegatesGL.glGetPerfCounterInfoINTEL));
			}
			if (SuportedExt.Contains("glGetPerfMonitorCounterDataAMD"))
			{
				dgtk.OpenGL.internalGL.glGetPerfMonitorCounterDataAMD = (dgtk.OpenGL.delegatesGL.glGetPerfMonitorCounterDataAMD) InternalTool.GetGLMethodAdress("glGetPerfMonitorCounterDataAMD", typeof(dgtk.OpenGL.delegatesGL.glGetPerfMonitorCounterDataAMD));
			}
			if (SuportedExt.Contains("glGetPerfMonitorCounterInfoAMD"))
			{
				dgtk.OpenGL.internalGL.glGetPerfMonitorCounterInfoAMD = (dgtk.OpenGL.delegatesGL.glGetPerfMonitorCounterInfoAMD) InternalTool.GetGLMethodAdress("glGetPerfMonitorCounterInfoAMD", typeof(dgtk.OpenGL.delegatesGL.glGetPerfMonitorCounterInfoAMD));
			}
			if (SuportedExt.Contains("glGetPerfMonitorCountersAMD"))
			{
				dgtk.OpenGL.internalGL.glGetPerfMonitorCountersAMD = (dgtk.OpenGL.delegatesGL.glGetPerfMonitorCountersAMD) InternalTool.GetGLMethodAdress("glGetPerfMonitorCountersAMD", typeof(dgtk.OpenGL.delegatesGL.glGetPerfMonitorCountersAMD));
			}
			if (SuportedExt.Contains("glGetPerfMonitorCounterStringAMD"))
			{
				dgtk.OpenGL.internalGL.glGetPerfMonitorCounterStringAMD = (dgtk.OpenGL.delegatesGL.glGetPerfMonitorCounterStringAMD) InternalTool.GetGLMethodAdress("glGetPerfMonitorCounterStringAMD", typeof(dgtk.OpenGL.delegatesGL.glGetPerfMonitorCounterStringAMD));
			}
			if (SuportedExt.Contains("glGetPerfMonitorGroupsAMD"))
			{
				dgtk.OpenGL.internalGL.glGetPerfMonitorGroupsAMD = (dgtk.OpenGL.delegatesGL.glGetPerfMonitorGroupsAMD) InternalTool.GetGLMethodAdress("glGetPerfMonitorGroupsAMD", typeof(dgtk.OpenGL.delegatesGL.glGetPerfMonitorGroupsAMD));
			}
			if (SuportedExt.Contains("glGetPerfMonitorGroupStringAMD"))
			{
				dgtk.OpenGL.internalGL.glGetPerfMonitorGroupStringAMD = (dgtk.OpenGL.delegatesGL.glGetPerfMonitorGroupStringAMD) InternalTool.GetGLMethodAdress("glGetPerfMonitorGroupStringAMD", typeof(dgtk.OpenGL.delegatesGL.glGetPerfMonitorGroupStringAMD));
			}
			if (SuportedExt.Contains("glGetPerfQueryDataINTEL"))
			{
				dgtk.OpenGL.internalGL.glGetPerfQueryDataINTEL = (dgtk.OpenGL.delegatesGL.glGetPerfQueryDataINTEL) InternalTool.GetGLMethodAdress("glGetPerfQueryDataINTEL", typeof(dgtk.OpenGL.delegatesGL.glGetPerfQueryDataINTEL));
			}
			if (SuportedExt.Contains("glGetPerfQueryIdByNameINTEL"))
			{
				dgtk.OpenGL.internalGL.glGetPerfQueryIdByNameINTEL = (dgtk.OpenGL.delegatesGL.glGetPerfQueryIdByNameINTEL) InternalTool.GetGLMethodAdress("glGetPerfQueryIdByNameINTEL", typeof(dgtk.OpenGL.delegatesGL.glGetPerfQueryIdByNameINTEL));
			}
			if (SuportedExt.Contains("glGetPerfQueryInfoINTEL"))
			{
				dgtk.OpenGL.internalGL.glGetPerfQueryInfoINTEL = (dgtk.OpenGL.delegatesGL.glGetPerfQueryInfoINTEL) InternalTool.GetGLMethodAdress("glGetPerfQueryInfoINTEL", typeof(dgtk.OpenGL.delegatesGL.glGetPerfQueryInfoINTEL));
			}
			if (SuportedExt.Contains("glGetPixelMapxv"))
			{
				dgtk.OpenGL.internalGL.glGetPixelMapxv = (dgtk.OpenGL.delegatesGL.glGetPixelMapxv) InternalTool.GetGLMethodAdress("glGetPixelMapxv", typeof(dgtk.OpenGL.delegatesGL.glGetPixelMapxv));
			}
			if (SuportedExt.Contains("glGetPixelTexGenParameterfvSGIS"))
			{
				dgtk.OpenGL.internalGL.glGetPixelTexGenParameterfvSGIS = (dgtk.OpenGL.delegatesGL.glGetPixelTexGenParameterfvSGIS) InternalTool.GetGLMethodAdress("glGetPixelTexGenParameterfvSGIS", typeof(dgtk.OpenGL.delegatesGL.glGetPixelTexGenParameterfvSGIS));
			}
			if (SuportedExt.Contains("glGetPixelTexGenParameterivSGIS"))
			{
				dgtk.OpenGL.internalGL.glGetPixelTexGenParameterivSGIS = (dgtk.OpenGL.delegatesGL.glGetPixelTexGenParameterivSGIS) InternalTool.GetGLMethodAdress("glGetPixelTexGenParameterivSGIS", typeof(dgtk.OpenGL.delegatesGL.glGetPixelTexGenParameterivSGIS));
			}
			if (SuportedExt.Contains("glGetPixelTransformParameterfvEXT"))
			{
				dgtk.OpenGL.internalGL.glGetPixelTransformParameterfvEXT = (dgtk.OpenGL.delegatesGL.glGetPixelTransformParameterfvEXT) InternalTool.GetGLMethodAdress("glGetPixelTransformParameterfvEXT", typeof(dgtk.OpenGL.delegatesGL.glGetPixelTransformParameterfvEXT));
			}
			if (SuportedExt.Contains("glGetPixelTransformParameterivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetPixelTransformParameterivEXT = (dgtk.OpenGL.delegatesGL.glGetPixelTransformParameterivEXT) InternalTool.GetGLMethodAdress("glGetPixelTransformParameterivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetPixelTransformParameterivEXT));
			}
			if (SuportedExt.Contains("glGetPointeri_vEXT"))
			{
				dgtk.OpenGL.internalGL.glGetPointeri_vEXT = (dgtk.OpenGL.delegatesGL.glGetPointeri_vEXT) InternalTool.GetGLMethodAdress("glGetPointeri_vEXT", typeof(dgtk.OpenGL.delegatesGL.glGetPointeri_vEXT));
			}
			if (SuportedExt.Contains("glGetPointerIndexedvEXT"))
			{
				dgtk.OpenGL.internalGL.glGetPointerIndexedvEXT = (dgtk.OpenGL.delegatesGL.glGetPointerIndexedvEXT) InternalTool.GetGLMethodAdress("glGetPointerIndexedvEXT", typeof(dgtk.OpenGL.delegatesGL.glGetPointerIndexedvEXT));
			}
			if (SuportedExt.Contains("glGetPointervEXT"))
			{
				dgtk.OpenGL.internalGL.glGetPointervEXT = (dgtk.OpenGL.delegatesGL.glGetPointervEXT) InternalTool.GetGLMethodAdress("glGetPointervEXT", typeof(dgtk.OpenGL.delegatesGL.glGetPointervEXT));
			}
			if (SuportedExt.Contains("glGetPointervKHR"))
			{
				dgtk.OpenGL.internalGL.glGetPointervKHR = (dgtk.OpenGL.delegatesGL.glGetPointervKHR) InternalTool.GetGLMethodAdress("glGetPointervKHR", typeof(dgtk.OpenGL.delegatesGL.glGetPointervKHR));
			}
			if (SuportedExt.Contains("glGetProgramBinaryOES"))
			{
				dgtk.OpenGL.internalGL.glGetProgramBinaryOES = (dgtk.OpenGL.delegatesGL.glGetProgramBinaryOES) InternalTool.GetGLMethodAdress("glGetProgramBinaryOES", typeof(dgtk.OpenGL.delegatesGL.glGetProgramBinaryOES));
			}
			if (SuportedExt.Contains("glGetProgramEnvParameterdvARB"))
			{
				dgtk.OpenGL.internalGL.glGetProgramEnvParameterdvARB = (dgtk.OpenGL.delegatesGL.glGetProgramEnvParameterdvARB) InternalTool.GetGLMethodAdress("glGetProgramEnvParameterdvARB", typeof(dgtk.OpenGL.delegatesGL.glGetProgramEnvParameterdvARB));
			}
			if (SuportedExt.Contains("glGetProgramEnvParameterfvARB"))
			{
				dgtk.OpenGL.internalGL.glGetProgramEnvParameterfvARB = (dgtk.OpenGL.delegatesGL.glGetProgramEnvParameterfvARB) InternalTool.GetGLMethodAdress("glGetProgramEnvParameterfvARB", typeof(dgtk.OpenGL.delegatesGL.glGetProgramEnvParameterfvARB));
			}
			if (SuportedExt.Contains("glGetProgramEnvParameterIivNV"))
			{
				dgtk.OpenGL.internalGL.glGetProgramEnvParameterIivNV = (dgtk.OpenGL.delegatesGL.glGetProgramEnvParameterIivNV) InternalTool.GetGLMethodAdress("glGetProgramEnvParameterIivNV", typeof(dgtk.OpenGL.delegatesGL.glGetProgramEnvParameterIivNV));
			}
			if (SuportedExt.Contains("glGetProgramEnvParameterIuivNV"))
			{
				dgtk.OpenGL.internalGL.glGetProgramEnvParameterIuivNV = (dgtk.OpenGL.delegatesGL.glGetProgramEnvParameterIuivNV) InternalTool.GetGLMethodAdress("glGetProgramEnvParameterIuivNV", typeof(dgtk.OpenGL.delegatesGL.glGetProgramEnvParameterIuivNV));
			}
			if (SuportedExt.Contains("glGetProgramivARB"))
			{
				dgtk.OpenGL.internalGL.glGetProgramivARB = (dgtk.OpenGL.delegatesGL.glGetProgramivARB) InternalTool.GetGLMethodAdress("glGetProgramivARB", typeof(dgtk.OpenGL.delegatesGL.glGetProgramivARB));
			}
			if (SuportedExt.Contains("glGetProgramivNV"))
			{
				dgtk.OpenGL.internalGL.glGetProgramivNV = (dgtk.OpenGL.delegatesGL.glGetProgramivNV) InternalTool.GetGLMethodAdress("glGetProgramivNV", typeof(dgtk.OpenGL.delegatesGL.glGetProgramivNV));
			}
			if (SuportedExt.Contains("glGetProgramLocalParameterdvARB"))
			{
				dgtk.OpenGL.internalGL.glGetProgramLocalParameterdvARB = (dgtk.OpenGL.delegatesGL.glGetProgramLocalParameterdvARB) InternalTool.GetGLMethodAdress("glGetProgramLocalParameterdvARB", typeof(dgtk.OpenGL.delegatesGL.glGetProgramLocalParameterdvARB));
			}
			if (SuportedExt.Contains("glGetProgramLocalParameterfvARB"))
			{
				dgtk.OpenGL.internalGL.glGetProgramLocalParameterfvARB = (dgtk.OpenGL.delegatesGL.glGetProgramLocalParameterfvARB) InternalTool.GetGLMethodAdress("glGetProgramLocalParameterfvARB", typeof(dgtk.OpenGL.delegatesGL.glGetProgramLocalParameterfvARB));
			}
			if (SuportedExt.Contains("glGetProgramLocalParameterIivNV"))
			{
				dgtk.OpenGL.internalGL.glGetProgramLocalParameterIivNV = (dgtk.OpenGL.delegatesGL.glGetProgramLocalParameterIivNV) InternalTool.GetGLMethodAdress("glGetProgramLocalParameterIivNV", typeof(dgtk.OpenGL.delegatesGL.glGetProgramLocalParameterIivNV));
			}
			if (SuportedExt.Contains("glGetProgramLocalParameterIuivNV"))
			{
				dgtk.OpenGL.internalGL.glGetProgramLocalParameterIuivNV = (dgtk.OpenGL.delegatesGL.glGetProgramLocalParameterIuivNV) InternalTool.GetGLMethodAdress("glGetProgramLocalParameterIuivNV", typeof(dgtk.OpenGL.delegatesGL.glGetProgramLocalParameterIuivNV));
			}
			if (SuportedExt.Contains("glGetProgramNamedParameterdvNV"))
			{
				dgtk.OpenGL.internalGL.glGetProgramNamedParameterdvNV = (dgtk.OpenGL.delegatesGL.glGetProgramNamedParameterdvNV) InternalTool.GetGLMethodAdress("glGetProgramNamedParameterdvNV", typeof(dgtk.OpenGL.delegatesGL.glGetProgramNamedParameterdvNV));
			}
			if (SuportedExt.Contains("glGetProgramNamedParameterfvNV"))
			{
				dgtk.OpenGL.internalGL.glGetProgramNamedParameterfvNV = (dgtk.OpenGL.delegatesGL.glGetProgramNamedParameterfvNV) InternalTool.GetGLMethodAdress("glGetProgramNamedParameterfvNV", typeof(dgtk.OpenGL.delegatesGL.glGetProgramNamedParameterfvNV));
			}
			if (SuportedExt.Contains("glGetProgramParameterdvNV"))
			{
				dgtk.OpenGL.internalGL.glGetProgramParameterdvNV = (dgtk.OpenGL.delegatesGL.glGetProgramParameterdvNV) InternalTool.GetGLMethodAdress("glGetProgramParameterdvNV", typeof(dgtk.OpenGL.delegatesGL.glGetProgramParameterdvNV));
			}
			if (SuportedExt.Contains("glGetProgramParameterfvNV"))
			{
				dgtk.OpenGL.internalGL.glGetProgramParameterfvNV = (dgtk.OpenGL.delegatesGL.glGetProgramParameterfvNV) InternalTool.GetGLMethodAdress("glGetProgramParameterfvNV", typeof(dgtk.OpenGL.delegatesGL.glGetProgramParameterfvNV));
			}
			if (SuportedExt.Contains("glGetProgramPipelineInfoLogEXT"))
			{
				dgtk.OpenGL.internalGL.glGetProgramPipelineInfoLogEXT = (dgtk.OpenGL.delegatesGL.glGetProgramPipelineInfoLogEXT) InternalTool.GetGLMethodAdress("glGetProgramPipelineInfoLogEXT", typeof(dgtk.OpenGL.delegatesGL.glGetProgramPipelineInfoLogEXT));
			}
			if (SuportedExt.Contains("glGetProgramPipelineivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetProgramPipelineivEXT = (dgtk.OpenGL.delegatesGL.glGetProgramPipelineivEXT) InternalTool.GetGLMethodAdress("glGetProgramPipelineivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetProgramPipelineivEXT));
			}
			if (SuportedExt.Contains("glGetProgramResourcefvNV"))
			{
				dgtk.OpenGL.internalGL.glGetProgramResourcefvNV = (dgtk.OpenGL.delegatesGL.glGetProgramResourcefvNV) InternalTool.GetGLMethodAdress("glGetProgramResourcefvNV", typeof(dgtk.OpenGL.delegatesGL.glGetProgramResourcefvNV));
			}
			if (SuportedExt.Contains("glGetProgramResourceLocationIndexEXT"))
			{
				dgtk.OpenGL.internalGL.glGetProgramResourceLocationIndexEXT = (dgtk.OpenGL.delegatesGL.glGetProgramResourceLocationIndexEXT) InternalTool.GetGLMethodAdress("glGetProgramResourceLocationIndexEXT", typeof(dgtk.OpenGL.delegatesGL.glGetProgramResourceLocationIndexEXT));
			}
			if (SuportedExt.Contains("glGetProgramStringARB"))
			{
				dgtk.OpenGL.internalGL.glGetProgramStringARB = (dgtk.OpenGL.delegatesGL.glGetProgramStringARB) InternalTool.GetGLMethodAdress("glGetProgramStringARB", typeof(dgtk.OpenGL.delegatesGL.glGetProgramStringARB));
			}
			if (SuportedExt.Contains("glGetProgramStringNV"))
			{
				dgtk.OpenGL.internalGL.glGetProgramStringNV = (dgtk.OpenGL.delegatesGL.glGetProgramStringNV) InternalTool.GetGLMethodAdress("glGetProgramStringNV", typeof(dgtk.OpenGL.delegatesGL.glGetProgramStringNV));
			}
			if (SuportedExt.Contains("glGetProgramSubroutineParameteruivNV"))
			{
				dgtk.OpenGL.internalGL.glGetProgramSubroutineParameteruivNV = (dgtk.OpenGL.delegatesGL.glGetProgramSubroutineParameteruivNV) InternalTool.GetGLMethodAdress("glGetProgramSubroutineParameteruivNV", typeof(dgtk.OpenGL.delegatesGL.glGetProgramSubroutineParameteruivNV));
			}
			if (SuportedExt.Contains("glGetQueryivARB"))
			{
				dgtk.OpenGL.internalGL.glGetQueryivARB = (dgtk.OpenGL.delegatesGL.glGetQueryivARB) InternalTool.GetGLMethodAdress("glGetQueryivARB", typeof(dgtk.OpenGL.delegatesGL.glGetQueryivARB));
			}
			if (SuportedExt.Contains("glGetQueryivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetQueryivEXT = (dgtk.OpenGL.delegatesGL.glGetQueryivEXT) InternalTool.GetGLMethodAdress("glGetQueryivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetQueryivEXT));
			}
			if (SuportedExt.Contains("glGetQueryObjecti64vEXT"))
			{
				dgtk.OpenGL.internalGL.glGetQueryObjecti64vEXT = (dgtk.OpenGL.delegatesGL.glGetQueryObjecti64vEXT) InternalTool.GetGLMethodAdress("glGetQueryObjecti64vEXT", typeof(dgtk.OpenGL.delegatesGL.glGetQueryObjecti64vEXT));
			}
			if (SuportedExt.Contains("glGetQueryObjectivARB"))
			{
				dgtk.OpenGL.internalGL.glGetQueryObjectivARB = (dgtk.OpenGL.delegatesGL.glGetQueryObjectivARB) InternalTool.GetGLMethodAdress("glGetQueryObjectivARB", typeof(dgtk.OpenGL.delegatesGL.glGetQueryObjectivARB));
			}
			if (SuportedExt.Contains("glGetQueryObjectivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetQueryObjectivEXT = (dgtk.OpenGL.delegatesGL.glGetQueryObjectivEXT) InternalTool.GetGLMethodAdress("glGetQueryObjectivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetQueryObjectivEXT));
			}
			if (SuportedExt.Contains("glGetQueryObjectui64vEXT"))
			{
				dgtk.OpenGL.internalGL.glGetQueryObjectui64vEXT = (dgtk.OpenGL.delegatesGL.glGetQueryObjectui64vEXT) InternalTool.GetGLMethodAdress("glGetQueryObjectui64vEXT", typeof(dgtk.OpenGL.delegatesGL.glGetQueryObjectui64vEXT));
			}
			if (SuportedExt.Contains("glGetQueryObjectuivARB"))
			{
				dgtk.OpenGL.internalGL.glGetQueryObjectuivARB = (dgtk.OpenGL.delegatesGL.glGetQueryObjectuivARB) InternalTool.GetGLMethodAdress("glGetQueryObjectuivARB", typeof(dgtk.OpenGL.delegatesGL.glGetQueryObjectuivARB));
			}
			if (SuportedExt.Contains("glGetQueryObjectuivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetQueryObjectuivEXT = (dgtk.OpenGL.delegatesGL.glGetQueryObjectuivEXT) InternalTool.GetGLMethodAdress("glGetQueryObjectuivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetQueryObjectuivEXT));
			}
			if (SuportedExt.Contains("glGetRenderbufferParameterivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetRenderbufferParameterivEXT = (dgtk.OpenGL.delegatesGL.glGetRenderbufferParameterivEXT) InternalTool.GetGLMethodAdress("glGetRenderbufferParameterivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetRenderbufferParameterivEXT));
			}
			if (SuportedExt.Contains("glGetRenderbufferParameterivOES"))
			{
				dgtk.OpenGL.internalGL.glGetRenderbufferParameterivOES = (dgtk.OpenGL.delegatesGL.glGetRenderbufferParameterivOES) InternalTool.GetGLMethodAdress("glGetRenderbufferParameterivOES", typeof(dgtk.OpenGL.delegatesGL.glGetRenderbufferParameterivOES));
			}
			if (SuportedExt.Contains("glGetSamplerParameterIivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetSamplerParameterIivEXT = (dgtk.OpenGL.delegatesGL.glGetSamplerParameterIivEXT) InternalTool.GetGLMethodAdress("glGetSamplerParameterIivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetSamplerParameterIivEXT));
			}
			if (SuportedExt.Contains("glGetSamplerParameterIivOES"))
			{
				dgtk.OpenGL.internalGL.glGetSamplerParameterIivOES = (dgtk.OpenGL.delegatesGL.glGetSamplerParameterIivOES) InternalTool.GetGLMethodAdress("glGetSamplerParameterIivOES", typeof(dgtk.OpenGL.delegatesGL.glGetSamplerParameterIivOES));
			}
			if (SuportedExt.Contains("glGetSamplerParameterIuivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetSamplerParameterIuivEXT = (dgtk.OpenGL.delegatesGL.glGetSamplerParameterIuivEXT) InternalTool.GetGLMethodAdress("glGetSamplerParameterIuivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetSamplerParameterIuivEXT));
			}
			if (SuportedExt.Contains("glGetSamplerParameterIuivOES"))
			{
				dgtk.OpenGL.internalGL.glGetSamplerParameterIuivOES = (dgtk.OpenGL.delegatesGL.glGetSamplerParameterIuivOES) InternalTool.GetGLMethodAdress("glGetSamplerParameterIuivOES", typeof(dgtk.OpenGL.delegatesGL.glGetSamplerParameterIuivOES));
			}
			if (SuportedExt.Contains("glGetSemaphoreParameterivNV"))
			{
				dgtk.OpenGL.internalGL.glGetSemaphoreParameterivNV = (dgtk.OpenGL.delegatesGL.glGetSemaphoreParameterivNV) InternalTool.GetGLMethodAdress("glGetSemaphoreParameterivNV", typeof(dgtk.OpenGL.delegatesGL.glGetSemaphoreParameterivNV));
			}
			if (SuportedExt.Contains("glGetSemaphoreParameterui64vEXT"))
			{
				dgtk.OpenGL.internalGL.glGetSemaphoreParameterui64vEXT = (dgtk.OpenGL.delegatesGL.glGetSemaphoreParameterui64vEXT) InternalTool.GetGLMethodAdress("glGetSemaphoreParameterui64vEXT", typeof(dgtk.OpenGL.delegatesGL.glGetSemaphoreParameterui64vEXT));
			}
			if (SuportedExt.Contains("glGetSeparableFilter"))
			{
				dgtk.OpenGL.internalGL.glGetSeparableFilter = (dgtk.OpenGL.delegatesGL.glGetSeparableFilter) InternalTool.GetGLMethodAdress("glGetSeparableFilter", typeof(dgtk.OpenGL.delegatesGL.glGetSeparableFilter));
			}
			if (SuportedExt.Contains("glGetSeparableFilterEXT"))
			{
				dgtk.OpenGL.internalGL.glGetSeparableFilterEXT = (dgtk.OpenGL.delegatesGL.glGetSeparableFilterEXT) InternalTool.GetGLMethodAdress("glGetSeparableFilterEXT", typeof(dgtk.OpenGL.delegatesGL.glGetSeparableFilterEXT));
			}
			if (SuportedExt.Contains("glGetShaderSourceARB"))
			{
				dgtk.OpenGL.internalGL.glGetShaderSourceARB = (dgtk.OpenGL.delegatesGL.glGetShaderSourceARB) InternalTool.GetGLMethodAdress("glGetShaderSourceARB", typeof(dgtk.OpenGL.delegatesGL.glGetShaderSourceARB));
			}
			if (SuportedExt.Contains("glGetShadingRateImagePaletteNV"))
			{
				dgtk.OpenGL.internalGL.glGetShadingRateImagePaletteNV = (dgtk.OpenGL.delegatesGL.glGetShadingRateImagePaletteNV) InternalTool.GetGLMethodAdress("glGetShadingRateImagePaletteNV", typeof(dgtk.OpenGL.delegatesGL.glGetShadingRateImagePaletteNV));
			}
			if (SuportedExt.Contains("glGetShadingRateSampleLocationivNV"))
			{
				dgtk.OpenGL.internalGL.glGetShadingRateSampleLocationivNV = (dgtk.OpenGL.delegatesGL.glGetShadingRateSampleLocationivNV) InternalTool.GetGLMethodAdress("glGetShadingRateSampleLocationivNV", typeof(dgtk.OpenGL.delegatesGL.glGetShadingRateSampleLocationivNV));
			}
			if (SuportedExt.Contains("glGetSharpenTexFuncSGIS"))
			{
				dgtk.OpenGL.internalGL.glGetSharpenTexFuncSGIS = (dgtk.OpenGL.delegatesGL.glGetSharpenTexFuncSGIS) InternalTool.GetGLMethodAdress("glGetSharpenTexFuncSGIS", typeof(dgtk.OpenGL.delegatesGL.glGetSharpenTexFuncSGIS));
			}
			if (SuportedExt.Contains("glGetStageIndexNV"))
			{
				dgtk.OpenGL.internalGL.glGetStageIndexNV = (dgtk.OpenGL.delegatesGL.glGetStageIndexNV) InternalTool.GetGLMethodAdress("glGetStageIndexNV", typeof(dgtk.OpenGL.delegatesGL.glGetStageIndexNV));
			}
			if (SuportedExt.Contains("glGetSyncivAPPLE"))
			{
				dgtk.OpenGL.internalGL.glGetSyncivAPPLE = (dgtk.OpenGL.delegatesGL.glGetSyncivAPPLE) InternalTool.GetGLMethodAdress("glGetSyncivAPPLE", typeof(dgtk.OpenGL.delegatesGL.glGetSyncivAPPLE));
			}
			if (SuportedExt.Contains("glGetTexBumpParameterfvATI"))
			{
				dgtk.OpenGL.internalGL.glGetTexBumpParameterfvATI = (dgtk.OpenGL.delegatesGL.glGetTexBumpParameterfvATI) InternalTool.GetGLMethodAdress("glGetTexBumpParameterfvATI", typeof(dgtk.OpenGL.delegatesGL.glGetTexBumpParameterfvATI));
			}
			if (SuportedExt.Contains("glGetTexBumpParameterivATI"))
			{
				dgtk.OpenGL.internalGL.glGetTexBumpParameterivATI = (dgtk.OpenGL.delegatesGL.glGetTexBumpParameterivATI) InternalTool.GetGLMethodAdress("glGetTexBumpParameterivATI", typeof(dgtk.OpenGL.delegatesGL.glGetTexBumpParameterivATI));
			}
			if (SuportedExt.Contains("glGetTexEnvxv"))
			{
				dgtk.OpenGL.internalGL.glGetTexEnvxv = (dgtk.OpenGL.delegatesGL.glGetTexEnvxv) InternalTool.GetGLMethodAdress("glGetTexEnvxv", typeof(dgtk.OpenGL.delegatesGL.glGetTexEnvxv));
			}
			if (SuportedExt.Contains("glGetTexEnvxvOES"))
			{
				dgtk.OpenGL.internalGL.glGetTexEnvxvOES = (dgtk.OpenGL.delegatesGL.glGetTexEnvxvOES) InternalTool.GetGLMethodAdress("glGetTexEnvxvOES", typeof(dgtk.OpenGL.delegatesGL.glGetTexEnvxvOES));
			}
			if (SuportedExt.Contains("glGetTexFilterFuncSGIS"))
			{
				dgtk.OpenGL.internalGL.glGetTexFilterFuncSGIS = (dgtk.OpenGL.delegatesGL.glGetTexFilterFuncSGIS) InternalTool.GetGLMethodAdress("glGetTexFilterFuncSGIS", typeof(dgtk.OpenGL.delegatesGL.glGetTexFilterFuncSGIS));
			}
			if (SuportedExt.Contains("glGetTexGenfvOES"))
			{
				dgtk.OpenGL.internalGL.glGetTexGenfvOES = (dgtk.OpenGL.delegatesGL.glGetTexGenfvOES) InternalTool.GetGLMethodAdress("glGetTexGenfvOES", typeof(dgtk.OpenGL.delegatesGL.glGetTexGenfvOES));
			}
			if (SuportedExt.Contains("glGetTexGenivOES"))
			{
				dgtk.OpenGL.internalGL.glGetTexGenivOES = (dgtk.OpenGL.delegatesGL.glGetTexGenivOES) InternalTool.GetGLMethodAdress("glGetTexGenivOES", typeof(dgtk.OpenGL.delegatesGL.glGetTexGenivOES));
			}
			if (SuportedExt.Contains("glGetTexGenxvOES"))
			{
				dgtk.OpenGL.internalGL.glGetTexGenxvOES = (dgtk.OpenGL.delegatesGL.glGetTexGenxvOES) InternalTool.GetGLMethodAdress("glGetTexGenxvOES", typeof(dgtk.OpenGL.delegatesGL.glGetTexGenxvOES));
			}
			if (SuportedExt.Contains("glGetTexLevelParameterxvOES"))
			{
				dgtk.OpenGL.internalGL.glGetTexLevelParameterxvOES = (dgtk.OpenGL.delegatesGL.glGetTexLevelParameterxvOES) InternalTool.GetGLMethodAdress("glGetTexLevelParameterxvOES", typeof(dgtk.OpenGL.delegatesGL.glGetTexLevelParameterxvOES));
			}
			if (SuportedExt.Contains("glGetTexParameterIivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetTexParameterIivEXT = (dgtk.OpenGL.delegatesGL.glGetTexParameterIivEXT) InternalTool.GetGLMethodAdress("glGetTexParameterIivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetTexParameterIivEXT));
			}
			if (SuportedExt.Contains("glGetTexParameterIivOES"))
			{
				dgtk.OpenGL.internalGL.glGetTexParameterIivOES = (dgtk.OpenGL.delegatesGL.glGetTexParameterIivOES) InternalTool.GetGLMethodAdress("glGetTexParameterIivOES", typeof(dgtk.OpenGL.delegatesGL.glGetTexParameterIivOES));
			}
			if (SuportedExt.Contains("glGetTexParameterIuivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetTexParameterIuivEXT = (dgtk.OpenGL.delegatesGL.glGetTexParameterIuivEXT) InternalTool.GetGLMethodAdress("glGetTexParameterIuivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetTexParameterIuivEXT));
			}
			if (SuportedExt.Contains("glGetTexParameterIuivOES"))
			{
				dgtk.OpenGL.internalGL.glGetTexParameterIuivOES = (dgtk.OpenGL.delegatesGL.glGetTexParameterIuivOES) InternalTool.GetGLMethodAdress("glGetTexParameterIuivOES", typeof(dgtk.OpenGL.delegatesGL.glGetTexParameterIuivOES));
			}
			if (SuportedExt.Contains("glGetTexParameterPointervAPPLE"))
			{
				dgtk.OpenGL.internalGL.glGetTexParameterPointervAPPLE = (dgtk.OpenGL.delegatesGL.glGetTexParameterPointervAPPLE) InternalTool.GetGLMethodAdress("glGetTexParameterPointervAPPLE", typeof(dgtk.OpenGL.delegatesGL.glGetTexParameterPointervAPPLE));
			}
			if (SuportedExt.Contains("glGetTexParameterxv"))
			{
				dgtk.OpenGL.internalGL.glGetTexParameterxv = (dgtk.OpenGL.delegatesGL.glGetTexParameterxv) InternalTool.GetGLMethodAdress("glGetTexParameterxv", typeof(dgtk.OpenGL.delegatesGL.glGetTexParameterxv));
			}
			if (SuportedExt.Contains("glGetTexParameterxvOES"))
			{
				dgtk.OpenGL.internalGL.glGetTexParameterxvOES = (dgtk.OpenGL.delegatesGL.glGetTexParameterxvOES) InternalTool.GetGLMethodAdress("glGetTexParameterxvOES", typeof(dgtk.OpenGL.delegatesGL.glGetTexParameterxvOES));
			}
			if (SuportedExt.Contains("glGetTextureHandleARB"))
			{
				dgtk.OpenGL.internalGL.glGetTextureHandleARB = (dgtk.OpenGL.delegatesGL.glGetTextureHandleARB) InternalTool.GetGLMethodAdress("glGetTextureHandleARB", typeof(dgtk.OpenGL.delegatesGL.glGetTextureHandleARB));
			}
			if (SuportedExt.Contains("glGetTextureHandleIMG"))
			{
				dgtk.OpenGL.internalGL.glGetTextureHandleIMG = (dgtk.OpenGL.delegatesGL.glGetTextureHandleIMG) InternalTool.GetGLMethodAdress("glGetTextureHandleIMG", typeof(dgtk.OpenGL.delegatesGL.glGetTextureHandleIMG));
			}
			if (SuportedExt.Contains("glGetTextureHandleNV"))
			{
				dgtk.OpenGL.internalGL.glGetTextureHandleNV = (dgtk.OpenGL.delegatesGL.glGetTextureHandleNV) InternalTool.GetGLMethodAdress("glGetTextureHandleNV", typeof(dgtk.OpenGL.delegatesGL.glGetTextureHandleNV));
			}
			if (SuportedExt.Contains("glGetTextureImageEXT"))
			{
				dgtk.OpenGL.internalGL.glGetTextureImageEXT = (dgtk.OpenGL.delegatesGL.glGetTextureImageEXT) InternalTool.GetGLMethodAdress("glGetTextureImageEXT", typeof(dgtk.OpenGL.delegatesGL.glGetTextureImageEXT));
			}
			if (SuportedExt.Contains("glGetTextureLevelParameterfvEXT"))
			{
				dgtk.OpenGL.internalGL.glGetTextureLevelParameterfvEXT = (dgtk.OpenGL.delegatesGL.glGetTextureLevelParameterfvEXT) InternalTool.GetGLMethodAdress("glGetTextureLevelParameterfvEXT", typeof(dgtk.OpenGL.delegatesGL.glGetTextureLevelParameterfvEXT));
			}
			if (SuportedExt.Contains("glGetTextureLevelParameterivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetTextureLevelParameterivEXT = (dgtk.OpenGL.delegatesGL.glGetTextureLevelParameterivEXT) InternalTool.GetGLMethodAdress("glGetTextureLevelParameterivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetTextureLevelParameterivEXT));
			}
			if (SuportedExt.Contains("glGetTextureParameterfvEXT"))
			{
				dgtk.OpenGL.internalGL.glGetTextureParameterfvEXT = (dgtk.OpenGL.delegatesGL.glGetTextureParameterfvEXT) InternalTool.GetGLMethodAdress("glGetTextureParameterfvEXT", typeof(dgtk.OpenGL.delegatesGL.glGetTextureParameterfvEXT));
			}
			if (SuportedExt.Contains("glGetTextureParameterIivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetTextureParameterIivEXT = (dgtk.OpenGL.delegatesGL.glGetTextureParameterIivEXT) InternalTool.GetGLMethodAdress("glGetTextureParameterIivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetTextureParameterIivEXT));
			}
			if (SuportedExt.Contains("glGetTextureParameterIuivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetTextureParameterIuivEXT = (dgtk.OpenGL.delegatesGL.glGetTextureParameterIuivEXT) InternalTool.GetGLMethodAdress("glGetTextureParameterIuivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetTextureParameterIuivEXT));
			}
			if (SuportedExt.Contains("glGetTextureParameterivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetTextureParameterivEXT = (dgtk.OpenGL.delegatesGL.glGetTextureParameterivEXT) InternalTool.GetGLMethodAdress("glGetTextureParameterivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetTextureParameterivEXT));
			}
			if (SuportedExt.Contains("glGetTextureSamplerHandleARB"))
			{
				dgtk.OpenGL.internalGL.glGetTextureSamplerHandleARB = (dgtk.OpenGL.delegatesGL.glGetTextureSamplerHandleARB) InternalTool.GetGLMethodAdress("glGetTextureSamplerHandleARB", typeof(dgtk.OpenGL.delegatesGL.glGetTextureSamplerHandleARB));
			}
			if (SuportedExt.Contains("glGetTextureSamplerHandleIMG"))
			{
				dgtk.OpenGL.internalGL.glGetTextureSamplerHandleIMG = (dgtk.OpenGL.delegatesGL.glGetTextureSamplerHandleIMG) InternalTool.GetGLMethodAdress("glGetTextureSamplerHandleIMG", typeof(dgtk.OpenGL.delegatesGL.glGetTextureSamplerHandleIMG));
			}
			if (SuportedExt.Contains("glGetTextureSamplerHandleNV"))
			{
				dgtk.OpenGL.internalGL.glGetTextureSamplerHandleNV = (dgtk.OpenGL.delegatesGL.glGetTextureSamplerHandleNV) InternalTool.GetGLMethodAdress("glGetTextureSamplerHandleNV", typeof(dgtk.OpenGL.delegatesGL.glGetTextureSamplerHandleNV));
			}
			if (SuportedExt.Contains("glGetTrackMatrixivNV"))
			{
				dgtk.OpenGL.internalGL.glGetTrackMatrixivNV = (dgtk.OpenGL.delegatesGL.glGetTrackMatrixivNV) InternalTool.GetGLMethodAdress("glGetTrackMatrixivNV", typeof(dgtk.OpenGL.delegatesGL.glGetTrackMatrixivNV));
			}
			if (SuportedExt.Contains("glGetTransformFeedbackVaryingEXT"))
			{
				dgtk.OpenGL.internalGL.glGetTransformFeedbackVaryingEXT = (dgtk.OpenGL.delegatesGL.glGetTransformFeedbackVaryingEXT) InternalTool.GetGLMethodAdress("glGetTransformFeedbackVaryingEXT", typeof(dgtk.OpenGL.delegatesGL.glGetTransformFeedbackVaryingEXT));
			}
			if (SuportedExt.Contains("glGetTransformFeedbackVaryingNV"))
			{
				dgtk.OpenGL.internalGL.glGetTransformFeedbackVaryingNV = (dgtk.OpenGL.delegatesGL.glGetTransformFeedbackVaryingNV) InternalTool.GetGLMethodAdress("glGetTransformFeedbackVaryingNV", typeof(dgtk.OpenGL.delegatesGL.glGetTransformFeedbackVaryingNV));
			}
			if (SuportedExt.Contains("glGetTranslatedShaderSourceANGLE"))
			{
				dgtk.OpenGL.internalGL.glGetTranslatedShaderSourceANGLE = (dgtk.OpenGL.delegatesGL.glGetTranslatedShaderSourceANGLE) InternalTool.GetGLMethodAdress("glGetTranslatedShaderSourceANGLE", typeof(dgtk.OpenGL.delegatesGL.glGetTranslatedShaderSourceANGLE));
			}
			if (SuportedExt.Contains("glGetUniformBufferSizeEXT"))
			{
				dgtk.OpenGL.internalGL.glGetUniformBufferSizeEXT = (dgtk.OpenGL.delegatesGL.glGetUniformBufferSizeEXT) InternalTool.GetGLMethodAdress("glGetUniformBufferSizeEXT", typeof(dgtk.OpenGL.delegatesGL.glGetUniformBufferSizeEXT));
			}
			if (SuportedExt.Contains("glGetUniformfvARB"))
			{
				dgtk.OpenGL.internalGL.glGetUniformfvARB = (dgtk.OpenGL.delegatesGL.glGetUniformfvARB) InternalTool.GetGLMethodAdress("glGetUniformfvARB", typeof(dgtk.OpenGL.delegatesGL.glGetUniformfvARB));
			}
			if (SuportedExt.Contains("glGetUniformi64vARB"))
			{
				dgtk.OpenGL.internalGL.glGetUniformi64vARB = (dgtk.OpenGL.delegatesGL.glGetUniformi64vARB) InternalTool.GetGLMethodAdress("glGetUniformi64vARB", typeof(dgtk.OpenGL.delegatesGL.glGetUniformi64vARB));
			}
			if (SuportedExt.Contains("glGetUniformi64vNV"))
			{
				dgtk.OpenGL.internalGL.glGetUniformi64vNV = (dgtk.OpenGL.delegatesGL.glGetUniformi64vNV) InternalTool.GetGLMethodAdress("glGetUniformi64vNV", typeof(dgtk.OpenGL.delegatesGL.glGetUniformi64vNV));
			}
			if (SuportedExt.Contains("glGetUniformivARB"))
			{
				dgtk.OpenGL.internalGL.glGetUniformivARB = (dgtk.OpenGL.delegatesGL.glGetUniformivARB) InternalTool.GetGLMethodAdress("glGetUniformivARB", typeof(dgtk.OpenGL.delegatesGL.glGetUniformivARB));
			}
			if (SuportedExt.Contains("glGetUniformLocationARB"))
			{
				dgtk.OpenGL.internalGL.glGetUniformLocationARB = (dgtk.OpenGL.delegatesGL.glGetUniformLocationARB) InternalTool.GetGLMethodAdress("glGetUniformLocationARB", typeof(dgtk.OpenGL.delegatesGL.glGetUniformLocationARB));
			}
			if (SuportedExt.Contains("glGetUniformOffsetEXT"))
			{
				dgtk.OpenGL.internalGL.glGetUniformOffsetEXT = (dgtk.OpenGL.delegatesGL.glGetUniformOffsetEXT) InternalTool.GetGLMethodAdress("glGetUniformOffsetEXT", typeof(dgtk.OpenGL.delegatesGL.glGetUniformOffsetEXT));
			}
			if (SuportedExt.Contains("glGetUniformui64vARB"))
			{
				dgtk.OpenGL.internalGL.glGetUniformui64vARB = (dgtk.OpenGL.delegatesGL.glGetUniformui64vARB) InternalTool.GetGLMethodAdress("glGetUniformui64vARB", typeof(dgtk.OpenGL.delegatesGL.glGetUniformui64vARB));
			}
			if (SuportedExt.Contains("glGetUniformui64vNV"))
			{
				dgtk.OpenGL.internalGL.glGetUniformui64vNV = (dgtk.OpenGL.delegatesGL.glGetUniformui64vNV) InternalTool.GetGLMethodAdress("glGetUniformui64vNV", typeof(dgtk.OpenGL.delegatesGL.glGetUniformui64vNV));
			}
			if (SuportedExt.Contains("glGetUniformuivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetUniformuivEXT = (dgtk.OpenGL.delegatesGL.glGetUniformuivEXT) InternalTool.GetGLMethodAdress("glGetUniformuivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetUniformuivEXT));
			}
			if (SuportedExt.Contains("glGetUnsignedBytei_vEXT"))
			{
				dgtk.OpenGL.internalGL.glGetUnsignedBytei_vEXT = (dgtk.OpenGL.delegatesGL.glGetUnsignedBytei_vEXT) InternalTool.GetGLMethodAdress("glGetUnsignedBytei_vEXT", typeof(dgtk.OpenGL.delegatesGL.glGetUnsignedBytei_vEXT));
			}
			if (SuportedExt.Contains("glGetUnsignedBytevEXT"))
			{
				dgtk.OpenGL.internalGL.glGetUnsignedBytevEXT = (dgtk.OpenGL.delegatesGL.glGetUnsignedBytevEXT) InternalTool.GetGLMethodAdress("glGetUnsignedBytevEXT", typeof(dgtk.OpenGL.delegatesGL.glGetUnsignedBytevEXT));
			}
			if (SuportedExt.Contains("glGetVariantArrayObjectfvATI"))
			{
				dgtk.OpenGL.internalGL.glGetVariantArrayObjectfvATI = (dgtk.OpenGL.delegatesGL.glGetVariantArrayObjectfvATI) InternalTool.GetGLMethodAdress("glGetVariantArrayObjectfvATI", typeof(dgtk.OpenGL.delegatesGL.glGetVariantArrayObjectfvATI));
			}
			if (SuportedExt.Contains("glGetVariantArrayObjectivATI"))
			{
				dgtk.OpenGL.internalGL.glGetVariantArrayObjectivATI = (dgtk.OpenGL.delegatesGL.glGetVariantArrayObjectivATI) InternalTool.GetGLMethodAdress("glGetVariantArrayObjectivATI", typeof(dgtk.OpenGL.delegatesGL.glGetVariantArrayObjectivATI));
			}
			if (SuportedExt.Contains("glGetVariantBooleanvEXT"))
			{
				dgtk.OpenGL.internalGL.glGetVariantBooleanvEXT = (dgtk.OpenGL.delegatesGL.glGetVariantBooleanvEXT) InternalTool.GetGLMethodAdress("glGetVariantBooleanvEXT", typeof(dgtk.OpenGL.delegatesGL.glGetVariantBooleanvEXT));
			}
			if (SuportedExt.Contains("glGetVariantFloatvEXT"))
			{
				dgtk.OpenGL.internalGL.glGetVariantFloatvEXT = (dgtk.OpenGL.delegatesGL.glGetVariantFloatvEXT) InternalTool.GetGLMethodAdress("glGetVariantFloatvEXT", typeof(dgtk.OpenGL.delegatesGL.glGetVariantFloatvEXT));
			}
			if (SuportedExt.Contains("glGetVariantIntegervEXT"))
			{
				dgtk.OpenGL.internalGL.glGetVariantIntegervEXT = (dgtk.OpenGL.delegatesGL.glGetVariantIntegervEXT) InternalTool.GetGLMethodAdress("glGetVariantIntegervEXT", typeof(dgtk.OpenGL.delegatesGL.glGetVariantIntegervEXT));
			}
			if (SuportedExt.Contains("glGetVariantPointervEXT"))
			{
				dgtk.OpenGL.internalGL.glGetVariantPointervEXT = (dgtk.OpenGL.delegatesGL.glGetVariantPointervEXT) InternalTool.GetGLMethodAdress("glGetVariantPointervEXT", typeof(dgtk.OpenGL.delegatesGL.glGetVariantPointervEXT));
			}
			if (SuportedExt.Contains("glGetVaryingLocationNV"))
			{
				dgtk.OpenGL.internalGL.glGetVaryingLocationNV = (dgtk.OpenGL.delegatesGL.glGetVaryingLocationNV) InternalTool.GetGLMethodAdress("glGetVaryingLocationNV", typeof(dgtk.OpenGL.delegatesGL.glGetVaryingLocationNV));
			}
			if (SuportedExt.Contains("glGetVertexArrayIntegeri_vEXT"))
			{
				dgtk.OpenGL.internalGL.glGetVertexArrayIntegeri_vEXT = (dgtk.OpenGL.delegatesGL.glGetVertexArrayIntegeri_vEXT) InternalTool.GetGLMethodAdress("glGetVertexArrayIntegeri_vEXT", typeof(dgtk.OpenGL.delegatesGL.glGetVertexArrayIntegeri_vEXT));
			}
			if (SuportedExt.Contains("glGetVertexArrayIntegervEXT"))
			{
				dgtk.OpenGL.internalGL.glGetVertexArrayIntegervEXT = (dgtk.OpenGL.delegatesGL.glGetVertexArrayIntegervEXT) InternalTool.GetGLMethodAdress("glGetVertexArrayIntegervEXT", typeof(dgtk.OpenGL.delegatesGL.glGetVertexArrayIntegervEXT));
			}
			if (SuportedExt.Contains("glGetVertexArrayPointeri_vEXT"))
			{
				dgtk.OpenGL.internalGL.glGetVertexArrayPointeri_vEXT = (dgtk.OpenGL.delegatesGL.glGetVertexArrayPointeri_vEXT) InternalTool.GetGLMethodAdress("glGetVertexArrayPointeri_vEXT", typeof(dgtk.OpenGL.delegatesGL.glGetVertexArrayPointeri_vEXT));
			}
			if (SuportedExt.Contains("glGetVertexArrayPointervEXT"))
			{
				dgtk.OpenGL.internalGL.glGetVertexArrayPointervEXT = (dgtk.OpenGL.delegatesGL.glGetVertexArrayPointervEXT) InternalTool.GetGLMethodAdress("glGetVertexArrayPointervEXT", typeof(dgtk.OpenGL.delegatesGL.glGetVertexArrayPointervEXT));
			}
			if (SuportedExt.Contains("glGetVertexAttribArrayObjectfvATI"))
			{
				dgtk.OpenGL.internalGL.glGetVertexAttribArrayObjectfvATI = (dgtk.OpenGL.delegatesGL.glGetVertexAttribArrayObjectfvATI) InternalTool.GetGLMethodAdress("glGetVertexAttribArrayObjectfvATI", typeof(dgtk.OpenGL.delegatesGL.glGetVertexAttribArrayObjectfvATI));
			}
			if (SuportedExt.Contains("glGetVertexAttribArrayObjectivATI"))
			{
				dgtk.OpenGL.internalGL.glGetVertexAttribArrayObjectivATI = (dgtk.OpenGL.delegatesGL.glGetVertexAttribArrayObjectivATI) InternalTool.GetGLMethodAdress("glGetVertexAttribArrayObjectivATI", typeof(dgtk.OpenGL.delegatesGL.glGetVertexAttribArrayObjectivATI));
			}
			if (SuportedExt.Contains("glGetVertexAttribdvARB"))
			{
				dgtk.OpenGL.internalGL.glGetVertexAttribdvARB = (dgtk.OpenGL.delegatesGL.glGetVertexAttribdvARB) InternalTool.GetGLMethodAdress("glGetVertexAttribdvARB", typeof(dgtk.OpenGL.delegatesGL.glGetVertexAttribdvARB));
			}
			if (SuportedExt.Contains("glGetVertexAttribdvNV"))
			{
				dgtk.OpenGL.internalGL.glGetVertexAttribdvNV = (dgtk.OpenGL.delegatesGL.glGetVertexAttribdvNV) InternalTool.GetGLMethodAdress("glGetVertexAttribdvNV", typeof(dgtk.OpenGL.delegatesGL.glGetVertexAttribdvNV));
			}
			if (SuportedExt.Contains("glGetVertexAttribfvARB"))
			{
				dgtk.OpenGL.internalGL.glGetVertexAttribfvARB = (dgtk.OpenGL.delegatesGL.glGetVertexAttribfvARB) InternalTool.GetGLMethodAdress("glGetVertexAttribfvARB", typeof(dgtk.OpenGL.delegatesGL.glGetVertexAttribfvARB));
			}
			if (SuportedExt.Contains("glGetVertexAttribfvNV"))
			{
				dgtk.OpenGL.internalGL.glGetVertexAttribfvNV = (dgtk.OpenGL.delegatesGL.glGetVertexAttribfvNV) InternalTool.GetGLMethodAdress("glGetVertexAttribfvNV", typeof(dgtk.OpenGL.delegatesGL.glGetVertexAttribfvNV));
			}
			if (SuportedExt.Contains("glGetVertexAttribIivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetVertexAttribIivEXT = (dgtk.OpenGL.delegatesGL.glGetVertexAttribIivEXT) InternalTool.GetGLMethodAdress("glGetVertexAttribIivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetVertexAttribIivEXT));
			}
			if (SuportedExt.Contains("glGetVertexAttribIuivEXT"))
			{
				dgtk.OpenGL.internalGL.glGetVertexAttribIuivEXT = (dgtk.OpenGL.delegatesGL.glGetVertexAttribIuivEXT) InternalTool.GetGLMethodAdress("glGetVertexAttribIuivEXT", typeof(dgtk.OpenGL.delegatesGL.glGetVertexAttribIuivEXT));
			}
			if (SuportedExt.Contains("glGetVertexAttribivARB"))
			{
				dgtk.OpenGL.internalGL.glGetVertexAttribivARB = (dgtk.OpenGL.delegatesGL.glGetVertexAttribivARB) InternalTool.GetGLMethodAdress("glGetVertexAttribivARB", typeof(dgtk.OpenGL.delegatesGL.glGetVertexAttribivARB));
			}
			if (SuportedExt.Contains("glGetVertexAttribivNV"))
			{
				dgtk.OpenGL.internalGL.glGetVertexAttribivNV = (dgtk.OpenGL.delegatesGL.glGetVertexAttribivNV) InternalTool.GetGLMethodAdress("glGetVertexAttribivNV", typeof(dgtk.OpenGL.delegatesGL.glGetVertexAttribivNV));
			}
			if (SuportedExt.Contains("glGetVertexAttribLdvEXT"))
			{
				dgtk.OpenGL.internalGL.glGetVertexAttribLdvEXT = (dgtk.OpenGL.delegatesGL.glGetVertexAttribLdvEXT) InternalTool.GetGLMethodAdress("glGetVertexAttribLdvEXT", typeof(dgtk.OpenGL.delegatesGL.glGetVertexAttribLdvEXT));
			}
			if (SuportedExt.Contains("glGetVertexAttribLi64vNV"))
			{
				dgtk.OpenGL.internalGL.glGetVertexAttribLi64vNV = (dgtk.OpenGL.delegatesGL.glGetVertexAttribLi64vNV) InternalTool.GetGLMethodAdress("glGetVertexAttribLi64vNV", typeof(dgtk.OpenGL.delegatesGL.glGetVertexAttribLi64vNV));
			}
			if (SuportedExt.Contains("glGetVertexAttribLui64vARB"))
			{
				dgtk.OpenGL.internalGL.glGetVertexAttribLui64vARB = (dgtk.OpenGL.delegatesGL.glGetVertexAttribLui64vARB) InternalTool.GetGLMethodAdress("glGetVertexAttribLui64vARB", typeof(dgtk.OpenGL.delegatesGL.glGetVertexAttribLui64vARB));
			}
			if (SuportedExt.Contains("glGetVertexAttribLui64vNV"))
			{
				dgtk.OpenGL.internalGL.glGetVertexAttribLui64vNV = (dgtk.OpenGL.delegatesGL.glGetVertexAttribLui64vNV) InternalTool.GetGLMethodAdress("glGetVertexAttribLui64vNV", typeof(dgtk.OpenGL.delegatesGL.glGetVertexAttribLui64vNV));
			}
			if (SuportedExt.Contains("glGetVertexAttribPointervARB"))
			{
				dgtk.OpenGL.internalGL.glGetVertexAttribPointervARB = (dgtk.OpenGL.delegatesGL.glGetVertexAttribPointervARB) InternalTool.GetGLMethodAdress("glGetVertexAttribPointervARB", typeof(dgtk.OpenGL.delegatesGL.glGetVertexAttribPointervARB));
			}
			if (SuportedExt.Contains("glGetVertexAttribPointervNV"))
			{
				dgtk.OpenGL.internalGL.glGetVertexAttribPointervNV = (dgtk.OpenGL.delegatesGL.glGetVertexAttribPointervNV) InternalTool.GetGLMethodAdress("glGetVertexAttribPointervNV", typeof(dgtk.OpenGL.delegatesGL.glGetVertexAttribPointervNV));
			}
			if (SuportedExt.Contains("glGetVideoCaptureivNV"))
			{
				dgtk.OpenGL.internalGL.glGetVideoCaptureivNV = (dgtk.OpenGL.delegatesGL.glGetVideoCaptureivNV) InternalTool.GetGLMethodAdress("glGetVideoCaptureivNV", typeof(dgtk.OpenGL.delegatesGL.glGetVideoCaptureivNV));
			}
			if (SuportedExt.Contains("glGetVideoCaptureStreamdvNV"))
			{
				dgtk.OpenGL.internalGL.glGetVideoCaptureStreamdvNV = (dgtk.OpenGL.delegatesGL.glGetVideoCaptureStreamdvNV) InternalTool.GetGLMethodAdress("glGetVideoCaptureStreamdvNV", typeof(dgtk.OpenGL.delegatesGL.glGetVideoCaptureStreamdvNV));
			}
			if (SuportedExt.Contains("glGetVideoCaptureStreamfvNV"))
			{
				dgtk.OpenGL.internalGL.glGetVideoCaptureStreamfvNV = (dgtk.OpenGL.delegatesGL.glGetVideoCaptureStreamfvNV) InternalTool.GetGLMethodAdress("glGetVideoCaptureStreamfvNV", typeof(dgtk.OpenGL.delegatesGL.glGetVideoCaptureStreamfvNV));
			}
			if (SuportedExt.Contains("glGetVideoCaptureStreamivNV"))
			{
				dgtk.OpenGL.internalGL.glGetVideoCaptureStreamivNV = (dgtk.OpenGL.delegatesGL.glGetVideoCaptureStreamivNV) InternalTool.GetGLMethodAdress("glGetVideoCaptureStreamivNV", typeof(dgtk.OpenGL.delegatesGL.glGetVideoCaptureStreamivNV));
			}
			if (SuportedExt.Contains("glGetVideoi64vNV"))
			{
				dgtk.OpenGL.internalGL.glGetVideoi64vNV = (dgtk.OpenGL.delegatesGL.glGetVideoi64vNV) InternalTool.GetGLMethodAdress("glGetVideoi64vNV", typeof(dgtk.OpenGL.delegatesGL.glGetVideoi64vNV));
			}
			if (SuportedExt.Contains("glGetVideoivNV"))
			{
				dgtk.OpenGL.internalGL.glGetVideoivNV = (dgtk.OpenGL.delegatesGL.glGetVideoivNV) InternalTool.GetGLMethodAdress("glGetVideoivNV", typeof(dgtk.OpenGL.delegatesGL.glGetVideoivNV));
			}
			if (SuportedExt.Contains("glGetVideoui64vNV"))
			{
				dgtk.OpenGL.internalGL.glGetVideoui64vNV = (dgtk.OpenGL.delegatesGL.glGetVideoui64vNV) InternalTool.GetGLMethodAdress("glGetVideoui64vNV", typeof(dgtk.OpenGL.delegatesGL.glGetVideoui64vNV));
			}
			if (SuportedExt.Contains("glGetVideouivNV"))
			{
				dgtk.OpenGL.internalGL.glGetVideouivNV = (dgtk.OpenGL.delegatesGL.glGetVideouivNV) InternalTool.GetGLMethodAdress("glGetVideouivNV", typeof(dgtk.OpenGL.delegatesGL.glGetVideouivNV));
			}
			if (SuportedExt.Contains("glGetVkProcAddrNV"))
			{
				dgtk.OpenGL.internalGL.glGetVkProcAddrNV = (dgtk.OpenGL.delegatesGL.glGetVkProcAddrNV) InternalTool.GetGLMethodAdress("glGetVkProcAddrNV", typeof(dgtk.OpenGL.delegatesGL.glGetVkProcAddrNV));
			}
			if (SuportedExt.Contains("glGlobalAlphaFactorbSUN"))
			{
				dgtk.OpenGL.internalGL.glGlobalAlphaFactorbSUN = (dgtk.OpenGL.delegatesGL.glGlobalAlphaFactorbSUN) InternalTool.GetGLMethodAdress("glGlobalAlphaFactorbSUN", typeof(dgtk.OpenGL.delegatesGL.glGlobalAlphaFactorbSUN));
			}
			if (SuportedExt.Contains("glGlobalAlphaFactordSUN"))
			{
				dgtk.OpenGL.internalGL.glGlobalAlphaFactordSUN = (dgtk.OpenGL.delegatesGL.glGlobalAlphaFactordSUN) InternalTool.GetGLMethodAdress("glGlobalAlphaFactordSUN", typeof(dgtk.OpenGL.delegatesGL.glGlobalAlphaFactordSUN));
			}
			if (SuportedExt.Contains("glGlobalAlphaFactorfSUN"))
			{
				dgtk.OpenGL.internalGL.glGlobalAlphaFactorfSUN = (dgtk.OpenGL.delegatesGL.glGlobalAlphaFactorfSUN) InternalTool.GetGLMethodAdress("glGlobalAlphaFactorfSUN", typeof(dgtk.OpenGL.delegatesGL.glGlobalAlphaFactorfSUN));
			}
			if (SuportedExt.Contains("glGlobalAlphaFactoriSUN"))
			{
				dgtk.OpenGL.internalGL.glGlobalAlphaFactoriSUN = (dgtk.OpenGL.delegatesGL.glGlobalAlphaFactoriSUN) InternalTool.GetGLMethodAdress("glGlobalAlphaFactoriSUN", typeof(dgtk.OpenGL.delegatesGL.glGlobalAlphaFactoriSUN));
			}
			if (SuportedExt.Contains("glGlobalAlphaFactorsSUN"))
			{
				dgtk.OpenGL.internalGL.glGlobalAlphaFactorsSUN = (dgtk.OpenGL.delegatesGL.glGlobalAlphaFactorsSUN) InternalTool.GetGLMethodAdress("glGlobalAlphaFactorsSUN", typeof(dgtk.OpenGL.delegatesGL.glGlobalAlphaFactorsSUN));
			}
			if (SuportedExt.Contains("glGlobalAlphaFactorubSUN"))
			{
				dgtk.OpenGL.internalGL.glGlobalAlphaFactorubSUN = (dgtk.OpenGL.delegatesGL.glGlobalAlphaFactorubSUN) InternalTool.GetGLMethodAdress("glGlobalAlphaFactorubSUN", typeof(dgtk.OpenGL.delegatesGL.glGlobalAlphaFactorubSUN));
			}
			if (SuportedExt.Contains("glGlobalAlphaFactoruiSUN"))
			{
				dgtk.OpenGL.internalGL.glGlobalAlphaFactoruiSUN = (dgtk.OpenGL.delegatesGL.glGlobalAlphaFactoruiSUN) InternalTool.GetGLMethodAdress("glGlobalAlphaFactoruiSUN", typeof(dgtk.OpenGL.delegatesGL.glGlobalAlphaFactoruiSUN));
			}
			if (SuportedExt.Contains("glGlobalAlphaFactorusSUN"))
			{
				dgtk.OpenGL.internalGL.glGlobalAlphaFactorusSUN = (dgtk.OpenGL.delegatesGL.glGlobalAlphaFactorusSUN) InternalTool.GetGLMethodAdress("glGlobalAlphaFactorusSUN", typeof(dgtk.OpenGL.delegatesGL.glGlobalAlphaFactorusSUN));
			}
			#endregion

			#region H:

			if (SuportedExt.Contains("glHintPGI"))
			{
				dgtk.OpenGL.internalGL.glHintPGI = (dgtk.OpenGL.delegatesGL.glHintPGI) InternalTool.GetGLMethodAdress("glHintPGI", typeof(dgtk.OpenGL.delegatesGL.glHintPGI));
			}
			if (SuportedExt.Contains("glHistogram"))
			{
				dgtk.OpenGL.internalGL.glHistogram = (dgtk.OpenGL.delegatesGL.glHistogram) InternalTool.GetGLMethodAdress("glHistogram", typeof(dgtk.OpenGL.delegatesGL.glHistogram));
			}
			if (SuportedExt.Contains("glHistogramEXT"))
			{
				dgtk.OpenGL.internalGL.glHistogramEXT = (dgtk.OpenGL.delegatesGL.glHistogramEXT) InternalTool.GetGLMethodAdress("glHistogramEXT", typeof(dgtk.OpenGL.delegatesGL.glHistogramEXT));
			}
			#endregion

			#region I:

			if (SuportedExt.Contains("glIglooInterfaceSGIX"))
			{
				dgtk.OpenGL.internalGL.glIglooInterfaceSGIX = (dgtk.OpenGL.delegatesGL.glIglooInterfaceSGIX) InternalTool.GetGLMethodAdress("glIglooInterfaceSGIX", typeof(dgtk.OpenGL.delegatesGL.glIglooInterfaceSGIX));
			}
			if (SuportedExt.Contains("glImageTransformParameterfHP"))
			{
				dgtk.OpenGL.internalGL.glImageTransformParameterfHP = (dgtk.OpenGL.delegatesGL.glImageTransformParameterfHP) InternalTool.GetGLMethodAdress("glImageTransformParameterfHP", typeof(dgtk.OpenGL.delegatesGL.glImageTransformParameterfHP));
			}
			if (SuportedExt.Contains("glImageTransformParameterfvHP"))
			{
				dgtk.OpenGL.internalGL.glImageTransformParameterfvHP = (dgtk.OpenGL.delegatesGL.glImageTransformParameterfvHP) InternalTool.GetGLMethodAdress("glImageTransformParameterfvHP", typeof(dgtk.OpenGL.delegatesGL.glImageTransformParameterfvHP));
			}
			if (SuportedExt.Contains("glImageTransformParameteriHP"))
			{
				dgtk.OpenGL.internalGL.glImageTransformParameteriHP = (dgtk.OpenGL.delegatesGL.glImageTransformParameteriHP) InternalTool.GetGLMethodAdress("glImageTransformParameteriHP", typeof(dgtk.OpenGL.delegatesGL.glImageTransformParameteriHP));
			}
			if (SuportedExt.Contains("glImageTransformParameterivHP"))
			{
				dgtk.OpenGL.internalGL.glImageTransformParameterivHP = (dgtk.OpenGL.delegatesGL.glImageTransformParameterivHP) InternalTool.GetGLMethodAdress("glImageTransformParameterivHP", typeof(dgtk.OpenGL.delegatesGL.glImageTransformParameterivHP));
			}
			if (SuportedExt.Contains("glImportMemoryFdEXT"))
			{
				dgtk.OpenGL.internalGL.glImportMemoryFdEXT = (dgtk.OpenGL.delegatesGL.glImportMemoryFdEXT) InternalTool.GetGLMethodAdress("glImportMemoryFdEXT", typeof(dgtk.OpenGL.delegatesGL.glImportMemoryFdEXT));
			}
			if (SuportedExt.Contains("glImportMemoryWin32HandleEXT"))
			{
				dgtk.OpenGL.internalGL.glImportMemoryWin32HandleEXT = (dgtk.OpenGL.delegatesGL.glImportMemoryWin32HandleEXT) InternalTool.GetGLMethodAdress("glImportMemoryWin32HandleEXT", typeof(dgtk.OpenGL.delegatesGL.glImportMemoryWin32HandleEXT));
			}
			if (SuportedExt.Contains("glImportMemoryWin32NameEXT"))
			{
				dgtk.OpenGL.internalGL.glImportMemoryWin32NameEXT = (dgtk.OpenGL.delegatesGL.glImportMemoryWin32NameEXT) InternalTool.GetGLMethodAdress("glImportMemoryWin32NameEXT", typeof(dgtk.OpenGL.delegatesGL.glImportMemoryWin32NameEXT));
			}
			if (SuportedExt.Contains("glImportSemaphoreFdEXT"))
			{
				dgtk.OpenGL.internalGL.glImportSemaphoreFdEXT = (dgtk.OpenGL.delegatesGL.glImportSemaphoreFdEXT) InternalTool.GetGLMethodAdress("glImportSemaphoreFdEXT", typeof(dgtk.OpenGL.delegatesGL.glImportSemaphoreFdEXT));
			}
			if (SuportedExt.Contains("glImportSemaphoreWin32HandleEXT"))
			{
				dgtk.OpenGL.internalGL.glImportSemaphoreWin32HandleEXT = (dgtk.OpenGL.delegatesGL.glImportSemaphoreWin32HandleEXT) InternalTool.GetGLMethodAdress("glImportSemaphoreWin32HandleEXT", typeof(dgtk.OpenGL.delegatesGL.glImportSemaphoreWin32HandleEXT));
			}
			if (SuportedExt.Contains("glImportSemaphoreWin32NameEXT"))
			{
				dgtk.OpenGL.internalGL.glImportSemaphoreWin32NameEXT = (dgtk.OpenGL.delegatesGL.glImportSemaphoreWin32NameEXT) InternalTool.GetGLMethodAdress("glImportSemaphoreWin32NameEXT", typeof(dgtk.OpenGL.delegatesGL.glImportSemaphoreWin32NameEXT));
			}
			if (SuportedExt.Contains("glImportSyncEXT"))
			{
				dgtk.OpenGL.internalGL.glImportSyncEXT = (dgtk.OpenGL.delegatesGL.glImportSyncEXT) InternalTool.GetGLMethodAdress("glImportSyncEXT", typeof(dgtk.OpenGL.delegatesGL.glImportSyncEXT));
			}
			if (SuportedExt.Contains("glIndexFormatNV"))
			{
				dgtk.OpenGL.internalGL.glIndexFormatNV = (dgtk.OpenGL.delegatesGL.glIndexFormatNV) InternalTool.GetGLMethodAdress("glIndexFormatNV", typeof(dgtk.OpenGL.delegatesGL.glIndexFormatNV));
			}
			if (SuportedExt.Contains("glIndexFuncEXT"))
			{
				dgtk.OpenGL.internalGL.glIndexFuncEXT = (dgtk.OpenGL.delegatesGL.glIndexFuncEXT) InternalTool.GetGLMethodAdress("glIndexFuncEXT", typeof(dgtk.OpenGL.delegatesGL.glIndexFuncEXT));
			}
			if (SuportedExt.Contains("glIndexMaterialEXT"))
			{
				dgtk.OpenGL.internalGL.glIndexMaterialEXT = (dgtk.OpenGL.delegatesGL.glIndexMaterialEXT) InternalTool.GetGLMethodAdress("glIndexMaterialEXT", typeof(dgtk.OpenGL.delegatesGL.glIndexMaterialEXT));
			}
			if (SuportedExt.Contains("glIndexPointerEXT"))
			{
				dgtk.OpenGL.internalGL.glIndexPointerEXT = (dgtk.OpenGL.delegatesGL.glIndexPointerEXT) InternalTool.GetGLMethodAdress("glIndexPointerEXT", typeof(dgtk.OpenGL.delegatesGL.glIndexPointerEXT));
			}
			if (SuportedExt.Contains("glIndexPointerListIBM"))
			{
				dgtk.OpenGL.internalGL.glIndexPointerListIBM = (dgtk.OpenGL.delegatesGL.glIndexPointerListIBM) InternalTool.GetGLMethodAdress("glIndexPointerListIBM", typeof(dgtk.OpenGL.delegatesGL.glIndexPointerListIBM));
			}
			if (SuportedExt.Contains("glIndexxOES"))
			{
				dgtk.OpenGL.internalGL.glIndexxOES = (dgtk.OpenGL.delegatesGL.glIndexxOES) InternalTool.GetGLMethodAdress("glIndexxOES", typeof(dgtk.OpenGL.delegatesGL.glIndexxOES));
			}
			if (SuportedExt.Contains("glIndexxvOES"))
			{
				dgtk.OpenGL.internalGL.glIndexxvOES = (dgtk.OpenGL.delegatesGL.glIndexxvOES) InternalTool.GetGLMethodAdress("glIndexxvOES", typeof(dgtk.OpenGL.delegatesGL.glIndexxvOES));
			}
			if (SuportedExt.Contains("glInsertComponentEXT"))
			{
				dgtk.OpenGL.internalGL.glInsertComponentEXT = (dgtk.OpenGL.delegatesGL.glInsertComponentEXT) InternalTool.GetGLMethodAdress("glInsertComponentEXT", typeof(dgtk.OpenGL.delegatesGL.glInsertComponentEXT));
			}
			if (SuportedExt.Contains("glInsertEventMarkerEXT"))
			{
				dgtk.OpenGL.internalGL.glInsertEventMarkerEXT = (dgtk.OpenGL.delegatesGL.glInsertEventMarkerEXT) InternalTool.GetGLMethodAdress("glInsertEventMarkerEXT", typeof(dgtk.OpenGL.delegatesGL.glInsertEventMarkerEXT));
			}
			if (SuportedExt.Contains("glInstrumentsBufferSGIX"))
			{
				dgtk.OpenGL.internalGL.glInstrumentsBufferSGIX = (dgtk.OpenGL.delegatesGL.glInstrumentsBufferSGIX) InternalTool.GetGLMethodAdress("glInstrumentsBufferSGIX", typeof(dgtk.OpenGL.delegatesGL.glInstrumentsBufferSGIX));
			}
			if (SuportedExt.Contains("glInterpolatePathsNV"))
			{
				dgtk.OpenGL.internalGL.glInterpolatePathsNV = (dgtk.OpenGL.delegatesGL.glInterpolatePathsNV) InternalTool.GetGLMethodAdress("glInterpolatePathsNV", typeof(dgtk.OpenGL.delegatesGL.glInterpolatePathsNV));
			}
			if (SuportedExt.Contains("glIsAsyncMarkerSGIX"))
			{
				dgtk.OpenGL.internalGL.glIsAsyncMarkerSGIX = (dgtk.OpenGL.delegatesGL.glIsAsyncMarkerSGIX) InternalTool.GetGLMethodAdress("glIsAsyncMarkerSGIX", typeof(dgtk.OpenGL.delegatesGL.glIsAsyncMarkerSGIX));
			}
			if (SuportedExt.Contains("glIsBufferARB"))
			{
				dgtk.OpenGL.internalGL.glIsBufferARB = (dgtk.OpenGL.delegatesGL.glIsBufferARB) InternalTool.GetGLMethodAdress("glIsBufferARB", typeof(dgtk.OpenGL.delegatesGL.glIsBufferARB));
			}
			if (SuportedExt.Contains("glIsBufferResidentNV"))
			{
				dgtk.OpenGL.internalGL.glIsBufferResidentNV = (dgtk.OpenGL.delegatesGL.glIsBufferResidentNV) InternalTool.GetGLMethodAdress("glIsBufferResidentNV", typeof(dgtk.OpenGL.delegatesGL.glIsBufferResidentNV));
			}
			if (SuportedExt.Contains("glIsCommandListNV"))
			{
				dgtk.OpenGL.internalGL.glIsCommandListNV = (dgtk.OpenGL.delegatesGL.glIsCommandListNV) InternalTool.GetGLMethodAdress("glIsCommandListNV", typeof(dgtk.OpenGL.delegatesGL.glIsCommandListNV));
			}
			if (SuportedExt.Contains("glIsEnablediEXT"))
			{
				dgtk.OpenGL.internalGL.glIsEnablediEXT = (dgtk.OpenGL.delegatesGL.glIsEnablediEXT) InternalTool.GetGLMethodAdress("glIsEnablediEXT", typeof(dgtk.OpenGL.delegatesGL.glIsEnablediEXT));
			}
			if (SuportedExt.Contains("glIsEnabledIndexedEXT"))
			{
				dgtk.OpenGL.internalGL.glIsEnabledIndexedEXT = (dgtk.OpenGL.delegatesGL.glIsEnabledIndexedEXT) InternalTool.GetGLMethodAdress("glIsEnabledIndexedEXT", typeof(dgtk.OpenGL.delegatesGL.glIsEnabledIndexedEXT));
			}
			if (SuportedExt.Contains("glIsEnablediNV"))
			{
				dgtk.OpenGL.internalGL.glIsEnablediNV = (dgtk.OpenGL.delegatesGL.glIsEnablediNV) InternalTool.GetGLMethodAdress("glIsEnablediNV", typeof(dgtk.OpenGL.delegatesGL.glIsEnablediNV));
			}
			if (SuportedExt.Contains("glIsEnablediOES"))
			{
				dgtk.OpenGL.internalGL.glIsEnablediOES = (dgtk.OpenGL.delegatesGL.glIsEnablediOES) InternalTool.GetGLMethodAdress("glIsEnablediOES", typeof(dgtk.OpenGL.delegatesGL.glIsEnablediOES));
			}
			if (SuportedExt.Contains("glIsFenceAPPLE"))
			{
				dgtk.OpenGL.internalGL.glIsFenceAPPLE = (dgtk.OpenGL.delegatesGL.glIsFenceAPPLE) InternalTool.GetGLMethodAdress("glIsFenceAPPLE", typeof(dgtk.OpenGL.delegatesGL.glIsFenceAPPLE));
			}
			if (SuportedExt.Contains("glIsFenceNV"))
			{
				dgtk.OpenGL.internalGL.glIsFenceNV = (dgtk.OpenGL.delegatesGL.glIsFenceNV) InternalTool.GetGLMethodAdress("glIsFenceNV", typeof(dgtk.OpenGL.delegatesGL.glIsFenceNV));
			}
			if (SuportedExt.Contains("glIsFramebufferEXT"))
			{
				dgtk.OpenGL.internalGL.glIsFramebufferEXT = (dgtk.OpenGL.delegatesGL.glIsFramebufferEXT) InternalTool.GetGLMethodAdress("glIsFramebufferEXT", typeof(dgtk.OpenGL.delegatesGL.glIsFramebufferEXT));
			}
			if (SuportedExt.Contains("glIsFramebufferOES"))
			{
				dgtk.OpenGL.internalGL.glIsFramebufferOES = (dgtk.OpenGL.delegatesGL.glIsFramebufferOES) InternalTool.GetGLMethodAdress("glIsFramebufferOES", typeof(dgtk.OpenGL.delegatesGL.glIsFramebufferOES));
			}
			if (SuportedExt.Contains("glIsImageHandleResidentARB"))
			{
				dgtk.OpenGL.internalGL.glIsImageHandleResidentARB = (dgtk.OpenGL.delegatesGL.glIsImageHandleResidentARB) InternalTool.GetGLMethodAdress("glIsImageHandleResidentARB", typeof(dgtk.OpenGL.delegatesGL.glIsImageHandleResidentARB));
			}
			if (SuportedExt.Contains("glIsImageHandleResidentNV"))
			{
				dgtk.OpenGL.internalGL.glIsImageHandleResidentNV = (dgtk.OpenGL.delegatesGL.glIsImageHandleResidentNV) InternalTool.GetGLMethodAdress("glIsImageHandleResidentNV", typeof(dgtk.OpenGL.delegatesGL.glIsImageHandleResidentNV));
			}
			if (SuportedExt.Contains("glIsMemoryObjectEXT"))
			{
				dgtk.OpenGL.internalGL.glIsMemoryObjectEXT = (dgtk.OpenGL.delegatesGL.glIsMemoryObjectEXT) InternalTool.GetGLMethodAdress("glIsMemoryObjectEXT", typeof(dgtk.OpenGL.delegatesGL.glIsMemoryObjectEXT));
			}
			if (SuportedExt.Contains("glIsNameAMD"))
			{
				dgtk.OpenGL.internalGL.glIsNameAMD = (dgtk.OpenGL.delegatesGL.glIsNameAMD) InternalTool.GetGLMethodAdress("glIsNameAMD", typeof(dgtk.OpenGL.delegatesGL.glIsNameAMD));
			}
			if (SuportedExt.Contains("glIsNamedBufferResidentNV"))
			{
				dgtk.OpenGL.internalGL.glIsNamedBufferResidentNV = (dgtk.OpenGL.delegatesGL.glIsNamedBufferResidentNV) InternalTool.GetGLMethodAdress("glIsNamedBufferResidentNV", typeof(dgtk.OpenGL.delegatesGL.glIsNamedBufferResidentNV));
			}
			if (SuportedExt.Contains("glIsNamedStringARB"))
			{
				dgtk.OpenGL.internalGL.glIsNamedStringARB = (dgtk.OpenGL.delegatesGL.glIsNamedStringARB) InternalTool.GetGLMethodAdress("glIsNamedStringARB", typeof(dgtk.OpenGL.delegatesGL.glIsNamedStringARB));
			}
			if (SuportedExt.Contains("glIsObjectBufferATI"))
			{
				dgtk.OpenGL.internalGL.glIsObjectBufferATI = (dgtk.OpenGL.delegatesGL.glIsObjectBufferATI) InternalTool.GetGLMethodAdress("glIsObjectBufferATI", typeof(dgtk.OpenGL.delegatesGL.glIsObjectBufferATI));
			}
			if (SuportedExt.Contains("glIsOcclusionQueryNV"))
			{
				dgtk.OpenGL.internalGL.glIsOcclusionQueryNV = (dgtk.OpenGL.delegatesGL.glIsOcclusionQueryNV) InternalTool.GetGLMethodAdress("glIsOcclusionQueryNV", typeof(dgtk.OpenGL.delegatesGL.glIsOcclusionQueryNV));
			}
			if (SuportedExt.Contains("glIsPathNV"))
			{
				dgtk.OpenGL.internalGL.glIsPathNV = (dgtk.OpenGL.delegatesGL.glIsPathNV) InternalTool.GetGLMethodAdress("glIsPathNV", typeof(dgtk.OpenGL.delegatesGL.glIsPathNV));
			}
			if (SuportedExt.Contains("glIsPointInFillPathNV"))
			{
				dgtk.OpenGL.internalGL.glIsPointInFillPathNV = (dgtk.OpenGL.delegatesGL.glIsPointInFillPathNV) InternalTool.GetGLMethodAdress("glIsPointInFillPathNV", typeof(dgtk.OpenGL.delegatesGL.glIsPointInFillPathNV));
			}
			if (SuportedExt.Contains("glIsPointInStrokePathNV"))
			{
				dgtk.OpenGL.internalGL.glIsPointInStrokePathNV = (dgtk.OpenGL.delegatesGL.glIsPointInStrokePathNV) InternalTool.GetGLMethodAdress("glIsPointInStrokePathNV", typeof(dgtk.OpenGL.delegatesGL.glIsPointInStrokePathNV));
			}
			if (SuportedExt.Contains("glIsProgramARB"))
			{
				dgtk.OpenGL.internalGL.glIsProgramARB = (dgtk.OpenGL.delegatesGL.glIsProgramARB) InternalTool.GetGLMethodAdress("glIsProgramARB", typeof(dgtk.OpenGL.delegatesGL.glIsProgramARB));
			}
			if (SuportedExt.Contains("glIsProgramNV"))
			{
				dgtk.OpenGL.internalGL.glIsProgramNV = (dgtk.OpenGL.delegatesGL.glIsProgramNV) InternalTool.GetGLMethodAdress("glIsProgramNV", typeof(dgtk.OpenGL.delegatesGL.glIsProgramNV));
			}
			if (SuportedExt.Contains("glIsProgramPipelineEXT"))
			{
				dgtk.OpenGL.internalGL.glIsProgramPipelineEXT = (dgtk.OpenGL.delegatesGL.glIsProgramPipelineEXT) InternalTool.GetGLMethodAdress("glIsProgramPipelineEXT", typeof(dgtk.OpenGL.delegatesGL.glIsProgramPipelineEXT));
			}
			if (SuportedExt.Contains("glIsQueryARB"))
			{
				dgtk.OpenGL.internalGL.glIsQueryARB = (dgtk.OpenGL.delegatesGL.glIsQueryARB) InternalTool.GetGLMethodAdress("glIsQueryARB", typeof(dgtk.OpenGL.delegatesGL.glIsQueryARB));
			}
			if (SuportedExt.Contains("glIsQueryEXT"))
			{
				dgtk.OpenGL.internalGL.glIsQueryEXT = (dgtk.OpenGL.delegatesGL.glIsQueryEXT) InternalTool.GetGLMethodAdress("glIsQueryEXT", typeof(dgtk.OpenGL.delegatesGL.glIsQueryEXT));
			}
			if (SuportedExt.Contains("glIsRenderbufferEXT"))
			{
				dgtk.OpenGL.internalGL.glIsRenderbufferEXT = (dgtk.OpenGL.delegatesGL.glIsRenderbufferEXT) InternalTool.GetGLMethodAdress("glIsRenderbufferEXT", typeof(dgtk.OpenGL.delegatesGL.glIsRenderbufferEXT));
			}
			if (SuportedExt.Contains("glIsRenderbufferOES"))
			{
				dgtk.OpenGL.internalGL.glIsRenderbufferOES = (dgtk.OpenGL.delegatesGL.glIsRenderbufferOES) InternalTool.GetGLMethodAdress("glIsRenderbufferOES", typeof(dgtk.OpenGL.delegatesGL.glIsRenderbufferOES));
			}
			if (SuportedExt.Contains("glIsSemaphoreEXT"))
			{
				dgtk.OpenGL.internalGL.glIsSemaphoreEXT = (dgtk.OpenGL.delegatesGL.glIsSemaphoreEXT) InternalTool.GetGLMethodAdress("glIsSemaphoreEXT", typeof(dgtk.OpenGL.delegatesGL.glIsSemaphoreEXT));
			}
			if (SuportedExt.Contains("glIsStateNV"))
			{
				dgtk.OpenGL.internalGL.glIsStateNV = (dgtk.OpenGL.delegatesGL.glIsStateNV) InternalTool.GetGLMethodAdress("glIsStateNV", typeof(dgtk.OpenGL.delegatesGL.glIsStateNV));
			}
			if (SuportedExt.Contains("glIsSyncAPPLE"))
			{
				dgtk.OpenGL.internalGL.glIsSyncAPPLE = (dgtk.OpenGL.delegatesGL.glIsSyncAPPLE) InternalTool.GetGLMethodAdress("glIsSyncAPPLE", typeof(dgtk.OpenGL.delegatesGL.glIsSyncAPPLE));
			}
			if (SuportedExt.Contains("glIsTextureEXT"))
			{
				dgtk.OpenGL.internalGL.glIsTextureEXT = (dgtk.OpenGL.delegatesGL.glIsTextureEXT) InternalTool.GetGLMethodAdress("glIsTextureEXT", typeof(dgtk.OpenGL.delegatesGL.glIsTextureEXT));
			}
			if (SuportedExt.Contains("glIsTextureHandleResidentARB"))
			{
				dgtk.OpenGL.internalGL.glIsTextureHandleResidentARB = (dgtk.OpenGL.delegatesGL.glIsTextureHandleResidentARB) InternalTool.GetGLMethodAdress("glIsTextureHandleResidentARB", typeof(dgtk.OpenGL.delegatesGL.glIsTextureHandleResidentARB));
			}
			if (SuportedExt.Contains("glIsTextureHandleResidentNV"))
			{
				dgtk.OpenGL.internalGL.glIsTextureHandleResidentNV = (dgtk.OpenGL.delegatesGL.glIsTextureHandleResidentNV) InternalTool.GetGLMethodAdress("glIsTextureHandleResidentNV", typeof(dgtk.OpenGL.delegatesGL.glIsTextureHandleResidentNV));
			}
			if (SuportedExt.Contains("glIsTransformFeedbackNV"))
			{
				dgtk.OpenGL.internalGL.glIsTransformFeedbackNV = (dgtk.OpenGL.delegatesGL.glIsTransformFeedbackNV) InternalTool.GetGLMethodAdress("glIsTransformFeedbackNV", typeof(dgtk.OpenGL.delegatesGL.glIsTransformFeedbackNV));
			}
			if (SuportedExt.Contains("glIsVariantEnabledEXT"))
			{
				dgtk.OpenGL.internalGL.glIsVariantEnabledEXT = (dgtk.OpenGL.delegatesGL.glIsVariantEnabledEXT) InternalTool.GetGLMethodAdress("glIsVariantEnabledEXT", typeof(dgtk.OpenGL.delegatesGL.glIsVariantEnabledEXT));
			}
			if (SuportedExt.Contains("glIsVertexArrayAPPLE"))
			{
				dgtk.OpenGL.internalGL.glIsVertexArrayAPPLE = (dgtk.OpenGL.delegatesGL.glIsVertexArrayAPPLE) InternalTool.GetGLMethodAdress("glIsVertexArrayAPPLE", typeof(dgtk.OpenGL.delegatesGL.glIsVertexArrayAPPLE));
			}
			if (SuportedExt.Contains("glIsVertexArrayOES"))
			{
				dgtk.OpenGL.internalGL.glIsVertexArrayOES = (dgtk.OpenGL.delegatesGL.glIsVertexArrayOES) InternalTool.GetGLMethodAdress("glIsVertexArrayOES", typeof(dgtk.OpenGL.delegatesGL.glIsVertexArrayOES));
			}
			if (SuportedExt.Contains("glIsVertexAttribEnabledAPPLE"))
			{
				dgtk.OpenGL.internalGL.glIsVertexAttribEnabledAPPLE = (dgtk.OpenGL.delegatesGL.glIsVertexAttribEnabledAPPLE) InternalTool.GetGLMethodAdress("glIsVertexAttribEnabledAPPLE", typeof(dgtk.OpenGL.delegatesGL.glIsVertexAttribEnabledAPPLE));
			}
			#endregion

			#region L:

			if (SuportedExt.Contains("glLabelObjectEXT"))
			{
				dgtk.OpenGL.internalGL.glLabelObjectEXT = (dgtk.OpenGL.delegatesGL.glLabelObjectEXT) InternalTool.GetGLMethodAdress("glLabelObjectEXT", typeof(dgtk.OpenGL.delegatesGL.glLabelObjectEXT));
			}
			if (SuportedExt.Contains("glLGPUCopyImageSubDataNVX"))
			{
				dgtk.OpenGL.internalGL.glLGPUCopyImageSubDataNVX = (dgtk.OpenGL.delegatesGL.glLGPUCopyImageSubDataNVX) InternalTool.GetGLMethodAdress("glLGPUCopyImageSubDataNVX", typeof(dgtk.OpenGL.delegatesGL.glLGPUCopyImageSubDataNVX));
			}
			if (SuportedExt.Contains("glLGPUInterlockNVX"))
			{
				dgtk.OpenGL.internalGL.glLGPUInterlockNVX = (dgtk.OpenGL.delegatesGL.glLGPUInterlockNVX) InternalTool.GetGLMethodAdress("glLGPUInterlockNVX", typeof(dgtk.OpenGL.delegatesGL.glLGPUInterlockNVX));
			}
			if (SuportedExt.Contains("glLGPUNamedBufferSubDataNVX"))
			{
				dgtk.OpenGL.internalGL.glLGPUNamedBufferSubDataNVX = (dgtk.OpenGL.delegatesGL.glLGPUNamedBufferSubDataNVX) InternalTool.GetGLMethodAdress("glLGPUNamedBufferSubDataNVX", typeof(dgtk.OpenGL.delegatesGL.glLGPUNamedBufferSubDataNVX));
			}
			if (SuportedExt.Contains("glLightEnviSGIX"))
			{
				dgtk.OpenGL.internalGL.glLightEnviSGIX = (dgtk.OpenGL.delegatesGL.glLightEnviSGIX) InternalTool.GetGLMethodAdress("glLightEnviSGIX", typeof(dgtk.OpenGL.delegatesGL.glLightEnviSGIX));
			}
			if (SuportedExt.Contains("glLightModelx"))
			{
				dgtk.OpenGL.internalGL.glLightModelx = (dgtk.OpenGL.delegatesGL.glLightModelx) InternalTool.GetGLMethodAdress("glLightModelx", typeof(dgtk.OpenGL.delegatesGL.glLightModelx));
			}
			if (SuportedExt.Contains("glLightModelxOES"))
			{
				dgtk.OpenGL.internalGL.glLightModelxOES = (dgtk.OpenGL.delegatesGL.glLightModelxOES) InternalTool.GetGLMethodAdress("glLightModelxOES", typeof(dgtk.OpenGL.delegatesGL.glLightModelxOES));
			}
			if (SuportedExt.Contains("glLightModelxv"))
			{
				dgtk.OpenGL.internalGL.glLightModelxv = (dgtk.OpenGL.delegatesGL.glLightModelxv) InternalTool.GetGLMethodAdress("glLightModelxv", typeof(dgtk.OpenGL.delegatesGL.glLightModelxv));
			}
			if (SuportedExt.Contains("glLightModelxvOES"))
			{
				dgtk.OpenGL.internalGL.glLightModelxvOES = (dgtk.OpenGL.delegatesGL.glLightModelxvOES) InternalTool.GetGLMethodAdress("glLightModelxvOES", typeof(dgtk.OpenGL.delegatesGL.glLightModelxvOES));
			}
			if (SuportedExt.Contains("glLightx"))
			{
				dgtk.OpenGL.internalGL.glLightx = (dgtk.OpenGL.delegatesGL.glLightx) InternalTool.GetGLMethodAdress("glLightx", typeof(dgtk.OpenGL.delegatesGL.glLightx));
			}
			if (SuportedExt.Contains("glLightxOES"))
			{
				dgtk.OpenGL.internalGL.glLightxOES = (dgtk.OpenGL.delegatesGL.glLightxOES) InternalTool.GetGLMethodAdress("glLightxOES", typeof(dgtk.OpenGL.delegatesGL.glLightxOES));
			}
			if (SuportedExt.Contains("glLightxv"))
			{
				dgtk.OpenGL.internalGL.glLightxv = (dgtk.OpenGL.delegatesGL.glLightxv) InternalTool.GetGLMethodAdress("glLightxv", typeof(dgtk.OpenGL.delegatesGL.glLightxv));
			}
			if (SuportedExt.Contains("glLightxvOES"))
			{
				dgtk.OpenGL.internalGL.glLightxvOES = (dgtk.OpenGL.delegatesGL.glLightxvOES) InternalTool.GetGLMethodAdress("glLightxvOES", typeof(dgtk.OpenGL.delegatesGL.glLightxvOES));
			}
			if (SuportedExt.Contains("glLineWidthx"))
			{
				dgtk.OpenGL.internalGL.glLineWidthx = (dgtk.OpenGL.delegatesGL.glLineWidthx) InternalTool.GetGLMethodAdress("glLineWidthx", typeof(dgtk.OpenGL.delegatesGL.glLineWidthx));
			}
			if (SuportedExt.Contains("glLineWidthxOES"))
			{
				dgtk.OpenGL.internalGL.glLineWidthxOES = (dgtk.OpenGL.delegatesGL.glLineWidthxOES) InternalTool.GetGLMethodAdress("glLineWidthxOES", typeof(dgtk.OpenGL.delegatesGL.glLineWidthxOES));
			}
			if (SuportedExt.Contains("glLinkProgramARB"))
			{
				dgtk.OpenGL.internalGL.glLinkProgramARB = (dgtk.OpenGL.delegatesGL.glLinkProgramARB) InternalTool.GetGLMethodAdress("glLinkProgramARB", typeof(dgtk.OpenGL.delegatesGL.glLinkProgramARB));
			}
			if (SuportedExt.Contains("glListDrawCommandsStatesClientNV"))
			{
				dgtk.OpenGL.internalGL.glListDrawCommandsStatesClientNV = (dgtk.OpenGL.delegatesGL.glListDrawCommandsStatesClientNV) InternalTool.GetGLMethodAdress("glListDrawCommandsStatesClientNV", typeof(dgtk.OpenGL.delegatesGL.glListDrawCommandsStatesClientNV));
			}
			if (SuportedExt.Contains("glListParameterfSGIX"))
			{
				dgtk.OpenGL.internalGL.glListParameterfSGIX = (dgtk.OpenGL.delegatesGL.glListParameterfSGIX) InternalTool.GetGLMethodAdress("glListParameterfSGIX", typeof(dgtk.OpenGL.delegatesGL.glListParameterfSGIX));
			}
			if (SuportedExt.Contains("glListParameterfvSGIX"))
			{
				dgtk.OpenGL.internalGL.glListParameterfvSGIX = (dgtk.OpenGL.delegatesGL.glListParameterfvSGIX) InternalTool.GetGLMethodAdress("glListParameterfvSGIX", typeof(dgtk.OpenGL.delegatesGL.glListParameterfvSGIX));
			}
			if (SuportedExt.Contains("glListParameteriSGIX"))
			{
				dgtk.OpenGL.internalGL.glListParameteriSGIX = (dgtk.OpenGL.delegatesGL.glListParameteriSGIX) InternalTool.GetGLMethodAdress("glListParameteriSGIX", typeof(dgtk.OpenGL.delegatesGL.glListParameteriSGIX));
			}
			if (SuportedExt.Contains("glListParameterivSGIX"))
			{
				dgtk.OpenGL.internalGL.glListParameterivSGIX = (dgtk.OpenGL.delegatesGL.glListParameterivSGIX) InternalTool.GetGLMethodAdress("glListParameterivSGIX", typeof(dgtk.OpenGL.delegatesGL.glListParameterivSGIX));
			}
			if (SuportedExt.Contains("glLoadIdentityDeformationMapSGIX"))
			{
				dgtk.OpenGL.internalGL.glLoadIdentityDeformationMapSGIX = (dgtk.OpenGL.delegatesGL.glLoadIdentityDeformationMapSGIX) InternalTool.GetGLMethodAdress("glLoadIdentityDeformationMapSGIX", typeof(dgtk.OpenGL.delegatesGL.glLoadIdentityDeformationMapSGIX));
			}
			if (SuportedExt.Contains("glLoadMatrixx"))
			{
				dgtk.OpenGL.internalGL.glLoadMatrixx = (dgtk.OpenGL.delegatesGL.glLoadMatrixx) InternalTool.GetGLMethodAdress("glLoadMatrixx", typeof(dgtk.OpenGL.delegatesGL.glLoadMatrixx));
			}
			if (SuportedExt.Contains("glLoadMatrixxOES"))
			{
				dgtk.OpenGL.internalGL.glLoadMatrixxOES = (dgtk.OpenGL.delegatesGL.glLoadMatrixxOES) InternalTool.GetGLMethodAdress("glLoadMatrixxOES", typeof(dgtk.OpenGL.delegatesGL.glLoadMatrixxOES));
			}
			if (SuportedExt.Contains("glLoadPaletteFromModelViewMatrixOES"))
			{
				dgtk.OpenGL.internalGL.glLoadPaletteFromModelViewMatrixOES = (dgtk.OpenGL.delegatesGL.glLoadPaletteFromModelViewMatrixOES) InternalTool.GetGLMethodAdress("glLoadPaletteFromModelViewMatrixOES", typeof(dgtk.OpenGL.delegatesGL.glLoadPaletteFromModelViewMatrixOES));
			}
			if (SuportedExt.Contains("glLoadProgramNV"))
			{
				dgtk.OpenGL.internalGL.glLoadProgramNV = (dgtk.OpenGL.delegatesGL.glLoadProgramNV) InternalTool.GetGLMethodAdress("glLoadProgramNV", typeof(dgtk.OpenGL.delegatesGL.glLoadProgramNV));
			}
			if (SuportedExt.Contains("glLoadTransposeMatrixdARB"))
			{
				dgtk.OpenGL.internalGL.glLoadTransposeMatrixdARB = (dgtk.OpenGL.delegatesGL.glLoadTransposeMatrixdARB) InternalTool.GetGLMethodAdress("glLoadTransposeMatrixdARB", typeof(dgtk.OpenGL.delegatesGL.glLoadTransposeMatrixdARB));
			}
			if (SuportedExt.Contains("glLoadTransposeMatrixfARB"))
			{
				dgtk.OpenGL.internalGL.glLoadTransposeMatrixfARB = (dgtk.OpenGL.delegatesGL.glLoadTransposeMatrixfARB) InternalTool.GetGLMethodAdress("glLoadTransposeMatrixfARB", typeof(dgtk.OpenGL.delegatesGL.glLoadTransposeMatrixfARB));
			}
			if (SuportedExt.Contains("glLoadTransposeMatrixxOES"))
			{
				dgtk.OpenGL.internalGL.glLoadTransposeMatrixxOES = (dgtk.OpenGL.delegatesGL.glLoadTransposeMatrixxOES) InternalTool.GetGLMethodAdress("glLoadTransposeMatrixxOES", typeof(dgtk.OpenGL.delegatesGL.glLoadTransposeMatrixxOES));
			}
			if (SuportedExt.Contains("glLockArraysEXT"))
			{
				dgtk.OpenGL.internalGL.glLockArraysEXT = (dgtk.OpenGL.delegatesGL.glLockArraysEXT) InternalTool.GetGLMethodAdress("glLockArraysEXT", typeof(dgtk.OpenGL.delegatesGL.glLockArraysEXT));
			}
			#endregion

			#region M:

			if (SuportedExt.Contains("glMakeBufferNonResidentNV"))
			{
				dgtk.OpenGL.internalGL.glMakeBufferNonResidentNV = (dgtk.OpenGL.delegatesGL.glMakeBufferNonResidentNV) InternalTool.GetGLMethodAdress("glMakeBufferNonResidentNV", typeof(dgtk.OpenGL.delegatesGL.glMakeBufferNonResidentNV));
			}
			if (SuportedExt.Contains("glMakeBufferResidentNV"))
			{
				dgtk.OpenGL.internalGL.glMakeBufferResidentNV = (dgtk.OpenGL.delegatesGL.glMakeBufferResidentNV) InternalTool.GetGLMethodAdress("glMakeBufferResidentNV", typeof(dgtk.OpenGL.delegatesGL.glMakeBufferResidentNV));
			}
			if (SuportedExt.Contains("glMakeImageHandleNonResidentARB"))
			{
				dgtk.OpenGL.internalGL.glMakeImageHandleNonResidentARB = (dgtk.OpenGL.delegatesGL.glMakeImageHandleNonResidentARB) InternalTool.GetGLMethodAdress("glMakeImageHandleNonResidentARB", typeof(dgtk.OpenGL.delegatesGL.glMakeImageHandleNonResidentARB));
			}
			if (SuportedExt.Contains("glMakeImageHandleNonResidentNV"))
			{
				dgtk.OpenGL.internalGL.glMakeImageHandleNonResidentNV = (dgtk.OpenGL.delegatesGL.glMakeImageHandleNonResidentNV) InternalTool.GetGLMethodAdress("glMakeImageHandleNonResidentNV", typeof(dgtk.OpenGL.delegatesGL.glMakeImageHandleNonResidentNV));
			}
			if (SuportedExt.Contains("glMakeImageHandleResidentARB"))
			{
				dgtk.OpenGL.internalGL.glMakeImageHandleResidentARB = (dgtk.OpenGL.delegatesGL.glMakeImageHandleResidentARB) InternalTool.GetGLMethodAdress("glMakeImageHandleResidentARB", typeof(dgtk.OpenGL.delegatesGL.glMakeImageHandleResidentARB));
			}
			if (SuportedExt.Contains("glMakeImageHandleResidentNV"))
			{
				dgtk.OpenGL.internalGL.glMakeImageHandleResidentNV = (dgtk.OpenGL.delegatesGL.glMakeImageHandleResidentNV) InternalTool.GetGLMethodAdress("glMakeImageHandleResidentNV", typeof(dgtk.OpenGL.delegatesGL.glMakeImageHandleResidentNV));
			}
			if (SuportedExt.Contains("glMakeNamedBufferNonResidentNV"))
			{
				dgtk.OpenGL.internalGL.glMakeNamedBufferNonResidentNV = (dgtk.OpenGL.delegatesGL.glMakeNamedBufferNonResidentNV) InternalTool.GetGLMethodAdress("glMakeNamedBufferNonResidentNV", typeof(dgtk.OpenGL.delegatesGL.glMakeNamedBufferNonResidentNV));
			}
			if (SuportedExt.Contains("glMakeNamedBufferResidentNV"))
			{
				dgtk.OpenGL.internalGL.glMakeNamedBufferResidentNV = (dgtk.OpenGL.delegatesGL.glMakeNamedBufferResidentNV) InternalTool.GetGLMethodAdress("glMakeNamedBufferResidentNV", typeof(dgtk.OpenGL.delegatesGL.glMakeNamedBufferResidentNV));
			}
			if (SuportedExt.Contains("glMakeTextureHandleNonResidentARB"))
			{
				dgtk.OpenGL.internalGL.glMakeTextureHandleNonResidentARB = (dgtk.OpenGL.delegatesGL.glMakeTextureHandleNonResidentARB) InternalTool.GetGLMethodAdress("glMakeTextureHandleNonResidentARB", typeof(dgtk.OpenGL.delegatesGL.glMakeTextureHandleNonResidentARB));
			}
			if (SuportedExt.Contains("glMakeTextureHandleNonResidentNV"))
			{
				dgtk.OpenGL.internalGL.glMakeTextureHandleNonResidentNV = (dgtk.OpenGL.delegatesGL.glMakeTextureHandleNonResidentNV) InternalTool.GetGLMethodAdress("glMakeTextureHandleNonResidentNV", typeof(dgtk.OpenGL.delegatesGL.glMakeTextureHandleNonResidentNV));
			}
			if (SuportedExt.Contains("glMakeTextureHandleResidentARB"))
			{
				dgtk.OpenGL.internalGL.glMakeTextureHandleResidentARB = (dgtk.OpenGL.delegatesGL.glMakeTextureHandleResidentARB) InternalTool.GetGLMethodAdress("glMakeTextureHandleResidentARB", typeof(dgtk.OpenGL.delegatesGL.glMakeTextureHandleResidentARB));
			}
			if (SuportedExt.Contains("glMakeTextureHandleResidentNV"))
			{
				dgtk.OpenGL.internalGL.glMakeTextureHandleResidentNV = (dgtk.OpenGL.delegatesGL.glMakeTextureHandleResidentNV) InternalTool.GetGLMethodAdress("glMakeTextureHandleResidentNV", typeof(dgtk.OpenGL.delegatesGL.glMakeTextureHandleResidentNV));
			}
			if (SuportedExt.Contains("glMap1xOES"))
			{
				dgtk.OpenGL.internalGL.glMap1xOES = (dgtk.OpenGL.delegatesGL.glMap1xOES) InternalTool.GetGLMethodAdress("glMap1xOES", typeof(dgtk.OpenGL.delegatesGL.glMap1xOES));
			}
			if (SuportedExt.Contains("glMap2xOES"))
			{
				dgtk.OpenGL.internalGL.glMap2xOES = (dgtk.OpenGL.delegatesGL.glMap2xOES) InternalTool.GetGLMethodAdress("glMap2xOES", typeof(dgtk.OpenGL.delegatesGL.glMap2xOES));
			}
			if (SuportedExt.Contains("glMapBufferARB"))
			{
				dgtk.OpenGL.internalGL.glMapBufferARB = (dgtk.OpenGL.delegatesGL.glMapBufferARB) InternalTool.GetGLMethodAdress("glMapBufferARB", typeof(dgtk.OpenGL.delegatesGL.glMapBufferARB));
			}
			if (SuportedExt.Contains("glMapBufferOES"))
			{
				dgtk.OpenGL.internalGL.glMapBufferOES = (dgtk.OpenGL.delegatesGL.glMapBufferOES) InternalTool.GetGLMethodAdress("glMapBufferOES", typeof(dgtk.OpenGL.delegatesGL.glMapBufferOES));
			}
			if (SuportedExt.Contains("glMapBufferRangeEXT"))
			{
				dgtk.OpenGL.internalGL.glMapBufferRangeEXT = (dgtk.OpenGL.delegatesGL.glMapBufferRangeEXT) InternalTool.GetGLMethodAdress("glMapBufferRangeEXT", typeof(dgtk.OpenGL.delegatesGL.glMapBufferRangeEXT));
			}
			if (SuportedExt.Contains("glMapControlPointsNV"))
			{
				dgtk.OpenGL.internalGL.glMapControlPointsNV = (dgtk.OpenGL.delegatesGL.glMapControlPointsNV) InternalTool.GetGLMethodAdress("glMapControlPointsNV", typeof(dgtk.OpenGL.delegatesGL.glMapControlPointsNV));
			}
			if (SuportedExt.Contains("glMapGrid1xOES"))
			{
				dgtk.OpenGL.internalGL.glMapGrid1xOES = (dgtk.OpenGL.delegatesGL.glMapGrid1xOES) InternalTool.GetGLMethodAdress("glMapGrid1xOES", typeof(dgtk.OpenGL.delegatesGL.glMapGrid1xOES));
			}
			if (SuportedExt.Contains("glMapGrid2xOES"))
			{
				dgtk.OpenGL.internalGL.glMapGrid2xOES = (dgtk.OpenGL.delegatesGL.glMapGrid2xOES) InternalTool.GetGLMethodAdress("glMapGrid2xOES", typeof(dgtk.OpenGL.delegatesGL.glMapGrid2xOES));
			}
			if (SuportedExt.Contains("glMapNamedBufferEXT"))
			{
				dgtk.OpenGL.internalGL.glMapNamedBufferEXT = (dgtk.OpenGL.delegatesGL.glMapNamedBufferEXT) InternalTool.GetGLMethodAdress("glMapNamedBufferEXT", typeof(dgtk.OpenGL.delegatesGL.glMapNamedBufferEXT));
			}
			if (SuportedExt.Contains("glMapNamedBufferRangeEXT"))
			{
				dgtk.OpenGL.internalGL.glMapNamedBufferRangeEXT = (dgtk.OpenGL.delegatesGL.glMapNamedBufferRangeEXT) InternalTool.GetGLMethodAdress("glMapNamedBufferRangeEXT", typeof(dgtk.OpenGL.delegatesGL.glMapNamedBufferRangeEXT));
			}
			if (SuportedExt.Contains("glMapObjectBufferATI"))
			{
				dgtk.OpenGL.internalGL.glMapObjectBufferATI = (dgtk.OpenGL.delegatesGL.glMapObjectBufferATI) InternalTool.GetGLMethodAdress("glMapObjectBufferATI", typeof(dgtk.OpenGL.delegatesGL.glMapObjectBufferATI));
			}
			if (SuportedExt.Contains("glMapParameterfvNV"))
			{
				dgtk.OpenGL.internalGL.glMapParameterfvNV = (dgtk.OpenGL.delegatesGL.glMapParameterfvNV) InternalTool.GetGLMethodAdress("glMapParameterfvNV", typeof(dgtk.OpenGL.delegatesGL.glMapParameterfvNV));
			}
			if (SuportedExt.Contains("glMapParameterivNV"))
			{
				dgtk.OpenGL.internalGL.glMapParameterivNV = (dgtk.OpenGL.delegatesGL.glMapParameterivNV) InternalTool.GetGLMethodAdress("glMapParameterivNV", typeof(dgtk.OpenGL.delegatesGL.glMapParameterivNV));
			}
			if (SuportedExt.Contains("glMapTexture2DINTEL"))
			{
				dgtk.OpenGL.internalGL.glMapTexture2DINTEL = (dgtk.OpenGL.delegatesGL.glMapTexture2DINTEL) InternalTool.GetGLMethodAdress("glMapTexture2DINTEL", typeof(dgtk.OpenGL.delegatesGL.glMapTexture2DINTEL));
			}
			if (SuportedExt.Contains("glMapVertexAttrib1dAPPLE"))
			{
				dgtk.OpenGL.internalGL.glMapVertexAttrib1dAPPLE = (dgtk.OpenGL.delegatesGL.glMapVertexAttrib1dAPPLE) InternalTool.GetGLMethodAdress("glMapVertexAttrib1dAPPLE", typeof(dgtk.OpenGL.delegatesGL.glMapVertexAttrib1dAPPLE));
			}
			if (SuportedExt.Contains("glMapVertexAttrib1fAPPLE"))
			{
				dgtk.OpenGL.internalGL.glMapVertexAttrib1fAPPLE = (dgtk.OpenGL.delegatesGL.glMapVertexAttrib1fAPPLE) InternalTool.GetGLMethodAdress("glMapVertexAttrib1fAPPLE", typeof(dgtk.OpenGL.delegatesGL.glMapVertexAttrib1fAPPLE));
			}
			if (SuportedExt.Contains("glMapVertexAttrib2dAPPLE"))
			{
				dgtk.OpenGL.internalGL.glMapVertexAttrib2dAPPLE = (dgtk.OpenGL.delegatesGL.glMapVertexAttrib2dAPPLE) InternalTool.GetGLMethodAdress("glMapVertexAttrib2dAPPLE", typeof(dgtk.OpenGL.delegatesGL.glMapVertexAttrib2dAPPLE));
			}
			if (SuportedExt.Contains("glMapVertexAttrib2fAPPLE"))
			{
				dgtk.OpenGL.internalGL.glMapVertexAttrib2fAPPLE = (dgtk.OpenGL.delegatesGL.glMapVertexAttrib2fAPPLE) InternalTool.GetGLMethodAdress("glMapVertexAttrib2fAPPLE", typeof(dgtk.OpenGL.delegatesGL.glMapVertexAttrib2fAPPLE));
			}
			if (SuportedExt.Contains("glMaterialx"))
			{
				dgtk.OpenGL.internalGL.glMaterialx = (dgtk.OpenGL.delegatesGL.glMaterialx) InternalTool.GetGLMethodAdress("glMaterialx", typeof(dgtk.OpenGL.delegatesGL.glMaterialx));
			}
			if (SuportedExt.Contains("glMaterialxOES"))
			{
				dgtk.OpenGL.internalGL.glMaterialxOES = (dgtk.OpenGL.delegatesGL.glMaterialxOES) InternalTool.GetGLMethodAdress("glMaterialxOES", typeof(dgtk.OpenGL.delegatesGL.glMaterialxOES));
			}
			if (SuportedExt.Contains("glMaterialxv"))
			{
				dgtk.OpenGL.internalGL.glMaterialxv = (dgtk.OpenGL.delegatesGL.glMaterialxv) InternalTool.GetGLMethodAdress("glMaterialxv", typeof(dgtk.OpenGL.delegatesGL.glMaterialxv));
			}
			if (SuportedExt.Contains("glMaterialxvOES"))
			{
				dgtk.OpenGL.internalGL.glMaterialxvOES = (dgtk.OpenGL.delegatesGL.glMaterialxvOES) InternalTool.GetGLMethodAdress("glMaterialxvOES", typeof(dgtk.OpenGL.delegatesGL.glMaterialxvOES));
			}
			if (SuportedExt.Contains("glMatrixFrustumEXT"))
			{
				dgtk.OpenGL.internalGL.glMatrixFrustumEXT = (dgtk.OpenGL.delegatesGL.glMatrixFrustumEXT) InternalTool.GetGLMethodAdress("glMatrixFrustumEXT", typeof(dgtk.OpenGL.delegatesGL.glMatrixFrustumEXT));
			}
			if (SuportedExt.Contains("glMatrixIndexPointerARB"))
			{
				dgtk.OpenGL.internalGL.glMatrixIndexPointerARB = (dgtk.OpenGL.delegatesGL.glMatrixIndexPointerARB) InternalTool.GetGLMethodAdress("glMatrixIndexPointerARB", typeof(dgtk.OpenGL.delegatesGL.glMatrixIndexPointerARB));
			}
			if (SuportedExt.Contains("glMatrixIndexPointerOES"))
			{
				dgtk.OpenGL.internalGL.glMatrixIndexPointerOES = (dgtk.OpenGL.delegatesGL.glMatrixIndexPointerOES) InternalTool.GetGLMethodAdress("glMatrixIndexPointerOES", typeof(dgtk.OpenGL.delegatesGL.glMatrixIndexPointerOES));
			}
			if (SuportedExt.Contains("glMatrixIndexubvARB"))
			{
				dgtk.OpenGL.internalGL.glMatrixIndexubvARB = (dgtk.OpenGL.delegatesGL.glMatrixIndexubvARB) InternalTool.GetGLMethodAdress("glMatrixIndexubvARB", typeof(dgtk.OpenGL.delegatesGL.glMatrixIndexubvARB));
			}
			if (SuportedExt.Contains("glMatrixIndexuivARB"))
			{
				dgtk.OpenGL.internalGL.glMatrixIndexuivARB = (dgtk.OpenGL.delegatesGL.glMatrixIndexuivARB) InternalTool.GetGLMethodAdress("glMatrixIndexuivARB", typeof(dgtk.OpenGL.delegatesGL.glMatrixIndexuivARB));
			}
			if (SuportedExt.Contains("glMatrixIndexusvARB"))
			{
				dgtk.OpenGL.internalGL.glMatrixIndexusvARB = (dgtk.OpenGL.delegatesGL.glMatrixIndexusvARB) InternalTool.GetGLMethodAdress("glMatrixIndexusvARB", typeof(dgtk.OpenGL.delegatesGL.glMatrixIndexusvARB));
			}
			if (SuportedExt.Contains("glMatrixLoad3x2fNV"))
			{
				dgtk.OpenGL.internalGL.glMatrixLoad3x2fNV = (dgtk.OpenGL.delegatesGL.glMatrixLoad3x2fNV) InternalTool.GetGLMethodAdress("glMatrixLoad3x2fNV", typeof(dgtk.OpenGL.delegatesGL.glMatrixLoad3x2fNV));
			}
			if (SuportedExt.Contains("glMatrixLoad3x3fNV"))
			{
				dgtk.OpenGL.internalGL.glMatrixLoad3x3fNV = (dgtk.OpenGL.delegatesGL.glMatrixLoad3x3fNV) InternalTool.GetGLMethodAdress("glMatrixLoad3x3fNV", typeof(dgtk.OpenGL.delegatesGL.glMatrixLoad3x3fNV));
			}
			if (SuportedExt.Contains("glMatrixLoaddEXT"))
			{
				dgtk.OpenGL.internalGL.glMatrixLoaddEXT = (dgtk.OpenGL.delegatesGL.glMatrixLoaddEXT) InternalTool.GetGLMethodAdress("glMatrixLoaddEXT", typeof(dgtk.OpenGL.delegatesGL.glMatrixLoaddEXT));
			}
			if (SuportedExt.Contains("glMatrixLoadfEXT"))
			{
				dgtk.OpenGL.internalGL.glMatrixLoadfEXT = (dgtk.OpenGL.delegatesGL.glMatrixLoadfEXT) InternalTool.GetGLMethodAdress("glMatrixLoadfEXT", typeof(dgtk.OpenGL.delegatesGL.glMatrixLoadfEXT));
			}
			if (SuportedExt.Contains("glMatrixLoadIdentityEXT"))
			{
				dgtk.OpenGL.internalGL.glMatrixLoadIdentityEXT = (dgtk.OpenGL.delegatesGL.glMatrixLoadIdentityEXT) InternalTool.GetGLMethodAdress("glMatrixLoadIdentityEXT", typeof(dgtk.OpenGL.delegatesGL.glMatrixLoadIdentityEXT));
			}
			if (SuportedExt.Contains("glMatrixLoadTranspose3x3fNV"))
			{
				dgtk.OpenGL.internalGL.glMatrixLoadTranspose3x3fNV = (dgtk.OpenGL.delegatesGL.glMatrixLoadTranspose3x3fNV) InternalTool.GetGLMethodAdress("glMatrixLoadTranspose3x3fNV", typeof(dgtk.OpenGL.delegatesGL.glMatrixLoadTranspose3x3fNV));
			}
			if (SuportedExt.Contains("glMatrixLoadTransposedEXT"))
			{
				dgtk.OpenGL.internalGL.glMatrixLoadTransposedEXT = (dgtk.OpenGL.delegatesGL.glMatrixLoadTransposedEXT) InternalTool.GetGLMethodAdress("glMatrixLoadTransposedEXT", typeof(dgtk.OpenGL.delegatesGL.glMatrixLoadTransposedEXT));
			}
			if (SuportedExt.Contains("glMatrixLoadTransposefEXT"))
			{
				dgtk.OpenGL.internalGL.glMatrixLoadTransposefEXT = (dgtk.OpenGL.delegatesGL.glMatrixLoadTransposefEXT) InternalTool.GetGLMethodAdress("glMatrixLoadTransposefEXT", typeof(dgtk.OpenGL.delegatesGL.glMatrixLoadTransposefEXT));
			}
			if (SuportedExt.Contains("glMatrixMult3x2fNV"))
			{
				dgtk.OpenGL.internalGL.glMatrixMult3x2fNV = (dgtk.OpenGL.delegatesGL.glMatrixMult3x2fNV) InternalTool.GetGLMethodAdress("glMatrixMult3x2fNV", typeof(dgtk.OpenGL.delegatesGL.glMatrixMult3x2fNV));
			}
			if (SuportedExt.Contains("glMatrixMult3x3fNV"))
			{
				dgtk.OpenGL.internalGL.glMatrixMult3x3fNV = (dgtk.OpenGL.delegatesGL.glMatrixMult3x3fNV) InternalTool.GetGLMethodAdress("glMatrixMult3x3fNV", typeof(dgtk.OpenGL.delegatesGL.glMatrixMult3x3fNV));
			}
			if (SuportedExt.Contains("glMatrixMultdEXT"))
			{
				dgtk.OpenGL.internalGL.glMatrixMultdEXT = (dgtk.OpenGL.delegatesGL.glMatrixMultdEXT) InternalTool.GetGLMethodAdress("glMatrixMultdEXT", typeof(dgtk.OpenGL.delegatesGL.glMatrixMultdEXT));
			}
			if (SuportedExt.Contains("glMatrixMultfEXT"))
			{
				dgtk.OpenGL.internalGL.glMatrixMultfEXT = (dgtk.OpenGL.delegatesGL.glMatrixMultfEXT) InternalTool.GetGLMethodAdress("glMatrixMultfEXT", typeof(dgtk.OpenGL.delegatesGL.glMatrixMultfEXT));
			}
			if (SuportedExt.Contains("glMatrixMultTranspose3x3fNV"))
			{
				dgtk.OpenGL.internalGL.glMatrixMultTranspose3x3fNV = (dgtk.OpenGL.delegatesGL.glMatrixMultTranspose3x3fNV) InternalTool.GetGLMethodAdress("glMatrixMultTranspose3x3fNV", typeof(dgtk.OpenGL.delegatesGL.glMatrixMultTranspose3x3fNV));
			}
			if (SuportedExt.Contains("glMatrixMultTransposedEXT"))
			{
				dgtk.OpenGL.internalGL.glMatrixMultTransposedEXT = (dgtk.OpenGL.delegatesGL.glMatrixMultTransposedEXT) InternalTool.GetGLMethodAdress("glMatrixMultTransposedEXT", typeof(dgtk.OpenGL.delegatesGL.glMatrixMultTransposedEXT));
			}
			if (SuportedExt.Contains("glMatrixMultTransposefEXT"))
			{
				dgtk.OpenGL.internalGL.glMatrixMultTransposefEXT = (dgtk.OpenGL.delegatesGL.glMatrixMultTransposefEXT) InternalTool.GetGLMethodAdress("glMatrixMultTransposefEXT", typeof(dgtk.OpenGL.delegatesGL.glMatrixMultTransposefEXT));
			}
			if (SuportedExt.Contains("glMatrixOrthoEXT"))
			{
				dgtk.OpenGL.internalGL.glMatrixOrthoEXT = (dgtk.OpenGL.delegatesGL.glMatrixOrthoEXT) InternalTool.GetGLMethodAdress("glMatrixOrthoEXT", typeof(dgtk.OpenGL.delegatesGL.glMatrixOrthoEXT));
			}
			if (SuportedExt.Contains("glMatrixPopEXT"))
			{
				dgtk.OpenGL.internalGL.glMatrixPopEXT = (dgtk.OpenGL.delegatesGL.glMatrixPopEXT) InternalTool.GetGLMethodAdress("glMatrixPopEXT", typeof(dgtk.OpenGL.delegatesGL.glMatrixPopEXT));
			}
			if (SuportedExt.Contains("glMatrixPushEXT"))
			{
				dgtk.OpenGL.internalGL.glMatrixPushEXT = (dgtk.OpenGL.delegatesGL.glMatrixPushEXT) InternalTool.GetGLMethodAdress("glMatrixPushEXT", typeof(dgtk.OpenGL.delegatesGL.glMatrixPushEXT));
			}
			if (SuportedExt.Contains("glMatrixRotatedEXT"))
			{
				dgtk.OpenGL.internalGL.glMatrixRotatedEXT = (dgtk.OpenGL.delegatesGL.glMatrixRotatedEXT) InternalTool.GetGLMethodAdress("glMatrixRotatedEXT", typeof(dgtk.OpenGL.delegatesGL.glMatrixRotatedEXT));
			}
			if (SuportedExt.Contains("glMatrixRotatefEXT"))
			{
				dgtk.OpenGL.internalGL.glMatrixRotatefEXT = (dgtk.OpenGL.delegatesGL.glMatrixRotatefEXT) InternalTool.GetGLMethodAdress("glMatrixRotatefEXT", typeof(dgtk.OpenGL.delegatesGL.glMatrixRotatefEXT));
			}
			if (SuportedExt.Contains("glMatrixScaledEXT"))
			{
				dgtk.OpenGL.internalGL.glMatrixScaledEXT = (dgtk.OpenGL.delegatesGL.glMatrixScaledEXT) InternalTool.GetGLMethodAdress("glMatrixScaledEXT", typeof(dgtk.OpenGL.delegatesGL.glMatrixScaledEXT));
			}
			if (SuportedExt.Contains("glMatrixScalefEXT"))
			{
				dgtk.OpenGL.internalGL.glMatrixScalefEXT = (dgtk.OpenGL.delegatesGL.glMatrixScalefEXT) InternalTool.GetGLMethodAdress("glMatrixScalefEXT", typeof(dgtk.OpenGL.delegatesGL.glMatrixScalefEXT));
			}
			if (SuportedExt.Contains("glMatrixTranslatedEXT"))
			{
				dgtk.OpenGL.internalGL.glMatrixTranslatedEXT = (dgtk.OpenGL.delegatesGL.glMatrixTranslatedEXT) InternalTool.GetGLMethodAdress("glMatrixTranslatedEXT", typeof(dgtk.OpenGL.delegatesGL.glMatrixTranslatedEXT));
			}
			if (SuportedExt.Contains("glMatrixTranslatefEXT"))
			{
				dgtk.OpenGL.internalGL.glMatrixTranslatefEXT = (dgtk.OpenGL.delegatesGL.glMatrixTranslatefEXT) InternalTool.GetGLMethodAdress("glMatrixTranslatefEXT", typeof(dgtk.OpenGL.delegatesGL.glMatrixTranslatefEXT));
			}
			if (SuportedExt.Contains("glMaxShaderCompilerThreadsARB"))
			{
				dgtk.OpenGL.internalGL.glMaxShaderCompilerThreadsARB = (dgtk.OpenGL.delegatesGL.glMaxShaderCompilerThreadsARB) InternalTool.GetGLMethodAdress("glMaxShaderCompilerThreadsARB", typeof(dgtk.OpenGL.delegatesGL.glMaxShaderCompilerThreadsARB));
			}
			if (SuportedExt.Contains("glMaxShaderCompilerThreadsKHR"))
			{
				dgtk.OpenGL.internalGL.glMaxShaderCompilerThreadsKHR = (dgtk.OpenGL.delegatesGL.glMaxShaderCompilerThreadsKHR) InternalTool.GetGLMethodAdress("glMaxShaderCompilerThreadsKHR", typeof(dgtk.OpenGL.delegatesGL.glMaxShaderCompilerThreadsKHR));
			}
			if (SuportedExt.Contains("glMemoryBarrierEXT"))
			{
				dgtk.OpenGL.internalGL.glMemoryBarrierEXT = (dgtk.OpenGL.delegatesGL.glMemoryBarrierEXT) InternalTool.GetGLMethodAdress("glMemoryBarrierEXT", typeof(dgtk.OpenGL.delegatesGL.glMemoryBarrierEXT));
			}
			if (SuportedExt.Contains("glMemoryObjectParameterivEXT"))
			{
				dgtk.OpenGL.internalGL.glMemoryObjectParameterivEXT = (dgtk.OpenGL.delegatesGL.glMemoryObjectParameterivEXT) InternalTool.GetGLMethodAdress("glMemoryObjectParameterivEXT", typeof(dgtk.OpenGL.delegatesGL.glMemoryObjectParameterivEXT));
			}
			if (SuportedExt.Contains("glMinmax"))
			{
				dgtk.OpenGL.internalGL.glMinmax = (dgtk.OpenGL.delegatesGL.glMinmax) InternalTool.GetGLMethodAdress("glMinmax", typeof(dgtk.OpenGL.delegatesGL.glMinmax));
			}
			if (SuportedExt.Contains("glMinmaxEXT"))
			{
				dgtk.OpenGL.internalGL.glMinmaxEXT = (dgtk.OpenGL.delegatesGL.glMinmaxEXT) InternalTool.GetGLMethodAdress("glMinmaxEXT", typeof(dgtk.OpenGL.delegatesGL.glMinmaxEXT));
			}
			if (SuportedExt.Contains("glMinSampleShadingARB"))
			{
				dgtk.OpenGL.internalGL.glMinSampleShadingARB = (dgtk.OpenGL.delegatesGL.glMinSampleShadingARB) InternalTool.GetGLMethodAdress("glMinSampleShadingARB", typeof(dgtk.OpenGL.delegatesGL.glMinSampleShadingARB));
			}
			if (SuportedExt.Contains("glMinSampleShadingOES"))
			{
				dgtk.OpenGL.internalGL.glMinSampleShadingOES = (dgtk.OpenGL.delegatesGL.glMinSampleShadingOES) InternalTool.GetGLMethodAdress("glMinSampleShadingOES", typeof(dgtk.OpenGL.delegatesGL.glMinSampleShadingOES));
			}
			if (SuportedExt.Contains("glMulticastBarrierNV"))
			{
				dgtk.OpenGL.internalGL.glMulticastBarrierNV = (dgtk.OpenGL.delegatesGL.glMulticastBarrierNV) InternalTool.GetGLMethodAdress("glMulticastBarrierNV", typeof(dgtk.OpenGL.delegatesGL.glMulticastBarrierNV));
			}
			if (SuportedExt.Contains("glMulticastBlitFramebufferNV"))
			{
				dgtk.OpenGL.internalGL.glMulticastBlitFramebufferNV = (dgtk.OpenGL.delegatesGL.glMulticastBlitFramebufferNV) InternalTool.GetGLMethodAdress("glMulticastBlitFramebufferNV", typeof(dgtk.OpenGL.delegatesGL.glMulticastBlitFramebufferNV));
			}
			if (SuportedExt.Contains("glMulticastBufferSubDataNV"))
			{
				dgtk.OpenGL.internalGL.glMulticastBufferSubDataNV = (dgtk.OpenGL.delegatesGL.glMulticastBufferSubDataNV) InternalTool.GetGLMethodAdress("glMulticastBufferSubDataNV", typeof(dgtk.OpenGL.delegatesGL.glMulticastBufferSubDataNV));
			}
			if (SuportedExt.Contains("glMulticastCopyBufferSubDataNV"))
			{
				dgtk.OpenGL.internalGL.glMulticastCopyBufferSubDataNV = (dgtk.OpenGL.delegatesGL.glMulticastCopyBufferSubDataNV) InternalTool.GetGLMethodAdress("glMulticastCopyBufferSubDataNV", typeof(dgtk.OpenGL.delegatesGL.glMulticastCopyBufferSubDataNV));
			}
			if (SuportedExt.Contains("glMulticastCopyImageSubDataNV"))
			{
				dgtk.OpenGL.internalGL.glMulticastCopyImageSubDataNV = (dgtk.OpenGL.delegatesGL.glMulticastCopyImageSubDataNV) InternalTool.GetGLMethodAdress("glMulticastCopyImageSubDataNV", typeof(dgtk.OpenGL.delegatesGL.glMulticastCopyImageSubDataNV));
			}
			if (SuportedExt.Contains("glMulticastFramebufferSampleLocationsfvNV"))
			{
				dgtk.OpenGL.internalGL.glMulticastFramebufferSampleLocationsfvNV = (dgtk.OpenGL.delegatesGL.glMulticastFramebufferSampleLocationsfvNV) InternalTool.GetGLMethodAdress("glMulticastFramebufferSampleLocationsfvNV", typeof(dgtk.OpenGL.delegatesGL.glMulticastFramebufferSampleLocationsfvNV));
			}
			if (SuportedExt.Contains("glMulticastGetQueryObjecti64vNV"))
			{
				dgtk.OpenGL.internalGL.glMulticastGetQueryObjecti64vNV = (dgtk.OpenGL.delegatesGL.glMulticastGetQueryObjecti64vNV) InternalTool.GetGLMethodAdress("glMulticastGetQueryObjecti64vNV", typeof(dgtk.OpenGL.delegatesGL.glMulticastGetQueryObjecti64vNV));
			}
			if (SuportedExt.Contains("glMulticastGetQueryObjectivNV"))
			{
				dgtk.OpenGL.internalGL.glMulticastGetQueryObjectivNV = (dgtk.OpenGL.delegatesGL.glMulticastGetQueryObjectivNV) InternalTool.GetGLMethodAdress("glMulticastGetQueryObjectivNV", typeof(dgtk.OpenGL.delegatesGL.glMulticastGetQueryObjectivNV));
			}
			if (SuportedExt.Contains("glMulticastGetQueryObjectui64vNV"))
			{
				dgtk.OpenGL.internalGL.glMulticastGetQueryObjectui64vNV = (dgtk.OpenGL.delegatesGL.glMulticastGetQueryObjectui64vNV) InternalTool.GetGLMethodAdress("glMulticastGetQueryObjectui64vNV", typeof(dgtk.OpenGL.delegatesGL.glMulticastGetQueryObjectui64vNV));
			}
			if (SuportedExt.Contains("glMulticastGetQueryObjectuivNV"))
			{
				dgtk.OpenGL.internalGL.glMulticastGetQueryObjectuivNV = (dgtk.OpenGL.delegatesGL.glMulticastGetQueryObjectuivNV) InternalTool.GetGLMethodAdress("glMulticastGetQueryObjectuivNV", typeof(dgtk.OpenGL.delegatesGL.glMulticastGetQueryObjectuivNV));
			}
			if (SuportedExt.Contains("glMulticastScissorArrayvNVX"))
			{
				dgtk.OpenGL.internalGL.glMulticastScissorArrayvNVX = (dgtk.OpenGL.delegatesGL.glMulticastScissorArrayvNVX) InternalTool.GetGLMethodAdress("glMulticastScissorArrayvNVX", typeof(dgtk.OpenGL.delegatesGL.glMulticastScissorArrayvNVX));
			}
			if (SuportedExt.Contains("glMulticastViewportArrayvNVX"))
			{
				dgtk.OpenGL.internalGL.glMulticastViewportArrayvNVX = (dgtk.OpenGL.delegatesGL.glMulticastViewportArrayvNVX) InternalTool.GetGLMethodAdress("glMulticastViewportArrayvNVX", typeof(dgtk.OpenGL.delegatesGL.glMulticastViewportArrayvNVX));
			}
			if (SuportedExt.Contains("glMulticastViewportPositionWScaleNVX"))
			{
				dgtk.OpenGL.internalGL.glMulticastViewportPositionWScaleNVX = (dgtk.OpenGL.delegatesGL.glMulticastViewportPositionWScaleNVX) InternalTool.GetGLMethodAdress("glMulticastViewportPositionWScaleNVX", typeof(dgtk.OpenGL.delegatesGL.glMulticastViewportPositionWScaleNVX));
			}
			if (SuportedExt.Contains("glMulticastWaitSyncNV"))
			{
				dgtk.OpenGL.internalGL.glMulticastWaitSyncNV = (dgtk.OpenGL.delegatesGL.glMulticastWaitSyncNV) InternalTool.GetGLMethodAdress("glMulticastWaitSyncNV", typeof(dgtk.OpenGL.delegatesGL.glMulticastWaitSyncNV));
			}
			if (SuportedExt.Contains("glMultiDrawArraysEXT"))
			{
				dgtk.OpenGL.internalGL.glMultiDrawArraysEXT = (dgtk.OpenGL.delegatesGL.glMultiDrawArraysEXT) InternalTool.GetGLMethodAdress("glMultiDrawArraysEXT", typeof(dgtk.OpenGL.delegatesGL.glMultiDrawArraysEXT));
			}
			if (SuportedExt.Contains("glMultiDrawArraysIndirectAMD"))
			{
				dgtk.OpenGL.internalGL.glMultiDrawArraysIndirectAMD = (dgtk.OpenGL.delegatesGL.glMultiDrawArraysIndirectAMD) InternalTool.GetGLMethodAdress("glMultiDrawArraysIndirectAMD", typeof(dgtk.OpenGL.delegatesGL.glMultiDrawArraysIndirectAMD));
			}
			if (SuportedExt.Contains("glMultiDrawArraysIndirectBindlessCountNV"))
			{
				dgtk.OpenGL.internalGL.glMultiDrawArraysIndirectBindlessCountNV = (dgtk.OpenGL.delegatesGL.glMultiDrawArraysIndirectBindlessCountNV) InternalTool.GetGLMethodAdress("glMultiDrawArraysIndirectBindlessCountNV", typeof(dgtk.OpenGL.delegatesGL.glMultiDrawArraysIndirectBindlessCountNV));
			}
			if (SuportedExt.Contains("glMultiDrawArraysIndirectBindlessNV"))
			{
				dgtk.OpenGL.internalGL.glMultiDrawArraysIndirectBindlessNV = (dgtk.OpenGL.delegatesGL.glMultiDrawArraysIndirectBindlessNV) InternalTool.GetGLMethodAdress("glMultiDrawArraysIndirectBindlessNV", typeof(dgtk.OpenGL.delegatesGL.glMultiDrawArraysIndirectBindlessNV));
			}
			if (SuportedExt.Contains("glMultiDrawArraysIndirectCountARB"))
			{
				dgtk.OpenGL.internalGL.glMultiDrawArraysIndirectCountARB = (dgtk.OpenGL.delegatesGL.glMultiDrawArraysIndirectCountARB) InternalTool.GetGLMethodAdress("glMultiDrawArraysIndirectCountARB", typeof(dgtk.OpenGL.delegatesGL.glMultiDrawArraysIndirectCountARB));
			}
			if (SuportedExt.Contains("glMultiDrawArraysIndirectEXT"))
			{
				dgtk.OpenGL.internalGL.glMultiDrawArraysIndirectEXT = (dgtk.OpenGL.delegatesGL.glMultiDrawArraysIndirectEXT) InternalTool.GetGLMethodAdress("glMultiDrawArraysIndirectEXT", typeof(dgtk.OpenGL.delegatesGL.glMultiDrawArraysIndirectEXT));
			}
			if (SuportedExt.Contains("glMultiDrawElementArrayAPPLE"))
			{
				dgtk.OpenGL.internalGL.glMultiDrawElementArrayAPPLE = (dgtk.OpenGL.delegatesGL.glMultiDrawElementArrayAPPLE) InternalTool.GetGLMethodAdress("glMultiDrawElementArrayAPPLE", typeof(dgtk.OpenGL.delegatesGL.glMultiDrawElementArrayAPPLE));
			}
			if (SuportedExt.Contains("glMultiDrawElementsBaseVertexEXT"))
			{
				dgtk.OpenGL.internalGL.glMultiDrawElementsBaseVertexEXT = (dgtk.OpenGL.delegatesGL.glMultiDrawElementsBaseVertexEXT) InternalTool.GetGLMethodAdress("glMultiDrawElementsBaseVertexEXT", typeof(dgtk.OpenGL.delegatesGL.glMultiDrawElementsBaseVertexEXT));
			}
			if (SuportedExt.Contains("glMultiDrawElementsEXT"))
			{
				dgtk.OpenGL.internalGL.glMultiDrawElementsEXT = (dgtk.OpenGL.delegatesGL.glMultiDrawElementsEXT) InternalTool.GetGLMethodAdress("glMultiDrawElementsEXT", typeof(dgtk.OpenGL.delegatesGL.glMultiDrawElementsEXT));
			}
			if (SuportedExt.Contains("glMultiDrawElementsIndirectAMD"))
			{
				dgtk.OpenGL.internalGL.glMultiDrawElementsIndirectAMD = (dgtk.OpenGL.delegatesGL.glMultiDrawElementsIndirectAMD) InternalTool.GetGLMethodAdress("glMultiDrawElementsIndirectAMD", typeof(dgtk.OpenGL.delegatesGL.glMultiDrawElementsIndirectAMD));
			}
			if (SuportedExt.Contains("glMultiDrawElementsIndirectBindlessCountNV"))
			{
				dgtk.OpenGL.internalGL.glMultiDrawElementsIndirectBindlessCountNV = (dgtk.OpenGL.delegatesGL.glMultiDrawElementsIndirectBindlessCountNV) InternalTool.GetGLMethodAdress("glMultiDrawElementsIndirectBindlessCountNV", typeof(dgtk.OpenGL.delegatesGL.glMultiDrawElementsIndirectBindlessCountNV));
			}
			if (SuportedExt.Contains("glMultiDrawElementsIndirectBindlessNV"))
			{
				dgtk.OpenGL.internalGL.glMultiDrawElementsIndirectBindlessNV = (dgtk.OpenGL.delegatesGL.glMultiDrawElementsIndirectBindlessNV) InternalTool.GetGLMethodAdress("glMultiDrawElementsIndirectBindlessNV", typeof(dgtk.OpenGL.delegatesGL.glMultiDrawElementsIndirectBindlessNV));
			}
			if (SuportedExt.Contains("glMultiDrawElementsIndirectCountARB"))
			{
				dgtk.OpenGL.internalGL.glMultiDrawElementsIndirectCountARB = (dgtk.OpenGL.delegatesGL.glMultiDrawElementsIndirectCountARB) InternalTool.GetGLMethodAdress("glMultiDrawElementsIndirectCountARB", typeof(dgtk.OpenGL.delegatesGL.glMultiDrawElementsIndirectCountARB));
			}
			if (SuportedExt.Contains("glMultiDrawElementsIndirectEXT"))
			{
				dgtk.OpenGL.internalGL.glMultiDrawElementsIndirectEXT = (dgtk.OpenGL.delegatesGL.glMultiDrawElementsIndirectEXT) InternalTool.GetGLMethodAdress("glMultiDrawElementsIndirectEXT", typeof(dgtk.OpenGL.delegatesGL.glMultiDrawElementsIndirectEXT));
			}
			if (SuportedExt.Contains("glMultiDrawMeshTasksIndirectCountNV"))
			{
				dgtk.OpenGL.internalGL.glMultiDrawMeshTasksIndirectCountNV = (dgtk.OpenGL.delegatesGL.glMultiDrawMeshTasksIndirectCountNV) InternalTool.GetGLMethodAdress("glMultiDrawMeshTasksIndirectCountNV", typeof(dgtk.OpenGL.delegatesGL.glMultiDrawMeshTasksIndirectCountNV));
			}
			if (SuportedExt.Contains("glMultiDrawMeshTasksIndirectNV"))
			{
				dgtk.OpenGL.internalGL.glMultiDrawMeshTasksIndirectNV = (dgtk.OpenGL.delegatesGL.glMultiDrawMeshTasksIndirectNV) InternalTool.GetGLMethodAdress("glMultiDrawMeshTasksIndirectNV", typeof(dgtk.OpenGL.delegatesGL.glMultiDrawMeshTasksIndirectNV));
			}
			if (SuportedExt.Contains("glMultiDrawRangeElementArrayAPPLE"))
			{
				dgtk.OpenGL.internalGL.glMultiDrawRangeElementArrayAPPLE = (dgtk.OpenGL.delegatesGL.glMultiDrawRangeElementArrayAPPLE) InternalTool.GetGLMethodAdress("glMultiDrawRangeElementArrayAPPLE", typeof(dgtk.OpenGL.delegatesGL.glMultiDrawRangeElementArrayAPPLE));
			}
			if (SuportedExt.Contains("glMultiModeDrawArraysIBM"))
			{
				dgtk.OpenGL.internalGL.glMultiModeDrawArraysIBM = (dgtk.OpenGL.delegatesGL.glMultiModeDrawArraysIBM) InternalTool.GetGLMethodAdress("glMultiModeDrawArraysIBM", typeof(dgtk.OpenGL.delegatesGL.glMultiModeDrawArraysIBM));
			}
			if (SuportedExt.Contains("glMultiModeDrawElementsIBM"))
			{
				dgtk.OpenGL.internalGL.glMultiModeDrawElementsIBM = (dgtk.OpenGL.delegatesGL.glMultiModeDrawElementsIBM) InternalTool.GetGLMethodAdress("glMultiModeDrawElementsIBM", typeof(dgtk.OpenGL.delegatesGL.glMultiModeDrawElementsIBM));
			}
			if (SuportedExt.Contains("glMultiTexBufferEXT"))
			{
				dgtk.OpenGL.internalGL.glMultiTexBufferEXT = (dgtk.OpenGL.delegatesGL.glMultiTexBufferEXT) InternalTool.GetGLMethodAdress("glMultiTexBufferEXT", typeof(dgtk.OpenGL.delegatesGL.glMultiTexBufferEXT));
			}
			if (SuportedExt.Contains("glMultiTexCoord1bOES"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord1bOES = (dgtk.OpenGL.delegatesGL.glMultiTexCoord1bOES) InternalTool.GetGLMethodAdress("glMultiTexCoord1bOES", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord1bOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord1bvOES"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord1bvOES = (dgtk.OpenGL.delegatesGL.glMultiTexCoord1bvOES) InternalTool.GetGLMethodAdress("glMultiTexCoord1bvOES", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord1bvOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord1dARB"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord1dARB = (dgtk.OpenGL.delegatesGL.glMultiTexCoord1dARB) InternalTool.GetGLMethodAdress("glMultiTexCoord1dARB", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord1dARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord1dvARB"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord1dvARB = (dgtk.OpenGL.delegatesGL.glMultiTexCoord1dvARB) InternalTool.GetGLMethodAdress("glMultiTexCoord1dvARB", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord1dvARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord1fARB"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord1fARB = (dgtk.OpenGL.delegatesGL.glMultiTexCoord1fARB) InternalTool.GetGLMethodAdress("glMultiTexCoord1fARB", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord1fARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord1fvARB"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord1fvARB = (dgtk.OpenGL.delegatesGL.glMultiTexCoord1fvARB) InternalTool.GetGLMethodAdress("glMultiTexCoord1fvARB", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord1fvARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord1hNV"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord1hNV = (dgtk.OpenGL.delegatesGL.glMultiTexCoord1hNV) InternalTool.GetGLMethodAdress("glMultiTexCoord1hNV", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord1hNV));
			}
			if (SuportedExt.Contains("glMultiTexCoord1hvNV"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord1hvNV = (dgtk.OpenGL.delegatesGL.glMultiTexCoord1hvNV) InternalTool.GetGLMethodAdress("glMultiTexCoord1hvNV", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord1hvNV));
			}
			if (SuportedExt.Contains("glMultiTexCoord1iARB"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord1iARB = (dgtk.OpenGL.delegatesGL.glMultiTexCoord1iARB) InternalTool.GetGLMethodAdress("glMultiTexCoord1iARB", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord1iARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord1ivARB"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord1ivARB = (dgtk.OpenGL.delegatesGL.glMultiTexCoord1ivARB) InternalTool.GetGLMethodAdress("glMultiTexCoord1ivARB", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord1ivARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord1sARB"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord1sARB = (dgtk.OpenGL.delegatesGL.glMultiTexCoord1sARB) InternalTool.GetGLMethodAdress("glMultiTexCoord1sARB", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord1sARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord1svARB"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord1svARB = (dgtk.OpenGL.delegatesGL.glMultiTexCoord1svARB) InternalTool.GetGLMethodAdress("glMultiTexCoord1svARB", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord1svARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord1xOES"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord1xOES = (dgtk.OpenGL.delegatesGL.glMultiTexCoord1xOES) InternalTool.GetGLMethodAdress("glMultiTexCoord1xOES", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord1xOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord1xvOES"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord1xvOES = (dgtk.OpenGL.delegatesGL.glMultiTexCoord1xvOES) InternalTool.GetGLMethodAdress("glMultiTexCoord1xvOES", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord1xvOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord2bOES"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord2bOES = (dgtk.OpenGL.delegatesGL.glMultiTexCoord2bOES) InternalTool.GetGLMethodAdress("glMultiTexCoord2bOES", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord2bOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord2bvOES"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord2bvOES = (dgtk.OpenGL.delegatesGL.glMultiTexCoord2bvOES) InternalTool.GetGLMethodAdress("glMultiTexCoord2bvOES", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord2bvOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord2dARB"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord2dARB = (dgtk.OpenGL.delegatesGL.glMultiTexCoord2dARB) InternalTool.GetGLMethodAdress("glMultiTexCoord2dARB", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord2dARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord2dvARB"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord2dvARB = (dgtk.OpenGL.delegatesGL.glMultiTexCoord2dvARB) InternalTool.GetGLMethodAdress("glMultiTexCoord2dvARB", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord2dvARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord2fARB"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord2fARB = (dgtk.OpenGL.delegatesGL.glMultiTexCoord2fARB) InternalTool.GetGLMethodAdress("glMultiTexCoord2fARB", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord2fARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord2fvARB"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord2fvARB = (dgtk.OpenGL.delegatesGL.glMultiTexCoord2fvARB) InternalTool.GetGLMethodAdress("glMultiTexCoord2fvARB", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord2fvARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord2hNV"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord2hNV = (dgtk.OpenGL.delegatesGL.glMultiTexCoord2hNV) InternalTool.GetGLMethodAdress("glMultiTexCoord2hNV", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord2hNV));
			}
			if (SuportedExt.Contains("glMultiTexCoord2hvNV"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord2hvNV = (dgtk.OpenGL.delegatesGL.glMultiTexCoord2hvNV) InternalTool.GetGLMethodAdress("glMultiTexCoord2hvNV", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord2hvNV));
			}
			if (SuportedExt.Contains("glMultiTexCoord2iARB"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord2iARB = (dgtk.OpenGL.delegatesGL.glMultiTexCoord2iARB) InternalTool.GetGLMethodAdress("glMultiTexCoord2iARB", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord2iARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord2ivARB"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord2ivARB = (dgtk.OpenGL.delegatesGL.glMultiTexCoord2ivARB) InternalTool.GetGLMethodAdress("glMultiTexCoord2ivARB", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord2ivARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord2sARB"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord2sARB = (dgtk.OpenGL.delegatesGL.glMultiTexCoord2sARB) InternalTool.GetGLMethodAdress("glMultiTexCoord2sARB", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord2sARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord2svARB"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord2svARB = (dgtk.OpenGL.delegatesGL.glMultiTexCoord2svARB) InternalTool.GetGLMethodAdress("glMultiTexCoord2svARB", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord2svARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord2xOES"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord2xOES = (dgtk.OpenGL.delegatesGL.glMultiTexCoord2xOES) InternalTool.GetGLMethodAdress("glMultiTexCoord2xOES", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord2xOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord2xvOES"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord2xvOES = (dgtk.OpenGL.delegatesGL.glMultiTexCoord2xvOES) InternalTool.GetGLMethodAdress("glMultiTexCoord2xvOES", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord2xvOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord3bOES"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord3bOES = (dgtk.OpenGL.delegatesGL.glMultiTexCoord3bOES) InternalTool.GetGLMethodAdress("glMultiTexCoord3bOES", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord3bOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord3bvOES"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord3bvOES = (dgtk.OpenGL.delegatesGL.glMultiTexCoord3bvOES) InternalTool.GetGLMethodAdress("glMultiTexCoord3bvOES", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord3bvOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord3dARB"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord3dARB = (dgtk.OpenGL.delegatesGL.glMultiTexCoord3dARB) InternalTool.GetGLMethodAdress("glMultiTexCoord3dARB", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord3dARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord3dvARB"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord3dvARB = (dgtk.OpenGL.delegatesGL.glMultiTexCoord3dvARB) InternalTool.GetGLMethodAdress("glMultiTexCoord3dvARB", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord3dvARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord3fARB"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord3fARB = (dgtk.OpenGL.delegatesGL.glMultiTexCoord3fARB) InternalTool.GetGLMethodAdress("glMultiTexCoord3fARB", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord3fARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord3fvARB"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord3fvARB = (dgtk.OpenGL.delegatesGL.glMultiTexCoord3fvARB) InternalTool.GetGLMethodAdress("glMultiTexCoord3fvARB", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord3fvARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord3hNV"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord3hNV = (dgtk.OpenGL.delegatesGL.glMultiTexCoord3hNV) InternalTool.GetGLMethodAdress("glMultiTexCoord3hNV", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord3hNV));
			}
			if (SuportedExt.Contains("glMultiTexCoord3hvNV"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord3hvNV = (dgtk.OpenGL.delegatesGL.glMultiTexCoord3hvNV) InternalTool.GetGLMethodAdress("glMultiTexCoord3hvNV", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord3hvNV));
			}
			if (SuportedExt.Contains("glMultiTexCoord3iARB"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord3iARB = (dgtk.OpenGL.delegatesGL.glMultiTexCoord3iARB) InternalTool.GetGLMethodAdress("glMultiTexCoord3iARB", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord3iARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord3ivARB"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord3ivARB = (dgtk.OpenGL.delegatesGL.glMultiTexCoord3ivARB) InternalTool.GetGLMethodAdress("glMultiTexCoord3ivARB", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord3ivARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord3sARB"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord3sARB = (dgtk.OpenGL.delegatesGL.glMultiTexCoord3sARB) InternalTool.GetGLMethodAdress("glMultiTexCoord3sARB", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord3sARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord3svARB"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord3svARB = (dgtk.OpenGL.delegatesGL.glMultiTexCoord3svARB) InternalTool.GetGLMethodAdress("glMultiTexCoord3svARB", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord3svARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord3xOES"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord3xOES = (dgtk.OpenGL.delegatesGL.glMultiTexCoord3xOES) InternalTool.GetGLMethodAdress("glMultiTexCoord3xOES", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord3xOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord3xvOES"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord3xvOES = (dgtk.OpenGL.delegatesGL.glMultiTexCoord3xvOES) InternalTool.GetGLMethodAdress("glMultiTexCoord3xvOES", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord3xvOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord4bOES"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord4bOES = (dgtk.OpenGL.delegatesGL.glMultiTexCoord4bOES) InternalTool.GetGLMethodAdress("glMultiTexCoord4bOES", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord4bOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord4bvOES"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord4bvOES = (dgtk.OpenGL.delegatesGL.glMultiTexCoord4bvOES) InternalTool.GetGLMethodAdress("glMultiTexCoord4bvOES", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord4bvOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord4dARB"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord4dARB = (dgtk.OpenGL.delegatesGL.glMultiTexCoord4dARB) InternalTool.GetGLMethodAdress("glMultiTexCoord4dARB", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord4dARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord4dvARB"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord4dvARB = (dgtk.OpenGL.delegatesGL.glMultiTexCoord4dvARB) InternalTool.GetGLMethodAdress("glMultiTexCoord4dvARB", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord4dvARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord4fARB"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord4fARB = (dgtk.OpenGL.delegatesGL.glMultiTexCoord4fARB) InternalTool.GetGLMethodAdress("glMultiTexCoord4fARB", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord4fARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord4fvARB"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord4fvARB = (dgtk.OpenGL.delegatesGL.glMultiTexCoord4fvARB) InternalTool.GetGLMethodAdress("glMultiTexCoord4fvARB", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord4fvARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord4hNV"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord4hNV = (dgtk.OpenGL.delegatesGL.glMultiTexCoord4hNV) InternalTool.GetGLMethodAdress("glMultiTexCoord4hNV", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord4hNV));
			}
			if (SuportedExt.Contains("glMultiTexCoord4hvNV"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord4hvNV = (dgtk.OpenGL.delegatesGL.glMultiTexCoord4hvNV) InternalTool.GetGLMethodAdress("glMultiTexCoord4hvNV", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord4hvNV));
			}
			if (SuportedExt.Contains("glMultiTexCoord4iARB"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord4iARB = (dgtk.OpenGL.delegatesGL.glMultiTexCoord4iARB) InternalTool.GetGLMethodAdress("glMultiTexCoord4iARB", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord4iARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord4ivARB"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord4ivARB = (dgtk.OpenGL.delegatesGL.glMultiTexCoord4ivARB) InternalTool.GetGLMethodAdress("glMultiTexCoord4ivARB", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord4ivARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord4sARB"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord4sARB = (dgtk.OpenGL.delegatesGL.glMultiTexCoord4sARB) InternalTool.GetGLMethodAdress("glMultiTexCoord4sARB", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord4sARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord4svARB"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord4svARB = (dgtk.OpenGL.delegatesGL.glMultiTexCoord4svARB) InternalTool.GetGLMethodAdress("glMultiTexCoord4svARB", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord4svARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord4x"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord4x = (dgtk.OpenGL.delegatesGL.glMultiTexCoord4x) InternalTool.GetGLMethodAdress("glMultiTexCoord4x", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord4x));
			}
			if (SuportedExt.Contains("glMultiTexCoord4xOES"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord4xOES = (dgtk.OpenGL.delegatesGL.glMultiTexCoord4xOES) InternalTool.GetGLMethodAdress("glMultiTexCoord4xOES", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord4xOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord4xvOES"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoord4xvOES = (dgtk.OpenGL.delegatesGL.glMultiTexCoord4xvOES) InternalTool.GetGLMethodAdress("glMultiTexCoord4xvOES", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoord4xvOES));
			}
			if (SuportedExt.Contains("glMultiTexCoordPointerEXT"))
			{
				dgtk.OpenGL.internalGL.glMultiTexCoordPointerEXT = (dgtk.OpenGL.delegatesGL.glMultiTexCoordPointerEXT) InternalTool.GetGLMethodAdress("glMultiTexCoordPointerEXT", typeof(dgtk.OpenGL.delegatesGL.glMultiTexCoordPointerEXT));
			}
			if (SuportedExt.Contains("glMultiTexEnvfEXT"))
			{
				dgtk.OpenGL.internalGL.glMultiTexEnvfEXT = (dgtk.OpenGL.delegatesGL.glMultiTexEnvfEXT) InternalTool.GetGLMethodAdress("glMultiTexEnvfEXT", typeof(dgtk.OpenGL.delegatesGL.glMultiTexEnvfEXT));
			}
			if (SuportedExt.Contains("glMultiTexEnvfvEXT"))
			{
				dgtk.OpenGL.internalGL.glMultiTexEnvfvEXT = (dgtk.OpenGL.delegatesGL.glMultiTexEnvfvEXT) InternalTool.GetGLMethodAdress("glMultiTexEnvfvEXT", typeof(dgtk.OpenGL.delegatesGL.glMultiTexEnvfvEXT));
			}
			if (SuportedExt.Contains("glMultiTexEnviEXT"))
			{
				dgtk.OpenGL.internalGL.glMultiTexEnviEXT = (dgtk.OpenGL.delegatesGL.glMultiTexEnviEXT) InternalTool.GetGLMethodAdress("glMultiTexEnviEXT", typeof(dgtk.OpenGL.delegatesGL.glMultiTexEnviEXT));
			}
			if (SuportedExt.Contains("glMultiTexEnvivEXT"))
			{
				dgtk.OpenGL.internalGL.glMultiTexEnvivEXT = (dgtk.OpenGL.delegatesGL.glMultiTexEnvivEXT) InternalTool.GetGLMethodAdress("glMultiTexEnvivEXT", typeof(dgtk.OpenGL.delegatesGL.glMultiTexEnvivEXT));
			}
			if (SuportedExt.Contains("glMultiTexGendEXT"))
			{
				dgtk.OpenGL.internalGL.glMultiTexGendEXT = (dgtk.OpenGL.delegatesGL.glMultiTexGendEXT) InternalTool.GetGLMethodAdress("glMultiTexGendEXT", typeof(dgtk.OpenGL.delegatesGL.glMultiTexGendEXT));
			}
			if (SuportedExt.Contains("glMultiTexGendvEXT"))
			{
				dgtk.OpenGL.internalGL.glMultiTexGendvEXT = (dgtk.OpenGL.delegatesGL.glMultiTexGendvEXT) InternalTool.GetGLMethodAdress("glMultiTexGendvEXT", typeof(dgtk.OpenGL.delegatesGL.glMultiTexGendvEXT));
			}
			if (SuportedExt.Contains("glMultiTexGenfEXT"))
			{
				dgtk.OpenGL.internalGL.glMultiTexGenfEXT = (dgtk.OpenGL.delegatesGL.glMultiTexGenfEXT) InternalTool.GetGLMethodAdress("glMultiTexGenfEXT", typeof(dgtk.OpenGL.delegatesGL.glMultiTexGenfEXT));
			}
			if (SuportedExt.Contains("glMultiTexGenfvEXT"))
			{
				dgtk.OpenGL.internalGL.glMultiTexGenfvEXT = (dgtk.OpenGL.delegatesGL.glMultiTexGenfvEXT) InternalTool.GetGLMethodAdress("glMultiTexGenfvEXT", typeof(dgtk.OpenGL.delegatesGL.glMultiTexGenfvEXT));
			}
			if (SuportedExt.Contains("glMultiTexGeniEXT"))
			{
				dgtk.OpenGL.internalGL.glMultiTexGeniEXT = (dgtk.OpenGL.delegatesGL.glMultiTexGeniEXT) InternalTool.GetGLMethodAdress("glMultiTexGeniEXT", typeof(dgtk.OpenGL.delegatesGL.glMultiTexGeniEXT));
			}
			if (SuportedExt.Contains("glMultiTexGenivEXT"))
			{
				dgtk.OpenGL.internalGL.glMultiTexGenivEXT = (dgtk.OpenGL.delegatesGL.glMultiTexGenivEXT) InternalTool.GetGLMethodAdress("glMultiTexGenivEXT", typeof(dgtk.OpenGL.delegatesGL.glMultiTexGenivEXT));
			}
			if (SuportedExt.Contains("glMultiTexImage1DEXT"))
			{
				dgtk.OpenGL.internalGL.glMultiTexImage1DEXT = (dgtk.OpenGL.delegatesGL.glMultiTexImage1DEXT) InternalTool.GetGLMethodAdress("glMultiTexImage1DEXT", typeof(dgtk.OpenGL.delegatesGL.glMultiTexImage1DEXT));
			}
			if (SuportedExt.Contains("glMultiTexImage2DEXT"))
			{
				dgtk.OpenGL.internalGL.glMultiTexImage2DEXT = (dgtk.OpenGL.delegatesGL.glMultiTexImage2DEXT) InternalTool.GetGLMethodAdress("glMultiTexImage2DEXT", typeof(dgtk.OpenGL.delegatesGL.glMultiTexImage2DEXT));
			}
			if (SuportedExt.Contains("glMultiTexImage3DEXT"))
			{
				dgtk.OpenGL.internalGL.glMultiTexImage3DEXT = (dgtk.OpenGL.delegatesGL.glMultiTexImage3DEXT) InternalTool.GetGLMethodAdress("glMultiTexImage3DEXT", typeof(dgtk.OpenGL.delegatesGL.glMultiTexImage3DEXT));
			}
			if (SuportedExt.Contains("glMultiTexParameterfEXT"))
			{
				dgtk.OpenGL.internalGL.glMultiTexParameterfEXT = (dgtk.OpenGL.delegatesGL.glMultiTexParameterfEXT) InternalTool.GetGLMethodAdress("glMultiTexParameterfEXT", typeof(dgtk.OpenGL.delegatesGL.glMultiTexParameterfEXT));
			}
			if (SuportedExt.Contains("glMultiTexParameterfvEXT"))
			{
				dgtk.OpenGL.internalGL.glMultiTexParameterfvEXT = (dgtk.OpenGL.delegatesGL.glMultiTexParameterfvEXT) InternalTool.GetGLMethodAdress("glMultiTexParameterfvEXT", typeof(dgtk.OpenGL.delegatesGL.glMultiTexParameterfvEXT));
			}
			if (SuportedExt.Contains("glMultiTexParameteriEXT"))
			{
				dgtk.OpenGL.internalGL.glMultiTexParameteriEXT = (dgtk.OpenGL.delegatesGL.glMultiTexParameteriEXT) InternalTool.GetGLMethodAdress("glMultiTexParameteriEXT", typeof(dgtk.OpenGL.delegatesGL.glMultiTexParameteriEXT));
			}
			if (SuportedExt.Contains("glMultiTexParameterIivEXT"))
			{
				dgtk.OpenGL.internalGL.glMultiTexParameterIivEXT = (dgtk.OpenGL.delegatesGL.glMultiTexParameterIivEXT) InternalTool.GetGLMethodAdress("glMultiTexParameterIivEXT", typeof(dgtk.OpenGL.delegatesGL.glMultiTexParameterIivEXT));
			}
			if (SuportedExt.Contains("glMultiTexParameterIuivEXT"))
			{
				dgtk.OpenGL.internalGL.glMultiTexParameterIuivEXT = (dgtk.OpenGL.delegatesGL.glMultiTexParameterIuivEXT) InternalTool.GetGLMethodAdress("glMultiTexParameterIuivEXT", typeof(dgtk.OpenGL.delegatesGL.glMultiTexParameterIuivEXT));
			}
			if (SuportedExt.Contains("glMultiTexParameterivEXT"))
			{
				dgtk.OpenGL.internalGL.glMultiTexParameterivEXT = (dgtk.OpenGL.delegatesGL.glMultiTexParameterivEXT) InternalTool.GetGLMethodAdress("glMultiTexParameterivEXT", typeof(dgtk.OpenGL.delegatesGL.glMultiTexParameterivEXT));
			}
			if (SuportedExt.Contains("glMultiTexRenderbufferEXT"))
			{
				dgtk.OpenGL.internalGL.glMultiTexRenderbufferEXT = (dgtk.OpenGL.delegatesGL.glMultiTexRenderbufferEXT) InternalTool.GetGLMethodAdress("glMultiTexRenderbufferEXT", typeof(dgtk.OpenGL.delegatesGL.glMultiTexRenderbufferEXT));
			}
			if (SuportedExt.Contains("glMultiTexSubImage1DEXT"))
			{
				dgtk.OpenGL.internalGL.glMultiTexSubImage1DEXT = (dgtk.OpenGL.delegatesGL.glMultiTexSubImage1DEXT) InternalTool.GetGLMethodAdress("glMultiTexSubImage1DEXT", typeof(dgtk.OpenGL.delegatesGL.glMultiTexSubImage1DEXT));
			}
			if (SuportedExt.Contains("glMultiTexSubImage2DEXT"))
			{
				dgtk.OpenGL.internalGL.glMultiTexSubImage2DEXT = (dgtk.OpenGL.delegatesGL.glMultiTexSubImage2DEXT) InternalTool.GetGLMethodAdress("glMultiTexSubImage2DEXT", typeof(dgtk.OpenGL.delegatesGL.glMultiTexSubImage2DEXT));
			}
			if (SuportedExt.Contains("glMultiTexSubImage3DEXT"))
			{
				dgtk.OpenGL.internalGL.glMultiTexSubImage3DEXT = (dgtk.OpenGL.delegatesGL.glMultiTexSubImage3DEXT) InternalTool.GetGLMethodAdress("glMultiTexSubImage3DEXT", typeof(dgtk.OpenGL.delegatesGL.glMultiTexSubImage3DEXT));
			}
			if (SuportedExt.Contains("glMultMatrixx"))
			{
				dgtk.OpenGL.internalGL.glMultMatrixx = (dgtk.OpenGL.delegatesGL.glMultMatrixx) InternalTool.GetGLMethodAdress("glMultMatrixx", typeof(dgtk.OpenGL.delegatesGL.glMultMatrixx));
			}
			if (SuportedExt.Contains("glMultMatrixxOES"))
			{
				dgtk.OpenGL.internalGL.glMultMatrixxOES = (dgtk.OpenGL.delegatesGL.glMultMatrixxOES) InternalTool.GetGLMethodAdress("glMultMatrixxOES", typeof(dgtk.OpenGL.delegatesGL.glMultMatrixxOES));
			}
			if (SuportedExt.Contains("glMultTransposeMatrixdARB"))
			{
				dgtk.OpenGL.internalGL.glMultTransposeMatrixdARB = (dgtk.OpenGL.delegatesGL.glMultTransposeMatrixdARB) InternalTool.GetGLMethodAdress("glMultTransposeMatrixdARB", typeof(dgtk.OpenGL.delegatesGL.glMultTransposeMatrixdARB));
			}
			if (SuportedExt.Contains("glMultTransposeMatrixfARB"))
			{
				dgtk.OpenGL.internalGL.glMultTransposeMatrixfARB = (dgtk.OpenGL.delegatesGL.glMultTransposeMatrixfARB) InternalTool.GetGLMethodAdress("glMultTransposeMatrixfARB", typeof(dgtk.OpenGL.delegatesGL.glMultTransposeMatrixfARB));
			}
			if (SuportedExt.Contains("glMultTransposeMatrixxOES"))
			{
				dgtk.OpenGL.internalGL.glMultTransposeMatrixxOES = (dgtk.OpenGL.delegatesGL.glMultTransposeMatrixxOES) InternalTool.GetGLMethodAdress("glMultTransposeMatrixxOES", typeof(dgtk.OpenGL.delegatesGL.glMultTransposeMatrixxOES));
			}
			#endregion

			#region N:

			if (SuportedExt.Contains("glNamedBufferAttachMemoryNV"))
			{
				dgtk.OpenGL.internalGL.glNamedBufferAttachMemoryNV = (dgtk.OpenGL.delegatesGL.glNamedBufferAttachMemoryNV) InternalTool.GetGLMethodAdress("glNamedBufferAttachMemoryNV", typeof(dgtk.OpenGL.delegatesGL.glNamedBufferAttachMemoryNV));
			}
			if (SuportedExt.Contains("glNamedBufferDataEXT"))
			{
				dgtk.OpenGL.internalGL.glNamedBufferDataEXT = (dgtk.OpenGL.delegatesGL.glNamedBufferDataEXT) InternalTool.GetGLMethodAdress("glNamedBufferDataEXT", typeof(dgtk.OpenGL.delegatesGL.glNamedBufferDataEXT));
			}
			if (SuportedExt.Contains("glNamedBufferPageCommitmentARB"))
			{
				dgtk.OpenGL.internalGL.glNamedBufferPageCommitmentARB = (dgtk.OpenGL.delegatesGL.glNamedBufferPageCommitmentARB) InternalTool.GetGLMethodAdress("glNamedBufferPageCommitmentARB", typeof(dgtk.OpenGL.delegatesGL.glNamedBufferPageCommitmentARB));
			}
			if (SuportedExt.Contains("glNamedBufferPageCommitmentEXT"))
			{
				dgtk.OpenGL.internalGL.glNamedBufferPageCommitmentEXT = (dgtk.OpenGL.delegatesGL.glNamedBufferPageCommitmentEXT) InternalTool.GetGLMethodAdress("glNamedBufferPageCommitmentEXT", typeof(dgtk.OpenGL.delegatesGL.glNamedBufferPageCommitmentEXT));
			}
			if (SuportedExt.Contains("glNamedBufferPageCommitmentMemNV"))
			{
				dgtk.OpenGL.internalGL.glNamedBufferPageCommitmentMemNV = (dgtk.OpenGL.delegatesGL.glNamedBufferPageCommitmentMemNV) InternalTool.GetGLMethodAdress("glNamedBufferPageCommitmentMemNV", typeof(dgtk.OpenGL.delegatesGL.glNamedBufferPageCommitmentMemNV));
			}
			if (SuportedExt.Contains("glNamedBufferStorageEXT"))
			{
				dgtk.OpenGL.internalGL.glNamedBufferStorageEXT = (dgtk.OpenGL.delegatesGL.glNamedBufferStorageEXT) InternalTool.GetGLMethodAdress("glNamedBufferStorageEXT", typeof(dgtk.OpenGL.delegatesGL.glNamedBufferStorageEXT));
			}
			if (SuportedExt.Contains("glNamedBufferStorageExternalEXT"))
			{
				dgtk.OpenGL.internalGL.glNamedBufferStorageExternalEXT = (dgtk.OpenGL.delegatesGL.glNamedBufferStorageExternalEXT) InternalTool.GetGLMethodAdress("glNamedBufferStorageExternalEXT", typeof(dgtk.OpenGL.delegatesGL.glNamedBufferStorageExternalEXT));
			}
			if (SuportedExt.Contains("glNamedBufferStorageMemEXT"))
			{
				dgtk.OpenGL.internalGL.glNamedBufferStorageMemEXT = (dgtk.OpenGL.delegatesGL.glNamedBufferStorageMemEXT) InternalTool.GetGLMethodAdress("glNamedBufferStorageMemEXT", typeof(dgtk.OpenGL.delegatesGL.glNamedBufferStorageMemEXT));
			}
			if (SuportedExt.Contains("glNamedBufferSubDataEXT"))
			{
				dgtk.OpenGL.internalGL.glNamedBufferSubDataEXT = (dgtk.OpenGL.delegatesGL.glNamedBufferSubDataEXT) InternalTool.GetGLMethodAdress("glNamedBufferSubDataEXT", typeof(dgtk.OpenGL.delegatesGL.glNamedBufferSubDataEXT));
			}
			if (SuportedExt.Contains("glNamedCopyBufferSubDataEXT"))
			{
				dgtk.OpenGL.internalGL.glNamedCopyBufferSubDataEXT = (dgtk.OpenGL.delegatesGL.glNamedCopyBufferSubDataEXT) InternalTool.GetGLMethodAdress("glNamedCopyBufferSubDataEXT", typeof(dgtk.OpenGL.delegatesGL.glNamedCopyBufferSubDataEXT));
			}
			if (SuportedExt.Contains("glNamedFramebufferParameteriEXT"))
			{
				dgtk.OpenGL.internalGL.glNamedFramebufferParameteriEXT = (dgtk.OpenGL.delegatesGL.glNamedFramebufferParameteriEXT) InternalTool.GetGLMethodAdress("glNamedFramebufferParameteriEXT", typeof(dgtk.OpenGL.delegatesGL.glNamedFramebufferParameteriEXT));
			}
			if (SuportedExt.Contains("glNamedFramebufferRenderbufferEXT"))
			{
				dgtk.OpenGL.internalGL.glNamedFramebufferRenderbufferEXT = (dgtk.OpenGL.delegatesGL.glNamedFramebufferRenderbufferEXT) InternalTool.GetGLMethodAdress("glNamedFramebufferRenderbufferEXT", typeof(dgtk.OpenGL.delegatesGL.glNamedFramebufferRenderbufferEXT));
			}
			if (SuportedExt.Contains("glNamedFramebufferSampleLocationsfvARB"))
			{
				dgtk.OpenGL.internalGL.glNamedFramebufferSampleLocationsfvARB = (dgtk.OpenGL.delegatesGL.glNamedFramebufferSampleLocationsfvARB) InternalTool.GetGLMethodAdress("glNamedFramebufferSampleLocationsfvARB", typeof(dgtk.OpenGL.delegatesGL.glNamedFramebufferSampleLocationsfvARB));
			}
			if (SuportedExt.Contains("glNamedFramebufferSampleLocationsfvNV"))
			{
				dgtk.OpenGL.internalGL.glNamedFramebufferSampleLocationsfvNV = (dgtk.OpenGL.delegatesGL.glNamedFramebufferSampleLocationsfvNV) InternalTool.GetGLMethodAdress("glNamedFramebufferSampleLocationsfvNV", typeof(dgtk.OpenGL.delegatesGL.glNamedFramebufferSampleLocationsfvNV));
			}
			if (SuportedExt.Contains("glNamedFramebufferSamplePositionsfvAMD"))
			{
				dgtk.OpenGL.internalGL.glNamedFramebufferSamplePositionsfvAMD = (dgtk.OpenGL.delegatesGL.glNamedFramebufferSamplePositionsfvAMD) InternalTool.GetGLMethodAdress("glNamedFramebufferSamplePositionsfvAMD", typeof(dgtk.OpenGL.delegatesGL.glNamedFramebufferSamplePositionsfvAMD));
			}
			if (SuportedExt.Contains("glNamedFramebufferTexture1DEXT"))
			{
				dgtk.OpenGL.internalGL.glNamedFramebufferTexture1DEXT = (dgtk.OpenGL.delegatesGL.glNamedFramebufferTexture1DEXT) InternalTool.GetGLMethodAdress("glNamedFramebufferTexture1DEXT", typeof(dgtk.OpenGL.delegatesGL.glNamedFramebufferTexture1DEXT));
			}
			if (SuportedExt.Contains("glNamedFramebufferTexture2DEXT"))
			{
				dgtk.OpenGL.internalGL.glNamedFramebufferTexture2DEXT = (dgtk.OpenGL.delegatesGL.glNamedFramebufferTexture2DEXT) InternalTool.GetGLMethodAdress("glNamedFramebufferTexture2DEXT", typeof(dgtk.OpenGL.delegatesGL.glNamedFramebufferTexture2DEXT));
			}
			if (SuportedExt.Contains("glNamedFramebufferTexture3DEXT"))
			{
				dgtk.OpenGL.internalGL.glNamedFramebufferTexture3DEXT = (dgtk.OpenGL.delegatesGL.glNamedFramebufferTexture3DEXT) InternalTool.GetGLMethodAdress("glNamedFramebufferTexture3DEXT", typeof(dgtk.OpenGL.delegatesGL.glNamedFramebufferTexture3DEXT));
			}
			if (SuportedExt.Contains("glNamedFramebufferTextureEXT"))
			{
				dgtk.OpenGL.internalGL.glNamedFramebufferTextureEXT = (dgtk.OpenGL.delegatesGL.glNamedFramebufferTextureEXT) InternalTool.GetGLMethodAdress("glNamedFramebufferTextureEXT", typeof(dgtk.OpenGL.delegatesGL.glNamedFramebufferTextureEXT));
			}
			if (SuportedExt.Contains("glNamedFramebufferTextureFaceEXT"))
			{
				dgtk.OpenGL.internalGL.glNamedFramebufferTextureFaceEXT = (dgtk.OpenGL.delegatesGL.glNamedFramebufferTextureFaceEXT) InternalTool.GetGLMethodAdress("glNamedFramebufferTextureFaceEXT", typeof(dgtk.OpenGL.delegatesGL.glNamedFramebufferTextureFaceEXT));
			}
			if (SuportedExt.Contains("glNamedFramebufferTextureLayerEXT"))
			{
				dgtk.OpenGL.internalGL.glNamedFramebufferTextureLayerEXT = (dgtk.OpenGL.delegatesGL.glNamedFramebufferTextureLayerEXT) InternalTool.GetGLMethodAdress("glNamedFramebufferTextureLayerEXT", typeof(dgtk.OpenGL.delegatesGL.glNamedFramebufferTextureLayerEXT));
			}
			if (SuportedExt.Contains("glNamedProgramLocalParameter4dEXT"))
			{
				dgtk.OpenGL.internalGL.glNamedProgramLocalParameter4dEXT = (dgtk.OpenGL.delegatesGL.glNamedProgramLocalParameter4dEXT) InternalTool.GetGLMethodAdress("glNamedProgramLocalParameter4dEXT", typeof(dgtk.OpenGL.delegatesGL.glNamedProgramLocalParameter4dEXT));
			}
			if (SuportedExt.Contains("glNamedProgramLocalParameter4dvEXT"))
			{
				dgtk.OpenGL.internalGL.glNamedProgramLocalParameter4dvEXT = (dgtk.OpenGL.delegatesGL.glNamedProgramLocalParameter4dvEXT) InternalTool.GetGLMethodAdress("glNamedProgramLocalParameter4dvEXT", typeof(dgtk.OpenGL.delegatesGL.glNamedProgramLocalParameter4dvEXT));
			}
			if (SuportedExt.Contains("glNamedProgramLocalParameter4fEXT"))
			{
				dgtk.OpenGL.internalGL.glNamedProgramLocalParameter4fEXT = (dgtk.OpenGL.delegatesGL.glNamedProgramLocalParameter4fEXT) InternalTool.GetGLMethodAdress("glNamedProgramLocalParameter4fEXT", typeof(dgtk.OpenGL.delegatesGL.glNamedProgramLocalParameter4fEXT));
			}
			if (SuportedExt.Contains("glNamedProgramLocalParameter4fvEXT"))
			{
				dgtk.OpenGL.internalGL.glNamedProgramLocalParameter4fvEXT = (dgtk.OpenGL.delegatesGL.glNamedProgramLocalParameter4fvEXT) InternalTool.GetGLMethodAdress("glNamedProgramLocalParameter4fvEXT", typeof(dgtk.OpenGL.delegatesGL.glNamedProgramLocalParameter4fvEXT));
			}
			if (SuportedExt.Contains("glNamedProgramLocalParameterI4iEXT"))
			{
				dgtk.OpenGL.internalGL.glNamedProgramLocalParameterI4iEXT = (dgtk.OpenGL.delegatesGL.glNamedProgramLocalParameterI4iEXT) InternalTool.GetGLMethodAdress("glNamedProgramLocalParameterI4iEXT", typeof(dgtk.OpenGL.delegatesGL.glNamedProgramLocalParameterI4iEXT));
			}
			if (SuportedExt.Contains("glNamedProgramLocalParameterI4ivEXT"))
			{
				dgtk.OpenGL.internalGL.glNamedProgramLocalParameterI4ivEXT = (dgtk.OpenGL.delegatesGL.glNamedProgramLocalParameterI4ivEXT) InternalTool.GetGLMethodAdress("glNamedProgramLocalParameterI4ivEXT", typeof(dgtk.OpenGL.delegatesGL.glNamedProgramLocalParameterI4ivEXT));
			}
			if (SuportedExt.Contains("glNamedProgramLocalParameterI4uiEXT"))
			{
				dgtk.OpenGL.internalGL.glNamedProgramLocalParameterI4uiEXT = (dgtk.OpenGL.delegatesGL.glNamedProgramLocalParameterI4uiEXT) InternalTool.GetGLMethodAdress("glNamedProgramLocalParameterI4uiEXT", typeof(dgtk.OpenGL.delegatesGL.glNamedProgramLocalParameterI4uiEXT));
			}
			if (SuportedExt.Contains("glNamedProgramLocalParameterI4uivEXT"))
			{
				dgtk.OpenGL.internalGL.glNamedProgramLocalParameterI4uivEXT = (dgtk.OpenGL.delegatesGL.glNamedProgramLocalParameterI4uivEXT) InternalTool.GetGLMethodAdress("glNamedProgramLocalParameterI4uivEXT", typeof(dgtk.OpenGL.delegatesGL.glNamedProgramLocalParameterI4uivEXT));
			}
			if (SuportedExt.Contains("glNamedProgramLocalParameters4fvEXT"))
			{
				dgtk.OpenGL.internalGL.glNamedProgramLocalParameters4fvEXT = (dgtk.OpenGL.delegatesGL.glNamedProgramLocalParameters4fvEXT) InternalTool.GetGLMethodAdress("glNamedProgramLocalParameters4fvEXT", typeof(dgtk.OpenGL.delegatesGL.glNamedProgramLocalParameters4fvEXT));
			}
			if (SuportedExt.Contains("glNamedProgramLocalParametersI4ivEXT"))
			{
				dgtk.OpenGL.internalGL.glNamedProgramLocalParametersI4ivEXT = (dgtk.OpenGL.delegatesGL.glNamedProgramLocalParametersI4ivEXT) InternalTool.GetGLMethodAdress("glNamedProgramLocalParametersI4ivEXT", typeof(dgtk.OpenGL.delegatesGL.glNamedProgramLocalParametersI4ivEXT));
			}
			if (SuportedExt.Contains("glNamedProgramLocalParametersI4uivEXT"))
			{
				dgtk.OpenGL.internalGL.glNamedProgramLocalParametersI4uivEXT = (dgtk.OpenGL.delegatesGL.glNamedProgramLocalParametersI4uivEXT) InternalTool.GetGLMethodAdress("glNamedProgramLocalParametersI4uivEXT", typeof(dgtk.OpenGL.delegatesGL.glNamedProgramLocalParametersI4uivEXT));
			}
			if (SuportedExt.Contains("glNamedProgramStringEXT"))
			{
				dgtk.OpenGL.internalGL.glNamedProgramStringEXT = (dgtk.OpenGL.delegatesGL.glNamedProgramStringEXT) InternalTool.GetGLMethodAdress("glNamedProgramStringEXT", typeof(dgtk.OpenGL.delegatesGL.glNamedProgramStringEXT));
			}
			if (SuportedExt.Contains("glNamedRenderbufferStorageEXT"))
			{
				dgtk.OpenGL.internalGL.glNamedRenderbufferStorageEXT = (dgtk.OpenGL.delegatesGL.glNamedRenderbufferStorageEXT) InternalTool.GetGLMethodAdress("glNamedRenderbufferStorageEXT", typeof(dgtk.OpenGL.delegatesGL.glNamedRenderbufferStorageEXT));
			}
			if (SuportedExt.Contains("glNamedRenderbufferStorageMultisampleAdvancedAMD"))
			{
				dgtk.OpenGL.internalGL.glNamedRenderbufferStorageMultisampleAdvancedAMD = (dgtk.OpenGL.delegatesGL.glNamedRenderbufferStorageMultisampleAdvancedAMD) InternalTool.GetGLMethodAdress("glNamedRenderbufferStorageMultisampleAdvancedAMD", typeof(dgtk.OpenGL.delegatesGL.glNamedRenderbufferStorageMultisampleAdvancedAMD));
			}
			if (SuportedExt.Contains("glNamedRenderbufferStorageMultisampleCoverageEXT"))
			{
				dgtk.OpenGL.internalGL.glNamedRenderbufferStorageMultisampleCoverageEXT = (dgtk.OpenGL.delegatesGL.glNamedRenderbufferStorageMultisampleCoverageEXT) InternalTool.GetGLMethodAdress("glNamedRenderbufferStorageMultisampleCoverageEXT", typeof(dgtk.OpenGL.delegatesGL.glNamedRenderbufferStorageMultisampleCoverageEXT));
			}
			if (SuportedExt.Contains("glNamedRenderbufferStorageMultisampleEXT"))
			{
				dgtk.OpenGL.internalGL.glNamedRenderbufferStorageMultisampleEXT = (dgtk.OpenGL.delegatesGL.glNamedRenderbufferStorageMultisampleEXT) InternalTool.GetGLMethodAdress("glNamedRenderbufferStorageMultisampleEXT", typeof(dgtk.OpenGL.delegatesGL.glNamedRenderbufferStorageMultisampleEXT));
			}
			if (SuportedExt.Contains("glNamedStringARB"))
			{
				dgtk.OpenGL.internalGL.glNamedStringARB = (dgtk.OpenGL.delegatesGL.glNamedStringARB) InternalTool.GetGLMethodAdress("glNamedStringARB", typeof(dgtk.OpenGL.delegatesGL.glNamedStringARB));
			}
			if (SuportedExt.Contains("glNewObjectBufferATI"))
			{
				dgtk.OpenGL.internalGL.glNewObjectBufferATI = (dgtk.OpenGL.delegatesGL.glNewObjectBufferATI) InternalTool.GetGLMethodAdress("glNewObjectBufferATI", typeof(dgtk.OpenGL.delegatesGL.glNewObjectBufferATI));
			}
			if (SuportedExt.Contains("glNormal3fVertex3fSUN"))
			{
				dgtk.OpenGL.internalGL.glNormal3fVertex3fSUN = (dgtk.OpenGL.delegatesGL.glNormal3fVertex3fSUN) InternalTool.GetGLMethodAdress("glNormal3fVertex3fSUN", typeof(dgtk.OpenGL.delegatesGL.glNormal3fVertex3fSUN));
			}
			if (SuportedExt.Contains("glNormal3fVertex3fvSUN"))
			{
				dgtk.OpenGL.internalGL.glNormal3fVertex3fvSUN = (dgtk.OpenGL.delegatesGL.glNormal3fVertex3fvSUN) InternalTool.GetGLMethodAdress("glNormal3fVertex3fvSUN", typeof(dgtk.OpenGL.delegatesGL.glNormal3fVertex3fvSUN));
			}
			if (SuportedExt.Contains("glNormal3hNV"))
			{
				dgtk.OpenGL.internalGL.glNormal3hNV = (dgtk.OpenGL.delegatesGL.glNormal3hNV) InternalTool.GetGLMethodAdress("glNormal3hNV", typeof(dgtk.OpenGL.delegatesGL.glNormal3hNV));
			}
			if (SuportedExt.Contains("glNormal3hvNV"))
			{
				dgtk.OpenGL.internalGL.glNormal3hvNV = (dgtk.OpenGL.delegatesGL.glNormal3hvNV) InternalTool.GetGLMethodAdress("glNormal3hvNV", typeof(dgtk.OpenGL.delegatesGL.glNormal3hvNV));
			}
			if (SuportedExt.Contains("glNormal3x"))
			{
				dgtk.OpenGL.internalGL.glNormal3x = (dgtk.OpenGL.delegatesGL.glNormal3x) InternalTool.GetGLMethodAdress("glNormal3x", typeof(dgtk.OpenGL.delegatesGL.glNormal3x));
			}
			if (SuportedExt.Contains("glNormal3xOES"))
			{
				dgtk.OpenGL.internalGL.glNormal3xOES = (dgtk.OpenGL.delegatesGL.glNormal3xOES) InternalTool.GetGLMethodAdress("glNormal3xOES", typeof(dgtk.OpenGL.delegatesGL.glNormal3xOES));
			}
			if (SuportedExt.Contains("glNormal3xvOES"))
			{
				dgtk.OpenGL.internalGL.glNormal3xvOES = (dgtk.OpenGL.delegatesGL.glNormal3xvOES) InternalTool.GetGLMethodAdress("glNormal3xvOES", typeof(dgtk.OpenGL.delegatesGL.glNormal3xvOES));
			}
			if (SuportedExt.Contains("glNormalFormatNV"))
			{
				dgtk.OpenGL.internalGL.glNormalFormatNV = (dgtk.OpenGL.delegatesGL.glNormalFormatNV) InternalTool.GetGLMethodAdress("glNormalFormatNV", typeof(dgtk.OpenGL.delegatesGL.glNormalFormatNV));
			}
			if (SuportedExt.Contains("glNormalPointerEXT"))
			{
				dgtk.OpenGL.internalGL.glNormalPointerEXT = (dgtk.OpenGL.delegatesGL.glNormalPointerEXT) InternalTool.GetGLMethodAdress("glNormalPointerEXT", typeof(dgtk.OpenGL.delegatesGL.glNormalPointerEXT));
			}
			if (SuportedExt.Contains("glNormalPointerListIBM"))
			{
				dgtk.OpenGL.internalGL.glNormalPointerListIBM = (dgtk.OpenGL.delegatesGL.glNormalPointerListIBM) InternalTool.GetGLMethodAdress("glNormalPointerListIBM", typeof(dgtk.OpenGL.delegatesGL.glNormalPointerListIBM));
			}
			if (SuportedExt.Contains("glNormalPointervINTEL"))
			{
				dgtk.OpenGL.internalGL.glNormalPointervINTEL = (dgtk.OpenGL.delegatesGL.glNormalPointervINTEL) InternalTool.GetGLMethodAdress("glNormalPointervINTEL", typeof(dgtk.OpenGL.delegatesGL.glNormalPointervINTEL));
			}
			if (SuportedExt.Contains("glNormalStream3bATI"))
			{
				dgtk.OpenGL.internalGL.glNormalStream3bATI = (dgtk.OpenGL.delegatesGL.glNormalStream3bATI) InternalTool.GetGLMethodAdress("glNormalStream3bATI", typeof(dgtk.OpenGL.delegatesGL.glNormalStream3bATI));
			}
			if (SuportedExt.Contains("glNormalStream3bvATI"))
			{
				dgtk.OpenGL.internalGL.glNormalStream3bvATI = (dgtk.OpenGL.delegatesGL.glNormalStream3bvATI) InternalTool.GetGLMethodAdress("glNormalStream3bvATI", typeof(dgtk.OpenGL.delegatesGL.glNormalStream3bvATI));
			}
			if (SuportedExt.Contains("glNormalStream3dATI"))
			{
				dgtk.OpenGL.internalGL.glNormalStream3dATI = (dgtk.OpenGL.delegatesGL.glNormalStream3dATI) InternalTool.GetGLMethodAdress("glNormalStream3dATI", typeof(dgtk.OpenGL.delegatesGL.glNormalStream3dATI));
			}
			if (SuportedExt.Contains("glNormalStream3dvATI"))
			{
				dgtk.OpenGL.internalGL.glNormalStream3dvATI = (dgtk.OpenGL.delegatesGL.glNormalStream3dvATI) InternalTool.GetGLMethodAdress("glNormalStream3dvATI", typeof(dgtk.OpenGL.delegatesGL.glNormalStream3dvATI));
			}
			if (SuportedExt.Contains("glNormalStream3fATI"))
			{
				dgtk.OpenGL.internalGL.glNormalStream3fATI = (dgtk.OpenGL.delegatesGL.glNormalStream3fATI) InternalTool.GetGLMethodAdress("glNormalStream3fATI", typeof(dgtk.OpenGL.delegatesGL.glNormalStream3fATI));
			}
			if (SuportedExt.Contains("glNormalStream3fvATI"))
			{
				dgtk.OpenGL.internalGL.glNormalStream3fvATI = (dgtk.OpenGL.delegatesGL.glNormalStream3fvATI) InternalTool.GetGLMethodAdress("glNormalStream3fvATI", typeof(dgtk.OpenGL.delegatesGL.glNormalStream3fvATI));
			}
			if (SuportedExt.Contains("glNormalStream3iATI"))
			{
				dgtk.OpenGL.internalGL.glNormalStream3iATI = (dgtk.OpenGL.delegatesGL.glNormalStream3iATI) InternalTool.GetGLMethodAdress("glNormalStream3iATI", typeof(dgtk.OpenGL.delegatesGL.glNormalStream3iATI));
			}
			if (SuportedExt.Contains("glNormalStream3ivATI"))
			{
				dgtk.OpenGL.internalGL.glNormalStream3ivATI = (dgtk.OpenGL.delegatesGL.glNormalStream3ivATI) InternalTool.GetGLMethodAdress("glNormalStream3ivATI", typeof(dgtk.OpenGL.delegatesGL.glNormalStream3ivATI));
			}
			if (SuportedExt.Contains("glNormalStream3sATI"))
			{
				dgtk.OpenGL.internalGL.glNormalStream3sATI = (dgtk.OpenGL.delegatesGL.glNormalStream3sATI) InternalTool.GetGLMethodAdress("glNormalStream3sATI", typeof(dgtk.OpenGL.delegatesGL.glNormalStream3sATI));
			}
			if (SuportedExt.Contains("glNormalStream3svATI"))
			{
				dgtk.OpenGL.internalGL.glNormalStream3svATI = (dgtk.OpenGL.delegatesGL.glNormalStream3svATI) InternalTool.GetGLMethodAdress("glNormalStream3svATI", typeof(dgtk.OpenGL.delegatesGL.glNormalStream3svATI));
			}
			#endregion

			#region O:

			if (SuportedExt.Contains("glObjectLabelKHR"))
			{
				dgtk.OpenGL.internalGL.glObjectLabelKHR = (dgtk.OpenGL.delegatesGL.glObjectLabelKHR) InternalTool.GetGLMethodAdress("glObjectLabelKHR", typeof(dgtk.OpenGL.delegatesGL.glObjectLabelKHR));
			}
			if (SuportedExt.Contains("glObjectPtrLabelKHR"))
			{
				dgtk.OpenGL.internalGL.glObjectPtrLabelKHR = (dgtk.OpenGL.delegatesGL.glObjectPtrLabelKHR) InternalTool.GetGLMethodAdress("glObjectPtrLabelKHR", typeof(dgtk.OpenGL.delegatesGL.glObjectPtrLabelKHR));
			}
			if (SuportedExt.Contains("glObjectPurgeableAPPLE"))
			{
				dgtk.OpenGL.internalGL.glObjectPurgeableAPPLE = (dgtk.OpenGL.delegatesGL.glObjectPurgeableAPPLE) InternalTool.GetGLMethodAdress("glObjectPurgeableAPPLE", typeof(dgtk.OpenGL.delegatesGL.glObjectPurgeableAPPLE));
			}
			if (SuportedExt.Contains("glObjectUnpurgeableAPPLE"))
			{
				dgtk.OpenGL.internalGL.glObjectUnpurgeableAPPLE = (dgtk.OpenGL.delegatesGL.glObjectUnpurgeableAPPLE) InternalTool.GetGLMethodAdress("glObjectUnpurgeableAPPLE", typeof(dgtk.OpenGL.delegatesGL.glObjectUnpurgeableAPPLE));
			}
			if (SuportedExt.Contains("glOrthof"))
			{
				dgtk.OpenGL.internalGL.glOrthof = (dgtk.OpenGL.delegatesGL.glOrthof) InternalTool.GetGLMethodAdress("glOrthof", typeof(dgtk.OpenGL.delegatesGL.glOrthof));
			}
			if (SuportedExt.Contains("glOrthofOES"))
			{
				dgtk.OpenGL.internalGL.glOrthofOES = (dgtk.OpenGL.delegatesGL.glOrthofOES) InternalTool.GetGLMethodAdress("glOrthofOES", typeof(dgtk.OpenGL.delegatesGL.glOrthofOES));
			}
			if (SuportedExt.Contains("glOrthox"))
			{
				dgtk.OpenGL.internalGL.glOrthox = (dgtk.OpenGL.delegatesGL.glOrthox) InternalTool.GetGLMethodAdress("glOrthox", typeof(dgtk.OpenGL.delegatesGL.glOrthox));
			}
			if (SuportedExt.Contains("glOrthoxOES"))
			{
				dgtk.OpenGL.internalGL.glOrthoxOES = (dgtk.OpenGL.delegatesGL.glOrthoxOES) InternalTool.GetGLMethodAdress("glOrthoxOES", typeof(dgtk.OpenGL.delegatesGL.glOrthoxOES));
			}
			#endregion

			#region P:

			if (SuportedExt.Contains("glPassTexCoordATI"))
			{
				dgtk.OpenGL.internalGL.glPassTexCoordATI = (dgtk.OpenGL.delegatesGL.glPassTexCoordATI) InternalTool.GetGLMethodAdress("glPassTexCoordATI", typeof(dgtk.OpenGL.delegatesGL.glPassTexCoordATI));
			}
			if (SuportedExt.Contains("glPassThroughxOES"))
			{
				dgtk.OpenGL.internalGL.glPassThroughxOES = (dgtk.OpenGL.delegatesGL.glPassThroughxOES) InternalTool.GetGLMethodAdress("glPassThroughxOES", typeof(dgtk.OpenGL.delegatesGL.glPassThroughxOES));
			}
			if (SuportedExt.Contains("glPatchParameteriEXT"))
			{
				dgtk.OpenGL.internalGL.glPatchParameteriEXT = (dgtk.OpenGL.delegatesGL.glPatchParameteriEXT) InternalTool.GetGLMethodAdress("glPatchParameteriEXT", typeof(dgtk.OpenGL.delegatesGL.glPatchParameteriEXT));
			}
			if (SuportedExt.Contains("glPatchParameteriOES"))
			{
				dgtk.OpenGL.internalGL.glPatchParameteriOES = (dgtk.OpenGL.delegatesGL.glPatchParameteriOES) InternalTool.GetGLMethodAdress("glPatchParameteriOES", typeof(dgtk.OpenGL.delegatesGL.glPatchParameteriOES));
			}
			if (SuportedExt.Contains("glPathColorGenNV"))
			{
				dgtk.OpenGL.internalGL.glPathColorGenNV = (dgtk.OpenGL.delegatesGL.glPathColorGenNV) InternalTool.GetGLMethodAdress("glPathColorGenNV", typeof(dgtk.OpenGL.delegatesGL.glPathColorGenNV));
			}
			if (SuportedExt.Contains("glPathCommandsNV"))
			{
				dgtk.OpenGL.internalGL.glPathCommandsNV = (dgtk.OpenGL.delegatesGL.glPathCommandsNV) InternalTool.GetGLMethodAdress("glPathCommandsNV", typeof(dgtk.OpenGL.delegatesGL.glPathCommandsNV));
			}
			if (SuportedExt.Contains("glPathCoordsNV"))
			{
				dgtk.OpenGL.internalGL.glPathCoordsNV = (dgtk.OpenGL.delegatesGL.glPathCoordsNV) InternalTool.GetGLMethodAdress("glPathCoordsNV", typeof(dgtk.OpenGL.delegatesGL.glPathCoordsNV));
			}
			if (SuportedExt.Contains("glPathCoverDepthFuncNV"))
			{
				dgtk.OpenGL.internalGL.glPathCoverDepthFuncNV = (dgtk.OpenGL.delegatesGL.glPathCoverDepthFuncNV) InternalTool.GetGLMethodAdress("glPathCoverDepthFuncNV", typeof(dgtk.OpenGL.delegatesGL.glPathCoverDepthFuncNV));
			}
			if (SuportedExt.Contains("glPathDashArrayNV"))
			{
				dgtk.OpenGL.internalGL.glPathDashArrayNV = (dgtk.OpenGL.delegatesGL.glPathDashArrayNV) InternalTool.GetGLMethodAdress("glPathDashArrayNV", typeof(dgtk.OpenGL.delegatesGL.glPathDashArrayNV));
			}
			if (SuportedExt.Contains("glPathFogGenNV"))
			{
				dgtk.OpenGL.internalGL.glPathFogGenNV = (dgtk.OpenGL.delegatesGL.glPathFogGenNV) InternalTool.GetGLMethodAdress("glPathFogGenNV", typeof(dgtk.OpenGL.delegatesGL.glPathFogGenNV));
			}
			if (SuportedExt.Contains("glPathGlyphIndexArrayNV"))
			{
				dgtk.OpenGL.internalGL.glPathGlyphIndexArrayNV = (dgtk.OpenGL.delegatesGL.glPathGlyphIndexArrayNV) InternalTool.GetGLMethodAdress("glPathGlyphIndexArrayNV", typeof(dgtk.OpenGL.delegatesGL.glPathGlyphIndexArrayNV));
			}
			if (SuportedExt.Contains("glPathGlyphIndexRangeNV"))
			{
				dgtk.OpenGL.internalGL.glPathGlyphIndexRangeNV = (dgtk.OpenGL.delegatesGL.glPathGlyphIndexRangeNV) InternalTool.GetGLMethodAdress("glPathGlyphIndexRangeNV", typeof(dgtk.OpenGL.delegatesGL.glPathGlyphIndexRangeNV));
			}
			if (SuportedExt.Contains("glPathGlyphRangeNV"))
			{
				dgtk.OpenGL.internalGL.glPathGlyphRangeNV = (dgtk.OpenGL.delegatesGL.glPathGlyphRangeNV) InternalTool.GetGLMethodAdress("glPathGlyphRangeNV", typeof(dgtk.OpenGL.delegatesGL.glPathGlyphRangeNV));
			}
			if (SuportedExt.Contains("glPathGlyphsNV"))
			{
				dgtk.OpenGL.internalGL.glPathGlyphsNV = (dgtk.OpenGL.delegatesGL.glPathGlyphsNV) InternalTool.GetGLMethodAdress("glPathGlyphsNV", typeof(dgtk.OpenGL.delegatesGL.glPathGlyphsNV));
			}
			if (SuportedExt.Contains("glPathMemoryGlyphIndexArrayNV"))
			{
				dgtk.OpenGL.internalGL.glPathMemoryGlyphIndexArrayNV = (dgtk.OpenGL.delegatesGL.glPathMemoryGlyphIndexArrayNV) InternalTool.GetGLMethodAdress("glPathMemoryGlyphIndexArrayNV", typeof(dgtk.OpenGL.delegatesGL.glPathMemoryGlyphIndexArrayNV));
			}
			if (SuportedExt.Contains("glPathParameterfNV"))
			{
				dgtk.OpenGL.internalGL.glPathParameterfNV = (dgtk.OpenGL.delegatesGL.glPathParameterfNV) InternalTool.GetGLMethodAdress("glPathParameterfNV", typeof(dgtk.OpenGL.delegatesGL.glPathParameterfNV));
			}
			if (SuportedExt.Contains("glPathParameterfvNV"))
			{
				dgtk.OpenGL.internalGL.glPathParameterfvNV = (dgtk.OpenGL.delegatesGL.glPathParameterfvNV) InternalTool.GetGLMethodAdress("glPathParameterfvNV", typeof(dgtk.OpenGL.delegatesGL.glPathParameterfvNV));
			}
			if (SuportedExt.Contains("glPathParameteriNV"))
			{
				dgtk.OpenGL.internalGL.glPathParameteriNV = (dgtk.OpenGL.delegatesGL.glPathParameteriNV) InternalTool.GetGLMethodAdress("glPathParameteriNV", typeof(dgtk.OpenGL.delegatesGL.glPathParameteriNV));
			}
			if (SuportedExt.Contains("glPathParameterivNV"))
			{
				dgtk.OpenGL.internalGL.glPathParameterivNV = (dgtk.OpenGL.delegatesGL.glPathParameterivNV) InternalTool.GetGLMethodAdress("glPathParameterivNV", typeof(dgtk.OpenGL.delegatesGL.glPathParameterivNV));
			}
			if (SuportedExt.Contains("glPathStencilDepthOffsetNV"))
			{
				dgtk.OpenGL.internalGL.glPathStencilDepthOffsetNV = (dgtk.OpenGL.delegatesGL.glPathStencilDepthOffsetNV) InternalTool.GetGLMethodAdress("glPathStencilDepthOffsetNV", typeof(dgtk.OpenGL.delegatesGL.glPathStencilDepthOffsetNV));
			}
			if (SuportedExt.Contains("glPathStencilFuncNV"))
			{
				dgtk.OpenGL.internalGL.glPathStencilFuncNV = (dgtk.OpenGL.delegatesGL.glPathStencilFuncNV) InternalTool.GetGLMethodAdress("glPathStencilFuncNV", typeof(dgtk.OpenGL.delegatesGL.glPathStencilFuncNV));
			}
			if (SuportedExt.Contains("glPathStringNV"))
			{
				dgtk.OpenGL.internalGL.glPathStringNV = (dgtk.OpenGL.delegatesGL.glPathStringNV) InternalTool.GetGLMethodAdress("glPathStringNV", typeof(dgtk.OpenGL.delegatesGL.glPathStringNV));
			}
			if (SuportedExt.Contains("glPathSubCommandsNV"))
			{
				dgtk.OpenGL.internalGL.glPathSubCommandsNV = (dgtk.OpenGL.delegatesGL.glPathSubCommandsNV) InternalTool.GetGLMethodAdress("glPathSubCommandsNV", typeof(dgtk.OpenGL.delegatesGL.glPathSubCommandsNV));
			}
			if (SuportedExt.Contains("glPathSubCoordsNV"))
			{
				dgtk.OpenGL.internalGL.glPathSubCoordsNV = (dgtk.OpenGL.delegatesGL.glPathSubCoordsNV) InternalTool.GetGLMethodAdress("glPathSubCoordsNV", typeof(dgtk.OpenGL.delegatesGL.glPathSubCoordsNV));
			}
			if (SuportedExt.Contains("glPathTexGenNV"))
			{
				dgtk.OpenGL.internalGL.glPathTexGenNV = (dgtk.OpenGL.delegatesGL.glPathTexGenNV) InternalTool.GetGLMethodAdress("glPathTexGenNV", typeof(dgtk.OpenGL.delegatesGL.glPathTexGenNV));
			}
			if (SuportedExt.Contains("glPauseTransformFeedbackNV"))
			{
				dgtk.OpenGL.internalGL.glPauseTransformFeedbackNV = (dgtk.OpenGL.delegatesGL.glPauseTransformFeedbackNV) InternalTool.GetGLMethodAdress("glPauseTransformFeedbackNV", typeof(dgtk.OpenGL.delegatesGL.glPauseTransformFeedbackNV));
			}
			if (SuportedExt.Contains("glPixelDataRangeNV"))
			{
				dgtk.OpenGL.internalGL.glPixelDataRangeNV = (dgtk.OpenGL.delegatesGL.glPixelDataRangeNV) InternalTool.GetGLMethodAdress("glPixelDataRangeNV", typeof(dgtk.OpenGL.delegatesGL.glPixelDataRangeNV));
			}
			if (SuportedExt.Contains("glPixelMapx"))
			{
				dgtk.OpenGL.internalGL.glPixelMapx = (dgtk.OpenGL.delegatesGL.glPixelMapx) InternalTool.GetGLMethodAdress("glPixelMapx", typeof(dgtk.OpenGL.delegatesGL.glPixelMapx));
			}
			if (SuportedExt.Contains("glPixelStorex"))
			{
				dgtk.OpenGL.internalGL.glPixelStorex = (dgtk.OpenGL.delegatesGL.glPixelStorex) InternalTool.GetGLMethodAdress("glPixelStorex", typeof(dgtk.OpenGL.delegatesGL.glPixelStorex));
			}
			if (SuportedExt.Contains("glPixelTexGenParameterfSGIS"))
			{
				dgtk.OpenGL.internalGL.glPixelTexGenParameterfSGIS = (dgtk.OpenGL.delegatesGL.glPixelTexGenParameterfSGIS) InternalTool.GetGLMethodAdress("glPixelTexGenParameterfSGIS", typeof(dgtk.OpenGL.delegatesGL.glPixelTexGenParameterfSGIS));
			}
			if (SuportedExt.Contains("glPixelTexGenParameterfvSGIS"))
			{
				dgtk.OpenGL.internalGL.glPixelTexGenParameterfvSGIS = (dgtk.OpenGL.delegatesGL.glPixelTexGenParameterfvSGIS) InternalTool.GetGLMethodAdress("glPixelTexGenParameterfvSGIS", typeof(dgtk.OpenGL.delegatesGL.glPixelTexGenParameterfvSGIS));
			}
			if (SuportedExt.Contains("glPixelTexGenParameteriSGIS"))
			{
				dgtk.OpenGL.internalGL.glPixelTexGenParameteriSGIS = (dgtk.OpenGL.delegatesGL.glPixelTexGenParameteriSGIS) InternalTool.GetGLMethodAdress("glPixelTexGenParameteriSGIS", typeof(dgtk.OpenGL.delegatesGL.glPixelTexGenParameteriSGIS));
			}
			if (SuportedExt.Contains("glPixelTexGenParameterivSGIS"))
			{
				dgtk.OpenGL.internalGL.glPixelTexGenParameterivSGIS = (dgtk.OpenGL.delegatesGL.glPixelTexGenParameterivSGIS) InternalTool.GetGLMethodAdress("glPixelTexGenParameterivSGIS", typeof(dgtk.OpenGL.delegatesGL.glPixelTexGenParameterivSGIS));
			}
			if (SuportedExt.Contains("glPixelTexGenSGIX"))
			{
				dgtk.OpenGL.internalGL.glPixelTexGenSGIX = (dgtk.OpenGL.delegatesGL.glPixelTexGenSGIX) InternalTool.GetGLMethodAdress("glPixelTexGenSGIX", typeof(dgtk.OpenGL.delegatesGL.glPixelTexGenSGIX));
			}
			if (SuportedExt.Contains("glPixelTransferxOES"))
			{
				dgtk.OpenGL.internalGL.glPixelTransferxOES = (dgtk.OpenGL.delegatesGL.glPixelTransferxOES) InternalTool.GetGLMethodAdress("glPixelTransferxOES", typeof(dgtk.OpenGL.delegatesGL.glPixelTransferxOES));
			}
			if (SuportedExt.Contains("glPixelTransformParameterfEXT"))
			{
				dgtk.OpenGL.internalGL.glPixelTransformParameterfEXT = (dgtk.OpenGL.delegatesGL.glPixelTransformParameterfEXT) InternalTool.GetGLMethodAdress("glPixelTransformParameterfEXT", typeof(dgtk.OpenGL.delegatesGL.glPixelTransformParameterfEXT));
			}
			if (SuportedExt.Contains("glPixelTransformParameterfvEXT"))
			{
				dgtk.OpenGL.internalGL.glPixelTransformParameterfvEXT = (dgtk.OpenGL.delegatesGL.glPixelTransformParameterfvEXT) InternalTool.GetGLMethodAdress("glPixelTransformParameterfvEXT", typeof(dgtk.OpenGL.delegatesGL.glPixelTransformParameterfvEXT));
			}
			if (SuportedExt.Contains("glPixelTransformParameteriEXT"))
			{
				dgtk.OpenGL.internalGL.glPixelTransformParameteriEXT = (dgtk.OpenGL.delegatesGL.glPixelTransformParameteriEXT) InternalTool.GetGLMethodAdress("glPixelTransformParameteriEXT", typeof(dgtk.OpenGL.delegatesGL.glPixelTransformParameteriEXT));
			}
			if (SuportedExt.Contains("glPixelTransformParameterivEXT"))
			{
				dgtk.OpenGL.internalGL.glPixelTransformParameterivEXT = (dgtk.OpenGL.delegatesGL.glPixelTransformParameterivEXT) InternalTool.GetGLMethodAdress("glPixelTransformParameterivEXT", typeof(dgtk.OpenGL.delegatesGL.glPixelTransformParameterivEXT));
			}
			if (SuportedExt.Contains("glPixelZoomxOES"))
			{
				dgtk.OpenGL.internalGL.glPixelZoomxOES = (dgtk.OpenGL.delegatesGL.glPixelZoomxOES) InternalTool.GetGLMethodAdress("glPixelZoomxOES", typeof(dgtk.OpenGL.delegatesGL.glPixelZoomxOES));
			}
			if (SuportedExt.Contains("glPNTrianglesfATI"))
			{
				dgtk.OpenGL.internalGL.glPNTrianglesfATI = (dgtk.OpenGL.delegatesGL.glPNTrianglesfATI) InternalTool.GetGLMethodAdress("glPNTrianglesfATI", typeof(dgtk.OpenGL.delegatesGL.glPNTrianglesfATI));
			}
			if (SuportedExt.Contains("glPNTrianglesiATI"))
			{
				dgtk.OpenGL.internalGL.glPNTrianglesiATI = (dgtk.OpenGL.delegatesGL.glPNTrianglesiATI) InternalTool.GetGLMethodAdress("glPNTrianglesiATI", typeof(dgtk.OpenGL.delegatesGL.glPNTrianglesiATI));
			}
			if (SuportedExt.Contains("glPointAlongPathNV"))
			{
				dgtk.OpenGL.internalGL.glPointAlongPathNV = (dgtk.OpenGL.delegatesGL.glPointAlongPathNV) InternalTool.GetGLMethodAdress("glPointAlongPathNV", typeof(dgtk.OpenGL.delegatesGL.glPointAlongPathNV));
			}
			if (SuportedExt.Contains("glPointParameterfARB"))
			{
				dgtk.OpenGL.internalGL.glPointParameterfARB = (dgtk.OpenGL.delegatesGL.glPointParameterfARB) InternalTool.GetGLMethodAdress("glPointParameterfARB", typeof(dgtk.OpenGL.delegatesGL.glPointParameterfARB));
			}
			if (SuportedExt.Contains("glPointParameterfEXT"))
			{
				dgtk.OpenGL.internalGL.glPointParameterfEXT = (dgtk.OpenGL.delegatesGL.glPointParameterfEXT) InternalTool.GetGLMethodAdress("glPointParameterfEXT", typeof(dgtk.OpenGL.delegatesGL.glPointParameterfEXT));
			}
			if (SuportedExt.Contains("glPointParameterfSGIS"))
			{
				dgtk.OpenGL.internalGL.glPointParameterfSGIS = (dgtk.OpenGL.delegatesGL.glPointParameterfSGIS) InternalTool.GetGLMethodAdress("glPointParameterfSGIS", typeof(dgtk.OpenGL.delegatesGL.glPointParameterfSGIS));
			}
			if (SuportedExt.Contains("glPointParameterfvARB"))
			{
				dgtk.OpenGL.internalGL.glPointParameterfvARB = (dgtk.OpenGL.delegatesGL.glPointParameterfvARB) InternalTool.GetGLMethodAdress("glPointParameterfvARB", typeof(dgtk.OpenGL.delegatesGL.glPointParameterfvARB));
			}
			if (SuportedExt.Contains("glPointParameterfvEXT"))
			{
				dgtk.OpenGL.internalGL.glPointParameterfvEXT = (dgtk.OpenGL.delegatesGL.glPointParameterfvEXT) InternalTool.GetGLMethodAdress("glPointParameterfvEXT", typeof(dgtk.OpenGL.delegatesGL.glPointParameterfvEXT));
			}
			if (SuportedExt.Contains("glPointParameterfvSGIS"))
			{
				dgtk.OpenGL.internalGL.glPointParameterfvSGIS = (dgtk.OpenGL.delegatesGL.glPointParameterfvSGIS) InternalTool.GetGLMethodAdress("glPointParameterfvSGIS", typeof(dgtk.OpenGL.delegatesGL.glPointParameterfvSGIS));
			}
			if (SuportedExt.Contains("glPointParameteriNV"))
			{
				dgtk.OpenGL.internalGL.glPointParameteriNV = (dgtk.OpenGL.delegatesGL.glPointParameteriNV) InternalTool.GetGLMethodAdress("glPointParameteriNV", typeof(dgtk.OpenGL.delegatesGL.glPointParameteriNV));
			}
			if (SuportedExt.Contains("glPointParameterivNV"))
			{
				dgtk.OpenGL.internalGL.glPointParameterivNV = (dgtk.OpenGL.delegatesGL.glPointParameterivNV) InternalTool.GetGLMethodAdress("glPointParameterivNV", typeof(dgtk.OpenGL.delegatesGL.glPointParameterivNV));
			}
			if (SuportedExt.Contains("glPointParameterx"))
			{
				dgtk.OpenGL.internalGL.glPointParameterx = (dgtk.OpenGL.delegatesGL.glPointParameterx) InternalTool.GetGLMethodAdress("glPointParameterx", typeof(dgtk.OpenGL.delegatesGL.glPointParameterx));
			}
			if (SuportedExt.Contains("glPointParameterxOES"))
			{
				dgtk.OpenGL.internalGL.glPointParameterxOES = (dgtk.OpenGL.delegatesGL.glPointParameterxOES) InternalTool.GetGLMethodAdress("glPointParameterxOES", typeof(dgtk.OpenGL.delegatesGL.glPointParameterxOES));
			}
			if (SuportedExt.Contains("glPointParameterxv"))
			{
				dgtk.OpenGL.internalGL.glPointParameterxv = (dgtk.OpenGL.delegatesGL.glPointParameterxv) InternalTool.GetGLMethodAdress("glPointParameterxv", typeof(dgtk.OpenGL.delegatesGL.glPointParameterxv));
			}
			if (SuportedExt.Contains("glPointParameterxvOES"))
			{
				dgtk.OpenGL.internalGL.glPointParameterxvOES = (dgtk.OpenGL.delegatesGL.glPointParameterxvOES) InternalTool.GetGLMethodAdress("glPointParameterxvOES", typeof(dgtk.OpenGL.delegatesGL.glPointParameterxvOES));
			}
			if (SuportedExt.Contains("glPointSizePointerOES"))
			{
				dgtk.OpenGL.internalGL.glPointSizePointerOES = (dgtk.OpenGL.delegatesGL.glPointSizePointerOES) InternalTool.GetGLMethodAdress("glPointSizePointerOES", typeof(dgtk.OpenGL.delegatesGL.glPointSizePointerOES));
			}
			if (SuportedExt.Contains("glPointSizex"))
			{
				dgtk.OpenGL.internalGL.glPointSizex = (dgtk.OpenGL.delegatesGL.glPointSizex) InternalTool.GetGLMethodAdress("glPointSizex", typeof(dgtk.OpenGL.delegatesGL.glPointSizex));
			}
			if (SuportedExt.Contains("glPointSizexOES"))
			{
				dgtk.OpenGL.internalGL.glPointSizexOES = (dgtk.OpenGL.delegatesGL.glPointSizexOES) InternalTool.GetGLMethodAdress("glPointSizexOES", typeof(dgtk.OpenGL.delegatesGL.glPointSizexOES));
			}
			if (SuportedExt.Contains("glPollAsyncSGIX"))
			{
				dgtk.OpenGL.internalGL.glPollAsyncSGIX = (dgtk.OpenGL.delegatesGL.glPollAsyncSGIX) InternalTool.GetGLMethodAdress("glPollAsyncSGIX", typeof(dgtk.OpenGL.delegatesGL.glPollAsyncSGIX));
			}
			if (SuportedExt.Contains("glPollInstrumentsSGIX"))
			{
				dgtk.OpenGL.internalGL.glPollInstrumentsSGIX = (dgtk.OpenGL.delegatesGL.glPollInstrumentsSGIX) InternalTool.GetGLMethodAdress("glPollInstrumentsSGIX", typeof(dgtk.OpenGL.delegatesGL.glPollInstrumentsSGIX));
			}
			if (SuportedExt.Contains("glPolygonModeNV"))
			{
				dgtk.OpenGL.internalGL.glPolygonModeNV = (dgtk.OpenGL.delegatesGL.glPolygonModeNV) InternalTool.GetGLMethodAdress("glPolygonModeNV", typeof(dgtk.OpenGL.delegatesGL.glPolygonModeNV));
			}
			if (SuportedExt.Contains("glPolygonOffsetClampEXT"))
			{
				dgtk.OpenGL.internalGL.glPolygonOffsetClampEXT = (dgtk.OpenGL.delegatesGL.glPolygonOffsetClampEXT) InternalTool.GetGLMethodAdress("glPolygonOffsetClampEXT", typeof(dgtk.OpenGL.delegatesGL.glPolygonOffsetClampEXT));
			}
			if (SuportedExt.Contains("glPolygonOffsetEXT"))
			{
				dgtk.OpenGL.internalGL.glPolygonOffsetEXT = (dgtk.OpenGL.delegatesGL.glPolygonOffsetEXT) InternalTool.GetGLMethodAdress("glPolygonOffsetEXT", typeof(dgtk.OpenGL.delegatesGL.glPolygonOffsetEXT));
			}
			if (SuportedExt.Contains("glPolygonOffsetx"))
			{
				dgtk.OpenGL.internalGL.glPolygonOffsetx = (dgtk.OpenGL.delegatesGL.glPolygonOffsetx) InternalTool.GetGLMethodAdress("glPolygonOffsetx", typeof(dgtk.OpenGL.delegatesGL.glPolygonOffsetx));
			}
			if (SuportedExt.Contains("glPolygonOffsetxOES"))
			{
				dgtk.OpenGL.internalGL.glPolygonOffsetxOES = (dgtk.OpenGL.delegatesGL.glPolygonOffsetxOES) InternalTool.GetGLMethodAdress("glPolygonOffsetxOES", typeof(dgtk.OpenGL.delegatesGL.glPolygonOffsetxOES));
			}
			if (SuportedExt.Contains("glPopDebugGroupKHR"))
			{
				dgtk.OpenGL.internalGL.glPopDebugGroupKHR = (dgtk.OpenGL.delegatesGL.glPopDebugGroupKHR) InternalTool.GetGLMethodAdress("glPopDebugGroupKHR", typeof(dgtk.OpenGL.delegatesGL.glPopDebugGroupKHR));
			}
			if (SuportedExt.Contains("glPopGroupMarkerEXT"))
			{
				dgtk.OpenGL.internalGL.glPopGroupMarkerEXT = (dgtk.OpenGL.delegatesGL.glPopGroupMarkerEXT) InternalTool.GetGLMethodAdress("glPopGroupMarkerEXT", typeof(dgtk.OpenGL.delegatesGL.glPopGroupMarkerEXT));
			}
			if (SuportedExt.Contains("glPresentFrameDualFillNV"))
			{
				dgtk.OpenGL.internalGL.glPresentFrameDualFillNV = (dgtk.OpenGL.delegatesGL.glPresentFrameDualFillNV) InternalTool.GetGLMethodAdress("glPresentFrameDualFillNV", typeof(dgtk.OpenGL.delegatesGL.glPresentFrameDualFillNV));
			}
			if (SuportedExt.Contains("glPresentFrameKeyedNV"))
			{
				dgtk.OpenGL.internalGL.glPresentFrameKeyedNV = (dgtk.OpenGL.delegatesGL.glPresentFrameKeyedNV) InternalTool.GetGLMethodAdress("glPresentFrameKeyedNV", typeof(dgtk.OpenGL.delegatesGL.glPresentFrameKeyedNV));
			}
			if (SuportedExt.Contains("glPrimitiveBoundingBox"))
			{
				dgtk.OpenGL.internalGL.glPrimitiveBoundingBox = (dgtk.OpenGL.delegatesGL.glPrimitiveBoundingBox) InternalTool.GetGLMethodAdress("glPrimitiveBoundingBox", typeof(dgtk.OpenGL.delegatesGL.glPrimitiveBoundingBox));
			}
			if (SuportedExt.Contains("glPrimitiveBoundingBoxARB"))
			{
				dgtk.OpenGL.internalGL.glPrimitiveBoundingBoxARB = (dgtk.OpenGL.delegatesGL.glPrimitiveBoundingBoxARB) InternalTool.GetGLMethodAdress("glPrimitiveBoundingBoxARB", typeof(dgtk.OpenGL.delegatesGL.glPrimitiveBoundingBoxARB));
			}
			if (SuportedExt.Contains("glPrimitiveBoundingBoxEXT"))
			{
				dgtk.OpenGL.internalGL.glPrimitiveBoundingBoxEXT = (dgtk.OpenGL.delegatesGL.glPrimitiveBoundingBoxEXT) InternalTool.GetGLMethodAdress("glPrimitiveBoundingBoxEXT", typeof(dgtk.OpenGL.delegatesGL.glPrimitiveBoundingBoxEXT));
			}
			if (SuportedExt.Contains("glPrimitiveBoundingBoxOES"))
			{
				dgtk.OpenGL.internalGL.glPrimitiveBoundingBoxOES = (dgtk.OpenGL.delegatesGL.glPrimitiveBoundingBoxOES) InternalTool.GetGLMethodAdress("glPrimitiveBoundingBoxOES", typeof(dgtk.OpenGL.delegatesGL.glPrimitiveBoundingBoxOES));
			}
			if (SuportedExt.Contains("glPrimitiveRestartIndexNV"))
			{
				dgtk.OpenGL.internalGL.glPrimitiveRestartIndexNV = (dgtk.OpenGL.delegatesGL.glPrimitiveRestartIndexNV) InternalTool.GetGLMethodAdress("glPrimitiveRestartIndexNV", typeof(dgtk.OpenGL.delegatesGL.glPrimitiveRestartIndexNV));
			}
			if (SuportedExt.Contains("glPrimitiveRestartNV"))
			{
				dgtk.OpenGL.internalGL.glPrimitiveRestartNV = (dgtk.OpenGL.delegatesGL.glPrimitiveRestartNV) InternalTool.GetGLMethodAdress("glPrimitiveRestartNV", typeof(dgtk.OpenGL.delegatesGL.glPrimitiveRestartNV));
			}
			if (SuportedExt.Contains("glPrioritizeTexturesEXT"))
			{
				dgtk.OpenGL.internalGL.glPrioritizeTexturesEXT = (dgtk.OpenGL.delegatesGL.glPrioritizeTexturesEXT) InternalTool.GetGLMethodAdress("glPrioritizeTexturesEXT", typeof(dgtk.OpenGL.delegatesGL.glPrioritizeTexturesEXT));
			}
			if (SuportedExt.Contains("glPrioritizeTexturesxOES"))
			{
				dgtk.OpenGL.internalGL.glPrioritizeTexturesxOES = (dgtk.OpenGL.delegatesGL.glPrioritizeTexturesxOES) InternalTool.GetGLMethodAdress("glPrioritizeTexturesxOES", typeof(dgtk.OpenGL.delegatesGL.glPrioritizeTexturesxOES));
			}
			if (SuportedExt.Contains("glProgramBinaryOES"))
			{
				dgtk.OpenGL.internalGL.glProgramBinaryOES = (dgtk.OpenGL.delegatesGL.glProgramBinaryOES) InternalTool.GetGLMethodAdress("glProgramBinaryOES", typeof(dgtk.OpenGL.delegatesGL.glProgramBinaryOES));
			}
			if (SuportedExt.Contains("glProgramBufferParametersfvNV"))
			{
				dgtk.OpenGL.internalGL.glProgramBufferParametersfvNV = (dgtk.OpenGL.delegatesGL.glProgramBufferParametersfvNV) InternalTool.GetGLMethodAdress("glProgramBufferParametersfvNV", typeof(dgtk.OpenGL.delegatesGL.glProgramBufferParametersfvNV));
			}
			if (SuportedExt.Contains("glProgramBufferParametersIivNV"))
			{
				dgtk.OpenGL.internalGL.glProgramBufferParametersIivNV = (dgtk.OpenGL.delegatesGL.glProgramBufferParametersIivNV) InternalTool.GetGLMethodAdress("glProgramBufferParametersIivNV", typeof(dgtk.OpenGL.delegatesGL.glProgramBufferParametersIivNV));
			}
			if (SuportedExt.Contains("glProgramBufferParametersIuivNV"))
			{
				dgtk.OpenGL.internalGL.glProgramBufferParametersIuivNV = (dgtk.OpenGL.delegatesGL.glProgramBufferParametersIuivNV) InternalTool.GetGLMethodAdress("glProgramBufferParametersIuivNV", typeof(dgtk.OpenGL.delegatesGL.glProgramBufferParametersIuivNV));
			}
			if (SuportedExt.Contains("glProgramEnvParameter4dARB"))
			{
				dgtk.OpenGL.internalGL.glProgramEnvParameter4dARB = (dgtk.OpenGL.delegatesGL.glProgramEnvParameter4dARB) InternalTool.GetGLMethodAdress("glProgramEnvParameter4dARB", typeof(dgtk.OpenGL.delegatesGL.glProgramEnvParameter4dARB));
			}
			if (SuportedExt.Contains("glProgramEnvParameter4dvARB"))
			{
				dgtk.OpenGL.internalGL.glProgramEnvParameter4dvARB = (dgtk.OpenGL.delegatesGL.glProgramEnvParameter4dvARB) InternalTool.GetGLMethodAdress("glProgramEnvParameter4dvARB", typeof(dgtk.OpenGL.delegatesGL.glProgramEnvParameter4dvARB));
			}
			if (SuportedExt.Contains("glProgramEnvParameter4fARB"))
			{
				dgtk.OpenGL.internalGL.glProgramEnvParameter4fARB = (dgtk.OpenGL.delegatesGL.glProgramEnvParameter4fARB) InternalTool.GetGLMethodAdress("glProgramEnvParameter4fARB", typeof(dgtk.OpenGL.delegatesGL.glProgramEnvParameter4fARB));
			}
			if (SuportedExt.Contains("glProgramEnvParameter4fvARB"))
			{
				dgtk.OpenGL.internalGL.glProgramEnvParameter4fvARB = (dgtk.OpenGL.delegatesGL.glProgramEnvParameter4fvARB) InternalTool.GetGLMethodAdress("glProgramEnvParameter4fvARB", typeof(dgtk.OpenGL.delegatesGL.glProgramEnvParameter4fvARB));
			}
			if (SuportedExt.Contains("glProgramEnvParameterI4iNV"))
			{
				dgtk.OpenGL.internalGL.glProgramEnvParameterI4iNV = (dgtk.OpenGL.delegatesGL.glProgramEnvParameterI4iNV) InternalTool.GetGLMethodAdress("glProgramEnvParameterI4iNV", typeof(dgtk.OpenGL.delegatesGL.glProgramEnvParameterI4iNV));
			}
			if (SuportedExt.Contains("glProgramEnvParameterI4ivNV"))
			{
				dgtk.OpenGL.internalGL.glProgramEnvParameterI4ivNV = (dgtk.OpenGL.delegatesGL.glProgramEnvParameterI4ivNV) InternalTool.GetGLMethodAdress("glProgramEnvParameterI4ivNV", typeof(dgtk.OpenGL.delegatesGL.glProgramEnvParameterI4ivNV));
			}
			if (SuportedExt.Contains("glProgramEnvParameterI4uiNV"))
			{
				dgtk.OpenGL.internalGL.glProgramEnvParameterI4uiNV = (dgtk.OpenGL.delegatesGL.glProgramEnvParameterI4uiNV) InternalTool.GetGLMethodAdress("glProgramEnvParameterI4uiNV", typeof(dgtk.OpenGL.delegatesGL.glProgramEnvParameterI4uiNV));
			}
			if (SuportedExt.Contains("glProgramEnvParameterI4uivNV"))
			{
				dgtk.OpenGL.internalGL.glProgramEnvParameterI4uivNV = (dgtk.OpenGL.delegatesGL.glProgramEnvParameterI4uivNV) InternalTool.GetGLMethodAdress("glProgramEnvParameterI4uivNV", typeof(dgtk.OpenGL.delegatesGL.glProgramEnvParameterI4uivNV));
			}
			if (SuportedExt.Contains("glProgramEnvParameters4fvEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramEnvParameters4fvEXT = (dgtk.OpenGL.delegatesGL.glProgramEnvParameters4fvEXT) InternalTool.GetGLMethodAdress("glProgramEnvParameters4fvEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramEnvParameters4fvEXT));
			}
			if (SuportedExt.Contains("glProgramEnvParametersI4ivNV"))
			{
				dgtk.OpenGL.internalGL.glProgramEnvParametersI4ivNV = (dgtk.OpenGL.delegatesGL.glProgramEnvParametersI4ivNV) InternalTool.GetGLMethodAdress("glProgramEnvParametersI4ivNV", typeof(dgtk.OpenGL.delegatesGL.glProgramEnvParametersI4ivNV));
			}
			if (SuportedExt.Contains("glProgramEnvParametersI4uivNV"))
			{
				dgtk.OpenGL.internalGL.glProgramEnvParametersI4uivNV = (dgtk.OpenGL.delegatesGL.glProgramEnvParametersI4uivNV) InternalTool.GetGLMethodAdress("glProgramEnvParametersI4uivNV", typeof(dgtk.OpenGL.delegatesGL.glProgramEnvParametersI4uivNV));
			}
			if (SuportedExt.Contains("glProgramLocalParameter4dARB"))
			{
				dgtk.OpenGL.internalGL.glProgramLocalParameter4dARB = (dgtk.OpenGL.delegatesGL.glProgramLocalParameter4dARB) InternalTool.GetGLMethodAdress("glProgramLocalParameter4dARB", typeof(dgtk.OpenGL.delegatesGL.glProgramLocalParameter4dARB));
			}
			if (SuportedExt.Contains("glProgramLocalParameter4dvARB"))
			{
				dgtk.OpenGL.internalGL.glProgramLocalParameter4dvARB = (dgtk.OpenGL.delegatesGL.glProgramLocalParameter4dvARB) InternalTool.GetGLMethodAdress("glProgramLocalParameter4dvARB", typeof(dgtk.OpenGL.delegatesGL.glProgramLocalParameter4dvARB));
			}
			if (SuportedExt.Contains("glProgramLocalParameter4fARB"))
			{
				dgtk.OpenGL.internalGL.glProgramLocalParameter4fARB = (dgtk.OpenGL.delegatesGL.glProgramLocalParameter4fARB) InternalTool.GetGLMethodAdress("glProgramLocalParameter4fARB", typeof(dgtk.OpenGL.delegatesGL.glProgramLocalParameter4fARB));
			}
			if (SuportedExt.Contains("glProgramLocalParameter4fvARB"))
			{
				dgtk.OpenGL.internalGL.glProgramLocalParameter4fvARB = (dgtk.OpenGL.delegatesGL.glProgramLocalParameter4fvARB) InternalTool.GetGLMethodAdress("glProgramLocalParameter4fvARB", typeof(dgtk.OpenGL.delegatesGL.glProgramLocalParameter4fvARB));
			}
			if (SuportedExt.Contains("glProgramLocalParameterI4iNV"))
			{
				dgtk.OpenGL.internalGL.glProgramLocalParameterI4iNV = (dgtk.OpenGL.delegatesGL.glProgramLocalParameterI4iNV) InternalTool.GetGLMethodAdress("glProgramLocalParameterI4iNV", typeof(dgtk.OpenGL.delegatesGL.glProgramLocalParameterI4iNV));
			}
			if (SuportedExt.Contains("glProgramLocalParameterI4ivNV"))
			{
				dgtk.OpenGL.internalGL.glProgramLocalParameterI4ivNV = (dgtk.OpenGL.delegatesGL.glProgramLocalParameterI4ivNV) InternalTool.GetGLMethodAdress("glProgramLocalParameterI4ivNV", typeof(dgtk.OpenGL.delegatesGL.glProgramLocalParameterI4ivNV));
			}
			if (SuportedExt.Contains("glProgramLocalParameterI4uiNV"))
			{
				dgtk.OpenGL.internalGL.glProgramLocalParameterI4uiNV = (dgtk.OpenGL.delegatesGL.glProgramLocalParameterI4uiNV) InternalTool.GetGLMethodAdress("glProgramLocalParameterI4uiNV", typeof(dgtk.OpenGL.delegatesGL.glProgramLocalParameterI4uiNV));
			}
			if (SuportedExt.Contains("glProgramLocalParameterI4uivNV"))
			{
				dgtk.OpenGL.internalGL.glProgramLocalParameterI4uivNV = (dgtk.OpenGL.delegatesGL.glProgramLocalParameterI4uivNV) InternalTool.GetGLMethodAdress("glProgramLocalParameterI4uivNV", typeof(dgtk.OpenGL.delegatesGL.glProgramLocalParameterI4uivNV));
			}
			if (SuportedExt.Contains("glProgramLocalParameters4fvEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramLocalParameters4fvEXT = (dgtk.OpenGL.delegatesGL.glProgramLocalParameters4fvEXT) InternalTool.GetGLMethodAdress("glProgramLocalParameters4fvEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramLocalParameters4fvEXT));
			}
			if (SuportedExt.Contains("glProgramLocalParametersI4ivNV"))
			{
				dgtk.OpenGL.internalGL.glProgramLocalParametersI4ivNV = (dgtk.OpenGL.delegatesGL.glProgramLocalParametersI4ivNV) InternalTool.GetGLMethodAdress("glProgramLocalParametersI4ivNV", typeof(dgtk.OpenGL.delegatesGL.glProgramLocalParametersI4ivNV));
			}
			if (SuportedExt.Contains("glProgramLocalParametersI4uivNV"))
			{
				dgtk.OpenGL.internalGL.glProgramLocalParametersI4uivNV = (dgtk.OpenGL.delegatesGL.glProgramLocalParametersI4uivNV) InternalTool.GetGLMethodAdress("glProgramLocalParametersI4uivNV", typeof(dgtk.OpenGL.delegatesGL.glProgramLocalParametersI4uivNV));
			}
			if (SuportedExt.Contains("glProgramNamedParameter4dNV"))
			{
				dgtk.OpenGL.internalGL.glProgramNamedParameter4dNV = (dgtk.OpenGL.delegatesGL.glProgramNamedParameter4dNV) InternalTool.GetGLMethodAdress("glProgramNamedParameter4dNV", typeof(dgtk.OpenGL.delegatesGL.glProgramNamedParameter4dNV));
			}
			if (SuportedExt.Contains("glProgramNamedParameter4dvNV"))
			{
				dgtk.OpenGL.internalGL.glProgramNamedParameter4dvNV = (dgtk.OpenGL.delegatesGL.glProgramNamedParameter4dvNV) InternalTool.GetGLMethodAdress("glProgramNamedParameter4dvNV", typeof(dgtk.OpenGL.delegatesGL.glProgramNamedParameter4dvNV));
			}
			if (SuportedExt.Contains("glProgramNamedParameter4fNV"))
			{
				dgtk.OpenGL.internalGL.glProgramNamedParameter4fNV = (dgtk.OpenGL.delegatesGL.glProgramNamedParameter4fNV) InternalTool.GetGLMethodAdress("glProgramNamedParameter4fNV", typeof(dgtk.OpenGL.delegatesGL.glProgramNamedParameter4fNV));
			}
			if (SuportedExt.Contains("glProgramNamedParameter4fvNV"))
			{
				dgtk.OpenGL.internalGL.glProgramNamedParameter4fvNV = (dgtk.OpenGL.delegatesGL.glProgramNamedParameter4fvNV) InternalTool.GetGLMethodAdress("glProgramNamedParameter4fvNV", typeof(dgtk.OpenGL.delegatesGL.glProgramNamedParameter4fvNV));
			}
			if (SuportedExt.Contains("glProgramParameter4dNV"))
			{
				dgtk.OpenGL.internalGL.glProgramParameter4dNV = (dgtk.OpenGL.delegatesGL.glProgramParameter4dNV) InternalTool.GetGLMethodAdress("glProgramParameter4dNV", typeof(dgtk.OpenGL.delegatesGL.glProgramParameter4dNV));
			}
			if (SuportedExt.Contains("glProgramParameter4dvNV"))
			{
				dgtk.OpenGL.internalGL.glProgramParameter4dvNV = (dgtk.OpenGL.delegatesGL.glProgramParameter4dvNV) InternalTool.GetGLMethodAdress("glProgramParameter4dvNV", typeof(dgtk.OpenGL.delegatesGL.glProgramParameter4dvNV));
			}
			if (SuportedExt.Contains("glProgramParameter4fNV"))
			{
				dgtk.OpenGL.internalGL.glProgramParameter4fNV = (dgtk.OpenGL.delegatesGL.glProgramParameter4fNV) InternalTool.GetGLMethodAdress("glProgramParameter4fNV", typeof(dgtk.OpenGL.delegatesGL.glProgramParameter4fNV));
			}
			if (SuportedExt.Contains("glProgramParameter4fvNV"))
			{
				dgtk.OpenGL.internalGL.glProgramParameter4fvNV = (dgtk.OpenGL.delegatesGL.glProgramParameter4fvNV) InternalTool.GetGLMethodAdress("glProgramParameter4fvNV", typeof(dgtk.OpenGL.delegatesGL.glProgramParameter4fvNV));
			}
			if (SuportedExt.Contains("glProgramParameteriARB"))
			{
				dgtk.OpenGL.internalGL.glProgramParameteriARB = (dgtk.OpenGL.delegatesGL.glProgramParameteriARB) InternalTool.GetGLMethodAdress("glProgramParameteriARB", typeof(dgtk.OpenGL.delegatesGL.glProgramParameteriARB));
			}
			if (SuportedExt.Contains("glProgramParameteriEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramParameteriEXT = (dgtk.OpenGL.delegatesGL.glProgramParameteriEXT) InternalTool.GetGLMethodAdress("glProgramParameteriEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramParameteriEXT));
			}
			if (SuportedExt.Contains("glProgramParameters4dvNV"))
			{
				dgtk.OpenGL.internalGL.glProgramParameters4dvNV = (dgtk.OpenGL.delegatesGL.glProgramParameters4dvNV) InternalTool.GetGLMethodAdress("glProgramParameters4dvNV", typeof(dgtk.OpenGL.delegatesGL.glProgramParameters4dvNV));
			}
			if (SuportedExt.Contains("glProgramParameters4fvNV"))
			{
				dgtk.OpenGL.internalGL.glProgramParameters4fvNV = (dgtk.OpenGL.delegatesGL.glProgramParameters4fvNV) InternalTool.GetGLMethodAdress("glProgramParameters4fvNV", typeof(dgtk.OpenGL.delegatesGL.glProgramParameters4fvNV));
			}
			if (SuportedExt.Contains("glProgramPathFragmentInputGenNV"))
			{
				dgtk.OpenGL.internalGL.glProgramPathFragmentInputGenNV = (dgtk.OpenGL.delegatesGL.glProgramPathFragmentInputGenNV) InternalTool.GetGLMethodAdress("glProgramPathFragmentInputGenNV", typeof(dgtk.OpenGL.delegatesGL.glProgramPathFragmentInputGenNV));
			}
			if (SuportedExt.Contains("glProgramStringARB"))
			{
				dgtk.OpenGL.internalGL.glProgramStringARB = (dgtk.OpenGL.delegatesGL.glProgramStringARB) InternalTool.GetGLMethodAdress("glProgramStringARB", typeof(dgtk.OpenGL.delegatesGL.glProgramStringARB));
			}
			if (SuportedExt.Contains("glProgramSubroutineParametersuivNV"))
			{
				dgtk.OpenGL.internalGL.glProgramSubroutineParametersuivNV = (dgtk.OpenGL.delegatesGL.glProgramSubroutineParametersuivNV) InternalTool.GetGLMethodAdress("glProgramSubroutineParametersuivNV", typeof(dgtk.OpenGL.delegatesGL.glProgramSubroutineParametersuivNV));
			}
			if (SuportedExt.Contains("glProgramUniform1dEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform1dEXT = (dgtk.OpenGL.delegatesGL.glProgramUniform1dEXT) InternalTool.GetGLMethodAdress("glProgramUniform1dEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform1dEXT));
			}
			if (SuportedExt.Contains("glProgramUniform1dvEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform1dvEXT = (dgtk.OpenGL.delegatesGL.glProgramUniform1dvEXT) InternalTool.GetGLMethodAdress("glProgramUniform1dvEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform1dvEXT));
			}
			if (SuportedExt.Contains("glProgramUniform1fEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform1fEXT = (dgtk.OpenGL.delegatesGL.glProgramUniform1fEXT) InternalTool.GetGLMethodAdress("glProgramUniform1fEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform1fEXT));
			}
			if (SuportedExt.Contains("glProgramUniform1fvEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform1fvEXT = (dgtk.OpenGL.delegatesGL.glProgramUniform1fvEXT) InternalTool.GetGLMethodAdress("glProgramUniform1fvEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform1fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniform1i64ARB"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform1i64ARB = (dgtk.OpenGL.delegatesGL.glProgramUniform1i64ARB) InternalTool.GetGLMethodAdress("glProgramUniform1i64ARB", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform1i64ARB));
			}
			if (SuportedExt.Contains("glProgramUniform1i64NV"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform1i64NV = (dgtk.OpenGL.delegatesGL.glProgramUniform1i64NV) InternalTool.GetGLMethodAdress("glProgramUniform1i64NV", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform1i64NV));
			}
			if (SuportedExt.Contains("glProgramUniform1i64vARB"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform1i64vARB = (dgtk.OpenGL.delegatesGL.glProgramUniform1i64vARB) InternalTool.GetGLMethodAdress("glProgramUniform1i64vARB", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform1i64vARB));
			}
			if (SuportedExt.Contains("glProgramUniform1i64vNV"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform1i64vNV = (dgtk.OpenGL.delegatesGL.glProgramUniform1i64vNV) InternalTool.GetGLMethodAdress("glProgramUniform1i64vNV", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform1i64vNV));
			}
			if (SuportedExt.Contains("glProgramUniform1iEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform1iEXT = (dgtk.OpenGL.delegatesGL.glProgramUniform1iEXT) InternalTool.GetGLMethodAdress("glProgramUniform1iEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform1iEXT));
			}
			if (SuportedExt.Contains("glProgramUniform1ivEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform1ivEXT = (dgtk.OpenGL.delegatesGL.glProgramUniform1ivEXT) InternalTool.GetGLMethodAdress("glProgramUniform1ivEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform1ivEXT));
			}
			if (SuportedExt.Contains("glProgramUniform1ui64ARB"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform1ui64ARB = (dgtk.OpenGL.delegatesGL.glProgramUniform1ui64ARB) InternalTool.GetGLMethodAdress("glProgramUniform1ui64ARB", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform1ui64ARB));
			}
			if (SuportedExt.Contains("glProgramUniform1ui64NV"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform1ui64NV = (dgtk.OpenGL.delegatesGL.glProgramUniform1ui64NV) InternalTool.GetGLMethodAdress("glProgramUniform1ui64NV", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform1ui64NV));
			}
			if (SuportedExt.Contains("glProgramUniform1ui64vARB"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform1ui64vARB = (dgtk.OpenGL.delegatesGL.glProgramUniform1ui64vARB) InternalTool.GetGLMethodAdress("glProgramUniform1ui64vARB", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform1ui64vARB));
			}
			if (SuportedExt.Contains("glProgramUniform1ui64vNV"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform1ui64vNV = (dgtk.OpenGL.delegatesGL.glProgramUniform1ui64vNV) InternalTool.GetGLMethodAdress("glProgramUniform1ui64vNV", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform1ui64vNV));
			}
			if (SuportedExt.Contains("glProgramUniform1uiEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform1uiEXT = (dgtk.OpenGL.delegatesGL.glProgramUniform1uiEXT) InternalTool.GetGLMethodAdress("glProgramUniform1uiEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform1uiEXT));
			}
			if (SuportedExt.Contains("glProgramUniform1uivEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform1uivEXT = (dgtk.OpenGL.delegatesGL.glProgramUniform1uivEXT) InternalTool.GetGLMethodAdress("glProgramUniform1uivEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform1uivEXT));
			}
			if (SuportedExt.Contains("glProgramUniform2dEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform2dEXT = (dgtk.OpenGL.delegatesGL.glProgramUniform2dEXT) InternalTool.GetGLMethodAdress("glProgramUniform2dEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform2dEXT));
			}
			if (SuportedExt.Contains("glProgramUniform2dvEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform2dvEXT = (dgtk.OpenGL.delegatesGL.glProgramUniform2dvEXT) InternalTool.GetGLMethodAdress("glProgramUniform2dvEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform2dvEXT));
			}
			if (SuportedExt.Contains("glProgramUniform2fEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform2fEXT = (dgtk.OpenGL.delegatesGL.glProgramUniform2fEXT) InternalTool.GetGLMethodAdress("glProgramUniform2fEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform2fEXT));
			}
			if (SuportedExt.Contains("glProgramUniform2fvEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform2fvEXT = (dgtk.OpenGL.delegatesGL.glProgramUniform2fvEXT) InternalTool.GetGLMethodAdress("glProgramUniform2fvEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform2fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniform2i64ARB"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform2i64ARB = (dgtk.OpenGL.delegatesGL.glProgramUniform2i64ARB) InternalTool.GetGLMethodAdress("glProgramUniform2i64ARB", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform2i64ARB));
			}
			if (SuportedExt.Contains("glProgramUniform2i64NV"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform2i64NV = (dgtk.OpenGL.delegatesGL.glProgramUniform2i64NV) InternalTool.GetGLMethodAdress("glProgramUniform2i64NV", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform2i64NV));
			}
			if (SuportedExt.Contains("glProgramUniform2i64vARB"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform2i64vARB = (dgtk.OpenGL.delegatesGL.glProgramUniform2i64vARB) InternalTool.GetGLMethodAdress("glProgramUniform2i64vARB", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform2i64vARB));
			}
			if (SuportedExt.Contains("glProgramUniform2i64vNV"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform2i64vNV = (dgtk.OpenGL.delegatesGL.glProgramUniform2i64vNV) InternalTool.GetGLMethodAdress("glProgramUniform2i64vNV", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform2i64vNV));
			}
			if (SuportedExt.Contains("glProgramUniform2iEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform2iEXT = (dgtk.OpenGL.delegatesGL.glProgramUniform2iEXT) InternalTool.GetGLMethodAdress("glProgramUniform2iEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform2iEXT));
			}
			if (SuportedExt.Contains("glProgramUniform2ivEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform2ivEXT = (dgtk.OpenGL.delegatesGL.glProgramUniform2ivEXT) InternalTool.GetGLMethodAdress("glProgramUniform2ivEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform2ivEXT));
			}
			if (SuportedExt.Contains("glProgramUniform2ui64ARB"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform2ui64ARB = (dgtk.OpenGL.delegatesGL.glProgramUniform2ui64ARB) InternalTool.GetGLMethodAdress("glProgramUniform2ui64ARB", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform2ui64ARB));
			}
			if (SuportedExt.Contains("glProgramUniform2ui64NV"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform2ui64NV = (dgtk.OpenGL.delegatesGL.glProgramUniform2ui64NV) InternalTool.GetGLMethodAdress("glProgramUniform2ui64NV", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform2ui64NV));
			}
			if (SuportedExt.Contains("glProgramUniform2ui64vARB"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform2ui64vARB = (dgtk.OpenGL.delegatesGL.glProgramUniform2ui64vARB) InternalTool.GetGLMethodAdress("glProgramUniform2ui64vARB", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform2ui64vARB));
			}
			if (SuportedExt.Contains("glProgramUniform2ui64vNV"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform2ui64vNV = (dgtk.OpenGL.delegatesGL.glProgramUniform2ui64vNV) InternalTool.GetGLMethodAdress("glProgramUniform2ui64vNV", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform2ui64vNV));
			}
			if (SuportedExt.Contains("glProgramUniform2uiEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform2uiEXT = (dgtk.OpenGL.delegatesGL.glProgramUniform2uiEXT) InternalTool.GetGLMethodAdress("glProgramUniform2uiEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform2uiEXT));
			}
			if (SuportedExt.Contains("glProgramUniform2uivEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform2uivEXT = (dgtk.OpenGL.delegatesGL.glProgramUniform2uivEXT) InternalTool.GetGLMethodAdress("glProgramUniform2uivEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform2uivEXT));
			}
			if (SuportedExt.Contains("glProgramUniform3dEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform3dEXT = (dgtk.OpenGL.delegatesGL.glProgramUniform3dEXT) InternalTool.GetGLMethodAdress("glProgramUniform3dEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform3dEXT));
			}
			if (SuportedExt.Contains("glProgramUniform3dvEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform3dvEXT = (dgtk.OpenGL.delegatesGL.glProgramUniform3dvEXT) InternalTool.GetGLMethodAdress("glProgramUniform3dvEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform3dvEXT));
			}
			if (SuportedExt.Contains("glProgramUniform3fEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform3fEXT = (dgtk.OpenGL.delegatesGL.glProgramUniform3fEXT) InternalTool.GetGLMethodAdress("glProgramUniform3fEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform3fEXT));
			}
			if (SuportedExt.Contains("glProgramUniform3fvEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform3fvEXT = (dgtk.OpenGL.delegatesGL.glProgramUniform3fvEXT) InternalTool.GetGLMethodAdress("glProgramUniform3fvEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform3fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniform3i64ARB"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform3i64ARB = (dgtk.OpenGL.delegatesGL.glProgramUniform3i64ARB) InternalTool.GetGLMethodAdress("glProgramUniform3i64ARB", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform3i64ARB));
			}
			if (SuportedExt.Contains("glProgramUniform3i64NV"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform3i64NV = (dgtk.OpenGL.delegatesGL.glProgramUniform3i64NV) InternalTool.GetGLMethodAdress("glProgramUniform3i64NV", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform3i64NV));
			}
			if (SuportedExt.Contains("glProgramUniform3i64vARB"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform3i64vARB = (dgtk.OpenGL.delegatesGL.glProgramUniform3i64vARB) InternalTool.GetGLMethodAdress("glProgramUniform3i64vARB", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform3i64vARB));
			}
			if (SuportedExt.Contains("glProgramUniform3i64vNV"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform3i64vNV = (dgtk.OpenGL.delegatesGL.glProgramUniform3i64vNV) InternalTool.GetGLMethodAdress("glProgramUniform3i64vNV", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform3i64vNV));
			}
			if (SuportedExt.Contains("glProgramUniform3iEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform3iEXT = (dgtk.OpenGL.delegatesGL.glProgramUniform3iEXT) InternalTool.GetGLMethodAdress("glProgramUniform3iEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform3iEXT));
			}
			if (SuportedExt.Contains("glProgramUniform3ivEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform3ivEXT = (dgtk.OpenGL.delegatesGL.glProgramUniform3ivEXT) InternalTool.GetGLMethodAdress("glProgramUniform3ivEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform3ivEXT));
			}
			if (SuportedExt.Contains("glProgramUniform3ui64ARB"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform3ui64ARB = (dgtk.OpenGL.delegatesGL.glProgramUniform3ui64ARB) InternalTool.GetGLMethodAdress("glProgramUniform3ui64ARB", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform3ui64ARB));
			}
			if (SuportedExt.Contains("glProgramUniform3ui64NV"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform3ui64NV = (dgtk.OpenGL.delegatesGL.glProgramUniform3ui64NV) InternalTool.GetGLMethodAdress("glProgramUniform3ui64NV", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform3ui64NV));
			}
			if (SuportedExt.Contains("glProgramUniform3ui64vARB"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform3ui64vARB = (dgtk.OpenGL.delegatesGL.glProgramUniform3ui64vARB) InternalTool.GetGLMethodAdress("glProgramUniform3ui64vARB", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform3ui64vARB));
			}
			if (SuportedExt.Contains("glProgramUniform3ui64vNV"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform3ui64vNV = (dgtk.OpenGL.delegatesGL.glProgramUniform3ui64vNV) InternalTool.GetGLMethodAdress("glProgramUniform3ui64vNV", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform3ui64vNV));
			}
			if (SuportedExt.Contains("glProgramUniform3uiEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform3uiEXT = (dgtk.OpenGL.delegatesGL.glProgramUniform3uiEXT) InternalTool.GetGLMethodAdress("glProgramUniform3uiEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform3uiEXT));
			}
			if (SuportedExt.Contains("glProgramUniform3uivEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform3uivEXT = (dgtk.OpenGL.delegatesGL.glProgramUniform3uivEXT) InternalTool.GetGLMethodAdress("glProgramUniform3uivEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform3uivEXT));
			}
			if (SuportedExt.Contains("glProgramUniform4dEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform4dEXT = (dgtk.OpenGL.delegatesGL.glProgramUniform4dEXT) InternalTool.GetGLMethodAdress("glProgramUniform4dEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform4dEXT));
			}
			if (SuportedExt.Contains("glProgramUniform4dvEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform4dvEXT = (dgtk.OpenGL.delegatesGL.glProgramUniform4dvEXT) InternalTool.GetGLMethodAdress("glProgramUniform4dvEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform4dvEXT));
			}
			if (SuportedExt.Contains("glProgramUniform4fEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform4fEXT = (dgtk.OpenGL.delegatesGL.glProgramUniform4fEXT) InternalTool.GetGLMethodAdress("glProgramUniform4fEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform4fEXT));
			}
			if (SuportedExt.Contains("glProgramUniform4fvEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform4fvEXT = (dgtk.OpenGL.delegatesGL.glProgramUniform4fvEXT) InternalTool.GetGLMethodAdress("glProgramUniform4fvEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform4fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniform4i64ARB"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform4i64ARB = (dgtk.OpenGL.delegatesGL.glProgramUniform4i64ARB) InternalTool.GetGLMethodAdress("glProgramUniform4i64ARB", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform4i64ARB));
			}
			if (SuportedExt.Contains("glProgramUniform4i64NV"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform4i64NV = (dgtk.OpenGL.delegatesGL.glProgramUniform4i64NV) InternalTool.GetGLMethodAdress("glProgramUniform4i64NV", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform4i64NV));
			}
			if (SuportedExt.Contains("glProgramUniform4i64vARB"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform4i64vARB = (dgtk.OpenGL.delegatesGL.glProgramUniform4i64vARB) InternalTool.GetGLMethodAdress("glProgramUniform4i64vARB", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform4i64vARB));
			}
			if (SuportedExt.Contains("glProgramUniform4i64vNV"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform4i64vNV = (dgtk.OpenGL.delegatesGL.glProgramUniform4i64vNV) InternalTool.GetGLMethodAdress("glProgramUniform4i64vNV", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform4i64vNV));
			}
			if (SuportedExt.Contains("glProgramUniform4iEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform4iEXT = (dgtk.OpenGL.delegatesGL.glProgramUniform4iEXT) InternalTool.GetGLMethodAdress("glProgramUniform4iEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform4iEXT));
			}
			if (SuportedExt.Contains("glProgramUniform4ivEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform4ivEXT = (dgtk.OpenGL.delegatesGL.glProgramUniform4ivEXT) InternalTool.GetGLMethodAdress("glProgramUniform4ivEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform4ivEXT));
			}
			if (SuportedExt.Contains("glProgramUniform4ui64ARB"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform4ui64ARB = (dgtk.OpenGL.delegatesGL.glProgramUniform4ui64ARB) InternalTool.GetGLMethodAdress("glProgramUniform4ui64ARB", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform4ui64ARB));
			}
			if (SuportedExt.Contains("glProgramUniform4ui64NV"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform4ui64NV = (dgtk.OpenGL.delegatesGL.glProgramUniform4ui64NV) InternalTool.GetGLMethodAdress("glProgramUniform4ui64NV", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform4ui64NV));
			}
			if (SuportedExt.Contains("glProgramUniform4ui64vARB"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform4ui64vARB = (dgtk.OpenGL.delegatesGL.glProgramUniform4ui64vARB) InternalTool.GetGLMethodAdress("glProgramUniform4ui64vARB", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform4ui64vARB));
			}
			if (SuportedExt.Contains("glProgramUniform4ui64vNV"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform4ui64vNV = (dgtk.OpenGL.delegatesGL.glProgramUniform4ui64vNV) InternalTool.GetGLMethodAdress("glProgramUniform4ui64vNV", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform4ui64vNV));
			}
			if (SuportedExt.Contains("glProgramUniform4uiEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform4uiEXT = (dgtk.OpenGL.delegatesGL.glProgramUniform4uiEXT) InternalTool.GetGLMethodAdress("glProgramUniform4uiEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform4uiEXT));
			}
			if (SuportedExt.Contains("glProgramUniform4uivEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniform4uivEXT = (dgtk.OpenGL.delegatesGL.glProgramUniform4uivEXT) InternalTool.GetGLMethodAdress("glProgramUniform4uivEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniform4uivEXT));
			}
			if (SuportedExt.Contains("glProgramUniformHandleui64ARB"))
			{
				dgtk.OpenGL.internalGL.glProgramUniformHandleui64ARB = (dgtk.OpenGL.delegatesGL.glProgramUniformHandleui64ARB) InternalTool.GetGLMethodAdress("glProgramUniformHandleui64ARB", typeof(dgtk.OpenGL.delegatesGL.glProgramUniformHandleui64ARB));
			}
			if (SuportedExt.Contains("glProgramUniformHandleui64IMG"))
			{
				dgtk.OpenGL.internalGL.glProgramUniformHandleui64IMG = (dgtk.OpenGL.delegatesGL.glProgramUniformHandleui64IMG) InternalTool.GetGLMethodAdress("glProgramUniformHandleui64IMG", typeof(dgtk.OpenGL.delegatesGL.glProgramUniformHandleui64IMG));
			}
			if (SuportedExt.Contains("glProgramUniformHandleui64NV"))
			{
				dgtk.OpenGL.internalGL.glProgramUniformHandleui64NV = (dgtk.OpenGL.delegatesGL.glProgramUniformHandleui64NV) InternalTool.GetGLMethodAdress("glProgramUniformHandleui64NV", typeof(dgtk.OpenGL.delegatesGL.glProgramUniformHandleui64NV));
			}
			if (SuportedExt.Contains("glProgramUniformHandleui64vARB"))
			{
				dgtk.OpenGL.internalGL.glProgramUniformHandleui64vARB = (dgtk.OpenGL.delegatesGL.glProgramUniformHandleui64vARB) InternalTool.GetGLMethodAdress("glProgramUniformHandleui64vARB", typeof(dgtk.OpenGL.delegatesGL.glProgramUniformHandleui64vARB));
			}
			if (SuportedExt.Contains("glProgramUniformHandleui64vIMG"))
			{
				dgtk.OpenGL.internalGL.glProgramUniformHandleui64vIMG = (dgtk.OpenGL.delegatesGL.glProgramUniformHandleui64vIMG) InternalTool.GetGLMethodAdress("glProgramUniformHandleui64vIMG", typeof(dgtk.OpenGL.delegatesGL.glProgramUniformHandleui64vIMG));
			}
			if (SuportedExt.Contains("glProgramUniformHandleui64vNV"))
			{
				dgtk.OpenGL.internalGL.glProgramUniformHandleui64vNV = (dgtk.OpenGL.delegatesGL.glProgramUniformHandleui64vNV) InternalTool.GetGLMethodAdress("glProgramUniformHandleui64vNV", typeof(dgtk.OpenGL.delegatesGL.glProgramUniformHandleui64vNV));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix2dvEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniformMatrix2dvEXT = (dgtk.OpenGL.delegatesGL.glProgramUniformMatrix2dvEXT) InternalTool.GetGLMethodAdress("glProgramUniformMatrix2dvEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniformMatrix2dvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix2fvEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniformMatrix2fvEXT = (dgtk.OpenGL.delegatesGL.glProgramUniformMatrix2fvEXT) InternalTool.GetGLMethodAdress("glProgramUniformMatrix2fvEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniformMatrix2fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix2x3dvEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniformMatrix2x3dvEXT = (dgtk.OpenGL.delegatesGL.glProgramUniformMatrix2x3dvEXT) InternalTool.GetGLMethodAdress("glProgramUniformMatrix2x3dvEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniformMatrix2x3dvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix2x3fvEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniformMatrix2x3fvEXT = (dgtk.OpenGL.delegatesGL.glProgramUniformMatrix2x3fvEXT) InternalTool.GetGLMethodAdress("glProgramUniformMatrix2x3fvEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniformMatrix2x3fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix2x4dvEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniformMatrix2x4dvEXT = (dgtk.OpenGL.delegatesGL.glProgramUniformMatrix2x4dvEXT) InternalTool.GetGLMethodAdress("glProgramUniformMatrix2x4dvEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniformMatrix2x4dvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix2x4fvEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniformMatrix2x4fvEXT = (dgtk.OpenGL.delegatesGL.glProgramUniformMatrix2x4fvEXT) InternalTool.GetGLMethodAdress("glProgramUniformMatrix2x4fvEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniformMatrix2x4fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix3dvEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniformMatrix3dvEXT = (dgtk.OpenGL.delegatesGL.glProgramUniformMatrix3dvEXT) InternalTool.GetGLMethodAdress("glProgramUniformMatrix3dvEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniformMatrix3dvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix3fvEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniformMatrix3fvEXT = (dgtk.OpenGL.delegatesGL.glProgramUniformMatrix3fvEXT) InternalTool.GetGLMethodAdress("glProgramUniformMatrix3fvEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniformMatrix3fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix3x2dvEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniformMatrix3x2dvEXT = (dgtk.OpenGL.delegatesGL.glProgramUniformMatrix3x2dvEXT) InternalTool.GetGLMethodAdress("glProgramUniformMatrix3x2dvEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniformMatrix3x2dvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix3x2fvEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniformMatrix3x2fvEXT = (dgtk.OpenGL.delegatesGL.glProgramUniformMatrix3x2fvEXT) InternalTool.GetGLMethodAdress("glProgramUniformMatrix3x2fvEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniformMatrix3x2fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix3x4dvEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniformMatrix3x4dvEXT = (dgtk.OpenGL.delegatesGL.glProgramUniformMatrix3x4dvEXT) InternalTool.GetGLMethodAdress("glProgramUniformMatrix3x4dvEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniformMatrix3x4dvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix3x4fvEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniformMatrix3x4fvEXT = (dgtk.OpenGL.delegatesGL.glProgramUniformMatrix3x4fvEXT) InternalTool.GetGLMethodAdress("glProgramUniformMatrix3x4fvEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniformMatrix3x4fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix4dvEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniformMatrix4dvEXT = (dgtk.OpenGL.delegatesGL.glProgramUniformMatrix4dvEXT) InternalTool.GetGLMethodAdress("glProgramUniformMatrix4dvEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniformMatrix4dvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix4fvEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniformMatrix4fvEXT = (dgtk.OpenGL.delegatesGL.glProgramUniformMatrix4fvEXT) InternalTool.GetGLMethodAdress("glProgramUniformMatrix4fvEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniformMatrix4fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix4x2dvEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniformMatrix4x2dvEXT = (dgtk.OpenGL.delegatesGL.glProgramUniformMatrix4x2dvEXT) InternalTool.GetGLMethodAdress("glProgramUniformMatrix4x2dvEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniformMatrix4x2dvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix4x2fvEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniformMatrix4x2fvEXT = (dgtk.OpenGL.delegatesGL.glProgramUniformMatrix4x2fvEXT) InternalTool.GetGLMethodAdress("glProgramUniformMatrix4x2fvEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniformMatrix4x2fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix4x3dvEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniformMatrix4x3dvEXT = (dgtk.OpenGL.delegatesGL.glProgramUniformMatrix4x3dvEXT) InternalTool.GetGLMethodAdress("glProgramUniformMatrix4x3dvEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniformMatrix4x3dvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix4x3fvEXT"))
			{
				dgtk.OpenGL.internalGL.glProgramUniformMatrix4x3fvEXT = (dgtk.OpenGL.delegatesGL.glProgramUniformMatrix4x3fvEXT) InternalTool.GetGLMethodAdress("glProgramUniformMatrix4x3fvEXT", typeof(dgtk.OpenGL.delegatesGL.glProgramUniformMatrix4x3fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformui64NV"))
			{
				dgtk.OpenGL.internalGL.glProgramUniformui64NV = (dgtk.OpenGL.delegatesGL.glProgramUniformui64NV) InternalTool.GetGLMethodAdress("glProgramUniformui64NV", typeof(dgtk.OpenGL.delegatesGL.glProgramUniformui64NV));
			}
			if (SuportedExt.Contains("glProgramUniformui64vNV"))
			{
				dgtk.OpenGL.internalGL.glProgramUniformui64vNV = (dgtk.OpenGL.delegatesGL.glProgramUniformui64vNV) InternalTool.GetGLMethodAdress("glProgramUniformui64vNV", typeof(dgtk.OpenGL.delegatesGL.glProgramUniformui64vNV));
			}
			if (SuportedExt.Contains("glProgramVertexLimitNV"))
			{
				dgtk.OpenGL.internalGL.glProgramVertexLimitNV = (dgtk.OpenGL.delegatesGL.glProgramVertexLimitNV) InternalTool.GetGLMethodAdress("glProgramVertexLimitNV", typeof(dgtk.OpenGL.delegatesGL.glProgramVertexLimitNV));
			}
			if (SuportedExt.Contains("glProvokingVertexEXT"))
			{
				dgtk.OpenGL.internalGL.glProvokingVertexEXT = (dgtk.OpenGL.delegatesGL.glProvokingVertexEXT) InternalTool.GetGLMethodAdress("glProvokingVertexEXT", typeof(dgtk.OpenGL.delegatesGL.glProvokingVertexEXT));
			}
			if (SuportedExt.Contains("glPushClientAttribDefaultEXT"))
			{
				dgtk.OpenGL.internalGL.glPushClientAttribDefaultEXT = (dgtk.OpenGL.delegatesGL.glPushClientAttribDefaultEXT) InternalTool.GetGLMethodAdress("glPushClientAttribDefaultEXT", typeof(dgtk.OpenGL.delegatesGL.glPushClientAttribDefaultEXT));
			}
			if (SuportedExt.Contains("glPushDebugGroupKHR"))
			{
				dgtk.OpenGL.internalGL.glPushDebugGroupKHR = (dgtk.OpenGL.delegatesGL.glPushDebugGroupKHR) InternalTool.GetGLMethodAdress("glPushDebugGroupKHR", typeof(dgtk.OpenGL.delegatesGL.glPushDebugGroupKHR));
			}
			if (SuportedExt.Contains("glPushGroupMarkerEXT"))
			{
				dgtk.OpenGL.internalGL.glPushGroupMarkerEXT = (dgtk.OpenGL.delegatesGL.glPushGroupMarkerEXT) InternalTool.GetGLMethodAdress("glPushGroupMarkerEXT", typeof(dgtk.OpenGL.delegatesGL.glPushGroupMarkerEXT));
			}
			#endregion

			#region Q:

			if (SuportedExt.Contains("glQueryCounterEXT"))
			{
				dgtk.OpenGL.internalGL.glQueryCounterEXT = (dgtk.OpenGL.delegatesGL.glQueryCounterEXT) InternalTool.GetGLMethodAdress("glQueryCounterEXT", typeof(dgtk.OpenGL.delegatesGL.glQueryCounterEXT));
			}
			if (SuportedExt.Contains("glQueryMatrixxOES"))
			{
				dgtk.OpenGL.internalGL.glQueryMatrixxOES = (dgtk.OpenGL.delegatesGL.glQueryMatrixxOES) InternalTool.GetGLMethodAdress("glQueryMatrixxOES", typeof(dgtk.OpenGL.delegatesGL.glQueryMatrixxOES));
			}
			if (SuportedExt.Contains("glQueryObjectParameteruiAMD"))
			{
				dgtk.OpenGL.internalGL.glQueryObjectParameteruiAMD = (dgtk.OpenGL.delegatesGL.glQueryObjectParameteruiAMD) InternalTool.GetGLMethodAdress("glQueryObjectParameteruiAMD", typeof(dgtk.OpenGL.delegatesGL.glQueryObjectParameteruiAMD));
			}
			if (SuportedExt.Contains("glQueryResourceNV"))
			{
				dgtk.OpenGL.internalGL.glQueryResourceNV = (dgtk.OpenGL.delegatesGL.glQueryResourceNV) InternalTool.GetGLMethodAdress("glQueryResourceNV", typeof(dgtk.OpenGL.delegatesGL.glQueryResourceNV));
			}
			if (SuportedExt.Contains("glQueryResourceTagNV"))
			{
				dgtk.OpenGL.internalGL.glQueryResourceTagNV = (dgtk.OpenGL.delegatesGL.glQueryResourceTagNV) InternalTool.GetGLMethodAdress("glQueryResourceTagNV", typeof(dgtk.OpenGL.delegatesGL.glQueryResourceTagNV));
			}
			#endregion

			#region R:

			if (SuportedExt.Contains("glRasterPos2xOES"))
			{
				dgtk.OpenGL.internalGL.glRasterPos2xOES = (dgtk.OpenGL.delegatesGL.glRasterPos2xOES) InternalTool.GetGLMethodAdress("glRasterPos2xOES", typeof(dgtk.OpenGL.delegatesGL.glRasterPos2xOES));
			}
			if (SuportedExt.Contains("glRasterPos2xvOES"))
			{
				dgtk.OpenGL.internalGL.glRasterPos2xvOES = (dgtk.OpenGL.delegatesGL.glRasterPos2xvOES) InternalTool.GetGLMethodAdress("glRasterPos2xvOES", typeof(dgtk.OpenGL.delegatesGL.glRasterPos2xvOES));
			}
			if (SuportedExt.Contains("glRasterPos3xOES"))
			{
				dgtk.OpenGL.internalGL.glRasterPos3xOES = (dgtk.OpenGL.delegatesGL.glRasterPos3xOES) InternalTool.GetGLMethodAdress("glRasterPos3xOES", typeof(dgtk.OpenGL.delegatesGL.glRasterPos3xOES));
			}
			if (SuportedExt.Contains("glRasterPos3xvOES"))
			{
				dgtk.OpenGL.internalGL.glRasterPos3xvOES = (dgtk.OpenGL.delegatesGL.glRasterPos3xvOES) InternalTool.GetGLMethodAdress("glRasterPos3xvOES", typeof(dgtk.OpenGL.delegatesGL.glRasterPos3xvOES));
			}
			if (SuportedExt.Contains("glRasterPos4xOES"))
			{
				dgtk.OpenGL.internalGL.glRasterPos4xOES = (dgtk.OpenGL.delegatesGL.glRasterPos4xOES) InternalTool.GetGLMethodAdress("glRasterPos4xOES", typeof(dgtk.OpenGL.delegatesGL.glRasterPos4xOES));
			}
			if (SuportedExt.Contains("glRasterPos4xvOES"))
			{
				dgtk.OpenGL.internalGL.glRasterPos4xvOES = (dgtk.OpenGL.delegatesGL.glRasterPos4xvOES) InternalTool.GetGLMethodAdress("glRasterPos4xvOES", typeof(dgtk.OpenGL.delegatesGL.glRasterPos4xvOES));
			}
			if (SuportedExt.Contains("glRasterSamplesEXT"))
			{
				dgtk.OpenGL.internalGL.glRasterSamplesEXT = (dgtk.OpenGL.delegatesGL.glRasterSamplesEXT) InternalTool.GetGLMethodAdress("glRasterSamplesEXT", typeof(dgtk.OpenGL.delegatesGL.glRasterSamplesEXT));
			}
			if (SuportedExt.Contains("glReadBufferIndexedEXT"))
			{
				dgtk.OpenGL.internalGL.glReadBufferIndexedEXT = (dgtk.OpenGL.delegatesGL.glReadBufferIndexedEXT) InternalTool.GetGLMethodAdress("glReadBufferIndexedEXT", typeof(dgtk.OpenGL.delegatesGL.glReadBufferIndexedEXT));
			}
			if (SuportedExt.Contains("glReadBufferNV"))
			{
				dgtk.OpenGL.internalGL.glReadBufferNV = (dgtk.OpenGL.delegatesGL.glReadBufferNV) InternalTool.GetGLMethodAdress("glReadBufferNV", typeof(dgtk.OpenGL.delegatesGL.glReadBufferNV));
			}
			if (SuportedExt.Contains("glReadInstrumentsSGIX"))
			{
				dgtk.OpenGL.internalGL.glReadInstrumentsSGIX = (dgtk.OpenGL.delegatesGL.glReadInstrumentsSGIX) InternalTool.GetGLMethodAdress("glReadInstrumentsSGIX", typeof(dgtk.OpenGL.delegatesGL.glReadInstrumentsSGIX));
			}
			if (SuportedExt.Contains("glReadnPixelsARB"))
			{
				dgtk.OpenGL.internalGL.glReadnPixelsARB = (dgtk.OpenGL.delegatesGL.glReadnPixelsARB) InternalTool.GetGLMethodAdress("glReadnPixelsARB", typeof(dgtk.OpenGL.delegatesGL.glReadnPixelsARB));
			}
			if (SuportedExt.Contains("glReadnPixelsEXT"))
			{
				dgtk.OpenGL.internalGL.glReadnPixelsEXT = (dgtk.OpenGL.delegatesGL.glReadnPixelsEXT) InternalTool.GetGLMethodAdress("glReadnPixelsEXT", typeof(dgtk.OpenGL.delegatesGL.glReadnPixelsEXT));
			}
			if (SuportedExt.Contains("glReadnPixelsKHR"))
			{
				dgtk.OpenGL.internalGL.glReadnPixelsKHR = (dgtk.OpenGL.delegatesGL.glReadnPixelsKHR) InternalTool.GetGLMethodAdress("glReadnPixelsKHR", typeof(dgtk.OpenGL.delegatesGL.glReadnPixelsKHR));
			}
			if (SuportedExt.Contains("glRectxOES"))
			{
				dgtk.OpenGL.internalGL.glRectxOES = (dgtk.OpenGL.delegatesGL.glRectxOES) InternalTool.GetGLMethodAdress("glRectxOES", typeof(dgtk.OpenGL.delegatesGL.glRectxOES));
			}
			if (SuportedExt.Contains("glRectxvOES"))
			{
				dgtk.OpenGL.internalGL.glRectxvOES = (dgtk.OpenGL.delegatesGL.glRectxvOES) InternalTool.GetGLMethodAdress("glRectxvOES", typeof(dgtk.OpenGL.delegatesGL.glRectxvOES));
			}
			if (SuportedExt.Contains("glReferencePlaneSGIX"))
			{
				dgtk.OpenGL.internalGL.glReferencePlaneSGIX = (dgtk.OpenGL.delegatesGL.glReferencePlaneSGIX) InternalTool.GetGLMethodAdress("glReferencePlaneSGIX", typeof(dgtk.OpenGL.delegatesGL.glReferencePlaneSGIX));
			}
			if (SuportedExt.Contains("glReleaseKeyedMutexWin32EXT"))
			{
				dgtk.OpenGL.internalGL.glReleaseKeyedMutexWin32EXT = (dgtk.OpenGL.delegatesGL.glReleaseKeyedMutexWin32EXT) InternalTool.GetGLMethodAdress("glReleaseKeyedMutexWin32EXT", typeof(dgtk.OpenGL.delegatesGL.glReleaseKeyedMutexWin32EXT));
			}
			if (SuportedExt.Contains("glRenderbufferStorageEXT"))
			{
				dgtk.OpenGL.internalGL.glRenderbufferStorageEXT = (dgtk.OpenGL.delegatesGL.glRenderbufferStorageEXT) InternalTool.GetGLMethodAdress("glRenderbufferStorageEXT", typeof(dgtk.OpenGL.delegatesGL.glRenderbufferStorageEXT));
			}
			if (SuportedExt.Contains("glRenderbufferStorageMultisampleAdvancedAMD"))
			{
				dgtk.OpenGL.internalGL.glRenderbufferStorageMultisampleAdvancedAMD = (dgtk.OpenGL.delegatesGL.glRenderbufferStorageMultisampleAdvancedAMD) InternalTool.GetGLMethodAdress("glRenderbufferStorageMultisampleAdvancedAMD", typeof(dgtk.OpenGL.delegatesGL.glRenderbufferStorageMultisampleAdvancedAMD));
			}
			if (SuportedExt.Contains("glRenderbufferStorageMultisampleANGLE"))
			{
				dgtk.OpenGL.internalGL.glRenderbufferStorageMultisampleANGLE = (dgtk.OpenGL.delegatesGL.glRenderbufferStorageMultisampleANGLE) InternalTool.GetGLMethodAdress("glRenderbufferStorageMultisampleANGLE", typeof(dgtk.OpenGL.delegatesGL.glRenderbufferStorageMultisampleANGLE));
			}
			if (SuportedExt.Contains("glRenderbufferStorageMultisampleAPPLE"))
			{
				dgtk.OpenGL.internalGL.glRenderbufferStorageMultisampleAPPLE = (dgtk.OpenGL.delegatesGL.glRenderbufferStorageMultisampleAPPLE) InternalTool.GetGLMethodAdress("glRenderbufferStorageMultisampleAPPLE", typeof(dgtk.OpenGL.delegatesGL.glRenderbufferStorageMultisampleAPPLE));
			}
			if (SuportedExt.Contains("glRenderbufferStorageMultisampleCoverageNV"))
			{
				dgtk.OpenGL.internalGL.glRenderbufferStorageMultisampleCoverageNV = (dgtk.OpenGL.delegatesGL.glRenderbufferStorageMultisampleCoverageNV) InternalTool.GetGLMethodAdress("glRenderbufferStorageMultisampleCoverageNV", typeof(dgtk.OpenGL.delegatesGL.glRenderbufferStorageMultisampleCoverageNV));
			}
			if (SuportedExt.Contains("glRenderbufferStorageMultisampleEXT"))
			{
				dgtk.OpenGL.internalGL.glRenderbufferStorageMultisampleEXT = (dgtk.OpenGL.delegatesGL.glRenderbufferStorageMultisampleEXT) InternalTool.GetGLMethodAdress("glRenderbufferStorageMultisampleEXT", typeof(dgtk.OpenGL.delegatesGL.glRenderbufferStorageMultisampleEXT));
			}
			if (SuportedExt.Contains("glRenderbufferStorageMultisampleIMG"))
			{
				dgtk.OpenGL.internalGL.glRenderbufferStorageMultisampleIMG = (dgtk.OpenGL.delegatesGL.glRenderbufferStorageMultisampleIMG) InternalTool.GetGLMethodAdress("glRenderbufferStorageMultisampleIMG", typeof(dgtk.OpenGL.delegatesGL.glRenderbufferStorageMultisampleIMG));
			}
			if (SuportedExt.Contains("glRenderbufferStorageMultisampleNV"))
			{
				dgtk.OpenGL.internalGL.glRenderbufferStorageMultisampleNV = (dgtk.OpenGL.delegatesGL.glRenderbufferStorageMultisampleNV) InternalTool.GetGLMethodAdress("glRenderbufferStorageMultisampleNV", typeof(dgtk.OpenGL.delegatesGL.glRenderbufferStorageMultisampleNV));
			}
			if (SuportedExt.Contains("glRenderbufferStorageOES"))
			{
				dgtk.OpenGL.internalGL.glRenderbufferStorageOES = (dgtk.OpenGL.delegatesGL.glRenderbufferStorageOES) InternalTool.GetGLMethodAdress("glRenderbufferStorageOES", typeof(dgtk.OpenGL.delegatesGL.glRenderbufferStorageOES));
			}
			if (SuportedExt.Contains("glRenderGpuMaskNV"))
			{
				dgtk.OpenGL.internalGL.glRenderGpuMaskNV = (dgtk.OpenGL.delegatesGL.glRenderGpuMaskNV) InternalTool.GetGLMethodAdress("glRenderGpuMaskNV", typeof(dgtk.OpenGL.delegatesGL.glRenderGpuMaskNV));
			}
			if (SuportedExt.Contains("glReplacementCodePointerSUN"))
			{
				dgtk.OpenGL.internalGL.glReplacementCodePointerSUN = (dgtk.OpenGL.delegatesGL.glReplacementCodePointerSUN) InternalTool.GetGLMethodAdress("glReplacementCodePointerSUN", typeof(dgtk.OpenGL.delegatesGL.glReplacementCodePointerSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeubSUN"))
			{
				dgtk.OpenGL.internalGL.glReplacementCodeubSUN = (dgtk.OpenGL.delegatesGL.glReplacementCodeubSUN) InternalTool.GetGLMethodAdress("glReplacementCodeubSUN", typeof(dgtk.OpenGL.delegatesGL.glReplacementCodeubSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeubvSUN"))
			{
				dgtk.OpenGL.internalGL.glReplacementCodeubvSUN = (dgtk.OpenGL.delegatesGL.glReplacementCodeubvSUN) InternalTool.GetGLMethodAdress("glReplacementCodeubvSUN", typeof(dgtk.OpenGL.delegatesGL.glReplacementCodeubvSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeuiColor3fVertex3fSUN"))
			{
				dgtk.OpenGL.internalGL.glReplacementCodeuiColor3fVertex3fSUN = (dgtk.OpenGL.delegatesGL.glReplacementCodeuiColor3fVertex3fSUN) InternalTool.GetGLMethodAdress("glReplacementCodeuiColor3fVertex3fSUN", typeof(dgtk.OpenGL.delegatesGL.glReplacementCodeuiColor3fVertex3fSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeuiColor3fVertex3fvSUN"))
			{
				dgtk.OpenGL.internalGL.glReplacementCodeuiColor3fVertex3fvSUN = (dgtk.OpenGL.delegatesGL.glReplacementCodeuiColor3fVertex3fvSUN) InternalTool.GetGLMethodAdress("glReplacementCodeuiColor3fVertex3fvSUN", typeof(dgtk.OpenGL.delegatesGL.glReplacementCodeuiColor3fVertex3fvSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeuiColor4fNormal3fVertex3fSUN"))
			{
				dgtk.OpenGL.internalGL.glReplacementCodeuiColor4fNormal3fVertex3fSUN = (dgtk.OpenGL.delegatesGL.glReplacementCodeuiColor4fNormal3fVertex3fSUN) InternalTool.GetGLMethodAdress("glReplacementCodeuiColor4fNormal3fVertex3fSUN", typeof(dgtk.OpenGL.delegatesGL.glReplacementCodeuiColor4fNormal3fVertex3fSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeuiColor4fNormal3fVertex3fvSUN"))
			{
				dgtk.OpenGL.internalGL.glReplacementCodeuiColor4fNormal3fVertex3fvSUN = (dgtk.OpenGL.delegatesGL.glReplacementCodeuiColor4fNormal3fVertex3fvSUN) InternalTool.GetGLMethodAdress("glReplacementCodeuiColor4fNormal3fVertex3fvSUN", typeof(dgtk.OpenGL.delegatesGL.glReplacementCodeuiColor4fNormal3fVertex3fvSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeuiColor4ubVertex3fSUN"))
			{
				dgtk.OpenGL.internalGL.glReplacementCodeuiColor4ubVertex3fSUN = (dgtk.OpenGL.delegatesGL.glReplacementCodeuiColor4ubVertex3fSUN) InternalTool.GetGLMethodAdress("glReplacementCodeuiColor4ubVertex3fSUN", typeof(dgtk.OpenGL.delegatesGL.glReplacementCodeuiColor4ubVertex3fSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeuiColor4ubVertex3fvSUN"))
			{
				dgtk.OpenGL.internalGL.glReplacementCodeuiColor4ubVertex3fvSUN = (dgtk.OpenGL.delegatesGL.glReplacementCodeuiColor4ubVertex3fvSUN) InternalTool.GetGLMethodAdress("glReplacementCodeuiColor4ubVertex3fvSUN", typeof(dgtk.OpenGL.delegatesGL.glReplacementCodeuiColor4ubVertex3fvSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeuiNormal3fVertex3fSUN"))
			{
				dgtk.OpenGL.internalGL.glReplacementCodeuiNormal3fVertex3fSUN = (dgtk.OpenGL.delegatesGL.glReplacementCodeuiNormal3fVertex3fSUN) InternalTool.GetGLMethodAdress("glReplacementCodeuiNormal3fVertex3fSUN", typeof(dgtk.OpenGL.delegatesGL.glReplacementCodeuiNormal3fVertex3fSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeuiNormal3fVertex3fvSUN"))
			{
				dgtk.OpenGL.internalGL.glReplacementCodeuiNormal3fVertex3fvSUN = (dgtk.OpenGL.delegatesGL.glReplacementCodeuiNormal3fVertex3fvSUN) InternalTool.GetGLMethodAdress("glReplacementCodeuiNormal3fVertex3fvSUN", typeof(dgtk.OpenGL.delegatesGL.glReplacementCodeuiNormal3fVertex3fvSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeuiSUN"))
			{
				dgtk.OpenGL.internalGL.glReplacementCodeuiSUN = (dgtk.OpenGL.delegatesGL.glReplacementCodeuiSUN) InternalTool.GetGLMethodAdress("glReplacementCodeuiSUN", typeof(dgtk.OpenGL.delegatesGL.glReplacementCodeuiSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN"))
			{
				dgtk.OpenGL.internalGL.glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN = (dgtk.OpenGL.delegatesGL.glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN) InternalTool.GetGLMethodAdress("glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN", typeof(dgtk.OpenGL.delegatesGL.glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN"))
			{
				dgtk.OpenGL.internalGL.glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN = (dgtk.OpenGL.delegatesGL.glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN) InternalTool.GetGLMethodAdress("glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", typeof(dgtk.OpenGL.delegatesGL.glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN"))
			{
				dgtk.OpenGL.internalGL.glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN = (dgtk.OpenGL.delegatesGL.glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN) InternalTool.GetGLMethodAdress("glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN", typeof(dgtk.OpenGL.delegatesGL.glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN"))
			{
				dgtk.OpenGL.internalGL.glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN = (dgtk.OpenGL.delegatesGL.glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN) InternalTool.GetGLMethodAdress("glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", typeof(dgtk.OpenGL.delegatesGL.glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeuiTexCoord2fVertex3fSUN"))
			{
				dgtk.OpenGL.internalGL.glReplacementCodeuiTexCoord2fVertex3fSUN = (dgtk.OpenGL.delegatesGL.glReplacementCodeuiTexCoord2fVertex3fSUN) InternalTool.GetGLMethodAdress("glReplacementCodeuiTexCoord2fVertex3fSUN", typeof(dgtk.OpenGL.delegatesGL.glReplacementCodeuiTexCoord2fVertex3fSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeuiTexCoord2fVertex3fvSUN"))
			{
				dgtk.OpenGL.internalGL.glReplacementCodeuiTexCoord2fVertex3fvSUN = (dgtk.OpenGL.delegatesGL.glReplacementCodeuiTexCoord2fVertex3fvSUN) InternalTool.GetGLMethodAdress("glReplacementCodeuiTexCoord2fVertex3fvSUN", typeof(dgtk.OpenGL.delegatesGL.glReplacementCodeuiTexCoord2fVertex3fvSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeuiVertex3fSUN"))
			{
				dgtk.OpenGL.internalGL.glReplacementCodeuiVertex3fSUN = (dgtk.OpenGL.delegatesGL.glReplacementCodeuiVertex3fSUN) InternalTool.GetGLMethodAdress("glReplacementCodeuiVertex3fSUN", typeof(dgtk.OpenGL.delegatesGL.glReplacementCodeuiVertex3fSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeuiVertex3fvSUN"))
			{
				dgtk.OpenGL.internalGL.glReplacementCodeuiVertex3fvSUN = (dgtk.OpenGL.delegatesGL.glReplacementCodeuiVertex3fvSUN) InternalTool.GetGLMethodAdress("glReplacementCodeuiVertex3fvSUN", typeof(dgtk.OpenGL.delegatesGL.glReplacementCodeuiVertex3fvSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeuivSUN"))
			{
				dgtk.OpenGL.internalGL.glReplacementCodeuivSUN = (dgtk.OpenGL.delegatesGL.glReplacementCodeuivSUN) InternalTool.GetGLMethodAdress("glReplacementCodeuivSUN", typeof(dgtk.OpenGL.delegatesGL.glReplacementCodeuivSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeusSUN"))
			{
				dgtk.OpenGL.internalGL.glReplacementCodeusSUN = (dgtk.OpenGL.delegatesGL.glReplacementCodeusSUN) InternalTool.GetGLMethodAdress("glReplacementCodeusSUN", typeof(dgtk.OpenGL.delegatesGL.glReplacementCodeusSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeusvSUN"))
			{
				dgtk.OpenGL.internalGL.glReplacementCodeusvSUN = (dgtk.OpenGL.delegatesGL.glReplacementCodeusvSUN) InternalTool.GetGLMethodAdress("glReplacementCodeusvSUN", typeof(dgtk.OpenGL.delegatesGL.glReplacementCodeusvSUN));
			}
			if (SuportedExt.Contains("glRequestResidentProgramsNV"))
			{
				dgtk.OpenGL.internalGL.glRequestResidentProgramsNV = (dgtk.OpenGL.delegatesGL.glRequestResidentProgramsNV) InternalTool.GetGLMethodAdress("glRequestResidentProgramsNV", typeof(dgtk.OpenGL.delegatesGL.glRequestResidentProgramsNV));
			}
			if (SuportedExt.Contains("glResetHistogram"))
			{
				dgtk.OpenGL.internalGL.glResetHistogram = (dgtk.OpenGL.delegatesGL.glResetHistogram) InternalTool.GetGLMethodAdress("glResetHistogram", typeof(dgtk.OpenGL.delegatesGL.glResetHistogram));
			}
			if (SuportedExt.Contains("glResetHistogramEXT"))
			{
				dgtk.OpenGL.internalGL.glResetHistogramEXT = (dgtk.OpenGL.delegatesGL.glResetHistogramEXT) InternalTool.GetGLMethodAdress("glResetHistogramEXT", typeof(dgtk.OpenGL.delegatesGL.glResetHistogramEXT));
			}
			if (SuportedExt.Contains("glResetMemoryObjectParameterNV"))
			{
				dgtk.OpenGL.internalGL.glResetMemoryObjectParameterNV = (dgtk.OpenGL.delegatesGL.glResetMemoryObjectParameterNV) InternalTool.GetGLMethodAdress("glResetMemoryObjectParameterNV", typeof(dgtk.OpenGL.delegatesGL.glResetMemoryObjectParameterNV));
			}
			if (SuportedExt.Contains("glResetMinmax"))
			{
				dgtk.OpenGL.internalGL.glResetMinmax = (dgtk.OpenGL.delegatesGL.glResetMinmax) InternalTool.GetGLMethodAdress("glResetMinmax", typeof(dgtk.OpenGL.delegatesGL.glResetMinmax));
			}
			if (SuportedExt.Contains("glResetMinmaxEXT"))
			{
				dgtk.OpenGL.internalGL.glResetMinmaxEXT = (dgtk.OpenGL.delegatesGL.glResetMinmaxEXT) InternalTool.GetGLMethodAdress("glResetMinmaxEXT", typeof(dgtk.OpenGL.delegatesGL.glResetMinmaxEXT));
			}
			if (SuportedExt.Contains("glResizeBuffersMESA"))
			{
				dgtk.OpenGL.internalGL.glResizeBuffersMESA = (dgtk.OpenGL.delegatesGL.glResizeBuffersMESA) InternalTool.GetGLMethodAdress("glResizeBuffersMESA", typeof(dgtk.OpenGL.delegatesGL.glResizeBuffersMESA));
			}
			if (SuportedExt.Contains("glResolveDepthValuesNV"))
			{
				dgtk.OpenGL.internalGL.glResolveDepthValuesNV = (dgtk.OpenGL.delegatesGL.glResolveDepthValuesNV) InternalTool.GetGLMethodAdress("glResolveDepthValuesNV", typeof(dgtk.OpenGL.delegatesGL.glResolveDepthValuesNV));
			}
			if (SuportedExt.Contains("glResolveMultisampleFramebufferAPPLE"))
			{
				dgtk.OpenGL.internalGL.glResolveMultisampleFramebufferAPPLE = (dgtk.OpenGL.delegatesGL.glResolveMultisampleFramebufferAPPLE) InternalTool.GetGLMethodAdress("glResolveMultisampleFramebufferAPPLE", typeof(dgtk.OpenGL.delegatesGL.glResolveMultisampleFramebufferAPPLE));
			}
			if (SuportedExt.Contains("glResumeTransformFeedbackNV"))
			{
				dgtk.OpenGL.internalGL.glResumeTransformFeedbackNV = (dgtk.OpenGL.delegatesGL.glResumeTransformFeedbackNV) InternalTool.GetGLMethodAdress("glResumeTransformFeedbackNV", typeof(dgtk.OpenGL.delegatesGL.glResumeTransformFeedbackNV));
			}
			if (SuportedExt.Contains("glRotatex"))
			{
				dgtk.OpenGL.internalGL.glRotatex = (dgtk.OpenGL.delegatesGL.glRotatex) InternalTool.GetGLMethodAdress("glRotatex", typeof(dgtk.OpenGL.delegatesGL.glRotatex));
			}
			if (SuportedExt.Contains("glRotatexOES"))
			{
				dgtk.OpenGL.internalGL.glRotatexOES = (dgtk.OpenGL.delegatesGL.glRotatexOES) InternalTool.GetGLMethodAdress("glRotatexOES", typeof(dgtk.OpenGL.delegatesGL.glRotatexOES));
			}
			#endregion

			#region S:

			if (SuportedExt.Contains("glSampleCoverageARB"))
			{
				dgtk.OpenGL.internalGL.glSampleCoverageARB = (dgtk.OpenGL.delegatesGL.glSampleCoverageARB) InternalTool.GetGLMethodAdress("glSampleCoverageARB", typeof(dgtk.OpenGL.delegatesGL.glSampleCoverageARB));
			}
			if (SuportedExt.Contains("glSampleCoveragex"))
			{
				dgtk.OpenGL.internalGL.glSampleCoveragex = (dgtk.OpenGL.delegatesGL.glSampleCoveragex) InternalTool.GetGLMethodAdress("glSampleCoveragex", typeof(dgtk.OpenGL.delegatesGL.glSampleCoveragex));
			}
			if (SuportedExt.Contains("glSampleCoveragexOES"))
			{
				dgtk.OpenGL.internalGL.glSampleCoveragexOES = (dgtk.OpenGL.delegatesGL.glSampleCoveragexOES) InternalTool.GetGLMethodAdress("glSampleCoveragexOES", typeof(dgtk.OpenGL.delegatesGL.glSampleCoveragexOES));
			}
			if (SuportedExt.Contains("glSampleMapATI"))
			{
				dgtk.OpenGL.internalGL.glSampleMapATI = (dgtk.OpenGL.delegatesGL.glSampleMapATI) InternalTool.GetGLMethodAdress("glSampleMapATI", typeof(dgtk.OpenGL.delegatesGL.glSampleMapATI));
			}
			if (SuportedExt.Contains("glSampleMaskEXT"))
			{
				dgtk.OpenGL.internalGL.glSampleMaskEXT = (dgtk.OpenGL.delegatesGL.glSampleMaskEXT) InternalTool.GetGLMethodAdress("glSampleMaskEXT", typeof(dgtk.OpenGL.delegatesGL.glSampleMaskEXT));
			}
			if (SuportedExt.Contains("glSampleMaskIndexedNV"))
			{
				dgtk.OpenGL.internalGL.glSampleMaskIndexedNV = (dgtk.OpenGL.delegatesGL.glSampleMaskIndexedNV) InternalTool.GetGLMethodAdress("glSampleMaskIndexedNV", typeof(dgtk.OpenGL.delegatesGL.glSampleMaskIndexedNV));
			}
			if (SuportedExt.Contains("glSampleMaskSGIS"))
			{
				dgtk.OpenGL.internalGL.glSampleMaskSGIS = (dgtk.OpenGL.delegatesGL.glSampleMaskSGIS) InternalTool.GetGLMethodAdress("glSampleMaskSGIS", typeof(dgtk.OpenGL.delegatesGL.glSampleMaskSGIS));
			}
			if (SuportedExt.Contains("glSamplePatternEXT"))
			{
				dgtk.OpenGL.internalGL.glSamplePatternEXT = (dgtk.OpenGL.delegatesGL.glSamplePatternEXT) InternalTool.GetGLMethodAdress("glSamplePatternEXT", typeof(dgtk.OpenGL.delegatesGL.glSamplePatternEXT));
			}
			if (SuportedExt.Contains("glSamplePatternSGIS"))
			{
				dgtk.OpenGL.internalGL.glSamplePatternSGIS = (dgtk.OpenGL.delegatesGL.glSamplePatternSGIS) InternalTool.GetGLMethodAdress("glSamplePatternSGIS", typeof(dgtk.OpenGL.delegatesGL.glSamplePatternSGIS));
			}
			if (SuportedExt.Contains("glSamplerParameterIivEXT"))
			{
				dgtk.OpenGL.internalGL.glSamplerParameterIivEXT = (dgtk.OpenGL.delegatesGL.glSamplerParameterIivEXT) InternalTool.GetGLMethodAdress("glSamplerParameterIivEXT", typeof(dgtk.OpenGL.delegatesGL.glSamplerParameterIivEXT));
			}
			if (SuportedExt.Contains("glSamplerParameterIivOES"))
			{
				dgtk.OpenGL.internalGL.glSamplerParameterIivOES = (dgtk.OpenGL.delegatesGL.glSamplerParameterIivOES) InternalTool.GetGLMethodAdress("glSamplerParameterIivOES", typeof(dgtk.OpenGL.delegatesGL.glSamplerParameterIivOES));
			}
			if (SuportedExt.Contains("glSamplerParameterIuivEXT"))
			{
				dgtk.OpenGL.internalGL.glSamplerParameterIuivEXT = (dgtk.OpenGL.delegatesGL.glSamplerParameterIuivEXT) InternalTool.GetGLMethodAdress("glSamplerParameterIuivEXT", typeof(dgtk.OpenGL.delegatesGL.glSamplerParameterIuivEXT));
			}
			if (SuportedExt.Contains("glSamplerParameterIuivOES"))
			{
				dgtk.OpenGL.internalGL.glSamplerParameterIuivOES = (dgtk.OpenGL.delegatesGL.glSamplerParameterIuivOES) InternalTool.GetGLMethodAdress("glSamplerParameterIuivOES", typeof(dgtk.OpenGL.delegatesGL.glSamplerParameterIuivOES));
			}
			if (SuportedExt.Contains("glScalex"))
			{
				dgtk.OpenGL.internalGL.glScalex = (dgtk.OpenGL.delegatesGL.glScalex) InternalTool.GetGLMethodAdress("glScalex", typeof(dgtk.OpenGL.delegatesGL.glScalex));
			}
			if (SuportedExt.Contains("glScalexOES"))
			{
				dgtk.OpenGL.internalGL.glScalexOES = (dgtk.OpenGL.delegatesGL.glScalexOES) InternalTool.GetGLMethodAdress("glScalexOES", typeof(dgtk.OpenGL.delegatesGL.glScalexOES));
			}
			if (SuportedExt.Contains("glScissorArrayvNV"))
			{
				dgtk.OpenGL.internalGL.glScissorArrayvNV = (dgtk.OpenGL.delegatesGL.glScissorArrayvNV) InternalTool.GetGLMethodAdress("glScissorArrayvNV", typeof(dgtk.OpenGL.delegatesGL.glScissorArrayvNV));
			}
			if (SuportedExt.Contains("glScissorArrayvOES"))
			{
				dgtk.OpenGL.internalGL.glScissorArrayvOES = (dgtk.OpenGL.delegatesGL.glScissorArrayvOES) InternalTool.GetGLMethodAdress("glScissorArrayvOES", typeof(dgtk.OpenGL.delegatesGL.glScissorArrayvOES));
			}
			if (SuportedExt.Contains("glScissorExclusiveArrayvNV"))
			{
				dgtk.OpenGL.internalGL.glScissorExclusiveArrayvNV = (dgtk.OpenGL.delegatesGL.glScissorExclusiveArrayvNV) InternalTool.GetGLMethodAdress("glScissorExclusiveArrayvNV", typeof(dgtk.OpenGL.delegatesGL.glScissorExclusiveArrayvNV));
			}
			if (SuportedExt.Contains("glScissorExclusiveNV"))
			{
				dgtk.OpenGL.internalGL.glScissorExclusiveNV = (dgtk.OpenGL.delegatesGL.glScissorExclusiveNV) InternalTool.GetGLMethodAdress("glScissorExclusiveNV", typeof(dgtk.OpenGL.delegatesGL.glScissorExclusiveNV));
			}
			if (SuportedExt.Contains("glScissorIndexedNV"))
			{
				dgtk.OpenGL.internalGL.glScissorIndexedNV = (dgtk.OpenGL.delegatesGL.glScissorIndexedNV) InternalTool.GetGLMethodAdress("glScissorIndexedNV", typeof(dgtk.OpenGL.delegatesGL.glScissorIndexedNV));
			}
			if (SuportedExt.Contains("glScissorIndexedOES"))
			{
				dgtk.OpenGL.internalGL.glScissorIndexedOES = (dgtk.OpenGL.delegatesGL.glScissorIndexedOES) InternalTool.GetGLMethodAdress("glScissorIndexedOES", typeof(dgtk.OpenGL.delegatesGL.glScissorIndexedOES));
			}
			if (SuportedExt.Contains("glScissorIndexedvNV"))
			{
				dgtk.OpenGL.internalGL.glScissorIndexedvNV = (dgtk.OpenGL.delegatesGL.glScissorIndexedvNV) InternalTool.GetGLMethodAdress("glScissorIndexedvNV", typeof(dgtk.OpenGL.delegatesGL.glScissorIndexedvNV));
			}
			if (SuportedExt.Contains("glScissorIndexedvOES"))
			{
				dgtk.OpenGL.internalGL.glScissorIndexedvOES = (dgtk.OpenGL.delegatesGL.glScissorIndexedvOES) InternalTool.GetGLMethodAdress("glScissorIndexedvOES", typeof(dgtk.OpenGL.delegatesGL.glScissorIndexedvOES));
			}
			if (SuportedExt.Contains("glSecondaryColor3bEXT"))
			{
				dgtk.OpenGL.internalGL.glSecondaryColor3bEXT = (dgtk.OpenGL.delegatesGL.glSecondaryColor3bEXT) InternalTool.GetGLMethodAdress("glSecondaryColor3bEXT", typeof(dgtk.OpenGL.delegatesGL.glSecondaryColor3bEXT));
			}
			if (SuportedExt.Contains("glSecondaryColor3bvEXT"))
			{
				dgtk.OpenGL.internalGL.glSecondaryColor3bvEXT = (dgtk.OpenGL.delegatesGL.glSecondaryColor3bvEXT) InternalTool.GetGLMethodAdress("glSecondaryColor3bvEXT", typeof(dgtk.OpenGL.delegatesGL.glSecondaryColor3bvEXT));
			}
			if (SuportedExt.Contains("glSecondaryColor3dEXT"))
			{
				dgtk.OpenGL.internalGL.glSecondaryColor3dEXT = (dgtk.OpenGL.delegatesGL.glSecondaryColor3dEXT) InternalTool.GetGLMethodAdress("glSecondaryColor3dEXT", typeof(dgtk.OpenGL.delegatesGL.glSecondaryColor3dEXT));
			}
			if (SuportedExt.Contains("glSecondaryColor3dvEXT"))
			{
				dgtk.OpenGL.internalGL.glSecondaryColor3dvEXT = (dgtk.OpenGL.delegatesGL.glSecondaryColor3dvEXT) InternalTool.GetGLMethodAdress("glSecondaryColor3dvEXT", typeof(dgtk.OpenGL.delegatesGL.glSecondaryColor3dvEXT));
			}
			if (SuportedExt.Contains("glSecondaryColor3fEXT"))
			{
				dgtk.OpenGL.internalGL.glSecondaryColor3fEXT = (dgtk.OpenGL.delegatesGL.glSecondaryColor3fEXT) InternalTool.GetGLMethodAdress("glSecondaryColor3fEXT", typeof(dgtk.OpenGL.delegatesGL.glSecondaryColor3fEXT));
			}
			if (SuportedExt.Contains("glSecondaryColor3fvEXT"))
			{
				dgtk.OpenGL.internalGL.glSecondaryColor3fvEXT = (dgtk.OpenGL.delegatesGL.glSecondaryColor3fvEXT) InternalTool.GetGLMethodAdress("glSecondaryColor3fvEXT", typeof(dgtk.OpenGL.delegatesGL.glSecondaryColor3fvEXT));
			}
			if (SuportedExt.Contains("glSecondaryColor3hNV"))
			{
				dgtk.OpenGL.internalGL.glSecondaryColor3hNV = (dgtk.OpenGL.delegatesGL.glSecondaryColor3hNV) InternalTool.GetGLMethodAdress("glSecondaryColor3hNV", typeof(dgtk.OpenGL.delegatesGL.glSecondaryColor3hNV));
			}
			if (SuportedExt.Contains("glSecondaryColor3hvNV"))
			{
				dgtk.OpenGL.internalGL.glSecondaryColor3hvNV = (dgtk.OpenGL.delegatesGL.glSecondaryColor3hvNV) InternalTool.GetGLMethodAdress("glSecondaryColor3hvNV", typeof(dgtk.OpenGL.delegatesGL.glSecondaryColor3hvNV));
			}
			if (SuportedExt.Contains("glSecondaryColor3iEXT"))
			{
				dgtk.OpenGL.internalGL.glSecondaryColor3iEXT = (dgtk.OpenGL.delegatesGL.glSecondaryColor3iEXT) InternalTool.GetGLMethodAdress("glSecondaryColor3iEXT", typeof(dgtk.OpenGL.delegatesGL.glSecondaryColor3iEXT));
			}
			if (SuportedExt.Contains("glSecondaryColor3ivEXT"))
			{
				dgtk.OpenGL.internalGL.glSecondaryColor3ivEXT = (dgtk.OpenGL.delegatesGL.glSecondaryColor3ivEXT) InternalTool.GetGLMethodAdress("glSecondaryColor3ivEXT", typeof(dgtk.OpenGL.delegatesGL.glSecondaryColor3ivEXT));
			}
			if (SuportedExt.Contains("glSecondaryColor3sEXT"))
			{
				dgtk.OpenGL.internalGL.glSecondaryColor3sEXT = (dgtk.OpenGL.delegatesGL.glSecondaryColor3sEXT) InternalTool.GetGLMethodAdress("glSecondaryColor3sEXT", typeof(dgtk.OpenGL.delegatesGL.glSecondaryColor3sEXT));
			}
			if (SuportedExt.Contains("glSecondaryColor3svEXT"))
			{
				dgtk.OpenGL.internalGL.glSecondaryColor3svEXT = (dgtk.OpenGL.delegatesGL.glSecondaryColor3svEXT) InternalTool.GetGLMethodAdress("glSecondaryColor3svEXT", typeof(dgtk.OpenGL.delegatesGL.glSecondaryColor3svEXT));
			}
			if (SuportedExt.Contains("glSecondaryColor3ubEXT"))
			{
				dgtk.OpenGL.internalGL.glSecondaryColor3ubEXT = (dgtk.OpenGL.delegatesGL.glSecondaryColor3ubEXT) InternalTool.GetGLMethodAdress("glSecondaryColor3ubEXT", typeof(dgtk.OpenGL.delegatesGL.glSecondaryColor3ubEXT));
			}
			if (SuportedExt.Contains("glSecondaryColor3ubvEXT"))
			{
				dgtk.OpenGL.internalGL.glSecondaryColor3ubvEXT = (dgtk.OpenGL.delegatesGL.glSecondaryColor3ubvEXT) InternalTool.GetGLMethodAdress("glSecondaryColor3ubvEXT", typeof(dgtk.OpenGL.delegatesGL.glSecondaryColor3ubvEXT));
			}
			if (SuportedExt.Contains("glSecondaryColor3uiEXT"))
			{
				dgtk.OpenGL.internalGL.glSecondaryColor3uiEXT = (dgtk.OpenGL.delegatesGL.glSecondaryColor3uiEXT) InternalTool.GetGLMethodAdress("glSecondaryColor3uiEXT", typeof(dgtk.OpenGL.delegatesGL.glSecondaryColor3uiEXT));
			}
			if (SuportedExt.Contains("glSecondaryColor3uivEXT"))
			{
				dgtk.OpenGL.internalGL.glSecondaryColor3uivEXT = (dgtk.OpenGL.delegatesGL.glSecondaryColor3uivEXT) InternalTool.GetGLMethodAdress("glSecondaryColor3uivEXT", typeof(dgtk.OpenGL.delegatesGL.glSecondaryColor3uivEXT));
			}
			if (SuportedExt.Contains("glSecondaryColor3usEXT"))
			{
				dgtk.OpenGL.internalGL.glSecondaryColor3usEXT = (dgtk.OpenGL.delegatesGL.glSecondaryColor3usEXT) InternalTool.GetGLMethodAdress("glSecondaryColor3usEXT", typeof(dgtk.OpenGL.delegatesGL.glSecondaryColor3usEXT));
			}
			if (SuportedExt.Contains("glSecondaryColor3usvEXT"))
			{
				dgtk.OpenGL.internalGL.glSecondaryColor3usvEXT = (dgtk.OpenGL.delegatesGL.glSecondaryColor3usvEXT) InternalTool.GetGLMethodAdress("glSecondaryColor3usvEXT", typeof(dgtk.OpenGL.delegatesGL.glSecondaryColor3usvEXT));
			}
			if (SuportedExt.Contains("glSecondaryColorFormatNV"))
			{
				dgtk.OpenGL.internalGL.glSecondaryColorFormatNV = (dgtk.OpenGL.delegatesGL.glSecondaryColorFormatNV) InternalTool.GetGLMethodAdress("glSecondaryColorFormatNV", typeof(dgtk.OpenGL.delegatesGL.glSecondaryColorFormatNV));
			}
			if (SuportedExt.Contains("glSecondaryColorPointerEXT"))
			{
				dgtk.OpenGL.internalGL.glSecondaryColorPointerEXT = (dgtk.OpenGL.delegatesGL.glSecondaryColorPointerEXT) InternalTool.GetGLMethodAdress("glSecondaryColorPointerEXT", typeof(dgtk.OpenGL.delegatesGL.glSecondaryColorPointerEXT));
			}
			if (SuportedExt.Contains("glSecondaryColorPointerListIBM"))
			{
				dgtk.OpenGL.internalGL.glSecondaryColorPointerListIBM = (dgtk.OpenGL.delegatesGL.glSecondaryColorPointerListIBM) InternalTool.GetGLMethodAdress("glSecondaryColorPointerListIBM", typeof(dgtk.OpenGL.delegatesGL.glSecondaryColorPointerListIBM));
			}
			if (SuportedExt.Contains("glSelectPerfMonitorCountersAMD"))
			{
				dgtk.OpenGL.internalGL.glSelectPerfMonitorCountersAMD = (dgtk.OpenGL.delegatesGL.glSelectPerfMonitorCountersAMD) InternalTool.GetGLMethodAdress("glSelectPerfMonitorCountersAMD", typeof(dgtk.OpenGL.delegatesGL.glSelectPerfMonitorCountersAMD));
			}
			if (SuportedExt.Contains("glSemaphoreParameterivNV"))
			{
				dgtk.OpenGL.internalGL.glSemaphoreParameterivNV = (dgtk.OpenGL.delegatesGL.glSemaphoreParameterivNV) InternalTool.GetGLMethodAdress("glSemaphoreParameterivNV", typeof(dgtk.OpenGL.delegatesGL.glSemaphoreParameterivNV));
			}
			if (SuportedExt.Contains("glSemaphoreParameterui64vEXT"))
			{
				dgtk.OpenGL.internalGL.glSemaphoreParameterui64vEXT = (dgtk.OpenGL.delegatesGL.glSemaphoreParameterui64vEXT) InternalTool.GetGLMethodAdress("glSemaphoreParameterui64vEXT", typeof(dgtk.OpenGL.delegatesGL.glSemaphoreParameterui64vEXT));
			}
			if (SuportedExt.Contains("glSeparableFilter2D"))
			{
				dgtk.OpenGL.internalGL.glSeparableFilter2D = (dgtk.OpenGL.delegatesGL.glSeparableFilter2D) InternalTool.GetGLMethodAdress("glSeparableFilter2D", typeof(dgtk.OpenGL.delegatesGL.glSeparableFilter2D));
			}
			if (SuportedExt.Contains("glSeparableFilter2DEXT"))
			{
				dgtk.OpenGL.internalGL.glSeparableFilter2DEXT = (dgtk.OpenGL.delegatesGL.glSeparableFilter2DEXT) InternalTool.GetGLMethodAdress("glSeparableFilter2DEXT", typeof(dgtk.OpenGL.delegatesGL.glSeparableFilter2DEXT));
			}
			if (SuportedExt.Contains("glSetFenceAPPLE"))
			{
				dgtk.OpenGL.internalGL.glSetFenceAPPLE = (dgtk.OpenGL.delegatesGL.glSetFenceAPPLE) InternalTool.GetGLMethodAdress("glSetFenceAPPLE", typeof(dgtk.OpenGL.delegatesGL.glSetFenceAPPLE));
			}
			if (SuportedExt.Contains("glSetFenceNV"))
			{
				dgtk.OpenGL.internalGL.glSetFenceNV = (dgtk.OpenGL.delegatesGL.glSetFenceNV) InternalTool.GetGLMethodAdress("glSetFenceNV", typeof(dgtk.OpenGL.delegatesGL.glSetFenceNV));
			}
			if (SuportedExt.Contains("glSetFragmentShaderConstantATI"))
			{
				dgtk.OpenGL.internalGL.glSetFragmentShaderConstantATI = (dgtk.OpenGL.delegatesGL.glSetFragmentShaderConstantATI) InternalTool.GetGLMethodAdress("glSetFragmentShaderConstantATI", typeof(dgtk.OpenGL.delegatesGL.glSetFragmentShaderConstantATI));
			}
			if (SuportedExt.Contains("glSetInvariantEXT"))
			{
				dgtk.OpenGL.internalGL.glSetInvariantEXT = (dgtk.OpenGL.delegatesGL.glSetInvariantEXT) InternalTool.GetGLMethodAdress("glSetInvariantEXT", typeof(dgtk.OpenGL.delegatesGL.glSetInvariantEXT));
			}
			if (SuportedExt.Contains("glSetLocalConstantEXT"))
			{
				dgtk.OpenGL.internalGL.glSetLocalConstantEXT = (dgtk.OpenGL.delegatesGL.glSetLocalConstantEXT) InternalTool.GetGLMethodAdress("glSetLocalConstantEXT", typeof(dgtk.OpenGL.delegatesGL.glSetLocalConstantEXT));
			}
			if (SuportedExt.Contains("glSetMultisamplefvAMD"))
			{
				dgtk.OpenGL.internalGL.glSetMultisamplefvAMD = (dgtk.OpenGL.delegatesGL.glSetMultisamplefvAMD) InternalTool.GetGLMethodAdress("glSetMultisamplefvAMD", typeof(dgtk.OpenGL.delegatesGL.glSetMultisamplefvAMD));
			}
			if (SuportedExt.Contains("glShaderOp1EXT"))
			{
				dgtk.OpenGL.internalGL.glShaderOp1EXT = (dgtk.OpenGL.delegatesGL.glShaderOp1EXT) InternalTool.GetGLMethodAdress("glShaderOp1EXT", typeof(dgtk.OpenGL.delegatesGL.glShaderOp1EXT));
			}
			if (SuportedExt.Contains("glShaderOp2EXT"))
			{
				dgtk.OpenGL.internalGL.glShaderOp2EXT = (dgtk.OpenGL.delegatesGL.glShaderOp2EXT) InternalTool.GetGLMethodAdress("glShaderOp2EXT", typeof(dgtk.OpenGL.delegatesGL.glShaderOp2EXT));
			}
			if (SuportedExt.Contains("glShaderOp3EXT"))
			{
				dgtk.OpenGL.internalGL.glShaderOp3EXT = (dgtk.OpenGL.delegatesGL.glShaderOp3EXT) InternalTool.GetGLMethodAdress("glShaderOp3EXT", typeof(dgtk.OpenGL.delegatesGL.glShaderOp3EXT));
			}
			if (SuportedExt.Contains("glShaderSourceARB"))
			{
				dgtk.OpenGL.internalGL.glShaderSourceARB = (dgtk.OpenGL.delegatesGL.glShaderSourceARB) InternalTool.GetGLMethodAdress("glShaderSourceARB", typeof(dgtk.OpenGL.delegatesGL.glShaderSourceARB));
			}
			if (SuportedExt.Contains("glShadingRateImageBarrierNV"))
			{
				dgtk.OpenGL.internalGL.glShadingRateImageBarrierNV = (dgtk.OpenGL.delegatesGL.glShadingRateImageBarrierNV) InternalTool.GetGLMethodAdress("glShadingRateImageBarrierNV", typeof(dgtk.OpenGL.delegatesGL.glShadingRateImageBarrierNV));
			}
			if (SuportedExt.Contains("glShadingRateImagePaletteNV"))
			{
				dgtk.OpenGL.internalGL.glShadingRateImagePaletteNV = (dgtk.OpenGL.delegatesGL.glShadingRateImagePaletteNV) InternalTool.GetGLMethodAdress("glShadingRateImagePaletteNV", typeof(dgtk.OpenGL.delegatesGL.glShadingRateImagePaletteNV));
			}
			if (SuportedExt.Contains("glShadingRateQCOM"))
			{
				dgtk.OpenGL.internalGL.glShadingRateQCOM = (dgtk.OpenGL.delegatesGL.glShadingRateQCOM) InternalTool.GetGLMethodAdress("glShadingRateQCOM", typeof(dgtk.OpenGL.delegatesGL.glShadingRateQCOM));
			}
			if (SuportedExt.Contains("glShadingRateSampleOrderCustomNV"))
			{
				dgtk.OpenGL.internalGL.glShadingRateSampleOrderCustomNV = (dgtk.OpenGL.delegatesGL.glShadingRateSampleOrderCustomNV) InternalTool.GetGLMethodAdress("glShadingRateSampleOrderCustomNV", typeof(dgtk.OpenGL.delegatesGL.glShadingRateSampleOrderCustomNV));
			}
			if (SuportedExt.Contains("glShadingRateSampleOrderNV"))
			{
				dgtk.OpenGL.internalGL.glShadingRateSampleOrderNV = (dgtk.OpenGL.delegatesGL.glShadingRateSampleOrderNV) InternalTool.GetGLMethodAdress("glShadingRateSampleOrderNV", typeof(dgtk.OpenGL.delegatesGL.glShadingRateSampleOrderNV));
			}
			if (SuportedExt.Contains("glSharpenTexFuncSGIS"))
			{
				dgtk.OpenGL.internalGL.glSharpenTexFuncSGIS = (dgtk.OpenGL.delegatesGL.glSharpenTexFuncSGIS) InternalTool.GetGLMethodAdress("glSharpenTexFuncSGIS", typeof(dgtk.OpenGL.delegatesGL.glSharpenTexFuncSGIS));
			}
			if (SuportedExt.Contains("glSignalSemaphoreEXT"))
			{
				dgtk.OpenGL.internalGL.glSignalSemaphoreEXT = (dgtk.OpenGL.delegatesGL.glSignalSemaphoreEXT) InternalTool.GetGLMethodAdress("glSignalSemaphoreEXT", typeof(dgtk.OpenGL.delegatesGL.glSignalSemaphoreEXT));
			}
			if (SuportedExt.Contains("glSignalSemaphoreui64NVX"))
			{
				dgtk.OpenGL.internalGL.glSignalSemaphoreui64NVX = (dgtk.OpenGL.delegatesGL.glSignalSemaphoreui64NVX) InternalTool.GetGLMethodAdress("glSignalSemaphoreui64NVX", typeof(dgtk.OpenGL.delegatesGL.glSignalSemaphoreui64NVX));
			}
			if (SuportedExt.Contains("glSignalVkFenceNV"))
			{
				dgtk.OpenGL.internalGL.glSignalVkFenceNV = (dgtk.OpenGL.delegatesGL.glSignalVkFenceNV) InternalTool.GetGLMethodAdress("glSignalVkFenceNV", typeof(dgtk.OpenGL.delegatesGL.glSignalVkFenceNV));
			}
			if (SuportedExt.Contains("glSignalVkSemaphoreNV"))
			{
				dgtk.OpenGL.internalGL.glSignalVkSemaphoreNV = (dgtk.OpenGL.delegatesGL.glSignalVkSemaphoreNV) InternalTool.GetGLMethodAdress("glSignalVkSemaphoreNV", typeof(dgtk.OpenGL.delegatesGL.glSignalVkSemaphoreNV));
			}
			if (SuportedExt.Contains("glSpecializeShaderARB"))
			{
				dgtk.OpenGL.internalGL.glSpecializeShaderARB = (dgtk.OpenGL.delegatesGL.glSpecializeShaderARB) InternalTool.GetGLMethodAdress("glSpecializeShaderARB", typeof(dgtk.OpenGL.delegatesGL.glSpecializeShaderARB));
			}
			if (SuportedExt.Contains("glSpriteParameterfSGIX"))
			{
				dgtk.OpenGL.internalGL.glSpriteParameterfSGIX = (dgtk.OpenGL.delegatesGL.glSpriteParameterfSGIX) InternalTool.GetGLMethodAdress("glSpriteParameterfSGIX", typeof(dgtk.OpenGL.delegatesGL.glSpriteParameterfSGIX));
			}
			if (SuportedExt.Contains("glSpriteParameterfvSGIX"))
			{
				dgtk.OpenGL.internalGL.glSpriteParameterfvSGIX = (dgtk.OpenGL.delegatesGL.glSpriteParameterfvSGIX) InternalTool.GetGLMethodAdress("glSpriteParameterfvSGIX", typeof(dgtk.OpenGL.delegatesGL.glSpriteParameterfvSGIX));
			}
			if (SuportedExt.Contains("glSpriteParameteriSGIX"))
			{
				dgtk.OpenGL.internalGL.glSpriteParameteriSGIX = (dgtk.OpenGL.delegatesGL.glSpriteParameteriSGIX) InternalTool.GetGLMethodAdress("glSpriteParameteriSGIX", typeof(dgtk.OpenGL.delegatesGL.glSpriteParameteriSGIX));
			}
			if (SuportedExt.Contains("glSpriteParameterivSGIX"))
			{
				dgtk.OpenGL.internalGL.glSpriteParameterivSGIX = (dgtk.OpenGL.delegatesGL.glSpriteParameterivSGIX) InternalTool.GetGLMethodAdress("glSpriteParameterivSGIX", typeof(dgtk.OpenGL.delegatesGL.glSpriteParameterivSGIX));
			}
			if (SuportedExt.Contains("glStartInstrumentsSGIX"))
			{
				dgtk.OpenGL.internalGL.glStartInstrumentsSGIX = (dgtk.OpenGL.delegatesGL.glStartInstrumentsSGIX) InternalTool.GetGLMethodAdress("glStartInstrumentsSGIX", typeof(dgtk.OpenGL.delegatesGL.glStartInstrumentsSGIX));
			}
			if (SuportedExt.Contains("glStartTilingQCOM"))
			{
				dgtk.OpenGL.internalGL.glStartTilingQCOM = (dgtk.OpenGL.delegatesGL.glStartTilingQCOM) InternalTool.GetGLMethodAdress("glStartTilingQCOM", typeof(dgtk.OpenGL.delegatesGL.glStartTilingQCOM));
			}
			if (SuportedExt.Contains("glStateCaptureNV"))
			{
				dgtk.OpenGL.internalGL.glStateCaptureNV = (dgtk.OpenGL.delegatesGL.glStateCaptureNV) InternalTool.GetGLMethodAdress("glStateCaptureNV", typeof(dgtk.OpenGL.delegatesGL.glStateCaptureNV));
			}
			if (SuportedExt.Contains("glStencilClearTagEXT"))
			{
				dgtk.OpenGL.internalGL.glStencilClearTagEXT = (dgtk.OpenGL.delegatesGL.glStencilClearTagEXT) InternalTool.GetGLMethodAdress("glStencilClearTagEXT", typeof(dgtk.OpenGL.delegatesGL.glStencilClearTagEXT));
			}
			if (SuportedExt.Contains("glStencilFillPathInstancedNV"))
			{
				dgtk.OpenGL.internalGL.glStencilFillPathInstancedNV = (dgtk.OpenGL.delegatesGL.glStencilFillPathInstancedNV) InternalTool.GetGLMethodAdress("glStencilFillPathInstancedNV", typeof(dgtk.OpenGL.delegatesGL.glStencilFillPathInstancedNV));
			}
			if (SuportedExt.Contains("glStencilFillPathNV"))
			{
				dgtk.OpenGL.internalGL.glStencilFillPathNV = (dgtk.OpenGL.delegatesGL.glStencilFillPathNV) InternalTool.GetGLMethodAdress("glStencilFillPathNV", typeof(dgtk.OpenGL.delegatesGL.glStencilFillPathNV));
			}
			if (SuportedExt.Contains("glStencilFuncSeparateATI"))
			{
				dgtk.OpenGL.internalGL.glStencilFuncSeparateATI = (dgtk.OpenGL.delegatesGL.glStencilFuncSeparateATI) InternalTool.GetGLMethodAdress("glStencilFuncSeparateATI", typeof(dgtk.OpenGL.delegatesGL.glStencilFuncSeparateATI));
			}
			if (SuportedExt.Contains("glStencilOpSeparateATI"))
			{
				dgtk.OpenGL.internalGL.glStencilOpSeparateATI = (dgtk.OpenGL.delegatesGL.glStencilOpSeparateATI) InternalTool.GetGLMethodAdress("glStencilOpSeparateATI", typeof(dgtk.OpenGL.delegatesGL.glStencilOpSeparateATI));
			}
			if (SuportedExt.Contains("glStencilOpValueAMD"))
			{
				dgtk.OpenGL.internalGL.glStencilOpValueAMD = (dgtk.OpenGL.delegatesGL.glStencilOpValueAMD) InternalTool.GetGLMethodAdress("glStencilOpValueAMD", typeof(dgtk.OpenGL.delegatesGL.glStencilOpValueAMD));
			}
			if (SuportedExt.Contains("glStencilStrokePathInstancedNV"))
			{
				dgtk.OpenGL.internalGL.glStencilStrokePathInstancedNV = (dgtk.OpenGL.delegatesGL.glStencilStrokePathInstancedNV) InternalTool.GetGLMethodAdress("glStencilStrokePathInstancedNV", typeof(dgtk.OpenGL.delegatesGL.glStencilStrokePathInstancedNV));
			}
			if (SuportedExt.Contains("glStencilStrokePathNV"))
			{
				dgtk.OpenGL.internalGL.glStencilStrokePathNV = (dgtk.OpenGL.delegatesGL.glStencilStrokePathNV) InternalTool.GetGLMethodAdress("glStencilStrokePathNV", typeof(dgtk.OpenGL.delegatesGL.glStencilStrokePathNV));
			}
			if (SuportedExt.Contains("glStencilThenCoverFillPathInstancedNV"))
			{
				dgtk.OpenGL.internalGL.glStencilThenCoverFillPathInstancedNV = (dgtk.OpenGL.delegatesGL.glStencilThenCoverFillPathInstancedNV) InternalTool.GetGLMethodAdress("glStencilThenCoverFillPathInstancedNV", typeof(dgtk.OpenGL.delegatesGL.glStencilThenCoverFillPathInstancedNV));
			}
			if (SuportedExt.Contains("glStencilThenCoverFillPathNV"))
			{
				dgtk.OpenGL.internalGL.glStencilThenCoverFillPathNV = (dgtk.OpenGL.delegatesGL.glStencilThenCoverFillPathNV) InternalTool.GetGLMethodAdress("glStencilThenCoverFillPathNV", typeof(dgtk.OpenGL.delegatesGL.glStencilThenCoverFillPathNV));
			}
			if (SuportedExt.Contains("glStencilThenCoverStrokePathInstancedNV"))
			{
				dgtk.OpenGL.internalGL.glStencilThenCoverStrokePathInstancedNV = (dgtk.OpenGL.delegatesGL.glStencilThenCoverStrokePathInstancedNV) InternalTool.GetGLMethodAdress("glStencilThenCoverStrokePathInstancedNV", typeof(dgtk.OpenGL.delegatesGL.glStencilThenCoverStrokePathInstancedNV));
			}
			if (SuportedExt.Contains("glStencilThenCoverStrokePathNV"))
			{
				dgtk.OpenGL.internalGL.glStencilThenCoverStrokePathNV = (dgtk.OpenGL.delegatesGL.glStencilThenCoverStrokePathNV) InternalTool.GetGLMethodAdress("glStencilThenCoverStrokePathNV", typeof(dgtk.OpenGL.delegatesGL.glStencilThenCoverStrokePathNV));
			}
			if (SuportedExt.Contains("glStopInstrumentsSGIX"))
			{
				dgtk.OpenGL.internalGL.glStopInstrumentsSGIX = (dgtk.OpenGL.delegatesGL.glStopInstrumentsSGIX) InternalTool.GetGLMethodAdress("glStopInstrumentsSGIX", typeof(dgtk.OpenGL.delegatesGL.glStopInstrumentsSGIX));
			}
			if (SuportedExt.Contains("glStringMarkerGREMEDY"))
			{
				dgtk.OpenGL.internalGL.glStringMarkerGREMEDY = (dgtk.OpenGL.delegatesGL.glStringMarkerGREMEDY) InternalTool.GetGLMethodAdress("glStringMarkerGREMEDY", typeof(dgtk.OpenGL.delegatesGL.glStringMarkerGREMEDY));
			}
			if (SuportedExt.Contains("glSubpixelPrecisionBiasNV"))
			{
				dgtk.OpenGL.internalGL.glSubpixelPrecisionBiasNV = (dgtk.OpenGL.delegatesGL.glSubpixelPrecisionBiasNV) InternalTool.GetGLMethodAdress("glSubpixelPrecisionBiasNV", typeof(dgtk.OpenGL.delegatesGL.glSubpixelPrecisionBiasNV));
			}
			if (SuportedExt.Contains("glSwizzleEXT"))
			{
				dgtk.OpenGL.internalGL.glSwizzleEXT = (dgtk.OpenGL.delegatesGL.glSwizzleEXT) InternalTool.GetGLMethodAdress("glSwizzleEXT", typeof(dgtk.OpenGL.delegatesGL.glSwizzleEXT));
			}
			if (SuportedExt.Contains("glSyncTextureINTEL"))
			{
				dgtk.OpenGL.internalGL.glSyncTextureINTEL = (dgtk.OpenGL.delegatesGL.glSyncTextureINTEL) InternalTool.GetGLMethodAdress("glSyncTextureINTEL", typeof(dgtk.OpenGL.delegatesGL.glSyncTextureINTEL));
			}
			#endregion

			#region T:

			if (SuportedExt.Contains("glTagSampleBufferSGIX"))
			{
				dgtk.OpenGL.internalGL.glTagSampleBufferSGIX = (dgtk.OpenGL.delegatesGL.glTagSampleBufferSGIX) InternalTool.GetGLMethodAdress("glTagSampleBufferSGIX", typeof(dgtk.OpenGL.delegatesGL.glTagSampleBufferSGIX));
			}
			if (SuportedExt.Contains("glTangent3bEXT"))
			{
				dgtk.OpenGL.internalGL.glTangent3bEXT = (dgtk.OpenGL.delegatesGL.glTangent3bEXT) InternalTool.GetGLMethodAdress("glTangent3bEXT", typeof(dgtk.OpenGL.delegatesGL.glTangent3bEXT));
			}
			if (SuportedExt.Contains("glTangent3bvEXT"))
			{
				dgtk.OpenGL.internalGL.glTangent3bvEXT = (dgtk.OpenGL.delegatesGL.glTangent3bvEXT) InternalTool.GetGLMethodAdress("glTangent3bvEXT", typeof(dgtk.OpenGL.delegatesGL.glTangent3bvEXT));
			}
			if (SuportedExt.Contains("glTangent3dEXT"))
			{
				dgtk.OpenGL.internalGL.glTangent3dEXT = (dgtk.OpenGL.delegatesGL.glTangent3dEXT) InternalTool.GetGLMethodAdress("glTangent3dEXT", typeof(dgtk.OpenGL.delegatesGL.glTangent3dEXT));
			}
			if (SuportedExt.Contains("glTangent3dvEXT"))
			{
				dgtk.OpenGL.internalGL.glTangent3dvEXT = (dgtk.OpenGL.delegatesGL.glTangent3dvEXT) InternalTool.GetGLMethodAdress("glTangent3dvEXT", typeof(dgtk.OpenGL.delegatesGL.glTangent3dvEXT));
			}
			if (SuportedExt.Contains("glTangent3fEXT"))
			{
				dgtk.OpenGL.internalGL.glTangent3fEXT = (dgtk.OpenGL.delegatesGL.glTangent3fEXT) InternalTool.GetGLMethodAdress("glTangent3fEXT", typeof(dgtk.OpenGL.delegatesGL.glTangent3fEXT));
			}
			if (SuportedExt.Contains("glTangent3fvEXT"))
			{
				dgtk.OpenGL.internalGL.glTangent3fvEXT = (dgtk.OpenGL.delegatesGL.glTangent3fvEXT) InternalTool.GetGLMethodAdress("glTangent3fvEXT", typeof(dgtk.OpenGL.delegatesGL.glTangent3fvEXT));
			}
			if (SuportedExt.Contains("glTangent3iEXT"))
			{
				dgtk.OpenGL.internalGL.glTangent3iEXT = (dgtk.OpenGL.delegatesGL.glTangent3iEXT) InternalTool.GetGLMethodAdress("glTangent3iEXT", typeof(dgtk.OpenGL.delegatesGL.glTangent3iEXT));
			}
			if (SuportedExt.Contains("glTangent3ivEXT"))
			{
				dgtk.OpenGL.internalGL.glTangent3ivEXT = (dgtk.OpenGL.delegatesGL.glTangent3ivEXT) InternalTool.GetGLMethodAdress("glTangent3ivEXT", typeof(dgtk.OpenGL.delegatesGL.glTangent3ivEXT));
			}
			if (SuportedExt.Contains("glTangent3sEXT"))
			{
				dgtk.OpenGL.internalGL.glTangent3sEXT = (dgtk.OpenGL.delegatesGL.glTangent3sEXT) InternalTool.GetGLMethodAdress("glTangent3sEXT", typeof(dgtk.OpenGL.delegatesGL.glTangent3sEXT));
			}
			if (SuportedExt.Contains("glTangent3svEXT"))
			{
				dgtk.OpenGL.internalGL.glTangent3svEXT = (dgtk.OpenGL.delegatesGL.glTangent3svEXT) InternalTool.GetGLMethodAdress("glTangent3svEXT", typeof(dgtk.OpenGL.delegatesGL.glTangent3svEXT));
			}
			if (SuportedExt.Contains("glTangentPointerEXT"))
			{
				dgtk.OpenGL.internalGL.glTangentPointerEXT = (dgtk.OpenGL.delegatesGL.glTangentPointerEXT) InternalTool.GetGLMethodAdress("glTangentPointerEXT", typeof(dgtk.OpenGL.delegatesGL.glTangentPointerEXT));
			}
			if (SuportedExt.Contains("glTbufferMask3DFX"))
			{
				dgtk.OpenGL.internalGL.glTbufferMask3DFX = (dgtk.OpenGL.delegatesGL.glTbufferMask3DFX) InternalTool.GetGLMethodAdress("glTbufferMask3DFX", typeof(dgtk.OpenGL.delegatesGL.glTbufferMask3DFX));
			}
			if (SuportedExt.Contains("glTessellationFactorAMD"))
			{
				dgtk.OpenGL.internalGL.glTessellationFactorAMD = (dgtk.OpenGL.delegatesGL.glTessellationFactorAMD) InternalTool.GetGLMethodAdress("glTessellationFactorAMD", typeof(dgtk.OpenGL.delegatesGL.glTessellationFactorAMD));
			}
			if (SuportedExt.Contains("glTessellationModeAMD"))
			{
				dgtk.OpenGL.internalGL.glTessellationModeAMD = (dgtk.OpenGL.delegatesGL.glTessellationModeAMD) InternalTool.GetGLMethodAdress("glTessellationModeAMD", typeof(dgtk.OpenGL.delegatesGL.glTessellationModeAMD));
			}
			if (SuportedExt.Contains("glTestFenceAPPLE"))
			{
				dgtk.OpenGL.internalGL.glTestFenceAPPLE = (dgtk.OpenGL.delegatesGL.glTestFenceAPPLE) InternalTool.GetGLMethodAdress("glTestFenceAPPLE", typeof(dgtk.OpenGL.delegatesGL.glTestFenceAPPLE));
			}
			if (SuportedExt.Contains("glTestFenceNV"))
			{
				dgtk.OpenGL.internalGL.glTestFenceNV = (dgtk.OpenGL.delegatesGL.glTestFenceNV) InternalTool.GetGLMethodAdress("glTestFenceNV", typeof(dgtk.OpenGL.delegatesGL.glTestFenceNV));
			}
			if (SuportedExt.Contains("glTestObjectAPPLE"))
			{
				dgtk.OpenGL.internalGL.glTestObjectAPPLE = (dgtk.OpenGL.delegatesGL.glTestObjectAPPLE) InternalTool.GetGLMethodAdress("glTestObjectAPPLE", typeof(dgtk.OpenGL.delegatesGL.glTestObjectAPPLE));
			}
			if (SuportedExt.Contains("glTexAttachMemoryNV"))
			{
				dgtk.OpenGL.internalGL.glTexAttachMemoryNV = (dgtk.OpenGL.delegatesGL.glTexAttachMemoryNV) InternalTool.GetGLMethodAdress("glTexAttachMemoryNV", typeof(dgtk.OpenGL.delegatesGL.glTexAttachMemoryNV));
			}
			if (SuportedExt.Contains("glTexBufferARB"))
			{
				dgtk.OpenGL.internalGL.glTexBufferARB = (dgtk.OpenGL.delegatesGL.glTexBufferARB) InternalTool.GetGLMethodAdress("glTexBufferARB", typeof(dgtk.OpenGL.delegatesGL.glTexBufferARB));
			}
			if (SuportedExt.Contains("glTexBufferEXT"))
			{
				dgtk.OpenGL.internalGL.glTexBufferEXT = (dgtk.OpenGL.delegatesGL.glTexBufferEXT) InternalTool.GetGLMethodAdress("glTexBufferEXT", typeof(dgtk.OpenGL.delegatesGL.glTexBufferEXT));
			}
			if (SuportedExt.Contains("glTexBufferOES"))
			{
				dgtk.OpenGL.internalGL.glTexBufferOES = (dgtk.OpenGL.delegatesGL.glTexBufferOES) InternalTool.GetGLMethodAdress("glTexBufferOES", typeof(dgtk.OpenGL.delegatesGL.glTexBufferOES));
			}
			if (SuportedExt.Contains("glTexBufferRangeEXT"))
			{
				dgtk.OpenGL.internalGL.glTexBufferRangeEXT = (dgtk.OpenGL.delegatesGL.glTexBufferRangeEXT) InternalTool.GetGLMethodAdress("glTexBufferRangeEXT", typeof(dgtk.OpenGL.delegatesGL.glTexBufferRangeEXT));
			}
			if (SuportedExt.Contains("glTexBufferRangeOES"))
			{
				dgtk.OpenGL.internalGL.glTexBufferRangeOES = (dgtk.OpenGL.delegatesGL.glTexBufferRangeOES) InternalTool.GetGLMethodAdress("glTexBufferRangeOES", typeof(dgtk.OpenGL.delegatesGL.glTexBufferRangeOES));
			}
			if (SuportedExt.Contains("glTexBumpParameterfvATI"))
			{
				dgtk.OpenGL.internalGL.glTexBumpParameterfvATI = (dgtk.OpenGL.delegatesGL.glTexBumpParameterfvATI) InternalTool.GetGLMethodAdress("glTexBumpParameterfvATI", typeof(dgtk.OpenGL.delegatesGL.glTexBumpParameterfvATI));
			}
			if (SuportedExt.Contains("glTexBumpParameterivATI"))
			{
				dgtk.OpenGL.internalGL.glTexBumpParameterivATI = (dgtk.OpenGL.delegatesGL.glTexBumpParameterivATI) InternalTool.GetGLMethodAdress("glTexBumpParameterivATI", typeof(dgtk.OpenGL.delegatesGL.glTexBumpParameterivATI));
			}
			if (SuportedExt.Contains("glTexCoord1bOES"))
			{
				dgtk.OpenGL.internalGL.glTexCoord1bOES = (dgtk.OpenGL.delegatesGL.glTexCoord1bOES) InternalTool.GetGLMethodAdress("glTexCoord1bOES", typeof(dgtk.OpenGL.delegatesGL.glTexCoord1bOES));
			}
			if (SuportedExt.Contains("glTexCoord1bvOES"))
			{
				dgtk.OpenGL.internalGL.glTexCoord1bvOES = (dgtk.OpenGL.delegatesGL.glTexCoord1bvOES) InternalTool.GetGLMethodAdress("glTexCoord1bvOES", typeof(dgtk.OpenGL.delegatesGL.glTexCoord1bvOES));
			}
			if (SuportedExt.Contains("glTexCoord1hNV"))
			{
				dgtk.OpenGL.internalGL.glTexCoord1hNV = (dgtk.OpenGL.delegatesGL.glTexCoord1hNV) InternalTool.GetGLMethodAdress("glTexCoord1hNV", typeof(dgtk.OpenGL.delegatesGL.glTexCoord1hNV));
			}
			if (SuportedExt.Contains("glTexCoord1hvNV"))
			{
				dgtk.OpenGL.internalGL.glTexCoord1hvNV = (dgtk.OpenGL.delegatesGL.glTexCoord1hvNV) InternalTool.GetGLMethodAdress("glTexCoord1hvNV", typeof(dgtk.OpenGL.delegatesGL.glTexCoord1hvNV));
			}
			if (SuportedExt.Contains("glTexCoord1xOES"))
			{
				dgtk.OpenGL.internalGL.glTexCoord1xOES = (dgtk.OpenGL.delegatesGL.glTexCoord1xOES) InternalTool.GetGLMethodAdress("glTexCoord1xOES", typeof(dgtk.OpenGL.delegatesGL.glTexCoord1xOES));
			}
			if (SuportedExt.Contains("glTexCoord1xvOES"))
			{
				dgtk.OpenGL.internalGL.glTexCoord1xvOES = (dgtk.OpenGL.delegatesGL.glTexCoord1xvOES) InternalTool.GetGLMethodAdress("glTexCoord1xvOES", typeof(dgtk.OpenGL.delegatesGL.glTexCoord1xvOES));
			}
			if (SuportedExt.Contains("glTexCoord2bOES"))
			{
				dgtk.OpenGL.internalGL.glTexCoord2bOES = (dgtk.OpenGL.delegatesGL.glTexCoord2bOES) InternalTool.GetGLMethodAdress("glTexCoord2bOES", typeof(dgtk.OpenGL.delegatesGL.glTexCoord2bOES));
			}
			if (SuportedExt.Contains("glTexCoord2bvOES"))
			{
				dgtk.OpenGL.internalGL.glTexCoord2bvOES = (dgtk.OpenGL.delegatesGL.glTexCoord2bvOES) InternalTool.GetGLMethodAdress("glTexCoord2bvOES", typeof(dgtk.OpenGL.delegatesGL.glTexCoord2bvOES));
			}
			if (SuportedExt.Contains("glTexCoord2fColor3fVertex3fSUN"))
			{
				dgtk.OpenGL.internalGL.glTexCoord2fColor3fVertex3fSUN = (dgtk.OpenGL.delegatesGL.glTexCoord2fColor3fVertex3fSUN) InternalTool.GetGLMethodAdress("glTexCoord2fColor3fVertex3fSUN", typeof(dgtk.OpenGL.delegatesGL.glTexCoord2fColor3fVertex3fSUN));
			}
			if (SuportedExt.Contains("glTexCoord2fColor3fVertex3fvSUN"))
			{
				dgtk.OpenGL.internalGL.glTexCoord2fColor3fVertex3fvSUN = (dgtk.OpenGL.delegatesGL.glTexCoord2fColor3fVertex3fvSUN) InternalTool.GetGLMethodAdress("glTexCoord2fColor3fVertex3fvSUN", typeof(dgtk.OpenGL.delegatesGL.glTexCoord2fColor3fVertex3fvSUN));
			}
			if (SuportedExt.Contains("glTexCoord2fColor4fNormal3fVertex3fSUN"))
			{
				dgtk.OpenGL.internalGL.glTexCoord2fColor4fNormal3fVertex3fSUN = (dgtk.OpenGL.delegatesGL.glTexCoord2fColor4fNormal3fVertex3fSUN) InternalTool.GetGLMethodAdress("glTexCoord2fColor4fNormal3fVertex3fSUN", typeof(dgtk.OpenGL.delegatesGL.glTexCoord2fColor4fNormal3fVertex3fSUN));
			}
			if (SuportedExt.Contains("glTexCoord2fColor4fNormal3fVertex3fvSUN"))
			{
				dgtk.OpenGL.internalGL.glTexCoord2fColor4fNormal3fVertex3fvSUN = (dgtk.OpenGL.delegatesGL.glTexCoord2fColor4fNormal3fVertex3fvSUN) InternalTool.GetGLMethodAdress("glTexCoord2fColor4fNormal3fVertex3fvSUN", typeof(dgtk.OpenGL.delegatesGL.glTexCoord2fColor4fNormal3fVertex3fvSUN));
			}
			if (SuportedExt.Contains("glTexCoord2fColor4ubVertex3fSUN"))
			{
				dgtk.OpenGL.internalGL.glTexCoord2fColor4ubVertex3fSUN = (dgtk.OpenGL.delegatesGL.glTexCoord2fColor4ubVertex3fSUN) InternalTool.GetGLMethodAdress("glTexCoord2fColor4ubVertex3fSUN", typeof(dgtk.OpenGL.delegatesGL.glTexCoord2fColor4ubVertex3fSUN));
			}
			if (SuportedExt.Contains("glTexCoord2fColor4ubVertex3fvSUN"))
			{
				dgtk.OpenGL.internalGL.glTexCoord2fColor4ubVertex3fvSUN = (dgtk.OpenGL.delegatesGL.glTexCoord2fColor4ubVertex3fvSUN) InternalTool.GetGLMethodAdress("glTexCoord2fColor4ubVertex3fvSUN", typeof(dgtk.OpenGL.delegatesGL.glTexCoord2fColor4ubVertex3fvSUN));
			}
			if (SuportedExt.Contains("glTexCoord2fNormal3fVertex3fSUN"))
			{
				dgtk.OpenGL.internalGL.glTexCoord2fNormal3fVertex3fSUN = (dgtk.OpenGL.delegatesGL.glTexCoord2fNormal3fVertex3fSUN) InternalTool.GetGLMethodAdress("glTexCoord2fNormal3fVertex3fSUN", typeof(dgtk.OpenGL.delegatesGL.glTexCoord2fNormal3fVertex3fSUN));
			}
			if (SuportedExt.Contains("glTexCoord2fNormal3fVertex3fvSUN"))
			{
				dgtk.OpenGL.internalGL.glTexCoord2fNormal3fVertex3fvSUN = (dgtk.OpenGL.delegatesGL.glTexCoord2fNormal3fVertex3fvSUN) InternalTool.GetGLMethodAdress("glTexCoord2fNormal3fVertex3fvSUN", typeof(dgtk.OpenGL.delegatesGL.glTexCoord2fNormal3fVertex3fvSUN));
			}
			if (SuportedExt.Contains("glTexCoord2fVertex3fSUN"))
			{
				dgtk.OpenGL.internalGL.glTexCoord2fVertex3fSUN = (dgtk.OpenGL.delegatesGL.glTexCoord2fVertex3fSUN) InternalTool.GetGLMethodAdress("glTexCoord2fVertex3fSUN", typeof(dgtk.OpenGL.delegatesGL.glTexCoord2fVertex3fSUN));
			}
			if (SuportedExt.Contains("glTexCoord2fVertex3fvSUN"))
			{
				dgtk.OpenGL.internalGL.glTexCoord2fVertex3fvSUN = (dgtk.OpenGL.delegatesGL.glTexCoord2fVertex3fvSUN) InternalTool.GetGLMethodAdress("glTexCoord2fVertex3fvSUN", typeof(dgtk.OpenGL.delegatesGL.glTexCoord2fVertex3fvSUN));
			}
			if (SuportedExt.Contains("glTexCoord2hNV"))
			{
				dgtk.OpenGL.internalGL.glTexCoord2hNV = (dgtk.OpenGL.delegatesGL.glTexCoord2hNV) InternalTool.GetGLMethodAdress("glTexCoord2hNV", typeof(dgtk.OpenGL.delegatesGL.glTexCoord2hNV));
			}
			if (SuportedExt.Contains("glTexCoord2hvNV"))
			{
				dgtk.OpenGL.internalGL.glTexCoord2hvNV = (dgtk.OpenGL.delegatesGL.glTexCoord2hvNV) InternalTool.GetGLMethodAdress("glTexCoord2hvNV", typeof(dgtk.OpenGL.delegatesGL.glTexCoord2hvNV));
			}
			if (SuportedExt.Contains("glTexCoord2xOES"))
			{
				dgtk.OpenGL.internalGL.glTexCoord2xOES = (dgtk.OpenGL.delegatesGL.glTexCoord2xOES) InternalTool.GetGLMethodAdress("glTexCoord2xOES", typeof(dgtk.OpenGL.delegatesGL.glTexCoord2xOES));
			}
			if (SuportedExt.Contains("glTexCoord2xvOES"))
			{
				dgtk.OpenGL.internalGL.glTexCoord2xvOES = (dgtk.OpenGL.delegatesGL.glTexCoord2xvOES) InternalTool.GetGLMethodAdress("glTexCoord2xvOES", typeof(dgtk.OpenGL.delegatesGL.glTexCoord2xvOES));
			}
			if (SuportedExt.Contains("glTexCoord3bOES"))
			{
				dgtk.OpenGL.internalGL.glTexCoord3bOES = (dgtk.OpenGL.delegatesGL.glTexCoord3bOES) InternalTool.GetGLMethodAdress("glTexCoord3bOES", typeof(dgtk.OpenGL.delegatesGL.glTexCoord3bOES));
			}
			if (SuportedExt.Contains("glTexCoord3bvOES"))
			{
				dgtk.OpenGL.internalGL.glTexCoord3bvOES = (dgtk.OpenGL.delegatesGL.glTexCoord3bvOES) InternalTool.GetGLMethodAdress("glTexCoord3bvOES", typeof(dgtk.OpenGL.delegatesGL.glTexCoord3bvOES));
			}
			if (SuportedExt.Contains("glTexCoord3hNV"))
			{
				dgtk.OpenGL.internalGL.glTexCoord3hNV = (dgtk.OpenGL.delegatesGL.glTexCoord3hNV) InternalTool.GetGLMethodAdress("glTexCoord3hNV", typeof(dgtk.OpenGL.delegatesGL.glTexCoord3hNV));
			}
			if (SuportedExt.Contains("glTexCoord3hvNV"))
			{
				dgtk.OpenGL.internalGL.glTexCoord3hvNV = (dgtk.OpenGL.delegatesGL.glTexCoord3hvNV) InternalTool.GetGLMethodAdress("glTexCoord3hvNV", typeof(dgtk.OpenGL.delegatesGL.glTexCoord3hvNV));
			}
			if (SuportedExt.Contains("glTexCoord3xOES"))
			{
				dgtk.OpenGL.internalGL.glTexCoord3xOES = (dgtk.OpenGL.delegatesGL.glTexCoord3xOES) InternalTool.GetGLMethodAdress("glTexCoord3xOES", typeof(dgtk.OpenGL.delegatesGL.glTexCoord3xOES));
			}
			if (SuportedExt.Contains("glTexCoord3xvOES"))
			{
				dgtk.OpenGL.internalGL.glTexCoord3xvOES = (dgtk.OpenGL.delegatesGL.glTexCoord3xvOES) InternalTool.GetGLMethodAdress("glTexCoord3xvOES", typeof(dgtk.OpenGL.delegatesGL.glTexCoord3xvOES));
			}
			if (SuportedExt.Contains("glTexCoord4bOES"))
			{
				dgtk.OpenGL.internalGL.glTexCoord4bOES = (dgtk.OpenGL.delegatesGL.glTexCoord4bOES) InternalTool.GetGLMethodAdress("glTexCoord4bOES", typeof(dgtk.OpenGL.delegatesGL.glTexCoord4bOES));
			}
			if (SuportedExt.Contains("glTexCoord4bvOES"))
			{
				dgtk.OpenGL.internalGL.glTexCoord4bvOES = (dgtk.OpenGL.delegatesGL.glTexCoord4bvOES) InternalTool.GetGLMethodAdress("glTexCoord4bvOES", typeof(dgtk.OpenGL.delegatesGL.glTexCoord4bvOES));
			}
			if (SuportedExt.Contains("glTexCoord4fColor4fNormal3fVertex4fSUN"))
			{
				dgtk.OpenGL.internalGL.glTexCoord4fColor4fNormal3fVertex4fSUN = (dgtk.OpenGL.delegatesGL.glTexCoord4fColor4fNormal3fVertex4fSUN) InternalTool.GetGLMethodAdress("glTexCoord4fColor4fNormal3fVertex4fSUN", typeof(dgtk.OpenGL.delegatesGL.glTexCoord4fColor4fNormal3fVertex4fSUN));
			}
			if (SuportedExt.Contains("glTexCoord4fColor4fNormal3fVertex4fvSUN"))
			{
				dgtk.OpenGL.internalGL.glTexCoord4fColor4fNormal3fVertex4fvSUN = (dgtk.OpenGL.delegatesGL.glTexCoord4fColor4fNormal3fVertex4fvSUN) InternalTool.GetGLMethodAdress("glTexCoord4fColor4fNormal3fVertex4fvSUN", typeof(dgtk.OpenGL.delegatesGL.glTexCoord4fColor4fNormal3fVertex4fvSUN));
			}
			if (SuportedExt.Contains("glTexCoord4fVertex4fSUN"))
			{
				dgtk.OpenGL.internalGL.glTexCoord4fVertex4fSUN = (dgtk.OpenGL.delegatesGL.glTexCoord4fVertex4fSUN) InternalTool.GetGLMethodAdress("glTexCoord4fVertex4fSUN", typeof(dgtk.OpenGL.delegatesGL.glTexCoord4fVertex4fSUN));
			}
			if (SuportedExt.Contains("glTexCoord4fVertex4fvSUN"))
			{
				dgtk.OpenGL.internalGL.glTexCoord4fVertex4fvSUN = (dgtk.OpenGL.delegatesGL.glTexCoord4fVertex4fvSUN) InternalTool.GetGLMethodAdress("glTexCoord4fVertex4fvSUN", typeof(dgtk.OpenGL.delegatesGL.glTexCoord4fVertex4fvSUN));
			}
			if (SuportedExt.Contains("glTexCoord4hNV"))
			{
				dgtk.OpenGL.internalGL.glTexCoord4hNV = (dgtk.OpenGL.delegatesGL.glTexCoord4hNV) InternalTool.GetGLMethodAdress("glTexCoord4hNV", typeof(dgtk.OpenGL.delegatesGL.glTexCoord4hNV));
			}
			if (SuportedExt.Contains("glTexCoord4hvNV"))
			{
				dgtk.OpenGL.internalGL.glTexCoord4hvNV = (dgtk.OpenGL.delegatesGL.glTexCoord4hvNV) InternalTool.GetGLMethodAdress("glTexCoord4hvNV", typeof(dgtk.OpenGL.delegatesGL.glTexCoord4hvNV));
			}
			if (SuportedExt.Contains("glTexCoord4xOES"))
			{
				dgtk.OpenGL.internalGL.glTexCoord4xOES = (dgtk.OpenGL.delegatesGL.glTexCoord4xOES) InternalTool.GetGLMethodAdress("glTexCoord4xOES", typeof(dgtk.OpenGL.delegatesGL.glTexCoord4xOES));
			}
			if (SuportedExt.Contains("glTexCoord4xvOES"))
			{
				dgtk.OpenGL.internalGL.glTexCoord4xvOES = (dgtk.OpenGL.delegatesGL.glTexCoord4xvOES) InternalTool.GetGLMethodAdress("glTexCoord4xvOES", typeof(dgtk.OpenGL.delegatesGL.glTexCoord4xvOES));
			}
			if (SuportedExt.Contains("glTexCoordFormatNV"))
			{
				dgtk.OpenGL.internalGL.glTexCoordFormatNV = (dgtk.OpenGL.delegatesGL.glTexCoordFormatNV) InternalTool.GetGLMethodAdress("glTexCoordFormatNV", typeof(dgtk.OpenGL.delegatesGL.glTexCoordFormatNV));
			}
			if (SuportedExt.Contains("glTexCoordPointerEXT"))
			{
				dgtk.OpenGL.internalGL.glTexCoordPointerEXT = (dgtk.OpenGL.delegatesGL.glTexCoordPointerEXT) InternalTool.GetGLMethodAdress("glTexCoordPointerEXT", typeof(dgtk.OpenGL.delegatesGL.glTexCoordPointerEXT));
			}
			if (SuportedExt.Contains("glTexCoordPointerListIBM"))
			{
				dgtk.OpenGL.internalGL.glTexCoordPointerListIBM = (dgtk.OpenGL.delegatesGL.glTexCoordPointerListIBM) InternalTool.GetGLMethodAdress("glTexCoordPointerListIBM", typeof(dgtk.OpenGL.delegatesGL.glTexCoordPointerListIBM));
			}
			if (SuportedExt.Contains("glTexCoordPointervINTEL"))
			{
				dgtk.OpenGL.internalGL.glTexCoordPointervINTEL = (dgtk.OpenGL.delegatesGL.glTexCoordPointervINTEL) InternalTool.GetGLMethodAdress("glTexCoordPointervINTEL", typeof(dgtk.OpenGL.delegatesGL.glTexCoordPointervINTEL));
			}
			if (SuportedExt.Contains("glTexEnvx"))
			{
				dgtk.OpenGL.internalGL.glTexEnvx = (dgtk.OpenGL.delegatesGL.glTexEnvx) InternalTool.GetGLMethodAdress("glTexEnvx", typeof(dgtk.OpenGL.delegatesGL.glTexEnvx));
			}
			if (SuportedExt.Contains("glTexEnvxOES"))
			{
				dgtk.OpenGL.internalGL.glTexEnvxOES = (dgtk.OpenGL.delegatesGL.glTexEnvxOES) InternalTool.GetGLMethodAdress("glTexEnvxOES", typeof(dgtk.OpenGL.delegatesGL.glTexEnvxOES));
			}
			if (SuportedExt.Contains("glTexEnvxv"))
			{
				dgtk.OpenGL.internalGL.glTexEnvxv = (dgtk.OpenGL.delegatesGL.glTexEnvxv) InternalTool.GetGLMethodAdress("glTexEnvxv", typeof(dgtk.OpenGL.delegatesGL.glTexEnvxv));
			}
			if (SuportedExt.Contains("glTexEnvxvOES"))
			{
				dgtk.OpenGL.internalGL.glTexEnvxvOES = (dgtk.OpenGL.delegatesGL.glTexEnvxvOES) InternalTool.GetGLMethodAdress("glTexEnvxvOES", typeof(dgtk.OpenGL.delegatesGL.glTexEnvxvOES));
			}
			if (SuportedExt.Contains("glTexEstimateMotionQCOM"))
			{
				dgtk.OpenGL.internalGL.glTexEstimateMotionQCOM = (dgtk.OpenGL.delegatesGL.glTexEstimateMotionQCOM) InternalTool.GetGLMethodAdress("glTexEstimateMotionQCOM", typeof(dgtk.OpenGL.delegatesGL.glTexEstimateMotionQCOM));
			}
			if (SuportedExt.Contains("glTexEstimateMotionRegionsQCOM"))
			{
				dgtk.OpenGL.internalGL.glTexEstimateMotionRegionsQCOM = (dgtk.OpenGL.delegatesGL.glTexEstimateMotionRegionsQCOM) InternalTool.GetGLMethodAdress("glTexEstimateMotionRegionsQCOM", typeof(dgtk.OpenGL.delegatesGL.glTexEstimateMotionRegionsQCOM));
			}
			if (SuportedExt.Contains("glTexFilterFuncSGIS"))
			{
				dgtk.OpenGL.internalGL.glTexFilterFuncSGIS = (dgtk.OpenGL.delegatesGL.glTexFilterFuncSGIS) InternalTool.GetGLMethodAdress("glTexFilterFuncSGIS", typeof(dgtk.OpenGL.delegatesGL.glTexFilterFuncSGIS));
			}
			if (SuportedExt.Contains("glTexGenfOES"))
			{
				dgtk.OpenGL.internalGL.glTexGenfOES = (dgtk.OpenGL.delegatesGL.glTexGenfOES) InternalTool.GetGLMethodAdress("glTexGenfOES", typeof(dgtk.OpenGL.delegatesGL.glTexGenfOES));
			}
			if (SuportedExt.Contains("glTexGenfvOES"))
			{
				dgtk.OpenGL.internalGL.glTexGenfvOES = (dgtk.OpenGL.delegatesGL.glTexGenfvOES) InternalTool.GetGLMethodAdress("glTexGenfvOES", typeof(dgtk.OpenGL.delegatesGL.glTexGenfvOES));
			}
			if (SuportedExt.Contains("glTexGeniOES"))
			{
				dgtk.OpenGL.internalGL.glTexGeniOES = (dgtk.OpenGL.delegatesGL.glTexGeniOES) InternalTool.GetGLMethodAdress("glTexGeniOES", typeof(dgtk.OpenGL.delegatesGL.glTexGeniOES));
			}
			if (SuportedExt.Contains("glTexGenivOES"))
			{
				dgtk.OpenGL.internalGL.glTexGenivOES = (dgtk.OpenGL.delegatesGL.glTexGenivOES) InternalTool.GetGLMethodAdress("glTexGenivOES", typeof(dgtk.OpenGL.delegatesGL.glTexGenivOES));
			}
			if (SuportedExt.Contains("glTexGenxOES"))
			{
				dgtk.OpenGL.internalGL.glTexGenxOES = (dgtk.OpenGL.delegatesGL.glTexGenxOES) InternalTool.GetGLMethodAdress("glTexGenxOES", typeof(dgtk.OpenGL.delegatesGL.glTexGenxOES));
			}
			if (SuportedExt.Contains("glTexGenxvOES"))
			{
				dgtk.OpenGL.internalGL.glTexGenxvOES = (dgtk.OpenGL.delegatesGL.glTexGenxvOES) InternalTool.GetGLMethodAdress("glTexGenxvOES", typeof(dgtk.OpenGL.delegatesGL.glTexGenxvOES));
			}
			if (SuportedExt.Contains("glTexImage2DMultisampleCoverageNV"))
			{
				dgtk.OpenGL.internalGL.glTexImage2DMultisampleCoverageNV = (dgtk.OpenGL.delegatesGL.glTexImage2DMultisampleCoverageNV) InternalTool.GetGLMethodAdress("glTexImage2DMultisampleCoverageNV", typeof(dgtk.OpenGL.delegatesGL.glTexImage2DMultisampleCoverageNV));
			}
			if (SuportedExt.Contains("glTexImage3DEXT"))
			{
				dgtk.OpenGL.internalGL.glTexImage3DEXT = (dgtk.OpenGL.delegatesGL.glTexImage3DEXT) InternalTool.GetGLMethodAdress("glTexImage3DEXT", typeof(dgtk.OpenGL.delegatesGL.glTexImage3DEXT));
			}
			if (SuportedExt.Contains("glTexImage3DMultisampleCoverageNV"))
			{
				dgtk.OpenGL.internalGL.glTexImage3DMultisampleCoverageNV = (dgtk.OpenGL.delegatesGL.glTexImage3DMultisampleCoverageNV) InternalTool.GetGLMethodAdress("glTexImage3DMultisampleCoverageNV", typeof(dgtk.OpenGL.delegatesGL.glTexImage3DMultisampleCoverageNV));
			}
			if (SuportedExt.Contains("glTexImage3DOES"))
			{
				dgtk.OpenGL.internalGL.glTexImage3DOES = (dgtk.OpenGL.delegatesGL.glTexImage3DOES) InternalTool.GetGLMethodAdress("glTexImage3DOES", typeof(dgtk.OpenGL.delegatesGL.glTexImage3DOES));
			}
			if (SuportedExt.Contains("glTexImage4DSGIS"))
			{
				dgtk.OpenGL.internalGL.glTexImage4DSGIS = (dgtk.OpenGL.delegatesGL.glTexImage4DSGIS) InternalTool.GetGLMethodAdress("glTexImage4DSGIS", typeof(dgtk.OpenGL.delegatesGL.glTexImage4DSGIS));
			}
			if (SuportedExt.Contains("glTexPageCommitmentARB"))
			{
				dgtk.OpenGL.internalGL.glTexPageCommitmentARB = (dgtk.OpenGL.delegatesGL.glTexPageCommitmentARB) InternalTool.GetGLMethodAdress("glTexPageCommitmentARB", typeof(dgtk.OpenGL.delegatesGL.glTexPageCommitmentARB));
			}
			if (SuportedExt.Contains("glTexPageCommitmentEXT"))
			{
				dgtk.OpenGL.internalGL.glTexPageCommitmentEXT = (dgtk.OpenGL.delegatesGL.glTexPageCommitmentEXT) InternalTool.GetGLMethodAdress("glTexPageCommitmentEXT", typeof(dgtk.OpenGL.delegatesGL.glTexPageCommitmentEXT));
			}
			if (SuportedExt.Contains("glTexPageCommitmentMemNV"))
			{
				dgtk.OpenGL.internalGL.glTexPageCommitmentMemNV = (dgtk.OpenGL.delegatesGL.glTexPageCommitmentMemNV) InternalTool.GetGLMethodAdress("glTexPageCommitmentMemNV", typeof(dgtk.OpenGL.delegatesGL.glTexPageCommitmentMemNV));
			}
			if (SuportedExt.Contains("glTexParameterIivEXT"))
			{
				dgtk.OpenGL.internalGL.glTexParameterIivEXT = (dgtk.OpenGL.delegatesGL.glTexParameterIivEXT) InternalTool.GetGLMethodAdress("glTexParameterIivEXT", typeof(dgtk.OpenGL.delegatesGL.glTexParameterIivEXT));
			}
			if (SuportedExt.Contains("glTexParameterIivOES"))
			{
				dgtk.OpenGL.internalGL.glTexParameterIivOES = (dgtk.OpenGL.delegatesGL.glTexParameterIivOES) InternalTool.GetGLMethodAdress("glTexParameterIivOES", typeof(dgtk.OpenGL.delegatesGL.glTexParameterIivOES));
			}
			if (SuportedExt.Contains("glTexParameterIuivEXT"))
			{
				dgtk.OpenGL.internalGL.glTexParameterIuivEXT = (dgtk.OpenGL.delegatesGL.glTexParameterIuivEXT) InternalTool.GetGLMethodAdress("glTexParameterIuivEXT", typeof(dgtk.OpenGL.delegatesGL.glTexParameterIuivEXT));
			}
			if (SuportedExt.Contains("glTexParameterIuivOES"))
			{
				dgtk.OpenGL.internalGL.glTexParameterIuivOES = (dgtk.OpenGL.delegatesGL.glTexParameterIuivOES) InternalTool.GetGLMethodAdress("glTexParameterIuivOES", typeof(dgtk.OpenGL.delegatesGL.glTexParameterIuivOES));
			}
			if (SuportedExt.Contains("glTexParameterx"))
			{
				dgtk.OpenGL.internalGL.glTexParameterx = (dgtk.OpenGL.delegatesGL.glTexParameterx) InternalTool.GetGLMethodAdress("glTexParameterx", typeof(dgtk.OpenGL.delegatesGL.glTexParameterx));
			}
			if (SuportedExt.Contains("glTexParameterxOES"))
			{
				dgtk.OpenGL.internalGL.glTexParameterxOES = (dgtk.OpenGL.delegatesGL.glTexParameterxOES) InternalTool.GetGLMethodAdress("glTexParameterxOES", typeof(dgtk.OpenGL.delegatesGL.glTexParameterxOES));
			}
			if (SuportedExt.Contains("glTexParameterxv"))
			{
				dgtk.OpenGL.internalGL.glTexParameterxv = (dgtk.OpenGL.delegatesGL.glTexParameterxv) InternalTool.GetGLMethodAdress("glTexParameterxv", typeof(dgtk.OpenGL.delegatesGL.glTexParameterxv));
			}
			if (SuportedExt.Contains("glTexParameterxvOES"))
			{
				dgtk.OpenGL.internalGL.glTexParameterxvOES = (dgtk.OpenGL.delegatesGL.glTexParameterxvOES) InternalTool.GetGLMethodAdress("glTexParameterxvOES", typeof(dgtk.OpenGL.delegatesGL.glTexParameterxvOES));
			}
			if (SuportedExt.Contains("glTexRenderbufferNV"))
			{
				dgtk.OpenGL.internalGL.glTexRenderbufferNV = (dgtk.OpenGL.delegatesGL.glTexRenderbufferNV) InternalTool.GetGLMethodAdress("glTexRenderbufferNV", typeof(dgtk.OpenGL.delegatesGL.glTexRenderbufferNV));
			}
			if (SuportedExt.Contains("glTexStorage1DEXT"))
			{
				dgtk.OpenGL.internalGL.glTexStorage1DEXT = (dgtk.OpenGL.delegatesGL.glTexStorage1DEXT) InternalTool.GetGLMethodAdress("glTexStorage1DEXT", typeof(dgtk.OpenGL.delegatesGL.glTexStorage1DEXT));
			}
			if (SuportedExt.Contains("glTexStorage2DEXT"))
			{
				dgtk.OpenGL.internalGL.glTexStorage2DEXT = (dgtk.OpenGL.delegatesGL.glTexStorage2DEXT) InternalTool.GetGLMethodAdress("glTexStorage2DEXT", typeof(dgtk.OpenGL.delegatesGL.glTexStorage2DEXT));
			}
			if (SuportedExt.Contains("glTexStorage3DEXT"))
			{
				dgtk.OpenGL.internalGL.glTexStorage3DEXT = (dgtk.OpenGL.delegatesGL.glTexStorage3DEXT) InternalTool.GetGLMethodAdress("glTexStorage3DEXT", typeof(dgtk.OpenGL.delegatesGL.glTexStorage3DEXT));
			}
			if (SuportedExt.Contains("glTexStorage3DMultisampleOES"))
			{
				dgtk.OpenGL.internalGL.glTexStorage3DMultisampleOES = (dgtk.OpenGL.delegatesGL.glTexStorage3DMultisampleOES) InternalTool.GetGLMethodAdress("glTexStorage3DMultisampleOES", typeof(dgtk.OpenGL.delegatesGL.glTexStorage3DMultisampleOES));
			}
			if (SuportedExt.Contains("glTexStorageMem1DEXT"))
			{
				dgtk.OpenGL.internalGL.glTexStorageMem1DEXT = (dgtk.OpenGL.delegatesGL.glTexStorageMem1DEXT) InternalTool.GetGLMethodAdress("glTexStorageMem1DEXT", typeof(dgtk.OpenGL.delegatesGL.glTexStorageMem1DEXT));
			}
			if (SuportedExt.Contains("glTexStorageMem2DEXT"))
			{
				dgtk.OpenGL.internalGL.glTexStorageMem2DEXT = (dgtk.OpenGL.delegatesGL.glTexStorageMem2DEXT) InternalTool.GetGLMethodAdress("glTexStorageMem2DEXT", typeof(dgtk.OpenGL.delegatesGL.glTexStorageMem2DEXT));
			}
			if (SuportedExt.Contains("glTexStorageMem2DMultisampleEXT"))
			{
				dgtk.OpenGL.internalGL.glTexStorageMem2DMultisampleEXT = (dgtk.OpenGL.delegatesGL.glTexStorageMem2DMultisampleEXT) InternalTool.GetGLMethodAdress("glTexStorageMem2DMultisampleEXT", typeof(dgtk.OpenGL.delegatesGL.glTexStorageMem2DMultisampleEXT));
			}
			if (SuportedExt.Contains("glTexStorageMem3DEXT"))
			{
				dgtk.OpenGL.internalGL.glTexStorageMem3DEXT = (dgtk.OpenGL.delegatesGL.glTexStorageMem3DEXT) InternalTool.GetGLMethodAdress("glTexStorageMem3DEXT", typeof(dgtk.OpenGL.delegatesGL.glTexStorageMem3DEXT));
			}
			if (SuportedExt.Contains("glTexStorageMem3DMultisampleEXT"))
			{
				dgtk.OpenGL.internalGL.glTexStorageMem3DMultisampleEXT = (dgtk.OpenGL.delegatesGL.glTexStorageMem3DMultisampleEXT) InternalTool.GetGLMethodAdress("glTexStorageMem3DMultisampleEXT", typeof(dgtk.OpenGL.delegatesGL.glTexStorageMem3DMultisampleEXT));
			}
			if (SuportedExt.Contains("glTexStorageSparseAMD"))
			{
				dgtk.OpenGL.internalGL.glTexStorageSparseAMD = (dgtk.OpenGL.delegatesGL.glTexStorageSparseAMD) InternalTool.GetGLMethodAdress("glTexStorageSparseAMD", typeof(dgtk.OpenGL.delegatesGL.glTexStorageSparseAMD));
			}
			if (SuportedExt.Contains("glTexSubImage1DEXT"))
			{
				dgtk.OpenGL.internalGL.glTexSubImage1DEXT = (dgtk.OpenGL.delegatesGL.glTexSubImage1DEXT) InternalTool.GetGLMethodAdress("glTexSubImage1DEXT", typeof(dgtk.OpenGL.delegatesGL.glTexSubImage1DEXT));
			}
			if (SuportedExt.Contains("glTexSubImage2DEXT"))
			{
				dgtk.OpenGL.internalGL.glTexSubImage2DEXT = (dgtk.OpenGL.delegatesGL.glTexSubImage2DEXT) InternalTool.GetGLMethodAdress("glTexSubImage2DEXT", typeof(dgtk.OpenGL.delegatesGL.glTexSubImage2DEXT));
			}
			if (SuportedExt.Contains("glTexSubImage3DEXT"))
			{
				dgtk.OpenGL.internalGL.glTexSubImage3DEXT = (dgtk.OpenGL.delegatesGL.glTexSubImage3DEXT) InternalTool.GetGLMethodAdress("glTexSubImage3DEXT", typeof(dgtk.OpenGL.delegatesGL.glTexSubImage3DEXT));
			}
			if (SuportedExt.Contains("glTexSubImage3DOES"))
			{
				dgtk.OpenGL.internalGL.glTexSubImage3DOES = (dgtk.OpenGL.delegatesGL.glTexSubImage3DOES) InternalTool.GetGLMethodAdress("glTexSubImage3DOES", typeof(dgtk.OpenGL.delegatesGL.glTexSubImage3DOES));
			}
			if (SuportedExt.Contains("glTexSubImage4DSGIS"))
			{
				dgtk.OpenGL.internalGL.glTexSubImage4DSGIS = (dgtk.OpenGL.delegatesGL.glTexSubImage4DSGIS) InternalTool.GetGLMethodAdress("glTexSubImage4DSGIS", typeof(dgtk.OpenGL.delegatesGL.glTexSubImage4DSGIS));
			}
			if (SuportedExt.Contains("glTextureAttachMemoryNV"))
			{
				dgtk.OpenGL.internalGL.glTextureAttachMemoryNV = (dgtk.OpenGL.delegatesGL.glTextureAttachMemoryNV) InternalTool.GetGLMethodAdress("glTextureAttachMemoryNV", typeof(dgtk.OpenGL.delegatesGL.glTextureAttachMemoryNV));
			}
			if (SuportedExt.Contains("glTextureBarrierNV"))
			{
				dgtk.OpenGL.internalGL.glTextureBarrierNV = (dgtk.OpenGL.delegatesGL.glTextureBarrierNV) InternalTool.GetGLMethodAdress("glTextureBarrierNV", typeof(dgtk.OpenGL.delegatesGL.glTextureBarrierNV));
			}
			if (SuportedExt.Contains("glTextureBufferEXT"))
			{
				dgtk.OpenGL.internalGL.glTextureBufferEXT = (dgtk.OpenGL.delegatesGL.glTextureBufferEXT) InternalTool.GetGLMethodAdress("glTextureBufferEXT", typeof(dgtk.OpenGL.delegatesGL.glTextureBufferEXT));
			}
			if (SuportedExt.Contains("glTextureBufferRangeEXT"))
			{
				dgtk.OpenGL.internalGL.glTextureBufferRangeEXT = (dgtk.OpenGL.delegatesGL.glTextureBufferRangeEXT) InternalTool.GetGLMethodAdress("glTextureBufferRangeEXT", typeof(dgtk.OpenGL.delegatesGL.glTextureBufferRangeEXT));
			}
			if (SuportedExt.Contains("glTextureColorMaskSGIS"))
			{
				dgtk.OpenGL.internalGL.glTextureColorMaskSGIS = (dgtk.OpenGL.delegatesGL.glTextureColorMaskSGIS) InternalTool.GetGLMethodAdress("glTextureColorMaskSGIS", typeof(dgtk.OpenGL.delegatesGL.glTextureColorMaskSGIS));
			}
			if (SuportedExt.Contains("glTextureFoveationParametersQCOM"))
			{
				dgtk.OpenGL.internalGL.glTextureFoveationParametersQCOM = (dgtk.OpenGL.delegatesGL.glTextureFoveationParametersQCOM) InternalTool.GetGLMethodAdress("glTextureFoveationParametersQCOM", typeof(dgtk.OpenGL.delegatesGL.glTextureFoveationParametersQCOM));
			}
			if (SuportedExt.Contains("glTextureImage1DEXT"))
			{
				dgtk.OpenGL.internalGL.glTextureImage1DEXT = (dgtk.OpenGL.delegatesGL.glTextureImage1DEXT) InternalTool.GetGLMethodAdress("glTextureImage1DEXT", typeof(dgtk.OpenGL.delegatesGL.glTextureImage1DEXT));
			}
			if (SuportedExt.Contains("glTextureImage2DEXT"))
			{
				dgtk.OpenGL.internalGL.glTextureImage2DEXT = (dgtk.OpenGL.delegatesGL.glTextureImage2DEXT) InternalTool.GetGLMethodAdress("glTextureImage2DEXT", typeof(dgtk.OpenGL.delegatesGL.glTextureImage2DEXT));
			}
			if (SuportedExt.Contains("glTextureImage2DMultisampleCoverageNV"))
			{
				dgtk.OpenGL.internalGL.glTextureImage2DMultisampleCoverageNV = (dgtk.OpenGL.delegatesGL.glTextureImage2DMultisampleCoverageNV) InternalTool.GetGLMethodAdress("glTextureImage2DMultisampleCoverageNV", typeof(dgtk.OpenGL.delegatesGL.glTextureImage2DMultisampleCoverageNV));
			}
			if (SuportedExt.Contains("glTextureImage2DMultisampleNV"))
			{
				dgtk.OpenGL.internalGL.glTextureImage2DMultisampleNV = (dgtk.OpenGL.delegatesGL.glTextureImage2DMultisampleNV) InternalTool.GetGLMethodAdress("glTextureImage2DMultisampleNV", typeof(dgtk.OpenGL.delegatesGL.glTextureImage2DMultisampleNV));
			}
			if (SuportedExt.Contains("glTextureImage3DEXT"))
			{
				dgtk.OpenGL.internalGL.glTextureImage3DEXT = (dgtk.OpenGL.delegatesGL.glTextureImage3DEXT) InternalTool.GetGLMethodAdress("glTextureImage3DEXT", typeof(dgtk.OpenGL.delegatesGL.glTextureImage3DEXT));
			}
			if (SuportedExt.Contains("glTextureImage3DMultisampleCoverageNV"))
			{
				dgtk.OpenGL.internalGL.glTextureImage3DMultisampleCoverageNV = (dgtk.OpenGL.delegatesGL.glTextureImage3DMultisampleCoverageNV) InternalTool.GetGLMethodAdress("glTextureImage3DMultisampleCoverageNV", typeof(dgtk.OpenGL.delegatesGL.glTextureImage3DMultisampleCoverageNV));
			}
			if (SuportedExt.Contains("glTextureImage3DMultisampleNV"))
			{
				dgtk.OpenGL.internalGL.glTextureImage3DMultisampleNV = (dgtk.OpenGL.delegatesGL.glTextureImage3DMultisampleNV) InternalTool.GetGLMethodAdress("glTextureImage3DMultisampleNV", typeof(dgtk.OpenGL.delegatesGL.glTextureImage3DMultisampleNV));
			}
			if (SuportedExt.Contains("glTextureLightEXT"))
			{
				dgtk.OpenGL.internalGL.glTextureLightEXT = (dgtk.OpenGL.delegatesGL.glTextureLightEXT) InternalTool.GetGLMethodAdress("glTextureLightEXT", typeof(dgtk.OpenGL.delegatesGL.glTextureLightEXT));
			}
			if (SuportedExt.Contains("glTextureMaterialEXT"))
			{
				dgtk.OpenGL.internalGL.glTextureMaterialEXT = (dgtk.OpenGL.delegatesGL.glTextureMaterialEXT) InternalTool.GetGLMethodAdress("glTextureMaterialEXT", typeof(dgtk.OpenGL.delegatesGL.glTextureMaterialEXT));
			}
			if (SuportedExt.Contains("glTextureNormalEXT"))
			{
				dgtk.OpenGL.internalGL.glTextureNormalEXT = (dgtk.OpenGL.delegatesGL.glTextureNormalEXT) InternalTool.GetGLMethodAdress("glTextureNormalEXT", typeof(dgtk.OpenGL.delegatesGL.glTextureNormalEXT));
			}
			if (SuportedExt.Contains("glTexturePageCommitmentEXT"))
			{
				dgtk.OpenGL.internalGL.glTexturePageCommitmentEXT = (dgtk.OpenGL.delegatesGL.glTexturePageCommitmentEXT) InternalTool.GetGLMethodAdress("glTexturePageCommitmentEXT", typeof(dgtk.OpenGL.delegatesGL.glTexturePageCommitmentEXT));
			}
			if (SuportedExt.Contains("glTexturePageCommitmentMemNV"))
			{
				dgtk.OpenGL.internalGL.glTexturePageCommitmentMemNV = (dgtk.OpenGL.delegatesGL.glTexturePageCommitmentMemNV) InternalTool.GetGLMethodAdress("glTexturePageCommitmentMemNV", typeof(dgtk.OpenGL.delegatesGL.glTexturePageCommitmentMemNV));
			}
			if (SuportedExt.Contains("glTextureParameterfEXT"))
			{
				dgtk.OpenGL.internalGL.glTextureParameterfEXT = (dgtk.OpenGL.delegatesGL.glTextureParameterfEXT) InternalTool.GetGLMethodAdress("glTextureParameterfEXT", typeof(dgtk.OpenGL.delegatesGL.glTextureParameterfEXT));
			}
			if (SuportedExt.Contains("glTextureParameterfvEXT"))
			{
				dgtk.OpenGL.internalGL.glTextureParameterfvEXT = (dgtk.OpenGL.delegatesGL.glTextureParameterfvEXT) InternalTool.GetGLMethodAdress("glTextureParameterfvEXT", typeof(dgtk.OpenGL.delegatesGL.glTextureParameterfvEXT));
			}
			if (SuportedExt.Contains("glTextureParameteriEXT"))
			{
				dgtk.OpenGL.internalGL.glTextureParameteriEXT = (dgtk.OpenGL.delegatesGL.glTextureParameteriEXT) InternalTool.GetGLMethodAdress("glTextureParameteriEXT", typeof(dgtk.OpenGL.delegatesGL.glTextureParameteriEXT));
			}
			if (SuportedExt.Contains("glTextureParameterIivEXT"))
			{
				dgtk.OpenGL.internalGL.glTextureParameterIivEXT = (dgtk.OpenGL.delegatesGL.glTextureParameterIivEXT) InternalTool.GetGLMethodAdress("glTextureParameterIivEXT", typeof(dgtk.OpenGL.delegatesGL.glTextureParameterIivEXT));
			}
			if (SuportedExt.Contains("glTextureParameterIuivEXT"))
			{
				dgtk.OpenGL.internalGL.glTextureParameterIuivEXT = (dgtk.OpenGL.delegatesGL.glTextureParameterIuivEXT) InternalTool.GetGLMethodAdress("glTextureParameterIuivEXT", typeof(dgtk.OpenGL.delegatesGL.glTextureParameterIuivEXT));
			}
			if (SuportedExt.Contains("glTextureParameterivEXT"))
			{
				dgtk.OpenGL.internalGL.glTextureParameterivEXT = (dgtk.OpenGL.delegatesGL.glTextureParameterivEXT) InternalTool.GetGLMethodAdress("glTextureParameterivEXT", typeof(dgtk.OpenGL.delegatesGL.glTextureParameterivEXT));
			}
			if (SuportedExt.Contains("glTextureRangeAPPLE"))
			{
				dgtk.OpenGL.internalGL.glTextureRangeAPPLE = (dgtk.OpenGL.delegatesGL.glTextureRangeAPPLE) InternalTool.GetGLMethodAdress("glTextureRangeAPPLE", typeof(dgtk.OpenGL.delegatesGL.glTextureRangeAPPLE));
			}
			if (SuportedExt.Contains("glTextureRenderbufferEXT"))
			{
				dgtk.OpenGL.internalGL.glTextureRenderbufferEXT = (dgtk.OpenGL.delegatesGL.glTextureRenderbufferEXT) InternalTool.GetGLMethodAdress("glTextureRenderbufferEXT", typeof(dgtk.OpenGL.delegatesGL.glTextureRenderbufferEXT));
			}
			if (SuportedExt.Contains("glTextureStorage1DEXT"))
			{
				dgtk.OpenGL.internalGL.glTextureStorage1DEXT = (dgtk.OpenGL.delegatesGL.glTextureStorage1DEXT) InternalTool.GetGLMethodAdress("glTextureStorage1DEXT", typeof(dgtk.OpenGL.delegatesGL.glTextureStorage1DEXT));
			}
			if (SuportedExt.Contains("glTextureStorage2DEXT"))
			{
				dgtk.OpenGL.internalGL.glTextureStorage2DEXT = (dgtk.OpenGL.delegatesGL.glTextureStorage2DEXT) InternalTool.GetGLMethodAdress("glTextureStorage2DEXT", typeof(dgtk.OpenGL.delegatesGL.glTextureStorage2DEXT));
			}
			if (SuportedExt.Contains("glTextureStorage2DMultisampleEXT"))
			{
				dgtk.OpenGL.internalGL.glTextureStorage2DMultisampleEXT = (dgtk.OpenGL.delegatesGL.glTextureStorage2DMultisampleEXT) InternalTool.GetGLMethodAdress("glTextureStorage2DMultisampleEXT", typeof(dgtk.OpenGL.delegatesGL.glTextureStorage2DMultisampleEXT));
			}
			if (SuportedExt.Contains("glTextureStorage3DEXT"))
			{
				dgtk.OpenGL.internalGL.glTextureStorage3DEXT = (dgtk.OpenGL.delegatesGL.glTextureStorage3DEXT) InternalTool.GetGLMethodAdress("glTextureStorage3DEXT", typeof(dgtk.OpenGL.delegatesGL.glTextureStorage3DEXT));
			}
			if (SuportedExt.Contains("glTextureStorage3DMultisampleEXT"))
			{
				dgtk.OpenGL.internalGL.glTextureStorage3DMultisampleEXT = (dgtk.OpenGL.delegatesGL.glTextureStorage3DMultisampleEXT) InternalTool.GetGLMethodAdress("glTextureStorage3DMultisampleEXT", typeof(dgtk.OpenGL.delegatesGL.glTextureStorage3DMultisampleEXT));
			}
			if (SuportedExt.Contains("glTextureStorageMem1DEXT"))
			{
				dgtk.OpenGL.internalGL.glTextureStorageMem1DEXT = (dgtk.OpenGL.delegatesGL.glTextureStorageMem1DEXT) InternalTool.GetGLMethodAdress("glTextureStorageMem1DEXT", typeof(dgtk.OpenGL.delegatesGL.glTextureStorageMem1DEXT));
			}
			if (SuportedExt.Contains("glTextureStorageMem2DEXT"))
			{
				dgtk.OpenGL.internalGL.glTextureStorageMem2DEXT = (dgtk.OpenGL.delegatesGL.glTextureStorageMem2DEXT) InternalTool.GetGLMethodAdress("glTextureStorageMem2DEXT", typeof(dgtk.OpenGL.delegatesGL.glTextureStorageMem2DEXT));
			}
			if (SuportedExt.Contains("glTextureStorageMem2DMultisampleEXT"))
			{
				dgtk.OpenGL.internalGL.glTextureStorageMem2DMultisampleEXT = (dgtk.OpenGL.delegatesGL.glTextureStorageMem2DMultisampleEXT) InternalTool.GetGLMethodAdress("glTextureStorageMem2DMultisampleEXT", typeof(dgtk.OpenGL.delegatesGL.glTextureStorageMem2DMultisampleEXT));
			}
			if (SuportedExt.Contains("glTextureStorageMem3DEXT"))
			{
				dgtk.OpenGL.internalGL.glTextureStorageMem3DEXT = (dgtk.OpenGL.delegatesGL.glTextureStorageMem3DEXT) InternalTool.GetGLMethodAdress("glTextureStorageMem3DEXT", typeof(dgtk.OpenGL.delegatesGL.glTextureStorageMem3DEXT));
			}
			if (SuportedExt.Contains("glTextureStorageMem3DMultisampleEXT"))
			{
				dgtk.OpenGL.internalGL.glTextureStorageMem3DMultisampleEXT = (dgtk.OpenGL.delegatesGL.glTextureStorageMem3DMultisampleEXT) InternalTool.GetGLMethodAdress("glTextureStorageMem3DMultisampleEXT", typeof(dgtk.OpenGL.delegatesGL.glTextureStorageMem3DMultisampleEXT));
			}
			if (SuportedExt.Contains("glTextureStorageSparseAMD"))
			{
				dgtk.OpenGL.internalGL.glTextureStorageSparseAMD = (dgtk.OpenGL.delegatesGL.glTextureStorageSparseAMD) InternalTool.GetGLMethodAdress("glTextureStorageSparseAMD", typeof(dgtk.OpenGL.delegatesGL.glTextureStorageSparseAMD));
			}
			if (SuportedExt.Contains("glTextureSubImage1DEXT"))
			{
				dgtk.OpenGL.internalGL.glTextureSubImage1DEXT = (dgtk.OpenGL.delegatesGL.glTextureSubImage1DEXT) InternalTool.GetGLMethodAdress("glTextureSubImage1DEXT", typeof(dgtk.OpenGL.delegatesGL.glTextureSubImage1DEXT));
			}
			if (SuportedExt.Contains("glTextureSubImage2DEXT"))
			{
				dgtk.OpenGL.internalGL.glTextureSubImage2DEXT = (dgtk.OpenGL.delegatesGL.glTextureSubImage2DEXT) InternalTool.GetGLMethodAdress("glTextureSubImage2DEXT", typeof(dgtk.OpenGL.delegatesGL.glTextureSubImage2DEXT));
			}
			if (SuportedExt.Contains("glTextureSubImage3DEXT"))
			{
				dgtk.OpenGL.internalGL.glTextureSubImage3DEXT = (dgtk.OpenGL.delegatesGL.glTextureSubImage3DEXT) InternalTool.GetGLMethodAdress("glTextureSubImage3DEXT", typeof(dgtk.OpenGL.delegatesGL.glTextureSubImage3DEXT));
			}
			if (SuportedExt.Contains("glTextureViewEXT"))
			{
				dgtk.OpenGL.internalGL.glTextureViewEXT = (dgtk.OpenGL.delegatesGL.glTextureViewEXT) InternalTool.GetGLMethodAdress("glTextureViewEXT", typeof(dgtk.OpenGL.delegatesGL.glTextureViewEXT));
			}
			if (SuportedExt.Contains("glTextureViewOES"))
			{
				dgtk.OpenGL.internalGL.glTextureViewOES = (dgtk.OpenGL.delegatesGL.glTextureViewOES) InternalTool.GetGLMethodAdress("glTextureViewOES", typeof(dgtk.OpenGL.delegatesGL.glTextureViewOES));
			}
			if (SuportedExt.Contains("glTrackMatrixNV"))
			{
				dgtk.OpenGL.internalGL.glTrackMatrixNV = (dgtk.OpenGL.delegatesGL.glTrackMatrixNV) InternalTool.GetGLMethodAdress("glTrackMatrixNV", typeof(dgtk.OpenGL.delegatesGL.glTrackMatrixNV));
			}
			if (SuportedExt.Contains("glTransformFeedbackAttribsNV"))
			{
				dgtk.OpenGL.internalGL.glTransformFeedbackAttribsNV = (dgtk.OpenGL.delegatesGL.glTransformFeedbackAttribsNV) InternalTool.GetGLMethodAdress("glTransformFeedbackAttribsNV", typeof(dgtk.OpenGL.delegatesGL.glTransformFeedbackAttribsNV));
			}
			if (SuportedExt.Contains("glTransformFeedbackStreamAttribsNV"))
			{
				dgtk.OpenGL.internalGL.glTransformFeedbackStreamAttribsNV = (dgtk.OpenGL.delegatesGL.glTransformFeedbackStreamAttribsNV) InternalTool.GetGLMethodAdress("glTransformFeedbackStreamAttribsNV", typeof(dgtk.OpenGL.delegatesGL.glTransformFeedbackStreamAttribsNV));
			}
			if (SuportedExt.Contains("glTransformFeedbackVaryingsEXT"))
			{
				dgtk.OpenGL.internalGL.glTransformFeedbackVaryingsEXT = (dgtk.OpenGL.delegatesGL.glTransformFeedbackVaryingsEXT) InternalTool.GetGLMethodAdress("glTransformFeedbackVaryingsEXT", typeof(dgtk.OpenGL.delegatesGL.glTransformFeedbackVaryingsEXT));
			}
			if (SuportedExt.Contains("glTransformFeedbackVaryingsNV"))
			{
				dgtk.OpenGL.internalGL.glTransformFeedbackVaryingsNV = (dgtk.OpenGL.delegatesGL.glTransformFeedbackVaryingsNV) InternalTool.GetGLMethodAdress("glTransformFeedbackVaryingsNV", typeof(dgtk.OpenGL.delegatesGL.glTransformFeedbackVaryingsNV));
			}
			if (SuportedExt.Contains("glTransformPathNV"))
			{
				dgtk.OpenGL.internalGL.glTransformPathNV = (dgtk.OpenGL.delegatesGL.glTransformPathNV) InternalTool.GetGLMethodAdress("glTransformPathNV", typeof(dgtk.OpenGL.delegatesGL.glTransformPathNV));
			}
			if (SuportedExt.Contains("glTranslatex"))
			{
				dgtk.OpenGL.internalGL.glTranslatex = (dgtk.OpenGL.delegatesGL.glTranslatex) InternalTool.GetGLMethodAdress("glTranslatex", typeof(dgtk.OpenGL.delegatesGL.glTranslatex));
			}
			if (SuportedExt.Contains("glTranslatexOES"))
			{
				dgtk.OpenGL.internalGL.glTranslatexOES = (dgtk.OpenGL.delegatesGL.glTranslatexOES) InternalTool.GetGLMethodAdress("glTranslatexOES", typeof(dgtk.OpenGL.delegatesGL.glTranslatexOES));
			}
			#endregion

			#region U:

			if (SuportedExt.Contains("glUniform1fARB"))
			{
				dgtk.OpenGL.internalGL.glUniform1fARB = (dgtk.OpenGL.delegatesGL.glUniform1fARB) InternalTool.GetGLMethodAdress("glUniform1fARB", typeof(dgtk.OpenGL.delegatesGL.glUniform1fARB));
			}
			if (SuportedExt.Contains("glUniform1fvARB"))
			{
				dgtk.OpenGL.internalGL.glUniform1fvARB = (dgtk.OpenGL.delegatesGL.glUniform1fvARB) InternalTool.GetGLMethodAdress("glUniform1fvARB", typeof(dgtk.OpenGL.delegatesGL.glUniform1fvARB));
			}
			if (SuportedExt.Contains("glUniform1i64ARB"))
			{
				dgtk.OpenGL.internalGL.glUniform1i64ARB = (dgtk.OpenGL.delegatesGL.glUniform1i64ARB) InternalTool.GetGLMethodAdress("glUniform1i64ARB", typeof(dgtk.OpenGL.delegatesGL.glUniform1i64ARB));
			}
			if (SuportedExt.Contains("glUniform1i64NV"))
			{
				dgtk.OpenGL.internalGL.glUniform1i64NV = (dgtk.OpenGL.delegatesGL.glUniform1i64NV) InternalTool.GetGLMethodAdress("glUniform1i64NV", typeof(dgtk.OpenGL.delegatesGL.glUniform1i64NV));
			}
			if (SuportedExt.Contains("glUniform1i64vARB"))
			{
				dgtk.OpenGL.internalGL.glUniform1i64vARB = (dgtk.OpenGL.delegatesGL.glUniform1i64vARB) InternalTool.GetGLMethodAdress("glUniform1i64vARB", typeof(dgtk.OpenGL.delegatesGL.glUniform1i64vARB));
			}
			if (SuportedExt.Contains("glUniform1i64vNV"))
			{
				dgtk.OpenGL.internalGL.glUniform1i64vNV = (dgtk.OpenGL.delegatesGL.glUniform1i64vNV) InternalTool.GetGLMethodAdress("glUniform1i64vNV", typeof(dgtk.OpenGL.delegatesGL.glUniform1i64vNV));
			}
			if (SuportedExt.Contains("glUniform1iARB"))
			{
				dgtk.OpenGL.internalGL.glUniform1iARB = (dgtk.OpenGL.delegatesGL.glUniform1iARB) InternalTool.GetGLMethodAdress("glUniform1iARB", typeof(dgtk.OpenGL.delegatesGL.glUniform1iARB));
			}
			if (SuportedExt.Contains("glUniform1ivARB"))
			{
				dgtk.OpenGL.internalGL.glUniform1ivARB = (dgtk.OpenGL.delegatesGL.glUniform1ivARB) InternalTool.GetGLMethodAdress("glUniform1ivARB", typeof(dgtk.OpenGL.delegatesGL.glUniform1ivARB));
			}
			if (SuportedExt.Contains("glUniform1ui64ARB"))
			{
				dgtk.OpenGL.internalGL.glUniform1ui64ARB = (dgtk.OpenGL.delegatesGL.glUniform1ui64ARB) InternalTool.GetGLMethodAdress("glUniform1ui64ARB", typeof(dgtk.OpenGL.delegatesGL.glUniform1ui64ARB));
			}
			if (SuportedExt.Contains("glUniform1ui64NV"))
			{
				dgtk.OpenGL.internalGL.glUniform1ui64NV = (dgtk.OpenGL.delegatesGL.glUniform1ui64NV) InternalTool.GetGLMethodAdress("glUniform1ui64NV", typeof(dgtk.OpenGL.delegatesGL.glUniform1ui64NV));
			}
			if (SuportedExt.Contains("glUniform1ui64vARB"))
			{
				dgtk.OpenGL.internalGL.glUniform1ui64vARB = (dgtk.OpenGL.delegatesGL.glUniform1ui64vARB) InternalTool.GetGLMethodAdress("glUniform1ui64vARB", typeof(dgtk.OpenGL.delegatesGL.glUniform1ui64vARB));
			}
			if (SuportedExt.Contains("glUniform1ui64vNV"))
			{
				dgtk.OpenGL.internalGL.glUniform1ui64vNV = (dgtk.OpenGL.delegatesGL.glUniform1ui64vNV) InternalTool.GetGLMethodAdress("glUniform1ui64vNV", typeof(dgtk.OpenGL.delegatesGL.glUniform1ui64vNV));
			}
			if (SuportedExt.Contains("glUniform1uiEXT"))
			{
				dgtk.OpenGL.internalGL.glUniform1uiEXT = (dgtk.OpenGL.delegatesGL.glUniform1uiEXT) InternalTool.GetGLMethodAdress("glUniform1uiEXT", typeof(dgtk.OpenGL.delegatesGL.glUniform1uiEXT));
			}
			if (SuportedExt.Contains("glUniform1uivEXT"))
			{
				dgtk.OpenGL.internalGL.glUniform1uivEXT = (dgtk.OpenGL.delegatesGL.glUniform1uivEXT) InternalTool.GetGLMethodAdress("glUniform1uivEXT", typeof(dgtk.OpenGL.delegatesGL.glUniform1uivEXT));
			}
			if (SuportedExt.Contains("glUniform2fARB"))
			{
				dgtk.OpenGL.internalGL.glUniform2fARB = (dgtk.OpenGL.delegatesGL.glUniform2fARB) InternalTool.GetGLMethodAdress("glUniform2fARB", typeof(dgtk.OpenGL.delegatesGL.glUniform2fARB));
			}
			if (SuportedExt.Contains("glUniform2fvARB"))
			{
				dgtk.OpenGL.internalGL.glUniform2fvARB = (dgtk.OpenGL.delegatesGL.glUniform2fvARB) InternalTool.GetGLMethodAdress("glUniform2fvARB", typeof(dgtk.OpenGL.delegatesGL.glUniform2fvARB));
			}
			if (SuportedExt.Contains("glUniform2i64ARB"))
			{
				dgtk.OpenGL.internalGL.glUniform2i64ARB = (dgtk.OpenGL.delegatesGL.glUniform2i64ARB) InternalTool.GetGLMethodAdress("glUniform2i64ARB", typeof(dgtk.OpenGL.delegatesGL.glUniform2i64ARB));
			}
			if (SuportedExt.Contains("glUniform2i64NV"))
			{
				dgtk.OpenGL.internalGL.glUniform2i64NV = (dgtk.OpenGL.delegatesGL.glUniform2i64NV) InternalTool.GetGLMethodAdress("glUniform2i64NV", typeof(dgtk.OpenGL.delegatesGL.glUniform2i64NV));
			}
			if (SuportedExt.Contains("glUniform2i64vARB"))
			{
				dgtk.OpenGL.internalGL.glUniform2i64vARB = (dgtk.OpenGL.delegatesGL.glUniform2i64vARB) InternalTool.GetGLMethodAdress("glUniform2i64vARB", typeof(dgtk.OpenGL.delegatesGL.glUniform2i64vARB));
			}
			if (SuportedExt.Contains("glUniform2i64vNV"))
			{
				dgtk.OpenGL.internalGL.glUniform2i64vNV = (dgtk.OpenGL.delegatesGL.glUniform2i64vNV) InternalTool.GetGLMethodAdress("glUniform2i64vNV", typeof(dgtk.OpenGL.delegatesGL.glUniform2i64vNV));
			}
			if (SuportedExt.Contains("glUniform2iARB"))
			{
				dgtk.OpenGL.internalGL.glUniform2iARB = (dgtk.OpenGL.delegatesGL.glUniform2iARB) InternalTool.GetGLMethodAdress("glUniform2iARB", typeof(dgtk.OpenGL.delegatesGL.glUniform2iARB));
			}
			if (SuportedExt.Contains("glUniform2ivARB"))
			{
				dgtk.OpenGL.internalGL.glUniform2ivARB = (dgtk.OpenGL.delegatesGL.glUniform2ivARB) InternalTool.GetGLMethodAdress("glUniform2ivARB", typeof(dgtk.OpenGL.delegatesGL.glUniform2ivARB));
			}
			if (SuportedExt.Contains("glUniform2ui64ARB"))
			{
				dgtk.OpenGL.internalGL.glUniform2ui64ARB = (dgtk.OpenGL.delegatesGL.glUniform2ui64ARB) InternalTool.GetGLMethodAdress("glUniform2ui64ARB", typeof(dgtk.OpenGL.delegatesGL.glUniform2ui64ARB));
			}
			if (SuportedExt.Contains("glUniform2ui64NV"))
			{
				dgtk.OpenGL.internalGL.glUniform2ui64NV = (dgtk.OpenGL.delegatesGL.glUniform2ui64NV) InternalTool.GetGLMethodAdress("glUniform2ui64NV", typeof(dgtk.OpenGL.delegatesGL.glUniform2ui64NV));
			}
			if (SuportedExt.Contains("glUniform2ui64vARB"))
			{
				dgtk.OpenGL.internalGL.glUniform2ui64vARB = (dgtk.OpenGL.delegatesGL.glUniform2ui64vARB) InternalTool.GetGLMethodAdress("glUniform2ui64vARB", typeof(dgtk.OpenGL.delegatesGL.glUniform2ui64vARB));
			}
			if (SuportedExt.Contains("glUniform2ui64vNV"))
			{
				dgtk.OpenGL.internalGL.glUniform2ui64vNV = (dgtk.OpenGL.delegatesGL.glUniform2ui64vNV) InternalTool.GetGLMethodAdress("glUniform2ui64vNV", typeof(dgtk.OpenGL.delegatesGL.glUniform2ui64vNV));
			}
			if (SuportedExt.Contains("glUniform2uiEXT"))
			{
				dgtk.OpenGL.internalGL.glUniform2uiEXT = (dgtk.OpenGL.delegatesGL.glUniform2uiEXT) InternalTool.GetGLMethodAdress("glUniform2uiEXT", typeof(dgtk.OpenGL.delegatesGL.glUniform2uiEXT));
			}
			if (SuportedExt.Contains("glUniform2uivEXT"))
			{
				dgtk.OpenGL.internalGL.glUniform2uivEXT = (dgtk.OpenGL.delegatesGL.glUniform2uivEXT) InternalTool.GetGLMethodAdress("glUniform2uivEXT", typeof(dgtk.OpenGL.delegatesGL.glUniform2uivEXT));
			}
			if (SuportedExt.Contains("glUniform3fARB"))
			{
				dgtk.OpenGL.internalGL.glUniform3fARB = (dgtk.OpenGL.delegatesGL.glUniform3fARB) InternalTool.GetGLMethodAdress("glUniform3fARB", typeof(dgtk.OpenGL.delegatesGL.glUniform3fARB));
			}
			if (SuportedExt.Contains("glUniform3fvARB"))
			{
				dgtk.OpenGL.internalGL.glUniform3fvARB = (dgtk.OpenGL.delegatesGL.glUniform3fvARB) InternalTool.GetGLMethodAdress("glUniform3fvARB", typeof(dgtk.OpenGL.delegatesGL.glUniform3fvARB));
			}
			if (SuportedExt.Contains("glUniform3i64ARB"))
			{
				dgtk.OpenGL.internalGL.glUniform3i64ARB = (dgtk.OpenGL.delegatesGL.glUniform3i64ARB) InternalTool.GetGLMethodAdress("glUniform3i64ARB", typeof(dgtk.OpenGL.delegatesGL.glUniform3i64ARB));
			}
			if (SuportedExt.Contains("glUniform3i64NV"))
			{
				dgtk.OpenGL.internalGL.glUniform3i64NV = (dgtk.OpenGL.delegatesGL.glUniform3i64NV) InternalTool.GetGLMethodAdress("glUniform3i64NV", typeof(dgtk.OpenGL.delegatesGL.glUniform3i64NV));
			}
			if (SuportedExt.Contains("glUniform3i64vARB"))
			{
				dgtk.OpenGL.internalGL.glUniform3i64vARB = (dgtk.OpenGL.delegatesGL.glUniform3i64vARB) InternalTool.GetGLMethodAdress("glUniform3i64vARB", typeof(dgtk.OpenGL.delegatesGL.glUniform3i64vARB));
			}
			if (SuportedExt.Contains("glUniform3i64vNV"))
			{
				dgtk.OpenGL.internalGL.glUniform3i64vNV = (dgtk.OpenGL.delegatesGL.glUniform3i64vNV) InternalTool.GetGLMethodAdress("glUniform3i64vNV", typeof(dgtk.OpenGL.delegatesGL.glUniform3i64vNV));
			}
			if (SuportedExt.Contains("glUniform3iARB"))
			{
				dgtk.OpenGL.internalGL.glUniform3iARB = (dgtk.OpenGL.delegatesGL.glUniform3iARB) InternalTool.GetGLMethodAdress("glUniform3iARB", typeof(dgtk.OpenGL.delegatesGL.glUniform3iARB));
			}
			if (SuportedExt.Contains("glUniform3ivARB"))
			{
				dgtk.OpenGL.internalGL.glUniform3ivARB = (dgtk.OpenGL.delegatesGL.glUniform3ivARB) InternalTool.GetGLMethodAdress("glUniform3ivARB", typeof(dgtk.OpenGL.delegatesGL.glUniform3ivARB));
			}
			if (SuportedExt.Contains("glUniform3ui64ARB"))
			{
				dgtk.OpenGL.internalGL.glUniform3ui64ARB = (dgtk.OpenGL.delegatesGL.glUniform3ui64ARB) InternalTool.GetGLMethodAdress("glUniform3ui64ARB", typeof(dgtk.OpenGL.delegatesGL.glUniform3ui64ARB));
			}
			if (SuportedExt.Contains("glUniform3ui64NV"))
			{
				dgtk.OpenGL.internalGL.glUniform3ui64NV = (dgtk.OpenGL.delegatesGL.glUniform3ui64NV) InternalTool.GetGLMethodAdress("glUniform3ui64NV", typeof(dgtk.OpenGL.delegatesGL.glUniform3ui64NV));
			}
			if (SuportedExt.Contains("glUniform3ui64vARB"))
			{
				dgtk.OpenGL.internalGL.glUniform3ui64vARB = (dgtk.OpenGL.delegatesGL.glUniform3ui64vARB) InternalTool.GetGLMethodAdress("glUniform3ui64vARB", typeof(dgtk.OpenGL.delegatesGL.glUniform3ui64vARB));
			}
			if (SuportedExt.Contains("glUniform3ui64vNV"))
			{
				dgtk.OpenGL.internalGL.glUniform3ui64vNV = (dgtk.OpenGL.delegatesGL.glUniform3ui64vNV) InternalTool.GetGLMethodAdress("glUniform3ui64vNV", typeof(dgtk.OpenGL.delegatesGL.glUniform3ui64vNV));
			}
			if (SuportedExt.Contains("glUniform3uiEXT"))
			{
				dgtk.OpenGL.internalGL.glUniform3uiEXT = (dgtk.OpenGL.delegatesGL.glUniform3uiEXT) InternalTool.GetGLMethodAdress("glUniform3uiEXT", typeof(dgtk.OpenGL.delegatesGL.glUniform3uiEXT));
			}
			if (SuportedExt.Contains("glUniform3uivEXT"))
			{
				dgtk.OpenGL.internalGL.glUniform3uivEXT = (dgtk.OpenGL.delegatesGL.glUniform3uivEXT) InternalTool.GetGLMethodAdress("glUniform3uivEXT", typeof(dgtk.OpenGL.delegatesGL.glUniform3uivEXT));
			}
			if (SuportedExt.Contains("glUniform4fARB"))
			{
				dgtk.OpenGL.internalGL.glUniform4fARB = (dgtk.OpenGL.delegatesGL.glUniform4fARB) InternalTool.GetGLMethodAdress("glUniform4fARB", typeof(dgtk.OpenGL.delegatesGL.glUniform4fARB));
			}
			if (SuportedExt.Contains("glUniform4fvARB"))
			{
				dgtk.OpenGL.internalGL.glUniform4fvARB = (dgtk.OpenGL.delegatesGL.glUniform4fvARB) InternalTool.GetGLMethodAdress("glUniform4fvARB", typeof(dgtk.OpenGL.delegatesGL.glUniform4fvARB));
			}
			if (SuportedExt.Contains("glUniform4i64ARB"))
			{
				dgtk.OpenGL.internalGL.glUniform4i64ARB = (dgtk.OpenGL.delegatesGL.glUniform4i64ARB) InternalTool.GetGLMethodAdress("glUniform4i64ARB", typeof(dgtk.OpenGL.delegatesGL.glUniform4i64ARB));
			}
			if (SuportedExt.Contains("glUniform4i64NV"))
			{
				dgtk.OpenGL.internalGL.glUniform4i64NV = (dgtk.OpenGL.delegatesGL.glUniform4i64NV) InternalTool.GetGLMethodAdress("glUniform4i64NV", typeof(dgtk.OpenGL.delegatesGL.glUniform4i64NV));
			}
			if (SuportedExt.Contains("glUniform4i64vARB"))
			{
				dgtk.OpenGL.internalGL.glUniform4i64vARB = (dgtk.OpenGL.delegatesGL.glUniform4i64vARB) InternalTool.GetGLMethodAdress("glUniform4i64vARB", typeof(dgtk.OpenGL.delegatesGL.glUniform4i64vARB));
			}
			if (SuportedExt.Contains("glUniform4i64vNV"))
			{
				dgtk.OpenGL.internalGL.glUniform4i64vNV = (dgtk.OpenGL.delegatesGL.glUniform4i64vNV) InternalTool.GetGLMethodAdress("glUniform4i64vNV", typeof(dgtk.OpenGL.delegatesGL.glUniform4i64vNV));
			}
			if (SuportedExt.Contains("glUniform4iARB"))
			{
				dgtk.OpenGL.internalGL.glUniform4iARB = (dgtk.OpenGL.delegatesGL.glUniform4iARB) InternalTool.GetGLMethodAdress("glUniform4iARB", typeof(dgtk.OpenGL.delegatesGL.glUniform4iARB));
			}
			if (SuportedExt.Contains("glUniform4ivARB"))
			{
				dgtk.OpenGL.internalGL.glUniform4ivARB = (dgtk.OpenGL.delegatesGL.glUniform4ivARB) InternalTool.GetGLMethodAdress("glUniform4ivARB", typeof(dgtk.OpenGL.delegatesGL.glUniform4ivARB));
			}
			if (SuportedExt.Contains("glUniform4ui64ARB"))
			{
				dgtk.OpenGL.internalGL.glUniform4ui64ARB = (dgtk.OpenGL.delegatesGL.glUniform4ui64ARB) InternalTool.GetGLMethodAdress("glUniform4ui64ARB", typeof(dgtk.OpenGL.delegatesGL.glUniform4ui64ARB));
			}
			if (SuportedExt.Contains("glUniform4ui64NV"))
			{
				dgtk.OpenGL.internalGL.glUniform4ui64NV = (dgtk.OpenGL.delegatesGL.glUniform4ui64NV) InternalTool.GetGLMethodAdress("glUniform4ui64NV", typeof(dgtk.OpenGL.delegatesGL.glUniform4ui64NV));
			}
			if (SuportedExt.Contains("glUniform4ui64vARB"))
			{
				dgtk.OpenGL.internalGL.glUniform4ui64vARB = (dgtk.OpenGL.delegatesGL.glUniform4ui64vARB) InternalTool.GetGLMethodAdress("glUniform4ui64vARB", typeof(dgtk.OpenGL.delegatesGL.glUniform4ui64vARB));
			}
			if (SuportedExt.Contains("glUniform4ui64vNV"))
			{
				dgtk.OpenGL.internalGL.glUniform4ui64vNV = (dgtk.OpenGL.delegatesGL.glUniform4ui64vNV) InternalTool.GetGLMethodAdress("glUniform4ui64vNV", typeof(dgtk.OpenGL.delegatesGL.glUniform4ui64vNV));
			}
			if (SuportedExt.Contains("glUniform4uiEXT"))
			{
				dgtk.OpenGL.internalGL.glUniform4uiEXT = (dgtk.OpenGL.delegatesGL.glUniform4uiEXT) InternalTool.GetGLMethodAdress("glUniform4uiEXT", typeof(dgtk.OpenGL.delegatesGL.glUniform4uiEXT));
			}
			if (SuportedExt.Contains("glUniform4uivEXT"))
			{
				dgtk.OpenGL.internalGL.glUniform4uivEXT = (dgtk.OpenGL.delegatesGL.glUniform4uivEXT) InternalTool.GetGLMethodAdress("glUniform4uivEXT", typeof(dgtk.OpenGL.delegatesGL.glUniform4uivEXT));
			}
			if (SuportedExt.Contains("glUniformBufferEXT"))
			{
				dgtk.OpenGL.internalGL.glUniformBufferEXT = (dgtk.OpenGL.delegatesGL.glUniformBufferEXT) InternalTool.GetGLMethodAdress("glUniformBufferEXT", typeof(dgtk.OpenGL.delegatesGL.glUniformBufferEXT));
			}
			if (SuportedExt.Contains("glUniformHandleui64ARB"))
			{
				dgtk.OpenGL.internalGL.glUniformHandleui64ARB = (dgtk.OpenGL.delegatesGL.glUniformHandleui64ARB) InternalTool.GetGLMethodAdress("glUniformHandleui64ARB", typeof(dgtk.OpenGL.delegatesGL.glUniformHandleui64ARB));
			}
			if (SuportedExt.Contains("glUniformHandleui64IMG"))
			{
				dgtk.OpenGL.internalGL.glUniformHandleui64IMG = (dgtk.OpenGL.delegatesGL.glUniformHandleui64IMG) InternalTool.GetGLMethodAdress("glUniformHandleui64IMG", typeof(dgtk.OpenGL.delegatesGL.glUniformHandleui64IMG));
			}
			if (SuportedExt.Contains("glUniformHandleui64NV"))
			{
				dgtk.OpenGL.internalGL.glUniformHandleui64NV = (dgtk.OpenGL.delegatesGL.glUniformHandleui64NV) InternalTool.GetGLMethodAdress("glUniformHandleui64NV", typeof(dgtk.OpenGL.delegatesGL.glUniformHandleui64NV));
			}
			if (SuportedExt.Contains("glUniformHandleui64vARB"))
			{
				dgtk.OpenGL.internalGL.glUniformHandleui64vARB = (dgtk.OpenGL.delegatesGL.glUniformHandleui64vARB) InternalTool.GetGLMethodAdress("glUniformHandleui64vARB", typeof(dgtk.OpenGL.delegatesGL.glUniformHandleui64vARB));
			}
			if (SuportedExt.Contains("glUniformHandleui64vIMG"))
			{
				dgtk.OpenGL.internalGL.glUniformHandleui64vIMG = (dgtk.OpenGL.delegatesGL.glUniformHandleui64vIMG) InternalTool.GetGLMethodAdress("glUniformHandleui64vIMG", typeof(dgtk.OpenGL.delegatesGL.glUniformHandleui64vIMG));
			}
			if (SuportedExt.Contains("glUniformHandleui64vNV"))
			{
				dgtk.OpenGL.internalGL.glUniformHandleui64vNV = (dgtk.OpenGL.delegatesGL.glUniformHandleui64vNV) InternalTool.GetGLMethodAdress("glUniformHandleui64vNV", typeof(dgtk.OpenGL.delegatesGL.glUniformHandleui64vNV));
			}
			if (SuportedExt.Contains("glUniformMatrix2fvARB"))
			{
				dgtk.OpenGL.internalGL.glUniformMatrix2fvARB = (dgtk.OpenGL.delegatesGL.glUniformMatrix2fvARB) InternalTool.GetGLMethodAdress("glUniformMatrix2fvARB", typeof(dgtk.OpenGL.delegatesGL.glUniformMatrix2fvARB));
			}
			if (SuportedExt.Contains("glUniformMatrix2x3fvNV"))
			{
				dgtk.OpenGL.internalGL.glUniformMatrix2x3fvNV = (dgtk.OpenGL.delegatesGL.glUniformMatrix2x3fvNV) InternalTool.GetGLMethodAdress("glUniformMatrix2x3fvNV", typeof(dgtk.OpenGL.delegatesGL.glUniformMatrix2x3fvNV));
			}
			if (SuportedExt.Contains("glUniformMatrix2x4fvNV"))
			{
				dgtk.OpenGL.internalGL.glUniformMatrix2x4fvNV = (dgtk.OpenGL.delegatesGL.glUniformMatrix2x4fvNV) InternalTool.GetGLMethodAdress("glUniformMatrix2x4fvNV", typeof(dgtk.OpenGL.delegatesGL.glUniformMatrix2x4fvNV));
			}
			if (SuportedExt.Contains("glUniformMatrix3fvARB"))
			{
				dgtk.OpenGL.internalGL.glUniformMatrix3fvARB = (dgtk.OpenGL.delegatesGL.glUniformMatrix3fvARB) InternalTool.GetGLMethodAdress("glUniformMatrix3fvARB", typeof(dgtk.OpenGL.delegatesGL.glUniformMatrix3fvARB));
			}
			if (SuportedExt.Contains("glUniformMatrix3x2fvNV"))
			{
				dgtk.OpenGL.internalGL.glUniformMatrix3x2fvNV = (dgtk.OpenGL.delegatesGL.glUniformMatrix3x2fvNV) InternalTool.GetGLMethodAdress("glUniformMatrix3x2fvNV", typeof(dgtk.OpenGL.delegatesGL.glUniformMatrix3x2fvNV));
			}
			if (SuportedExt.Contains("glUniformMatrix3x4fvNV"))
			{
				dgtk.OpenGL.internalGL.glUniformMatrix3x4fvNV = (dgtk.OpenGL.delegatesGL.glUniformMatrix3x4fvNV) InternalTool.GetGLMethodAdress("glUniformMatrix3x4fvNV", typeof(dgtk.OpenGL.delegatesGL.glUniformMatrix3x4fvNV));
			}
			if (SuportedExt.Contains("glUniformMatrix4fvARB"))
			{
				dgtk.OpenGL.internalGL.glUniformMatrix4fvARB = (dgtk.OpenGL.delegatesGL.glUniformMatrix4fvARB) InternalTool.GetGLMethodAdress("glUniformMatrix4fvARB", typeof(dgtk.OpenGL.delegatesGL.glUniformMatrix4fvARB));
			}
			if (SuportedExt.Contains("glUniformMatrix4x2fvNV"))
			{
				dgtk.OpenGL.internalGL.glUniformMatrix4x2fvNV = (dgtk.OpenGL.delegatesGL.glUniformMatrix4x2fvNV) InternalTool.GetGLMethodAdress("glUniformMatrix4x2fvNV", typeof(dgtk.OpenGL.delegatesGL.glUniformMatrix4x2fvNV));
			}
			if (SuportedExt.Contains("glUniformMatrix4x3fvNV"))
			{
				dgtk.OpenGL.internalGL.glUniformMatrix4x3fvNV = (dgtk.OpenGL.delegatesGL.glUniformMatrix4x3fvNV) InternalTool.GetGLMethodAdress("glUniformMatrix4x3fvNV", typeof(dgtk.OpenGL.delegatesGL.glUniformMatrix4x3fvNV));
			}
			if (SuportedExt.Contains("glUniformui64NV"))
			{
				dgtk.OpenGL.internalGL.glUniformui64NV = (dgtk.OpenGL.delegatesGL.glUniformui64NV) InternalTool.GetGLMethodAdress("glUniformui64NV", typeof(dgtk.OpenGL.delegatesGL.glUniformui64NV));
			}
			if (SuportedExt.Contains("glUniformui64vNV"))
			{
				dgtk.OpenGL.internalGL.glUniformui64vNV = (dgtk.OpenGL.delegatesGL.glUniformui64vNV) InternalTool.GetGLMethodAdress("glUniformui64vNV", typeof(dgtk.OpenGL.delegatesGL.glUniformui64vNV));
			}
			if (SuportedExt.Contains("glUnlockArraysEXT"))
			{
				dgtk.OpenGL.internalGL.glUnlockArraysEXT = (dgtk.OpenGL.delegatesGL.glUnlockArraysEXT) InternalTool.GetGLMethodAdress("glUnlockArraysEXT", typeof(dgtk.OpenGL.delegatesGL.glUnlockArraysEXT));
			}
			if (SuportedExt.Contains("glUnmapBufferARB"))
			{
				dgtk.OpenGL.internalGL.glUnmapBufferARB = (dgtk.OpenGL.delegatesGL.glUnmapBufferARB) InternalTool.GetGLMethodAdress("glUnmapBufferARB", typeof(dgtk.OpenGL.delegatesGL.glUnmapBufferARB));
			}
			if (SuportedExt.Contains("glUnmapBufferOES"))
			{
				dgtk.OpenGL.internalGL.glUnmapBufferOES = (dgtk.OpenGL.delegatesGL.glUnmapBufferOES) InternalTool.GetGLMethodAdress("glUnmapBufferOES", typeof(dgtk.OpenGL.delegatesGL.glUnmapBufferOES));
			}
			if (SuportedExt.Contains("glUnmapNamedBufferEXT"))
			{
				dgtk.OpenGL.internalGL.glUnmapNamedBufferEXT = (dgtk.OpenGL.delegatesGL.glUnmapNamedBufferEXT) InternalTool.GetGLMethodAdress("glUnmapNamedBufferEXT", typeof(dgtk.OpenGL.delegatesGL.glUnmapNamedBufferEXT));
			}
			if (SuportedExt.Contains("glUnmapObjectBufferATI"))
			{
				dgtk.OpenGL.internalGL.glUnmapObjectBufferATI = (dgtk.OpenGL.delegatesGL.glUnmapObjectBufferATI) InternalTool.GetGLMethodAdress("glUnmapObjectBufferATI", typeof(dgtk.OpenGL.delegatesGL.glUnmapObjectBufferATI));
			}
			if (SuportedExt.Contains("glUnmapTexture2DINTEL"))
			{
				dgtk.OpenGL.internalGL.glUnmapTexture2DINTEL = (dgtk.OpenGL.delegatesGL.glUnmapTexture2DINTEL) InternalTool.GetGLMethodAdress("glUnmapTexture2DINTEL", typeof(dgtk.OpenGL.delegatesGL.glUnmapTexture2DINTEL));
			}
			if (SuportedExt.Contains("glUpdateObjectBufferATI"))
			{
				dgtk.OpenGL.internalGL.glUpdateObjectBufferATI = (dgtk.OpenGL.delegatesGL.glUpdateObjectBufferATI) InternalTool.GetGLMethodAdress("glUpdateObjectBufferATI", typeof(dgtk.OpenGL.delegatesGL.glUpdateObjectBufferATI));
			}
			if (SuportedExt.Contains("glUploadGpuMaskNVX"))
			{
				dgtk.OpenGL.internalGL.glUploadGpuMaskNVX = (dgtk.OpenGL.delegatesGL.glUploadGpuMaskNVX) InternalTool.GetGLMethodAdress("glUploadGpuMaskNVX", typeof(dgtk.OpenGL.delegatesGL.glUploadGpuMaskNVX));
			}
			if (SuportedExt.Contains("glUseProgramObjectARB"))
			{
				dgtk.OpenGL.internalGL.glUseProgramObjectARB = (dgtk.OpenGL.delegatesGL.glUseProgramObjectARB) InternalTool.GetGLMethodAdress("glUseProgramObjectARB", typeof(dgtk.OpenGL.delegatesGL.glUseProgramObjectARB));
			}
			if (SuportedExt.Contains("glUseProgramStagesEXT"))
			{
				dgtk.OpenGL.internalGL.glUseProgramStagesEXT = (dgtk.OpenGL.delegatesGL.glUseProgramStagesEXT) InternalTool.GetGLMethodAdress("glUseProgramStagesEXT", typeof(dgtk.OpenGL.delegatesGL.glUseProgramStagesEXT));
			}
			if (SuportedExt.Contains("glUseShaderProgramEXT"))
			{
				dgtk.OpenGL.internalGL.glUseShaderProgramEXT = (dgtk.OpenGL.delegatesGL.glUseShaderProgramEXT) InternalTool.GetGLMethodAdress("glUseShaderProgramEXT", typeof(dgtk.OpenGL.delegatesGL.glUseShaderProgramEXT));
			}
			#endregion

			#region V:

			if (SuportedExt.Contains("glValidateProgramARB"))
			{
				dgtk.OpenGL.internalGL.glValidateProgramARB = (dgtk.OpenGL.delegatesGL.glValidateProgramARB) InternalTool.GetGLMethodAdress("glValidateProgramARB", typeof(dgtk.OpenGL.delegatesGL.glValidateProgramARB));
			}
			if (SuportedExt.Contains("glValidateProgramPipelineEXT"))
			{
				dgtk.OpenGL.internalGL.glValidateProgramPipelineEXT = (dgtk.OpenGL.delegatesGL.glValidateProgramPipelineEXT) InternalTool.GetGLMethodAdress("glValidateProgramPipelineEXT", typeof(dgtk.OpenGL.delegatesGL.glValidateProgramPipelineEXT));
			}
			if (SuportedExt.Contains("glVariantArrayObjectATI"))
			{
				dgtk.OpenGL.internalGL.glVariantArrayObjectATI = (dgtk.OpenGL.delegatesGL.glVariantArrayObjectATI) InternalTool.GetGLMethodAdress("glVariantArrayObjectATI", typeof(dgtk.OpenGL.delegatesGL.glVariantArrayObjectATI));
			}
			if (SuportedExt.Contains("glVariantbvEXT"))
			{
				dgtk.OpenGL.internalGL.glVariantbvEXT = (dgtk.OpenGL.delegatesGL.glVariantbvEXT) InternalTool.GetGLMethodAdress("glVariantbvEXT", typeof(dgtk.OpenGL.delegatesGL.glVariantbvEXT));
			}
			if (SuportedExt.Contains("glVariantdvEXT"))
			{
				dgtk.OpenGL.internalGL.glVariantdvEXT = (dgtk.OpenGL.delegatesGL.glVariantdvEXT) InternalTool.GetGLMethodAdress("glVariantdvEXT", typeof(dgtk.OpenGL.delegatesGL.glVariantdvEXT));
			}
			if (SuportedExt.Contains("glVariantfvEXT"))
			{
				dgtk.OpenGL.internalGL.glVariantfvEXT = (dgtk.OpenGL.delegatesGL.glVariantfvEXT) InternalTool.GetGLMethodAdress("glVariantfvEXT", typeof(dgtk.OpenGL.delegatesGL.glVariantfvEXT));
			}
			if (SuportedExt.Contains("glVariantivEXT"))
			{
				dgtk.OpenGL.internalGL.glVariantivEXT = (dgtk.OpenGL.delegatesGL.glVariantivEXT) InternalTool.GetGLMethodAdress("glVariantivEXT", typeof(dgtk.OpenGL.delegatesGL.glVariantivEXT));
			}
			if (SuportedExt.Contains("glVariantPointerEXT"))
			{
				dgtk.OpenGL.internalGL.glVariantPointerEXT = (dgtk.OpenGL.delegatesGL.glVariantPointerEXT) InternalTool.GetGLMethodAdress("glVariantPointerEXT", typeof(dgtk.OpenGL.delegatesGL.glVariantPointerEXT));
			}
			if (SuportedExt.Contains("glVariantsvEXT"))
			{
				dgtk.OpenGL.internalGL.glVariantsvEXT = (dgtk.OpenGL.delegatesGL.glVariantsvEXT) InternalTool.GetGLMethodAdress("glVariantsvEXT", typeof(dgtk.OpenGL.delegatesGL.glVariantsvEXT));
			}
			if (SuportedExt.Contains("glVariantubvEXT"))
			{
				dgtk.OpenGL.internalGL.glVariantubvEXT = (dgtk.OpenGL.delegatesGL.glVariantubvEXT) InternalTool.GetGLMethodAdress("glVariantubvEXT", typeof(dgtk.OpenGL.delegatesGL.glVariantubvEXT));
			}
			if (SuportedExt.Contains("glVariantuivEXT"))
			{
				dgtk.OpenGL.internalGL.glVariantuivEXT = (dgtk.OpenGL.delegatesGL.glVariantuivEXT) InternalTool.GetGLMethodAdress("glVariantuivEXT", typeof(dgtk.OpenGL.delegatesGL.glVariantuivEXT));
			}
			if (SuportedExt.Contains("glVariantusvEXT"))
			{
				dgtk.OpenGL.internalGL.glVariantusvEXT = (dgtk.OpenGL.delegatesGL.glVariantusvEXT) InternalTool.GetGLMethodAdress("glVariantusvEXT", typeof(dgtk.OpenGL.delegatesGL.glVariantusvEXT));
			}
			if (SuportedExt.Contains("glVDPAUFiniNV"))
			{
				dgtk.OpenGL.internalGL.glVDPAUFiniNV = (dgtk.OpenGL.delegatesGL.glVDPAUFiniNV) InternalTool.GetGLMethodAdress("glVDPAUFiniNV", typeof(dgtk.OpenGL.delegatesGL.glVDPAUFiniNV));
			}
			if (SuportedExt.Contains("glVDPAUGetSurfaceivNV"))
			{
				dgtk.OpenGL.internalGL.glVDPAUGetSurfaceivNV = (dgtk.OpenGL.delegatesGL.glVDPAUGetSurfaceivNV) InternalTool.GetGLMethodAdress("glVDPAUGetSurfaceivNV", typeof(dgtk.OpenGL.delegatesGL.glVDPAUGetSurfaceivNV));
			}
			if (SuportedExt.Contains("glVDPAUInitNV"))
			{
				dgtk.OpenGL.internalGL.glVDPAUInitNV = (dgtk.OpenGL.delegatesGL.glVDPAUInitNV) InternalTool.GetGLMethodAdress("glVDPAUInitNV", typeof(dgtk.OpenGL.delegatesGL.glVDPAUInitNV));
			}
			if (SuportedExt.Contains("glVDPAUIsSurfaceNV"))
			{
				dgtk.OpenGL.internalGL.glVDPAUIsSurfaceNV = (dgtk.OpenGL.delegatesGL.glVDPAUIsSurfaceNV) InternalTool.GetGLMethodAdress("glVDPAUIsSurfaceNV", typeof(dgtk.OpenGL.delegatesGL.glVDPAUIsSurfaceNV));
			}
			if (SuportedExt.Contains("glVDPAUMapSurfacesNV"))
			{
				dgtk.OpenGL.internalGL.glVDPAUMapSurfacesNV = (dgtk.OpenGL.delegatesGL.glVDPAUMapSurfacesNV) InternalTool.GetGLMethodAdress("glVDPAUMapSurfacesNV", typeof(dgtk.OpenGL.delegatesGL.glVDPAUMapSurfacesNV));
			}
			if (SuportedExt.Contains("glVDPAURegisterOutputSurfaceNV"))
			{
				dgtk.OpenGL.internalGL.glVDPAURegisterOutputSurfaceNV = (dgtk.OpenGL.delegatesGL.glVDPAURegisterOutputSurfaceNV) InternalTool.GetGLMethodAdress("glVDPAURegisterOutputSurfaceNV", typeof(dgtk.OpenGL.delegatesGL.glVDPAURegisterOutputSurfaceNV));
			}
			if (SuportedExt.Contains("glVDPAURegisterVideoSurfaceNV"))
			{
				dgtk.OpenGL.internalGL.glVDPAURegisterVideoSurfaceNV = (dgtk.OpenGL.delegatesGL.glVDPAURegisterVideoSurfaceNV) InternalTool.GetGLMethodAdress("glVDPAURegisterVideoSurfaceNV", typeof(dgtk.OpenGL.delegatesGL.glVDPAURegisterVideoSurfaceNV));
			}
			if (SuportedExt.Contains("glVDPAURegisterVideoSurfaceWithPictureStructureNV"))
			{
				dgtk.OpenGL.internalGL.glVDPAURegisterVideoSurfaceWithPictureStructureNV = (dgtk.OpenGL.delegatesGL.glVDPAURegisterVideoSurfaceWithPictureStructureNV) InternalTool.GetGLMethodAdress("glVDPAURegisterVideoSurfaceWithPictureStructureNV", typeof(dgtk.OpenGL.delegatesGL.glVDPAURegisterVideoSurfaceWithPictureStructureNV));
			}
			if (SuportedExt.Contains("glVDPAUSurfaceAccessNV"))
			{
				dgtk.OpenGL.internalGL.glVDPAUSurfaceAccessNV = (dgtk.OpenGL.delegatesGL.glVDPAUSurfaceAccessNV) InternalTool.GetGLMethodAdress("glVDPAUSurfaceAccessNV", typeof(dgtk.OpenGL.delegatesGL.glVDPAUSurfaceAccessNV));
			}
			if (SuportedExt.Contains("glVDPAUUnmapSurfacesNV"))
			{
				dgtk.OpenGL.internalGL.glVDPAUUnmapSurfacesNV = (dgtk.OpenGL.delegatesGL.glVDPAUUnmapSurfacesNV) InternalTool.GetGLMethodAdress("glVDPAUUnmapSurfacesNV", typeof(dgtk.OpenGL.delegatesGL.glVDPAUUnmapSurfacesNV));
			}
			if (SuportedExt.Contains("glVDPAUUnregisterSurfaceNV"))
			{
				dgtk.OpenGL.internalGL.glVDPAUUnregisterSurfaceNV = (dgtk.OpenGL.delegatesGL.glVDPAUUnregisterSurfaceNV) InternalTool.GetGLMethodAdress("glVDPAUUnregisterSurfaceNV", typeof(dgtk.OpenGL.delegatesGL.glVDPAUUnregisterSurfaceNV));
			}
			if (SuportedExt.Contains("glVertex2bOES"))
			{
				dgtk.OpenGL.internalGL.glVertex2bOES = (dgtk.OpenGL.delegatesGL.glVertex2bOES) InternalTool.GetGLMethodAdress("glVertex2bOES", typeof(dgtk.OpenGL.delegatesGL.glVertex2bOES));
			}
			if (SuportedExt.Contains("glVertex2bvOES"))
			{
				dgtk.OpenGL.internalGL.glVertex2bvOES = (dgtk.OpenGL.delegatesGL.glVertex2bvOES) InternalTool.GetGLMethodAdress("glVertex2bvOES", typeof(dgtk.OpenGL.delegatesGL.glVertex2bvOES));
			}
			if (SuportedExt.Contains("glVertex2hNV"))
			{
				dgtk.OpenGL.internalGL.glVertex2hNV = (dgtk.OpenGL.delegatesGL.glVertex2hNV) InternalTool.GetGLMethodAdress("glVertex2hNV", typeof(dgtk.OpenGL.delegatesGL.glVertex2hNV));
			}
			if (SuportedExt.Contains("glVertex2hvNV"))
			{
				dgtk.OpenGL.internalGL.glVertex2hvNV = (dgtk.OpenGL.delegatesGL.glVertex2hvNV) InternalTool.GetGLMethodAdress("glVertex2hvNV", typeof(dgtk.OpenGL.delegatesGL.glVertex2hvNV));
			}
			if (SuportedExt.Contains("glVertex2xOES"))
			{
				dgtk.OpenGL.internalGL.glVertex2xOES = (dgtk.OpenGL.delegatesGL.glVertex2xOES) InternalTool.GetGLMethodAdress("glVertex2xOES", typeof(dgtk.OpenGL.delegatesGL.glVertex2xOES));
			}
			if (SuportedExt.Contains("glVertex2xvOES"))
			{
				dgtk.OpenGL.internalGL.glVertex2xvOES = (dgtk.OpenGL.delegatesGL.glVertex2xvOES) InternalTool.GetGLMethodAdress("glVertex2xvOES", typeof(dgtk.OpenGL.delegatesGL.glVertex2xvOES));
			}
			if (SuportedExt.Contains("glVertex3bOES"))
			{
				dgtk.OpenGL.internalGL.glVertex3bOES = (dgtk.OpenGL.delegatesGL.glVertex3bOES) InternalTool.GetGLMethodAdress("glVertex3bOES", typeof(dgtk.OpenGL.delegatesGL.glVertex3bOES));
			}
			if (SuportedExt.Contains("glVertex3bvOES"))
			{
				dgtk.OpenGL.internalGL.glVertex3bvOES = (dgtk.OpenGL.delegatesGL.glVertex3bvOES) InternalTool.GetGLMethodAdress("glVertex3bvOES", typeof(dgtk.OpenGL.delegatesGL.glVertex3bvOES));
			}
			if (SuportedExt.Contains("glVertex3hNV"))
			{
				dgtk.OpenGL.internalGL.glVertex3hNV = (dgtk.OpenGL.delegatesGL.glVertex3hNV) InternalTool.GetGLMethodAdress("glVertex3hNV", typeof(dgtk.OpenGL.delegatesGL.glVertex3hNV));
			}
			if (SuportedExt.Contains("glVertex3hvNV"))
			{
				dgtk.OpenGL.internalGL.glVertex3hvNV = (dgtk.OpenGL.delegatesGL.glVertex3hvNV) InternalTool.GetGLMethodAdress("glVertex3hvNV", typeof(dgtk.OpenGL.delegatesGL.glVertex3hvNV));
			}
			if (SuportedExt.Contains("glVertex3xOES"))
			{
				dgtk.OpenGL.internalGL.glVertex3xOES = (dgtk.OpenGL.delegatesGL.glVertex3xOES) InternalTool.GetGLMethodAdress("glVertex3xOES", typeof(dgtk.OpenGL.delegatesGL.glVertex3xOES));
			}
			if (SuportedExt.Contains("glVertex3xvOES"))
			{
				dgtk.OpenGL.internalGL.glVertex3xvOES = (dgtk.OpenGL.delegatesGL.glVertex3xvOES) InternalTool.GetGLMethodAdress("glVertex3xvOES", typeof(dgtk.OpenGL.delegatesGL.glVertex3xvOES));
			}
			if (SuportedExt.Contains("glVertex4bOES"))
			{
				dgtk.OpenGL.internalGL.glVertex4bOES = (dgtk.OpenGL.delegatesGL.glVertex4bOES) InternalTool.GetGLMethodAdress("glVertex4bOES", typeof(dgtk.OpenGL.delegatesGL.glVertex4bOES));
			}
			if (SuportedExt.Contains("glVertex4bvOES"))
			{
				dgtk.OpenGL.internalGL.glVertex4bvOES = (dgtk.OpenGL.delegatesGL.glVertex4bvOES) InternalTool.GetGLMethodAdress("glVertex4bvOES", typeof(dgtk.OpenGL.delegatesGL.glVertex4bvOES));
			}
			if (SuportedExt.Contains("glVertex4hNV"))
			{
				dgtk.OpenGL.internalGL.glVertex4hNV = (dgtk.OpenGL.delegatesGL.glVertex4hNV) InternalTool.GetGLMethodAdress("glVertex4hNV", typeof(dgtk.OpenGL.delegatesGL.glVertex4hNV));
			}
			if (SuportedExt.Contains("glVertex4hvNV"))
			{
				dgtk.OpenGL.internalGL.glVertex4hvNV = (dgtk.OpenGL.delegatesGL.glVertex4hvNV) InternalTool.GetGLMethodAdress("glVertex4hvNV", typeof(dgtk.OpenGL.delegatesGL.glVertex4hvNV));
			}
			if (SuportedExt.Contains("glVertex4xOES"))
			{
				dgtk.OpenGL.internalGL.glVertex4xOES = (dgtk.OpenGL.delegatesGL.glVertex4xOES) InternalTool.GetGLMethodAdress("glVertex4xOES", typeof(dgtk.OpenGL.delegatesGL.glVertex4xOES));
			}
			if (SuportedExt.Contains("glVertex4xvOES"))
			{
				dgtk.OpenGL.internalGL.glVertex4xvOES = (dgtk.OpenGL.delegatesGL.glVertex4xvOES) InternalTool.GetGLMethodAdress("glVertex4xvOES", typeof(dgtk.OpenGL.delegatesGL.glVertex4xvOES));
			}
			if (SuportedExt.Contains("glVertexArrayBindVertexBufferEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexArrayBindVertexBufferEXT = (dgtk.OpenGL.delegatesGL.glVertexArrayBindVertexBufferEXT) InternalTool.GetGLMethodAdress("glVertexArrayBindVertexBufferEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexArrayBindVertexBufferEXT));
			}
			if (SuportedExt.Contains("glVertexArrayColorOffsetEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexArrayColorOffsetEXT = (dgtk.OpenGL.delegatesGL.glVertexArrayColorOffsetEXT) InternalTool.GetGLMethodAdress("glVertexArrayColorOffsetEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexArrayColorOffsetEXT));
			}
			if (SuportedExt.Contains("glVertexArrayEdgeFlagOffsetEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexArrayEdgeFlagOffsetEXT = (dgtk.OpenGL.delegatesGL.glVertexArrayEdgeFlagOffsetEXT) InternalTool.GetGLMethodAdress("glVertexArrayEdgeFlagOffsetEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexArrayEdgeFlagOffsetEXT));
			}
			if (SuportedExt.Contains("glVertexArrayFogCoordOffsetEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexArrayFogCoordOffsetEXT = (dgtk.OpenGL.delegatesGL.glVertexArrayFogCoordOffsetEXT) InternalTool.GetGLMethodAdress("glVertexArrayFogCoordOffsetEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexArrayFogCoordOffsetEXT));
			}
			if (SuportedExt.Contains("glVertexArrayIndexOffsetEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexArrayIndexOffsetEXT = (dgtk.OpenGL.delegatesGL.glVertexArrayIndexOffsetEXT) InternalTool.GetGLMethodAdress("glVertexArrayIndexOffsetEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexArrayIndexOffsetEXT));
			}
			if (SuportedExt.Contains("glVertexArrayMultiTexCoordOffsetEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexArrayMultiTexCoordOffsetEXT = (dgtk.OpenGL.delegatesGL.glVertexArrayMultiTexCoordOffsetEXT) InternalTool.GetGLMethodAdress("glVertexArrayMultiTexCoordOffsetEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexArrayMultiTexCoordOffsetEXT));
			}
			if (SuportedExt.Contains("glVertexArrayNormalOffsetEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexArrayNormalOffsetEXT = (dgtk.OpenGL.delegatesGL.glVertexArrayNormalOffsetEXT) InternalTool.GetGLMethodAdress("glVertexArrayNormalOffsetEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexArrayNormalOffsetEXT));
			}
			if (SuportedExt.Contains("glVertexArrayParameteriAPPLE"))
			{
				dgtk.OpenGL.internalGL.glVertexArrayParameteriAPPLE = (dgtk.OpenGL.delegatesGL.glVertexArrayParameteriAPPLE) InternalTool.GetGLMethodAdress("glVertexArrayParameteriAPPLE", typeof(dgtk.OpenGL.delegatesGL.glVertexArrayParameteriAPPLE));
			}
			if (SuportedExt.Contains("glVertexArrayRangeAPPLE"))
			{
				dgtk.OpenGL.internalGL.glVertexArrayRangeAPPLE = (dgtk.OpenGL.delegatesGL.glVertexArrayRangeAPPLE) InternalTool.GetGLMethodAdress("glVertexArrayRangeAPPLE", typeof(dgtk.OpenGL.delegatesGL.glVertexArrayRangeAPPLE));
			}
			if (SuportedExt.Contains("glVertexArrayRangeNV"))
			{
				dgtk.OpenGL.internalGL.glVertexArrayRangeNV = (dgtk.OpenGL.delegatesGL.glVertexArrayRangeNV) InternalTool.GetGLMethodAdress("glVertexArrayRangeNV", typeof(dgtk.OpenGL.delegatesGL.glVertexArrayRangeNV));
			}
			if (SuportedExt.Contains("glVertexArraySecondaryColorOffsetEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexArraySecondaryColorOffsetEXT = (dgtk.OpenGL.delegatesGL.glVertexArraySecondaryColorOffsetEXT) InternalTool.GetGLMethodAdress("glVertexArraySecondaryColorOffsetEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexArraySecondaryColorOffsetEXT));
			}
			if (SuportedExt.Contains("glVertexArrayTexCoordOffsetEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexArrayTexCoordOffsetEXT = (dgtk.OpenGL.delegatesGL.glVertexArrayTexCoordOffsetEXT) InternalTool.GetGLMethodAdress("glVertexArrayTexCoordOffsetEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexArrayTexCoordOffsetEXT));
			}
			if (SuportedExt.Contains("glVertexArrayVertexAttribBindingEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexArrayVertexAttribBindingEXT = (dgtk.OpenGL.delegatesGL.glVertexArrayVertexAttribBindingEXT) InternalTool.GetGLMethodAdress("glVertexArrayVertexAttribBindingEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexArrayVertexAttribBindingEXT));
			}
			if (SuportedExt.Contains("glVertexArrayVertexAttribDivisorEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexArrayVertexAttribDivisorEXT = (dgtk.OpenGL.delegatesGL.glVertexArrayVertexAttribDivisorEXT) InternalTool.GetGLMethodAdress("glVertexArrayVertexAttribDivisorEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexArrayVertexAttribDivisorEXT));
			}
			if (SuportedExt.Contains("glVertexArrayVertexAttribFormatEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexArrayVertexAttribFormatEXT = (dgtk.OpenGL.delegatesGL.glVertexArrayVertexAttribFormatEXT) InternalTool.GetGLMethodAdress("glVertexArrayVertexAttribFormatEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexArrayVertexAttribFormatEXT));
			}
			if (SuportedExt.Contains("glVertexArrayVertexAttribIFormatEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexArrayVertexAttribIFormatEXT = (dgtk.OpenGL.delegatesGL.glVertexArrayVertexAttribIFormatEXT) InternalTool.GetGLMethodAdress("glVertexArrayVertexAttribIFormatEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexArrayVertexAttribIFormatEXT));
			}
			if (SuportedExt.Contains("glVertexArrayVertexAttribIOffsetEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexArrayVertexAttribIOffsetEXT = (dgtk.OpenGL.delegatesGL.glVertexArrayVertexAttribIOffsetEXT) InternalTool.GetGLMethodAdress("glVertexArrayVertexAttribIOffsetEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexArrayVertexAttribIOffsetEXT));
			}
			if (SuportedExt.Contains("glVertexArrayVertexAttribLFormatEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexArrayVertexAttribLFormatEXT = (dgtk.OpenGL.delegatesGL.glVertexArrayVertexAttribLFormatEXT) InternalTool.GetGLMethodAdress("glVertexArrayVertexAttribLFormatEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexArrayVertexAttribLFormatEXT));
			}
			if (SuportedExt.Contains("glVertexArrayVertexAttribLOffsetEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexArrayVertexAttribLOffsetEXT = (dgtk.OpenGL.delegatesGL.glVertexArrayVertexAttribLOffsetEXT) InternalTool.GetGLMethodAdress("glVertexArrayVertexAttribLOffsetEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexArrayVertexAttribLOffsetEXT));
			}
			if (SuportedExt.Contains("glVertexArrayVertexAttribOffsetEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexArrayVertexAttribOffsetEXT = (dgtk.OpenGL.delegatesGL.glVertexArrayVertexAttribOffsetEXT) InternalTool.GetGLMethodAdress("glVertexArrayVertexAttribOffsetEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexArrayVertexAttribOffsetEXT));
			}
			if (SuportedExt.Contains("glVertexArrayVertexBindingDivisorEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexArrayVertexBindingDivisorEXT = (dgtk.OpenGL.delegatesGL.glVertexArrayVertexBindingDivisorEXT) InternalTool.GetGLMethodAdress("glVertexArrayVertexBindingDivisorEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexArrayVertexBindingDivisorEXT));
			}
			if (SuportedExt.Contains("glVertexArrayVertexOffsetEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexArrayVertexOffsetEXT = (dgtk.OpenGL.delegatesGL.glVertexArrayVertexOffsetEXT) InternalTool.GetGLMethodAdress("glVertexArrayVertexOffsetEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexArrayVertexOffsetEXT));
			}
			if (SuportedExt.Contains("glVertexAttrib1dARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib1dARB = (dgtk.OpenGL.delegatesGL.glVertexAttrib1dARB) InternalTool.GetGLMethodAdress("glVertexAttrib1dARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib1dARB));
			}
			if (SuportedExt.Contains("glVertexAttrib1dNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib1dNV = (dgtk.OpenGL.delegatesGL.glVertexAttrib1dNV) InternalTool.GetGLMethodAdress("glVertexAttrib1dNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib1dNV));
			}
			if (SuportedExt.Contains("glVertexAttrib1dvARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib1dvARB = (dgtk.OpenGL.delegatesGL.glVertexAttrib1dvARB) InternalTool.GetGLMethodAdress("glVertexAttrib1dvARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib1dvARB));
			}
			if (SuportedExt.Contains("glVertexAttrib1dvNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib1dvNV = (dgtk.OpenGL.delegatesGL.glVertexAttrib1dvNV) InternalTool.GetGLMethodAdress("glVertexAttrib1dvNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib1dvNV));
			}
			if (SuportedExt.Contains("glVertexAttrib1fARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib1fARB = (dgtk.OpenGL.delegatesGL.glVertexAttrib1fARB) InternalTool.GetGLMethodAdress("glVertexAttrib1fARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib1fARB));
			}
			if (SuportedExt.Contains("glVertexAttrib1fNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib1fNV = (dgtk.OpenGL.delegatesGL.glVertexAttrib1fNV) InternalTool.GetGLMethodAdress("glVertexAttrib1fNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib1fNV));
			}
			if (SuportedExt.Contains("glVertexAttrib1fvARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib1fvARB = (dgtk.OpenGL.delegatesGL.glVertexAttrib1fvARB) InternalTool.GetGLMethodAdress("glVertexAttrib1fvARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib1fvARB));
			}
			if (SuportedExt.Contains("glVertexAttrib1fvNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib1fvNV = (dgtk.OpenGL.delegatesGL.glVertexAttrib1fvNV) InternalTool.GetGLMethodAdress("glVertexAttrib1fvNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib1fvNV));
			}
			if (SuportedExt.Contains("glVertexAttrib1hNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib1hNV = (dgtk.OpenGL.delegatesGL.glVertexAttrib1hNV) InternalTool.GetGLMethodAdress("glVertexAttrib1hNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib1hNV));
			}
			if (SuportedExt.Contains("glVertexAttrib1hvNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib1hvNV = (dgtk.OpenGL.delegatesGL.glVertexAttrib1hvNV) InternalTool.GetGLMethodAdress("glVertexAttrib1hvNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib1hvNV));
			}
			if (SuportedExt.Contains("glVertexAttrib1sARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib1sARB = (dgtk.OpenGL.delegatesGL.glVertexAttrib1sARB) InternalTool.GetGLMethodAdress("glVertexAttrib1sARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib1sARB));
			}
			if (SuportedExt.Contains("glVertexAttrib1sNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib1sNV = (dgtk.OpenGL.delegatesGL.glVertexAttrib1sNV) InternalTool.GetGLMethodAdress("glVertexAttrib1sNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib1sNV));
			}
			if (SuportedExt.Contains("glVertexAttrib1svARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib1svARB = (dgtk.OpenGL.delegatesGL.glVertexAttrib1svARB) InternalTool.GetGLMethodAdress("glVertexAttrib1svARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib1svARB));
			}
			if (SuportedExt.Contains("glVertexAttrib1svNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib1svNV = (dgtk.OpenGL.delegatesGL.glVertexAttrib1svNV) InternalTool.GetGLMethodAdress("glVertexAttrib1svNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib1svNV));
			}
			if (SuportedExt.Contains("glVertexAttrib2dARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib2dARB = (dgtk.OpenGL.delegatesGL.glVertexAttrib2dARB) InternalTool.GetGLMethodAdress("glVertexAttrib2dARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib2dARB));
			}
			if (SuportedExt.Contains("glVertexAttrib2dNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib2dNV = (dgtk.OpenGL.delegatesGL.glVertexAttrib2dNV) InternalTool.GetGLMethodAdress("glVertexAttrib2dNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib2dNV));
			}
			if (SuportedExt.Contains("glVertexAttrib2dvARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib2dvARB = (dgtk.OpenGL.delegatesGL.glVertexAttrib2dvARB) InternalTool.GetGLMethodAdress("glVertexAttrib2dvARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib2dvARB));
			}
			if (SuportedExt.Contains("glVertexAttrib2dvNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib2dvNV = (dgtk.OpenGL.delegatesGL.glVertexAttrib2dvNV) InternalTool.GetGLMethodAdress("glVertexAttrib2dvNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib2dvNV));
			}
			if (SuportedExt.Contains("glVertexAttrib2fARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib2fARB = (dgtk.OpenGL.delegatesGL.glVertexAttrib2fARB) InternalTool.GetGLMethodAdress("glVertexAttrib2fARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib2fARB));
			}
			if (SuportedExt.Contains("glVertexAttrib2fNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib2fNV = (dgtk.OpenGL.delegatesGL.glVertexAttrib2fNV) InternalTool.GetGLMethodAdress("glVertexAttrib2fNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib2fNV));
			}
			if (SuportedExt.Contains("glVertexAttrib2fvARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib2fvARB = (dgtk.OpenGL.delegatesGL.glVertexAttrib2fvARB) InternalTool.GetGLMethodAdress("glVertexAttrib2fvARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib2fvARB));
			}
			if (SuportedExt.Contains("glVertexAttrib2fvNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib2fvNV = (dgtk.OpenGL.delegatesGL.glVertexAttrib2fvNV) InternalTool.GetGLMethodAdress("glVertexAttrib2fvNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib2fvNV));
			}
			if (SuportedExt.Contains("glVertexAttrib2hNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib2hNV = (dgtk.OpenGL.delegatesGL.glVertexAttrib2hNV) InternalTool.GetGLMethodAdress("glVertexAttrib2hNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib2hNV));
			}
			if (SuportedExt.Contains("glVertexAttrib2hvNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib2hvNV = (dgtk.OpenGL.delegatesGL.glVertexAttrib2hvNV) InternalTool.GetGLMethodAdress("glVertexAttrib2hvNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib2hvNV));
			}
			if (SuportedExt.Contains("glVertexAttrib2sARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib2sARB = (dgtk.OpenGL.delegatesGL.glVertexAttrib2sARB) InternalTool.GetGLMethodAdress("glVertexAttrib2sARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib2sARB));
			}
			if (SuportedExt.Contains("glVertexAttrib2sNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib2sNV = (dgtk.OpenGL.delegatesGL.glVertexAttrib2sNV) InternalTool.GetGLMethodAdress("glVertexAttrib2sNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib2sNV));
			}
			if (SuportedExt.Contains("glVertexAttrib2svARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib2svARB = (dgtk.OpenGL.delegatesGL.glVertexAttrib2svARB) InternalTool.GetGLMethodAdress("glVertexAttrib2svARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib2svARB));
			}
			if (SuportedExt.Contains("glVertexAttrib2svNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib2svNV = (dgtk.OpenGL.delegatesGL.glVertexAttrib2svNV) InternalTool.GetGLMethodAdress("glVertexAttrib2svNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib2svNV));
			}
			if (SuportedExt.Contains("glVertexAttrib3dARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib3dARB = (dgtk.OpenGL.delegatesGL.glVertexAttrib3dARB) InternalTool.GetGLMethodAdress("glVertexAttrib3dARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib3dARB));
			}
			if (SuportedExt.Contains("glVertexAttrib3dNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib3dNV = (dgtk.OpenGL.delegatesGL.glVertexAttrib3dNV) InternalTool.GetGLMethodAdress("glVertexAttrib3dNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib3dNV));
			}
			if (SuportedExt.Contains("glVertexAttrib3dvARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib3dvARB = (dgtk.OpenGL.delegatesGL.glVertexAttrib3dvARB) InternalTool.GetGLMethodAdress("glVertexAttrib3dvARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib3dvARB));
			}
			if (SuportedExt.Contains("glVertexAttrib3dvNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib3dvNV = (dgtk.OpenGL.delegatesGL.glVertexAttrib3dvNV) InternalTool.GetGLMethodAdress("glVertexAttrib3dvNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib3dvNV));
			}
			if (SuportedExt.Contains("glVertexAttrib3fARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib3fARB = (dgtk.OpenGL.delegatesGL.glVertexAttrib3fARB) InternalTool.GetGLMethodAdress("glVertexAttrib3fARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib3fARB));
			}
			if (SuportedExt.Contains("glVertexAttrib3fNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib3fNV = (dgtk.OpenGL.delegatesGL.glVertexAttrib3fNV) InternalTool.GetGLMethodAdress("glVertexAttrib3fNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib3fNV));
			}
			if (SuportedExt.Contains("glVertexAttrib3fvARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib3fvARB = (dgtk.OpenGL.delegatesGL.glVertexAttrib3fvARB) InternalTool.GetGLMethodAdress("glVertexAttrib3fvARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib3fvARB));
			}
			if (SuportedExt.Contains("glVertexAttrib3fvNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib3fvNV = (dgtk.OpenGL.delegatesGL.glVertexAttrib3fvNV) InternalTool.GetGLMethodAdress("glVertexAttrib3fvNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib3fvNV));
			}
			if (SuportedExt.Contains("glVertexAttrib3hNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib3hNV = (dgtk.OpenGL.delegatesGL.glVertexAttrib3hNV) InternalTool.GetGLMethodAdress("glVertexAttrib3hNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib3hNV));
			}
			if (SuportedExt.Contains("glVertexAttrib3hvNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib3hvNV = (dgtk.OpenGL.delegatesGL.glVertexAttrib3hvNV) InternalTool.GetGLMethodAdress("glVertexAttrib3hvNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib3hvNV));
			}
			if (SuportedExt.Contains("glVertexAttrib3sARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib3sARB = (dgtk.OpenGL.delegatesGL.glVertexAttrib3sARB) InternalTool.GetGLMethodAdress("glVertexAttrib3sARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib3sARB));
			}
			if (SuportedExt.Contains("glVertexAttrib3sNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib3sNV = (dgtk.OpenGL.delegatesGL.glVertexAttrib3sNV) InternalTool.GetGLMethodAdress("glVertexAttrib3sNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib3sNV));
			}
			if (SuportedExt.Contains("glVertexAttrib3svARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib3svARB = (dgtk.OpenGL.delegatesGL.glVertexAttrib3svARB) InternalTool.GetGLMethodAdress("glVertexAttrib3svARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib3svARB));
			}
			if (SuportedExt.Contains("glVertexAttrib3svNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib3svNV = (dgtk.OpenGL.delegatesGL.glVertexAttrib3svNV) InternalTool.GetGLMethodAdress("glVertexAttrib3svNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib3svNV));
			}
			if (SuportedExt.Contains("glVertexAttrib4bvARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib4bvARB = (dgtk.OpenGL.delegatesGL.glVertexAttrib4bvARB) InternalTool.GetGLMethodAdress("glVertexAttrib4bvARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib4bvARB));
			}
			if (SuportedExt.Contains("glVertexAttrib4dARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib4dARB = (dgtk.OpenGL.delegatesGL.glVertexAttrib4dARB) InternalTool.GetGLMethodAdress("glVertexAttrib4dARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib4dARB));
			}
			if (SuportedExt.Contains("glVertexAttrib4dNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib4dNV = (dgtk.OpenGL.delegatesGL.glVertexAttrib4dNV) InternalTool.GetGLMethodAdress("glVertexAttrib4dNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib4dNV));
			}
			if (SuportedExt.Contains("glVertexAttrib4dvARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib4dvARB = (dgtk.OpenGL.delegatesGL.glVertexAttrib4dvARB) InternalTool.GetGLMethodAdress("glVertexAttrib4dvARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib4dvARB));
			}
			if (SuportedExt.Contains("glVertexAttrib4dvNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib4dvNV = (dgtk.OpenGL.delegatesGL.glVertexAttrib4dvNV) InternalTool.GetGLMethodAdress("glVertexAttrib4dvNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib4dvNV));
			}
			if (SuportedExt.Contains("glVertexAttrib4fARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib4fARB = (dgtk.OpenGL.delegatesGL.glVertexAttrib4fARB) InternalTool.GetGLMethodAdress("glVertexAttrib4fARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib4fARB));
			}
			if (SuportedExt.Contains("glVertexAttrib4fNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib4fNV = (dgtk.OpenGL.delegatesGL.glVertexAttrib4fNV) InternalTool.GetGLMethodAdress("glVertexAttrib4fNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib4fNV));
			}
			if (SuportedExt.Contains("glVertexAttrib4fvARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib4fvARB = (dgtk.OpenGL.delegatesGL.glVertexAttrib4fvARB) InternalTool.GetGLMethodAdress("glVertexAttrib4fvARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib4fvARB));
			}
			if (SuportedExt.Contains("glVertexAttrib4fvNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib4fvNV = (dgtk.OpenGL.delegatesGL.glVertexAttrib4fvNV) InternalTool.GetGLMethodAdress("glVertexAttrib4fvNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib4fvNV));
			}
			if (SuportedExt.Contains("glVertexAttrib4hNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib4hNV = (dgtk.OpenGL.delegatesGL.glVertexAttrib4hNV) InternalTool.GetGLMethodAdress("glVertexAttrib4hNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib4hNV));
			}
			if (SuportedExt.Contains("glVertexAttrib4hvNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib4hvNV = (dgtk.OpenGL.delegatesGL.glVertexAttrib4hvNV) InternalTool.GetGLMethodAdress("glVertexAttrib4hvNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib4hvNV));
			}
			if (SuportedExt.Contains("glVertexAttrib4ivARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib4ivARB = (dgtk.OpenGL.delegatesGL.glVertexAttrib4ivARB) InternalTool.GetGLMethodAdress("glVertexAttrib4ivARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib4ivARB));
			}
			if (SuportedExt.Contains("glVertexAttrib4NbvARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib4NbvARB = (dgtk.OpenGL.delegatesGL.glVertexAttrib4NbvARB) InternalTool.GetGLMethodAdress("glVertexAttrib4NbvARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib4NbvARB));
			}
			if (SuportedExt.Contains("glVertexAttrib4NivARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib4NivARB = (dgtk.OpenGL.delegatesGL.glVertexAttrib4NivARB) InternalTool.GetGLMethodAdress("glVertexAttrib4NivARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib4NivARB));
			}
			if (SuportedExt.Contains("glVertexAttrib4NsvARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib4NsvARB = (dgtk.OpenGL.delegatesGL.glVertexAttrib4NsvARB) InternalTool.GetGLMethodAdress("glVertexAttrib4NsvARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib4NsvARB));
			}
			if (SuportedExt.Contains("glVertexAttrib4NubARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib4NubARB = (dgtk.OpenGL.delegatesGL.glVertexAttrib4NubARB) InternalTool.GetGLMethodAdress("glVertexAttrib4NubARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib4NubARB));
			}
			if (SuportedExt.Contains("glVertexAttrib4NubvARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib4NubvARB = (dgtk.OpenGL.delegatesGL.glVertexAttrib4NubvARB) InternalTool.GetGLMethodAdress("glVertexAttrib4NubvARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib4NubvARB));
			}
			if (SuportedExt.Contains("glVertexAttrib4NuivARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib4NuivARB = (dgtk.OpenGL.delegatesGL.glVertexAttrib4NuivARB) InternalTool.GetGLMethodAdress("glVertexAttrib4NuivARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib4NuivARB));
			}
			if (SuportedExt.Contains("glVertexAttrib4NusvARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib4NusvARB = (dgtk.OpenGL.delegatesGL.glVertexAttrib4NusvARB) InternalTool.GetGLMethodAdress("glVertexAttrib4NusvARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib4NusvARB));
			}
			if (SuportedExt.Contains("glVertexAttrib4sARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib4sARB = (dgtk.OpenGL.delegatesGL.glVertexAttrib4sARB) InternalTool.GetGLMethodAdress("glVertexAttrib4sARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib4sARB));
			}
			if (SuportedExt.Contains("glVertexAttrib4sNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib4sNV = (dgtk.OpenGL.delegatesGL.glVertexAttrib4sNV) InternalTool.GetGLMethodAdress("glVertexAttrib4sNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib4sNV));
			}
			if (SuportedExt.Contains("glVertexAttrib4svARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib4svARB = (dgtk.OpenGL.delegatesGL.glVertexAttrib4svARB) InternalTool.GetGLMethodAdress("glVertexAttrib4svARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib4svARB));
			}
			if (SuportedExt.Contains("glVertexAttrib4svNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib4svNV = (dgtk.OpenGL.delegatesGL.glVertexAttrib4svNV) InternalTool.GetGLMethodAdress("glVertexAttrib4svNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib4svNV));
			}
			if (SuportedExt.Contains("glVertexAttrib4ubNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib4ubNV = (dgtk.OpenGL.delegatesGL.glVertexAttrib4ubNV) InternalTool.GetGLMethodAdress("glVertexAttrib4ubNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib4ubNV));
			}
			if (SuportedExt.Contains("glVertexAttrib4ubvARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib4ubvARB = (dgtk.OpenGL.delegatesGL.glVertexAttrib4ubvARB) InternalTool.GetGLMethodAdress("glVertexAttrib4ubvARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib4ubvARB));
			}
			if (SuportedExt.Contains("glVertexAttrib4ubvNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib4ubvNV = (dgtk.OpenGL.delegatesGL.glVertexAttrib4ubvNV) InternalTool.GetGLMethodAdress("glVertexAttrib4ubvNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib4ubvNV));
			}
			if (SuportedExt.Contains("glVertexAttrib4uivARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib4uivARB = (dgtk.OpenGL.delegatesGL.glVertexAttrib4uivARB) InternalTool.GetGLMethodAdress("glVertexAttrib4uivARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib4uivARB));
			}
			if (SuportedExt.Contains("glVertexAttrib4usvARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttrib4usvARB = (dgtk.OpenGL.delegatesGL.glVertexAttrib4usvARB) InternalTool.GetGLMethodAdress("glVertexAttrib4usvARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttrib4usvARB));
			}
			if (SuportedExt.Contains("glVertexAttribArrayObjectATI"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribArrayObjectATI = (dgtk.OpenGL.delegatesGL.glVertexAttribArrayObjectATI) InternalTool.GetGLMethodAdress("glVertexAttribArrayObjectATI", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribArrayObjectATI));
			}
			if (SuportedExt.Contains("glVertexAttribDivisorANGLE"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribDivisorANGLE = (dgtk.OpenGL.delegatesGL.glVertexAttribDivisorANGLE) InternalTool.GetGLMethodAdress("glVertexAttribDivisorANGLE", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribDivisorANGLE));
			}
			if (SuportedExt.Contains("glVertexAttribDivisorARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribDivisorARB = (dgtk.OpenGL.delegatesGL.glVertexAttribDivisorARB) InternalTool.GetGLMethodAdress("glVertexAttribDivisorARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribDivisorARB));
			}
			if (SuportedExt.Contains("glVertexAttribDivisorEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribDivisorEXT = (dgtk.OpenGL.delegatesGL.glVertexAttribDivisorEXT) InternalTool.GetGLMethodAdress("glVertexAttribDivisorEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribDivisorEXT));
			}
			if (SuportedExt.Contains("glVertexAttribDivisorNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribDivisorNV = (dgtk.OpenGL.delegatesGL.glVertexAttribDivisorNV) InternalTool.GetGLMethodAdress("glVertexAttribDivisorNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribDivisorNV));
			}
			if (SuportedExt.Contains("glVertexAttribFormatNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribFormatNV = (dgtk.OpenGL.delegatesGL.glVertexAttribFormatNV) InternalTool.GetGLMethodAdress("glVertexAttribFormatNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribFormatNV));
			}
			if (SuportedExt.Contains("glVertexAttribI1iEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribI1iEXT = (dgtk.OpenGL.delegatesGL.glVertexAttribI1iEXT) InternalTool.GetGLMethodAdress("glVertexAttribI1iEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribI1iEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI1ivEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribI1ivEXT = (dgtk.OpenGL.delegatesGL.glVertexAttribI1ivEXT) InternalTool.GetGLMethodAdress("glVertexAttribI1ivEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribI1ivEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI1uiEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribI1uiEXT = (dgtk.OpenGL.delegatesGL.glVertexAttribI1uiEXT) InternalTool.GetGLMethodAdress("glVertexAttribI1uiEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribI1uiEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI1uivEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribI1uivEXT = (dgtk.OpenGL.delegatesGL.glVertexAttribI1uivEXT) InternalTool.GetGLMethodAdress("glVertexAttribI1uivEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribI1uivEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI2iEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribI2iEXT = (dgtk.OpenGL.delegatesGL.glVertexAttribI2iEXT) InternalTool.GetGLMethodAdress("glVertexAttribI2iEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribI2iEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI2ivEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribI2ivEXT = (dgtk.OpenGL.delegatesGL.glVertexAttribI2ivEXT) InternalTool.GetGLMethodAdress("glVertexAttribI2ivEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribI2ivEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI2uiEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribI2uiEXT = (dgtk.OpenGL.delegatesGL.glVertexAttribI2uiEXT) InternalTool.GetGLMethodAdress("glVertexAttribI2uiEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribI2uiEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI2uivEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribI2uivEXT = (dgtk.OpenGL.delegatesGL.glVertexAttribI2uivEXT) InternalTool.GetGLMethodAdress("glVertexAttribI2uivEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribI2uivEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI3iEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribI3iEXT = (dgtk.OpenGL.delegatesGL.glVertexAttribI3iEXT) InternalTool.GetGLMethodAdress("glVertexAttribI3iEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribI3iEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI3ivEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribI3ivEXT = (dgtk.OpenGL.delegatesGL.glVertexAttribI3ivEXT) InternalTool.GetGLMethodAdress("glVertexAttribI3ivEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribI3ivEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI3uiEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribI3uiEXT = (dgtk.OpenGL.delegatesGL.glVertexAttribI3uiEXT) InternalTool.GetGLMethodAdress("glVertexAttribI3uiEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribI3uiEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI3uivEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribI3uivEXT = (dgtk.OpenGL.delegatesGL.glVertexAttribI3uivEXT) InternalTool.GetGLMethodAdress("glVertexAttribI3uivEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribI3uivEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI4bvEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribI4bvEXT = (dgtk.OpenGL.delegatesGL.glVertexAttribI4bvEXT) InternalTool.GetGLMethodAdress("glVertexAttribI4bvEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribI4bvEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI4iEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribI4iEXT = (dgtk.OpenGL.delegatesGL.glVertexAttribI4iEXT) InternalTool.GetGLMethodAdress("glVertexAttribI4iEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribI4iEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI4ivEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribI4ivEXT = (dgtk.OpenGL.delegatesGL.glVertexAttribI4ivEXT) InternalTool.GetGLMethodAdress("glVertexAttribI4ivEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribI4ivEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI4svEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribI4svEXT = (dgtk.OpenGL.delegatesGL.glVertexAttribI4svEXT) InternalTool.GetGLMethodAdress("glVertexAttribI4svEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribI4svEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI4ubvEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribI4ubvEXT = (dgtk.OpenGL.delegatesGL.glVertexAttribI4ubvEXT) InternalTool.GetGLMethodAdress("glVertexAttribI4ubvEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribI4ubvEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI4uiEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribI4uiEXT = (dgtk.OpenGL.delegatesGL.glVertexAttribI4uiEXT) InternalTool.GetGLMethodAdress("glVertexAttribI4uiEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribI4uiEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI4uivEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribI4uivEXT = (dgtk.OpenGL.delegatesGL.glVertexAttribI4uivEXT) InternalTool.GetGLMethodAdress("glVertexAttribI4uivEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribI4uivEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI4usvEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribI4usvEXT = (dgtk.OpenGL.delegatesGL.glVertexAttribI4usvEXT) InternalTool.GetGLMethodAdress("glVertexAttribI4usvEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribI4usvEXT));
			}
			if (SuportedExt.Contains("glVertexAttribIFormatNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribIFormatNV = (dgtk.OpenGL.delegatesGL.glVertexAttribIFormatNV) InternalTool.GetGLMethodAdress("glVertexAttribIFormatNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribIFormatNV));
			}
			if (SuportedExt.Contains("glVertexAttribIPointerEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribIPointerEXT = (dgtk.OpenGL.delegatesGL.glVertexAttribIPointerEXT) InternalTool.GetGLMethodAdress("glVertexAttribIPointerEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribIPointerEXT));
			}
			if (SuportedExt.Contains("glVertexAttribL1dEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribL1dEXT = (dgtk.OpenGL.delegatesGL.glVertexAttribL1dEXT) InternalTool.GetGLMethodAdress("glVertexAttribL1dEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribL1dEXT));
			}
			if (SuportedExt.Contains("glVertexAttribL1dvEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribL1dvEXT = (dgtk.OpenGL.delegatesGL.glVertexAttribL1dvEXT) InternalTool.GetGLMethodAdress("glVertexAttribL1dvEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribL1dvEXT));
			}
			if (SuportedExt.Contains("glVertexAttribL1i64NV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribL1i64NV = (dgtk.OpenGL.delegatesGL.glVertexAttribL1i64NV) InternalTool.GetGLMethodAdress("glVertexAttribL1i64NV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribL1i64NV));
			}
			if (SuportedExt.Contains("glVertexAttribL1i64vNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribL1i64vNV = (dgtk.OpenGL.delegatesGL.glVertexAttribL1i64vNV) InternalTool.GetGLMethodAdress("glVertexAttribL1i64vNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribL1i64vNV));
			}
			if (SuportedExt.Contains("glVertexAttribL1ui64ARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribL1ui64ARB = (dgtk.OpenGL.delegatesGL.glVertexAttribL1ui64ARB) InternalTool.GetGLMethodAdress("glVertexAttribL1ui64ARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribL1ui64ARB));
			}
			if (SuportedExt.Contains("glVertexAttribL1ui64NV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribL1ui64NV = (dgtk.OpenGL.delegatesGL.glVertexAttribL1ui64NV) InternalTool.GetGLMethodAdress("glVertexAttribL1ui64NV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribL1ui64NV));
			}
			if (SuportedExt.Contains("glVertexAttribL1ui64vARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribL1ui64vARB = (dgtk.OpenGL.delegatesGL.glVertexAttribL1ui64vARB) InternalTool.GetGLMethodAdress("glVertexAttribL1ui64vARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribL1ui64vARB));
			}
			if (SuportedExt.Contains("glVertexAttribL1ui64vNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribL1ui64vNV = (dgtk.OpenGL.delegatesGL.glVertexAttribL1ui64vNV) InternalTool.GetGLMethodAdress("glVertexAttribL1ui64vNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribL1ui64vNV));
			}
			if (SuportedExt.Contains("glVertexAttribL2dEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribL2dEXT = (dgtk.OpenGL.delegatesGL.glVertexAttribL2dEXT) InternalTool.GetGLMethodAdress("glVertexAttribL2dEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribL2dEXT));
			}
			if (SuportedExt.Contains("glVertexAttribL2dvEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribL2dvEXT = (dgtk.OpenGL.delegatesGL.glVertexAttribL2dvEXT) InternalTool.GetGLMethodAdress("glVertexAttribL2dvEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribL2dvEXT));
			}
			if (SuportedExt.Contains("glVertexAttribL2i64NV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribL2i64NV = (dgtk.OpenGL.delegatesGL.glVertexAttribL2i64NV) InternalTool.GetGLMethodAdress("glVertexAttribL2i64NV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribL2i64NV));
			}
			if (SuportedExt.Contains("glVertexAttribL2i64vNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribL2i64vNV = (dgtk.OpenGL.delegatesGL.glVertexAttribL2i64vNV) InternalTool.GetGLMethodAdress("glVertexAttribL2i64vNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribL2i64vNV));
			}
			if (SuportedExt.Contains("glVertexAttribL2ui64NV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribL2ui64NV = (dgtk.OpenGL.delegatesGL.glVertexAttribL2ui64NV) InternalTool.GetGLMethodAdress("glVertexAttribL2ui64NV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribL2ui64NV));
			}
			if (SuportedExt.Contains("glVertexAttribL2ui64vNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribL2ui64vNV = (dgtk.OpenGL.delegatesGL.glVertexAttribL2ui64vNV) InternalTool.GetGLMethodAdress("glVertexAttribL2ui64vNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribL2ui64vNV));
			}
			if (SuportedExt.Contains("glVertexAttribL3dEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribL3dEXT = (dgtk.OpenGL.delegatesGL.glVertexAttribL3dEXT) InternalTool.GetGLMethodAdress("glVertexAttribL3dEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribL3dEXT));
			}
			if (SuportedExt.Contains("glVertexAttribL3dvEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribL3dvEXT = (dgtk.OpenGL.delegatesGL.glVertexAttribL3dvEXT) InternalTool.GetGLMethodAdress("glVertexAttribL3dvEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribL3dvEXT));
			}
			if (SuportedExt.Contains("glVertexAttribL3i64NV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribL3i64NV = (dgtk.OpenGL.delegatesGL.glVertexAttribL3i64NV) InternalTool.GetGLMethodAdress("glVertexAttribL3i64NV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribL3i64NV));
			}
			if (SuportedExt.Contains("glVertexAttribL3i64vNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribL3i64vNV = (dgtk.OpenGL.delegatesGL.glVertexAttribL3i64vNV) InternalTool.GetGLMethodAdress("glVertexAttribL3i64vNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribL3i64vNV));
			}
			if (SuportedExt.Contains("glVertexAttribL3ui64NV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribL3ui64NV = (dgtk.OpenGL.delegatesGL.glVertexAttribL3ui64NV) InternalTool.GetGLMethodAdress("glVertexAttribL3ui64NV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribL3ui64NV));
			}
			if (SuportedExt.Contains("glVertexAttribL3ui64vNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribL3ui64vNV = (dgtk.OpenGL.delegatesGL.glVertexAttribL3ui64vNV) InternalTool.GetGLMethodAdress("glVertexAttribL3ui64vNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribL3ui64vNV));
			}
			if (SuportedExt.Contains("glVertexAttribL4dEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribL4dEXT = (dgtk.OpenGL.delegatesGL.glVertexAttribL4dEXT) InternalTool.GetGLMethodAdress("glVertexAttribL4dEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribL4dEXT));
			}
			if (SuportedExt.Contains("glVertexAttribL4dvEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribL4dvEXT = (dgtk.OpenGL.delegatesGL.glVertexAttribL4dvEXT) InternalTool.GetGLMethodAdress("glVertexAttribL4dvEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribL4dvEXT));
			}
			if (SuportedExt.Contains("glVertexAttribL4i64NV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribL4i64NV = (dgtk.OpenGL.delegatesGL.glVertexAttribL4i64NV) InternalTool.GetGLMethodAdress("glVertexAttribL4i64NV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribL4i64NV));
			}
			if (SuportedExt.Contains("glVertexAttribL4i64vNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribL4i64vNV = (dgtk.OpenGL.delegatesGL.glVertexAttribL4i64vNV) InternalTool.GetGLMethodAdress("glVertexAttribL4i64vNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribL4i64vNV));
			}
			if (SuportedExt.Contains("glVertexAttribL4ui64NV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribL4ui64NV = (dgtk.OpenGL.delegatesGL.glVertexAttribL4ui64NV) InternalTool.GetGLMethodAdress("glVertexAttribL4ui64NV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribL4ui64NV));
			}
			if (SuportedExt.Contains("glVertexAttribL4ui64vNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribL4ui64vNV = (dgtk.OpenGL.delegatesGL.glVertexAttribL4ui64vNV) InternalTool.GetGLMethodAdress("glVertexAttribL4ui64vNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribL4ui64vNV));
			}
			if (SuportedExt.Contains("glVertexAttribLFormatNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribLFormatNV = (dgtk.OpenGL.delegatesGL.glVertexAttribLFormatNV) InternalTool.GetGLMethodAdress("glVertexAttribLFormatNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribLFormatNV));
			}
			if (SuportedExt.Contains("glVertexAttribLPointerEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribLPointerEXT = (dgtk.OpenGL.delegatesGL.glVertexAttribLPointerEXT) InternalTool.GetGLMethodAdress("glVertexAttribLPointerEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribLPointerEXT));
			}
			if (SuportedExt.Contains("glVertexAttribParameteriAMD"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribParameteriAMD = (dgtk.OpenGL.delegatesGL.glVertexAttribParameteriAMD) InternalTool.GetGLMethodAdress("glVertexAttribParameteriAMD", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribParameteriAMD));
			}
			if (SuportedExt.Contains("glVertexAttribPointerARB"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribPointerARB = (dgtk.OpenGL.delegatesGL.glVertexAttribPointerARB) InternalTool.GetGLMethodAdress("glVertexAttribPointerARB", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribPointerARB));
			}
			if (SuportedExt.Contains("glVertexAttribPointerNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribPointerNV = (dgtk.OpenGL.delegatesGL.glVertexAttribPointerNV) InternalTool.GetGLMethodAdress("glVertexAttribPointerNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribPointerNV));
			}
			if (SuportedExt.Contains("glVertexAttribs1dvNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribs1dvNV = (dgtk.OpenGL.delegatesGL.glVertexAttribs1dvNV) InternalTool.GetGLMethodAdress("glVertexAttribs1dvNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribs1dvNV));
			}
			if (SuportedExt.Contains("glVertexAttribs1fvNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribs1fvNV = (dgtk.OpenGL.delegatesGL.glVertexAttribs1fvNV) InternalTool.GetGLMethodAdress("glVertexAttribs1fvNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribs1fvNV));
			}
			if (SuportedExt.Contains("glVertexAttribs1hvNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribs1hvNV = (dgtk.OpenGL.delegatesGL.glVertexAttribs1hvNV) InternalTool.GetGLMethodAdress("glVertexAttribs1hvNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribs1hvNV));
			}
			if (SuportedExt.Contains("glVertexAttribs1svNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribs1svNV = (dgtk.OpenGL.delegatesGL.glVertexAttribs1svNV) InternalTool.GetGLMethodAdress("glVertexAttribs1svNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribs1svNV));
			}
			if (SuportedExt.Contains("glVertexAttribs2dvNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribs2dvNV = (dgtk.OpenGL.delegatesGL.glVertexAttribs2dvNV) InternalTool.GetGLMethodAdress("glVertexAttribs2dvNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribs2dvNV));
			}
			if (SuportedExt.Contains("glVertexAttribs2fvNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribs2fvNV = (dgtk.OpenGL.delegatesGL.glVertexAttribs2fvNV) InternalTool.GetGLMethodAdress("glVertexAttribs2fvNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribs2fvNV));
			}
			if (SuportedExt.Contains("glVertexAttribs2hvNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribs2hvNV = (dgtk.OpenGL.delegatesGL.glVertexAttribs2hvNV) InternalTool.GetGLMethodAdress("glVertexAttribs2hvNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribs2hvNV));
			}
			if (SuportedExt.Contains("glVertexAttribs2svNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribs2svNV = (dgtk.OpenGL.delegatesGL.glVertexAttribs2svNV) InternalTool.GetGLMethodAdress("glVertexAttribs2svNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribs2svNV));
			}
			if (SuportedExt.Contains("glVertexAttribs3dvNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribs3dvNV = (dgtk.OpenGL.delegatesGL.glVertexAttribs3dvNV) InternalTool.GetGLMethodAdress("glVertexAttribs3dvNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribs3dvNV));
			}
			if (SuportedExt.Contains("glVertexAttribs3fvNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribs3fvNV = (dgtk.OpenGL.delegatesGL.glVertexAttribs3fvNV) InternalTool.GetGLMethodAdress("glVertexAttribs3fvNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribs3fvNV));
			}
			if (SuportedExt.Contains("glVertexAttribs3hvNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribs3hvNV = (dgtk.OpenGL.delegatesGL.glVertexAttribs3hvNV) InternalTool.GetGLMethodAdress("glVertexAttribs3hvNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribs3hvNV));
			}
			if (SuportedExt.Contains("glVertexAttribs3svNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribs3svNV = (dgtk.OpenGL.delegatesGL.glVertexAttribs3svNV) InternalTool.GetGLMethodAdress("glVertexAttribs3svNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribs3svNV));
			}
			if (SuportedExt.Contains("glVertexAttribs4dvNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribs4dvNV = (dgtk.OpenGL.delegatesGL.glVertexAttribs4dvNV) InternalTool.GetGLMethodAdress("glVertexAttribs4dvNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribs4dvNV));
			}
			if (SuportedExt.Contains("glVertexAttribs4fvNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribs4fvNV = (dgtk.OpenGL.delegatesGL.glVertexAttribs4fvNV) InternalTool.GetGLMethodAdress("glVertexAttribs4fvNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribs4fvNV));
			}
			if (SuportedExt.Contains("glVertexAttribs4hvNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribs4hvNV = (dgtk.OpenGL.delegatesGL.glVertexAttribs4hvNV) InternalTool.GetGLMethodAdress("glVertexAttribs4hvNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribs4hvNV));
			}
			if (SuportedExt.Contains("glVertexAttribs4svNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribs4svNV = (dgtk.OpenGL.delegatesGL.glVertexAttribs4svNV) InternalTool.GetGLMethodAdress("glVertexAttribs4svNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribs4svNV));
			}
			if (SuportedExt.Contains("glVertexAttribs4ubvNV"))
			{
				dgtk.OpenGL.internalGL.glVertexAttribs4ubvNV = (dgtk.OpenGL.delegatesGL.glVertexAttribs4ubvNV) InternalTool.GetGLMethodAdress("glVertexAttribs4ubvNV", typeof(dgtk.OpenGL.delegatesGL.glVertexAttribs4ubvNV));
			}
			if (SuportedExt.Contains("glVertexBlendARB"))
			{
				dgtk.OpenGL.internalGL.glVertexBlendARB = (dgtk.OpenGL.delegatesGL.glVertexBlendARB) InternalTool.GetGLMethodAdress("glVertexBlendARB", typeof(dgtk.OpenGL.delegatesGL.glVertexBlendARB));
			}
			if (SuportedExt.Contains("glVertexBlendEnvfATI"))
			{
				dgtk.OpenGL.internalGL.glVertexBlendEnvfATI = (dgtk.OpenGL.delegatesGL.glVertexBlendEnvfATI) InternalTool.GetGLMethodAdress("glVertexBlendEnvfATI", typeof(dgtk.OpenGL.delegatesGL.glVertexBlendEnvfATI));
			}
			if (SuportedExt.Contains("glVertexBlendEnviATI"))
			{
				dgtk.OpenGL.internalGL.glVertexBlendEnviATI = (dgtk.OpenGL.delegatesGL.glVertexBlendEnviATI) InternalTool.GetGLMethodAdress("glVertexBlendEnviATI", typeof(dgtk.OpenGL.delegatesGL.glVertexBlendEnviATI));
			}
			if (SuportedExt.Contains("glVertexFormatNV"))
			{
				dgtk.OpenGL.internalGL.glVertexFormatNV = (dgtk.OpenGL.delegatesGL.glVertexFormatNV) InternalTool.GetGLMethodAdress("glVertexFormatNV", typeof(dgtk.OpenGL.delegatesGL.glVertexFormatNV));
			}
			if (SuportedExt.Contains("glVertexPointerEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexPointerEXT = (dgtk.OpenGL.delegatesGL.glVertexPointerEXT) InternalTool.GetGLMethodAdress("glVertexPointerEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexPointerEXT));
			}
			if (SuportedExt.Contains("glVertexPointerListIBM"))
			{
				dgtk.OpenGL.internalGL.glVertexPointerListIBM = (dgtk.OpenGL.delegatesGL.glVertexPointerListIBM) InternalTool.GetGLMethodAdress("glVertexPointerListIBM", typeof(dgtk.OpenGL.delegatesGL.glVertexPointerListIBM));
			}
			if (SuportedExt.Contains("glVertexPointervINTEL"))
			{
				dgtk.OpenGL.internalGL.glVertexPointervINTEL = (dgtk.OpenGL.delegatesGL.glVertexPointervINTEL) InternalTool.GetGLMethodAdress("glVertexPointervINTEL", typeof(dgtk.OpenGL.delegatesGL.glVertexPointervINTEL));
			}
			if (SuportedExt.Contains("glVertexStream1dATI"))
			{
				dgtk.OpenGL.internalGL.glVertexStream1dATI = (dgtk.OpenGL.delegatesGL.glVertexStream1dATI) InternalTool.GetGLMethodAdress("glVertexStream1dATI", typeof(dgtk.OpenGL.delegatesGL.glVertexStream1dATI));
			}
			if (SuportedExt.Contains("glVertexStream1dvATI"))
			{
				dgtk.OpenGL.internalGL.glVertexStream1dvATI = (dgtk.OpenGL.delegatesGL.glVertexStream1dvATI) InternalTool.GetGLMethodAdress("glVertexStream1dvATI", typeof(dgtk.OpenGL.delegatesGL.glVertexStream1dvATI));
			}
			if (SuportedExt.Contains("glVertexStream1fATI"))
			{
				dgtk.OpenGL.internalGL.glVertexStream1fATI = (dgtk.OpenGL.delegatesGL.glVertexStream1fATI) InternalTool.GetGLMethodAdress("glVertexStream1fATI", typeof(dgtk.OpenGL.delegatesGL.glVertexStream1fATI));
			}
			if (SuportedExt.Contains("glVertexStream1fvATI"))
			{
				dgtk.OpenGL.internalGL.glVertexStream1fvATI = (dgtk.OpenGL.delegatesGL.glVertexStream1fvATI) InternalTool.GetGLMethodAdress("glVertexStream1fvATI", typeof(dgtk.OpenGL.delegatesGL.glVertexStream1fvATI));
			}
			if (SuportedExt.Contains("glVertexStream1iATI"))
			{
				dgtk.OpenGL.internalGL.glVertexStream1iATI = (dgtk.OpenGL.delegatesGL.glVertexStream1iATI) InternalTool.GetGLMethodAdress("glVertexStream1iATI", typeof(dgtk.OpenGL.delegatesGL.glVertexStream1iATI));
			}
			if (SuportedExt.Contains("glVertexStream1ivATI"))
			{
				dgtk.OpenGL.internalGL.glVertexStream1ivATI = (dgtk.OpenGL.delegatesGL.glVertexStream1ivATI) InternalTool.GetGLMethodAdress("glVertexStream1ivATI", typeof(dgtk.OpenGL.delegatesGL.glVertexStream1ivATI));
			}
			if (SuportedExt.Contains("glVertexStream1sATI"))
			{
				dgtk.OpenGL.internalGL.glVertexStream1sATI = (dgtk.OpenGL.delegatesGL.glVertexStream1sATI) InternalTool.GetGLMethodAdress("glVertexStream1sATI", typeof(dgtk.OpenGL.delegatesGL.glVertexStream1sATI));
			}
			if (SuportedExt.Contains("glVertexStream1svATI"))
			{
				dgtk.OpenGL.internalGL.glVertexStream1svATI = (dgtk.OpenGL.delegatesGL.glVertexStream1svATI) InternalTool.GetGLMethodAdress("glVertexStream1svATI", typeof(dgtk.OpenGL.delegatesGL.glVertexStream1svATI));
			}
			if (SuportedExt.Contains("glVertexStream2dATI"))
			{
				dgtk.OpenGL.internalGL.glVertexStream2dATI = (dgtk.OpenGL.delegatesGL.glVertexStream2dATI) InternalTool.GetGLMethodAdress("glVertexStream2dATI", typeof(dgtk.OpenGL.delegatesGL.glVertexStream2dATI));
			}
			if (SuportedExt.Contains("glVertexStream2dvATI"))
			{
				dgtk.OpenGL.internalGL.glVertexStream2dvATI = (dgtk.OpenGL.delegatesGL.glVertexStream2dvATI) InternalTool.GetGLMethodAdress("glVertexStream2dvATI", typeof(dgtk.OpenGL.delegatesGL.glVertexStream2dvATI));
			}
			if (SuportedExt.Contains("glVertexStream2fATI"))
			{
				dgtk.OpenGL.internalGL.glVertexStream2fATI = (dgtk.OpenGL.delegatesGL.glVertexStream2fATI) InternalTool.GetGLMethodAdress("glVertexStream2fATI", typeof(dgtk.OpenGL.delegatesGL.glVertexStream2fATI));
			}
			if (SuportedExt.Contains("glVertexStream2fvATI"))
			{
				dgtk.OpenGL.internalGL.glVertexStream2fvATI = (dgtk.OpenGL.delegatesGL.glVertexStream2fvATI) InternalTool.GetGLMethodAdress("glVertexStream2fvATI", typeof(dgtk.OpenGL.delegatesGL.glVertexStream2fvATI));
			}
			if (SuportedExt.Contains("glVertexStream2iATI"))
			{
				dgtk.OpenGL.internalGL.glVertexStream2iATI = (dgtk.OpenGL.delegatesGL.glVertexStream2iATI) InternalTool.GetGLMethodAdress("glVertexStream2iATI", typeof(dgtk.OpenGL.delegatesGL.glVertexStream2iATI));
			}
			if (SuportedExt.Contains("glVertexStream2ivATI"))
			{
				dgtk.OpenGL.internalGL.glVertexStream2ivATI = (dgtk.OpenGL.delegatesGL.glVertexStream2ivATI) InternalTool.GetGLMethodAdress("glVertexStream2ivATI", typeof(dgtk.OpenGL.delegatesGL.glVertexStream2ivATI));
			}
			if (SuportedExt.Contains("glVertexStream2sATI"))
			{
				dgtk.OpenGL.internalGL.glVertexStream2sATI = (dgtk.OpenGL.delegatesGL.glVertexStream2sATI) InternalTool.GetGLMethodAdress("glVertexStream2sATI", typeof(dgtk.OpenGL.delegatesGL.glVertexStream2sATI));
			}
			if (SuportedExt.Contains("glVertexStream2svATI"))
			{
				dgtk.OpenGL.internalGL.glVertexStream2svATI = (dgtk.OpenGL.delegatesGL.glVertexStream2svATI) InternalTool.GetGLMethodAdress("glVertexStream2svATI", typeof(dgtk.OpenGL.delegatesGL.glVertexStream2svATI));
			}
			if (SuportedExt.Contains("glVertexStream3dATI"))
			{
				dgtk.OpenGL.internalGL.glVertexStream3dATI = (dgtk.OpenGL.delegatesGL.glVertexStream3dATI) InternalTool.GetGLMethodAdress("glVertexStream3dATI", typeof(dgtk.OpenGL.delegatesGL.glVertexStream3dATI));
			}
			if (SuportedExt.Contains("glVertexStream3dvATI"))
			{
				dgtk.OpenGL.internalGL.glVertexStream3dvATI = (dgtk.OpenGL.delegatesGL.glVertexStream3dvATI) InternalTool.GetGLMethodAdress("glVertexStream3dvATI", typeof(dgtk.OpenGL.delegatesGL.glVertexStream3dvATI));
			}
			if (SuportedExt.Contains("glVertexStream3fATI"))
			{
				dgtk.OpenGL.internalGL.glVertexStream3fATI = (dgtk.OpenGL.delegatesGL.glVertexStream3fATI) InternalTool.GetGLMethodAdress("glVertexStream3fATI", typeof(dgtk.OpenGL.delegatesGL.glVertexStream3fATI));
			}
			if (SuportedExt.Contains("glVertexStream3fvATI"))
			{
				dgtk.OpenGL.internalGL.glVertexStream3fvATI = (dgtk.OpenGL.delegatesGL.glVertexStream3fvATI) InternalTool.GetGLMethodAdress("glVertexStream3fvATI", typeof(dgtk.OpenGL.delegatesGL.glVertexStream3fvATI));
			}
			if (SuportedExt.Contains("glVertexStream3iATI"))
			{
				dgtk.OpenGL.internalGL.glVertexStream3iATI = (dgtk.OpenGL.delegatesGL.glVertexStream3iATI) InternalTool.GetGLMethodAdress("glVertexStream3iATI", typeof(dgtk.OpenGL.delegatesGL.glVertexStream3iATI));
			}
			if (SuportedExt.Contains("glVertexStream3ivATI"))
			{
				dgtk.OpenGL.internalGL.glVertexStream3ivATI = (dgtk.OpenGL.delegatesGL.glVertexStream3ivATI) InternalTool.GetGLMethodAdress("glVertexStream3ivATI", typeof(dgtk.OpenGL.delegatesGL.glVertexStream3ivATI));
			}
			if (SuportedExt.Contains("glVertexStream3sATI"))
			{
				dgtk.OpenGL.internalGL.glVertexStream3sATI = (dgtk.OpenGL.delegatesGL.glVertexStream3sATI) InternalTool.GetGLMethodAdress("glVertexStream3sATI", typeof(dgtk.OpenGL.delegatesGL.glVertexStream3sATI));
			}
			if (SuportedExt.Contains("glVertexStream3svATI"))
			{
				dgtk.OpenGL.internalGL.glVertexStream3svATI = (dgtk.OpenGL.delegatesGL.glVertexStream3svATI) InternalTool.GetGLMethodAdress("glVertexStream3svATI", typeof(dgtk.OpenGL.delegatesGL.glVertexStream3svATI));
			}
			if (SuportedExt.Contains("glVertexStream4dATI"))
			{
				dgtk.OpenGL.internalGL.glVertexStream4dATI = (dgtk.OpenGL.delegatesGL.glVertexStream4dATI) InternalTool.GetGLMethodAdress("glVertexStream4dATI", typeof(dgtk.OpenGL.delegatesGL.glVertexStream4dATI));
			}
			if (SuportedExt.Contains("glVertexStream4dvATI"))
			{
				dgtk.OpenGL.internalGL.glVertexStream4dvATI = (dgtk.OpenGL.delegatesGL.glVertexStream4dvATI) InternalTool.GetGLMethodAdress("glVertexStream4dvATI", typeof(dgtk.OpenGL.delegatesGL.glVertexStream4dvATI));
			}
			if (SuportedExt.Contains("glVertexStream4fATI"))
			{
				dgtk.OpenGL.internalGL.glVertexStream4fATI = (dgtk.OpenGL.delegatesGL.glVertexStream4fATI) InternalTool.GetGLMethodAdress("glVertexStream4fATI", typeof(dgtk.OpenGL.delegatesGL.glVertexStream4fATI));
			}
			if (SuportedExt.Contains("glVertexStream4fvATI"))
			{
				dgtk.OpenGL.internalGL.glVertexStream4fvATI = (dgtk.OpenGL.delegatesGL.glVertexStream4fvATI) InternalTool.GetGLMethodAdress("glVertexStream4fvATI", typeof(dgtk.OpenGL.delegatesGL.glVertexStream4fvATI));
			}
			if (SuportedExt.Contains("glVertexStream4iATI"))
			{
				dgtk.OpenGL.internalGL.glVertexStream4iATI = (dgtk.OpenGL.delegatesGL.glVertexStream4iATI) InternalTool.GetGLMethodAdress("glVertexStream4iATI", typeof(dgtk.OpenGL.delegatesGL.glVertexStream4iATI));
			}
			if (SuportedExt.Contains("glVertexStream4ivATI"))
			{
				dgtk.OpenGL.internalGL.glVertexStream4ivATI = (dgtk.OpenGL.delegatesGL.glVertexStream4ivATI) InternalTool.GetGLMethodAdress("glVertexStream4ivATI", typeof(dgtk.OpenGL.delegatesGL.glVertexStream4ivATI));
			}
			if (SuportedExt.Contains("glVertexStream4sATI"))
			{
				dgtk.OpenGL.internalGL.glVertexStream4sATI = (dgtk.OpenGL.delegatesGL.glVertexStream4sATI) InternalTool.GetGLMethodAdress("glVertexStream4sATI", typeof(dgtk.OpenGL.delegatesGL.glVertexStream4sATI));
			}
			if (SuportedExt.Contains("glVertexStream4svATI"))
			{
				dgtk.OpenGL.internalGL.glVertexStream4svATI = (dgtk.OpenGL.delegatesGL.glVertexStream4svATI) InternalTool.GetGLMethodAdress("glVertexStream4svATI", typeof(dgtk.OpenGL.delegatesGL.glVertexStream4svATI));
			}
			if (SuportedExt.Contains("glVertexWeightfEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexWeightfEXT = (dgtk.OpenGL.delegatesGL.glVertexWeightfEXT) InternalTool.GetGLMethodAdress("glVertexWeightfEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexWeightfEXT));
			}
			if (SuportedExt.Contains("glVertexWeightfvEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexWeightfvEXT = (dgtk.OpenGL.delegatesGL.glVertexWeightfvEXT) InternalTool.GetGLMethodAdress("glVertexWeightfvEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexWeightfvEXT));
			}
			if (SuportedExt.Contains("glVertexWeighthNV"))
			{
				dgtk.OpenGL.internalGL.glVertexWeighthNV = (dgtk.OpenGL.delegatesGL.glVertexWeighthNV) InternalTool.GetGLMethodAdress("glVertexWeighthNV", typeof(dgtk.OpenGL.delegatesGL.glVertexWeighthNV));
			}
			if (SuportedExt.Contains("glVertexWeighthvNV"))
			{
				dgtk.OpenGL.internalGL.glVertexWeighthvNV = (dgtk.OpenGL.delegatesGL.glVertexWeighthvNV) InternalTool.GetGLMethodAdress("glVertexWeighthvNV", typeof(dgtk.OpenGL.delegatesGL.glVertexWeighthvNV));
			}
			if (SuportedExt.Contains("glVertexWeightPointerEXT"))
			{
				dgtk.OpenGL.internalGL.glVertexWeightPointerEXT = (dgtk.OpenGL.delegatesGL.glVertexWeightPointerEXT) InternalTool.GetGLMethodAdress("glVertexWeightPointerEXT", typeof(dgtk.OpenGL.delegatesGL.glVertexWeightPointerEXT));
			}
			if (SuportedExt.Contains("glVideoCaptureNV"))
			{
				dgtk.OpenGL.internalGL.glVideoCaptureNV = (dgtk.OpenGL.delegatesGL.glVideoCaptureNV) InternalTool.GetGLMethodAdress("glVideoCaptureNV", typeof(dgtk.OpenGL.delegatesGL.glVideoCaptureNV));
			}
			if (SuportedExt.Contains("glVideoCaptureStreamParameterdvNV"))
			{
				dgtk.OpenGL.internalGL.glVideoCaptureStreamParameterdvNV = (dgtk.OpenGL.delegatesGL.glVideoCaptureStreamParameterdvNV) InternalTool.GetGLMethodAdress("glVideoCaptureStreamParameterdvNV", typeof(dgtk.OpenGL.delegatesGL.glVideoCaptureStreamParameterdvNV));
			}
			if (SuportedExt.Contains("glVideoCaptureStreamParameterfvNV"))
			{
				dgtk.OpenGL.internalGL.glVideoCaptureStreamParameterfvNV = (dgtk.OpenGL.delegatesGL.glVideoCaptureStreamParameterfvNV) InternalTool.GetGLMethodAdress("glVideoCaptureStreamParameterfvNV", typeof(dgtk.OpenGL.delegatesGL.glVideoCaptureStreamParameterfvNV));
			}
			if (SuportedExt.Contains("glVideoCaptureStreamParameterivNV"))
			{
				dgtk.OpenGL.internalGL.glVideoCaptureStreamParameterivNV = (dgtk.OpenGL.delegatesGL.glVideoCaptureStreamParameterivNV) InternalTool.GetGLMethodAdress("glVideoCaptureStreamParameterivNV", typeof(dgtk.OpenGL.delegatesGL.glVideoCaptureStreamParameterivNV));
			}
			if (SuportedExt.Contains("glViewportArrayvNV"))
			{
				dgtk.OpenGL.internalGL.glViewportArrayvNV = (dgtk.OpenGL.delegatesGL.glViewportArrayvNV) InternalTool.GetGLMethodAdress("glViewportArrayvNV", typeof(dgtk.OpenGL.delegatesGL.glViewportArrayvNV));
			}
			if (SuportedExt.Contains("glViewportArrayvOES"))
			{
				dgtk.OpenGL.internalGL.glViewportArrayvOES = (dgtk.OpenGL.delegatesGL.glViewportArrayvOES) InternalTool.GetGLMethodAdress("glViewportArrayvOES", typeof(dgtk.OpenGL.delegatesGL.glViewportArrayvOES));
			}
			if (SuportedExt.Contains("glViewportIndexedfNV"))
			{
				dgtk.OpenGL.internalGL.glViewportIndexedfNV = (dgtk.OpenGL.delegatesGL.glViewportIndexedfNV) InternalTool.GetGLMethodAdress("glViewportIndexedfNV", typeof(dgtk.OpenGL.delegatesGL.glViewportIndexedfNV));
			}
			if (SuportedExt.Contains("glViewportIndexedfOES"))
			{
				dgtk.OpenGL.internalGL.glViewportIndexedfOES = (dgtk.OpenGL.delegatesGL.glViewportIndexedfOES) InternalTool.GetGLMethodAdress("glViewportIndexedfOES", typeof(dgtk.OpenGL.delegatesGL.glViewportIndexedfOES));
			}
			if (SuportedExt.Contains("glViewportIndexedfvNV"))
			{
				dgtk.OpenGL.internalGL.glViewportIndexedfvNV = (dgtk.OpenGL.delegatesGL.glViewportIndexedfvNV) InternalTool.GetGLMethodAdress("glViewportIndexedfvNV", typeof(dgtk.OpenGL.delegatesGL.glViewportIndexedfvNV));
			}
			if (SuportedExt.Contains("glViewportIndexedfvOES"))
			{
				dgtk.OpenGL.internalGL.glViewportIndexedfvOES = (dgtk.OpenGL.delegatesGL.glViewportIndexedfvOES) InternalTool.GetGLMethodAdress("glViewportIndexedfvOES", typeof(dgtk.OpenGL.delegatesGL.glViewportIndexedfvOES));
			}
			if (SuportedExt.Contains("glViewportPositionWScaleNV"))
			{
				dgtk.OpenGL.internalGL.glViewportPositionWScaleNV = (dgtk.OpenGL.delegatesGL.glViewportPositionWScaleNV) InternalTool.GetGLMethodAdress("glViewportPositionWScaleNV", typeof(dgtk.OpenGL.delegatesGL.glViewportPositionWScaleNV));
			}
			if (SuportedExt.Contains("glViewportSwizzleNV"))
			{
				dgtk.OpenGL.internalGL.glViewportSwizzleNV = (dgtk.OpenGL.delegatesGL.glViewportSwizzleNV) InternalTool.GetGLMethodAdress("glViewportSwizzleNV", typeof(dgtk.OpenGL.delegatesGL.glViewportSwizzleNV));
			}
			#endregion

			#region W:

			if (SuportedExt.Contains("glWaitSemaphoreEXT"))
			{
				dgtk.OpenGL.internalGL.glWaitSemaphoreEXT = (dgtk.OpenGL.delegatesGL.glWaitSemaphoreEXT) InternalTool.GetGLMethodAdress("glWaitSemaphoreEXT", typeof(dgtk.OpenGL.delegatesGL.glWaitSemaphoreEXT));
			}
			if (SuportedExt.Contains("glWaitSemaphoreui64NVX"))
			{
				dgtk.OpenGL.internalGL.glWaitSemaphoreui64NVX = (dgtk.OpenGL.delegatesGL.glWaitSemaphoreui64NVX) InternalTool.GetGLMethodAdress("glWaitSemaphoreui64NVX", typeof(dgtk.OpenGL.delegatesGL.glWaitSemaphoreui64NVX));
			}
			if (SuportedExt.Contains("glWaitSyncAPPLE"))
			{
				dgtk.OpenGL.internalGL.glWaitSyncAPPLE = (dgtk.OpenGL.delegatesGL.glWaitSyncAPPLE) InternalTool.GetGLMethodAdress("glWaitSyncAPPLE", typeof(dgtk.OpenGL.delegatesGL.glWaitSyncAPPLE));
			}
			if (SuportedExt.Contains("glWaitVkSemaphoreNV"))
			{
				dgtk.OpenGL.internalGL.glWaitVkSemaphoreNV = (dgtk.OpenGL.delegatesGL.glWaitVkSemaphoreNV) InternalTool.GetGLMethodAdress("glWaitVkSemaphoreNV", typeof(dgtk.OpenGL.delegatesGL.glWaitVkSemaphoreNV));
			}
			if (SuportedExt.Contains("glWeightbvARB"))
			{
				dgtk.OpenGL.internalGL.glWeightbvARB = (dgtk.OpenGL.delegatesGL.glWeightbvARB) InternalTool.GetGLMethodAdress("glWeightbvARB", typeof(dgtk.OpenGL.delegatesGL.glWeightbvARB));
			}
			if (SuportedExt.Contains("glWeightdvARB"))
			{
				dgtk.OpenGL.internalGL.glWeightdvARB = (dgtk.OpenGL.delegatesGL.glWeightdvARB) InternalTool.GetGLMethodAdress("glWeightdvARB", typeof(dgtk.OpenGL.delegatesGL.glWeightdvARB));
			}
			if (SuportedExt.Contains("glWeightfvARB"))
			{
				dgtk.OpenGL.internalGL.glWeightfvARB = (dgtk.OpenGL.delegatesGL.glWeightfvARB) InternalTool.GetGLMethodAdress("glWeightfvARB", typeof(dgtk.OpenGL.delegatesGL.glWeightfvARB));
			}
			if (SuportedExt.Contains("glWeightivARB"))
			{
				dgtk.OpenGL.internalGL.glWeightivARB = (dgtk.OpenGL.delegatesGL.glWeightivARB) InternalTool.GetGLMethodAdress("glWeightivARB", typeof(dgtk.OpenGL.delegatesGL.glWeightivARB));
			}
			if (SuportedExt.Contains("glWeightPathsNV"))
			{
				dgtk.OpenGL.internalGL.glWeightPathsNV = (dgtk.OpenGL.delegatesGL.glWeightPathsNV) InternalTool.GetGLMethodAdress("glWeightPathsNV", typeof(dgtk.OpenGL.delegatesGL.glWeightPathsNV));
			}
			if (SuportedExt.Contains("glWeightPointerARB"))
			{
				dgtk.OpenGL.internalGL.glWeightPointerARB = (dgtk.OpenGL.delegatesGL.glWeightPointerARB) InternalTool.GetGLMethodAdress("glWeightPointerARB", typeof(dgtk.OpenGL.delegatesGL.glWeightPointerARB));
			}
			if (SuportedExt.Contains("glWeightPointerOES"))
			{
				dgtk.OpenGL.internalGL.glWeightPointerOES = (dgtk.OpenGL.delegatesGL.glWeightPointerOES) InternalTool.GetGLMethodAdress("glWeightPointerOES", typeof(dgtk.OpenGL.delegatesGL.glWeightPointerOES));
			}
			if (SuportedExt.Contains("glWeightsvARB"))
			{
				dgtk.OpenGL.internalGL.glWeightsvARB = (dgtk.OpenGL.delegatesGL.glWeightsvARB) InternalTool.GetGLMethodAdress("glWeightsvARB", typeof(dgtk.OpenGL.delegatesGL.glWeightsvARB));
			}
			if (SuportedExt.Contains("glWeightubvARB"))
			{
				dgtk.OpenGL.internalGL.glWeightubvARB = (dgtk.OpenGL.delegatesGL.glWeightubvARB) InternalTool.GetGLMethodAdress("glWeightubvARB", typeof(dgtk.OpenGL.delegatesGL.glWeightubvARB));
			}
			if (SuportedExt.Contains("glWeightuivARB"))
			{
				dgtk.OpenGL.internalGL.glWeightuivARB = (dgtk.OpenGL.delegatesGL.glWeightuivARB) InternalTool.GetGLMethodAdress("glWeightuivARB", typeof(dgtk.OpenGL.delegatesGL.glWeightuivARB));
			}
			if (SuportedExt.Contains("glWeightusvARB"))
			{
				dgtk.OpenGL.internalGL.glWeightusvARB = (dgtk.OpenGL.delegatesGL.glWeightusvARB) InternalTool.GetGLMethodAdress("glWeightusvARB", typeof(dgtk.OpenGL.delegatesGL.glWeightusvARB));
			}
			if (SuportedExt.Contains("glWindowPos2dARB"))
			{
				dgtk.OpenGL.internalGL.glWindowPos2dARB = (dgtk.OpenGL.delegatesGL.glWindowPos2dARB) InternalTool.GetGLMethodAdress("glWindowPos2dARB", typeof(dgtk.OpenGL.delegatesGL.glWindowPos2dARB));
			}
			if (SuportedExt.Contains("glWindowPos2dMESA"))
			{
				dgtk.OpenGL.internalGL.glWindowPos2dMESA = (dgtk.OpenGL.delegatesGL.glWindowPos2dMESA) InternalTool.GetGLMethodAdress("glWindowPos2dMESA", typeof(dgtk.OpenGL.delegatesGL.glWindowPos2dMESA));
			}
			if (SuportedExt.Contains("glWindowPos2dvARB"))
			{
				dgtk.OpenGL.internalGL.glWindowPos2dvARB = (dgtk.OpenGL.delegatesGL.glWindowPos2dvARB) InternalTool.GetGLMethodAdress("glWindowPos2dvARB", typeof(dgtk.OpenGL.delegatesGL.glWindowPos2dvARB));
			}
			if (SuportedExt.Contains("glWindowPos2dvMESA"))
			{
				dgtk.OpenGL.internalGL.glWindowPos2dvMESA = (dgtk.OpenGL.delegatesGL.glWindowPos2dvMESA) InternalTool.GetGLMethodAdress("glWindowPos2dvMESA", typeof(dgtk.OpenGL.delegatesGL.glWindowPos2dvMESA));
			}
			if (SuportedExt.Contains("glWindowPos2fARB"))
			{
				dgtk.OpenGL.internalGL.glWindowPos2fARB = (dgtk.OpenGL.delegatesGL.glWindowPos2fARB) InternalTool.GetGLMethodAdress("glWindowPos2fARB", typeof(dgtk.OpenGL.delegatesGL.glWindowPos2fARB));
			}
			if (SuportedExt.Contains("glWindowPos2fMESA"))
			{
				dgtk.OpenGL.internalGL.glWindowPos2fMESA = (dgtk.OpenGL.delegatesGL.glWindowPos2fMESA) InternalTool.GetGLMethodAdress("glWindowPos2fMESA", typeof(dgtk.OpenGL.delegatesGL.glWindowPos2fMESA));
			}
			if (SuportedExt.Contains("glWindowPos2fvARB"))
			{
				dgtk.OpenGL.internalGL.glWindowPos2fvARB = (dgtk.OpenGL.delegatesGL.glWindowPos2fvARB) InternalTool.GetGLMethodAdress("glWindowPos2fvARB", typeof(dgtk.OpenGL.delegatesGL.glWindowPos2fvARB));
			}
			if (SuportedExt.Contains("glWindowPos2fvMESA"))
			{
				dgtk.OpenGL.internalGL.glWindowPos2fvMESA = (dgtk.OpenGL.delegatesGL.glWindowPos2fvMESA) InternalTool.GetGLMethodAdress("glWindowPos2fvMESA", typeof(dgtk.OpenGL.delegatesGL.glWindowPos2fvMESA));
			}
			if (SuportedExt.Contains("glWindowPos2iARB"))
			{
				dgtk.OpenGL.internalGL.glWindowPos2iARB = (dgtk.OpenGL.delegatesGL.glWindowPos2iARB) InternalTool.GetGLMethodAdress("glWindowPos2iARB", typeof(dgtk.OpenGL.delegatesGL.glWindowPos2iARB));
			}
			if (SuportedExt.Contains("glWindowPos2iMESA"))
			{
				dgtk.OpenGL.internalGL.glWindowPos2iMESA = (dgtk.OpenGL.delegatesGL.glWindowPos2iMESA) InternalTool.GetGLMethodAdress("glWindowPos2iMESA", typeof(dgtk.OpenGL.delegatesGL.glWindowPos2iMESA));
			}
			if (SuportedExt.Contains("glWindowPos2ivARB"))
			{
				dgtk.OpenGL.internalGL.glWindowPos2ivARB = (dgtk.OpenGL.delegatesGL.glWindowPos2ivARB) InternalTool.GetGLMethodAdress("glWindowPos2ivARB", typeof(dgtk.OpenGL.delegatesGL.glWindowPos2ivARB));
			}
			if (SuportedExt.Contains("glWindowPos2ivMESA"))
			{
				dgtk.OpenGL.internalGL.glWindowPos2ivMESA = (dgtk.OpenGL.delegatesGL.glWindowPos2ivMESA) InternalTool.GetGLMethodAdress("glWindowPos2ivMESA", typeof(dgtk.OpenGL.delegatesGL.glWindowPos2ivMESA));
			}
			if (SuportedExt.Contains("glWindowPos2sARB"))
			{
				dgtk.OpenGL.internalGL.glWindowPos2sARB = (dgtk.OpenGL.delegatesGL.glWindowPos2sARB) InternalTool.GetGLMethodAdress("glWindowPos2sARB", typeof(dgtk.OpenGL.delegatesGL.glWindowPos2sARB));
			}
			if (SuportedExt.Contains("glWindowPos2sMESA"))
			{
				dgtk.OpenGL.internalGL.glWindowPos2sMESA = (dgtk.OpenGL.delegatesGL.glWindowPos2sMESA) InternalTool.GetGLMethodAdress("glWindowPos2sMESA", typeof(dgtk.OpenGL.delegatesGL.glWindowPos2sMESA));
			}
			if (SuportedExt.Contains("glWindowPos2svARB"))
			{
				dgtk.OpenGL.internalGL.glWindowPos2svARB = (dgtk.OpenGL.delegatesGL.glWindowPos2svARB) InternalTool.GetGLMethodAdress("glWindowPos2svARB", typeof(dgtk.OpenGL.delegatesGL.glWindowPos2svARB));
			}
			if (SuportedExt.Contains("glWindowPos2svMESA"))
			{
				dgtk.OpenGL.internalGL.glWindowPos2svMESA = (dgtk.OpenGL.delegatesGL.glWindowPos2svMESA) InternalTool.GetGLMethodAdress("glWindowPos2svMESA", typeof(dgtk.OpenGL.delegatesGL.glWindowPos2svMESA));
			}
			if (SuportedExt.Contains("glWindowPos3dARB"))
			{
				dgtk.OpenGL.internalGL.glWindowPos3dARB = (dgtk.OpenGL.delegatesGL.glWindowPos3dARB) InternalTool.GetGLMethodAdress("glWindowPos3dARB", typeof(dgtk.OpenGL.delegatesGL.glWindowPos3dARB));
			}
			if (SuportedExt.Contains("glWindowPos3dMESA"))
			{
				dgtk.OpenGL.internalGL.glWindowPos3dMESA = (dgtk.OpenGL.delegatesGL.glWindowPos3dMESA) InternalTool.GetGLMethodAdress("glWindowPos3dMESA", typeof(dgtk.OpenGL.delegatesGL.glWindowPos3dMESA));
			}
			if (SuportedExt.Contains("glWindowPos3dvARB"))
			{
				dgtk.OpenGL.internalGL.glWindowPos3dvARB = (dgtk.OpenGL.delegatesGL.glWindowPos3dvARB) InternalTool.GetGLMethodAdress("glWindowPos3dvARB", typeof(dgtk.OpenGL.delegatesGL.glWindowPos3dvARB));
			}
			if (SuportedExt.Contains("glWindowPos3dvMESA"))
			{
				dgtk.OpenGL.internalGL.glWindowPos3dvMESA = (dgtk.OpenGL.delegatesGL.glWindowPos3dvMESA) InternalTool.GetGLMethodAdress("glWindowPos3dvMESA", typeof(dgtk.OpenGL.delegatesGL.glWindowPos3dvMESA));
			}
			if (SuportedExt.Contains("glWindowPos3fARB"))
			{
				dgtk.OpenGL.internalGL.glWindowPos3fARB = (dgtk.OpenGL.delegatesGL.glWindowPos3fARB) InternalTool.GetGLMethodAdress("glWindowPos3fARB", typeof(dgtk.OpenGL.delegatesGL.glWindowPos3fARB));
			}
			if (SuportedExt.Contains("glWindowPos3fMESA"))
			{
				dgtk.OpenGL.internalGL.glWindowPos3fMESA = (dgtk.OpenGL.delegatesGL.glWindowPos3fMESA) InternalTool.GetGLMethodAdress("glWindowPos3fMESA", typeof(dgtk.OpenGL.delegatesGL.glWindowPos3fMESA));
			}
			if (SuportedExt.Contains("glWindowPos3fvARB"))
			{
				dgtk.OpenGL.internalGL.glWindowPos3fvARB = (dgtk.OpenGL.delegatesGL.glWindowPos3fvARB) InternalTool.GetGLMethodAdress("glWindowPos3fvARB", typeof(dgtk.OpenGL.delegatesGL.glWindowPos3fvARB));
			}
			if (SuportedExt.Contains("glWindowPos3fvMESA"))
			{
				dgtk.OpenGL.internalGL.glWindowPos3fvMESA = (dgtk.OpenGL.delegatesGL.glWindowPos3fvMESA) InternalTool.GetGLMethodAdress("glWindowPos3fvMESA", typeof(dgtk.OpenGL.delegatesGL.glWindowPos3fvMESA));
			}
			if (SuportedExt.Contains("glWindowPos3iARB"))
			{
				dgtk.OpenGL.internalGL.glWindowPos3iARB = (dgtk.OpenGL.delegatesGL.glWindowPos3iARB) InternalTool.GetGLMethodAdress("glWindowPos3iARB", typeof(dgtk.OpenGL.delegatesGL.glWindowPos3iARB));
			}
			if (SuportedExt.Contains("glWindowPos3iMESA"))
			{
				dgtk.OpenGL.internalGL.glWindowPos3iMESA = (dgtk.OpenGL.delegatesGL.glWindowPos3iMESA) InternalTool.GetGLMethodAdress("glWindowPos3iMESA", typeof(dgtk.OpenGL.delegatesGL.glWindowPos3iMESA));
			}
			if (SuportedExt.Contains("glWindowPos3ivARB"))
			{
				dgtk.OpenGL.internalGL.glWindowPos3ivARB = (dgtk.OpenGL.delegatesGL.glWindowPos3ivARB) InternalTool.GetGLMethodAdress("glWindowPos3ivARB", typeof(dgtk.OpenGL.delegatesGL.glWindowPos3ivARB));
			}
			if (SuportedExt.Contains("glWindowPos3ivMESA"))
			{
				dgtk.OpenGL.internalGL.glWindowPos3ivMESA = (dgtk.OpenGL.delegatesGL.glWindowPos3ivMESA) InternalTool.GetGLMethodAdress("glWindowPos3ivMESA", typeof(dgtk.OpenGL.delegatesGL.glWindowPos3ivMESA));
			}
			if (SuportedExt.Contains("glWindowPos3sARB"))
			{
				dgtk.OpenGL.internalGL.glWindowPos3sARB = (dgtk.OpenGL.delegatesGL.glWindowPos3sARB) InternalTool.GetGLMethodAdress("glWindowPos3sARB", typeof(dgtk.OpenGL.delegatesGL.glWindowPos3sARB));
			}
			if (SuportedExt.Contains("glWindowPos3sMESA"))
			{
				dgtk.OpenGL.internalGL.glWindowPos3sMESA = (dgtk.OpenGL.delegatesGL.glWindowPos3sMESA) InternalTool.GetGLMethodAdress("glWindowPos3sMESA", typeof(dgtk.OpenGL.delegatesGL.glWindowPos3sMESA));
			}
			if (SuportedExt.Contains("glWindowPos3svARB"))
			{
				dgtk.OpenGL.internalGL.glWindowPos3svARB = (dgtk.OpenGL.delegatesGL.glWindowPos3svARB) InternalTool.GetGLMethodAdress("glWindowPos3svARB", typeof(dgtk.OpenGL.delegatesGL.glWindowPos3svARB));
			}
			if (SuportedExt.Contains("glWindowPos3svMESA"))
			{
				dgtk.OpenGL.internalGL.glWindowPos3svMESA = (dgtk.OpenGL.delegatesGL.glWindowPos3svMESA) InternalTool.GetGLMethodAdress("glWindowPos3svMESA", typeof(dgtk.OpenGL.delegatesGL.glWindowPos3svMESA));
			}
			if (SuportedExt.Contains("glWindowPos4dMESA"))
			{
				dgtk.OpenGL.internalGL.glWindowPos4dMESA = (dgtk.OpenGL.delegatesGL.glWindowPos4dMESA) InternalTool.GetGLMethodAdress("glWindowPos4dMESA", typeof(dgtk.OpenGL.delegatesGL.glWindowPos4dMESA));
			}
			if (SuportedExt.Contains("glWindowPos4dvMESA"))
			{
				dgtk.OpenGL.internalGL.glWindowPos4dvMESA = (dgtk.OpenGL.delegatesGL.glWindowPos4dvMESA) InternalTool.GetGLMethodAdress("glWindowPos4dvMESA", typeof(dgtk.OpenGL.delegatesGL.glWindowPos4dvMESA));
			}
			if (SuportedExt.Contains("glWindowPos4fMESA"))
			{
				dgtk.OpenGL.internalGL.glWindowPos4fMESA = (dgtk.OpenGL.delegatesGL.glWindowPos4fMESA) InternalTool.GetGLMethodAdress("glWindowPos4fMESA", typeof(dgtk.OpenGL.delegatesGL.glWindowPos4fMESA));
			}
			if (SuportedExt.Contains("glWindowPos4fvMESA"))
			{
				dgtk.OpenGL.internalGL.glWindowPos4fvMESA = (dgtk.OpenGL.delegatesGL.glWindowPos4fvMESA) InternalTool.GetGLMethodAdress("glWindowPos4fvMESA", typeof(dgtk.OpenGL.delegatesGL.glWindowPos4fvMESA));
			}
			if (SuportedExt.Contains("glWindowPos4iMESA"))
			{
				dgtk.OpenGL.internalGL.glWindowPos4iMESA = (dgtk.OpenGL.delegatesGL.glWindowPos4iMESA) InternalTool.GetGLMethodAdress("glWindowPos4iMESA", typeof(dgtk.OpenGL.delegatesGL.glWindowPos4iMESA));
			}
			if (SuportedExt.Contains("glWindowPos4ivMESA"))
			{
				dgtk.OpenGL.internalGL.glWindowPos4ivMESA = (dgtk.OpenGL.delegatesGL.glWindowPos4ivMESA) InternalTool.GetGLMethodAdress("glWindowPos4ivMESA", typeof(dgtk.OpenGL.delegatesGL.glWindowPos4ivMESA));
			}
			if (SuportedExt.Contains("glWindowPos4sMESA"))
			{
				dgtk.OpenGL.internalGL.glWindowPos4sMESA = (dgtk.OpenGL.delegatesGL.glWindowPos4sMESA) InternalTool.GetGLMethodAdress("glWindowPos4sMESA", typeof(dgtk.OpenGL.delegatesGL.glWindowPos4sMESA));
			}
			if (SuportedExt.Contains("glWindowPos4svMESA"))
			{
				dgtk.OpenGL.internalGL.glWindowPos4svMESA = (dgtk.OpenGL.delegatesGL.glWindowPos4svMESA) InternalTool.GetGLMethodAdress("glWindowPos4svMESA", typeof(dgtk.OpenGL.delegatesGL.glWindowPos4svMESA));
			}
			if (SuportedExt.Contains("glWindowRectanglesEXT"))
			{
				dgtk.OpenGL.internalGL.glWindowRectanglesEXT = (dgtk.OpenGL.delegatesGL.glWindowRectanglesEXT) InternalTool.GetGLMethodAdress("glWindowRectanglesEXT", typeof(dgtk.OpenGL.delegatesGL.glWindowRectanglesEXT));
			}
			if (SuportedExt.Contains("glWriteMaskEXT"))
			{
				dgtk.OpenGL.internalGL.glWriteMaskEXT = (dgtk.OpenGL.delegatesGL.glWriteMaskEXT) InternalTool.GetGLMethodAdress("glWriteMaskEXT", typeof(dgtk.OpenGL.delegatesGL.glWriteMaskEXT));
			}
			#endregion

		}
		[DllImport("opengl32.dll")]
		private static extern IntPtr glGetString(StringName name);

		private static string oglGetString(dgtk.OpenGL.StringName name)
		{
			return Marshal.PtrToStringAnsi(glGetString(name));
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

