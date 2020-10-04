namespace CSharpInterviewQuestions
{
    sealed class SealedClass
    {

    }
    
    //class InheritingFromSealedClass : SealedClass { } //does not compile! The error is "cannot derive from sealed type 'SealedClass'"

    class BaseClass
    {
        public virtual string GetName()
        {
            return "I am a Base Class";
        }
    }

    class ChildClass : BaseClass
    {
        sealed public override string GetName()
        {
            return "I am a Child Class";
        }
    }

    class GrandchildClass : ChildClass
    {
        //public override string GetName() //does not compile. The error is "cannot override inherited member 'ChildClass.GetName()' because it is sealed"
        //{
        //    return "I am a Child Class";
        //}
    }
}
