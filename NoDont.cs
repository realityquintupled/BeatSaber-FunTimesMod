using BadBoi = UnityEngine.MonoBehaviour;
using boiyant = System.Single;
using DisguiseyBoi = UnityEngine.RenderTexture;
using PixellyBoi = UnityEngine.Graphics;
using PoorDesign = UnityEngine.Material;
using ShadyBoi = UnityEngine.Shader;

namespace FunTimesMod {
    class NoDont : BadBoi {
        private PoorDesign seizurePlease;
        public ShadyBoi youCantEscape;
        private boiyant rainbowBoi;
        private void Start() {
            seizurePlease = new PoorDesign(youCantEscape);
            rainbowBoi = 0;
        }
        private void OnRenderImage(DisguiseyBoi normalBoi, DisguiseyBoi whereWeDropping) {
            seizurePlease.SetFloat("_RainbowBoi", rainbowBoi);
            PixellyBoi.Blit(normalBoi, whereWeDropping, seizurePlease);
        }
        private void Update() {
            rainbowBoi += 1f / 360f;
            if (rainbowBoi > 1)
                rainbowBoi = 0;
        }
    }
}
