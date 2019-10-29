Shader "Custom/Sparks"
{
	Properties
	{
		_MainTex ("Texture", 2D) = "white" {}
		_Value("Value",Range(0.0,128.0)) = 1.0
		//_Color("Color", Color) = (1,1,1,1)								// define multiply color
	}
	SubShader
	{
		Tags { "RenderType"="Transparent" "Queue"="Transparent"}
		LOD 100
		Blend One One
		//Blend One OneMinusSrcAlpha
		//Zwrite Off
		Cull off

		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
				float4 color : COLOR; //<<<< added this line to access vertex colour from particle system
			};

			struct v2f
			{
				float2 uv : TEXCOORD0;
				float4 vertex : SV_POSITION;
				float4 color : COLOR; //<<<< added this line to access vertex colour from particle system
			};

			sampler2D _MainTex;
			float4 _MainTex_ST;
			float _Value;
			//float4 _Color;
			
			v2f vert (appdata v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.uv = TRANSFORM_TEX(v.uv, _MainTex);
				o.color = v.color;
				return o;
			}
			
			fixed4 frag (v2f i) : SV_Target
			{
				// sample the texture

				fixed4 col = tex2D(_MainTex, i.uv);
				col.rgb *= i.color.a;
				
				return col * _Value * i.color;
				//float uv = length(i.uv - .5);
				//return smoothstep(.5,0.4,uv)*smoothstep(.3,.4,uv)* _Value * i.color;
			}
			ENDCG
		}
	}
}
