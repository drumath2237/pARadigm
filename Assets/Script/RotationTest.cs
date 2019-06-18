using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Kinect = Windows.Kinect;

public class RotationTest : MonoBehaviour
{
    [SerializeField] GameObject head;
    [SerializeField] GameObject shoulder;
    [SerializeField] GameObject spine;
    [SerializeField] GameObject armLeft;
    [SerializeField] GameObject armRight;

    [SerializeField] GameObject BodySourceManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var _bodySource = BodySourceManager.GetComponent<BodySourceManager>();
        Kinect.Body[] data = _bodySource.GetData();

        var _body = data[0];

        head.transform.position = kinectPosition2vec3(_body.Joints[Kinect.JointType.Head]);
        shoulder.transform.position = kinectPosition2vec3(_body.Joints[Kinect.JointType.SpineShoulder]);
        spine.transform.position = kinectPosition2vec3(_body.Joints[Kinect.JointType.SpineBase]);
        armLeft.transform.position = kinectPosition2vec3(_body.Joints[Kinect.JointType.HandLeft]);
        armRight.transform.position = kinectPosition2vec3(_body.Joints[Kinect.JointType.HandRight]);

    }

    Vector3 kinectPosition2vec3(Kinect.Joint j)
    {
        return new Vector3(j.Position.X, j.Position.Y, j.Position.Z);
    }
}
