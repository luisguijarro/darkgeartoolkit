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

		internal static void InitDelegatesGLesExts()
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
				glGetStringi = (dglGetStringi)dgtk.OpenGL.InternalTool.GetGLesMethodAdress("glGetStringi", typeof(dglGetStringi));
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
				dgtk.OpenGL.internalGLes.glAccumxOES = (dgtk.OpenGL.delegatesGLes.glAccumxOES) InternalTool.GetGLesMethodAdress("glAccumxOES", typeof(dgtk.OpenGL.delegatesGLes.glAccumxOES));
			}
			if (SuportedExt.Contains("glAcquireKeyedMutexWin32EXT"))
			{
				dgtk.OpenGL.internalGLes.glAcquireKeyedMutexWin32EXT = (dgtk.OpenGL.delegatesGLes.glAcquireKeyedMutexWin32EXT) InternalTool.GetGLesMethodAdress("glAcquireKeyedMutexWin32EXT", typeof(dgtk.OpenGL.delegatesGLes.glAcquireKeyedMutexWin32EXT));
			}
			if (SuportedExt.Contains("glActiveProgramEXT"))
			{
				dgtk.OpenGL.internalGLes.glActiveProgramEXT = (dgtk.OpenGL.delegatesGLes.glActiveProgramEXT) InternalTool.GetGLesMethodAdress("glActiveProgramEXT", typeof(dgtk.OpenGL.delegatesGLes.glActiveProgramEXT));
			}
			if (SuportedExt.Contains("glActiveShaderProgramEXT"))
			{
				dgtk.OpenGL.internalGLes.glActiveShaderProgramEXT = (dgtk.OpenGL.delegatesGLes.glActiveShaderProgramEXT) InternalTool.GetGLesMethodAdress("glActiveShaderProgramEXT", typeof(dgtk.OpenGL.delegatesGLes.glActiveShaderProgramEXT));
			}
			if (SuportedExt.Contains("glActiveStencilFaceEXT"))
			{
				dgtk.OpenGL.internalGLes.glActiveStencilFaceEXT = (dgtk.OpenGL.delegatesGLes.glActiveStencilFaceEXT) InternalTool.GetGLesMethodAdress("glActiveStencilFaceEXT", typeof(dgtk.OpenGL.delegatesGLes.glActiveStencilFaceEXT));
			}
			if (SuportedExt.Contains("glActiveTextureARB"))
			{
				dgtk.OpenGL.internalGLes.glActiveTextureARB = (dgtk.OpenGL.delegatesGLes.glActiveTextureARB) InternalTool.GetGLesMethodAdress("glActiveTextureARB", typeof(dgtk.OpenGL.delegatesGLes.glActiveTextureARB));
			}
			if (SuportedExt.Contains("glActiveVaryingNV"))
			{
				dgtk.OpenGL.internalGLes.glActiveVaryingNV = (dgtk.OpenGL.delegatesGLes.glActiveVaryingNV) InternalTool.GetGLesMethodAdress("glActiveVaryingNV", typeof(dgtk.OpenGL.delegatesGLes.glActiveVaryingNV));
			}
			if (SuportedExt.Contains("glAlphaFragmentOp1ATI"))
			{
				dgtk.OpenGL.internalGLes.glAlphaFragmentOp1ATI = (dgtk.OpenGL.delegatesGLes.glAlphaFragmentOp1ATI) InternalTool.GetGLesMethodAdress("glAlphaFragmentOp1ATI", typeof(dgtk.OpenGL.delegatesGLes.glAlphaFragmentOp1ATI));
			}
			if (SuportedExt.Contains("glAlphaFragmentOp2ATI"))
			{
				dgtk.OpenGL.internalGLes.glAlphaFragmentOp2ATI = (dgtk.OpenGL.delegatesGLes.glAlphaFragmentOp2ATI) InternalTool.GetGLesMethodAdress("glAlphaFragmentOp2ATI", typeof(dgtk.OpenGL.delegatesGLes.glAlphaFragmentOp2ATI));
			}
			if (SuportedExt.Contains("glAlphaFragmentOp3ATI"))
			{
				dgtk.OpenGL.internalGLes.glAlphaFragmentOp3ATI = (dgtk.OpenGL.delegatesGLes.glAlphaFragmentOp3ATI) InternalTool.GetGLesMethodAdress("glAlphaFragmentOp3ATI", typeof(dgtk.OpenGL.delegatesGLes.glAlphaFragmentOp3ATI));
			}
			if (SuportedExt.Contains("glAlphaFuncQCOM"))
			{
				dgtk.OpenGL.internalGLes.glAlphaFuncQCOM = (dgtk.OpenGL.delegatesGLes.glAlphaFuncQCOM) InternalTool.GetGLesMethodAdress("glAlphaFuncQCOM", typeof(dgtk.OpenGL.delegatesGLes.glAlphaFuncQCOM));
			}
			if (SuportedExt.Contains("glAlphaFuncx"))
			{
				dgtk.OpenGL.internalGLes.glAlphaFuncx = (dgtk.OpenGL.delegatesGLes.glAlphaFuncx) InternalTool.GetGLesMethodAdress("glAlphaFuncx", typeof(dgtk.OpenGL.delegatesGLes.glAlphaFuncx));
			}
			if (SuportedExt.Contains("glAlphaFuncxOES"))
			{
				dgtk.OpenGL.internalGLes.glAlphaFuncxOES = (dgtk.OpenGL.delegatesGLes.glAlphaFuncxOES) InternalTool.GetGLesMethodAdress("glAlphaFuncxOES", typeof(dgtk.OpenGL.delegatesGLes.glAlphaFuncxOES));
			}
			if (SuportedExt.Contains("glAlphaToCoverageDitherControlNV"))
			{
				dgtk.OpenGL.internalGLes.glAlphaToCoverageDitherControlNV = (dgtk.OpenGL.delegatesGLes.glAlphaToCoverageDitherControlNV) InternalTool.GetGLesMethodAdress("glAlphaToCoverageDitherControlNV", typeof(dgtk.OpenGL.delegatesGLes.glAlphaToCoverageDitherControlNV));
			}
			if (SuportedExt.Contains("glApplyFramebufferAttachmentCMAAINTEL"))
			{
				dgtk.OpenGL.internalGLes.glApplyFramebufferAttachmentCMAAINTEL = (dgtk.OpenGL.delegatesGLes.glApplyFramebufferAttachmentCMAAINTEL) InternalTool.GetGLesMethodAdress("glApplyFramebufferAttachmentCMAAINTEL", typeof(dgtk.OpenGL.delegatesGLes.glApplyFramebufferAttachmentCMAAINTEL));
			}
			if (SuportedExt.Contains("glApplyTextureEXT"))
			{
				dgtk.OpenGL.internalGLes.glApplyTextureEXT = (dgtk.OpenGL.delegatesGLes.glApplyTextureEXT) InternalTool.GetGLesMethodAdress("glApplyTextureEXT", typeof(dgtk.OpenGL.delegatesGLes.glApplyTextureEXT));
			}
			if (SuportedExt.Contains("glAreProgramsResidentNV"))
			{
				dgtk.OpenGL.internalGLes.glAreProgramsResidentNV = (dgtk.OpenGL.delegatesGLes.glAreProgramsResidentNV) InternalTool.GetGLesMethodAdress("glAreProgramsResidentNV", typeof(dgtk.OpenGL.delegatesGLes.glAreProgramsResidentNV));
			}
			if (SuportedExt.Contains("glAreTexturesResidentEXT"))
			{
				dgtk.OpenGL.internalGLes.glAreTexturesResidentEXT = (dgtk.OpenGL.delegatesGLes.glAreTexturesResidentEXT) InternalTool.GetGLesMethodAdress("glAreTexturesResidentEXT", typeof(dgtk.OpenGL.delegatesGLes.glAreTexturesResidentEXT));
			}
			if (SuportedExt.Contains("glArrayElementEXT"))
			{
				dgtk.OpenGL.internalGLes.glArrayElementEXT = (dgtk.OpenGL.delegatesGLes.glArrayElementEXT) InternalTool.GetGLesMethodAdress("glArrayElementEXT", typeof(dgtk.OpenGL.delegatesGLes.glArrayElementEXT));
			}
			if (SuportedExt.Contains("glArrayObjectATI"))
			{
				dgtk.OpenGL.internalGLes.glArrayObjectATI = (dgtk.OpenGL.delegatesGLes.glArrayObjectATI) InternalTool.GetGLesMethodAdress("glArrayObjectATI", typeof(dgtk.OpenGL.delegatesGLes.glArrayObjectATI));
			}
			if (SuportedExt.Contains("glAsyncCopyBufferSubDataNVX"))
			{
				dgtk.OpenGL.internalGLes.glAsyncCopyBufferSubDataNVX = (dgtk.OpenGL.delegatesGLes.glAsyncCopyBufferSubDataNVX) InternalTool.GetGLesMethodAdress("glAsyncCopyBufferSubDataNVX", typeof(dgtk.OpenGL.delegatesGLes.glAsyncCopyBufferSubDataNVX));
			}
			if (SuportedExt.Contains("glAsyncCopyImageSubDataNVX"))
			{
				dgtk.OpenGL.internalGLes.glAsyncCopyImageSubDataNVX = (dgtk.OpenGL.delegatesGLes.glAsyncCopyImageSubDataNVX) InternalTool.GetGLesMethodAdress("glAsyncCopyImageSubDataNVX", typeof(dgtk.OpenGL.delegatesGLes.glAsyncCopyImageSubDataNVX));
			}
			if (SuportedExt.Contains("glAsyncMarkerSGIX"))
			{
				dgtk.OpenGL.internalGLes.glAsyncMarkerSGIX = (dgtk.OpenGL.delegatesGLes.glAsyncMarkerSGIX) InternalTool.GetGLesMethodAdress("glAsyncMarkerSGIX", typeof(dgtk.OpenGL.delegatesGLes.glAsyncMarkerSGIX));
			}
			if (SuportedExt.Contains("glAttachObjectARB"))
			{
				dgtk.OpenGL.internalGLes.glAttachObjectARB = (dgtk.OpenGL.delegatesGLes.glAttachObjectARB) InternalTool.GetGLesMethodAdress("glAttachObjectARB", typeof(dgtk.OpenGL.delegatesGLes.glAttachObjectARB));
			}
			#endregion

			#region B:

			if (SuportedExt.Contains("glBeginConditionalRenderNV"))
			{
				dgtk.OpenGL.internalGLes.glBeginConditionalRenderNV = (dgtk.OpenGL.delegatesGLes.glBeginConditionalRenderNV) InternalTool.GetGLesMethodAdress("glBeginConditionalRenderNV", typeof(dgtk.OpenGL.delegatesGLes.glBeginConditionalRenderNV));
			}
			if (SuportedExt.Contains("glBeginConditionalRenderNVX"))
			{
				dgtk.OpenGL.internalGLes.glBeginConditionalRenderNVX = (dgtk.OpenGL.delegatesGLes.glBeginConditionalRenderNVX) InternalTool.GetGLesMethodAdress("glBeginConditionalRenderNVX", typeof(dgtk.OpenGL.delegatesGLes.glBeginConditionalRenderNVX));
			}
			if (SuportedExt.Contains("glBeginFragmentShaderATI"))
			{
				dgtk.OpenGL.internalGLes.glBeginFragmentShaderATI = (dgtk.OpenGL.delegatesGLes.glBeginFragmentShaderATI) InternalTool.GetGLesMethodAdress("glBeginFragmentShaderATI", typeof(dgtk.OpenGL.delegatesGLes.glBeginFragmentShaderATI));
			}
			if (SuportedExt.Contains("glBeginOcclusionQueryNV"))
			{
				dgtk.OpenGL.internalGLes.glBeginOcclusionQueryNV = (dgtk.OpenGL.delegatesGLes.glBeginOcclusionQueryNV) InternalTool.GetGLesMethodAdress("glBeginOcclusionQueryNV", typeof(dgtk.OpenGL.delegatesGLes.glBeginOcclusionQueryNV));
			}
			if (SuportedExt.Contains("glBeginPerfMonitorAMD"))
			{
				dgtk.OpenGL.internalGLes.glBeginPerfMonitorAMD = (dgtk.OpenGL.delegatesGLes.glBeginPerfMonitorAMD) InternalTool.GetGLesMethodAdress("glBeginPerfMonitorAMD", typeof(dgtk.OpenGL.delegatesGLes.glBeginPerfMonitorAMD));
			}
			if (SuportedExt.Contains("glBeginPerfQueryINTEL"))
			{
				dgtk.OpenGL.internalGLes.glBeginPerfQueryINTEL = (dgtk.OpenGL.delegatesGLes.glBeginPerfQueryINTEL) InternalTool.GetGLesMethodAdress("glBeginPerfQueryINTEL", typeof(dgtk.OpenGL.delegatesGLes.glBeginPerfQueryINTEL));
			}
			if (SuportedExt.Contains("glBeginQueryARB"))
			{
				dgtk.OpenGL.internalGLes.glBeginQueryARB = (dgtk.OpenGL.delegatesGLes.glBeginQueryARB) InternalTool.GetGLesMethodAdress("glBeginQueryARB", typeof(dgtk.OpenGL.delegatesGLes.glBeginQueryARB));
			}
			if (SuportedExt.Contains("glBeginQueryEXT"))
			{
				dgtk.OpenGL.internalGLes.glBeginQueryEXT = (dgtk.OpenGL.delegatesGLes.glBeginQueryEXT) InternalTool.GetGLesMethodAdress("glBeginQueryEXT", typeof(dgtk.OpenGL.delegatesGLes.glBeginQueryEXT));
			}
			if (SuportedExt.Contains("glBeginTransformFeedbackEXT"))
			{
				dgtk.OpenGL.internalGLes.glBeginTransformFeedbackEXT = (dgtk.OpenGL.delegatesGLes.glBeginTransformFeedbackEXT) InternalTool.GetGLesMethodAdress("glBeginTransformFeedbackEXT", typeof(dgtk.OpenGL.delegatesGLes.glBeginTransformFeedbackEXT));
			}
			if (SuportedExt.Contains("glBeginTransformFeedbackNV"))
			{
				dgtk.OpenGL.internalGLes.glBeginTransformFeedbackNV = (dgtk.OpenGL.delegatesGLes.glBeginTransformFeedbackNV) InternalTool.GetGLesMethodAdress("glBeginTransformFeedbackNV", typeof(dgtk.OpenGL.delegatesGLes.glBeginTransformFeedbackNV));
			}
			if (SuportedExt.Contains("glBeginVertexShaderEXT"))
			{
				dgtk.OpenGL.internalGLes.glBeginVertexShaderEXT = (dgtk.OpenGL.delegatesGLes.glBeginVertexShaderEXT) InternalTool.GetGLesMethodAdress("glBeginVertexShaderEXT", typeof(dgtk.OpenGL.delegatesGLes.glBeginVertexShaderEXT));
			}
			if (SuportedExt.Contains("glBeginVideoCaptureNV"))
			{
				dgtk.OpenGL.internalGLes.glBeginVideoCaptureNV = (dgtk.OpenGL.delegatesGLes.glBeginVideoCaptureNV) InternalTool.GetGLesMethodAdress("glBeginVideoCaptureNV", typeof(dgtk.OpenGL.delegatesGLes.glBeginVideoCaptureNV));
			}
			if (SuportedExt.Contains("glBindAttribLocationARB"))
			{
				dgtk.OpenGL.internalGLes.glBindAttribLocationARB = (dgtk.OpenGL.delegatesGLes.glBindAttribLocationARB) InternalTool.GetGLesMethodAdress("glBindAttribLocationARB", typeof(dgtk.OpenGL.delegatesGLes.glBindAttribLocationARB));
			}
			if (SuportedExt.Contains("glBindBufferARB"))
			{
				dgtk.OpenGL.internalGLes.glBindBufferARB = (dgtk.OpenGL.delegatesGLes.glBindBufferARB) InternalTool.GetGLesMethodAdress("glBindBufferARB", typeof(dgtk.OpenGL.delegatesGLes.glBindBufferARB));
			}
			if (SuportedExt.Contains("glBindBufferBaseEXT"))
			{
				dgtk.OpenGL.internalGLes.glBindBufferBaseEXT = (dgtk.OpenGL.delegatesGLes.glBindBufferBaseEXT) InternalTool.GetGLesMethodAdress("glBindBufferBaseEXT", typeof(dgtk.OpenGL.delegatesGLes.glBindBufferBaseEXT));
			}
			if (SuportedExt.Contains("glBindBufferBaseNV"))
			{
				dgtk.OpenGL.internalGLes.glBindBufferBaseNV = (dgtk.OpenGL.delegatesGLes.glBindBufferBaseNV) InternalTool.GetGLesMethodAdress("glBindBufferBaseNV", typeof(dgtk.OpenGL.delegatesGLes.glBindBufferBaseNV));
			}
			if (SuportedExt.Contains("glBindBufferOffsetEXT"))
			{
				dgtk.OpenGL.internalGLes.glBindBufferOffsetEXT = (dgtk.OpenGL.delegatesGLes.glBindBufferOffsetEXT) InternalTool.GetGLesMethodAdress("glBindBufferOffsetEXT", typeof(dgtk.OpenGL.delegatesGLes.glBindBufferOffsetEXT));
			}
			if (SuportedExt.Contains("glBindBufferOffsetNV"))
			{
				dgtk.OpenGL.internalGLes.glBindBufferOffsetNV = (dgtk.OpenGL.delegatesGLes.glBindBufferOffsetNV) InternalTool.GetGLesMethodAdress("glBindBufferOffsetNV", typeof(dgtk.OpenGL.delegatesGLes.glBindBufferOffsetNV));
			}
			if (SuportedExt.Contains("glBindBufferRangeEXT"))
			{
				dgtk.OpenGL.internalGLes.glBindBufferRangeEXT = (dgtk.OpenGL.delegatesGLes.glBindBufferRangeEXT) InternalTool.GetGLesMethodAdress("glBindBufferRangeEXT", typeof(dgtk.OpenGL.delegatesGLes.glBindBufferRangeEXT));
			}
			if (SuportedExt.Contains("glBindBufferRangeNV"))
			{
				dgtk.OpenGL.internalGLes.glBindBufferRangeNV = (dgtk.OpenGL.delegatesGLes.glBindBufferRangeNV) InternalTool.GetGLesMethodAdress("glBindBufferRangeNV", typeof(dgtk.OpenGL.delegatesGLes.glBindBufferRangeNV));
			}
			if (SuportedExt.Contains("glBindFragDataLocationEXT"))
			{
				dgtk.OpenGL.internalGLes.glBindFragDataLocationEXT = (dgtk.OpenGL.delegatesGLes.glBindFragDataLocationEXT) InternalTool.GetGLesMethodAdress("glBindFragDataLocationEXT", typeof(dgtk.OpenGL.delegatesGLes.glBindFragDataLocationEXT));
			}
			if (SuportedExt.Contains("glBindFragDataLocationIndexedEXT"))
			{
				dgtk.OpenGL.internalGLes.glBindFragDataLocationIndexedEXT = (dgtk.OpenGL.delegatesGLes.glBindFragDataLocationIndexedEXT) InternalTool.GetGLesMethodAdress("glBindFragDataLocationIndexedEXT", typeof(dgtk.OpenGL.delegatesGLes.glBindFragDataLocationIndexedEXT));
			}
			if (SuportedExt.Contains("glBindFragmentShaderATI"))
			{
				dgtk.OpenGL.internalGLes.glBindFragmentShaderATI = (dgtk.OpenGL.delegatesGLes.glBindFragmentShaderATI) InternalTool.GetGLesMethodAdress("glBindFragmentShaderATI", typeof(dgtk.OpenGL.delegatesGLes.glBindFragmentShaderATI));
			}
			if (SuportedExt.Contains("glBindFramebufferEXT"))
			{
				dgtk.OpenGL.internalGLes.glBindFramebufferEXT = (dgtk.OpenGL.delegatesGLes.glBindFramebufferEXT) InternalTool.GetGLesMethodAdress("glBindFramebufferEXT", typeof(dgtk.OpenGL.delegatesGLes.glBindFramebufferEXT));
			}
			if (SuportedExt.Contains("glBindFramebufferOES"))
			{
				dgtk.OpenGL.internalGLes.glBindFramebufferOES = (dgtk.OpenGL.delegatesGLes.glBindFramebufferOES) InternalTool.GetGLesMethodAdress("glBindFramebufferOES", typeof(dgtk.OpenGL.delegatesGLes.glBindFramebufferOES));
			}
			if (SuportedExt.Contains("glBindImageTextureEXT"))
			{
				dgtk.OpenGL.internalGLes.glBindImageTextureEXT = (dgtk.OpenGL.delegatesGLes.glBindImageTextureEXT) InternalTool.GetGLesMethodAdress("glBindImageTextureEXT", typeof(dgtk.OpenGL.delegatesGLes.glBindImageTextureEXT));
			}
			if (SuportedExt.Contains("glBindLightParameterEXT"))
			{
				dgtk.OpenGL.internalGLes.glBindLightParameterEXT = (dgtk.OpenGL.delegatesGLes.glBindLightParameterEXT) InternalTool.GetGLesMethodAdress("glBindLightParameterEXT", typeof(dgtk.OpenGL.delegatesGLes.glBindLightParameterEXT));
			}
			if (SuportedExt.Contains("glBindMaterialParameterEXT"))
			{
				dgtk.OpenGL.internalGLes.glBindMaterialParameterEXT = (dgtk.OpenGL.delegatesGLes.glBindMaterialParameterEXT) InternalTool.GetGLesMethodAdress("glBindMaterialParameterEXT", typeof(dgtk.OpenGL.delegatesGLes.glBindMaterialParameterEXT));
			}
			if (SuportedExt.Contains("glBindMultiTextureEXT"))
			{
				dgtk.OpenGL.internalGLes.glBindMultiTextureEXT = (dgtk.OpenGL.delegatesGLes.glBindMultiTextureEXT) InternalTool.GetGLesMethodAdress("glBindMultiTextureEXT", typeof(dgtk.OpenGL.delegatesGLes.glBindMultiTextureEXT));
			}
			if (SuportedExt.Contains("glBindParameterEXT"))
			{
				dgtk.OpenGL.internalGLes.glBindParameterEXT = (dgtk.OpenGL.delegatesGLes.glBindParameterEXT) InternalTool.GetGLesMethodAdress("glBindParameterEXT", typeof(dgtk.OpenGL.delegatesGLes.glBindParameterEXT));
			}
			if (SuportedExt.Contains("glBindProgramARB"))
			{
				dgtk.OpenGL.internalGLes.glBindProgramARB = (dgtk.OpenGL.delegatesGLes.glBindProgramARB) InternalTool.GetGLesMethodAdress("glBindProgramARB", typeof(dgtk.OpenGL.delegatesGLes.glBindProgramARB));
			}
			if (SuportedExt.Contains("glBindProgramNV"))
			{
				dgtk.OpenGL.internalGLes.glBindProgramNV = (dgtk.OpenGL.delegatesGLes.glBindProgramNV) InternalTool.GetGLesMethodAdress("glBindProgramNV", typeof(dgtk.OpenGL.delegatesGLes.glBindProgramNV));
			}
			if (SuportedExt.Contains("glBindProgramPipelineEXT"))
			{
				dgtk.OpenGL.internalGLes.glBindProgramPipelineEXT = (dgtk.OpenGL.delegatesGLes.glBindProgramPipelineEXT) InternalTool.GetGLesMethodAdress("glBindProgramPipelineEXT", typeof(dgtk.OpenGL.delegatesGLes.glBindProgramPipelineEXT));
			}
			if (SuportedExt.Contains("glBindRenderbufferEXT"))
			{
				dgtk.OpenGL.internalGLes.glBindRenderbufferEXT = (dgtk.OpenGL.delegatesGLes.glBindRenderbufferEXT) InternalTool.GetGLesMethodAdress("glBindRenderbufferEXT", typeof(dgtk.OpenGL.delegatesGLes.glBindRenderbufferEXT));
			}
			if (SuportedExt.Contains("glBindRenderbufferOES"))
			{
				dgtk.OpenGL.internalGLes.glBindRenderbufferOES = (dgtk.OpenGL.delegatesGLes.glBindRenderbufferOES) InternalTool.GetGLesMethodAdress("glBindRenderbufferOES", typeof(dgtk.OpenGL.delegatesGLes.glBindRenderbufferOES));
			}
			if (SuportedExt.Contains("glBindShadingRateImageNV"))
			{
				dgtk.OpenGL.internalGLes.glBindShadingRateImageNV = (dgtk.OpenGL.delegatesGLes.glBindShadingRateImageNV) InternalTool.GetGLesMethodAdress("glBindShadingRateImageNV", typeof(dgtk.OpenGL.delegatesGLes.glBindShadingRateImageNV));
			}
			if (SuportedExt.Contains("glBindTexGenParameterEXT"))
			{
				dgtk.OpenGL.internalGLes.glBindTexGenParameterEXT = (dgtk.OpenGL.delegatesGLes.glBindTexGenParameterEXT) InternalTool.GetGLesMethodAdress("glBindTexGenParameterEXT", typeof(dgtk.OpenGL.delegatesGLes.glBindTexGenParameterEXT));
			}
			if (SuportedExt.Contains("glBindTextureEXT"))
			{
				dgtk.OpenGL.internalGLes.glBindTextureEXT = (dgtk.OpenGL.delegatesGLes.glBindTextureEXT) InternalTool.GetGLesMethodAdress("glBindTextureEXT", typeof(dgtk.OpenGL.delegatesGLes.glBindTextureEXT));
			}
			if (SuportedExt.Contains("glBindTextureUnitParameterEXT"))
			{
				dgtk.OpenGL.internalGLes.glBindTextureUnitParameterEXT = (dgtk.OpenGL.delegatesGLes.glBindTextureUnitParameterEXT) InternalTool.GetGLesMethodAdress("glBindTextureUnitParameterEXT", typeof(dgtk.OpenGL.delegatesGLes.glBindTextureUnitParameterEXT));
			}
			if (SuportedExt.Contains("glBindTransformFeedbackNV"))
			{
				dgtk.OpenGL.internalGLes.glBindTransformFeedbackNV = (dgtk.OpenGL.delegatesGLes.glBindTransformFeedbackNV) InternalTool.GetGLesMethodAdress("glBindTransformFeedbackNV", typeof(dgtk.OpenGL.delegatesGLes.glBindTransformFeedbackNV));
			}
			if (SuportedExt.Contains("glBindVertexArrayAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glBindVertexArrayAPPLE = (dgtk.OpenGL.delegatesGLes.glBindVertexArrayAPPLE) InternalTool.GetGLesMethodAdress("glBindVertexArrayAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glBindVertexArrayAPPLE));
			}
			if (SuportedExt.Contains("glBindVertexArrayOES"))
			{
				dgtk.OpenGL.internalGLes.glBindVertexArrayOES = (dgtk.OpenGL.delegatesGLes.glBindVertexArrayOES) InternalTool.GetGLesMethodAdress("glBindVertexArrayOES", typeof(dgtk.OpenGL.delegatesGLes.glBindVertexArrayOES));
			}
			if (SuportedExt.Contains("glBindVertexShaderEXT"))
			{
				dgtk.OpenGL.internalGLes.glBindVertexShaderEXT = (dgtk.OpenGL.delegatesGLes.glBindVertexShaderEXT) InternalTool.GetGLesMethodAdress("glBindVertexShaderEXT", typeof(dgtk.OpenGL.delegatesGLes.glBindVertexShaderEXT));
			}
			if (SuportedExt.Contains("glBindVideoCaptureStreamBufferNV"))
			{
				dgtk.OpenGL.internalGLes.glBindVideoCaptureStreamBufferNV = (dgtk.OpenGL.delegatesGLes.glBindVideoCaptureStreamBufferNV) InternalTool.GetGLesMethodAdress("glBindVideoCaptureStreamBufferNV", typeof(dgtk.OpenGL.delegatesGLes.glBindVideoCaptureStreamBufferNV));
			}
			if (SuportedExt.Contains("glBindVideoCaptureStreamTextureNV"))
			{
				dgtk.OpenGL.internalGLes.glBindVideoCaptureStreamTextureNV = (dgtk.OpenGL.delegatesGLes.glBindVideoCaptureStreamTextureNV) InternalTool.GetGLesMethodAdress("glBindVideoCaptureStreamTextureNV", typeof(dgtk.OpenGL.delegatesGLes.glBindVideoCaptureStreamTextureNV));
			}
			if (SuportedExt.Contains("glBinormal3bEXT"))
			{
				dgtk.OpenGL.internalGLes.glBinormal3bEXT = (dgtk.OpenGL.delegatesGLes.glBinormal3bEXT) InternalTool.GetGLesMethodAdress("glBinormal3bEXT", typeof(dgtk.OpenGL.delegatesGLes.glBinormal3bEXT));
			}
			if (SuportedExt.Contains("glBinormal3bvEXT"))
			{
				dgtk.OpenGL.internalGLes.glBinormal3bvEXT = (dgtk.OpenGL.delegatesGLes.glBinormal3bvEXT) InternalTool.GetGLesMethodAdress("glBinormal3bvEXT", typeof(dgtk.OpenGL.delegatesGLes.glBinormal3bvEXT));
			}
			if (SuportedExt.Contains("glBinormal3dEXT"))
			{
				dgtk.OpenGL.internalGLes.glBinormal3dEXT = (dgtk.OpenGL.delegatesGLes.glBinormal3dEXT) InternalTool.GetGLesMethodAdress("glBinormal3dEXT", typeof(dgtk.OpenGL.delegatesGLes.glBinormal3dEXT));
			}
			if (SuportedExt.Contains("glBinormal3dvEXT"))
			{
				dgtk.OpenGL.internalGLes.glBinormal3dvEXT = (dgtk.OpenGL.delegatesGLes.glBinormal3dvEXT) InternalTool.GetGLesMethodAdress("glBinormal3dvEXT", typeof(dgtk.OpenGL.delegatesGLes.glBinormal3dvEXT));
			}
			if (SuportedExt.Contains("glBinormal3fEXT"))
			{
				dgtk.OpenGL.internalGLes.glBinormal3fEXT = (dgtk.OpenGL.delegatesGLes.glBinormal3fEXT) InternalTool.GetGLesMethodAdress("glBinormal3fEXT", typeof(dgtk.OpenGL.delegatesGLes.glBinormal3fEXT));
			}
			if (SuportedExt.Contains("glBinormal3fvEXT"))
			{
				dgtk.OpenGL.internalGLes.glBinormal3fvEXT = (dgtk.OpenGL.delegatesGLes.glBinormal3fvEXT) InternalTool.GetGLesMethodAdress("glBinormal3fvEXT", typeof(dgtk.OpenGL.delegatesGLes.glBinormal3fvEXT));
			}
			if (SuportedExt.Contains("glBinormal3iEXT"))
			{
				dgtk.OpenGL.internalGLes.glBinormal3iEXT = (dgtk.OpenGL.delegatesGLes.glBinormal3iEXT) InternalTool.GetGLesMethodAdress("glBinormal3iEXT", typeof(dgtk.OpenGL.delegatesGLes.glBinormal3iEXT));
			}
			if (SuportedExt.Contains("glBinormal3ivEXT"))
			{
				dgtk.OpenGL.internalGLes.glBinormal3ivEXT = (dgtk.OpenGL.delegatesGLes.glBinormal3ivEXT) InternalTool.GetGLesMethodAdress("glBinormal3ivEXT", typeof(dgtk.OpenGL.delegatesGLes.glBinormal3ivEXT));
			}
			if (SuportedExt.Contains("glBinormal3sEXT"))
			{
				dgtk.OpenGL.internalGLes.glBinormal3sEXT = (dgtk.OpenGL.delegatesGLes.glBinormal3sEXT) InternalTool.GetGLesMethodAdress("glBinormal3sEXT", typeof(dgtk.OpenGL.delegatesGLes.glBinormal3sEXT));
			}
			if (SuportedExt.Contains("glBinormal3svEXT"))
			{
				dgtk.OpenGL.internalGLes.glBinormal3svEXT = (dgtk.OpenGL.delegatesGLes.glBinormal3svEXT) InternalTool.GetGLesMethodAdress("glBinormal3svEXT", typeof(dgtk.OpenGL.delegatesGLes.glBinormal3svEXT));
			}
			if (SuportedExt.Contains("glBinormalPointerEXT"))
			{
				dgtk.OpenGL.internalGLes.glBinormalPointerEXT = (dgtk.OpenGL.delegatesGLes.glBinormalPointerEXT) InternalTool.GetGLesMethodAdress("glBinormalPointerEXT", typeof(dgtk.OpenGL.delegatesGLes.glBinormalPointerEXT));
			}
			if (SuportedExt.Contains("glBitmapxOES"))
			{
				dgtk.OpenGL.internalGLes.glBitmapxOES = (dgtk.OpenGL.delegatesGLes.glBitmapxOES) InternalTool.GetGLesMethodAdress("glBitmapxOES", typeof(dgtk.OpenGL.delegatesGLes.glBitmapxOES));
			}
			if (SuportedExt.Contains("glBlendBarrier"))
			{
				dgtk.OpenGL.internalGLes.glBlendBarrier = (dgtk.OpenGL.delegatesGLes.glBlendBarrier) InternalTool.GetGLesMethodAdress("glBlendBarrier", typeof(dgtk.OpenGL.delegatesGLes.glBlendBarrier));
			}
			if (SuportedExt.Contains("glBlendBarrierKHR"))
			{
				dgtk.OpenGL.internalGLes.glBlendBarrierKHR = (dgtk.OpenGL.delegatesGLes.glBlendBarrierKHR) InternalTool.GetGLesMethodAdress("glBlendBarrierKHR", typeof(dgtk.OpenGL.delegatesGLes.glBlendBarrierKHR));
			}
			if (SuportedExt.Contains("glBlendBarrierNV"))
			{
				dgtk.OpenGL.internalGLes.glBlendBarrierNV = (dgtk.OpenGL.delegatesGLes.glBlendBarrierNV) InternalTool.GetGLesMethodAdress("glBlendBarrierNV", typeof(dgtk.OpenGL.delegatesGLes.glBlendBarrierNV));
			}
			if (SuportedExt.Contains("glBlendColorEXT"))
			{
				dgtk.OpenGL.internalGLes.glBlendColorEXT = (dgtk.OpenGL.delegatesGLes.glBlendColorEXT) InternalTool.GetGLesMethodAdress("glBlendColorEXT", typeof(dgtk.OpenGL.delegatesGLes.glBlendColorEXT));
			}
			if (SuportedExt.Contains("glBlendColorxOES"))
			{
				dgtk.OpenGL.internalGLes.glBlendColorxOES = (dgtk.OpenGL.delegatesGLes.glBlendColorxOES) InternalTool.GetGLesMethodAdress("glBlendColorxOES", typeof(dgtk.OpenGL.delegatesGLes.glBlendColorxOES));
			}
			if (SuportedExt.Contains("glBlendEquationEXT"))
			{
				dgtk.OpenGL.internalGLes.glBlendEquationEXT = (dgtk.OpenGL.delegatesGLes.glBlendEquationEXT) InternalTool.GetGLesMethodAdress("glBlendEquationEXT", typeof(dgtk.OpenGL.delegatesGLes.glBlendEquationEXT));
			}
			if (SuportedExt.Contains("glBlendEquationiARB"))
			{
				dgtk.OpenGL.internalGLes.glBlendEquationiARB = (dgtk.OpenGL.delegatesGLes.glBlendEquationiARB) InternalTool.GetGLesMethodAdress("glBlendEquationiARB", typeof(dgtk.OpenGL.delegatesGLes.glBlendEquationiARB));
			}
			if (SuportedExt.Contains("glBlendEquationiEXT"))
			{
				dgtk.OpenGL.internalGLes.glBlendEquationiEXT = (dgtk.OpenGL.delegatesGLes.glBlendEquationiEXT) InternalTool.GetGLesMethodAdress("glBlendEquationiEXT", typeof(dgtk.OpenGL.delegatesGLes.glBlendEquationiEXT));
			}
			if (SuportedExt.Contains("glBlendEquationIndexedAMD"))
			{
				dgtk.OpenGL.internalGLes.glBlendEquationIndexedAMD = (dgtk.OpenGL.delegatesGLes.glBlendEquationIndexedAMD) InternalTool.GetGLesMethodAdress("glBlendEquationIndexedAMD", typeof(dgtk.OpenGL.delegatesGLes.glBlendEquationIndexedAMD));
			}
			if (SuportedExt.Contains("glBlendEquationiOES"))
			{
				dgtk.OpenGL.internalGLes.glBlendEquationiOES = (dgtk.OpenGL.delegatesGLes.glBlendEquationiOES) InternalTool.GetGLesMethodAdress("glBlendEquationiOES", typeof(dgtk.OpenGL.delegatesGLes.glBlendEquationiOES));
			}
			if (SuportedExt.Contains("glBlendEquationOES"))
			{
				dgtk.OpenGL.internalGLes.glBlendEquationOES = (dgtk.OpenGL.delegatesGLes.glBlendEquationOES) InternalTool.GetGLesMethodAdress("glBlendEquationOES", typeof(dgtk.OpenGL.delegatesGLes.glBlendEquationOES));
			}
			if (SuportedExt.Contains("glBlendEquationSeparateEXT"))
			{
				dgtk.OpenGL.internalGLes.glBlendEquationSeparateEXT = (dgtk.OpenGL.delegatesGLes.glBlendEquationSeparateEXT) InternalTool.GetGLesMethodAdress("glBlendEquationSeparateEXT", typeof(dgtk.OpenGL.delegatesGLes.glBlendEquationSeparateEXT));
			}
			if (SuportedExt.Contains("glBlendEquationSeparateiARB"))
			{
				dgtk.OpenGL.internalGLes.glBlendEquationSeparateiARB = (dgtk.OpenGL.delegatesGLes.glBlendEquationSeparateiARB) InternalTool.GetGLesMethodAdress("glBlendEquationSeparateiARB", typeof(dgtk.OpenGL.delegatesGLes.glBlendEquationSeparateiARB));
			}
			if (SuportedExt.Contains("glBlendEquationSeparateiEXT"))
			{
				dgtk.OpenGL.internalGLes.glBlendEquationSeparateiEXT = (dgtk.OpenGL.delegatesGLes.glBlendEquationSeparateiEXT) InternalTool.GetGLesMethodAdress("glBlendEquationSeparateiEXT", typeof(dgtk.OpenGL.delegatesGLes.glBlendEquationSeparateiEXT));
			}
			if (SuportedExt.Contains("glBlendEquationSeparateIndexedAMD"))
			{
				dgtk.OpenGL.internalGLes.glBlendEquationSeparateIndexedAMD = (dgtk.OpenGL.delegatesGLes.glBlendEquationSeparateIndexedAMD) InternalTool.GetGLesMethodAdress("glBlendEquationSeparateIndexedAMD", typeof(dgtk.OpenGL.delegatesGLes.glBlendEquationSeparateIndexedAMD));
			}
			if (SuportedExt.Contains("glBlendEquationSeparateiOES"))
			{
				dgtk.OpenGL.internalGLes.glBlendEquationSeparateiOES = (dgtk.OpenGL.delegatesGLes.glBlendEquationSeparateiOES) InternalTool.GetGLesMethodAdress("glBlendEquationSeparateiOES", typeof(dgtk.OpenGL.delegatesGLes.glBlendEquationSeparateiOES));
			}
			if (SuportedExt.Contains("glBlendEquationSeparateOES"))
			{
				dgtk.OpenGL.internalGLes.glBlendEquationSeparateOES = (dgtk.OpenGL.delegatesGLes.glBlendEquationSeparateOES) InternalTool.GetGLesMethodAdress("glBlendEquationSeparateOES", typeof(dgtk.OpenGL.delegatesGLes.glBlendEquationSeparateOES));
			}
			if (SuportedExt.Contains("glBlendFunciARB"))
			{
				dgtk.OpenGL.internalGLes.glBlendFunciARB = (dgtk.OpenGL.delegatesGLes.glBlendFunciARB) InternalTool.GetGLesMethodAdress("glBlendFunciARB", typeof(dgtk.OpenGL.delegatesGLes.glBlendFunciARB));
			}
			if (SuportedExt.Contains("glBlendFunciEXT"))
			{
				dgtk.OpenGL.internalGLes.glBlendFunciEXT = (dgtk.OpenGL.delegatesGLes.glBlendFunciEXT) InternalTool.GetGLesMethodAdress("glBlendFunciEXT", typeof(dgtk.OpenGL.delegatesGLes.glBlendFunciEXT));
			}
			if (SuportedExt.Contains("glBlendFuncIndexedAMD"))
			{
				dgtk.OpenGL.internalGLes.glBlendFuncIndexedAMD = (dgtk.OpenGL.delegatesGLes.glBlendFuncIndexedAMD) InternalTool.GetGLesMethodAdress("glBlendFuncIndexedAMD", typeof(dgtk.OpenGL.delegatesGLes.glBlendFuncIndexedAMD));
			}
			if (SuportedExt.Contains("glBlendFunciOES"))
			{
				dgtk.OpenGL.internalGLes.glBlendFunciOES = (dgtk.OpenGL.delegatesGLes.glBlendFunciOES) InternalTool.GetGLesMethodAdress("glBlendFunciOES", typeof(dgtk.OpenGL.delegatesGLes.glBlendFunciOES));
			}
			if (SuportedExt.Contains("glBlendFuncSeparateEXT"))
			{
				dgtk.OpenGL.internalGLes.glBlendFuncSeparateEXT = (dgtk.OpenGL.delegatesGLes.glBlendFuncSeparateEXT) InternalTool.GetGLesMethodAdress("glBlendFuncSeparateEXT", typeof(dgtk.OpenGL.delegatesGLes.glBlendFuncSeparateEXT));
			}
			if (SuportedExt.Contains("glBlendFuncSeparateiARB"))
			{
				dgtk.OpenGL.internalGLes.glBlendFuncSeparateiARB = (dgtk.OpenGL.delegatesGLes.glBlendFuncSeparateiARB) InternalTool.GetGLesMethodAdress("glBlendFuncSeparateiARB", typeof(dgtk.OpenGL.delegatesGLes.glBlendFuncSeparateiARB));
			}
			if (SuportedExt.Contains("glBlendFuncSeparateiEXT"))
			{
				dgtk.OpenGL.internalGLes.glBlendFuncSeparateiEXT = (dgtk.OpenGL.delegatesGLes.glBlendFuncSeparateiEXT) InternalTool.GetGLesMethodAdress("glBlendFuncSeparateiEXT", typeof(dgtk.OpenGL.delegatesGLes.glBlendFuncSeparateiEXT));
			}
			if (SuportedExt.Contains("glBlendFuncSeparateIndexedAMD"))
			{
				dgtk.OpenGL.internalGLes.glBlendFuncSeparateIndexedAMD = (dgtk.OpenGL.delegatesGLes.glBlendFuncSeparateIndexedAMD) InternalTool.GetGLesMethodAdress("glBlendFuncSeparateIndexedAMD", typeof(dgtk.OpenGL.delegatesGLes.glBlendFuncSeparateIndexedAMD));
			}
			if (SuportedExt.Contains("glBlendFuncSeparateINGR"))
			{
				dgtk.OpenGL.internalGLes.glBlendFuncSeparateINGR = (dgtk.OpenGL.delegatesGLes.glBlendFuncSeparateINGR) InternalTool.GetGLesMethodAdress("glBlendFuncSeparateINGR", typeof(dgtk.OpenGL.delegatesGLes.glBlendFuncSeparateINGR));
			}
			if (SuportedExt.Contains("glBlendFuncSeparateiOES"))
			{
				dgtk.OpenGL.internalGLes.glBlendFuncSeparateiOES = (dgtk.OpenGL.delegatesGLes.glBlendFuncSeparateiOES) InternalTool.GetGLesMethodAdress("glBlendFuncSeparateiOES", typeof(dgtk.OpenGL.delegatesGLes.glBlendFuncSeparateiOES));
			}
			if (SuportedExt.Contains("glBlendFuncSeparateOES"))
			{
				dgtk.OpenGL.internalGLes.glBlendFuncSeparateOES = (dgtk.OpenGL.delegatesGLes.glBlendFuncSeparateOES) InternalTool.GetGLesMethodAdress("glBlendFuncSeparateOES", typeof(dgtk.OpenGL.delegatesGLes.glBlendFuncSeparateOES));
			}
			if (SuportedExt.Contains("glBlendParameteriNV"))
			{
				dgtk.OpenGL.internalGLes.glBlendParameteriNV = (dgtk.OpenGL.delegatesGLes.glBlendParameteriNV) InternalTool.GetGLesMethodAdress("glBlendParameteriNV", typeof(dgtk.OpenGL.delegatesGLes.glBlendParameteriNV));
			}
			if (SuportedExt.Contains("glBlitFramebufferANGLE"))
			{
				dgtk.OpenGL.internalGLes.glBlitFramebufferANGLE = (dgtk.OpenGL.delegatesGLes.glBlitFramebufferANGLE) InternalTool.GetGLesMethodAdress("glBlitFramebufferANGLE", typeof(dgtk.OpenGL.delegatesGLes.glBlitFramebufferANGLE));
			}
			if (SuportedExt.Contains("glBlitFramebufferEXT"))
			{
				dgtk.OpenGL.internalGLes.glBlitFramebufferEXT = (dgtk.OpenGL.delegatesGLes.glBlitFramebufferEXT) InternalTool.GetGLesMethodAdress("glBlitFramebufferEXT", typeof(dgtk.OpenGL.delegatesGLes.glBlitFramebufferEXT));
			}
			if (SuportedExt.Contains("glBlitFramebufferNV"))
			{
				dgtk.OpenGL.internalGLes.glBlitFramebufferNV = (dgtk.OpenGL.delegatesGLes.glBlitFramebufferNV) InternalTool.GetGLesMethodAdress("glBlitFramebufferNV", typeof(dgtk.OpenGL.delegatesGLes.glBlitFramebufferNV));
			}
			if (SuportedExt.Contains("glBufferAddressRangeNV"))
			{
				dgtk.OpenGL.internalGLes.glBufferAddressRangeNV = (dgtk.OpenGL.delegatesGLes.glBufferAddressRangeNV) InternalTool.GetGLesMethodAdress("glBufferAddressRangeNV", typeof(dgtk.OpenGL.delegatesGLes.glBufferAddressRangeNV));
			}
			if (SuportedExt.Contains("glBufferAttachMemoryNV"))
			{
				dgtk.OpenGL.internalGLes.glBufferAttachMemoryNV = (dgtk.OpenGL.delegatesGLes.glBufferAttachMemoryNV) InternalTool.GetGLesMethodAdress("glBufferAttachMemoryNV", typeof(dgtk.OpenGL.delegatesGLes.glBufferAttachMemoryNV));
			}
			if (SuportedExt.Contains("glBufferDataARB"))
			{
				dgtk.OpenGL.internalGLes.glBufferDataARB = (dgtk.OpenGL.delegatesGLes.glBufferDataARB) InternalTool.GetGLesMethodAdress("glBufferDataARB", typeof(dgtk.OpenGL.delegatesGLes.glBufferDataARB));
			}
			if (SuportedExt.Contains("glBufferPageCommitmentARB"))
			{
				dgtk.OpenGL.internalGLes.glBufferPageCommitmentARB = (dgtk.OpenGL.delegatesGLes.glBufferPageCommitmentARB) InternalTool.GetGLesMethodAdress("glBufferPageCommitmentARB", typeof(dgtk.OpenGL.delegatesGLes.glBufferPageCommitmentARB));
			}
			if (SuportedExt.Contains("glBufferPageCommitmentMemNV"))
			{
				dgtk.OpenGL.internalGLes.glBufferPageCommitmentMemNV = (dgtk.OpenGL.delegatesGLes.glBufferPageCommitmentMemNV) InternalTool.GetGLesMethodAdress("glBufferPageCommitmentMemNV", typeof(dgtk.OpenGL.delegatesGLes.glBufferPageCommitmentMemNV));
			}
			if (SuportedExt.Contains("glBufferParameteriAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glBufferParameteriAPPLE = (dgtk.OpenGL.delegatesGLes.glBufferParameteriAPPLE) InternalTool.GetGLesMethodAdress("glBufferParameteriAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glBufferParameteriAPPLE));
			}
			if (SuportedExt.Contains("glBufferStorageEXT"))
			{
				dgtk.OpenGL.internalGLes.glBufferStorageEXT = (dgtk.OpenGL.delegatesGLes.glBufferStorageEXT) InternalTool.GetGLesMethodAdress("glBufferStorageEXT", typeof(dgtk.OpenGL.delegatesGLes.glBufferStorageEXT));
			}
			if (SuportedExt.Contains("glBufferStorageExternalEXT"))
			{
				dgtk.OpenGL.internalGLes.glBufferStorageExternalEXT = (dgtk.OpenGL.delegatesGLes.glBufferStorageExternalEXT) InternalTool.GetGLesMethodAdress("glBufferStorageExternalEXT", typeof(dgtk.OpenGL.delegatesGLes.glBufferStorageExternalEXT));
			}
			if (SuportedExt.Contains("glBufferStorageMemEXT"))
			{
				dgtk.OpenGL.internalGLes.glBufferStorageMemEXT = (dgtk.OpenGL.delegatesGLes.glBufferStorageMemEXT) InternalTool.GetGLesMethodAdress("glBufferStorageMemEXT", typeof(dgtk.OpenGL.delegatesGLes.glBufferStorageMemEXT));
			}
			if (SuportedExt.Contains("glBufferSubDataARB"))
			{
				dgtk.OpenGL.internalGLes.glBufferSubDataARB = (dgtk.OpenGL.delegatesGLes.glBufferSubDataARB) InternalTool.GetGLesMethodAdress("glBufferSubDataARB", typeof(dgtk.OpenGL.delegatesGLes.glBufferSubDataARB));
			}
			#endregion

			#region C:

			if (SuportedExt.Contains("glCallCommandListNV"))
			{
				dgtk.OpenGL.internalGLes.glCallCommandListNV = (dgtk.OpenGL.delegatesGLes.glCallCommandListNV) InternalTool.GetGLesMethodAdress("glCallCommandListNV", typeof(dgtk.OpenGL.delegatesGLes.glCallCommandListNV));
			}
			if (SuportedExt.Contains("glCheckFramebufferStatusEXT"))
			{
				dgtk.OpenGL.internalGLes.glCheckFramebufferStatusEXT = (dgtk.OpenGL.delegatesGLes.glCheckFramebufferStatusEXT) InternalTool.GetGLesMethodAdress("glCheckFramebufferStatusEXT", typeof(dgtk.OpenGL.delegatesGLes.glCheckFramebufferStatusEXT));
			}
			if (SuportedExt.Contains("glCheckFramebufferStatusOES"))
			{
				dgtk.OpenGL.internalGLes.glCheckFramebufferStatusOES = (dgtk.OpenGL.delegatesGLes.glCheckFramebufferStatusOES) InternalTool.GetGLesMethodAdress("glCheckFramebufferStatusOES", typeof(dgtk.OpenGL.delegatesGLes.glCheckFramebufferStatusOES));
			}
			if (SuportedExt.Contains("glCheckNamedFramebufferStatusEXT"))
			{
				dgtk.OpenGL.internalGLes.glCheckNamedFramebufferStatusEXT = (dgtk.OpenGL.delegatesGLes.glCheckNamedFramebufferStatusEXT) InternalTool.GetGLesMethodAdress("glCheckNamedFramebufferStatusEXT", typeof(dgtk.OpenGL.delegatesGLes.glCheckNamedFramebufferStatusEXT));
			}
			if (SuportedExt.Contains("glClampColorARB"))
			{
				dgtk.OpenGL.internalGLes.glClampColorARB = (dgtk.OpenGL.delegatesGLes.glClampColorARB) InternalTool.GetGLesMethodAdress("glClampColorARB", typeof(dgtk.OpenGL.delegatesGLes.glClampColorARB));
			}
			if (SuportedExt.Contains("glClearAccumxOES"))
			{
				dgtk.OpenGL.internalGLes.glClearAccumxOES = (dgtk.OpenGL.delegatesGLes.glClearAccumxOES) InternalTool.GetGLesMethodAdress("glClearAccumxOES", typeof(dgtk.OpenGL.delegatesGLes.glClearAccumxOES));
			}
			if (SuportedExt.Contains("glClearColorIiEXT"))
			{
				dgtk.OpenGL.internalGLes.glClearColorIiEXT = (dgtk.OpenGL.delegatesGLes.glClearColorIiEXT) InternalTool.GetGLesMethodAdress("glClearColorIiEXT", typeof(dgtk.OpenGL.delegatesGLes.glClearColorIiEXT));
			}
			if (SuportedExt.Contains("glClearColorIuiEXT"))
			{
				dgtk.OpenGL.internalGLes.glClearColorIuiEXT = (dgtk.OpenGL.delegatesGLes.glClearColorIuiEXT) InternalTool.GetGLesMethodAdress("glClearColorIuiEXT", typeof(dgtk.OpenGL.delegatesGLes.glClearColorIuiEXT));
			}
			if (SuportedExt.Contains("glClearColorx"))
			{
				dgtk.OpenGL.internalGLes.glClearColorx = (dgtk.OpenGL.delegatesGLes.glClearColorx) InternalTool.GetGLesMethodAdress("glClearColorx", typeof(dgtk.OpenGL.delegatesGLes.glClearColorx));
			}
			if (SuportedExt.Contains("glClearColorxOES"))
			{
				dgtk.OpenGL.internalGLes.glClearColorxOES = (dgtk.OpenGL.delegatesGLes.glClearColorxOES) InternalTool.GetGLesMethodAdress("glClearColorxOES", typeof(dgtk.OpenGL.delegatesGLes.glClearColorxOES));
			}
			if (SuportedExt.Contains("glClearDepthdNV"))
			{
				dgtk.OpenGL.internalGLes.glClearDepthdNV = (dgtk.OpenGL.delegatesGLes.glClearDepthdNV) InternalTool.GetGLesMethodAdress("glClearDepthdNV", typeof(dgtk.OpenGL.delegatesGLes.glClearDepthdNV));
			}
			if (SuportedExt.Contains("glClearDepthfOES"))
			{
				dgtk.OpenGL.internalGLes.glClearDepthfOES = (dgtk.OpenGL.delegatesGLes.glClearDepthfOES) InternalTool.GetGLesMethodAdress("glClearDepthfOES", typeof(dgtk.OpenGL.delegatesGLes.glClearDepthfOES));
			}
			if (SuportedExt.Contains("glClearDepthx"))
			{
				dgtk.OpenGL.internalGLes.glClearDepthx = (dgtk.OpenGL.delegatesGLes.glClearDepthx) InternalTool.GetGLesMethodAdress("glClearDepthx", typeof(dgtk.OpenGL.delegatesGLes.glClearDepthx));
			}
			if (SuportedExt.Contains("glClearDepthxOES"))
			{
				dgtk.OpenGL.internalGLes.glClearDepthxOES = (dgtk.OpenGL.delegatesGLes.glClearDepthxOES) InternalTool.GetGLesMethodAdress("glClearDepthxOES", typeof(dgtk.OpenGL.delegatesGLes.glClearDepthxOES));
			}
			if (SuportedExt.Contains("glClearNamedBufferDataEXT"))
			{
				dgtk.OpenGL.internalGLes.glClearNamedBufferDataEXT = (dgtk.OpenGL.delegatesGLes.glClearNamedBufferDataEXT) InternalTool.GetGLesMethodAdress("glClearNamedBufferDataEXT", typeof(dgtk.OpenGL.delegatesGLes.glClearNamedBufferDataEXT));
			}
			if (SuportedExt.Contains("glClearNamedBufferSubDataEXT"))
			{
				dgtk.OpenGL.internalGLes.glClearNamedBufferSubDataEXT = (dgtk.OpenGL.delegatesGLes.glClearNamedBufferSubDataEXT) InternalTool.GetGLesMethodAdress("glClearNamedBufferSubDataEXT", typeof(dgtk.OpenGL.delegatesGLes.glClearNamedBufferSubDataEXT));
			}
			if (SuportedExt.Contains("glClearPixelLocalStorageuiEXT"))
			{
				dgtk.OpenGL.internalGLes.glClearPixelLocalStorageuiEXT = (dgtk.OpenGL.delegatesGLes.glClearPixelLocalStorageuiEXT) InternalTool.GetGLesMethodAdress("glClearPixelLocalStorageuiEXT", typeof(dgtk.OpenGL.delegatesGLes.glClearPixelLocalStorageuiEXT));
			}
			if (SuportedExt.Contains("glClearTexImageEXT"))
			{
				dgtk.OpenGL.internalGLes.glClearTexImageEXT = (dgtk.OpenGL.delegatesGLes.glClearTexImageEXT) InternalTool.GetGLesMethodAdress("glClearTexImageEXT", typeof(dgtk.OpenGL.delegatesGLes.glClearTexImageEXT));
			}
			if (SuportedExt.Contains("glClearTexSubImageEXT"))
			{
				dgtk.OpenGL.internalGLes.glClearTexSubImageEXT = (dgtk.OpenGL.delegatesGLes.glClearTexSubImageEXT) InternalTool.GetGLesMethodAdress("glClearTexSubImageEXT", typeof(dgtk.OpenGL.delegatesGLes.glClearTexSubImageEXT));
			}
			if (SuportedExt.Contains("glClientActiveTextureARB"))
			{
				dgtk.OpenGL.internalGLes.glClientActiveTextureARB = (dgtk.OpenGL.delegatesGLes.glClientActiveTextureARB) InternalTool.GetGLesMethodAdress("glClientActiveTextureARB", typeof(dgtk.OpenGL.delegatesGLes.glClientActiveTextureARB));
			}
			if (SuportedExt.Contains("glClientActiveVertexStreamATI"))
			{
				dgtk.OpenGL.internalGLes.glClientActiveVertexStreamATI = (dgtk.OpenGL.delegatesGLes.glClientActiveVertexStreamATI) InternalTool.GetGLesMethodAdress("glClientActiveVertexStreamATI", typeof(dgtk.OpenGL.delegatesGLes.glClientActiveVertexStreamATI));
			}
			if (SuportedExt.Contains("glClientAttribDefaultEXT"))
			{
				dgtk.OpenGL.internalGLes.glClientAttribDefaultEXT = (dgtk.OpenGL.delegatesGLes.glClientAttribDefaultEXT) InternalTool.GetGLesMethodAdress("glClientAttribDefaultEXT", typeof(dgtk.OpenGL.delegatesGLes.glClientAttribDefaultEXT));
			}
			if (SuportedExt.Contains("glClientWaitSemaphoreui64NVX"))
			{
				dgtk.OpenGL.internalGLes.glClientWaitSemaphoreui64NVX = (dgtk.OpenGL.delegatesGLes.glClientWaitSemaphoreui64NVX) InternalTool.GetGLesMethodAdress("glClientWaitSemaphoreui64NVX", typeof(dgtk.OpenGL.delegatesGLes.glClientWaitSemaphoreui64NVX));
			}
			if (SuportedExt.Contains("glClientWaitSyncAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glClientWaitSyncAPPLE = (dgtk.OpenGL.delegatesGLes.glClientWaitSyncAPPLE) InternalTool.GetGLesMethodAdress("glClientWaitSyncAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glClientWaitSyncAPPLE));
			}
			if (SuportedExt.Contains("glClipControlEXT"))
			{
				dgtk.OpenGL.internalGLes.glClipControlEXT = (dgtk.OpenGL.delegatesGLes.glClipControlEXT) InternalTool.GetGLesMethodAdress("glClipControlEXT", typeof(dgtk.OpenGL.delegatesGLes.glClipControlEXT));
			}
			if (SuportedExt.Contains("glClipPlanef"))
			{
				dgtk.OpenGL.internalGLes.glClipPlanef = (dgtk.OpenGL.delegatesGLes.glClipPlanef) InternalTool.GetGLesMethodAdress("glClipPlanef", typeof(dgtk.OpenGL.delegatesGLes.glClipPlanef));
			}
			if (SuportedExt.Contains("glClipPlanefIMG"))
			{
				dgtk.OpenGL.internalGLes.glClipPlanefIMG = (dgtk.OpenGL.delegatesGLes.glClipPlanefIMG) InternalTool.GetGLesMethodAdress("glClipPlanefIMG", typeof(dgtk.OpenGL.delegatesGLes.glClipPlanefIMG));
			}
			if (SuportedExt.Contains("glClipPlanefOES"))
			{
				dgtk.OpenGL.internalGLes.glClipPlanefOES = (dgtk.OpenGL.delegatesGLes.glClipPlanefOES) InternalTool.GetGLesMethodAdress("glClipPlanefOES", typeof(dgtk.OpenGL.delegatesGLes.glClipPlanefOES));
			}
			if (SuportedExt.Contains("glClipPlanex"))
			{
				dgtk.OpenGL.internalGLes.glClipPlanex = (dgtk.OpenGL.delegatesGLes.glClipPlanex) InternalTool.GetGLesMethodAdress("glClipPlanex", typeof(dgtk.OpenGL.delegatesGLes.glClipPlanex));
			}
			if (SuportedExt.Contains("glClipPlanexIMG"))
			{
				dgtk.OpenGL.internalGLes.glClipPlanexIMG = (dgtk.OpenGL.delegatesGLes.glClipPlanexIMG) InternalTool.GetGLesMethodAdress("glClipPlanexIMG", typeof(dgtk.OpenGL.delegatesGLes.glClipPlanexIMG));
			}
			if (SuportedExt.Contains("glClipPlanexOES"))
			{
				dgtk.OpenGL.internalGLes.glClipPlanexOES = (dgtk.OpenGL.delegatesGLes.glClipPlanexOES) InternalTool.GetGLesMethodAdress("glClipPlanexOES", typeof(dgtk.OpenGL.delegatesGLes.glClipPlanexOES));
			}
			if (SuportedExt.Contains("glColor3fVertex3fSUN"))
			{
				dgtk.OpenGL.internalGLes.glColor3fVertex3fSUN = (dgtk.OpenGL.delegatesGLes.glColor3fVertex3fSUN) InternalTool.GetGLesMethodAdress("glColor3fVertex3fSUN", typeof(dgtk.OpenGL.delegatesGLes.glColor3fVertex3fSUN));
			}
			if (SuportedExt.Contains("glColor3fVertex3fvSUN"))
			{
				dgtk.OpenGL.internalGLes.glColor3fVertex3fvSUN = (dgtk.OpenGL.delegatesGLes.glColor3fVertex3fvSUN) InternalTool.GetGLesMethodAdress("glColor3fVertex3fvSUN", typeof(dgtk.OpenGL.delegatesGLes.glColor3fVertex3fvSUN));
			}
			if (SuportedExt.Contains("glColor3hNV"))
			{
				dgtk.OpenGL.internalGLes.glColor3hNV = (dgtk.OpenGL.delegatesGLes.glColor3hNV) InternalTool.GetGLesMethodAdress("glColor3hNV", typeof(dgtk.OpenGL.delegatesGLes.glColor3hNV));
			}
			if (SuportedExt.Contains("glColor3hvNV"))
			{
				dgtk.OpenGL.internalGLes.glColor3hvNV = (dgtk.OpenGL.delegatesGLes.glColor3hvNV) InternalTool.GetGLesMethodAdress("glColor3hvNV", typeof(dgtk.OpenGL.delegatesGLes.glColor3hvNV));
			}
			if (SuportedExt.Contains("glColor3xOES"))
			{
				dgtk.OpenGL.internalGLes.glColor3xOES = (dgtk.OpenGL.delegatesGLes.glColor3xOES) InternalTool.GetGLesMethodAdress("glColor3xOES", typeof(dgtk.OpenGL.delegatesGLes.glColor3xOES));
			}
			if (SuportedExt.Contains("glColor3xvOES"))
			{
				dgtk.OpenGL.internalGLes.glColor3xvOES = (dgtk.OpenGL.delegatesGLes.glColor3xvOES) InternalTool.GetGLesMethodAdress("glColor3xvOES", typeof(dgtk.OpenGL.delegatesGLes.glColor3xvOES));
			}
			if (SuportedExt.Contains("glColor4fNormal3fVertex3fSUN"))
			{
				dgtk.OpenGL.internalGLes.glColor4fNormal3fVertex3fSUN = (dgtk.OpenGL.delegatesGLes.glColor4fNormal3fVertex3fSUN) InternalTool.GetGLesMethodAdress("glColor4fNormal3fVertex3fSUN", typeof(dgtk.OpenGL.delegatesGLes.glColor4fNormal3fVertex3fSUN));
			}
			if (SuportedExt.Contains("glColor4fNormal3fVertex3fvSUN"))
			{
				dgtk.OpenGL.internalGLes.glColor4fNormal3fVertex3fvSUN = (dgtk.OpenGL.delegatesGLes.glColor4fNormal3fVertex3fvSUN) InternalTool.GetGLesMethodAdress("glColor4fNormal3fVertex3fvSUN", typeof(dgtk.OpenGL.delegatesGLes.glColor4fNormal3fVertex3fvSUN));
			}
			if (SuportedExt.Contains("glColor4hNV"))
			{
				dgtk.OpenGL.internalGLes.glColor4hNV = (dgtk.OpenGL.delegatesGLes.glColor4hNV) InternalTool.GetGLesMethodAdress("glColor4hNV", typeof(dgtk.OpenGL.delegatesGLes.glColor4hNV));
			}
			if (SuportedExt.Contains("glColor4hvNV"))
			{
				dgtk.OpenGL.internalGLes.glColor4hvNV = (dgtk.OpenGL.delegatesGLes.glColor4hvNV) InternalTool.GetGLesMethodAdress("glColor4hvNV", typeof(dgtk.OpenGL.delegatesGLes.glColor4hvNV));
			}
			if (SuportedExt.Contains("glColor4ubVertex2fSUN"))
			{
				dgtk.OpenGL.internalGLes.glColor4ubVertex2fSUN = (dgtk.OpenGL.delegatesGLes.glColor4ubVertex2fSUN) InternalTool.GetGLesMethodAdress("glColor4ubVertex2fSUN", typeof(dgtk.OpenGL.delegatesGLes.glColor4ubVertex2fSUN));
			}
			if (SuportedExt.Contains("glColor4ubVertex2fvSUN"))
			{
				dgtk.OpenGL.internalGLes.glColor4ubVertex2fvSUN = (dgtk.OpenGL.delegatesGLes.glColor4ubVertex2fvSUN) InternalTool.GetGLesMethodAdress("glColor4ubVertex2fvSUN", typeof(dgtk.OpenGL.delegatesGLes.glColor4ubVertex2fvSUN));
			}
			if (SuportedExt.Contains("glColor4ubVertex3fSUN"))
			{
				dgtk.OpenGL.internalGLes.glColor4ubVertex3fSUN = (dgtk.OpenGL.delegatesGLes.glColor4ubVertex3fSUN) InternalTool.GetGLesMethodAdress("glColor4ubVertex3fSUN", typeof(dgtk.OpenGL.delegatesGLes.glColor4ubVertex3fSUN));
			}
			if (SuportedExt.Contains("glColor4ubVertex3fvSUN"))
			{
				dgtk.OpenGL.internalGLes.glColor4ubVertex3fvSUN = (dgtk.OpenGL.delegatesGLes.glColor4ubVertex3fvSUN) InternalTool.GetGLesMethodAdress("glColor4ubVertex3fvSUN", typeof(dgtk.OpenGL.delegatesGLes.glColor4ubVertex3fvSUN));
			}
			if (SuportedExt.Contains("glColor4x"))
			{
				dgtk.OpenGL.internalGLes.glColor4x = (dgtk.OpenGL.delegatesGLes.glColor4x) InternalTool.GetGLesMethodAdress("glColor4x", typeof(dgtk.OpenGL.delegatesGLes.glColor4x));
			}
			if (SuportedExt.Contains("glColor4xOES"))
			{
				dgtk.OpenGL.internalGLes.glColor4xOES = (dgtk.OpenGL.delegatesGLes.glColor4xOES) InternalTool.GetGLesMethodAdress("glColor4xOES", typeof(dgtk.OpenGL.delegatesGLes.glColor4xOES));
			}
			if (SuportedExt.Contains("glColor4xvOES"))
			{
				dgtk.OpenGL.internalGLes.glColor4xvOES = (dgtk.OpenGL.delegatesGLes.glColor4xvOES) InternalTool.GetGLesMethodAdress("glColor4xvOES", typeof(dgtk.OpenGL.delegatesGLes.glColor4xvOES));
			}
			if (SuportedExt.Contains("glColorFormatNV"))
			{
				dgtk.OpenGL.internalGLes.glColorFormatNV = (dgtk.OpenGL.delegatesGLes.glColorFormatNV) InternalTool.GetGLesMethodAdress("glColorFormatNV", typeof(dgtk.OpenGL.delegatesGLes.glColorFormatNV));
			}
			if (SuportedExt.Contains("glColorFragmentOp1ATI"))
			{
				dgtk.OpenGL.internalGLes.glColorFragmentOp1ATI = (dgtk.OpenGL.delegatesGLes.glColorFragmentOp1ATI) InternalTool.GetGLesMethodAdress("glColorFragmentOp1ATI", typeof(dgtk.OpenGL.delegatesGLes.glColorFragmentOp1ATI));
			}
			if (SuportedExt.Contains("glColorFragmentOp2ATI"))
			{
				dgtk.OpenGL.internalGLes.glColorFragmentOp2ATI = (dgtk.OpenGL.delegatesGLes.glColorFragmentOp2ATI) InternalTool.GetGLesMethodAdress("glColorFragmentOp2ATI", typeof(dgtk.OpenGL.delegatesGLes.glColorFragmentOp2ATI));
			}
			if (SuportedExt.Contains("glColorFragmentOp3ATI"))
			{
				dgtk.OpenGL.internalGLes.glColorFragmentOp3ATI = (dgtk.OpenGL.delegatesGLes.glColorFragmentOp3ATI) InternalTool.GetGLesMethodAdress("glColorFragmentOp3ATI", typeof(dgtk.OpenGL.delegatesGLes.glColorFragmentOp3ATI));
			}
			if (SuportedExt.Contains("glColorMaskiEXT"))
			{
				dgtk.OpenGL.internalGLes.glColorMaskiEXT = (dgtk.OpenGL.delegatesGLes.glColorMaskiEXT) InternalTool.GetGLesMethodAdress("glColorMaskiEXT", typeof(dgtk.OpenGL.delegatesGLes.glColorMaskiEXT));
			}
			if (SuportedExt.Contains("glColorMaskIndexedEXT"))
			{
				dgtk.OpenGL.internalGLes.glColorMaskIndexedEXT = (dgtk.OpenGL.delegatesGLes.glColorMaskIndexedEXT) InternalTool.GetGLesMethodAdress("glColorMaskIndexedEXT", typeof(dgtk.OpenGL.delegatesGLes.glColorMaskIndexedEXT));
			}
			if (SuportedExt.Contains("glColorMaskiOES"))
			{
				dgtk.OpenGL.internalGLes.glColorMaskiOES = (dgtk.OpenGL.delegatesGLes.glColorMaskiOES) InternalTool.GetGLesMethodAdress("glColorMaskiOES", typeof(dgtk.OpenGL.delegatesGLes.glColorMaskiOES));
			}
			if (SuportedExt.Contains("glColorPointerEXT"))
			{
				dgtk.OpenGL.internalGLes.glColorPointerEXT = (dgtk.OpenGL.delegatesGLes.glColorPointerEXT) InternalTool.GetGLesMethodAdress("glColorPointerEXT", typeof(dgtk.OpenGL.delegatesGLes.glColorPointerEXT));
			}
			if (SuportedExt.Contains("glColorPointerListIBM"))
			{
				dgtk.OpenGL.internalGLes.glColorPointerListIBM = (dgtk.OpenGL.delegatesGLes.glColorPointerListIBM) InternalTool.GetGLesMethodAdress("glColorPointerListIBM", typeof(dgtk.OpenGL.delegatesGLes.glColorPointerListIBM));
			}
			if (SuportedExt.Contains("glColorPointervINTEL"))
			{
				dgtk.OpenGL.internalGLes.glColorPointervINTEL = (dgtk.OpenGL.delegatesGLes.glColorPointervINTEL) InternalTool.GetGLesMethodAdress("glColorPointervINTEL", typeof(dgtk.OpenGL.delegatesGLes.glColorPointervINTEL));
			}
			if (SuportedExt.Contains("glColorSubTable"))
			{
				dgtk.OpenGL.internalGLes.glColorSubTable = (dgtk.OpenGL.delegatesGLes.glColorSubTable) InternalTool.GetGLesMethodAdress("glColorSubTable", typeof(dgtk.OpenGL.delegatesGLes.glColorSubTable));
			}
			if (SuportedExt.Contains("glColorSubTableEXT"))
			{
				dgtk.OpenGL.internalGLes.glColorSubTableEXT = (dgtk.OpenGL.delegatesGLes.glColorSubTableEXT) InternalTool.GetGLesMethodAdress("glColorSubTableEXT", typeof(dgtk.OpenGL.delegatesGLes.glColorSubTableEXT));
			}
			if (SuportedExt.Contains("glColorTable"))
			{
				dgtk.OpenGL.internalGLes.glColorTable = (dgtk.OpenGL.delegatesGLes.glColorTable) InternalTool.GetGLesMethodAdress("glColorTable", typeof(dgtk.OpenGL.delegatesGLes.glColorTable));
			}
			if (SuportedExt.Contains("glColorTableEXT"))
			{
				dgtk.OpenGL.internalGLes.glColorTableEXT = (dgtk.OpenGL.delegatesGLes.glColorTableEXT) InternalTool.GetGLesMethodAdress("glColorTableEXT", typeof(dgtk.OpenGL.delegatesGLes.glColorTableEXT));
			}
			if (SuportedExt.Contains("glColorTableParameterfv"))
			{
				dgtk.OpenGL.internalGLes.glColorTableParameterfv = (dgtk.OpenGL.delegatesGLes.glColorTableParameterfv) InternalTool.GetGLesMethodAdress("glColorTableParameterfv", typeof(dgtk.OpenGL.delegatesGLes.glColorTableParameterfv));
			}
			if (SuportedExt.Contains("glColorTableParameterfvSGI"))
			{
				dgtk.OpenGL.internalGLes.glColorTableParameterfvSGI = (dgtk.OpenGL.delegatesGLes.glColorTableParameterfvSGI) InternalTool.GetGLesMethodAdress("glColorTableParameterfvSGI", typeof(dgtk.OpenGL.delegatesGLes.glColorTableParameterfvSGI));
			}
			if (SuportedExt.Contains("glColorTableParameteriv"))
			{
				dgtk.OpenGL.internalGLes.glColorTableParameteriv = (dgtk.OpenGL.delegatesGLes.glColorTableParameteriv) InternalTool.GetGLesMethodAdress("glColorTableParameteriv", typeof(dgtk.OpenGL.delegatesGLes.glColorTableParameteriv));
			}
			if (SuportedExt.Contains("glColorTableParameterivSGI"))
			{
				dgtk.OpenGL.internalGLes.glColorTableParameterivSGI = (dgtk.OpenGL.delegatesGLes.glColorTableParameterivSGI) InternalTool.GetGLesMethodAdress("glColorTableParameterivSGI", typeof(dgtk.OpenGL.delegatesGLes.glColorTableParameterivSGI));
			}
			if (SuportedExt.Contains("glColorTableSGI"))
			{
				dgtk.OpenGL.internalGLes.glColorTableSGI = (dgtk.OpenGL.delegatesGLes.glColorTableSGI) InternalTool.GetGLesMethodAdress("glColorTableSGI", typeof(dgtk.OpenGL.delegatesGLes.glColorTableSGI));
			}
			if (SuportedExt.Contains("glCombinerInputNV"))
			{
				dgtk.OpenGL.internalGLes.glCombinerInputNV = (dgtk.OpenGL.delegatesGLes.glCombinerInputNV) InternalTool.GetGLesMethodAdress("glCombinerInputNV", typeof(dgtk.OpenGL.delegatesGLes.glCombinerInputNV));
			}
			if (SuportedExt.Contains("glCombinerOutputNV"))
			{
				dgtk.OpenGL.internalGLes.glCombinerOutputNV = (dgtk.OpenGL.delegatesGLes.glCombinerOutputNV) InternalTool.GetGLesMethodAdress("glCombinerOutputNV", typeof(dgtk.OpenGL.delegatesGLes.glCombinerOutputNV));
			}
			if (SuportedExt.Contains("glCombinerParameterfNV"))
			{
				dgtk.OpenGL.internalGLes.glCombinerParameterfNV = (dgtk.OpenGL.delegatesGLes.glCombinerParameterfNV) InternalTool.GetGLesMethodAdress("glCombinerParameterfNV", typeof(dgtk.OpenGL.delegatesGLes.glCombinerParameterfNV));
			}
			if (SuportedExt.Contains("glCombinerParameterfvNV"))
			{
				dgtk.OpenGL.internalGLes.glCombinerParameterfvNV = (dgtk.OpenGL.delegatesGLes.glCombinerParameterfvNV) InternalTool.GetGLesMethodAdress("glCombinerParameterfvNV", typeof(dgtk.OpenGL.delegatesGLes.glCombinerParameterfvNV));
			}
			if (SuportedExt.Contains("glCombinerParameteriNV"))
			{
				dgtk.OpenGL.internalGLes.glCombinerParameteriNV = (dgtk.OpenGL.delegatesGLes.glCombinerParameteriNV) InternalTool.GetGLesMethodAdress("glCombinerParameteriNV", typeof(dgtk.OpenGL.delegatesGLes.glCombinerParameteriNV));
			}
			if (SuportedExt.Contains("glCombinerParameterivNV"))
			{
				dgtk.OpenGL.internalGLes.glCombinerParameterivNV = (dgtk.OpenGL.delegatesGLes.glCombinerParameterivNV) InternalTool.GetGLesMethodAdress("glCombinerParameterivNV", typeof(dgtk.OpenGL.delegatesGLes.glCombinerParameterivNV));
			}
			if (SuportedExt.Contains("glCombinerStageParameterfvNV"))
			{
				dgtk.OpenGL.internalGLes.glCombinerStageParameterfvNV = (dgtk.OpenGL.delegatesGLes.glCombinerStageParameterfvNV) InternalTool.GetGLesMethodAdress("glCombinerStageParameterfvNV", typeof(dgtk.OpenGL.delegatesGLes.glCombinerStageParameterfvNV));
			}
			if (SuportedExt.Contains("glCommandListSegmentsNV"))
			{
				dgtk.OpenGL.internalGLes.glCommandListSegmentsNV = (dgtk.OpenGL.delegatesGLes.glCommandListSegmentsNV) InternalTool.GetGLesMethodAdress("glCommandListSegmentsNV", typeof(dgtk.OpenGL.delegatesGLes.glCommandListSegmentsNV));
			}
			if (SuportedExt.Contains("glCompileCommandListNV"))
			{
				dgtk.OpenGL.internalGLes.glCompileCommandListNV = (dgtk.OpenGL.delegatesGLes.glCompileCommandListNV) InternalTool.GetGLesMethodAdress("glCompileCommandListNV", typeof(dgtk.OpenGL.delegatesGLes.glCompileCommandListNV));
			}
			if (SuportedExt.Contains("glCompileShaderARB"))
			{
				dgtk.OpenGL.internalGLes.glCompileShaderARB = (dgtk.OpenGL.delegatesGLes.glCompileShaderARB) InternalTool.GetGLesMethodAdress("glCompileShaderARB", typeof(dgtk.OpenGL.delegatesGLes.glCompileShaderARB));
			}
			if (SuportedExt.Contains("glCompileShaderIncludeARB"))
			{
				dgtk.OpenGL.internalGLes.glCompileShaderIncludeARB = (dgtk.OpenGL.delegatesGLes.glCompileShaderIncludeARB) InternalTool.GetGLesMethodAdress("glCompileShaderIncludeARB", typeof(dgtk.OpenGL.delegatesGLes.glCompileShaderIncludeARB));
			}
			if (SuportedExt.Contains("glCompressedMultiTexImage1DEXT"))
			{
				dgtk.OpenGL.internalGLes.glCompressedMultiTexImage1DEXT = (dgtk.OpenGL.delegatesGLes.glCompressedMultiTexImage1DEXT) InternalTool.GetGLesMethodAdress("glCompressedMultiTexImage1DEXT", typeof(dgtk.OpenGL.delegatesGLes.glCompressedMultiTexImage1DEXT));
			}
			if (SuportedExt.Contains("glCompressedMultiTexImage2DEXT"))
			{
				dgtk.OpenGL.internalGLes.glCompressedMultiTexImage2DEXT = (dgtk.OpenGL.delegatesGLes.glCompressedMultiTexImage2DEXT) InternalTool.GetGLesMethodAdress("glCompressedMultiTexImage2DEXT", typeof(dgtk.OpenGL.delegatesGLes.glCompressedMultiTexImage2DEXT));
			}
			if (SuportedExt.Contains("glCompressedMultiTexImage3DEXT"))
			{
				dgtk.OpenGL.internalGLes.glCompressedMultiTexImage3DEXT = (dgtk.OpenGL.delegatesGLes.glCompressedMultiTexImage3DEXT) InternalTool.GetGLesMethodAdress("glCompressedMultiTexImage3DEXT", typeof(dgtk.OpenGL.delegatesGLes.glCompressedMultiTexImage3DEXT));
			}
			if (SuportedExt.Contains("glCompressedMultiTexSubImage1DEXT"))
			{
				dgtk.OpenGL.internalGLes.glCompressedMultiTexSubImage1DEXT = (dgtk.OpenGL.delegatesGLes.glCompressedMultiTexSubImage1DEXT) InternalTool.GetGLesMethodAdress("glCompressedMultiTexSubImage1DEXT", typeof(dgtk.OpenGL.delegatesGLes.glCompressedMultiTexSubImage1DEXT));
			}
			if (SuportedExt.Contains("glCompressedMultiTexSubImage2DEXT"))
			{
				dgtk.OpenGL.internalGLes.glCompressedMultiTexSubImage2DEXT = (dgtk.OpenGL.delegatesGLes.glCompressedMultiTexSubImage2DEXT) InternalTool.GetGLesMethodAdress("glCompressedMultiTexSubImage2DEXT", typeof(dgtk.OpenGL.delegatesGLes.glCompressedMultiTexSubImage2DEXT));
			}
			if (SuportedExt.Contains("glCompressedMultiTexSubImage3DEXT"))
			{
				dgtk.OpenGL.internalGLes.glCompressedMultiTexSubImage3DEXT = (dgtk.OpenGL.delegatesGLes.glCompressedMultiTexSubImage3DEXT) InternalTool.GetGLesMethodAdress("glCompressedMultiTexSubImage3DEXT", typeof(dgtk.OpenGL.delegatesGLes.glCompressedMultiTexSubImage3DEXT));
			}
			if (SuportedExt.Contains("glCompressedTexImage1DARB"))
			{
				dgtk.OpenGL.internalGLes.glCompressedTexImage1DARB = (dgtk.OpenGL.delegatesGLes.glCompressedTexImage1DARB) InternalTool.GetGLesMethodAdress("glCompressedTexImage1DARB", typeof(dgtk.OpenGL.delegatesGLes.glCompressedTexImage1DARB));
			}
			if (SuportedExt.Contains("glCompressedTexImage2DARB"))
			{
				dgtk.OpenGL.internalGLes.glCompressedTexImage2DARB = (dgtk.OpenGL.delegatesGLes.glCompressedTexImage2DARB) InternalTool.GetGLesMethodAdress("glCompressedTexImage2DARB", typeof(dgtk.OpenGL.delegatesGLes.glCompressedTexImage2DARB));
			}
			if (SuportedExt.Contains("glCompressedTexImage3DARB"))
			{
				dgtk.OpenGL.internalGLes.glCompressedTexImage3DARB = (dgtk.OpenGL.delegatesGLes.glCompressedTexImage3DARB) InternalTool.GetGLesMethodAdress("glCompressedTexImage3DARB", typeof(dgtk.OpenGL.delegatesGLes.glCompressedTexImage3DARB));
			}
			if (SuportedExt.Contains("glCompressedTexImage3DOES"))
			{
				dgtk.OpenGL.internalGLes.glCompressedTexImage3DOES = (dgtk.OpenGL.delegatesGLes.glCompressedTexImage3DOES) InternalTool.GetGLesMethodAdress("glCompressedTexImage3DOES", typeof(dgtk.OpenGL.delegatesGLes.glCompressedTexImage3DOES));
			}
			if (SuportedExt.Contains("glCompressedTexSubImage1DARB"))
			{
				dgtk.OpenGL.internalGLes.glCompressedTexSubImage1DARB = (dgtk.OpenGL.delegatesGLes.glCompressedTexSubImage1DARB) InternalTool.GetGLesMethodAdress("glCompressedTexSubImage1DARB", typeof(dgtk.OpenGL.delegatesGLes.glCompressedTexSubImage1DARB));
			}
			if (SuportedExt.Contains("glCompressedTexSubImage2DARB"))
			{
				dgtk.OpenGL.internalGLes.glCompressedTexSubImage2DARB = (dgtk.OpenGL.delegatesGLes.glCompressedTexSubImage2DARB) InternalTool.GetGLesMethodAdress("glCompressedTexSubImage2DARB", typeof(dgtk.OpenGL.delegatesGLes.glCompressedTexSubImage2DARB));
			}
			if (SuportedExt.Contains("glCompressedTexSubImage3DARB"))
			{
				dgtk.OpenGL.internalGLes.glCompressedTexSubImage3DARB = (dgtk.OpenGL.delegatesGLes.glCompressedTexSubImage3DARB) InternalTool.GetGLesMethodAdress("glCompressedTexSubImage3DARB", typeof(dgtk.OpenGL.delegatesGLes.glCompressedTexSubImage3DARB));
			}
			if (SuportedExt.Contains("glCompressedTexSubImage3DOES"))
			{
				dgtk.OpenGL.internalGLes.glCompressedTexSubImage3DOES = (dgtk.OpenGL.delegatesGLes.glCompressedTexSubImage3DOES) InternalTool.GetGLesMethodAdress("glCompressedTexSubImage3DOES", typeof(dgtk.OpenGL.delegatesGLes.glCompressedTexSubImage3DOES));
			}
			if (SuportedExt.Contains("glCompressedTextureImage1DEXT"))
			{
				dgtk.OpenGL.internalGLes.glCompressedTextureImage1DEXT = (dgtk.OpenGL.delegatesGLes.glCompressedTextureImage1DEXT) InternalTool.GetGLesMethodAdress("glCompressedTextureImage1DEXT", typeof(dgtk.OpenGL.delegatesGLes.glCompressedTextureImage1DEXT));
			}
			if (SuportedExt.Contains("glCompressedTextureImage2DEXT"))
			{
				dgtk.OpenGL.internalGLes.glCompressedTextureImage2DEXT = (dgtk.OpenGL.delegatesGLes.glCompressedTextureImage2DEXT) InternalTool.GetGLesMethodAdress("glCompressedTextureImage2DEXT", typeof(dgtk.OpenGL.delegatesGLes.glCompressedTextureImage2DEXT));
			}
			if (SuportedExt.Contains("glCompressedTextureImage3DEXT"))
			{
				dgtk.OpenGL.internalGLes.glCompressedTextureImage3DEXT = (dgtk.OpenGL.delegatesGLes.glCompressedTextureImage3DEXT) InternalTool.GetGLesMethodAdress("glCompressedTextureImage3DEXT", typeof(dgtk.OpenGL.delegatesGLes.glCompressedTextureImage3DEXT));
			}
			if (SuportedExt.Contains("glCompressedTextureSubImage1DEXT"))
			{
				dgtk.OpenGL.internalGLes.glCompressedTextureSubImage1DEXT = (dgtk.OpenGL.delegatesGLes.glCompressedTextureSubImage1DEXT) InternalTool.GetGLesMethodAdress("glCompressedTextureSubImage1DEXT", typeof(dgtk.OpenGL.delegatesGLes.glCompressedTextureSubImage1DEXT));
			}
			if (SuportedExt.Contains("glCompressedTextureSubImage2DEXT"))
			{
				dgtk.OpenGL.internalGLes.glCompressedTextureSubImage2DEXT = (dgtk.OpenGL.delegatesGLes.glCompressedTextureSubImage2DEXT) InternalTool.GetGLesMethodAdress("glCompressedTextureSubImage2DEXT", typeof(dgtk.OpenGL.delegatesGLes.glCompressedTextureSubImage2DEXT));
			}
			if (SuportedExt.Contains("glCompressedTextureSubImage3DEXT"))
			{
				dgtk.OpenGL.internalGLes.glCompressedTextureSubImage3DEXT = (dgtk.OpenGL.delegatesGLes.glCompressedTextureSubImage3DEXT) InternalTool.GetGLesMethodAdress("glCompressedTextureSubImage3DEXT", typeof(dgtk.OpenGL.delegatesGLes.glCompressedTextureSubImage3DEXT));
			}
			if (SuportedExt.Contains("glConservativeRasterParameterfNV"))
			{
				dgtk.OpenGL.internalGLes.glConservativeRasterParameterfNV = (dgtk.OpenGL.delegatesGLes.glConservativeRasterParameterfNV) InternalTool.GetGLesMethodAdress("glConservativeRasterParameterfNV", typeof(dgtk.OpenGL.delegatesGLes.glConservativeRasterParameterfNV));
			}
			if (SuportedExt.Contains("glConservativeRasterParameteriNV"))
			{
				dgtk.OpenGL.internalGLes.glConservativeRasterParameteriNV = (dgtk.OpenGL.delegatesGLes.glConservativeRasterParameteriNV) InternalTool.GetGLesMethodAdress("glConservativeRasterParameteriNV", typeof(dgtk.OpenGL.delegatesGLes.glConservativeRasterParameteriNV));
			}
			if (SuportedExt.Contains("glConvolutionFilter1D"))
			{
				dgtk.OpenGL.internalGLes.glConvolutionFilter1D = (dgtk.OpenGL.delegatesGLes.glConvolutionFilter1D) InternalTool.GetGLesMethodAdress("glConvolutionFilter1D", typeof(dgtk.OpenGL.delegatesGLes.glConvolutionFilter1D));
			}
			if (SuportedExt.Contains("glConvolutionFilter1DEXT"))
			{
				dgtk.OpenGL.internalGLes.glConvolutionFilter1DEXT = (dgtk.OpenGL.delegatesGLes.glConvolutionFilter1DEXT) InternalTool.GetGLesMethodAdress("glConvolutionFilter1DEXT", typeof(dgtk.OpenGL.delegatesGLes.glConvolutionFilter1DEXT));
			}
			if (SuportedExt.Contains("glConvolutionFilter2D"))
			{
				dgtk.OpenGL.internalGLes.glConvolutionFilter2D = (dgtk.OpenGL.delegatesGLes.glConvolutionFilter2D) InternalTool.GetGLesMethodAdress("glConvolutionFilter2D", typeof(dgtk.OpenGL.delegatesGLes.glConvolutionFilter2D));
			}
			if (SuportedExt.Contains("glConvolutionFilter2DEXT"))
			{
				dgtk.OpenGL.internalGLes.glConvolutionFilter2DEXT = (dgtk.OpenGL.delegatesGLes.glConvolutionFilter2DEXT) InternalTool.GetGLesMethodAdress("glConvolutionFilter2DEXT", typeof(dgtk.OpenGL.delegatesGLes.glConvolutionFilter2DEXT));
			}
			if (SuportedExt.Contains("glConvolutionParameterf"))
			{
				dgtk.OpenGL.internalGLes.glConvolutionParameterf = (dgtk.OpenGL.delegatesGLes.glConvolutionParameterf) InternalTool.GetGLesMethodAdress("glConvolutionParameterf", typeof(dgtk.OpenGL.delegatesGLes.glConvolutionParameterf));
			}
			if (SuportedExt.Contains("glConvolutionParameterfEXT"))
			{
				dgtk.OpenGL.internalGLes.glConvolutionParameterfEXT = (dgtk.OpenGL.delegatesGLes.glConvolutionParameterfEXT) InternalTool.GetGLesMethodAdress("glConvolutionParameterfEXT", typeof(dgtk.OpenGL.delegatesGLes.glConvolutionParameterfEXT));
			}
			if (SuportedExt.Contains("glConvolutionParameterfv"))
			{
				dgtk.OpenGL.internalGLes.glConvolutionParameterfv = (dgtk.OpenGL.delegatesGLes.glConvolutionParameterfv) InternalTool.GetGLesMethodAdress("glConvolutionParameterfv", typeof(dgtk.OpenGL.delegatesGLes.glConvolutionParameterfv));
			}
			if (SuportedExt.Contains("glConvolutionParameterfvEXT"))
			{
				dgtk.OpenGL.internalGLes.glConvolutionParameterfvEXT = (dgtk.OpenGL.delegatesGLes.glConvolutionParameterfvEXT) InternalTool.GetGLesMethodAdress("glConvolutionParameterfvEXT", typeof(dgtk.OpenGL.delegatesGLes.glConvolutionParameterfvEXT));
			}
			if (SuportedExt.Contains("glConvolutionParameteri"))
			{
				dgtk.OpenGL.internalGLes.glConvolutionParameteri = (dgtk.OpenGL.delegatesGLes.glConvolutionParameteri) InternalTool.GetGLesMethodAdress("glConvolutionParameteri", typeof(dgtk.OpenGL.delegatesGLes.glConvolutionParameteri));
			}
			if (SuportedExt.Contains("glConvolutionParameteriEXT"))
			{
				dgtk.OpenGL.internalGLes.glConvolutionParameteriEXT = (dgtk.OpenGL.delegatesGLes.glConvolutionParameteriEXT) InternalTool.GetGLesMethodAdress("glConvolutionParameteriEXT", typeof(dgtk.OpenGL.delegatesGLes.glConvolutionParameteriEXT));
			}
			if (SuportedExt.Contains("glConvolutionParameteriv"))
			{
				dgtk.OpenGL.internalGLes.glConvolutionParameteriv = (dgtk.OpenGL.delegatesGLes.glConvolutionParameteriv) InternalTool.GetGLesMethodAdress("glConvolutionParameteriv", typeof(dgtk.OpenGL.delegatesGLes.glConvolutionParameteriv));
			}
			if (SuportedExt.Contains("glConvolutionParameterivEXT"))
			{
				dgtk.OpenGL.internalGLes.glConvolutionParameterivEXT = (dgtk.OpenGL.delegatesGLes.glConvolutionParameterivEXT) InternalTool.GetGLesMethodAdress("glConvolutionParameterivEXT", typeof(dgtk.OpenGL.delegatesGLes.glConvolutionParameterivEXT));
			}
			if (SuportedExt.Contains("glConvolutionParameterxOES"))
			{
				dgtk.OpenGL.internalGLes.glConvolutionParameterxOES = (dgtk.OpenGL.delegatesGLes.glConvolutionParameterxOES) InternalTool.GetGLesMethodAdress("glConvolutionParameterxOES", typeof(dgtk.OpenGL.delegatesGLes.glConvolutionParameterxOES));
			}
			if (SuportedExt.Contains("glConvolutionParameterxvOES"))
			{
				dgtk.OpenGL.internalGLes.glConvolutionParameterxvOES = (dgtk.OpenGL.delegatesGLes.glConvolutionParameterxvOES) InternalTool.GetGLesMethodAdress("glConvolutionParameterxvOES", typeof(dgtk.OpenGL.delegatesGLes.glConvolutionParameterxvOES));
			}
			if (SuportedExt.Contains("glCopyBufferSubDataNV"))
			{
				dgtk.OpenGL.internalGLes.glCopyBufferSubDataNV = (dgtk.OpenGL.delegatesGLes.glCopyBufferSubDataNV) InternalTool.GetGLesMethodAdress("glCopyBufferSubDataNV", typeof(dgtk.OpenGL.delegatesGLes.glCopyBufferSubDataNV));
			}
			if (SuportedExt.Contains("glCopyColorSubTable"))
			{
				dgtk.OpenGL.internalGLes.glCopyColorSubTable = (dgtk.OpenGL.delegatesGLes.glCopyColorSubTable) InternalTool.GetGLesMethodAdress("glCopyColorSubTable", typeof(dgtk.OpenGL.delegatesGLes.glCopyColorSubTable));
			}
			if (SuportedExt.Contains("glCopyColorSubTableEXT"))
			{
				dgtk.OpenGL.internalGLes.glCopyColorSubTableEXT = (dgtk.OpenGL.delegatesGLes.glCopyColorSubTableEXT) InternalTool.GetGLesMethodAdress("glCopyColorSubTableEXT", typeof(dgtk.OpenGL.delegatesGLes.glCopyColorSubTableEXT));
			}
			if (SuportedExt.Contains("glCopyColorTable"))
			{
				dgtk.OpenGL.internalGLes.glCopyColorTable = (dgtk.OpenGL.delegatesGLes.glCopyColorTable) InternalTool.GetGLesMethodAdress("glCopyColorTable", typeof(dgtk.OpenGL.delegatesGLes.glCopyColorTable));
			}
			if (SuportedExt.Contains("glCopyColorTableSGI"))
			{
				dgtk.OpenGL.internalGLes.glCopyColorTableSGI = (dgtk.OpenGL.delegatesGLes.glCopyColorTableSGI) InternalTool.GetGLesMethodAdress("glCopyColorTableSGI", typeof(dgtk.OpenGL.delegatesGLes.glCopyColorTableSGI));
			}
			if (SuportedExt.Contains("glCopyConvolutionFilter1D"))
			{
				dgtk.OpenGL.internalGLes.glCopyConvolutionFilter1D = (dgtk.OpenGL.delegatesGLes.glCopyConvolutionFilter1D) InternalTool.GetGLesMethodAdress("glCopyConvolutionFilter1D", typeof(dgtk.OpenGL.delegatesGLes.glCopyConvolutionFilter1D));
			}
			if (SuportedExt.Contains("glCopyConvolutionFilter1DEXT"))
			{
				dgtk.OpenGL.internalGLes.glCopyConvolutionFilter1DEXT = (dgtk.OpenGL.delegatesGLes.glCopyConvolutionFilter1DEXT) InternalTool.GetGLesMethodAdress("glCopyConvolutionFilter1DEXT", typeof(dgtk.OpenGL.delegatesGLes.glCopyConvolutionFilter1DEXT));
			}
			if (SuportedExt.Contains("glCopyConvolutionFilter2D"))
			{
				dgtk.OpenGL.internalGLes.glCopyConvolutionFilter2D = (dgtk.OpenGL.delegatesGLes.glCopyConvolutionFilter2D) InternalTool.GetGLesMethodAdress("glCopyConvolutionFilter2D", typeof(dgtk.OpenGL.delegatesGLes.glCopyConvolutionFilter2D));
			}
			if (SuportedExt.Contains("glCopyConvolutionFilter2DEXT"))
			{
				dgtk.OpenGL.internalGLes.glCopyConvolutionFilter2DEXT = (dgtk.OpenGL.delegatesGLes.glCopyConvolutionFilter2DEXT) InternalTool.GetGLesMethodAdress("glCopyConvolutionFilter2DEXT", typeof(dgtk.OpenGL.delegatesGLes.glCopyConvolutionFilter2DEXT));
			}
			if (SuportedExt.Contains("glCopyImageSubDataEXT"))
			{
				dgtk.OpenGL.internalGLes.glCopyImageSubDataEXT = (dgtk.OpenGL.delegatesGLes.glCopyImageSubDataEXT) InternalTool.GetGLesMethodAdress("glCopyImageSubDataEXT", typeof(dgtk.OpenGL.delegatesGLes.glCopyImageSubDataEXT));
			}
			if (SuportedExt.Contains("glCopyImageSubDataNV"))
			{
				dgtk.OpenGL.internalGLes.glCopyImageSubDataNV = (dgtk.OpenGL.delegatesGLes.glCopyImageSubDataNV) InternalTool.GetGLesMethodAdress("glCopyImageSubDataNV", typeof(dgtk.OpenGL.delegatesGLes.glCopyImageSubDataNV));
			}
			if (SuportedExt.Contains("glCopyImageSubDataOES"))
			{
				dgtk.OpenGL.internalGLes.glCopyImageSubDataOES = (dgtk.OpenGL.delegatesGLes.glCopyImageSubDataOES) InternalTool.GetGLesMethodAdress("glCopyImageSubDataOES", typeof(dgtk.OpenGL.delegatesGLes.glCopyImageSubDataOES));
			}
			if (SuportedExt.Contains("glCopyMultiTexImage1DEXT"))
			{
				dgtk.OpenGL.internalGLes.glCopyMultiTexImage1DEXT = (dgtk.OpenGL.delegatesGLes.glCopyMultiTexImage1DEXT) InternalTool.GetGLesMethodAdress("glCopyMultiTexImage1DEXT", typeof(dgtk.OpenGL.delegatesGLes.glCopyMultiTexImage1DEXT));
			}
			if (SuportedExt.Contains("glCopyMultiTexImage2DEXT"))
			{
				dgtk.OpenGL.internalGLes.glCopyMultiTexImage2DEXT = (dgtk.OpenGL.delegatesGLes.glCopyMultiTexImage2DEXT) InternalTool.GetGLesMethodAdress("glCopyMultiTexImage2DEXT", typeof(dgtk.OpenGL.delegatesGLes.glCopyMultiTexImage2DEXT));
			}
			if (SuportedExt.Contains("glCopyMultiTexSubImage1DEXT"))
			{
				dgtk.OpenGL.internalGLes.glCopyMultiTexSubImage1DEXT = (dgtk.OpenGL.delegatesGLes.glCopyMultiTexSubImage1DEXT) InternalTool.GetGLesMethodAdress("glCopyMultiTexSubImage1DEXT", typeof(dgtk.OpenGL.delegatesGLes.glCopyMultiTexSubImage1DEXT));
			}
			if (SuportedExt.Contains("glCopyMultiTexSubImage2DEXT"))
			{
				dgtk.OpenGL.internalGLes.glCopyMultiTexSubImage2DEXT = (dgtk.OpenGL.delegatesGLes.glCopyMultiTexSubImage2DEXT) InternalTool.GetGLesMethodAdress("glCopyMultiTexSubImage2DEXT", typeof(dgtk.OpenGL.delegatesGLes.glCopyMultiTexSubImage2DEXT));
			}
			if (SuportedExt.Contains("glCopyMultiTexSubImage3DEXT"))
			{
				dgtk.OpenGL.internalGLes.glCopyMultiTexSubImage3DEXT = (dgtk.OpenGL.delegatesGLes.glCopyMultiTexSubImage3DEXT) InternalTool.GetGLesMethodAdress("glCopyMultiTexSubImage3DEXT", typeof(dgtk.OpenGL.delegatesGLes.glCopyMultiTexSubImage3DEXT));
			}
			if (SuportedExt.Contains("glCopyPathNV"))
			{
				dgtk.OpenGL.internalGLes.glCopyPathNV = (dgtk.OpenGL.delegatesGLes.glCopyPathNV) InternalTool.GetGLesMethodAdress("glCopyPathNV", typeof(dgtk.OpenGL.delegatesGLes.glCopyPathNV));
			}
			if (SuportedExt.Contains("glCopyTexImage1DEXT"))
			{
				dgtk.OpenGL.internalGLes.glCopyTexImage1DEXT = (dgtk.OpenGL.delegatesGLes.glCopyTexImage1DEXT) InternalTool.GetGLesMethodAdress("glCopyTexImage1DEXT", typeof(dgtk.OpenGL.delegatesGLes.glCopyTexImage1DEXT));
			}
			if (SuportedExt.Contains("glCopyTexImage2DEXT"))
			{
				dgtk.OpenGL.internalGLes.glCopyTexImage2DEXT = (dgtk.OpenGL.delegatesGLes.glCopyTexImage2DEXT) InternalTool.GetGLesMethodAdress("glCopyTexImage2DEXT", typeof(dgtk.OpenGL.delegatesGLes.glCopyTexImage2DEXT));
			}
			if (SuportedExt.Contains("glCopyTexSubImage1DEXT"))
			{
				dgtk.OpenGL.internalGLes.glCopyTexSubImage1DEXT = (dgtk.OpenGL.delegatesGLes.glCopyTexSubImage1DEXT) InternalTool.GetGLesMethodAdress("glCopyTexSubImage1DEXT", typeof(dgtk.OpenGL.delegatesGLes.glCopyTexSubImage1DEXT));
			}
			if (SuportedExt.Contains("glCopyTexSubImage2DEXT"))
			{
				dgtk.OpenGL.internalGLes.glCopyTexSubImage2DEXT = (dgtk.OpenGL.delegatesGLes.glCopyTexSubImage2DEXT) InternalTool.GetGLesMethodAdress("glCopyTexSubImage2DEXT", typeof(dgtk.OpenGL.delegatesGLes.glCopyTexSubImage2DEXT));
			}
			if (SuportedExt.Contains("glCopyTexSubImage3DEXT"))
			{
				dgtk.OpenGL.internalGLes.glCopyTexSubImage3DEXT = (dgtk.OpenGL.delegatesGLes.glCopyTexSubImage3DEXT) InternalTool.GetGLesMethodAdress("glCopyTexSubImage3DEXT", typeof(dgtk.OpenGL.delegatesGLes.glCopyTexSubImage3DEXT));
			}
			if (SuportedExt.Contains("glCopyTexSubImage3DOES"))
			{
				dgtk.OpenGL.internalGLes.glCopyTexSubImage3DOES = (dgtk.OpenGL.delegatesGLes.glCopyTexSubImage3DOES) InternalTool.GetGLesMethodAdress("glCopyTexSubImage3DOES", typeof(dgtk.OpenGL.delegatesGLes.glCopyTexSubImage3DOES));
			}
			if (SuportedExt.Contains("glCopyTextureImage1DEXT"))
			{
				dgtk.OpenGL.internalGLes.glCopyTextureImage1DEXT = (dgtk.OpenGL.delegatesGLes.glCopyTextureImage1DEXT) InternalTool.GetGLesMethodAdress("glCopyTextureImage1DEXT", typeof(dgtk.OpenGL.delegatesGLes.glCopyTextureImage1DEXT));
			}
			if (SuportedExt.Contains("glCopyTextureImage2DEXT"))
			{
				dgtk.OpenGL.internalGLes.glCopyTextureImage2DEXT = (dgtk.OpenGL.delegatesGLes.glCopyTextureImage2DEXT) InternalTool.GetGLesMethodAdress("glCopyTextureImage2DEXT", typeof(dgtk.OpenGL.delegatesGLes.glCopyTextureImage2DEXT));
			}
			if (SuportedExt.Contains("glCopyTextureLevelsAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glCopyTextureLevelsAPPLE = (dgtk.OpenGL.delegatesGLes.glCopyTextureLevelsAPPLE) InternalTool.GetGLesMethodAdress("glCopyTextureLevelsAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glCopyTextureLevelsAPPLE));
			}
			if (SuportedExt.Contains("glCopyTextureSubImage1DEXT"))
			{
				dgtk.OpenGL.internalGLes.glCopyTextureSubImage1DEXT = (dgtk.OpenGL.delegatesGLes.glCopyTextureSubImage1DEXT) InternalTool.GetGLesMethodAdress("glCopyTextureSubImage1DEXT", typeof(dgtk.OpenGL.delegatesGLes.glCopyTextureSubImage1DEXT));
			}
			if (SuportedExt.Contains("glCopyTextureSubImage2DEXT"))
			{
				dgtk.OpenGL.internalGLes.glCopyTextureSubImage2DEXT = (dgtk.OpenGL.delegatesGLes.glCopyTextureSubImage2DEXT) InternalTool.GetGLesMethodAdress("glCopyTextureSubImage2DEXT", typeof(dgtk.OpenGL.delegatesGLes.glCopyTextureSubImage2DEXT));
			}
			if (SuportedExt.Contains("glCopyTextureSubImage3DEXT"))
			{
				dgtk.OpenGL.internalGLes.glCopyTextureSubImage3DEXT = (dgtk.OpenGL.delegatesGLes.glCopyTextureSubImage3DEXT) InternalTool.GetGLesMethodAdress("glCopyTextureSubImage3DEXT", typeof(dgtk.OpenGL.delegatesGLes.glCopyTextureSubImage3DEXT));
			}
			if (SuportedExt.Contains("glCoverageMaskNV"))
			{
				dgtk.OpenGL.internalGLes.glCoverageMaskNV = (dgtk.OpenGL.delegatesGLes.glCoverageMaskNV) InternalTool.GetGLesMethodAdress("glCoverageMaskNV", typeof(dgtk.OpenGL.delegatesGLes.glCoverageMaskNV));
			}
			if (SuportedExt.Contains("glCoverageModulationNV"))
			{
				dgtk.OpenGL.internalGLes.glCoverageModulationNV = (dgtk.OpenGL.delegatesGLes.glCoverageModulationNV) InternalTool.GetGLesMethodAdress("glCoverageModulationNV", typeof(dgtk.OpenGL.delegatesGLes.glCoverageModulationNV));
			}
			if (SuportedExt.Contains("glCoverageModulationTableNV"))
			{
				dgtk.OpenGL.internalGLes.glCoverageModulationTableNV = (dgtk.OpenGL.delegatesGLes.glCoverageModulationTableNV) InternalTool.GetGLesMethodAdress("glCoverageModulationTableNV", typeof(dgtk.OpenGL.delegatesGLes.glCoverageModulationTableNV));
			}
			if (SuportedExt.Contains("glCoverageOperationNV"))
			{
				dgtk.OpenGL.internalGLes.glCoverageOperationNV = (dgtk.OpenGL.delegatesGLes.glCoverageOperationNV) InternalTool.GetGLesMethodAdress("glCoverageOperationNV", typeof(dgtk.OpenGL.delegatesGLes.glCoverageOperationNV));
			}
			if (SuportedExt.Contains("glCoverFillPathInstancedNV"))
			{
				dgtk.OpenGL.internalGLes.glCoverFillPathInstancedNV = (dgtk.OpenGL.delegatesGLes.glCoverFillPathInstancedNV) InternalTool.GetGLesMethodAdress("glCoverFillPathInstancedNV", typeof(dgtk.OpenGL.delegatesGLes.glCoverFillPathInstancedNV));
			}
			if (SuportedExt.Contains("glCoverFillPathNV"))
			{
				dgtk.OpenGL.internalGLes.glCoverFillPathNV = (dgtk.OpenGL.delegatesGLes.glCoverFillPathNV) InternalTool.GetGLesMethodAdress("glCoverFillPathNV", typeof(dgtk.OpenGL.delegatesGLes.glCoverFillPathNV));
			}
			if (SuportedExt.Contains("glCoverStrokePathInstancedNV"))
			{
				dgtk.OpenGL.internalGLes.glCoverStrokePathInstancedNV = (dgtk.OpenGL.delegatesGLes.glCoverStrokePathInstancedNV) InternalTool.GetGLesMethodAdress("glCoverStrokePathInstancedNV", typeof(dgtk.OpenGL.delegatesGLes.glCoverStrokePathInstancedNV));
			}
			if (SuportedExt.Contains("glCoverStrokePathNV"))
			{
				dgtk.OpenGL.internalGLes.glCoverStrokePathNV = (dgtk.OpenGL.delegatesGLes.glCoverStrokePathNV) InternalTool.GetGLesMethodAdress("glCoverStrokePathNV", typeof(dgtk.OpenGL.delegatesGLes.glCoverStrokePathNV));
			}
			if (SuportedExt.Contains("glCreateCommandListsNV"))
			{
				dgtk.OpenGL.internalGLes.glCreateCommandListsNV = (dgtk.OpenGL.delegatesGLes.glCreateCommandListsNV) InternalTool.GetGLesMethodAdress("glCreateCommandListsNV", typeof(dgtk.OpenGL.delegatesGLes.glCreateCommandListsNV));
			}
			if (SuportedExt.Contains("glCreateMemoryObjectsEXT"))
			{
				dgtk.OpenGL.internalGLes.glCreateMemoryObjectsEXT = (dgtk.OpenGL.delegatesGLes.glCreateMemoryObjectsEXT) InternalTool.GetGLesMethodAdress("glCreateMemoryObjectsEXT", typeof(dgtk.OpenGL.delegatesGLes.glCreateMemoryObjectsEXT));
			}
			if (SuportedExt.Contains("glCreatePerfQueryINTEL"))
			{
				dgtk.OpenGL.internalGLes.glCreatePerfQueryINTEL = (dgtk.OpenGL.delegatesGLes.glCreatePerfQueryINTEL) InternalTool.GetGLesMethodAdress("glCreatePerfQueryINTEL", typeof(dgtk.OpenGL.delegatesGLes.glCreatePerfQueryINTEL));
			}
			if (SuportedExt.Contains("glCreateProgramObjectARB"))
			{
				dgtk.OpenGL.internalGLes.glCreateProgramObjectARB = (dgtk.OpenGL.delegatesGLes.glCreateProgramObjectARB) InternalTool.GetGLesMethodAdress("glCreateProgramObjectARB", typeof(dgtk.OpenGL.delegatesGLes.glCreateProgramObjectARB));
			}
			if (SuportedExt.Contains("glCreateProgressFenceNVX"))
			{
				dgtk.OpenGL.internalGLes.glCreateProgressFenceNVX = (dgtk.OpenGL.delegatesGLes.glCreateProgressFenceNVX) InternalTool.GetGLesMethodAdress("glCreateProgressFenceNVX", typeof(dgtk.OpenGL.delegatesGLes.glCreateProgressFenceNVX));
			}
			if (SuportedExt.Contains("glCreateSemaphoresNV"))
			{
				dgtk.OpenGL.internalGLes.glCreateSemaphoresNV = (dgtk.OpenGL.delegatesGLes.glCreateSemaphoresNV) InternalTool.GetGLesMethodAdress("glCreateSemaphoresNV", typeof(dgtk.OpenGL.delegatesGLes.glCreateSemaphoresNV));
			}
			if (SuportedExt.Contains("glCreateShaderObjectARB"))
			{
				dgtk.OpenGL.internalGLes.glCreateShaderObjectARB = (dgtk.OpenGL.delegatesGLes.glCreateShaderObjectARB) InternalTool.GetGLesMethodAdress("glCreateShaderObjectARB", typeof(dgtk.OpenGL.delegatesGLes.glCreateShaderObjectARB));
			}
			if (SuportedExt.Contains("glCreateShaderProgramEXT"))
			{
				dgtk.OpenGL.internalGLes.glCreateShaderProgramEXT = (dgtk.OpenGL.delegatesGLes.glCreateShaderProgramEXT) InternalTool.GetGLesMethodAdress("glCreateShaderProgramEXT", typeof(dgtk.OpenGL.delegatesGLes.glCreateShaderProgramEXT));
			}
			if (SuportedExt.Contains("glCreateShaderProgramvEXT"))
			{
				dgtk.OpenGL.internalGLes.glCreateShaderProgramvEXT = (dgtk.OpenGL.delegatesGLes.glCreateShaderProgramvEXT) InternalTool.GetGLesMethodAdress("glCreateShaderProgramvEXT", typeof(dgtk.OpenGL.delegatesGLes.glCreateShaderProgramvEXT));
			}
			if (SuportedExt.Contains("glCreateStatesNV"))
			{
				dgtk.OpenGL.internalGLes.glCreateStatesNV = (dgtk.OpenGL.delegatesGLes.glCreateStatesNV) InternalTool.GetGLesMethodAdress("glCreateStatesNV", typeof(dgtk.OpenGL.delegatesGLes.glCreateStatesNV));
			}
			if (SuportedExt.Contains("glCreateSyncFromCLeventARB"))
			{
				dgtk.OpenGL.internalGLes.glCreateSyncFromCLeventARB = (dgtk.OpenGL.delegatesGLes.glCreateSyncFromCLeventARB) InternalTool.GetGLesMethodAdress("glCreateSyncFromCLeventARB", typeof(dgtk.OpenGL.delegatesGLes.glCreateSyncFromCLeventARB));
			}
			if (SuportedExt.Contains("glCullParameterdvEXT"))
			{
				dgtk.OpenGL.internalGLes.glCullParameterdvEXT = (dgtk.OpenGL.delegatesGLes.glCullParameterdvEXT) InternalTool.GetGLesMethodAdress("glCullParameterdvEXT", typeof(dgtk.OpenGL.delegatesGLes.glCullParameterdvEXT));
			}
			if (SuportedExt.Contains("glCullParameterfvEXT"))
			{
				dgtk.OpenGL.internalGLes.glCullParameterfvEXT = (dgtk.OpenGL.delegatesGLes.glCullParameterfvEXT) InternalTool.GetGLesMethodAdress("glCullParameterfvEXT", typeof(dgtk.OpenGL.delegatesGLes.glCullParameterfvEXT));
			}
			if (SuportedExt.Contains("glCurrentPaletteMatrixARB"))
			{
				dgtk.OpenGL.internalGLes.glCurrentPaletteMatrixARB = (dgtk.OpenGL.delegatesGLes.glCurrentPaletteMatrixARB) InternalTool.GetGLesMethodAdress("glCurrentPaletteMatrixARB", typeof(dgtk.OpenGL.delegatesGLes.glCurrentPaletteMatrixARB));
			}
			if (SuportedExt.Contains("glCurrentPaletteMatrixOES"))
			{
				dgtk.OpenGL.internalGLes.glCurrentPaletteMatrixOES = (dgtk.OpenGL.delegatesGLes.glCurrentPaletteMatrixOES) InternalTool.GetGLesMethodAdress("glCurrentPaletteMatrixOES", typeof(dgtk.OpenGL.delegatesGLes.glCurrentPaletteMatrixOES));
			}
			#endregion

			#region D:

			if (SuportedExt.Contains("glDebugMessageCallbackAMD"))
			{
				dgtk.OpenGL.internalGLes.glDebugMessageCallbackAMD = (dgtk.OpenGL.delegatesGLes.glDebugMessageCallbackAMD) InternalTool.GetGLesMethodAdress("glDebugMessageCallbackAMD", typeof(dgtk.OpenGL.delegatesGLes.glDebugMessageCallbackAMD));
			}
			if (SuportedExt.Contains("glDebugMessageCallbackARB"))
			{
				dgtk.OpenGL.internalGLes.glDebugMessageCallbackARB = (dgtk.OpenGL.delegatesGLes.glDebugMessageCallbackARB) InternalTool.GetGLesMethodAdress("glDebugMessageCallbackARB", typeof(dgtk.OpenGL.delegatesGLes.glDebugMessageCallbackARB));
			}
			if (SuportedExt.Contains("glDebugMessageCallbackKHR"))
			{
				dgtk.OpenGL.internalGLes.glDebugMessageCallbackKHR = (dgtk.OpenGL.delegatesGLes.glDebugMessageCallbackKHR) InternalTool.GetGLesMethodAdress("glDebugMessageCallbackKHR", typeof(dgtk.OpenGL.delegatesGLes.glDebugMessageCallbackKHR));
			}
			if (SuportedExt.Contains("glDebugMessageControlARB"))
			{
				dgtk.OpenGL.internalGLes.glDebugMessageControlARB = (dgtk.OpenGL.delegatesGLes.glDebugMessageControlARB) InternalTool.GetGLesMethodAdress("glDebugMessageControlARB", typeof(dgtk.OpenGL.delegatesGLes.glDebugMessageControlARB));
			}
			if (SuportedExt.Contains("glDebugMessageControlKHR"))
			{
				dgtk.OpenGL.internalGLes.glDebugMessageControlKHR = (dgtk.OpenGL.delegatesGLes.glDebugMessageControlKHR) InternalTool.GetGLesMethodAdress("glDebugMessageControlKHR", typeof(dgtk.OpenGL.delegatesGLes.glDebugMessageControlKHR));
			}
			if (SuportedExt.Contains("glDebugMessageEnableAMD"))
			{
				dgtk.OpenGL.internalGLes.glDebugMessageEnableAMD = (dgtk.OpenGL.delegatesGLes.glDebugMessageEnableAMD) InternalTool.GetGLesMethodAdress("glDebugMessageEnableAMD", typeof(dgtk.OpenGL.delegatesGLes.glDebugMessageEnableAMD));
			}
			if (SuportedExt.Contains("glDebugMessageInsertAMD"))
			{
				dgtk.OpenGL.internalGLes.glDebugMessageInsertAMD = (dgtk.OpenGL.delegatesGLes.glDebugMessageInsertAMD) InternalTool.GetGLesMethodAdress("glDebugMessageInsertAMD", typeof(dgtk.OpenGL.delegatesGLes.glDebugMessageInsertAMD));
			}
			if (SuportedExt.Contains("glDebugMessageInsertARB"))
			{
				dgtk.OpenGL.internalGLes.glDebugMessageInsertARB = (dgtk.OpenGL.delegatesGLes.glDebugMessageInsertARB) InternalTool.GetGLesMethodAdress("glDebugMessageInsertARB", typeof(dgtk.OpenGL.delegatesGLes.glDebugMessageInsertARB));
			}
			if (SuportedExt.Contains("glDebugMessageInsertKHR"))
			{
				dgtk.OpenGL.internalGLes.glDebugMessageInsertKHR = (dgtk.OpenGL.delegatesGLes.glDebugMessageInsertKHR) InternalTool.GetGLesMethodAdress("glDebugMessageInsertKHR", typeof(dgtk.OpenGL.delegatesGLes.glDebugMessageInsertKHR));
			}
			if (SuportedExt.Contains("glDeformationMap3dSGIX"))
			{
				dgtk.OpenGL.internalGLes.glDeformationMap3dSGIX = (dgtk.OpenGL.delegatesGLes.glDeformationMap3dSGIX) InternalTool.GetGLesMethodAdress("glDeformationMap3dSGIX", typeof(dgtk.OpenGL.delegatesGLes.glDeformationMap3dSGIX));
			}
			if (SuportedExt.Contains("glDeformationMap3fSGIX"))
			{
				dgtk.OpenGL.internalGLes.glDeformationMap3fSGIX = (dgtk.OpenGL.delegatesGLes.glDeformationMap3fSGIX) InternalTool.GetGLesMethodAdress("glDeformationMap3fSGIX", typeof(dgtk.OpenGL.delegatesGLes.glDeformationMap3fSGIX));
			}
			if (SuportedExt.Contains("glDeformSGIX"))
			{
				dgtk.OpenGL.internalGLes.glDeformSGIX = (dgtk.OpenGL.delegatesGLes.glDeformSGIX) InternalTool.GetGLesMethodAdress("glDeformSGIX", typeof(dgtk.OpenGL.delegatesGLes.glDeformSGIX));
			}
			if (SuportedExt.Contains("glDeleteAsyncMarkersSGIX"))
			{
				dgtk.OpenGL.internalGLes.glDeleteAsyncMarkersSGIX = (dgtk.OpenGL.delegatesGLes.glDeleteAsyncMarkersSGIX) InternalTool.GetGLesMethodAdress("glDeleteAsyncMarkersSGIX", typeof(dgtk.OpenGL.delegatesGLes.glDeleteAsyncMarkersSGIX));
			}
			if (SuportedExt.Contains("glDeleteBuffersARB"))
			{
				dgtk.OpenGL.internalGLes.glDeleteBuffersARB = (dgtk.OpenGL.delegatesGLes.glDeleteBuffersARB) InternalTool.GetGLesMethodAdress("glDeleteBuffersARB", typeof(dgtk.OpenGL.delegatesGLes.glDeleteBuffersARB));
			}
			if (SuportedExt.Contains("glDeleteCommandListsNV"))
			{
				dgtk.OpenGL.internalGLes.glDeleteCommandListsNV = (dgtk.OpenGL.delegatesGLes.glDeleteCommandListsNV) InternalTool.GetGLesMethodAdress("glDeleteCommandListsNV", typeof(dgtk.OpenGL.delegatesGLes.glDeleteCommandListsNV));
			}
			if (SuportedExt.Contains("glDeleteFencesAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glDeleteFencesAPPLE = (dgtk.OpenGL.delegatesGLes.glDeleteFencesAPPLE) InternalTool.GetGLesMethodAdress("glDeleteFencesAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glDeleteFencesAPPLE));
			}
			if (SuportedExt.Contains("glDeleteFencesNV"))
			{
				dgtk.OpenGL.internalGLes.glDeleteFencesNV = (dgtk.OpenGL.delegatesGLes.glDeleteFencesNV) InternalTool.GetGLesMethodAdress("glDeleteFencesNV", typeof(dgtk.OpenGL.delegatesGLes.glDeleteFencesNV));
			}
			if (SuportedExt.Contains("glDeleteFragmentShaderATI"))
			{
				dgtk.OpenGL.internalGLes.glDeleteFragmentShaderATI = (dgtk.OpenGL.delegatesGLes.glDeleteFragmentShaderATI) InternalTool.GetGLesMethodAdress("glDeleteFragmentShaderATI", typeof(dgtk.OpenGL.delegatesGLes.glDeleteFragmentShaderATI));
			}
			if (SuportedExt.Contains("glDeleteFramebuffersEXT"))
			{
				dgtk.OpenGL.internalGLes.glDeleteFramebuffersEXT = (dgtk.OpenGL.delegatesGLes.glDeleteFramebuffersEXT) InternalTool.GetGLesMethodAdress("glDeleteFramebuffersEXT", typeof(dgtk.OpenGL.delegatesGLes.glDeleteFramebuffersEXT));
			}
			if (SuportedExt.Contains("glDeleteFramebuffersOES"))
			{
				dgtk.OpenGL.internalGLes.glDeleteFramebuffersOES = (dgtk.OpenGL.delegatesGLes.glDeleteFramebuffersOES) InternalTool.GetGLesMethodAdress("glDeleteFramebuffersOES", typeof(dgtk.OpenGL.delegatesGLes.glDeleteFramebuffersOES));
			}
			if (SuportedExt.Contains("glDeleteMemoryObjectsEXT"))
			{
				dgtk.OpenGL.internalGLes.glDeleteMemoryObjectsEXT = (dgtk.OpenGL.delegatesGLes.glDeleteMemoryObjectsEXT) InternalTool.GetGLesMethodAdress("glDeleteMemoryObjectsEXT", typeof(dgtk.OpenGL.delegatesGLes.glDeleteMemoryObjectsEXT));
			}
			if (SuportedExt.Contains("glDeleteNamedStringARB"))
			{
				dgtk.OpenGL.internalGLes.glDeleteNamedStringARB = (dgtk.OpenGL.delegatesGLes.glDeleteNamedStringARB) InternalTool.GetGLesMethodAdress("glDeleteNamedStringARB", typeof(dgtk.OpenGL.delegatesGLes.glDeleteNamedStringARB));
			}
			if (SuportedExt.Contains("glDeleteNamesAMD"))
			{
				dgtk.OpenGL.internalGLes.glDeleteNamesAMD = (dgtk.OpenGL.delegatesGLes.glDeleteNamesAMD) InternalTool.GetGLesMethodAdress("glDeleteNamesAMD", typeof(dgtk.OpenGL.delegatesGLes.glDeleteNamesAMD));
			}
			if (SuportedExt.Contains("glDeleteObjectARB"))
			{
				dgtk.OpenGL.internalGLes.glDeleteObjectARB = (dgtk.OpenGL.delegatesGLes.glDeleteObjectARB) InternalTool.GetGLesMethodAdress("glDeleteObjectARB", typeof(dgtk.OpenGL.delegatesGLes.glDeleteObjectARB));
			}
			if (SuportedExt.Contains("glDeleteOcclusionQueriesNV"))
			{
				dgtk.OpenGL.internalGLes.glDeleteOcclusionQueriesNV = (dgtk.OpenGL.delegatesGLes.glDeleteOcclusionQueriesNV) InternalTool.GetGLesMethodAdress("glDeleteOcclusionQueriesNV", typeof(dgtk.OpenGL.delegatesGLes.glDeleteOcclusionQueriesNV));
			}
			if (SuportedExt.Contains("glDeletePathsNV"))
			{
				dgtk.OpenGL.internalGLes.glDeletePathsNV = (dgtk.OpenGL.delegatesGLes.glDeletePathsNV) InternalTool.GetGLesMethodAdress("glDeletePathsNV", typeof(dgtk.OpenGL.delegatesGLes.glDeletePathsNV));
			}
			if (SuportedExt.Contains("glDeletePerfMonitorsAMD"))
			{
				dgtk.OpenGL.internalGLes.glDeletePerfMonitorsAMD = (dgtk.OpenGL.delegatesGLes.glDeletePerfMonitorsAMD) InternalTool.GetGLesMethodAdress("glDeletePerfMonitorsAMD", typeof(dgtk.OpenGL.delegatesGLes.glDeletePerfMonitorsAMD));
			}
			if (SuportedExt.Contains("glDeletePerfQueryINTEL"))
			{
				dgtk.OpenGL.internalGLes.glDeletePerfQueryINTEL = (dgtk.OpenGL.delegatesGLes.glDeletePerfQueryINTEL) InternalTool.GetGLesMethodAdress("glDeletePerfQueryINTEL", typeof(dgtk.OpenGL.delegatesGLes.glDeletePerfQueryINTEL));
			}
			if (SuportedExt.Contains("glDeleteProgramPipelinesEXT"))
			{
				dgtk.OpenGL.internalGLes.glDeleteProgramPipelinesEXT = (dgtk.OpenGL.delegatesGLes.glDeleteProgramPipelinesEXT) InternalTool.GetGLesMethodAdress("glDeleteProgramPipelinesEXT", typeof(dgtk.OpenGL.delegatesGLes.glDeleteProgramPipelinesEXT));
			}
			if (SuportedExt.Contains("glDeleteProgramsARB"))
			{
				dgtk.OpenGL.internalGLes.glDeleteProgramsARB = (dgtk.OpenGL.delegatesGLes.glDeleteProgramsARB) InternalTool.GetGLesMethodAdress("glDeleteProgramsARB", typeof(dgtk.OpenGL.delegatesGLes.glDeleteProgramsARB));
			}
			if (SuportedExt.Contains("glDeleteProgramsNV"))
			{
				dgtk.OpenGL.internalGLes.glDeleteProgramsNV = (dgtk.OpenGL.delegatesGLes.glDeleteProgramsNV) InternalTool.GetGLesMethodAdress("glDeleteProgramsNV", typeof(dgtk.OpenGL.delegatesGLes.glDeleteProgramsNV));
			}
			if (SuportedExt.Contains("glDeleteQueriesARB"))
			{
				dgtk.OpenGL.internalGLes.glDeleteQueriesARB = (dgtk.OpenGL.delegatesGLes.glDeleteQueriesARB) InternalTool.GetGLesMethodAdress("glDeleteQueriesARB", typeof(dgtk.OpenGL.delegatesGLes.glDeleteQueriesARB));
			}
			if (SuportedExt.Contains("glDeleteQueriesEXT"))
			{
				dgtk.OpenGL.internalGLes.glDeleteQueriesEXT = (dgtk.OpenGL.delegatesGLes.glDeleteQueriesEXT) InternalTool.GetGLesMethodAdress("glDeleteQueriesEXT", typeof(dgtk.OpenGL.delegatesGLes.glDeleteQueriesEXT));
			}
			if (SuportedExt.Contains("glDeleteQueryResourceTagNV"))
			{
				dgtk.OpenGL.internalGLes.glDeleteQueryResourceTagNV = (dgtk.OpenGL.delegatesGLes.glDeleteQueryResourceTagNV) InternalTool.GetGLesMethodAdress("glDeleteQueryResourceTagNV", typeof(dgtk.OpenGL.delegatesGLes.glDeleteQueryResourceTagNV));
			}
			if (SuportedExt.Contains("glDeleteRenderbuffersEXT"))
			{
				dgtk.OpenGL.internalGLes.glDeleteRenderbuffersEXT = (dgtk.OpenGL.delegatesGLes.glDeleteRenderbuffersEXT) InternalTool.GetGLesMethodAdress("glDeleteRenderbuffersEXT", typeof(dgtk.OpenGL.delegatesGLes.glDeleteRenderbuffersEXT));
			}
			if (SuportedExt.Contains("glDeleteRenderbuffersOES"))
			{
				dgtk.OpenGL.internalGLes.glDeleteRenderbuffersOES = (dgtk.OpenGL.delegatesGLes.glDeleteRenderbuffersOES) InternalTool.GetGLesMethodAdress("glDeleteRenderbuffersOES", typeof(dgtk.OpenGL.delegatesGLes.glDeleteRenderbuffersOES));
			}
			if (SuportedExt.Contains("glDeleteSemaphoresEXT"))
			{
				dgtk.OpenGL.internalGLes.glDeleteSemaphoresEXT = (dgtk.OpenGL.delegatesGLes.glDeleteSemaphoresEXT) InternalTool.GetGLesMethodAdress("glDeleteSemaphoresEXT", typeof(dgtk.OpenGL.delegatesGLes.glDeleteSemaphoresEXT));
			}
			if (SuportedExt.Contains("glDeleteStatesNV"))
			{
				dgtk.OpenGL.internalGLes.glDeleteStatesNV = (dgtk.OpenGL.delegatesGLes.glDeleteStatesNV) InternalTool.GetGLesMethodAdress("glDeleteStatesNV", typeof(dgtk.OpenGL.delegatesGLes.glDeleteStatesNV));
			}
			if (SuportedExt.Contains("glDeleteSyncAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glDeleteSyncAPPLE = (dgtk.OpenGL.delegatesGLes.glDeleteSyncAPPLE) InternalTool.GetGLesMethodAdress("glDeleteSyncAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glDeleteSyncAPPLE));
			}
			if (SuportedExt.Contains("glDeleteTexturesEXT"))
			{
				dgtk.OpenGL.internalGLes.glDeleteTexturesEXT = (dgtk.OpenGL.delegatesGLes.glDeleteTexturesEXT) InternalTool.GetGLesMethodAdress("glDeleteTexturesEXT", typeof(dgtk.OpenGL.delegatesGLes.glDeleteTexturesEXT));
			}
			if (SuportedExt.Contains("glDeleteTransformFeedbacksNV"))
			{
				dgtk.OpenGL.internalGLes.glDeleteTransformFeedbacksNV = (dgtk.OpenGL.delegatesGLes.glDeleteTransformFeedbacksNV) InternalTool.GetGLesMethodAdress("glDeleteTransformFeedbacksNV", typeof(dgtk.OpenGL.delegatesGLes.glDeleteTransformFeedbacksNV));
			}
			if (SuportedExt.Contains("glDeleteVertexArraysAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glDeleteVertexArraysAPPLE = (dgtk.OpenGL.delegatesGLes.glDeleteVertexArraysAPPLE) InternalTool.GetGLesMethodAdress("glDeleteVertexArraysAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glDeleteVertexArraysAPPLE));
			}
			if (SuportedExt.Contains("glDeleteVertexArraysOES"))
			{
				dgtk.OpenGL.internalGLes.glDeleteVertexArraysOES = (dgtk.OpenGL.delegatesGLes.glDeleteVertexArraysOES) InternalTool.GetGLesMethodAdress("glDeleteVertexArraysOES", typeof(dgtk.OpenGL.delegatesGLes.glDeleteVertexArraysOES));
			}
			if (SuportedExt.Contains("glDeleteVertexShaderEXT"))
			{
				dgtk.OpenGL.internalGLes.glDeleteVertexShaderEXT = (dgtk.OpenGL.delegatesGLes.glDeleteVertexShaderEXT) InternalTool.GetGLesMethodAdress("glDeleteVertexShaderEXT", typeof(dgtk.OpenGL.delegatesGLes.glDeleteVertexShaderEXT));
			}
			if (SuportedExt.Contains("glDepthBoundsdNV"))
			{
				dgtk.OpenGL.internalGLes.glDepthBoundsdNV = (dgtk.OpenGL.delegatesGLes.glDepthBoundsdNV) InternalTool.GetGLesMethodAdress("glDepthBoundsdNV", typeof(dgtk.OpenGL.delegatesGLes.glDepthBoundsdNV));
			}
			if (SuportedExt.Contains("glDepthBoundsEXT"))
			{
				dgtk.OpenGL.internalGLes.glDepthBoundsEXT = (dgtk.OpenGL.delegatesGLes.glDepthBoundsEXT) InternalTool.GetGLesMethodAdress("glDepthBoundsEXT", typeof(dgtk.OpenGL.delegatesGLes.glDepthBoundsEXT));
			}
			if (SuportedExt.Contains("glDepthRangeArraydvNV"))
			{
				dgtk.OpenGL.internalGLes.glDepthRangeArraydvNV = (dgtk.OpenGL.delegatesGLes.glDepthRangeArraydvNV) InternalTool.GetGLesMethodAdress("glDepthRangeArraydvNV", typeof(dgtk.OpenGL.delegatesGLes.glDepthRangeArraydvNV));
			}
			if (SuportedExt.Contains("glDepthRangeArrayfvNV"))
			{
				dgtk.OpenGL.internalGLes.glDepthRangeArrayfvNV = (dgtk.OpenGL.delegatesGLes.glDepthRangeArrayfvNV) InternalTool.GetGLesMethodAdress("glDepthRangeArrayfvNV", typeof(dgtk.OpenGL.delegatesGLes.glDepthRangeArrayfvNV));
			}
			if (SuportedExt.Contains("glDepthRangeArrayfvOES"))
			{
				dgtk.OpenGL.internalGLes.glDepthRangeArrayfvOES = (dgtk.OpenGL.delegatesGLes.glDepthRangeArrayfvOES) InternalTool.GetGLesMethodAdress("glDepthRangeArrayfvOES", typeof(dgtk.OpenGL.delegatesGLes.glDepthRangeArrayfvOES));
			}
			if (SuportedExt.Contains("glDepthRangedNV"))
			{
				dgtk.OpenGL.internalGLes.glDepthRangedNV = (dgtk.OpenGL.delegatesGLes.glDepthRangedNV) InternalTool.GetGLesMethodAdress("glDepthRangedNV", typeof(dgtk.OpenGL.delegatesGLes.glDepthRangedNV));
			}
			if (SuportedExt.Contains("glDepthRangefOES"))
			{
				dgtk.OpenGL.internalGLes.glDepthRangefOES = (dgtk.OpenGL.delegatesGLes.glDepthRangefOES) InternalTool.GetGLesMethodAdress("glDepthRangefOES", typeof(dgtk.OpenGL.delegatesGLes.glDepthRangefOES));
			}
			if (SuportedExt.Contains("glDepthRangeIndexeddNV"))
			{
				dgtk.OpenGL.internalGLes.glDepthRangeIndexeddNV = (dgtk.OpenGL.delegatesGLes.glDepthRangeIndexeddNV) InternalTool.GetGLesMethodAdress("glDepthRangeIndexeddNV", typeof(dgtk.OpenGL.delegatesGLes.glDepthRangeIndexeddNV));
			}
			if (SuportedExt.Contains("glDepthRangeIndexedfNV"))
			{
				dgtk.OpenGL.internalGLes.glDepthRangeIndexedfNV = (dgtk.OpenGL.delegatesGLes.glDepthRangeIndexedfNV) InternalTool.GetGLesMethodAdress("glDepthRangeIndexedfNV", typeof(dgtk.OpenGL.delegatesGLes.glDepthRangeIndexedfNV));
			}
			if (SuportedExt.Contains("glDepthRangeIndexedfOES"))
			{
				dgtk.OpenGL.internalGLes.glDepthRangeIndexedfOES = (dgtk.OpenGL.delegatesGLes.glDepthRangeIndexedfOES) InternalTool.GetGLesMethodAdress("glDepthRangeIndexedfOES", typeof(dgtk.OpenGL.delegatesGLes.glDepthRangeIndexedfOES));
			}
			if (SuportedExt.Contains("glDepthRangex"))
			{
				dgtk.OpenGL.internalGLes.glDepthRangex = (dgtk.OpenGL.delegatesGLes.glDepthRangex) InternalTool.GetGLesMethodAdress("glDepthRangex", typeof(dgtk.OpenGL.delegatesGLes.glDepthRangex));
			}
			if (SuportedExt.Contains("glDepthRangexOES"))
			{
				dgtk.OpenGL.internalGLes.glDepthRangexOES = (dgtk.OpenGL.delegatesGLes.glDepthRangexOES) InternalTool.GetGLesMethodAdress("glDepthRangexOES", typeof(dgtk.OpenGL.delegatesGLes.glDepthRangexOES));
			}
			if (SuportedExt.Contains("glDetachObjectARB"))
			{
				dgtk.OpenGL.internalGLes.glDetachObjectARB = (dgtk.OpenGL.delegatesGLes.glDetachObjectARB) InternalTool.GetGLesMethodAdress("glDetachObjectARB", typeof(dgtk.OpenGL.delegatesGLes.glDetachObjectARB));
			}
			if (SuportedExt.Contains("glDetailTexFuncSGIS"))
			{
				dgtk.OpenGL.internalGLes.glDetailTexFuncSGIS = (dgtk.OpenGL.delegatesGLes.glDetailTexFuncSGIS) InternalTool.GetGLesMethodAdress("glDetailTexFuncSGIS", typeof(dgtk.OpenGL.delegatesGLes.glDetailTexFuncSGIS));
			}
			if (SuportedExt.Contains("glDisableClientStateiEXT"))
			{
				dgtk.OpenGL.internalGLes.glDisableClientStateiEXT = (dgtk.OpenGL.delegatesGLes.glDisableClientStateiEXT) InternalTool.GetGLesMethodAdress("glDisableClientStateiEXT", typeof(dgtk.OpenGL.delegatesGLes.glDisableClientStateiEXT));
			}
			if (SuportedExt.Contains("glDisableClientStateIndexedEXT"))
			{
				dgtk.OpenGL.internalGLes.glDisableClientStateIndexedEXT = (dgtk.OpenGL.delegatesGLes.glDisableClientStateIndexedEXT) InternalTool.GetGLesMethodAdress("glDisableClientStateIndexedEXT", typeof(dgtk.OpenGL.delegatesGLes.glDisableClientStateIndexedEXT));
			}
			if (SuportedExt.Contains("glDisableDriverControlQCOM"))
			{
				dgtk.OpenGL.internalGLes.glDisableDriverControlQCOM = (dgtk.OpenGL.delegatesGLes.glDisableDriverControlQCOM) InternalTool.GetGLesMethodAdress("glDisableDriverControlQCOM", typeof(dgtk.OpenGL.delegatesGLes.glDisableDriverControlQCOM));
			}
			if (SuportedExt.Contains("glDisableiEXT"))
			{
				dgtk.OpenGL.internalGLes.glDisableiEXT = (dgtk.OpenGL.delegatesGLes.glDisableiEXT) InternalTool.GetGLesMethodAdress("glDisableiEXT", typeof(dgtk.OpenGL.delegatesGLes.glDisableiEXT));
			}
			if (SuportedExt.Contains("glDisableIndexedEXT"))
			{
				dgtk.OpenGL.internalGLes.glDisableIndexedEXT = (dgtk.OpenGL.delegatesGLes.glDisableIndexedEXT) InternalTool.GetGLesMethodAdress("glDisableIndexedEXT", typeof(dgtk.OpenGL.delegatesGLes.glDisableIndexedEXT));
			}
			if (SuportedExt.Contains("glDisableiNV"))
			{
				dgtk.OpenGL.internalGLes.glDisableiNV = (dgtk.OpenGL.delegatesGLes.glDisableiNV) InternalTool.GetGLesMethodAdress("glDisableiNV", typeof(dgtk.OpenGL.delegatesGLes.glDisableiNV));
			}
			if (SuportedExt.Contains("glDisableiOES"))
			{
				dgtk.OpenGL.internalGLes.glDisableiOES = (dgtk.OpenGL.delegatesGLes.glDisableiOES) InternalTool.GetGLesMethodAdress("glDisableiOES", typeof(dgtk.OpenGL.delegatesGLes.glDisableiOES));
			}
			if (SuportedExt.Contains("glDisableVariantClientStateEXT"))
			{
				dgtk.OpenGL.internalGLes.glDisableVariantClientStateEXT = (dgtk.OpenGL.delegatesGLes.glDisableVariantClientStateEXT) InternalTool.GetGLesMethodAdress("glDisableVariantClientStateEXT", typeof(dgtk.OpenGL.delegatesGLes.glDisableVariantClientStateEXT));
			}
			if (SuportedExt.Contains("glDisableVertexArrayAttribEXT"))
			{
				dgtk.OpenGL.internalGLes.glDisableVertexArrayAttribEXT = (dgtk.OpenGL.delegatesGLes.glDisableVertexArrayAttribEXT) InternalTool.GetGLesMethodAdress("glDisableVertexArrayAttribEXT", typeof(dgtk.OpenGL.delegatesGLes.glDisableVertexArrayAttribEXT));
			}
			if (SuportedExt.Contains("glDisableVertexArrayEXT"))
			{
				dgtk.OpenGL.internalGLes.glDisableVertexArrayEXT = (dgtk.OpenGL.delegatesGLes.glDisableVertexArrayEXT) InternalTool.GetGLesMethodAdress("glDisableVertexArrayEXT", typeof(dgtk.OpenGL.delegatesGLes.glDisableVertexArrayEXT));
			}
			if (SuportedExt.Contains("glDisableVertexAttribAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glDisableVertexAttribAPPLE = (dgtk.OpenGL.delegatesGLes.glDisableVertexAttribAPPLE) InternalTool.GetGLesMethodAdress("glDisableVertexAttribAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glDisableVertexAttribAPPLE));
			}
			if (SuportedExt.Contains("glDisableVertexAttribArrayARB"))
			{
				dgtk.OpenGL.internalGLes.glDisableVertexAttribArrayARB = (dgtk.OpenGL.delegatesGLes.glDisableVertexAttribArrayARB) InternalTool.GetGLesMethodAdress("glDisableVertexAttribArrayARB", typeof(dgtk.OpenGL.delegatesGLes.glDisableVertexAttribArrayARB));
			}
			if (SuportedExt.Contains("glDiscardFramebufferEXT"))
			{
				dgtk.OpenGL.internalGLes.glDiscardFramebufferEXT = (dgtk.OpenGL.delegatesGLes.glDiscardFramebufferEXT) InternalTool.GetGLesMethodAdress("glDiscardFramebufferEXT", typeof(dgtk.OpenGL.delegatesGLes.glDiscardFramebufferEXT));
			}
			if (SuportedExt.Contains("glDispatchComputeGroupSizeARB"))
			{
				dgtk.OpenGL.internalGLes.glDispatchComputeGroupSizeARB = (dgtk.OpenGL.delegatesGLes.glDispatchComputeGroupSizeARB) InternalTool.GetGLesMethodAdress("glDispatchComputeGroupSizeARB", typeof(dgtk.OpenGL.delegatesGLes.glDispatchComputeGroupSizeARB));
			}
			if (SuportedExt.Contains("glDrawArraysEXT"))
			{
				dgtk.OpenGL.internalGLes.glDrawArraysEXT = (dgtk.OpenGL.delegatesGLes.glDrawArraysEXT) InternalTool.GetGLesMethodAdress("glDrawArraysEXT", typeof(dgtk.OpenGL.delegatesGLes.glDrawArraysEXT));
			}
			if (SuportedExt.Contains("glDrawArraysInstancedANGLE"))
			{
				dgtk.OpenGL.internalGLes.glDrawArraysInstancedANGLE = (dgtk.OpenGL.delegatesGLes.glDrawArraysInstancedANGLE) InternalTool.GetGLesMethodAdress("glDrawArraysInstancedANGLE", typeof(dgtk.OpenGL.delegatesGLes.glDrawArraysInstancedANGLE));
			}
			if (SuportedExt.Contains("glDrawArraysInstancedARB"))
			{
				dgtk.OpenGL.internalGLes.glDrawArraysInstancedARB = (dgtk.OpenGL.delegatesGLes.glDrawArraysInstancedARB) InternalTool.GetGLesMethodAdress("glDrawArraysInstancedARB", typeof(dgtk.OpenGL.delegatesGLes.glDrawArraysInstancedARB));
			}
			if (SuportedExt.Contains("glDrawArraysInstancedBaseInstanceEXT"))
			{
				dgtk.OpenGL.internalGLes.glDrawArraysInstancedBaseInstanceEXT = (dgtk.OpenGL.delegatesGLes.glDrawArraysInstancedBaseInstanceEXT) InternalTool.GetGLesMethodAdress("glDrawArraysInstancedBaseInstanceEXT", typeof(dgtk.OpenGL.delegatesGLes.glDrawArraysInstancedBaseInstanceEXT));
			}
			if (SuportedExt.Contains("glDrawArraysInstancedEXT"))
			{
				dgtk.OpenGL.internalGLes.glDrawArraysInstancedEXT = (dgtk.OpenGL.delegatesGLes.glDrawArraysInstancedEXT) InternalTool.GetGLesMethodAdress("glDrawArraysInstancedEXT", typeof(dgtk.OpenGL.delegatesGLes.glDrawArraysInstancedEXT));
			}
			if (SuportedExt.Contains("glDrawArraysInstancedNV"))
			{
				dgtk.OpenGL.internalGLes.glDrawArraysInstancedNV = (dgtk.OpenGL.delegatesGLes.glDrawArraysInstancedNV) InternalTool.GetGLesMethodAdress("glDrawArraysInstancedNV", typeof(dgtk.OpenGL.delegatesGLes.glDrawArraysInstancedNV));
			}
			if (SuportedExt.Contains("glDrawBuffersARB"))
			{
				dgtk.OpenGL.internalGLes.glDrawBuffersARB = (dgtk.OpenGL.delegatesGLes.glDrawBuffersARB) InternalTool.GetGLesMethodAdress("glDrawBuffersARB", typeof(dgtk.OpenGL.delegatesGLes.glDrawBuffersARB));
			}
			if (SuportedExt.Contains("glDrawBuffersATI"))
			{
				dgtk.OpenGL.internalGLes.glDrawBuffersATI = (dgtk.OpenGL.delegatesGLes.glDrawBuffersATI) InternalTool.GetGLesMethodAdress("glDrawBuffersATI", typeof(dgtk.OpenGL.delegatesGLes.glDrawBuffersATI));
			}
			if (SuportedExt.Contains("glDrawBuffersEXT"))
			{
				dgtk.OpenGL.internalGLes.glDrawBuffersEXT = (dgtk.OpenGL.delegatesGLes.glDrawBuffersEXT) InternalTool.GetGLesMethodAdress("glDrawBuffersEXT", typeof(dgtk.OpenGL.delegatesGLes.glDrawBuffersEXT));
			}
			if (SuportedExt.Contains("glDrawBuffersIndexedEXT"))
			{
				dgtk.OpenGL.internalGLes.glDrawBuffersIndexedEXT = (dgtk.OpenGL.delegatesGLes.glDrawBuffersIndexedEXT) InternalTool.GetGLesMethodAdress("glDrawBuffersIndexedEXT", typeof(dgtk.OpenGL.delegatesGLes.glDrawBuffersIndexedEXT));
			}
			if (SuportedExt.Contains("glDrawBuffersNV"))
			{
				dgtk.OpenGL.internalGLes.glDrawBuffersNV = (dgtk.OpenGL.delegatesGLes.glDrawBuffersNV) InternalTool.GetGLesMethodAdress("glDrawBuffersNV", typeof(dgtk.OpenGL.delegatesGLes.glDrawBuffersNV));
			}
			if (SuportedExt.Contains("glDrawCommandsAddressNV"))
			{
				dgtk.OpenGL.internalGLes.glDrawCommandsAddressNV = (dgtk.OpenGL.delegatesGLes.glDrawCommandsAddressNV) InternalTool.GetGLesMethodAdress("glDrawCommandsAddressNV", typeof(dgtk.OpenGL.delegatesGLes.glDrawCommandsAddressNV));
			}
			if (SuportedExt.Contains("glDrawCommandsNV"))
			{
				dgtk.OpenGL.internalGLes.glDrawCommandsNV = (dgtk.OpenGL.delegatesGLes.glDrawCommandsNV) InternalTool.GetGLesMethodAdress("glDrawCommandsNV", typeof(dgtk.OpenGL.delegatesGLes.glDrawCommandsNV));
			}
			if (SuportedExt.Contains("glDrawCommandsStatesAddressNV"))
			{
				dgtk.OpenGL.internalGLes.glDrawCommandsStatesAddressNV = (dgtk.OpenGL.delegatesGLes.glDrawCommandsStatesAddressNV) InternalTool.GetGLesMethodAdress("glDrawCommandsStatesAddressNV", typeof(dgtk.OpenGL.delegatesGLes.glDrawCommandsStatesAddressNV));
			}
			if (SuportedExt.Contains("glDrawCommandsStatesNV"))
			{
				dgtk.OpenGL.internalGLes.glDrawCommandsStatesNV = (dgtk.OpenGL.delegatesGLes.glDrawCommandsStatesNV) InternalTool.GetGLesMethodAdress("glDrawCommandsStatesNV", typeof(dgtk.OpenGL.delegatesGLes.glDrawCommandsStatesNV));
			}
			if (SuportedExt.Contains("glDrawElementArrayAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glDrawElementArrayAPPLE = (dgtk.OpenGL.delegatesGLes.glDrawElementArrayAPPLE) InternalTool.GetGLesMethodAdress("glDrawElementArrayAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glDrawElementArrayAPPLE));
			}
			if (SuportedExt.Contains("glDrawElementArrayATI"))
			{
				dgtk.OpenGL.internalGLes.glDrawElementArrayATI = (dgtk.OpenGL.delegatesGLes.glDrawElementArrayATI) InternalTool.GetGLesMethodAdress("glDrawElementArrayATI", typeof(dgtk.OpenGL.delegatesGLes.glDrawElementArrayATI));
			}
			if (SuportedExt.Contains("glDrawElementsBaseVertexEXT"))
			{
				dgtk.OpenGL.internalGLes.glDrawElementsBaseVertexEXT = (dgtk.OpenGL.delegatesGLes.glDrawElementsBaseVertexEXT) InternalTool.GetGLesMethodAdress("glDrawElementsBaseVertexEXT", typeof(dgtk.OpenGL.delegatesGLes.glDrawElementsBaseVertexEXT));
			}
			if (SuportedExt.Contains("glDrawElementsBaseVertexOES"))
			{
				dgtk.OpenGL.internalGLes.glDrawElementsBaseVertexOES = (dgtk.OpenGL.delegatesGLes.glDrawElementsBaseVertexOES) InternalTool.GetGLesMethodAdress("glDrawElementsBaseVertexOES", typeof(dgtk.OpenGL.delegatesGLes.glDrawElementsBaseVertexOES));
			}
			if (SuportedExt.Contains("glDrawElementsInstancedANGLE"))
			{
				dgtk.OpenGL.internalGLes.glDrawElementsInstancedANGLE = (dgtk.OpenGL.delegatesGLes.glDrawElementsInstancedANGLE) InternalTool.GetGLesMethodAdress("glDrawElementsInstancedANGLE", typeof(dgtk.OpenGL.delegatesGLes.glDrawElementsInstancedANGLE));
			}
			if (SuportedExt.Contains("glDrawElementsInstancedARB"))
			{
				dgtk.OpenGL.internalGLes.glDrawElementsInstancedARB = (dgtk.OpenGL.delegatesGLes.glDrawElementsInstancedARB) InternalTool.GetGLesMethodAdress("glDrawElementsInstancedARB", typeof(dgtk.OpenGL.delegatesGLes.glDrawElementsInstancedARB));
			}
			if (SuportedExt.Contains("glDrawElementsInstancedBaseInstanceEXT"))
			{
				dgtk.OpenGL.internalGLes.glDrawElementsInstancedBaseInstanceEXT = (dgtk.OpenGL.delegatesGLes.glDrawElementsInstancedBaseInstanceEXT) InternalTool.GetGLesMethodAdress("glDrawElementsInstancedBaseInstanceEXT", typeof(dgtk.OpenGL.delegatesGLes.glDrawElementsInstancedBaseInstanceEXT));
			}
			if (SuportedExt.Contains("glDrawElementsInstancedBaseVertexBaseInstanceEXT"))
			{
				dgtk.OpenGL.internalGLes.glDrawElementsInstancedBaseVertexBaseInstanceEXT = (dgtk.OpenGL.delegatesGLes.glDrawElementsInstancedBaseVertexBaseInstanceEXT) InternalTool.GetGLesMethodAdress("glDrawElementsInstancedBaseVertexBaseInstanceEXT", typeof(dgtk.OpenGL.delegatesGLes.glDrawElementsInstancedBaseVertexBaseInstanceEXT));
			}
			if (SuportedExt.Contains("glDrawElementsInstancedBaseVertexEXT"))
			{
				dgtk.OpenGL.internalGLes.glDrawElementsInstancedBaseVertexEXT = (dgtk.OpenGL.delegatesGLes.glDrawElementsInstancedBaseVertexEXT) InternalTool.GetGLesMethodAdress("glDrawElementsInstancedBaseVertexEXT", typeof(dgtk.OpenGL.delegatesGLes.glDrawElementsInstancedBaseVertexEXT));
			}
			if (SuportedExt.Contains("glDrawElementsInstancedBaseVertexOES"))
			{
				dgtk.OpenGL.internalGLes.glDrawElementsInstancedBaseVertexOES = (dgtk.OpenGL.delegatesGLes.glDrawElementsInstancedBaseVertexOES) InternalTool.GetGLesMethodAdress("glDrawElementsInstancedBaseVertexOES", typeof(dgtk.OpenGL.delegatesGLes.glDrawElementsInstancedBaseVertexOES));
			}
			if (SuportedExt.Contains("glDrawElementsInstancedEXT"))
			{
				dgtk.OpenGL.internalGLes.glDrawElementsInstancedEXT = (dgtk.OpenGL.delegatesGLes.glDrawElementsInstancedEXT) InternalTool.GetGLesMethodAdress("glDrawElementsInstancedEXT", typeof(dgtk.OpenGL.delegatesGLes.glDrawElementsInstancedEXT));
			}
			if (SuportedExt.Contains("glDrawElementsInstancedNV"))
			{
				dgtk.OpenGL.internalGLes.glDrawElementsInstancedNV = (dgtk.OpenGL.delegatesGLes.glDrawElementsInstancedNV) InternalTool.GetGLesMethodAdress("glDrawElementsInstancedNV", typeof(dgtk.OpenGL.delegatesGLes.glDrawElementsInstancedNV));
			}
			if (SuportedExt.Contains("glDrawMeshArraysSUN"))
			{
				dgtk.OpenGL.internalGLes.glDrawMeshArraysSUN = (dgtk.OpenGL.delegatesGLes.glDrawMeshArraysSUN) InternalTool.GetGLesMethodAdress("glDrawMeshArraysSUN", typeof(dgtk.OpenGL.delegatesGLes.glDrawMeshArraysSUN));
			}
			if (SuportedExt.Contains("glDrawMeshTasksIndirectNV"))
			{
				dgtk.OpenGL.internalGLes.glDrawMeshTasksIndirectNV = (dgtk.OpenGL.delegatesGLes.glDrawMeshTasksIndirectNV) InternalTool.GetGLesMethodAdress("glDrawMeshTasksIndirectNV", typeof(dgtk.OpenGL.delegatesGLes.glDrawMeshTasksIndirectNV));
			}
			if (SuportedExt.Contains("glDrawMeshTasksNV"))
			{
				dgtk.OpenGL.internalGLes.glDrawMeshTasksNV = (dgtk.OpenGL.delegatesGLes.glDrawMeshTasksNV) InternalTool.GetGLesMethodAdress("glDrawMeshTasksNV", typeof(dgtk.OpenGL.delegatesGLes.glDrawMeshTasksNV));
			}
			if (SuportedExt.Contains("glDrawRangeElementArrayAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glDrawRangeElementArrayAPPLE = (dgtk.OpenGL.delegatesGLes.glDrawRangeElementArrayAPPLE) InternalTool.GetGLesMethodAdress("glDrawRangeElementArrayAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glDrawRangeElementArrayAPPLE));
			}
			if (SuportedExt.Contains("glDrawRangeElementArrayATI"))
			{
				dgtk.OpenGL.internalGLes.glDrawRangeElementArrayATI = (dgtk.OpenGL.delegatesGLes.glDrawRangeElementArrayATI) InternalTool.GetGLesMethodAdress("glDrawRangeElementArrayATI", typeof(dgtk.OpenGL.delegatesGLes.glDrawRangeElementArrayATI));
			}
			if (SuportedExt.Contains("glDrawRangeElementsBaseVertexEXT"))
			{
				dgtk.OpenGL.internalGLes.glDrawRangeElementsBaseVertexEXT = (dgtk.OpenGL.delegatesGLes.glDrawRangeElementsBaseVertexEXT) InternalTool.GetGLesMethodAdress("glDrawRangeElementsBaseVertexEXT", typeof(dgtk.OpenGL.delegatesGLes.glDrawRangeElementsBaseVertexEXT));
			}
			if (SuportedExt.Contains("glDrawRangeElementsBaseVertexOES"))
			{
				dgtk.OpenGL.internalGLes.glDrawRangeElementsBaseVertexOES = (dgtk.OpenGL.delegatesGLes.glDrawRangeElementsBaseVertexOES) InternalTool.GetGLesMethodAdress("glDrawRangeElementsBaseVertexOES", typeof(dgtk.OpenGL.delegatesGLes.glDrawRangeElementsBaseVertexOES));
			}
			if (SuportedExt.Contains("glDrawRangeElementsEXT"))
			{
				dgtk.OpenGL.internalGLes.glDrawRangeElementsEXT = (dgtk.OpenGL.delegatesGLes.glDrawRangeElementsEXT) InternalTool.GetGLesMethodAdress("glDrawRangeElementsEXT", typeof(dgtk.OpenGL.delegatesGLes.glDrawRangeElementsEXT));
			}
			if (SuportedExt.Contains("glDrawTexfOES"))
			{
				dgtk.OpenGL.internalGLes.glDrawTexfOES = (dgtk.OpenGL.delegatesGLes.glDrawTexfOES) InternalTool.GetGLesMethodAdress("glDrawTexfOES", typeof(dgtk.OpenGL.delegatesGLes.glDrawTexfOES));
			}
			if (SuportedExt.Contains("glDrawTexfvOES"))
			{
				dgtk.OpenGL.internalGLes.glDrawTexfvOES = (dgtk.OpenGL.delegatesGLes.glDrawTexfvOES) InternalTool.GetGLesMethodAdress("glDrawTexfvOES", typeof(dgtk.OpenGL.delegatesGLes.glDrawTexfvOES));
			}
			if (SuportedExt.Contains("glDrawTexiOES"))
			{
				dgtk.OpenGL.internalGLes.glDrawTexiOES = (dgtk.OpenGL.delegatesGLes.glDrawTexiOES) InternalTool.GetGLesMethodAdress("glDrawTexiOES", typeof(dgtk.OpenGL.delegatesGLes.glDrawTexiOES));
			}
			if (SuportedExt.Contains("glDrawTexivOES"))
			{
				dgtk.OpenGL.internalGLes.glDrawTexivOES = (dgtk.OpenGL.delegatesGLes.glDrawTexivOES) InternalTool.GetGLesMethodAdress("glDrawTexivOES", typeof(dgtk.OpenGL.delegatesGLes.glDrawTexivOES));
			}
			if (SuportedExt.Contains("glDrawTexsOES"))
			{
				dgtk.OpenGL.internalGLes.glDrawTexsOES = (dgtk.OpenGL.delegatesGLes.glDrawTexsOES) InternalTool.GetGLesMethodAdress("glDrawTexsOES", typeof(dgtk.OpenGL.delegatesGLes.glDrawTexsOES));
			}
			if (SuportedExt.Contains("glDrawTexsvOES"))
			{
				dgtk.OpenGL.internalGLes.glDrawTexsvOES = (dgtk.OpenGL.delegatesGLes.glDrawTexsvOES) InternalTool.GetGLesMethodAdress("glDrawTexsvOES", typeof(dgtk.OpenGL.delegatesGLes.glDrawTexsvOES));
			}
			if (SuportedExt.Contains("glDrawTextureNV"))
			{
				dgtk.OpenGL.internalGLes.glDrawTextureNV = (dgtk.OpenGL.delegatesGLes.glDrawTextureNV) InternalTool.GetGLesMethodAdress("glDrawTextureNV", typeof(dgtk.OpenGL.delegatesGLes.glDrawTextureNV));
			}
			if (SuportedExt.Contains("glDrawTexxOES"))
			{
				dgtk.OpenGL.internalGLes.glDrawTexxOES = (dgtk.OpenGL.delegatesGLes.glDrawTexxOES) InternalTool.GetGLesMethodAdress("glDrawTexxOES", typeof(dgtk.OpenGL.delegatesGLes.glDrawTexxOES));
			}
			if (SuportedExt.Contains("glDrawTexxvOES"))
			{
				dgtk.OpenGL.internalGLes.glDrawTexxvOES = (dgtk.OpenGL.delegatesGLes.glDrawTexxvOES) InternalTool.GetGLesMethodAdress("glDrawTexxvOES", typeof(dgtk.OpenGL.delegatesGLes.glDrawTexxvOES));
			}
			if (SuportedExt.Contains("glDrawTransformFeedbackEXT"))
			{
				dgtk.OpenGL.internalGLes.glDrawTransformFeedbackEXT = (dgtk.OpenGL.delegatesGLes.glDrawTransformFeedbackEXT) InternalTool.GetGLesMethodAdress("glDrawTransformFeedbackEXT", typeof(dgtk.OpenGL.delegatesGLes.glDrawTransformFeedbackEXT));
			}
			if (SuportedExt.Contains("glDrawTransformFeedbackInstancedEXT"))
			{
				dgtk.OpenGL.internalGLes.glDrawTransformFeedbackInstancedEXT = (dgtk.OpenGL.delegatesGLes.glDrawTransformFeedbackInstancedEXT) InternalTool.GetGLesMethodAdress("glDrawTransformFeedbackInstancedEXT", typeof(dgtk.OpenGL.delegatesGLes.glDrawTransformFeedbackInstancedEXT));
			}
			if (SuportedExt.Contains("glDrawTransformFeedbackNV"))
			{
				dgtk.OpenGL.internalGLes.glDrawTransformFeedbackNV = (dgtk.OpenGL.delegatesGLes.glDrawTransformFeedbackNV) InternalTool.GetGLesMethodAdress("glDrawTransformFeedbackNV", typeof(dgtk.OpenGL.delegatesGLes.glDrawTransformFeedbackNV));
			}
			if (SuportedExt.Contains("glDrawVkImageNV"))
			{
				dgtk.OpenGL.internalGLes.glDrawVkImageNV = (dgtk.OpenGL.delegatesGLes.glDrawVkImageNV) InternalTool.GetGLesMethodAdress("glDrawVkImageNV", typeof(dgtk.OpenGL.delegatesGLes.glDrawVkImageNV));
			}
			#endregion

			#region E:

			if (SuportedExt.Contains("glEdgeFlagFormatNV"))
			{
				dgtk.OpenGL.internalGLes.glEdgeFlagFormatNV = (dgtk.OpenGL.delegatesGLes.glEdgeFlagFormatNV) InternalTool.GetGLesMethodAdress("glEdgeFlagFormatNV", typeof(dgtk.OpenGL.delegatesGLes.glEdgeFlagFormatNV));
			}
			if (SuportedExt.Contains("glEdgeFlagPointerEXT"))
			{
				dgtk.OpenGL.internalGLes.glEdgeFlagPointerEXT = (dgtk.OpenGL.delegatesGLes.glEdgeFlagPointerEXT) InternalTool.GetGLesMethodAdress("glEdgeFlagPointerEXT", typeof(dgtk.OpenGL.delegatesGLes.glEdgeFlagPointerEXT));
			}
			if (SuportedExt.Contains("glEdgeFlagPointerListIBM"))
			{
				dgtk.OpenGL.internalGLes.glEdgeFlagPointerListIBM = (dgtk.OpenGL.delegatesGLes.glEdgeFlagPointerListIBM) InternalTool.GetGLesMethodAdress("glEdgeFlagPointerListIBM", typeof(dgtk.OpenGL.delegatesGLes.glEdgeFlagPointerListIBM));
			}
			if (SuportedExt.Contains("glEGLImageTargetRenderbufferStorageOES"))
			{
				dgtk.OpenGL.internalGLes.glEGLImageTargetRenderbufferStorageOES = (dgtk.OpenGL.delegatesGLes.glEGLImageTargetRenderbufferStorageOES) InternalTool.GetGLesMethodAdress("glEGLImageTargetRenderbufferStorageOES", typeof(dgtk.OpenGL.delegatesGLes.glEGLImageTargetRenderbufferStorageOES));
			}
			if (SuportedExt.Contains("glEGLImageTargetTexStorageEXT"))
			{
				dgtk.OpenGL.internalGLes.glEGLImageTargetTexStorageEXT = (dgtk.OpenGL.delegatesGLes.glEGLImageTargetTexStorageEXT) InternalTool.GetGLesMethodAdress("glEGLImageTargetTexStorageEXT", typeof(dgtk.OpenGL.delegatesGLes.glEGLImageTargetTexStorageEXT));
			}
			if (SuportedExt.Contains("glEGLImageTargetTexture2DOES"))
			{
				dgtk.OpenGL.internalGLes.glEGLImageTargetTexture2DOES = (dgtk.OpenGL.delegatesGLes.glEGLImageTargetTexture2DOES) InternalTool.GetGLesMethodAdress("glEGLImageTargetTexture2DOES", typeof(dgtk.OpenGL.delegatesGLes.glEGLImageTargetTexture2DOES));
			}
			if (SuportedExt.Contains("glEGLImageTargetTextureStorageEXT"))
			{
				dgtk.OpenGL.internalGLes.glEGLImageTargetTextureStorageEXT = (dgtk.OpenGL.delegatesGLes.glEGLImageTargetTextureStorageEXT) InternalTool.GetGLesMethodAdress("glEGLImageTargetTextureStorageEXT", typeof(dgtk.OpenGL.delegatesGLes.glEGLImageTargetTextureStorageEXT));
			}
			if (SuportedExt.Contains("glElementPointerAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glElementPointerAPPLE = (dgtk.OpenGL.delegatesGLes.glElementPointerAPPLE) InternalTool.GetGLesMethodAdress("glElementPointerAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glElementPointerAPPLE));
			}
			if (SuportedExt.Contains("glElementPointerATI"))
			{
				dgtk.OpenGL.internalGLes.glElementPointerATI = (dgtk.OpenGL.delegatesGLes.glElementPointerATI) InternalTool.GetGLesMethodAdress("glElementPointerATI", typeof(dgtk.OpenGL.delegatesGLes.glElementPointerATI));
			}
			if (SuportedExt.Contains("glEnableClientStateiEXT"))
			{
				dgtk.OpenGL.internalGLes.glEnableClientStateiEXT = (dgtk.OpenGL.delegatesGLes.glEnableClientStateiEXT) InternalTool.GetGLesMethodAdress("glEnableClientStateiEXT", typeof(dgtk.OpenGL.delegatesGLes.glEnableClientStateiEXT));
			}
			if (SuportedExt.Contains("glEnableClientStateIndexedEXT"))
			{
				dgtk.OpenGL.internalGLes.glEnableClientStateIndexedEXT = (dgtk.OpenGL.delegatesGLes.glEnableClientStateIndexedEXT) InternalTool.GetGLesMethodAdress("glEnableClientStateIndexedEXT", typeof(dgtk.OpenGL.delegatesGLes.glEnableClientStateIndexedEXT));
			}
			if (SuportedExt.Contains("glEnableDriverControlQCOM"))
			{
				dgtk.OpenGL.internalGLes.glEnableDriverControlQCOM = (dgtk.OpenGL.delegatesGLes.glEnableDriverControlQCOM) InternalTool.GetGLesMethodAdress("glEnableDriverControlQCOM", typeof(dgtk.OpenGL.delegatesGLes.glEnableDriverControlQCOM));
			}
			if (SuportedExt.Contains("glEnableiEXT"))
			{
				dgtk.OpenGL.internalGLes.glEnableiEXT = (dgtk.OpenGL.delegatesGLes.glEnableiEXT) InternalTool.GetGLesMethodAdress("glEnableiEXT", typeof(dgtk.OpenGL.delegatesGLes.glEnableiEXT));
			}
			if (SuportedExt.Contains("glEnableIndexedEXT"))
			{
				dgtk.OpenGL.internalGLes.glEnableIndexedEXT = (dgtk.OpenGL.delegatesGLes.glEnableIndexedEXT) InternalTool.GetGLesMethodAdress("glEnableIndexedEXT", typeof(dgtk.OpenGL.delegatesGLes.glEnableIndexedEXT));
			}
			if (SuportedExt.Contains("glEnableiNV"))
			{
				dgtk.OpenGL.internalGLes.glEnableiNV = (dgtk.OpenGL.delegatesGLes.glEnableiNV) InternalTool.GetGLesMethodAdress("glEnableiNV", typeof(dgtk.OpenGL.delegatesGLes.glEnableiNV));
			}
			if (SuportedExt.Contains("glEnableiOES"))
			{
				dgtk.OpenGL.internalGLes.glEnableiOES = (dgtk.OpenGL.delegatesGLes.glEnableiOES) InternalTool.GetGLesMethodAdress("glEnableiOES", typeof(dgtk.OpenGL.delegatesGLes.glEnableiOES));
			}
			if (SuportedExt.Contains("glEnableVariantClientStateEXT"))
			{
				dgtk.OpenGL.internalGLes.glEnableVariantClientStateEXT = (dgtk.OpenGL.delegatesGLes.glEnableVariantClientStateEXT) InternalTool.GetGLesMethodAdress("glEnableVariantClientStateEXT", typeof(dgtk.OpenGL.delegatesGLes.glEnableVariantClientStateEXT));
			}
			if (SuportedExt.Contains("glEnableVertexArrayAttribEXT"))
			{
				dgtk.OpenGL.internalGLes.glEnableVertexArrayAttribEXT = (dgtk.OpenGL.delegatesGLes.glEnableVertexArrayAttribEXT) InternalTool.GetGLesMethodAdress("glEnableVertexArrayAttribEXT", typeof(dgtk.OpenGL.delegatesGLes.glEnableVertexArrayAttribEXT));
			}
			if (SuportedExt.Contains("glEnableVertexArrayEXT"))
			{
				dgtk.OpenGL.internalGLes.glEnableVertexArrayEXT = (dgtk.OpenGL.delegatesGLes.glEnableVertexArrayEXT) InternalTool.GetGLesMethodAdress("glEnableVertexArrayEXT", typeof(dgtk.OpenGL.delegatesGLes.glEnableVertexArrayEXT));
			}
			if (SuportedExt.Contains("glEnableVertexAttribAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glEnableVertexAttribAPPLE = (dgtk.OpenGL.delegatesGLes.glEnableVertexAttribAPPLE) InternalTool.GetGLesMethodAdress("glEnableVertexAttribAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glEnableVertexAttribAPPLE));
			}
			if (SuportedExt.Contains("glEnableVertexAttribArrayARB"))
			{
				dgtk.OpenGL.internalGLes.glEnableVertexAttribArrayARB = (dgtk.OpenGL.delegatesGLes.glEnableVertexAttribArrayARB) InternalTool.GetGLesMethodAdress("glEnableVertexAttribArrayARB", typeof(dgtk.OpenGL.delegatesGLes.glEnableVertexAttribArrayARB));
			}
			if (SuportedExt.Contains("glEndConditionalRenderNV"))
			{
				dgtk.OpenGL.internalGLes.glEndConditionalRenderNV = (dgtk.OpenGL.delegatesGLes.glEndConditionalRenderNV) InternalTool.GetGLesMethodAdress("glEndConditionalRenderNV", typeof(dgtk.OpenGL.delegatesGLes.glEndConditionalRenderNV));
			}
			if (SuportedExt.Contains("glEndConditionalRenderNVX"))
			{
				dgtk.OpenGL.internalGLes.glEndConditionalRenderNVX = (dgtk.OpenGL.delegatesGLes.glEndConditionalRenderNVX) InternalTool.GetGLesMethodAdress("glEndConditionalRenderNVX", typeof(dgtk.OpenGL.delegatesGLes.glEndConditionalRenderNVX));
			}
			if (SuportedExt.Contains("glEndFragmentShaderATI"))
			{
				dgtk.OpenGL.internalGLes.glEndFragmentShaderATI = (dgtk.OpenGL.delegatesGLes.glEndFragmentShaderATI) InternalTool.GetGLesMethodAdress("glEndFragmentShaderATI", typeof(dgtk.OpenGL.delegatesGLes.glEndFragmentShaderATI));
			}
			if (SuportedExt.Contains("glEndOcclusionQueryNV"))
			{
				dgtk.OpenGL.internalGLes.glEndOcclusionQueryNV = (dgtk.OpenGL.delegatesGLes.glEndOcclusionQueryNV) InternalTool.GetGLesMethodAdress("glEndOcclusionQueryNV", typeof(dgtk.OpenGL.delegatesGLes.glEndOcclusionQueryNV));
			}
			if (SuportedExt.Contains("glEndPerfMonitorAMD"))
			{
				dgtk.OpenGL.internalGLes.glEndPerfMonitorAMD = (dgtk.OpenGL.delegatesGLes.glEndPerfMonitorAMD) InternalTool.GetGLesMethodAdress("glEndPerfMonitorAMD", typeof(dgtk.OpenGL.delegatesGLes.glEndPerfMonitorAMD));
			}
			if (SuportedExt.Contains("glEndPerfQueryINTEL"))
			{
				dgtk.OpenGL.internalGLes.glEndPerfQueryINTEL = (dgtk.OpenGL.delegatesGLes.glEndPerfQueryINTEL) InternalTool.GetGLesMethodAdress("glEndPerfQueryINTEL", typeof(dgtk.OpenGL.delegatesGLes.glEndPerfQueryINTEL));
			}
			if (SuportedExt.Contains("glEndQueryARB"))
			{
				dgtk.OpenGL.internalGLes.glEndQueryARB = (dgtk.OpenGL.delegatesGLes.glEndQueryARB) InternalTool.GetGLesMethodAdress("glEndQueryARB", typeof(dgtk.OpenGL.delegatesGLes.glEndQueryARB));
			}
			if (SuportedExt.Contains("glEndQueryEXT"))
			{
				dgtk.OpenGL.internalGLes.glEndQueryEXT = (dgtk.OpenGL.delegatesGLes.glEndQueryEXT) InternalTool.GetGLesMethodAdress("glEndQueryEXT", typeof(dgtk.OpenGL.delegatesGLes.glEndQueryEXT));
			}
			if (SuportedExt.Contains("glEndTilingQCOM"))
			{
				dgtk.OpenGL.internalGLes.glEndTilingQCOM = (dgtk.OpenGL.delegatesGLes.glEndTilingQCOM) InternalTool.GetGLesMethodAdress("glEndTilingQCOM", typeof(dgtk.OpenGL.delegatesGLes.glEndTilingQCOM));
			}
			if (SuportedExt.Contains("glEndTransformFeedbackEXT"))
			{
				dgtk.OpenGL.internalGLes.glEndTransformFeedbackEXT = (dgtk.OpenGL.delegatesGLes.glEndTransformFeedbackEXT) InternalTool.GetGLesMethodAdress("glEndTransformFeedbackEXT", typeof(dgtk.OpenGL.delegatesGLes.glEndTransformFeedbackEXT));
			}
			if (SuportedExt.Contains("glEndTransformFeedbackNV"))
			{
				dgtk.OpenGL.internalGLes.glEndTransformFeedbackNV = (dgtk.OpenGL.delegatesGLes.glEndTransformFeedbackNV) InternalTool.GetGLesMethodAdress("glEndTransformFeedbackNV", typeof(dgtk.OpenGL.delegatesGLes.glEndTransformFeedbackNV));
			}
			if (SuportedExt.Contains("glEndVertexShaderEXT"))
			{
				dgtk.OpenGL.internalGLes.glEndVertexShaderEXT = (dgtk.OpenGL.delegatesGLes.glEndVertexShaderEXT) InternalTool.GetGLesMethodAdress("glEndVertexShaderEXT", typeof(dgtk.OpenGL.delegatesGLes.glEndVertexShaderEXT));
			}
			if (SuportedExt.Contains("glEndVideoCaptureNV"))
			{
				dgtk.OpenGL.internalGLes.glEndVideoCaptureNV = (dgtk.OpenGL.delegatesGLes.glEndVideoCaptureNV) InternalTool.GetGLesMethodAdress("glEndVideoCaptureNV", typeof(dgtk.OpenGL.delegatesGLes.glEndVideoCaptureNV));
			}
			if (SuportedExt.Contains("glEvalCoord1xOES"))
			{
				dgtk.OpenGL.internalGLes.glEvalCoord1xOES = (dgtk.OpenGL.delegatesGLes.glEvalCoord1xOES) InternalTool.GetGLesMethodAdress("glEvalCoord1xOES", typeof(dgtk.OpenGL.delegatesGLes.glEvalCoord1xOES));
			}
			if (SuportedExt.Contains("glEvalCoord1xvOES"))
			{
				dgtk.OpenGL.internalGLes.glEvalCoord1xvOES = (dgtk.OpenGL.delegatesGLes.glEvalCoord1xvOES) InternalTool.GetGLesMethodAdress("glEvalCoord1xvOES", typeof(dgtk.OpenGL.delegatesGLes.glEvalCoord1xvOES));
			}
			if (SuportedExt.Contains("glEvalCoord2xOES"))
			{
				dgtk.OpenGL.internalGLes.glEvalCoord2xOES = (dgtk.OpenGL.delegatesGLes.glEvalCoord2xOES) InternalTool.GetGLesMethodAdress("glEvalCoord2xOES", typeof(dgtk.OpenGL.delegatesGLes.glEvalCoord2xOES));
			}
			if (SuportedExt.Contains("glEvalCoord2xvOES"))
			{
				dgtk.OpenGL.internalGLes.glEvalCoord2xvOES = (dgtk.OpenGL.delegatesGLes.glEvalCoord2xvOES) InternalTool.GetGLesMethodAdress("glEvalCoord2xvOES", typeof(dgtk.OpenGL.delegatesGLes.glEvalCoord2xvOES));
			}
			if (SuportedExt.Contains("glEvalMapsNV"))
			{
				dgtk.OpenGL.internalGLes.glEvalMapsNV = (dgtk.OpenGL.delegatesGLes.glEvalMapsNV) InternalTool.GetGLesMethodAdress("glEvalMapsNV", typeof(dgtk.OpenGL.delegatesGLes.glEvalMapsNV));
			}
			if (SuportedExt.Contains("glEvaluateDepthValuesARB"))
			{
				dgtk.OpenGL.internalGLes.glEvaluateDepthValuesARB = (dgtk.OpenGL.delegatesGLes.glEvaluateDepthValuesARB) InternalTool.GetGLesMethodAdress("glEvaluateDepthValuesARB", typeof(dgtk.OpenGL.delegatesGLes.glEvaluateDepthValuesARB));
			}
			if (SuportedExt.Contains("glExecuteProgramNV"))
			{
				dgtk.OpenGL.internalGLes.glExecuteProgramNV = (dgtk.OpenGL.delegatesGLes.glExecuteProgramNV) InternalTool.GetGLesMethodAdress("glExecuteProgramNV", typeof(dgtk.OpenGL.delegatesGLes.glExecuteProgramNV));
			}
			if (SuportedExt.Contains("glExtGetBufferPointervQCOM"))
			{
				dgtk.OpenGL.internalGLes.glExtGetBufferPointervQCOM = (dgtk.OpenGL.delegatesGLes.glExtGetBufferPointervQCOM) InternalTool.GetGLesMethodAdress("glExtGetBufferPointervQCOM", typeof(dgtk.OpenGL.delegatesGLes.glExtGetBufferPointervQCOM));
			}
			if (SuportedExt.Contains("glExtGetBuffersQCOM"))
			{
				dgtk.OpenGL.internalGLes.glExtGetBuffersQCOM = (dgtk.OpenGL.delegatesGLes.glExtGetBuffersQCOM) InternalTool.GetGLesMethodAdress("glExtGetBuffersQCOM", typeof(dgtk.OpenGL.delegatesGLes.glExtGetBuffersQCOM));
			}
			if (SuportedExt.Contains("glExtGetFramebuffersQCOM"))
			{
				dgtk.OpenGL.internalGLes.glExtGetFramebuffersQCOM = (dgtk.OpenGL.delegatesGLes.glExtGetFramebuffersQCOM) InternalTool.GetGLesMethodAdress("glExtGetFramebuffersQCOM", typeof(dgtk.OpenGL.delegatesGLes.glExtGetFramebuffersQCOM));
			}
			if (SuportedExt.Contains("glExtGetProgramBinarySourceQCOM"))
			{
				dgtk.OpenGL.internalGLes.glExtGetProgramBinarySourceQCOM = (dgtk.OpenGL.delegatesGLes.glExtGetProgramBinarySourceQCOM) InternalTool.GetGLesMethodAdress("glExtGetProgramBinarySourceQCOM", typeof(dgtk.OpenGL.delegatesGLes.glExtGetProgramBinarySourceQCOM));
			}
			if (SuportedExt.Contains("glExtGetProgramsQCOM"))
			{
				dgtk.OpenGL.internalGLes.glExtGetProgramsQCOM = (dgtk.OpenGL.delegatesGLes.glExtGetProgramsQCOM) InternalTool.GetGLesMethodAdress("glExtGetProgramsQCOM", typeof(dgtk.OpenGL.delegatesGLes.glExtGetProgramsQCOM));
			}
			if (SuportedExt.Contains("glExtGetRenderbuffersQCOM"))
			{
				dgtk.OpenGL.internalGLes.glExtGetRenderbuffersQCOM = (dgtk.OpenGL.delegatesGLes.glExtGetRenderbuffersQCOM) InternalTool.GetGLesMethodAdress("glExtGetRenderbuffersQCOM", typeof(dgtk.OpenGL.delegatesGLes.glExtGetRenderbuffersQCOM));
			}
			if (SuportedExt.Contains("glExtGetShadersQCOM"))
			{
				dgtk.OpenGL.internalGLes.glExtGetShadersQCOM = (dgtk.OpenGL.delegatesGLes.glExtGetShadersQCOM) InternalTool.GetGLesMethodAdress("glExtGetShadersQCOM", typeof(dgtk.OpenGL.delegatesGLes.glExtGetShadersQCOM));
			}
			if (SuportedExt.Contains("glExtGetTexLevelParameterivQCOM"))
			{
				dgtk.OpenGL.internalGLes.glExtGetTexLevelParameterivQCOM = (dgtk.OpenGL.delegatesGLes.glExtGetTexLevelParameterivQCOM) InternalTool.GetGLesMethodAdress("glExtGetTexLevelParameterivQCOM", typeof(dgtk.OpenGL.delegatesGLes.glExtGetTexLevelParameterivQCOM));
			}
			if (SuportedExt.Contains("glExtGetTexSubImageQCOM"))
			{
				dgtk.OpenGL.internalGLes.glExtGetTexSubImageQCOM = (dgtk.OpenGL.delegatesGLes.glExtGetTexSubImageQCOM) InternalTool.GetGLesMethodAdress("glExtGetTexSubImageQCOM", typeof(dgtk.OpenGL.delegatesGLes.glExtGetTexSubImageQCOM));
			}
			if (SuportedExt.Contains("glExtGetTexturesQCOM"))
			{
				dgtk.OpenGL.internalGLes.glExtGetTexturesQCOM = (dgtk.OpenGL.delegatesGLes.glExtGetTexturesQCOM) InternalTool.GetGLesMethodAdress("glExtGetTexturesQCOM", typeof(dgtk.OpenGL.delegatesGLes.glExtGetTexturesQCOM));
			}
			if (SuportedExt.Contains("glExtIsProgramBinaryQCOM"))
			{
				dgtk.OpenGL.internalGLes.glExtIsProgramBinaryQCOM = (dgtk.OpenGL.delegatesGLes.glExtIsProgramBinaryQCOM) InternalTool.GetGLesMethodAdress("glExtIsProgramBinaryQCOM", typeof(dgtk.OpenGL.delegatesGLes.glExtIsProgramBinaryQCOM));
			}
			if (SuportedExt.Contains("glExtractComponentEXT"))
			{
				dgtk.OpenGL.internalGLes.glExtractComponentEXT = (dgtk.OpenGL.delegatesGLes.glExtractComponentEXT) InternalTool.GetGLesMethodAdress("glExtractComponentEXT", typeof(dgtk.OpenGL.delegatesGLes.glExtractComponentEXT));
			}
			if (SuportedExt.Contains("glExtrapolateTex2DQCOM"))
			{
				dgtk.OpenGL.internalGLes.glExtrapolateTex2DQCOM = (dgtk.OpenGL.delegatesGLes.glExtrapolateTex2DQCOM) InternalTool.GetGLesMethodAdress("glExtrapolateTex2DQCOM", typeof(dgtk.OpenGL.delegatesGLes.glExtrapolateTex2DQCOM));
			}
			if (SuportedExt.Contains("glExtTexObjectStateOverrideiQCOM"))
			{
				dgtk.OpenGL.internalGLes.glExtTexObjectStateOverrideiQCOM = (dgtk.OpenGL.delegatesGLes.glExtTexObjectStateOverrideiQCOM) InternalTool.GetGLesMethodAdress("glExtTexObjectStateOverrideiQCOM", typeof(dgtk.OpenGL.delegatesGLes.glExtTexObjectStateOverrideiQCOM));
			}
			#endregion

			#region F:

			if (SuportedExt.Contains("glFeedbackBufferxOES"))
			{
				dgtk.OpenGL.internalGLes.glFeedbackBufferxOES = (dgtk.OpenGL.delegatesGLes.glFeedbackBufferxOES) InternalTool.GetGLesMethodAdress("glFeedbackBufferxOES", typeof(dgtk.OpenGL.delegatesGLes.glFeedbackBufferxOES));
			}
			if (SuportedExt.Contains("glFenceSyncAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glFenceSyncAPPLE = (dgtk.OpenGL.delegatesGLes.glFenceSyncAPPLE) InternalTool.GetGLesMethodAdress("glFenceSyncAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glFenceSyncAPPLE));
			}
			if (SuportedExt.Contains("glFinalCombinerInputNV"))
			{
				dgtk.OpenGL.internalGLes.glFinalCombinerInputNV = (dgtk.OpenGL.delegatesGLes.glFinalCombinerInputNV) InternalTool.GetGLesMethodAdress("glFinalCombinerInputNV", typeof(dgtk.OpenGL.delegatesGLes.glFinalCombinerInputNV));
			}
			if (SuportedExt.Contains("glFinishAsyncSGIX"))
			{
				dgtk.OpenGL.internalGLes.glFinishAsyncSGIX = (dgtk.OpenGL.delegatesGLes.glFinishAsyncSGIX) InternalTool.GetGLesMethodAdress("glFinishAsyncSGIX", typeof(dgtk.OpenGL.delegatesGLes.glFinishAsyncSGIX));
			}
			if (SuportedExt.Contains("glFinishFenceAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glFinishFenceAPPLE = (dgtk.OpenGL.delegatesGLes.glFinishFenceAPPLE) InternalTool.GetGLesMethodAdress("glFinishFenceAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glFinishFenceAPPLE));
			}
			if (SuportedExt.Contains("glFinishFenceNV"))
			{
				dgtk.OpenGL.internalGLes.glFinishFenceNV = (dgtk.OpenGL.delegatesGLes.glFinishFenceNV) InternalTool.GetGLesMethodAdress("glFinishFenceNV", typeof(dgtk.OpenGL.delegatesGLes.glFinishFenceNV));
			}
			if (SuportedExt.Contains("glFinishObjectAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glFinishObjectAPPLE = (dgtk.OpenGL.delegatesGLes.glFinishObjectAPPLE) InternalTool.GetGLesMethodAdress("glFinishObjectAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glFinishObjectAPPLE));
			}
			if (SuportedExt.Contains("glFinishTextureSUNX"))
			{
				dgtk.OpenGL.internalGLes.glFinishTextureSUNX = (dgtk.OpenGL.delegatesGLes.glFinishTextureSUNX) InternalTool.GetGLesMethodAdress("glFinishTextureSUNX", typeof(dgtk.OpenGL.delegatesGLes.glFinishTextureSUNX));
			}
			if (SuportedExt.Contains("glFlushMappedBufferRangeAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glFlushMappedBufferRangeAPPLE = (dgtk.OpenGL.delegatesGLes.glFlushMappedBufferRangeAPPLE) InternalTool.GetGLesMethodAdress("glFlushMappedBufferRangeAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glFlushMappedBufferRangeAPPLE));
			}
			if (SuportedExt.Contains("glFlushMappedBufferRangeEXT"))
			{
				dgtk.OpenGL.internalGLes.glFlushMappedBufferRangeEXT = (dgtk.OpenGL.delegatesGLes.glFlushMappedBufferRangeEXT) InternalTool.GetGLesMethodAdress("glFlushMappedBufferRangeEXT", typeof(dgtk.OpenGL.delegatesGLes.glFlushMappedBufferRangeEXT));
			}
			if (SuportedExt.Contains("glFlushMappedNamedBufferRangeEXT"))
			{
				dgtk.OpenGL.internalGLes.glFlushMappedNamedBufferRangeEXT = (dgtk.OpenGL.delegatesGLes.glFlushMappedNamedBufferRangeEXT) InternalTool.GetGLesMethodAdress("glFlushMappedNamedBufferRangeEXT", typeof(dgtk.OpenGL.delegatesGLes.glFlushMappedNamedBufferRangeEXT));
			}
			if (SuportedExt.Contains("glFlushPixelDataRangeNV"))
			{
				dgtk.OpenGL.internalGLes.glFlushPixelDataRangeNV = (dgtk.OpenGL.delegatesGLes.glFlushPixelDataRangeNV) InternalTool.GetGLesMethodAdress("glFlushPixelDataRangeNV", typeof(dgtk.OpenGL.delegatesGLes.glFlushPixelDataRangeNV));
			}
			if (SuportedExt.Contains("glFlushRasterSGIX"))
			{
				dgtk.OpenGL.internalGLes.glFlushRasterSGIX = (dgtk.OpenGL.delegatesGLes.glFlushRasterSGIX) InternalTool.GetGLesMethodAdress("glFlushRasterSGIX", typeof(dgtk.OpenGL.delegatesGLes.glFlushRasterSGIX));
			}
			if (SuportedExt.Contains("glFlushStaticDataIBM"))
			{
				dgtk.OpenGL.internalGLes.glFlushStaticDataIBM = (dgtk.OpenGL.delegatesGLes.glFlushStaticDataIBM) InternalTool.GetGLesMethodAdress("glFlushStaticDataIBM", typeof(dgtk.OpenGL.delegatesGLes.glFlushStaticDataIBM));
			}
			if (SuportedExt.Contains("glFlushVertexArrayRangeAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glFlushVertexArrayRangeAPPLE = (dgtk.OpenGL.delegatesGLes.glFlushVertexArrayRangeAPPLE) InternalTool.GetGLesMethodAdress("glFlushVertexArrayRangeAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glFlushVertexArrayRangeAPPLE));
			}
			if (SuportedExt.Contains("glFlushVertexArrayRangeNV"))
			{
				dgtk.OpenGL.internalGLes.glFlushVertexArrayRangeNV = (dgtk.OpenGL.delegatesGLes.glFlushVertexArrayRangeNV) InternalTool.GetGLesMethodAdress("glFlushVertexArrayRangeNV", typeof(dgtk.OpenGL.delegatesGLes.glFlushVertexArrayRangeNV));
			}
			if (SuportedExt.Contains("glFogCoorddEXT"))
			{
				dgtk.OpenGL.internalGLes.glFogCoorddEXT = (dgtk.OpenGL.delegatesGLes.glFogCoorddEXT) InternalTool.GetGLesMethodAdress("glFogCoorddEXT", typeof(dgtk.OpenGL.delegatesGLes.glFogCoorddEXT));
			}
			if (SuportedExt.Contains("glFogCoorddvEXT"))
			{
				dgtk.OpenGL.internalGLes.glFogCoorddvEXT = (dgtk.OpenGL.delegatesGLes.glFogCoorddvEXT) InternalTool.GetGLesMethodAdress("glFogCoorddvEXT", typeof(dgtk.OpenGL.delegatesGLes.glFogCoorddvEXT));
			}
			if (SuportedExt.Contains("glFogCoordfEXT"))
			{
				dgtk.OpenGL.internalGLes.glFogCoordfEXT = (dgtk.OpenGL.delegatesGLes.glFogCoordfEXT) InternalTool.GetGLesMethodAdress("glFogCoordfEXT", typeof(dgtk.OpenGL.delegatesGLes.glFogCoordfEXT));
			}
			if (SuportedExt.Contains("glFogCoordFormatNV"))
			{
				dgtk.OpenGL.internalGLes.glFogCoordFormatNV = (dgtk.OpenGL.delegatesGLes.glFogCoordFormatNV) InternalTool.GetGLesMethodAdress("glFogCoordFormatNV", typeof(dgtk.OpenGL.delegatesGLes.glFogCoordFormatNV));
			}
			if (SuportedExt.Contains("glFogCoordfvEXT"))
			{
				dgtk.OpenGL.internalGLes.glFogCoordfvEXT = (dgtk.OpenGL.delegatesGLes.glFogCoordfvEXT) InternalTool.GetGLesMethodAdress("glFogCoordfvEXT", typeof(dgtk.OpenGL.delegatesGLes.glFogCoordfvEXT));
			}
			if (SuportedExt.Contains("glFogCoordhNV"))
			{
				dgtk.OpenGL.internalGLes.glFogCoordhNV = (dgtk.OpenGL.delegatesGLes.glFogCoordhNV) InternalTool.GetGLesMethodAdress("glFogCoordhNV", typeof(dgtk.OpenGL.delegatesGLes.glFogCoordhNV));
			}
			if (SuportedExt.Contains("glFogCoordhvNV"))
			{
				dgtk.OpenGL.internalGLes.glFogCoordhvNV = (dgtk.OpenGL.delegatesGLes.glFogCoordhvNV) InternalTool.GetGLesMethodAdress("glFogCoordhvNV", typeof(dgtk.OpenGL.delegatesGLes.glFogCoordhvNV));
			}
			if (SuportedExt.Contains("glFogCoordPointerEXT"))
			{
				dgtk.OpenGL.internalGLes.glFogCoordPointerEXT = (dgtk.OpenGL.delegatesGLes.glFogCoordPointerEXT) InternalTool.GetGLesMethodAdress("glFogCoordPointerEXT", typeof(dgtk.OpenGL.delegatesGLes.glFogCoordPointerEXT));
			}
			if (SuportedExt.Contains("glFogCoordPointerListIBM"))
			{
				dgtk.OpenGL.internalGLes.glFogCoordPointerListIBM = (dgtk.OpenGL.delegatesGLes.glFogCoordPointerListIBM) InternalTool.GetGLesMethodAdress("glFogCoordPointerListIBM", typeof(dgtk.OpenGL.delegatesGLes.glFogCoordPointerListIBM));
			}
			if (SuportedExt.Contains("glFogFuncSGIS"))
			{
				dgtk.OpenGL.internalGLes.glFogFuncSGIS = (dgtk.OpenGL.delegatesGLes.glFogFuncSGIS) InternalTool.GetGLesMethodAdress("glFogFuncSGIS", typeof(dgtk.OpenGL.delegatesGLes.glFogFuncSGIS));
			}
			if (SuportedExt.Contains("glFogx"))
			{
				dgtk.OpenGL.internalGLes.glFogx = (dgtk.OpenGL.delegatesGLes.glFogx) InternalTool.GetGLesMethodAdress("glFogx", typeof(dgtk.OpenGL.delegatesGLes.glFogx));
			}
			if (SuportedExt.Contains("glFogxOES"))
			{
				dgtk.OpenGL.internalGLes.glFogxOES = (dgtk.OpenGL.delegatesGLes.glFogxOES) InternalTool.GetGLesMethodAdress("glFogxOES", typeof(dgtk.OpenGL.delegatesGLes.glFogxOES));
			}
			if (SuportedExt.Contains("glFogxv"))
			{
				dgtk.OpenGL.internalGLes.glFogxv = (dgtk.OpenGL.delegatesGLes.glFogxv) InternalTool.GetGLesMethodAdress("glFogxv", typeof(dgtk.OpenGL.delegatesGLes.glFogxv));
			}
			if (SuportedExt.Contains("glFogxvOES"))
			{
				dgtk.OpenGL.internalGLes.glFogxvOES = (dgtk.OpenGL.delegatesGLes.glFogxvOES) InternalTool.GetGLesMethodAdress("glFogxvOES", typeof(dgtk.OpenGL.delegatesGLes.glFogxvOES));
			}
			if (SuportedExt.Contains("glFragmentColorMaterialSGIX"))
			{
				dgtk.OpenGL.internalGLes.glFragmentColorMaterialSGIX = (dgtk.OpenGL.delegatesGLes.glFragmentColorMaterialSGIX) InternalTool.GetGLesMethodAdress("glFragmentColorMaterialSGIX", typeof(dgtk.OpenGL.delegatesGLes.glFragmentColorMaterialSGIX));
			}
			if (SuportedExt.Contains("glFragmentCoverageColorNV"))
			{
				dgtk.OpenGL.internalGLes.glFragmentCoverageColorNV = (dgtk.OpenGL.delegatesGLes.glFragmentCoverageColorNV) InternalTool.GetGLesMethodAdress("glFragmentCoverageColorNV", typeof(dgtk.OpenGL.delegatesGLes.glFragmentCoverageColorNV));
			}
			if (SuportedExt.Contains("glFragmentLightfSGIX"))
			{
				dgtk.OpenGL.internalGLes.glFragmentLightfSGIX = (dgtk.OpenGL.delegatesGLes.glFragmentLightfSGIX) InternalTool.GetGLesMethodAdress("glFragmentLightfSGIX", typeof(dgtk.OpenGL.delegatesGLes.glFragmentLightfSGIX));
			}
			if (SuportedExt.Contains("glFragmentLightfvSGIX"))
			{
				dgtk.OpenGL.internalGLes.glFragmentLightfvSGIX = (dgtk.OpenGL.delegatesGLes.glFragmentLightfvSGIX) InternalTool.GetGLesMethodAdress("glFragmentLightfvSGIX", typeof(dgtk.OpenGL.delegatesGLes.glFragmentLightfvSGIX));
			}
			if (SuportedExt.Contains("glFragmentLightiSGIX"))
			{
				dgtk.OpenGL.internalGLes.glFragmentLightiSGIX = (dgtk.OpenGL.delegatesGLes.glFragmentLightiSGIX) InternalTool.GetGLesMethodAdress("glFragmentLightiSGIX", typeof(dgtk.OpenGL.delegatesGLes.glFragmentLightiSGIX));
			}
			if (SuportedExt.Contains("glFragmentLightivSGIX"))
			{
				dgtk.OpenGL.internalGLes.glFragmentLightivSGIX = (dgtk.OpenGL.delegatesGLes.glFragmentLightivSGIX) InternalTool.GetGLesMethodAdress("glFragmentLightivSGIX", typeof(dgtk.OpenGL.delegatesGLes.glFragmentLightivSGIX));
			}
			if (SuportedExt.Contains("glFragmentLightModelfSGIX"))
			{
				dgtk.OpenGL.internalGLes.glFragmentLightModelfSGIX = (dgtk.OpenGL.delegatesGLes.glFragmentLightModelfSGIX) InternalTool.GetGLesMethodAdress("glFragmentLightModelfSGIX", typeof(dgtk.OpenGL.delegatesGLes.glFragmentLightModelfSGIX));
			}
			if (SuportedExt.Contains("glFragmentLightModelfvSGIX"))
			{
				dgtk.OpenGL.internalGLes.glFragmentLightModelfvSGIX = (dgtk.OpenGL.delegatesGLes.glFragmentLightModelfvSGIX) InternalTool.GetGLesMethodAdress("glFragmentLightModelfvSGIX", typeof(dgtk.OpenGL.delegatesGLes.glFragmentLightModelfvSGIX));
			}
			if (SuportedExt.Contains("glFragmentLightModeliSGIX"))
			{
				dgtk.OpenGL.internalGLes.glFragmentLightModeliSGIX = (dgtk.OpenGL.delegatesGLes.glFragmentLightModeliSGIX) InternalTool.GetGLesMethodAdress("glFragmentLightModeliSGIX", typeof(dgtk.OpenGL.delegatesGLes.glFragmentLightModeliSGIX));
			}
			if (SuportedExt.Contains("glFragmentLightModelivSGIX"))
			{
				dgtk.OpenGL.internalGLes.glFragmentLightModelivSGIX = (dgtk.OpenGL.delegatesGLes.glFragmentLightModelivSGIX) InternalTool.GetGLesMethodAdress("glFragmentLightModelivSGIX", typeof(dgtk.OpenGL.delegatesGLes.glFragmentLightModelivSGIX));
			}
			if (SuportedExt.Contains("glFragmentMaterialfSGIX"))
			{
				dgtk.OpenGL.internalGLes.glFragmentMaterialfSGIX = (dgtk.OpenGL.delegatesGLes.glFragmentMaterialfSGIX) InternalTool.GetGLesMethodAdress("glFragmentMaterialfSGIX", typeof(dgtk.OpenGL.delegatesGLes.glFragmentMaterialfSGIX));
			}
			if (SuportedExt.Contains("glFragmentMaterialfvSGIX"))
			{
				dgtk.OpenGL.internalGLes.glFragmentMaterialfvSGIX = (dgtk.OpenGL.delegatesGLes.glFragmentMaterialfvSGIX) InternalTool.GetGLesMethodAdress("glFragmentMaterialfvSGIX", typeof(dgtk.OpenGL.delegatesGLes.glFragmentMaterialfvSGIX));
			}
			if (SuportedExt.Contains("glFragmentMaterialiSGIX"))
			{
				dgtk.OpenGL.internalGLes.glFragmentMaterialiSGIX = (dgtk.OpenGL.delegatesGLes.glFragmentMaterialiSGIX) InternalTool.GetGLesMethodAdress("glFragmentMaterialiSGIX", typeof(dgtk.OpenGL.delegatesGLes.glFragmentMaterialiSGIX));
			}
			if (SuportedExt.Contains("glFragmentMaterialivSGIX"))
			{
				dgtk.OpenGL.internalGLes.glFragmentMaterialivSGIX = (dgtk.OpenGL.delegatesGLes.glFragmentMaterialivSGIX) InternalTool.GetGLesMethodAdress("glFragmentMaterialivSGIX", typeof(dgtk.OpenGL.delegatesGLes.glFragmentMaterialivSGIX));
			}
			if (SuportedExt.Contains("glFramebufferDrawBufferEXT"))
			{
				dgtk.OpenGL.internalGLes.glFramebufferDrawBufferEXT = (dgtk.OpenGL.delegatesGLes.glFramebufferDrawBufferEXT) InternalTool.GetGLesMethodAdress("glFramebufferDrawBufferEXT", typeof(dgtk.OpenGL.delegatesGLes.glFramebufferDrawBufferEXT));
			}
			if (SuportedExt.Contains("glFramebufferDrawBuffersEXT"))
			{
				dgtk.OpenGL.internalGLes.glFramebufferDrawBuffersEXT = (dgtk.OpenGL.delegatesGLes.glFramebufferDrawBuffersEXT) InternalTool.GetGLesMethodAdress("glFramebufferDrawBuffersEXT", typeof(dgtk.OpenGL.delegatesGLes.glFramebufferDrawBuffersEXT));
			}
			if (SuportedExt.Contains("glFramebufferFetchBarrierEXT"))
			{
				dgtk.OpenGL.internalGLes.glFramebufferFetchBarrierEXT = (dgtk.OpenGL.delegatesGLes.glFramebufferFetchBarrierEXT) InternalTool.GetGLesMethodAdress("glFramebufferFetchBarrierEXT", typeof(dgtk.OpenGL.delegatesGLes.glFramebufferFetchBarrierEXT));
			}
			if (SuportedExt.Contains("glFramebufferFetchBarrierQCOM"))
			{
				dgtk.OpenGL.internalGLes.glFramebufferFetchBarrierQCOM = (dgtk.OpenGL.delegatesGLes.glFramebufferFetchBarrierQCOM) InternalTool.GetGLesMethodAdress("glFramebufferFetchBarrierQCOM", typeof(dgtk.OpenGL.delegatesGLes.glFramebufferFetchBarrierQCOM));
			}
			if (SuportedExt.Contains("glFramebufferFoveationConfigQCOM"))
			{
				dgtk.OpenGL.internalGLes.glFramebufferFoveationConfigQCOM = (dgtk.OpenGL.delegatesGLes.glFramebufferFoveationConfigQCOM) InternalTool.GetGLesMethodAdress("glFramebufferFoveationConfigQCOM", typeof(dgtk.OpenGL.delegatesGLes.glFramebufferFoveationConfigQCOM));
			}
			if (SuportedExt.Contains("glFramebufferFoveationParametersQCOM"))
			{
				dgtk.OpenGL.internalGLes.glFramebufferFoveationParametersQCOM = (dgtk.OpenGL.delegatesGLes.glFramebufferFoveationParametersQCOM) InternalTool.GetGLesMethodAdress("glFramebufferFoveationParametersQCOM", typeof(dgtk.OpenGL.delegatesGLes.glFramebufferFoveationParametersQCOM));
			}
			if (SuportedExt.Contains("glFramebufferParameteriMESA"))
			{
				dgtk.OpenGL.internalGLes.glFramebufferParameteriMESA = (dgtk.OpenGL.delegatesGLes.glFramebufferParameteriMESA) InternalTool.GetGLesMethodAdress("glFramebufferParameteriMESA", typeof(dgtk.OpenGL.delegatesGLes.glFramebufferParameteriMESA));
			}
			if (SuportedExt.Contains("glFramebufferPixelLocalStorageSizeEXT"))
			{
				dgtk.OpenGL.internalGLes.glFramebufferPixelLocalStorageSizeEXT = (dgtk.OpenGL.delegatesGLes.glFramebufferPixelLocalStorageSizeEXT) InternalTool.GetGLesMethodAdress("glFramebufferPixelLocalStorageSizeEXT", typeof(dgtk.OpenGL.delegatesGLes.glFramebufferPixelLocalStorageSizeEXT));
			}
			if (SuportedExt.Contains("glFramebufferReadBufferEXT"))
			{
				dgtk.OpenGL.internalGLes.glFramebufferReadBufferEXT = (dgtk.OpenGL.delegatesGLes.glFramebufferReadBufferEXT) InternalTool.GetGLesMethodAdress("glFramebufferReadBufferEXT", typeof(dgtk.OpenGL.delegatesGLes.glFramebufferReadBufferEXT));
			}
			if (SuportedExt.Contains("glFramebufferRenderbufferEXT"))
			{
				dgtk.OpenGL.internalGLes.glFramebufferRenderbufferEXT = (dgtk.OpenGL.delegatesGLes.glFramebufferRenderbufferEXT) InternalTool.GetGLesMethodAdress("glFramebufferRenderbufferEXT", typeof(dgtk.OpenGL.delegatesGLes.glFramebufferRenderbufferEXT));
			}
			if (SuportedExt.Contains("glFramebufferRenderbufferOES"))
			{
				dgtk.OpenGL.internalGLes.glFramebufferRenderbufferOES = (dgtk.OpenGL.delegatesGLes.glFramebufferRenderbufferOES) InternalTool.GetGLesMethodAdress("glFramebufferRenderbufferOES", typeof(dgtk.OpenGL.delegatesGLes.glFramebufferRenderbufferOES));
			}
			if (SuportedExt.Contains("glFramebufferSampleLocationsfvARB"))
			{
				dgtk.OpenGL.internalGLes.glFramebufferSampleLocationsfvARB = (dgtk.OpenGL.delegatesGLes.glFramebufferSampleLocationsfvARB) InternalTool.GetGLesMethodAdress("glFramebufferSampleLocationsfvARB", typeof(dgtk.OpenGL.delegatesGLes.glFramebufferSampleLocationsfvARB));
			}
			if (SuportedExt.Contains("glFramebufferSampleLocationsfvNV"))
			{
				dgtk.OpenGL.internalGLes.glFramebufferSampleLocationsfvNV = (dgtk.OpenGL.delegatesGLes.glFramebufferSampleLocationsfvNV) InternalTool.GetGLesMethodAdress("glFramebufferSampleLocationsfvNV", typeof(dgtk.OpenGL.delegatesGLes.glFramebufferSampleLocationsfvNV));
			}
			if (SuportedExt.Contains("glFramebufferSamplePositionsfvAMD"))
			{
				dgtk.OpenGL.internalGLes.glFramebufferSamplePositionsfvAMD = (dgtk.OpenGL.delegatesGLes.glFramebufferSamplePositionsfvAMD) InternalTool.GetGLesMethodAdress("glFramebufferSamplePositionsfvAMD", typeof(dgtk.OpenGL.delegatesGLes.glFramebufferSamplePositionsfvAMD));
			}
			if (SuportedExt.Contains("glFramebufferTexture1DEXT"))
			{
				dgtk.OpenGL.internalGLes.glFramebufferTexture1DEXT = (dgtk.OpenGL.delegatesGLes.glFramebufferTexture1DEXT) InternalTool.GetGLesMethodAdress("glFramebufferTexture1DEXT", typeof(dgtk.OpenGL.delegatesGLes.glFramebufferTexture1DEXT));
			}
			if (SuportedExt.Contains("glFramebufferTexture2DDownsampleIMG"))
			{
				dgtk.OpenGL.internalGLes.glFramebufferTexture2DDownsampleIMG = (dgtk.OpenGL.delegatesGLes.glFramebufferTexture2DDownsampleIMG) InternalTool.GetGLesMethodAdress("glFramebufferTexture2DDownsampleIMG", typeof(dgtk.OpenGL.delegatesGLes.glFramebufferTexture2DDownsampleIMG));
			}
			if (SuportedExt.Contains("glFramebufferTexture2DEXT"))
			{
				dgtk.OpenGL.internalGLes.glFramebufferTexture2DEXT = (dgtk.OpenGL.delegatesGLes.glFramebufferTexture2DEXT) InternalTool.GetGLesMethodAdress("glFramebufferTexture2DEXT", typeof(dgtk.OpenGL.delegatesGLes.glFramebufferTexture2DEXT));
			}
			if (SuportedExt.Contains("glFramebufferTexture2DMultisampleEXT"))
			{
				dgtk.OpenGL.internalGLes.glFramebufferTexture2DMultisampleEXT = (dgtk.OpenGL.delegatesGLes.glFramebufferTexture2DMultisampleEXT) InternalTool.GetGLesMethodAdress("glFramebufferTexture2DMultisampleEXT", typeof(dgtk.OpenGL.delegatesGLes.glFramebufferTexture2DMultisampleEXT));
			}
			if (SuportedExt.Contains("glFramebufferTexture2DMultisampleIMG"))
			{
				dgtk.OpenGL.internalGLes.glFramebufferTexture2DMultisampleIMG = (dgtk.OpenGL.delegatesGLes.glFramebufferTexture2DMultisampleIMG) InternalTool.GetGLesMethodAdress("glFramebufferTexture2DMultisampleIMG", typeof(dgtk.OpenGL.delegatesGLes.glFramebufferTexture2DMultisampleIMG));
			}
			if (SuportedExt.Contains("glFramebufferTexture2DOES"))
			{
				dgtk.OpenGL.internalGLes.glFramebufferTexture2DOES = (dgtk.OpenGL.delegatesGLes.glFramebufferTexture2DOES) InternalTool.GetGLesMethodAdress("glFramebufferTexture2DOES", typeof(dgtk.OpenGL.delegatesGLes.glFramebufferTexture2DOES));
			}
			if (SuportedExt.Contains("glFramebufferTexture3DEXT"))
			{
				dgtk.OpenGL.internalGLes.glFramebufferTexture3DEXT = (dgtk.OpenGL.delegatesGLes.glFramebufferTexture3DEXT) InternalTool.GetGLesMethodAdress("glFramebufferTexture3DEXT", typeof(dgtk.OpenGL.delegatesGLes.glFramebufferTexture3DEXT));
			}
			if (SuportedExt.Contains("glFramebufferTexture3DOES"))
			{
				dgtk.OpenGL.internalGLes.glFramebufferTexture3DOES = (dgtk.OpenGL.delegatesGLes.glFramebufferTexture3DOES) InternalTool.GetGLesMethodAdress("glFramebufferTexture3DOES", typeof(dgtk.OpenGL.delegatesGLes.glFramebufferTexture3DOES));
			}
			if (SuportedExt.Contains("glFramebufferTextureARB"))
			{
				dgtk.OpenGL.internalGLes.glFramebufferTextureARB = (dgtk.OpenGL.delegatesGLes.glFramebufferTextureARB) InternalTool.GetGLesMethodAdress("glFramebufferTextureARB", typeof(dgtk.OpenGL.delegatesGLes.glFramebufferTextureARB));
			}
			if (SuportedExt.Contains("glFramebufferTextureEXT"))
			{
				dgtk.OpenGL.internalGLes.glFramebufferTextureEXT = (dgtk.OpenGL.delegatesGLes.glFramebufferTextureEXT) InternalTool.GetGLesMethodAdress("glFramebufferTextureEXT", typeof(dgtk.OpenGL.delegatesGLes.glFramebufferTextureEXT));
			}
			if (SuportedExt.Contains("glFramebufferTextureFaceARB"))
			{
				dgtk.OpenGL.internalGLes.glFramebufferTextureFaceARB = (dgtk.OpenGL.delegatesGLes.glFramebufferTextureFaceARB) InternalTool.GetGLesMethodAdress("glFramebufferTextureFaceARB", typeof(dgtk.OpenGL.delegatesGLes.glFramebufferTextureFaceARB));
			}
			if (SuportedExt.Contains("glFramebufferTextureFaceEXT"))
			{
				dgtk.OpenGL.internalGLes.glFramebufferTextureFaceEXT = (dgtk.OpenGL.delegatesGLes.glFramebufferTextureFaceEXT) InternalTool.GetGLesMethodAdress("glFramebufferTextureFaceEXT", typeof(dgtk.OpenGL.delegatesGLes.glFramebufferTextureFaceEXT));
			}
			if (SuportedExt.Contains("glFramebufferTextureLayerARB"))
			{
				dgtk.OpenGL.internalGLes.glFramebufferTextureLayerARB = (dgtk.OpenGL.delegatesGLes.glFramebufferTextureLayerARB) InternalTool.GetGLesMethodAdress("glFramebufferTextureLayerARB", typeof(dgtk.OpenGL.delegatesGLes.glFramebufferTextureLayerARB));
			}
			if (SuportedExt.Contains("glFramebufferTextureLayerDownsampleIMG"))
			{
				dgtk.OpenGL.internalGLes.glFramebufferTextureLayerDownsampleIMG = (dgtk.OpenGL.delegatesGLes.glFramebufferTextureLayerDownsampleIMG) InternalTool.GetGLesMethodAdress("glFramebufferTextureLayerDownsampleIMG", typeof(dgtk.OpenGL.delegatesGLes.glFramebufferTextureLayerDownsampleIMG));
			}
			if (SuportedExt.Contains("glFramebufferTextureLayerEXT"))
			{
				dgtk.OpenGL.internalGLes.glFramebufferTextureLayerEXT = (dgtk.OpenGL.delegatesGLes.glFramebufferTextureLayerEXT) InternalTool.GetGLesMethodAdress("glFramebufferTextureLayerEXT", typeof(dgtk.OpenGL.delegatesGLes.glFramebufferTextureLayerEXT));
			}
			if (SuportedExt.Contains("glFramebufferTextureMultisampleMultiviewOVR"))
			{
				dgtk.OpenGL.internalGLes.glFramebufferTextureMultisampleMultiviewOVR = (dgtk.OpenGL.delegatesGLes.glFramebufferTextureMultisampleMultiviewOVR) InternalTool.GetGLesMethodAdress("glFramebufferTextureMultisampleMultiviewOVR", typeof(dgtk.OpenGL.delegatesGLes.glFramebufferTextureMultisampleMultiviewOVR));
			}
			if (SuportedExt.Contains("glFramebufferTextureMultiviewOVR"))
			{
				dgtk.OpenGL.internalGLes.glFramebufferTextureMultiviewOVR = (dgtk.OpenGL.delegatesGLes.glFramebufferTextureMultiviewOVR) InternalTool.GetGLesMethodAdress("glFramebufferTextureMultiviewOVR", typeof(dgtk.OpenGL.delegatesGLes.glFramebufferTextureMultiviewOVR));
			}
			if (SuportedExt.Contains("glFramebufferTextureOES"))
			{
				dgtk.OpenGL.internalGLes.glFramebufferTextureOES = (dgtk.OpenGL.delegatesGLes.glFramebufferTextureOES) InternalTool.GetGLesMethodAdress("glFramebufferTextureOES", typeof(dgtk.OpenGL.delegatesGLes.glFramebufferTextureOES));
			}
			if (SuportedExt.Contains("glFrameTerminatorGREMEDY"))
			{
				dgtk.OpenGL.internalGLes.glFrameTerminatorGREMEDY = (dgtk.OpenGL.delegatesGLes.glFrameTerminatorGREMEDY) InternalTool.GetGLesMethodAdress("glFrameTerminatorGREMEDY", typeof(dgtk.OpenGL.delegatesGLes.glFrameTerminatorGREMEDY));
			}
			if (SuportedExt.Contains("glFrameZoomSGIX"))
			{
				dgtk.OpenGL.internalGLes.glFrameZoomSGIX = (dgtk.OpenGL.delegatesGLes.glFrameZoomSGIX) InternalTool.GetGLesMethodAdress("glFrameZoomSGIX", typeof(dgtk.OpenGL.delegatesGLes.glFrameZoomSGIX));
			}
			if (SuportedExt.Contains("glFreeObjectBufferATI"))
			{
				dgtk.OpenGL.internalGLes.glFreeObjectBufferATI = (dgtk.OpenGL.delegatesGLes.glFreeObjectBufferATI) InternalTool.GetGLesMethodAdress("glFreeObjectBufferATI", typeof(dgtk.OpenGL.delegatesGLes.glFreeObjectBufferATI));
			}
			if (SuportedExt.Contains("glFrustumf"))
			{
				dgtk.OpenGL.internalGLes.glFrustumf = (dgtk.OpenGL.delegatesGLes.glFrustumf) InternalTool.GetGLesMethodAdress("glFrustumf", typeof(dgtk.OpenGL.delegatesGLes.glFrustumf));
			}
			if (SuportedExt.Contains("glFrustumfOES"))
			{
				dgtk.OpenGL.internalGLes.glFrustumfOES = (dgtk.OpenGL.delegatesGLes.glFrustumfOES) InternalTool.GetGLesMethodAdress("glFrustumfOES", typeof(dgtk.OpenGL.delegatesGLes.glFrustumfOES));
			}
			if (SuportedExt.Contains("glFrustumx"))
			{
				dgtk.OpenGL.internalGLes.glFrustumx = (dgtk.OpenGL.delegatesGLes.glFrustumx) InternalTool.GetGLesMethodAdress("glFrustumx", typeof(dgtk.OpenGL.delegatesGLes.glFrustumx));
			}
			if (SuportedExt.Contains("glFrustumxOES"))
			{
				dgtk.OpenGL.internalGLes.glFrustumxOES = (dgtk.OpenGL.delegatesGLes.glFrustumxOES) InternalTool.GetGLesMethodAdress("glFrustumxOES", typeof(dgtk.OpenGL.delegatesGLes.glFrustumxOES));
			}
			#endregion

			#region G:

			if (SuportedExt.Contains("glGenAsyncMarkersSGIX"))
			{
				dgtk.OpenGL.internalGLes.glGenAsyncMarkersSGIX = (dgtk.OpenGL.delegatesGLes.glGenAsyncMarkersSGIX) InternalTool.GetGLesMethodAdress("glGenAsyncMarkersSGIX", typeof(dgtk.OpenGL.delegatesGLes.glGenAsyncMarkersSGIX));
			}
			if (SuportedExt.Contains("glGenBuffersARB"))
			{
				dgtk.OpenGL.internalGLes.glGenBuffersARB = (dgtk.OpenGL.delegatesGLes.glGenBuffersARB) InternalTool.GetGLesMethodAdress("glGenBuffersARB", typeof(dgtk.OpenGL.delegatesGLes.glGenBuffersARB));
			}
			if (SuportedExt.Contains("glGenerateMipmapEXT"))
			{
				dgtk.OpenGL.internalGLes.glGenerateMipmapEXT = (dgtk.OpenGL.delegatesGLes.glGenerateMipmapEXT) InternalTool.GetGLesMethodAdress("glGenerateMipmapEXT", typeof(dgtk.OpenGL.delegatesGLes.glGenerateMipmapEXT));
			}
			if (SuportedExt.Contains("glGenerateMipmapOES"))
			{
				dgtk.OpenGL.internalGLes.glGenerateMipmapOES = (dgtk.OpenGL.delegatesGLes.glGenerateMipmapOES) InternalTool.GetGLesMethodAdress("glGenerateMipmapOES", typeof(dgtk.OpenGL.delegatesGLes.glGenerateMipmapOES));
			}
			if (SuportedExt.Contains("glGenerateMultiTexMipmapEXT"))
			{
				dgtk.OpenGL.internalGLes.glGenerateMultiTexMipmapEXT = (dgtk.OpenGL.delegatesGLes.glGenerateMultiTexMipmapEXT) InternalTool.GetGLesMethodAdress("glGenerateMultiTexMipmapEXT", typeof(dgtk.OpenGL.delegatesGLes.glGenerateMultiTexMipmapEXT));
			}
			if (SuportedExt.Contains("glGenerateTextureMipmapEXT"))
			{
				dgtk.OpenGL.internalGLes.glGenerateTextureMipmapEXT = (dgtk.OpenGL.delegatesGLes.glGenerateTextureMipmapEXT) InternalTool.GetGLesMethodAdress("glGenerateTextureMipmapEXT", typeof(dgtk.OpenGL.delegatesGLes.glGenerateTextureMipmapEXT));
			}
			if (SuportedExt.Contains("glGenFencesAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glGenFencesAPPLE = (dgtk.OpenGL.delegatesGLes.glGenFencesAPPLE) InternalTool.GetGLesMethodAdress("glGenFencesAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glGenFencesAPPLE));
			}
			if (SuportedExt.Contains("glGenFencesNV"))
			{
				dgtk.OpenGL.internalGLes.glGenFencesNV = (dgtk.OpenGL.delegatesGLes.glGenFencesNV) InternalTool.GetGLesMethodAdress("glGenFencesNV", typeof(dgtk.OpenGL.delegatesGLes.glGenFencesNV));
			}
			if (SuportedExt.Contains("glGenFragmentShadersATI"))
			{
				dgtk.OpenGL.internalGLes.glGenFragmentShadersATI = (dgtk.OpenGL.delegatesGLes.glGenFragmentShadersATI) InternalTool.GetGLesMethodAdress("glGenFragmentShadersATI", typeof(dgtk.OpenGL.delegatesGLes.glGenFragmentShadersATI));
			}
			if (SuportedExt.Contains("glGenFramebuffersEXT"))
			{
				dgtk.OpenGL.internalGLes.glGenFramebuffersEXT = (dgtk.OpenGL.delegatesGLes.glGenFramebuffersEXT) InternalTool.GetGLesMethodAdress("glGenFramebuffersEXT", typeof(dgtk.OpenGL.delegatesGLes.glGenFramebuffersEXT));
			}
			if (SuportedExt.Contains("glGenFramebuffersOES"))
			{
				dgtk.OpenGL.internalGLes.glGenFramebuffersOES = (dgtk.OpenGL.delegatesGLes.glGenFramebuffersOES) InternalTool.GetGLesMethodAdress("glGenFramebuffersOES", typeof(dgtk.OpenGL.delegatesGLes.glGenFramebuffersOES));
			}
			if (SuportedExt.Contains("glGenNamesAMD"))
			{
				dgtk.OpenGL.internalGLes.glGenNamesAMD = (dgtk.OpenGL.delegatesGLes.glGenNamesAMD) InternalTool.GetGLesMethodAdress("glGenNamesAMD", typeof(dgtk.OpenGL.delegatesGLes.glGenNamesAMD));
			}
			if (SuportedExt.Contains("glGenOcclusionQueriesNV"))
			{
				dgtk.OpenGL.internalGLes.glGenOcclusionQueriesNV = (dgtk.OpenGL.delegatesGLes.glGenOcclusionQueriesNV) InternalTool.GetGLesMethodAdress("glGenOcclusionQueriesNV", typeof(dgtk.OpenGL.delegatesGLes.glGenOcclusionQueriesNV));
			}
			if (SuportedExt.Contains("glGenPathsNV"))
			{
				dgtk.OpenGL.internalGLes.glGenPathsNV = (dgtk.OpenGL.delegatesGLes.glGenPathsNV) InternalTool.GetGLesMethodAdress("glGenPathsNV", typeof(dgtk.OpenGL.delegatesGLes.glGenPathsNV));
			}
			if (SuportedExt.Contains("glGenPerfMonitorsAMD"))
			{
				dgtk.OpenGL.internalGLes.glGenPerfMonitorsAMD = (dgtk.OpenGL.delegatesGLes.glGenPerfMonitorsAMD) InternalTool.GetGLesMethodAdress("glGenPerfMonitorsAMD", typeof(dgtk.OpenGL.delegatesGLes.glGenPerfMonitorsAMD));
			}
			if (SuportedExt.Contains("glGenProgramPipelinesEXT"))
			{
				dgtk.OpenGL.internalGLes.glGenProgramPipelinesEXT = (dgtk.OpenGL.delegatesGLes.glGenProgramPipelinesEXT) InternalTool.GetGLesMethodAdress("glGenProgramPipelinesEXT", typeof(dgtk.OpenGL.delegatesGLes.glGenProgramPipelinesEXT));
			}
			if (SuportedExt.Contains("glGenProgramsARB"))
			{
				dgtk.OpenGL.internalGLes.glGenProgramsARB = (dgtk.OpenGL.delegatesGLes.glGenProgramsARB) InternalTool.GetGLesMethodAdress("glGenProgramsARB", typeof(dgtk.OpenGL.delegatesGLes.glGenProgramsARB));
			}
			if (SuportedExt.Contains("glGenProgramsNV"))
			{
				dgtk.OpenGL.internalGLes.glGenProgramsNV = (dgtk.OpenGL.delegatesGLes.glGenProgramsNV) InternalTool.GetGLesMethodAdress("glGenProgramsNV", typeof(dgtk.OpenGL.delegatesGLes.glGenProgramsNV));
			}
			if (SuportedExt.Contains("glGenQueriesARB"))
			{
				dgtk.OpenGL.internalGLes.glGenQueriesARB = (dgtk.OpenGL.delegatesGLes.glGenQueriesARB) InternalTool.GetGLesMethodAdress("glGenQueriesARB", typeof(dgtk.OpenGL.delegatesGLes.glGenQueriesARB));
			}
			if (SuportedExt.Contains("glGenQueriesEXT"))
			{
				dgtk.OpenGL.internalGLes.glGenQueriesEXT = (dgtk.OpenGL.delegatesGLes.glGenQueriesEXT) InternalTool.GetGLesMethodAdress("glGenQueriesEXT", typeof(dgtk.OpenGL.delegatesGLes.glGenQueriesEXT));
			}
			if (SuportedExt.Contains("glGenQueryResourceTagNV"))
			{
				dgtk.OpenGL.internalGLes.glGenQueryResourceTagNV = (dgtk.OpenGL.delegatesGLes.glGenQueryResourceTagNV) InternalTool.GetGLesMethodAdress("glGenQueryResourceTagNV", typeof(dgtk.OpenGL.delegatesGLes.glGenQueryResourceTagNV));
			}
			if (SuportedExt.Contains("glGenRenderbuffersEXT"))
			{
				dgtk.OpenGL.internalGLes.glGenRenderbuffersEXT = (dgtk.OpenGL.delegatesGLes.glGenRenderbuffersEXT) InternalTool.GetGLesMethodAdress("glGenRenderbuffersEXT", typeof(dgtk.OpenGL.delegatesGLes.glGenRenderbuffersEXT));
			}
			if (SuportedExt.Contains("glGenRenderbuffersOES"))
			{
				dgtk.OpenGL.internalGLes.glGenRenderbuffersOES = (dgtk.OpenGL.delegatesGLes.glGenRenderbuffersOES) InternalTool.GetGLesMethodAdress("glGenRenderbuffersOES", typeof(dgtk.OpenGL.delegatesGLes.glGenRenderbuffersOES));
			}
			if (SuportedExt.Contains("glGenSemaphoresEXT"))
			{
				dgtk.OpenGL.internalGLes.glGenSemaphoresEXT = (dgtk.OpenGL.delegatesGLes.glGenSemaphoresEXT) InternalTool.GetGLesMethodAdress("glGenSemaphoresEXT", typeof(dgtk.OpenGL.delegatesGLes.glGenSemaphoresEXT));
			}
			if (SuportedExt.Contains("glGenSymbolsEXT"))
			{
				dgtk.OpenGL.internalGLes.glGenSymbolsEXT = (dgtk.OpenGL.delegatesGLes.glGenSymbolsEXT) InternalTool.GetGLesMethodAdress("glGenSymbolsEXT", typeof(dgtk.OpenGL.delegatesGLes.glGenSymbolsEXT));
			}
			if (SuportedExt.Contains("glGenTexturesEXT"))
			{
				dgtk.OpenGL.internalGLes.glGenTexturesEXT = (dgtk.OpenGL.delegatesGLes.glGenTexturesEXT) InternalTool.GetGLesMethodAdress("glGenTexturesEXT", typeof(dgtk.OpenGL.delegatesGLes.glGenTexturesEXT));
			}
			if (SuportedExt.Contains("glGenTransformFeedbacksNV"))
			{
				dgtk.OpenGL.internalGLes.glGenTransformFeedbacksNV = (dgtk.OpenGL.delegatesGLes.glGenTransformFeedbacksNV) InternalTool.GetGLesMethodAdress("glGenTransformFeedbacksNV", typeof(dgtk.OpenGL.delegatesGLes.glGenTransformFeedbacksNV));
			}
			if (SuportedExt.Contains("glGenVertexArraysAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glGenVertexArraysAPPLE = (dgtk.OpenGL.delegatesGLes.glGenVertexArraysAPPLE) InternalTool.GetGLesMethodAdress("glGenVertexArraysAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glGenVertexArraysAPPLE));
			}
			if (SuportedExt.Contains("glGenVertexArraysOES"))
			{
				dgtk.OpenGL.internalGLes.glGenVertexArraysOES = (dgtk.OpenGL.delegatesGLes.glGenVertexArraysOES) InternalTool.GetGLesMethodAdress("glGenVertexArraysOES", typeof(dgtk.OpenGL.delegatesGLes.glGenVertexArraysOES));
			}
			if (SuportedExt.Contains("glGenVertexShadersEXT"))
			{
				dgtk.OpenGL.internalGLes.glGenVertexShadersEXT = (dgtk.OpenGL.delegatesGLes.glGenVertexShadersEXT) InternalTool.GetGLesMethodAdress("glGenVertexShadersEXT", typeof(dgtk.OpenGL.delegatesGLes.glGenVertexShadersEXT));
			}
			if (SuportedExt.Contains("glGetActiveAttribARB"))
			{
				dgtk.OpenGL.internalGLes.glGetActiveAttribARB = (dgtk.OpenGL.delegatesGLes.glGetActiveAttribARB) InternalTool.GetGLesMethodAdress("glGetActiveAttribARB", typeof(dgtk.OpenGL.delegatesGLes.glGetActiveAttribARB));
			}
			if (SuportedExt.Contains("glGetActiveUniformARB"))
			{
				dgtk.OpenGL.internalGLes.glGetActiveUniformARB = (dgtk.OpenGL.delegatesGLes.glGetActiveUniformARB) InternalTool.GetGLesMethodAdress("glGetActiveUniformARB", typeof(dgtk.OpenGL.delegatesGLes.glGetActiveUniformARB));
			}
			if (SuportedExt.Contains("glGetActiveVaryingNV"))
			{
				dgtk.OpenGL.internalGLes.glGetActiveVaryingNV = (dgtk.OpenGL.delegatesGLes.glGetActiveVaryingNV) InternalTool.GetGLesMethodAdress("glGetActiveVaryingNV", typeof(dgtk.OpenGL.delegatesGLes.glGetActiveVaryingNV));
			}
			if (SuportedExt.Contains("glGetArrayObjectfvATI"))
			{
				dgtk.OpenGL.internalGLes.glGetArrayObjectfvATI = (dgtk.OpenGL.delegatesGLes.glGetArrayObjectfvATI) InternalTool.GetGLesMethodAdress("glGetArrayObjectfvATI", typeof(dgtk.OpenGL.delegatesGLes.glGetArrayObjectfvATI));
			}
			if (SuportedExt.Contains("glGetArrayObjectivATI"))
			{
				dgtk.OpenGL.internalGLes.glGetArrayObjectivATI = (dgtk.OpenGL.delegatesGLes.glGetArrayObjectivATI) InternalTool.GetGLesMethodAdress("glGetArrayObjectivATI", typeof(dgtk.OpenGL.delegatesGLes.glGetArrayObjectivATI));
			}
			if (SuportedExt.Contains("glGetAttachedObjectsARB"))
			{
				dgtk.OpenGL.internalGLes.glGetAttachedObjectsARB = (dgtk.OpenGL.delegatesGLes.glGetAttachedObjectsARB) InternalTool.GetGLesMethodAdress("glGetAttachedObjectsARB", typeof(dgtk.OpenGL.delegatesGLes.glGetAttachedObjectsARB));
			}
			if (SuportedExt.Contains("glGetAttribLocationARB"))
			{
				dgtk.OpenGL.internalGLes.glGetAttribLocationARB = (dgtk.OpenGL.delegatesGLes.glGetAttribLocationARB) InternalTool.GetGLesMethodAdress("glGetAttribLocationARB", typeof(dgtk.OpenGL.delegatesGLes.glGetAttribLocationARB));
			}
			if (SuportedExt.Contains("glGetBooleanIndexedvEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetBooleanIndexedvEXT = (dgtk.OpenGL.delegatesGLes.glGetBooleanIndexedvEXT) InternalTool.GetGLesMethodAdress("glGetBooleanIndexedvEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetBooleanIndexedvEXT));
			}
			if (SuportedExt.Contains("glGetBufferParameterivARB"))
			{
				dgtk.OpenGL.internalGLes.glGetBufferParameterivARB = (dgtk.OpenGL.delegatesGLes.glGetBufferParameterivARB) InternalTool.GetGLesMethodAdress("glGetBufferParameterivARB", typeof(dgtk.OpenGL.delegatesGLes.glGetBufferParameterivARB));
			}
			if (SuportedExt.Contains("glGetBufferParameterui64vNV"))
			{
				dgtk.OpenGL.internalGLes.glGetBufferParameterui64vNV = (dgtk.OpenGL.delegatesGLes.glGetBufferParameterui64vNV) InternalTool.GetGLesMethodAdress("glGetBufferParameterui64vNV", typeof(dgtk.OpenGL.delegatesGLes.glGetBufferParameterui64vNV));
			}
			if (SuportedExt.Contains("glGetBufferPointervARB"))
			{
				dgtk.OpenGL.internalGLes.glGetBufferPointervARB = (dgtk.OpenGL.delegatesGLes.glGetBufferPointervARB) InternalTool.GetGLesMethodAdress("glGetBufferPointervARB", typeof(dgtk.OpenGL.delegatesGLes.glGetBufferPointervARB));
			}
			if (SuportedExt.Contains("glGetBufferPointervOES"))
			{
				dgtk.OpenGL.internalGLes.glGetBufferPointervOES = (dgtk.OpenGL.delegatesGLes.glGetBufferPointervOES) InternalTool.GetGLesMethodAdress("glGetBufferPointervOES", typeof(dgtk.OpenGL.delegatesGLes.glGetBufferPointervOES));
			}
			if (SuportedExt.Contains("glGetBufferSubDataARB"))
			{
				dgtk.OpenGL.internalGLes.glGetBufferSubDataARB = (dgtk.OpenGL.delegatesGLes.glGetBufferSubDataARB) InternalTool.GetGLesMethodAdress("glGetBufferSubDataARB", typeof(dgtk.OpenGL.delegatesGLes.glGetBufferSubDataARB));
			}
			if (SuportedExt.Contains("glGetClipPlanef"))
			{
				dgtk.OpenGL.internalGLes.glGetClipPlanef = (dgtk.OpenGL.delegatesGLes.glGetClipPlanef) InternalTool.GetGLesMethodAdress("glGetClipPlanef", typeof(dgtk.OpenGL.delegatesGLes.glGetClipPlanef));
			}
			if (SuportedExt.Contains("glGetClipPlanefOES"))
			{
				dgtk.OpenGL.internalGLes.glGetClipPlanefOES = (dgtk.OpenGL.delegatesGLes.glGetClipPlanefOES) InternalTool.GetGLesMethodAdress("glGetClipPlanefOES", typeof(dgtk.OpenGL.delegatesGLes.glGetClipPlanefOES));
			}
			if (SuportedExt.Contains("glGetClipPlanex"))
			{
				dgtk.OpenGL.internalGLes.glGetClipPlanex = (dgtk.OpenGL.delegatesGLes.glGetClipPlanex) InternalTool.GetGLesMethodAdress("glGetClipPlanex", typeof(dgtk.OpenGL.delegatesGLes.glGetClipPlanex));
			}
			if (SuportedExt.Contains("glGetClipPlanexOES"))
			{
				dgtk.OpenGL.internalGLes.glGetClipPlanexOES = (dgtk.OpenGL.delegatesGLes.glGetClipPlanexOES) InternalTool.GetGLesMethodAdress("glGetClipPlanexOES", typeof(dgtk.OpenGL.delegatesGLes.glGetClipPlanexOES));
			}
			if (SuportedExt.Contains("glGetColorTable"))
			{
				dgtk.OpenGL.internalGLes.glGetColorTable = (dgtk.OpenGL.delegatesGLes.glGetColorTable) InternalTool.GetGLesMethodAdress("glGetColorTable", typeof(dgtk.OpenGL.delegatesGLes.glGetColorTable));
			}
			if (SuportedExt.Contains("glGetColorTableEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetColorTableEXT = (dgtk.OpenGL.delegatesGLes.glGetColorTableEXT) InternalTool.GetGLesMethodAdress("glGetColorTableEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetColorTableEXT));
			}
			if (SuportedExt.Contains("glGetColorTableParameterfv"))
			{
				dgtk.OpenGL.internalGLes.glGetColorTableParameterfv = (dgtk.OpenGL.delegatesGLes.glGetColorTableParameterfv) InternalTool.GetGLesMethodAdress("glGetColorTableParameterfv", typeof(dgtk.OpenGL.delegatesGLes.glGetColorTableParameterfv));
			}
			if (SuportedExt.Contains("glGetColorTableParameterfvEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetColorTableParameterfvEXT = (dgtk.OpenGL.delegatesGLes.glGetColorTableParameterfvEXT) InternalTool.GetGLesMethodAdress("glGetColorTableParameterfvEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetColorTableParameterfvEXT));
			}
			if (SuportedExt.Contains("glGetColorTableParameterfvSGI"))
			{
				dgtk.OpenGL.internalGLes.glGetColorTableParameterfvSGI = (dgtk.OpenGL.delegatesGLes.glGetColorTableParameterfvSGI) InternalTool.GetGLesMethodAdress("glGetColorTableParameterfvSGI", typeof(dgtk.OpenGL.delegatesGLes.glGetColorTableParameterfvSGI));
			}
			if (SuportedExt.Contains("glGetColorTableParameteriv"))
			{
				dgtk.OpenGL.internalGLes.glGetColorTableParameteriv = (dgtk.OpenGL.delegatesGLes.glGetColorTableParameteriv) InternalTool.GetGLesMethodAdress("glGetColorTableParameteriv", typeof(dgtk.OpenGL.delegatesGLes.glGetColorTableParameteriv));
			}
			if (SuportedExt.Contains("glGetColorTableParameterivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetColorTableParameterivEXT = (dgtk.OpenGL.delegatesGLes.glGetColorTableParameterivEXT) InternalTool.GetGLesMethodAdress("glGetColorTableParameterivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetColorTableParameterivEXT));
			}
			if (SuportedExt.Contains("glGetColorTableParameterivSGI"))
			{
				dgtk.OpenGL.internalGLes.glGetColorTableParameterivSGI = (dgtk.OpenGL.delegatesGLes.glGetColorTableParameterivSGI) InternalTool.GetGLesMethodAdress("glGetColorTableParameterivSGI", typeof(dgtk.OpenGL.delegatesGLes.glGetColorTableParameterivSGI));
			}
			if (SuportedExt.Contains("glGetColorTableSGI"))
			{
				dgtk.OpenGL.internalGLes.glGetColorTableSGI = (dgtk.OpenGL.delegatesGLes.glGetColorTableSGI) InternalTool.GetGLesMethodAdress("glGetColorTableSGI", typeof(dgtk.OpenGL.delegatesGLes.glGetColorTableSGI));
			}
			if (SuportedExt.Contains("glGetCombinerInputParameterfvNV"))
			{
				dgtk.OpenGL.internalGLes.glGetCombinerInputParameterfvNV = (dgtk.OpenGL.delegatesGLes.glGetCombinerInputParameterfvNV) InternalTool.GetGLesMethodAdress("glGetCombinerInputParameterfvNV", typeof(dgtk.OpenGL.delegatesGLes.glGetCombinerInputParameterfvNV));
			}
			if (SuportedExt.Contains("glGetCombinerInputParameterivNV"))
			{
				dgtk.OpenGL.internalGLes.glGetCombinerInputParameterivNV = (dgtk.OpenGL.delegatesGLes.glGetCombinerInputParameterivNV) InternalTool.GetGLesMethodAdress("glGetCombinerInputParameterivNV", typeof(dgtk.OpenGL.delegatesGLes.glGetCombinerInputParameterivNV));
			}
			if (SuportedExt.Contains("glGetCombinerOutputParameterfvNV"))
			{
				dgtk.OpenGL.internalGLes.glGetCombinerOutputParameterfvNV = (dgtk.OpenGL.delegatesGLes.glGetCombinerOutputParameterfvNV) InternalTool.GetGLesMethodAdress("glGetCombinerOutputParameterfvNV", typeof(dgtk.OpenGL.delegatesGLes.glGetCombinerOutputParameterfvNV));
			}
			if (SuportedExt.Contains("glGetCombinerOutputParameterivNV"))
			{
				dgtk.OpenGL.internalGLes.glGetCombinerOutputParameterivNV = (dgtk.OpenGL.delegatesGLes.glGetCombinerOutputParameterivNV) InternalTool.GetGLesMethodAdress("glGetCombinerOutputParameterivNV", typeof(dgtk.OpenGL.delegatesGLes.glGetCombinerOutputParameterivNV));
			}
			if (SuportedExt.Contains("glGetCombinerStageParameterfvNV"))
			{
				dgtk.OpenGL.internalGLes.glGetCombinerStageParameterfvNV = (dgtk.OpenGL.delegatesGLes.glGetCombinerStageParameterfvNV) InternalTool.GetGLesMethodAdress("glGetCombinerStageParameterfvNV", typeof(dgtk.OpenGL.delegatesGLes.glGetCombinerStageParameterfvNV));
			}
			if (SuportedExt.Contains("glGetCommandHeaderNV"))
			{
				dgtk.OpenGL.internalGLes.glGetCommandHeaderNV = (dgtk.OpenGL.delegatesGLes.glGetCommandHeaderNV) InternalTool.GetGLesMethodAdress("glGetCommandHeaderNV", typeof(dgtk.OpenGL.delegatesGLes.glGetCommandHeaderNV));
			}
			if (SuportedExt.Contains("glGetCompressedMultiTexImageEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetCompressedMultiTexImageEXT = (dgtk.OpenGL.delegatesGLes.glGetCompressedMultiTexImageEXT) InternalTool.GetGLesMethodAdress("glGetCompressedMultiTexImageEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetCompressedMultiTexImageEXT));
			}
			if (SuportedExt.Contains("glGetCompressedTexImageARB"))
			{
				dgtk.OpenGL.internalGLes.glGetCompressedTexImageARB = (dgtk.OpenGL.delegatesGLes.glGetCompressedTexImageARB) InternalTool.GetGLesMethodAdress("glGetCompressedTexImageARB", typeof(dgtk.OpenGL.delegatesGLes.glGetCompressedTexImageARB));
			}
			if (SuportedExt.Contains("glGetCompressedTextureImageEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetCompressedTextureImageEXT = (dgtk.OpenGL.delegatesGLes.glGetCompressedTextureImageEXT) InternalTool.GetGLesMethodAdress("glGetCompressedTextureImageEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetCompressedTextureImageEXT));
			}
			if (SuportedExt.Contains("glGetConvolutionFilter"))
			{
				dgtk.OpenGL.internalGLes.glGetConvolutionFilter = (dgtk.OpenGL.delegatesGLes.glGetConvolutionFilter) InternalTool.GetGLesMethodAdress("glGetConvolutionFilter", typeof(dgtk.OpenGL.delegatesGLes.glGetConvolutionFilter));
			}
			if (SuportedExt.Contains("glGetConvolutionFilterEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetConvolutionFilterEXT = (dgtk.OpenGL.delegatesGLes.glGetConvolutionFilterEXT) InternalTool.GetGLesMethodAdress("glGetConvolutionFilterEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetConvolutionFilterEXT));
			}
			if (SuportedExt.Contains("glGetConvolutionParameterfv"))
			{
				dgtk.OpenGL.internalGLes.glGetConvolutionParameterfv = (dgtk.OpenGL.delegatesGLes.glGetConvolutionParameterfv) InternalTool.GetGLesMethodAdress("glGetConvolutionParameterfv", typeof(dgtk.OpenGL.delegatesGLes.glGetConvolutionParameterfv));
			}
			if (SuportedExt.Contains("glGetConvolutionParameterfvEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetConvolutionParameterfvEXT = (dgtk.OpenGL.delegatesGLes.glGetConvolutionParameterfvEXT) InternalTool.GetGLesMethodAdress("glGetConvolutionParameterfvEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetConvolutionParameterfvEXT));
			}
			if (SuportedExt.Contains("glGetConvolutionParameteriv"))
			{
				dgtk.OpenGL.internalGLes.glGetConvolutionParameteriv = (dgtk.OpenGL.delegatesGLes.glGetConvolutionParameteriv) InternalTool.GetGLesMethodAdress("glGetConvolutionParameteriv", typeof(dgtk.OpenGL.delegatesGLes.glGetConvolutionParameteriv));
			}
			if (SuportedExt.Contains("glGetConvolutionParameterivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetConvolutionParameterivEXT = (dgtk.OpenGL.delegatesGLes.glGetConvolutionParameterivEXT) InternalTool.GetGLesMethodAdress("glGetConvolutionParameterivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetConvolutionParameterivEXT));
			}
			if (SuportedExt.Contains("glGetConvolutionParameterxvOES"))
			{
				dgtk.OpenGL.internalGLes.glGetConvolutionParameterxvOES = (dgtk.OpenGL.delegatesGLes.glGetConvolutionParameterxvOES) InternalTool.GetGLesMethodAdress("glGetConvolutionParameterxvOES", typeof(dgtk.OpenGL.delegatesGLes.glGetConvolutionParameterxvOES));
			}
			if (SuportedExt.Contains("glGetCoverageModulationTableNV"))
			{
				dgtk.OpenGL.internalGLes.glGetCoverageModulationTableNV = (dgtk.OpenGL.delegatesGLes.glGetCoverageModulationTableNV) InternalTool.GetGLesMethodAdress("glGetCoverageModulationTableNV", typeof(dgtk.OpenGL.delegatesGLes.glGetCoverageModulationTableNV));
			}
			if (SuportedExt.Contains("glGetDebugMessageLogAMD"))
			{
				dgtk.OpenGL.internalGLes.glGetDebugMessageLogAMD = (dgtk.OpenGL.delegatesGLes.glGetDebugMessageLogAMD) InternalTool.GetGLesMethodAdress("glGetDebugMessageLogAMD", typeof(dgtk.OpenGL.delegatesGLes.glGetDebugMessageLogAMD));
			}
			if (SuportedExt.Contains("glGetDebugMessageLogARB"))
			{
				dgtk.OpenGL.internalGLes.glGetDebugMessageLogARB = (dgtk.OpenGL.delegatesGLes.glGetDebugMessageLogARB) InternalTool.GetGLesMethodAdress("glGetDebugMessageLogARB", typeof(dgtk.OpenGL.delegatesGLes.glGetDebugMessageLogARB));
			}
			if (SuportedExt.Contains("glGetDebugMessageLogKHR"))
			{
				dgtk.OpenGL.internalGLes.glGetDebugMessageLogKHR = (dgtk.OpenGL.delegatesGLes.glGetDebugMessageLogKHR) InternalTool.GetGLesMethodAdress("glGetDebugMessageLogKHR", typeof(dgtk.OpenGL.delegatesGLes.glGetDebugMessageLogKHR));
			}
			if (SuportedExt.Contains("glGetDetailTexFuncSGIS"))
			{
				dgtk.OpenGL.internalGLes.glGetDetailTexFuncSGIS = (dgtk.OpenGL.delegatesGLes.glGetDetailTexFuncSGIS) InternalTool.GetGLesMethodAdress("glGetDetailTexFuncSGIS", typeof(dgtk.OpenGL.delegatesGLes.glGetDetailTexFuncSGIS));
			}
			if (SuportedExt.Contains("glGetDoublei_vEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetDoublei_vEXT = (dgtk.OpenGL.delegatesGLes.glGetDoublei_vEXT) InternalTool.GetGLesMethodAdress("glGetDoublei_vEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetDoublei_vEXT));
			}
			if (SuportedExt.Contains("glGetDoubleIndexedvEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetDoubleIndexedvEXT = (dgtk.OpenGL.delegatesGLes.glGetDoubleIndexedvEXT) InternalTool.GetGLesMethodAdress("glGetDoubleIndexedvEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetDoubleIndexedvEXT));
			}
			if (SuportedExt.Contains("glGetDriverControlsQCOM"))
			{
				dgtk.OpenGL.internalGLes.glGetDriverControlsQCOM = (dgtk.OpenGL.delegatesGLes.glGetDriverControlsQCOM) InternalTool.GetGLesMethodAdress("glGetDriverControlsQCOM", typeof(dgtk.OpenGL.delegatesGLes.glGetDriverControlsQCOM));
			}
			if (SuportedExt.Contains("glGetDriverControlStringQCOM"))
			{
				dgtk.OpenGL.internalGLes.glGetDriverControlStringQCOM = (dgtk.OpenGL.delegatesGLes.glGetDriverControlStringQCOM) InternalTool.GetGLesMethodAdress("glGetDriverControlStringQCOM", typeof(dgtk.OpenGL.delegatesGLes.glGetDriverControlStringQCOM));
			}
			if (SuportedExt.Contains("glGetFenceivNV"))
			{
				dgtk.OpenGL.internalGLes.glGetFenceivNV = (dgtk.OpenGL.delegatesGLes.glGetFenceivNV) InternalTool.GetGLesMethodAdress("glGetFenceivNV", typeof(dgtk.OpenGL.delegatesGLes.glGetFenceivNV));
			}
			if (SuportedExt.Contains("glGetFinalCombinerInputParameterfvNV"))
			{
				dgtk.OpenGL.internalGLes.glGetFinalCombinerInputParameterfvNV = (dgtk.OpenGL.delegatesGLes.glGetFinalCombinerInputParameterfvNV) InternalTool.GetGLesMethodAdress("glGetFinalCombinerInputParameterfvNV", typeof(dgtk.OpenGL.delegatesGLes.glGetFinalCombinerInputParameterfvNV));
			}
			if (SuportedExt.Contains("glGetFinalCombinerInputParameterivNV"))
			{
				dgtk.OpenGL.internalGLes.glGetFinalCombinerInputParameterivNV = (dgtk.OpenGL.delegatesGLes.glGetFinalCombinerInputParameterivNV) InternalTool.GetGLesMethodAdress("glGetFinalCombinerInputParameterivNV", typeof(dgtk.OpenGL.delegatesGLes.glGetFinalCombinerInputParameterivNV));
			}
			if (SuportedExt.Contains("glGetFirstPerfQueryIdINTEL"))
			{
				dgtk.OpenGL.internalGLes.glGetFirstPerfQueryIdINTEL = (dgtk.OpenGL.delegatesGLes.glGetFirstPerfQueryIdINTEL) InternalTool.GetGLesMethodAdress("glGetFirstPerfQueryIdINTEL", typeof(dgtk.OpenGL.delegatesGLes.glGetFirstPerfQueryIdINTEL));
			}
			if (SuportedExt.Contains("glGetFixedv"))
			{
				dgtk.OpenGL.internalGLes.glGetFixedv = (dgtk.OpenGL.delegatesGLes.glGetFixedv) InternalTool.GetGLesMethodAdress("glGetFixedv", typeof(dgtk.OpenGL.delegatesGLes.glGetFixedv));
			}
			if (SuportedExt.Contains("glGetFixedvOES"))
			{
				dgtk.OpenGL.internalGLes.glGetFixedvOES = (dgtk.OpenGL.delegatesGLes.glGetFixedvOES) InternalTool.GetGLesMethodAdress("glGetFixedvOES", typeof(dgtk.OpenGL.delegatesGLes.glGetFixedvOES));
			}
			if (SuportedExt.Contains("glGetFloati_vEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetFloati_vEXT = (dgtk.OpenGL.delegatesGLes.glGetFloati_vEXT) InternalTool.GetGLesMethodAdress("glGetFloati_vEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetFloati_vEXT));
			}
			if (SuportedExt.Contains("glGetFloati_vNV"))
			{
				dgtk.OpenGL.internalGLes.glGetFloati_vNV = (dgtk.OpenGL.delegatesGLes.glGetFloati_vNV) InternalTool.GetGLesMethodAdress("glGetFloati_vNV", typeof(dgtk.OpenGL.delegatesGLes.glGetFloati_vNV));
			}
			if (SuportedExt.Contains("glGetFloati_vOES"))
			{
				dgtk.OpenGL.internalGLes.glGetFloati_vOES = (dgtk.OpenGL.delegatesGLes.glGetFloati_vOES) InternalTool.GetGLesMethodAdress("glGetFloati_vOES", typeof(dgtk.OpenGL.delegatesGLes.glGetFloati_vOES));
			}
			if (SuportedExt.Contains("glGetFloatIndexedvEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetFloatIndexedvEXT = (dgtk.OpenGL.delegatesGLes.glGetFloatIndexedvEXT) InternalTool.GetGLesMethodAdress("glGetFloatIndexedvEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetFloatIndexedvEXT));
			}
			if (SuportedExt.Contains("glGetFogFuncSGIS"))
			{
				dgtk.OpenGL.internalGLes.glGetFogFuncSGIS = (dgtk.OpenGL.delegatesGLes.glGetFogFuncSGIS) InternalTool.GetGLesMethodAdress("glGetFogFuncSGIS", typeof(dgtk.OpenGL.delegatesGLes.glGetFogFuncSGIS));
			}
			if (SuportedExt.Contains("glGetFragDataIndexEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetFragDataIndexEXT = (dgtk.OpenGL.delegatesGLes.glGetFragDataIndexEXT) InternalTool.GetGLesMethodAdress("glGetFragDataIndexEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetFragDataIndexEXT));
			}
			if (SuportedExt.Contains("glGetFragDataLocationEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetFragDataLocationEXT = (dgtk.OpenGL.delegatesGLes.glGetFragDataLocationEXT) InternalTool.GetGLesMethodAdress("glGetFragDataLocationEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetFragDataLocationEXT));
			}
			if (SuportedExt.Contains("glGetFragmentLightfvSGIX"))
			{
				dgtk.OpenGL.internalGLes.glGetFragmentLightfvSGIX = (dgtk.OpenGL.delegatesGLes.glGetFragmentLightfvSGIX) InternalTool.GetGLesMethodAdress("glGetFragmentLightfvSGIX", typeof(dgtk.OpenGL.delegatesGLes.glGetFragmentLightfvSGIX));
			}
			if (SuportedExt.Contains("glGetFragmentLightivSGIX"))
			{
				dgtk.OpenGL.internalGLes.glGetFragmentLightivSGIX = (dgtk.OpenGL.delegatesGLes.glGetFragmentLightivSGIX) InternalTool.GetGLesMethodAdress("glGetFragmentLightivSGIX", typeof(dgtk.OpenGL.delegatesGLes.glGetFragmentLightivSGIX));
			}
			if (SuportedExt.Contains("glGetFragmentMaterialfvSGIX"))
			{
				dgtk.OpenGL.internalGLes.glGetFragmentMaterialfvSGIX = (dgtk.OpenGL.delegatesGLes.glGetFragmentMaterialfvSGIX) InternalTool.GetGLesMethodAdress("glGetFragmentMaterialfvSGIX", typeof(dgtk.OpenGL.delegatesGLes.glGetFragmentMaterialfvSGIX));
			}
			if (SuportedExt.Contains("glGetFragmentMaterialivSGIX"))
			{
				dgtk.OpenGL.internalGLes.glGetFragmentMaterialivSGIX = (dgtk.OpenGL.delegatesGLes.glGetFragmentMaterialivSGIX) InternalTool.GetGLesMethodAdress("glGetFragmentMaterialivSGIX", typeof(dgtk.OpenGL.delegatesGLes.glGetFragmentMaterialivSGIX));
			}
			if (SuportedExt.Contains("glGetFramebufferAttachmentParameterivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetFramebufferAttachmentParameterivEXT = (dgtk.OpenGL.delegatesGLes.glGetFramebufferAttachmentParameterivEXT) InternalTool.GetGLesMethodAdress("glGetFramebufferAttachmentParameterivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetFramebufferAttachmentParameterivEXT));
			}
			if (SuportedExt.Contains("glGetFramebufferAttachmentParameterivOES"))
			{
				dgtk.OpenGL.internalGLes.glGetFramebufferAttachmentParameterivOES = (dgtk.OpenGL.delegatesGLes.glGetFramebufferAttachmentParameterivOES) InternalTool.GetGLesMethodAdress("glGetFramebufferAttachmentParameterivOES", typeof(dgtk.OpenGL.delegatesGLes.glGetFramebufferAttachmentParameterivOES));
			}
			if (SuportedExt.Contains("glGetFramebufferParameterfvAMD"))
			{
				dgtk.OpenGL.internalGLes.glGetFramebufferParameterfvAMD = (dgtk.OpenGL.delegatesGLes.glGetFramebufferParameterfvAMD) InternalTool.GetGLesMethodAdress("glGetFramebufferParameterfvAMD", typeof(dgtk.OpenGL.delegatesGLes.glGetFramebufferParameterfvAMD));
			}
			if (SuportedExt.Contains("glGetFramebufferParameterivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetFramebufferParameterivEXT = (dgtk.OpenGL.delegatesGLes.glGetFramebufferParameterivEXT) InternalTool.GetGLesMethodAdress("glGetFramebufferParameterivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetFramebufferParameterivEXT));
			}
			if (SuportedExt.Contains("glGetFramebufferParameterivMESA"))
			{
				dgtk.OpenGL.internalGLes.glGetFramebufferParameterivMESA = (dgtk.OpenGL.delegatesGLes.glGetFramebufferParameterivMESA) InternalTool.GetGLesMethodAdress("glGetFramebufferParameterivMESA", typeof(dgtk.OpenGL.delegatesGLes.glGetFramebufferParameterivMESA));
			}
			if (SuportedExt.Contains("glGetFramebufferPixelLocalStorageSizeEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetFramebufferPixelLocalStorageSizeEXT = (dgtk.OpenGL.delegatesGLes.glGetFramebufferPixelLocalStorageSizeEXT) InternalTool.GetGLesMethodAdress("glGetFramebufferPixelLocalStorageSizeEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetFramebufferPixelLocalStorageSizeEXT));
			}
			if (SuportedExt.Contains("glGetGraphicsResetStatusARB"))
			{
				dgtk.OpenGL.internalGLes.glGetGraphicsResetStatusARB = (dgtk.OpenGL.delegatesGLes.glGetGraphicsResetStatusARB) InternalTool.GetGLesMethodAdress("glGetGraphicsResetStatusARB", typeof(dgtk.OpenGL.delegatesGLes.glGetGraphicsResetStatusARB));
			}
			if (SuportedExt.Contains("glGetGraphicsResetStatusEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetGraphicsResetStatusEXT = (dgtk.OpenGL.delegatesGLes.glGetGraphicsResetStatusEXT) InternalTool.GetGLesMethodAdress("glGetGraphicsResetStatusEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetGraphicsResetStatusEXT));
			}
			if (SuportedExt.Contains("glGetGraphicsResetStatusKHR"))
			{
				dgtk.OpenGL.internalGLes.glGetGraphicsResetStatusKHR = (dgtk.OpenGL.delegatesGLes.glGetGraphicsResetStatusKHR) InternalTool.GetGLesMethodAdress("glGetGraphicsResetStatusKHR", typeof(dgtk.OpenGL.delegatesGLes.glGetGraphicsResetStatusKHR));
			}
			if (SuportedExt.Contains("glGetHandleARB"))
			{
				dgtk.OpenGL.internalGLes.glGetHandleARB = (dgtk.OpenGL.delegatesGLes.glGetHandleARB) InternalTool.GetGLesMethodAdress("glGetHandleARB", typeof(dgtk.OpenGL.delegatesGLes.glGetHandleARB));
			}
			if (SuportedExt.Contains("glGetHistogram"))
			{
				dgtk.OpenGL.internalGLes.glGetHistogram = (dgtk.OpenGL.delegatesGLes.glGetHistogram) InternalTool.GetGLesMethodAdress("glGetHistogram", typeof(dgtk.OpenGL.delegatesGLes.glGetHistogram));
			}
			if (SuportedExt.Contains("glGetHistogramEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetHistogramEXT = (dgtk.OpenGL.delegatesGLes.glGetHistogramEXT) InternalTool.GetGLesMethodAdress("glGetHistogramEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetHistogramEXT));
			}
			if (SuportedExt.Contains("glGetHistogramParameterfv"))
			{
				dgtk.OpenGL.internalGLes.glGetHistogramParameterfv = (dgtk.OpenGL.delegatesGLes.glGetHistogramParameterfv) InternalTool.GetGLesMethodAdress("glGetHistogramParameterfv", typeof(dgtk.OpenGL.delegatesGLes.glGetHistogramParameterfv));
			}
			if (SuportedExt.Contains("glGetHistogramParameterfvEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetHistogramParameterfvEXT = (dgtk.OpenGL.delegatesGLes.glGetHistogramParameterfvEXT) InternalTool.GetGLesMethodAdress("glGetHistogramParameterfvEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetHistogramParameterfvEXT));
			}
			if (SuportedExt.Contains("glGetHistogramParameteriv"))
			{
				dgtk.OpenGL.internalGLes.glGetHistogramParameteriv = (dgtk.OpenGL.delegatesGLes.glGetHistogramParameteriv) InternalTool.GetGLesMethodAdress("glGetHistogramParameteriv", typeof(dgtk.OpenGL.delegatesGLes.glGetHistogramParameteriv));
			}
			if (SuportedExt.Contains("glGetHistogramParameterivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetHistogramParameterivEXT = (dgtk.OpenGL.delegatesGLes.glGetHistogramParameterivEXT) InternalTool.GetGLesMethodAdress("glGetHistogramParameterivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetHistogramParameterivEXT));
			}
			if (SuportedExt.Contains("glGetHistogramParameterxvOES"))
			{
				dgtk.OpenGL.internalGLes.glGetHistogramParameterxvOES = (dgtk.OpenGL.delegatesGLes.glGetHistogramParameterxvOES) InternalTool.GetGLesMethodAdress("glGetHistogramParameterxvOES", typeof(dgtk.OpenGL.delegatesGLes.glGetHistogramParameterxvOES));
			}
			if (SuportedExt.Contains("glGetImageHandleARB"))
			{
				dgtk.OpenGL.internalGLes.glGetImageHandleARB = (dgtk.OpenGL.delegatesGLes.glGetImageHandleARB) InternalTool.GetGLesMethodAdress("glGetImageHandleARB", typeof(dgtk.OpenGL.delegatesGLes.glGetImageHandleARB));
			}
			if (SuportedExt.Contains("glGetImageHandleNV"))
			{
				dgtk.OpenGL.internalGLes.glGetImageHandleNV = (dgtk.OpenGL.delegatesGLes.glGetImageHandleNV) InternalTool.GetGLesMethodAdress("glGetImageHandleNV", typeof(dgtk.OpenGL.delegatesGLes.glGetImageHandleNV));
			}
			if (SuportedExt.Contains("glGetImageTransformParameterfvHP"))
			{
				dgtk.OpenGL.internalGLes.glGetImageTransformParameterfvHP = (dgtk.OpenGL.delegatesGLes.glGetImageTransformParameterfvHP) InternalTool.GetGLesMethodAdress("glGetImageTransformParameterfvHP", typeof(dgtk.OpenGL.delegatesGLes.glGetImageTransformParameterfvHP));
			}
			if (SuportedExt.Contains("glGetImageTransformParameterivHP"))
			{
				dgtk.OpenGL.internalGLes.glGetImageTransformParameterivHP = (dgtk.OpenGL.delegatesGLes.glGetImageTransformParameterivHP) InternalTool.GetGLesMethodAdress("glGetImageTransformParameterivHP", typeof(dgtk.OpenGL.delegatesGLes.glGetImageTransformParameterivHP));
			}
			if (SuportedExt.Contains("glGetInfoLogARB"))
			{
				dgtk.OpenGL.internalGLes.glGetInfoLogARB = (dgtk.OpenGL.delegatesGLes.glGetInfoLogARB) InternalTool.GetGLesMethodAdress("glGetInfoLogARB", typeof(dgtk.OpenGL.delegatesGLes.glGetInfoLogARB));
			}
			if (SuportedExt.Contains("glGetInstrumentsSGIX"))
			{
				dgtk.OpenGL.internalGLes.glGetInstrumentsSGIX = (dgtk.OpenGL.delegatesGLes.glGetInstrumentsSGIX) InternalTool.GetGLesMethodAdress("glGetInstrumentsSGIX", typeof(dgtk.OpenGL.delegatesGLes.glGetInstrumentsSGIX));
			}
			if (SuportedExt.Contains("glGetInteger64vAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glGetInteger64vAPPLE = (dgtk.OpenGL.delegatesGLes.glGetInteger64vAPPLE) InternalTool.GetGLesMethodAdress("glGetInteger64vAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glGetInteger64vAPPLE));
			}
			if (SuportedExt.Contains("glGetInteger64vEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetInteger64vEXT = (dgtk.OpenGL.delegatesGLes.glGetInteger64vEXT) InternalTool.GetGLesMethodAdress("glGetInteger64vEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetInteger64vEXT));
			}
			if (SuportedExt.Contains("glGetIntegeri_vEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetIntegeri_vEXT = (dgtk.OpenGL.delegatesGLes.glGetIntegeri_vEXT) InternalTool.GetGLesMethodAdress("glGetIntegeri_vEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetIntegeri_vEXT));
			}
			if (SuportedExt.Contains("glGetIntegerIndexedvEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetIntegerIndexedvEXT = (dgtk.OpenGL.delegatesGLes.glGetIntegerIndexedvEXT) InternalTool.GetGLesMethodAdress("glGetIntegerIndexedvEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetIntegerIndexedvEXT));
			}
			if (SuportedExt.Contains("glGetIntegerui64i_vNV"))
			{
				dgtk.OpenGL.internalGLes.glGetIntegerui64i_vNV = (dgtk.OpenGL.delegatesGLes.glGetIntegerui64i_vNV) InternalTool.GetGLesMethodAdress("glGetIntegerui64i_vNV", typeof(dgtk.OpenGL.delegatesGLes.glGetIntegerui64i_vNV));
			}
			if (SuportedExt.Contains("glGetIntegerui64vNV"))
			{
				dgtk.OpenGL.internalGLes.glGetIntegerui64vNV = (dgtk.OpenGL.delegatesGLes.glGetIntegerui64vNV) InternalTool.GetGLesMethodAdress("glGetIntegerui64vNV", typeof(dgtk.OpenGL.delegatesGLes.glGetIntegerui64vNV));
			}
			if (SuportedExt.Contains("glGetInternalformatSampleivNV"))
			{
				dgtk.OpenGL.internalGLes.glGetInternalformatSampleivNV = (dgtk.OpenGL.delegatesGLes.glGetInternalformatSampleivNV) InternalTool.GetGLesMethodAdress("glGetInternalformatSampleivNV", typeof(dgtk.OpenGL.delegatesGLes.glGetInternalformatSampleivNV));
			}
			if (SuportedExt.Contains("glGetInvariantBooleanvEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetInvariantBooleanvEXT = (dgtk.OpenGL.delegatesGLes.glGetInvariantBooleanvEXT) InternalTool.GetGLesMethodAdress("glGetInvariantBooleanvEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetInvariantBooleanvEXT));
			}
			if (SuportedExt.Contains("glGetInvariantFloatvEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetInvariantFloatvEXT = (dgtk.OpenGL.delegatesGLes.glGetInvariantFloatvEXT) InternalTool.GetGLesMethodAdress("glGetInvariantFloatvEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetInvariantFloatvEXT));
			}
			if (SuportedExt.Contains("glGetInvariantIntegervEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetInvariantIntegervEXT = (dgtk.OpenGL.delegatesGLes.glGetInvariantIntegervEXT) InternalTool.GetGLesMethodAdress("glGetInvariantIntegervEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetInvariantIntegervEXT));
			}
			if (SuportedExt.Contains("glGetLightxOES"))
			{
				dgtk.OpenGL.internalGLes.glGetLightxOES = (dgtk.OpenGL.delegatesGLes.glGetLightxOES) InternalTool.GetGLesMethodAdress("glGetLightxOES", typeof(dgtk.OpenGL.delegatesGLes.glGetLightxOES));
			}
			if (SuportedExt.Contains("glGetLightxv"))
			{
				dgtk.OpenGL.internalGLes.glGetLightxv = (dgtk.OpenGL.delegatesGLes.glGetLightxv) InternalTool.GetGLesMethodAdress("glGetLightxv", typeof(dgtk.OpenGL.delegatesGLes.glGetLightxv));
			}
			if (SuportedExt.Contains("glGetLightxvOES"))
			{
				dgtk.OpenGL.internalGLes.glGetLightxvOES = (dgtk.OpenGL.delegatesGLes.glGetLightxvOES) InternalTool.GetGLesMethodAdress("glGetLightxvOES", typeof(dgtk.OpenGL.delegatesGLes.glGetLightxvOES));
			}
			if (SuportedExt.Contains("glGetListParameterfvSGIX"))
			{
				dgtk.OpenGL.internalGLes.glGetListParameterfvSGIX = (dgtk.OpenGL.delegatesGLes.glGetListParameterfvSGIX) InternalTool.GetGLesMethodAdress("glGetListParameterfvSGIX", typeof(dgtk.OpenGL.delegatesGLes.glGetListParameterfvSGIX));
			}
			if (SuportedExt.Contains("glGetListParameterivSGIX"))
			{
				dgtk.OpenGL.internalGLes.glGetListParameterivSGIX = (dgtk.OpenGL.delegatesGLes.glGetListParameterivSGIX) InternalTool.GetGLesMethodAdress("glGetListParameterivSGIX", typeof(dgtk.OpenGL.delegatesGLes.glGetListParameterivSGIX));
			}
			if (SuportedExt.Contains("glGetLocalConstantBooleanvEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetLocalConstantBooleanvEXT = (dgtk.OpenGL.delegatesGLes.glGetLocalConstantBooleanvEXT) InternalTool.GetGLesMethodAdress("glGetLocalConstantBooleanvEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetLocalConstantBooleanvEXT));
			}
			if (SuportedExt.Contains("glGetLocalConstantFloatvEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetLocalConstantFloatvEXT = (dgtk.OpenGL.delegatesGLes.glGetLocalConstantFloatvEXT) InternalTool.GetGLesMethodAdress("glGetLocalConstantFloatvEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetLocalConstantFloatvEXT));
			}
			if (SuportedExt.Contains("glGetLocalConstantIntegervEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetLocalConstantIntegervEXT = (dgtk.OpenGL.delegatesGLes.glGetLocalConstantIntegervEXT) InternalTool.GetGLesMethodAdress("glGetLocalConstantIntegervEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetLocalConstantIntegervEXT));
			}
			if (SuportedExt.Contains("glGetMapAttribParameterfvNV"))
			{
				dgtk.OpenGL.internalGLes.glGetMapAttribParameterfvNV = (dgtk.OpenGL.delegatesGLes.glGetMapAttribParameterfvNV) InternalTool.GetGLesMethodAdress("glGetMapAttribParameterfvNV", typeof(dgtk.OpenGL.delegatesGLes.glGetMapAttribParameterfvNV));
			}
			if (SuportedExt.Contains("glGetMapAttribParameterivNV"))
			{
				dgtk.OpenGL.internalGLes.glGetMapAttribParameterivNV = (dgtk.OpenGL.delegatesGLes.glGetMapAttribParameterivNV) InternalTool.GetGLesMethodAdress("glGetMapAttribParameterivNV", typeof(dgtk.OpenGL.delegatesGLes.glGetMapAttribParameterivNV));
			}
			if (SuportedExt.Contains("glGetMapControlPointsNV"))
			{
				dgtk.OpenGL.internalGLes.glGetMapControlPointsNV = (dgtk.OpenGL.delegatesGLes.glGetMapControlPointsNV) InternalTool.GetGLesMethodAdress("glGetMapControlPointsNV", typeof(dgtk.OpenGL.delegatesGLes.glGetMapControlPointsNV));
			}
			if (SuportedExt.Contains("glGetMapParameterfvNV"))
			{
				dgtk.OpenGL.internalGLes.glGetMapParameterfvNV = (dgtk.OpenGL.delegatesGLes.glGetMapParameterfvNV) InternalTool.GetGLesMethodAdress("glGetMapParameterfvNV", typeof(dgtk.OpenGL.delegatesGLes.glGetMapParameterfvNV));
			}
			if (SuportedExt.Contains("glGetMapParameterivNV"))
			{
				dgtk.OpenGL.internalGLes.glGetMapParameterivNV = (dgtk.OpenGL.delegatesGLes.glGetMapParameterivNV) InternalTool.GetGLesMethodAdress("glGetMapParameterivNV", typeof(dgtk.OpenGL.delegatesGLes.glGetMapParameterivNV));
			}
			if (SuportedExt.Contains("glGetMapxvOES"))
			{
				dgtk.OpenGL.internalGLes.glGetMapxvOES = (dgtk.OpenGL.delegatesGLes.glGetMapxvOES) InternalTool.GetGLesMethodAdress("glGetMapxvOES", typeof(dgtk.OpenGL.delegatesGLes.glGetMapxvOES));
			}
			if (SuportedExt.Contains("glGetMaterialxOES"))
			{
				dgtk.OpenGL.internalGLes.glGetMaterialxOES = (dgtk.OpenGL.delegatesGLes.glGetMaterialxOES) InternalTool.GetGLesMethodAdress("glGetMaterialxOES", typeof(dgtk.OpenGL.delegatesGLes.glGetMaterialxOES));
			}
			if (SuportedExt.Contains("glGetMaterialxv"))
			{
				dgtk.OpenGL.internalGLes.glGetMaterialxv = (dgtk.OpenGL.delegatesGLes.glGetMaterialxv) InternalTool.GetGLesMethodAdress("glGetMaterialxv", typeof(dgtk.OpenGL.delegatesGLes.glGetMaterialxv));
			}
			if (SuportedExt.Contains("glGetMaterialxvOES"))
			{
				dgtk.OpenGL.internalGLes.glGetMaterialxvOES = (dgtk.OpenGL.delegatesGLes.glGetMaterialxvOES) InternalTool.GetGLesMethodAdress("glGetMaterialxvOES", typeof(dgtk.OpenGL.delegatesGLes.glGetMaterialxvOES));
			}
			if (SuportedExt.Contains("glGetMemoryObjectDetachedResourcesuivNV"))
			{
				dgtk.OpenGL.internalGLes.glGetMemoryObjectDetachedResourcesuivNV = (dgtk.OpenGL.delegatesGLes.glGetMemoryObjectDetachedResourcesuivNV) InternalTool.GetGLesMethodAdress("glGetMemoryObjectDetachedResourcesuivNV", typeof(dgtk.OpenGL.delegatesGLes.glGetMemoryObjectDetachedResourcesuivNV));
			}
			if (SuportedExt.Contains("glGetMemoryObjectParameterivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetMemoryObjectParameterivEXT = (dgtk.OpenGL.delegatesGLes.glGetMemoryObjectParameterivEXT) InternalTool.GetGLesMethodAdress("glGetMemoryObjectParameterivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetMemoryObjectParameterivEXT));
			}
			if (SuportedExt.Contains("glGetMinmax"))
			{
				dgtk.OpenGL.internalGLes.glGetMinmax = (dgtk.OpenGL.delegatesGLes.glGetMinmax) InternalTool.GetGLesMethodAdress("glGetMinmax", typeof(dgtk.OpenGL.delegatesGLes.glGetMinmax));
			}
			if (SuportedExt.Contains("glGetMinmaxEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetMinmaxEXT = (dgtk.OpenGL.delegatesGLes.glGetMinmaxEXT) InternalTool.GetGLesMethodAdress("glGetMinmaxEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetMinmaxEXT));
			}
			if (SuportedExt.Contains("glGetMinmaxParameterfv"))
			{
				dgtk.OpenGL.internalGLes.glGetMinmaxParameterfv = (dgtk.OpenGL.delegatesGLes.glGetMinmaxParameterfv) InternalTool.GetGLesMethodAdress("glGetMinmaxParameterfv", typeof(dgtk.OpenGL.delegatesGLes.glGetMinmaxParameterfv));
			}
			if (SuportedExt.Contains("glGetMinmaxParameterfvEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetMinmaxParameterfvEXT = (dgtk.OpenGL.delegatesGLes.glGetMinmaxParameterfvEXT) InternalTool.GetGLesMethodAdress("glGetMinmaxParameterfvEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetMinmaxParameterfvEXT));
			}
			if (SuportedExt.Contains("glGetMinmaxParameteriv"))
			{
				dgtk.OpenGL.internalGLes.glGetMinmaxParameteriv = (dgtk.OpenGL.delegatesGLes.glGetMinmaxParameteriv) InternalTool.GetGLesMethodAdress("glGetMinmaxParameteriv", typeof(dgtk.OpenGL.delegatesGLes.glGetMinmaxParameteriv));
			}
			if (SuportedExt.Contains("glGetMinmaxParameterivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetMinmaxParameterivEXT = (dgtk.OpenGL.delegatesGLes.glGetMinmaxParameterivEXT) InternalTool.GetGLesMethodAdress("glGetMinmaxParameterivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetMinmaxParameterivEXT));
			}
			if (SuportedExt.Contains("glGetMultisamplefvNV"))
			{
				dgtk.OpenGL.internalGLes.glGetMultisamplefvNV = (dgtk.OpenGL.delegatesGLes.glGetMultisamplefvNV) InternalTool.GetGLesMethodAdress("glGetMultisamplefvNV", typeof(dgtk.OpenGL.delegatesGLes.glGetMultisamplefvNV));
			}
			if (SuportedExt.Contains("glGetMultiTexEnvfvEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetMultiTexEnvfvEXT = (dgtk.OpenGL.delegatesGLes.glGetMultiTexEnvfvEXT) InternalTool.GetGLesMethodAdress("glGetMultiTexEnvfvEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetMultiTexEnvfvEXT));
			}
			if (SuportedExt.Contains("glGetMultiTexEnvivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetMultiTexEnvivEXT = (dgtk.OpenGL.delegatesGLes.glGetMultiTexEnvivEXT) InternalTool.GetGLesMethodAdress("glGetMultiTexEnvivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetMultiTexEnvivEXT));
			}
			if (SuportedExt.Contains("glGetMultiTexGendvEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetMultiTexGendvEXT = (dgtk.OpenGL.delegatesGLes.glGetMultiTexGendvEXT) InternalTool.GetGLesMethodAdress("glGetMultiTexGendvEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetMultiTexGendvEXT));
			}
			if (SuportedExt.Contains("glGetMultiTexGenfvEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetMultiTexGenfvEXT = (dgtk.OpenGL.delegatesGLes.glGetMultiTexGenfvEXT) InternalTool.GetGLesMethodAdress("glGetMultiTexGenfvEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetMultiTexGenfvEXT));
			}
			if (SuportedExt.Contains("glGetMultiTexGenivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetMultiTexGenivEXT = (dgtk.OpenGL.delegatesGLes.glGetMultiTexGenivEXT) InternalTool.GetGLesMethodAdress("glGetMultiTexGenivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetMultiTexGenivEXT));
			}
			if (SuportedExt.Contains("glGetMultiTexImageEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetMultiTexImageEXT = (dgtk.OpenGL.delegatesGLes.glGetMultiTexImageEXT) InternalTool.GetGLesMethodAdress("glGetMultiTexImageEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetMultiTexImageEXT));
			}
			if (SuportedExt.Contains("glGetMultiTexLevelParameterfvEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetMultiTexLevelParameterfvEXT = (dgtk.OpenGL.delegatesGLes.glGetMultiTexLevelParameterfvEXT) InternalTool.GetGLesMethodAdress("glGetMultiTexLevelParameterfvEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetMultiTexLevelParameterfvEXT));
			}
			if (SuportedExt.Contains("glGetMultiTexLevelParameterivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetMultiTexLevelParameterivEXT = (dgtk.OpenGL.delegatesGLes.glGetMultiTexLevelParameterivEXT) InternalTool.GetGLesMethodAdress("glGetMultiTexLevelParameterivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetMultiTexLevelParameterivEXT));
			}
			if (SuportedExt.Contains("glGetMultiTexParameterfvEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetMultiTexParameterfvEXT = (dgtk.OpenGL.delegatesGLes.glGetMultiTexParameterfvEXT) InternalTool.GetGLesMethodAdress("glGetMultiTexParameterfvEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetMultiTexParameterfvEXT));
			}
			if (SuportedExt.Contains("glGetMultiTexParameterIivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetMultiTexParameterIivEXT = (dgtk.OpenGL.delegatesGLes.glGetMultiTexParameterIivEXT) InternalTool.GetGLesMethodAdress("glGetMultiTexParameterIivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetMultiTexParameterIivEXT));
			}
			if (SuportedExt.Contains("glGetMultiTexParameterIuivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetMultiTexParameterIuivEXT = (dgtk.OpenGL.delegatesGLes.glGetMultiTexParameterIuivEXT) InternalTool.GetGLesMethodAdress("glGetMultiTexParameterIuivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetMultiTexParameterIuivEXT));
			}
			if (SuportedExt.Contains("glGetMultiTexParameterivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetMultiTexParameterivEXT = (dgtk.OpenGL.delegatesGLes.glGetMultiTexParameterivEXT) InternalTool.GetGLesMethodAdress("glGetMultiTexParameterivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetMultiTexParameterivEXT));
			}
			if (SuportedExt.Contains("glGetNamedBufferParameterivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetNamedBufferParameterivEXT = (dgtk.OpenGL.delegatesGLes.glGetNamedBufferParameterivEXT) InternalTool.GetGLesMethodAdress("glGetNamedBufferParameterivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetNamedBufferParameterivEXT));
			}
			if (SuportedExt.Contains("glGetNamedBufferParameterui64vNV"))
			{
				dgtk.OpenGL.internalGLes.glGetNamedBufferParameterui64vNV = (dgtk.OpenGL.delegatesGLes.glGetNamedBufferParameterui64vNV) InternalTool.GetGLesMethodAdress("glGetNamedBufferParameterui64vNV", typeof(dgtk.OpenGL.delegatesGLes.glGetNamedBufferParameterui64vNV));
			}
			if (SuportedExt.Contains("glGetNamedBufferPointervEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetNamedBufferPointervEXT = (dgtk.OpenGL.delegatesGLes.glGetNamedBufferPointervEXT) InternalTool.GetGLesMethodAdress("glGetNamedBufferPointervEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetNamedBufferPointervEXT));
			}
			if (SuportedExt.Contains("glGetNamedBufferSubDataEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetNamedBufferSubDataEXT = (dgtk.OpenGL.delegatesGLes.glGetNamedBufferSubDataEXT) InternalTool.GetGLesMethodAdress("glGetNamedBufferSubDataEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetNamedBufferSubDataEXT));
			}
			if (SuportedExt.Contains("glGetNamedFramebufferAttachmentParameterivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetNamedFramebufferAttachmentParameterivEXT = (dgtk.OpenGL.delegatesGLes.glGetNamedFramebufferAttachmentParameterivEXT) InternalTool.GetGLesMethodAdress("glGetNamedFramebufferAttachmentParameterivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetNamedFramebufferAttachmentParameterivEXT));
			}
			if (SuportedExt.Contains("glGetNamedFramebufferParameterfvAMD"))
			{
				dgtk.OpenGL.internalGLes.glGetNamedFramebufferParameterfvAMD = (dgtk.OpenGL.delegatesGLes.glGetNamedFramebufferParameterfvAMD) InternalTool.GetGLesMethodAdress("glGetNamedFramebufferParameterfvAMD", typeof(dgtk.OpenGL.delegatesGLes.glGetNamedFramebufferParameterfvAMD));
			}
			if (SuportedExt.Contains("glGetNamedFramebufferParameterivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetNamedFramebufferParameterivEXT = (dgtk.OpenGL.delegatesGLes.glGetNamedFramebufferParameterivEXT) InternalTool.GetGLesMethodAdress("glGetNamedFramebufferParameterivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetNamedFramebufferParameterivEXT));
			}
			if (SuportedExt.Contains("glGetNamedProgramivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetNamedProgramivEXT = (dgtk.OpenGL.delegatesGLes.glGetNamedProgramivEXT) InternalTool.GetGLesMethodAdress("glGetNamedProgramivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetNamedProgramivEXT));
			}
			if (SuportedExt.Contains("glGetNamedProgramLocalParameterdvEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetNamedProgramLocalParameterdvEXT = (dgtk.OpenGL.delegatesGLes.glGetNamedProgramLocalParameterdvEXT) InternalTool.GetGLesMethodAdress("glGetNamedProgramLocalParameterdvEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetNamedProgramLocalParameterdvEXT));
			}
			if (SuportedExt.Contains("glGetNamedProgramLocalParameterfvEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetNamedProgramLocalParameterfvEXT = (dgtk.OpenGL.delegatesGLes.glGetNamedProgramLocalParameterfvEXT) InternalTool.GetGLesMethodAdress("glGetNamedProgramLocalParameterfvEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetNamedProgramLocalParameterfvEXT));
			}
			if (SuportedExt.Contains("glGetNamedProgramLocalParameterIivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetNamedProgramLocalParameterIivEXT = (dgtk.OpenGL.delegatesGLes.glGetNamedProgramLocalParameterIivEXT) InternalTool.GetGLesMethodAdress("glGetNamedProgramLocalParameterIivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetNamedProgramLocalParameterIivEXT));
			}
			if (SuportedExt.Contains("glGetNamedProgramLocalParameterIuivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetNamedProgramLocalParameterIuivEXT = (dgtk.OpenGL.delegatesGLes.glGetNamedProgramLocalParameterIuivEXT) InternalTool.GetGLesMethodAdress("glGetNamedProgramLocalParameterIuivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetNamedProgramLocalParameterIuivEXT));
			}
			if (SuportedExt.Contains("glGetNamedProgramStringEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetNamedProgramStringEXT = (dgtk.OpenGL.delegatesGLes.glGetNamedProgramStringEXT) InternalTool.GetGLesMethodAdress("glGetNamedProgramStringEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetNamedProgramStringEXT));
			}
			if (SuportedExt.Contains("glGetNamedRenderbufferParameterivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetNamedRenderbufferParameterivEXT = (dgtk.OpenGL.delegatesGLes.glGetNamedRenderbufferParameterivEXT) InternalTool.GetGLesMethodAdress("glGetNamedRenderbufferParameterivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetNamedRenderbufferParameterivEXT));
			}
			if (SuportedExt.Contains("glGetNamedStringARB"))
			{
				dgtk.OpenGL.internalGLes.glGetNamedStringARB = (dgtk.OpenGL.delegatesGLes.glGetNamedStringARB) InternalTool.GetGLesMethodAdress("glGetNamedStringARB", typeof(dgtk.OpenGL.delegatesGLes.glGetNamedStringARB));
			}
			if (SuportedExt.Contains("glGetNamedStringivARB"))
			{
				dgtk.OpenGL.internalGLes.glGetNamedStringivARB = (dgtk.OpenGL.delegatesGLes.glGetNamedStringivARB) InternalTool.GetGLesMethodAdress("glGetNamedStringivARB", typeof(dgtk.OpenGL.delegatesGLes.glGetNamedStringivARB));
			}
			if (SuportedExt.Contains("glGetnColorTableARB"))
			{
				dgtk.OpenGL.internalGLes.glGetnColorTableARB = (dgtk.OpenGL.delegatesGLes.glGetnColorTableARB) InternalTool.GetGLesMethodAdress("glGetnColorTableARB", typeof(dgtk.OpenGL.delegatesGLes.glGetnColorTableARB));
			}
			if (SuportedExt.Contains("glGetnCompressedTexImageARB"))
			{
				dgtk.OpenGL.internalGLes.glGetnCompressedTexImageARB = (dgtk.OpenGL.delegatesGLes.glGetnCompressedTexImageARB) InternalTool.GetGLesMethodAdress("glGetnCompressedTexImageARB", typeof(dgtk.OpenGL.delegatesGLes.glGetnCompressedTexImageARB));
			}
			if (SuportedExt.Contains("glGetnConvolutionFilterARB"))
			{
				dgtk.OpenGL.internalGLes.glGetnConvolutionFilterARB = (dgtk.OpenGL.delegatesGLes.glGetnConvolutionFilterARB) InternalTool.GetGLesMethodAdress("glGetnConvolutionFilterARB", typeof(dgtk.OpenGL.delegatesGLes.glGetnConvolutionFilterARB));
			}
			if (SuportedExt.Contains("glGetNextPerfQueryIdINTEL"))
			{
				dgtk.OpenGL.internalGLes.glGetNextPerfQueryIdINTEL = (dgtk.OpenGL.delegatesGLes.glGetNextPerfQueryIdINTEL) InternalTool.GetGLesMethodAdress("glGetNextPerfQueryIdINTEL", typeof(dgtk.OpenGL.delegatesGLes.glGetNextPerfQueryIdINTEL));
			}
			if (SuportedExt.Contains("glGetnHistogramARB"))
			{
				dgtk.OpenGL.internalGLes.glGetnHistogramARB = (dgtk.OpenGL.delegatesGLes.glGetnHistogramARB) InternalTool.GetGLesMethodAdress("glGetnHistogramARB", typeof(dgtk.OpenGL.delegatesGLes.glGetnHistogramARB));
			}
			if (SuportedExt.Contains("glGetnMapdvARB"))
			{
				dgtk.OpenGL.internalGLes.glGetnMapdvARB = (dgtk.OpenGL.delegatesGLes.glGetnMapdvARB) InternalTool.GetGLesMethodAdress("glGetnMapdvARB", typeof(dgtk.OpenGL.delegatesGLes.glGetnMapdvARB));
			}
			if (SuportedExt.Contains("glGetnMapfvARB"))
			{
				dgtk.OpenGL.internalGLes.glGetnMapfvARB = (dgtk.OpenGL.delegatesGLes.glGetnMapfvARB) InternalTool.GetGLesMethodAdress("glGetnMapfvARB", typeof(dgtk.OpenGL.delegatesGLes.glGetnMapfvARB));
			}
			if (SuportedExt.Contains("glGetnMapivARB"))
			{
				dgtk.OpenGL.internalGLes.glGetnMapivARB = (dgtk.OpenGL.delegatesGLes.glGetnMapivARB) InternalTool.GetGLesMethodAdress("glGetnMapivARB", typeof(dgtk.OpenGL.delegatesGLes.glGetnMapivARB));
			}
			if (SuportedExt.Contains("glGetnMinmaxARB"))
			{
				dgtk.OpenGL.internalGLes.glGetnMinmaxARB = (dgtk.OpenGL.delegatesGLes.glGetnMinmaxARB) InternalTool.GetGLesMethodAdress("glGetnMinmaxARB", typeof(dgtk.OpenGL.delegatesGLes.glGetnMinmaxARB));
			}
			if (SuportedExt.Contains("glGetnPixelMapfvARB"))
			{
				dgtk.OpenGL.internalGLes.glGetnPixelMapfvARB = (dgtk.OpenGL.delegatesGLes.glGetnPixelMapfvARB) InternalTool.GetGLesMethodAdress("glGetnPixelMapfvARB", typeof(dgtk.OpenGL.delegatesGLes.glGetnPixelMapfvARB));
			}
			if (SuportedExt.Contains("glGetnPixelMapuivARB"))
			{
				dgtk.OpenGL.internalGLes.glGetnPixelMapuivARB = (dgtk.OpenGL.delegatesGLes.glGetnPixelMapuivARB) InternalTool.GetGLesMethodAdress("glGetnPixelMapuivARB", typeof(dgtk.OpenGL.delegatesGLes.glGetnPixelMapuivARB));
			}
			if (SuportedExt.Contains("glGetnPixelMapusvARB"))
			{
				dgtk.OpenGL.internalGLes.glGetnPixelMapusvARB = (dgtk.OpenGL.delegatesGLes.glGetnPixelMapusvARB) InternalTool.GetGLesMethodAdress("glGetnPixelMapusvARB", typeof(dgtk.OpenGL.delegatesGLes.glGetnPixelMapusvARB));
			}
			if (SuportedExt.Contains("glGetnPolygonStippleARB"))
			{
				dgtk.OpenGL.internalGLes.glGetnPolygonStippleARB = (dgtk.OpenGL.delegatesGLes.glGetnPolygonStippleARB) InternalTool.GetGLesMethodAdress("glGetnPolygonStippleARB", typeof(dgtk.OpenGL.delegatesGLes.glGetnPolygonStippleARB));
			}
			if (SuportedExt.Contains("glGetnSeparableFilterARB"))
			{
				dgtk.OpenGL.internalGLes.glGetnSeparableFilterARB = (dgtk.OpenGL.delegatesGLes.glGetnSeparableFilterARB) InternalTool.GetGLesMethodAdress("glGetnSeparableFilterARB", typeof(dgtk.OpenGL.delegatesGLes.glGetnSeparableFilterARB));
			}
			if (SuportedExt.Contains("glGetnTexImageARB"))
			{
				dgtk.OpenGL.internalGLes.glGetnTexImageARB = (dgtk.OpenGL.delegatesGLes.glGetnTexImageARB) InternalTool.GetGLesMethodAdress("glGetnTexImageARB", typeof(dgtk.OpenGL.delegatesGLes.glGetnTexImageARB));
			}
			if (SuportedExt.Contains("glGetnUniformdvARB"))
			{
				dgtk.OpenGL.internalGLes.glGetnUniformdvARB = (dgtk.OpenGL.delegatesGLes.glGetnUniformdvARB) InternalTool.GetGLesMethodAdress("glGetnUniformdvARB", typeof(dgtk.OpenGL.delegatesGLes.glGetnUniformdvARB));
			}
			if (SuportedExt.Contains("glGetnUniformfvARB"))
			{
				dgtk.OpenGL.internalGLes.glGetnUniformfvARB = (dgtk.OpenGL.delegatesGLes.glGetnUniformfvARB) InternalTool.GetGLesMethodAdress("glGetnUniformfvARB", typeof(dgtk.OpenGL.delegatesGLes.glGetnUniformfvARB));
			}
			if (SuportedExt.Contains("glGetnUniformfvEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetnUniformfvEXT = (dgtk.OpenGL.delegatesGLes.glGetnUniformfvEXT) InternalTool.GetGLesMethodAdress("glGetnUniformfvEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetnUniformfvEXT));
			}
			if (SuportedExt.Contains("glGetnUniformfvKHR"))
			{
				dgtk.OpenGL.internalGLes.glGetnUniformfvKHR = (dgtk.OpenGL.delegatesGLes.glGetnUniformfvKHR) InternalTool.GetGLesMethodAdress("glGetnUniformfvKHR", typeof(dgtk.OpenGL.delegatesGLes.glGetnUniformfvKHR));
			}
			if (SuportedExt.Contains("glGetnUniformi64vARB"))
			{
				dgtk.OpenGL.internalGLes.glGetnUniformi64vARB = (dgtk.OpenGL.delegatesGLes.glGetnUniformi64vARB) InternalTool.GetGLesMethodAdress("glGetnUniformi64vARB", typeof(dgtk.OpenGL.delegatesGLes.glGetnUniformi64vARB));
			}
			if (SuportedExt.Contains("glGetnUniformivARB"))
			{
				dgtk.OpenGL.internalGLes.glGetnUniformivARB = (dgtk.OpenGL.delegatesGLes.glGetnUniformivARB) InternalTool.GetGLesMethodAdress("glGetnUniformivARB", typeof(dgtk.OpenGL.delegatesGLes.glGetnUniformivARB));
			}
			if (SuportedExt.Contains("glGetnUniformivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetnUniformivEXT = (dgtk.OpenGL.delegatesGLes.glGetnUniformivEXT) InternalTool.GetGLesMethodAdress("glGetnUniformivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetnUniformivEXT));
			}
			if (SuportedExt.Contains("glGetnUniformivKHR"))
			{
				dgtk.OpenGL.internalGLes.glGetnUniformivKHR = (dgtk.OpenGL.delegatesGLes.glGetnUniformivKHR) InternalTool.GetGLesMethodAdress("glGetnUniformivKHR", typeof(dgtk.OpenGL.delegatesGLes.glGetnUniformivKHR));
			}
			if (SuportedExt.Contains("glGetnUniformui64vARB"))
			{
				dgtk.OpenGL.internalGLes.glGetnUniformui64vARB = (dgtk.OpenGL.delegatesGLes.glGetnUniformui64vARB) InternalTool.GetGLesMethodAdress("glGetnUniformui64vARB", typeof(dgtk.OpenGL.delegatesGLes.glGetnUniformui64vARB));
			}
			if (SuportedExt.Contains("glGetnUniformuivARB"))
			{
				dgtk.OpenGL.internalGLes.glGetnUniformuivARB = (dgtk.OpenGL.delegatesGLes.glGetnUniformuivARB) InternalTool.GetGLesMethodAdress("glGetnUniformuivARB", typeof(dgtk.OpenGL.delegatesGLes.glGetnUniformuivARB));
			}
			if (SuportedExt.Contains("glGetnUniformuivKHR"))
			{
				dgtk.OpenGL.internalGLes.glGetnUniformuivKHR = (dgtk.OpenGL.delegatesGLes.glGetnUniformuivKHR) InternalTool.GetGLesMethodAdress("glGetnUniformuivKHR", typeof(dgtk.OpenGL.delegatesGLes.glGetnUniformuivKHR));
			}
			if (SuportedExt.Contains("glGetObjectBufferfvATI"))
			{
				dgtk.OpenGL.internalGLes.glGetObjectBufferfvATI = (dgtk.OpenGL.delegatesGLes.glGetObjectBufferfvATI) InternalTool.GetGLesMethodAdress("glGetObjectBufferfvATI", typeof(dgtk.OpenGL.delegatesGLes.glGetObjectBufferfvATI));
			}
			if (SuportedExt.Contains("glGetObjectBufferivATI"))
			{
				dgtk.OpenGL.internalGLes.glGetObjectBufferivATI = (dgtk.OpenGL.delegatesGLes.glGetObjectBufferivATI) InternalTool.GetGLesMethodAdress("glGetObjectBufferivATI", typeof(dgtk.OpenGL.delegatesGLes.glGetObjectBufferivATI));
			}
			if (SuportedExt.Contains("glGetObjectLabelEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetObjectLabelEXT = (dgtk.OpenGL.delegatesGLes.glGetObjectLabelEXT) InternalTool.GetGLesMethodAdress("glGetObjectLabelEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetObjectLabelEXT));
			}
			if (SuportedExt.Contains("glGetObjectLabelKHR"))
			{
				dgtk.OpenGL.internalGLes.glGetObjectLabelKHR = (dgtk.OpenGL.delegatesGLes.glGetObjectLabelKHR) InternalTool.GetGLesMethodAdress("glGetObjectLabelKHR", typeof(dgtk.OpenGL.delegatesGLes.glGetObjectLabelKHR));
			}
			if (SuportedExt.Contains("glGetObjectParameterfvARB"))
			{
				dgtk.OpenGL.internalGLes.glGetObjectParameterfvARB = (dgtk.OpenGL.delegatesGLes.glGetObjectParameterfvARB) InternalTool.GetGLesMethodAdress("glGetObjectParameterfvARB", typeof(dgtk.OpenGL.delegatesGLes.glGetObjectParameterfvARB));
			}
			if (SuportedExt.Contains("glGetObjectParameterivAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glGetObjectParameterivAPPLE = (dgtk.OpenGL.delegatesGLes.glGetObjectParameterivAPPLE) InternalTool.GetGLesMethodAdress("glGetObjectParameterivAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glGetObjectParameterivAPPLE));
			}
			if (SuportedExt.Contains("glGetObjectParameterivARB"))
			{
				dgtk.OpenGL.internalGLes.glGetObjectParameterivARB = (dgtk.OpenGL.delegatesGLes.glGetObjectParameterivARB) InternalTool.GetGLesMethodAdress("glGetObjectParameterivARB", typeof(dgtk.OpenGL.delegatesGLes.glGetObjectParameterivARB));
			}
			if (SuportedExt.Contains("glGetObjectPtrLabelKHR"))
			{
				dgtk.OpenGL.internalGLes.glGetObjectPtrLabelKHR = (dgtk.OpenGL.delegatesGLes.glGetObjectPtrLabelKHR) InternalTool.GetGLesMethodAdress("glGetObjectPtrLabelKHR", typeof(dgtk.OpenGL.delegatesGLes.glGetObjectPtrLabelKHR));
			}
			if (SuportedExt.Contains("glGetOcclusionQueryivNV"))
			{
				dgtk.OpenGL.internalGLes.glGetOcclusionQueryivNV = (dgtk.OpenGL.delegatesGLes.glGetOcclusionQueryivNV) InternalTool.GetGLesMethodAdress("glGetOcclusionQueryivNV", typeof(dgtk.OpenGL.delegatesGLes.glGetOcclusionQueryivNV));
			}
			if (SuportedExt.Contains("glGetOcclusionQueryuivNV"))
			{
				dgtk.OpenGL.internalGLes.glGetOcclusionQueryuivNV = (dgtk.OpenGL.delegatesGLes.glGetOcclusionQueryuivNV) InternalTool.GetGLesMethodAdress("glGetOcclusionQueryuivNV", typeof(dgtk.OpenGL.delegatesGLes.glGetOcclusionQueryuivNV));
			}
			if (SuportedExt.Contains("glGetPathColorGenfvNV"))
			{
				dgtk.OpenGL.internalGLes.glGetPathColorGenfvNV = (dgtk.OpenGL.delegatesGLes.glGetPathColorGenfvNV) InternalTool.GetGLesMethodAdress("glGetPathColorGenfvNV", typeof(dgtk.OpenGL.delegatesGLes.glGetPathColorGenfvNV));
			}
			if (SuportedExt.Contains("glGetPathColorGenivNV"))
			{
				dgtk.OpenGL.internalGLes.glGetPathColorGenivNV = (dgtk.OpenGL.delegatesGLes.glGetPathColorGenivNV) InternalTool.GetGLesMethodAdress("glGetPathColorGenivNV", typeof(dgtk.OpenGL.delegatesGLes.glGetPathColorGenivNV));
			}
			if (SuportedExt.Contains("glGetPathCommandsNV"))
			{
				dgtk.OpenGL.internalGLes.glGetPathCommandsNV = (dgtk.OpenGL.delegatesGLes.glGetPathCommandsNV) InternalTool.GetGLesMethodAdress("glGetPathCommandsNV", typeof(dgtk.OpenGL.delegatesGLes.glGetPathCommandsNV));
			}
			if (SuportedExt.Contains("glGetPathCoordsNV"))
			{
				dgtk.OpenGL.internalGLes.glGetPathCoordsNV = (dgtk.OpenGL.delegatesGLes.glGetPathCoordsNV) InternalTool.GetGLesMethodAdress("glGetPathCoordsNV", typeof(dgtk.OpenGL.delegatesGLes.glGetPathCoordsNV));
			}
			if (SuportedExt.Contains("glGetPathDashArrayNV"))
			{
				dgtk.OpenGL.internalGLes.glGetPathDashArrayNV = (dgtk.OpenGL.delegatesGLes.glGetPathDashArrayNV) InternalTool.GetGLesMethodAdress("glGetPathDashArrayNV", typeof(dgtk.OpenGL.delegatesGLes.glGetPathDashArrayNV));
			}
			if (SuportedExt.Contains("glGetPathLengthNV"))
			{
				dgtk.OpenGL.internalGLes.glGetPathLengthNV = (dgtk.OpenGL.delegatesGLes.glGetPathLengthNV) InternalTool.GetGLesMethodAdress("glGetPathLengthNV", typeof(dgtk.OpenGL.delegatesGLes.glGetPathLengthNV));
			}
			if (SuportedExt.Contains("glGetPathMetricRangeNV"))
			{
				dgtk.OpenGL.internalGLes.glGetPathMetricRangeNV = (dgtk.OpenGL.delegatesGLes.glGetPathMetricRangeNV) InternalTool.GetGLesMethodAdress("glGetPathMetricRangeNV", typeof(dgtk.OpenGL.delegatesGLes.glGetPathMetricRangeNV));
			}
			if (SuportedExt.Contains("glGetPathMetricsNV"))
			{
				dgtk.OpenGL.internalGLes.glGetPathMetricsNV = (dgtk.OpenGL.delegatesGLes.glGetPathMetricsNV) InternalTool.GetGLesMethodAdress("glGetPathMetricsNV", typeof(dgtk.OpenGL.delegatesGLes.glGetPathMetricsNV));
			}
			if (SuportedExt.Contains("glGetPathParameterfvNV"))
			{
				dgtk.OpenGL.internalGLes.glGetPathParameterfvNV = (dgtk.OpenGL.delegatesGLes.glGetPathParameterfvNV) InternalTool.GetGLesMethodAdress("glGetPathParameterfvNV", typeof(dgtk.OpenGL.delegatesGLes.glGetPathParameterfvNV));
			}
			if (SuportedExt.Contains("glGetPathParameterivNV"))
			{
				dgtk.OpenGL.internalGLes.glGetPathParameterivNV = (dgtk.OpenGL.delegatesGLes.glGetPathParameterivNV) InternalTool.GetGLesMethodAdress("glGetPathParameterivNV", typeof(dgtk.OpenGL.delegatesGLes.glGetPathParameterivNV));
			}
			if (SuportedExt.Contains("glGetPathSpacingNV"))
			{
				dgtk.OpenGL.internalGLes.glGetPathSpacingNV = (dgtk.OpenGL.delegatesGLes.glGetPathSpacingNV) InternalTool.GetGLesMethodAdress("glGetPathSpacingNV", typeof(dgtk.OpenGL.delegatesGLes.glGetPathSpacingNV));
			}
			if (SuportedExt.Contains("glGetPathTexGenfvNV"))
			{
				dgtk.OpenGL.internalGLes.glGetPathTexGenfvNV = (dgtk.OpenGL.delegatesGLes.glGetPathTexGenfvNV) InternalTool.GetGLesMethodAdress("glGetPathTexGenfvNV", typeof(dgtk.OpenGL.delegatesGLes.glGetPathTexGenfvNV));
			}
			if (SuportedExt.Contains("glGetPathTexGenivNV"))
			{
				dgtk.OpenGL.internalGLes.glGetPathTexGenivNV = (dgtk.OpenGL.delegatesGLes.glGetPathTexGenivNV) InternalTool.GetGLesMethodAdress("glGetPathTexGenivNV", typeof(dgtk.OpenGL.delegatesGLes.glGetPathTexGenivNV));
			}
			if (SuportedExt.Contains("glGetPerfCounterInfoINTEL"))
			{
				dgtk.OpenGL.internalGLes.glGetPerfCounterInfoINTEL = (dgtk.OpenGL.delegatesGLes.glGetPerfCounterInfoINTEL) InternalTool.GetGLesMethodAdress("glGetPerfCounterInfoINTEL", typeof(dgtk.OpenGL.delegatesGLes.glGetPerfCounterInfoINTEL));
			}
			if (SuportedExt.Contains("glGetPerfMonitorCounterDataAMD"))
			{
				dgtk.OpenGL.internalGLes.glGetPerfMonitorCounterDataAMD = (dgtk.OpenGL.delegatesGLes.glGetPerfMonitorCounterDataAMD) InternalTool.GetGLesMethodAdress("glGetPerfMonitorCounterDataAMD", typeof(dgtk.OpenGL.delegatesGLes.glGetPerfMonitorCounterDataAMD));
			}
			if (SuportedExt.Contains("glGetPerfMonitorCounterInfoAMD"))
			{
				dgtk.OpenGL.internalGLes.glGetPerfMonitorCounterInfoAMD = (dgtk.OpenGL.delegatesGLes.glGetPerfMonitorCounterInfoAMD) InternalTool.GetGLesMethodAdress("glGetPerfMonitorCounterInfoAMD", typeof(dgtk.OpenGL.delegatesGLes.glGetPerfMonitorCounterInfoAMD));
			}
			if (SuportedExt.Contains("glGetPerfMonitorCountersAMD"))
			{
				dgtk.OpenGL.internalGLes.glGetPerfMonitorCountersAMD = (dgtk.OpenGL.delegatesGLes.glGetPerfMonitorCountersAMD) InternalTool.GetGLesMethodAdress("glGetPerfMonitorCountersAMD", typeof(dgtk.OpenGL.delegatesGLes.glGetPerfMonitorCountersAMD));
			}
			if (SuportedExt.Contains("glGetPerfMonitorCounterStringAMD"))
			{
				dgtk.OpenGL.internalGLes.glGetPerfMonitorCounterStringAMD = (dgtk.OpenGL.delegatesGLes.glGetPerfMonitorCounterStringAMD) InternalTool.GetGLesMethodAdress("glGetPerfMonitorCounterStringAMD", typeof(dgtk.OpenGL.delegatesGLes.glGetPerfMonitorCounterStringAMD));
			}
			if (SuportedExt.Contains("glGetPerfMonitorGroupsAMD"))
			{
				dgtk.OpenGL.internalGLes.glGetPerfMonitorGroupsAMD = (dgtk.OpenGL.delegatesGLes.glGetPerfMonitorGroupsAMD) InternalTool.GetGLesMethodAdress("glGetPerfMonitorGroupsAMD", typeof(dgtk.OpenGL.delegatesGLes.glGetPerfMonitorGroupsAMD));
			}
			if (SuportedExt.Contains("glGetPerfMonitorGroupStringAMD"))
			{
				dgtk.OpenGL.internalGLes.glGetPerfMonitorGroupStringAMD = (dgtk.OpenGL.delegatesGLes.glGetPerfMonitorGroupStringAMD) InternalTool.GetGLesMethodAdress("glGetPerfMonitorGroupStringAMD", typeof(dgtk.OpenGL.delegatesGLes.glGetPerfMonitorGroupStringAMD));
			}
			if (SuportedExt.Contains("glGetPerfQueryDataINTEL"))
			{
				dgtk.OpenGL.internalGLes.glGetPerfQueryDataINTEL = (dgtk.OpenGL.delegatesGLes.glGetPerfQueryDataINTEL) InternalTool.GetGLesMethodAdress("glGetPerfQueryDataINTEL", typeof(dgtk.OpenGL.delegatesGLes.glGetPerfQueryDataINTEL));
			}
			if (SuportedExt.Contains("glGetPerfQueryIdByNameINTEL"))
			{
				dgtk.OpenGL.internalGLes.glGetPerfQueryIdByNameINTEL = (dgtk.OpenGL.delegatesGLes.glGetPerfQueryIdByNameINTEL) InternalTool.GetGLesMethodAdress("glGetPerfQueryIdByNameINTEL", typeof(dgtk.OpenGL.delegatesGLes.glGetPerfQueryIdByNameINTEL));
			}
			if (SuportedExt.Contains("glGetPerfQueryInfoINTEL"))
			{
				dgtk.OpenGL.internalGLes.glGetPerfQueryInfoINTEL = (dgtk.OpenGL.delegatesGLes.glGetPerfQueryInfoINTEL) InternalTool.GetGLesMethodAdress("glGetPerfQueryInfoINTEL", typeof(dgtk.OpenGL.delegatesGLes.glGetPerfQueryInfoINTEL));
			}
			if (SuportedExt.Contains("glGetPixelMapxv"))
			{
				dgtk.OpenGL.internalGLes.glGetPixelMapxv = (dgtk.OpenGL.delegatesGLes.glGetPixelMapxv) InternalTool.GetGLesMethodAdress("glGetPixelMapxv", typeof(dgtk.OpenGL.delegatesGLes.glGetPixelMapxv));
			}
			if (SuportedExt.Contains("glGetPixelTexGenParameterfvSGIS"))
			{
				dgtk.OpenGL.internalGLes.glGetPixelTexGenParameterfvSGIS = (dgtk.OpenGL.delegatesGLes.glGetPixelTexGenParameterfvSGIS) InternalTool.GetGLesMethodAdress("glGetPixelTexGenParameterfvSGIS", typeof(dgtk.OpenGL.delegatesGLes.glGetPixelTexGenParameterfvSGIS));
			}
			if (SuportedExt.Contains("glGetPixelTexGenParameterivSGIS"))
			{
				dgtk.OpenGL.internalGLes.glGetPixelTexGenParameterivSGIS = (dgtk.OpenGL.delegatesGLes.glGetPixelTexGenParameterivSGIS) InternalTool.GetGLesMethodAdress("glGetPixelTexGenParameterivSGIS", typeof(dgtk.OpenGL.delegatesGLes.glGetPixelTexGenParameterivSGIS));
			}
			if (SuportedExt.Contains("glGetPixelTransformParameterfvEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetPixelTransformParameterfvEXT = (dgtk.OpenGL.delegatesGLes.glGetPixelTransformParameterfvEXT) InternalTool.GetGLesMethodAdress("glGetPixelTransformParameterfvEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetPixelTransformParameterfvEXT));
			}
			if (SuportedExt.Contains("glGetPixelTransformParameterivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetPixelTransformParameterivEXT = (dgtk.OpenGL.delegatesGLes.glGetPixelTransformParameterivEXT) InternalTool.GetGLesMethodAdress("glGetPixelTransformParameterivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetPixelTransformParameterivEXT));
			}
			if (SuportedExt.Contains("glGetPointeri_vEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetPointeri_vEXT = (dgtk.OpenGL.delegatesGLes.glGetPointeri_vEXT) InternalTool.GetGLesMethodAdress("glGetPointeri_vEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetPointeri_vEXT));
			}
			if (SuportedExt.Contains("glGetPointerIndexedvEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetPointerIndexedvEXT = (dgtk.OpenGL.delegatesGLes.glGetPointerIndexedvEXT) InternalTool.GetGLesMethodAdress("glGetPointerIndexedvEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetPointerIndexedvEXT));
			}
			if (SuportedExt.Contains("glGetPointervEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetPointervEXT = (dgtk.OpenGL.delegatesGLes.glGetPointervEXT) InternalTool.GetGLesMethodAdress("glGetPointervEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetPointervEXT));
			}
			if (SuportedExt.Contains("glGetPointervKHR"))
			{
				dgtk.OpenGL.internalGLes.glGetPointervKHR = (dgtk.OpenGL.delegatesGLes.glGetPointervKHR) InternalTool.GetGLesMethodAdress("glGetPointervKHR", typeof(dgtk.OpenGL.delegatesGLes.glGetPointervKHR));
			}
			if (SuportedExt.Contains("glGetProgramBinaryOES"))
			{
				dgtk.OpenGL.internalGLes.glGetProgramBinaryOES = (dgtk.OpenGL.delegatesGLes.glGetProgramBinaryOES) InternalTool.GetGLesMethodAdress("glGetProgramBinaryOES", typeof(dgtk.OpenGL.delegatesGLes.glGetProgramBinaryOES));
			}
			if (SuportedExt.Contains("glGetProgramEnvParameterdvARB"))
			{
				dgtk.OpenGL.internalGLes.glGetProgramEnvParameterdvARB = (dgtk.OpenGL.delegatesGLes.glGetProgramEnvParameterdvARB) InternalTool.GetGLesMethodAdress("glGetProgramEnvParameterdvARB", typeof(dgtk.OpenGL.delegatesGLes.glGetProgramEnvParameterdvARB));
			}
			if (SuportedExt.Contains("glGetProgramEnvParameterfvARB"))
			{
				dgtk.OpenGL.internalGLes.glGetProgramEnvParameterfvARB = (dgtk.OpenGL.delegatesGLes.glGetProgramEnvParameterfvARB) InternalTool.GetGLesMethodAdress("glGetProgramEnvParameterfvARB", typeof(dgtk.OpenGL.delegatesGLes.glGetProgramEnvParameterfvARB));
			}
			if (SuportedExt.Contains("glGetProgramEnvParameterIivNV"))
			{
				dgtk.OpenGL.internalGLes.glGetProgramEnvParameterIivNV = (dgtk.OpenGL.delegatesGLes.glGetProgramEnvParameterIivNV) InternalTool.GetGLesMethodAdress("glGetProgramEnvParameterIivNV", typeof(dgtk.OpenGL.delegatesGLes.glGetProgramEnvParameterIivNV));
			}
			if (SuportedExt.Contains("glGetProgramEnvParameterIuivNV"))
			{
				dgtk.OpenGL.internalGLes.glGetProgramEnvParameterIuivNV = (dgtk.OpenGL.delegatesGLes.glGetProgramEnvParameterIuivNV) InternalTool.GetGLesMethodAdress("glGetProgramEnvParameterIuivNV", typeof(dgtk.OpenGL.delegatesGLes.glGetProgramEnvParameterIuivNV));
			}
			if (SuportedExt.Contains("glGetProgramivARB"))
			{
				dgtk.OpenGL.internalGLes.glGetProgramivARB = (dgtk.OpenGL.delegatesGLes.glGetProgramivARB) InternalTool.GetGLesMethodAdress("glGetProgramivARB", typeof(dgtk.OpenGL.delegatesGLes.glGetProgramivARB));
			}
			if (SuportedExt.Contains("glGetProgramivNV"))
			{
				dgtk.OpenGL.internalGLes.glGetProgramivNV = (dgtk.OpenGL.delegatesGLes.glGetProgramivNV) InternalTool.GetGLesMethodAdress("glGetProgramivNV", typeof(dgtk.OpenGL.delegatesGLes.glGetProgramivNV));
			}
			if (SuportedExt.Contains("glGetProgramLocalParameterdvARB"))
			{
				dgtk.OpenGL.internalGLes.glGetProgramLocalParameterdvARB = (dgtk.OpenGL.delegatesGLes.glGetProgramLocalParameterdvARB) InternalTool.GetGLesMethodAdress("glGetProgramLocalParameterdvARB", typeof(dgtk.OpenGL.delegatesGLes.glGetProgramLocalParameterdvARB));
			}
			if (SuportedExt.Contains("glGetProgramLocalParameterfvARB"))
			{
				dgtk.OpenGL.internalGLes.glGetProgramLocalParameterfvARB = (dgtk.OpenGL.delegatesGLes.glGetProgramLocalParameterfvARB) InternalTool.GetGLesMethodAdress("glGetProgramLocalParameterfvARB", typeof(dgtk.OpenGL.delegatesGLes.glGetProgramLocalParameterfvARB));
			}
			if (SuportedExt.Contains("glGetProgramLocalParameterIivNV"))
			{
				dgtk.OpenGL.internalGLes.glGetProgramLocalParameterIivNV = (dgtk.OpenGL.delegatesGLes.glGetProgramLocalParameterIivNV) InternalTool.GetGLesMethodAdress("glGetProgramLocalParameterIivNV", typeof(dgtk.OpenGL.delegatesGLes.glGetProgramLocalParameterIivNV));
			}
			if (SuportedExt.Contains("glGetProgramLocalParameterIuivNV"))
			{
				dgtk.OpenGL.internalGLes.glGetProgramLocalParameterIuivNV = (dgtk.OpenGL.delegatesGLes.glGetProgramLocalParameterIuivNV) InternalTool.GetGLesMethodAdress("glGetProgramLocalParameterIuivNV", typeof(dgtk.OpenGL.delegatesGLes.glGetProgramLocalParameterIuivNV));
			}
			if (SuportedExt.Contains("glGetProgramNamedParameterdvNV"))
			{
				dgtk.OpenGL.internalGLes.glGetProgramNamedParameterdvNV = (dgtk.OpenGL.delegatesGLes.glGetProgramNamedParameterdvNV) InternalTool.GetGLesMethodAdress("glGetProgramNamedParameterdvNV", typeof(dgtk.OpenGL.delegatesGLes.glGetProgramNamedParameterdvNV));
			}
			if (SuportedExt.Contains("glGetProgramNamedParameterfvNV"))
			{
				dgtk.OpenGL.internalGLes.glGetProgramNamedParameterfvNV = (dgtk.OpenGL.delegatesGLes.glGetProgramNamedParameterfvNV) InternalTool.GetGLesMethodAdress("glGetProgramNamedParameterfvNV", typeof(dgtk.OpenGL.delegatesGLes.glGetProgramNamedParameterfvNV));
			}
			if (SuportedExt.Contains("glGetProgramParameterdvNV"))
			{
				dgtk.OpenGL.internalGLes.glGetProgramParameterdvNV = (dgtk.OpenGL.delegatesGLes.glGetProgramParameterdvNV) InternalTool.GetGLesMethodAdress("glGetProgramParameterdvNV", typeof(dgtk.OpenGL.delegatesGLes.glGetProgramParameterdvNV));
			}
			if (SuportedExt.Contains("glGetProgramParameterfvNV"))
			{
				dgtk.OpenGL.internalGLes.glGetProgramParameterfvNV = (dgtk.OpenGL.delegatesGLes.glGetProgramParameterfvNV) InternalTool.GetGLesMethodAdress("glGetProgramParameterfvNV", typeof(dgtk.OpenGL.delegatesGLes.glGetProgramParameterfvNV));
			}
			if (SuportedExt.Contains("glGetProgramPipelineInfoLogEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetProgramPipelineInfoLogEXT = (dgtk.OpenGL.delegatesGLes.glGetProgramPipelineInfoLogEXT) InternalTool.GetGLesMethodAdress("glGetProgramPipelineInfoLogEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetProgramPipelineInfoLogEXT));
			}
			if (SuportedExt.Contains("glGetProgramPipelineivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetProgramPipelineivEXT = (dgtk.OpenGL.delegatesGLes.glGetProgramPipelineivEXT) InternalTool.GetGLesMethodAdress("glGetProgramPipelineivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetProgramPipelineivEXT));
			}
			if (SuportedExt.Contains("glGetProgramResourcefvNV"))
			{
				dgtk.OpenGL.internalGLes.glGetProgramResourcefvNV = (dgtk.OpenGL.delegatesGLes.glGetProgramResourcefvNV) InternalTool.GetGLesMethodAdress("glGetProgramResourcefvNV", typeof(dgtk.OpenGL.delegatesGLes.glGetProgramResourcefvNV));
			}
			if (SuportedExt.Contains("glGetProgramResourceLocationIndexEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetProgramResourceLocationIndexEXT = (dgtk.OpenGL.delegatesGLes.glGetProgramResourceLocationIndexEXT) InternalTool.GetGLesMethodAdress("glGetProgramResourceLocationIndexEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetProgramResourceLocationIndexEXT));
			}
			if (SuportedExt.Contains("glGetProgramStringARB"))
			{
				dgtk.OpenGL.internalGLes.glGetProgramStringARB = (dgtk.OpenGL.delegatesGLes.glGetProgramStringARB) InternalTool.GetGLesMethodAdress("glGetProgramStringARB", typeof(dgtk.OpenGL.delegatesGLes.glGetProgramStringARB));
			}
			if (SuportedExt.Contains("glGetProgramStringNV"))
			{
				dgtk.OpenGL.internalGLes.glGetProgramStringNV = (dgtk.OpenGL.delegatesGLes.glGetProgramStringNV) InternalTool.GetGLesMethodAdress("glGetProgramStringNV", typeof(dgtk.OpenGL.delegatesGLes.glGetProgramStringNV));
			}
			if (SuportedExt.Contains("glGetProgramSubroutineParameteruivNV"))
			{
				dgtk.OpenGL.internalGLes.glGetProgramSubroutineParameteruivNV = (dgtk.OpenGL.delegatesGLes.glGetProgramSubroutineParameteruivNV) InternalTool.GetGLesMethodAdress("glGetProgramSubroutineParameteruivNV", typeof(dgtk.OpenGL.delegatesGLes.glGetProgramSubroutineParameteruivNV));
			}
			if (SuportedExt.Contains("glGetQueryivARB"))
			{
				dgtk.OpenGL.internalGLes.glGetQueryivARB = (dgtk.OpenGL.delegatesGLes.glGetQueryivARB) InternalTool.GetGLesMethodAdress("glGetQueryivARB", typeof(dgtk.OpenGL.delegatesGLes.glGetQueryivARB));
			}
			if (SuportedExt.Contains("glGetQueryivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetQueryivEXT = (dgtk.OpenGL.delegatesGLes.glGetQueryivEXT) InternalTool.GetGLesMethodAdress("glGetQueryivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetQueryivEXT));
			}
			if (SuportedExt.Contains("glGetQueryObjecti64vEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetQueryObjecti64vEXT = (dgtk.OpenGL.delegatesGLes.glGetQueryObjecti64vEXT) InternalTool.GetGLesMethodAdress("glGetQueryObjecti64vEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetQueryObjecti64vEXT));
			}
			if (SuportedExt.Contains("glGetQueryObjectivARB"))
			{
				dgtk.OpenGL.internalGLes.glGetQueryObjectivARB = (dgtk.OpenGL.delegatesGLes.glGetQueryObjectivARB) InternalTool.GetGLesMethodAdress("glGetQueryObjectivARB", typeof(dgtk.OpenGL.delegatesGLes.glGetQueryObjectivARB));
			}
			if (SuportedExt.Contains("glGetQueryObjectivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetQueryObjectivEXT = (dgtk.OpenGL.delegatesGLes.glGetQueryObjectivEXT) InternalTool.GetGLesMethodAdress("glGetQueryObjectivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetQueryObjectivEXT));
			}
			if (SuportedExt.Contains("glGetQueryObjectui64vEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetQueryObjectui64vEXT = (dgtk.OpenGL.delegatesGLes.glGetQueryObjectui64vEXT) InternalTool.GetGLesMethodAdress("glGetQueryObjectui64vEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetQueryObjectui64vEXT));
			}
			if (SuportedExt.Contains("glGetQueryObjectuivARB"))
			{
				dgtk.OpenGL.internalGLes.glGetQueryObjectuivARB = (dgtk.OpenGL.delegatesGLes.glGetQueryObjectuivARB) InternalTool.GetGLesMethodAdress("glGetQueryObjectuivARB", typeof(dgtk.OpenGL.delegatesGLes.glGetQueryObjectuivARB));
			}
			if (SuportedExt.Contains("glGetQueryObjectuivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetQueryObjectuivEXT = (dgtk.OpenGL.delegatesGLes.glGetQueryObjectuivEXT) InternalTool.GetGLesMethodAdress("glGetQueryObjectuivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetQueryObjectuivEXT));
			}
			if (SuportedExt.Contains("glGetRenderbufferParameterivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetRenderbufferParameterivEXT = (dgtk.OpenGL.delegatesGLes.glGetRenderbufferParameterivEXT) InternalTool.GetGLesMethodAdress("glGetRenderbufferParameterivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetRenderbufferParameterivEXT));
			}
			if (SuportedExt.Contains("glGetRenderbufferParameterivOES"))
			{
				dgtk.OpenGL.internalGLes.glGetRenderbufferParameterivOES = (dgtk.OpenGL.delegatesGLes.glGetRenderbufferParameterivOES) InternalTool.GetGLesMethodAdress("glGetRenderbufferParameterivOES", typeof(dgtk.OpenGL.delegatesGLes.glGetRenderbufferParameterivOES));
			}
			if (SuportedExt.Contains("glGetSamplerParameterIivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetSamplerParameterIivEXT = (dgtk.OpenGL.delegatesGLes.glGetSamplerParameterIivEXT) InternalTool.GetGLesMethodAdress("glGetSamplerParameterIivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetSamplerParameterIivEXT));
			}
			if (SuportedExt.Contains("glGetSamplerParameterIivOES"))
			{
				dgtk.OpenGL.internalGLes.glGetSamplerParameterIivOES = (dgtk.OpenGL.delegatesGLes.glGetSamplerParameterIivOES) InternalTool.GetGLesMethodAdress("glGetSamplerParameterIivOES", typeof(dgtk.OpenGL.delegatesGLes.glGetSamplerParameterIivOES));
			}
			if (SuportedExt.Contains("glGetSamplerParameterIuivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetSamplerParameterIuivEXT = (dgtk.OpenGL.delegatesGLes.glGetSamplerParameterIuivEXT) InternalTool.GetGLesMethodAdress("glGetSamplerParameterIuivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetSamplerParameterIuivEXT));
			}
			if (SuportedExt.Contains("glGetSamplerParameterIuivOES"))
			{
				dgtk.OpenGL.internalGLes.glGetSamplerParameterIuivOES = (dgtk.OpenGL.delegatesGLes.glGetSamplerParameterIuivOES) InternalTool.GetGLesMethodAdress("glGetSamplerParameterIuivOES", typeof(dgtk.OpenGL.delegatesGLes.glGetSamplerParameterIuivOES));
			}
			if (SuportedExt.Contains("glGetSemaphoreParameterivNV"))
			{
				dgtk.OpenGL.internalGLes.glGetSemaphoreParameterivNV = (dgtk.OpenGL.delegatesGLes.glGetSemaphoreParameterivNV) InternalTool.GetGLesMethodAdress("glGetSemaphoreParameterivNV", typeof(dgtk.OpenGL.delegatesGLes.glGetSemaphoreParameterivNV));
			}
			if (SuportedExt.Contains("glGetSemaphoreParameterui64vEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetSemaphoreParameterui64vEXT = (dgtk.OpenGL.delegatesGLes.glGetSemaphoreParameterui64vEXT) InternalTool.GetGLesMethodAdress("glGetSemaphoreParameterui64vEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetSemaphoreParameterui64vEXT));
			}
			if (SuportedExt.Contains("glGetSeparableFilter"))
			{
				dgtk.OpenGL.internalGLes.glGetSeparableFilter = (dgtk.OpenGL.delegatesGLes.glGetSeparableFilter) InternalTool.GetGLesMethodAdress("glGetSeparableFilter", typeof(dgtk.OpenGL.delegatesGLes.glGetSeparableFilter));
			}
			if (SuportedExt.Contains("glGetSeparableFilterEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetSeparableFilterEXT = (dgtk.OpenGL.delegatesGLes.glGetSeparableFilterEXT) InternalTool.GetGLesMethodAdress("glGetSeparableFilterEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetSeparableFilterEXT));
			}
			if (SuportedExt.Contains("glGetShaderSourceARB"))
			{
				dgtk.OpenGL.internalGLes.glGetShaderSourceARB = (dgtk.OpenGL.delegatesGLes.glGetShaderSourceARB) InternalTool.GetGLesMethodAdress("glGetShaderSourceARB", typeof(dgtk.OpenGL.delegatesGLes.glGetShaderSourceARB));
			}
			if (SuportedExt.Contains("glGetShadingRateImagePaletteNV"))
			{
				dgtk.OpenGL.internalGLes.glGetShadingRateImagePaletteNV = (dgtk.OpenGL.delegatesGLes.glGetShadingRateImagePaletteNV) InternalTool.GetGLesMethodAdress("glGetShadingRateImagePaletteNV", typeof(dgtk.OpenGL.delegatesGLes.glGetShadingRateImagePaletteNV));
			}
			if (SuportedExt.Contains("glGetShadingRateSampleLocationivNV"))
			{
				dgtk.OpenGL.internalGLes.glGetShadingRateSampleLocationivNV = (dgtk.OpenGL.delegatesGLes.glGetShadingRateSampleLocationivNV) InternalTool.GetGLesMethodAdress("glGetShadingRateSampleLocationivNV", typeof(dgtk.OpenGL.delegatesGLes.glGetShadingRateSampleLocationivNV));
			}
			if (SuportedExt.Contains("glGetSharpenTexFuncSGIS"))
			{
				dgtk.OpenGL.internalGLes.glGetSharpenTexFuncSGIS = (dgtk.OpenGL.delegatesGLes.glGetSharpenTexFuncSGIS) InternalTool.GetGLesMethodAdress("glGetSharpenTexFuncSGIS", typeof(dgtk.OpenGL.delegatesGLes.glGetSharpenTexFuncSGIS));
			}
			if (SuportedExt.Contains("glGetStageIndexNV"))
			{
				dgtk.OpenGL.internalGLes.glGetStageIndexNV = (dgtk.OpenGL.delegatesGLes.glGetStageIndexNV) InternalTool.GetGLesMethodAdress("glGetStageIndexNV", typeof(dgtk.OpenGL.delegatesGLes.glGetStageIndexNV));
			}
			if (SuportedExt.Contains("glGetSyncivAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glGetSyncivAPPLE = (dgtk.OpenGL.delegatesGLes.glGetSyncivAPPLE) InternalTool.GetGLesMethodAdress("glGetSyncivAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glGetSyncivAPPLE));
			}
			if (SuportedExt.Contains("glGetTexBumpParameterfvATI"))
			{
				dgtk.OpenGL.internalGLes.glGetTexBumpParameterfvATI = (dgtk.OpenGL.delegatesGLes.glGetTexBumpParameterfvATI) InternalTool.GetGLesMethodAdress("glGetTexBumpParameterfvATI", typeof(dgtk.OpenGL.delegatesGLes.glGetTexBumpParameterfvATI));
			}
			if (SuportedExt.Contains("glGetTexBumpParameterivATI"))
			{
				dgtk.OpenGL.internalGLes.glGetTexBumpParameterivATI = (dgtk.OpenGL.delegatesGLes.glGetTexBumpParameterivATI) InternalTool.GetGLesMethodAdress("glGetTexBumpParameterivATI", typeof(dgtk.OpenGL.delegatesGLes.glGetTexBumpParameterivATI));
			}
			if (SuportedExt.Contains("glGetTexEnvxv"))
			{
				dgtk.OpenGL.internalGLes.glGetTexEnvxv = (dgtk.OpenGL.delegatesGLes.glGetTexEnvxv) InternalTool.GetGLesMethodAdress("glGetTexEnvxv", typeof(dgtk.OpenGL.delegatesGLes.glGetTexEnvxv));
			}
			if (SuportedExt.Contains("glGetTexEnvxvOES"))
			{
				dgtk.OpenGL.internalGLes.glGetTexEnvxvOES = (dgtk.OpenGL.delegatesGLes.glGetTexEnvxvOES) InternalTool.GetGLesMethodAdress("glGetTexEnvxvOES", typeof(dgtk.OpenGL.delegatesGLes.glGetTexEnvxvOES));
			}
			if (SuportedExt.Contains("glGetTexFilterFuncSGIS"))
			{
				dgtk.OpenGL.internalGLes.glGetTexFilterFuncSGIS = (dgtk.OpenGL.delegatesGLes.glGetTexFilterFuncSGIS) InternalTool.GetGLesMethodAdress("glGetTexFilterFuncSGIS", typeof(dgtk.OpenGL.delegatesGLes.glGetTexFilterFuncSGIS));
			}
			if (SuportedExt.Contains("glGetTexGenfvOES"))
			{
				dgtk.OpenGL.internalGLes.glGetTexGenfvOES = (dgtk.OpenGL.delegatesGLes.glGetTexGenfvOES) InternalTool.GetGLesMethodAdress("glGetTexGenfvOES", typeof(dgtk.OpenGL.delegatesGLes.glGetTexGenfvOES));
			}
			if (SuportedExt.Contains("glGetTexGenivOES"))
			{
				dgtk.OpenGL.internalGLes.glGetTexGenivOES = (dgtk.OpenGL.delegatesGLes.glGetTexGenivOES) InternalTool.GetGLesMethodAdress("glGetTexGenivOES", typeof(dgtk.OpenGL.delegatesGLes.glGetTexGenivOES));
			}
			if (SuportedExt.Contains("glGetTexGenxvOES"))
			{
				dgtk.OpenGL.internalGLes.glGetTexGenxvOES = (dgtk.OpenGL.delegatesGLes.glGetTexGenxvOES) InternalTool.GetGLesMethodAdress("glGetTexGenxvOES", typeof(dgtk.OpenGL.delegatesGLes.glGetTexGenxvOES));
			}
			if (SuportedExt.Contains("glGetTexLevelParameterxvOES"))
			{
				dgtk.OpenGL.internalGLes.glGetTexLevelParameterxvOES = (dgtk.OpenGL.delegatesGLes.glGetTexLevelParameterxvOES) InternalTool.GetGLesMethodAdress("glGetTexLevelParameterxvOES", typeof(dgtk.OpenGL.delegatesGLes.glGetTexLevelParameterxvOES));
			}
			if (SuportedExt.Contains("glGetTexParameterIivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetTexParameterIivEXT = (dgtk.OpenGL.delegatesGLes.glGetTexParameterIivEXT) InternalTool.GetGLesMethodAdress("glGetTexParameterIivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetTexParameterIivEXT));
			}
			if (SuportedExt.Contains("glGetTexParameterIivOES"))
			{
				dgtk.OpenGL.internalGLes.glGetTexParameterIivOES = (dgtk.OpenGL.delegatesGLes.glGetTexParameterIivOES) InternalTool.GetGLesMethodAdress("glGetTexParameterIivOES", typeof(dgtk.OpenGL.delegatesGLes.glGetTexParameterIivOES));
			}
			if (SuportedExt.Contains("glGetTexParameterIuivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetTexParameterIuivEXT = (dgtk.OpenGL.delegatesGLes.glGetTexParameterIuivEXT) InternalTool.GetGLesMethodAdress("glGetTexParameterIuivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetTexParameterIuivEXT));
			}
			if (SuportedExt.Contains("glGetTexParameterIuivOES"))
			{
				dgtk.OpenGL.internalGLes.glGetTexParameterIuivOES = (dgtk.OpenGL.delegatesGLes.glGetTexParameterIuivOES) InternalTool.GetGLesMethodAdress("glGetTexParameterIuivOES", typeof(dgtk.OpenGL.delegatesGLes.glGetTexParameterIuivOES));
			}
			if (SuportedExt.Contains("glGetTexParameterPointervAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glGetTexParameterPointervAPPLE = (dgtk.OpenGL.delegatesGLes.glGetTexParameterPointervAPPLE) InternalTool.GetGLesMethodAdress("glGetTexParameterPointervAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glGetTexParameterPointervAPPLE));
			}
			if (SuportedExt.Contains("glGetTexParameterxv"))
			{
				dgtk.OpenGL.internalGLes.glGetTexParameterxv = (dgtk.OpenGL.delegatesGLes.glGetTexParameterxv) InternalTool.GetGLesMethodAdress("glGetTexParameterxv", typeof(dgtk.OpenGL.delegatesGLes.glGetTexParameterxv));
			}
			if (SuportedExt.Contains("glGetTexParameterxvOES"))
			{
				dgtk.OpenGL.internalGLes.glGetTexParameterxvOES = (dgtk.OpenGL.delegatesGLes.glGetTexParameterxvOES) InternalTool.GetGLesMethodAdress("glGetTexParameterxvOES", typeof(dgtk.OpenGL.delegatesGLes.glGetTexParameterxvOES));
			}
			if (SuportedExt.Contains("glGetTextureHandleARB"))
			{
				dgtk.OpenGL.internalGLes.glGetTextureHandleARB = (dgtk.OpenGL.delegatesGLes.glGetTextureHandleARB) InternalTool.GetGLesMethodAdress("glGetTextureHandleARB", typeof(dgtk.OpenGL.delegatesGLes.glGetTextureHandleARB));
			}
			if (SuportedExt.Contains("glGetTextureHandleIMG"))
			{
				dgtk.OpenGL.internalGLes.glGetTextureHandleIMG = (dgtk.OpenGL.delegatesGLes.glGetTextureHandleIMG) InternalTool.GetGLesMethodAdress("glGetTextureHandleIMG", typeof(dgtk.OpenGL.delegatesGLes.glGetTextureHandleIMG));
			}
			if (SuportedExt.Contains("glGetTextureHandleNV"))
			{
				dgtk.OpenGL.internalGLes.glGetTextureHandleNV = (dgtk.OpenGL.delegatesGLes.glGetTextureHandleNV) InternalTool.GetGLesMethodAdress("glGetTextureHandleNV", typeof(dgtk.OpenGL.delegatesGLes.glGetTextureHandleNV));
			}
			if (SuportedExt.Contains("glGetTextureImageEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetTextureImageEXT = (dgtk.OpenGL.delegatesGLes.glGetTextureImageEXT) InternalTool.GetGLesMethodAdress("glGetTextureImageEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetTextureImageEXT));
			}
			if (SuportedExt.Contains("glGetTextureLevelParameterfvEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetTextureLevelParameterfvEXT = (dgtk.OpenGL.delegatesGLes.glGetTextureLevelParameterfvEXT) InternalTool.GetGLesMethodAdress("glGetTextureLevelParameterfvEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetTextureLevelParameterfvEXT));
			}
			if (SuportedExt.Contains("glGetTextureLevelParameterivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetTextureLevelParameterivEXT = (dgtk.OpenGL.delegatesGLes.glGetTextureLevelParameterivEXT) InternalTool.GetGLesMethodAdress("glGetTextureLevelParameterivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetTextureLevelParameterivEXT));
			}
			if (SuportedExt.Contains("glGetTextureParameterfvEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetTextureParameterfvEXT = (dgtk.OpenGL.delegatesGLes.glGetTextureParameterfvEXT) InternalTool.GetGLesMethodAdress("glGetTextureParameterfvEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetTextureParameterfvEXT));
			}
			if (SuportedExt.Contains("glGetTextureParameterIivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetTextureParameterIivEXT = (dgtk.OpenGL.delegatesGLes.glGetTextureParameterIivEXT) InternalTool.GetGLesMethodAdress("glGetTextureParameterIivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetTextureParameterIivEXT));
			}
			if (SuportedExt.Contains("glGetTextureParameterIuivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetTextureParameterIuivEXT = (dgtk.OpenGL.delegatesGLes.glGetTextureParameterIuivEXT) InternalTool.GetGLesMethodAdress("glGetTextureParameterIuivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetTextureParameterIuivEXT));
			}
			if (SuportedExt.Contains("glGetTextureParameterivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetTextureParameterivEXT = (dgtk.OpenGL.delegatesGLes.glGetTextureParameterivEXT) InternalTool.GetGLesMethodAdress("glGetTextureParameterivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetTextureParameterivEXT));
			}
			if (SuportedExt.Contains("glGetTextureSamplerHandleARB"))
			{
				dgtk.OpenGL.internalGLes.glGetTextureSamplerHandleARB = (dgtk.OpenGL.delegatesGLes.glGetTextureSamplerHandleARB) InternalTool.GetGLesMethodAdress("glGetTextureSamplerHandleARB", typeof(dgtk.OpenGL.delegatesGLes.glGetTextureSamplerHandleARB));
			}
			if (SuportedExt.Contains("glGetTextureSamplerHandleIMG"))
			{
				dgtk.OpenGL.internalGLes.glGetTextureSamplerHandleIMG = (dgtk.OpenGL.delegatesGLes.glGetTextureSamplerHandleIMG) InternalTool.GetGLesMethodAdress("glGetTextureSamplerHandleIMG", typeof(dgtk.OpenGL.delegatesGLes.glGetTextureSamplerHandleIMG));
			}
			if (SuportedExt.Contains("glGetTextureSamplerHandleNV"))
			{
				dgtk.OpenGL.internalGLes.glGetTextureSamplerHandleNV = (dgtk.OpenGL.delegatesGLes.glGetTextureSamplerHandleNV) InternalTool.GetGLesMethodAdress("glGetTextureSamplerHandleNV", typeof(dgtk.OpenGL.delegatesGLes.glGetTextureSamplerHandleNV));
			}
			if (SuportedExt.Contains("glGetTrackMatrixivNV"))
			{
				dgtk.OpenGL.internalGLes.glGetTrackMatrixivNV = (dgtk.OpenGL.delegatesGLes.glGetTrackMatrixivNV) InternalTool.GetGLesMethodAdress("glGetTrackMatrixivNV", typeof(dgtk.OpenGL.delegatesGLes.glGetTrackMatrixivNV));
			}
			if (SuportedExt.Contains("glGetTransformFeedbackVaryingEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetTransformFeedbackVaryingEXT = (dgtk.OpenGL.delegatesGLes.glGetTransformFeedbackVaryingEXT) InternalTool.GetGLesMethodAdress("glGetTransformFeedbackVaryingEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetTransformFeedbackVaryingEXT));
			}
			if (SuportedExt.Contains("glGetTransformFeedbackVaryingNV"))
			{
				dgtk.OpenGL.internalGLes.glGetTransformFeedbackVaryingNV = (dgtk.OpenGL.delegatesGLes.glGetTransformFeedbackVaryingNV) InternalTool.GetGLesMethodAdress("glGetTransformFeedbackVaryingNV", typeof(dgtk.OpenGL.delegatesGLes.glGetTransformFeedbackVaryingNV));
			}
			if (SuportedExt.Contains("glGetTranslatedShaderSourceANGLE"))
			{
				dgtk.OpenGL.internalGLes.glGetTranslatedShaderSourceANGLE = (dgtk.OpenGL.delegatesGLes.glGetTranslatedShaderSourceANGLE) InternalTool.GetGLesMethodAdress("glGetTranslatedShaderSourceANGLE", typeof(dgtk.OpenGL.delegatesGLes.glGetTranslatedShaderSourceANGLE));
			}
			if (SuportedExt.Contains("glGetUniformBufferSizeEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetUniformBufferSizeEXT = (dgtk.OpenGL.delegatesGLes.glGetUniformBufferSizeEXT) InternalTool.GetGLesMethodAdress("glGetUniformBufferSizeEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetUniformBufferSizeEXT));
			}
			if (SuportedExt.Contains("glGetUniformfvARB"))
			{
				dgtk.OpenGL.internalGLes.glGetUniformfvARB = (dgtk.OpenGL.delegatesGLes.glGetUniformfvARB) InternalTool.GetGLesMethodAdress("glGetUniformfvARB", typeof(dgtk.OpenGL.delegatesGLes.glGetUniformfvARB));
			}
			if (SuportedExt.Contains("glGetUniformi64vARB"))
			{
				dgtk.OpenGL.internalGLes.glGetUniformi64vARB = (dgtk.OpenGL.delegatesGLes.glGetUniformi64vARB) InternalTool.GetGLesMethodAdress("glGetUniformi64vARB", typeof(dgtk.OpenGL.delegatesGLes.glGetUniformi64vARB));
			}
			if (SuportedExt.Contains("glGetUniformi64vNV"))
			{
				dgtk.OpenGL.internalGLes.glGetUniformi64vNV = (dgtk.OpenGL.delegatesGLes.glGetUniformi64vNV) InternalTool.GetGLesMethodAdress("glGetUniformi64vNV", typeof(dgtk.OpenGL.delegatesGLes.glGetUniformi64vNV));
			}
			if (SuportedExt.Contains("glGetUniformivARB"))
			{
				dgtk.OpenGL.internalGLes.glGetUniformivARB = (dgtk.OpenGL.delegatesGLes.glGetUniformivARB) InternalTool.GetGLesMethodAdress("glGetUniformivARB", typeof(dgtk.OpenGL.delegatesGLes.glGetUniformivARB));
			}
			if (SuportedExt.Contains("glGetUniformLocationARB"))
			{
				dgtk.OpenGL.internalGLes.glGetUniformLocationARB = (dgtk.OpenGL.delegatesGLes.glGetUniformLocationARB) InternalTool.GetGLesMethodAdress("glGetUniformLocationARB", typeof(dgtk.OpenGL.delegatesGLes.glGetUniformLocationARB));
			}
			if (SuportedExt.Contains("glGetUniformOffsetEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetUniformOffsetEXT = (dgtk.OpenGL.delegatesGLes.glGetUniformOffsetEXT) InternalTool.GetGLesMethodAdress("glGetUniformOffsetEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetUniformOffsetEXT));
			}
			if (SuportedExt.Contains("glGetUniformui64vARB"))
			{
				dgtk.OpenGL.internalGLes.glGetUniformui64vARB = (dgtk.OpenGL.delegatesGLes.glGetUniformui64vARB) InternalTool.GetGLesMethodAdress("glGetUniformui64vARB", typeof(dgtk.OpenGL.delegatesGLes.glGetUniformui64vARB));
			}
			if (SuportedExt.Contains("glGetUniformui64vNV"))
			{
				dgtk.OpenGL.internalGLes.glGetUniformui64vNV = (dgtk.OpenGL.delegatesGLes.glGetUniformui64vNV) InternalTool.GetGLesMethodAdress("glGetUniformui64vNV", typeof(dgtk.OpenGL.delegatesGLes.glGetUniformui64vNV));
			}
			if (SuportedExt.Contains("glGetUniformuivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetUniformuivEXT = (dgtk.OpenGL.delegatesGLes.glGetUniformuivEXT) InternalTool.GetGLesMethodAdress("glGetUniformuivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetUniformuivEXT));
			}
			if (SuportedExt.Contains("glGetUnsignedBytei_vEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetUnsignedBytei_vEXT = (dgtk.OpenGL.delegatesGLes.glGetUnsignedBytei_vEXT) InternalTool.GetGLesMethodAdress("glGetUnsignedBytei_vEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetUnsignedBytei_vEXT));
			}
			if (SuportedExt.Contains("glGetUnsignedBytevEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetUnsignedBytevEXT = (dgtk.OpenGL.delegatesGLes.glGetUnsignedBytevEXT) InternalTool.GetGLesMethodAdress("glGetUnsignedBytevEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetUnsignedBytevEXT));
			}
			if (SuportedExt.Contains("glGetVariantArrayObjectfvATI"))
			{
				dgtk.OpenGL.internalGLes.glGetVariantArrayObjectfvATI = (dgtk.OpenGL.delegatesGLes.glGetVariantArrayObjectfvATI) InternalTool.GetGLesMethodAdress("glGetVariantArrayObjectfvATI", typeof(dgtk.OpenGL.delegatesGLes.glGetVariantArrayObjectfvATI));
			}
			if (SuportedExt.Contains("glGetVariantArrayObjectivATI"))
			{
				dgtk.OpenGL.internalGLes.glGetVariantArrayObjectivATI = (dgtk.OpenGL.delegatesGLes.glGetVariantArrayObjectivATI) InternalTool.GetGLesMethodAdress("glGetVariantArrayObjectivATI", typeof(dgtk.OpenGL.delegatesGLes.glGetVariantArrayObjectivATI));
			}
			if (SuportedExt.Contains("glGetVariantBooleanvEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetVariantBooleanvEXT = (dgtk.OpenGL.delegatesGLes.glGetVariantBooleanvEXT) InternalTool.GetGLesMethodAdress("glGetVariantBooleanvEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetVariantBooleanvEXT));
			}
			if (SuportedExt.Contains("glGetVariantFloatvEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetVariantFloatvEXT = (dgtk.OpenGL.delegatesGLes.glGetVariantFloatvEXT) InternalTool.GetGLesMethodAdress("glGetVariantFloatvEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetVariantFloatvEXT));
			}
			if (SuportedExt.Contains("glGetVariantIntegervEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetVariantIntegervEXT = (dgtk.OpenGL.delegatesGLes.glGetVariantIntegervEXT) InternalTool.GetGLesMethodAdress("glGetVariantIntegervEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetVariantIntegervEXT));
			}
			if (SuportedExt.Contains("glGetVariantPointervEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetVariantPointervEXT = (dgtk.OpenGL.delegatesGLes.glGetVariantPointervEXT) InternalTool.GetGLesMethodAdress("glGetVariantPointervEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetVariantPointervEXT));
			}
			if (SuportedExt.Contains("glGetVaryingLocationNV"))
			{
				dgtk.OpenGL.internalGLes.glGetVaryingLocationNV = (dgtk.OpenGL.delegatesGLes.glGetVaryingLocationNV) InternalTool.GetGLesMethodAdress("glGetVaryingLocationNV", typeof(dgtk.OpenGL.delegatesGLes.glGetVaryingLocationNV));
			}
			if (SuportedExt.Contains("glGetVertexArrayIntegeri_vEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetVertexArrayIntegeri_vEXT = (dgtk.OpenGL.delegatesGLes.glGetVertexArrayIntegeri_vEXT) InternalTool.GetGLesMethodAdress("glGetVertexArrayIntegeri_vEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetVertexArrayIntegeri_vEXT));
			}
			if (SuportedExt.Contains("glGetVertexArrayIntegervEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetVertexArrayIntegervEXT = (dgtk.OpenGL.delegatesGLes.glGetVertexArrayIntegervEXT) InternalTool.GetGLesMethodAdress("glGetVertexArrayIntegervEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetVertexArrayIntegervEXT));
			}
			if (SuportedExt.Contains("glGetVertexArrayPointeri_vEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetVertexArrayPointeri_vEXT = (dgtk.OpenGL.delegatesGLes.glGetVertexArrayPointeri_vEXT) InternalTool.GetGLesMethodAdress("glGetVertexArrayPointeri_vEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetVertexArrayPointeri_vEXT));
			}
			if (SuportedExt.Contains("glGetVertexArrayPointervEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetVertexArrayPointervEXT = (dgtk.OpenGL.delegatesGLes.glGetVertexArrayPointervEXT) InternalTool.GetGLesMethodAdress("glGetVertexArrayPointervEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetVertexArrayPointervEXT));
			}
			if (SuportedExt.Contains("glGetVertexAttribArrayObjectfvATI"))
			{
				dgtk.OpenGL.internalGLes.glGetVertexAttribArrayObjectfvATI = (dgtk.OpenGL.delegatesGLes.glGetVertexAttribArrayObjectfvATI) InternalTool.GetGLesMethodAdress("glGetVertexAttribArrayObjectfvATI", typeof(dgtk.OpenGL.delegatesGLes.glGetVertexAttribArrayObjectfvATI));
			}
			if (SuportedExt.Contains("glGetVertexAttribArrayObjectivATI"))
			{
				dgtk.OpenGL.internalGLes.glGetVertexAttribArrayObjectivATI = (dgtk.OpenGL.delegatesGLes.glGetVertexAttribArrayObjectivATI) InternalTool.GetGLesMethodAdress("glGetVertexAttribArrayObjectivATI", typeof(dgtk.OpenGL.delegatesGLes.glGetVertexAttribArrayObjectivATI));
			}
			if (SuportedExt.Contains("glGetVertexAttribdvARB"))
			{
				dgtk.OpenGL.internalGLes.glGetVertexAttribdvARB = (dgtk.OpenGL.delegatesGLes.glGetVertexAttribdvARB) InternalTool.GetGLesMethodAdress("glGetVertexAttribdvARB", typeof(dgtk.OpenGL.delegatesGLes.glGetVertexAttribdvARB));
			}
			if (SuportedExt.Contains("glGetVertexAttribdvNV"))
			{
				dgtk.OpenGL.internalGLes.glGetVertexAttribdvNV = (dgtk.OpenGL.delegatesGLes.glGetVertexAttribdvNV) InternalTool.GetGLesMethodAdress("glGetVertexAttribdvNV", typeof(dgtk.OpenGL.delegatesGLes.glGetVertexAttribdvNV));
			}
			if (SuportedExt.Contains("glGetVertexAttribfvARB"))
			{
				dgtk.OpenGL.internalGLes.glGetVertexAttribfvARB = (dgtk.OpenGL.delegatesGLes.glGetVertexAttribfvARB) InternalTool.GetGLesMethodAdress("glGetVertexAttribfvARB", typeof(dgtk.OpenGL.delegatesGLes.glGetVertexAttribfvARB));
			}
			if (SuportedExt.Contains("glGetVertexAttribfvNV"))
			{
				dgtk.OpenGL.internalGLes.glGetVertexAttribfvNV = (dgtk.OpenGL.delegatesGLes.glGetVertexAttribfvNV) InternalTool.GetGLesMethodAdress("glGetVertexAttribfvNV", typeof(dgtk.OpenGL.delegatesGLes.glGetVertexAttribfvNV));
			}
			if (SuportedExt.Contains("glGetVertexAttribIivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetVertexAttribIivEXT = (dgtk.OpenGL.delegatesGLes.glGetVertexAttribIivEXT) InternalTool.GetGLesMethodAdress("glGetVertexAttribIivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetVertexAttribIivEXT));
			}
			if (SuportedExt.Contains("glGetVertexAttribIuivEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetVertexAttribIuivEXT = (dgtk.OpenGL.delegatesGLes.glGetVertexAttribIuivEXT) InternalTool.GetGLesMethodAdress("glGetVertexAttribIuivEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetVertexAttribIuivEXT));
			}
			if (SuportedExt.Contains("glGetVertexAttribivARB"))
			{
				dgtk.OpenGL.internalGLes.glGetVertexAttribivARB = (dgtk.OpenGL.delegatesGLes.glGetVertexAttribivARB) InternalTool.GetGLesMethodAdress("glGetVertexAttribivARB", typeof(dgtk.OpenGL.delegatesGLes.glGetVertexAttribivARB));
			}
			if (SuportedExt.Contains("glGetVertexAttribivNV"))
			{
				dgtk.OpenGL.internalGLes.glGetVertexAttribivNV = (dgtk.OpenGL.delegatesGLes.glGetVertexAttribivNV) InternalTool.GetGLesMethodAdress("glGetVertexAttribivNV", typeof(dgtk.OpenGL.delegatesGLes.glGetVertexAttribivNV));
			}
			if (SuportedExt.Contains("glGetVertexAttribLdvEXT"))
			{
				dgtk.OpenGL.internalGLes.glGetVertexAttribLdvEXT = (dgtk.OpenGL.delegatesGLes.glGetVertexAttribLdvEXT) InternalTool.GetGLesMethodAdress("glGetVertexAttribLdvEXT", typeof(dgtk.OpenGL.delegatesGLes.glGetVertexAttribLdvEXT));
			}
			if (SuportedExt.Contains("glGetVertexAttribLi64vNV"))
			{
				dgtk.OpenGL.internalGLes.glGetVertexAttribLi64vNV = (dgtk.OpenGL.delegatesGLes.glGetVertexAttribLi64vNV) InternalTool.GetGLesMethodAdress("glGetVertexAttribLi64vNV", typeof(dgtk.OpenGL.delegatesGLes.glGetVertexAttribLi64vNV));
			}
			if (SuportedExt.Contains("glGetVertexAttribLui64vARB"))
			{
				dgtk.OpenGL.internalGLes.glGetVertexAttribLui64vARB = (dgtk.OpenGL.delegatesGLes.glGetVertexAttribLui64vARB) InternalTool.GetGLesMethodAdress("glGetVertexAttribLui64vARB", typeof(dgtk.OpenGL.delegatesGLes.glGetVertexAttribLui64vARB));
			}
			if (SuportedExt.Contains("glGetVertexAttribLui64vNV"))
			{
				dgtk.OpenGL.internalGLes.glGetVertexAttribLui64vNV = (dgtk.OpenGL.delegatesGLes.glGetVertexAttribLui64vNV) InternalTool.GetGLesMethodAdress("glGetVertexAttribLui64vNV", typeof(dgtk.OpenGL.delegatesGLes.glGetVertexAttribLui64vNV));
			}
			if (SuportedExt.Contains("glGetVertexAttribPointervARB"))
			{
				dgtk.OpenGL.internalGLes.glGetVertexAttribPointervARB = (dgtk.OpenGL.delegatesGLes.glGetVertexAttribPointervARB) InternalTool.GetGLesMethodAdress("glGetVertexAttribPointervARB", typeof(dgtk.OpenGL.delegatesGLes.glGetVertexAttribPointervARB));
			}
			if (SuportedExt.Contains("glGetVertexAttribPointervNV"))
			{
				dgtk.OpenGL.internalGLes.glGetVertexAttribPointervNV = (dgtk.OpenGL.delegatesGLes.glGetVertexAttribPointervNV) InternalTool.GetGLesMethodAdress("glGetVertexAttribPointervNV", typeof(dgtk.OpenGL.delegatesGLes.glGetVertexAttribPointervNV));
			}
			if (SuportedExt.Contains("glGetVideoCaptureivNV"))
			{
				dgtk.OpenGL.internalGLes.glGetVideoCaptureivNV = (dgtk.OpenGL.delegatesGLes.glGetVideoCaptureivNV) InternalTool.GetGLesMethodAdress("glGetVideoCaptureivNV", typeof(dgtk.OpenGL.delegatesGLes.glGetVideoCaptureivNV));
			}
			if (SuportedExt.Contains("glGetVideoCaptureStreamdvNV"))
			{
				dgtk.OpenGL.internalGLes.glGetVideoCaptureStreamdvNV = (dgtk.OpenGL.delegatesGLes.glGetVideoCaptureStreamdvNV) InternalTool.GetGLesMethodAdress("glGetVideoCaptureStreamdvNV", typeof(dgtk.OpenGL.delegatesGLes.glGetVideoCaptureStreamdvNV));
			}
			if (SuportedExt.Contains("glGetVideoCaptureStreamfvNV"))
			{
				dgtk.OpenGL.internalGLes.glGetVideoCaptureStreamfvNV = (dgtk.OpenGL.delegatesGLes.glGetVideoCaptureStreamfvNV) InternalTool.GetGLesMethodAdress("glGetVideoCaptureStreamfvNV", typeof(dgtk.OpenGL.delegatesGLes.glGetVideoCaptureStreamfvNV));
			}
			if (SuportedExt.Contains("glGetVideoCaptureStreamivNV"))
			{
				dgtk.OpenGL.internalGLes.glGetVideoCaptureStreamivNV = (dgtk.OpenGL.delegatesGLes.glGetVideoCaptureStreamivNV) InternalTool.GetGLesMethodAdress("glGetVideoCaptureStreamivNV", typeof(dgtk.OpenGL.delegatesGLes.glGetVideoCaptureStreamivNV));
			}
			if (SuportedExt.Contains("glGetVideoi64vNV"))
			{
				dgtk.OpenGL.internalGLes.glGetVideoi64vNV = (dgtk.OpenGL.delegatesGLes.glGetVideoi64vNV) InternalTool.GetGLesMethodAdress("glGetVideoi64vNV", typeof(dgtk.OpenGL.delegatesGLes.glGetVideoi64vNV));
			}
			if (SuportedExt.Contains("glGetVideoivNV"))
			{
				dgtk.OpenGL.internalGLes.glGetVideoivNV = (dgtk.OpenGL.delegatesGLes.glGetVideoivNV) InternalTool.GetGLesMethodAdress("glGetVideoivNV", typeof(dgtk.OpenGL.delegatesGLes.glGetVideoivNV));
			}
			if (SuportedExt.Contains("glGetVideoui64vNV"))
			{
				dgtk.OpenGL.internalGLes.glGetVideoui64vNV = (dgtk.OpenGL.delegatesGLes.glGetVideoui64vNV) InternalTool.GetGLesMethodAdress("glGetVideoui64vNV", typeof(dgtk.OpenGL.delegatesGLes.glGetVideoui64vNV));
			}
			if (SuportedExt.Contains("glGetVideouivNV"))
			{
				dgtk.OpenGL.internalGLes.glGetVideouivNV = (dgtk.OpenGL.delegatesGLes.glGetVideouivNV) InternalTool.GetGLesMethodAdress("glGetVideouivNV", typeof(dgtk.OpenGL.delegatesGLes.glGetVideouivNV));
			}
			if (SuportedExt.Contains("glGetVkProcAddrNV"))
			{
				dgtk.OpenGL.internalGLes.glGetVkProcAddrNV = (dgtk.OpenGL.delegatesGLes.glGetVkProcAddrNV) InternalTool.GetGLesMethodAdress("glGetVkProcAddrNV", typeof(dgtk.OpenGL.delegatesGLes.glGetVkProcAddrNV));
			}
			if (SuportedExt.Contains("glGlobalAlphaFactorbSUN"))
			{
				dgtk.OpenGL.internalGLes.glGlobalAlphaFactorbSUN = (dgtk.OpenGL.delegatesGLes.glGlobalAlphaFactorbSUN) InternalTool.GetGLesMethodAdress("glGlobalAlphaFactorbSUN", typeof(dgtk.OpenGL.delegatesGLes.glGlobalAlphaFactorbSUN));
			}
			if (SuportedExt.Contains("glGlobalAlphaFactordSUN"))
			{
				dgtk.OpenGL.internalGLes.glGlobalAlphaFactordSUN = (dgtk.OpenGL.delegatesGLes.glGlobalAlphaFactordSUN) InternalTool.GetGLesMethodAdress("glGlobalAlphaFactordSUN", typeof(dgtk.OpenGL.delegatesGLes.glGlobalAlphaFactordSUN));
			}
			if (SuportedExt.Contains("glGlobalAlphaFactorfSUN"))
			{
				dgtk.OpenGL.internalGLes.glGlobalAlphaFactorfSUN = (dgtk.OpenGL.delegatesGLes.glGlobalAlphaFactorfSUN) InternalTool.GetGLesMethodAdress("glGlobalAlphaFactorfSUN", typeof(dgtk.OpenGL.delegatesGLes.glGlobalAlphaFactorfSUN));
			}
			if (SuportedExt.Contains("glGlobalAlphaFactoriSUN"))
			{
				dgtk.OpenGL.internalGLes.glGlobalAlphaFactoriSUN = (dgtk.OpenGL.delegatesGLes.glGlobalAlphaFactoriSUN) InternalTool.GetGLesMethodAdress("glGlobalAlphaFactoriSUN", typeof(dgtk.OpenGL.delegatesGLes.glGlobalAlphaFactoriSUN));
			}
			if (SuportedExt.Contains("glGlobalAlphaFactorsSUN"))
			{
				dgtk.OpenGL.internalGLes.glGlobalAlphaFactorsSUN = (dgtk.OpenGL.delegatesGLes.glGlobalAlphaFactorsSUN) InternalTool.GetGLesMethodAdress("glGlobalAlphaFactorsSUN", typeof(dgtk.OpenGL.delegatesGLes.glGlobalAlphaFactorsSUN));
			}
			if (SuportedExt.Contains("glGlobalAlphaFactorubSUN"))
			{
				dgtk.OpenGL.internalGLes.glGlobalAlphaFactorubSUN = (dgtk.OpenGL.delegatesGLes.glGlobalAlphaFactorubSUN) InternalTool.GetGLesMethodAdress("glGlobalAlphaFactorubSUN", typeof(dgtk.OpenGL.delegatesGLes.glGlobalAlphaFactorubSUN));
			}
			if (SuportedExt.Contains("glGlobalAlphaFactoruiSUN"))
			{
				dgtk.OpenGL.internalGLes.glGlobalAlphaFactoruiSUN = (dgtk.OpenGL.delegatesGLes.glGlobalAlphaFactoruiSUN) InternalTool.GetGLesMethodAdress("glGlobalAlphaFactoruiSUN", typeof(dgtk.OpenGL.delegatesGLes.glGlobalAlphaFactoruiSUN));
			}
			if (SuportedExt.Contains("glGlobalAlphaFactorusSUN"))
			{
				dgtk.OpenGL.internalGLes.glGlobalAlphaFactorusSUN = (dgtk.OpenGL.delegatesGLes.glGlobalAlphaFactorusSUN) InternalTool.GetGLesMethodAdress("glGlobalAlphaFactorusSUN", typeof(dgtk.OpenGL.delegatesGLes.glGlobalAlphaFactorusSUN));
			}
			#endregion

			#region H:

			if (SuportedExt.Contains("glHintPGI"))
			{
				dgtk.OpenGL.internalGLes.glHintPGI = (dgtk.OpenGL.delegatesGLes.glHintPGI) InternalTool.GetGLesMethodAdress("glHintPGI", typeof(dgtk.OpenGL.delegatesGLes.glHintPGI));
			}
			if (SuportedExt.Contains("glHistogram"))
			{
				dgtk.OpenGL.internalGLes.glHistogram = (dgtk.OpenGL.delegatesGLes.glHistogram) InternalTool.GetGLesMethodAdress("glHistogram", typeof(dgtk.OpenGL.delegatesGLes.glHistogram));
			}
			if (SuportedExt.Contains("glHistogramEXT"))
			{
				dgtk.OpenGL.internalGLes.glHistogramEXT = (dgtk.OpenGL.delegatesGLes.glHistogramEXT) InternalTool.GetGLesMethodAdress("glHistogramEXT", typeof(dgtk.OpenGL.delegatesGLes.glHistogramEXT));
			}
			#endregion

			#region I:

			if (SuportedExt.Contains("glIglooInterfaceSGIX"))
			{
				dgtk.OpenGL.internalGLes.glIglooInterfaceSGIX = (dgtk.OpenGL.delegatesGLes.glIglooInterfaceSGIX) InternalTool.GetGLesMethodAdress("glIglooInterfaceSGIX", typeof(dgtk.OpenGL.delegatesGLes.glIglooInterfaceSGIX));
			}
			if (SuportedExt.Contains("glImageTransformParameterfHP"))
			{
				dgtk.OpenGL.internalGLes.glImageTransformParameterfHP = (dgtk.OpenGL.delegatesGLes.glImageTransformParameterfHP) InternalTool.GetGLesMethodAdress("glImageTransformParameterfHP", typeof(dgtk.OpenGL.delegatesGLes.glImageTransformParameterfHP));
			}
			if (SuportedExt.Contains("glImageTransformParameterfvHP"))
			{
				dgtk.OpenGL.internalGLes.glImageTransformParameterfvHP = (dgtk.OpenGL.delegatesGLes.glImageTransformParameterfvHP) InternalTool.GetGLesMethodAdress("glImageTransformParameterfvHP", typeof(dgtk.OpenGL.delegatesGLes.glImageTransformParameterfvHP));
			}
			if (SuportedExt.Contains("glImageTransformParameteriHP"))
			{
				dgtk.OpenGL.internalGLes.glImageTransformParameteriHP = (dgtk.OpenGL.delegatesGLes.glImageTransformParameteriHP) InternalTool.GetGLesMethodAdress("glImageTransformParameteriHP", typeof(dgtk.OpenGL.delegatesGLes.glImageTransformParameteriHP));
			}
			if (SuportedExt.Contains("glImageTransformParameterivHP"))
			{
				dgtk.OpenGL.internalGLes.glImageTransformParameterivHP = (dgtk.OpenGL.delegatesGLes.glImageTransformParameterivHP) InternalTool.GetGLesMethodAdress("glImageTransformParameterivHP", typeof(dgtk.OpenGL.delegatesGLes.glImageTransformParameterivHP));
			}
			if (SuportedExt.Contains("glImportMemoryFdEXT"))
			{
				dgtk.OpenGL.internalGLes.glImportMemoryFdEXT = (dgtk.OpenGL.delegatesGLes.glImportMemoryFdEXT) InternalTool.GetGLesMethodAdress("glImportMemoryFdEXT", typeof(dgtk.OpenGL.delegatesGLes.glImportMemoryFdEXT));
			}
			if (SuportedExt.Contains("glImportMemoryWin32HandleEXT"))
			{
				dgtk.OpenGL.internalGLes.glImportMemoryWin32HandleEXT = (dgtk.OpenGL.delegatesGLes.glImportMemoryWin32HandleEXT) InternalTool.GetGLesMethodAdress("glImportMemoryWin32HandleEXT", typeof(dgtk.OpenGL.delegatesGLes.glImportMemoryWin32HandleEXT));
			}
			if (SuportedExt.Contains("glImportMemoryWin32NameEXT"))
			{
				dgtk.OpenGL.internalGLes.glImportMemoryWin32NameEXT = (dgtk.OpenGL.delegatesGLes.glImportMemoryWin32NameEXT) InternalTool.GetGLesMethodAdress("glImportMemoryWin32NameEXT", typeof(dgtk.OpenGL.delegatesGLes.glImportMemoryWin32NameEXT));
			}
			if (SuportedExt.Contains("glImportSemaphoreFdEXT"))
			{
				dgtk.OpenGL.internalGLes.glImportSemaphoreFdEXT = (dgtk.OpenGL.delegatesGLes.glImportSemaphoreFdEXT) InternalTool.GetGLesMethodAdress("glImportSemaphoreFdEXT", typeof(dgtk.OpenGL.delegatesGLes.glImportSemaphoreFdEXT));
			}
			if (SuportedExt.Contains("glImportSemaphoreWin32HandleEXT"))
			{
				dgtk.OpenGL.internalGLes.glImportSemaphoreWin32HandleEXT = (dgtk.OpenGL.delegatesGLes.glImportSemaphoreWin32HandleEXT) InternalTool.GetGLesMethodAdress("glImportSemaphoreWin32HandleEXT", typeof(dgtk.OpenGL.delegatesGLes.glImportSemaphoreWin32HandleEXT));
			}
			if (SuportedExt.Contains("glImportSemaphoreWin32NameEXT"))
			{
				dgtk.OpenGL.internalGLes.glImportSemaphoreWin32NameEXT = (dgtk.OpenGL.delegatesGLes.glImportSemaphoreWin32NameEXT) InternalTool.GetGLesMethodAdress("glImportSemaphoreWin32NameEXT", typeof(dgtk.OpenGL.delegatesGLes.glImportSemaphoreWin32NameEXT));
			}
			if (SuportedExt.Contains("glImportSyncEXT"))
			{
				dgtk.OpenGL.internalGLes.glImportSyncEXT = (dgtk.OpenGL.delegatesGLes.glImportSyncEXT) InternalTool.GetGLesMethodAdress("glImportSyncEXT", typeof(dgtk.OpenGL.delegatesGLes.glImportSyncEXT));
			}
			if (SuportedExt.Contains("glIndexFormatNV"))
			{
				dgtk.OpenGL.internalGLes.glIndexFormatNV = (dgtk.OpenGL.delegatesGLes.glIndexFormatNV) InternalTool.GetGLesMethodAdress("glIndexFormatNV", typeof(dgtk.OpenGL.delegatesGLes.glIndexFormatNV));
			}
			if (SuportedExt.Contains("glIndexFuncEXT"))
			{
				dgtk.OpenGL.internalGLes.glIndexFuncEXT = (dgtk.OpenGL.delegatesGLes.glIndexFuncEXT) InternalTool.GetGLesMethodAdress("glIndexFuncEXT", typeof(dgtk.OpenGL.delegatesGLes.glIndexFuncEXT));
			}
			if (SuportedExt.Contains("glIndexMaterialEXT"))
			{
				dgtk.OpenGL.internalGLes.glIndexMaterialEXT = (dgtk.OpenGL.delegatesGLes.glIndexMaterialEXT) InternalTool.GetGLesMethodAdress("glIndexMaterialEXT", typeof(dgtk.OpenGL.delegatesGLes.glIndexMaterialEXT));
			}
			if (SuportedExt.Contains("glIndexPointerEXT"))
			{
				dgtk.OpenGL.internalGLes.glIndexPointerEXT = (dgtk.OpenGL.delegatesGLes.glIndexPointerEXT) InternalTool.GetGLesMethodAdress("glIndexPointerEXT", typeof(dgtk.OpenGL.delegatesGLes.glIndexPointerEXT));
			}
			if (SuportedExt.Contains("glIndexPointerListIBM"))
			{
				dgtk.OpenGL.internalGLes.glIndexPointerListIBM = (dgtk.OpenGL.delegatesGLes.glIndexPointerListIBM) InternalTool.GetGLesMethodAdress("glIndexPointerListIBM", typeof(dgtk.OpenGL.delegatesGLes.glIndexPointerListIBM));
			}
			if (SuportedExt.Contains("glIndexxOES"))
			{
				dgtk.OpenGL.internalGLes.glIndexxOES = (dgtk.OpenGL.delegatesGLes.glIndexxOES) InternalTool.GetGLesMethodAdress("glIndexxOES", typeof(dgtk.OpenGL.delegatesGLes.glIndexxOES));
			}
			if (SuportedExt.Contains("glIndexxvOES"))
			{
				dgtk.OpenGL.internalGLes.glIndexxvOES = (dgtk.OpenGL.delegatesGLes.glIndexxvOES) InternalTool.GetGLesMethodAdress("glIndexxvOES", typeof(dgtk.OpenGL.delegatesGLes.glIndexxvOES));
			}
			if (SuportedExt.Contains("glInsertComponentEXT"))
			{
				dgtk.OpenGL.internalGLes.glInsertComponentEXT = (dgtk.OpenGL.delegatesGLes.glInsertComponentEXT) InternalTool.GetGLesMethodAdress("glInsertComponentEXT", typeof(dgtk.OpenGL.delegatesGLes.glInsertComponentEXT));
			}
			if (SuportedExt.Contains("glInsertEventMarkerEXT"))
			{
				dgtk.OpenGL.internalGLes.glInsertEventMarkerEXT = (dgtk.OpenGL.delegatesGLes.glInsertEventMarkerEXT) InternalTool.GetGLesMethodAdress("glInsertEventMarkerEXT", typeof(dgtk.OpenGL.delegatesGLes.glInsertEventMarkerEXT));
			}
			if (SuportedExt.Contains("glInstrumentsBufferSGIX"))
			{
				dgtk.OpenGL.internalGLes.glInstrumentsBufferSGIX = (dgtk.OpenGL.delegatesGLes.glInstrumentsBufferSGIX) InternalTool.GetGLesMethodAdress("glInstrumentsBufferSGIX", typeof(dgtk.OpenGL.delegatesGLes.glInstrumentsBufferSGIX));
			}
			if (SuportedExt.Contains("glInterpolatePathsNV"))
			{
				dgtk.OpenGL.internalGLes.glInterpolatePathsNV = (dgtk.OpenGL.delegatesGLes.glInterpolatePathsNV) InternalTool.GetGLesMethodAdress("glInterpolatePathsNV", typeof(dgtk.OpenGL.delegatesGLes.glInterpolatePathsNV));
			}
			if (SuportedExt.Contains("glIsAsyncMarkerSGIX"))
			{
				dgtk.OpenGL.internalGLes.glIsAsyncMarkerSGIX = (dgtk.OpenGL.delegatesGLes.glIsAsyncMarkerSGIX) InternalTool.GetGLesMethodAdress("glIsAsyncMarkerSGIX", typeof(dgtk.OpenGL.delegatesGLes.glIsAsyncMarkerSGIX));
			}
			if (SuportedExt.Contains("glIsBufferARB"))
			{
				dgtk.OpenGL.internalGLes.glIsBufferARB = (dgtk.OpenGL.delegatesGLes.glIsBufferARB) InternalTool.GetGLesMethodAdress("glIsBufferARB", typeof(dgtk.OpenGL.delegatesGLes.glIsBufferARB));
			}
			if (SuportedExt.Contains("glIsBufferResidentNV"))
			{
				dgtk.OpenGL.internalGLes.glIsBufferResidentNV = (dgtk.OpenGL.delegatesGLes.glIsBufferResidentNV) InternalTool.GetGLesMethodAdress("glIsBufferResidentNV", typeof(dgtk.OpenGL.delegatesGLes.glIsBufferResidentNV));
			}
			if (SuportedExt.Contains("glIsCommandListNV"))
			{
				dgtk.OpenGL.internalGLes.glIsCommandListNV = (dgtk.OpenGL.delegatesGLes.glIsCommandListNV) InternalTool.GetGLesMethodAdress("glIsCommandListNV", typeof(dgtk.OpenGL.delegatesGLes.glIsCommandListNV));
			}
			if (SuportedExt.Contains("glIsEnablediEXT"))
			{
				dgtk.OpenGL.internalGLes.glIsEnablediEXT = (dgtk.OpenGL.delegatesGLes.glIsEnablediEXT) InternalTool.GetGLesMethodAdress("glIsEnablediEXT", typeof(dgtk.OpenGL.delegatesGLes.glIsEnablediEXT));
			}
			if (SuportedExt.Contains("glIsEnabledIndexedEXT"))
			{
				dgtk.OpenGL.internalGLes.glIsEnabledIndexedEXT = (dgtk.OpenGL.delegatesGLes.glIsEnabledIndexedEXT) InternalTool.GetGLesMethodAdress("glIsEnabledIndexedEXT", typeof(dgtk.OpenGL.delegatesGLes.glIsEnabledIndexedEXT));
			}
			if (SuportedExt.Contains("glIsEnablediNV"))
			{
				dgtk.OpenGL.internalGLes.glIsEnablediNV = (dgtk.OpenGL.delegatesGLes.glIsEnablediNV) InternalTool.GetGLesMethodAdress("glIsEnablediNV", typeof(dgtk.OpenGL.delegatesGLes.glIsEnablediNV));
			}
			if (SuportedExt.Contains("glIsEnablediOES"))
			{
				dgtk.OpenGL.internalGLes.glIsEnablediOES = (dgtk.OpenGL.delegatesGLes.glIsEnablediOES) InternalTool.GetGLesMethodAdress("glIsEnablediOES", typeof(dgtk.OpenGL.delegatesGLes.glIsEnablediOES));
			}
			if (SuportedExt.Contains("glIsFenceAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glIsFenceAPPLE = (dgtk.OpenGL.delegatesGLes.glIsFenceAPPLE) InternalTool.GetGLesMethodAdress("glIsFenceAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glIsFenceAPPLE));
			}
			if (SuportedExt.Contains("glIsFenceNV"))
			{
				dgtk.OpenGL.internalGLes.glIsFenceNV = (dgtk.OpenGL.delegatesGLes.glIsFenceNV) InternalTool.GetGLesMethodAdress("glIsFenceNV", typeof(dgtk.OpenGL.delegatesGLes.glIsFenceNV));
			}
			if (SuportedExt.Contains("glIsFramebufferEXT"))
			{
				dgtk.OpenGL.internalGLes.glIsFramebufferEXT = (dgtk.OpenGL.delegatesGLes.glIsFramebufferEXT) InternalTool.GetGLesMethodAdress("glIsFramebufferEXT", typeof(dgtk.OpenGL.delegatesGLes.glIsFramebufferEXT));
			}
			if (SuportedExt.Contains("glIsFramebufferOES"))
			{
				dgtk.OpenGL.internalGLes.glIsFramebufferOES = (dgtk.OpenGL.delegatesGLes.glIsFramebufferOES) InternalTool.GetGLesMethodAdress("glIsFramebufferOES", typeof(dgtk.OpenGL.delegatesGLes.glIsFramebufferOES));
			}
			if (SuportedExt.Contains("glIsImageHandleResidentARB"))
			{
				dgtk.OpenGL.internalGLes.glIsImageHandleResidentARB = (dgtk.OpenGL.delegatesGLes.glIsImageHandleResidentARB) InternalTool.GetGLesMethodAdress("glIsImageHandleResidentARB", typeof(dgtk.OpenGL.delegatesGLes.glIsImageHandleResidentARB));
			}
			if (SuportedExt.Contains("glIsImageHandleResidentNV"))
			{
				dgtk.OpenGL.internalGLes.glIsImageHandleResidentNV = (dgtk.OpenGL.delegatesGLes.glIsImageHandleResidentNV) InternalTool.GetGLesMethodAdress("glIsImageHandleResidentNV", typeof(dgtk.OpenGL.delegatesGLes.glIsImageHandleResidentNV));
			}
			if (SuportedExt.Contains("glIsMemoryObjectEXT"))
			{
				dgtk.OpenGL.internalGLes.glIsMemoryObjectEXT = (dgtk.OpenGL.delegatesGLes.glIsMemoryObjectEXT) InternalTool.GetGLesMethodAdress("glIsMemoryObjectEXT", typeof(dgtk.OpenGL.delegatesGLes.glIsMemoryObjectEXT));
			}
			if (SuportedExt.Contains("glIsNameAMD"))
			{
				dgtk.OpenGL.internalGLes.glIsNameAMD = (dgtk.OpenGL.delegatesGLes.glIsNameAMD) InternalTool.GetGLesMethodAdress("glIsNameAMD", typeof(dgtk.OpenGL.delegatesGLes.glIsNameAMD));
			}
			if (SuportedExt.Contains("glIsNamedBufferResidentNV"))
			{
				dgtk.OpenGL.internalGLes.glIsNamedBufferResidentNV = (dgtk.OpenGL.delegatesGLes.glIsNamedBufferResidentNV) InternalTool.GetGLesMethodAdress("glIsNamedBufferResidentNV", typeof(dgtk.OpenGL.delegatesGLes.glIsNamedBufferResidentNV));
			}
			if (SuportedExt.Contains("glIsNamedStringARB"))
			{
				dgtk.OpenGL.internalGLes.glIsNamedStringARB = (dgtk.OpenGL.delegatesGLes.glIsNamedStringARB) InternalTool.GetGLesMethodAdress("glIsNamedStringARB", typeof(dgtk.OpenGL.delegatesGLes.glIsNamedStringARB));
			}
			if (SuportedExt.Contains("glIsObjectBufferATI"))
			{
				dgtk.OpenGL.internalGLes.glIsObjectBufferATI = (dgtk.OpenGL.delegatesGLes.glIsObjectBufferATI) InternalTool.GetGLesMethodAdress("glIsObjectBufferATI", typeof(dgtk.OpenGL.delegatesGLes.glIsObjectBufferATI));
			}
			if (SuportedExt.Contains("glIsOcclusionQueryNV"))
			{
				dgtk.OpenGL.internalGLes.glIsOcclusionQueryNV = (dgtk.OpenGL.delegatesGLes.glIsOcclusionQueryNV) InternalTool.GetGLesMethodAdress("glIsOcclusionQueryNV", typeof(dgtk.OpenGL.delegatesGLes.glIsOcclusionQueryNV));
			}
			if (SuportedExt.Contains("glIsPathNV"))
			{
				dgtk.OpenGL.internalGLes.glIsPathNV = (dgtk.OpenGL.delegatesGLes.glIsPathNV) InternalTool.GetGLesMethodAdress("glIsPathNV", typeof(dgtk.OpenGL.delegatesGLes.glIsPathNV));
			}
			if (SuportedExt.Contains("glIsPointInFillPathNV"))
			{
				dgtk.OpenGL.internalGLes.glIsPointInFillPathNV = (dgtk.OpenGL.delegatesGLes.glIsPointInFillPathNV) InternalTool.GetGLesMethodAdress("glIsPointInFillPathNV", typeof(dgtk.OpenGL.delegatesGLes.glIsPointInFillPathNV));
			}
			if (SuportedExt.Contains("glIsPointInStrokePathNV"))
			{
				dgtk.OpenGL.internalGLes.glIsPointInStrokePathNV = (dgtk.OpenGL.delegatesGLes.glIsPointInStrokePathNV) InternalTool.GetGLesMethodAdress("glIsPointInStrokePathNV", typeof(dgtk.OpenGL.delegatesGLes.glIsPointInStrokePathNV));
			}
			if (SuportedExt.Contains("glIsProgramARB"))
			{
				dgtk.OpenGL.internalGLes.glIsProgramARB = (dgtk.OpenGL.delegatesGLes.glIsProgramARB) InternalTool.GetGLesMethodAdress("glIsProgramARB", typeof(dgtk.OpenGL.delegatesGLes.glIsProgramARB));
			}
			if (SuportedExt.Contains("glIsProgramNV"))
			{
				dgtk.OpenGL.internalGLes.glIsProgramNV = (dgtk.OpenGL.delegatesGLes.glIsProgramNV) InternalTool.GetGLesMethodAdress("glIsProgramNV", typeof(dgtk.OpenGL.delegatesGLes.glIsProgramNV));
			}
			if (SuportedExt.Contains("glIsProgramPipelineEXT"))
			{
				dgtk.OpenGL.internalGLes.glIsProgramPipelineEXT = (dgtk.OpenGL.delegatesGLes.glIsProgramPipelineEXT) InternalTool.GetGLesMethodAdress("glIsProgramPipelineEXT", typeof(dgtk.OpenGL.delegatesGLes.glIsProgramPipelineEXT));
			}
			if (SuportedExt.Contains("glIsQueryARB"))
			{
				dgtk.OpenGL.internalGLes.glIsQueryARB = (dgtk.OpenGL.delegatesGLes.glIsQueryARB) InternalTool.GetGLesMethodAdress("glIsQueryARB", typeof(dgtk.OpenGL.delegatesGLes.glIsQueryARB));
			}
			if (SuportedExt.Contains("glIsQueryEXT"))
			{
				dgtk.OpenGL.internalGLes.glIsQueryEXT = (dgtk.OpenGL.delegatesGLes.glIsQueryEXT) InternalTool.GetGLesMethodAdress("glIsQueryEXT", typeof(dgtk.OpenGL.delegatesGLes.glIsQueryEXT));
			}
			if (SuportedExt.Contains("glIsRenderbufferEXT"))
			{
				dgtk.OpenGL.internalGLes.glIsRenderbufferEXT = (dgtk.OpenGL.delegatesGLes.glIsRenderbufferEXT) InternalTool.GetGLesMethodAdress("glIsRenderbufferEXT", typeof(dgtk.OpenGL.delegatesGLes.glIsRenderbufferEXT));
			}
			if (SuportedExt.Contains("glIsRenderbufferOES"))
			{
				dgtk.OpenGL.internalGLes.glIsRenderbufferOES = (dgtk.OpenGL.delegatesGLes.glIsRenderbufferOES) InternalTool.GetGLesMethodAdress("glIsRenderbufferOES", typeof(dgtk.OpenGL.delegatesGLes.glIsRenderbufferOES));
			}
			if (SuportedExt.Contains("glIsSemaphoreEXT"))
			{
				dgtk.OpenGL.internalGLes.glIsSemaphoreEXT = (dgtk.OpenGL.delegatesGLes.glIsSemaphoreEXT) InternalTool.GetGLesMethodAdress("glIsSemaphoreEXT", typeof(dgtk.OpenGL.delegatesGLes.glIsSemaphoreEXT));
			}
			if (SuportedExt.Contains("glIsStateNV"))
			{
				dgtk.OpenGL.internalGLes.glIsStateNV = (dgtk.OpenGL.delegatesGLes.glIsStateNV) InternalTool.GetGLesMethodAdress("glIsStateNV", typeof(dgtk.OpenGL.delegatesGLes.glIsStateNV));
			}
			if (SuportedExt.Contains("glIsSyncAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glIsSyncAPPLE = (dgtk.OpenGL.delegatesGLes.glIsSyncAPPLE) InternalTool.GetGLesMethodAdress("glIsSyncAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glIsSyncAPPLE));
			}
			if (SuportedExt.Contains("glIsTextureEXT"))
			{
				dgtk.OpenGL.internalGLes.glIsTextureEXT = (dgtk.OpenGL.delegatesGLes.glIsTextureEXT) InternalTool.GetGLesMethodAdress("glIsTextureEXT", typeof(dgtk.OpenGL.delegatesGLes.glIsTextureEXT));
			}
			if (SuportedExt.Contains("glIsTextureHandleResidentARB"))
			{
				dgtk.OpenGL.internalGLes.glIsTextureHandleResidentARB = (dgtk.OpenGL.delegatesGLes.glIsTextureHandleResidentARB) InternalTool.GetGLesMethodAdress("glIsTextureHandleResidentARB", typeof(dgtk.OpenGL.delegatesGLes.glIsTextureHandleResidentARB));
			}
			if (SuportedExt.Contains("glIsTextureHandleResidentNV"))
			{
				dgtk.OpenGL.internalGLes.glIsTextureHandleResidentNV = (dgtk.OpenGL.delegatesGLes.glIsTextureHandleResidentNV) InternalTool.GetGLesMethodAdress("glIsTextureHandleResidentNV", typeof(dgtk.OpenGL.delegatesGLes.glIsTextureHandleResidentNV));
			}
			if (SuportedExt.Contains("glIsTransformFeedbackNV"))
			{
				dgtk.OpenGL.internalGLes.glIsTransformFeedbackNV = (dgtk.OpenGL.delegatesGLes.glIsTransformFeedbackNV) InternalTool.GetGLesMethodAdress("glIsTransformFeedbackNV", typeof(dgtk.OpenGL.delegatesGLes.glIsTransformFeedbackNV));
			}
			if (SuportedExt.Contains("glIsVariantEnabledEXT"))
			{
				dgtk.OpenGL.internalGLes.glIsVariantEnabledEXT = (dgtk.OpenGL.delegatesGLes.glIsVariantEnabledEXT) InternalTool.GetGLesMethodAdress("glIsVariantEnabledEXT", typeof(dgtk.OpenGL.delegatesGLes.glIsVariantEnabledEXT));
			}
			if (SuportedExt.Contains("glIsVertexArrayAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glIsVertexArrayAPPLE = (dgtk.OpenGL.delegatesGLes.glIsVertexArrayAPPLE) InternalTool.GetGLesMethodAdress("glIsVertexArrayAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glIsVertexArrayAPPLE));
			}
			if (SuportedExt.Contains("glIsVertexArrayOES"))
			{
				dgtk.OpenGL.internalGLes.glIsVertexArrayOES = (dgtk.OpenGL.delegatesGLes.glIsVertexArrayOES) InternalTool.GetGLesMethodAdress("glIsVertexArrayOES", typeof(dgtk.OpenGL.delegatesGLes.glIsVertexArrayOES));
			}
			if (SuportedExt.Contains("glIsVertexAttribEnabledAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glIsVertexAttribEnabledAPPLE = (dgtk.OpenGL.delegatesGLes.glIsVertexAttribEnabledAPPLE) InternalTool.GetGLesMethodAdress("glIsVertexAttribEnabledAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glIsVertexAttribEnabledAPPLE));
			}
			#endregion

			#region L:

			if (SuportedExt.Contains("glLabelObjectEXT"))
			{
				dgtk.OpenGL.internalGLes.glLabelObjectEXT = (dgtk.OpenGL.delegatesGLes.glLabelObjectEXT) InternalTool.GetGLesMethodAdress("glLabelObjectEXT", typeof(dgtk.OpenGL.delegatesGLes.glLabelObjectEXT));
			}
			if (SuportedExt.Contains("glLGPUCopyImageSubDataNVX"))
			{
				dgtk.OpenGL.internalGLes.glLGPUCopyImageSubDataNVX = (dgtk.OpenGL.delegatesGLes.glLGPUCopyImageSubDataNVX) InternalTool.GetGLesMethodAdress("glLGPUCopyImageSubDataNVX", typeof(dgtk.OpenGL.delegatesGLes.glLGPUCopyImageSubDataNVX));
			}
			if (SuportedExt.Contains("glLGPUInterlockNVX"))
			{
				dgtk.OpenGL.internalGLes.glLGPUInterlockNVX = (dgtk.OpenGL.delegatesGLes.glLGPUInterlockNVX) InternalTool.GetGLesMethodAdress("glLGPUInterlockNVX", typeof(dgtk.OpenGL.delegatesGLes.glLGPUInterlockNVX));
			}
			if (SuportedExt.Contains("glLGPUNamedBufferSubDataNVX"))
			{
				dgtk.OpenGL.internalGLes.glLGPUNamedBufferSubDataNVX = (dgtk.OpenGL.delegatesGLes.glLGPUNamedBufferSubDataNVX) InternalTool.GetGLesMethodAdress("glLGPUNamedBufferSubDataNVX", typeof(dgtk.OpenGL.delegatesGLes.glLGPUNamedBufferSubDataNVX));
			}
			if (SuportedExt.Contains("glLightEnviSGIX"))
			{
				dgtk.OpenGL.internalGLes.glLightEnviSGIX = (dgtk.OpenGL.delegatesGLes.glLightEnviSGIX) InternalTool.GetGLesMethodAdress("glLightEnviSGIX", typeof(dgtk.OpenGL.delegatesGLes.glLightEnviSGIX));
			}
			if (SuportedExt.Contains("glLightModelx"))
			{
				dgtk.OpenGL.internalGLes.glLightModelx = (dgtk.OpenGL.delegatesGLes.glLightModelx) InternalTool.GetGLesMethodAdress("glLightModelx", typeof(dgtk.OpenGL.delegatesGLes.glLightModelx));
			}
			if (SuportedExt.Contains("glLightModelxOES"))
			{
				dgtk.OpenGL.internalGLes.glLightModelxOES = (dgtk.OpenGL.delegatesGLes.glLightModelxOES) InternalTool.GetGLesMethodAdress("glLightModelxOES", typeof(dgtk.OpenGL.delegatesGLes.glLightModelxOES));
			}
			if (SuportedExt.Contains("glLightModelxv"))
			{
				dgtk.OpenGL.internalGLes.glLightModelxv = (dgtk.OpenGL.delegatesGLes.glLightModelxv) InternalTool.GetGLesMethodAdress("glLightModelxv", typeof(dgtk.OpenGL.delegatesGLes.glLightModelxv));
			}
			if (SuportedExt.Contains("glLightModelxvOES"))
			{
				dgtk.OpenGL.internalGLes.glLightModelxvOES = (dgtk.OpenGL.delegatesGLes.glLightModelxvOES) InternalTool.GetGLesMethodAdress("glLightModelxvOES", typeof(dgtk.OpenGL.delegatesGLes.glLightModelxvOES));
			}
			if (SuportedExt.Contains("glLightx"))
			{
				dgtk.OpenGL.internalGLes.glLightx = (dgtk.OpenGL.delegatesGLes.glLightx) InternalTool.GetGLesMethodAdress("glLightx", typeof(dgtk.OpenGL.delegatesGLes.glLightx));
			}
			if (SuportedExt.Contains("glLightxOES"))
			{
				dgtk.OpenGL.internalGLes.glLightxOES = (dgtk.OpenGL.delegatesGLes.glLightxOES) InternalTool.GetGLesMethodAdress("glLightxOES", typeof(dgtk.OpenGL.delegatesGLes.glLightxOES));
			}
			if (SuportedExt.Contains("glLightxv"))
			{
				dgtk.OpenGL.internalGLes.glLightxv = (dgtk.OpenGL.delegatesGLes.glLightxv) InternalTool.GetGLesMethodAdress("glLightxv", typeof(dgtk.OpenGL.delegatesGLes.glLightxv));
			}
			if (SuportedExt.Contains("glLightxvOES"))
			{
				dgtk.OpenGL.internalGLes.glLightxvOES = (dgtk.OpenGL.delegatesGLes.glLightxvOES) InternalTool.GetGLesMethodAdress("glLightxvOES", typeof(dgtk.OpenGL.delegatesGLes.glLightxvOES));
			}
			if (SuportedExt.Contains("glLineWidthx"))
			{
				dgtk.OpenGL.internalGLes.glLineWidthx = (dgtk.OpenGL.delegatesGLes.glLineWidthx) InternalTool.GetGLesMethodAdress("glLineWidthx", typeof(dgtk.OpenGL.delegatesGLes.glLineWidthx));
			}
			if (SuportedExt.Contains("glLineWidthxOES"))
			{
				dgtk.OpenGL.internalGLes.glLineWidthxOES = (dgtk.OpenGL.delegatesGLes.glLineWidthxOES) InternalTool.GetGLesMethodAdress("glLineWidthxOES", typeof(dgtk.OpenGL.delegatesGLes.glLineWidthxOES));
			}
			if (SuportedExt.Contains("glLinkProgramARB"))
			{
				dgtk.OpenGL.internalGLes.glLinkProgramARB = (dgtk.OpenGL.delegatesGLes.glLinkProgramARB) InternalTool.GetGLesMethodAdress("glLinkProgramARB", typeof(dgtk.OpenGL.delegatesGLes.glLinkProgramARB));
			}
			if (SuportedExt.Contains("glListDrawCommandsStatesClientNV"))
			{
				dgtk.OpenGL.internalGLes.glListDrawCommandsStatesClientNV = (dgtk.OpenGL.delegatesGLes.glListDrawCommandsStatesClientNV) InternalTool.GetGLesMethodAdress("glListDrawCommandsStatesClientNV", typeof(dgtk.OpenGL.delegatesGLes.glListDrawCommandsStatesClientNV));
			}
			if (SuportedExt.Contains("glListParameterfSGIX"))
			{
				dgtk.OpenGL.internalGLes.glListParameterfSGIX = (dgtk.OpenGL.delegatesGLes.glListParameterfSGIX) InternalTool.GetGLesMethodAdress("glListParameterfSGIX", typeof(dgtk.OpenGL.delegatesGLes.glListParameterfSGIX));
			}
			if (SuportedExt.Contains("glListParameterfvSGIX"))
			{
				dgtk.OpenGL.internalGLes.glListParameterfvSGIX = (dgtk.OpenGL.delegatesGLes.glListParameterfvSGIX) InternalTool.GetGLesMethodAdress("glListParameterfvSGIX", typeof(dgtk.OpenGL.delegatesGLes.glListParameterfvSGIX));
			}
			if (SuportedExt.Contains("glListParameteriSGIX"))
			{
				dgtk.OpenGL.internalGLes.glListParameteriSGIX = (dgtk.OpenGL.delegatesGLes.glListParameteriSGIX) InternalTool.GetGLesMethodAdress("glListParameteriSGIX", typeof(dgtk.OpenGL.delegatesGLes.glListParameteriSGIX));
			}
			if (SuportedExt.Contains("glListParameterivSGIX"))
			{
				dgtk.OpenGL.internalGLes.glListParameterivSGIX = (dgtk.OpenGL.delegatesGLes.glListParameterivSGIX) InternalTool.GetGLesMethodAdress("glListParameterivSGIX", typeof(dgtk.OpenGL.delegatesGLes.glListParameterivSGIX));
			}
			if (SuportedExt.Contains("glLoadIdentityDeformationMapSGIX"))
			{
				dgtk.OpenGL.internalGLes.glLoadIdentityDeformationMapSGIX = (dgtk.OpenGL.delegatesGLes.glLoadIdentityDeformationMapSGIX) InternalTool.GetGLesMethodAdress("glLoadIdentityDeformationMapSGIX", typeof(dgtk.OpenGL.delegatesGLes.glLoadIdentityDeformationMapSGIX));
			}
			if (SuportedExt.Contains("glLoadMatrixx"))
			{
				dgtk.OpenGL.internalGLes.glLoadMatrixx = (dgtk.OpenGL.delegatesGLes.glLoadMatrixx) InternalTool.GetGLesMethodAdress("glLoadMatrixx", typeof(dgtk.OpenGL.delegatesGLes.glLoadMatrixx));
			}
			if (SuportedExt.Contains("glLoadMatrixxOES"))
			{
				dgtk.OpenGL.internalGLes.glLoadMatrixxOES = (dgtk.OpenGL.delegatesGLes.glLoadMatrixxOES) InternalTool.GetGLesMethodAdress("glLoadMatrixxOES", typeof(dgtk.OpenGL.delegatesGLes.glLoadMatrixxOES));
			}
			if (SuportedExt.Contains("glLoadPaletteFromModelViewMatrixOES"))
			{
				dgtk.OpenGL.internalGLes.glLoadPaletteFromModelViewMatrixOES = (dgtk.OpenGL.delegatesGLes.glLoadPaletteFromModelViewMatrixOES) InternalTool.GetGLesMethodAdress("glLoadPaletteFromModelViewMatrixOES", typeof(dgtk.OpenGL.delegatesGLes.glLoadPaletteFromModelViewMatrixOES));
			}
			if (SuportedExt.Contains("glLoadProgramNV"))
			{
				dgtk.OpenGL.internalGLes.glLoadProgramNV = (dgtk.OpenGL.delegatesGLes.glLoadProgramNV) InternalTool.GetGLesMethodAdress("glLoadProgramNV", typeof(dgtk.OpenGL.delegatesGLes.glLoadProgramNV));
			}
			if (SuportedExt.Contains("glLoadTransposeMatrixdARB"))
			{
				dgtk.OpenGL.internalGLes.glLoadTransposeMatrixdARB = (dgtk.OpenGL.delegatesGLes.glLoadTransposeMatrixdARB) InternalTool.GetGLesMethodAdress("glLoadTransposeMatrixdARB", typeof(dgtk.OpenGL.delegatesGLes.glLoadTransposeMatrixdARB));
			}
			if (SuportedExt.Contains("glLoadTransposeMatrixfARB"))
			{
				dgtk.OpenGL.internalGLes.glLoadTransposeMatrixfARB = (dgtk.OpenGL.delegatesGLes.glLoadTransposeMatrixfARB) InternalTool.GetGLesMethodAdress("glLoadTransposeMatrixfARB", typeof(dgtk.OpenGL.delegatesGLes.glLoadTransposeMatrixfARB));
			}
			if (SuportedExt.Contains("glLoadTransposeMatrixxOES"))
			{
				dgtk.OpenGL.internalGLes.glLoadTransposeMatrixxOES = (dgtk.OpenGL.delegatesGLes.glLoadTransposeMatrixxOES) InternalTool.GetGLesMethodAdress("glLoadTransposeMatrixxOES", typeof(dgtk.OpenGL.delegatesGLes.glLoadTransposeMatrixxOES));
			}
			if (SuportedExt.Contains("glLockArraysEXT"))
			{
				dgtk.OpenGL.internalGLes.glLockArraysEXT = (dgtk.OpenGL.delegatesGLes.glLockArraysEXT) InternalTool.GetGLesMethodAdress("glLockArraysEXT", typeof(dgtk.OpenGL.delegatesGLes.glLockArraysEXT));
			}
			#endregion

			#region M:

			if (SuportedExt.Contains("glMakeBufferNonResidentNV"))
			{
				dgtk.OpenGL.internalGLes.glMakeBufferNonResidentNV = (dgtk.OpenGL.delegatesGLes.glMakeBufferNonResidentNV) InternalTool.GetGLesMethodAdress("glMakeBufferNonResidentNV", typeof(dgtk.OpenGL.delegatesGLes.glMakeBufferNonResidentNV));
			}
			if (SuportedExt.Contains("glMakeBufferResidentNV"))
			{
				dgtk.OpenGL.internalGLes.glMakeBufferResidentNV = (dgtk.OpenGL.delegatesGLes.glMakeBufferResidentNV) InternalTool.GetGLesMethodAdress("glMakeBufferResidentNV", typeof(dgtk.OpenGL.delegatesGLes.glMakeBufferResidentNV));
			}
			if (SuportedExt.Contains("glMakeImageHandleNonResidentARB"))
			{
				dgtk.OpenGL.internalGLes.glMakeImageHandleNonResidentARB = (dgtk.OpenGL.delegatesGLes.glMakeImageHandleNonResidentARB) InternalTool.GetGLesMethodAdress("glMakeImageHandleNonResidentARB", typeof(dgtk.OpenGL.delegatesGLes.glMakeImageHandleNonResidentARB));
			}
			if (SuportedExt.Contains("glMakeImageHandleNonResidentNV"))
			{
				dgtk.OpenGL.internalGLes.glMakeImageHandleNonResidentNV = (dgtk.OpenGL.delegatesGLes.glMakeImageHandleNonResidentNV) InternalTool.GetGLesMethodAdress("glMakeImageHandleNonResidentNV", typeof(dgtk.OpenGL.delegatesGLes.glMakeImageHandleNonResidentNV));
			}
			if (SuportedExt.Contains("glMakeImageHandleResidentARB"))
			{
				dgtk.OpenGL.internalGLes.glMakeImageHandleResidentARB = (dgtk.OpenGL.delegatesGLes.glMakeImageHandleResidentARB) InternalTool.GetGLesMethodAdress("glMakeImageHandleResidentARB", typeof(dgtk.OpenGL.delegatesGLes.glMakeImageHandleResidentARB));
			}
			if (SuportedExt.Contains("glMakeImageHandleResidentNV"))
			{
				dgtk.OpenGL.internalGLes.glMakeImageHandleResidentNV = (dgtk.OpenGL.delegatesGLes.glMakeImageHandleResidentNV) InternalTool.GetGLesMethodAdress("glMakeImageHandleResidentNV", typeof(dgtk.OpenGL.delegatesGLes.glMakeImageHandleResidentNV));
			}
			if (SuportedExt.Contains("glMakeNamedBufferNonResidentNV"))
			{
				dgtk.OpenGL.internalGLes.glMakeNamedBufferNonResidentNV = (dgtk.OpenGL.delegatesGLes.glMakeNamedBufferNonResidentNV) InternalTool.GetGLesMethodAdress("glMakeNamedBufferNonResidentNV", typeof(dgtk.OpenGL.delegatesGLes.glMakeNamedBufferNonResidentNV));
			}
			if (SuportedExt.Contains("glMakeNamedBufferResidentNV"))
			{
				dgtk.OpenGL.internalGLes.glMakeNamedBufferResidentNV = (dgtk.OpenGL.delegatesGLes.glMakeNamedBufferResidentNV) InternalTool.GetGLesMethodAdress("glMakeNamedBufferResidentNV", typeof(dgtk.OpenGL.delegatesGLes.glMakeNamedBufferResidentNV));
			}
			if (SuportedExt.Contains("glMakeTextureHandleNonResidentARB"))
			{
				dgtk.OpenGL.internalGLes.glMakeTextureHandleNonResidentARB = (dgtk.OpenGL.delegatesGLes.glMakeTextureHandleNonResidentARB) InternalTool.GetGLesMethodAdress("glMakeTextureHandleNonResidentARB", typeof(dgtk.OpenGL.delegatesGLes.glMakeTextureHandleNonResidentARB));
			}
			if (SuportedExt.Contains("glMakeTextureHandleNonResidentNV"))
			{
				dgtk.OpenGL.internalGLes.glMakeTextureHandleNonResidentNV = (dgtk.OpenGL.delegatesGLes.glMakeTextureHandleNonResidentNV) InternalTool.GetGLesMethodAdress("glMakeTextureHandleNonResidentNV", typeof(dgtk.OpenGL.delegatesGLes.glMakeTextureHandleNonResidentNV));
			}
			if (SuportedExt.Contains("glMakeTextureHandleResidentARB"))
			{
				dgtk.OpenGL.internalGLes.glMakeTextureHandleResidentARB = (dgtk.OpenGL.delegatesGLes.glMakeTextureHandleResidentARB) InternalTool.GetGLesMethodAdress("glMakeTextureHandleResidentARB", typeof(dgtk.OpenGL.delegatesGLes.glMakeTextureHandleResidentARB));
			}
			if (SuportedExt.Contains("glMakeTextureHandleResidentNV"))
			{
				dgtk.OpenGL.internalGLes.glMakeTextureHandleResidentNV = (dgtk.OpenGL.delegatesGLes.glMakeTextureHandleResidentNV) InternalTool.GetGLesMethodAdress("glMakeTextureHandleResidentNV", typeof(dgtk.OpenGL.delegatesGLes.glMakeTextureHandleResidentNV));
			}
			if (SuportedExt.Contains("glMap1xOES"))
			{
				dgtk.OpenGL.internalGLes.glMap1xOES = (dgtk.OpenGL.delegatesGLes.glMap1xOES) InternalTool.GetGLesMethodAdress("glMap1xOES", typeof(dgtk.OpenGL.delegatesGLes.glMap1xOES));
			}
			if (SuportedExt.Contains("glMap2xOES"))
			{
				dgtk.OpenGL.internalGLes.glMap2xOES = (dgtk.OpenGL.delegatesGLes.glMap2xOES) InternalTool.GetGLesMethodAdress("glMap2xOES", typeof(dgtk.OpenGL.delegatesGLes.glMap2xOES));
			}
			if (SuportedExt.Contains("glMapBufferARB"))
			{
				dgtk.OpenGL.internalGLes.glMapBufferARB = (dgtk.OpenGL.delegatesGLes.glMapBufferARB) InternalTool.GetGLesMethodAdress("glMapBufferARB", typeof(dgtk.OpenGL.delegatesGLes.glMapBufferARB));
			}
			if (SuportedExt.Contains("glMapBufferOES"))
			{
				dgtk.OpenGL.internalGLes.glMapBufferOES = (dgtk.OpenGL.delegatesGLes.glMapBufferOES) InternalTool.GetGLesMethodAdress("glMapBufferOES", typeof(dgtk.OpenGL.delegatesGLes.glMapBufferOES));
			}
			if (SuportedExt.Contains("glMapBufferRangeEXT"))
			{
				dgtk.OpenGL.internalGLes.glMapBufferRangeEXT = (dgtk.OpenGL.delegatesGLes.glMapBufferRangeEXT) InternalTool.GetGLesMethodAdress("glMapBufferRangeEXT", typeof(dgtk.OpenGL.delegatesGLes.glMapBufferRangeEXT));
			}
			if (SuportedExt.Contains("glMapControlPointsNV"))
			{
				dgtk.OpenGL.internalGLes.glMapControlPointsNV = (dgtk.OpenGL.delegatesGLes.glMapControlPointsNV) InternalTool.GetGLesMethodAdress("glMapControlPointsNV", typeof(dgtk.OpenGL.delegatesGLes.glMapControlPointsNV));
			}
			if (SuportedExt.Contains("glMapGrid1xOES"))
			{
				dgtk.OpenGL.internalGLes.glMapGrid1xOES = (dgtk.OpenGL.delegatesGLes.glMapGrid1xOES) InternalTool.GetGLesMethodAdress("glMapGrid1xOES", typeof(dgtk.OpenGL.delegatesGLes.glMapGrid1xOES));
			}
			if (SuportedExt.Contains("glMapGrid2xOES"))
			{
				dgtk.OpenGL.internalGLes.glMapGrid2xOES = (dgtk.OpenGL.delegatesGLes.glMapGrid2xOES) InternalTool.GetGLesMethodAdress("glMapGrid2xOES", typeof(dgtk.OpenGL.delegatesGLes.glMapGrid2xOES));
			}
			if (SuportedExt.Contains("glMapNamedBufferEXT"))
			{
				dgtk.OpenGL.internalGLes.glMapNamedBufferEXT = (dgtk.OpenGL.delegatesGLes.glMapNamedBufferEXT) InternalTool.GetGLesMethodAdress("glMapNamedBufferEXT", typeof(dgtk.OpenGL.delegatesGLes.glMapNamedBufferEXT));
			}
			if (SuportedExt.Contains("glMapNamedBufferRangeEXT"))
			{
				dgtk.OpenGL.internalGLes.glMapNamedBufferRangeEXT = (dgtk.OpenGL.delegatesGLes.glMapNamedBufferRangeEXT) InternalTool.GetGLesMethodAdress("glMapNamedBufferRangeEXT", typeof(dgtk.OpenGL.delegatesGLes.glMapNamedBufferRangeEXT));
			}
			if (SuportedExt.Contains("glMapObjectBufferATI"))
			{
				dgtk.OpenGL.internalGLes.glMapObjectBufferATI = (dgtk.OpenGL.delegatesGLes.glMapObjectBufferATI) InternalTool.GetGLesMethodAdress("glMapObjectBufferATI", typeof(dgtk.OpenGL.delegatesGLes.glMapObjectBufferATI));
			}
			if (SuportedExt.Contains("glMapParameterfvNV"))
			{
				dgtk.OpenGL.internalGLes.glMapParameterfvNV = (dgtk.OpenGL.delegatesGLes.glMapParameterfvNV) InternalTool.GetGLesMethodAdress("glMapParameterfvNV", typeof(dgtk.OpenGL.delegatesGLes.glMapParameterfvNV));
			}
			if (SuportedExt.Contains("glMapParameterivNV"))
			{
				dgtk.OpenGL.internalGLes.glMapParameterivNV = (dgtk.OpenGL.delegatesGLes.glMapParameterivNV) InternalTool.GetGLesMethodAdress("glMapParameterivNV", typeof(dgtk.OpenGL.delegatesGLes.glMapParameterivNV));
			}
			if (SuportedExt.Contains("glMapTexture2DINTEL"))
			{
				dgtk.OpenGL.internalGLes.glMapTexture2DINTEL = (dgtk.OpenGL.delegatesGLes.glMapTexture2DINTEL) InternalTool.GetGLesMethodAdress("glMapTexture2DINTEL", typeof(dgtk.OpenGL.delegatesGLes.glMapTexture2DINTEL));
			}
			if (SuportedExt.Contains("glMapVertexAttrib1dAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glMapVertexAttrib1dAPPLE = (dgtk.OpenGL.delegatesGLes.glMapVertexAttrib1dAPPLE) InternalTool.GetGLesMethodAdress("glMapVertexAttrib1dAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glMapVertexAttrib1dAPPLE));
			}
			if (SuportedExt.Contains("glMapVertexAttrib1fAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glMapVertexAttrib1fAPPLE = (dgtk.OpenGL.delegatesGLes.glMapVertexAttrib1fAPPLE) InternalTool.GetGLesMethodAdress("glMapVertexAttrib1fAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glMapVertexAttrib1fAPPLE));
			}
			if (SuportedExt.Contains("glMapVertexAttrib2dAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glMapVertexAttrib2dAPPLE = (dgtk.OpenGL.delegatesGLes.glMapVertexAttrib2dAPPLE) InternalTool.GetGLesMethodAdress("glMapVertexAttrib2dAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glMapVertexAttrib2dAPPLE));
			}
			if (SuportedExt.Contains("glMapVertexAttrib2fAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glMapVertexAttrib2fAPPLE = (dgtk.OpenGL.delegatesGLes.glMapVertexAttrib2fAPPLE) InternalTool.GetGLesMethodAdress("glMapVertexAttrib2fAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glMapVertexAttrib2fAPPLE));
			}
			if (SuportedExt.Contains("glMaterialx"))
			{
				dgtk.OpenGL.internalGLes.glMaterialx = (dgtk.OpenGL.delegatesGLes.glMaterialx) InternalTool.GetGLesMethodAdress("glMaterialx", typeof(dgtk.OpenGL.delegatesGLes.glMaterialx));
			}
			if (SuportedExt.Contains("glMaterialxOES"))
			{
				dgtk.OpenGL.internalGLes.glMaterialxOES = (dgtk.OpenGL.delegatesGLes.glMaterialxOES) InternalTool.GetGLesMethodAdress("glMaterialxOES", typeof(dgtk.OpenGL.delegatesGLes.glMaterialxOES));
			}
			if (SuportedExt.Contains("glMaterialxv"))
			{
				dgtk.OpenGL.internalGLes.glMaterialxv = (dgtk.OpenGL.delegatesGLes.glMaterialxv) InternalTool.GetGLesMethodAdress("glMaterialxv", typeof(dgtk.OpenGL.delegatesGLes.glMaterialxv));
			}
			if (SuportedExt.Contains("glMaterialxvOES"))
			{
				dgtk.OpenGL.internalGLes.glMaterialxvOES = (dgtk.OpenGL.delegatesGLes.glMaterialxvOES) InternalTool.GetGLesMethodAdress("glMaterialxvOES", typeof(dgtk.OpenGL.delegatesGLes.glMaterialxvOES));
			}
			if (SuportedExt.Contains("glMatrixFrustumEXT"))
			{
				dgtk.OpenGL.internalGLes.glMatrixFrustumEXT = (dgtk.OpenGL.delegatesGLes.glMatrixFrustumEXT) InternalTool.GetGLesMethodAdress("glMatrixFrustumEXT", typeof(dgtk.OpenGL.delegatesGLes.glMatrixFrustumEXT));
			}
			if (SuportedExt.Contains("glMatrixIndexPointerARB"))
			{
				dgtk.OpenGL.internalGLes.glMatrixIndexPointerARB = (dgtk.OpenGL.delegatesGLes.glMatrixIndexPointerARB) InternalTool.GetGLesMethodAdress("glMatrixIndexPointerARB", typeof(dgtk.OpenGL.delegatesGLes.glMatrixIndexPointerARB));
			}
			if (SuportedExt.Contains("glMatrixIndexPointerOES"))
			{
				dgtk.OpenGL.internalGLes.glMatrixIndexPointerOES = (dgtk.OpenGL.delegatesGLes.glMatrixIndexPointerOES) InternalTool.GetGLesMethodAdress("glMatrixIndexPointerOES", typeof(dgtk.OpenGL.delegatesGLes.glMatrixIndexPointerOES));
			}
			if (SuportedExt.Contains("glMatrixIndexubvARB"))
			{
				dgtk.OpenGL.internalGLes.glMatrixIndexubvARB = (dgtk.OpenGL.delegatesGLes.glMatrixIndexubvARB) InternalTool.GetGLesMethodAdress("glMatrixIndexubvARB", typeof(dgtk.OpenGL.delegatesGLes.glMatrixIndexubvARB));
			}
			if (SuportedExt.Contains("glMatrixIndexuivARB"))
			{
				dgtk.OpenGL.internalGLes.glMatrixIndexuivARB = (dgtk.OpenGL.delegatesGLes.glMatrixIndexuivARB) InternalTool.GetGLesMethodAdress("glMatrixIndexuivARB", typeof(dgtk.OpenGL.delegatesGLes.glMatrixIndexuivARB));
			}
			if (SuportedExt.Contains("glMatrixIndexusvARB"))
			{
				dgtk.OpenGL.internalGLes.glMatrixIndexusvARB = (dgtk.OpenGL.delegatesGLes.glMatrixIndexusvARB) InternalTool.GetGLesMethodAdress("glMatrixIndexusvARB", typeof(dgtk.OpenGL.delegatesGLes.glMatrixIndexusvARB));
			}
			if (SuportedExt.Contains("glMatrixLoad3x2fNV"))
			{
				dgtk.OpenGL.internalGLes.glMatrixLoad3x2fNV = (dgtk.OpenGL.delegatesGLes.glMatrixLoad3x2fNV) InternalTool.GetGLesMethodAdress("glMatrixLoad3x2fNV", typeof(dgtk.OpenGL.delegatesGLes.glMatrixLoad3x2fNV));
			}
			if (SuportedExt.Contains("glMatrixLoad3x3fNV"))
			{
				dgtk.OpenGL.internalGLes.glMatrixLoad3x3fNV = (dgtk.OpenGL.delegatesGLes.glMatrixLoad3x3fNV) InternalTool.GetGLesMethodAdress("glMatrixLoad3x3fNV", typeof(dgtk.OpenGL.delegatesGLes.glMatrixLoad3x3fNV));
			}
			if (SuportedExt.Contains("glMatrixLoaddEXT"))
			{
				dgtk.OpenGL.internalGLes.glMatrixLoaddEXT = (dgtk.OpenGL.delegatesGLes.glMatrixLoaddEXT) InternalTool.GetGLesMethodAdress("glMatrixLoaddEXT", typeof(dgtk.OpenGL.delegatesGLes.glMatrixLoaddEXT));
			}
			if (SuportedExt.Contains("glMatrixLoadfEXT"))
			{
				dgtk.OpenGL.internalGLes.glMatrixLoadfEXT = (dgtk.OpenGL.delegatesGLes.glMatrixLoadfEXT) InternalTool.GetGLesMethodAdress("glMatrixLoadfEXT", typeof(dgtk.OpenGL.delegatesGLes.glMatrixLoadfEXT));
			}
			if (SuportedExt.Contains("glMatrixLoadIdentityEXT"))
			{
				dgtk.OpenGL.internalGLes.glMatrixLoadIdentityEXT = (dgtk.OpenGL.delegatesGLes.glMatrixLoadIdentityEXT) InternalTool.GetGLesMethodAdress("glMatrixLoadIdentityEXT", typeof(dgtk.OpenGL.delegatesGLes.glMatrixLoadIdentityEXT));
			}
			if (SuportedExt.Contains("glMatrixLoadTranspose3x3fNV"))
			{
				dgtk.OpenGL.internalGLes.glMatrixLoadTranspose3x3fNV = (dgtk.OpenGL.delegatesGLes.glMatrixLoadTranspose3x3fNV) InternalTool.GetGLesMethodAdress("glMatrixLoadTranspose3x3fNV", typeof(dgtk.OpenGL.delegatesGLes.glMatrixLoadTranspose3x3fNV));
			}
			if (SuportedExt.Contains("glMatrixLoadTransposedEXT"))
			{
				dgtk.OpenGL.internalGLes.glMatrixLoadTransposedEXT = (dgtk.OpenGL.delegatesGLes.glMatrixLoadTransposedEXT) InternalTool.GetGLesMethodAdress("glMatrixLoadTransposedEXT", typeof(dgtk.OpenGL.delegatesGLes.glMatrixLoadTransposedEXT));
			}
			if (SuportedExt.Contains("glMatrixLoadTransposefEXT"))
			{
				dgtk.OpenGL.internalGLes.glMatrixLoadTransposefEXT = (dgtk.OpenGL.delegatesGLes.glMatrixLoadTransposefEXT) InternalTool.GetGLesMethodAdress("glMatrixLoadTransposefEXT", typeof(dgtk.OpenGL.delegatesGLes.glMatrixLoadTransposefEXT));
			}
			if (SuportedExt.Contains("glMatrixMult3x2fNV"))
			{
				dgtk.OpenGL.internalGLes.glMatrixMult3x2fNV = (dgtk.OpenGL.delegatesGLes.glMatrixMult3x2fNV) InternalTool.GetGLesMethodAdress("glMatrixMult3x2fNV", typeof(dgtk.OpenGL.delegatesGLes.glMatrixMult3x2fNV));
			}
			if (SuportedExt.Contains("glMatrixMult3x3fNV"))
			{
				dgtk.OpenGL.internalGLes.glMatrixMult3x3fNV = (dgtk.OpenGL.delegatesGLes.glMatrixMult3x3fNV) InternalTool.GetGLesMethodAdress("glMatrixMult3x3fNV", typeof(dgtk.OpenGL.delegatesGLes.glMatrixMult3x3fNV));
			}
			if (SuportedExt.Contains("glMatrixMultdEXT"))
			{
				dgtk.OpenGL.internalGLes.glMatrixMultdEXT = (dgtk.OpenGL.delegatesGLes.glMatrixMultdEXT) InternalTool.GetGLesMethodAdress("glMatrixMultdEXT", typeof(dgtk.OpenGL.delegatesGLes.glMatrixMultdEXT));
			}
			if (SuportedExt.Contains("glMatrixMultfEXT"))
			{
				dgtk.OpenGL.internalGLes.glMatrixMultfEXT = (dgtk.OpenGL.delegatesGLes.glMatrixMultfEXT) InternalTool.GetGLesMethodAdress("glMatrixMultfEXT", typeof(dgtk.OpenGL.delegatesGLes.glMatrixMultfEXT));
			}
			if (SuportedExt.Contains("glMatrixMultTranspose3x3fNV"))
			{
				dgtk.OpenGL.internalGLes.glMatrixMultTranspose3x3fNV = (dgtk.OpenGL.delegatesGLes.glMatrixMultTranspose3x3fNV) InternalTool.GetGLesMethodAdress("glMatrixMultTranspose3x3fNV", typeof(dgtk.OpenGL.delegatesGLes.glMatrixMultTranspose3x3fNV));
			}
			if (SuportedExt.Contains("glMatrixMultTransposedEXT"))
			{
				dgtk.OpenGL.internalGLes.glMatrixMultTransposedEXT = (dgtk.OpenGL.delegatesGLes.glMatrixMultTransposedEXT) InternalTool.GetGLesMethodAdress("glMatrixMultTransposedEXT", typeof(dgtk.OpenGL.delegatesGLes.glMatrixMultTransposedEXT));
			}
			if (SuportedExt.Contains("glMatrixMultTransposefEXT"))
			{
				dgtk.OpenGL.internalGLes.glMatrixMultTransposefEXT = (dgtk.OpenGL.delegatesGLes.glMatrixMultTransposefEXT) InternalTool.GetGLesMethodAdress("glMatrixMultTransposefEXT", typeof(dgtk.OpenGL.delegatesGLes.glMatrixMultTransposefEXT));
			}
			if (SuportedExt.Contains("glMatrixOrthoEXT"))
			{
				dgtk.OpenGL.internalGLes.glMatrixOrthoEXT = (dgtk.OpenGL.delegatesGLes.glMatrixOrthoEXT) InternalTool.GetGLesMethodAdress("glMatrixOrthoEXT", typeof(dgtk.OpenGL.delegatesGLes.glMatrixOrthoEXT));
			}
			if (SuportedExt.Contains("glMatrixPopEXT"))
			{
				dgtk.OpenGL.internalGLes.glMatrixPopEXT = (dgtk.OpenGL.delegatesGLes.glMatrixPopEXT) InternalTool.GetGLesMethodAdress("glMatrixPopEXT", typeof(dgtk.OpenGL.delegatesGLes.glMatrixPopEXT));
			}
			if (SuportedExt.Contains("glMatrixPushEXT"))
			{
				dgtk.OpenGL.internalGLes.glMatrixPushEXT = (dgtk.OpenGL.delegatesGLes.glMatrixPushEXT) InternalTool.GetGLesMethodAdress("glMatrixPushEXT", typeof(dgtk.OpenGL.delegatesGLes.glMatrixPushEXT));
			}
			if (SuportedExt.Contains("glMatrixRotatedEXT"))
			{
				dgtk.OpenGL.internalGLes.glMatrixRotatedEXT = (dgtk.OpenGL.delegatesGLes.glMatrixRotatedEXT) InternalTool.GetGLesMethodAdress("glMatrixRotatedEXT", typeof(dgtk.OpenGL.delegatesGLes.glMatrixRotatedEXT));
			}
			if (SuportedExt.Contains("glMatrixRotatefEXT"))
			{
				dgtk.OpenGL.internalGLes.glMatrixRotatefEXT = (dgtk.OpenGL.delegatesGLes.glMatrixRotatefEXT) InternalTool.GetGLesMethodAdress("glMatrixRotatefEXT", typeof(dgtk.OpenGL.delegatesGLes.glMatrixRotatefEXT));
			}
			if (SuportedExt.Contains("glMatrixScaledEXT"))
			{
				dgtk.OpenGL.internalGLes.glMatrixScaledEXT = (dgtk.OpenGL.delegatesGLes.glMatrixScaledEXT) InternalTool.GetGLesMethodAdress("glMatrixScaledEXT", typeof(dgtk.OpenGL.delegatesGLes.glMatrixScaledEXT));
			}
			if (SuportedExt.Contains("glMatrixScalefEXT"))
			{
				dgtk.OpenGL.internalGLes.glMatrixScalefEXT = (dgtk.OpenGL.delegatesGLes.glMatrixScalefEXT) InternalTool.GetGLesMethodAdress("glMatrixScalefEXT", typeof(dgtk.OpenGL.delegatesGLes.glMatrixScalefEXT));
			}
			if (SuportedExt.Contains("glMatrixTranslatedEXT"))
			{
				dgtk.OpenGL.internalGLes.glMatrixTranslatedEXT = (dgtk.OpenGL.delegatesGLes.glMatrixTranslatedEXT) InternalTool.GetGLesMethodAdress("glMatrixTranslatedEXT", typeof(dgtk.OpenGL.delegatesGLes.glMatrixTranslatedEXT));
			}
			if (SuportedExt.Contains("glMatrixTranslatefEXT"))
			{
				dgtk.OpenGL.internalGLes.glMatrixTranslatefEXT = (dgtk.OpenGL.delegatesGLes.glMatrixTranslatefEXT) InternalTool.GetGLesMethodAdress("glMatrixTranslatefEXT", typeof(dgtk.OpenGL.delegatesGLes.glMatrixTranslatefEXT));
			}
			if (SuportedExt.Contains("glMaxShaderCompilerThreadsARB"))
			{
				dgtk.OpenGL.internalGLes.glMaxShaderCompilerThreadsARB = (dgtk.OpenGL.delegatesGLes.glMaxShaderCompilerThreadsARB) InternalTool.GetGLesMethodAdress("glMaxShaderCompilerThreadsARB", typeof(dgtk.OpenGL.delegatesGLes.glMaxShaderCompilerThreadsARB));
			}
			if (SuportedExt.Contains("glMaxShaderCompilerThreadsKHR"))
			{
				dgtk.OpenGL.internalGLes.glMaxShaderCompilerThreadsKHR = (dgtk.OpenGL.delegatesGLes.glMaxShaderCompilerThreadsKHR) InternalTool.GetGLesMethodAdress("glMaxShaderCompilerThreadsKHR", typeof(dgtk.OpenGL.delegatesGLes.glMaxShaderCompilerThreadsKHR));
			}
			if (SuportedExt.Contains("glMemoryBarrierEXT"))
			{
				dgtk.OpenGL.internalGLes.glMemoryBarrierEXT = (dgtk.OpenGL.delegatesGLes.glMemoryBarrierEXT) InternalTool.GetGLesMethodAdress("glMemoryBarrierEXT", typeof(dgtk.OpenGL.delegatesGLes.glMemoryBarrierEXT));
			}
			if (SuportedExt.Contains("glMemoryObjectParameterivEXT"))
			{
				dgtk.OpenGL.internalGLes.glMemoryObjectParameterivEXT = (dgtk.OpenGL.delegatesGLes.glMemoryObjectParameterivEXT) InternalTool.GetGLesMethodAdress("glMemoryObjectParameterivEXT", typeof(dgtk.OpenGL.delegatesGLes.glMemoryObjectParameterivEXT));
			}
			if (SuportedExt.Contains("glMinmax"))
			{
				dgtk.OpenGL.internalGLes.glMinmax = (dgtk.OpenGL.delegatesGLes.glMinmax) InternalTool.GetGLesMethodAdress("glMinmax", typeof(dgtk.OpenGL.delegatesGLes.glMinmax));
			}
			if (SuportedExt.Contains("glMinmaxEXT"))
			{
				dgtk.OpenGL.internalGLes.glMinmaxEXT = (dgtk.OpenGL.delegatesGLes.glMinmaxEXT) InternalTool.GetGLesMethodAdress("glMinmaxEXT", typeof(dgtk.OpenGL.delegatesGLes.glMinmaxEXT));
			}
			if (SuportedExt.Contains("glMinSampleShadingARB"))
			{
				dgtk.OpenGL.internalGLes.glMinSampleShadingARB = (dgtk.OpenGL.delegatesGLes.glMinSampleShadingARB) InternalTool.GetGLesMethodAdress("glMinSampleShadingARB", typeof(dgtk.OpenGL.delegatesGLes.glMinSampleShadingARB));
			}
			if (SuportedExt.Contains("glMinSampleShadingOES"))
			{
				dgtk.OpenGL.internalGLes.glMinSampleShadingOES = (dgtk.OpenGL.delegatesGLes.glMinSampleShadingOES) InternalTool.GetGLesMethodAdress("glMinSampleShadingOES", typeof(dgtk.OpenGL.delegatesGLes.glMinSampleShadingOES));
			}
			if (SuportedExt.Contains("glMulticastBarrierNV"))
			{
				dgtk.OpenGL.internalGLes.glMulticastBarrierNV = (dgtk.OpenGL.delegatesGLes.glMulticastBarrierNV) InternalTool.GetGLesMethodAdress("glMulticastBarrierNV", typeof(dgtk.OpenGL.delegatesGLes.glMulticastBarrierNV));
			}
			if (SuportedExt.Contains("glMulticastBlitFramebufferNV"))
			{
				dgtk.OpenGL.internalGLes.glMulticastBlitFramebufferNV = (dgtk.OpenGL.delegatesGLes.glMulticastBlitFramebufferNV) InternalTool.GetGLesMethodAdress("glMulticastBlitFramebufferNV", typeof(dgtk.OpenGL.delegatesGLes.glMulticastBlitFramebufferNV));
			}
			if (SuportedExt.Contains("glMulticastBufferSubDataNV"))
			{
				dgtk.OpenGL.internalGLes.glMulticastBufferSubDataNV = (dgtk.OpenGL.delegatesGLes.glMulticastBufferSubDataNV) InternalTool.GetGLesMethodAdress("glMulticastBufferSubDataNV", typeof(dgtk.OpenGL.delegatesGLes.glMulticastBufferSubDataNV));
			}
			if (SuportedExt.Contains("glMulticastCopyBufferSubDataNV"))
			{
				dgtk.OpenGL.internalGLes.glMulticastCopyBufferSubDataNV = (dgtk.OpenGL.delegatesGLes.glMulticastCopyBufferSubDataNV) InternalTool.GetGLesMethodAdress("glMulticastCopyBufferSubDataNV", typeof(dgtk.OpenGL.delegatesGLes.glMulticastCopyBufferSubDataNV));
			}
			if (SuportedExt.Contains("glMulticastCopyImageSubDataNV"))
			{
				dgtk.OpenGL.internalGLes.glMulticastCopyImageSubDataNV = (dgtk.OpenGL.delegatesGLes.glMulticastCopyImageSubDataNV) InternalTool.GetGLesMethodAdress("glMulticastCopyImageSubDataNV", typeof(dgtk.OpenGL.delegatesGLes.glMulticastCopyImageSubDataNV));
			}
			if (SuportedExt.Contains("glMulticastFramebufferSampleLocationsfvNV"))
			{
				dgtk.OpenGL.internalGLes.glMulticastFramebufferSampleLocationsfvNV = (dgtk.OpenGL.delegatesGLes.glMulticastFramebufferSampleLocationsfvNV) InternalTool.GetGLesMethodAdress("glMulticastFramebufferSampleLocationsfvNV", typeof(dgtk.OpenGL.delegatesGLes.glMulticastFramebufferSampleLocationsfvNV));
			}
			if (SuportedExt.Contains("glMulticastGetQueryObjecti64vNV"))
			{
				dgtk.OpenGL.internalGLes.glMulticastGetQueryObjecti64vNV = (dgtk.OpenGL.delegatesGLes.glMulticastGetQueryObjecti64vNV) InternalTool.GetGLesMethodAdress("glMulticastGetQueryObjecti64vNV", typeof(dgtk.OpenGL.delegatesGLes.glMulticastGetQueryObjecti64vNV));
			}
			if (SuportedExt.Contains("glMulticastGetQueryObjectivNV"))
			{
				dgtk.OpenGL.internalGLes.glMulticastGetQueryObjectivNV = (dgtk.OpenGL.delegatesGLes.glMulticastGetQueryObjectivNV) InternalTool.GetGLesMethodAdress("glMulticastGetQueryObjectivNV", typeof(dgtk.OpenGL.delegatesGLes.glMulticastGetQueryObjectivNV));
			}
			if (SuportedExt.Contains("glMulticastGetQueryObjectui64vNV"))
			{
				dgtk.OpenGL.internalGLes.glMulticastGetQueryObjectui64vNV = (dgtk.OpenGL.delegatesGLes.glMulticastGetQueryObjectui64vNV) InternalTool.GetGLesMethodAdress("glMulticastGetQueryObjectui64vNV", typeof(dgtk.OpenGL.delegatesGLes.glMulticastGetQueryObjectui64vNV));
			}
			if (SuportedExt.Contains("glMulticastGetQueryObjectuivNV"))
			{
				dgtk.OpenGL.internalGLes.glMulticastGetQueryObjectuivNV = (dgtk.OpenGL.delegatesGLes.glMulticastGetQueryObjectuivNV) InternalTool.GetGLesMethodAdress("glMulticastGetQueryObjectuivNV", typeof(dgtk.OpenGL.delegatesGLes.glMulticastGetQueryObjectuivNV));
			}
			if (SuportedExt.Contains("glMulticastScissorArrayvNVX"))
			{
				dgtk.OpenGL.internalGLes.glMulticastScissorArrayvNVX = (dgtk.OpenGL.delegatesGLes.glMulticastScissorArrayvNVX) InternalTool.GetGLesMethodAdress("glMulticastScissorArrayvNVX", typeof(dgtk.OpenGL.delegatesGLes.glMulticastScissorArrayvNVX));
			}
			if (SuportedExt.Contains("glMulticastViewportArrayvNVX"))
			{
				dgtk.OpenGL.internalGLes.glMulticastViewportArrayvNVX = (dgtk.OpenGL.delegatesGLes.glMulticastViewportArrayvNVX) InternalTool.GetGLesMethodAdress("glMulticastViewportArrayvNVX", typeof(dgtk.OpenGL.delegatesGLes.glMulticastViewportArrayvNVX));
			}
			if (SuportedExt.Contains("glMulticastViewportPositionWScaleNVX"))
			{
				dgtk.OpenGL.internalGLes.glMulticastViewportPositionWScaleNVX = (dgtk.OpenGL.delegatesGLes.glMulticastViewportPositionWScaleNVX) InternalTool.GetGLesMethodAdress("glMulticastViewportPositionWScaleNVX", typeof(dgtk.OpenGL.delegatesGLes.glMulticastViewportPositionWScaleNVX));
			}
			if (SuportedExt.Contains("glMulticastWaitSyncNV"))
			{
				dgtk.OpenGL.internalGLes.glMulticastWaitSyncNV = (dgtk.OpenGL.delegatesGLes.glMulticastWaitSyncNV) InternalTool.GetGLesMethodAdress("glMulticastWaitSyncNV", typeof(dgtk.OpenGL.delegatesGLes.glMulticastWaitSyncNV));
			}
			if (SuportedExt.Contains("glMultiDrawArraysEXT"))
			{
				dgtk.OpenGL.internalGLes.glMultiDrawArraysEXT = (dgtk.OpenGL.delegatesGLes.glMultiDrawArraysEXT) InternalTool.GetGLesMethodAdress("glMultiDrawArraysEXT", typeof(dgtk.OpenGL.delegatesGLes.glMultiDrawArraysEXT));
			}
			if (SuportedExt.Contains("glMultiDrawArraysIndirectAMD"))
			{
				dgtk.OpenGL.internalGLes.glMultiDrawArraysIndirectAMD = (dgtk.OpenGL.delegatesGLes.glMultiDrawArraysIndirectAMD) InternalTool.GetGLesMethodAdress("glMultiDrawArraysIndirectAMD", typeof(dgtk.OpenGL.delegatesGLes.glMultiDrawArraysIndirectAMD));
			}
			if (SuportedExt.Contains("glMultiDrawArraysIndirectBindlessCountNV"))
			{
				dgtk.OpenGL.internalGLes.glMultiDrawArraysIndirectBindlessCountNV = (dgtk.OpenGL.delegatesGLes.glMultiDrawArraysIndirectBindlessCountNV) InternalTool.GetGLesMethodAdress("glMultiDrawArraysIndirectBindlessCountNV", typeof(dgtk.OpenGL.delegatesGLes.glMultiDrawArraysIndirectBindlessCountNV));
			}
			if (SuportedExt.Contains("glMultiDrawArraysIndirectBindlessNV"))
			{
				dgtk.OpenGL.internalGLes.glMultiDrawArraysIndirectBindlessNV = (dgtk.OpenGL.delegatesGLes.glMultiDrawArraysIndirectBindlessNV) InternalTool.GetGLesMethodAdress("glMultiDrawArraysIndirectBindlessNV", typeof(dgtk.OpenGL.delegatesGLes.glMultiDrawArraysIndirectBindlessNV));
			}
			if (SuportedExt.Contains("glMultiDrawArraysIndirectCountARB"))
			{
				dgtk.OpenGL.internalGLes.glMultiDrawArraysIndirectCountARB = (dgtk.OpenGL.delegatesGLes.glMultiDrawArraysIndirectCountARB) InternalTool.GetGLesMethodAdress("glMultiDrawArraysIndirectCountARB", typeof(dgtk.OpenGL.delegatesGLes.glMultiDrawArraysIndirectCountARB));
			}
			if (SuportedExt.Contains("glMultiDrawArraysIndirectEXT"))
			{
				dgtk.OpenGL.internalGLes.glMultiDrawArraysIndirectEXT = (dgtk.OpenGL.delegatesGLes.glMultiDrawArraysIndirectEXT) InternalTool.GetGLesMethodAdress("glMultiDrawArraysIndirectEXT", typeof(dgtk.OpenGL.delegatesGLes.glMultiDrawArraysIndirectEXT));
			}
			if (SuportedExt.Contains("glMultiDrawElementArrayAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glMultiDrawElementArrayAPPLE = (dgtk.OpenGL.delegatesGLes.glMultiDrawElementArrayAPPLE) InternalTool.GetGLesMethodAdress("glMultiDrawElementArrayAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glMultiDrawElementArrayAPPLE));
			}
			if (SuportedExt.Contains("glMultiDrawElementsBaseVertexEXT"))
			{
				dgtk.OpenGL.internalGLes.glMultiDrawElementsBaseVertexEXT = (dgtk.OpenGL.delegatesGLes.glMultiDrawElementsBaseVertexEXT) InternalTool.GetGLesMethodAdress("glMultiDrawElementsBaseVertexEXT", typeof(dgtk.OpenGL.delegatesGLes.glMultiDrawElementsBaseVertexEXT));
			}
			if (SuportedExt.Contains("glMultiDrawElementsEXT"))
			{
				dgtk.OpenGL.internalGLes.glMultiDrawElementsEXT = (dgtk.OpenGL.delegatesGLes.glMultiDrawElementsEXT) InternalTool.GetGLesMethodAdress("glMultiDrawElementsEXT", typeof(dgtk.OpenGL.delegatesGLes.glMultiDrawElementsEXT));
			}
			if (SuportedExt.Contains("glMultiDrawElementsIndirectAMD"))
			{
				dgtk.OpenGL.internalGLes.glMultiDrawElementsIndirectAMD = (dgtk.OpenGL.delegatesGLes.glMultiDrawElementsIndirectAMD) InternalTool.GetGLesMethodAdress("glMultiDrawElementsIndirectAMD", typeof(dgtk.OpenGL.delegatesGLes.glMultiDrawElementsIndirectAMD));
			}
			if (SuportedExt.Contains("glMultiDrawElementsIndirectBindlessCountNV"))
			{
				dgtk.OpenGL.internalGLes.glMultiDrawElementsIndirectBindlessCountNV = (dgtk.OpenGL.delegatesGLes.glMultiDrawElementsIndirectBindlessCountNV) InternalTool.GetGLesMethodAdress("glMultiDrawElementsIndirectBindlessCountNV", typeof(dgtk.OpenGL.delegatesGLes.glMultiDrawElementsIndirectBindlessCountNV));
			}
			if (SuportedExt.Contains("glMultiDrawElementsIndirectBindlessNV"))
			{
				dgtk.OpenGL.internalGLes.glMultiDrawElementsIndirectBindlessNV = (dgtk.OpenGL.delegatesGLes.glMultiDrawElementsIndirectBindlessNV) InternalTool.GetGLesMethodAdress("glMultiDrawElementsIndirectBindlessNV", typeof(dgtk.OpenGL.delegatesGLes.glMultiDrawElementsIndirectBindlessNV));
			}
			if (SuportedExt.Contains("glMultiDrawElementsIndirectCountARB"))
			{
				dgtk.OpenGL.internalGLes.glMultiDrawElementsIndirectCountARB = (dgtk.OpenGL.delegatesGLes.glMultiDrawElementsIndirectCountARB) InternalTool.GetGLesMethodAdress("glMultiDrawElementsIndirectCountARB", typeof(dgtk.OpenGL.delegatesGLes.glMultiDrawElementsIndirectCountARB));
			}
			if (SuportedExt.Contains("glMultiDrawElementsIndirectEXT"))
			{
				dgtk.OpenGL.internalGLes.glMultiDrawElementsIndirectEXT = (dgtk.OpenGL.delegatesGLes.glMultiDrawElementsIndirectEXT) InternalTool.GetGLesMethodAdress("glMultiDrawElementsIndirectEXT", typeof(dgtk.OpenGL.delegatesGLes.glMultiDrawElementsIndirectEXT));
			}
			if (SuportedExt.Contains("glMultiDrawMeshTasksIndirectCountNV"))
			{
				dgtk.OpenGL.internalGLes.glMultiDrawMeshTasksIndirectCountNV = (dgtk.OpenGL.delegatesGLes.glMultiDrawMeshTasksIndirectCountNV) InternalTool.GetGLesMethodAdress("glMultiDrawMeshTasksIndirectCountNV", typeof(dgtk.OpenGL.delegatesGLes.glMultiDrawMeshTasksIndirectCountNV));
			}
			if (SuportedExt.Contains("glMultiDrawMeshTasksIndirectNV"))
			{
				dgtk.OpenGL.internalGLes.glMultiDrawMeshTasksIndirectNV = (dgtk.OpenGL.delegatesGLes.glMultiDrawMeshTasksIndirectNV) InternalTool.GetGLesMethodAdress("glMultiDrawMeshTasksIndirectNV", typeof(dgtk.OpenGL.delegatesGLes.glMultiDrawMeshTasksIndirectNV));
			}
			if (SuportedExt.Contains("glMultiDrawRangeElementArrayAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glMultiDrawRangeElementArrayAPPLE = (dgtk.OpenGL.delegatesGLes.glMultiDrawRangeElementArrayAPPLE) InternalTool.GetGLesMethodAdress("glMultiDrawRangeElementArrayAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glMultiDrawRangeElementArrayAPPLE));
			}
			if (SuportedExt.Contains("glMultiModeDrawArraysIBM"))
			{
				dgtk.OpenGL.internalGLes.glMultiModeDrawArraysIBM = (dgtk.OpenGL.delegatesGLes.glMultiModeDrawArraysIBM) InternalTool.GetGLesMethodAdress("glMultiModeDrawArraysIBM", typeof(dgtk.OpenGL.delegatesGLes.glMultiModeDrawArraysIBM));
			}
			if (SuportedExt.Contains("glMultiModeDrawElementsIBM"))
			{
				dgtk.OpenGL.internalGLes.glMultiModeDrawElementsIBM = (dgtk.OpenGL.delegatesGLes.glMultiModeDrawElementsIBM) InternalTool.GetGLesMethodAdress("glMultiModeDrawElementsIBM", typeof(dgtk.OpenGL.delegatesGLes.glMultiModeDrawElementsIBM));
			}
			if (SuportedExt.Contains("glMultiTexBufferEXT"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexBufferEXT = (dgtk.OpenGL.delegatesGLes.glMultiTexBufferEXT) InternalTool.GetGLesMethodAdress("glMultiTexBufferEXT", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexBufferEXT));
			}
			if (SuportedExt.Contains("glMultiTexCoord1bOES"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord1bOES = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord1bOES) InternalTool.GetGLesMethodAdress("glMultiTexCoord1bOES", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord1bOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord1bvOES"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord1bvOES = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord1bvOES) InternalTool.GetGLesMethodAdress("glMultiTexCoord1bvOES", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord1bvOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord1dARB"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord1dARB = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord1dARB) InternalTool.GetGLesMethodAdress("glMultiTexCoord1dARB", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord1dARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord1dvARB"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord1dvARB = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord1dvARB) InternalTool.GetGLesMethodAdress("glMultiTexCoord1dvARB", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord1dvARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord1fARB"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord1fARB = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord1fARB) InternalTool.GetGLesMethodAdress("glMultiTexCoord1fARB", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord1fARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord1fvARB"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord1fvARB = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord1fvARB) InternalTool.GetGLesMethodAdress("glMultiTexCoord1fvARB", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord1fvARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord1hNV"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord1hNV = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord1hNV) InternalTool.GetGLesMethodAdress("glMultiTexCoord1hNV", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord1hNV));
			}
			if (SuportedExt.Contains("glMultiTexCoord1hvNV"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord1hvNV = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord1hvNV) InternalTool.GetGLesMethodAdress("glMultiTexCoord1hvNV", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord1hvNV));
			}
			if (SuportedExt.Contains("glMultiTexCoord1iARB"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord1iARB = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord1iARB) InternalTool.GetGLesMethodAdress("glMultiTexCoord1iARB", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord1iARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord1ivARB"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord1ivARB = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord1ivARB) InternalTool.GetGLesMethodAdress("glMultiTexCoord1ivARB", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord1ivARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord1sARB"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord1sARB = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord1sARB) InternalTool.GetGLesMethodAdress("glMultiTexCoord1sARB", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord1sARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord1svARB"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord1svARB = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord1svARB) InternalTool.GetGLesMethodAdress("glMultiTexCoord1svARB", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord1svARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord1xOES"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord1xOES = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord1xOES) InternalTool.GetGLesMethodAdress("glMultiTexCoord1xOES", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord1xOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord1xvOES"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord1xvOES = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord1xvOES) InternalTool.GetGLesMethodAdress("glMultiTexCoord1xvOES", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord1xvOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord2bOES"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord2bOES = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord2bOES) InternalTool.GetGLesMethodAdress("glMultiTexCoord2bOES", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord2bOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord2bvOES"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord2bvOES = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord2bvOES) InternalTool.GetGLesMethodAdress("glMultiTexCoord2bvOES", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord2bvOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord2dARB"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord2dARB = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord2dARB) InternalTool.GetGLesMethodAdress("glMultiTexCoord2dARB", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord2dARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord2dvARB"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord2dvARB = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord2dvARB) InternalTool.GetGLesMethodAdress("glMultiTexCoord2dvARB", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord2dvARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord2fARB"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord2fARB = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord2fARB) InternalTool.GetGLesMethodAdress("glMultiTexCoord2fARB", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord2fARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord2fvARB"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord2fvARB = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord2fvARB) InternalTool.GetGLesMethodAdress("glMultiTexCoord2fvARB", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord2fvARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord2hNV"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord2hNV = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord2hNV) InternalTool.GetGLesMethodAdress("glMultiTexCoord2hNV", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord2hNV));
			}
			if (SuportedExt.Contains("glMultiTexCoord2hvNV"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord2hvNV = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord2hvNV) InternalTool.GetGLesMethodAdress("glMultiTexCoord2hvNV", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord2hvNV));
			}
			if (SuportedExt.Contains("glMultiTexCoord2iARB"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord2iARB = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord2iARB) InternalTool.GetGLesMethodAdress("glMultiTexCoord2iARB", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord2iARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord2ivARB"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord2ivARB = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord2ivARB) InternalTool.GetGLesMethodAdress("glMultiTexCoord2ivARB", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord2ivARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord2sARB"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord2sARB = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord2sARB) InternalTool.GetGLesMethodAdress("glMultiTexCoord2sARB", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord2sARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord2svARB"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord2svARB = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord2svARB) InternalTool.GetGLesMethodAdress("glMultiTexCoord2svARB", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord2svARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord2xOES"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord2xOES = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord2xOES) InternalTool.GetGLesMethodAdress("glMultiTexCoord2xOES", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord2xOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord2xvOES"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord2xvOES = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord2xvOES) InternalTool.GetGLesMethodAdress("glMultiTexCoord2xvOES", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord2xvOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord3bOES"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord3bOES = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord3bOES) InternalTool.GetGLesMethodAdress("glMultiTexCoord3bOES", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord3bOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord3bvOES"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord3bvOES = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord3bvOES) InternalTool.GetGLesMethodAdress("glMultiTexCoord3bvOES", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord3bvOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord3dARB"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord3dARB = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord3dARB) InternalTool.GetGLesMethodAdress("glMultiTexCoord3dARB", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord3dARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord3dvARB"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord3dvARB = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord3dvARB) InternalTool.GetGLesMethodAdress("glMultiTexCoord3dvARB", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord3dvARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord3fARB"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord3fARB = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord3fARB) InternalTool.GetGLesMethodAdress("glMultiTexCoord3fARB", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord3fARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord3fvARB"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord3fvARB = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord3fvARB) InternalTool.GetGLesMethodAdress("glMultiTexCoord3fvARB", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord3fvARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord3hNV"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord3hNV = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord3hNV) InternalTool.GetGLesMethodAdress("glMultiTexCoord3hNV", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord3hNV));
			}
			if (SuportedExt.Contains("glMultiTexCoord3hvNV"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord3hvNV = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord3hvNV) InternalTool.GetGLesMethodAdress("glMultiTexCoord3hvNV", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord3hvNV));
			}
			if (SuportedExt.Contains("glMultiTexCoord3iARB"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord3iARB = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord3iARB) InternalTool.GetGLesMethodAdress("glMultiTexCoord3iARB", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord3iARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord3ivARB"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord3ivARB = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord3ivARB) InternalTool.GetGLesMethodAdress("glMultiTexCoord3ivARB", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord3ivARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord3sARB"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord3sARB = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord3sARB) InternalTool.GetGLesMethodAdress("glMultiTexCoord3sARB", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord3sARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord3svARB"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord3svARB = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord3svARB) InternalTool.GetGLesMethodAdress("glMultiTexCoord3svARB", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord3svARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord3xOES"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord3xOES = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord3xOES) InternalTool.GetGLesMethodAdress("glMultiTexCoord3xOES", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord3xOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord3xvOES"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord3xvOES = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord3xvOES) InternalTool.GetGLesMethodAdress("glMultiTexCoord3xvOES", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord3xvOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord4bOES"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord4bOES = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord4bOES) InternalTool.GetGLesMethodAdress("glMultiTexCoord4bOES", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord4bOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord4bvOES"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord4bvOES = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord4bvOES) InternalTool.GetGLesMethodAdress("glMultiTexCoord4bvOES", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord4bvOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord4dARB"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord4dARB = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord4dARB) InternalTool.GetGLesMethodAdress("glMultiTexCoord4dARB", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord4dARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord4dvARB"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord4dvARB = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord4dvARB) InternalTool.GetGLesMethodAdress("glMultiTexCoord4dvARB", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord4dvARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord4fARB"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord4fARB = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord4fARB) InternalTool.GetGLesMethodAdress("glMultiTexCoord4fARB", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord4fARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord4fvARB"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord4fvARB = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord4fvARB) InternalTool.GetGLesMethodAdress("glMultiTexCoord4fvARB", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord4fvARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord4hNV"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord4hNV = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord4hNV) InternalTool.GetGLesMethodAdress("glMultiTexCoord4hNV", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord4hNV));
			}
			if (SuportedExt.Contains("glMultiTexCoord4hvNV"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord4hvNV = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord4hvNV) InternalTool.GetGLesMethodAdress("glMultiTexCoord4hvNV", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord4hvNV));
			}
			if (SuportedExt.Contains("glMultiTexCoord4iARB"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord4iARB = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord4iARB) InternalTool.GetGLesMethodAdress("glMultiTexCoord4iARB", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord4iARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord4ivARB"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord4ivARB = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord4ivARB) InternalTool.GetGLesMethodAdress("glMultiTexCoord4ivARB", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord4ivARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord4sARB"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord4sARB = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord4sARB) InternalTool.GetGLesMethodAdress("glMultiTexCoord4sARB", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord4sARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord4svARB"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord4svARB = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord4svARB) InternalTool.GetGLesMethodAdress("glMultiTexCoord4svARB", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord4svARB));
			}
			if (SuportedExt.Contains("glMultiTexCoord4x"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord4x = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord4x) InternalTool.GetGLesMethodAdress("glMultiTexCoord4x", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord4x));
			}
			if (SuportedExt.Contains("glMultiTexCoord4xOES"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord4xOES = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord4xOES) InternalTool.GetGLesMethodAdress("glMultiTexCoord4xOES", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord4xOES));
			}
			if (SuportedExt.Contains("glMultiTexCoord4xvOES"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoord4xvOES = (dgtk.OpenGL.delegatesGLes.glMultiTexCoord4xvOES) InternalTool.GetGLesMethodAdress("glMultiTexCoord4xvOES", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoord4xvOES));
			}
			if (SuportedExt.Contains("glMultiTexCoordPointerEXT"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexCoordPointerEXT = (dgtk.OpenGL.delegatesGLes.glMultiTexCoordPointerEXT) InternalTool.GetGLesMethodAdress("glMultiTexCoordPointerEXT", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexCoordPointerEXT));
			}
			if (SuportedExt.Contains("glMultiTexEnvfEXT"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexEnvfEXT = (dgtk.OpenGL.delegatesGLes.glMultiTexEnvfEXT) InternalTool.GetGLesMethodAdress("glMultiTexEnvfEXT", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexEnvfEXT));
			}
			if (SuportedExt.Contains("glMultiTexEnvfvEXT"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexEnvfvEXT = (dgtk.OpenGL.delegatesGLes.glMultiTexEnvfvEXT) InternalTool.GetGLesMethodAdress("glMultiTexEnvfvEXT", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexEnvfvEXT));
			}
			if (SuportedExt.Contains("glMultiTexEnviEXT"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexEnviEXT = (dgtk.OpenGL.delegatesGLes.glMultiTexEnviEXT) InternalTool.GetGLesMethodAdress("glMultiTexEnviEXT", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexEnviEXT));
			}
			if (SuportedExt.Contains("glMultiTexEnvivEXT"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexEnvivEXT = (dgtk.OpenGL.delegatesGLes.glMultiTexEnvivEXT) InternalTool.GetGLesMethodAdress("glMultiTexEnvivEXT", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexEnvivEXT));
			}
			if (SuportedExt.Contains("glMultiTexGendEXT"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexGendEXT = (dgtk.OpenGL.delegatesGLes.glMultiTexGendEXT) InternalTool.GetGLesMethodAdress("glMultiTexGendEXT", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexGendEXT));
			}
			if (SuportedExt.Contains("glMultiTexGendvEXT"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexGendvEXT = (dgtk.OpenGL.delegatesGLes.glMultiTexGendvEXT) InternalTool.GetGLesMethodAdress("glMultiTexGendvEXT", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexGendvEXT));
			}
			if (SuportedExt.Contains("glMultiTexGenfEXT"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexGenfEXT = (dgtk.OpenGL.delegatesGLes.glMultiTexGenfEXT) InternalTool.GetGLesMethodAdress("glMultiTexGenfEXT", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexGenfEXT));
			}
			if (SuportedExt.Contains("glMultiTexGenfvEXT"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexGenfvEXT = (dgtk.OpenGL.delegatesGLes.glMultiTexGenfvEXT) InternalTool.GetGLesMethodAdress("glMultiTexGenfvEXT", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexGenfvEXT));
			}
			if (SuportedExt.Contains("glMultiTexGeniEXT"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexGeniEXT = (dgtk.OpenGL.delegatesGLes.glMultiTexGeniEXT) InternalTool.GetGLesMethodAdress("glMultiTexGeniEXT", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexGeniEXT));
			}
			if (SuportedExt.Contains("glMultiTexGenivEXT"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexGenivEXT = (dgtk.OpenGL.delegatesGLes.glMultiTexGenivEXT) InternalTool.GetGLesMethodAdress("glMultiTexGenivEXT", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexGenivEXT));
			}
			if (SuportedExt.Contains("glMultiTexImage1DEXT"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexImage1DEXT = (dgtk.OpenGL.delegatesGLes.glMultiTexImage1DEXT) InternalTool.GetGLesMethodAdress("glMultiTexImage1DEXT", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexImage1DEXT));
			}
			if (SuportedExt.Contains("glMultiTexImage2DEXT"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexImage2DEXT = (dgtk.OpenGL.delegatesGLes.glMultiTexImage2DEXT) InternalTool.GetGLesMethodAdress("glMultiTexImage2DEXT", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexImage2DEXT));
			}
			if (SuportedExt.Contains("glMultiTexImage3DEXT"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexImage3DEXT = (dgtk.OpenGL.delegatesGLes.glMultiTexImage3DEXT) InternalTool.GetGLesMethodAdress("glMultiTexImage3DEXT", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexImage3DEXT));
			}
			if (SuportedExt.Contains("glMultiTexParameterfEXT"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexParameterfEXT = (dgtk.OpenGL.delegatesGLes.glMultiTexParameterfEXT) InternalTool.GetGLesMethodAdress("glMultiTexParameterfEXT", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexParameterfEXT));
			}
			if (SuportedExt.Contains("glMultiTexParameterfvEXT"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexParameterfvEXT = (dgtk.OpenGL.delegatesGLes.glMultiTexParameterfvEXT) InternalTool.GetGLesMethodAdress("glMultiTexParameterfvEXT", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexParameterfvEXT));
			}
			if (SuportedExt.Contains("glMultiTexParameteriEXT"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexParameteriEXT = (dgtk.OpenGL.delegatesGLes.glMultiTexParameteriEXT) InternalTool.GetGLesMethodAdress("glMultiTexParameteriEXT", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexParameteriEXT));
			}
			if (SuportedExt.Contains("glMultiTexParameterIivEXT"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexParameterIivEXT = (dgtk.OpenGL.delegatesGLes.glMultiTexParameterIivEXT) InternalTool.GetGLesMethodAdress("glMultiTexParameterIivEXT", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexParameterIivEXT));
			}
			if (SuportedExt.Contains("glMultiTexParameterIuivEXT"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexParameterIuivEXT = (dgtk.OpenGL.delegatesGLes.glMultiTexParameterIuivEXT) InternalTool.GetGLesMethodAdress("glMultiTexParameterIuivEXT", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexParameterIuivEXT));
			}
			if (SuportedExt.Contains("glMultiTexParameterivEXT"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexParameterivEXT = (dgtk.OpenGL.delegatesGLes.glMultiTexParameterivEXT) InternalTool.GetGLesMethodAdress("glMultiTexParameterivEXT", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexParameterivEXT));
			}
			if (SuportedExt.Contains("glMultiTexRenderbufferEXT"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexRenderbufferEXT = (dgtk.OpenGL.delegatesGLes.glMultiTexRenderbufferEXT) InternalTool.GetGLesMethodAdress("glMultiTexRenderbufferEXT", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexRenderbufferEXT));
			}
			if (SuportedExt.Contains("glMultiTexSubImage1DEXT"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexSubImage1DEXT = (dgtk.OpenGL.delegatesGLes.glMultiTexSubImage1DEXT) InternalTool.GetGLesMethodAdress("glMultiTexSubImage1DEXT", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexSubImage1DEXT));
			}
			if (SuportedExt.Contains("glMultiTexSubImage2DEXT"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexSubImage2DEXT = (dgtk.OpenGL.delegatesGLes.glMultiTexSubImage2DEXT) InternalTool.GetGLesMethodAdress("glMultiTexSubImage2DEXT", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexSubImage2DEXT));
			}
			if (SuportedExt.Contains("glMultiTexSubImage3DEXT"))
			{
				dgtk.OpenGL.internalGLes.glMultiTexSubImage3DEXT = (dgtk.OpenGL.delegatesGLes.glMultiTexSubImage3DEXT) InternalTool.GetGLesMethodAdress("glMultiTexSubImage3DEXT", typeof(dgtk.OpenGL.delegatesGLes.glMultiTexSubImage3DEXT));
			}
			if (SuportedExt.Contains("glMultMatrixx"))
			{
				dgtk.OpenGL.internalGLes.glMultMatrixx = (dgtk.OpenGL.delegatesGLes.glMultMatrixx) InternalTool.GetGLesMethodAdress("glMultMatrixx", typeof(dgtk.OpenGL.delegatesGLes.glMultMatrixx));
			}
			if (SuportedExt.Contains("glMultMatrixxOES"))
			{
				dgtk.OpenGL.internalGLes.glMultMatrixxOES = (dgtk.OpenGL.delegatesGLes.glMultMatrixxOES) InternalTool.GetGLesMethodAdress("glMultMatrixxOES", typeof(dgtk.OpenGL.delegatesGLes.glMultMatrixxOES));
			}
			if (SuportedExt.Contains("glMultTransposeMatrixdARB"))
			{
				dgtk.OpenGL.internalGLes.glMultTransposeMatrixdARB = (dgtk.OpenGL.delegatesGLes.glMultTransposeMatrixdARB) InternalTool.GetGLesMethodAdress("glMultTransposeMatrixdARB", typeof(dgtk.OpenGL.delegatesGLes.glMultTransposeMatrixdARB));
			}
			if (SuportedExt.Contains("glMultTransposeMatrixfARB"))
			{
				dgtk.OpenGL.internalGLes.glMultTransposeMatrixfARB = (dgtk.OpenGL.delegatesGLes.glMultTransposeMatrixfARB) InternalTool.GetGLesMethodAdress("glMultTransposeMatrixfARB", typeof(dgtk.OpenGL.delegatesGLes.glMultTransposeMatrixfARB));
			}
			if (SuportedExt.Contains("glMultTransposeMatrixxOES"))
			{
				dgtk.OpenGL.internalGLes.glMultTransposeMatrixxOES = (dgtk.OpenGL.delegatesGLes.glMultTransposeMatrixxOES) InternalTool.GetGLesMethodAdress("glMultTransposeMatrixxOES", typeof(dgtk.OpenGL.delegatesGLes.glMultTransposeMatrixxOES));
			}
			#endregion

			#region N:

			if (SuportedExt.Contains("glNamedBufferAttachMemoryNV"))
			{
				dgtk.OpenGL.internalGLes.glNamedBufferAttachMemoryNV = (dgtk.OpenGL.delegatesGLes.glNamedBufferAttachMemoryNV) InternalTool.GetGLesMethodAdress("glNamedBufferAttachMemoryNV", typeof(dgtk.OpenGL.delegatesGLes.glNamedBufferAttachMemoryNV));
			}
			if (SuportedExt.Contains("glNamedBufferDataEXT"))
			{
				dgtk.OpenGL.internalGLes.glNamedBufferDataEXT = (dgtk.OpenGL.delegatesGLes.glNamedBufferDataEXT) InternalTool.GetGLesMethodAdress("glNamedBufferDataEXT", typeof(dgtk.OpenGL.delegatesGLes.glNamedBufferDataEXT));
			}
			if (SuportedExt.Contains("glNamedBufferPageCommitmentARB"))
			{
				dgtk.OpenGL.internalGLes.glNamedBufferPageCommitmentARB = (dgtk.OpenGL.delegatesGLes.glNamedBufferPageCommitmentARB) InternalTool.GetGLesMethodAdress("glNamedBufferPageCommitmentARB", typeof(dgtk.OpenGL.delegatesGLes.glNamedBufferPageCommitmentARB));
			}
			if (SuportedExt.Contains("glNamedBufferPageCommitmentEXT"))
			{
				dgtk.OpenGL.internalGLes.glNamedBufferPageCommitmentEXT = (dgtk.OpenGL.delegatesGLes.glNamedBufferPageCommitmentEXT) InternalTool.GetGLesMethodAdress("glNamedBufferPageCommitmentEXT", typeof(dgtk.OpenGL.delegatesGLes.glNamedBufferPageCommitmentEXT));
			}
			if (SuportedExt.Contains("glNamedBufferPageCommitmentMemNV"))
			{
				dgtk.OpenGL.internalGLes.glNamedBufferPageCommitmentMemNV = (dgtk.OpenGL.delegatesGLes.glNamedBufferPageCommitmentMemNV) InternalTool.GetGLesMethodAdress("glNamedBufferPageCommitmentMemNV", typeof(dgtk.OpenGL.delegatesGLes.glNamedBufferPageCommitmentMemNV));
			}
			if (SuportedExt.Contains("glNamedBufferStorageEXT"))
			{
				dgtk.OpenGL.internalGLes.glNamedBufferStorageEXT = (dgtk.OpenGL.delegatesGLes.glNamedBufferStorageEXT) InternalTool.GetGLesMethodAdress("glNamedBufferStorageEXT", typeof(dgtk.OpenGL.delegatesGLes.glNamedBufferStorageEXT));
			}
			if (SuportedExt.Contains("glNamedBufferStorageExternalEXT"))
			{
				dgtk.OpenGL.internalGLes.glNamedBufferStorageExternalEXT = (dgtk.OpenGL.delegatesGLes.glNamedBufferStorageExternalEXT) InternalTool.GetGLesMethodAdress("glNamedBufferStorageExternalEXT", typeof(dgtk.OpenGL.delegatesGLes.glNamedBufferStorageExternalEXT));
			}
			if (SuportedExt.Contains("glNamedBufferStorageMemEXT"))
			{
				dgtk.OpenGL.internalGLes.glNamedBufferStorageMemEXT = (dgtk.OpenGL.delegatesGLes.glNamedBufferStorageMemEXT) InternalTool.GetGLesMethodAdress("glNamedBufferStorageMemEXT", typeof(dgtk.OpenGL.delegatesGLes.glNamedBufferStorageMemEXT));
			}
			if (SuportedExt.Contains("glNamedBufferSubDataEXT"))
			{
				dgtk.OpenGL.internalGLes.glNamedBufferSubDataEXT = (dgtk.OpenGL.delegatesGLes.glNamedBufferSubDataEXT) InternalTool.GetGLesMethodAdress("glNamedBufferSubDataEXT", typeof(dgtk.OpenGL.delegatesGLes.glNamedBufferSubDataEXT));
			}
			if (SuportedExt.Contains("glNamedCopyBufferSubDataEXT"))
			{
				dgtk.OpenGL.internalGLes.glNamedCopyBufferSubDataEXT = (dgtk.OpenGL.delegatesGLes.glNamedCopyBufferSubDataEXT) InternalTool.GetGLesMethodAdress("glNamedCopyBufferSubDataEXT", typeof(dgtk.OpenGL.delegatesGLes.glNamedCopyBufferSubDataEXT));
			}
			if (SuportedExt.Contains("glNamedFramebufferParameteriEXT"))
			{
				dgtk.OpenGL.internalGLes.glNamedFramebufferParameteriEXT = (dgtk.OpenGL.delegatesGLes.glNamedFramebufferParameteriEXT) InternalTool.GetGLesMethodAdress("glNamedFramebufferParameteriEXT", typeof(dgtk.OpenGL.delegatesGLes.glNamedFramebufferParameteriEXT));
			}
			if (SuportedExt.Contains("glNamedFramebufferRenderbufferEXT"))
			{
				dgtk.OpenGL.internalGLes.glNamedFramebufferRenderbufferEXT = (dgtk.OpenGL.delegatesGLes.glNamedFramebufferRenderbufferEXT) InternalTool.GetGLesMethodAdress("glNamedFramebufferRenderbufferEXT", typeof(dgtk.OpenGL.delegatesGLes.glNamedFramebufferRenderbufferEXT));
			}
			if (SuportedExt.Contains("glNamedFramebufferSampleLocationsfvARB"))
			{
				dgtk.OpenGL.internalGLes.glNamedFramebufferSampleLocationsfvARB = (dgtk.OpenGL.delegatesGLes.glNamedFramebufferSampleLocationsfvARB) InternalTool.GetGLesMethodAdress("glNamedFramebufferSampleLocationsfvARB", typeof(dgtk.OpenGL.delegatesGLes.glNamedFramebufferSampleLocationsfvARB));
			}
			if (SuportedExt.Contains("glNamedFramebufferSampleLocationsfvNV"))
			{
				dgtk.OpenGL.internalGLes.glNamedFramebufferSampleLocationsfvNV = (dgtk.OpenGL.delegatesGLes.glNamedFramebufferSampleLocationsfvNV) InternalTool.GetGLesMethodAdress("glNamedFramebufferSampleLocationsfvNV", typeof(dgtk.OpenGL.delegatesGLes.glNamedFramebufferSampleLocationsfvNV));
			}
			if (SuportedExt.Contains("glNamedFramebufferSamplePositionsfvAMD"))
			{
				dgtk.OpenGL.internalGLes.glNamedFramebufferSamplePositionsfvAMD = (dgtk.OpenGL.delegatesGLes.glNamedFramebufferSamplePositionsfvAMD) InternalTool.GetGLesMethodAdress("glNamedFramebufferSamplePositionsfvAMD", typeof(dgtk.OpenGL.delegatesGLes.glNamedFramebufferSamplePositionsfvAMD));
			}
			if (SuportedExt.Contains("glNamedFramebufferTexture1DEXT"))
			{
				dgtk.OpenGL.internalGLes.glNamedFramebufferTexture1DEXT = (dgtk.OpenGL.delegatesGLes.glNamedFramebufferTexture1DEXT) InternalTool.GetGLesMethodAdress("glNamedFramebufferTexture1DEXT", typeof(dgtk.OpenGL.delegatesGLes.glNamedFramebufferTexture1DEXT));
			}
			if (SuportedExt.Contains("glNamedFramebufferTexture2DEXT"))
			{
				dgtk.OpenGL.internalGLes.glNamedFramebufferTexture2DEXT = (dgtk.OpenGL.delegatesGLes.glNamedFramebufferTexture2DEXT) InternalTool.GetGLesMethodAdress("glNamedFramebufferTexture2DEXT", typeof(dgtk.OpenGL.delegatesGLes.glNamedFramebufferTexture2DEXT));
			}
			if (SuportedExt.Contains("glNamedFramebufferTexture3DEXT"))
			{
				dgtk.OpenGL.internalGLes.glNamedFramebufferTexture3DEXT = (dgtk.OpenGL.delegatesGLes.glNamedFramebufferTexture3DEXT) InternalTool.GetGLesMethodAdress("glNamedFramebufferTexture3DEXT", typeof(dgtk.OpenGL.delegatesGLes.glNamedFramebufferTexture3DEXT));
			}
			if (SuportedExt.Contains("glNamedFramebufferTextureEXT"))
			{
				dgtk.OpenGL.internalGLes.glNamedFramebufferTextureEXT = (dgtk.OpenGL.delegatesGLes.glNamedFramebufferTextureEXT) InternalTool.GetGLesMethodAdress("glNamedFramebufferTextureEXT", typeof(dgtk.OpenGL.delegatesGLes.glNamedFramebufferTextureEXT));
			}
			if (SuportedExt.Contains("glNamedFramebufferTextureFaceEXT"))
			{
				dgtk.OpenGL.internalGLes.glNamedFramebufferTextureFaceEXT = (dgtk.OpenGL.delegatesGLes.glNamedFramebufferTextureFaceEXT) InternalTool.GetGLesMethodAdress("glNamedFramebufferTextureFaceEXT", typeof(dgtk.OpenGL.delegatesGLes.glNamedFramebufferTextureFaceEXT));
			}
			if (SuportedExt.Contains("glNamedFramebufferTextureLayerEXT"))
			{
				dgtk.OpenGL.internalGLes.glNamedFramebufferTextureLayerEXT = (dgtk.OpenGL.delegatesGLes.glNamedFramebufferTextureLayerEXT) InternalTool.GetGLesMethodAdress("glNamedFramebufferTextureLayerEXT", typeof(dgtk.OpenGL.delegatesGLes.glNamedFramebufferTextureLayerEXT));
			}
			if (SuportedExt.Contains("glNamedProgramLocalParameter4dEXT"))
			{
				dgtk.OpenGL.internalGLes.glNamedProgramLocalParameter4dEXT = (dgtk.OpenGL.delegatesGLes.glNamedProgramLocalParameter4dEXT) InternalTool.GetGLesMethodAdress("glNamedProgramLocalParameter4dEXT", typeof(dgtk.OpenGL.delegatesGLes.glNamedProgramLocalParameter4dEXT));
			}
			if (SuportedExt.Contains("glNamedProgramLocalParameter4dvEXT"))
			{
				dgtk.OpenGL.internalGLes.glNamedProgramLocalParameter4dvEXT = (dgtk.OpenGL.delegatesGLes.glNamedProgramLocalParameter4dvEXT) InternalTool.GetGLesMethodAdress("glNamedProgramLocalParameter4dvEXT", typeof(dgtk.OpenGL.delegatesGLes.glNamedProgramLocalParameter4dvEXT));
			}
			if (SuportedExt.Contains("glNamedProgramLocalParameter4fEXT"))
			{
				dgtk.OpenGL.internalGLes.glNamedProgramLocalParameter4fEXT = (dgtk.OpenGL.delegatesGLes.glNamedProgramLocalParameter4fEXT) InternalTool.GetGLesMethodAdress("glNamedProgramLocalParameter4fEXT", typeof(dgtk.OpenGL.delegatesGLes.glNamedProgramLocalParameter4fEXT));
			}
			if (SuportedExt.Contains("glNamedProgramLocalParameter4fvEXT"))
			{
				dgtk.OpenGL.internalGLes.glNamedProgramLocalParameter4fvEXT = (dgtk.OpenGL.delegatesGLes.glNamedProgramLocalParameter4fvEXT) InternalTool.GetGLesMethodAdress("glNamedProgramLocalParameter4fvEXT", typeof(dgtk.OpenGL.delegatesGLes.glNamedProgramLocalParameter4fvEXT));
			}
			if (SuportedExt.Contains("glNamedProgramLocalParameterI4iEXT"))
			{
				dgtk.OpenGL.internalGLes.glNamedProgramLocalParameterI4iEXT = (dgtk.OpenGL.delegatesGLes.glNamedProgramLocalParameterI4iEXT) InternalTool.GetGLesMethodAdress("glNamedProgramLocalParameterI4iEXT", typeof(dgtk.OpenGL.delegatesGLes.glNamedProgramLocalParameterI4iEXT));
			}
			if (SuportedExt.Contains("glNamedProgramLocalParameterI4ivEXT"))
			{
				dgtk.OpenGL.internalGLes.glNamedProgramLocalParameterI4ivEXT = (dgtk.OpenGL.delegatesGLes.glNamedProgramLocalParameterI4ivEXT) InternalTool.GetGLesMethodAdress("glNamedProgramLocalParameterI4ivEXT", typeof(dgtk.OpenGL.delegatesGLes.glNamedProgramLocalParameterI4ivEXT));
			}
			if (SuportedExt.Contains("glNamedProgramLocalParameterI4uiEXT"))
			{
				dgtk.OpenGL.internalGLes.glNamedProgramLocalParameterI4uiEXT = (dgtk.OpenGL.delegatesGLes.glNamedProgramLocalParameterI4uiEXT) InternalTool.GetGLesMethodAdress("glNamedProgramLocalParameterI4uiEXT", typeof(dgtk.OpenGL.delegatesGLes.glNamedProgramLocalParameterI4uiEXT));
			}
			if (SuportedExt.Contains("glNamedProgramLocalParameterI4uivEXT"))
			{
				dgtk.OpenGL.internalGLes.glNamedProgramLocalParameterI4uivEXT = (dgtk.OpenGL.delegatesGLes.glNamedProgramLocalParameterI4uivEXT) InternalTool.GetGLesMethodAdress("glNamedProgramLocalParameterI4uivEXT", typeof(dgtk.OpenGL.delegatesGLes.glNamedProgramLocalParameterI4uivEXT));
			}
			if (SuportedExt.Contains("glNamedProgramLocalParameters4fvEXT"))
			{
				dgtk.OpenGL.internalGLes.glNamedProgramLocalParameters4fvEXT = (dgtk.OpenGL.delegatesGLes.glNamedProgramLocalParameters4fvEXT) InternalTool.GetGLesMethodAdress("glNamedProgramLocalParameters4fvEXT", typeof(dgtk.OpenGL.delegatesGLes.glNamedProgramLocalParameters4fvEXT));
			}
			if (SuportedExt.Contains("glNamedProgramLocalParametersI4ivEXT"))
			{
				dgtk.OpenGL.internalGLes.glNamedProgramLocalParametersI4ivEXT = (dgtk.OpenGL.delegatesGLes.glNamedProgramLocalParametersI4ivEXT) InternalTool.GetGLesMethodAdress("glNamedProgramLocalParametersI4ivEXT", typeof(dgtk.OpenGL.delegatesGLes.glNamedProgramLocalParametersI4ivEXT));
			}
			if (SuportedExt.Contains("glNamedProgramLocalParametersI4uivEXT"))
			{
				dgtk.OpenGL.internalGLes.glNamedProgramLocalParametersI4uivEXT = (dgtk.OpenGL.delegatesGLes.glNamedProgramLocalParametersI4uivEXT) InternalTool.GetGLesMethodAdress("glNamedProgramLocalParametersI4uivEXT", typeof(dgtk.OpenGL.delegatesGLes.glNamedProgramLocalParametersI4uivEXT));
			}
			if (SuportedExt.Contains("glNamedProgramStringEXT"))
			{
				dgtk.OpenGL.internalGLes.glNamedProgramStringEXT = (dgtk.OpenGL.delegatesGLes.glNamedProgramStringEXT) InternalTool.GetGLesMethodAdress("glNamedProgramStringEXT", typeof(dgtk.OpenGL.delegatesGLes.glNamedProgramStringEXT));
			}
			if (SuportedExt.Contains("glNamedRenderbufferStorageEXT"))
			{
				dgtk.OpenGL.internalGLes.glNamedRenderbufferStorageEXT = (dgtk.OpenGL.delegatesGLes.glNamedRenderbufferStorageEXT) InternalTool.GetGLesMethodAdress("glNamedRenderbufferStorageEXT", typeof(dgtk.OpenGL.delegatesGLes.glNamedRenderbufferStorageEXT));
			}
			if (SuportedExt.Contains("glNamedRenderbufferStorageMultisampleAdvancedAMD"))
			{
				dgtk.OpenGL.internalGLes.glNamedRenderbufferStorageMultisampleAdvancedAMD = (dgtk.OpenGL.delegatesGLes.glNamedRenderbufferStorageMultisampleAdvancedAMD) InternalTool.GetGLesMethodAdress("glNamedRenderbufferStorageMultisampleAdvancedAMD", typeof(dgtk.OpenGL.delegatesGLes.glNamedRenderbufferStorageMultisampleAdvancedAMD));
			}
			if (SuportedExt.Contains("glNamedRenderbufferStorageMultisampleCoverageEXT"))
			{
				dgtk.OpenGL.internalGLes.glNamedRenderbufferStorageMultisampleCoverageEXT = (dgtk.OpenGL.delegatesGLes.glNamedRenderbufferStorageMultisampleCoverageEXT) InternalTool.GetGLesMethodAdress("glNamedRenderbufferStorageMultisampleCoverageEXT", typeof(dgtk.OpenGL.delegatesGLes.glNamedRenderbufferStorageMultisampleCoverageEXT));
			}
			if (SuportedExt.Contains("glNamedRenderbufferStorageMultisampleEXT"))
			{
				dgtk.OpenGL.internalGLes.glNamedRenderbufferStorageMultisampleEXT = (dgtk.OpenGL.delegatesGLes.glNamedRenderbufferStorageMultisampleEXT) InternalTool.GetGLesMethodAdress("glNamedRenderbufferStorageMultisampleEXT", typeof(dgtk.OpenGL.delegatesGLes.glNamedRenderbufferStorageMultisampleEXT));
			}
			if (SuportedExt.Contains("glNamedStringARB"))
			{
				dgtk.OpenGL.internalGLes.glNamedStringARB = (dgtk.OpenGL.delegatesGLes.glNamedStringARB) InternalTool.GetGLesMethodAdress("glNamedStringARB", typeof(dgtk.OpenGL.delegatesGLes.glNamedStringARB));
			}
			if (SuportedExt.Contains("glNewObjectBufferATI"))
			{
				dgtk.OpenGL.internalGLes.glNewObjectBufferATI = (dgtk.OpenGL.delegatesGLes.glNewObjectBufferATI) InternalTool.GetGLesMethodAdress("glNewObjectBufferATI", typeof(dgtk.OpenGL.delegatesGLes.glNewObjectBufferATI));
			}
			if (SuportedExt.Contains("glNormal3fVertex3fSUN"))
			{
				dgtk.OpenGL.internalGLes.glNormal3fVertex3fSUN = (dgtk.OpenGL.delegatesGLes.glNormal3fVertex3fSUN) InternalTool.GetGLesMethodAdress("glNormal3fVertex3fSUN", typeof(dgtk.OpenGL.delegatesGLes.glNormal3fVertex3fSUN));
			}
			if (SuportedExt.Contains("glNormal3fVertex3fvSUN"))
			{
				dgtk.OpenGL.internalGLes.glNormal3fVertex3fvSUN = (dgtk.OpenGL.delegatesGLes.glNormal3fVertex3fvSUN) InternalTool.GetGLesMethodAdress("glNormal3fVertex3fvSUN", typeof(dgtk.OpenGL.delegatesGLes.glNormal3fVertex3fvSUN));
			}
			if (SuportedExt.Contains("glNormal3hNV"))
			{
				dgtk.OpenGL.internalGLes.glNormal3hNV = (dgtk.OpenGL.delegatesGLes.glNormal3hNV) InternalTool.GetGLesMethodAdress("glNormal3hNV", typeof(dgtk.OpenGL.delegatesGLes.glNormal3hNV));
			}
			if (SuportedExt.Contains("glNormal3hvNV"))
			{
				dgtk.OpenGL.internalGLes.glNormal3hvNV = (dgtk.OpenGL.delegatesGLes.glNormal3hvNV) InternalTool.GetGLesMethodAdress("glNormal3hvNV", typeof(dgtk.OpenGL.delegatesGLes.glNormal3hvNV));
			}
			if (SuportedExt.Contains("glNormal3x"))
			{
				dgtk.OpenGL.internalGLes.glNormal3x = (dgtk.OpenGL.delegatesGLes.glNormal3x) InternalTool.GetGLesMethodAdress("glNormal3x", typeof(dgtk.OpenGL.delegatesGLes.glNormal3x));
			}
			if (SuportedExt.Contains("glNormal3xOES"))
			{
				dgtk.OpenGL.internalGLes.glNormal3xOES = (dgtk.OpenGL.delegatesGLes.glNormal3xOES) InternalTool.GetGLesMethodAdress("glNormal3xOES", typeof(dgtk.OpenGL.delegatesGLes.glNormal3xOES));
			}
			if (SuportedExt.Contains("glNormal3xvOES"))
			{
				dgtk.OpenGL.internalGLes.glNormal3xvOES = (dgtk.OpenGL.delegatesGLes.glNormal3xvOES) InternalTool.GetGLesMethodAdress("glNormal3xvOES", typeof(dgtk.OpenGL.delegatesGLes.glNormal3xvOES));
			}
			if (SuportedExt.Contains("glNormalFormatNV"))
			{
				dgtk.OpenGL.internalGLes.glNormalFormatNV = (dgtk.OpenGL.delegatesGLes.glNormalFormatNV) InternalTool.GetGLesMethodAdress("glNormalFormatNV", typeof(dgtk.OpenGL.delegatesGLes.glNormalFormatNV));
			}
			if (SuportedExt.Contains("glNormalPointerEXT"))
			{
				dgtk.OpenGL.internalGLes.glNormalPointerEXT = (dgtk.OpenGL.delegatesGLes.glNormalPointerEXT) InternalTool.GetGLesMethodAdress("glNormalPointerEXT", typeof(dgtk.OpenGL.delegatesGLes.glNormalPointerEXT));
			}
			if (SuportedExt.Contains("glNormalPointerListIBM"))
			{
				dgtk.OpenGL.internalGLes.glNormalPointerListIBM = (dgtk.OpenGL.delegatesGLes.glNormalPointerListIBM) InternalTool.GetGLesMethodAdress("glNormalPointerListIBM", typeof(dgtk.OpenGL.delegatesGLes.glNormalPointerListIBM));
			}
			if (SuportedExt.Contains("glNormalPointervINTEL"))
			{
				dgtk.OpenGL.internalGLes.glNormalPointervINTEL = (dgtk.OpenGL.delegatesGLes.glNormalPointervINTEL) InternalTool.GetGLesMethodAdress("glNormalPointervINTEL", typeof(dgtk.OpenGL.delegatesGLes.glNormalPointervINTEL));
			}
			if (SuportedExt.Contains("glNormalStream3bATI"))
			{
				dgtk.OpenGL.internalGLes.glNormalStream3bATI = (dgtk.OpenGL.delegatesGLes.glNormalStream3bATI) InternalTool.GetGLesMethodAdress("glNormalStream3bATI", typeof(dgtk.OpenGL.delegatesGLes.glNormalStream3bATI));
			}
			if (SuportedExt.Contains("glNormalStream3bvATI"))
			{
				dgtk.OpenGL.internalGLes.glNormalStream3bvATI = (dgtk.OpenGL.delegatesGLes.glNormalStream3bvATI) InternalTool.GetGLesMethodAdress("glNormalStream3bvATI", typeof(dgtk.OpenGL.delegatesGLes.glNormalStream3bvATI));
			}
			if (SuportedExt.Contains("glNormalStream3dATI"))
			{
				dgtk.OpenGL.internalGLes.glNormalStream3dATI = (dgtk.OpenGL.delegatesGLes.glNormalStream3dATI) InternalTool.GetGLesMethodAdress("glNormalStream3dATI", typeof(dgtk.OpenGL.delegatesGLes.glNormalStream3dATI));
			}
			if (SuportedExt.Contains("glNormalStream3dvATI"))
			{
				dgtk.OpenGL.internalGLes.glNormalStream3dvATI = (dgtk.OpenGL.delegatesGLes.glNormalStream3dvATI) InternalTool.GetGLesMethodAdress("glNormalStream3dvATI", typeof(dgtk.OpenGL.delegatesGLes.glNormalStream3dvATI));
			}
			if (SuportedExt.Contains("glNormalStream3fATI"))
			{
				dgtk.OpenGL.internalGLes.glNormalStream3fATI = (dgtk.OpenGL.delegatesGLes.glNormalStream3fATI) InternalTool.GetGLesMethodAdress("glNormalStream3fATI", typeof(dgtk.OpenGL.delegatesGLes.glNormalStream3fATI));
			}
			if (SuportedExt.Contains("glNormalStream3fvATI"))
			{
				dgtk.OpenGL.internalGLes.glNormalStream3fvATI = (dgtk.OpenGL.delegatesGLes.glNormalStream3fvATI) InternalTool.GetGLesMethodAdress("glNormalStream3fvATI", typeof(dgtk.OpenGL.delegatesGLes.glNormalStream3fvATI));
			}
			if (SuportedExt.Contains("glNormalStream3iATI"))
			{
				dgtk.OpenGL.internalGLes.glNormalStream3iATI = (dgtk.OpenGL.delegatesGLes.glNormalStream3iATI) InternalTool.GetGLesMethodAdress("glNormalStream3iATI", typeof(dgtk.OpenGL.delegatesGLes.glNormalStream3iATI));
			}
			if (SuportedExt.Contains("glNormalStream3ivATI"))
			{
				dgtk.OpenGL.internalGLes.glNormalStream3ivATI = (dgtk.OpenGL.delegatesGLes.glNormalStream3ivATI) InternalTool.GetGLesMethodAdress("glNormalStream3ivATI", typeof(dgtk.OpenGL.delegatesGLes.glNormalStream3ivATI));
			}
			if (SuportedExt.Contains("glNormalStream3sATI"))
			{
				dgtk.OpenGL.internalGLes.glNormalStream3sATI = (dgtk.OpenGL.delegatesGLes.glNormalStream3sATI) InternalTool.GetGLesMethodAdress("glNormalStream3sATI", typeof(dgtk.OpenGL.delegatesGLes.glNormalStream3sATI));
			}
			if (SuportedExt.Contains("glNormalStream3svATI"))
			{
				dgtk.OpenGL.internalGLes.glNormalStream3svATI = (dgtk.OpenGL.delegatesGLes.glNormalStream3svATI) InternalTool.GetGLesMethodAdress("glNormalStream3svATI", typeof(dgtk.OpenGL.delegatesGLes.glNormalStream3svATI));
			}
			#endregion

			#region O:

			if (SuportedExt.Contains("glObjectLabelKHR"))
			{
				dgtk.OpenGL.internalGLes.glObjectLabelKHR = (dgtk.OpenGL.delegatesGLes.glObjectLabelKHR) InternalTool.GetGLesMethodAdress("glObjectLabelKHR", typeof(dgtk.OpenGL.delegatesGLes.glObjectLabelKHR));
			}
			if (SuportedExt.Contains("glObjectPtrLabelKHR"))
			{
				dgtk.OpenGL.internalGLes.glObjectPtrLabelKHR = (dgtk.OpenGL.delegatesGLes.glObjectPtrLabelKHR) InternalTool.GetGLesMethodAdress("glObjectPtrLabelKHR", typeof(dgtk.OpenGL.delegatesGLes.glObjectPtrLabelKHR));
			}
			if (SuportedExt.Contains("glObjectPurgeableAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glObjectPurgeableAPPLE = (dgtk.OpenGL.delegatesGLes.glObjectPurgeableAPPLE) InternalTool.GetGLesMethodAdress("glObjectPurgeableAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glObjectPurgeableAPPLE));
			}
			if (SuportedExt.Contains("glObjectUnpurgeableAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glObjectUnpurgeableAPPLE = (dgtk.OpenGL.delegatesGLes.glObjectUnpurgeableAPPLE) InternalTool.GetGLesMethodAdress("glObjectUnpurgeableAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glObjectUnpurgeableAPPLE));
			}
			if (SuportedExt.Contains("glOrthof"))
			{
				dgtk.OpenGL.internalGLes.glOrthof = (dgtk.OpenGL.delegatesGLes.glOrthof) InternalTool.GetGLesMethodAdress("glOrthof", typeof(dgtk.OpenGL.delegatesGLes.glOrthof));
			}
			if (SuportedExt.Contains("glOrthofOES"))
			{
				dgtk.OpenGL.internalGLes.glOrthofOES = (dgtk.OpenGL.delegatesGLes.glOrthofOES) InternalTool.GetGLesMethodAdress("glOrthofOES", typeof(dgtk.OpenGL.delegatesGLes.glOrthofOES));
			}
			if (SuportedExt.Contains("glOrthox"))
			{
				dgtk.OpenGL.internalGLes.glOrthox = (dgtk.OpenGL.delegatesGLes.glOrthox) InternalTool.GetGLesMethodAdress("glOrthox", typeof(dgtk.OpenGL.delegatesGLes.glOrthox));
			}
			if (SuportedExt.Contains("glOrthoxOES"))
			{
				dgtk.OpenGL.internalGLes.glOrthoxOES = (dgtk.OpenGL.delegatesGLes.glOrthoxOES) InternalTool.GetGLesMethodAdress("glOrthoxOES", typeof(dgtk.OpenGL.delegatesGLes.glOrthoxOES));
			}
			#endregion

			#region P:

			if (SuportedExt.Contains("glPassTexCoordATI"))
			{
				dgtk.OpenGL.internalGLes.glPassTexCoordATI = (dgtk.OpenGL.delegatesGLes.glPassTexCoordATI) InternalTool.GetGLesMethodAdress("glPassTexCoordATI", typeof(dgtk.OpenGL.delegatesGLes.glPassTexCoordATI));
			}
			if (SuportedExt.Contains("glPassThroughxOES"))
			{
				dgtk.OpenGL.internalGLes.glPassThroughxOES = (dgtk.OpenGL.delegatesGLes.glPassThroughxOES) InternalTool.GetGLesMethodAdress("glPassThroughxOES", typeof(dgtk.OpenGL.delegatesGLes.glPassThroughxOES));
			}
			if (SuportedExt.Contains("glPatchParameteriEXT"))
			{
				dgtk.OpenGL.internalGLes.glPatchParameteriEXT = (dgtk.OpenGL.delegatesGLes.glPatchParameteriEXT) InternalTool.GetGLesMethodAdress("glPatchParameteriEXT", typeof(dgtk.OpenGL.delegatesGLes.glPatchParameteriEXT));
			}
			if (SuportedExt.Contains("glPatchParameteriOES"))
			{
				dgtk.OpenGL.internalGLes.glPatchParameteriOES = (dgtk.OpenGL.delegatesGLes.glPatchParameteriOES) InternalTool.GetGLesMethodAdress("glPatchParameteriOES", typeof(dgtk.OpenGL.delegatesGLes.glPatchParameteriOES));
			}
			if (SuportedExt.Contains("glPathColorGenNV"))
			{
				dgtk.OpenGL.internalGLes.glPathColorGenNV = (dgtk.OpenGL.delegatesGLes.glPathColorGenNV) InternalTool.GetGLesMethodAdress("glPathColorGenNV", typeof(dgtk.OpenGL.delegatesGLes.glPathColorGenNV));
			}
			if (SuportedExt.Contains("glPathCommandsNV"))
			{
				dgtk.OpenGL.internalGLes.glPathCommandsNV = (dgtk.OpenGL.delegatesGLes.glPathCommandsNV) InternalTool.GetGLesMethodAdress("glPathCommandsNV", typeof(dgtk.OpenGL.delegatesGLes.glPathCommandsNV));
			}
			if (SuportedExt.Contains("glPathCoordsNV"))
			{
				dgtk.OpenGL.internalGLes.glPathCoordsNV = (dgtk.OpenGL.delegatesGLes.glPathCoordsNV) InternalTool.GetGLesMethodAdress("glPathCoordsNV", typeof(dgtk.OpenGL.delegatesGLes.glPathCoordsNV));
			}
			if (SuportedExt.Contains("glPathCoverDepthFuncNV"))
			{
				dgtk.OpenGL.internalGLes.glPathCoverDepthFuncNV = (dgtk.OpenGL.delegatesGLes.glPathCoverDepthFuncNV) InternalTool.GetGLesMethodAdress("glPathCoverDepthFuncNV", typeof(dgtk.OpenGL.delegatesGLes.glPathCoverDepthFuncNV));
			}
			if (SuportedExt.Contains("glPathDashArrayNV"))
			{
				dgtk.OpenGL.internalGLes.glPathDashArrayNV = (dgtk.OpenGL.delegatesGLes.glPathDashArrayNV) InternalTool.GetGLesMethodAdress("glPathDashArrayNV", typeof(dgtk.OpenGL.delegatesGLes.glPathDashArrayNV));
			}
			if (SuportedExt.Contains("glPathFogGenNV"))
			{
				dgtk.OpenGL.internalGLes.glPathFogGenNV = (dgtk.OpenGL.delegatesGLes.glPathFogGenNV) InternalTool.GetGLesMethodAdress("glPathFogGenNV", typeof(dgtk.OpenGL.delegatesGLes.glPathFogGenNV));
			}
			if (SuportedExt.Contains("glPathGlyphIndexArrayNV"))
			{
				dgtk.OpenGL.internalGLes.glPathGlyphIndexArrayNV = (dgtk.OpenGL.delegatesGLes.glPathGlyphIndexArrayNV) InternalTool.GetGLesMethodAdress("glPathGlyphIndexArrayNV", typeof(dgtk.OpenGL.delegatesGLes.glPathGlyphIndexArrayNV));
			}
			if (SuportedExt.Contains("glPathGlyphIndexRangeNV"))
			{
				dgtk.OpenGL.internalGLes.glPathGlyphIndexRangeNV = (dgtk.OpenGL.delegatesGLes.glPathGlyphIndexRangeNV) InternalTool.GetGLesMethodAdress("glPathGlyphIndexRangeNV", typeof(dgtk.OpenGL.delegatesGLes.glPathGlyphIndexRangeNV));
			}
			if (SuportedExt.Contains("glPathGlyphRangeNV"))
			{
				dgtk.OpenGL.internalGLes.glPathGlyphRangeNV = (dgtk.OpenGL.delegatesGLes.glPathGlyphRangeNV) InternalTool.GetGLesMethodAdress("glPathGlyphRangeNV", typeof(dgtk.OpenGL.delegatesGLes.glPathGlyphRangeNV));
			}
			if (SuportedExt.Contains("glPathGlyphsNV"))
			{
				dgtk.OpenGL.internalGLes.glPathGlyphsNV = (dgtk.OpenGL.delegatesGLes.glPathGlyphsNV) InternalTool.GetGLesMethodAdress("glPathGlyphsNV", typeof(dgtk.OpenGL.delegatesGLes.glPathGlyphsNV));
			}
			if (SuportedExt.Contains("glPathMemoryGlyphIndexArrayNV"))
			{
				dgtk.OpenGL.internalGLes.glPathMemoryGlyphIndexArrayNV = (dgtk.OpenGL.delegatesGLes.glPathMemoryGlyphIndexArrayNV) InternalTool.GetGLesMethodAdress("glPathMemoryGlyphIndexArrayNV", typeof(dgtk.OpenGL.delegatesGLes.glPathMemoryGlyphIndexArrayNV));
			}
			if (SuportedExt.Contains("glPathParameterfNV"))
			{
				dgtk.OpenGL.internalGLes.glPathParameterfNV = (dgtk.OpenGL.delegatesGLes.glPathParameterfNV) InternalTool.GetGLesMethodAdress("glPathParameterfNV", typeof(dgtk.OpenGL.delegatesGLes.glPathParameterfNV));
			}
			if (SuportedExt.Contains("glPathParameterfvNV"))
			{
				dgtk.OpenGL.internalGLes.glPathParameterfvNV = (dgtk.OpenGL.delegatesGLes.glPathParameterfvNV) InternalTool.GetGLesMethodAdress("glPathParameterfvNV", typeof(dgtk.OpenGL.delegatesGLes.glPathParameterfvNV));
			}
			if (SuportedExt.Contains("glPathParameteriNV"))
			{
				dgtk.OpenGL.internalGLes.glPathParameteriNV = (dgtk.OpenGL.delegatesGLes.glPathParameteriNV) InternalTool.GetGLesMethodAdress("glPathParameteriNV", typeof(dgtk.OpenGL.delegatesGLes.glPathParameteriNV));
			}
			if (SuportedExt.Contains("glPathParameterivNV"))
			{
				dgtk.OpenGL.internalGLes.glPathParameterivNV = (dgtk.OpenGL.delegatesGLes.glPathParameterivNV) InternalTool.GetGLesMethodAdress("glPathParameterivNV", typeof(dgtk.OpenGL.delegatesGLes.glPathParameterivNV));
			}
			if (SuportedExt.Contains("glPathStencilDepthOffsetNV"))
			{
				dgtk.OpenGL.internalGLes.glPathStencilDepthOffsetNV = (dgtk.OpenGL.delegatesGLes.glPathStencilDepthOffsetNV) InternalTool.GetGLesMethodAdress("glPathStencilDepthOffsetNV", typeof(dgtk.OpenGL.delegatesGLes.glPathStencilDepthOffsetNV));
			}
			if (SuportedExt.Contains("glPathStencilFuncNV"))
			{
				dgtk.OpenGL.internalGLes.glPathStencilFuncNV = (dgtk.OpenGL.delegatesGLes.glPathStencilFuncNV) InternalTool.GetGLesMethodAdress("glPathStencilFuncNV", typeof(dgtk.OpenGL.delegatesGLes.glPathStencilFuncNV));
			}
			if (SuportedExt.Contains("glPathStringNV"))
			{
				dgtk.OpenGL.internalGLes.glPathStringNV = (dgtk.OpenGL.delegatesGLes.glPathStringNV) InternalTool.GetGLesMethodAdress("glPathStringNV", typeof(dgtk.OpenGL.delegatesGLes.glPathStringNV));
			}
			if (SuportedExt.Contains("glPathSubCommandsNV"))
			{
				dgtk.OpenGL.internalGLes.glPathSubCommandsNV = (dgtk.OpenGL.delegatesGLes.glPathSubCommandsNV) InternalTool.GetGLesMethodAdress("glPathSubCommandsNV", typeof(dgtk.OpenGL.delegatesGLes.glPathSubCommandsNV));
			}
			if (SuportedExt.Contains("glPathSubCoordsNV"))
			{
				dgtk.OpenGL.internalGLes.glPathSubCoordsNV = (dgtk.OpenGL.delegatesGLes.glPathSubCoordsNV) InternalTool.GetGLesMethodAdress("glPathSubCoordsNV", typeof(dgtk.OpenGL.delegatesGLes.glPathSubCoordsNV));
			}
			if (SuportedExt.Contains("glPathTexGenNV"))
			{
				dgtk.OpenGL.internalGLes.glPathTexGenNV = (dgtk.OpenGL.delegatesGLes.glPathTexGenNV) InternalTool.GetGLesMethodAdress("glPathTexGenNV", typeof(dgtk.OpenGL.delegatesGLes.glPathTexGenNV));
			}
			if (SuportedExt.Contains("glPauseTransformFeedbackNV"))
			{
				dgtk.OpenGL.internalGLes.glPauseTransformFeedbackNV = (dgtk.OpenGL.delegatesGLes.glPauseTransformFeedbackNV) InternalTool.GetGLesMethodAdress("glPauseTransformFeedbackNV", typeof(dgtk.OpenGL.delegatesGLes.glPauseTransformFeedbackNV));
			}
			if (SuportedExt.Contains("glPixelDataRangeNV"))
			{
				dgtk.OpenGL.internalGLes.glPixelDataRangeNV = (dgtk.OpenGL.delegatesGLes.glPixelDataRangeNV) InternalTool.GetGLesMethodAdress("glPixelDataRangeNV", typeof(dgtk.OpenGL.delegatesGLes.glPixelDataRangeNV));
			}
			if (SuportedExt.Contains("glPixelMapx"))
			{
				dgtk.OpenGL.internalGLes.glPixelMapx = (dgtk.OpenGL.delegatesGLes.glPixelMapx) InternalTool.GetGLesMethodAdress("glPixelMapx", typeof(dgtk.OpenGL.delegatesGLes.glPixelMapx));
			}
			if (SuportedExt.Contains("glPixelStorex"))
			{
				dgtk.OpenGL.internalGLes.glPixelStorex = (dgtk.OpenGL.delegatesGLes.glPixelStorex) InternalTool.GetGLesMethodAdress("glPixelStorex", typeof(dgtk.OpenGL.delegatesGLes.glPixelStorex));
			}
			if (SuportedExt.Contains("glPixelTexGenParameterfSGIS"))
			{
				dgtk.OpenGL.internalGLes.glPixelTexGenParameterfSGIS = (dgtk.OpenGL.delegatesGLes.glPixelTexGenParameterfSGIS) InternalTool.GetGLesMethodAdress("glPixelTexGenParameterfSGIS", typeof(dgtk.OpenGL.delegatesGLes.glPixelTexGenParameterfSGIS));
			}
			if (SuportedExt.Contains("glPixelTexGenParameterfvSGIS"))
			{
				dgtk.OpenGL.internalGLes.glPixelTexGenParameterfvSGIS = (dgtk.OpenGL.delegatesGLes.glPixelTexGenParameterfvSGIS) InternalTool.GetGLesMethodAdress("glPixelTexGenParameterfvSGIS", typeof(dgtk.OpenGL.delegatesGLes.glPixelTexGenParameterfvSGIS));
			}
			if (SuportedExt.Contains("glPixelTexGenParameteriSGIS"))
			{
				dgtk.OpenGL.internalGLes.glPixelTexGenParameteriSGIS = (dgtk.OpenGL.delegatesGLes.glPixelTexGenParameteriSGIS) InternalTool.GetGLesMethodAdress("glPixelTexGenParameteriSGIS", typeof(dgtk.OpenGL.delegatesGLes.glPixelTexGenParameteriSGIS));
			}
			if (SuportedExt.Contains("glPixelTexGenParameterivSGIS"))
			{
				dgtk.OpenGL.internalGLes.glPixelTexGenParameterivSGIS = (dgtk.OpenGL.delegatesGLes.glPixelTexGenParameterivSGIS) InternalTool.GetGLesMethodAdress("glPixelTexGenParameterivSGIS", typeof(dgtk.OpenGL.delegatesGLes.glPixelTexGenParameterivSGIS));
			}
			if (SuportedExt.Contains("glPixelTexGenSGIX"))
			{
				dgtk.OpenGL.internalGLes.glPixelTexGenSGIX = (dgtk.OpenGL.delegatesGLes.glPixelTexGenSGIX) InternalTool.GetGLesMethodAdress("glPixelTexGenSGIX", typeof(dgtk.OpenGL.delegatesGLes.glPixelTexGenSGIX));
			}
			if (SuportedExt.Contains("glPixelTransferxOES"))
			{
				dgtk.OpenGL.internalGLes.glPixelTransferxOES = (dgtk.OpenGL.delegatesGLes.glPixelTransferxOES) InternalTool.GetGLesMethodAdress("glPixelTransferxOES", typeof(dgtk.OpenGL.delegatesGLes.glPixelTransferxOES));
			}
			if (SuportedExt.Contains("glPixelTransformParameterfEXT"))
			{
				dgtk.OpenGL.internalGLes.glPixelTransformParameterfEXT = (dgtk.OpenGL.delegatesGLes.glPixelTransformParameterfEXT) InternalTool.GetGLesMethodAdress("glPixelTransformParameterfEXT", typeof(dgtk.OpenGL.delegatesGLes.glPixelTransformParameterfEXT));
			}
			if (SuportedExt.Contains("glPixelTransformParameterfvEXT"))
			{
				dgtk.OpenGL.internalGLes.glPixelTransformParameterfvEXT = (dgtk.OpenGL.delegatesGLes.glPixelTransformParameterfvEXT) InternalTool.GetGLesMethodAdress("glPixelTransformParameterfvEXT", typeof(dgtk.OpenGL.delegatesGLes.glPixelTransformParameterfvEXT));
			}
			if (SuportedExt.Contains("glPixelTransformParameteriEXT"))
			{
				dgtk.OpenGL.internalGLes.glPixelTransformParameteriEXT = (dgtk.OpenGL.delegatesGLes.glPixelTransformParameteriEXT) InternalTool.GetGLesMethodAdress("glPixelTransformParameteriEXT", typeof(dgtk.OpenGL.delegatesGLes.glPixelTransformParameteriEXT));
			}
			if (SuportedExt.Contains("glPixelTransformParameterivEXT"))
			{
				dgtk.OpenGL.internalGLes.glPixelTransformParameterivEXT = (dgtk.OpenGL.delegatesGLes.glPixelTransformParameterivEXT) InternalTool.GetGLesMethodAdress("glPixelTransformParameterivEXT", typeof(dgtk.OpenGL.delegatesGLes.glPixelTransformParameterivEXT));
			}
			if (SuportedExt.Contains("glPixelZoomxOES"))
			{
				dgtk.OpenGL.internalGLes.glPixelZoomxOES = (dgtk.OpenGL.delegatesGLes.glPixelZoomxOES) InternalTool.GetGLesMethodAdress("glPixelZoomxOES", typeof(dgtk.OpenGL.delegatesGLes.glPixelZoomxOES));
			}
			if (SuportedExt.Contains("glPNTrianglesfATI"))
			{
				dgtk.OpenGL.internalGLes.glPNTrianglesfATI = (dgtk.OpenGL.delegatesGLes.glPNTrianglesfATI) InternalTool.GetGLesMethodAdress("glPNTrianglesfATI", typeof(dgtk.OpenGL.delegatesGLes.glPNTrianglesfATI));
			}
			if (SuportedExt.Contains("glPNTrianglesiATI"))
			{
				dgtk.OpenGL.internalGLes.glPNTrianglesiATI = (dgtk.OpenGL.delegatesGLes.glPNTrianglesiATI) InternalTool.GetGLesMethodAdress("glPNTrianglesiATI", typeof(dgtk.OpenGL.delegatesGLes.glPNTrianglesiATI));
			}
			if (SuportedExt.Contains("glPointAlongPathNV"))
			{
				dgtk.OpenGL.internalGLes.glPointAlongPathNV = (dgtk.OpenGL.delegatesGLes.glPointAlongPathNV) InternalTool.GetGLesMethodAdress("glPointAlongPathNV", typeof(dgtk.OpenGL.delegatesGLes.glPointAlongPathNV));
			}
			if (SuportedExt.Contains("glPointParameterfARB"))
			{
				dgtk.OpenGL.internalGLes.glPointParameterfARB = (dgtk.OpenGL.delegatesGLes.glPointParameterfARB) InternalTool.GetGLesMethodAdress("glPointParameterfARB", typeof(dgtk.OpenGL.delegatesGLes.glPointParameterfARB));
			}
			if (SuportedExt.Contains("glPointParameterfEXT"))
			{
				dgtk.OpenGL.internalGLes.glPointParameterfEXT = (dgtk.OpenGL.delegatesGLes.glPointParameterfEXT) InternalTool.GetGLesMethodAdress("glPointParameterfEXT", typeof(dgtk.OpenGL.delegatesGLes.glPointParameterfEXT));
			}
			if (SuportedExt.Contains("glPointParameterfSGIS"))
			{
				dgtk.OpenGL.internalGLes.glPointParameterfSGIS = (dgtk.OpenGL.delegatesGLes.glPointParameterfSGIS) InternalTool.GetGLesMethodAdress("glPointParameterfSGIS", typeof(dgtk.OpenGL.delegatesGLes.glPointParameterfSGIS));
			}
			if (SuportedExt.Contains("glPointParameterfvARB"))
			{
				dgtk.OpenGL.internalGLes.glPointParameterfvARB = (dgtk.OpenGL.delegatesGLes.glPointParameterfvARB) InternalTool.GetGLesMethodAdress("glPointParameterfvARB", typeof(dgtk.OpenGL.delegatesGLes.glPointParameterfvARB));
			}
			if (SuportedExt.Contains("glPointParameterfvEXT"))
			{
				dgtk.OpenGL.internalGLes.glPointParameterfvEXT = (dgtk.OpenGL.delegatesGLes.glPointParameterfvEXT) InternalTool.GetGLesMethodAdress("glPointParameterfvEXT", typeof(dgtk.OpenGL.delegatesGLes.glPointParameterfvEXT));
			}
			if (SuportedExt.Contains("glPointParameterfvSGIS"))
			{
				dgtk.OpenGL.internalGLes.glPointParameterfvSGIS = (dgtk.OpenGL.delegatesGLes.glPointParameterfvSGIS) InternalTool.GetGLesMethodAdress("glPointParameterfvSGIS", typeof(dgtk.OpenGL.delegatesGLes.glPointParameterfvSGIS));
			}
			if (SuportedExt.Contains("glPointParameteriNV"))
			{
				dgtk.OpenGL.internalGLes.glPointParameteriNV = (dgtk.OpenGL.delegatesGLes.glPointParameteriNV) InternalTool.GetGLesMethodAdress("glPointParameteriNV", typeof(dgtk.OpenGL.delegatesGLes.glPointParameteriNV));
			}
			if (SuportedExt.Contains("glPointParameterivNV"))
			{
				dgtk.OpenGL.internalGLes.glPointParameterivNV = (dgtk.OpenGL.delegatesGLes.glPointParameterivNV) InternalTool.GetGLesMethodAdress("glPointParameterivNV", typeof(dgtk.OpenGL.delegatesGLes.glPointParameterivNV));
			}
			if (SuportedExt.Contains("glPointParameterx"))
			{
				dgtk.OpenGL.internalGLes.glPointParameterx = (dgtk.OpenGL.delegatesGLes.glPointParameterx) InternalTool.GetGLesMethodAdress("glPointParameterx", typeof(dgtk.OpenGL.delegatesGLes.glPointParameterx));
			}
			if (SuportedExt.Contains("glPointParameterxOES"))
			{
				dgtk.OpenGL.internalGLes.glPointParameterxOES = (dgtk.OpenGL.delegatesGLes.glPointParameterxOES) InternalTool.GetGLesMethodAdress("glPointParameterxOES", typeof(dgtk.OpenGL.delegatesGLes.glPointParameterxOES));
			}
			if (SuportedExt.Contains("glPointParameterxv"))
			{
				dgtk.OpenGL.internalGLes.glPointParameterxv = (dgtk.OpenGL.delegatesGLes.glPointParameterxv) InternalTool.GetGLesMethodAdress("glPointParameterxv", typeof(dgtk.OpenGL.delegatesGLes.glPointParameterxv));
			}
			if (SuportedExt.Contains("glPointParameterxvOES"))
			{
				dgtk.OpenGL.internalGLes.glPointParameterxvOES = (dgtk.OpenGL.delegatesGLes.glPointParameterxvOES) InternalTool.GetGLesMethodAdress("glPointParameterxvOES", typeof(dgtk.OpenGL.delegatesGLes.glPointParameterxvOES));
			}
			if (SuportedExt.Contains("glPointSizePointerOES"))
			{
				dgtk.OpenGL.internalGLes.glPointSizePointerOES = (dgtk.OpenGL.delegatesGLes.glPointSizePointerOES) InternalTool.GetGLesMethodAdress("glPointSizePointerOES", typeof(dgtk.OpenGL.delegatesGLes.glPointSizePointerOES));
			}
			if (SuportedExt.Contains("glPointSizex"))
			{
				dgtk.OpenGL.internalGLes.glPointSizex = (dgtk.OpenGL.delegatesGLes.glPointSizex) InternalTool.GetGLesMethodAdress("glPointSizex", typeof(dgtk.OpenGL.delegatesGLes.glPointSizex));
			}
			if (SuportedExt.Contains("glPointSizexOES"))
			{
				dgtk.OpenGL.internalGLes.glPointSizexOES = (dgtk.OpenGL.delegatesGLes.glPointSizexOES) InternalTool.GetGLesMethodAdress("glPointSizexOES", typeof(dgtk.OpenGL.delegatesGLes.glPointSizexOES));
			}
			if (SuportedExt.Contains("glPollAsyncSGIX"))
			{
				dgtk.OpenGL.internalGLes.glPollAsyncSGIX = (dgtk.OpenGL.delegatesGLes.glPollAsyncSGIX) InternalTool.GetGLesMethodAdress("glPollAsyncSGIX", typeof(dgtk.OpenGL.delegatesGLes.glPollAsyncSGIX));
			}
			if (SuportedExt.Contains("glPollInstrumentsSGIX"))
			{
				dgtk.OpenGL.internalGLes.glPollInstrumentsSGIX = (dgtk.OpenGL.delegatesGLes.glPollInstrumentsSGIX) InternalTool.GetGLesMethodAdress("glPollInstrumentsSGIX", typeof(dgtk.OpenGL.delegatesGLes.glPollInstrumentsSGIX));
			}
			if (SuportedExt.Contains("glPolygonModeNV"))
			{
				dgtk.OpenGL.internalGLes.glPolygonModeNV = (dgtk.OpenGL.delegatesGLes.glPolygonModeNV) InternalTool.GetGLesMethodAdress("glPolygonModeNV", typeof(dgtk.OpenGL.delegatesGLes.glPolygonModeNV));
			}
			if (SuportedExt.Contains("glPolygonOffsetClampEXT"))
			{
				dgtk.OpenGL.internalGLes.glPolygonOffsetClampEXT = (dgtk.OpenGL.delegatesGLes.glPolygonOffsetClampEXT) InternalTool.GetGLesMethodAdress("glPolygonOffsetClampEXT", typeof(dgtk.OpenGL.delegatesGLes.glPolygonOffsetClampEXT));
			}
			if (SuportedExt.Contains("glPolygonOffsetEXT"))
			{
				dgtk.OpenGL.internalGLes.glPolygonOffsetEXT = (dgtk.OpenGL.delegatesGLes.glPolygonOffsetEXT) InternalTool.GetGLesMethodAdress("glPolygonOffsetEXT", typeof(dgtk.OpenGL.delegatesGLes.glPolygonOffsetEXT));
			}
			if (SuportedExt.Contains("glPolygonOffsetx"))
			{
				dgtk.OpenGL.internalGLes.glPolygonOffsetx = (dgtk.OpenGL.delegatesGLes.glPolygonOffsetx) InternalTool.GetGLesMethodAdress("glPolygonOffsetx", typeof(dgtk.OpenGL.delegatesGLes.glPolygonOffsetx));
			}
			if (SuportedExt.Contains("glPolygonOffsetxOES"))
			{
				dgtk.OpenGL.internalGLes.glPolygonOffsetxOES = (dgtk.OpenGL.delegatesGLes.glPolygonOffsetxOES) InternalTool.GetGLesMethodAdress("glPolygonOffsetxOES", typeof(dgtk.OpenGL.delegatesGLes.glPolygonOffsetxOES));
			}
			if (SuportedExt.Contains("glPopDebugGroupKHR"))
			{
				dgtk.OpenGL.internalGLes.glPopDebugGroupKHR = (dgtk.OpenGL.delegatesGLes.glPopDebugGroupKHR) InternalTool.GetGLesMethodAdress("glPopDebugGroupKHR", typeof(dgtk.OpenGL.delegatesGLes.glPopDebugGroupKHR));
			}
			if (SuportedExt.Contains("glPopGroupMarkerEXT"))
			{
				dgtk.OpenGL.internalGLes.glPopGroupMarkerEXT = (dgtk.OpenGL.delegatesGLes.glPopGroupMarkerEXT) InternalTool.GetGLesMethodAdress("glPopGroupMarkerEXT", typeof(dgtk.OpenGL.delegatesGLes.glPopGroupMarkerEXT));
			}
			if (SuportedExt.Contains("glPresentFrameDualFillNV"))
			{
				dgtk.OpenGL.internalGLes.glPresentFrameDualFillNV = (dgtk.OpenGL.delegatesGLes.glPresentFrameDualFillNV) InternalTool.GetGLesMethodAdress("glPresentFrameDualFillNV", typeof(dgtk.OpenGL.delegatesGLes.glPresentFrameDualFillNV));
			}
			if (SuportedExt.Contains("glPresentFrameKeyedNV"))
			{
				dgtk.OpenGL.internalGLes.glPresentFrameKeyedNV = (dgtk.OpenGL.delegatesGLes.glPresentFrameKeyedNV) InternalTool.GetGLesMethodAdress("glPresentFrameKeyedNV", typeof(dgtk.OpenGL.delegatesGLes.glPresentFrameKeyedNV));
			}
			if (SuportedExt.Contains("glPrimitiveBoundingBox"))
			{
				dgtk.OpenGL.internalGLes.glPrimitiveBoundingBox = (dgtk.OpenGL.delegatesGLes.glPrimitiveBoundingBox) InternalTool.GetGLesMethodAdress("glPrimitiveBoundingBox", typeof(dgtk.OpenGL.delegatesGLes.glPrimitiveBoundingBox));
			}
			if (SuportedExt.Contains("glPrimitiveBoundingBoxARB"))
			{
				dgtk.OpenGL.internalGLes.glPrimitiveBoundingBoxARB = (dgtk.OpenGL.delegatesGLes.glPrimitiveBoundingBoxARB) InternalTool.GetGLesMethodAdress("glPrimitiveBoundingBoxARB", typeof(dgtk.OpenGL.delegatesGLes.glPrimitiveBoundingBoxARB));
			}
			if (SuportedExt.Contains("glPrimitiveBoundingBoxEXT"))
			{
				dgtk.OpenGL.internalGLes.glPrimitiveBoundingBoxEXT = (dgtk.OpenGL.delegatesGLes.glPrimitiveBoundingBoxEXT) InternalTool.GetGLesMethodAdress("glPrimitiveBoundingBoxEXT", typeof(dgtk.OpenGL.delegatesGLes.glPrimitiveBoundingBoxEXT));
			}
			if (SuportedExt.Contains("glPrimitiveBoundingBoxOES"))
			{
				dgtk.OpenGL.internalGLes.glPrimitiveBoundingBoxOES = (dgtk.OpenGL.delegatesGLes.glPrimitiveBoundingBoxOES) InternalTool.GetGLesMethodAdress("glPrimitiveBoundingBoxOES", typeof(dgtk.OpenGL.delegatesGLes.glPrimitiveBoundingBoxOES));
			}
			if (SuportedExt.Contains("glPrimitiveRestartIndexNV"))
			{
				dgtk.OpenGL.internalGLes.glPrimitiveRestartIndexNV = (dgtk.OpenGL.delegatesGLes.glPrimitiveRestartIndexNV) InternalTool.GetGLesMethodAdress("glPrimitiveRestartIndexNV", typeof(dgtk.OpenGL.delegatesGLes.glPrimitiveRestartIndexNV));
			}
			if (SuportedExt.Contains("glPrimitiveRestartNV"))
			{
				dgtk.OpenGL.internalGLes.glPrimitiveRestartNV = (dgtk.OpenGL.delegatesGLes.glPrimitiveRestartNV) InternalTool.GetGLesMethodAdress("glPrimitiveRestartNV", typeof(dgtk.OpenGL.delegatesGLes.glPrimitiveRestartNV));
			}
			if (SuportedExt.Contains("glPrioritizeTexturesEXT"))
			{
				dgtk.OpenGL.internalGLes.glPrioritizeTexturesEXT = (dgtk.OpenGL.delegatesGLes.glPrioritizeTexturesEXT) InternalTool.GetGLesMethodAdress("glPrioritizeTexturesEXT", typeof(dgtk.OpenGL.delegatesGLes.glPrioritizeTexturesEXT));
			}
			if (SuportedExt.Contains("glPrioritizeTexturesxOES"))
			{
				dgtk.OpenGL.internalGLes.glPrioritizeTexturesxOES = (dgtk.OpenGL.delegatesGLes.glPrioritizeTexturesxOES) InternalTool.GetGLesMethodAdress("glPrioritizeTexturesxOES", typeof(dgtk.OpenGL.delegatesGLes.glPrioritizeTexturesxOES));
			}
			if (SuportedExt.Contains("glProgramBinaryOES"))
			{
				dgtk.OpenGL.internalGLes.glProgramBinaryOES = (dgtk.OpenGL.delegatesGLes.glProgramBinaryOES) InternalTool.GetGLesMethodAdress("glProgramBinaryOES", typeof(dgtk.OpenGL.delegatesGLes.glProgramBinaryOES));
			}
			if (SuportedExt.Contains("glProgramBufferParametersfvNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramBufferParametersfvNV = (dgtk.OpenGL.delegatesGLes.glProgramBufferParametersfvNV) InternalTool.GetGLesMethodAdress("glProgramBufferParametersfvNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramBufferParametersfvNV));
			}
			if (SuportedExt.Contains("glProgramBufferParametersIivNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramBufferParametersIivNV = (dgtk.OpenGL.delegatesGLes.glProgramBufferParametersIivNV) InternalTool.GetGLesMethodAdress("glProgramBufferParametersIivNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramBufferParametersIivNV));
			}
			if (SuportedExt.Contains("glProgramBufferParametersIuivNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramBufferParametersIuivNV = (dgtk.OpenGL.delegatesGLes.glProgramBufferParametersIuivNV) InternalTool.GetGLesMethodAdress("glProgramBufferParametersIuivNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramBufferParametersIuivNV));
			}
			if (SuportedExt.Contains("glProgramEnvParameter4dARB"))
			{
				dgtk.OpenGL.internalGLes.glProgramEnvParameter4dARB = (dgtk.OpenGL.delegatesGLes.glProgramEnvParameter4dARB) InternalTool.GetGLesMethodAdress("glProgramEnvParameter4dARB", typeof(dgtk.OpenGL.delegatesGLes.glProgramEnvParameter4dARB));
			}
			if (SuportedExt.Contains("glProgramEnvParameter4dvARB"))
			{
				dgtk.OpenGL.internalGLes.glProgramEnvParameter4dvARB = (dgtk.OpenGL.delegatesGLes.glProgramEnvParameter4dvARB) InternalTool.GetGLesMethodAdress("glProgramEnvParameter4dvARB", typeof(dgtk.OpenGL.delegatesGLes.glProgramEnvParameter4dvARB));
			}
			if (SuportedExt.Contains("glProgramEnvParameter4fARB"))
			{
				dgtk.OpenGL.internalGLes.glProgramEnvParameter4fARB = (dgtk.OpenGL.delegatesGLes.glProgramEnvParameter4fARB) InternalTool.GetGLesMethodAdress("glProgramEnvParameter4fARB", typeof(dgtk.OpenGL.delegatesGLes.glProgramEnvParameter4fARB));
			}
			if (SuportedExt.Contains("glProgramEnvParameter4fvARB"))
			{
				dgtk.OpenGL.internalGLes.glProgramEnvParameter4fvARB = (dgtk.OpenGL.delegatesGLes.glProgramEnvParameter4fvARB) InternalTool.GetGLesMethodAdress("glProgramEnvParameter4fvARB", typeof(dgtk.OpenGL.delegatesGLes.glProgramEnvParameter4fvARB));
			}
			if (SuportedExt.Contains("glProgramEnvParameterI4iNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramEnvParameterI4iNV = (dgtk.OpenGL.delegatesGLes.glProgramEnvParameterI4iNV) InternalTool.GetGLesMethodAdress("glProgramEnvParameterI4iNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramEnvParameterI4iNV));
			}
			if (SuportedExt.Contains("glProgramEnvParameterI4ivNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramEnvParameterI4ivNV = (dgtk.OpenGL.delegatesGLes.glProgramEnvParameterI4ivNV) InternalTool.GetGLesMethodAdress("glProgramEnvParameterI4ivNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramEnvParameterI4ivNV));
			}
			if (SuportedExt.Contains("glProgramEnvParameterI4uiNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramEnvParameterI4uiNV = (dgtk.OpenGL.delegatesGLes.glProgramEnvParameterI4uiNV) InternalTool.GetGLesMethodAdress("glProgramEnvParameterI4uiNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramEnvParameterI4uiNV));
			}
			if (SuportedExt.Contains("glProgramEnvParameterI4uivNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramEnvParameterI4uivNV = (dgtk.OpenGL.delegatesGLes.glProgramEnvParameterI4uivNV) InternalTool.GetGLesMethodAdress("glProgramEnvParameterI4uivNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramEnvParameterI4uivNV));
			}
			if (SuportedExt.Contains("glProgramEnvParameters4fvEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramEnvParameters4fvEXT = (dgtk.OpenGL.delegatesGLes.glProgramEnvParameters4fvEXT) InternalTool.GetGLesMethodAdress("glProgramEnvParameters4fvEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramEnvParameters4fvEXT));
			}
			if (SuportedExt.Contains("glProgramEnvParametersI4ivNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramEnvParametersI4ivNV = (dgtk.OpenGL.delegatesGLes.glProgramEnvParametersI4ivNV) InternalTool.GetGLesMethodAdress("glProgramEnvParametersI4ivNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramEnvParametersI4ivNV));
			}
			if (SuportedExt.Contains("glProgramEnvParametersI4uivNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramEnvParametersI4uivNV = (dgtk.OpenGL.delegatesGLes.glProgramEnvParametersI4uivNV) InternalTool.GetGLesMethodAdress("glProgramEnvParametersI4uivNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramEnvParametersI4uivNV));
			}
			if (SuportedExt.Contains("glProgramLocalParameter4dARB"))
			{
				dgtk.OpenGL.internalGLes.glProgramLocalParameter4dARB = (dgtk.OpenGL.delegatesGLes.glProgramLocalParameter4dARB) InternalTool.GetGLesMethodAdress("glProgramLocalParameter4dARB", typeof(dgtk.OpenGL.delegatesGLes.glProgramLocalParameter4dARB));
			}
			if (SuportedExt.Contains("glProgramLocalParameter4dvARB"))
			{
				dgtk.OpenGL.internalGLes.glProgramLocalParameter4dvARB = (dgtk.OpenGL.delegatesGLes.glProgramLocalParameter4dvARB) InternalTool.GetGLesMethodAdress("glProgramLocalParameter4dvARB", typeof(dgtk.OpenGL.delegatesGLes.glProgramLocalParameter4dvARB));
			}
			if (SuportedExt.Contains("glProgramLocalParameter4fARB"))
			{
				dgtk.OpenGL.internalGLes.glProgramLocalParameter4fARB = (dgtk.OpenGL.delegatesGLes.glProgramLocalParameter4fARB) InternalTool.GetGLesMethodAdress("glProgramLocalParameter4fARB", typeof(dgtk.OpenGL.delegatesGLes.glProgramLocalParameter4fARB));
			}
			if (SuportedExt.Contains("glProgramLocalParameter4fvARB"))
			{
				dgtk.OpenGL.internalGLes.glProgramLocalParameter4fvARB = (dgtk.OpenGL.delegatesGLes.glProgramLocalParameter4fvARB) InternalTool.GetGLesMethodAdress("glProgramLocalParameter4fvARB", typeof(dgtk.OpenGL.delegatesGLes.glProgramLocalParameter4fvARB));
			}
			if (SuportedExt.Contains("glProgramLocalParameterI4iNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramLocalParameterI4iNV = (dgtk.OpenGL.delegatesGLes.glProgramLocalParameterI4iNV) InternalTool.GetGLesMethodAdress("glProgramLocalParameterI4iNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramLocalParameterI4iNV));
			}
			if (SuportedExt.Contains("glProgramLocalParameterI4ivNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramLocalParameterI4ivNV = (dgtk.OpenGL.delegatesGLes.glProgramLocalParameterI4ivNV) InternalTool.GetGLesMethodAdress("glProgramLocalParameterI4ivNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramLocalParameterI4ivNV));
			}
			if (SuportedExt.Contains("glProgramLocalParameterI4uiNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramLocalParameterI4uiNV = (dgtk.OpenGL.delegatesGLes.glProgramLocalParameterI4uiNV) InternalTool.GetGLesMethodAdress("glProgramLocalParameterI4uiNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramLocalParameterI4uiNV));
			}
			if (SuportedExt.Contains("glProgramLocalParameterI4uivNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramLocalParameterI4uivNV = (dgtk.OpenGL.delegatesGLes.glProgramLocalParameterI4uivNV) InternalTool.GetGLesMethodAdress("glProgramLocalParameterI4uivNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramLocalParameterI4uivNV));
			}
			if (SuportedExt.Contains("glProgramLocalParameters4fvEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramLocalParameters4fvEXT = (dgtk.OpenGL.delegatesGLes.glProgramLocalParameters4fvEXT) InternalTool.GetGLesMethodAdress("glProgramLocalParameters4fvEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramLocalParameters4fvEXT));
			}
			if (SuportedExt.Contains("glProgramLocalParametersI4ivNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramLocalParametersI4ivNV = (dgtk.OpenGL.delegatesGLes.glProgramLocalParametersI4ivNV) InternalTool.GetGLesMethodAdress("glProgramLocalParametersI4ivNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramLocalParametersI4ivNV));
			}
			if (SuportedExt.Contains("glProgramLocalParametersI4uivNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramLocalParametersI4uivNV = (dgtk.OpenGL.delegatesGLes.glProgramLocalParametersI4uivNV) InternalTool.GetGLesMethodAdress("glProgramLocalParametersI4uivNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramLocalParametersI4uivNV));
			}
			if (SuportedExt.Contains("glProgramNamedParameter4dNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramNamedParameter4dNV = (dgtk.OpenGL.delegatesGLes.glProgramNamedParameter4dNV) InternalTool.GetGLesMethodAdress("glProgramNamedParameter4dNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramNamedParameter4dNV));
			}
			if (SuportedExt.Contains("glProgramNamedParameter4dvNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramNamedParameter4dvNV = (dgtk.OpenGL.delegatesGLes.glProgramNamedParameter4dvNV) InternalTool.GetGLesMethodAdress("glProgramNamedParameter4dvNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramNamedParameter4dvNV));
			}
			if (SuportedExt.Contains("glProgramNamedParameter4fNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramNamedParameter4fNV = (dgtk.OpenGL.delegatesGLes.glProgramNamedParameter4fNV) InternalTool.GetGLesMethodAdress("glProgramNamedParameter4fNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramNamedParameter4fNV));
			}
			if (SuportedExt.Contains("glProgramNamedParameter4fvNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramNamedParameter4fvNV = (dgtk.OpenGL.delegatesGLes.glProgramNamedParameter4fvNV) InternalTool.GetGLesMethodAdress("glProgramNamedParameter4fvNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramNamedParameter4fvNV));
			}
			if (SuportedExt.Contains("glProgramParameter4dNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramParameter4dNV = (dgtk.OpenGL.delegatesGLes.glProgramParameter4dNV) InternalTool.GetGLesMethodAdress("glProgramParameter4dNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramParameter4dNV));
			}
			if (SuportedExt.Contains("glProgramParameter4dvNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramParameter4dvNV = (dgtk.OpenGL.delegatesGLes.glProgramParameter4dvNV) InternalTool.GetGLesMethodAdress("glProgramParameter4dvNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramParameter4dvNV));
			}
			if (SuportedExt.Contains("glProgramParameter4fNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramParameter4fNV = (dgtk.OpenGL.delegatesGLes.glProgramParameter4fNV) InternalTool.GetGLesMethodAdress("glProgramParameter4fNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramParameter4fNV));
			}
			if (SuportedExt.Contains("glProgramParameter4fvNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramParameter4fvNV = (dgtk.OpenGL.delegatesGLes.glProgramParameter4fvNV) InternalTool.GetGLesMethodAdress("glProgramParameter4fvNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramParameter4fvNV));
			}
			if (SuportedExt.Contains("glProgramParameteriARB"))
			{
				dgtk.OpenGL.internalGLes.glProgramParameteriARB = (dgtk.OpenGL.delegatesGLes.glProgramParameteriARB) InternalTool.GetGLesMethodAdress("glProgramParameteriARB", typeof(dgtk.OpenGL.delegatesGLes.glProgramParameteriARB));
			}
			if (SuportedExt.Contains("glProgramParameteriEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramParameteriEXT = (dgtk.OpenGL.delegatesGLes.glProgramParameteriEXT) InternalTool.GetGLesMethodAdress("glProgramParameteriEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramParameteriEXT));
			}
			if (SuportedExt.Contains("glProgramParameters4dvNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramParameters4dvNV = (dgtk.OpenGL.delegatesGLes.glProgramParameters4dvNV) InternalTool.GetGLesMethodAdress("glProgramParameters4dvNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramParameters4dvNV));
			}
			if (SuportedExt.Contains("glProgramParameters4fvNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramParameters4fvNV = (dgtk.OpenGL.delegatesGLes.glProgramParameters4fvNV) InternalTool.GetGLesMethodAdress("glProgramParameters4fvNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramParameters4fvNV));
			}
			if (SuportedExt.Contains("glProgramPathFragmentInputGenNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramPathFragmentInputGenNV = (dgtk.OpenGL.delegatesGLes.glProgramPathFragmentInputGenNV) InternalTool.GetGLesMethodAdress("glProgramPathFragmentInputGenNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramPathFragmentInputGenNV));
			}
			if (SuportedExt.Contains("glProgramStringARB"))
			{
				dgtk.OpenGL.internalGLes.glProgramStringARB = (dgtk.OpenGL.delegatesGLes.glProgramStringARB) InternalTool.GetGLesMethodAdress("glProgramStringARB", typeof(dgtk.OpenGL.delegatesGLes.glProgramStringARB));
			}
			if (SuportedExt.Contains("glProgramSubroutineParametersuivNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramSubroutineParametersuivNV = (dgtk.OpenGL.delegatesGLes.glProgramSubroutineParametersuivNV) InternalTool.GetGLesMethodAdress("glProgramSubroutineParametersuivNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramSubroutineParametersuivNV));
			}
			if (SuportedExt.Contains("glProgramUniform1dEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform1dEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniform1dEXT) InternalTool.GetGLesMethodAdress("glProgramUniform1dEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform1dEXT));
			}
			if (SuportedExt.Contains("glProgramUniform1dvEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform1dvEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniform1dvEXT) InternalTool.GetGLesMethodAdress("glProgramUniform1dvEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform1dvEXT));
			}
			if (SuportedExt.Contains("glProgramUniform1fEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform1fEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniform1fEXT) InternalTool.GetGLesMethodAdress("glProgramUniform1fEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform1fEXT));
			}
			if (SuportedExt.Contains("glProgramUniform1fvEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform1fvEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniform1fvEXT) InternalTool.GetGLesMethodAdress("glProgramUniform1fvEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform1fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniform1i64ARB"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform1i64ARB = (dgtk.OpenGL.delegatesGLes.glProgramUniform1i64ARB) InternalTool.GetGLesMethodAdress("glProgramUniform1i64ARB", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform1i64ARB));
			}
			if (SuportedExt.Contains("glProgramUniform1i64NV"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform1i64NV = (dgtk.OpenGL.delegatesGLes.glProgramUniform1i64NV) InternalTool.GetGLesMethodAdress("glProgramUniform1i64NV", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform1i64NV));
			}
			if (SuportedExt.Contains("glProgramUniform1i64vARB"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform1i64vARB = (dgtk.OpenGL.delegatesGLes.glProgramUniform1i64vARB) InternalTool.GetGLesMethodAdress("glProgramUniform1i64vARB", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform1i64vARB));
			}
			if (SuportedExt.Contains("glProgramUniform1i64vNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform1i64vNV = (dgtk.OpenGL.delegatesGLes.glProgramUniform1i64vNV) InternalTool.GetGLesMethodAdress("glProgramUniform1i64vNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform1i64vNV));
			}
			if (SuportedExt.Contains("glProgramUniform1iEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform1iEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniform1iEXT) InternalTool.GetGLesMethodAdress("glProgramUniform1iEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform1iEXT));
			}
			if (SuportedExt.Contains("glProgramUniform1ivEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform1ivEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniform1ivEXT) InternalTool.GetGLesMethodAdress("glProgramUniform1ivEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform1ivEXT));
			}
			if (SuportedExt.Contains("glProgramUniform1ui64ARB"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform1ui64ARB = (dgtk.OpenGL.delegatesGLes.glProgramUniform1ui64ARB) InternalTool.GetGLesMethodAdress("glProgramUniform1ui64ARB", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform1ui64ARB));
			}
			if (SuportedExt.Contains("glProgramUniform1ui64NV"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform1ui64NV = (dgtk.OpenGL.delegatesGLes.glProgramUniform1ui64NV) InternalTool.GetGLesMethodAdress("glProgramUniform1ui64NV", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform1ui64NV));
			}
			if (SuportedExt.Contains("glProgramUniform1ui64vARB"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform1ui64vARB = (dgtk.OpenGL.delegatesGLes.glProgramUniform1ui64vARB) InternalTool.GetGLesMethodAdress("glProgramUniform1ui64vARB", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform1ui64vARB));
			}
			if (SuportedExt.Contains("glProgramUniform1ui64vNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform1ui64vNV = (dgtk.OpenGL.delegatesGLes.glProgramUniform1ui64vNV) InternalTool.GetGLesMethodAdress("glProgramUniform1ui64vNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform1ui64vNV));
			}
			if (SuportedExt.Contains("glProgramUniform1uiEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform1uiEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniform1uiEXT) InternalTool.GetGLesMethodAdress("glProgramUniform1uiEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform1uiEXT));
			}
			if (SuportedExt.Contains("glProgramUniform1uivEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform1uivEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniform1uivEXT) InternalTool.GetGLesMethodAdress("glProgramUniform1uivEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform1uivEXT));
			}
			if (SuportedExt.Contains("glProgramUniform2dEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform2dEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniform2dEXT) InternalTool.GetGLesMethodAdress("glProgramUniform2dEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform2dEXT));
			}
			if (SuportedExt.Contains("glProgramUniform2dvEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform2dvEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniform2dvEXT) InternalTool.GetGLesMethodAdress("glProgramUniform2dvEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform2dvEXT));
			}
			if (SuportedExt.Contains("glProgramUniform2fEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform2fEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniform2fEXT) InternalTool.GetGLesMethodAdress("glProgramUniform2fEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform2fEXT));
			}
			if (SuportedExt.Contains("glProgramUniform2fvEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform2fvEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniform2fvEXT) InternalTool.GetGLesMethodAdress("glProgramUniform2fvEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform2fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniform2i64ARB"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform2i64ARB = (dgtk.OpenGL.delegatesGLes.glProgramUniform2i64ARB) InternalTool.GetGLesMethodAdress("glProgramUniform2i64ARB", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform2i64ARB));
			}
			if (SuportedExt.Contains("glProgramUniform2i64NV"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform2i64NV = (dgtk.OpenGL.delegatesGLes.glProgramUniform2i64NV) InternalTool.GetGLesMethodAdress("glProgramUniform2i64NV", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform2i64NV));
			}
			if (SuportedExt.Contains("glProgramUniform2i64vARB"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform2i64vARB = (dgtk.OpenGL.delegatesGLes.glProgramUniform2i64vARB) InternalTool.GetGLesMethodAdress("glProgramUniform2i64vARB", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform2i64vARB));
			}
			if (SuportedExt.Contains("glProgramUniform2i64vNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform2i64vNV = (dgtk.OpenGL.delegatesGLes.glProgramUniform2i64vNV) InternalTool.GetGLesMethodAdress("glProgramUniform2i64vNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform2i64vNV));
			}
			if (SuportedExt.Contains("glProgramUniform2iEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform2iEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniform2iEXT) InternalTool.GetGLesMethodAdress("glProgramUniform2iEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform2iEXT));
			}
			if (SuportedExt.Contains("glProgramUniform2ivEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform2ivEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniform2ivEXT) InternalTool.GetGLesMethodAdress("glProgramUniform2ivEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform2ivEXT));
			}
			if (SuportedExt.Contains("glProgramUniform2ui64ARB"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform2ui64ARB = (dgtk.OpenGL.delegatesGLes.glProgramUniform2ui64ARB) InternalTool.GetGLesMethodAdress("glProgramUniform2ui64ARB", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform2ui64ARB));
			}
			if (SuportedExt.Contains("glProgramUniform2ui64NV"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform2ui64NV = (dgtk.OpenGL.delegatesGLes.glProgramUniform2ui64NV) InternalTool.GetGLesMethodAdress("glProgramUniform2ui64NV", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform2ui64NV));
			}
			if (SuportedExt.Contains("glProgramUniform2ui64vARB"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform2ui64vARB = (dgtk.OpenGL.delegatesGLes.glProgramUniform2ui64vARB) InternalTool.GetGLesMethodAdress("glProgramUniform2ui64vARB", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform2ui64vARB));
			}
			if (SuportedExt.Contains("glProgramUniform2ui64vNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform2ui64vNV = (dgtk.OpenGL.delegatesGLes.glProgramUniform2ui64vNV) InternalTool.GetGLesMethodAdress("glProgramUniform2ui64vNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform2ui64vNV));
			}
			if (SuportedExt.Contains("glProgramUniform2uiEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform2uiEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniform2uiEXT) InternalTool.GetGLesMethodAdress("glProgramUniform2uiEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform2uiEXT));
			}
			if (SuportedExt.Contains("glProgramUniform2uivEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform2uivEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniform2uivEXT) InternalTool.GetGLesMethodAdress("glProgramUniform2uivEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform2uivEXT));
			}
			if (SuportedExt.Contains("glProgramUniform3dEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform3dEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniform3dEXT) InternalTool.GetGLesMethodAdress("glProgramUniform3dEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform3dEXT));
			}
			if (SuportedExt.Contains("glProgramUniform3dvEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform3dvEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniform3dvEXT) InternalTool.GetGLesMethodAdress("glProgramUniform3dvEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform3dvEXT));
			}
			if (SuportedExt.Contains("glProgramUniform3fEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform3fEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniform3fEXT) InternalTool.GetGLesMethodAdress("glProgramUniform3fEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform3fEXT));
			}
			if (SuportedExt.Contains("glProgramUniform3fvEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform3fvEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniform3fvEXT) InternalTool.GetGLesMethodAdress("glProgramUniform3fvEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform3fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniform3i64ARB"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform3i64ARB = (dgtk.OpenGL.delegatesGLes.glProgramUniform3i64ARB) InternalTool.GetGLesMethodAdress("glProgramUniform3i64ARB", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform3i64ARB));
			}
			if (SuportedExt.Contains("glProgramUniform3i64NV"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform3i64NV = (dgtk.OpenGL.delegatesGLes.glProgramUniform3i64NV) InternalTool.GetGLesMethodAdress("glProgramUniform3i64NV", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform3i64NV));
			}
			if (SuportedExt.Contains("glProgramUniform3i64vARB"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform3i64vARB = (dgtk.OpenGL.delegatesGLes.glProgramUniform3i64vARB) InternalTool.GetGLesMethodAdress("glProgramUniform3i64vARB", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform3i64vARB));
			}
			if (SuportedExt.Contains("glProgramUniform3i64vNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform3i64vNV = (dgtk.OpenGL.delegatesGLes.glProgramUniform3i64vNV) InternalTool.GetGLesMethodAdress("glProgramUniform3i64vNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform3i64vNV));
			}
			if (SuportedExt.Contains("glProgramUniform3iEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform3iEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniform3iEXT) InternalTool.GetGLesMethodAdress("glProgramUniform3iEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform3iEXT));
			}
			if (SuportedExt.Contains("glProgramUniform3ivEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform3ivEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniform3ivEXT) InternalTool.GetGLesMethodAdress("glProgramUniform3ivEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform3ivEXT));
			}
			if (SuportedExt.Contains("glProgramUniform3ui64ARB"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform3ui64ARB = (dgtk.OpenGL.delegatesGLes.glProgramUniform3ui64ARB) InternalTool.GetGLesMethodAdress("glProgramUniform3ui64ARB", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform3ui64ARB));
			}
			if (SuportedExt.Contains("glProgramUniform3ui64NV"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform3ui64NV = (dgtk.OpenGL.delegatesGLes.glProgramUniform3ui64NV) InternalTool.GetGLesMethodAdress("glProgramUniform3ui64NV", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform3ui64NV));
			}
			if (SuportedExt.Contains("glProgramUniform3ui64vARB"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform3ui64vARB = (dgtk.OpenGL.delegatesGLes.glProgramUniform3ui64vARB) InternalTool.GetGLesMethodAdress("glProgramUniform3ui64vARB", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform3ui64vARB));
			}
			if (SuportedExt.Contains("glProgramUniform3ui64vNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform3ui64vNV = (dgtk.OpenGL.delegatesGLes.glProgramUniform3ui64vNV) InternalTool.GetGLesMethodAdress("glProgramUniform3ui64vNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform3ui64vNV));
			}
			if (SuportedExt.Contains("glProgramUniform3uiEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform3uiEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniform3uiEXT) InternalTool.GetGLesMethodAdress("glProgramUniform3uiEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform3uiEXT));
			}
			if (SuportedExt.Contains("glProgramUniform3uivEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform3uivEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniform3uivEXT) InternalTool.GetGLesMethodAdress("glProgramUniform3uivEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform3uivEXT));
			}
			if (SuportedExt.Contains("glProgramUniform4dEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform4dEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniform4dEXT) InternalTool.GetGLesMethodAdress("glProgramUniform4dEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform4dEXT));
			}
			if (SuportedExt.Contains("glProgramUniform4dvEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform4dvEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniform4dvEXT) InternalTool.GetGLesMethodAdress("glProgramUniform4dvEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform4dvEXT));
			}
			if (SuportedExt.Contains("glProgramUniform4fEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform4fEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniform4fEXT) InternalTool.GetGLesMethodAdress("glProgramUniform4fEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform4fEXT));
			}
			if (SuportedExt.Contains("glProgramUniform4fvEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform4fvEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniform4fvEXT) InternalTool.GetGLesMethodAdress("glProgramUniform4fvEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform4fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniform4i64ARB"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform4i64ARB = (dgtk.OpenGL.delegatesGLes.glProgramUniform4i64ARB) InternalTool.GetGLesMethodAdress("glProgramUniform4i64ARB", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform4i64ARB));
			}
			if (SuportedExt.Contains("glProgramUniform4i64NV"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform4i64NV = (dgtk.OpenGL.delegatesGLes.glProgramUniform4i64NV) InternalTool.GetGLesMethodAdress("glProgramUniform4i64NV", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform4i64NV));
			}
			if (SuportedExt.Contains("glProgramUniform4i64vARB"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform4i64vARB = (dgtk.OpenGL.delegatesGLes.glProgramUniform4i64vARB) InternalTool.GetGLesMethodAdress("glProgramUniform4i64vARB", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform4i64vARB));
			}
			if (SuportedExt.Contains("glProgramUniform4i64vNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform4i64vNV = (dgtk.OpenGL.delegatesGLes.glProgramUniform4i64vNV) InternalTool.GetGLesMethodAdress("glProgramUniform4i64vNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform4i64vNV));
			}
			if (SuportedExt.Contains("glProgramUniform4iEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform4iEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniform4iEXT) InternalTool.GetGLesMethodAdress("glProgramUniform4iEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform4iEXT));
			}
			if (SuportedExt.Contains("glProgramUniform4ivEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform4ivEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniform4ivEXT) InternalTool.GetGLesMethodAdress("glProgramUniform4ivEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform4ivEXT));
			}
			if (SuportedExt.Contains("glProgramUniform4ui64ARB"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform4ui64ARB = (dgtk.OpenGL.delegatesGLes.glProgramUniform4ui64ARB) InternalTool.GetGLesMethodAdress("glProgramUniform4ui64ARB", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform4ui64ARB));
			}
			if (SuportedExt.Contains("glProgramUniform4ui64NV"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform4ui64NV = (dgtk.OpenGL.delegatesGLes.glProgramUniform4ui64NV) InternalTool.GetGLesMethodAdress("glProgramUniform4ui64NV", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform4ui64NV));
			}
			if (SuportedExt.Contains("glProgramUniform4ui64vARB"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform4ui64vARB = (dgtk.OpenGL.delegatesGLes.glProgramUniform4ui64vARB) InternalTool.GetGLesMethodAdress("glProgramUniform4ui64vARB", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform4ui64vARB));
			}
			if (SuportedExt.Contains("glProgramUniform4ui64vNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform4ui64vNV = (dgtk.OpenGL.delegatesGLes.glProgramUniform4ui64vNV) InternalTool.GetGLesMethodAdress("glProgramUniform4ui64vNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform4ui64vNV));
			}
			if (SuportedExt.Contains("glProgramUniform4uiEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform4uiEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniform4uiEXT) InternalTool.GetGLesMethodAdress("glProgramUniform4uiEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform4uiEXT));
			}
			if (SuportedExt.Contains("glProgramUniform4uivEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniform4uivEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniform4uivEXT) InternalTool.GetGLesMethodAdress("glProgramUniform4uivEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniform4uivEXT));
			}
			if (SuportedExt.Contains("glProgramUniformHandleui64ARB"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniformHandleui64ARB = (dgtk.OpenGL.delegatesGLes.glProgramUniformHandleui64ARB) InternalTool.GetGLesMethodAdress("glProgramUniformHandleui64ARB", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniformHandleui64ARB));
			}
			if (SuportedExt.Contains("glProgramUniformHandleui64IMG"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniformHandleui64IMG = (dgtk.OpenGL.delegatesGLes.glProgramUniformHandleui64IMG) InternalTool.GetGLesMethodAdress("glProgramUniformHandleui64IMG", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniformHandleui64IMG));
			}
			if (SuportedExt.Contains("glProgramUniformHandleui64NV"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniformHandleui64NV = (dgtk.OpenGL.delegatesGLes.glProgramUniformHandleui64NV) InternalTool.GetGLesMethodAdress("glProgramUniformHandleui64NV", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniformHandleui64NV));
			}
			if (SuportedExt.Contains("glProgramUniformHandleui64vARB"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniformHandleui64vARB = (dgtk.OpenGL.delegatesGLes.glProgramUniformHandleui64vARB) InternalTool.GetGLesMethodAdress("glProgramUniformHandleui64vARB", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniformHandleui64vARB));
			}
			if (SuportedExt.Contains("glProgramUniformHandleui64vIMG"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniformHandleui64vIMG = (dgtk.OpenGL.delegatesGLes.glProgramUniformHandleui64vIMG) InternalTool.GetGLesMethodAdress("glProgramUniformHandleui64vIMG", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniformHandleui64vIMG));
			}
			if (SuportedExt.Contains("glProgramUniformHandleui64vNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniformHandleui64vNV = (dgtk.OpenGL.delegatesGLes.glProgramUniformHandleui64vNV) InternalTool.GetGLesMethodAdress("glProgramUniformHandleui64vNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniformHandleui64vNV));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix2dvEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniformMatrix2dvEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniformMatrix2dvEXT) InternalTool.GetGLesMethodAdress("glProgramUniformMatrix2dvEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniformMatrix2dvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix2fvEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniformMatrix2fvEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniformMatrix2fvEXT) InternalTool.GetGLesMethodAdress("glProgramUniformMatrix2fvEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniformMatrix2fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix2x3dvEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniformMatrix2x3dvEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniformMatrix2x3dvEXT) InternalTool.GetGLesMethodAdress("glProgramUniformMatrix2x3dvEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniformMatrix2x3dvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix2x3fvEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniformMatrix2x3fvEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniformMatrix2x3fvEXT) InternalTool.GetGLesMethodAdress("glProgramUniformMatrix2x3fvEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniformMatrix2x3fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix2x4dvEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniformMatrix2x4dvEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniformMatrix2x4dvEXT) InternalTool.GetGLesMethodAdress("glProgramUniformMatrix2x4dvEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniformMatrix2x4dvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix2x4fvEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniformMatrix2x4fvEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniformMatrix2x4fvEXT) InternalTool.GetGLesMethodAdress("glProgramUniformMatrix2x4fvEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniformMatrix2x4fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix3dvEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniformMatrix3dvEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniformMatrix3dvEXT) InternalTool.GetGLesMethodAdress("glProgramUniformMatrix3dvEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniformMatrix3dvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix3fvEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniformMatrix3fvEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniformMatrix3fvEXT) InternalTool.GetGLesMethodAdress("glProgramUniformMatrix3fvEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniformMatrix3fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix3x2dvEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniformMatrix3x2dvEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniformMatrix3x2dvEXT) InternalTool.GetGLesMethodAdress("glProgramUniformMatrix3x2dvEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniformMatrix3x2dvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix3x2fvEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniformMatrix3x2fvEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniformMatrix3x2fvEXT) InternalTool.GetGLesMethodAdress("glProgramUniformMatrix3x2fvEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniformMatrix3x2fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix3x4dvEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniformMatrix3x4dvEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniformMatrix3x4dvEXT) InternalTool.GetGLesMethodAdress("glProgramUniformMatrix3x4dvEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniformMatrix3x4dvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix3x4fvEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniformMatrix3x4fvEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniformMatrix3x4fvEXT) InternalTool.GetGLesMethodAdress("glProgramUniformMatrix3x4fvEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniformMatrix3x4fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix4dvEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniformMatrix4dvEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniformMatrix4dvEXT) InternalTool.GetGLesMethodAdress("glProgramUniformMatrix4dvEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniformMatrix4dvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix4fvEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniformMatrix4fvEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniformMatrix4fvEXT) InternalTool.GetGLesMethodAdress("glProgramUniformMatrix4fvEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniformMatrix4fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix4x2dvEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniformMatrix4x2dvEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniformMatrix4x2dvEXT) InternalTool.GetGLesMethodAdress("glProgramUniformMatrix4x2dvEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniformMatrix4x2dvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix4x2fvEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniformMatrix4x2fvEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniformMatrix4x2fvEXT) InternalTool.GetGLesMethodAdress("glProgramUniformMatrix4x2fvEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniformMatrix4x2fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix4x3dvEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniformMatrix4x3dvEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniformMatrix4x3dvEXT) InternalTool.GetGLesMethodAdress("glProgramUniformMatrix4x3dvEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniformMatrix4x3dvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformMatrix4x3fvEXT"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniformMatrix4x3fvEXT = (dgtk.OpenGL.delegatesGLes.glProgramUniformMatrix4x3fvEXT) InternalTool.GetGLesMethodAdress("glProgramUniformMatrix4x3fvEXT", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniformMatrix4x3fvEXT));
			}
			if (SuportedExt.Contains("glProgramUniformui64NV"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniformui64NV = (dgtk.OpenGL.delegatesGLes.glProgramUniformui64NV) InternalTool.GetGLesMethodAdress("glProgramUniformui64NV", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniformui64NV));
			}
			if (SuportedExt.Contains("glProgramUniformui64vNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramUniformui64vNV = (dgtk.OpenGL.delegatesGLes.glProgramUniformui64vNV) InternalTool.GetGLesMethodAdress("glProgramUniformui64vNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramUniformui64vNV));
			}
			if (SuportedExt.Contains("glProgramVertexLimitNV"))
			{
				dgtk.OpenGL.internalGLes.glProgramVertexLimitNV = (dgtk.OpenGL.delegatesGLes.glProgramVertexLimitNV) InternalTool.GetGLesMethodAdress("glProgramVertexLimitNV", typeof(dgtk.OpenGL.delegatesGLes.glProgramVertexLimitNV));
			}
			if (SuportedExt.Contains("glProvokingVertexEXT"))
			{
				dgtk.OpenGL.internalGLes.glProvokingVertexEXT = (dgtk.OpenGL.delegatesGLes.glProvokingVertexEXT) InternalTool.GetGLesMethodAdress("glProvokingVertexEXT", typeof(dgtk.OpenGL.delegatesGLes.glProvokingVertexEXT));
			}
			if (SuportedExt.Contains("glPushClientAttribDefaultEXT"))
			{
				dgtk.OpenGL.internalGLes.glPushClientAttribDefaultEXT = (dgtk.OpenGL.delegatesGLes.glPushClientAttribDefaultEXT) InternalTool.GetGLesMethodAdress("glPushClientAttribDefaultEXT", typeof(dgtk.OpenGL.delegatesGLes.glPushClientAttribDefaultEXT));
			}
			if (SuportedExt.Contains("glPushDebugGroupKHR"))
			{
				dgtk.OpenGL.internalGLes.glPushDebugGroupKHR = (dgtk.OpenGL.delegatesGLes.glPushDebugGroupKHR) InternalTool.GetGLesMethodAdress("glPushDebugGroupKHR", typeof(dgtk.OpenGL.delegatesGLes.glPushDebugGroupKHR));
			}
			if (SuportedExt.Contains("glPushGroupMarkerEXT"))
			{
				dgtk.OpenGL.internalGLes.glPushGroupMarkerEXT = (dgtk.OpenGL.delegatesGLes.glPushGroupMarkerEXT) InternalTool.GetGLesMethodAdress("glPushGroupMarkerEXT", typeof(dgtk.OpenGL.delegatesGLes.glPushGroupMarkerEXT));
			}
			#endregion

			#region Q:

			if (SuportedExt.Contains("glQueryCounterEXT"))
			{
				dgtk.OpenGL.internalGLes.glQueryCounterEXT = (dgtk.OpenGL.delegatesGLes.glQueryCounterEXT) InternalTool.GetGLesMethodAdress("glQueryCounterEXT", typeof(dgtk.OpenGL.delegatesGLes.glQueryCounterEXT));
			}
			if (SuportedExt.Contains("glQueryMatrixxOES"))
			{
				dgtk.OpenGL.internalGLes.glQueryMatrixxOES = (dgtk.OpenGL.delegatesGLes.glQueryMatrixxOES) InternalTool.GetGLesMethodAdress("glQueryMatrixxOES", typeof(dgtk.OpenGL.delegatesGLes.glQueryMatrixxOES));
			}
			if (SuportedExt.Contains("glQueryObjectParameteruiAMD"))
			{
				dgtk.OpenGL.internalGLes.glQueryObjectParameteruiAMD = (dgtk.OpenGL.delegatesGLes.glQueryObjectParameteruiAMD) InternalTool.GetGLesMethodAdress("glQueryObjectParameteruiAMD", typeof(dgtk.OpenGL.delegatesGLes.glQueryObjectParameteruiAMD));
			}
			if (SuportedExt.Contains("glQueryResourceNV"))
			{
				dgtk.OpenGL.internalGLes.glQueryResourceNV = (dgtk.OpenGL.delegatesGLes.glQueryResourceNV) InternalTool.GetGLesMethodAdress("glQueryResourceNV", typeof(dgtk.OpenGL.delegatesGLes.glQueryResourceNV));
			}
			if (SuportedExt.Contains("glQueryResourceTagNV"))
			{
				dgtk.OpenGL.internalGLes.glQueryResourceTagNV = (dgtk.OpenGL.delegatesGLes.glQueryResourceTagNV) InternalTool.GetGLesMethodAdress("glQueryResourceTagNV", typeof(dgtk.OpenGL.delegatesGLes.glQueryResourceTagNV));
			}
			#endregion

			#region R:

			if (SuportedExt.Contains("glRasterPos2xOES"))
			{
				dgtk.OpenGL.internalGLes.glRasterPos2xOES = (dgtk.OpenGL.delegatesGLes.glRasterPos2xOES) InternalTool.GetGLesMethodAdress("glRasterPos2xOES", typeof(dgtk.OpenGL.delegatesGLes.glRasterPos2xOES));
			}
			if (SuportedExt.Contains("glRasterPos2xvOES"))
			{
				dgtk.OpenGL.internalGLes.glRasterPos2xvOES = (dgtk.OpenGL.delegatesGLes.glRasterPos2xvOES) InternalTool.GetGLesMethodAdress("glRasterPos2xvOES", typeof(dgtk.OpenGL.delegatesGLes.glRasterPos2xvOES));
			}
			if (SuportedExt.Contains("glRasterPos3xOES"))
			{
				dgtk.OpenGL.internalGLes.glRasterPos3xOES = (dgtk.OpenGL.delegatesGLes.glRasterPos3xOES) InternalTool.GetGLesMethodAdress("glRasterPos3xOES", typeof(dgtk.OpenGL.delegatesGLes.glRasterPos3xOES));
			}
			if (SuportedExt.Contains("glRasterPos3xvOES"))
			{
				dgtk.OpenGL.internalGLes.glRasterPos3xvOES = (dgtk.OpenGL.delegatesGLes.glRasterPos3xvOES) InternalTool.GetGLesMethodAdress("glRasterPos3xvOES", typeof(dgtk.OpenGL.delegatesGLes.glRasterPos3xvOES));
			}
			if (SuportedExt.Contains("glRasterPos4xOES"))
			{
				dgtk.OpenGL.internalGLes.glRasterPos4xOES = (dgtk.OpenGL.delegatesGLes.glRasterPos4xOES) InternalTool.GetGLesMethodAdress("glRasterPos4xOES", typeof(dgtk.OpenGL.delegatesGLes.glRasterPos4xOES));
			}
			if (SuportedExt.Contains("glRasterPos4xvOES"))
			{
				dgtk.OpenGL.internalGLes.glRasterPos4xvOES = (dgtk.OpenGL.delegatesGLes.glRasterPos4xvOES) InternalTool.GetGLesMethodAdress("glRasterPos4xvOES", typeof(dgtk.OpenGL.delegatesGLes.glRasterPos4xvOES));
			}
			if (SuportedExt.Contains("glRasterSamplesEXT"))
			{
				dgtk.OpenGL.internalGLes.glRasterSamplesEXT = (dgtk.OpenGL.delegatesGLes.glRasterSamplesEXT) InternalTool.GetGLesMethodAdress("glRasterSamplesEXT", typeof(dgtk.OpenGL.delegatesGLes.glRasterSamplesEXT));
			}
			if (SuportedExt.Contains("glReadBufferIndexedEXT"))
			{
				dgtk.OpenGL.internalGLes.glReadBufferIndexedEXT = (dgtk.OpenGL.delegatesGLes.glReadBufferIndexedEXT) InternalTool.GetGLesMethodAdress("glReadBufferIndexedEXT", typeof(dgtk.OpenGL.delegatesGLes.glReadBufferIndexedEXT));
			}
			if (SuportedExt.Contains("glReadBufferNV"))
			{
				dgtk.OpenGL.internalGLes.glReadBufferNV = (dgtk.OpenGL.delegatesGLes.glReadBufferNV) InternalTool.GetGLesMethodAdress("glReadBufferNV", typeof(dgtk.OpenGL.delegatesGLes.glReadBufferNV));
			}
			if (SuportedExt.Contains("glReadInstrumentsSGIX"))
			{
				dgtk.OpenGL.internalGLes.glReadInstrumentsSGIX = (dgtk.OpenGL.delegatesGLes.glReadInstrumentsSGIX) InternalTool.GetGLesMethodAdress("glReadInstrumentsSGIX", typeof(dgtk.OpenGL.delegatesGLes.glReadInstrumentsSGIX));
			}
			if (SuportedExt.Contains("glReadnPixelsARB"))
			{
				dgtk.OpenGL.internalGLes.glReadnPixelsARB = (dgtk.OpenGL.delegatesGLes.glReadnPixelsARB) InternalTool.GetGLesMethodAdress("glReadnPixelsARB", typeof(dgtk.OpenGL.delegatesGLes.glReadnPixelsARB));
			}
			if (SuportedExt.Contains("glReadnPixelsEXT"))
			{
				dgtk.OpenGL.internalGLes.glReadnPixelsEXT = (dgtk.OpenGL.delegatesGLes.glReadnPixelsEXT) InternalTool.GetGLesMethodAdress("glReadnPixelsEXT", typeof(dgtk.OpenGL.delegatesGLes.glReadnPixelsEXT));
			}
			if (SuportedExt.Contains("glReadnPixelsKHR"))
			{
				dgtk.OpenGL.internalGLes.glReadnPixelsKHR = (dgtk.OpenGL.delegatesGLes.glReadnPixelsKHR) InternalTool.GetGLesMethodAdress("glReadnPixelsKHR", typeof(dgtk.OpenGL.delegatesGLes.glReadnPixelsKHR));
			}
			if (SuportedExt.Contains("glRectxOES"))
			{
				dgtk.OpenGL.internalGLes.glRectxOES = (dgtk.OpenGL.delegatesGLes.glRectxOES) InternalTool.GetGLesMethodAdress("glRectxOES", typeof(dgtk.OpenGL.delegatesGLes.glRectxOES));
			}
			if (SuportedExt.Contains("glRectxvOES"))
			{
				dgtk.OpenGL.internalGLes.glRectxvOES = (dgtk.OpenGL.delegatesGLes.glRectxvOES) InternalTool.GetGLesMethodAdress("glRectxvOES", typeof(dgtk.OpenGL.delegatesGLes.glRectxvOES));
			}
			if (SuportedExt.Contains("glReferencePlaneSGIX"))
			{
				dgtk.OpenGL.internalGLes.glReferencePlaneSGIX = (dgtk.OpenGL.delegatesGLes.glReferencePlaneSGIX) InternalTool.GetGLesMethodAdress("glReferencePlaneSGIX", typeof(dgtk.OpenGL.delegatesGLes.glReferencePlaneSGIX));
			}
			if (SuportedExt.Contains("glReleaseKeyedMutexWin32EXT"))
			{
				dgtk.OpenGL.internalGLes.glReleaseKeyedMutexWin32EXT = (dgtk.OpenGL.delegatesGLes.glReleaseKeyedMutexWin32EXT) InternalTool.GetGLesMethodAdress("glReleaseKeyedMutexWin32EXT", typeof(dgtk.OpenGL.delegatesGLes.glReleaseKeyedMutexWin32EXT));
			}
			if (SuportedExt.Contains("glRenderbufferStorageEXT"))
			{
				dgtk.OpenGL.internalGLes.glRenderbufferStorageEXT = (dgtk.OpenGL.delegatesGLes.glRenderbufferStorageEXT) InternalTool.GetGLesMethodAdress("glRenderbufferStorageEXT", typeof(dgtk.OpenGL.delegatesGLes.glRenderbufferStorageEXT));
			}
			if (SuportedExt.Contains("glRenderbufferStorageMultisampleAdvancedAMD"))
			{
				dgtk.OpenGL.internalGLes.glRenderbufferStorageMultisampleAdvancedAMD = (dgtk.OpenGL.delegatesGLes.glRenderbufferStorageMultisampleAdvancedAMD) InternalTool.GetGLesMethodAdress("glRenderbufferStorageMultisampleAdvancedAMD", typeof(dgtk.OpenGL.delegatesGLes.glRenderbufferStorageMultisampleAdvancedAMD));
			}
			if (SuportedExt.Contains("glRenderbufferStorageMultisampleANGLE"))
			{
				dgtk.OpenGL.internalGLes.glRenderbufferStorageMultisampleANGLE = (dgtk.OpenGL.delegatesGLes.glRenderbufferStorageMultisampleANGLE) InternalTool.GetGLesMethodAdress("glRenderbufferStorageMultisampleANGLE", typeof(dgtk.OpenGL.delegatesGLes.glRenderbufferStorageMultisampleANGLE));
			}
			if (SuportedExt.Contains("glRenderbufferStorageMultisampleAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glRenderbufferStorageMultisampleAPPLE = (dgtk.OpenGL.delegatesGLes.glRenderbufferStorageMultisampleAPPLE) InternalTool.GetGLesMethodAdress("glRenderbufferStorageMultisampleAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glRenderbufferStorageMultisampleAPPLE));
			}
			if (SuportedExt.Contains("glRenderbufferStorageMultisampleCoverageNV"))
			{
				dgtk.OpenGL.internalGLes.glRenderbufferStorageMultisampleCoverageNV = (dgtk.OpenGL.delegatesGLes.glRenderbufferStorageMultisampleCoverageNV) InternalTool.GetGLesMethodAdress("glRenderbufferStorageMultisampleCoverageNV", typeof(dgtk.OpenGL.delegatesGLes.glRenderbufferStorageMultisampleCoverageNV));
			}
			if (SuportedExt.Contains("glRenderbufferStorageMultisampleEXT"))
			{
				dgtk.OpenGL.internalGLes.glRenderbufferStorageMultisampleEXT = (dgtk.OpenGL.delegatesGLes.glRenderbufferStorageMultisampleEXT) InternalTool.GetGLesMethodAdress("glRenderbufferStorageMultisampleEXT", typeof(dgtk.OpenGL.delegatesGLes.glRenderbufferStorageMultisampleEXT));
			}
			if (SuportedExt.Contains("glRenderbufferStorageMultisampleIMG"))
			{
				dgtk.OpenGL.internalGLes.glRenderbufferStorageMultisampleIMG = (dgtk.OpenGL.delegatesGLes.glRenderbufferStorageMultisampleIMG) InternalTool.GetGLesMethodAdress("glRenderbufferStorageMultisampleIMG", typeof(dgtk.OpenGL.delegatesGLes.glRenderbufferStorageMultisampleIMG));
			}
			if (SuportedExt.Contains("glRenderbufferStorageMultisampleNV"))
			{
				dgtk.OpenGL.internalGLes.glRenderbufferStorageMultisampleNV = (dgtk.OpenGL.delegatesGLes.glRenderbufferStorageMultisampleNV) InternalTool.GetGLesMethodAdress("glRenderbufferStorageMultisampleNV", typeof(dgtk.OpenGL.delegatesGLes.glRenderbufferStorageMultisampleNV));
			}
			if (SuportedExt.Contains("glRenderbufferStorageOES"))
			{
				dgtk.OpenGL.internalGLes.glRenderbufferStorageOES = (dgtk.OpenGL.delegatesGLes.glRenderbufferStorageOES) InternalTool.GetGLesMethodAdress("glRenderbufferStorageOES", typeof(dgtk.OpenGL.delegatesGLes.glRenderbufferStorageOES));
			}
			if (SuportedExt.Contains("glRenderGpuMaskNV"))
			{
				dgtk.OpenGL.internalGLes.glRenderGpuMaskNV = (dgtk.OpenGL.delegatesGLes.glRenderGpuMaskNV) InternalTool.GetGLesMethodAdress("glRenderGpuMaskNV", typeof(dgtk.OpenGL.delegatesGLes.glRenderGpuMaskNV));
			}
			if (SuportedExt.Contains("glReplacementCodePointerSUN"))
			{
				dgtk.OpenGL.internalGLes.glReplacementCodePointerSUN = (dgtk.OpenGL.delegatesGLes.glReplacementCodePointerSUN) InternalTool.GetGLesMethodAdress("glReplacementCodePointerSUN", typeof(dgtk.OpenGL.delegatesGLes.glReplacementCodePointerSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeubSUN"))
			{
				dgtk.OpenGL.internalGLes.glReplacementCodeubSUN = (dgtk.OpenGL.delegatesGLes.glReplacementCodeubSUN) InternalTool.GetGLesMethodAdress("glReplacementCodeubSUN", typeof(dgtk.OpenGL.delegatesGLes.glReplacementCodeubSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeubvSUN"))
			{
				dgtk.OpenGL.internalGLes.glReplacementCodeubvSUN = (dgtk.OpenGL.delegatesGLes.glReplacementCodeubvSUN) InternalTool.GetGLesMethodAdress("glReplacementCodeubvSUN", typeof(dgtk.OpenGL.delegatesGLes.glReplacementCodeubvSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeuiColor3fVertex3fSUN"))
			{
				dgtk.OpenGL.internalGLes.glReplacementCodeuiColor3fVertex3fSUN = (dgtk.OpenGL.delegatesGLes.glReplacementCodeuiColor3fVertex3fSUN) InternalTool.GetGLesMethodAdress("glReplacementCodeuiColor3fVertex3fSUN", typeof(dgtk.OpenGL.delegatesGLes.glReplacementCodeuiColor3fVertex3fSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeuiColor3fVertex3fvSUN"))
			{
				dgtk.OpenGL.internalGLes.glReplacementCodeuiColor3fVertex3fvSUN = (dgtk.OpenGL.delegatesGLes.glReplacementCodeuiColor3fVertex3fvSUN) InternalTool.GetGLesMethodAdress("glReplacementCodeuiColor3fVertex3fvSUN", typeof(dgtk.OpenGL.delegatesGLes.glReplacementCodeuiColor3fVertex3fvSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeuiColor4fNormal3fVertex3fSUN"))
			{
				dgtk.OpenGL.internalGLes.glReplacementCodeuiColor4fNormal3fVertex3fSUN = (dgtk.OpenGL.delegatesGLes.glReplacementCodeuiColor4fNormal3fVertex3fSUN) InternalTool.GetGLesMethodAdress("glReplacementCodeuiColor4fNormal3fVertex3fSUN", typeof(dgtk.OpenGL.delegatesGLes.glReplacementCodeuiColor4fNormal3fVertex3fSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeuiColor4fNormal3fVertex3fvSUN"))
			{
				dgtk.OpenGL.internalGLes.glReplacementCodeuiColor4fNormal3fVertex3fvSUN = (dgtk.OpenGL.delegatesGLes.glReplacementCodeuiColor4fNormal3fVertex3fvSUN) InternalTool.GetGLesMethodAdress("glReplacementCodeuiColor4fNormal3fVertex3fvSUN", typeof(dgtk.OpenGL.delegatesGLes.glReplacementCodeuiColor4fNormal3fVertex3fvSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeuiColor4ubVertex3fSUN"))
			{
				dgtk.OpenGL.internalGLes.glReplacementCodeuiColor4ubVertex3fSUN = (dgtk.OpenGL.delegatesGLes.glReplacementCodeuiColor4ubVertex3fSUN) InternalTool.GetGLesMethodAdress("glReplacementCodeuiColor4ubVertex3fSUN", typeof(dgtk.OpenGL.delegatesGLes.glReplacementCodeuiColor4ubVertex3fSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeuiColor4ubVertex3fvSUN"))
			{
				dgtk.OpenGL.internalGLes.glReplacementCodeuiColor4ubVertex3fvSUN = (dgtk.OpenGL.delegatesGLes.glReplacementCodeuiColor4ubVertex3fvSUN) InternalTool.GetGLesMethodAdress("glReplacementCodeuiColor4ubVertex3fvSUN", typeof(dgtk.OpenGL.delegatesGLes.glReplacementCodeuiColor4ubVertex3fvSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeuiNormal3fVertex3fSUN"))
			{
				dgtk.OpenGL.internalGLes.glReplacementCodeuiNormal3fVertex3fSUN = (dgtk.OpenGL.delegatesGLes.glReplacementCodeuiNormal3fVertex3fSUN) InternalTool.GetGLesMethodAdress("glReplacementCodeuiNormal3fVertex3fSUN", typeof(dgtk.OpenGL.delegatesGLes.glReplacementCodeuiNormal3fVertex3fSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeuiNormal3fVertex3fvSUN"))
			{
				dgtk.OpenGL.internalGLes.glReplacementCodeuiNormal3fVertex3fvSUN = (dgtk.OpenGL.delegatesGLes.glReplacementCodeuiNormal3fVertex3fvSUN) InternalTool.GetGLesMethodAdress("glReplacementCodeuiNormal3fVertex3fvSUN", typeof(dgtk.OpenGL.delegatesGLes.glReplacementCodeuiNormal3fVertex3fvSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeuiSUN"))
			{
				dgtk.OpenGL.internalGLes.glReplacementCodeuiSUN = (dgtk.OpenGL.delegatesGLes.glReplacementCodeuiSUN) InternalTool.GetGLesMethodAdress("glReplacementCodeuiSUN", typeof(dgtk.OpenGL.delegatesGLes.glReplacementCodeuiSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN"))
			{
				dgtk.OpenGL.internalGLes.glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN = (dgtk.OpenGL.delegatesGLes.glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN) InternalTool.GetGLesMethodAdress("glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN", typeof(dgtk.OpenGL.delegatesGLes.glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN"))
			{
				dgtk.OpenGL.internalGLes.glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN = (dgtk.OpenGL.delegatesGLes.glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN) InternalTool.GetGLesMethodAdress("glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", typeof(dgtk.OpenGL.delegatesGLes.glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN"))
			{
				dgtk.OpenGL.internalGLes.glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN = (dgtk.OpenGL.delegatesGLes.glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN) InternalTool.GetGLesMethodAdress("glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN", typeof(dgtk.OpenGL.delegatesGLes.glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN"))
			{
				dgtk.OpenGL.internalGLes.glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN = (dgtk.OpenGL.delegatesGLes.glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN) InternalTool.GetGLesMethodAdress("glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", typeof(dgtk.OpenGL.delegatesGLes.glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeuiTexCoord2fVertex3fSUN"))
			{
				dgtk.OpenGL.internalGLes.glReplacementCodeuiTexCoord2fVertex3fSUN = (dgtk.OpenGL.delegatesGLes.glReplacementCodeuiTexCoord2fVertex3fSUN) InternalTool.GetGLesMethodAdress("glReplacementCodeuiTexCoord2fVertex3fSUN", typeof(dgtk.OpenGL.delegatesGLes.glReplacementCodeuiTexCoord2fVertex3fSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeuiTexCoord2fVertex3fvSUN"))
			{
				dgtk.OpenGL.internalGLes.glReplacementCodeuiTexCoord2fVertex3fvSUN = (dgtk.OpenGL.delegatesGLes.glReplacementCodeuiTexCoord2fVertex3fvSUN) InternalTool.GetGLesMethodAdress("glReplacementCodeuiTexCoord2fVertex3fvSUN", typeof(dgtk.OpenGL.delegatesGLes.glReplacementCodeuiTexCoord2fVertex3fvSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeuiVertex3fSUN"))
			{
				dgtk.OpenGL.internalGLes.glReplacementCodeuiVertex3fSUN = (dgtk.OpenGL.delegatesGLes.glReplacementCodeuiVertex3fSUN) InternalTool.GetGLesMethodAdress("glReplacementCodeuiVertex3fSUN", typeof(dgtk.OpenGL.delegatesGLes.glReplacementCodeuiVertex3fSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeuiVertex3fvSUN"))
			{
				dgtk.OpenGL.internalGLes.glReplacementCodeuiVertex3fvSUN = (dgtk.OpenGL.delegatesGLes.glReplacementCodeuiVertex3fvSUN) InternalTool.GetGLesMethodAdress("glReplacementCodeuiVertex3fvSUN", typeof(dgtk.OpenGL.delegatesGLes.glReplacementCodeuiVertex3fvSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeuivSUN"))
			{
				dgtk.OpenGL.internalGLes.glReplacementCodeuivSUN = (dgtk.OpenGL.delegatesGLes.glReplacementCodeuivSUN) InternalTool.GetGLesMethodAdress("glReplacementCodeuivSUN", typeof(dgtk.OpenGL.delegatesGLes.glReplacementCodeuivSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeusSUN"))
			{
				dgtk.OpenGL.internalGLes.glReplacementCodeusSUN = (dgtk.OpenGL.delegatesGLes.glReplacementCodeusSUN) InternalTool.GetGLesMethodAdress("glReplacementCodeusSUN", typeof(dgtk.OpenGL.delegatesGLes.glReplacementCodeusSUN));
			}
			if (SuportedExt.Contains("glReplacementCodeusvSUN"))
			{
				dgtk.OpenGL.internalGLes.glReplacementCodeusvSUN = (dgtk.OpenGL.delegatesGLes.glReplacementCodeusvSUN) InternalTool.GetGLesMethodAdress("glReplacementCodeusvSUN", typeof(dgtk.OpenGL.delegatesGLes.glReplacementCodeusvSUN));
			}
			if (SuportedExt.Contains("glRequestResidentProgramsNV"))
			{
				dgtk.OpenGL.internalGLes.glRequestResidentProgramsNV = (dgtk.OpenGL.delegatesGLes.glRequestResidentProgramsNV) InternalTool.GetGLesMethodAdress("glRequestResidentProgramsNV", typeof(dgtk.OpenGL.delegatesGLes.glRequestResidentProgramsNV));
			}
			if (SuportedExt.Contains("glResetHistogram"))
			{
				dgtk.OpenGL.internalGLes.glResetHistogram = (dgtk.OpenGL.delegatesGLes.glResetHistogram) InternalTool.GetGLesMethodAdress("glResetHistogram", typeof(dgtk.OpenGL.delegatesGLes.glResetHistogram));
			}
			if (SuportedExt.Contains("glResetHistogramEXT"))
			{
				dgtk.OpenGL.internalGLes.glResetHistogramEXT = (dgtk.OpenGL.delegatesGLes.glResetHistogramEXT) InternalTool.GetGLesMethodAdress("glResetHistogramEXT", typeof(dgtk.OpenGL.delegatesGLes.glResetHistogramEXT));
			}
			if (SuportedExt.Contains("glResetMemoryObjectParameterNV"))
			{
				dgtk.OpenGL.internalGLes.glResetMemoryObjectParameterNV = (dgtk.OpenGL.delegatesGLes.glResetMemoryObjectParameterNV) InternalTool.GetGLesMethodAdress("glResetMemoryObjectParameterNV", typeof(dgtk.OpenGL.delegatesGLes.glResetMemoryObjectParameterNV));
			}
			if (SuportedExt.Contains("glResetMinmax"))
			{
				dgtk.OpenGL.internalGLes.glResetMinmax = (dgtk.OpenGL.delegatesGLes.glResetMinmax) InternalTool.GetGLesMethodAdress("glResetMinmax", typeof(dgtk.OpenGL.delegatesGLes.glResetMinmax));
			}
			if (SuportedExt.Contains("glResetMinmaxEXT"))
			{
				dgtk.OpenGL.internalGLes.glResetMinmaxEXT = (dgtk.OpenGL.delegatesGLes.glResetMinmaxEXT) InternalTool.GetGLesMethodAdress("glResetMinmaxEXT", typeof(dgtk.OpenGL.delegatesGLes.glResetMinmaxEXT));
			}
			if (SuportedExt.Contains("glResizeBuffersMESA"))
			{
				dgtk.OpenGL.internalGLes.glResizeBuffersMESA = (dgtk.OpenGL.delegatesGLes.glResizeBuffersMESA) InternalTool.GetGLesMethodAdress("glResizeBuffersMESA", typeof(dgtk.OpenGL.delegatesGLes.glResizeBuffersMESA));
			}
			if (SuportedExt.Contains("glResolveDepthValuesNV"))
			{
				dgtk.OpenGL.internalGLes.glResolveDepthValuesNV = (dgtk.OpenGL.delegatesGLes.glResolveDepthValuesNV) InternalTool.GetGLesMethodAdress("glResolveDepthValuesNV", typeof(dgtk.OpenGL.delegatesGLes.glResolveDepthValuesNV));
			}
			if (SuportedExt.Contains("glResolveMultisampleFramebufferAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glResolveMultisampleFramebufferAPPLE = (dgtk.OpenGL.delegatesGLes.glResolveMultisampleFramebufferAPPLE) InternalTool.GetGLesMethodAdress("glResolveMultisampleFramebufferAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glResolveMultisampleFramebufferAPPLE));
			}
			if (SuportedExt.Contains("glResumeTransformFeedbackNV"))
			{
				dgtk.OpenGL.internalGLes.glResumeTransformFeedbackNV = (dgtk.OpenGL.delegatesGLes.glResumeTransformFeedbackNV) InternalTool.GetGLesMethodAdress("glResumeTransformFeedbackNV", typeof(dgtk.OpenGL.delegatesGLes.glResumeTransformFeedbackNV));
			}
			if (SuportedExt.Contains("glRotatex"))
			{
				dgtk.OpenGL.internalGLes.glRotatex = (dgtk.OpenGL.delegatesGLes.glRotatex) InternalTool.GetGLesMethodAdress("glRotatex", typeof(dgtk.OpenGL.delegatesGLes.glRotatex));
			}
			if (SuportedExt.Contains("glRotatexOES"))
			{
				dgtk.OpenGL.internalGLes.glRotatexOES = (dgtk.OpenGL.delegatesGLes.glRotatexOES) InternalTool.GetGLesMethodAdress("glRotatexOES", typeof(dgtk.OpenGL.delegatesGLes.glRotatexOES));
			}
			#endregion

			#region S:

			if (SuportedExt.Contains("glSampleCoverageARB"))
			{
				dgtk.OpenGL.internalGLes.glSampleCoverageARB = (dgtk.OpenGL.delegatesGLes.glSampleCoverageARB) InternalTool.GetGLesMethodAdress("glSampleCoverageARB", typeof(dgtk.OpenGL.delegatesGLes.glSampleCoverageARB));
			}
			if (SuportedExt.Contains("glSampleCoveragex"))
			{
				dgtk.OpenGL.internalGLes.glSampleCoveragex = (dgtk.OpenGL.delegatesGLes.glSampleCoveragex) InternalTool.GetGLesMethodAdress("glSampleCoveragex", typeof(dgtk.OpenGL.delegatesGLes.glSampleCoveragex));
			}
			if (SuportedExt.Contains("glSampleCoveragexOES"))
			{
				dgtk.OpenGL.internalGLes.glSampleCoveragexOES = (dgtk.OpenGL.delegatesGLes.glSampleCoveragexOES) InternalTool.GetGLesMethodAdress("glSampleCoveragexOES", typeof(dgtk.OpenGL.delegatesGLes.glSampleCoveragexOES));
			}
			if (SuportedExt.Contains("glSampleMapATI"))
			{
				dgtk.OpenGL.internalGLes.glSampleMapATI = (dgtk.OpenGL.delegatesGLes.glSampleMapATI) InternalTool.GetGLesMethodAdress("glSampleMapATI", typeof(dgtk.OpenGL.delegatesGLes.glSampleMapATI));
			}
			if (SuportedExt.Contains("glSampleMaskEXT"))
			{
				dgtk.OpenGL.internalGLes.glSampleMaskEXT = (dgtk.OpenGL.delegatesGLes.glSampleMaskEXT) InternalTool.GetGLesMethodAdress("glSampleMaskEXT", typeof(dgtk.OpenGL.delegatesGLes.glSampleMaskEXT));
			}
			if (SuportedExt.Contains("glSampleMaskIndexedNV"))
			{
				dgtk.OpenGL.internalGLes.glSampleMaskIndexedNV = (dgtk.OpenGL.delegatesGLes.glSampleMaskIndexedNV) InternalTool.GetGLesMethodAdress("glSampleMaskIndexedNV", typeof(dgtk.OpenGL.delegatesGLes.glSampleMaskIndexedNV));
			}
			if (SuportedExt.Contains("glSampleMaskSGIS"))
			{
				dgtk.OpenGL.internalGLes.glSampleMaskSGIS = (dgtk.OpenGL.delegatesGLes.glSampleMaskSGIS) InternalTool.GetGLesMethodAdress("glSampleMaskSGIS", typeof(dgtk.OpenGL.delegatesGLes.glSampleMaskSGIS));
			}
			if (SuportedExt.Contains("glSamplePatternEXT"))
			{
				dgtk.OpenGL.internalGLes.glSamplePatternEXT = (dgtk.OpenGL.delegatesGLes.glSamplePatternEXT) InternalTool.GetGLesMethodAdress("glSamplePatternEXT", typeof(dgtk.OpenGL.delegatesGLes.glSamplePatternEXT));
			}
			if (SuportedExt.Contains("glSamplePatternSGIS"))
			{
				dgtk.OpenGL.internalGLes.glSamplePatternSGIS = (dgtk.OpenGL.delegatesGLes.glSamplePatternSGIS) InternalTool.GetGLesMethodAdress("glSamplePatternSGIS", typeof(dgtk.OpenGL.delegatesGLes.glSamplePatternSGIS));
			}
			if (SuportedExt.Contains("glSamplerParameterIivEXT"))
			{
				dgtk.OpenGL.internalGLes.glSamplerParameterIivEXT = (dgtk.OpenGL.delegatesGLes.glSamplerParameterIivEXT) InternalTool.GetGLesMethodAdress("glSamplerParameterIivEXT", typeof(dgtk.OpenGL.delegatesGLes.glSamplerParameterIivEXT));
			}
			if (SuportedExt.Contains("glSamplerParameterIivOES"))
			{
				dgtk.OpenGL.internalGLes.glSamplerParameterIivOES = (dgtk.OpenGL.delegatesGLes.glSamplerParameterIivOES) InternalTool.GetGLesMethodAdress("glSamplerParameterIivOES", typeof(dgtk.OpenGL.delegatesGLes.glSamplerParameterIivOES));
			}
			if (SuportedExt.Contains("glSamplerParameterIuivEXT"))
			{
				dgtk.OpenGL.internalGLes.glSamplerParameterIuivEXT = (dgtk.OpenGL.delegatesGLes.glSamplerParameterIuivEXT) InternalTool.GetGLesMethodAdress("glSamplerParameterIuivEXT", typeof(dgtk.OpenGL.delegatesGLes.glSamplerParameterIuivEXT));
			}
			if (SuportedExt.Contains("glSamplerParameterIuivOES"))
			{
				dgtk.OpenGL.internalGLes.glSamplerParameterIuivOES = (dgtk.OpenGL.delegatesGLes.glSamplerParameterIuivOES) InternalTool.GetGLesMethodAdress("glSamplerParameterIuivOES", typeof(dgtk.OpenGL.delegatesGLes.glSamplerParameterIuivOES));
			}
			if (SuportedExt.Contains("glScalex"))
			{
				dgtk.OpenGL.internalGLes.glScalex = (dgtk.OpenGL.delegatesGLes.glScalex) InternalTool.GetGLesMethodAdress("glScalex", typeof(dgtk.OpenGL.delegatesGLes.glScalex));
			}
			if (SuportedExt.Contains("glScalexOES"))
			{
				dgtk.OpenGL.internalGLes.glScalexOES = (dgtk.OpenGL.delegatesGLes.glScalexOES) InternalTool.GetGLesMethodAdress("glScalexOES", typeof(dgtk.OpenGL.delegatesGLes.glScalexOES));
			}
			if (SuportedExt.Contains("glScissorArrayvNV"))
			{
				dgtk.OpenGL.internalGLes.glScissorArrayvNV = (dgtk.OpenGL.delegatesGLes.glScissorArrayvNV) InternalTool.GetGLesMethodAdress("glScissorArrayvNV", typeof(dgtk.OpenGL.delegatesGLes.glScissorArrayvNV));
			}
			if (SuportedExt.Contains("glScissorArrayvOES"))
			{
				dgtk.OpenGL.internalGLes.glScissorArrayvOES = (dgtk.OpenGL.delegatesGLes.glScissorArrayvOES) InternalTool.GetGLesMethodAdress("glScissorArrayvOES", typeof(dgtk.OpenGL.delegatesGLes.glScissorArrayvOES));
			}
			if (SuportedExt.Contains("glScissorExclusiveArrayvNV"))
			{
				dgtk.OpenGL.internalGLes.glScissorExclusiveArrayvNV = (dgtk.OpenGL.delegatesGLes.glScissorExclusiveArrayvNV) InternalTool.GetGLesMethodAdress("glScissorExclusiveArrayvNV", typeof(dgtk.OpenGL.delegatesGLes.glScissorExclusiveArrayvNV));
			}
			if (SuportedExt.Contains("glScissorExclusiveNV"))
			{
				dgtk.OpenGL.internalGLes.glScissorExclusiveNV = (dgtk.OpenGL.delegatesGLes.glScissorExclusiveNV) InternalTool.GetGLesMethodAdress("glScissorExclusiveNV", typeof(dgtk.OpenGL.delegatesGLes.glScissorExclusiveNV));
			}
			if (SuportedExt.Contains("glScissorIndexedNV"))
			{
				dgtk.OpenGL.internalGLes.glScissorIndexedNV = (dgtk.OpenGL.delegatesGLes.glScissorIndexedNV) InternalTool.GetGLesMethodAdress("glScissorIndexedNV", typeof(dgtk.OpenGL.delegatesGLes.glScissorIndexedNV));
			}
			if (SuportedExt.Contains("glScissorIndexedOES"))
			{
				dgtk.OpenGL.internalGLes.glScissorIndexedOES = (dgtk.OpenGL.delegatesGLes.glScissorIndexedOES) InternalTool.GetGLesMethodAdress("glScissorIndexedOES", typeof(dgtk.OpenGL.delegatesGLes.glScissorIndexedOES));
			}
			if (SuportedExt.Contains("glScissorIndexedvNV"))
			{
				dgtk.OpenGL.internalGLes.glScissorIndexedvNV = (dgtk.OpenGL.delegatesGLes.glScissorIndexedvNV) InternalTool.GetGLesMethodAdress("glScissorIndexedvNV", typeof(dgtk.OpenGL.delegatesGLes.glScissorIndexedvNV));
			}
			if (SuportedExt.Contains("glScissorIndexedvOES"))
			{
				dgtk.OpenGL.internalGLes.glScissorIndexedvOES = (dgtk.OpenGL.delegatesGLes.glScissorIndexedvOES) InternalTool.GetGLesMethodAdress("glScissorIndexedvOES", typeof(dgtk.OpenGL.delegatesGLes.glScissorIndexedvOES));
			}
			if (SuportedExt.Contains("glSecondaryColor3bEXT"))
			{
				dgtk.OpenGL.internalGLes.glSecondaryColor3bEXT = (dgtk.OpenGL.delegatesGLes.glSecondaryColor3bEXT) InternalTool.GetGLesMethodAdress("glSecondaryColor3bEXT", typeof(dgtk.OpenGL.delegatesGLes.glSecondaryColor3bEXT));
			}
			if (SuportedExt.Contains("glSecondaryColor3bvEXT"))
			{
				dgtk.OpenGL.internalGLes.glSecondaryColor3bvEXT = (dgtk.OpenGL.delegatesGLes.glSecondaryColor3bvEXT) InternalTool.GetGLesMethodAdress("glSecondaryColor3bvEXT", typeof(dgtk.OpenGL.delegatesGLes.glSecondaryColor3bvEXT));
			}
			if (SuportedExt.Contains("glSecondaryColor3dEXT"))
			{
				dgtk.OpenGL.internalGLes.glSecondaryColor3dEXT = (dgtk.OpenGL.delegatesGLes.glSecondaryColor3dEXT) InternalTool.GetGLesMethodAdress("glSecondaryColor3dEXT", typeof(dgtk.OpenGL.delegatesGLes.glSecondaryColor3dEXT));
			}
			if (SuportedExt.Contains("glSecondaryColor3dvEXT"))
			{
				dgtk.OpenGL.internalGLes.glSecondaryColor3dvEXT = (dgtk.OpenGL.delegatesGLes.glSecondaryColor3dvEXT) InternalTool.GetGLesMethodAdress("glSecondaryColor3dvEXT", typeof(dgtk.OpenGL.delegatesGLes.glSecondaryColor3dvEXT));
			}
			if (SuportedExt.Contains("glSecondaryColor3fEXT"))
			{
				dgtk.OpenGL.internalGLes.glSecondaryColor3fEXT = (dgtk.OpenGL.delegatesGLes.glSecondaryColor3fEXT) InternalTool.GetGLesMethodAdress("glSecondaryColor3fEXT", typeof(dgtk.OpenGL.delegatesGLes.glSecondaryColor3fEXT));
			}
			if (SuportedExt.Contains("glSecondaryColor3fvEXT"))
			{
				dgtk.OpenGL.internalGLes.glSecondaryColor3fvEXT = (dgtk.OpenGL.delegatesGLes.glSecondaryColor3fvEXT) InternalTool.GetGLesMethodAdress("glSecondaryColor3fvEXT", typeof(dgtk.OpenGL.delegatesGLes.glSecondaryColor3fvEXT));
			}
			if (SuportedExt.Contains("glSecondaryColor3hNV"))
			{
				dgtk.OpenGL.internalGLes.glSecondaryColor3hNV = (dgtk.OpenGL.delegatesGLes.glSecondaryColor3hNV) InternalTool.GetGLesMethodAdress("glSecondaryColor3hNV", typeof(dgtk.OpenGL.delegatesGLes.glSecondaryColor3hNV));
			}
			if (SuportedExt.Contains("glSecondaryColor3hvNV"))
			{
				dgtk.OpenGL.internalGLes.glSecondaryColor3hvNV = (dgtk.OpenGL.delegatesGLes.glSecondaryColor3hvNV) InternalTool.GetGLesMethodAdress("glSecondaryColor3hvNV", typeof(dgtk.OpenGL.delegatesGLes.glSecondaryColor3hvNV));
			}
			if (SuportedExt.Contains("glSecondaryColor3iEXT"))
			{
				dgtk.OpenGL.internalGLes.glSecondaryColor3iEXT = (dgtk.OpenGL.delegatesGLes.glSecondaryColor3iEXT) InternalTool.GetGLesMethodAdress("glSecondaryColor3iEXT", typeof(dgtk.OpenGL.delegatesGLes.glSecondaryColor3iEXT));
			}
			if (SuportedExt.Contains("glSecondaryColor3ivEXT"))
			{
				dgtk.OpenGL.internalGLes.glSecondaryColor3ivEXT = (dgtk.OpenGL.delegatesGLes.glSecondaryColor3ivEXT) InternalTool.GetGLesMethodAdress("glSecondaryColor3ivEXT", typeof(dgtk.OpenGL.delegatesGLes.glSecondaryColor3ivEXT));
			}
			if (SuportedExt.Contains("glSecondaryColor3sEXT"))
			{
				dgtk.OpenGL.internalGLes.glSecondaryColor3sEXT = (dgtk.OpenGL.delegatesGLes.glSecondaryColor3sEXT) InternalTool.GetGLesMethodAdress("glSecondaryColor3sEXT", typeof(dgtk.OpenGL.delegatesGLes.glSecondaryColor3sEXT));
			}
			if (SuportedExt.Contains("glSecondaryColor3svEXT"))
			{
				dgtk.OpenGL.internalGLes.glSecondaryColor3svEXT = (dgtk.OpenGL.delegatesGLes.glSecondaryColor3svEXT) InternalTool.GetGLesMethodAdress("glSecondaryColor3svEXT", typeof(dgtk.OpenGL.delegatesGLes.glSecondaryColor3svEXT));
			}
			if (SuportedExt.Contains("glSecondaryColor3ubEXT"))
			{
				dgtk.OpenGL.internalGLes.glSecondaryColor3ubEXT = (dgtk.OpenGL.delegatesGLes.glSecondaryColor3ubEXT) InternalTool.GetGLesMethodAdress("glSecondaryColor3ubEXT", typeof(dgtk.OpenGL.delegatesGLes.glSecondaryColor3ubEXT));
			}
			if (SuportedExt.Contains("glSecondaryColor3ubvEXT"))
			{
				dgtk.OpenGL.internalGLes.glSecondaryColor3ubvEXT = (dgtk.OpenGL.delegatesGLes.glSecondaryColor3ubvEXT) InternalTool.GetGLesMethodAdress("glSecondaryColor3ubvEXT", typeof(dgtk.OpenGL.delegatesGLes.glSecondaryColor3ubvEXT));
			}
			if (SuportedExt.Contains("glSecondaryColor3uiEXT"))
			{
				dgtk.OpenGL.internalGLes.glSecondaryColor3uiEXT = (dgtk.OpenGL.delegatesGLes.glSecondaryColor3uiEXT) InternalTool.GetGLesMethodAdress("glSecondaryColor3uiEXT", typeof(dgtk.OpenGL.delegatesGLes.glSecondaryColor3uiEXT));
			}
			if (SuportedExt.Contains("glSecondaryColor3uivEXT"))
			{
				dgtk.OpenGL.internalGLes.glSecondaryColor3uivEXT = (dgtk.OpenGL.delegatesGLes.glSecondaryColor3uivEXT) InternalTool.GetGLesMethodAdress("glSecondaryColor3uivEXT", typeof(dgtk.OpenGL.delegatesGLes.glSecondaryColor3uivEXT));
			}
			if (SuportedExt.Contains("glSecondaryColor3usEXT"))
			{
				dgtk.OpenGL.internalGLes.glSecondaryColor3usEXT = (dgtk.OpenGL.delegatesGLes.glSecondaryColor3usEXT) InternalTool.GetGLesMethodAdress("glSecondaryColor3usEXT", typeof(dgtk.OpenGL.delegatesGLes.glSecondaryColor3usEXT));
			}
			if (SuportedExt.Contains("glSecondaryColor3usvEXT"))
			{
				dgtk.OpenGL.internalGLes.glSecondaryColor3usvEXT = (dgtk.OpenGL.delegatesGLes.glSecondaryColor3usvEXT) InternalTool.GetGLesMethodAdress("glSecondaryColor3usvEXT", typeof(dgtk.OpenGL.delegatesGLes.glSecondaryColor3usvEXT));
			}
			if (SuportedExt.Contains("glSecondaryColorFormatNV"))
			{
				dgtk.OpenGL.internalGLes.glSecondaryColorFormatNV = (dgtk.OpenGL.delegatesGLes.glSecondaryColorFormatNV) InternalTool.GetGLesMethodAdress("glSecondaryColorFormatNV", typeof(dgtk.OpenGL.delegatesGLes.glSecondaryColorFormatNV));
			}
			if (SuportedExt.Contains("glSecondaryColorPointerEXT"))
			{
				dgtk.OpenGL.internalGLes.glSecondaryColorPointerEXT = (dgtk.OpenGL.delegatesGLes.glSecondaryColorPointerEXT) InternalTool.GetGLesMethodAdress("glSecondaryColorPointerEXT", typeof(dgtk.OpenGL.delegatesGLes.glSecondaryColorPointerEXT));
			}
			if (SuportedExt.Contains("glSecondaryColorPointerListIBM"))
			{
				dgtk.OpenGL.internalGLes.glSecondaryColorPointerListIBM = (dgtk.OpenGL.delegatesGLes.glSecondaryColorPointerListIBM) InternalTool.GetGLesMethodAdress("glSecondaryColorPointerListIBM", typeof(dgtk.OpenGL.delegatesGLes.glSecondaryColorPointerListIBM));
			}
			if (SuportedExt.Contains("glSelectPerfMonitorCountersAMD"))
			{
				dgtk.OpenGL.internalGLes.glSelectPerfMonitorCountersAMD = (dgtk.OpenGL.delegatesGLes.glSelectPerfMonitorCountersAMD) InternalTool.GetGLesMethodAdress("glSelectPerfMonitorCountersAMD", typeof(dgtk.OpenGL.delegatesGLes.glSelectPerfMonitorCountersAMD));
			}
			if (SuportedExt.Contains("glSemaphoreParameterivNV"))
			{
				dgtk.OpenGL.internalGLes.glSemaphoreParameterivNV = (dgtk.OpenGL.delegatesGLes.glSemaphoreParameterivNV) InternalTool.GetGLesMethodAdress("glSemaphoreParameterivNV", typeof(dgtk.OpenGL.delegatesGLes.glSemaphoreParameterivNV));
			}
			if (SuportedExt.Contains("glSemaphoreParameterui64vEXT"))
			{
				dgtk.OpenGL.internalGLes.glSemaphoreParameterui64vEXT = (dgtk.OpenGL.delegatesGLes.glSemaphoreParameterui64vEXT) InternalTool.GetGLesMethodAdress("glSemaphoreParameterui64vEXT", typeof(dgtk.OpenGL.delegatesGLes.glSemaphoreParameterui64vEXT));
			}
			if (SuportedExt.Contains("glSeparableFilter2D"))
			{
				dgtk.OpenGL.internalGLes.glSeparableFilter2D = (dgtk.OpenGL.delegatesGLes.glSeparableFilter2D) InternalTool.GetGLesMethodAdress("glSeparableFilter2D", typeof(dgtk.OpenGL.delegatesGLes.glSeparableFilter2D));
			}
			if (SuportedExt.Contains("glSeparableFilter2DEXT"))
			{
				dgtk.OpenGL.internalGLes.glSeparableFilter2DEXT = (dgtk.OpenGL.delegatesGLes.glSeparableFilter2DEXT) InternalTool.GetGLesMethodAdress("glSeparableFilter2DEXT", typeof(dgtk.OpenGL.delegatesGLes.glSeparableFilter2DEXT));
			}
			if (SuportedExt.Contains("glSetFenceAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glSetFenceAPPLE = (dgtk.OpenGL.delegatesGLes.glSetFenceAPPLE) InternalTool.GetGLesMethodAdress("glSetFenceAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glSetFenceAPPLE));
			}
			if (SuportedExt.Contains("glSetFenceNV"))
			{
				dgtk.OpenGL.internalGLes.glSetFenceNV = (dgtk.OpenGL.delegatesGLes.glSetFenceNV) InternalTool.GetGLesMethodAdress("glSetFenceNV", typeof(dgtk.OpenGL.delegatesGLes.glSetFenceNV));
			}
			if (SuportedExt.Contains("glSetFragmentShaderConstantATI"))
			{
				dgtk.OpenGL.internalGLes.glSetFragmentShaderConstantATI = (dgtk.OpenGL.delegatesGLes.glSetFragmentShaderConstantATI) InternalTool.GetGLesMethodAdress("glSetFragmentShaderConstantATI", typeof(dgtk.OpenGL.delegatesGLes.glSetFragmentShaderConstantATI));
			}
			if (SuportedExt.Contains("glSetInvariantEXT"))
			{
				dgtk.OpenGL.internalGLes.glSetInvariantEXT = (dgtk.OpenGL.delegatesGLes.glSetInvariantEXT) InternalTool.GetGLesMethodAdress("glSetInvariantEXT", typeof(dgtk.OpenGL.delegatesGLes.glSetInvariantEXT));
			}
			if (SuportedExt.Contains("glSetLocalConstantEXT"))
			{
				dgtk.OpenGL.internalGLes.glSetLocalConstantEXT = (dgtk.OpenGL.delegatesGLes.glSetLocalConstantEXT) InternalTool.GetGLesMethodAdress("glSetLocalConstantEXT", typeof(dgtk.OpenGL.delegatesGLes.glSetLocalConstantEXT));
			}
			if (SuportedExt.Contains("glSetMultisamplefvAMD"))
			{
				dgtk.OpenGL.internalGLes.glSetMultisamplefvAMD = (dgtk.OpenGL.delegatesGLes.glSetMultisamplefvAMD) InternalTool.GetGLesMethodAdress("glSetMultisamplefvAMD", typeof(dgtk.OpenGL.delegatesGLes.glSetMultisamplefvAMD));
			}
			if (SuportedExt.Contains("glShaderOp1EXT"))
			{
				dgtk.OpenGL.internalGLes.glShaderOp1EXT = (dgtk.OpenGL.delegatesGLes.glShaderOp1EXT) InternalTool.GetGLesMethodAdress("glShaderOp1EXT", typeof(dgtk.OpenGL.delegatesGLes.glShaderOp1EXT));
			}
			if (SuportedExt.Contains("glShaderOp2EXT"))
			{
				dgtk.OpenGL.internalGLes.glShaderOp2EXT = (dgtk.OpenGL.delegatesGLes.glShaderOp2EXT) InternalTool.GetGLesMethodAdress("glShaderOp2EXT", typeof(dgtk.OpenGL.delegatesGLes.glShaderOp2EXT));
			}
			if (SuportedExt.Contains("glShaderOp3EXT"))
			{
				dgtk.OpenGL.internalGLes.glShaderOp3EXT = (dgtk.OpenGL.delegatesGLes.glShaderOp3EXT) InternalTool.GetGLesMethodAdress("glShaderOp3EXT", typeof(dgtk.OpenGL.delegatesGLes.glShaderOp3EXT));
			}
			if (SuportedExt.Contains("glShaderSourceARB"))
			{
				dgtk.OpenGL.internalGLes.glShaderSourceARB = (dgtk.OpenGL.delegatesGLes.glShaderSourceARB) InternalTool.GetGLesMethodAdress("glShaderSourceARB", typeof(dgtk.OpenGL.delegatesGLes.glShaderSourceARB));
			}
			if (SuportedExt.Contains("glShadingRateImageBarrierNV"))
			{
				dgtk.OpenGL.internalGLes.glShadingRateImageBarrierNV = (dgtk.OpenGL.delegatesGLes.glShadingRateImageBarrierNV) InternalTool.GetGLesMethodAdress("glShadingRateImageBarrierNV", typeof(dgtk.OpenGL.delegatesGLes.glShadingRateImageBarrierNV));
			}
			if (SuportedExt.Contains("glShadingRateImagePaletteNV"))
			{
				dgtk.OpenGL.internalGLes.glShadingRateImagePaletteNV = (dgtk.OpenGL.delegatesGLes.glShadingRateImagePaletteNV) InternalTool.GetGLesMethodAdress("glShadingRateImagePaletteNV", typeof(dgtk.OpenGL.delegatesGLes.glShadingRateImagePaletteNV));
			}
			if (SuportedExt.Contains("glShadingRateQCOM"))
			{
				dgtk.OpenGL.internalGLes.glShadingRateQCOM = (dgtk.OpenGL.delegatesGLes.glShadingRateQCOM) InternalTool.GetGLesMethodAdress("glShadingRateQCOM", typeof(dgtk.OpenGL.delegatesGLes.glShadingRateQCOM));
			}
			if (SuportedExt.Contains("glShadingRateSampleOrderCustomNV"))
			{
				dgtk.OpenGL.internalGLes.glShadingRateSampleOrderCustomNV = (dgtk.OpenGL.delegatesGLes.glShadingRateSampleOrderCustomNV) InternalTool.GetGLesMethodAdress("glShadingRateSampleOrderCustomNV", typeof(dgtk.OpenGL.delegatesGLes.glShadingRateSampleOrderCustomNV));
			}
			if (SuportedExt.Contains("glShadingRateSampleOrderNV"))
			{
				dgtk.OpenGL.internalGLes.glShadingRateSampleOrderNV = (dgtk.OpenGL.delegatesGLes.glShadingRateSampleOrderNV) InternalTool.GetGLesMethodAdress("glShadingRateSampleOrderNV", typeof(dgtk.OpenGL.delegatesGLes.glShadingRateSampleOrderNV));
			}
			if (SuportedExt.Contains("glSharpenTexFuncSGIS"))
			{
				dgtk.OpenGL.internalGLes.glSharpenTexFuncSGIS = (dgtk.OpenGL.delegatesGLes.glSharpenTexFuncSGIS) InternalTool.GetGLesMethodAdress("glSharpenTexFuncSGIS", typeof(dgtk.OpenGL.delegatesGLes.glSharpenTexFuncSGIS));
			}
			if (SuportedExt.Contains("glSignalSemaphoreEXT"))
			{
				dgtk.OpenGL.internalGLes.glSignalSemaphoreEXT = (dgtk.OpenGL.delegatesGLes.glSignalSemaphoreEXT) InternalTool.GetGLesMethodAdress("glSignalSemaphoreEXT", typeof(dgtk.OpenGL.delegatesGLes.glSignalSemaphoreEXT));
			}
			if (SuportedExt.Contains("glSignalSemaphoreui64NVX"))
			{
				dgtk.OpenGL.internalGLes.glSignalSemaphoreui64NVX = (dgtk.OpenGL.delegatesGLes.glSignalSemaphoreui64NVX) InternalTool.GetGLesMethodAdress("glSignalSemaphoreui64NVX", typeof(dgtk.OpenGL.delegatesGLes.glSignalSemaphoreui64NVX));
			}
			if (SuportedExt.Contains("glSignalVkFenceNV"))
			{
				dgtk.OpenGL.internalGLes.glSignalVkFenceNV = (dgtk.OpenGL.delegatesGLes.glSignalVkFenceNV) InternalTool.GetGLesMethodAdress("glSignalVkFenceNV", typeof(dgtk.OpenGL.delegatesGLes.glSignalVkFenceNV));
			}
			if (SuportedExt.Contains("glSignalVkSemaphoreNV"))
			{
				dgtk.OpenGL.internalGLes.glSignalVkSemaphoreNV = (dgtk.OpenGL.delegatesGLes.glSignalVkSemaphoreNV) InternalTool.GetGLesMethodAdress("glSignalVkSemaphoreNV", typeof(dgtk.OpenGL.delegatesGLes.glSignalVkSemaphoreNV));
			}
			if (SuportedExt.Contains("glSpecializeShaderARB"))
			{
				dgtk.OpenGL.internalGLes.glSpecializeShaderARB = (dgtk.OpenGL.delegatesGLes.glSpecializeShaderARB) InternalTool.GetGLesMethodAdress("glSpecializeShaderARB", typeof(dgtk.OpenGL.delegatesGLes.glSpecializeShaderARB));
			}
			if (SuportedExt.Contains("glSpriteParameterfSGIX"))
			{
				dgtk.OpenGL.internalGLes.glSpriteParameterfSGIX = (dgtk.OpenGL.delegatesGLes.glSpriteParameterfSGIX) InternalTool.GetGLesMethodAdress("glSpriteParameterfSGIX", typeof(dgtk.OpenGL.delegatesGLes.glSpriteParameterfSGIX));
			}
			if (SuportedExt.Contains("glSpriteParameterfvSGIX"))
			{
				dgtk.OpenGL.internalGLes.glSpriteParameterfvSGIX = (dgtk.OpenGL.delegatesGLes.glSpriteParameterfvSGIX) InternalTool.GetGLesMethodAdress("glSpriteParameterfvSGIX", typeof(dgtk.OpenGL.delegatesGLes.glSpriteParameterfvSGIX));
			}
			if (SuportedExt.Contains("glSpriteParameteriSGIX"))
			{
				dgtk.OpenGL.internalGLes.glSpriteParameteriSGIX = (dgtk.OpenGL.delegatesGLes.glSpriteParameteriSGIX) InternalTool.GetGLesMethodAdress("glSpriteParameteriSGIX", typeof(dgtk.OpenGL.delegatesGLes.glSpriteParameteriSGIX));
			}
			if (SuportedExt.Contains("glSpriteParameterivSGIX"))
			{
				dgtk.OpenGL.internalGLes.glSpriteParameterivSGIX = (dgtk.OpenGL.delegatesGLes.glSpriteParameterivSGIX) InternalTool.GetGLesMethodAdress("glSpriteParameterivSGIX", typeof(dgtk.OpenGL.delegatesGLes.glSpriteParameterivSGIX));
			}
			if (SuportedExt.Contains("glStartInstrumentsSGIX"))
			{
				dgtk.OpenGL.internalGLes.glStartInstrumentsSGIX = (dgtk.OpenGL.delegatesGLes.glStartInstrumentsSGIX) InternalTool.GetGLesMethodAdress("glStartInstrumentsSGIX", typeof(dgtk.OpenGL.delegatesGLes.glStartInstrumentsSGIX));
			}
			if (SuportedExt.Contains("glStartTilingQCOM"))
			{
				dgtk.OpenGL.internalGLes.glStartTilingQCOM = (dgtk.OpenGL.delegatesGLes.glStartTilingQCOM) InternalTool.GetGLesMethodAdress("glStartTilingQCOM", typeof(dgtk.OpenGL.delegatesGLes.glStartTilingQCOM));
			}
			if (SuportedExt.Contains("glStateCaptureNV"))
			{
				dgtk.OpenGL.internalGLes.glStateCaptureNV = (dgtk.OpenGL.delegatesGLes.glStateCaptureNV) InternalTool.GetGLesMethodAdress("glStateCaptureNV", typeof(dgtk.OpenGL.delegatesGLes.glStateCaptureNV));
			}
			if (SuportedExt.Contains("glStencilClearTagEXT"))
			{
				dgtk.OpenGL.internalGLes.glStencilClearTagEXT = (dgtk.OpenGL.delegatesGLes.glStencilClearTagEXT) InternalTool.GetGLesMethodAdress("glStencilClearTagEXT", typeof(dgtk.OpenGL.delegatesGLes.glStencilClearTagEXT));
			}
			if (SuportedExt.Contains("glStencilFillPathInstancedNV"))
			{
				dgtk.OpenGL.internalGLes.glStencilFillPathInstancedNV = (dgtk.OpenGL.delegatesGLes.glStencilFillPathInstancedNV) InternalTool.GetGLesMethodAdress("glStencilFillPathInstancedNV", typeof(dgtk.OpenGL.delegatesGLes.glStencilFillPathInstancedNV));
			}
			if (SuportedExt.Contains("glStencilFillPathNV"))
			{
				dgtk.OpenGL.internalGLes.glStencilFillPathNV = (dgtk.OpenGL.delegatesGLes.glStencilFillPathNV) InternalTool.GetGLesMethodAdress("glStencilFillPathNV", typeof(dgtk.OpenGL.delegatesGLes.glStencilFillPathNV));
			}
			if (SuportedExt.Contains("glStencilFuncSeparateATI"))
			{
				dgtk.OpenGL.internalGLes.glStencilFuncSeparateATI = (dgtk.OpenGL.delegatesGLes.glStencilFuncSeparateATI) InternalTool.GetGLesMethodAdress("glStencilFuncSeparateATI", typeof(dgtk.OpenGL.delegatesGLes.glStencilFuncSeparateATI));
			}
			if (SuportedExt.Contains("glStencilOpSeparateATI"))
			{
				dgtk.OpenGL.internalGLes.glStencilOpSeparateATI = (dgtk.OpenGL.delegatesGLes.glStencilOpSeparateATI) InternalTool.GetGLesMethodAdress("glStencilOpSeparateATI", typeof(dgtk.OpenGL.delegatesGLes.glStencilOpSeparateATI));
			}
			if (SuportedExt.Contains("glStencilOpValueAMD"))
			{
				dgtk.OpenGL.internalGLes.glStencilOpValueAMD = (dgtk.OpenGL.delegatesGLes.glStencilOpValueAMD) InternalTool.GetGLesMethodAdress("glStencilOpValueAMD", typeof(dgtk.OpenGL.delegatesGLes.glStencilOpValueAMD));
			}
			if (SuportedExt.Contains("glStencilStrokePathInstancedNV"))
			{
				dgtk.OpenGL.internalGLes.glStencilStrokePathInstancedNV = (dgtk.OpenGL.delegatesGLes.glStencilStrokePathInstancedNV) InternalTool.GetGLesMethodAdress("glStencilStrokePathInstancedNV", typeof(dgtk.OpenGL.delegatesGLes.glStencilStrokePathInstancedNV));
			}
			if (SuportedExt.Contains("glStencilStrokePathNV"))
			{
				dgtk.OpenGL.internalGLes.glStencilStrokePathNV = (dgtk.OpenGL.delegatesGLes.glStencilStrokePathNV) InternalTool.GetGLesMethodAdress("glStencilStrokePathNV", typeof(dgtk.OpenGL.delegatesGLes.glStencilStrokePathNV));
			}
			if (SuportedExt.Contains("glStencilThenCoverFillPathInstancedNV"))
			{
				dgtk.OpenGL.internalGLes.glStencilThenCoverFillPathInstancedNV = (dgtk.OpenGL.delegatesGLes.glStencilThenCoverFillPathInstancedNV) InternalTool.GetGLesMethodAdress("glStencilThenCoverFillPathInstancedNV", typeof(dgtk.OpenGL.delegatesGLes.glStencilThenCoverFillPathInstancedNV));
			}
			if (SuportedExt.Contains("glStencilThenCoverFillPathNV"))
			{
				dgtk.OpenGL.internalGLes.glStencilThenCoverFillPathNV = (dgtk.OpenGL.delegatesGLes.glStencilThenCoverFillPathNV) InternalTool.GetGLesMethodAdress("glStencilThenCoverFillPathNV", typeof(dgtk.OpenGL.delegatesGLes.glStencilThenCoverFillPathNV));
			}
			if (SuportedExt.Contains("glStencilThenCoverStrokePathInstancedNV"))
			{
				dgtk.OpenGL.internalGLes.glStencilThenCoverStrokePathInstancedNV = (dgtk.OpenGL.delegatesGLes.glStencilThenCoverStrokePathInstancedNV) InternalTool.GetGLesMethodAdress("glStencilThenCoverStrokePathInstancedNV", typeof(dgtk.OpenGL.delegatesGLes.glStencilThenCoverStrokePathInstancedNV));
			}
			if (SuportedExt.Contains("glStencilThenCoverStrokePathNV"))
			{
				dgtk.OpenGL.internalGLes.glStencilThenCoverStrokePathNV = (dgtk.OpenGL.delegatesGLes.glStencilThenCoverStrokePathNV) InternalTool.GetGLesMethodAdress("glStencilThenCoverStrokePathNV", typeof(dgtk.OpenGL.delegatesGLes.glStencilThenCoverStrokePathNV));
			}
			if (SuportedExt.Contains("glStopInstrumentsSGIX"))
			{
				dgtk.OpenGL.internalGLes.glStopInstrumentsSGIX = (dgtk.OpenGL.delegatesGLes.glStopInstrumentsSGIX) InternalTool.GetGLesMethodAdress("glStopInstrumentsSGIX", typeof(dgtk.OpenGL.delegatesGLes.glStopInstrumentsSGIX));
			}
			if (SuportedExt.Contains("glStringMarkerGREMEDY"))
			{
				dgtk.OpenGL.internalGLes.glStringMarkerGREMEDY = (dgtk.OpenGL.delegatesGLes.glStringMarkerGREMEDY) InternalTool.GetGLesMethodAdress("glStringMarkerGREMEDY", typeof(dgtk.OpenGL.delegatesGLes.glStringMarkerGREMEDY));
			}
			if (SuportedExt.Contains("glSubpixelPrecisionBiasNV"))
			{
				dgtk.OpenGL.internalGLes.glSubpixelPrecisionBiasNV = (dgtk.OpenGL.delegatesGLes.glSubpixelPrecisionBiasNV) InternalTool.GetGLesMethodAdress("glSubpixelPrecisionBiasNV", typeof(dgtk.OpenGL.delegatesGLes.glSubpixelPrecisionBiasNV));
			}
			if (SuportedExt.Contains("glSwizzleEXT"))
			{
				dgtk.OpenGL.internalGLes.glSwizzleEXT = (dgtk.OpenGL.delegatesGLes.glSwizzleEXT) InternalTool.GetGLesMethodAdress("glSwizzleEXT", typeof(dgtk.OpenGL.delegatesGLes.glSwizzleEXT));
			}
			if (SuportedExt.Contains("glSyncTextureINTEL"))
			{
				dgtk.OpenGL.internalGLes.glSyncTextureINTEL = (dgtk.OpenGL.delegatesGLes.glSyncTextureINTEL) InternalTool.GetGLesMethodAdress("glSyncTextureINTEL", typeof(dgtk.OpenGL.delegatesGLes.glSyncTextureINTEL));
			}
			#endregion

			#region T:

			if (SuportedExt.Contains("glTagSampleBufferSGIX"))
			{
				dgtk.OpenGL.internalGLes.glTagSampleBufferSGIX = (dgtk.OpenGL.delegatesGLes.glTagSampleBufferSGIX) InternalTool.GetGLesMethodAdress("glTagSampleBufferSGIX", typeof(dgtk.OpenGL.delegatesGLes.glTagSampleBufferSGIX));
			}
			if (SuportedExt.Contains("glTangent3bEXT"))
			{
				dgtk.OpenGL.internalGLes.glTangent3bEXT = (dgtk.OpenGL.delegatesGLes.glTangent3bEXT) InternalTool.GetGLesMethodAdress("glTangent3bEXT", typeof(dgtk.OpenGL.delegatesGLes.glTangent3bEXT));
			}
			if (SuportedExt.Contains("glTangent3bvEXT"))
			{
				dgtk.OpenGL.internalGLes.glTangent3bvEXT = (dgtk.OpenGL.delegatesGLes.glTangent3bvEXT) InternalTool.GetGLesMethodAdress("glTangent3bvEXT", typeof(dgtk.OpenGL.delegatesGLes.glTangent3bvEXT));
			}
			if (SuportedExt.Contains("glTangent3dEXT"))
			{
				dgtk.OpenGL.internalGLes.glTangent3dEXT = (dgtk.OpenGL.delegatesGLes.glTangent3dEXT) InternalTool.GetGLesMethodAdress("glTangent3dEXT", typeof(dgtk.OpenGL.delegatesGLes.glTangent3dEXT));
			}
			if (SuportedExt.Contains("glTangent3dvEXT"))
			{
				dgtk.OpenGL.internalGLes.glTangent3dvEXT = (dgtk.OpenGL.delegatesGLes.glTangent3dvEXT) InternalTool.GetGLesMethodAdress("glTangent3dvEXT", typeof(dgtk.OpenGL.delegatesGLes.glTangent3dvEXT));
			}
			if (SuportedExt.Contains("glTangent3fEXT"))
			{
				dgtk.OpenGL.internalGLes.glTangent3fEXT = (dgtk.OpenGL.delegatesGLes.glTangent3fEXT) InternalTool.GetGLesMethodAdress("glTangent3fEXT", typeof(dgtk.OpenGL.delegatesGLes.glTangent3fEXT));
			}
			if (SuportedExt.Contains("glTangent3fvEXT"))
			{
				dgtk.OpenGL.internalGLes.glTangent3fvEXT = (dgtk.OpenGL.delegatesGLes.glTangent3fvEXT) InternalTool.GetGLesMethodAdress("glTangent3fvEXT", typeof(dgtk.OpenGL.delegatesGLes.glTangent3fvEXT));
			}
			if (SuportedExt.Contains("glTangent3iEXT"))
			{
				dgtk.OpenGL.internalGLes.glTangent3iEXT = (dgtk.OpenGL.delegatesGLes.glTangent3iEXT) InternalTool.GetGLesMethodAdress("glTangent3iEXT", typeof(dgtk.OpenGL.delegatesGLes.glTangent3iEXT));
			}
			if (SuportedExt.Contains("glTangent3ivEXT"))
			{
				dgtk.OpenGL.internalGLes.glTangent3ivEXT = (dgtk.OpenGL.delegatesGLes.glTangent3ivEXT) InternalTool.GetGLesMethodAdress("glTangent3ivEXT", typeof(dgtk.OpenGL.delegatesGLes.glTangent3ivEXT));
			}
			if (SuportedExt.Contains("glTangent3sEXT"))
			{
				dgtk.OpenGL.internalGLes.glTangent3sEXT = (dgtk.OpenGL.delegatesGLes.glTangent3sEXT) InternalTool.GetGLesMethodAdress("glTangent3sEXT", typeof(dgtk.OpenGL.delegatesGLes.glTangent3sEXT));
			}
			if (SuportedExt.Contains("glTangent3svEXT"))
			{
				dgtk.OpenGL.internalGLes.glTangent3svEXT = (dgtk.OpenGL.delegatesGLes.glTangent3svEXT) InternalTool.GetGLesMethodAdress("glTangent3svEXT", typeof(dgtk.OpenGL.delegatesGLes.glTangent3svEXT));
			}
			if (SuportedExt.Contains("glTangentPointerEXT"))
			{
				dgtk.OpenGL.internalGLes.glTangentPointerEXT = (dgtk.OpenGL.delegatesGLes.glTangentPointerEXT) InternalTool.GetGLesMethodAdress("glTangentPointerEXT", typeof(dgtk.OpenGL.delegatesGLes.glTangentPointerEXT));
			}
			if (SuportedExt.Contains("glTbufferMask3DFX"))
			{
				dgtk.OpenGL.internalGLes.glTbufferMask3DFX = (dgtk.OpenGL.delegatesGLes.glTbufferMask3DFX) InternalTool.GetGLesMethodAdress("glTbufferMask3DFX", typeof(dgtk.OpenGL.delegatesGLes.glTbufferMask3DFX));
			}
			if (SuportedExt.Contains("glTessellationFactorAMD"))
			{
				dgtk.OpenGL.internalGLes.glTessellationFactorAMD = (dgtk.OpenGL.delegatesGLes.glTessellationFactorAMD) InternalTool.GetGLesMethodAdress("glTessellationFactorAMD", typeof(dgtk.OpenGL.delegatesGLes.glTessellationFactorAMD));
			}
			if (SuportedExt.Contains("glTessellationModeAMD"))
			{
				dgtk.OpenGL.internalGLes.glTessellationModeAMD = (dgtk.OpenGL.delegatesGLes.glTessellationModeAMD) InternalTool.GetGLesMethodAdress("glTessellationModeAMD", typeof(dgtk.OpenGL.delegatesGLes.glTessellationModeAMD));
			}
			if (SuportedExt.Contains("glTestFenceAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glTestFenceAPPLE = (dgtk.OpenGL.delegatesGLes.glTestFenceAPPLE) InternalTool.GetGLesMethodAdress("glTestFenceAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glTestFenceAPPLE));
			}
			if (SuportedExt.Contains("glTestFenceNV"))
			{
				dgtk.OpenGL.internalGLes.glTestFenceNV = (dgtk.OpenGL.delegatesGLes.glTestFenceNV) InternalTool.GetGLesMethodAdress("glTestFenceNV", typeof(dgtk.OpenGL.delegatesGLes.glTestFenceNV));
			}
			if (SuportedExt.Contains("glTestObjectAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glTestObjectAPPLE = (dgtk.OpenGL.delegatesGLes.glTestObjectAPPLE) InternalTool.GetGLesMethodAdress("glTestObjectAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glTestObjectAPPLE));
			}
			if (SuportedExt.Contains("glTexAttachMemoryNV"))
			{
				dgtk.OpenGL.internalGLes.glTexAttachMemoryNV = (dgtk.OpenGL.delegatesGLes.glTexAttachMemoryNV) InternalTool.GetGLesMethodAdress("glTexAttachMemoryNV", typeof(dgtk.OpenGL.delegatesGLes.glTexAttachMemoryNV));
			}
			if (SuportedExt.Contains("glTexBufferARB"))
			{
				dgtk.OpenGL.internalGLes.glTexBufferARB = (dgtk.OpenGL.delegatesGLes.glTexBufferARB) InternalTool.GetGLesMethodAdress("glTexBufferARB", typeof(dgtk.OpenGL.delegatesGLes.glTexBufferARB));
			}
			if (SuportedExt.Contains("glTexBufferEXT"))
			{
				dgtk.OpenGL.internalGLes.glTexBufferEXT = (dgtk.OpenGL.delegatesGLes.glTexBufferEXT) InternalTool.GetGLesMethodAdress("glTexBufferEXT", typeof(dgtk.OpenGL.delegatesGLes.glTexBufferEXT));
			}
			if (SuportedExt.Contains("glTexBufferOES"))
			{
				dgtk.OpenGL.internalGLes.glTexBufferOES = (dgtk.OpenGL.delegatesGLes.glTexBufferOES) InternalTool.GetGLesMethodAdress("glTexBufferOES", typeof(dgtk.OpenGL.delegatesGLes.glTexBufferOES));
			}
			if (SuportedExt.Contains("glTexBufferRangeEXT"))
			{
				dgtk.OpenGL.internalGLes.glTexBufferRangeEXT = (dgtk.OpenGL.delegatesGLes.glTexBufferRangeEXT) InternalTool.GetGLesMethodAdress("glTexBufferRangeEXT", typeof(dgtk.OpenGL.delegatesGLes.glTexBufferRangeEXT));
			}
			if (SuportedExt.Contains("glTexBufferRangeOES"))
			{
				dgtk.OpenGL.internalGLes.glTexBufferRangeOES = (dgtk.OpenGL.delegatesGLes.glTexBufferRangeOES) InternalTool.GetGLesMethodAdress("glTexBufferRangeOES", typeof(dgtk.OpenGL.delegatesGLes.glTexBufferRangeOES));
			}
			if (SuportedExt.Contains("glTexBumpParameterfvATI"))
			{
				dgtk.OpenGL.internalGLes.glTexBumpParameterfvATI = (dgtk.OpenGL.delegatesGLes.glTexBumpParameterfvATI) InternalTool.GetGLesMethodAdress("glTexBumpParameterfvATI", typeof(dgtk.OpenGL.delegatesGLes.glTexBumpParameterfvATI));
			}
			if (SuportedExt.Contains("glTexBumpParameterivATI"))
			{
				dgtk.OpenGL.internalGLes.glTexBumpParameterivATI = (dgtk.OpenGL.delegatesGLes.glTexBumpParameterivATI) InternalTool.GetGLesMethodAdress("glTexBumpParameterivATI", typeof(dgtk.OpenGL.delegatesGLes.glTexBumpParameterivATI));
			}
			if (SuportedExt.Contains("glTexCoord1bOES"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord1bOES = (dgtk.OpenGL.delegatesGLes.glTexCoord1bOES) InternalTool.GetGLesMethodAdress("glTexCoord1bOES", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord1bOES));
			}
			if (SuportedExt.Contains("glTexCoord1bvOES"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord1bvOES = (dgtk.OpenGL.delegatesGLes.glTexCoord1bvOES) InternalTool.GetGLesMethodAdress("glTexCoord1bvOES", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord1bvOES));
			}
			if (SuportedExt.Contains("glTexCoord1hNV"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord1hNV = (dgtk.OpenGL.delegatesGLes.glTexCoord1hNV) InternalTool.GetGLesMethodAdress("glTexCoord1hNV", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord1hNV));
			}
			if (SuportedExt.Contains("glTexCoord1hvNV"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord1hvNV = (dgtk.OpenGL.delegatesGLes.glTexCoord1hvNV) InternalTool.GetGLesMethodAdress("glTexCoord1hvNV", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord1hvNV));
			}
			if (SuportedExt.Contains("glTexCoord1xOES"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord1xOES = (dgtk.OpenGL.delegatesGLes.glTexCoord1xOES) InternalTool.GetGLesMethodAdress("glTexCoord1xOES", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord1xOES));
			}
			if (SuportedExt.Contains("glTexCoord1xvOES"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord1xvOES = (dgtk.OpenGL.delegatesGLes.glTexCoord1xvOES) InternalTool.GetGLesMethodAdress("glTexCoord1xvOES", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord1xvOES));
			}
			if (SuportedExt.Contains("glTexCoord2bOES"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord2bOES = (dgtk.OpenGL.delegatesGLes.glTexCoord2bOES) InternalTool.GetGLesMethodAdress("glTexCoord2bOES", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord2bOES));
			}
			if (SuportedExt.Contains("glTexCoord2bvOES"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord2bvOES = (dgtk.OpenGL.delegatesGLes.glTexCoord2bvOES) InternalTool.GetGLesMethodAdress("glTexCoord2bvOES", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord2bvOES));
			}
			if (SuportedExt.Contains("glTexCoord2fColor3fVertex3fSUN"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord2fColor3fVertex3fSUN = (dgtk.OpenGL.delegatesGLes.glTexCoord2fColor3fVertex3fSUN) InternalTool.GetGLesMethodAdress("glTexCoord2fColor3fVertex3fSUN", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord2fColor3fVertex3fSUN));
			}
			if (SuportedExt.Contains("glTexCoord2fColor3fVertex3fvSUN"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord2fColor3fVertex3fvSUN = (dgtk.OpenGL.delegatesGLes.glTexCoord2fColor3fVertex3fvSUN) InternalTool.GetGLesMethodAdress("glTexCoord2fColor3fVertex3fvSUN", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord2fColor3fVertex3fvSUN));
			}
			if (SuportedExt.Contains("glTexCoord2fColor4fNormal3fVertex3fSUN"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord2fColor4fNormal3fVertex3fSUN = (dgtk.OpenGL.delegatesGLes.glTexCoord2fColor4fNormal3fVertex3fSUN) InternalTool.GetGLesMethodAdress("glTexCoord2fColor4fNormal3fVertex3fSUN", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord2fColor4fNormal3fVertex3fSUN));
			}
			if (SuportedExt.Contains("glTexCoord2fColor4fNormal3fVertex3fvSUN"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord2fColor4fNormal3fVertex3fvSUN = (dgtk.OpenGL.delegatesGLes.glTexCoord2fColor4fNormal3fVertex3fvSUN) InternalTool.GetGLesMethodAdress("glTexCoord2fColor4fNormal3fVertex3fvSUN", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord2fColor4fNormal3fVertex3fvSUN));
			}
			if (SuportedExt.Contains("glTexCoord2fColor4ubVertex3fSUN"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord2fColor4ubVertex3fSUN = (dgtk.OpenGL.delegatesGLes.glTexCoord2fColor4ubVertex3fSUN) InternalTool.GetGLesMethodAdress("glTexCoord2fColor4ubVertex3fSUN", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord2fColor4ubVertex3fSUN));
			}
			if (SuportedExt.Contains("glTexCoord2fColor4ubVertex3fvSUN"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord2fColor4ubVertex3fvSUN = (dgtk.OpenGL.delegatesGLes.glTexCoord2fColor4ubVertex3fvSUN) InternalTool.GetGLesMethodAdress("glTexCoord2fColor4ubVertex3fvSUN", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord2fColor4ubVertex3fvSUN));
			}
			if (SuportedExt.Contains("glTexCoord2fNormal3fVertex3fSUN"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord2fNormal3fVertex3fSUN = (dgtk.OpenGL.delegatesGLes.glTexCoord2fNormal3fVertex3fSUN) InternalTool.GetGLesMethodAdress("glTexCoord2fNormal3fVertex3fSUN", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord2fNormal3fVertex3fSUN));
			}
			if (SuportedExt.Contains("glTexCoord2fNormal3fVertex3fvSUN"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord2fNormal3fVertex3fvSUN = (dgtk.OpenGL.delegatesGLes.glTexCoord2fNormal3fVertex3fvSUN) InternalTool.GetGLesMethodAdress("glTexCoord2fNormal3fVertex3fvSUN", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord2fNormal3fVertex3fvSUN));
			}
			if (SuportedExt.Contains("glTexCoord2fVertex3fSUN"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord2fVertex3fSUN = (dgtk.OpenGL.delegatesGLes.glTexCoord2fVertex3fSUN) InternalTool.GetGLesMethodAdress("glTexCoord2fVertex3fSUN", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord2fVertex3fSUN));
			}
			if (SuportedExt.Contains("glTexCoord2fVertex3fvSUN"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord2fVertex3fvSUN = (dgtk.OpenGL.delegatesGLes.glTexCoord2fVertex3fvSUN) InternalTool.GetGLesMethodAdress("glTexCoord2fVertex3fvSUN", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord2fVertex3fvSUN));
			}
			if (SuportedExt.Contains("glTexCoord2hNV"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord2hNV = (dgtk.OpenGL.delegatesGLes.glTexCoord2hNV) InternalTool.GetGLesMethodAdress("glTexCoord2hNV", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord2hNV));
			}
			if (SuportedExt.Contains("glTexCoord2hvNV"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord2hvNV = (dgtk.OpenGL.delegatesGLes.glTexCoord2hvNV) InternalTool.GetGLesMethodAdress("glTexCoord2hvNV", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord2hvNV));
			}
			if (SuportedExt.Contains("glTexCoord2xOES"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord2xOES = (dgtk.OpenGL.delegatesGLes.glTexCoord2xOES) InternalTool.GetGLesMethodAdress("glTexCoord2xOES", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord2xOES));
			}
			if (SuportedExt.Contains("glTexCoord2xvOES"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord2xvOES = (dgtk.OpenGL.delegatesGLes.glTexCoord2xvOES) InternalTool.GetGLesMethodAdress("glTexCoord2xvOES", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord2xvOES));
			}
			if (SuportedExt.Contains("glTexCoord3bOES"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord3bOES = (dgtk.OpenGL.delegatesGLes.glTexCoord3bOES) InternalTool.GetGLesMethodAdress("glTexCoord3bOES", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord3bOES));
			}
			if (SuportedExt.Contains("glTexCoord3bvOES"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord3bvOES = (dgtk.OpenGL.delegatesGLes.glTexCoord3bvOES) InternalTool.GetGLesMethodAdress("glTexCoord3bvOES", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord3bvOES));
			}
			if (SuportedExt.Contains("glTexCoord3hNV"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord3hNV = (dgtk.OpenGL.delegatesGLes.glTexCoord3hNV) InternalTool.GetGLesMethodAdress("glTexCoord3hNV", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord3hNV));
			}
			if (SuportedExt.Contains("glTexCoord3hvNV"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord3hvNV = (dgtk.OpenGL.delegatesGLes.glTexCoord3hvNV) InternalTool.GetGLesMethodAdress("glTexCoord3hvNV", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord3hvNV));
			}
			if (SuportedExt.Contains("glTexCoord3xOES"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord3xOES = (dgtk.OpenGL.delegatesGLes.glTexCoord3xOES) InternalTool.GetGLesMethodAdress("glTexCoord3xOES", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord3xOES));
			}
			if (SuportedExt.Contains("glTexCoord3xvOES"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord3xvOES = (dgtk.OpenGL.delegatesGLes.glTexCoord3xvOES) InternalTool.GetGLesMethodAdress("glTexCoord3xvOES", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord3xvOES));
			}
			if (SuportedExt.Contains("glTexCoord4bOES"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord4bOES = (dgtk.OpenGL.delegatesGLes.glTexCoord4bOES) InternalTool.GetGLesMethodAdress("glTexCoord4bOES", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord4bOES));
			}
			if (SuportedExt.Contains("glTexCoord4bvOES"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord4bvOES = (dgtk.OpenGL.delegatesGLes.glTexCoord4bvOES) InternalTool.GetGLesMethodAdress("glTexCoord4bvOES", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord4bvOES));
			}
			if (SuportedExt.Contains("glTexCoord4fColor4fNormal3fVertex4fSUN"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord4fColor4fNormal3fVertex4fSUN = (dgtk.OpenGL.delegatesGLes.glTexCoord4fColor4fNormal3fVertex4fSUN) InternalTool.GetGLesMethodAdress("glTexCoord4fColor4fNormal3fVertex4fSUN", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord4fColor4fNormal3fVertex4fSUN));
			}
			if (SuportedExt.Contains("glTexCoord4fColor4fNormal3fVertex4fvSUN"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord4fColor4fNormal3fVertex4fvSUN = (dgtk.OpenGL.delegatesGLes.glTexCoord4fColor4fNormal3fVertex4fvSUN) InternalTool.GetGLesMethodAdress("glTexCoord4fColor4fNormal3fVertex4fvSUN", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord4fColor4fNormal3fVertex4fvSUN));
			}
			if (SuportedExt.Contains("glTexCoord4fVertex4fSUN"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord4fVertex4fSUN = (dgtk.OpenGL.delegatesGLes.glTexCoord4fVertex4fSUN) InternalTool.GetGLesMethodAdress("glTexCoord4fVertex4fSUN", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord4fVertex4fSUN));
			}
			if (SuportedExt.Contains("glTexCoord4fVertex4fvSUN"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord4fVertex4fvSUN = (dgtk.OpenGL.delegatesGLes.glTexCoord4fVertex4fvSUN) InternalTool.GetGLesMethodAdress("glTexCoord4fVertex4fvSUN", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord4fVertex4fvSUN));
			}
			if (SuportedExt.Contains("glTexCoord4hNV"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord4hNV = (dgtk.OpenGL.delegatesGLes.glTexCoord4hNV) InternalTool.GetGLesMethodAdress("glTexCoord4hNV", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord4hNV));
			}
			if (SuportedExt.Contains("glTexCoord4hvNV"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord4hvNV = (dgtk.OpenGL.delegatesGLes.glTexCoord4hvNV) InternalTool.GetGLesMethodAdress("glTexCoord4hvNV", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord4hvNV));
			}
			if (SuportedExt.Contains("glTexCoord4xOES"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord4xOES = (dgtk.OpenGL.delegatesGLes.glTexCoord4xOES) InternalTool.GetGLesMethodAdress("glTexCoord4xOES", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord4xOES));
			}
			if (SuportedExt.Contains("glTexCoord4xvOES"))
			{
				dgtk.OpenGL.internalGLes.glTexCoord4xvOES = (dgtk.OpenGL.delegatesGLes.glTexCoord4xvOES) InternalTool.GetGLesMethodAdress("glTexCoord4xvOES", typeof(dgtk.OpenGL.delegatesGLes.glTexCoord4xvOES));
			}
			if (SuportedExt.Contains("glTexCoordFormatNV"))
			{
				dgtk.OpenGL.internalGLes.glTexCoordFormatNV = (dgtk.OpenGL.delegatesGLes.glTexCoordFormatNV) InternalTool.GetGLesMethodAdress("glTexCoordFormatNV", typeof(dgtk.OpenGL.delegatesGLes.glTexCoordFormatNV));
			}
			if (SuportedExt.Contains("glTexCoordPointerEXT"))
			{
				dgtk.OpenGL.internalGLes.glTexCoordPointerEXT = (dgtk.OpenGL.delegatesGLes.glTexCoordPointerEXT) InternalTool.GetGLesMethodAdress("glTexCoordPointerEXT", typeof(dgtk.OpenGL.delegatesGLes.glTexCoordPointerEXT));
			}
			if (SuportedExt.Contains("glTexCoordPointerListIBM"))
			{
				dgtk.OpenGL.internalGLes.glTexCoordPointerListIBM = (dgtk.OpenGL.delegatesGLes.glTexCoordPointerListIBM) InternalTool.GetGLesMethodAdress("glTexCoordPointerListIBM", typeof(dgtk.OpenGL.delegatesGLes.glTexCoordPointerListIBM));
			}
			if (SuportedExt.Contains("glTexCoordPointervINTEL"))
			{
				dgtk.OpenGL.internalGLes.glTexCoordPointervINTEL = (dgtk.OpenGL.delegatesGLes.glTexCoordPointervINTEL) InternalTool.GetGLesMethodAdress("glTexCoordPointervINTEL", typeof(dgtk.OpenGL.delegatesGLes.glTexCoordPointervINTEL));
			}
			if (SuportedExt.Contains("glTexEnvx"))
			{
				dgtk.OpenGL.internalGLes.glTexEnvx = (dgtk.OpenGL.delegatesGLes.glTexEnvx) InternalTool.GetGLesMethodAdress("glTexEnvx", typeof(dgtk.OpenGL.delegatesGLes.glTexEnvx));
			}
			if (SuportedExt.Contains("glTexEnvxOES"))
			{
				dgtk.OpenGL.internalGLes.glTexEnvxOES = (dgtk.OpenGL.delegatesGLes.glTexEnvxOES) InternalTool.GetGLesMethodAdress("glTexEnvxOES", typeof(dgtk.OpenGL.delegatesGLes.glTexEnvxOES));
			}
			if (SuportedExt.Contains("glTexEnvxv"))
			{
				dgtk.OpenGL.internalGLes.glTexEnvxv = (dgtk.OpenGL.delegatesGLes.glTexEnvxv) InternalTool.GetGLesMethodAdress("glTexEnvxv", typeof(dgtk.OpenGL.delegatesGLes.glTexEnvxv));
			}
			if (SuportedExt.Contains("glTexEnvxvOES"))
			{
				dgtk.OpenGL.internalGLes.glTexEnvxvOES = (dgtk.OpenGL.delegatesGLes.glTexEnvxvOES) InternalTool.GetGLesMethodAdress("glTexEnvxvOES", typeof(dgtk.OpenGL.delegatesGLes.glTexEnvxvOES));
			}
			if (SuportedExt.Contains("glTexEstimateMotionQCOM"))
			{
				dgtk.OpenGL.internalGLes.glTexEstimateMotionQCOM = (dgtk.OpenGL.delegatesGLes.glTexEstimateMotionQCOM) InternalTool.GetGLesMethodAdress("glTexEstimateMotionQCOM", typeof(dgtk.OpenGL.delegatesGLes.glTexEstimateMotionQCOM));
			}
			if (SuportedExt.Contains("glTexEstimateMotionRegionsQCOM"))
			{
				dgtk.OpenGL.internalGLes.glTexEstimateMotionRegionsQCOM = (dgtk.OpenGL.delegatesGLes.glTexEstimateMotionRegionsQCOM) InternalTool.GetGLesMethodAdress("glTexEstimateMotionRegionsQCOM", typeof(dgtk.OpenGL.delegatesGLes.glTexEstimateMotionRegionsQCOM));
			}
			if (SuportedExt.Contains("glTexFilterFuncSGIS"))
			{
				dgtk.OpenGL.internalGLes.glTexFilterFuncSGIS = (dgtk.OpenGL.delegatesGLes.glTexFilterFuncSGIS) InternalTool.GetGLesMethodAdress("glTexFilterFuncSGIS", typeof(dgtk.OpenGL.delegatesGLes.glTexFilterFuncSGIS));
			}
			if (SuportedExt.Contains("glTexGenfOES"))
			{
				dgtk.OpenGL.internalGLes.glTexGenfOES = (dgtk.OpenGL.delegatesGLes.glTexGenfOES) InternalTool.GetGLesMethodAdress("glTexGenfOES", typeof(dgtk.OpenGL.delegatesGLes.glTexGenfOES));
			}
			if (SuportedExt.Contains("glTexGenfvOES"))
			{
				dgtk.OpenGL.internalGLes.glTexGenfvOES = (dgtk.OpenGL.delegatesGLes.glTexGenfvOES) InternalTool.GetGLesMethodAdress("glTexGenfvOES", typeof(dgtk.OpenGL.delegatesGLes.glTexGenfvOES));
			}
			if (SuportedExt.Contains("glTexGeniOES"))
			{
				dgtk.OpenGL.internalGLes.glTexGeniOES = (dgtk.OpenGL.delegatesGLes.glTexGeniOES) InternalTool.GetGLesMethodAdress("glTexGeniOES", typeof(dgtk.OpenGL.delegatesGLes.glTexGeniOES));
			}
			if (SuportedExt.Contains("glTexGenivOES"))
			{
				dgtk.OpenGL.internalGLes.glTexGenivOES = (dgtk.OpenGL.delegatesGLes.glTexGenivOES) InternalTool.GetGLesMethodAdress("glTexGenivOES", typeof(dgtk.OpenGL.delegatesGLes.glTexGenivOES));
			}
			if (SuportedExt.Contains("glTexGenxOES"))
			{
				dgtk.OpenGL.internalGLes.glTexGenxOES = (dgtk.OpenGL.delegatesGLes.glTexGenxOES) InternalTool.GetGLesMethodAdress("glTexGenxOES", typeof(dgtk.OpenGL.delegatesGLes.glTexGenxOES));
			}
			if (SuportedExt.Contains("glTexGenxvOES"))
			{
				dgtk.OpenGL.internalGLes.glTexGenxvOES = (dgtk.OpenGL.delegatesGLes.glTexGenxvOES) InternalTool.GetGLesMethodAdress("glTexGenxvOES", typeof(dgtk.OpenGL.delegatesGLes.glTexGenxvOES));
			}
			if (SuportedExt.Contains("glTexImage2DMultisampleCoverageNV"))
			{
				dgtk.OpenGL.internalGLes.glTexImage2DMultisampleCoverageNV = (dgtk.OpenGL.delegatesGLes.glTexImage2DMultisampleCoverageNV) InternalTool.GetGLesMethodAdress("glTexImage2DMultisampleCoverageNV", typeof(dgtk.OpenGL.delegatesGLes.glTexImage2DMultisampleCoverageNV));
			}
			if (SuportedExt.Contains("glTexImage3DEXT"))
			{
				dgtk.OpenGL.internalGLes.glTexImage3DEXT = (dgtk.OpenGL.delegatesGLes.glTexImage3DEXT) InternalTool.GetGLesMethodAdress("glTexImage3DEXT", typeof(dgtk.OpenGL.delegatesGLes.glTexImage3DEXT));
			}
			if (SuportedExt.Contains("glTexImage3DMultisampleCoverageNV"))
			{
				dgtk.OpenGL.internalGLes.glTexImage3DMultisampleCoverageNV = (dgtk.OpenGL.delegatesGLes.glTexImage3DMultisampleCoverageNV) InternalTool.GetGLesMethodAdress("glTexImage3DMultisampleCoverageNV", typeof(dgtk.OpenGL.delegatesGLes.glTexImage3DMultisampleCoverageNV));
			}
			if (SuportedExt.Contains("glTexImage3DOES"))
			{
				dgtk.OpenGL.internalGLes.glTexImage3DOES = (dgtk.OpenGL.delegatesGLes.glTexImage3DOES) InternalTool.GetGLesMethodAdress("glTexImage3DOES", typeof(dgtk.OpenGL.delegatesGLes.glTexImage3DOES));
			}
			if (SuportedExt.Contains("glTexImage4DSGIS"))
			{
				dgtk.OpenGL.internalGLes.glTexImage4DSGIS = (dgtk.OpenGL.delegatesGLes.glTexImage4DSGIS) InternalTool.GetGLesMethodAdress("glTexImage4DSGIS", typeof(dgtk.OpenGL.delegatesGLes.glTexImage4DSGIS));
			}
			if (SuportedExt.Contains("glTexPageCommitmentARB"))
			{
				dgtk.OpenGL.internalGLes.glTexPageCommitmentARB = (dgtk.OpenGL.delegatesGLes.glTexPageCommitmentARB) InternalTool.GetGLesMethodAdress("glTexPageCommitmentARB", typeof(dgtk.OpenGL.delegatesGLes.glTexPageCommitmentARB));
			}
			if (SuportedExt.Contains("glTexPageCommitmentEXT"))
			{
				dgtk.OpenGL.internalGLes.glTexPageCommitmentEXT = (dgtk.OpenGL.delegatesGLes.glTexPageCommitmentEXT) InternalTool.GetGLesMethodAdress("glTexPageCommitmentEXT", typeof(dgtk.OpenGL.delegatesGLes.glTexPageCommitmentEXT));
			}
			if (SuportedExt.Contains("glTexPageCommitmentMemNV"))
			{
				dgtk.OpenGL.internalGLes.glTexPageCommitmentMemNV = (dgtk.OpenGL.delegatesGLes.glTexPageCommitmentMemNV) InternalTool.GetGLesMethodAdress("glTexPageCommitmentMemNV", typeof(dgtk.OpenGL.delegatesGLes.glTexPageCommitmentMemNV));
			}
			if (SuportedExt.Contains("glTexParameterIivEXT"))
			{
				dgtk.OpenGL.internalGLes.glTexParameterIivEXT = (dgtk.OpenGL.delegatesGLes.glTexParameterIivEXT) InternalTool.GetGLesMethodAdress("glTexParameterIivEXT", typeof(dgtk.OpenGL.delegatesGLes.glTexParameterIivEXT));
			}
			if (SuportedExt.Contains("glTexParameterIivOES"))
			{
				dgtk.OpenGL.internalGLes.glTexParameterIivOES = (dgtk.OpenGL.delegatesGLes.glTexParameterIivOES) InternalTool.GetGLesMethodAdress("glTexParameterIivOES", typeof(dgtk.OpenGL.delegatesGLes.glTexParameterIivOES));
			}
			if (SuportedExt.Contains("glTexParameterIuivEXT"))
			{
				dgtk.OpenGL.internalGLes.glTexParameterIuivEXT = (dgtk.OpenGL.delegatesGLes.glTexParameterIuivEXT) InternalTool.GetGLesMethodAdress("glTexParameterIuivEXT", typeof(dgtk.OpenGL.delegatesGLes.glTexParameterIuivEXT));
			}
			if (SuportedExt.Contains("glTexParameterIuivOES"))
			{
				dgtk.OpenGL.internalGLes.glTexParameterIuivOES = (dgtk.OpenGL.delegatesGLes.glTexParameterIuivOES) InternalTool.GetGLesMethodAdress("glTexParameterIuivOES", typeof(dgtk.OpenGL.delegatesGLes.glTexParameterIuivOES));
			}
			if (SuportedExt.Contains("glTexParameterx"))
			{
				dgtk.OpenGL.internalGLes.glTexParameterx = (dgtk.OpenGL.delegatesGLes.glTexParameterx) InternalTool.GetGLesMethodAdress("glTexParameterx", typeof(dgtk.OpenGL.delegatesGLes.glTexParameterx));
			}
			if (SuportedExt.Contains("glTexParameterxOES"))
			{
				dgtk.OpenGL.internalGLes.glTexParameterxOES = (dgtk.OpenGL.delegatesGLes.glTexParameterxOES) InternalTool.GetGLesMethodAdress("glTexParameterxOES", typeof(dgtk.OpenGL.delegatesGLes.glTexParameterxOES));
			}
			if (SuportedExt.Contains("glTexParameterxv"))
			{
				dgtk.OpenGL.internalGLes.glTexParameterxv = (dgtk.OpenGL.delegatesGLes.glTexParameterxv) InternalTool.GetGLesMethodAdress("glTexParameterxv", typeof(dgtk.OpenGL.delegatesGLes.glTexParameterxv));
			}
			if (SuportedExt.Contains("glTexParameterxvOES"))
			{
				dgtk.OpenGL.internalGLes.glTexParameterxvOES = (dgtk.OpenGL.delegatesGLes.glTexParameterxvOES) InternalTool.GetGLesMethodAdress("glTexParameterxvOES", typeof(dgtk.OpenGL.delegatesGLes.glTexParameterxvOES));
			}
			if (SuportedExt.Contains("glTexRenderbufferNV"))
			{
				dgtk.OpenGL.internalGLes.glTexRenderbufferNV = (dgtk.OpenGL.delegatesGLes.glTexRenderbufferNV) InternalTool.GetGLesMethodAdress("glTexRenderbufferNV", typeof(dgtk.OpenGL.delegatesGLes.glTexRenderbufferNV));
			}
			if (SuportedExt.Contains("glTexStorage1DEXT"))
			{
				dgtk.OpenGL.internalGLes.glTexStorage1DEXT = (dgtk.OpenGL.delegatesGLes.glTexStorage1DEXT) InternalTool.GetGLesMethodAdress("glTexStorage1DEXT", typeof(dgtk.OpenGL.delegatesGLes.glTexStorage1DEXT));
			}
			if (SuportedExt.Contains("glTexStorage2DEXT"))
			{
				dgtk.OpenGL.internalGLes.glTexStorage2DEXT = (dgtk.OpenGL.delegatesGLes.glTexStorage2DEXT) InternalTool.GetGLesMethodAdress("glTexStorage2DEXT", typeof(dgtk.OpenGL.delegatesGLes.glTexStorage2DEXT));
			}
			if (SuportedExt.Contains("glTexStorage3DEXT"))
			{
				dgtk.OpenGL.internalGLes.glTexStorage3DEXT = (dgtk.OpenGL.delegatesGLes.glTexStorage3DEXT) InternalTool.GetGLesMethodAdress("glTexStorage3DEXT", typeof(dgtk.OpenGL.delegatesGLes.glTexStorage3DEXT));
			}
			if (SuportedExt.Contains("glTexStorage3DMultisampleOES"))
			{
				dgtk.OpenGL.internalGLes.glTexStorage3DMultisampleOES = (dgtk.OpenGL.delegatesGLes.glTexStorage3DMultisampleOES) InternalTool.GetGLesMethodAdress("glTexStorage3DMultisampleOES", typeof(dgtk.OpenGL.delegatesGLes.glTexStorage3DMultisampleOES));
			}
			if (SuportedExt.Contains("glTexStorageAttribs2DEXT"))
			{
				dgtk.OpenGL.internalGLes.glTexStorageAttribs2DEXT = (dgtk.OpenGL.delegatesGLes.glTexStorageAttribs2DEXT) InternalTool.GetGLesMethodAdress("glTexStorageAttribs2DEXT", typeof(dgtk.OpenGL.delegatesGLes.glTexStorageAttribs2DEXT));
			}
			if (SuportedExt.Contains("glTexStorageAttribs3DEXT"))
			{
				dgtk.OpenGL.internalGLes.glTexStorageAttribs3DEXT = (dgtk.OpenGL.delegatesGLes.glTexStorageAttribs3DEXT) InternalTool.GetGLesMethodAdress("glTexStorageAttribs3DEXT", typeof(dgtk.OpenGL.delegatesGLes.glTexStorageAttribs3DEXT));
			}
			if (SuportedExt.Contains("glTexStorageMem1DEXT"))
			{
				dgtk.OpenGL.internalGLes.glTexStorageMem1DEXT = (dgtk.OpenGL.delegatesGLes.glTexStorageMem1DEXT) InternalTool.GetGLesMethodAdress("glTexStorageMem1DEXT", typeof(dgtk.OpenGL.delegatesGLes.glTexStorageMem1DEXT));
			}
			if (SuportedExt.Contains("glTexStorageMem2DEXT"))
			{
				dgtk.OpenGL.internalGLes.glTexStorageMem2DEXT = (dgtk.OpenGL.delegatesGLes.glTexStorageMem2DEXT) InternalTool.GetGLesMethodAdress("glTexStorageMem2DEXT", typeof(dgtk.OpenGL.delegatesGLes.glTexStorageMem2DEXT));
			}
			if (SuportedExt.Contains("glTexStorageMem2DMultisampleEXT"))
			{
				dgtk.OpenGL.internalGLes.glTexStorageMem2DMultisampleEXT = (dgtk.OpenGL.delegatesGLes.glTexStorageMem2DMultisampleEXT) InternalTool.GetGLesMethodAdress("glTexStorageMem2DMultisampleEXT", typeof(dgtk.OpenGL.delegatesGLes.glTexStorageMem2DMultisampleEXT));
			}
			if (SuportedExt.Contains("glTexStorageMem3DEXT"))
			{
				dgtk.OpenGL.internalGLes.glTexStorageMem3DEXT = (dgtk.OpenGL.delegatesGLes.glTexStorageMem3DEXT) InternalTool.GetGLesMethodAdress("glTexStorageMem3DEXT", typeof(dgtk.OpenGL.delegatesGLes.glTexStorageMem3DEXT));
			}
			if (SuportedExt.Contains("glTexStorageMem3DMultisampleEXT"))
			{
				dgtk.OpenGL.internalGLes.glTexStorageMem3DMultisampleEXT = (dgtk.OpenGL.delegatesGLes.glTexStorageMem3DMultisampleEXT) InternalTool.GetGLesMethodAdress("glTexStorageMem3DMultisampleEXT", typeof(dgtk.OpenGL.delegatesGLes.glTexStorageMem3DMultisampleEXT));
			}
			if (SuportedExt.Contains("glTexStorageSparseAMD"))
			{
				dgtk.OpenGL.internalGLes.glTexStorageSparseAMD = (dgtk.OpenGL.delegatesGLes.glTexStorageSparseAMD) InternalTool.GetGLesMethodAdress("glTexStorageSparseAMD", typeof(dgtk.OpenGL.delegatesGLes.glTexStorageSparseAMD));
			}
			if (SuportedExt.Contains("glTexSubImage1DEXT"))
			{
				dgtk.OpenGL.internalGLes.glTexSubImage1DEXT = (dgtk.OpenGL.delegatesGLes.glTexSubImage1DEXT) InternalTool.GetGLesMethodAdress("glTexSubImage1DEXT", typeof(dgtk.OpenGL.delegatesGLes.glTexSubImage1DEXT));
			}
			if (SuportedExt.Contains("glTexSubImage2DEXT"))
			{
				dgtk.OpenGL.internalGLes.glTexSubImage2DEXT = (dgtk.OpenGL.delegatesGLes.glTexSubImage2DEXT) InternalTool.GetGLesMethodAdress("glTexSubImage2DEXT", typeof(dgtk.OpenGL.delegatesGLes.glTexSubImage2DEXT));
			}
			if (SuportedExt.Contains("glTexSubImage3DEXT"))
			{
				dgtk.OpenGL.internalGLes.glTexSubImage3DEXT = (dgtk.OpenGL.delegatesGLes.glTexSubImage3DEXT) InternalTool.GetGLesMethodAdress("glTexSubImage3DEXT", typeof(dgtk.OpenGL.delegatesGLes.glTexSubImage3DEXT));
			}
			if (SuportedExt.Contains("glTexSubImage3DOES"))
			{
				dgtk.OpenGL.internalGLes.glTexSubImage3DOES = (dgtk.OpenGL.delegatesGLes.glTexSubImage3DOES) InternalTool.GetGLesMethodAdress("glTexSubImage3DOES", typeof(dgtk.OpenGL.delegatesGLes.glTexSubImage3DOES));
			}
			if (SuportedExt.Contains("glTexSubImage4DSGIS"))
			{
				dgtk.OpenGL.internalGLes.glTexSubImage4DSGIS = (dgtk.OpenGL.delegatesGLes.glTexSubImage4DSGIS) InternalTool.GetGLesMethodAdress("glTexSubImage4DSGIS", typeof(dgtk.OpenGL.delegatesGLes.glTexSubImage4DSGIS));
			}
			if (SuportedExt.Contains("glTextureAttachMemoryNV"))
			{
				dgtk.OpenGL.internalGLes.glTextureAttachMemoryNV = (dgtk.OpenGL.delegatesGLes.glTextureAttachMemoryNV) InternalTool.GetGLesMethodAdress("glTextureAttachMemoryNV", typeof(dgtk.OpenGL.delegatesGLes.glTextureAttachMemoryNV));
			}
			if (SuportedExt.Contains("glTextureBarrierNV"))
			{
				dgtk.OpenGL.internalGLes.glTextureBarrierNV = (dgtk.OpenGL.delegatesGLes.glTextureBarrierNV) InternalTool.GetGLesMethodAdress("glTextureBarrierNV", typeof(dgtk.OpenGL.delegatesGLes.glTextureBarrierNV));
			}
			if (SuportedExt.Contains("glTextureBufferEXT"))
			{
				dgtk.OpenGL.internalGLes.glTextureBufferEXT = (dgtk.OpenGL.delegatesGLes.glTextureBufferEXT) InternalTool.GetGLesMethodAdress("glTextureBufferEXT", typeof(dgtk.OpenGL.delegatesGLes.glTextureBufferEXT));
			}
			if (SuportedExt.Contains("glTextureBufferRangeEXT"))
			{
				dgtk.OpenGL.internalGLes.glTextureBufferRangeEXT = (dgtk.OpenGL.delegatesGLes.glTextureBufferRangeEXT) InternalTool.GetGLesMethodAdress("glTextureBufferRangeEXT", typeof(dgtk.OpenGL.delegatesGLes.glTextureBufferRangeEXT));
			}
			if (SuportedExt.Contains("glTextureColorMaskSGIS"))
			{
				dgtk.OpenGL.internalGLes.glTextureColorMaskSGIS = (dgtk.OpenGL.delegatesGLes.glTextureColorMaskSGIS) InternalTool.GetGLesMethodAdress("glTextureColorMaskSGIS", typeof(dgtk.OpenGL.delegatesGLes.glTextureColorMaskSGIS));
			}
			if (SuportedExt.Contains("glTextureFoveationParametersQCOM"))
			{
				dgtk.OpenGL.internalGLes.glTextureFoveationParametersQCOM = (dgtk.OpenGL.delegatesGLes.glTextureFoveationParametersQCOM) InternalTool.GetGLesMethodAdress("glTextureFoveationParametersQCOM", typeof(dgtk.OpenGL.delegatesGLes.glTextureFoveationParametersQCOM));
			}
			if (SuportedExt.Contains("glTextureImage1DEXT"))
			{
				dgtk.OpenGL.internalGLes.glTextureImage1DEXT = (dgtk.OpenGL.delegatesGLes.glTextureImage1DEXT) InternalTool.GetGLesMethodAdress("glTextureImage1DEXT", typeof(dgtk.OpenGL.delegatesGLes.glTextureImage1DEXT));
			}
			if (SuportedExt.Contains("glTextureImage2DEXT"))
			{
				dgtk.OpenGL.internalGLes.glTextureImage2DEXT = (dgtk.OpenGL.delegatesGLes.glTextureImage2DEXT) InternalTool.GetGLesMethodAdress("glTextureImage2DEXT", typeof(dgtk.OpenGL.delegatesGLes.glTextureImage2DEXT));
			}
			if (SuportedExt.Contains("glTextureImage2DMultisampleCoverageNV"))
			{
				dgtk.OpenGL.internalGLes.glTextureImage2DMultisampleCoverageNV = (dgtk.OpenGL.delegatesGLes.glTextureImage2DMultisampleCoverageNV) InternalTool.GetGLesMethodAdress("glTextureImage2DMultisampleCoverageNV", typeof(dgtk.OpenGL.delegatesGLes.glTextureImage2DMultisampleCoverageNV));
			}
			if (SuportedExt.Contains("glTextureImage2DMultisampleNV"))
			{
				dgtk.OpenGL.internalGLes.glTextureImage2DMultisampleNV = (dgtk.OpenGL.delegatesGLes.glTextureImage2DMultisampleNV) InternalTool.GetGLesMethodAdress("glTextureImage2DMultisampleNV", typeof(dgtk.OpenGL.delegatesGLes.glTextureImage2DMultisampleNV));
			}
			if (SuportedExt.Contains("glTextureImage3DEXT"))
			{
				dgtk.OpenGL.internalGLes.glTextureImage3DEXT = (dgtk.OpenGL.delegatesGLes.glTextureImage3DEXT) InternalTool.GetGLesMethodAdress("glTextureImage3DEXT", typeof(dgtk.OpenGL.delegatesGLes.glTextureImage3DEXT));
			}
			if (SuportedExt.Contains("glTextureImage3DMultisampleCoverageNV"))
			{
				dgtk.OpenGL.internalGLes.glTextureImage3DMultisampleCoverageNV = (dgtk.OpenGL.delegatesGLes.glTextureImage3DMultisampleCoverageNV) InternalTool.GetGLesMethodAdress("glTextureImage3DMultisampleCoverageNV", typeof(dgtk.OpenGL.delegatesGLes.glTextureImage3DMultisampleCoverageNV));
			}
			if (SuportedExt.Contains("glTextureImage3DMultisampleNV"))
			{
				dgtk.OpenGL.internalGLes.glTextureImage3DMultisampleNV = (dgtk.OpenGL.delegatesGLes.glTextureImage3DMultisampleNV) InternalTool.GetGLesMethodAdress("glTextureImage3DMultisampleNV", typeof(dgtk.OpenGL.delegatesGLes.glTextureImage3DMultisampleNV));
			}
			if (SuportedExt.Contains("glTextureLightEXT"))
			{
				dgtk.OpenGL.internalGLes.glTextureLightEXT = (dgtk.OpenGL.delegatesGLes.glTextureLightEXT) InternalTool.GetGLesMethodAdress("glTextureLightEXT", typeof(dgtk.OpenGL.delegatesGLes.glTextureLightEXT));
			}
			if (SuportedExt.Contains("glTextureMaterialEXT"))
			{
				dgtk.OpenGL.internalGLes.glTextureMaterialEXT = (dgtk.OpenGL.delegatesGLes.glTextureMaterialEXT) InternalTool.GetGLesMethodAdress("glTextureMaterialEXT", typeof(dgtk.OpenGL.delegatesGLes.glTextureMaterialEXT));
			}
			if (SuportedExt.Contains("glTextureNormalEXT"))
			{
				dgtk.OpenGL.internalGLes.glTextureNormalEXT = (dgtk.OpenGL.delegatesGLes.glTextureNormalEXT) InternalTool.GetGLesMethodAdress("glTextureNormalEXT", typeof(dgtk.OpenGL.delegatesGLes.glTextureNormalEXT));
			}
			if (SuportedExt.Contains("glTexturePageCommitmentEXT"))
			{
				dgtk.OpenGL.internalGLes.glTexturePageCommitmentEXT = (dgtk.OpenGL.delegatesGLes.glTexturePageCommitmentEXT) InternalTool.GetGLesMethodAdress("glTexturePageCommitmentEXT", typeof(dgtk.OpenGL.delegatesGLes.glTexturePageCommitmentEXT));
			}
			if (SuportedExt.Contains("glTexturePageCommitmentMemNV"))
			{
				dgtk.OpenGL.internalGLes.glTexturePageCommitmentMemNV = (dgtk.OpenGL.delegatesGLes.glTexturePageCommitmentMemNV) InternalTool.GetGLesMethodAdress("glTexturePageCommitmentMemNV", typeof(dgtk.OpenGL.delegatesGLes.glTexturePageCommitmentMemNV));
			}
			if (SuportedExt.Contains("glTextureParameterfEXT"))
			{
				dgtk.OpenGL.internalGLes.glTextureParameterfEXT = (dgtk.OpenGL.delegatesGLes.glTextureParameterfEXT) InternalTool.GetGLesMethodAdress("glTextureParameterfEXT", typeof(dgtk.OpenGL.delegatesGLes.glTextureParameterfEXT));
			}
			if (SuportedExt.Contains("glTextureParameterfvEXT"))
			{
				dgtk.OpenGL.internalGLes.glTextureParameterfvEXT = (dgtk.OpenGL.delegatesGLes.glTextureParameterfvEXT) InternalTool.GetGLesMethodAdress("glTextureParameterfvEXT", typeof(dgtk.OpenGL.delegatesGLes.glTextureParameterfvEXT));
			}
			if (SuportedExt.Contains("glTextureParameteriEXT"))
			{
				dgtk.OpenGL.internalGLes.glTextureParameteriEXT = (dgtk.OpenGL.delegatesGLes.glTextureParameteriEXT) InternalTool.GetGLesMethodAdress("glTextureParameteriEXT", typeof(dgtk.OpenGL.delegatesGLes.glTextureParameteriEXT));
			}
			if (SuportedExt.Contains("glTextureParameterIivEXT"))
			{
				dgtk.OpenGL.internalGLes.glTextureParameterIivEXT = (dgtk.OpenGL.delegatesGLes.glTextureParameterIivEXT) InternalTool.GetGLesMethodAdress("glTextureParameterIivEXT", typeof(dgtk.OpenGL.delegatesGLes.glTextureParameterIivEXT));
			}
			if (SuportedExt.Contains("glTextureParameterIuivEXT"))
			{
				dgtk.OpenGL.internalGLes.glTextureParameterIuivEXT = (dgtk.OpenGL.delegatesGLes.glTextureParameterIuivEXT) InternalTool.GetGLesMethodAdress("glTextureParameterIuivEXT", typeof(dgtk.OpenGL.delegatesGLes.glTextureParameterIuivEXT));
			}
			if (SuportedExt.Contains("glTextureParameterivEXT"))
			{
				dgtk.OpenGL.internalGLes.glTextureParameterivEXT = (dgtk.OpenGL.delegatesGLes.glTextureParameterivEXT) InternalTool.GetGLesMethodAdress("glTextureParameterivEXT", typeof(dgtk.OpenGL.delegatesGLes.glTextureParameterivEXT));
			}
			if (SuportedExt.Contains("glTextureRangeAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glTextureRangeAPPLE = (dgtk.OpenGL.delegatesGLes.glTextureRangeAPPLE) InternalTool.GetGLesMethodAdress("glTextureRangeAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glTextureRangeAPPLE));
			}
			if (SuportedExt.Contains("glTextureRenderbufferEXT"))
			{
				dgtk.OpenGL.internalGLes.glTextureRenderbufferEXT = (dgtk.OpenGL.delegatesGLes.glTextureRenderbufferEXT) InternalTool.GetGLesMethodAdress("glTextureRenderbufferEXT", typeof(dgtk.OpenGL.delegatesGLes.glTextureRenderbufferEXT));
			}
			if (SuportedExt.Contains("glTextureStorage1DEXT"))
			{
				dgtk.OpenGL.internalGLes.glTextureStorage1DEXT = (dgtk.OpenGL.delegatesGLes.glTextureStorage1DEXT) InternalTool.GetGLesMethodAdress("glTextureStorage1DEXT", typeof(dgtk.OpenGL.delegatesGLes.glTextureStorage1DEXT));
			}
			if (SuportedExt.Contains("glTextureStorage2DEXT"))
			{
				dgtk.OpenGL.internalGLes.glTextureStorage2DEXT = (dgtk.OpenGL.delegatesGLes.glTextureStorage2DEXT) InternalTool.GetGLesMethodAdress("glTextureStorage2DEXT", typeof(dgtk.OpenGL.delegatesGLes.glTextureStorage2DEXT));
			}
			if (SuportedExt.Contains("glTextureStorage2DMultisampleEXT"))
			{
				dgtk.OpenGL.internalGLes.glTextureStorage2DMultisampleEXT = (dgtk.OpenGL.delegatesGLes.glTextureStorage2DMultisampleEXT) InternalTool.GetGLesMethodAdress("glTextureStorage2DMultisampleEXT", typeof(dgtk.OpenGL.delegatesGLes.glTextureStorage2DMultisampleEXT));
			}
			if (SuportedExt.Contains("glTextureStorage3DEXT"))
			{
				dgtk.OpenGL.internalGLes.glTextureStorage3DEXT = (dgtk.OpenGL.delegatesGLes.glTextureStorage3DEXT) InternalTool.GetGLesMethodAdress("glTextureStorage3DEXT", typeof(dgtk.OpenGL.delegatesGLes.glTextureStorage3DEXT));
			}
			if (SuportedExt.Contains("glTextureStorage3DMultisampleEXT"))
			{
				dgtk.OpenGL.internalGLes.glTextureStorage3DMultisampleEXT = (dgtk.OpenGL.delegatesGLes.glTextureStorage3DMultisampleEXT) InternalTool.GetGLesMethodAdress("glTextureStorage3DMultisampleEXT", typeof(dgtk.OpenGL.delegatesGLes.glTextureStorage3DMultisampleEXT));
			}
			if (SuportedExt.Contains("glTextureStorageMem1DEXT"))
			{
				dgtk.OpenGL.internalGLes.glTextureStorageMem1DEXT = (dgtk.OpenGL.delegatesGLes.glTextureStorageMem1DEXT) InternalTool.GetGLesMethodAdress("glTextureStorageMem1DEXT", typeof(dgtk.OpenGL.delegatesGLes.glTextureStorageMem1DEXT));
			}
			if (SuportedExt.Contains("glTextureStorageMem2DEXT"))
			{
				dgtk.OpenGL.internalGLes.glTextureStorageMem2DEXT = (dgtk.OpenGL.delegatesGLes.glTextureStorageMem2DEXT) InternalTool.GetGLesMethodAdress("glTextureStorageMem2DEXT", typeof(dgtk.OpenGL.delegatesGLes.glTextureStorageMem2DEXT));
			}
			if (SuportedExt.Contains("glTextureStorageMem2DMultisampleEXT"))
			{
				dgtk.OpenGL.internalGLes.glTextureStorageMem2DMultisampleEXT = (dgtk.OpenGL.delegatesGLes.glTextureStorageMem2DMultisampleEXT) InternalTool.GetGLesMethodAdress("glTextureStorageMem2DMultisampleEXT", typeof(dgtk.OpenGL.delegatesGLes.glTextureStorageMem2DMultisampleEXT));
			}
			if (SuportedExt.Contains("glTextureStorageMem3DEXT"))
			{
				dgtk.OpenGL.internalGLes.glTextureStorageMem3DEXT = (dgtk.OpenGL.delegatesGLes.glTextureStorageMem3DEXT) InternalTool.GetGLesMethodAdress("glTextureStorageMem3DEXT", typeof(dgtk.OpenGL.delegatesGLes.glTextureStorageMem3DEXT));
			}
			if (SuportedExt.Contains("glTextureStorageMem3DMultisampleEXT"))
			{
				dgtk.OpenGL.internalGLes.glTextureStorageMem3DMultisampleEXT = (dgtk.OpenGL.delegatesGLes.glTextureStorageMem3DMultisampleEXT) InternalTool.GetGLesMethodAdress("glTextureStorageMem3DMultisampleEXT", typeof(dgtk.OpenGL.delegatesGLes.glTextureStorageMem3DMultisampleEXT));
			}
			if (SuportedExt.Contains("glTextureStorageSparseAMD"))
			{
				dgtk.OpenGL.internalGLes.glTextureStorageSparseAMD = (dgtk.OpenGL.delegatesGLes.glTextureStorageSparseAMD) InternalTool.GetGLesMethodAdress("glTextureStorageSparseAMD", typeof(dgtk.OpenGL.delegatesGLes.glTextureStorageSparseAMD));
			}
			if (SuportedExt.Contains("glTextureSubImage1DEXT"))
			{
				dgtk.OpenGL.internalGLes.glTextureSubImage1DEXT = (dgtk.OpenGL.delegatesGLes.glTextureSubImage1DEXT) InternalTool.GetGLesMethodAdress("glTextureSubImage1DEXT", typeof(dgtk.OpenGL.delegatesGLes.glTextureSubImage1DEXT));
			}
			if (SuportedExt.Contains("glTextureSubImage2DEXT"))
			{
				dgtk.OpenGL.internalGLes.glTextureSubImage2DEXT = (dgtk.OpenGL.delegatesGLes.glTextureSubImage2DEXT) InternalTool.GetGLesMethodAdress("glTextureSubImage2DEXT", typeof(dgtk.OpenGL.delegatesGLes.glTextureSubImage2DEXT));
			}
			if (SuportedExt.Contains("glTextureSubImage3DEXT"))
			{
				dgtk.OpenGL.internalGLes.glTextureSubImage3DEXT = (dgtk.OpenGL.delegatesGLes.glTextureSubImage3DEXT) InternalTool.GetGLesMethodAdress("glTextureSubImage3DEXT", typeof(dgtk.OpenGL.delegatesGLes.glTextureSubImage3DEXT));
			}
			if (SuportedExt.Contains("glTextureViewEXT"))
			{
				dgtk.OpenGL.internalGLes.glTextureViewEXT = (dgtk.OpenGL.delegatesGLes.glTextureViewEXT) InternalTool.GetGLesMethodAdress("glTextureViewEXT", typeof(dgtk.OpenGL.delegatesGLes.glTextureViewEXT));
			}
			if (SuportedExt.Contains("glTextureViewOES"))
			{
				dgtk.OpenGL.internalGLes.glTextureViewOES = (dgtk.OpenGL.delegatesGLes.glTextureViewOES) InternalTool.GetGLesMethodAdress("glTextureViewOES", typeof(dgtk.OpenGL.delegatesGLes.glTextureViewOES));
			}
			if (SuportedExt.Contains("glTrackMatrixNV"))
			{
				dgtk.OpenGL.internalGLes.glTrackMatrixNV = (dgtk.OpenGL.delegatesGLes.glTrackMatrixNV) InternalTool.GetGLesMethodAdress("glTrackMatrixNV", typeof(dgtk.OpenGL.delegatesGLes.glTrackMatrixNV));
			}
			if (SuportedExt.Contains("glTransformFeedbackAttribsNV"))
			{
				dgtk.OpenGL.internalGLes.glTransformFeedbackAttribsNV = (dgtk.OpenGL.delegatesGLes.glTransformFeedbackAttribsNV) InternalTool.GetGLesMethodAdress("glTransformFeedbackAttribsNV", typeof(dgtk.OpenGL.delegatesGLes.glTransformFeedbackAttribsNV));
			}
			if (SuportedExt.Contains("glTransformFeedbackStreamAttribsNV"))
			{
				dgtk.OpenGL.internalGLes.glTransformFeedbackStreamAttribsNV = (dgtk.OpenGL.delegatesGLes.glTransformFeedbackStreamAttribsNV) InternalTool.GetGLesMethodAdress("glTransformFeedbackStreamAttribsNV", typeof(dgtk.OpenGL.delegatesGLes.glTransformFeedbackStreamAttribsNV));
			}
			if (SuportedExt.Contains("glTransformFeedbackVaryingsEXT"))
			{
				dgtk.OpenGL.internalGLes.glTransformFeedbackVaryingsEXT = (dgtk.OpenGL.delegatesGLes.glTransformFeedbackVaryingsEXT) InternalTool.GetGLesMethodAdress("glTransformFeedbackVaryingsEXT", typeof(dgtk.OpenGL.delegatesGLes.glTransformFeedbackVaryingsEXT));
			}
			if (SuportedExt.Contains("glTransformFeedbackVaryingsNV"))
			{
				dgtk.OpenGL.internalGLes.glTransformFeedbackVaryingsNV = (dgtk.OpenGL.delegatesGLes.glTransformFeedbackVaryingsNV) InternalTool.GetGLesMethodAdress("glTransformFeedbackVaryingsNV", typeof(dgtk.OpenGL.delegatesGLes.glTransformFeedbackVaryingsNV));
			}
			if (SuportedExt.Contains("glTransformPathNV"))
			{
				dgtk.OpenGL.internalGLes.glTransformPathNV = (dgtk.OpenGL.delegatesGLes.glTransformPathNV) InternalTool.GetGLesMethodAdress("glTransformPathNV", typeof(dgtk.OpenGL.delegatesGLes.glTransformPathNV));
			}
			if (SuportedExt.Contains("glTranslatex"))
			{
				dgtk.OpenGL.internalGLes.glTranslatex = (dgtk.OpenGL.delegatesGLes.glTranslatex) InternalTool.GetGLesMethodAdress("glTranslatex", typeof(dgtk.OpenGL.delegatesGLes.glTranslatex));
			}
			if (SuportedExt.Contains("glTranslatexOES"))
			{
				dgtk.OpenGL.internalGLes.glTranslatexOES = (dgtk.OpenGL.delegatesGLes.glTranslatexOES) InternalTool.GetGLesMethodAdress("glTranslatexOES", typeof(dgtk.OpenGL.delegatesGLes.glTranslatexOES));
			}
			#endregion

			#region U:

			if (SuportedExt.Contains("glUniform1fARB"))
			{
				dgtk.OpenGL.internalGLes.glUniform1fARB = (dgtk.OpenGL.delegatesGLes.glUniform1fARB) InternalTool.GetGLesMethodAdress("glUniform1fARB", typeof(dgtk.OpenGL.delegatesGLes.glUniform1fARB));
			}
			if (SuportedExt.Contains("glUniform1fvARB"))
			{
				dgtk.OpenGL.internalGLes.glUniform1fvARB = (dgtk.OpenGL.delegatesGLes.glUniform1fvARB) InternalTool.GetGLesMethodAdress("glUniform1fvARB", typeof(dgtk.OpenGL.delegatesGLes.glUniform1fvARB));
			}
			if (SuportedExt.Contains("glUniform1i64ARB"))
			{
				dgtk.OpenGL.internalGLes.glUniform1i64ARB = (dgtk.OpenGL.delegatesGLes.glUniform1i64ARB) InternalTool.GetGLesMethodAdress("glUniform1i64ARB", typeof(dgtk.OpenGL.delegatesGLes.glUniform1i64ARB));
			}
			if (SuportedExt.Contains("glUniform1i64NV"))
			{
				dgtk.OpenGL.internalGLes.glUniform1i64NV = (dgtk.OpenGL.delegatesGLes.glUniform1i64NV) InternalTool.GetGLesMethodAdress("glUniform1i64NV", typeof(dgtk.OpenGL.delegatesGLes.glUniform1i64NV));
			}
			if (SuportedExt.Contains("glUniform1i64vARB"))
			{
				dgtk.OpenGL.internalGLes.glUniform1i64vARB = (dgtk.OpenGL.delegatesGLes.glUniform1i64vARB) InternalTool.GetGLesMethodAdress("glUniform1i64vARB", typeof(dgtk.OpenGL.delegatesGLes.glUniform1i64vARB));
			}
			if (SuportedExt.Contains("glUniform1i64vNV"))
			{
				dgtk.OpenGL.internalGLes.glUniform1i64vNV = (dgtk.OpenGL.delegatesGLes.glUniform1i64vNV) InternalTool.GetGLesMethodAdress("glUniform1i64vNV", typeof(dgtk.OpenGL.delegatesGLes.glUniform1i64vNV));
			}
			if (SuportedExt.Contains("glUniform1iARB"))
			{
				dgtk.OpenGL.internalGLes.glUniform1iARB = (dgtk.OpenGL.delegatesGLes.glUniform1iARB) InternalTool.GetGLesMethodAdress("glUniform1iARB", typeof(dgtk.OpenGL.delegatesGLes.glUniform1iARB));
			}
			if (SuportedExt.Contains("glUniform1ivARB"))
			{
				dgtk.OpenGL.internalGLes.glUniform1ivARB = (dgtk.OpenGL.delegatesGLes.glUniform1ivARB) InternalTool.GetGLesMethodAdress("glUniform1ivARB", typeof(dgtk.OpenGL.delegatesGLes.glUniform1ivARB));
			}
			if (SuportedExt.Contains("glUniform1ui64ARB"))
			{
				dgtk.OpenGL.internalGLes.glUniform1ui64ARB = (dgtk.OpenGL.delegatesGLes.glUniform1ui64ARB) InternalTool.GetGLesMethodAdress("glUniform1ui64ARB", typeof(dgtk.OpenGL.delegatesGLes.glUniform1ui64ARB));
			}
			if (SuportedExt.Contains("glUniform1ui64NV"))
			{
				dgtk.OpenGL.internalGLes.glUniform1ui64NV = (dgtk.OpenGL.delegatesGLes.glUniform1ui64NV) InternalTool.GetGLesMethodAdress("glUniform1ui64NV", typeof(dgtk.OpenGL.delegatesGLes.glUniform1ui64NV));
			}
			if (SuportedExt.Contains("glUniform1ui64vARB"))
			{
				dgtk.OpenGL.internalGLes.glUniform1ui64vARB = (dgtk.OpenGL.delegatesGLes.glUniform1ui64vARB) InternalTool.GetGLesMethodAdress("glUniform1ui64vARB", typeof(dgtk.OpenGL.delegatesGLes.glUniform1ui64vARB));
			}
			if (SuportedExt.Contains("glUniform1ui64vNV"))
			{
				dgtk.OpenGL.internalGLes.glUniform1ui64vNV = (dgtk.OpenGL.delegatesGLes.glUniform1ui64vNV) InternalTool.GetGLesMethodAdress("glUniform1ui64vNV", typeof(dgtk.OpenGL.delegatesGLes.glUniform1ui64vNV));
			}
			if (SuportedExt.Contains("glUniform1uiEXT"))
			{
				dgtk.OpenGL.internalGLes.glUniform1uiEXT = (dgtk.OpenGL.delegatesGLes.glUniform1uiEXT) InternalTool.GetGLesMethodAdress("glUniform1uiEXT", typeof(dgtk.OpenGL.delegatesGLes.glUniform1uiEXT));
			}
			if (SuportedExt.Contains("glUniform1uivEXT"))
			{
				dgtk.OpenGL.internalGLes.glUniform1uivEXT = (dgtk.OpenGL.delegatesGLes.glUniform1uivEXT) InternalTool.GetGLesMethodAdress("glUniform1uivEXT", typeof(dgtk.OpenGL.delegatesGLes.glUniform1uivEXT));
			}
			if (SuportedExt.Contains("glUniform2fARB"))
			{
				dgtk.OpenGL.internalGLes.glUniform2fARB = (dgtk.OpenGL.delegatesGLes.glUniform2fARB) InternalTool.GetGLesMethodAdress("glUniform2fARB", typeof(dgtk.OpenGL.delegatesGLes.glUniform2fARB));
			}
			if (SuportedExt.Contains("glUniform2fvARB"))
			{
				dgtk.OpenGL.internalGLes.glUniform2fvARB = (dgtk.OpenGL.delegatesGLes.glUniform2fvARB) InternalTool.GetGLesMethodAdress("glUniform2fvARB", typeof(dgtk.OpenGL.delegatesGLes.glUniform2fvARB));
			}
			if (SuportedExt.Contains("glUniform2i64ARB"))
			{
				dgtk.OpenGL.internalGLes.glUniform2i64ARB = (dgtk.OpenGL.delegatesGLes.glUniform2i64ARB) InternalTool.GetGLesMethodAdress("glUniform2i64ARB", typeof(dgtk.OpenGL.delegatesGLes.glUniform2i64ARB));
			}
			if (SuportedExt.Contains("glUniform2i64NV"))
			{
				dgtk.OpenGL.internalGLes.glUniform2i64NV = (dgtk.OpenGL.delegatesGLes.glUniform2i64NV) InternalTool.GetGLesMethodAdress("glUniform2i64NV", typeof(dgtk.OpenGL.delegatesGLes.glUniform2i64NV));
			}
			if (SuportedExt.Contains("glUniform2i64vARB"))
			{
				dgtk.OpenGL.internalGLes.glUniform2i64vARB = (dgtk.OpenGL.delegatesGLes.glUniform2i64vARB) InternalTool.GetGLesMethodAdress("glUniform2i64vARB", typeof(dgtk.OpenGL.delegatesGLes.glUniform2i64vARB));
			}
			if (SuportedExt.Contains("glUniform2i64vNV"))
			{
				dgtk.OpenGL.internalGLes.glUniform2i64vNV = (dgtk.OpenGL.delegatesGLes.glUniform2i64vNV) InternalTool.GetGLesMethodAdress("glUniform2i64vNV", typeof(dgtk.OpenGL.delegatesGLes.glUniform2i64vNV));
			}
			if (SuportedExt.Contains("glUniform2iARB"))
			{
				dgtk.OpenGL.internalGLes.glUniform2iARB = (dgtk.OpenGL.delegatesGLes.glUniform2iARB) InternalTool.GetGLesMethodAdress("glUniform2iARB", typeof(dgtk.OpenGL.delegatesGLes.glUniform2iARB));
			}
			if (SuportedExt.Contains("glUniform2ivARB"))
			{
				dgtk.OpenGL.internalGLes.glUniform2ivARB = (dgtk.OpenGL.delegatesGLes.glUniform2ivARB) InternalTool.GetGLesMethodAdress("glUniform2ivARB", typeof(dgtk.OpenGL.delegatesGLes.glUniform2ivARB));
			}
			if (SuportedExt.Contains("glUniform2ui64ARB"))
			{
				dgtk.OpenGL.internalGLes.glUniform2ui64ARB = (dgtk.OpenGL.delegatesGLes.glUniform2ui64ARB) InternalTool.GetGLesMethodAdress("glUniform2ui64ARB", typeof(dgtk.OpenGL.delegatesGLes.glUniform2ui64ARB));
			}
			if (SuportedExt.Contains("glUniform2ui64NV"))
			{
				dgtk.OpenGL.internalGLes.glUniform2ui64NV = (dgtk.OpenGL.delegatesGLes.glUniform2ui64NV) InternalTool.GetGLesMethodAdress("glUniform2ui64NV", typeof(dgtk.OpenGL.delegatesGLes.glUniform2ui64NV));
			}
			if (SuportedExt.Contains("glUniform2ui64vARB"))
			{
				dgtk.OpenGL.internalGLes.glUniform2ui64vARB = (dgtk.OpenGL.delegatesGLes.glUniform2ui64vARB) InternalTool.GetGLesMethodAdress("glUniform2ui64vARB", typeof(dgtk.OpenGL.delegatesGLes.glUniform2ui64vARB));
			}
			if (SuportedExt.Contains("glUniform2ui64vNV"))
			{
				dgtk.OpenGL.internalGLes.glUniform2ui64vNV = (dgtk.OpenGL.delegatesGLes.glUniform2ui64vNV) InternalTool.GetGLesMethodAdress("glUniform2ui64vNV", typeof(dgtk.OpenGL.delegatesGLes.glUniform2ui64vNV));
			}
			if (SuportedExt.Contains("glUniform2uiEXT"))
			{
				dgtk.OpenGL.internalGLes.glUniform2uiEXT = (dgtk.OpenGL.delegatesGLes.glUniform2uiEXT) InternalTool.GetGLesMethodAdress("glUniform2uiEXT", typeof(dgtk.OpenGL.delegatesGLes.glUniform2uiEXT));
			}
			if (SuportedExt.Contains("glUniform2uivEXT"))
			{
				dgtk.OpenGL.internalGLes.glUniform2uivEXT = (dgtk.OpenGL.delegatesGLes.glUniform2uivEXT) InternalTool.GetGLesMethodAdress("glUniform2uivEXT", typeof(dgtk.OpenGL.delegatesGLes.glUniform2uivEXT));
			}
			if (SuportedExt.Contains("glUniform3fARB"))
			{
				dgtk.OpenGL.internalGLes.glUniform3fARB = (dgtk.OpenGL.delegatesGLes.glUniform3fARB) InternalTool.GetGLesMethodAdress("glUniform3fARB", typeof(dgtk.OpenGL.delegatesGLes.glUniform3fARB));
			}
			if (SuportedExt.Contains("glUniform3fvARB"))
			{
				dgtk.OpenGL.internalGLes.glUniform3fvARB = (dgtk.OpenGL.delegatesGLes.glUniform3fvARB) InternalTool.GetGLesMethodAdress("glUniform3fvARB", typeof(dgtk.OpenGL.delegatesGLes.glUniform3fvARB));
			}
			if (SuportedExt.Contains("glUniform3i64ARB"))
			{
				dgtk.OpenGL.internalGLes.glUniform3i64ARB = (dgtk.OpenGL.delegatesGLes.glUniform3i64ARB) InternalTool.GetGLesMethodAdress("glUniform3i64ARB", typeof(dgtk.OpenGL.delegatesGLes.glUniform3i64ARB));
			}
			if (SuportedExt.Contains("glUniform3i64NV"))
			{
				dgtk.OpenGL.internalGLes.glUniform3i64NV = (dgtk.OpenGL.delegatesGLes.glUniform3i64NV) InternalTool.GetGLesMethodAdress("glUniform3i64NV", typeof(dgtk.OpenGL.delegatesGLes.glUniform3i64NV));
			}
			if (SuportedExt.Contains("glUniform3i64vARB"))
			{
				dgtk.OpenGL.internalGLes.glUniform3i64vARB = (dgtk.OpenGL.delegatesGLes.glUniform3i64vARB) InternalTool.GetGLesMethodAdress("glUniform3i64vARB", typeof(dgtk.OpenGL.delegatesGLes.glUniform3i64vARB));
			}
			if (SuportedExt.Contains("glUniform3i64vNV"))
			{
				dgtk.OpenGL.internalGLes.glUniform3i64vNV = (dgtk.OpenGL.delegatesGLes.glUniform3i64vNV) InternalTool.GetGLesMethodAdress("glUniform3i64vNV", typeof(dgtk.OpenGL.delegatesGLes.glUniform3i64vNV));
			}
			if (SuportedExt.Contains("glUniform3iARB"))
			{
				dgtk.OpenGL.internalGLes.glUniform3iARB = (dgtk.OpenGL.delegatesGLes.glUniform3iARB) InternalTool.GetGLesMethodAdress("glUniform3iARB", typeof(dgtk.OpenGL.delegatesGLes.glUniform3iARB));
			}
			if (SuportedExt.Contains("glUniform3ivARB"))
			{
				dgtk.OpenGL.internalGLes.glUniform3ivARB = (dgtk.OpenGL.delegatesGLes.glUniform3ivARB) InternalTool.GetGLesMethodAdress("glUniform3ivARB", typeof(dgtk.OpenGL.delegatesGLes.glUniform3ivARB));
			}
			if (SuportedExt.Contains("glUniform3ui64ARB"))
			{
				dgtk.OpenGL.internalGLes.glUniform3ui64ARB = (dgtk.OpenGL.delegatesGLes.glUniform3ui64ARB) InternalTool.GetGLesMethodAdress("glUniform3ui64ARB", typeof(dgtk.OpenGL.delegatesGLes.glUniform3ui64ARB));
			}
			if (SuportedExt.Contains("glUniform3ui64NV"))
			{
				dgtk.OpenGL.internalGLes.glUniform3ui64NV = (dgtk.OpenGL.delegatesGLes.glUniform3ui64NV) InternalTool.GetGLesMethodAdress("glUniform3ui64NV", typeof(dgtk.OpenGL.delegatesGLes.glUniform3ui64NV));
			}
			if (SuportedExt.Contains("glUniform3ui64vARB"))
			{
				dgtk.OpenGL.internalGLes.glUniform3ui64vARB = (dgtk.OpenGL.delegatesGLes.glUniform3ui64vARB) InternalTool.GetGLesMethodAdress("glUniform3ui64vARB", typeof(dgtk.OpenGL.delegatesGLes.glUniform3ui64vARB));
			}
			if (SuportedExt.Contains("glUniform3ui64vNV"))
			{
				dgtk.OpenGL.internalGLes.glUniform3ui64vNV = (dgtk.OpenGL.delegatesGLes.glUniform3ui64vNV) InternalTool.GetGLesMethodAdress("glUniform3ui64vNV", typeof(dgtk.OpenGL.delegatesGLes.glUniform3ui64vNV));
			}
			if (SuportedExt.Contains("glUniform3uiEXT"))
			{
				dgtk.OpenGL.internalGLes.glUniform3uiEXT = (dgtk.OpenGL.delegatesGLes.glUniform3uiEXT) InternalTool.GetGLesMethodAdress("glUniform3uiEXT", typeof(dgtk.OpenGL.delegatesGLes.glUniform3uiEXT));
			}
			if (SuportedExt.Contains("glUniform3uivEXT"))
			{
				dgtk.OpenGL.internalGLes.glUniform3uivEXT = (dgtk.OpenGL.delegatesGLes.glUniform3uivEXT) InternalTool.GetGLesMethodAdress("glUniform3uivEXT", typeof(dgtk.OpenGL.delegatesGLes.glUniform3uivEXT));
			}
			if (SuportedExt.Contains("glUniform4fARB"))
			{
				dgtk.OpenGL.internalGLes.glUniform4fARB = (dgtk.OpenGL.delegatesGLes.glUniform4fARB) InternalTool.GetGLesMethodAdress("glUniform4fARB", typeof(dgtk.OpenGL.delegatesGLes.glUniform4fARB));
			}
			if (SuportedExt.Contains("glUniform4fvARB"))
			{
				dgtk.OpenGL.internalGLes.glUniform4fvARB = (dgtk.OpenGL.delegatesGLes.glUniform4fvARB) InternalTool.GetGLesMethodAdress("glUniform4fvARB", typeof(dgtk.OpenGL.delegatesGLes.glUniform4fvARB));
			}
			if (SuportedExt.Contains("glUniform4i64ARB"))
			{
				dgtk.OpenGL.internalGLes.glUniform4i64ARB = (dgtk.OpenGL.delegatesGLes.glUniform4i64ARB) InternalTool.GetGLesMethodAdress("glUniform4i64ARB", typeof(dgtk.OpenGL.delegatesGLes.glUniform4i64ARB));
			}
			if (SuportedExt.Contains("glUniform4i64NV"))
			{
				dgtk.OpenGL.internalGLes.glUniform4i64NV = (dgtk.OpenGL.delegatesGLes.glUniform4i64NV) InternalTool.GetGLesMethodAdress("glUniform4i64NV", typeof(dgtk.OpenGL.delegatesGLes.glUniform4i64NV));
			}
			if (SuportedExt.Contains("glUniform4i64vARB"))
			{
				dgtk.OpenGL.internalGLes.glUniform4i64vARB = (dgtk.OpenGL.delegatesGLes.glUniform4i64vARB) InternalTool.GetGLesMethodAdress("glUniform4i64vARB", typeof(dgtk.OpenGL.delegatesGLes.glUniform4i64vARB));
			}
			if (SuportedExt.Contains("glUniform4i64vNV"))
			{
				dgtk.OpenGL.internalGLes.glUniform4i64vNV = (dgtk.OpenGL.delegatesGLes.glUniform4i64vNV) InternalTool.GetGLesMethodAdress("glUniform4i64vNV", typeof(dgtk.OpenGL.delegatesGLes.glUniform4i64vNV));
			}
			if (SuportedExt.Contains("glUniform4iARB"))
			{
				dgtk.OpenGL.internalGLes.glUniform4iARB = (dgtk.OpenGL.delegatesGLes.glUniform4iARB) InternalTool.GetGLesMethodAdress("glUniform4iARB", typeof(dgtk.OpenGL.delegatesGLes.glUniform4iARB));
			}
			if (SuportedExt.Contains("glUniform4ivARB"))
			{
				dgtk.OpenGL.internalGLes.glUniform4ivARB = (dgtk.OpenGL.delegatesGLes.glUniform4ivARB) InternalTool.GetGLesMethodAdress("glUniform4ivARB", typeof(dgtk.OpenGL.delegatesGLes.glUniform4ivARB));
			}
			if (SuportedExt.Contains("glUniform4ui64ARB"))
			{
				dgtk.OpenGL.internalGLes.glUniform4ui64ARB = (dgtk.OpenGL.delegatesGLes.glUniform4ui64ARB) InternalTool.GetGLesMethodAdress("glUniform4ui64ARB", typeof(dgtk.OpenGL.delegatesGLes.glUniform4ui64ARB));
			}
			if (SuportedExt.Contains("glUniform4ui64NV"))
			{
				dgtk.OpenGL.internalGLes.glUniform4ui64NV = (dgtk.OpenGL.delegatesGLes.glUniform4ui64NV) InternalTool.GetGLesMethodAdress("glUniform4ui64NV", typeof(dgtk.OpenGL.delegatesGLes.glUniform4ui64NV));
			}
			if (SuportedExt.Contains("glUniform4ui64vARB"))
			{
				dgtk.OpenGL.internalGLes.glUniform4ui64vARB = (dgtk.OpenGL.delegatesGLes.glUniform4ui64vARB) InternalTool.GetGLesMethodAdress("glUniform4ui64vARB", typeof(dgtk.OpenGL.delegatesGLes.glUniform4ui64vARB));
			}
			if (SuportedExt.Contains("glUniform4ui64vNV"))
			{
				dgtk.OpenGL.internalGLes.glUniform4ui64vNV = (dgtk.OpenGL.delegatesGLes.glUniform4ui64vNV) InternalTool.GetGLesMethodAdress("glUniform4ui64vNV", typeof(dgtk.OpenGL.delegatesGLes.glUniform4ui64vNV));
			}
			if (SuportedExt.Contains("glUniform4uiEXT"))
			{
				dgtk.OpenGL.internalGLes.glUniform4uiEXT = (dgtk.OpenGL.delegatesGLes.glUniform4uiEXT) InternalTool.GetGLesMethodAdress("glUniform4uiEXT", typeof(dgtk.OpenGL.delegatesGLes.glUniform4uiEXT));
			}
			if (SuportedExt.Contains("glUniform4uivEXT"))
			{
				dgtk.OpenGL.internalGLes.glUniform4uivEXT = (dgtk.OpenGL.delegatesGLes.glUniform4uivEXT) InternalTool.GetGLesMethodAdress("glUniform4uivEXT", typeof(dgtk.OpenGL.delegatesGLes.glUniform4uivEXT));
			}
			if (SuportedExt.Contains("glUniformBufferEXT"))
			{
				dgtk.OpenGL.internalGLes.glUniformBufferEXT = (dgtk.OpenGL.delegatesGLes.glUniformBufferEXT) InternalTool.GetGLesMethodAdress("glUniformBufferEXT", typeof(dgtk.OpenGL.delegatesGLes.glUniformBufferEXT));
			}
			if (SuportedExt.Contains("glUniformHandleui64ARB"))
			{
				dgtk.OpenGL.internalGLes.glUniformHandleui64ARB = (dgtk.OpenGL.delegatesGLes.glUniformHandleui64ARB) InternalTool.GetGLesMethodAdress("glUniformHandleui64ARB", typeof(dgtk.OpenGL.delegatesGLes.glUniformHandleui64ARB));
			}
			if (SuportedExt.Contains("glUniformHandleui64IMG"))
			{
				dgtk.OpenGL.internalGLes.glUniformHandleui64IMG = (dgtk.OpenGL.delegatesGLes.glUniformHandleui64IMG) InternalTool.GetGLesMethodAdress("glUniformHandleui64IMG", typeof(dgtk.OpenGL.delegatesGLes.glUniformHandleui64IMG));
			}
			if (SuportedExt.Contains("glUniformHandleui64NV"))
			{
				dgtk.OpenGL.internalGLes.glUniformHandleui64NV = (dgtk.OpenGL.delegatesGLes.glUniformHandleui64NV) InternalTool.GetGLesMethodAdress("glUniformHandleui64NV", typeof(dgtk.OpenGL.delegatesGLes.glUniformHandleui64NV));
			}
			if (SuportedExt.Contains("glUniformHandleui64vARB"))
			{
				dgtk.OpenGL.internalGLes.glUniformHandleui64vARB = (dgtk.OpenGL.delegatesGLes.glUniformHandleui64vARB) InternalTool.GetGLesMethodAdress("glUniformHandleui64vARB", typeof(dgtk.OpenGL.delegatesGLes.glUniformHandleui64vARB));
			}
			if (SuportedExt.Contains("glUniformHandleui64vIMG"))
			{
				dgtk.OpenGL.internalGLes.glUniformHandleui64vIMG = (dgtk.OpenGL.delegatesGLes.glUniformHandleui64vIMG) InternalTool.GetGLesMethodAdress("glUniformHandleui64vIMG", typeof(dgtk.OpenGL.delegatesGLes.glUniformHandleui64vIMG));
			}
			if (SuportedExt.Contains("glUniformHandleui64vNV"))
			{
				dgtk.OpenGL.internalGLes.glUniformHandleui64vNV = (dgtk.OpenGL.delegatesGLes.glUniformHandleui64vNV) InternalTool.GetGLesMethodAdress("glUniformHandleui64vNV", typeof(dgtk.OpenGL.delegatesGLes.glUniformHandleui64vNV));
			}
			if (SuportedExt.Contains("glUniformMatrix2fvARB"))
			{
				dgtk.OpenGL.internalGLes.glUniformMatrix2fvARB = (dgtk.OpenGL.delegatesGLes.glUniformMatrix2fvARB) InternalTool.GetGLesMethodAdress("glUniformMatrix2fvARB", typeof(dgtk.OpenGL.delegatesGLes.glUniformMatrix2fvARB));
			}
			if (SuportedExt.Contains("glUniformMatrix2x3fvNV"))
			{
				dgtk.OpenGL.internalGLes.glUniformMatrix2x3fvNV = (dgtk.OpenGL.delegatesGLes.glUniformMatrix2x3fvNV) InternalTool.GetGLesMethodAdress("glUniformMatrix2x3fvNV", typeof(dgtk.OpenGL.delegatesGLes.glUniformMatrix2x3fvNV));
			}
			if (SuportedExt.Contains("glUniformMatrix2x4fvNV"))
			{
				dgtk.OpenGL.internalGLes.glUniformMatrix2x4fvNV = (dgtk.OpenGL.delegatesGLes.glUniformMatrix2x4fvNV) InternalTool.GetGLesMethodAdress("glUniformMatrix2x4fvNV", typeof(dgtk.OpenGL.delegatesGLes.glUniformMatrix2x4fvNV));
			}
			if (SuportedExt.Contains("glUniformMatrix3fvARB"))
			{
				dgtk.OpenGL.internalGLes.glUniformMatrix3fvARB = (dgtk.OpenGL.delegatesGLes.glUniformMatrix3fvARB) InternalTool.GetGLesMethodAdress("glUniformMatrix3fvARB", typeof(dgtk.OpenGL.delegatesGLes.glUniformMatrix3fvARB));
			}
			if (SuportedExt.Contains("glUniformMatrix3x2fvNV"))
			{
				dgtk.OpenGL.internalGLes.glUniformMatrix3x2fvNV = (dgtk.OpenGL.delegatesGLes.glUniformMatrix3x2fvNV) InternalTool.GetGLesMethodAdress("glUniformMatrix3x2fvNV", typeof(dgtk.OpenGL.delegatesGLes.glUniformMatrix3x2fvNV));
			}
			if (SuportedExt.Contains("glUniformMatrix3x4fvNV"))
			{
				dgtk.OpenGL.internalGLes.glUniformMatrix3x4fvNV = (dgtk.OpenGL.delegatesGLes.glUniformMatrix3x4fvNV) InternalTool.GetGLesMethodAdress("glUniformMatrix3x4fvNV", typeof(dgtk.OpenGL.delegatesGLes.glUniformMatrix3x4fvNV));
			}
			if (SuportedExt.Contains("glUniformMatrix4fvARB"))
			{
				dgtk.OpenGL.internalGLes.glUniformMatrix4fvARB = (dgtk.OpenGL.delegatesGLes.glUniformMatrix4fvARB) InternalTool.GetGLesMethodAdress("glUniformMatrix4fvARB", typeof(dgtk.OpenGL.delegatesGLes.glUniformMatrix4fvARB));
			}
			if (SuportedExt.Contains("glUniformMatrix4x2fvNV"))
			{
				dgtk.OpenGL.internalGLes.glUniformMatrix4x2fvNV = (dgtk.OpenGL.delegatesGLes.glUniformMatrix4x2fvNV) InternalTool.GetGLesMethodAdress("glUniformMatrix4x2fvNV", typeof(dgtk.OpenGL.delegatesGLes.glUniformMatrix4x2fvNV));
			}
			if (SuportedExt.Contains("glUniformMatrix4x3fvNV"))
			{
				dgtk.OpenGL.internalGLes.glUniformMatrix4x3fvNV = (dgtk.OpenGL.delegatesGLes.glUniformMatrix4x3fvNV) InternalTool.GetGLesMethodAdress("glUniformMatrix4x3fvNV", typeof(dgtk.OpenGL.delegatesGLes.glUniformMatrix4x3fvNV));
			}
			if (SuportedExt.Contains("glUniformui64NV"))
			{
				dgtk.OpenGL.internalGLes.glUniformui64NV = (dgtk.OpenGL.delegatesGLes.glUniformui64NV) InternalTool.GetGLesMethodAdress("glUniformui64NV", typeof(dgtk.OpenGL.delegatesGLes.glUniformui64NV));
			}
			if (SuportedExt.Contains("glUniformui64vNV"))
			{
				dgtk.OpenGL.internalGLes.glUniformui64vNV = (dgtk.OpenGL.delegatesGLes.glUniformui64vNV) InternalTool.GetGLesMethodAdress("glUniformui64vNV", typeof(dgtk.OpenGL.delegatesGLes.glUniformui64vNV));
			}
			if (SuportedExt.Contains("glUnlockArraysEXT"))
			{
				dgtk.OpenGL.internalGLes.glUnlockArraysEXT = (dgtk.OpenGL.delegatesGLes.glUnlockArraysEXT) InternalTool.GetGLesMethodAdress("glUnlockArraysEXT", typeof(dgtk.OpenGL.delegatesGLes.glUnlockArraysEXT));
			}
			if (SuportedExt.Contains("glUnmapBufferARB"))
			{
				dgtk.OpenGL.internalGLes.glUnmapBufferARB = (dgtk.OpenGL.delegatesGLes.glUnmapBufferARB) InternalTool.GetGLesMethodAdress("glUnmapBufferARB", typeof(dgtk.OpenGL.delegatesGLes.glUnmapBufferARB));
			}
			if (SuportedExt.Contains("glUnmapBufferOES"))
			{
				dgtk.OpenGL.internalGLes.glUnmapBufferOES = (dgtk.OpenGL.delegatesGLes.glUnmapBufferOES) InternalTool.GetGLesMethodAdress("glUnmapBufferOES", typeof(dgtk.OpenGL.delegatesGLes.glUnmapBufferOES));
			}
			if (SuportedExt.Contains("glUnmapNamedBufferEXT"))
			{
				dgtk.OpenGL.internalGLes.glUnmapNamedBufferEXT = (dgtk.OpenGL.delegatesGLes.glUnmapNamedBufferEXT) InternalTool.GetGLesMethodAdress("glUnmapNamedBufferEXT", typeof(dgtk.OpenGL.delegatesGLes.glUnmapNamedBufferEXT));
			}
			if (SuportedExt.Contains("glUnmapObjectBufferATI"))
			{
				dgtk.OpenGL.internalGLes.glUnmapObjectBufferATI = (dgtk.OpenGL.delegatesGLes.glUnmapObjectBufferATI) InternalTool.GetGLesMethodAdress("glUnmapObjectBufferATI", typeof(dgtk.OpenGL.delegatesGLes.glUnmapObjectBufferATI));
			}
			if (SuportedExt.Contains("glUnmapTexture2DINTEL"))
			{
				dgtk.OpenGL.internalGLes.glUnmapTexture2DINTEL = (dgtk.OpenGL.delegatesGLes.glUnmapTexture2DINTEL) InternalTool.GetGLesMethodAdress("glUnmapTexture2DINTEL", typeof(dgtk.OpenGL.delegatesGLes.glUnmapTexture2DINTEL));
			}
			if (SuportedExt.Contains("glUpdateObjectBufferATI"))
			{
				dgtk.OpenGL.internalGLes.glUpdateObjectBufferATI = (dgtk.OpenGL.delegatesGLes.glUpdateObjectBufferATI) InternalTool.GetGLesMethodAdress("glUpdateObjectBufferATI", typeof(dgtk.OpenGL.delegatesGLes.glUpdateObjectBufferATI));
			}
			if (SuportedExt.Contains("glUploadGpuMaskNVX"))
			{
				dgtk.OpenGL.internalGLes.glUploadGpuMaskNVX = (dgtk.OpenGL.delegatesGLes.glUploadGpuMaskNVX) InternalTool.GetGLesMethodAdress("glUploadGpuMaskNVX", typeof(dgtk.OpenGL.delegatesGLes.glUploadGpuMaskNVX));
			}
			if (SuportedExt.Contains("glUseProgramObjectARB"))
			{
				dgtk.OpenGL.internalGLes.glUseProgramObjectARB = (dgtk.OpenGL.delegatesGLes.glUseProgramObjectARB) InternalTool.GetGLesMethodAdress("glUseProgramObjectARB", typeof(dgtk.OpenGL.delegatesGLes.glUseProgramObjectARB));
			}
			if (SuportedExt.Contains("glUseProgramStagesEXT"))
			{
				dgtk.OpenGL.internalGLes.glUseProgramStagesEXT = (dgtk.OpenGL.delegatesGLes.glUseProgramStagesEXT) InternalTool.GetGLesMethodAdress("glUseProgramStagesEXT", typeof(dgtk.OpenGL.delegatesGLes.glUseProgramStagesEXT));
			}
			if (SuportedExt.Contains("glUseShaderProgramEXT"))
			{
				dgtk.OpenGL.internalGLes.glUseShaderProgramEXT = (dgtk.OpenGL.delegatesGLes.glUseShaderProgramEXT) InternalTool.GetGLesMethodAdress("glUseShaderProgramEXT", typeof(dgtk.OpenGL.delegatesGLes.glUseShaderProgramEXT));
			}
			#endregion

			#region V:

			if (SuportedExt.Contains("glValidateProgramARB"))
			{
				dgtk.OpenGL.internalGLes.glValidateProgramARB = (dgtk.OpenGL.delegatesGLes.glValidateProgramARB) InternalTool.GetGLesMethodAdress("glValidateProgramARB", typeof(dgtk.OpenGL.delegatesGLes.glValidateProgramARB));
			}
			if (SuportedExt.Contains("glValidateProgramPipelineEXT"))
			{
				dgtk.OpenGL.internalGLes.glValidateProgramPipelineEXT = (dgtk.OpenGL.delegatesGLes.glValidateProgramPipelineEXT) InternalTool.GetGLesMethodAdress("glValidateProgramPipelineEXT", typeof(dgtk.OpenGL.delegatesGLes.glValidateProgramPipelineEXT));
			}
			if (SuportedExt.Contains("glVariantArrayObjectATI"))
			{
				dgtk.OpenGL.internalGLes.glVariantArrayObjectATI = (dgtk.OpenGL.delegatesGLes.glVariantArrayObjectATI) InternalTool.GetGLesMethodAdress("glVariantArrayObjectATI", typeof(dgtk.OpenGL.delegatesGLes.glVariantArrayObjectATI));
			}
			if (SuportedExt.Contains("glVariantbvEXT"))
			{
				dgtk.OpenGL.internalGLes.glVariantbvEXT = (dgtk.OpenGL.delegatesGLes.glVariantbvEXT) InternalTool.GetGLesMethodAdress("glVariantbvEXT", typeof(dgtk.OpenGL.delegatesGLes.glVariantbvEXT));
			}
			if (SuportedExt.Contains("glVariantdvEXT"))
			{
				dgtk.OpenGL.internalGLes.glVariantdvEXT = (dgtk.OpenGL.delegatesGLes.glVariantdvEXT) InternalTool.GetGLesMethodAdress("glVariantdvEXT", typeof(dgtk.OpenGL.delegatesGLes.glVariantdvEXT));
			}
			if (SuportedExt.Contains("glVariantfvEXT"))
			{
				dgtk.OpenGL.internalGLes.glVariantfvEXT = (dgtk.OpenGL.delegatesGLes.glVariantfvEXT) InternalTool.GetGLesMethodAdress("glVariantfvEXT", typeof(dgtk.OpenGL.delegatesGLes.glVariantfvEXT));
			}
			if (SuportedExt.Contains("glVariantivEXT"))
			{
				dgtk.OpenGL.internalGLes.glVariantivEXT = (dgtk.OpenGL.delegatesGLes.glVariantivEXT) InternalTool.GetGLesMethodAdress("glVariantivEXT", typeof(dgtk.OpenGL.delegatesGLes.glVariantivEXT));
			}
			if (SuportedExt.Contains("glVariantPointerEXT"))
			{
				dgtk.OpenGL.internalGLes.glVariantPointerEXT = (dgtk.OpenGL.delegatesGLes.glVariantPointerEXT) InternalTool.GetGLesMethodAdress("glVariantPointerEXT", typeof(dgtk.OpenGL.delegatesGLes.glVariantPointerEXT));
			}
			if (SuportedExt.Contains("glVariantsvEXT"))
			{
				dgtk.OpenGL.internalGLes.glVariantsvEXT = (dgtk.OpenGL.delegatesGLes.glVariantsvEXT) InternalTool.GetGLesMethodAdress("glVariantsvEXT", typeof(dgtk.OpenGL.delegatesGLes.glVariantsvEXT));
			}
			if (SuportedExt.Contains("glVariantubvEXT"))
			{
				dgtk.OpenGL.internalGLes.glVariantubvEXT = (dgtk.OpenGL.delegatesGLes.glVariantubvEXT) InternalTool.GetGLesMethodAdress("glVariantubvEXT", typeof(dgtk.OpenGL.delegatesGLes.glVariantubvEXT));
			}
			if (SuportedExt.Contains("glVariantuivEXT"))
			{
				dgtk.OpenGL.internalGLes.glVariantuivEXT = (dgtk.OpenGL.delegatesGLes.glVariantuivEXT) InternalTool.GetGLesMethodAdress("glVariantuivEXT", typeof(dgtk.OpenGL.delegatesGLes.glVariantuivEXT));
			}
			if (SuportedExt.Contains("glVariantusvEXT"))
			{
				dgtk.OpenGL.internalGLes.glVariantusvEXT = (dgtk.OpenGL.delegatesGLes.glVariantusvEXT) InternalTool.GetGLesMethodAdress("glVariantusvEXT", typeof(dgtk.OpenGL.delegatesGLes.glVariantusvEXT));
			}
			if (SuportedExt.Contains("glVDPAUFiniNV"))
			{
				dgtk.OpenGL.internalGLes.glVDPAUFiniNV = (dgtk.OpenGL.delegatesGLes.glVDPAUFiniNV) InternalTool.GetGLesMethodAdress("glVDPAUFiniNV", typeof(dgtk.OpenGL.delegatesGLes.glVDPAUFiniNV));
			}
			if (SuportedExt.Contains("glVDPAUGetSurfaceivNV"))
			{
				dgtk.OpenGL.internalGLes.glVDPAUGetSurfaceivNV = (dgtk.OpenGL.delegatesGLes.glVDPAUGetSurfaceivNV) InternalTool.GetGLesMethodAdress("glVDPAUGetSurfaceivNV", typeof(dgtk.OpenGL.delegatesGLes.glVDPAUGetSurfaceivNV));
			}
			if (SuportedExt.Contains("glVDPAUInitNV"))
			{
				dgtk.OpenGL.internalGLes.glVDPAUInitNV = (dgtk.OpenGL.delegatesGLes.glVDPAUInitNV) InternalTool.GetGLesMethodAdress("glVDPAUInitNV", typeof(dgtk.OpenGL.delegatesGLes.glVDPAUInitNV));
			}
			if (SuportedExt.Contains("glVDPAUIsSurfaceNV"))
			{
				dgtk.OpenGL.internalGLes.glVDPAUIsSurfaceNV = (dgtk.OpenGL.delegatesGLes.glVDPAUIsSurfaceNV) InternalTool.GetGLesMethodAdress("glVDPAUIsSurfaceNV", typeof(dgtk.OpenGL.delegatesGLes.glVDPAUIsSurfaceNV));
			}
			if (SuportedExt.Contains("glVDPAUMapSurfacesNV"))
			{
				dgtk.OpenGL.internalGLes.glVDPAUMapSurfacesNV = (dgtk.OpenGL.delegatesGLes.glVDPAUMapSurfacesNV) InternalTool.GetGLesMethodAdress("glVDPAUMapSurfacesNV", typeof(dgtk.OpenGL.delegatesGLes.glVDPAUMapSurfacesNV));
			}
			if (SuportedExt.Contains("glVDPAURegisterOutputSurfaceNV"))
			{
				dgtk.OpenGL.internalGLes.glVDPAURegisterOutputSurfaceNV = (dgtk.OpenGL.delegatesGLes.glVDPAURegisterOutputSurfaceNV) InternalTool.GetGLesMethodAdress("glVDPAURegisterOutputSurfaceNV", typeof(dgtk.OpenGL.delegatesGLes.glVDPAURegisterOutputSurfaceNV));
			}
			if (SuportedExt.Contains("glVDPAURegisterVideoSurfaceNV"))
			{
				dgtk.OpenGL.internalGLes.glVDPAURegisterVideoSurfaceNV = (dgtk.OpenGL.delegatesGLes.glVDPAURegisterVideoSurfaceNV) InternalTool.GetGLesMethodAdress("glVDPAURegisterVideoSurfaceNV", typeof(dgtk.OpenGL.delegatesGLes.glVDPAURegisterVideoSurfaceNV));
			}
			if (SuportedExt.Contains("glVDPAURegisterVideoSurfaceWithPictureStructureNV"))
			{
				dgtk.OpenGL.internalGLes.glVDPAURegisterVideoSurfaceWithPictureStructureNV = (dgtk.OpenGL.delegatesGLes.glVDPAURegisterVideoSurfaceWithPictureStructureNV) InternalTool.GetGLesMethodAdress("glVDPAURegisterVideoSurfaceWithPictureStructureNV", typeof(dgtk.OpenGL.delegatesGLes.glVDPAURegisterVideoSurfaceWithPictureStructureNV));
			}
			if (SuportedExt.Contains("glVDPAUSurfaceAccessNV"))
			{
				dgtk.OpenGL.internalGLes.glVDPAUSurfaceAccessNV = (dgtk.OpenGL.delegatesGLes.glVDPAUSurfaceAccessNV) InternalTool.GetGLesMethodAdress("glVDPAUSurfaceAccessNV", typeof(dgtk.OpenGL.delegatesGLes.glVDPAUSurfaceAccessNV));
			}
			if (SuportedExt.Contains("glVDPAUUnmapSurfacesNV"))
			{
				dgtk.OpenGL.internalGLes.glVDPAUUnmapSurfacesNV = (dgtk.OpenGL.delegatesGLes.glVDPAUUnmapSurfacesNV) InternalTool.GetGLesMethodAdress("glVDPAUUnmapSurfacesNV", typeof(dgtk.OpenGL.delegatesGLes.glVDPAUUnmapSurfacesNV));
			}
			if (SuportedExt.Contains("glVDPAUUnregisterSurfaceNV"))
			{
				dgtk.OpenGL.internalGLes.glVDPAUUnregisterSurfaceNV = (dgtk.OpenGL.delegatesGLes.glVDPAUUnregisterSurfaceNV) InternalTool.GetGLesMethodAdress("glVDPAUUnregisterSurfaceNV", typeof(dgtk.OpenGL.delegatesGLes.glVDPAUUnregisterSurfaceNV));
			}
			if (SuportedExt.Contains("glVertex2bOES"))
			{
				dgtk.OpenGL.internalGLes.glVertex2bOES = (dgtk.OpenGL.delegatesGLes.glVertex2bOES) InternalTool.GetGLesMethodAdress("glVertex2bOES", typeof(dgtk.OpenGL.delegatesGLes.glVertex2bOES));
			}
			if (SuportedExt.Contains("glVertex2bvOES"))
			{
				dgtk.OpenGL.internalGLes.glVertex2bvOES = (dgtk.OpenGL.delegatesGLes.glVertex2bvOES) InternalTool.GetGLesMethodAdress("glVertex2bvOES", typeof(dgtk.OpenGL.delegatesGLes.glVertex2bvOES));
			}
			if (SuportedExt.Contains("glVertex2hNV"))
			{
				dgtk.OpenGL.internalGLes.glVertex2hNV = (dgtk.OpenGL.delegatesGLes.glVertex2hNV) InternalTool.GetGLesMethodAdress("glVertex2hNV", typeof(dgtk.OpenGL.delegatesGLes.glVertex2hNV));
			}
			if (SuportedExt.Contains("glVertex2hvNV"))
			{
				dgtk.OpenGL.internalGLes.glVertex2hvNV = (dgtk.OpenGL.delegatesGLes.glVertex2hvNV) InternalTool.GetGLesMethodAdress("glVertex2hvNV", typeof(dgtk.OpenGL.delegatesGLes.glVertex2hvNV));
			}
			if (SuportedExt.Contains("glVertex2xOES"))
			{
				dgtk.OpenGL.internalGLes.glVertex2xOES = (dgtk.OpenGL.delegatesGLes.glVertex2xOES) InternalTool.GetGLesMethodAdress("glVertex2xOES", typeof(dgtk.OpenGL.delegatesGLes.glVertex2xOES));
			}
			if (SuportedExt.Contains("glVertex2xvOES"))
			{
				dgtk.OpenGL.internalGLes.glVertex2xvOES = (dgtk.OpenGL.delegatesGLes.glVertex2xvOES) InternalTool.GetGLesMethodAdress("glVertex2xvOES", typeof(dgtk.OpenGL.delegatesGLes.glVertex2xvOES));
			}
			if (SuportedExt.Contains("glVertex3bOES"))
			{
				dgtk.OpenGL.internalGLes.glVertex3bOES = (dgtk.OpenGL.delegatesGLes.glVertex3bOES) InternalTool.GetGLesMethodAdress("glVertex3bOES", typeof(dgtk.OpenGL.delegatesGLes.glVertex3bOES));
			}
			if (SuportedExt.Contains("glVertex3bvOES"))
			{
				dgtk.OpenGL.internalGLes.glVertex3bvOES = (dgtk.OpenGL.delegatesGLes.glVertex3bvOES) InternalTool.GetGLesMethodAdress("glVertex3bvOES", typeof(dgtk.OpenGL.delegatesGLes.glVertex3bvOES));
			}
			if (SuportedExt.Contains("glVertex3hNV"))
			{
				dgtk.OpenGL.internalGLes.glVertex3hNV = (dgtk.OpenGL.delegatesGLes.glVertex3hNV) InternalTool.GetGLesMethodAdress("glVertex3hNV", typeof(dgtk.OpenGL.delegatesGLes.glVertex3hNV));
			}
			if (SuportedExt.Contains("glVertex3hvNV"))
			{
				dgtk.OpenGL.internalGLes.glVertex3hvNV = (dgtk.OpenGL.delegatesGLes.glVertex3hvNV) InternalTool.GetGLesMethodAdress("glVertex3hvNV", typeof(dgtk.OpenGL.delegatesGLes.glVertex3hvNV));
			}
			if (SuportedExt.Contains("glVertex3xOES"))
			{
				dgtk.OpenGL.internalGLes.glVertex3xOES = (dgtk.OpenGL.delegatesGLes.glVertex3xOES) InternalTool.GetGLesMethodAdress("glVertex3xOES", typeof(dgtk.OpenGL.delegatesGLes.glVertex3xOES));
			}
			if (SuportedExt.Contains("glVertex3xvOES"))
			{
				dgtk.OpenGL.internalGLes.glVertex3xvOES = (dgtk.OpenGL.delegatesGLes.glVertex3xvOES) InternalTool.GetGLesMethodAdress("glVertex3xvOES", typeof(dgtk.OpenGL.delegatesGLes.glVertex3xvOES));
			}
			if (SuportedExt.Contains("glVertex4bOES"))
			{
				dgtk.OpenGL.internalGLes.glVertex4bOES = (dgtk.OpenGL.delegatesGLes.glVertex4bOES) InternalTool.GetGLesMethodAdress("glVertex4bOES", typeof(dgtk.OpenGL.delegatesGLes.glVertex4bOES));
			}
			if (SuportedExt.Contains("glVertex4bvOES"))
			{
				dgtk.OpenGL.internalGLes.glVertex4bvOES = (dgtk.OpenGL.delegatesGLes.glVertex4bvOES) InternalTool.GetGLesMethodAdress("glVertex4bvOES", typeof(dgtk.OpenGL.delegatesGLes.glVertex4bvOES));
			}
			if (SuportedExt.Contains("glVertex4hNV"))
			{
				dgtk.OpenGL.internalGLes.glVertex4hNV = (dgtk.OpenGL.delegatesGLes.glVertex4hNV) InternalTool.GetGLesMethodAdress("glVertex4hNV", typeof(dgtk.OpenGL.delegatesGLes.glVertex4hNV));
			}
			if (SuportedExt.Contains("glVertex4hvNV"))
			{
				dgtk.OpenGL.internalGLes.glVertex4hvNV = (dgtk.OpenGL.delegatesGLes.glVertex4hvNV) InternalTool.GetGLesMethodAdress("glVertex4hvNV", typeof(dgtk.OpenGL.delegatesGLes.glVertex4hvNV));
			}
			if (SuportedExt.Contains("glVertex4xOES"))
			{
				dgtk.OpenGL.internalGLes.glVertex4xOES = (dgtk.OpenGL.delegatesGLes.glVertex4xOES) InternalTool.GetGLesMethodAdress("glVertex4xOES", typeof(dgtk.OpenGL.delegatesGLes.glVertex4xOES));
			}
			if (SuportedExt.Contains("glVertex4xvOES"))
			{
				dgtk.OpenGL.internalGLes.glVertex4xvOES = (dgtk.OpenGL.delegatesGLes.glVertex4xvOES) InternalTool.GetGLesMethodAdress("glVertex4xvOES", typeof(dgtk.OpenGL.delegatesGLes.glVertex4xvOES));
			}
			if (SuportedExt.Contains("glVertexArrayBindVertexBufferEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexArrayBindVertexBufferEXT = (dgtk.OpenGL.delegatesGLes.glVertexArrayBindVertexBufferEXT) InternalTool.GetGLesMethodAdress("glVertexArrayBindVertexBufferEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexArrayBindVertexBufferEXT));
			}
			if (SuportedExt.Contains("glVertexArrayColorOffsetEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexArrayColorOffsetEXT = (dgtk.OpenGL.delegatesGLes.glVertexArrayColorOffsetEXT) InternalTool.GetGLesMethodAdress("glVertexArrayColorOffsetEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexArrayColorOffsetEXT));
			}
			if (SuportedExt.Contains("glVertexArrayEdgeFlagOffsetEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexArrayEdgeFlagOffsetEXT = (dgtk.OpenGL.delegatesGLes.glVertexArrayEdgeFlagOffsetEXT) InternalTool.GetGLesMethodAdress("glVertexArrayEdgeFlagOffsetEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexArrayEdgeFlagOffsetEXT));
			}
			if (SuportedExt.Contains("glVertexArrayFogCoordOffsetEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexArrayFogCoordOffsetEXT = (dgtk.OpenGL.delegatesGLes.glVertexArrayFogCoordOffsetEXT) InternalTool.GetGLesMethodAdress("glVertexArrayFogCoordOffsetEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexArrayFogCoordOffsetEXT));
			}
			if (SuportedExt.Contains("glVertexArrayIndexOffsetEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexArrayIndexOffsetEXT = (dgtk.OpenGL.delegatesGLes.glVertexArrayIndexOffsetEXT) InternalTool.GetGLesMethodAdress("glVertexArrayIndexOffsetEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexArrayIndexOffsetEXT));
			}
			if (SuportedExt.Contains("glVertexArrayMultiTexCoordOffsetEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexArrayMultiTexCoordOffsetEXT = (dgtk.OpenGL.delegatesGLes.glVertexArrayMultiTexCoordOffsetEXT) InternalTool.GetGLesMethodAdress("glVertexArrayMultiTexCoordOffsetEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexArrayMultiTexCoordOffsetEXT));
			}
			if (SuportedExt.Contains("glVertexArrayNormalOffsetEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexArrayNormalOffsetEXT = (dgtk.OpenGL.delegatesGLes.glVertexArrayNormalOffsetEXT) InternalTool.GetGLesMethodAdress("glVertexArrayNormalOffsetEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexArrayNormalOffsetEXT));
			}
			if (SuportedExt.Contains("glVertexArrayParameteriAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glVertexArrayParameteriAPPLE = (dgtk.OpenGL.delegatesGLes.glVertexArrayParameteriAPPLE) InternalTool.GetGLesMethodAdress("glVertexArrayParameteriAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glVertexArrayParameteriAPPLE));
			}
			if (SuportedExt.Contains("glVertexArrayRangeAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glVertexArrayRangeAPPLE = (dgtk.OpenGL.delegatesGLes.glVertexArrayRangeAPPLE) InternalTool.GetGLesMethodAdress("glVertexArrayRangeAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glVertexArrayRangeAPPLE));
			}
			if (SuportedExt.Contains("glVertexArrayRangeNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexArrayRangeNV = (dgtk.OpenGL.delegatesGLes.glVertexArrayRangeNV) InternalTool.GetGLesMethodAdress("glVertexArrayRangeNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexArrayRangeNV));
			}
			if (SuportedExt.Contains("glVertexArraySecondaryColorOffsetEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexArraySecondaryColorOffsetEXT = (dgtk.OpenGL.delegatesGLes.glVertexArraySecondaryColorOffsetEXT) InternalTool.GetGLesMethodAdress("glVertexArraySecondaryColorOffsetEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexArraySecondaryColorOffsetEXT));
			}
			if (SuportedExt.Contains("glVertexArrayTexCoordOffsetEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexArrayTexCoordOffsetEXT = (dgtk.OpenGL.delegatesGLes.glVertexArrayTexCoordOffsetEXT) InternalTool.GetGLesMethodAdress("glVertexArrayTexCoordOffsetEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexArrayTexCoordOffsetEXT));
			}
			if (SuportedExt.Contains("glVertexArrayVertexAttribBindingEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexArrayVertexAttribBindingEXT = (dgtk.OpenGL.delegatesGLes.glVertexArrayVertexAttribBindingEXT) InternalTool.GetGLesMethodAdress("glVertexArrayVertexAttribBindingEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexArrayVertexAttribBindingEXT));
			}
			if (SuportedExt.Contains("glVertexArrayVertexAttribDivisorEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexArrayVertexAttribDivisorEXT = (dgtk.OpenGL.delegatesGLes.glVertexArrayVertexAttribDivisorEXT) InternalTool.GetGLesMethodAdress("glVertexArrayVertexAttribDivisorEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexArrayVertexAttribDivisorEXT));
			}
			if (SuportedExt.Contains("glVertexArrayVertexAttribFormatEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexArrayVertexAttribFormatEXT = (dgtk.OpenGL.delegatesGLes.glVertexArrayVertexAttribFormatEXT) InternalTool.GetGLesMethodAdress("glVertexArrayVertexAttribFormatEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexArrayVertexAttribFormatEXT));
			}
			if (SuportedExt.Contains("glVertexArrayVertexAttribIFormatEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexArrayVertexAttribIFormatEXT = (dgtk.OpenGL.delegatesGLes.glVertexArrayVertexAttribIFormatEXT) InternalTool.GetGLesMethodAdress("glVertexArrayVertexAttribIFormatEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexArrayVertexAttribIFormatEXT));
			}
			if (SuportedExt.Contains("glVertexArrayVertexAttribIOffsetEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexArrayVertexAttribIOffsetEXT = (dgtk.OpenGL.delegatesGLes.glVertexArrayVertexAttribIOffsetEXT) InternalTool.GetGLesMethodAdress("glVertexArrayVertexAttribIOffsetEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexArrayVertexAttribIOffsetEXT));
			}
			if (SuportedExt.Contains("glVertexArrayVertexAttribLFormatEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexArrayVertexAttribLFormatEXT = (dgtk.OpenGL.delegatesGLes.glVertexArrayVertexAttribLFormatEXT) InternalTool.GetGLesMethodAdress("glVertexArrayVertexAttribLFormatEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexArrayVertexAttribLFormatEXT));
			}
			if (SuportedExt.Contains("glVertexArrayVertexAttribLOffsetEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexArrayVertexAttribLOffsetEXT = (dgtk.OpenGL.delegatesGLes.glVertexArrayVertexAttribLOffsetEXT) InternalTool.GetGLesMethodAdress("glVertexArrayVertexAttribLOffsetEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexArrayVertexAttribLOffsetEXT));
			}
			if (SuportedExt.Contains("glVertexArrayVertexAttribOffsetEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexArrayVertexAttribOffsetEXT = (dgtk.OpenGL.delegatesGLes.glVertexArrayVertexAttribOffsetEXT) InternalTool.GetGLesMethodAdress("glVertexArrayVertexAttribOffsetEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexArrayVertexAttribOffsetEXT));
			}
			if (SuportedExt.Contains("glVertexArrayVertexBindingDivisorEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexArrayVertexBindingDivisorEXT = (dgtk.OpenGL.delegatesGLes.glVertexArrayVertexBindingDivisorEXT) InternalTool.GetGLesMethodAdress("glVertexArrayVertexBindingDivisorEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexArrayVertexBindingDivisorEXT));
			}
			if (SuportedExt.Contains("glVertexArrayVertexOffsetEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexArrayVertexOffsetEXT = (dgtk.OpenGL.delegatesGLes.glVertexArrayVertexOffsetEXT) InternalTool.GetGLesMethodAdress("glVertexArrayVertexOffsetEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexArrayVertexOffsetEXT));
			}
			if (SuportedExt.Contains("glVertexAttrib1dARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib1dARB = (dgtk.OpenGL.delegatesGLes.glVertexAttrib1dARB) InternalTool.GetGLesMethodAdress("glVertexAttrib1dARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib1dARB));
			}
			if (SuportedExt.Contains("glVertexAttrib1dNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib1dNV = (dgtk.OpenGL.delegatesGLes.glVertexAttrib1dNV) InternalTool.GetGLesMethodAdress("glVertexAttrib1dNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib1dNV));
			}
			if (SuportedExt.Contains("glVertexAttrib1dvARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib1dvARB = (dgtk.OpenGL.delegatesGLes.glVertexAttrib1dvARB) InternalTool.GetGLesMethodAdress("glVertexAttrib1dvARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib1dvARB));
			}
			if (SuportedExt.Contains("glVertexAttrib1dvNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib1dvNV = (dgtk.OpenGL.delegatesGLes.glVertexAttrib1dvNV) InternalTool.GetGLesMethodAdress("glVertexAttrib1dvNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib1dvNV));
			}
			if (SuportedExt.Contains("glVertexAttrib1fARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib1fARB = (dgtk.OpenGL.delegatesGLes.glVertexAttrib1fARB) InternalTool.GetGLesMethodAdress("glVertexAttrib1fARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib1fARB));
			}
			if (SuportedExt.Contains("glVertexAttrib1fNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib1fNV = (dgtk.OpenGL.delegatesGLes.glVertexAttrib1fNV) InternalTool.GetGLesMethodAdress("glVertexAttrib1fNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib1fNV));
			}
			if (SuportedExt.Contains("glVertexAttrib1fvARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib1fvARB = (dgtk.OpenGL.delegatesGLes.glVertexAttrib1fvARB) InternalTool.GetGLesMethodAdress("glVertexAttrib1fvARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib1fvARB));
			}
			if (SuportedExt.Contains("glVertexAttrib1fvNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib1fvNV = (dgtk.OpenGL.delegatesGLes.glVertexAttrib1fvNV) InternalTool.GetGLesMethodAdress("glVertexAttrib1fvNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib1fvNV));
			}
			if (SuportedExt.Contains("glVertexAttrib1hNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib1hNV = (dgtk.OpenGL.delegatesGLes.glVertexAttrib1hNV) InternalTool.GetGLesMethodAdress("glVertexAttrib1hNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib1hNV));
			}
			if (SuportedExt.Contains("glVertexAttrib1hvNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib1hvNV = (dgtk.OpenGL.delegatesGLes.glVertexAttrib1hvNV) InternalTool.GetGLesMethodAdress("glVertexAttrib1hvNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib1hvNV));
			}
			if (SuportedExt.Contains("glVertexAttrib1sARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib1sARB = (dgtk.OpenGL.delegatesGLes.glVertexAttrib1sARB) InternalTool.GetGLesMethodAdress("glVertexAttrib1sARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib1sARB));
			}
			if (SuportedExt.Contains("glVertexAttrib1sNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib1sNV = (dgtk.OpenGL.delegatesGLes.glVertexAttrib1sNV) InternalTool.GetGLesMethodAdress("glVertexAttrib1sNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib1sNV));
			}
			if (SuportedExt.Contains("glVertexAttrib1svARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib1svARB = (dgtk.OpenGL.delegatesGLes.glVertexAttrib1svARB) InternalTool.GetGLesMethodAdress("glVertexAttrib1svARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib1svARB));
			}
			if (SuportedExt.Contains("glVertexAttrib1svNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib1svNV = (dgtk.OpenGL.delegatesGLes.glVertexAttrib1svNV) InternalTool.GetGLesMethodAdress("glVertexAttrib1svNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib1svNV));
			}
			if (SuportedExt.Contains("glVertexAttrib2dARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib2dARB = (dgtk.OpenGL.delegatesGLes.glVertexAttrib2dARB) InternalTool.GetGLesMethodAdress("glVertexAttrib2dARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib2dARB));
			}
			if (SuportedExt.Contains("glVertexAttrib2dNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib2dNV = (dgtk.OpenGL.delegatesGLes.glVertexAttrib2dNV) InternalTool.GetGLesMethodAdress("glVertexAttrib2dNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib2dNV));
			}
			if (SuportedExt.Contains("glVertexAttrib2dvARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib2dvARB = (dgtk.OpenGL.delegatesGLes.glVertexAttrib2dvARB) InternalTool.GetGLesMethodAdress("glVertexAttrib2dvARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib2dvARB));
			}
			if (SuportedExt.Contains("glVertexAttrib2dvNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib2dvNV = (dgtk.OpenGL.delegatesGLes.glVertexAttrib2dvNV) InternalTool.GetGLesMethodAdress("glVertexAttrib2dvNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib2dvNV));
			}
			if (SuportedExt.Contains("glVertexAttrib2fARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib2fARB = (dgtk.OpenGL.delegatesGLes.glVertexAttrib2fARB) InternalTool.GetGLesMethodAdress("glVertexAttrib2fARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib2fARB));
			}
			if (SuportedExt.Contains("glVertexAttrib2fNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib2fNV = (dgtk.OpenGL.delegatesGLes.glVertexAttrib2fNV) InternalTool.GetGLesMethodAdress("glVertexAttrib2fNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib2fNV));
			}
			if (SuportedExt.Contains("glVertexAttrib2fvARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib2fvARB = (dgtk.OpenGL.delegatesGLes.glVertexAttrib2fvARB) InternalTool.GetGLesMethodAdress("glVertexAttrib2fvARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib2fvARB));
			}
			if (SuportedExt.Contains("glVertexAttrib2fvNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib2fvNV = (dgtk.OpenGL.delegatesGLes.glVertexAttrib2fvNV) InternalTool.GetGLesMethodAdress("glVertexAttrib2fvNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib2fvNV));
			}
			if (SuportedExt.Contains("glVertexAttrib2hNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib2hNV = (dgtk.OpenGL.delegatesGLes.glVertexAttrib2hNV) InternalTool.GetGLesMethodAdress("glVertexAttrib2hNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib2hNV));
			}
			if (SuportedExt.Contains("glVertexAttrib2hvNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib2hvNV = (dgtk.OpenGL.delegatesGLes.glVertexAttrib2hvNV) InternalTool.GetGLesMethodAdress("glVertexAttrib2hvNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib2hvNV));
			}
			if (SuportedExt.Contains("glVertexAttrib2sARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib2sARB = (dgtk.OpenGL.delegatesGLes.glVertexAttrib2sARB) InternalTool.GetGLesMethodAdress("glVertexAttrib2sARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib2sARB));
			}
			if (SuportedExt.Contains("glVertexAttrib2sNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib2sNV = (dgtk.OpenGL.delegatesGLes.glVertexAttrib2sNV) InternalTool.GetGLesMethodAdress("glVertexAttrib2sNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib2sNV));
			}
			if (SuportedExt.Contains("glVertexAttrib2svARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib2svARB = (dgtk.OpenGL.delegatesGLes.glVertexAttrib2svARB) InternalTool.GetGLesMethodAdress("glVertexAttrib2svARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib2svARB));
			}
			if (SuportedExt.Contains("glVertexAttrib2svNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib2svNV = (dgtk.OpenGL.delegatesGLes.glVertexAttrib2svNV) InternalTool.GetGLesMethodAdress("glVertexAttrib2svNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib2svNV));
			}
			if (SuportedExt.Contains("glVertexAttrib3dARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib3dARB = (dgtk.OpenGL.delegatesGLes.glVertexAttrib3dARB) InternalTool.GetGLesMethodAdress("glVertexAttrib3dARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib3dARB));
			}
			if (SuportedExt.Contains("glVertexAttrib3dNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib3dNV = (dgtk.OpenGL.delegatesGLes.glVertexAttrib3dNV) InternalTool.GetGLesMethodAdress("glVertexAttrib3dNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib3dNV));
			}
			if (SuportedExt.Contains("glVertexAttrib3dvARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib3dvARB = (dgtk.OpenGL.delegatesGLes.glVertexAttrib3dvARB) InternalTool.GetGLesMethodAdress("glVertexAttrib3dvARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib3dvARB));
			}
			if (SuportedExt.Contains("glVertexAttrib3dvNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib3dvNV = (dgtk.OpenGL.delegatesGLes.glVertexAttrib3dvNV) InternalTool.GetGLesMethodAdress("glVertexAttrib3dvNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib3dvNV));
			}
			if (SuportedExt.Contains("glVertexAttrib3fARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib3fARB = (dgtk.OpenGL.delegatesGLes.glVertexAttrib3fARB) InternalTool.GetGLesMethodAdress("glVertexAttrib3fARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib3fARB));
			}
			if (SuportedExt.Contains("glVertexAttrib3fNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib3fNV = (dgtk.OpenGL.delegatesGLes.glVertexAttrib3fNV) InternalTool.GetGLesMethodAdress("glVertexAttrib3fNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib3fNV));
			}
			if (SuportedExt.Contains("glVertexAttrib3fvARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib3fvARB = (dgtk.OpenGL.delegatesGLes.glVertexAttrib3fvARB) InternalTool.GetGLesMethodAdress("glVertexAttrib3fvARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib3fvARB));
			}
			if (SuportedExt.Contains("glVertexAttrib3fvNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib3fvNV = (dgtk.OpenGL.delegatesGLes.glVertexAttrib3fvNV) InternalTool.GetGLesMethodAdress("glVertexAttrib3fvNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib3fvNV));
			}
			if (SuportedExt.Contains("glVertexAttrib3hNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib3hNV = (dgtk.OpenGL.delegatesGLes.glVertexAttrib3hNV) InternalTool.GetGLesMethodAdress("glVertexAttrib3hNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib3hNV));
			}
			if (SuportedExt.Contains("glVertexAttrib3hvNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib3hvNV = (dgtk.OpenGL.delegatesGLes.glVertexAttrib3hvNV) InternalTool.GetGLesMethodAdress("glVertexAttrib3hvNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib3hvNV));
			}
			if (SuportedExt.Contains("glVertexAttrib3sARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib3sARB = (dgtk.OpenGL.delegatesGLes.glVertexAttrib3sARB) InternalTool.GetGLesMethodAdress("glVertexAttrib3sARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib3sARB));
			}
			if (SuportedExt.Contains("glVertexAttrib3sNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib3sNV = (dgtk.OpenGL.delegatesGLes.glVertexAttrib3sNV) InternalTool.GetGLesMethodAdress("glVertexAttrib3sNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib3sNV));
			}
			if (SuportedExt.Contains("glVertexAttrib3svARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib3svARB = (dgtk.OpenGL.delegatesGLes.glVertexAttrib3svARB) InternalTool.GetGLesMethodAdress("glVertexAttrib3svARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib3svARB));
			}
			if (SuportedExt.Contains("glVertexAttrib3svNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib3svNV = (dgtk.OpenGL.delegatesGLes.glVertexAttrib3svNV) InternalTool.GetGLesMethodAdress("glVertexAttrib3svNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib3svNV));
			}
			if (SuportedExt.Contains("glVertexAttrib4bvARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib4bvARB = (dgtk.OpenGL.delegatesGLes.glVertexAttrib4bvARB) InternalTool.GetGLesMethodAdress("glVertexAttrib4bvARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib4bvARB));
			}
			if (SuportedExt.Contains("glVertexAttrib4dARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib4dARB = (dgtk.OpenGL.delegatesGLes.glVertexAttrib4dARB) InternalTool.GetGLesMethodAdress("glVertexAttrib4dARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib4dARB));
			}
			if (SuportedExt.Contains("glVertexAttrib4dNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib4dNV = (dgtk.OpenGL.delegatesGLes.glVertexAttrib4dNV) InternalTool.GetGLesMethodAdress("glVertexAttrib4dNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib4dNV));
			}
			if (SuportedExt.Contains("glVertexAttrib4dvARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib4dvARB = (dgtk.OpenGL.delegatesGLes.glVertexAttrib4dvARB) InternalTool.GetGLesMethodAdress("glVertexAttrib4dvARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib4dvARB));
			}
			if (SuportedExt.Contains("glVertexAttrib4dvNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib4dvNV = (dgtk.OpenGL.delegatesGLes.glVertexAttrib4dvNV) InternalTool.GetGLesMethodAdress("glVertexAttrib4dvNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib4dvNV));
			}
			if (SuportedExt.Contains("glVertexAttrib4fARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib4fARB = (dgtk.OpenGL.delegatesGLes.glVertexAttrib4fARB) InternalTool.GetGLesMethodAdress("glVertexAttrib4fARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib4fARB));
			}
			if (SuportedExt.Contains("glVertexAttrib4fNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib4fNV = (dgtk.OpenGL.delegatesGLes.glVertexAttrib4fNV) InternalTool.GetGLesMethodAdress("glVertexAttrib4fNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib4fNV));
			}
			if (SuportedExt.Contains("glVertexAttrib4fvARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib4fvARB = (dgtk.OpenGL.delegatesGLes.glVertexAttrib4fvARB) InternalTool.GetGLesMethodAdress("glVertexAttrib4fvARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib4fvARB));
			}
			if (SuportedExt.Contains("glVertexAttrib4fvNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib4fvNV = (dgtk.OpenGL.delegatesGLes.glVertexAttrib4fvNV) InternalTool.GetGLesMethodAdress("glVertexAttrib4fvNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib4fvNV));
			}
			if (SuportedExt.Contains("glVertexAttrib4hNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib4hNV = (dgtk.OpenGL.delegatesGLes.glVertexAttrib4hNV) InternalTool.GetGLesMethodAdress("glVertexAttrib4hNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib4hNV));
			}
			if (SuportedExt.Contains("glVertexAttrib4hvNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib4hvNV = (dgtk.OpenGL.delegatesGLes.glVertexAttrib4hvNV) InternalTool.GetGLesMethodAdress("glVertexAttrib4hvNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib4hvNV));
			}
			if (SuportedExt.Contains("glVertexAttrib4ivARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib4ivARB = (dgtk.OpenGL.delegatesGLes.glVertexAttrib4ivARB) InternalTool.GetGLesMethodAdress("glVertexAttrib4ivARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib4ivARB));
			}
			if (SuportedExt.Contains("glVertexAttrib4NbvARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib4NbvARB = (dgtk.OpenGL.delegatesGLes.glVertexAttrib4NbvARB) InternalTool.GetGLesMethodAdress("glVertexAttrib4NbvARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib4NbvARB));
			}
			if (SuportedExt.Contains("glVertexAttrib4NivARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib4NivARB = (dgtk.OpenGL.delegatesGLes.glVertexAttrib4NivARB) InternalTool.GetGLesMethodAdress("glVertexAttrib4NivARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib4NivARB));
			}
			if (SuportedExt.Contains("glVertexAttrib4NsvARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib4NsvARB = (dgtk.OpenGL.delegatesGLes.glVertexAttrib4NsvARB) InternalTool.GetGLesMethodAdress("glVertexAttrib4NsvARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib4NsvARB));
			}
			if (SuportedExt.Contains("glVertexAttrib4NubARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib4NubARB = (dgtk.OpenGL.delegatesGLes.glVertexAttrib4NubARB) InternalTool.GetGLesMethodAdress("glVertexAttrib4NubARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib4NubARB));
			}
			if (SuportedExt.Contains("glVertexAttrib4NubvARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib4NubvARB = (dgtk.OpenGL.delegatesGLes.glVertexAttrib4NubvARB) InternalTool.GetGLesMethodAdress("glVertexAttrib4NubvARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib4NubvARB));
			}
			if (SuportedExt.Contains("glVertexAttrib4NuivARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib4NuivARB = (dgtk.OpenGL.delegatesGLes.glVertexAttrib4NuivARB) InternalTool.GetGLesMethodAdress("glVertexAttrib4NuivARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib4NuivARB));
			}
			if (SuportedExt.Contains("glVertexAttrib4NusvARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib4NusvARB = (dgtk.OpenGL.delegatesGLes.glVertexAttrib4NusvARB) InternalTool.GetGLesMethodAdress("glVertexAttrib4NusvARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib4NusvARB));
			}
			if (SuportedExt.Contains("glVertexAttrib4sARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib4sARB = (dgtk.OpenGL.delegatesGLes.glVertexAttrib4sARB) InternalTool.GetGLesMethodAdress("glVertexAttrib4sARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib4sARB));
			}
			if (SuportedExt.Contains("glVertexAttrib4sNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib4sNV = (dgtk.OpenGL.delegatesGLes.glVertexAttrib4sNV) InternalTool.GetGLesMethodAdress("glVertexAttrib4sNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib4sNV));
			}
			if (SuportedExt.Contains("glVertexAttrib4svARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib4svARB = (dgtk.OpenGL.delegatesGLes.glVertexAttrib4svARB) InternalTool.GetGLesMethodAdress("glVertexAttrib4svARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib4svARB));
			}
			if (SuportedExt.Contains("glVertexAttrib4svNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib4svNV = (dgtk.OpenGL.delegatesGLes.glVertexAttrib4svNV) InternalTool.GetGLesMethodAdress("glVertexAttrib4svNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib4svNV));
			}
			if (SuportedExt.Contains("glVertexAttrib4ubNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib4ubNV = (dgtk.OpenGL.delegatesGLes.glVertexAttrib4ubNV) InternalTool.GetGLesMethodAdress("glVertexAttrib4ubNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib4ubNV));
			}
			if (SuportedExt.Contains("glVertexAttrib4ubvARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib4ubvARB = (dgtk.OpenGL.delegatesGLes.glVertexAttrib4ubvARB) InternalTool.GetGLesMethodAdress("glVertexAttrib4ubvARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib4ubvARB));
			}
			if (SuportedExt.Contains("glVertexAttrib4ubvNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib4ubvNV = (dgtk.OpenGL.delegatesGLes.glVertexAttrib4ubvNV) InternalTool.GetGLesMethodAdress("glVertexAttrib4ubvNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib4ubvNV));
			}
			if (SuportedExt.Contains("glVertexAttrib4uivARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib4uivARB = (dgtk.OpenGL.delegatesGLes.glVertexAttrib4uivARB) InternalTool.GetGLesMethodAdress("glVertexAttrib4uivARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib4uivARB));
			}
			if (SuportedExt.Contains("glVertexAttrib4usvARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttrib4usvARB = (dgtk.OpenGL.delegatesGLes.glVertexAttrib4usvARB) InternalTool.GetGLesMethodAdress("glVertexAttrib4usvARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttrib4usvARB));
			}
			if (SuportedExt.Contains("glVertexAttribArrayObjectATI"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribArrayObjectATI = (dgtk.OpenGL.delegatesGLes.glVertexAttribArrayObjectATI) InternalTool.GetGLesMethodAdress("glVertexAttribArrayObjectATI", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribArrayObjectATI));
			}
			if (SuportedExt.Contains("glVertexAttribDivisorANGLE"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribDivisorANGLE = (dgtk.OpenGL.delegatesGLes.glVertexAttribDivisorANGLE) InternalTool.GetGLesMethodAdress("glVertexAttribDivisorANGLE", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribDivisorANGLE));
			}
			if (SuportedExt.Contains("glVertexAttribDivisorARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribDivisorARB = (dgtk.OpenGL.delegatesGLes.glVertexAttribDivisorARB) InternalTool.GetGLesMethodAdress("glVertexAttribDivisorARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribDivisorARB));
			}
			if (SuportedExt.Contains("glVertexAttribDivisorEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribDivisorEXT = (dgtk.OpenGL.delegatesGLes.glVertexAttribDivisorEXT) InternalTool.GetGLesMethodAdress("glVertexAttribDivisorEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribDivisorEXT));
			}
			if (SuportedExt.Contains("glVertexAttribDivisorNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribDivisorNV = (dgtk.OpenGL.delegatesGLes.glVertexAttribDivisorNV) InternalTool.GetGLesMethodAdress("glVertexAttribDivisorNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribDivisorNV));
			}
			if (SuportedExt.Contains("glVertexAttribFormatNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribFormatNV = (dgtk.OpenGL.delegatesGLes.glVertexAttribFormatNV) InternalTool.GetGLesMethodAdress("glVertexAttribFormatNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribFormatNV));
			}
			if (SuportedExt.Contains("glVertexAttribI1iEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribI1iEXT = (dgtk.OpenGL.delegatesGLes.glVertexAttribI1iEXT) InternalTool.GetGLesMethodAdress("glVertexAttribI1iEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribI1iEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI1ivEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribI1ivEXT = (dgtk.OpenGL.delegatesGLes.glVertexAttribI1ivEXT) InternalTool.GetGLesMethodAdress("glVertexAttribI1ivEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribI1ivEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI1uiEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribI1uiEXT = (dgtk.OpenGL.delegatesGLes.glVertexAttribI1uiEXT) InternalTool.GetGLesMethodAdress("glVertexAttribI1uiEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribI1uiEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI1uivEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribI1uivEXT = (dgtk.OpenGL.delegatesGLes.glVertexAttribI1uivEXT) InternalTool.GetGLesMethodAdress("glVertexAttribI1uivEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribI1uivEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI2iEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribI2iEXT = (dgtk.OpenGL.delegatesGLes.glVertexAttribI2iEXT) InternalTool.GetGLesMethodAdress("glVertexAttribI2iEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribI2iEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI2ivEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribI2ivEXT = (dgtk.OpenGL.delegatesGLes.glVertexAttribI2ivEXT) InternalTool.GetGLesMethodAdress("glVertexAttribI2ivEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribI2ivEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI2uiEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribI2uiEXT = (dgtk.OpenGL.delegatesGLes.glVertexAttribI2uiEXT) InternalTool.GetGLesMethodAdress("glVertexAttribI2uiEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribI2uiEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI2uivEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribI2uivEXT = (dgtk.OpenGL.delegatesGLes.glVertexAttribI2uivEXT) InternalTool.GetGLesMethodAdress("glVertexAttribI2uivEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribI2uivEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI3iEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribI3iEXT = (dgtk.OpenGL.delegatesGLes.glVertexAttribI3iEXT) InternalTool.GetGLesMethodAdress("glVertexAttribI3iEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribI3iEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI3ivEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribI3ivEXT = (dgtk.OpenGL.delegatesGLes.glVertexAttribI3ivEXT) InternalTool.GetGLesMethodAdress("glVertexAttribI3ivEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribI3ivEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI3uiEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribI3uiEXT = (dgtk.OpenGL.delegatesGLes.glVertexAttribI3uiEXT) InternalTool.GetGLesMethodAdress("glVertexAttribI3uiEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribI3uiEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI3uivEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribI3uivEXT = (dgtk.OpenGL.delegatesGLes.glVertexAttribI3uivEXT) InternalTool.GetGLesMethodAdress("glVertexAttribI3uivEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribI3uivEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI4bvEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribI4bvEXT = (dgtk.OpenGL.delegatesGLes.glVertexAttribI4bvEXT) InternalTool.GetGLesMethodAdress("glVertexAttribI4bvEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribI4bvEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI4iEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribI4iEXT = (dgtk.OpenGL.delegatesGLes.glVertexAttribI4iEXT) InternalTool.GetGLesMethodAdress("glVertexAttribI4iEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribI4iEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI4ivEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribI4ivEXT = (dgtk.OpenGL.delegatesGLes.glVertexAttribI4ivEXT) InternalTool.GetGLesMethodAdress("glVertexAttribI4ivEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribI4ivEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI4svEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribI4svEXT = (dgtk.OpenGL.delegatesGLes.glVertexAttribI4svEXT) InternalTool.GetGLesMethodAdress("glVertexAttribI4svEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribI4svEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI4ubvEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribI4ubvEXT = (dgtk.OpenGL.delegatesGLes.glVertexAttribI4ubvEXT) InternalTool.GetGLesMethodAdress("glVertexAttribI4ubvEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribI4ubvEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI4uiEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribI4uiEXT = (dgtk.OpenGL.delegatesGLes.glVertexAttribI4uiEXT) InternalTool.GetGLesMethodAdress("glVertexAttribI4uiEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribI4uiEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI4uivEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribI4uivEXT = (dgtk.OpenGL.delegatesGLes.glVertexAttribI4uivEXT) InternalTool.GetGLesMethodAdress("glVertexAttribI4uivEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribI4uivEXT));
			}
			if (SuportedExt.Contains("glVertexAttribI4usvEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribI4usvEXT = (dgtk.OpenGL.delegatesGLes.glVertexAttribI4usvEXT) InternalTool.GetGLesMethodAdress("glVertexAttribI4usvEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribI4usvEXT));
			}
			if (SuportedExt.Contains("glVertexAttribIFormatNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribIFormatNV = (dgtk.OpenGL.delegatesGLes.glVertexAttribIFormatNV) InternalTool.GetGLesMethodAdress("glVertexAttribIFormatNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribIFormatNV));
			}
			if (SuportedExt.Contains("glVertexAttribIPointerEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribIPointerEXT = (dgtk.OpenGL.delegatesGLes.glVertexAttribIPointerEXT) InternalTool.GetGLesMethodAdress("glVertexAttribIPointerEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribIPointerEXT));
			}
			if (SuportedExt.Contains("glVertexAttribL1dEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribL1dEXT = (dgtk.OpenGL.delegatesGLes.glVertexAttribL1dEXT) InternalTool.GetGLesMethodAdress("glVertexAttribL1dEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribL1dEXT));
			}
			if (SuportedExt.Contains("glVertexAttribL1dvEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribL1dvEXT = (dgtk.OpenGL.delegatesGLes.glVertexAttribL1dvEXT) InternalTool.GetGLesMethodAdress("glVertexAttribL1dvEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribL1dvEXT));
			}
			if (SuportedExt.Contains("glVertexAttribL1i64NV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribL1i64NV = (dgtk.OpenGL.delegatesGLes.glVertexAttribL1i64NV) InternalTool.GetGLesMethodAdress("glVertexAttribL1i64NV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribL1i64NV));
			}
			if (SuportedExt.Contains("glVertexAttribL1i64vNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribL1i64vNV = (dgtk.OpenGL.delegatesGLes.glVertexAttribL1i64vNV) InternalTool.GetGLesMethodAdress("glVertexAttribL1i64vNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribL1i64vNV));
			}
			if (SuportedExt.Contains("glVertexAttribL1ui64ARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribL1ui64ARB = (dgtk.OpenGL.delegatesGLes.glVertexAttribL1ui64ARB) InternalTool.GetGLesMethodAdress("glVertexAttribL1ui64ARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribL1ui64ARB));
			}
			if (SuportedExt.Contains("glVertexAttribL1ui64NV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribL1ui64NV = (dgtk.OpenGL.delegatesGLes.glVertexAttribL1ui64NV) InternalTool.GetGLesMethodAdress("glVertexAttribL1ui64NV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribL1ui64NV));
			}
			if (SuportedExt.Contains("glVertexAttribL1ui64vARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribL1ui64vARB = (dgtk.OpenGL.delegatesGLes.glVertexAttribL1ui64vARB) InternalTool.GetGLesMethodAdress("glVertexAttribL1ui64vARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribL1ui64vARB));
			}
			if (SuportedExt.Contains("glVertexAttribL1ui64vNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribL1ui64vNV = (dgtk.OpenGL.delegatesGLes.glVertexAttribL1ui64vNV) InternalTool.GetGLesMethodAdress("glVertexAttribL1ui64vNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribL1ui64vNV));
			}
			if (SuportedExt.Contains("glVertexAttribL2dEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribL2dEXT = (dgtk.OpenGL.delegatesGLes.glVertexAttribL2dEXT) InternalTool.GetGLesMethodAdress("glVertexAttribL2dEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribL2dEXT));
			}
			if (SuportedExt.Contains("glVertexAttribL2dvEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribL2dvEXT = (dgtk.OpenGL.delegatesGLes.glVertexAttribL2dvEXT) InternalTool.GetGLesMethodAdress("glVertexAttribL2dvEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribL2dvEXT));
			}
			if (SuportedExt.Contains("glVertexAttribL2i64NV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribL2i64NV = (dgtk.OpenGL.delegatesGLes.glVertexAttribL2i64NV) InternalTool.GetGLesMethodAdress("glVertexAttribL2i64NV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribL2i64NV));
			}
			if (SuportedExt.Contains("glVertexAttribL2i64vNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribL2i64vNV = (dgtk.OpenGL.delegatesGLes.glVertexAttribL2i64vNV) InternalTool.GetGLesMethodAdress("glVertexAttribL2i64vNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribL2i64vNV));
			}
			if (SuportedExt.Contains("glVertexAttribL2ui64NV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribL2ui64NV = (dgtk.OpenGL.delegatesGLes.glVertexAttribL2ui64NV) InternalTool.GetGLesMethodAdress("glVertexAttribL2ui64NV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribL2ui64NV));
			}
			if (SuportedExt.Contains("glVertexAttribL2ui64vNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribL2ui64vNV = (dgtk.OpenGL.delegatesGLes.glVertexAttribL2ui64vNV) InternalTool.GetGLesMethodAdress("glVertexAttribL2ui64vNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribL2ui64vNV));
			}
			if (SuportedExt.Contains("glVertexAttribL3dEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribL3dEXT = (dgtk.OpenGL.delegatesGLes.glVertexAttribL3dEXT) InternalTool.GetGLesMethodAdress("glVertexAttribL3dEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribL3dEXT));
			}
			if (SuportedExt.Contains("glVertexAttribL3dvEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribL3dvEXT = (dgtk.OpenGL.delegatesGLes.glVertexAttribL3dvEXT) InternalTool.GetGLesMethodAdress("glVertexAttribL3dvEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribL3dvEXT));
			}
			if (SuportedExt.Contains("glVertexAttribL3i64NV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribL3i64NV = (dgtk.OpenGL.delegatesGLes.glVertexAttribL3i64NV) InternalTool.GetGLesMethodAdress("glVertexAttribL3i64NV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribL3i64NV));
			}
			if (SuportedExt.Contains("glVertexAttribL3i64vNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribL3i64vNV = (dgtk.OpenGL.delegatesGLes.glVertexAttribL3i64vNV) InternalTool.GetGLesMethodAdress("glVertexAttribL3i64vNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribL3i64vNV));
			}
			if (SuportedExt.Contains("glVertexAttribL3ui64NV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribL3ui64NV = (dgtk.OpenGL.delegatesGLes.glVertexAttribL3ui64NV) InternalTool.GetGLesMethodAdress("glVertexAttribL3ui64NV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribL3ui64NV));
			}
			if (SuportedExt.Contains("glVertexAttribL3ui64vNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribL3ui64vNV = (dgtk.OpenGL.delegatesGLes.glVertexAttribL3ui64vNV) InternalTool.GetGLesMethodAdress("glVertexAttribL3ui64vNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribL3ui64vNV));
			}
			if (SuportedExt.Contains("glVertexAttribL4dEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribL4dEXT = (dgtk.OpenGL.delegatesGLes.glVertexAttribL4dEXT) InternalTool.GetGLesMethodAdress("glVertexAttribL4dEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribL4dEXT));
			}
			if (SuportedExt.Contains("glVertexAttribL4dvEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribL4dvEXT = (dgtk.OpenGL.delegatesGLes.glVertexAttribL4dvEXT) InternalTool.GetGLesMethodAdress("glVertexAttribL4dvEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribL4dvEXT));
			}
			if (SuportedExt.Contains("glVertexAttribL4i64NV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribL4i64NV = (dgtk.OpenGL.delegatesGLes.glVertexAttribL4i64NV) InternalTool.GetGLesMethodAdress("glVertexAttribL4i64NV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribL4i64NV));
			}
			if (SuportedExt.Contains("glVertexAttribL4i64vNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribL4i64vNV = (dgtk.OpenGL.delegatesGLes.glVertexAttribL4i64vNV) InternalTool.GetGLesMethodAdress("glVertexAttribL4i64vNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribL4i64vNV));
			}
			if (SuportedExt.Contains("glVertexAttribL4ui64NV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribL4ui64NV = (dgtk.OpenGL.delegatesGLes.glVertexAttribL4ui64NV) InternalTool.GetGLesMethodAdress("glVertexAttribL4ui64NV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribL4ui64NV));
			}
			if (SuportedExt.Contains("glVertexAttribL4ui64vNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribL4ui64vNV = (dgtk.OpenGL.delegatesGLes.glVertexAttribL4ui64vNV) InternalTool.GetGLesMethodAdress("glVertexAttribL4ui64vNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribL4ui64vNV));
			}
			if (SuportedExt.Contains("glVertexAttribLFormatNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribLFormatNV = (dgtk.OpenGL.delegatesGLes.glVertexAttribLFormatNV) InternalTool.GetGLesMethodAdress("glVertexAttribLFormatNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribLFormatNV));
			}
			if (SuportedExt.Contains("glVertexAttribLPointerEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribLPointerEXT = (dgtk.OpenGL.delegatesGLes.glVertexAttribLPointerEXT) InternalTool.GetGLesMethodAdress("glVertexAttribLPointerEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribLPointerEXT));
			}
			if (SuportedExt.Contains("glVertexAttribParameteriAMD"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribParameteriAMD = (dgtk.OpenGL.delegatesGLes.glVertexAttribParameteriAMD) InternalTool.GetGLesMethodAdress("glVertexAttribParameteriAMD", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribParameteriAMD));
			}
			if (SuportedExt.Contains("glVertexAttribPointerARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribPointerARB = (dgtk.OpenGL.delegatesGLes.glVertexAttribPointerARB) InternalTool.GetGLesMethodAdress("glVertexAttribPointerARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribPointerARB));
			}
			if (SuportedExt.Contains("glVertexAttribPointerNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribPointerNV = (dgtk.OpenGL.delegatesGLes.glVertexAttribPointerNV) InternalTool.GetGLesMethodAdress("glVertexAttribPointerNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribPointerNV));
			}
			if (SuportedExt.Contains("glVertexAttribs1dvNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribs1dvNV = (dgtk.OpenGL.delegatesGLes.glVertexAttribs1dvNV) InternalTool.GetGLesMethodAdress("glVertexAttribs1dvNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribs1dvNV));
			}
			if (SuportedExt.Contains("glVertexAttribs1fvNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribs1fvNV = (dgtk.OpenGL.delegatesGLes.glVertexAttribs1fvNV) InternalTool.GetGLesMethodAdress("glVertexAttribs1fvNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribs1fvNV));
			}
			if (SuportedExt.Contains("glVertexAttribs1hvNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribs1hvNV = (dgtk.OpenGL.delegatesGLes.glVertexAttribs1hvNV) InternalTool.GetGLesMethodAdress("glVertexAttribs1hvNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribs1hvNV));
			}
			if (SuportedExt.Contains("glVertexAttribs1svNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribs1svNV = (dgtk.OpenGL.delegatesGLes.glVertexAttribs1svNV) InternalTool.GetGLesMethodAdress("glVertexAttribs1svNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribs1svNV));
			}
			if (SuportedExt.Contains("glVertexAttribs2dvNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribs2dvNV = (dgtk.OpenGL.delegatesGLes.glVertexAttribs2dvNV) InternalTool.GetGLesMethodAdress("glVertexAttribs2dvNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribs2dvNV));
			}
			if (SuportedExt.Contains("glVertexAttribs2fvNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribs2fvNV = (dgtk.OpenGL.delegatesGLes.glVertexAttribs2fvNV) InternalTool.GetGLesMethodAdress("glVertexAttribs2fvNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribs2fvNV));
			}
			if (SuportedExt.Contains("glVertexAttribs2hvNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribs2hvNV = (dgtk.OpenGL.delegatesGLes.glVertexAttribs2hvNV) InternalTool.GetGLesMethodAdress("glVertexAttribs2hvNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribs2hvNV));
			}
			if (SuportedExt.Contains("glVertexAttribs2svNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribs2svNV = (dgtk.OpenGL.delegatesGLes.glVertexAttribs2svNV) InternalTool.GetGLesMethodAdress("glVertexAttribs2svNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribs2svNV));
			}
			if (SuportedExt.Contains("glVertexAttribs3dvNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribs3dvNV = (dgtk.OpenGL.delegatesGLes.glVertexAttribs3dvNV) InternalTool.GetGLesMethodAdress("glVertexAttribs3dvNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribs3dvNV));
			}
			if (SuportedExt.Contains("glVertexAttribs3fvNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribs3fvNV = (dgtk.OpenGL.delegatesGLes.glVertexAttribs3fvNV) InternalTool.GetGLesMethodAdress("glVertexAttribs3fvNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribs3fvNV));
			}
			if (SuportedExt.Contains("glVertexAttribs3hvNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribs3hvNV = (dgtk.OpenGL.delegatesGLes.glVertexAttribs3hvNV) InternalTool.GetGLesMethodAdress("glVertexAttribs3hvNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribs3hvNV));
			}
			if (SuportedExt.Contains("glVertexAttribs3svNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribs3svNV = (dgtk.OpenGL.delegatesGLes.glVertexAttribs3svNV) InternalTool.GetGLesMethodAdress("glVertexAttribs3svNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribs3svNV));
			}
			if (SuportedExt.Contains("glVertexAttribs4dvNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribs4dvNV = (dgtk.OpenGL.delegatesGLes.glVertexAttribs4dvNV) InternalTool.GetGLesMethodAdress("glVertexAttribs4dvNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribs4dvNV));
			}
			if (SuportedExt.Contains("glVertexAttribs4fvNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribs4fvNV = (dgtk.OpenGL.delegatesGLes.glVertexAttribs4fvNV) InternalTool.GetGLesMethodAdress("glVertexAttribs4fvNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribs4fvNV));
			}
			if (SuportedExt.Contains("glVertexAttribs4hvNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribs4hvNV = (dgtk.OpenGL.delegatesGLes.glVertexAttribs4hvNV) InternalTool.GetGLesMethodAdress("glVertexAttribs4hvNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribs4hvNV));
			}
			if (SuportedExt.Contains("glVertexAttribs4svNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribs4svNV = (dgtk.OpenGL.delegatesGLes.glVertexAttribs4svNV) InternalTool.GetGLesMethodAdress("glVertexAttribs4svNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribs4svNV));
			}
			if (SuportedExt.Contains("glVertexAttribs4ubvNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexAttribs4ubvNV = (dgtk.OpenGL.delegatesGLes.glVertexAttribs4ubvNV) InternalTool.GetGLesMethodAdress("glVertexAttribs4ubvNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexAttribs4ubvNV));
			}
			if (SuportedExt.Contains("glVertexBlendARB"))
			{
				dgtk.OpenGL.internalGLes.glVertexBlendARB = (dgtk.OpenGL.delegatesGLes.glVertexBlendARB) InternalTool.GetGLesMethodAdress("glVertexBlendARB", typeof(dgtk.OpenGL.delegatesGLes.glVertexBlendARB));
			}
			if (SuportedExt.Contains("glVertexBlendEnvfATI"))
			{
				dgtk.OpenGL.internalGLes.glVertexBlendEnvfATI = (dgtk.OpenGL.delegatesGLes.glVertexBlendEnvfATI) InternalTool.GetGLesMethodAdress("glVertexBlendEnvfATI", typeof(dgtk.OpenGL.delegatesGLes.glVertexBlendEnvfATI));
			}
			if (SuportedExt.Contains("glVertexBlendEnviATI"))
			{
				dgtk.OpenGL.internalGLes.glVertexBlendEnviATI = (dgtk.OpenGL.delegatesGLes.glVertexBlendEnviATI) InternalTool.GetGLesMethodAdress("glVertexBlendEnviATI", typeof(dgtk.OpenGL.delegatesGLes.glVertexBlendEnviATI));
			}
			if (SuportedExt.Contains("glVertexFormatNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexFormatNV = (dgtk.OpenGL.delegatesGLes.glVertexFormatNV) InternalTool.GetGLesMethodAdress("glVertexFormatNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexFormatNV));
			}
			if (SuportedExt.Contains("glVertexPointerEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexPointerEXT = (dgtk.OpenGL.delegatesGLes.glVertexPointerEXT) InternalTool.GetGLesMethodAdress("glVertexPointerEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexPointerEXT));
			}
			if (SuportedExt.Contains("glVertexPointerListIBM"))
			{
				dgtk.OpenGL.internalGLes.glVertexPointerListIBM = (dgtk.OpenGL.delegatesGLes.glVertexPointerListIBM) InternalTool.GetGLesMethodAdress("glVertexPointerListIBM", typeof(dgtk.OpenGL.delegatesGLes.glVertexPointerListIBM));
			}
			if (SuportedExt.Contains("glVertexPointervINTEL"))
			{
				dgtk.OpenGL.internalGLes.glVertexPointervINTEL = (dgtk.OpenGL.delegatesGLes.glVertexPointervINTEL) InternalTool.GetGLesMethodAdress("glVertexPointervINTEL", typeof(dgtk.OpenGL.delegatesGLes.glVertexPointervINTEL));
			}
			if (SuportedExt.Contains("glVertexStream1dATI"))
			{
				dgtk.OpenGL.internalGLes.glVertexStream1dATI = (dgtk.OpenGL.delegatesGLes.glVertexStream1dATI) InternalTool.GetGLesMethodAdress("glVertexStream1dATI", typeof(dgtk.OpenGL.delegatesGLes.glVertexStream1dATI));
			}
			if (SuportedExt.Contains("glVertexStream1dvATI"))
			{
				dgtk.OpenGL.internalGLes.glVertexStream1dvATI = (dgtk.OpenGL.delegatesGLes.glVertexStream1dvATI) InternalTool.GetGLesMethodAdress("glVertexStream1dvATI", typeof(dgtk.OpenGL.delegatesGLes.glVertexStream1dvATI));
			}
			if (SuportedExt.Contains("glVertexStream1fATI"))
			{
				dgtk.OpenGL.internalGLes.glVertexStream1fATI = (dgtk.OpenGL.delegatesGLes.glVertexStream1fATI) InternalTool.GetGLesMethodAdress("glVertexStream1fATI", typeof(dgtk.OpenGL.delegatesGLes.glVertexStream1fATI));
			}
			if (SuportedExt.Contains("glVertexStream1fvATI"))
			{
				dgtk.OpenGL.internalGLes.glVertexStream1fvATI = (dgtk.OpenGL.delegatesGLes.glVertexStream1fvATI) InternalTool.GetGLesMethodAdress("glVertexStream1fvATI", typeof(dgtk.OpenGL.delegatesGLes.glVertexStream1fvATI));
			}
			if (SuportedExt.Contains("glVertexStream1iATI"))
			{
				dgtk.OpenGL.internalGLes.glVertexStream1iATI = (dgtk.OpenGL.delegatesGLes.glVertexStream1iATI) InternalTool.GetGLesMethodAdress("glVertexStream1iATI", typeof(dgtk.OpenGL.delegatesGLes.glVertexStream1iATI));
			}
			if (SuportedExt.Contains("glVertexStream1ivATI"))
			{
				dgtk.OpenGL.internalGLes.glVertexStream1ivATI = (dgtk.OpenGL.delegatesGLes.glVertexStream1ivATI) InternalTool.GetGLesMethodAdress("glVertexStream1ivATI", typeof(dgtk.OpenGL.delegatesGLes.glVertexStream1ivATI));
			}
			if (SuportedExt.Contains("glVertexStream1sATI"))
			{
				dgtk.OpenGL.internalGLes.glVertexStream1sATI = (dgtk.OpenGL.delegatesGLes.glVertexStream1sATI) InternalTool.GetGLesMethodAdress("glVertexStream1sATI", typeof(dgtk.OpenGL.delegatesGLes.glVertexStream1sATI));
			}
			if (SuportedExt.Contains("glVertexStream1svATI"))
			{
				dgtk.OpenGL.internalGLes.glVertexStream1svATI = (dgtk.OpenGL.delegatesGLes.glVertexStream1svATI) InternalTool.GetGLesMethodAdress("glVertexStream1svATI", typeof(dgtk.OpenGL.delegatesGLes.glVertexStream1svATI));
			}
			if (SuportedExt.Contains("glVertexStream2dATI"))
			{
				dgtk.OpenGL.internalGLes.glVertexStream2dATI = (dgtk.OpenGL.delegatesGLes.glVertexStream2dATI) InternalTool.GetGLesMethodAdress("glVertexStream2dATI", typeof(dgtk.OpenGL.delegatesGLes.glVertexStream2dATI));
			}
			if (SuportedExt.Contains("glVertexStream2dvATI"))
			{
				dgtk.OpenGL.internalGLes.glVertexStream2dvATI = (dgtk.OpenGL.delegatesGLes.glVertexStream2dvATI) InternalTool.GetGLesMethodAdress("glVertexStream2dvATI", typeof(dgtk.OpenGL.delegatesGLes.glVertexStream2dvATI));
			}
			if (SuportedExt.Contains("glVertexStream2fATI"))
			{
				dgtk.OpenGL.internalGLes.glVertexStream2fATI = (dgtk.OpenGL.delegatesGLes.glVertexStream2fATI) InternalTool.GetGLesMethodAdress("glVertexStream2fATI", typeof(dgtk.OpenGL.delegatesGLes.glVertexStream2fATI));
			}
			if (SuportedExt.Contains("glVertexStream2fvATI"))
			{
				dgtk.OpenGL.internalGLes.glVertexStream2fvATI = (dgtk.OpenGL.delegatesGLes.glVertexStream2fvATI) InternalTool.GetGLesMethodAdress("glVertexStream2fvATI", typeof(dgtk.OpenGL.delegatesGLes.glVertexStream2fvATI));
			}
			if (SuportedExt.Contains("glVertexStream2iATI"))
			{
				dgtk.OpenGL.internalGLes.glVertexStream2iATI = (dgtk.OpenGL.delegatesGLes.glVertexStream2iATI) InternalTool.GetGLesMethodAdress("glVertexStream2iATI", typeof(dgtk.OpenGL.delegatesGLes.glVertexStream2iATI));
			}
			if (SuportedExt.Contains("glVertexStream2ivATI"))
			{
				dgtk.OpenGL.internalGLes.glVertexStream2ivATI = (dgtk.OpenGL.delegatesGLes.glVertexStream2ivATI) InternalTool.GetGLesMethodAdress("glVertexStream2ivATI", typeof(dgtk.OpenGL.delegatesGLes.glVertexStream2ivATI));
			}
			if (SuportedExt.Contains("glVertexStream2sATI"))
			{
				dgtk.OpenGL.internalGLes.glVertexStream2sATI = (dgtk.OpenGL.delegatesGLes.glVertexStream2sATI) InternalTool.GetGLesMethodAdress("glVertexStream2sATI", typeof(dgtk.OpenGL.delegatesGLes.glVertexStream2sATI));
			}
			if (SuportedExt.Contains("glVertexStream2svATI"))
			{
				dgtk.OpenGL.internalGLes.glVertexStream2svATI = (dgtk.OpenGL.delegatesGLes.glVertexStream2svATI) InternalTool.GetGLesMethodAdress("glVertexStream2svATI", typeof(dgtk.OpenGL.delegatesGLes.glVertexStream2svATI));
			}
			if (SuportedExt.Contains("glVertexStream3dATI"))
			{
				dgtk.OpenGL.internalGLes.glVertexStream3dATI = (dgtk.OpenGL.delegatesGLes.glVertexStream3dATI) InternalTool.GetGLesMethodAdress("glVertexStream3dATI", typeof(dgtk.OpenGL.delegatesGLes.glVertexStream3dATI));
			}
			if (SuportedExt.Contains("glVertexStream3dvATI"))
			{
				dgtk.OpenGL.internalGLes.glVertexStream3dvATI = (dgtk.OpenGL.delegatesGLes.glVertexStream3dvATI) InternalTool.GetGLesMethodAdress("glVertexStream3dvATI", typeof(dgtk.OpenGL.delegatesGLes.glVertexStream3dvATI));
			}
			if (SuportedExt.Contains("glVertexStream3fATI"))
			{
				dgtk.OpenGL.internalGLes.glVertexStream3fATI = (dgtk.OpenGL.delegatesGLes.glVertexStream3fATI) InternalTool.GetGLesMethodAdress("glVertexStream3fATI", typeof(dgtk.OpenGL.delegatesGLes.glVertexStream3fATI));
			}
			if (SuportedExt.Contains("glVertexStream3fvATI"))
			{
				dgtk.OpenGL.internalGLes.glVertexStream3fvATI = (dgtk.OpenGL.delegatesGLes.glVertexStream3fvATI) InternalTool.GetGLesMethodAdress("glVertexStream3fvATI", typeof(dgtk.OpenGL.delegatesGLes.glVertexStream3fvATI));
			}
			if (SuportedExt.Contains("glVertexStream3iATI"))
			{
				dgtk.OpenGL.internalGLes.glVertexStream3iATI = (dgtk.OpenGL.delegatesGLes.glVertexStream3iATI) InternalTool.GetGLesMethodAdress("glVertexStream3iATI", typeof(dgtk.OpenGL.delegatesGLes.glVertexStream3iATI));
			}
			if (SuportedExt.Contains("glVertexStream3ivATI"))
			{
				dgtk.OpenGL.internalGLes.glVertexStream3ivATI = (dgtk.OpenGL.delegatesGLes.glVertexStream3ivATI) InternalTool.GetGLesMethodAdress("glVertexStream3ivATI", typeof(dgtk.OpenGL.delegatesGLes.glVertexStream3ivATI));
			}
			if (SuportedExt.Contains("glVertexStream3sATI"))
			{
				dgtk.OpenGL.internalGLes.glVertexStream3sATI = (dgtk.OpenGL.delegatesGLes.glVertexStream3sATI) InternalTool.GetGLesMethodAdress("glVertexStream3sATI", typeof(dgtk.OpenGL.delegatesGLes.glVertexStream3sATI));
			}
			if (SuportedExt.Contains("glVertexStream3svATI"))
			{
				dgtk.OpenGL.internalGLes.glVertexStream3svATI = (dgtk.OpenGL.delegatesGLes.glVertexStream3svATI) InternalTool.GetGLesMethodAdress("glVertexStream3svATI", typeof(dgtk.OpenGL.delegatesGLes.glVertexStream3svATI));
			}
			if (SuportedExt.Contains("glVertexStream4dATI"))
			{
				dgtk.OpenGL.internalGLes.glVertexStream4dATI = (dgtk.OpenGL.delegatesGLes.glVertexStream4dATI) InternalTool.GetGLesMethodAdress("glVertexStream4dATI", typeof(dgtk.OpenGL.delegatesGLes.glVertexStream4dATI));
			}
			if (SuportedExt.Contains("glVertexStream4dvATI"))
			{
				dgtk.OpenGL.internalGLes.glVertexStream4dvATI = (dgtk.OpenGL.delegatesGLes.glVertexStream4dvATI) InternalTool.GetGLesMethodAdress("glVertexStream4dvATI", typeof(dgtk.OpenGL.delegatesGLes.glVertexStream4dvATI));
			}
			if (SuportedExt.Contains("glVertexStream4fATI"))
			{
				dgtk.OpenGL.internalGLes.glVertexStream4fATI = (dgtk.OpenGL.delegatesGLes.glVertexStream4fATI) InternalTool.GetGLesMethodAdress("glVertexStream4fATI", typeof(dgtk.OpenGL.delegatesGLes.glVertexStream4fATI));
			}
			if (SuportedExt.Contains("glVertexStream4fvATI"))
			{
				dgtk.OpenGL.internalGLes.glVertexStream4fvATI = (dgtk.OpenGL.delegatesGLes.glVertexStream4fvATI) InternalTool.GetGLesMethodAdress("glVertexStream4fvATI", typeof(dgtk.OpenGL.delegatesGLes.glVertexStream4fvATI));
			}
			if (SuportedExt.Contains("glVertexStream4iATI"))
			{
				dgtk.OpenGL.internalGLes.glVertexStream4iATI = (dgtk.OpenGL.delegatesGLes.glVertexStream4iATI) InternalTool.GetGLesMethodAdress("glVertexStream4iATI", typeof(dgtk.OpenGL.delegatesGLes.glVertexStream4iATI));
			}
			if (SuportedExt.Contains("glVertexStream4ivATI"))
			{
				dgtk.OpenGL.internalGLes.glVertexStream4ivATI = (dgtk.OpenGL.delegatesGLes.glVertexStream4ivATI) InternalTool.GetGLesMethodAdress("glVertexStream4ivATI", typeof(dgtk.OpenGL.delegatesGLes.glVertexStream4ivATI));
			}
			if (SuportedExt.Contains("glVertexStream4sATI"))
			{
				dgtk.OpenGL.internalGLes.glVertexStream4sATI = (dgtk.OpenGL.delegatesGLes.glVertexStream4sATI) InternalTool.GetGLesMethodAdress("glVertexStream4sATI", typeof(dgtk.OpenGL.delegatesGLes.glVertexStream4sATI));
			}
			if (SuportedExt.Contains("glVertexStream4svATI"))
			{
				dgtk.OpenGL.internalGLes.glVertexStream4svATI = (dgtk.OpenGL.delegatesGLes.glVertexStream4svATI) InternalTool.GetGLesMethodAdress("glVertexStream4svATI", typeof(dgtk.OpenGL.delegatesGLes.glVertexStream4svATI));
			}
			if (SuportedExt.Contains("glVertexWeightfEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexWeightfEXT = (dgtk.OpenGL.delegatesGLes.glVertexWeightfEXT) InternalTool.GetGLesMethodAdress("glVertexWeightfEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexWeightfEXT));
			}
			if (SuportedExt.Contains("glVertexWeightfvEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexWeightfvEXT = (dgtk.OpenGL.delegatesGLes.glVertexWeightfvEXT) InternalTool.GetGLesMethodAdress("glVertexWeightfvEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexWeightfvEXT));
			}
			if (SuportedExt.Contains("glVertexWeighthNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexWeighthNV = (dgtk.OpenGL.delegatesGLes.glVertexWeighthNV) InternalTool.GetGLesMethodAdress("glVertexWeighthNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexWeighthNV));
			}
			if (SuportedExt.Contains("glVertexWeighthvNV"))
			{
				dgtk.OpenGL.internalGLes.glVertexWeighthvNV = (dgtk.OpenGL.delegatesGLes.glVertexWeighthvNV) InternalTool.GetGLesMethodAdress("glVertexWeighthvNV", typeof(dgtk.OpenGL.delegatesGLes.glVertexWeighthvNV));
			}
			if (SuportedExt.Contains("glVertexWeightPointerEXT"))
			{
				dgtk.OpenGL.internalGLes.glVertexWeightPointerEXT = (dgtk.OpenGL.delegatesGLes.glVertexWeightPointerEXT) InternalTool.GetGLesMethodAdress("glVertexWeightPointerEXT", typeof(dgtk.OpenGL.delegatesGLes.glVertexWeightPointerEXT));
			}
			if (SuportedExt.Contains("glVideoCaptureNV"))
			{
				dgtk.OpenGL.internalGLes.glVideoCaptureNV = (dgtk.OpenGL.delegatesGLes.glVideoCaptureNV) InternalTool.GetGLesMethodAdress("glVideoCaptureNV", typeof(dgtk.OpenGL.delegatesGLes.glVideoCaptureNV));
			}
			if (SuportedExt.Contains("glVideoCaptureStreamParameterdvNV"))
			{
				dgtk.OpenGL.internalGLes.glVideoCaptureStreamParameterdvNV = (dgtk.OpenGL.delegatesGLes.glVideoCaptureStreamParameterdvNV) InternalTool.GetGLesMethodAdress("glVideoCaptureStreamParameterdvNV", typeof(dgtk.OpenGL.delegatesGLes.glVideoCaptureStreamParameterdvNV));
			}
			if (SuportedExt.Contains("glVideoCaptureStreamParameterfvNV"))
			{
				dgtk.OpenGL.internalGLes.glVideoCaptureStreamParameterfvNV = (dgtk.OpenGL.delegatesGLes.glVideoCaptureStreamParameterfvNV) InternalTool.GetGLesMethodAdress("glVideoCaptureStreamParameterfvNV", typeof(dgtk.OpenGL.delegatesGLes.glVideoCaptureStreamParameterfvNV));
			}
			if (SuportedExt.Contains("glVideoCaptureStreamParameterivNV"))
			{
				dgtk.OpenGL.internalGLes.glVideoCaptureStreamParameterivNV = (dgtk.OpenGL.delegatesGLes.glVideoCaptureStreamParameterivNV) InternalTool.GetGLesMethodAdress("glVideoCaptureStreamParameterivNV", typeof(dgtk.OpenGL.delegatesGLes.glVideoCaptureStreamParameterivNV));
			}
			if (SuportedExt.Contains("glViewportArrayvNV"))
			{
				dgtk.OpenGL.internalGLes.glViewportArrayvNV = (dgtk.OpenGL.delegatesGLes.glViewportArrayvNV) InternalTool.GetGLesMethodAdress("glViewportArrayvNV", typeof(dgtk.OpenGL.delegatesGLes.glViewportArrayvNV));
			}
			if (SuportedExt.Contains("glViewportArrayvOES"))
			{
				dgtk.OpenGL.internalGLes.glViewportArrayvOES = (dgtk.OpenGL.delegatesGLes.glViewportArrayvOES) InternalTool.GetGLesMethodAdress("glViewportArrayvOES", typeof(dgtk.OpenGL.delegatesGLes.glViewportArrayvOES));
			}
			if (SuportedExt.Contains("glViewportIndexedfNV"))
			{
				dgtk.OpenGL.internalGLes.glViewportIndexedfNV = (dgtk.OpenGL.delegatesGLes.glViewportIndexedfNV) InternalTool.GetGLesMethodAdress("glViewportIndexedfNV", typeof(dgtk.OpenGL.delegatesGLes.glViewportIndexedfNV));
			}
			if (SuportedExt.Contains("glViewportIndexedfOES"))
			{
				dgtk.OpenGL.internalGLes.glViewportIndexedfOES = (dgtk.OpenGL.delegatesGLes.glViewportIndexedfOES) InternalTool.GetGLesMethodAdress("glViewportIndexedfOES", typeof(dgtk.OpenGL.delegatesGLes.glViewportIndexedfOES));
			}
			if (SuportedExt.Contains("glViewportIndexedfvNV"))
			{
				dgtk.OpenGL.internalGLes.glViewportIndexedfvNV = (dgtk.OpenGL.delegatesGLes.glViewportIndexedfvNV) InternalTool.GetGLesMethodAdress("glViewportIndexedfvNV", typeof(dgtk.OpenGL.delegatesGLes.glViewportIndexedfvNV));
			}
			if (SuportedExt.Contains("glViewportIndexedfvOES"))
			{
				dgtk.OpenGL.internalGLes.glViewportIndexedfvOES = (dgtk.OpenGL.delegatesGLes.glViewportIndexedfvOES) InternalTool.GetGLesMethodAdress("glViewportIndexedfvOES", typeof(dgtk.OpenGL.delegatesGLes.glViewportIndexedfvOES));
			}
			if (SuportedExt.Contains("glViewportPositionWScaleNV"))
			{
				dgtk.OpenGL.internalGLes.glViewportPositionWScaleNV = (dgtk.OpenGL.delegatesGLes.glViewportPositionWScaleNV) InternalTool.GetGLesMethodAdress("glViewportPositionWScaleNV", typeof(dgtk.OpenGL.delegatesGLes.glViewportPositionWScaleNV));
			}
			if (SuportedExt.Contains("glViewportSwizzleNV"))
			{
				dgtk.OpenGL.internalGLes.glViewportSwizzleNV = (dgtk.OpenGL.delegatesGLes.glViewportSwizzleNV) InternalTool.GetGLesMethodAdress("glViewportSwizzleNV", typeof(dgtk.OpenGL.delegatesGLes.glViewportSwizzleNV));
			}
			#endregion

			#region W:

			if (SuportedExt.Contains("glWaitSemaphoreEXT"))
			{
				dgtk.OpenGL.internalGLes.glWaitSemaphoreEXT = (dgtk.OpenGL.delegatesGLes.glWaitSemaphoreEXT) InternalTool.GetGLesMethodAdress("glWaitSemaphoreEXT", typeof(dgtk.OpenGL.delegatesGLes.glWaitSemaphoreEXT));
			}
			if (SuportedExt.Contains("glWaitSemaphoreui64NVX"))
			{
				dgtk.OpenGL.internalGLes.glWaitSemaphoreui64NVX = (dgtk.OpenGL.delegatesGLes.glWaitSemaphoreui64NVX) InternalTool.GetGLesMethodAdress("glWaitSemaphoreui64NVX", typeof(dgtk.OpenGL.delegatesGLes.glWaitSemaphoreui64NVX));
			}
			if (SuportedExt.Contains("glWaitSyncAPPLE"))
			{
				dgtk.OpenGL.internalGLes.glWaitSyncAPPLE = (dgtk.OpenGL.delegatesGLes.glWaitSyncAPPLE) InternalTool.GetGLesMethodAdress("glWaitSyncAPPLE", typeof(dgtk.OpenGL.delegatesGLes.glWaitSyncAPPLE));
			}
			if (SuportedExt.Contains("glWaitVkSemaphoreNV"))
			{
				dgtk.OpenGL.internalGLes.glWaitVkSemaphoreNV = (dgtk.OpenGL.delegatesGLes.glWaitVkSemaphoreNV) InternalTool.GetGLesMethodAdress("glWaitVkSemaphoreNV", typeof(dgtk.OpenGL.delegatesGLes.glWaitVkSemaphoreNV));
			}
			if (SuportedExt.Contains("glWeightbvARB"))
			{
				dgtk.OpenGL.internalGLes.glWeightbvARB = (dgtk.OpenGL.delegatesGLes.glWeightbvARB) InternalTool.GetGLesMethodAdress("glWeightbvARB", typeof(dgtk.OpenGL.delegatesGLes.glWeightbvARB));
			}
			if (SuportedExt.Contains("glWeightdvARB"))
			{
				dgtk.OpenGL.internalGLes.glWeightdvARB = (dgtk.OpenGL.delegatesGLes.glWeightdvARB) InternalTool.GetGLesMethodAdress("glWeightdvARB", typeof(dgtk.OpenGL.delegatesGLes.glWeightdvARB));
			}
			if (SuportedExt.Contains("glWeightfvARB"))
			{
				dgtk.OpenGL.internalGLes.glWeightfvARB = (dgtk.OpenGL.delegatesGLes.glWeightfvARB) InternalTool.GetGLesMethodAdress("glWeightfvARB", typeof(dgtk.OpenGL.delegatesGLes.glWeightfvARB));
			}
			if (SuportedExt.Contains("glWeightivARB"))
			{
				dgtk.OpenGL.internalGLes.glWeightivARB = (dgtk.OpenGL.delegatesGLes.glWeightivARB) InternalTool.GetGLesMethodAdress("glWeightivARB", typeof(dgtk.OpenGL.delegatesGLes.glWeightivARB));
			}
			if (SuportedExt.Contains("glWeightPathsNV"))
			{
				dgtk.OpenGL.internalGLes.glWeightPathsNV = (dgtk.OpenGL.delegatesGLes.glWeightPathsNV) InternalTool.GetGLesMethodAdress("glWeightPathsNV", typeof(dgtk.OpenGL.delegatesGLes.glWeightPathsNV));
			}
			if (SuportedExt.Contains("glWeightPointerARB"))
			{
				dgtk.OpenGL.internalGLes.glWeightPointerARB = (dgtk.OpenGL.delegatesGLes.glWeightPointerARB) InternalTool.GetGLesMethodAdress("glWeightPointerARB", typeof(dgtk.OpenGL.delegatesGLes.glWeightPointerARB));
			}
			if (SuportedExt.Contains("glWeightPointerOES"))
			{
				dgtk.OpenGL.internalGLes.glWeightPointerOES = (dgtk.OpenGL.delegatesGLes.glWeightPointerOES) InternalTool.GetGLesMethodAdress("glWeightPointerOES", typeof(dgtk.OpenGL.delegatesGLes.glWeightPointerOES));
			}
			if (SuportedExt.Contains("glWeightsvARB"))
			{
				dgtk.OpenGL.internalGLes.glWeightsvARB = (dgtk.OpenGL.delegatesGLes.glWeightsvARB) InternalTool.GetGLesMethodAdress("glWeightsvARB", typeof(dgtk.OpenGL.delegatesGLes.glWeightsvARB));
			}
			if (SuportedExt.Contains("glWeightubvARB"))
			{
				dgtk.OpenGL.internalGLes.glWeightubvARB = (dgtk.OpenGL.delegatesGLes.glWeightubvARB) InternalTool.GetGLesMethodAdress("glWeightubvARB", typeof(dgtk.OpenGL.delegatesGLes.glWeightubvARB));
			}
			if (SuportedExt.Contains("glWeightuivARB"))
			{
				dgtk.OpenGL.internalGLes.glWeightuivARB = (dgtk.OpenGL.delegatesGLes.glWeightuivARB) InternalTool.GetGLesMethodAdress("glWeightuivARB", typeof(dgtk.OpenGL.delegatesGLes.glWeightuivARB));
			}
			if (SuportedExt.Contains("glWeightusvARB"))
			{
				dgtk.OpenGL.internalGLes.glWeightusvARB = (dgtk.OpenGL.delegatesGLes.glWeightusvARB) InternalTool.GetGLesMethodAdress("glWeightusvARB", typeof(dgtk.OpenGL.delegatesGLes.glWeightusvARB));
			}
			if (SuportedExt.Contains("glWindowPos2dARB"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos2dARB = (dgtk.OpenGL.delegatesGLes.glWindowPos2dARB) InternalTool.GetGLesMethodAdress("glWindowPos2dARB", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos2dARB));
			}
			if (SuportedExt.Contains("glWindowPos2dMESA"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos2dMESA = (dgtk.OpenGL.delegatesGLes.glWindowPos2dMESA) InternalTool.GetGLesMethodAdress("glWindowPos2dMESA", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos2dMESA));
			}
			if (SuportedExt.Contains("glWindowPos2dvARB"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos2dvARB = (dgtk.OpenGL.delegatesGLes.glWindowPos2dvARB) InternalTool.GetGLesMethodAdress("glWindowPos2dvARB", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos2dvARB));
			}
			if (SuportedExt.Contains("glWindowPos2dvMESA"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos2dvMESA = (dgtk.OpenGL.delegatesGLes.glWindowPos2dvMESA) InternalTool.GetGLesMethodAdress("glWindowPos2dvMESA", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos2dvMESA));
			}
			if (SuportedExt.Contains("glWindowPos2fARB"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos2fARB = (dgtk.OpenGL.delegatesGLes.glWindowPos2fARB) InternalTool.GetGLesMethodAdress("glWindowPos2fARB", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos2fARB));
			}
			if (SuportedExt.Contains("glWindowPos2fMESA"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos2fMESA = (dgtk.OpenGL.delegatesGLes.glWindowPos2fMESA) InternalTool.GetGLesMethodAdress("glWindowPos2fMESA", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos2fMESA));
			}
			if (SuportedExt.Contains("glWindowPos2fvARB"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos2fvARB = (dgtk.OpenGL.delegatesGLes.glWindowPos2fvARB) InternalTool.GetGLesMethodAdress("glWindowPos2fvARB", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos2fvARB));
			}
			if (SuportedExt.Contains("glWindowPos2fvMESA"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos2fvMESA = (dgtk.OpenGL.delegatesGLes.glWindowPos2fvMESA) InternalTool.GetGLesMethodAdress("glWindowPos2fvMESA", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos2fvMESA));
			}
			if (SuportedExt.Contains("glWindowPos2iARB"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos2iARB = (dgtk.OpenGL.delegatesGLes.glWindowPos2iARB) InternalTool.GetGLesMethodAdress("glWindowPos2iARB", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos2iARB));
			}
			if (SuportedExt.Contains("glWindowPos2iMESA"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos2iMESA = (dgtk.OpenGL.delegatesGLes.glWindowPos2iMESA) InternalTool.GetGLesMethodAdress("glWindowPos2iMESA", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos2iMESA));
			}
			if (SuportedExt.Contains("glWindowPos2ivARB"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos2ivARB = (dgtk.OpenGL.delegatesGLes.glWindowPos2ivARB) InternalTool.GetGLesMethodAdress("glWindowPos2ivARB", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos2ivARB));
			}
			if (SuportedExt.Contains("glWindowPos2ivMESA"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos2ivMESA = (dgtk.OpenGL.delegatesGLes.glWindowPos2ivMESA) InternalTool.GetGLesMethodAdress("glWindowPos2ivMESA", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos2ivMESA));
			}
			if (SuportedExt.Contains("glWindowPos2sARB"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos2sARB = (dgtk.OpenGL.delegatesGLes.glWindowPos2sARB) InternalTool.GetGLesMethodAdress("glWindowPos2sARB", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos2sARB));
			}
			if (SuportedExt.Contains("glWindowPos2sMESA"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos2sMESA = (dgtk.OpenGL.delegatesGLes.glWindowPos2sMESA) InternalTool.GetGLesMethodAdress("glWindowPos2sMESA", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos2sMESA));
			}
			if (SuportedExt.Contains("glWindowPos2svARB"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos2svARB = (dgtk.OpenGL.delegatesGLes.glWindowPos2svARB) InternalTool.GetGLesMethodAdress("glWindowPos2svARB", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos2svARB));
			}
			if (SuportedExt.Contains("glWindowPos2svMESA"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos2svMESA = (dgtk.OpenGL.delegatesGLes.glWindowPos2svMESA) InternalTool.GetGLesMethodAdress("glWindowPos2svMESA", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos2svMESA));
			}
			if (SuportedExt.Contains("glWindowPos3dARB"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos3dARB = (dgtk.OpenGL.delegatesGLes.glWindowPos3dARB) InternalTool.GetGLesMethodAdress("glWindowPos3dARB", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos3dARB));
			}
			if (SuportedExt.Contains("glWindowPos3dMESA"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos3dMESA = (dgtk.OpenGL.delegatesGLes.glWindowPos3dMESA) InternalTool.GetGLesMethodAdress("glWindowPos3dMESA", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos3dMESA));
			}
			if (SuportedExt.Contains("glWindowPos3dvARB"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos3dvARB = (dgtk.OpenGL.delegatesGLes.glWindowPos3dvARB) InternalTool.GetGLesMethodAdress("glWindowPos3dvARB", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos3dvARB));
			}
			if (SuportedExt.Contains("glWindowPos3dvMESA"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos3dvMESA = (dgtk.OpenGL.delegatesGLes.glWindowPos3dvMESA) InternalTool.GetGLesMethodAdress("glWindowPos3dvMESA", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos3dvMESA));
			}
			if (SuportedExt.Contains("glWindowPos3fARB"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos3fARB = (dgtk.OpenGL.delegatesGLes.glWindowPos3fARB) InternalTool.GetGLesMethodAdress("glWindowPos3fARB", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos3fARB));
			}
			if (SuportedExt.Contains("glWindowPos3fMESA"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos3fMESA = (dgtk.OpenGL.delegatesGLes.glWindowPos3fMESA) InternalTool.GetGLesMethodAdress("glWindowPos3fMESA", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos3fMESA));
			}
			if (SuportedExt.Contains("glWindowPos3fvARB"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos3fvARB = (dgtk.OpenGL.delegatesGLes.glWindowPos3fvARB) InternalTool.GetGLesMethodAdress("glWindowPos3fvARB", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos3fvARB));
			}
			if (SuportedExt.Contains("glWindowPos3fvMESA"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos3fvMESA = (dgtk.OpenGL.delegatesGLes.glWindowPos3fvMESA) InternalTool.GetGLesMethodAdress("glWindowPos3fvMESA", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos3fvMESA));
			}
			if (SuportedExt.Contains("glWindowPos3iARB"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos3iARB = (dgtk.OpenGL.delegatesGLes.glWindowPos3iARB) InternalTool.GetGLesMethodAdress("glWindowPos3iARB", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos3iARB));
			}
			if (SuportedExt.Contains("glWindowPos3iMESA"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos3iMESA = (dgtk.OpenGL.delegatesGLes.glWindowPos3iMESA) InternalTool.GetGLesMethodAdress("glWindowPos3iMESA", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos3iMESA));
			}
			if (SuportedExt.Contains("glWindowPos3ivARB"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos3ivARB = (dgtk.OpenGL.delegatesGLes.glWindowPos3ivARB) InternalTool.GetGLesMethodAdress("glWindowPos3ivARB", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos3ivARB));
			}
			if (SuportedExt.Contains("glWindowPos3ivMESA"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos3ivMESA = (dgtk.OpenGL.delegatesGLes.glWindowPos3ivMESA) InternalTool.GetGLesMethodAdress("glWindowPos3ivMESA", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos3ivMESA));
			}
			if (SuportedExt.Contains("glWindowPos3sARB"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos3sARB = (dgtk.OpenGL.delegatesGLes.glWindowPos3sARB) InternalTool.GetGLesMethodAdress("glWindowPos3sARB", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos3sARB));
			}
			if (SuportedExt.Contains("glWindowPos3sMESA"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos3sMESA = (dgtk.OpenGL.delegatesGLes.glWindowPos3sMESA) InternalTool.GetGLesMethodAdress("glWindowPos3sMESA", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos3sMESA));
			}
			if (SuportedExt.Contains("glWindowPos3svARB"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos3svARB = (dgtk.OpenGL.delegatesGLes.glWindowPos3svARB) InternalTool.GetGLesMethodAdress("glWindowPos3svARB", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos3svARB));
			}
			if (SuportedExt.Contains("glWindowPos3svMESA"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos3svMESA = (dgtk.OpenGL.delegatesGLes.glWindowPos3svMESA) InternalTool.GetGLesMethodAdress("glWindowPos3svMESA", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos3svMESA));
			}
			if (SuportedExt.Contains("glWindowPos4dMESA"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos4dMESA = (dgtk.OpenGL.delegatesGLes.glWindowPos4dMESA) InternalTool.GetGLesMethodAdress("glWindowPos4dMESA", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos4dMESA));
			}
			if (SuportedExt.Contains("glWindowPos4dvMESA"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos4dvMESA = (dgtk.OpenGL.delegatesGLes.glWindowPos4dvMESA) InternalTool.GetGLesMethodAdress("glWindowPos4dvMESA", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos4dvMESA));
			}
			if (SuportedExt.Contains("glWindowPos4fMESA"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos4fMESA = (dgtk.OpenGL.delegatesGLes.glWindowPos4fMESA) InternalTool.GetGLesMethodAdress("glWindowPos4fMESA", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos4fMESA));
			}
			if (SuportedExt.Contains("glWindowPos4fvMESA"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos4fvMESA = (dgtk.OpenGL.delegatesGLes.glWindowPos4fvMESA) InternalTool.GetGLesMethodAdress("glWindowPos4fvMESA", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos4fvMESA));
			}
			if (SuportedExt.Contains("glWindowPos4iMESA"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos4iMESA = (dgtk.OpenGL.delegatesGLes.glWindowPos4iMESA) InternalTool.GetGLesMethodAdress("glWindowPos4iMESA", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos4iMESA));
			}
			if (SuportedExt.Contains("glWindowPos4ivMESA"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos4ivMESA = (dgtk.OpenGL.delegatesGLes.glWindowPos4ivMESA) InternalTool.GetGLesMethodAdress("glWindowPos4ivMESA", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos4ivMESA));
			}
			if (SuportedExt.Contains("glWindowPos4sMESA"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos4sMESA = (dgtk.OpenGL.delegatesGLes.glWindowPos4sMESA) InternalTool.GetGLesMethodAdress("glWindowPos4sMESA", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos4sMESA));
			}
			if (SuportedExt.Contains("glWindowPos4svMESA"))
			{
				dgtk.OpenGL.internalGLes.glWindowPos4svMESA = (dgtk.OpenGL.delegatesGLes.glWindowPos4svMESA) InternalTool.GetGLesMethodAdress("glWindowPos4svMESA", typeof(dgtk.OpenGL.delegatesGLes.glWindowPos4svMESA));
			}
			if (SuportedExt.Contains("glWindowRectanglesEXT"))
			{
				dgtk.OpenGL.internalGLes.glWindowRectanglesEXT = (dgtk.OpenGL.delegatesGLes.glWindowRectanglesEXT) InternalTool.GetGLesMethodAdress("glWindowRectanglesEXT", typeof(dgtk.OpenGL.delegatesGLes.glWindowRectanglesEXT));
			}
			if (SuportedExt.Contains("glWriteMaskEXT"))
			{
				dgtk.OpenGL.internalGLes.glWriteMaskEXT = (dgtk.OpenGL.delegatesGLes.glWriteMaskEXT) InternalTool.GetGLesMethodAdress("glWriteMaskEXT", typeof(dgtk.OpenGL.delegatesGLes.glWriteMaskEXT));
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

