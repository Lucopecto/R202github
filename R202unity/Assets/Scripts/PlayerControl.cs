using UnityEngine;





public class PlayerControl : MonoBehaviour
{



    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _dashForce;
    [SerializeField] private Rigidbody _rb;

    private bool dashRequested = false;
    private bool dashRecharge = true;

    public float seuil = 0.1f;


    
    void Update()
    {
        // Mouvement
        var vel = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * _speed;
        vel.y = _rb.velocity.y;
        _rb.velocity = vel;

        // Saut
        if (Input.GetKeyDown(KeyCode.Space) && EstAuSol())
        {
            _rb.AddForce(Vector3.up * _jumpForce);
        }

        // Rechargement du dash
        if (EstAuSol())
        {
            dashRecharge = true;
        }

        // Demande de dash
        if (Input.GetKeyDown(KeyCode.Return) && (Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)))
        {
            dashRequested = true;
        }
    }

    void FixedUpdate()
    {
        if (dashRequested)
        {
            dashRequested = false;
            if (dashRecharge)
            {
                Dash();
                dashRecharge = false;
            }
        }
    }



    void Dash()
    {
        Vector3 dashDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.Z))
        {
            dashDirection -= transform.right;
        }
        if (Input.GetKey(KeyCode.S))
        {
            dashDirection += transform.right;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            dashDirection -= transform.forward;
        }
        if (Input.GetKey(KeyCode.D))
        {
            dashDirection += transform.forward;
        }

        _rb.AddForce(dashDirection * _dashForce, ForceMode.Impulse);
    }



    bool EstAuSol()
    {
        return Physics.Raycast(transform.position, -Vector3.up, GetComponent<Collider>().bounds.extents.y + seuil);
    }





}