public class Address{
    private string _streetAddress;
    private string _state;
    private string _country;

    public Address (string streetAddress, string state, string country){
        _streetAddress = streetAddress;
        _state = state;
        _country = country;
    }

    public bool IsInUSA(){
        string country = _country.Trim().ToLower();
        if (country == "usa" || country == "united states" || country == "united states of america"){
            return true;
        }
        else{
            return false;
        }
    }

    public string GetFullAddress(){
        return $"{_streetAddress}, {_state}, {_country}";
    }

}