using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncomDashboardCore.Code
{






    //Mike Belcher - Used in Forms and views


    public class FormItems
    {

        // We can create one UserFormItems instance of this class and assign all the selected items to it an access it throughout the controller.
        private string _SelectedCountry;
        private string _SelectedState;
        private string _SelectedAge;
        private string _SelectedGender;


        // ACCESS THIS PROPERTY IN CODE BY CREATING AN INSTANCE OF THE OBJECT LIKE SO:
        // FormItems S = new FormItems();
        // S.SelectedCountry = "USA"; 
        public string SelectedCountry
        {
            get { return _SelectedCountry; }
            set { _SelectedCountry = value; }
        }


        // ACCESS THIS PROPERTY IN CODE BY CREATING AN INSTANCE OF THE OBJECT LIKE SO:
        // FormItems S = new FormItems();
        // S.SelectedState = "Maryland"; 
        public string SelectedState
        {
            get { return _SelectedState; }
            set { _SelectedState = value; }
        }



        public string SelectedAge
        {
            get { return _SelectedAge; }
            set { _SelectedAge = value; }
        }



        public string SelectedGender
        {
            get { return _SelectedGender; }
            set { _SelectedGender = value; }
        }

        public static List<SelectListItem> Apptypes { get; private set; }




        // COUNTRIES DROP-DOWN
        // ACCESS THIS METHOD IN CODE DIRECTLY AS SO:   List<KeyValuePair<string, string>> ListCountries = FormItems.GetCountries();
        public static List<KeyValuePair<string, string>> GetCountries()//these could also be T = SelectListItem
        {
            List<KeyValuePair<string, string>> Countries = new List<KeyValuePair<string, string>>();
            Countries.Add(new KeyValuePair<string, string>("United States", "United States"));
            Countries.Add(new KeyValuePair<string, string>("Canada", "Canada"));
            Countries.Add(new KeyValuePair<string, string>("Albania", "Albania"));
            Countries.Add(new KeyValuePair<string, string>("Algeria", "Algeria"));
            Countries.Add(new KeyValuePair<string, string>("American Samoa", "American Samoa"));
            Countries.Add(new KeyValuePair<string, string>("Andorra", "Andorra"));
            Countries.Add(new KeyValuePair<string, string>("Anguilla", "Anguilla"));
            Countries.Add(new KeyValuePair<string, string>("Antigua & Barbuda", "Antigua & Barbuda"));
            Countries.Add(new KeyValuePair<string, string>("Argentina", "Argentina"));
            Countries.Add(new KeyValuePair<string, string>("Aruba", "Aruba"));
            Countries.Add(new KeyValuePair<string, string>("Australia", "Australia"));
            Countries.Add(new KeyValuePair<string, string>("Austria", "Austria"));
            Countries.Add(new KeyValuePair<string, string>("Azores", "Azores"));
            Countries.Add(new KeyValuePair<string, string>("Bahamas", "Bahamas"));
            Countries.Add(new KeyValuePair<string, string>("Bahrain", "Bahrain"));
            Countries.Add(new KeyValuePair<string, string>("Bangladesh", "Bangladesh"));
            Countries.Add(new KeyValuePair<string, string>("Barbados", "Barbados"));
            Countries.Add(new KeyValuePair<string, string>("Belgium", "Belgium"));
            Countries.Add(new KeyValuePair<string, string>("Belize", "Belize"));
            Countries.Add(new KeyValuePair<string, string>("Belarus", "Belarus"));
            Countries.Add(new KeyValuePair<string, string>("Benin", "Benin"));
            Countries.Add(new KeyValuePair<string, string>("Bermuda", "Bermuda"));
            Countries.Add(new KeyValuePair<string, string>("Bolivia", "Bolivia"));
            Countries.Add(new KeyValuePair<string, string>("Bonaire", "Bonaire"));
            Countries.Add(new KeyValuePair<string, string>("Bosnia", "Bosnia"));
            Countries.Add(new KeyValuePair<string, string>("Botswana", "Botswana"));
            Countries.Add(new KeyValuePair<string, string>("Brazil", "Brazil"));
            Countries.Add(new KeyValuePair<string, string>("British Virgin Islands", "British Virgin Islands"));
            Countries.Add(new KeyValuePair<string, string>("Brunei", "Brunei"));
            Countries.Add(new KeyValuePair<string, string>("Bulgaria", "Bulgaria"));
            Countries.Add(new KeyValuePair<string, string>("Burkina Faso", "Burkina Faso"));
            Countries.Add(new KeyValuePair<string, string>("Burundi", "Burundi"));
            Countries.Add(new KeyValuePair<string, string>("Cambodia", "Cambodia"));
            Countries.Add(new KeyValuePair<string, string>("Cameroon", "Cameroon"));
            Countries.Add(new KeyValuePair<string, string>("Canary Islands", "Canary Islands"));
            Countries.Add(new KeyValuePair<string, string>("Cape Verde Islands", "Cape Verde Islands"));
            Countries.Add(new KeyValuePair<string, string>("Cayman Islands", "Cayman Islands"));
            Countries.Add(new KeyValuePair<string, string>("Central African Republic", "Central African Republic"));
            Countries.Add(new KeyValuePair<string, string>("Chad", "Chad"));
            Countries.Add(new KeyValuePair<string, string>("Channel Islands", "Channel Islands"));
            Countries.Add(new KeyValuePair<string, string>("Chile", "Chile"));
            Countries.Add(new KeyValuePair<string, string>("China", "China"));
            Countries.Add(new KeyValuePair<string, string>("Colombia", "Colombia"));
            Countries.Add(new KeyValuePair<string, string>("Congo", "Congo"));
            Countries.Add(new KeyValuePair<string, string>("Cook Islands", "Cook Islands"));
            Countries.Add(new KeyValuePair<string, string>("Costa Rica", "Costa Rica"));
            Countries.Add(new KeyValuePair<string, string>("Croatia", "Croatia"));
            Countries.Add(new KeyValuePair<string, string>("Curacao", "Curacao"));
            Countries.Add(new KeyValuePair<string, string>("Cyprus", "Cyprus"));
            Countries.Add(new KeyValuePair<string, string>("Czech Republic", "Czech Republic"));
            Countries.Add(new KeyValuePair<string, string>("Denmark", "Denmark"));
            Countries.Add(new KeyValuePair<string, string>("Djibouti", "Djibouti"));
            Countries.Add(new KeyValuePair<string, string>("Dominica", "Dominica"));
            Countries.Add(new KeyValuePair<string, string>("Dominican Republic", "Dominican Republic"));
            Countries.Add(new KeyValuePair<string, string>("Ecuador", "Ecuador"));
            Countries.Add(new KeyValuePair<string, string>("Egypt", "Egypt"));
            Countries.Add(new KeyValuePair<string, string>("El Salvador", "El Salvador"));
            Countries.Add(new KeyValuePair<string, string>("England", "England"));
            Countries.Add(new KeyValuePair<string, string>("Equitorial Guinea", "Equitorial Guinea"));
            Countries.Add(new KeyValuePair<string, string>("Eritrea", "Eritrea"));
            Countries.Add(new KeyValuePair<string, string>("Estonia", "Estonia"));
            Countries.Add(new KeyValuePair<string, string>("Ethiopia", "Ethiopia"));
            Countries.Add(new KeyValuePair<string, string>("Faeroe Islands", "Faeroe Islands"));
            Countries.Add(new KeyValuePair<string, string>("Federated States of Micronesia", "Federated States of Micronesia"));
            Countries.Add(new KeyValuePair<string, string>("Fiji", "Fiji"));
            Countries.Add(new KeyValuePair<string, string>("Finland", "Finland"));
            Countries.Add(new KeyValuePair<string, string>("France", "France"));
            Countries.Add(new KeyValuePair<string, string>("French Guiana", "French Guiana"));
            Countries.Add(new KeyValuePair<string, string>("French Polynesia", "French Polynesia"));
            Countries.Add(new KeyValuePair<string, string>("Gabon", "Gabon"));
            Countries.Add(new KeyValuePair<string, string>("Gambia", "Gambia"));
            Countries.Add(new KeyValuePair<string, string>("Georgia", "Georgia"));
            Countries.Add(new KeyValuePair<string, string>("Germany", "Germany"));
            Countries.Add(new KeyValuePair<string, string>("Ghana", "Ghana"));
            Countries.Add(new KeyValuePair<string, string>("Gibraltar", "Gibraltar"));
            Countries.Add(new KeyValuePair<string, string>("Greece", "Greece"));
            Countries.Add(new KeyValuePair<string, string>("Greenland", "Greenland"));
            Countries.Add(new KeyValuePair<string, string>("Grenada", "Grenada"));
            Countries.Add(new KeyValuePair<string, string>("Guadeloupe", "Guadeloupe"));
            Countries.Add(new KeyValuePair<string, string>("Guam", "Guam"));
            Countries.Add(new KeyValuePair<string, string>("Guatemala", "Guatemala"));
            Countries.Add(new KeyValuePair<string, string>("Guinea", "Guinea"));
            Countries.Add(new KeyValuePair<string, string>("Guinea-Bissau", "Guinea-Bissau"));
            Countries.Add(new KeyValuePair<string, string>("Guyana", "Guyana"));
            Countries.Add(new KeyValuePair<string, string>("Haiti", "Haiti"));
            Countries.Add(new KeyValuePair<string, string>("Holland", "Holland"));
            Countries.Add(new KeyValuePair<string, string>("Honduras", "Honduras"));
            Countries.Add(new KeyValuePair<string, string>("Hong Kong", "Hong Kong"));
            Countries.Add(new KeyValuePair<string, string>("Hungary", "Hungary"));
            Countries.Add(new KeyValuePair<string, string>("Iceland", "Iceland"));
            Countries.Add(new KeyValuePair<string, string>("India", "India"));
            Countries.Add(new KeyValuePair<string, string>("Indonesia", "Indonesia"));
            Countries.Add(new KeyValuePair<string, string>("Israel", "Israel"));
            Countries.Add(new KeyValuePair<string, string>("Italy", "Italy"));
            Countries.Add(new KeyValuePair<string, string>("Ivory Coast", "Ivory Coast"));
            Countries.Add(new KeyValuePair<string, string>("Jamaica", "Jamaica"));
            Countries.Add(new KeyValuePair<string, string>("Japan", "Japan"));
            Countries.Add(new KeyValuePair<string, string>("Jordan", "Jordan"));
            Countries.Add(new KeyValuePair<string, string>("Kazakhstan", "Kazakhstan"));
            Countries.Add(new KeyValuePair<string, string>("Kenya", "Kenya"));
            Countries.Add(new KeyValuePair<string, string>("Kiribati", "Kiribati"));
            Countries.Add(new KeyValuePair<string, string>("Kosrae", "Kosrae"));
            Countries.Add(new KeyValuePair<string, string>("Kuwait", "Kuwait"));
            Countries.Add(new KeyValuePair<string, string>("Kyrgyzstan", "Kyrgyzstan"));
            Countries.Add(new KeyValuePair<string, string>("Laos", "Laos"));
            Countries.Add(new KeyValuePair<string, string>("Latvia", "Latvia"));
            Countries.Add(new KeyValuePair<string, string>("Lebanon", "Lebanon"));
            Countries.Add(new KeyValuePair<string, string>("Lesotho", "Lesotho"));
            Countries.Add(new KeyValuePair<string, string>("LLiberia", "Liberia"));
            Countries.Add(new KeyValuePair<string, string>("Liechtenstein", "Liechtenstein"));
            Countries.Add(new KeyValuePair<string, string>("Lithuania", "Lithuania"));
            Countries.Add(new KeyValuePair<string, string>("Luxembourg", "Luxembourg"));
            Countries.Add(new KeyValuePair<string, string>("Macau", "Macau"));
            Countries.Add(new KeyValuePair<string, string>("Macedonia", "Macedonia"));
            Countries.Add(new KeyValuePair<string, string>("Madagascar", "Madagascar"));
            Countries.Add(new KeyValuePair<string, string>("Madeira", "Madeira"));
            Countries.Add(new KeyValuePair<string, string>("Malawi", "Malawi"));
            Countries.Add(new KeyValuePair<string, string>("Malaysia", "Malaysia"));
            Countries.Add(new KeyValuePair<string, string>("Maldives", "Maldives"));
            Countries.Add(new KeyValuePair<string, string>("Mali", "Mali"));
            Countries.Add(new KeyValuePair<string, string>("Malta", "Malta"));
            Countries.Add(new KeyValuePair<string, string>("Marshall Islands", "Marshall Islands"));
            Countries.Add(new KeyValuePair<string, string>("Martinique", "Martinique"));
            Countries.Add(new KeyValuePair<string, string>("Mauritania", "Mauritania"));
            Countries.Add(new KeyValuePair<string, string>("Mauritius", "Mauritius"));
            Countries.Add(new KeyValuePair<string, string>("Mexico", "Mexico"));
            Countries.Add(new KeyValuePair<string, string>("Moldova", "Moldova"));
            Countries.Add(new KeyValuePair<string, string>("Monaco", "Monaco"));
            Countries.Add(new KeyValuePair<string, string>("Montserrat", "Montserrat"));
            Countries.Add(new KeyValuePair<string, string>("Morocco", "Morocco"));
            Countries.Add(new KeyValuePair<string, string>("Mozambique", "Mozambique"));
            Countries.Add(new KeyValuePair<string, string>("Myanmar", "Myanmar"));
            Countries.Add(new KeyValuePair<string, string>("Namibia", "Namibia"));
            Countries.Add(new KeyValuePair<string, string>("Nepal", "Nepal"));
            Countries.Add(new KeyValuePair<string, string>("Netherlands", "Netherlands"));
            Countries.Add(new KeyValuePair<string, string>("Netherlands Antilles", "Netherlands Antilles"));
            Countries.Add(new KeyValuePair<string, string>("New Caledonia", "New Caledonia"));
            Countries.Add(new KeyValuePair<string, string>("New Zealand", "New Zealand"));
            Countries.Add(new KeyValuePair<string, string>("Nicaragua", "Nicaragua"));
            Countries.Add(new KeyValuePair<string, string>("Niger", "Niger"));
            Countries.Add(new KeyValuePair<string, string>("Nigeria", "Nigeria"));
            Countries.Add(new KeyValuePair<string, string>("Norfolk Island", "Norfolk Island"));
            Countries.Add(new KeyValuePair<string, string>("Northern Ireland", "Northern Ireland"));
            Countries.Add(new KeyValuePair<string, string>("Northern Mariana Islands", "Northern Mariana Islands"));
            Countries.Add(new KeyValuePair<string, string>("Norway", "Norway"));
            Countries.Add(new KeyValuePair<string, string>("Oman", "Oman"));
            Countries.Add(new KeyValuePair<string, string>("Pakistan", "Pakistan"));
            Countries.Add(new KeyValuePair<string, string>("Palau", "Palau"));
            Countries.Add(new KeyValuePair<string, string>("Panama", "Panama"));
            Countries.Add(new KeyValuePair<string, string>("Papua New Guinea", "Papua New Guinea"));
            Countries.Add(new KeyValuePair<string, string>("Paraguay", "Paraguay"));
            Countries.Add(new KeyValuePair<string, string>("Peru", "Peru"));
            Countries.Add(new KeyValuePair<string, string>("Philippines", "Philippines"));
            Countries.Add(new KeyValuePair<string, string>("Poland", "Poland"));
            Countries.Add(new KeyValuePair<string, string>("Ponape", "Ponape"));
            Countries.Add(new KeyValuePair<string, string>("Portugal", "Portugal"));
            Countries.Add(new KeyValuePair<string, string>("Puerto Rico", "Puerto Rico"));
            Countries.Add(new KeyValuePair<string, string>("Qatar", "Qatar"));
            Countries.Add(new KeyValuePair<string, string>("Republic of Ireland", "Republic of Ireland"));
            Countries.Add(new KeyValuePair<string, string>("Republic of Yemen", "Republic of Yemen"));
            Countries.Add(new KeyValuePair<string, string>("Reunion", "Reunion"));
            Countries.Add(new KeyValuePair<string, string>("Romania", "Romania"));
            Countries.Add(new KeyValuePair<string, string>("Rota", "Rota"));
            Countries.Add(new KeyValuePair<string, string>("Russia", "Russia"));
            Countries.Add(new KeyValuePair<string, string>("Rwanda", "Rwanda"));
            Countries.Add(new KeyValuePair<string, string>("Saba", "Saba"));
            Countries.Add(new KeyValuePair<string, string>("Saipan", "Saipan"));
            Countries.Add(new KeyValuePair<string, string>("Saudi Arabia", "Saudi Arabia"));
            Countries.Add(new KeyValuePair<string, string>("Scotland", "Scotland"));
            Countries.Add(new KeyValuePair<string, string>("Senegal", "Senegal"));
            Countries.Add(new KeyValuePair<string, string>("Seychelles", "Seychelles"));
            Countries.Add(new KeyValuePair<string, string>("Sierra Leone", "Sierra Leone"));
            Countries.Add(new KeyValuePair<string, string>("Singapore", "Singapore"));
            Countries.Add(new KeyValuePair<string, string>("Slovakia", "Slovakia"));
            Countries.Add(new KeyValuePair<string, string>("Slovenia", "Slovenia"));
            Countries.Add(new KeyValuePair<string, string>("Solomon Islands", "Solomon Islands"));
            Countries.Add(new KeyValuePair<string, string>("South Africa", "South Africa"));
            Countries.Add(new KeyValuePair<string, string>("South Korea", "South Korea"));
            Countries.Add(new KeyValuePair<string, string>("Spain", "Spain"));
            Countries.Add(new KeyValuePair<string, string>("Sri Lanka", "Sri Lanka"));
            Countries.Add(new KeyValuePair<string, string>("St. Barthelemy", "St. Barthelemy"));
            Countries.Add(new KeyValuePair<string, string>("St. Christopher", "St. Christopher"));
            Countries.Add(new KeyValuePair<string, string>("St. Croix", "St. Croix"));
            Countries.Add(new KeyValuePair<string, string>("St. Eustatius", "St. Eustatius"));
            Countries.Add(new KeyValuePair<string, string>("St. John", "St. John"));
            Countries.Add(new KeyValuePair<string, string>("St. Kitts & Nevis", "St. Kitts & Nevis"));
            Countries.Add(new KeyValuePair<string, string>("St. Lucia", "St. Lucia"));
            Countries.Add(new KeyValuePair<string, string>("St. Maarten", "St. Maarten"));
            Countries.Add(new KeyValuePair<string, string>("St. Martin", "St. Martin"));
            Countries.Add(new KeyValuePair<string, string>("St. Thomas", "St. Thomas"));
            Countries.Add(new KeyValuePair<string, string>("St. Vincent & the Grenadines", "St. Vincent & the Grenadines"));
            Countries.Add(new KeyValuePair<string, string>("Sudan", "Sudan"));
            Countries.Add(new KeyValuePair<string, string>("Suriname", "Suriname"));
            Countries.Add(new KeyValuePair<string, string>("Swaziland", "Swaziland"));
            Countries.Add(new KeyValuePair<string, string>("Sweden", "Sweden"));
            Countries.Add(new KeyValuePair<string, string>("Switzerland", "Switzerland"));
            Countries.Add(new KeyValuePair<string, string>("Syria", "Syria"));
            Countries.Add(new KeyValuePair<string, string>("Tahiti", "Tahiti"));
            Countries.Add(new KeyValuePair<string, string>("Taiwan", "Taiwan"));
            Countries.Add(new KeyValuePair<string, string>("Tajikistan", "Tajikistan"));
            Countries.Add(new KeyValuePair<string, string>("Tanzania", "Tanzania"));
            Countries.Add(new KeyValuePair<string, string>("Thailand", "Thailand"));
            Countries.Add(new KeyValuePair<string, string>("Tinian", "Tinian"));
            Countries.Add(new KeyValuePair<string, string>("Togo", "Togo"));
            Countries.Add(new KeyValuePair<string, string>("Tonga", "Tonga"));
            Countries.Add(new KeyValuePair<string, string>("Tortola", "Tortola"));
            Countries.Add(new KeyValuePair<string, string>("Trinidad & Tobago", "Trinidad & Tobago"));
            Countries.Add(new KeyValuePair<string, string>("Truk", "Truk"));
            Countries.Add(new KeyValuePair<string, string>("Tunisia", "Tunisia"));
            Countries.Add(new KeyValuePair<string, string>("Turkey", "Turkey"));
            Countries.Add(new KeyValuePair<string, string>("Turks & Caicos Islands", "Turks & Caicos Islands"));
            Countries.Add(new KeyValuePair<string, string>("Tuvalu", "Tuvalu"));
            Countries.Add(new KeyValuePair<string, string>("Uganda", "Uganda"));
            Countries.Add(new KeyValuePair<string, string>("Ukraine", "Ukraine"));
            Countries.Add(new KeyValuePair<string, string>("Union Island", "Union Island"));
            Countries.Add(new KeyValuePair<string, string>("United Arab Emirates", "United Arab Emirates"));
            Countries.Add(new KeyValuePair<string, string>("United Kingdom", "United Kingdom"));
            Countries.Add(new KeyValuePair<string, string>("Uruguay", "Uruguay"));
            Countries.Add(new KeyValuePair<string, string>("US Virgin Islands", "US Virgin Islands"));
            Countries.Add(new KeyValuePair<string, string>("Uzbekistan", "Uzbekistan"));
            Countries.Add(new KeyValuePair<string, string>("Vanuatu", "Vanuatu"));
            Countries.Add(new KeyValuePair<string, string>("Venezuela", "Venezuela"));
            Countries.Add(new KeyValuePair<string, string>("Vietnam", "Vietnam"));
            Countries.Add(new KeyValuePair<string, string>("Virgin Gorda", "Virgin Gorda"));
            Countries.Add(new KeyValuePair<string, string>("Wake Island", "Wake Island"));
            Countries.Add(new KeyValuePair<string, string>("Wales", "Wales"));
            Countries.Add(new KeyValuePair<string, string>("Wallis & Futuna Islands", "Wallis & Futuna Islands"));
            Countries.Add(new KeyValuePair<string, string>("Western Samoa", "Western Samoa"));
            Countries.Add(new KeyValuePair<string, string>("Yap", "Yap"));
            Countries.Add(new KeyValuePair<string, string>("Yugoslavia", "Yugoslavia"));
            Countries.Add(new KeyValuePair<string, string>("Zaire", "Zaire"));
            Countries.Add(new KeyValuePair<string, string>("Zambia", "Zambia"));
            return Countries;
        }























        // STATES DROP-DOWN
        // ACCESS THIS METHOD IN CODE DIRECTLY AS SO:   List<KeyValuePair<string, string>> ListStates = FormItems.GetStates();
        public static List<KeyValuePair<string, string>> GetStates()
        {
            List<KeyValuePair<string, string>> States = new List<KeyValuePair<string, string>>();
            States.Add(new KeyValuePair<string, string>("Alabama", "Alabama"));
            States.Add(new KeyValuePair<string, string>("Alaska", "Alaska"));
            States.Add(new KeyValuePair<string, string>("Arizona", "Arizona"));
            States.Add(new KeyValuePair<string, string>("Arkansas", "Arkansas"));
            States.Add(new KeyValuePair<string, string>("California", "California"));
            States.Add(new KeyValuePair<string, string>("Colorado", "Colorado"));
            States.Add(new KeyValuePair<string, string>("Connecticut", "Connecticut"));
            States.Add(new KeyValuePair<string, string>("Delaware", "Delaware"));
            States.Add(new KeyValuePair<string, string>("District of Columbia", "District of Columbia"));
            States.Add(new KeyValuePair<string, string>("Florida", "Florida"));
            States.Add(new KeyValuePair<string, string>("Georgia", "Georgia"));
            States.Add(new KeyValuePair<string, string>("Hawaii", "Hawaii"));
            States.Add(new KeyValuePair<string, string>("Idaho", "Idaho"));
            States.Add(new KeyValuePair<string, string>("Illinois", "Illinois"));
            States.Add(new KeyValuePair<string, string>("Indiana", "Indiana"));
            States.Add(new KeyValuePair<string, string>("Iowa", "Iowa"));
            States.Add(new KeyValuePair<string, string>("Kansas", "Kansas"));
            States.Add(new KeyValuePair<string, string>("Kentucky", "Kentucky"));
            States.Add(new KeyValuePair<string, string>("Louisiana", "Louisiana"));
            States.Add(new KeyValuePair<string, string>("Maine", "Maine"));
            States.Add(new KeyValuePair<string, string>("Maryland", "Maryland"));
            States.Add(new KeyValuePair<string, string>("Massachusetts", "Massachusetts"));
            States.Add(new KeyValuePair<string, string>("Michigan", "Michigan"));
            States.Add(new KeyValuePair<string, string>("Minnesota", "Minnesota"));
            States.Add(new KeyValuePair<string, string>("Mississippi", "Mississippi"));
            States.Add(new KeyValuePair<string, string>("Missouri", "Missouri"));
            States.Add(new KeyValuePair<string, string>("Montana", "Montana"));
            States.Add(new KeyValuePair<string, string>("Nebraska", "Nebraska"));
            States.Add(new KeyValuePair<string, string>("Nevada", "Nevada"));
            States.Add(new KeyValuePair<string, string>("New Hampshire", "New Hampshire"));
            States.Add(new KeyValuePair<string, string>("New Jersey", "New Jersey"));
            States.Add(new KeyValuePair<string, string>("New Mexico", "New Mexico"));
            States.Add(new KeyValuePair<string, string>("New York", "New York"));
            States.Add(new KeyValuePair<string, string>("North Carolina", "North Carolina"));
            States.Add(new KeyValuePair<string, string>("North Dakota", "North Dakota"));
            States.Add(new KeyValuePair<string, string>("Ohio", "Ohio"));
            States.Add(new KeyValuePair<string, string>("Oklahoma", "Oklahoma"));
            States.Add(new KeyValuePair<string, string>("Oregon", "Oregon"));
            States.Add(new KeyValuePair<string, string>("Pennsylvania", "Pennsylvania"));
            States.Add(new KeyValuePair<string, string>("Rhode Island", "Rhode Island"));
            States.Add(new KeyValuePair<string, string>("South Carolina", "South Carolina"));
            States.Add(new KeyValuePair<string, string>("South Dakota", "South Dakota"));
            States.Add(new KeyValuePair<string, string>("Tennessee", "Tennessee"));
            States.Add(new KeyValuePair<string, string>("Texas", "Texas"));
            States.Add(new KeyValuePair<string, string>("Utah", "Utah"));
            States.Add(new KeyValuePair<string, string>("Vermont", "Vermont"));
            States.Add(new KeyValuePair<string, string>("Virginia", "Virginia"));
            States.Add(new KeyValuePair<string, string>("Washington", "Washington"));
            States.Add(new KeyValuePair<string, string>("West Virginia", "West Virginia"));
            States.Add(new KeyValuePair<string, string>("Wisconsin", "Wisconsin"));
            States.Add(new KeyValuePair<string, string>("Wyoming", "Wyoming"));
            States.Add(new KeyValuePair<string, string>("Not in usa", "Not in usa"));
            return States;
        }


        // AGE DROP-DOWN
        // ACCESS THIS METHOD IN CODE DIRECTLY AS SO:   List<KeyValuePair<string, string>> ListGender = FormItems.GetAges();
        public static List<KeyValuePair<string, string>> GetAges()
        {
            List<KeyValuePair<string, string>> Ages = new List<KeyValuePair<string, string>>();
            for (int i = 1; i < 100; i++)
            {
                Ages.Add(new KeyValuePair<string, string>(i.ToString(), i.ToString()));
            }
            return Ages;

        }

        // GENDER DROP-DOWN
        // ACCESS THIS METHOD IN CODE DIRECTLY AS SO:   List<KeyValuePair<string, string>> ListGender = FormItems.GetGenders();
        public static List<KeyValuePair<string, string>> GetGenders()
        {
            List<KeyValuePair<string, string>> Genders = new List<KeyValuePair<string, string>>();
            Genders.Add(new KeyValuePair<string, string>("Male", "Male"));
            Genders.Add(new KeyValuePair<string, string>("Female", "Female"));
            Genders.Add(new KeyValuePair<string, string>("Transgender", "Transgender"));
            return Genders;
        }


        // CATEGORY DROP-DOWN
        // ACCESS THIS METHOD IN CODE DIRECTLY AS SO:   List<KeyValuePair<string, string>> ListCategory = FormItems.GetCategories();
        public static List<KeyValuePair<string, string>> GetCategories()
        {
            List<KeyValuePair<string, string>> Categories = new List<KeyValuePair<string, string>>();
            Categories.Add(new KeyValuePair<string, string>("Family", "Family"));
            Categories.Add(new KeyValuePair<string, string>("Friends", "Friends"));
            Categories.Add(new KeyValuePair<string, string>("Colleague", "Colleague"));
            Categories.Add(new KeyValuePair<string, string>("People", "People"));
            Categories.Add(new KeyValuePair<string, string>("Service", "Service"));
            return Categories;
        }






        // AppType DROP-DOWN
        // ACCESS THIS METHOD IN CODE DIRECTLY AS SO:   List<KeyValuePair<string, string>> ListAppType = FormItems.GetApplicationTypes();
        //public static List<KeyValuePair<string, string>> GetApplicationTypes()
        //{
        //    List<KeyValuePair<string, string>> Apptypes = new List<KeyValuePair<string, string>>();
        //    Apptypes.Add(new KeyValuePair<string, string>("Application", "Application"));
        //    Apptypes.Add(new KeyValuePair<string, string>("Service", "Service"));
        //    Apptypes.Add(new KeyValuePair<string, string>("Website", "Website"));
        //    return Apptypes;
        //}







        public static List<SelectListItem> GetApplicationTypes()
        {
            List<SelectListItem> Apptypes = new List<SelectListItem>();
            new SelectListItem { Value = "Application", Text = "Application" };
            new SelectListItem { Value = "Service", Text = "Service" };
            new SelectListItem { Value = "Website", Text = "Website" };
            return Apptypes;
        }


        public static List<SelectListItem> GetApplicationTypes2()
        {
            List<SelectListItem> Apptypes = new List<SelectListItem>();
            new SelectListItem { Value = "Application", Text = "Application" };
            new SelectListItem { Value = "Service", Text = "Service" };
            new SelectListItem { Value = "Website", Text = "Website" };
            return Apptypes;
        }

        public static List<SelectListItem> GetApplicationTypes3()
        {
            List<SelectListItem> Apptypes = new List<SelectListItem>();
            Apptypes.Add(new SelectListItem("Application", "Application"));
            Apptypes.Add(new SelectListItem("Service", "Service"));
            Apptypes.Add(new SelectListItem("(Website", "Website"));
            return Apptypes;
        }



        //public static IEnumerable<SelectListItem> ToSelectListItems(
        //     this IEnumerable<T> items,
        //     Func<T, string> nameSelector,
        //     Func<T, string> valueSelector,
        //     Func<T, bool> selected)
        //{
        //    return items.OrderBy(item => nameSelector(item))
        //           .Select(item =>
        //                   new SelectListItem
        //                   {
        //                       Selected = selected(item),
        //                       Text = nameSelector(item),
        //                       Value = valueSelector(item)
        //                   });
        //}



        // AppStatus DROP-DOWN
        // ACCESS THIS METHOD IN CODE DIRECTLY AS SO:   List<KeyValuePair<int, int>> ListAppStatus = FormItems.GetApplicationStatuses(();
        //public static List<KeyValuePair<int, int>> GetApplicationStatuses()
        //{
        //    List<KeyValuePair<int, int>> AppStatuses = new List<KeyValuePair<int, int>>();
        //    AppStatuses.Add(new KeyValuePair<int, int>(0, 0));
        //    AppStatuses.Add(new KeyValuePair<int, int>(1, 1));
        //    return AppStatuses;
        //}


        public static List<SelectListItem> GetApplicationStatuses()
        {
            List<SelectListItem> AppStatuses = new List<SelectListItem>();
            new SelectListItem { Value = "0", Text = "0" };
            new SelectListItem { Value = "1", Text = "1" };
            return AppStatuses;
        }



    }// END class FormItems








}
