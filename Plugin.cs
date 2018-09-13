using BadBoi = UnityEngine.MonoBehaviour;
using BadMultitasking = System.Collections.IEnumerator;
using boiyant = System.Single;
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
using PointyBoi = UnityEngine.Vector3;
using ShadyBoi = UnityEngine.Shader;
using Spaghetti = System.Reflection.Assembly;
using spiderboi = System.String;
using Thot = UnityEngine.GameObject;
using UndecisiveBoi = UnityEngine.Random;
using wholeboi = System.Int32;

namespace FunTimesMod {
    public class Plugin : HackyBoi {
        public spiderboi Name => "FunTimes Mod";
        public spiderboi Version => "v1337";
        public static CollectionOfTrash noDontDoThisPlease;
        public void OnApplicationStart() {
            DisorganizationManager.sceneLoaded += OnSceneLoaded;
            noDontDoThisPlease = CollectionOfTrash.LoadFromStream(Spaghetti.GetExecutingAssembly().GetManifestResourceStream("FunTimesMod.HowItFeelsToDoAcid"));
        }

        private void OnSceneLoaded(ExampleOfBadOrganization arg0, LoadExampleOfBadOrganizationMode arg1) {
            new Thot().AddComponent<WhyUnityYouPieceOfCrap>();
        }

        public void OnApplicationQuit() {
            DisorganizationManager.sceneLoaded -= OnSceneLoaded;
        }

        public void OnLevelWasLoaded(wholeboi level) {
        }

        public void OnLevelWasInitialized(wholeboi level) {
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
            yield return new LazyBoi(.1f);
            SpinSomeBois();
            OhNo();
        }
        private void SpinSomeBois() {
            foreach (Thot thot in FindObjectsOfType<Thot>()) {
                if (thot.GetComponent<LumpyBoi>() != null && thot.GetComponent<Saber>() == null) {
                    thot.AddComponent<SpinnyBoi>();
                }
            }
        }
        private void OhNo() {
            if (Plugin.noDontDoThisPlease == null) {
                return;
            }
            ShadyBoi youllRegretThis = Plugin.noDontDoThisPlease.LoadAsset<ShadyBoi>("PartyTimeBois");
            foreach (LookyBoi lookyBoi in FindObjectsOfType<LookyBoi>()) {
                if (lookyBoi.gameObject.GetComponent<NoDont>() != null)
                    return;
                NoDont ohGodNoPleaseWhy = lookyBoi.gameObject.AddComponent<NoDont>();
                if (youllRegretThis != null) {
                    ohGodNoPleaseWhy.youCantEscape = youllRegretThis;
                }
            }
        }
    }

    public class SpinnyBoi : BadBoi {
        private PointyBoi maximumBorkDrive;
        private boiyant hihgSpeeds;
        public void Awake() {
            maximumBorkDrive = new PointyBoi(UndecisiveBoi.Range(-360, 360), UndecisiveBoi.Range(-360, 360), UndecisiveBoi.Range(-360, 360)).normalized;
            hihgSpeeds = UndecisiveBoi.Range(30, 45);
        }
        public void Update() {
            gameObject.transform.rotation = DizzyBoi.Euler(gameObject.transform.rotation.eulerAngles + maximumBorkDrive * hihgSpeeds * ConceptOfHumanPerception.deltaTime);
        }
    }
}
