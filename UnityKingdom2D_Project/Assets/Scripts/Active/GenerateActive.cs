using System;
using UnityEngine;

public class GenerateActive : MonoBehaviour {
    public GameObject[] Creeps;
    public float DelayTime;
    
    public Action<Transform, string> GenerateAction { get; set; }

    public bool IsReadySpawn {
        set {
            if (value) {
                if (spawntime > 0) {
                    spawntime -= Time.deltaTime;
                }
                var gm = GameManager.Instance;
                if (spawntime < 0) {
                    spawntime = 1f;
                    GenerateAction?.Invoke(transform, transform.tag);
                    //if (UnityEngine.Random.Range(1, 10) <= 5) {
                    //    Instantiate(gm.Origin_Lumber, gm.RandomPosition(transform.position), Quaternion.identity);
                    //}
                    //if (UnityEngine.Random.Range(1, 10) <= 2) {
                    //    Instantiate(gm.Origin_CrudeOil, gm.RandomPosition(transform.position), Quaternion.identity);
                    //}
                }
            }
        }
    }

    public int Stock {
        get {
            return stock;
        }
        set {
            stock = value;
            Creeps = new GameObject[stock];
        }
    }

    private int stock;
    private float castime;
    private float spawntime;

    private void Start() {
        castime = DelayTime;
    }

    private void Update() {
        if (castime > 0) {
            castime -= Time.deltaTime;
        }

        if (castime < 0) {
            castime = 0;
            spawntime = 1f;
        }

        IsReadySpawn = transform.childCount < Stock;
    }
}
