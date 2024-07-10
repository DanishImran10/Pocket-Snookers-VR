using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http.Headers;
using UnityEngine;
//using UnityEngine.InputSystem;

public class StickScript : MonoBehaviour
{
    public bool rotation_mode;
    public bool aim_mode;
    public bool power_mode;
    public bool shot_mode;
    Vector2 rotate;
    public float angle_deg;
    Vector2 aim;
    Vector2 translate;
    public GameObject cueball;
    private Vector3 force;
    private float hitForce = 1.5f;
    private float delayTime = 0.5f;
    Vector3 ballpos;
    Vector3 cuepos;
    bool boundarybreachleft = false;
    bool boundarybreachright = false;
    bool boundarybreachupper = false;
    bool boundarybreachlower = false;
    public GameObject cam;
    public bool shottaken = false;
    public GameObject GameManager;
    private bool applyforce = false;
    public GameObject pointer;
    private float angles_rotated = 0f;
    private float aiml;
    private float aimr;
    private float aimu;
    private float aimd;
    private float powf;
    private float powb;
    ContactPoint contact;
    public bool lerpon;
    public GameObject orient1;
    public GameObject orient2;
    public Quaternion temprot;
    public Vector3 initballpos;
    public Vector3 initcuepos;
    public Quaternion initcuerot;
    public Vector3 initcampos;
    public Quaternion initcamrot;
    public GameObject GM;
    public AudioSource audioSource;
    public AudioClip clip;

    void Start()
    {
        rotation_mode = true;
        aim_mode = false;
        power_mode = false;
        shot_mode = false;
        lerpon = false;
        pointer.SetActive(true);
        cam.transform.position = new Vector3(transform.position.x, transform.position.y + 0.134f, transform.position.z - 0.227f);
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Input.GetButton("B"))
        {
            GM.GetComponent<GameManagerScript>().EndGame();
        }

        if (rotation_mode)
        {
            Physics.IgnoreLayerCollision(0, 6, true);
            float x = Input.GetAxis("Horizontal");
            rotate.x = x;

            if(Input.GetButton("A"))
                RotateToAim();
            // if(Input.GetButton("C"))
            //     RotateToPower();
        }
        if (aim_mode)
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");
            aim.x = x;
            aim.y = y;

            // if(Input.GetButton("B"))
            //     AimToRotate();
            if(Input.GetButton("C"))
                AimToPower();
        }
        if (power_mode)
        {
            pointer.SetActive(false);
            float y = Input.GetAxis("Vertical");
            translate.y = y;

            if(powf >= 0f && Input.GetButton("A"))
            {
                GM.GetComponent<GameManagerScript>().modeText.text = "Mode: Shot";
                GM.GetComponent<GameManagerScript>().instructionText.text = "";
                GM.GetComponent<GameManagerScript>().canvas.transform.Translate(0, 0.5f, 0);

                power_mode = false;
                shot_mode = true;
                lerpon = true;
                temprot = cam.transform.rotation;
                Vector3 v1 = new Vector3(2.15f, 1.81f, 0.05f);
                Vector3 v2 = new Vector3(-2.15f, 1.81f, 0.05f);
                float d1 = Vector3.Distance(v1, cam.transform.position);
                float d2 = Vector3.Distance(v2, cam.transform.position);
                if (d1 < d2)
                {
                    cam.transform.position = v1;
                    cam.transform.rotation = orient1.transform.rotation;
                }
                else
                {
                    cam.transform.position = v2;
                    cam.transform.rotation = orient2.transform.rotation;
                }
                CueShot();
            }
        }   

        if (rotation_mode)
            CalculateJoystickInput();
        else if (aim_mode)
            SettingUpAim();
        else if (power_mode && !lerpon)
            ShotRadar();

        if (applyforce)
            ApplyForce();
    }

    private void CalculateJoystickInput()
    {
        angle_deg = 0f;
        if (rotate.x == 1)
            angle_deg = -180f;
        else if (rotate.x == -1)
            angle_deg = 180f;
        angles_rotated += angle_deg * 0.01f;
        transform.RotateAround(cueball.transform.position, Vector3.up, angle_deg * 0.01f);
        cam.transform.RotateAround(cueball.transform.position, Vector3.up, angle_deg * 0.01f);
    }

    private void SettingUpAim()
    {
        Vector3 vx = new Vector3(0, 0, aim.x * 0.0007f);
        Vector3 vy = new Vector3(0, aim.y * 0.0007f, 0);
        if (aim.x != 0)
        {
            if(aiml == 0f)
                boundarybreachleft = true;
            if(aimr == 0f)
                boundarybreachright = true;
            if(aiml > 0f && aimr > 0f)
            {
                boundarybreachleft = false;
                boundarybreachright = false;
            }

            if(boundarybreachleft == false && aim.x == -1)
            {
                aiml--;
                aimr++;
                transform.Translate(vx, Space.Self);
            }
            if(boundarybreachright == false && aim.x == 1)
            {
                aimr--;
                aiml++;
                transform.Translate(vx, Space.Self);
            }
        }
        else if (aim.y != 0)
        {
            if(aimu == 0f)
                boundarybreachupper = true;
            if(aimd == 0f)
                boundarybreachlower = true;
            if(aimu > 0f && aimd > 0f)
            {
                boundarybreachupper = false;
                boundarybreachlower = false;
            }

            if(boundarybreachupper == false && aim.y == 1)
            {
                aimu--;
                aimd++;
                transform.Translate(vy, Space.Self);
            }
            if(boundarybreachlower == false && aim.y == -1)
            {
                aimd--;
                aimu++;
                transform.Translate(vy, Space.Self);
            }
        }
    }

    private void ShotRadar()
    {
        angles_rotated = 0f;
        cam.transform.position = transform.position;
        Vector3 camvec = new Vector3(0, 0.5f, -1f);
        cam.transform.Translate(camvec, Space.Self);

        if (translate.y == -1 && powb > 0f)
        {
            Vector3 v = new Vector3(-translate.y, 0, 0) * 2f * Time.deltaTime;
            transform.Translate(v, Space.Self);
            powb--;
            powf++;
        }
        else if (translate.y == 1 && powf > 0f)
        {
            Vector3 v = new Vector3(-translate.y, 0, 0) * 2f * Time.deltaTime;
            transform.Translate(v, Space.Self);
            powf--;
            powb++;
        }
    }

    private void RotateToAim()
    {
        cuepos = transform.InverseTransformDirection(transform.position);
        aiml = 16f;
        aimr = 16f;
        aimu = 16f;
        aimd = 16f;
        rotation_mode = false;
        aim_mode = true;
        GM.GetComponent<GameManagerScript>().modeText.text = "Mode: Aim";
        GM.GetComponent<GameManagerScript>().instructionText.text = "Joystick: Up/Down Left/Right\nPress C to continue";
    }

    private void AimToPower()
    {
        aim_mode = false;
        power_mode = true;
        powf = -4f;
        powb = 12f;
        GM.GetComponent<GameManagerScript>().modeText.text = "Mode: Power";
        GM.GetComponent<GameManagerScript>().instructionText.text = "Joystick: Up/Down\nPress A to continue";

        Vector3 canvec = new Vector3(0, -0.5f, 0);
        GM.GetComponent<GameManagerScript>().canvas.transform.Translate(canvec, Space.Self);
    }
    private void CueShot()
    {
        // Vector3 campos = new Vector3(1.298f, 1.316f, -0.041f);
        // cam.transform.position = campos;
        // Quaternion camrot = new Quaternion(33.462f, -90f, 0f, 0f);
        // cam.transform.rotation = camrot;
        Physics.IgnoreLayerCollision(0, 6, false);
        Vector3 forceDirection = (transform.position - cueball.transform.position).normalized;
        if (Vector3.Dot(forceDirection, transform.right) >= 0)
            forceDirection *= -1f;
        float forceMagnitude = Vector3.Distance(transform.position, cueball.transform.position) * hitForce;
        force = forceDirection * forceMagnitude;
        Vector3 initialPosition = transform.position;
        //Vector3 offset = new Vector3(0, 0, -0.5278f);  //to account for that stick's transform is at center and not tip but it should stop at tip.
        Vector3 targetPosition = cueball.transform.position;
        StartCoroutine(WaitAndMove(initialPosition, targetPosition, delayTime));
    }

    IEnumerator WaitAndMove(Vector3 initialPosition, Vector3 targetPosition, float delayTime)
    {
        yield return new WaitForSeconds(delayTime); // Start after delayTime

        float startTime = Time.time;
        float duration = 0.5f; // Time taken to reach target position
        while (Time.time - startTime <= duration)
        {
            float t = (Time.time - startTime) / duration; // Calculate interpolation factor
            transform.position = Vector3.Lerp(initialPosition, targetPosition, t); // Lerp from initial to target position
            yield return null; // Wait for next frame
        }
    }

    private void ApplyForce()
    {
        initballpos = cueball.transform.position;

        if (aimu < 16f && aimu > 0f)
        {
            cueball.GetComponent<Rigidbody>().AddTorque(transform.right * force.magnitude * 1 / aimu * 50f, ForceMode.Impulse);
            //print(transform.right * 1 / aimu * 90f);
        }
        else if (aimu == 0f)
        {
            cueball.GetComponent<Rigidbody>().AddTorque(transform.right * force.magnitude * 50f, ForceMode.Impulse);
            //print(transform.right * 100f);
        }
        else if (aimd < 16f && aimd > 0f)
        {
            cueball.GetComponent<Rigidbody>().AddTorque(-transform.right * force.magnitude * 1 / aimd * 50f, ForceMode.Impulse);
            //print(-transform.right * 1 / aimd * 90f);
        }
        else if (aimd == 0f)
        {
            cueball.GetComponent<Rigidbody>().AddTorque(-transform.right * force.magnitude * 50f, ForceMode.Impulse);
            //print(-transform.right * 100f);
        }
        else
            cueball.GetComponent<Rigidbody>().AddForceAtPosition(force, contact.point, ForceMode.Impulse);

        applyforce = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.StartsWith("CueBall"))
        {
            applyforce = true;
            transform.GetComponent<MeshRenderer>().enabled = false;
            contact = collision.contacts[0];
            audioSource.clip = clip; //cue collides with cueball
            audioSource.Play();
        }
    }
    private void OnCollisionExit(Collision collision) 
    {
        if (collision.gameObject.name.StartsWith("CueBall"))
        {
            Physics.IgnoreLayerCollision(0, 6, true);
            shottaken = true;
        }
    }
}