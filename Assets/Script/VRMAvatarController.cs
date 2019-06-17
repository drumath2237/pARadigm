using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Kinect = Windows.Kinect;

public class VRMAvatarController : MonoBehaviour
{
    public GameObject BodySourceManager;
    private BodySourceManager _BodyManager;

    [SerializeField] GameObject head;
    [SerializeField] GameObject neck;
    [SerializeField] GameObject spineShoulder;
    [SerializeField] GameObject upperChest;
    [SerializeField] GameObject lowerChest;
    [SerializeField] GameObject spine;

    [SerializeField] GameObject shoulderRight;
    [SerializeField] GameObject shoulderLeft;

    [SerializeField] GameObject elbowRight;
    [SerializeField] GameObject elbowLeft;

    [SerializeField] GameObject handRight;
    [SerializeField] GameObject handLeft;

    [SerializeField] GameObject hipRight;
    [SerializeField] GameObject hipLeft;

    [SerializeField] GameObject kneeRight;
    [SerializeField] GameObject kneeLeft;

    [SerializeField] GameObject footRight;
    [SerializeField] GameObject footLeft;

    [SerializeField] GameObject toeRight;
    [SerializeField] GameObject toeLeft;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _BodyManager = BodySourceManager.GetComponent<BodySourceManager>();
        Kinect.Body[] data = _BodyManager.GetData();
        var _body = data[0];

        if (_body.IsTracked)
        {
            //head.transform.position = GetVector3FromJoint(_body.Joints[Kinect.JointType.Head]);
            //neck.transform.position = GetVector3FromJoint(_body.Joints[Kinect.JointType.Neck]);
            //spineShoulder.transform.position = GetVector3FromJoint(_body.Joints[Kinect.JointType.SpineShoulder]);
            //upperChest.transform.position = GetVector3FromJoint(_body.Joints[Kinect.JointType.SpineMid]);
            //lowerChest.transform.position = GetVector3FromJoint(_body.Joints[Kinect.JointType.SpineBase]);
            spine.transform.position = GetVector3FromJoint(_body.Joints[Kinect.JointType.SpineBase]);
        }
        
    }

    private static Vector3 GetVector3FromJoint(Kinect.Joint joint)
    {
        return new Vector3(joint.Position.X * 10, joint.Position.Y * 10, joint.Position.Z * 10);
    }

}
