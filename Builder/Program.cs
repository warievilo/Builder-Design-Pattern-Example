using Builder.Enums;
using Builder.Services;

var peopleInformationInHtml = PeopleInformationBuilder
                                .Configure()
                                .WithName("Aparecida Clarice Moreira")
                                .WithCPF("561.302.586-07")
                                .WithRG("44.684.672-7")
                                .WithBirthDate(new DateOnly(1997, 03, 17))
                                .WithGender(Gender.Female)
                                .WithEmail("aparecida.clarice.moreira@grupoblackout.com.br")
                                .WithPhoneNumber("19 992127627")                            
                                .WithAnotherPhoneNumber("19 992265611")
                                //.WithoutAddress()
                                .WithAddress()
                                .WithZipCode("61605-285")
                                .WithStreet("Francisco Louredo")
                                .WithNumber("195")
                                .WithDistrict("Jardim de Bugio")
                                .WithCity("Aracaju")
                                .WithState("Sergipe")
                                .WithCountry("Brasil")
                                .Build();

File.WriteAllText(@"C:\Temp\peopleInformation.html", peopleInformationInHtml);
