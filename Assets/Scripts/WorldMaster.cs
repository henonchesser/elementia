using UnityEngine;
using System.Collections;

public class WorldMaster : MonoBehaviour {
    [SerializeField]
    private int _worldChunkAmount = 10;
    [SerializeField]
    private GameObject[] _worldChunkArray;

    private int _worldoffset;

	// Use this for initialization
	void Start () {
	    for(var i = 0; i < _worldChunkAmount; i++)
        {
            var randomChunkIndex = Random.Range(0,_worldChunkArray.Length);
            var newChunkPos = new Vector3(_worldoffset, 0, 0);
            var thisChunk = (GameObject)Instantiate(_worldChunkArray[randomChunkIndex], newChunkPos, Quaternion.identity);
            thisChunk.transform.parent = transform;
            _worldoffset += 20;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
