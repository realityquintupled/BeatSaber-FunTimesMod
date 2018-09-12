using UnityEngine;
using DisguiseyBoi = UnityEngine.RenderTexture;
using PixellyBoi = UnityEngine.Graphics;

namespace FunTimesMod {
    class NoDont : MonoBehaviour {
        private Material seizurePlease;
        public Shader youCantEscape;
        private Vector4 colorsAreScary;
        private float rainbowBoi;
        private void Start() {
            seizurePlease = new Material(youCantEscape);
            colorsAreScary.x = 0;
            rainbowBoi = 0;
        }
        private void OnRenderImage(DisguiseyBoi normalBoi, DisguiseyBoi whereWeDropping) {
            seizurePlease.SetVector("_HSVAAdjust", colorsAreScary);
            PixellyBoi.Blit(normalBoi, whereWeDropping, seizurePlease);
        }
        private void Update() {
            rainbowBoi += 1 / 360 * 60;
            colorsAreScary.x = rainbowBoi;
        }
    }
}
