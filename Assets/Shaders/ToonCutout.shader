// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'
// Upgrade NOTE: replaced '_World2Object' with 'unity_WorldToObject'

Shader "TreeBranch/ToonCutout" {
	Properties {
		_MainTex ("Color (RGB) Alpha (A)", 2D) = "white" {}
		_Color("Main Color", Color) = (0, 0, 0, 0)

		// Emission
		_EmissionMap("Emission Map", 2D) = "black" {}
		_Emission("Emission Color", Color) = (1, 1, 1, 1)

	}

	SubShader {

		Tags{ 
			"RenderType"="TransparentCutout"			
			"Queue"="Transparent" 
		}
		// Cull off
		// ZWrite Off
		// Blend SrcAlpha OneMinusSrcAlpha

		// Toon shading
		CGPROGRAM
		#pragma surface surf CelShadingForward alpha alphatest:_Cutoff addshadow
		#pragma target 3.0

		half4 LightingCelShadingForward(SurfaceOutput s, half3 lightDir, half atten) {
			half NdotL = dot(s.Normal, lightDir);
			if (NdotL <= 0.0) NdotL = 0;
			else NdotL = 1;
			half4 c;
			c.rgb = s.Albedo * _LightColor0.rgb * (NdotL * atten);
			c.a = s.Alpha;
			return c;
		}
		
		sampler2D _MainTex;
		fixed4 _Color;

		sampler2D _EmissionMap;
		fixed4 _Emission;

		struct Input {
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutput o) {
			fixed4 color = tex2D(_MainTex, IN.uv_MainTex) * _Color;
			fixed4 emission = tex2D(_EmissionMap, IN.uv_MainTex) * _Emission;

			o.Albedo = color.rgb;
			o.Alpha = color.a;
			o.Emission = emission;
		}
		ENDCG
	}


	Fallback "Toon/Basic"
}
