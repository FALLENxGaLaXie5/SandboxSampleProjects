var DamageAmount : int = 5; //amount of damage hand gun will do when fired
var TargetDistance :  float; //how far away hand gun is from enemy
var AllowedRange : float = 15; //how far can the hand gun be before it inflicts damage

function Update () {
    if (Input.GetButtonDown("Fire1")) { //left mouse button to fire the gun. True when hand gun is fired
        {
            //check how far an target is from Gun using RaycastHit
            var Shot : RaycastHit; //Shot is a variable of type RaycastHit
            if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), Shot)) 
            { 
                TargetDistance = Shot.distance; //TargetDistance is how far an object is from the hand gun, using RaycastHit 
                if (TargetDistance < AllowedRange) 
                {
                    Shot.transform.SendMessage("DeductPoints", DamageAmount, SendMessageOptions.DontRequireReceiver);
                }
            }
        }
    }
}