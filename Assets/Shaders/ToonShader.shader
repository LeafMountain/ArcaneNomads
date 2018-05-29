Shader "TreeBranch/Toon/Dynamic" 
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

		// Outline
		_OutlineColor("Outline Color", Color) = (0, 0, 0, 0)
		_OutlineWidth("Outline Width", Range(0.0, 0.10)) = 0
	}

	CGINCLUDE
	#include "UnityCG.cginc"

		struct appdata {
			float4 vertex : POSITION;
			float3 normal :  NORMAL;
			float4 texcoord : TEXCOORD0;
		};

		struct v2f {
			float4 pos : SV_POSITION;
			UNITY_FOG_COORDS(0)
			fixed4 color : COLOR;
		};

		float _OutlineWidth;
		float4 _OutlineColor;
		float _OutlineZ;

		v2f vert (appdata v){
			v2f o;
			o.pos = UnityObjectToClipPos(v.vertex);

			//Creates an offest to expand from center of mesh
			float3 norm = normalize(mul((float3x3)UNITY_MATRIX_IT_MV, v.normal));
        	float2 offset = TransformViewToProjection(norm.xy);

			//Offests vertex by outline width (adjusted by offset)
			o.pos.xy += offset * _OutlineWidth;

			// o.pos.z += _OutlineZ;
        	UNITY_TRANSFER_FOG(o, o.pos);
		
			return o;
		}

	ENDCG

	// CGINCLUDE
	// #include "UnityCG.cginc"

	// half _OutlineWidth;
	// half4 _OutlineColor;

	// struct appdata 
	// {
	// 	half4 vertex : POSITION;
	// 	half4 uv : TEXCOORD0;
	// 	half3 normal : NORMAL;
	// 	fixed4 color : COLOR;
	// };

	// struct v2f 
	// {
	// 	half4 pos : POSITION;
	// 	half2 uv : TEXCOORD0;
	// 	fixed4 color : COLOR;
	// };
	// ENDCG

	SubShader 
	{
		Tags
		{ 
			"RenderType" = "Opaque"
		}
		LOD 200

		// Outline
		Pass 
		{
			Name "OUTLINE"
			Tags { "LightMode" = "Always" }
			Cull Front
			ZWrite On
			ColorMask RGB

			CGPROGRAM

				#pragma vertex vert
				#pragma fragment frag

				half4 frag(v2f i) : SV_TARGET{
					return _OutlineColor;
				}

			ENDCG

		}

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
	Fallback "TreeBranch/Toon/Static"
}
