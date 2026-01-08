Shader "Custom/shader"
{
    Properties
    {
        _MainTex ("Sprite Texture", 2D) = "white" {}
        _Palette ("Palette Texture", 2D) = "white" {}
    }
    SubShader
    {
        Tags { "RenderType"="Transparent" "Queue"="Transparent"}
        LOD 100
        Blend SrcAlpha OneMinusSrcAlpha
        Cull Off
        Lighting Off
        ZWrite Off

        Pass {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            struct appdata_t {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            sampler2D _Palette;

            v2f vert(appdata_t v) {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            // Helper function to find closest palette color
            fixed4 frag(v2f i) : SV_Target {
                fixed4 texColor = tex2D(_MainTex, i.uv);
                fixed4 closestColor = tex2D(_Palette, float2(0, 0));
                float minDist = 1000;

                // Sample the palette horizontally
                const int paletteSize = 16; // 4 for 4-color, 16 for 16-color
                for (int j = 0; j < paletteSize; j++) {
                    float u = (j + 0.5) / paletteSize;
                    fixed4 pColor = tex2D(_Palette, float2(u, 0));
                    float dist = distance(texColor.rgb, pColor.rgb);
                    if (dist < minDist) {
                        minDist = dist;
                        closestColor = pColor;
                    }
                }

                // Preserve original alpha
                closestColor.a = texColor.a;
                return closestColor;
            }
            ENDCG
        }
    }
}