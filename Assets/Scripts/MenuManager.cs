using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Slider ampSlider;
    public Slider waveOneSlider;
    public Slider waveTwoSlider;
    private WaveGenerator wg;
    private void Start()
    {
        ampSlider.onValueChanged.AddListener(UpdateAmplitude);
        waveOneSlider.onValueChanged.AddListener(UpdateWavelength);
        waveTwoSlider.onValueChanged.AddListener(UpdateSecWavelength);
        wg = FindObjectOfType<WaveGenerator>();
    }

    public void UpdateAmplitude(float sliderValue)
    {
        wg.SetAmplitude(sliderValue);
    }
    
    public void UpdateWavelength(float sliderValue)
    {
        wg.SetWavelength(sliderValue);
    }
    
    public void UpdateSecWavelength(float sliderValue)
    {
        wg.SetSecWaveLength(sliderValue);
    }
}
