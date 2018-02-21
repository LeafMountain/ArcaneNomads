Shader "Custom/ToonShader" {
	Properties {
		_Texture ("Texture", 2D) = "white" {}
		_LightRamp ("Light Ramp", 2D) = "white" {}
		_Color("Color", Color) = (0, 0, 0, 0);
	}

	SubShader {
		//Properties
		sampler2D _Texture;
		sampler2D _LightRamp;

		half4 _Color;

		Tags {
			"Queue" = "Geomety"
			"RenderType" = "Opaque"
		}

		CGPPOGRAM

		ENDCG
	}
}
