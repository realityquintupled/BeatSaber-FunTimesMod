using IllusionPlugin;
using System;
using System.Collections;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;
using PointyBoi = UnityEngine.Vector3;
using Random = UnityEngine.Random;

namespace FunTimesMod {
    public class Plugin : IPlugin {
        public string Name => "FunTimes Mod";
        public string Version => "v1337";
        private static AssetBundle noDontDoThisPlease;
        public void OnApplicationStart() {
            SceneManager.sceneLoaded += OnSceneLoaded;
            SceneManager.activeSceneChanged += OnActiveSceneChanged;
            noDontDoThisPlease = AssetBundle.LoadFromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("FunTimesMod.ThisIsAMistake.bundle"));
        }

        private void OnActiveSceneChanged(Scene arg0, Scene arg1) {
            if (noDontDoThisPlease == null) {
                return;
            }
            foreach(Camera lookyBoi in UnityEngine.Object.FindObjectsOfType<Camera>()) {
                NoDont ohGodNoPleaseWhy = lookyBoi.gameObject.AddComponent<NoDont>();
                Shader youllRegretThis = noDontDoThisPlease.LoadAsset<Shader>("sh_HueShift");
                if(youllRegretThis != null) {
                    ohGodNoPleaseWhy.youCantEscape = youllRegretThis;
                }
            }
        }

        private void OnSceneLoaded(Scene arg0, LoadSceneMode arg1) {
            new GameObject().AddComponent<WhyUnityYouPieceOfCrap>();
        }

        public void OnApplicationQuit() {
            SceneManager.sceneLoaded -= OnSceneLoaded;
            SceneManager.activeSceneChanged -= OnActiveSceneChanged;
        }

        public void OnLevelWasLoaded(int level) {
        }

        public void OnLevelWasInitialized(int level) {
        }

        public void OnUpdate() {
        }

        public void OnFixedUpdate() {
        }
    }

    public class WhyUnityYouPieceOfCrap : MonoBehaviour {
        public void Awake() {
            StartCoroutine(WaitBecauseWhyTheHeckNot());
        }
        private IEnumerator WaitBecauseWhyTheHeckNot() {
            yield return new WaitForSeconds(.25f);
            SpinSomeBois();
        }
        private void SpinSomeBois() {
            foreach (GameObject thot in FindObjectsOfType<GameObject>()) {
                if (thot.GetComponent<MeshRenderer>() != null && thot.GetComponent<Saber>() == null) {
                    thot.AddComponent<SpinnyBoi>();
                }
            }
        }
    }

    public class SpinnyBoi : MonoBehaviour {
        private PointyBoi maximumBorkDrive;
        private float hihgSpeeds;
        public void Awake() {
            maximumBorkDrive = new PointyBoi(Random.Range(-360, 360), Random.Range(-360, 360), Random.Range(-360, 360)).normalized;
            hihgSpeeds = Random.Range(30, 45);
        }
        public void Update() {
            gameObject.transform.rotation = Quaternion.Euler(gameObject.transform.rotation.eulerAngles + maximumBorkDrive * hihgSpeeds * Time.deltaTime);
        }
    }
}
