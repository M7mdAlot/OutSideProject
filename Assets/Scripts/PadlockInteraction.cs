using System.Collections;
using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.Events;

public class PadlockInteraction : MonoBehaviour
{
    public UnityEvent UE;
    public Animator animator;
    public Animator animatorLock;
    public GameObject Handle;
    public string PuzzleCode= "1234";
    public GameObject LockInteracton;
    public GameObject LockPuzzle;
    public CinemachineCamera PuzzleCamera;
    private bool Isinteracting = false;
    private float RotationStep = 36f;
    public int CurrentCylinder = 0;
    public GameObject Cylinder1;
    private int Cylinder1Step = 0;
    private string Cylinder1Letter;
    public float Cylinder1Rotation = 0;
    public GameObject Cylinder2;
    private int Cylinder2Step = 0;
    private string Cylinder2Letter;
    public float Cylinder2Rotation = 0;
    public GameObject Cylinder3;
    private int Cylinder3Step = 0;
    private string Cylinder3Letter;
    public float Cylinder3Rotation = 0;
    public GameObject Cylinder4;
    private int Cylinder4Step = 0;
    private string Cylinder4Letter;
    public float Cylinder4Rotation = 0;
    void Start()
    {

    }
    private void Update()
    {
        if (Isinteracting)
        {
            if(Input.GetKeyDown(KeyCode.D))
            {
                CurrentCylinder = Mathf.Min(CurrentCylinder + 1, 3); ;
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                CurrentCylinder = Mathf.Max(CurrentCylinder - 1, 0); ;

            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                if (CurrentCylinder == 0)
                {
                    Cylinder1Step = (Cylinder1Step + 1) % 10;
                    Cylinder1Rotation += RotationStep;
                    Cylinder1.transform.localEulerAngles = new Vector3(Cylinder1Rotation, 0f, 0f);
                    Cylinder1Value();
                }
                if (CurrentCylinder == 1)
                {
                    Cylinder2Step = (Cylinder2Step + 1) % 10;
                    Cylinder2Rotation += RotationStep;
                    Cylinder2.transform.localEulerAngles = new Vector3(Cylinder2Rotation, 0f, 0f);
                    Cylinder2Value();
                }
                if (CurrentCylinder == 2)
                {
                    Cylinder3Step = (Cylinder3Step + 1) % 10;
                    Cylinder3Rotation += RotationStep;
                    Cylinder3.transform.localEulerAngles = new Vector3(Cylinder3Rotation, 0f, 0f);
                    Cylinder3Value();
                }
                if (CurrentCylinder == 3)
                {
                    Cylinder4Step = (Cylinder4Step + 1) % 10;
                    Cylinder4Rotation += RotationStep;
                    Cylinder4.transform.localEulerAngles = new Vector3(Cylinder4Rotation, 0f, 0f);
                    Cylinder4Value();
                }
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                if (CurrentCylinder == 0)
                {
                    Cylinder1Step = (Cylinder1Step - 1 + 10) % 10;
                    Cylinder1Rotation -= RotationStep;

                    Cylinder1.transform.localEulerAngles = new Vector3(Cylinder1Rotation, 0f, 0f);
                    Cylinder1Value();
                }
                if (CurrentCylinder == 1)
                {
                    Cylinder2Step = (Cylinder2Step - 1 + 10) % 10;
                    Cylinder2Rotation -= RotationStep;

                    Cylinder2.transform.localEulerAngles = new Vector3(Cylinder2Rotation, 0f, 0f);
                    Cylinder2Value();
                }
                if (CurrentCylinder == 2)
                {
                    Cylinder3Step = (Cylinder3Step - 1 + 10) % 10;
                    Cylinder3Rotation -= RotationStep;

                    Cylinder3.transform.localEulerAngles = new Vector3(Cylinder3Rotation, 0f, 0f);
                    Cylinder3Value();
                }
                if (CurrentCylinder == 3)
                {
                    Cylinder4Step = (Cylinder4Step - 1 + 10) % 10;
                    Cylinder4Rotation -= RotationStep;

                    Cylinder4.transform.localEulerAngles = new Vector3(Cylinder4Rotation, 0f, 0f);
                    Cylinder4Value();
                }
            }
        }
    }
    public void Cylinder1Value()
    {
        switch (Cylinder1Step)
        {
            case 0: Cylinder1Letter = "5"; break;
            case 1: Cylinder1Letter = "4"; break;
            case 2: Cylinder1Letter = "3"; break;
            case 3: Cylinder1Letter = "2"; break;
            case 4: Cylinder1Letter = "1"; break;
            case 5: Cylinder1Letter = "0"; break;
            case 6: Cylinder1Letter = "9"; break;
            case 7: Cylinder1Letter = "8"; break;
            case 8: Cylinder1Letter = "7"; break;
            case 9: Cylinder1Letter = "6"; break;
            default: Cylinder1Letter = "5"; break;
        }
        PuzzleSolution();
    }

    public void Cylinder2Value()
    {
        switch (Cylinder2Step)
        {
            case 0: Cylinder2Letter = "5"; break;
            case 1: Cylinder2Letter = "4"; break;
            case 2: Cylinder2Letter = "3"; break;
            case 3: Cylinder2Letter = "2"; break;
            case 4: Cylinder2Letter = "1"; break;
            case 5: Cylinder2Letter = "0"; break;
            case 6: Cylinder2Letter = "9"; break;
            case 7: Cylinder2Letter = "8"; break;
            case 8: Cylinder2Letter = "7"; break;
            case 9: Cylinder2Letter = "6"; break;
            default: Cylinder2Letter = "5"; break;
        }
        PuzzleSolution();
    }

    public void Cylinder3Value()
    {
        switch (Cylinder3Step)
        {
            case 0: Cylinder3Letter = "5"; break;
            case 1: Cylinder3Letter = "4"; break;
            case 2: Cylinder3Letter = "3"; break;
            case 3: Cylinder3Letter = "2"; break;
            case 4: Cylinder3Letter = "1"; break;
            case 5: Cylinder3Letter = "0"; break;
            case 6: Cylinder3Letter = "9"; break;
            case 7: Cylinder3Letter = "8"; break;
            case 8: Cylinder3Letter = "7"; break;
            case 9: Cylinder3Letter = "6"; break;
            default: Cylinder3Letter = "5"; break;
        }
        PuzzleSolution();
    }

    public void Cylinder4Value()
    {
        switch (Cylinder4Step)
        {
            case 0: Cylinder4Letter = "5"; break;
            case 1: Cylinder4Letter = "4"; break;
            case 2: Cylinder4Letter = "3"; break;
            case 3: Cylinder4Letter = "2"; break;
            case 4: Cylinder4Letter = "1"; break;
            case 5: Cylinder4Letter = "0"; break;
            case 6: Cylinder4Letter = "9"; break;
            case 7: Cylinder4Letter = "8"; break;
            case 8: Cylinder4Letter = "7"; break;
            case 9: Cylinder4Letter = "6"; break;
            default: Cylinder4Letter = "5"; break;
        }
        PuzzleSolution();
    }
    public void PuzzleSolution()
    {
        string Entered_Code = Cylinder1Letter + Cylinder2Letter + Cylinder3Letter + Cylinder4Letter;
        if (Entered_Code == PuzzleCode)
        {
            Debug.Log("Puzzle Is Complete!");
            StartCoroutine("ComopletedPuzzle");

        }
        else
        {

        }
    }
    IEnumerator ComopletedPuzzle() 
    {
        Time.timeScale = 1f;
        Isinteracting = false;
        Handle.SetActive(true);
        animatorLock.SetBool("LockOpen", true);
        yield return new WaitForSeconds(1.5f);
        EndPuzzle();
        animator.SetBool("PuzzleFinished", true);
        UE.Invoke();
        Destroy(gameObject);

    }

    public void StartPuzzle()
    {
        StartCoroutine("PuzzleStart");
    }

    public void EndPuzzle()
    {
        Time.timeScale = 1f;
        PuzzleCamera.Priority = 0;
        Isinteracting = false;

    }
    IEnumerator PuzzleStart()
    {
        Isinteracting = true;
        PuzzleCamera.Priority = 20;
        yield return new WaitForSecondsRealtime(0.5f);
        Time.timeScale = 0f;

    }

}

