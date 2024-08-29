Shader "Unlit/UnlitExample"
{
    Properties //esta en la capa de unity, no esta en el codigo de graficos
    {
        _MainTex ("Texture", 2D) = "white" {}
        _Color ("Color", Color)=(1,1,1,1)
        _Intensity ("Intensity",Range(0,1))=0.5
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100
       //Cull front 
       //Renderiza las caras de adentro nada mas

        Pass 
        {
            //codigo de shaders HSLS
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            // make fog work
            //#pragma multi_compile_fog

            #include "UnityCG.cginc"

            struct appdata 
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f //datos que van del que modifica los vertices al color
            {
                float2 uv : TEXCOORD0;
                //UNITY_FOG_COORDS(1)
                float4 vertex : SV_POSITION;
            };

            //aqui hay que declarar variables para enchufar lo de la capa de unity 
            sampler2D _MainTex;
            float4 _MainTex_ST;
            float4 _Color;
            float4 _Intensity;

            v2f vert (appdata v) //datos del mesh al vert
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                //UNITY_TRANSFER_FOG(o,o.vertex);
                return o;
            }

            fixed4 frag (v2f i) : SV_Target  //modifica el color
            {
                // sample the texture
                fixed4 col = tex2D(_MainTex, i.uv);
                // apply fog
                //UNITY_APPLY_FOG(i.fogCoord, col);

                /**col.rgb=1;
                col.gb=0;
                col.yzx=0;
                col.x=1;
                
                **/
                col=col* _Color;

                return col;
            }
            ENDCG
        }
    }
}
