Shader "TreeBranch/Toon/Static" 
{
	Properties 
	{
		_MainTex ("Texture", 2D) = "white" {}
		_Color("Main Color", Color) = (0, 0, 0, 0)

		// Emission
		_EmissionMap("Emission Map", 2D) = "black" {}
		_Emission("Emission Color", Color) = (1, 1, 1, 1)

		// Light
		_LightRamp ("Light Ramp", 2D) = "white" {}		
	}

	SubShader 
	{
		Tags
		{ 
			"RenderType" = "Opaque"
		}
		LOD 200

		// Toon shading
		CGPROGRAM
		#pragma surface surf ToonRamp
		#pragma target 3.0

		sampler2D _MainTex;
		sampler2D _EmissionMap;
		sampler2D _LightRamp;
		
		fixed4 _Color;
		fixed4 _Emission;

		#pragma lighting ToonRamp exclude_path:prepass
		inline half4 LightingToonRamp (SurfaceOutput s, half3 lightDir, half atten)
        {
            #ifndef USING_DIRECTIONAL_LIGHT
            lightDir = normalize(lightDir);
            #endif
        
            half d = dot (s.Normal, lightDir)*0.5 + 0.5;
            half3 ramp = tex2D (_LightRamp, float2(d,d)).rgb;
        
            half4 c;
            c.rgb = s.Albedo * _LightColor0.rgb * ramp * (atten * 2);
            c.a = 0;
            return c;
        }		

		struct Input {
			float2 uv_MainTex : TEXCOORD0;
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
	Fallback "Diffuse"
}
