using UnityEngine;

public class CorocterContoroler : MonoBehaviour
{
	public float move;
	public float jump;
	private Rigidbody2D rigi;
	
	//parash gofl bashad dar hava	
	
	public Transform groundchek;
	public float groundchekradeus;
	public LayerMask laye_zamin_kodome;
	public bool granded;
	//ta inga
	
	public bool dabeljump;    //paresh dobare



    void Start()
		{rigi = GetComponent<Rigidbody2D>();
	        
	    }


	void fixedUpdete()       //agar shay ba zamin barkhord kard dahkel granded mereza
		{
		
			granded = Physics2D .OverlapCircle(groundchek.position,groundchekradeus,laye_zamin_kodome);
			
		}


    void Update()
	{   	if(granded)
			{Debug.Log("a");}
			
			
			if(granded)
			{dabeljump=false;}			
			
    		
    		
			if(Input.GetKeyDown(KeyCode.Space)&&granded)
		    {rigi.linearVelocity=new Vector2(0,move);}
		    
		    	
				if(Input.GetKeyDown(KeyCode.Space)&&!dabeljump&&!granded)
			{rigi.linearVelocity=new Vector2(0,move);
				dabeljump=true;}
		    
		    if(Input.GetKey(KeyCode.D))
		    {rigi.linearVelocity=new Vector2(move,0);}
		    
		    if(Input.GetKey(KeyCode.A))
		    {rigi.linearVelocity=new Vector2(-move,0);}
    	}
}
