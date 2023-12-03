using System;

public class Address
{
    private string _venueName;
    private string _streetAddress; 
    private string _city; 
    private string _stateProvince; 
    private string _postalCode; 
    private string _country; 

    public Address(string venueName, string streetAddress, string city, string stateProvince, string postalCode, string country)
    {
        _venueName = venueName;
        _streetAddress = streetAddress; 
        _city = city; 
        _stateProvince = stateProvince; 
        _postalCode = postalCode; 
        _country = country; 
    }
    public void SetVenueName(string venueName)
    {
        _venueName = venueName;
    }
    public string GetVenueName()
    {
        return _venueName;
    }
    public void SetStreetAddress(string streetAddress)
    {
        _streetAddress = streetAddress;
    }
    public string GetStreetAddress()
    {
        return _streetAddress;
    }
    public void SetCity(string city)
    {
        _city = city;
    }
    public string GetCity()
    {
        return _city;
    }
    public void SetStateProvince(string stateProvince)
    {
        _stateProvince = stateProvince;
    }
    public string GetStateProvince()
    {
        return _stateProvince;
    }
    public void SetPostalCode(string postalCode)
    {
        _postalCode = postalCode;
    }
    public string GetPostalCode()
    {
        return _postalCode;
    }
    public void SetCountry(string country)
    {
        _country = country;
    }
    public string GetCountry()
    {
        return _country;
    }
    public bool LivesInUSA()
    {
        bool truth =false;
        if (_country == "USA")
        {
            truth = true;
        }
        else
        {
            truth = false;
        }
        return truth;
    }
    public string GetFullAddress()
    {
        //const string NewLine = "\n";
        return $"{_streetAddress}\n{_city}, {_stateProvince} {_postalCode}\n{_country}";
    }
}