// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

Shader "Custom/ToonShader" {
	Properties {
		_MainTex ("Texture", 2D) = "white" {}
		// _RampTex ("Light Ramp", 2D) = "white" {}
		_Color("Main Color", Color) = (0, 0, 0, 0)

		_OutlineColor("Outline Color", Color) = (0, 0, 0, 0)
		_OutlineWidth("Outline Width", Range(0.0, 0.07)) = 0.015
		_OutlineZ("Outline Z", Range(-.002, 0)) = -.001
	}

	CGINCLUDE
	#include "UnityCG.cginc"

		struct appdata{
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

			o.pos.z += _OutlineZ;
        	UNITY_TRANSFER_FOG(o, o.pos);
		
			return o;
		}

	ENDCG

	SubShader {

		Tags{ 
			"RenderType" = "Opaque"
			// "Queue" = "Transparent" 
		}

        UsePass "Toon/Lit/FORWARD"

		//Outline
		Pass {
			Name "OUTLINE"
			Tags { "LightMode" = "Always" }
			Cull Off
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
		#pragma surface surf CelShadingForward
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

		struct Input {
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutput o) {
			// Albedo comes from a texture tinted by color
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}


	Fallback "Toon/Basic"
}
