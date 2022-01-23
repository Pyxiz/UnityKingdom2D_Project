using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public abstract class GUI_Active : MonoBehaviour {
    public Transform Player;
    public Transform MainCamera;
    public Transform SubCamera;
    public GameData Data;

    public void BtnPause_Handler() {
        IsPaused = !IsPaused;
        PnlPause.gameObject.SetActive(IsPaused);
        var button = PnlPause.Find("BtnNo");
        button.GetComponent<Button>().Select();
        Time.timeScale = IsPaused ? 0f : 1f;
    }

    public void BtnExit_Handler() {
        SceneManager.LoadScene("GameLobbyScene");
    }

    protected Transform PnlPause;
    protected bool IsPaused;

    protected abstract void InitializeComponent();
    protected abstract void GuiMonitor();

    private void Start() {
        InitializeComponent();
        PnlPause = transform.Find("PnlPause");
    }

    private void LateUpdate() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            BtnPause_Handler();
        }
        GuiMonitor();
    }
}
