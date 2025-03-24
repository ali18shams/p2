using UnityEngine;

public class move : MonoBehaviour
{
	private Rigidbody2D rigid;
	public float movv;
	void Start()
	
    {
	    rigid =GetComponent <Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
	    if(Input.GetKey(KeyCode.D))
	    {rigid.linearVelocity=new Vector2(movv,0);}
    }
}
