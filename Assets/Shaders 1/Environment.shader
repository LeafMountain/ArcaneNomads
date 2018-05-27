﻿Shader "TreeBranch/Environment" {
	Properties {
		_Color ("Color", Color) = (1,1,1,1)
		_MainTex ("Albedo (RGB)", 2D) = "white" {}
		_Glossiness ("Smoothness", Range(0,1)) = 0.5
		_Metallic ("Metallic", Range(0,1)) = 0.0

		_NoiseTex ("Noise Texture (RGB)", 2D) = "white" {}
		_NoiseScale ("Noise Scale", Range(0.01, 5)) = 1
		_NoiseAmount ("Noise Amount", Range(0,1)) = 0.5

		_DecalTex ("Decal Texture (RGB)", 2D) = "white" {}
		_DecalScale ("Decal Scale", Range(0.01, 5)) = 1
		_DecalColor("Decal Color", Color) = (1,1,1,1)
	}
	SubShader {
		Tags { "RenderType"="Opaque" }
		LOD 200

		CGPROGRAM
		// Physically based Standard lighting model, and enable shadows on all light types
		#pragma surface surf Standard fullforwardshadows

		// Use shader model 3.0 target, to get nicer looking lighting
		#pragma target 3.0

		sampler2D _MainTex;
		sampler2D _NoiseTex;
		sampler2D _DecalTex;

		struct Input {
			float2 uv_MainTex;
			float3 worldPos;
		};

		half _Glossiness;
		half _Metallic;
		fixed4 _Color;
		fixed4 _DecalColor;
		half _NoiseAmount;
		half _NoiseScale;
		half _DecalScale;

		// Add instancing support for this shader. You need to check 'Enable Instancing' on materials that use the shader.
		// See https://docs.unity3d.com/Manual/GPUInstancing.html for more information about instancing.
		// #pragma instancing_options assumeuniformscaling
		UNITY_INSTANCING_BUFFER_START(Props)
			// put more per-instance properties here
		UNITY_INSTANCING_BUFFER_END(Props)

		void surf (Input IN, inout SurfaceOutputStandard o) {
			float3 xd = tex2D(_DecalTex, IN.worldPos.zy * _DecalScale) * _DecalColor;
			float3 zd = tex2D(_DecalTex, IN.worldPos.xy * _DecalScale) * _DecalColor;
			float3 yd = tex2D(_DecalTex, IN.worldPos.zx * _DecalScale) * _DecalColor;

			float3 xn = tex2D(_NoiseTex, IN.worldPos.zy * _NoiseScale);
			float3 zn = tex2D(_NoiseTex, IN.worldPos.xy * _NoiseScale);
			float3 yn = tex2D(_NoiseTex, IN.worldPos.zx * _NoiseScale);

			// float3 toptexture = zm;
			// toptexture = lerp(toptexture, xm, blendNormal.x);
			// toptexture = lerp(toptexture, ym, blendNormal.y);

			fixed4 mainTex = tex2D (_MainTex, IN.uv_MainTex) * _Color;

			o.Albedo = lerp(mainTex.rgb, xd.rgb, step(xn.r, step(mainTex.a, 0.5) * _NoiseAmount));
			o.Albedo = lerp(mainTex.rgb, zd.rgb, step(zn.r, step(mainTex.a, 0.5) * _NoiseAmount));
			o.Albedo = lerp(mainTex.rgb, yd.rgb, step(yn.r, step(mainTex.a, 0.5) * _NoiseAmount));
			
			// Metallic and smoothness come from slider variables
			o.Metallic = _Metallic;
			o.Smoothness = _Glossiness;
			// o.Alpha = mainTex.a;
		}
		ENDCG
	}
	FallBack "Diffuse"
}
