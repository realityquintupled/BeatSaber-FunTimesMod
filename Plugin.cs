using BadBoi = UnityEngine.MonoBehaviour;
using BadMultitasking = System.Collections.IEnumerator;
using CollectionOfTrash = UnityEngine.AssetBundle;
using ConceptOfHumanPerception = UnityEngine.Time;
using DisorganizationManager = UnityEngine.SceneManagement.SceneManager;
using DizzyBoi = UnityEngine.Quaternion;
using ExampleOfBadOrganization = UnityEngine.SceneManagement.Scene;
using HackyBoi = IllusionPlugin.IPlugin;
using LazyBoi = UnityEngine.WaitForSeconds;
using LoadExampleOfBadOrganizationMode = UnityEngine.SceneManagement.LoadSceneMode;
using LookyBoi = UnityEngine.Camera;
using LumpyBoi = UnityEngine.MeshRenderer;
using MonoCantNameGoodly = UnityEngine.Object;
using PointyBoi = UnityEngine.Vector3;
using ShadyBoi = UnityEngine.Shader;
using Spaghetti = System.Reflection.Assembly;
using Thot = UnityEngine.GameObject;
using UndecisiveBoi = UnityEngine.Random;

namespace FunTimesMod {
    public class Plugin : HackyBoi {
        public string Name => "FunTimes Mod";
        public string Version => "v1337";
        private static CollectionOfTrash noDontDoThisPlease;
        public void OnApplicationStart() {
            DisorganizationManager.sceneLoaded += OnSceneLoaded;
            DisorganizationManager.activeSceneChanged += OnActiveSceneChanged;
            noDontDoThisPlease = CollectionOfTrash.LoadFromStream(Spaghetti.GetExecutingAssembly().GetManifestResourceStream("FunTimesMod.HowItFeelsToDoAcid"));
        }

        private void OnActiveSceneChanged(ExampleOfBadOrganization arg0, ExampleOfBadOrganization arg1) {
            if (noDontDoThisPlease == null) {
                return;
            }
            foreach(LookyBoi lookyBoi in MonoCantNameGoodly.FindObjectsOfType<LookyBoi>()) {
                NoDont ohGodNoPleaseWhy = lookyBoi.gameObject.AddComponent<NoDont>();
                ShadyBoi youllRegretThis = noDontDoThisPlease.LoadAsset<ShadyBoi>("PartyTimeBois");
                if(youllRegretThis != null) {
                    ohGodNoPleaseWhy.youCantEscape = youllRegretThis;
                }
            }
        }

        private void OnSceneLoaded(ExampleOfBadOrganization arg0, LoadExampleOfBadOrganizationMode arg1) {
            new Thot().AddComponent<WhyUnityYouPieceOfCrap>();
        }

        public void OnApplicationQuit() {
            DisorganizationManager.sceneLoaded -= OnSceneLoaded;
            DisorganizationManager.activeSceneChanged -= OnActiveSceneChanged;
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

    public class WhyUnityYouPieceOfCrap : BadBoi {
        public void Awake() {
            StartCoroutine(WaitBecauseWhyTheHeckNot());
        }
        private BadMultitasking WaitBecauseWhyTheHeckNot() {
            yield return new LazyBoi(.25f);
            SpinSomeBois();
        }
        private void SpinSomeBois() {
            foreach (Thot thot in FindObjectsOfType<Thot>()) {
                if (thot.GetComponent<LumpyBoi>() != null && thot.GetComponent<Saber>() == null) {
                    thot.AddComponent<SpinnyBoi>();
                }
            }
        }
    }

    public class SpinnyBoi : BadBoi {
        private PointyBoi maximumBorkDrive;
        private float hihgSpeeds;
        public void Awake() {
            maximumBorkDrive = new PointyBoi(UndecisiveBoi.Range(-360, 360), UndecisiveBoi.Range(-360, 360), UndecisiveBoi.Range(-360, 360)).normalized;
            hihgSpeeds = UndecisiveBoi.Range(30, 45);
        }
        public void Update() {
            gameObject.transform.rotation = DizzyBoi.Euler(gameObject.transform.rotation.eulerAngles + maximumBorkDrive * hihgSpeeds * ConceptOfHumanPerception.deltaTime);
        }
    }
}
