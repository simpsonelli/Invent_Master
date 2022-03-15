using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmplitudeReader : MonoBehaviour
{
    [SerializeField] float m_amplitude = 0.5f;

    [SerializeField] Transform m_transform; //Something you want to change

    private float m_lerpedVal;

    public static float s_spectrumVal;
    private float[] m_audioSpectrum;
    // Use this for initialization
    void Awake()
    {
        m_audioSpectrum = new float[128];
    }

    // Update is called once per frame
    void Update()
    {
        AudioListener.GetSpectrumData(m_audioSpectrum, 0, FFTWindow.Hamming);

        if (m_audioSpectrum != null && m_audioSpectrum.Length > 0)
        {
            s_spectrumVal = m_audioSpectrum[0] * m_amplitude;
        }
        m_lerpedVal = Mathf.Lerp(m_lerpedVal, s_spectrumVal, .05f); //Something with s_spectrumVal
        m_transform.localScale = new Vector3(m_lerpedVal, m_lerpedVal, m_lerpedVal); 
    }
}
