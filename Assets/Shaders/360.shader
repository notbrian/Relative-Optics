Shader "Flipping Normals" {
    Properties {
        _MainTex ("Base (RGB)", 2D) = "white" {}
        _Alpha ("Alpha", Range(0,1)) = 1
    }
    SubShader {

        Tags { "RenderType" = "Opaque" }

        Cull Off

        CGPROGRAM

         half _Alpha;
        #pragma surface surf Lambert vertex:vert
        sampler2D _MainTex;

        struct Input {
            float2 uv_MainTex;
            float4 color : COLOR;
        };

        void vert(inout appdata_full v) {
            v.normal.xyz = v.normal * -1;
        }

        void surf (Input IN, inout SurfaceOutput o) {
             fixed3 result = tex2D(_MainTex, IN.uv_MainTex);
             o.Albedo = result.rgb;
             o.Alpha = _Alpha;
        }

        ENDCG

    }

      Fallback "Diffuse"
}