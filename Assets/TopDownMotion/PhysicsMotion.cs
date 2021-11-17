using System.Collections; // asdasdasdasffsegfgwre
using System.Collections.Generic;
using UnityEngine; //asasdnadewbhjgrvjharabhjarbhdarbhfdadffrygut4jhdgsgebghirggeh88guyh8u9538953hy98h59u3587vn8u5hn7bv8ywv58hv8u5hwe8ouvirvnuhvreihtythty858hb594hv8w57hnt87w5hvt8we57hvtn875hvw59hv95y95678698764984379349834789389688888888888888888888888788888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888ehrwhwrgshrgwnheb nhietgeirgnverbsiurgjhierjgciejhgoiuerhgsjogsmerovmwo nigeria akjsdfhisechihfviauerhfercargcifiaaguiahnaiosrhaniurhgniarsg/asgiasruirghasruighairugh897yq7thb uhgrhilwerthlieruhlerihreouthwep9rthwe54uthwliuerghluerge5uiwhu95eh98prsugwrbiuhut9w4fwh9hewtniervertvergrgsfjksggshjigshiosrghiserig
//ligma bal
//asasbhgskbrgbrgbh sdrguarg basrbgasu ag  aarsb hsthb eg bhsnt kthryh w jtgh hitio iojjijiohwejhtjthui wyh98 5yw98 y589h 54yw8954y w89y 54wu895y 489489778978 ry9u8yjnht tfh  yjdry
public class PhysicsMotion : MonoBehaviour
{
    public float scaler;
    private Rigidbody2D rb2;
    public float angle; //asdhasbhasbnsabjasenqbfbnkqef
    public float puntForce;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.deltaTime);
        //motion for character
        float inX = Time.deltaTime * scaler * Input.GetAxis("Horizontal");
        //fknjsndfkjs
        float inY = Time.deltaTime * scaler * Input.GetAxis("Vertical");
        //askfafnafdaf
        //asfasadjgnesrbhargbhjagrg
        //jryj
        //tyktukku
        //ryjryjyrjyyi
        //liiluilyltuykuuk
        //wewrgerhereh
        //yukyukyukyuk


        //jryrjry
        //drhethetyukyukyyukjhtj
        //yukyuukkurukfukukf0
        rb2.AddForce(new Vector2(inX,inY));

        //listen for a punt
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("Punt!");
            float fX = puntForce * Mathf.Cos(angle * Mathf.Deg2Rad);
            float fY = puntForce * Mathf.Sin(angle * Mathf.Deg2Rad);
            rb2.AddForce(new Vector2(fX, fY));
        }

        //listen for a reset (esc)
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            transform.position = new Vector3(0, 0, 0);
            rb2.velocity = new Vector2(0, 0);
        }
    }
}
//aaaaaaaaa

//aaaaaaaaa
//aaaaaaaaa
//aaaaaaaaa
//aaaaaaaaa
//aaaaaaaaa

//aaaaaaaaa
//aaaaaaaaa
//aaaaaaaaa
//aaaaaaaaa

//aaaaaaaaa
//aaaaaaaaa
//aaaaaaaaa
//aaaaaaaaa
//aaaaaaaaa
//aaaaaaaaa
//aaaaaaaaa