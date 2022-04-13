namespace Builder.Interfaces;

public interface IPeopleInformationPhoneNumber
{
    public IPeopleInformationPhoneNumber WithAnotherPhoneNumber(string phoneNumber);
    public IPeopleInformationWithoutAddress WithoutAddress();    
    public IPeopleInformationAddress WithAddress();        
}
