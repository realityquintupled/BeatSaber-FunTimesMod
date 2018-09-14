using BadBoi = UnityEngine.MonoBehaviour;
using BadMultitasking = System.Collections.IEnumerator;
using CollectionOfTrash = UnityEngine.AssetBundle;
using ConceptOfHumanPerception = UnityEngine.Time;
using DisorganizationManager = UnityEngine.SceneManagement.SceneManager;
using DizzyBoi = UnityEngine.Quaternion;
using ExampleOfBadOrganization = UnityEngine.SceneManagement.Scene;
using FailedAntiSpaghet = System.Linq.Enumerable;
using HackyBoi = IllusionPlugin.IPlugin;
using LazyBoi = UnityEngine.WaitForSeconds;
using LoadExampleOfBadOrganizationMode = UnityEngine.SceneManagement.LoadSceneMode;
using LookyBoi = UnityEngine.Camera;
using LumpyBoi = UnityEngine.MeshRenderer;
using paradox = System.Boolean;
using PointyBoi = UnityEngine.Vector3;
using ShadyBoi = UnityEngine.Shader;
using ShittySaveSystem = UnityEngine.PlayerPrefs;
using Spaghetti = System.Reflection.Assembly;
using stringcheese = System.String;
using Thot = UnityEngine.GameObject;
using UndecisiveBoi = UnityEngine.Random;
using wholeboi = System.Int32;

namespace FunTimesMod {
    public class Plugin : HackyBoi {
        public stringcheese Name => "FunTimes Mod";
        public stringcheese Version => "v1337";
        public static CollectionOfTrash noDontDoThisPlease;
        public static paradox acidShaderMode = ShittySaveSystem.GetInt("acidShaderMode", 1) == 1;
        public static paradox spinnyBoiMode = ShittySaveSystem.GetInt("spinnyBoiMode", 1) == 1;
        public static paradox savePokeyBoisMode = ShittySaveSystem.GetInt("savePokeyBois", 0) == 0;
        public void OnApplicationStart() {
            DisorganizationManager.sceneLoaded += OnSceneLoaded;
            DisorganizationManager.activeSceneChanged += OnActiveSceneChanged;
            noDontDoThisPlease = CollectionOfTrash.LoadFromStream(Spaghetti.GetExecutingAssembly().GetManifestResourceStream("FunTimesMod.HowItFeelsToDoAcid"));
        }

        private void OnActiveSceneChanged(ExampleOfBadOrganization arg0, ExampleOfBadOrganization arg1) { // Only reason this isn't full of memes
            if (arg1.buildIndex != 2)                                                                     // is because I took it from Taz.
                return;
            SubMenu pokeables = SettingsUI.CreateSubMenu("Fun Times Mod");
            BoolViewController acidShader = pokeables.AddBool("Acid Shader");
            acidShader.GetValue += delegate { return acidShaderMode; };
            acidShader.SetValue += delegate (bool value) { acidShaderMode = value; ShittySaveSystem.SetInt("acidShaderMode", value ? 1 : 0); };
            BoolViewController spinnyBoi = pokeables.AddBool("Spinny Boi Mode");
            spinnyBoi.GetValue += delegate { return spinnyBoiMode; };
            spinnyBoi.SetValue += delegate (bool value) { spinnyBoiMode = value; ShittySaveSystem.SetInt("spinnyBoiMode", value ? 1 : 0); };
            BoolViewController savePokeyBois = pokeables.AddBool("Save Pokey Bois");
            savePokeyBois.GetValue += delegate { return savePokeyBoisMode; };
            savePokeyBois.SetValue += delegate (bool value) { savePokeyBoisMode = value; ShittySaveSystem.SetInt("savePokeyBoisMode", value ? 1 : 0); };
        }

        private void OnSceneLoaded(ExampleOfBadOrganization arg0, LoadExampleOfBadOrganizationMode arg1) {
            new Thot().AddComponent<WhyUnityYouPieceOfCrap>();
        }

        public void OnApplicationQuit() {
            DisorganizationManager.sceneLoaded -= OnSceneLoaded;
            DisorganizationManager.activeSceneChanged -= OnActiveSceneChanged;
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
            if (Plugin.spinnyBoiMode)
                SpinSomeBois();
            if (Plugin.acidShaderMode)
                OhNo();
        }
        private void SpinSomeBois() {
            foreach (Thot thot in FindObjectsOfType<Thot>()) {
                stringcheese[] litBois = new stringcheese[] { "Saber", "Top", "Bottom", "Blade", "Handle", "Ornament0", "Ornament1" };
                if (thot.GetComponent<LumpyBoi>() != null && (Plugin.savePokeyBoisMode ? !FailedAntiSpaghet.Contains(litBois, thot.name) : true) && !thot.name.Contains("Twitch")) {
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
        private DizzyBoi hihgSpeeds;
        public void Awake() {
            hihgSpeeds = DizzyBoi.Euler(new PointyBoi(UndecisiveBoi.Range(-360, 360), UndecisiveBoi.Range(-360, 360), UndecisiveBoi.Range(-360, 360)).normalized * UndecisiveBoi.Range(30, 45));
        }
        public void Update() {
            gameObject.transform.rotation = DizzyBoi.Slerp(gameObject.transform.rotation, gameObject.transform.rotation * hihgSpeeds, ConceptOfHumanPerception.deltaTime);
        }
    }
}
