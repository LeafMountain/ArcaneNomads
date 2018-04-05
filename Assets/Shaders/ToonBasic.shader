Shader "Custom/ToonBasic" {
	Properties {
		_MainTex ("Texture", 2D) = "white" {}
		_Color("Main Color", Color) = (0, 0, 0, 0)
		_Ramp("Toon Ramp (RGB)", 2D) = "gray" {}		

		_OutlineColor("Outline Color", Color) = (0, 0, 0, 0)
		_OutlineWidth("Outline Width", Range(0.0, 0.07)) = 0.015
		_OutlineZ("Outline Z", Range(-.002, 0)) = -.001
	}

	SubShader {
		Tags { "RenderType"="Opaque" }
		LOD 200
		Cull Off

		CGPROGRAM

		#pragma surface surf ToonRamp vertex:disp addshadow
		sampler2D _Ramp;

		#pragma lighting ToonRamp exclude_path:prepass
		inline half4 LightingToonRamp(SurfaceOutput s, half3 lightDir, half atten){
			#ifndef USING_DIRECTIONAL_LIGHT
			lightDir = normalize(lightDir);
			#endif

			half d = dot(s.Normal, lightDir) * 0.5 + 0.5;
			half3 ramp = tex2D(_Ramp, float2(d, d)).rgb;

			half4 c;
			c.rgb = s.Albedo * _LightColor0.rgb * ramp * (atten * 2);
			c.a = 0;
			return c;
		}

		sampler2D _MainTex;

		float4 _Color;
		float4 _OutlineColor;
		float _OutlineWidth;

		struct Input {
			float2 uv_MainTex : TEXCOORD0;
			float3 worldPos;
			float3 viewDir;
			float3 lightDir;
		};

		struct appdata {
			float4 vertex : POSITION;
			float3 normal : NORMAL;
		};

		void disp(inout appdata_full v, out Input o){
			UNITY_INITIALIZE_OUTPUT(Input, o);
			o.lightDir = WorldSpaceLightDir(v.vertex);

			v.vertex.xyz += v.normal * _OutlineWidth;
		}

		void surf(Input IN, inout SurfaceOutput o){
			half4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
			o.Albedo = c.rgb * _Color;
			o.Alpha = c.a;
		}


		ENDCG
	}
	FallBack "Diffuse"
}
