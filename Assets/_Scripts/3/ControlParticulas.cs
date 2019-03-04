﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlParticulas : MonoBehaviour {

    public ParticleSystem ps;
    public float multiplicador;

    private float velocidad;

    void Update ()
    {
        velocidad = AudioSpectrum.bandBuffer[0] * multiplicador;

        var main = ps.main;
        main.simulationSpeed = velocidad;
	}
}