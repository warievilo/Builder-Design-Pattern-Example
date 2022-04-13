using Builder.Enums;
using Builder.Interfaces;

namespace Builder.Services;

public class PeopleInformationBuilder : 
    IPeopleInformation,
    IPeopleInformationName,
    IPeopleInformationCPF,
    IPeopleInformationRG,
    IPeopleInformationBirthDate,
    IPeopleInformationGender,
    IPeopleInformationEmail,
    IPeopleInformationPhoneNumber,
    IPeopleInformationWithoutAddress,
    IPeopleInformationAddress,
    IPeopleInformationZipCode,
    IPeopleInformationStreet,
    IPeopleInformationNumber,
    IPeopleInformationDistrict,
    IPeopleInformationCity,
    IPeopleInformationState,
    IPeopleInformationCountry
{
    private string? _name;
    private string? _cpf;
    private string? _rg;
    private DateOnly _birthDate;    
    private Gender _gender;
    private string? _email;
    private List<string> _phoneNumbers = new List<string>();    
    private bool _withAddress;
    private string? _zipCode;
    private string? _street;
    private string? _number;
    private string? _district;
    private string? _city;
    private string? _state;
    private string? _country;

    private PeopleInformationBuilder()
    {
        
    }

    public static IPeopleInformation Configure()
    {
        return new PeopleInformationBuilder();
    }

    public IPeopleInformationName WithName(string name)
    {
        _name = name;
        return this;
    }
    
    public IPeopleInformationCPF WithCPF(string cpf)
    {
        _cpf = cpf;
        return this;
    }

    public IPeopleInformationRG WithRG(string rg)
    {
        _rg = rg;
        return this;
    }

    public IPeopleInformationBirthDate WithBirthDate(DateOnly birthDate)
    {
        _birthDate = birthDate;
        return this;
    }

    public IPeopleInformationGender WithGender(Gender gender)
    {
        _gender = gender;
        return this;
    }

    public IPeopleInformationEmail WithEmail(string email)
    {
        _email = email;
        return this;
    }

    public IPeopleInformationPhoneNumber WithPhoneNumber(string phoneNumber)
    {
        _phoneNumbers.Add(phoneNumber);
        return this;
    }

    public IPeopleInformationPhoneNumber WithAnotherPhoneNumber(string phoneNumber)
    {
        _phoneNumbers.Add(phoneNumber);
        return this;
    }

    public IPeopleInformationWithoutAddress WithoutAddress()
    {
        _withAddress = false;
        return this;
    }

    public IPeopleInformationAddress WithAddress()
    {
        _withAddress = true;
        return this;
    }

    public IPeopleInformationZipCode WithZipCode(string zipCode)
    {
        _zipCode = zipCode;
        return this;
    }

    public IPeopleInformationStreet WithStreet(string street)
    {
        _street = street;
        return this;
    }

    public IPeopleInformationNumber WithNumber(string number)
    {
        _number = number;
        return this;
    }

    public IPeopleInformationDistrict WithDistrict(string district)
    {
        _district = district;
        return this;
    }

    public IPeopleInformationCity WithCity(string city)
    {
        _city = city;
        return this;
    }

    public IPeopleInformationState WithState(string state)
    {
        _state = state;
        return this;
    }

    public IPeopleInformationCountry WithCountry(string country)
    {
        _country = country;
        return this;
    }

    public string Build()
    {
        string html = $@"
        <html>
            <head>
                <title>Information about { _name }</title>                
            </head>
            <body>
                <h1>Information about { _name }</h1>
                <p>
                    <strong>CPF:</strong> { _cpf }
                </p>
                <p>
                    <strong>RG:</strong> { _rg }
                </p>
                <p>
                    <strong>Birth date:</strong> { _birthDate.ToShortDateString() }
                </p>
                <p>
                    <strong>Gender:</strong> { _gender.ToString() }
                </p>
                <p>
                    <strong>E-mail:</strong> { _email }
                </p>
                { 
                    string.Concat(_phoneNumbers.Select(x => $@"
                        <p>
                            <strong>Phone number:</strong> { x }
                        </p>")
                    )
                }
                { 
                    (!_withAddress ? string.Empty : $@"
                        <p>
                            <strong>Zip code:</strong> { _zipCode }
                        </p>
                        <p>
                            <strong>Street:</strong> { _street }
                        </p>
                        <p>
                            <strong>Number:</strong> { _number }
                        </p>
                        <p>
                            <strong>District:</strong> { _district }
                        </p>
                        <p>
                            <strong>City:</strong> { _city }
                        </p>
                        <p>
                            <strong>State:</strong> { _state }
                        </p>
                        <p>
                            <strong>Country:</strong> { _country }
                        </p>                    
                    ")
                }                
            </body>
        </html>";
        
        return html;
    }    
}