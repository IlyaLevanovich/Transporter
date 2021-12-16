using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.UI
{
    public class LevelTimer : MonoBehaviour
    {
        [SerializeField] private Image _timerBar;
        [SerializeField] private Text _totalScore, _mainScore;
        [SerializeField] private GameObject _totalWindow;
        private float _timer = 60;

        private void Update()
        {
            _timer -= Time.deltaTime;
            _timerBar.fillAmount = _timer / 60;
            if (_timer <= 0)
            {
                Pause();
                this.enabled = false;
            }
                
        }
        private void Pause()
        {
            _totalWindow.SetActive(true);
            _totalScore.text = "Total Score: " + _mainScore.text;
            Time.timeScale = 0;
        }
        public void Restart()
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(0);
        }

    }
}