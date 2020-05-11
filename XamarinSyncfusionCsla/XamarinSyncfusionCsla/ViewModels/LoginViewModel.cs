using Csla;
using Csla.Rules.CommonRules;
using Csla.Xaml;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinSyncfusionCsla.ViewModels
{
    public class LoginViewModel : ViewModelBase<LoginModel>
    {
        public LoginViewModel()
        {
            this.Model = DataPortal.Create<LoginModel>();

        }
    }

    [Serializable]
    public class LoginModel : BusinessBase<LoginModel>
    {
        public static readonly PropertyInfo<string> UsernameProperty = RegisterProperty<string>(x => x.Username);
        public string Username
        {
            get => GetProperty(UsernameProperty);
            set => SetProperty(UsernameProperty, value);
        }

        public static readonly PropertyInfo<string> PasswordProperty = RegisterProperty<string>(x => x.Password);
        public string Password
        {
            get => GetProperty(PasswordProperty);
            set => SetProperty(PasswordProperty, value);
        }


        protected override void AddBusinessRules()
        {
            BusinessRules.SuppressRuleChecking = true;
            base.AddBusinessRules();

            //Email
            BusinessRules.AddRule(new Required(UsernameProperty));
            BusinessRules.AddRule(new RegExMatch(UsernameProperty, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", "Username is not a valid email.") { NullOption = RegExMatch.NullResultOptions.ReturnTrue });
            BusinessRules.AddRule(new Required(PasswordProperty));
        }

        public void SuppressRuleChecking()
        {
            this.BusinessRules.SuppressRuleChecking = true;
        }
        public void ContinueRuleChecking()
        {
            this.BusinessRules.SuppressRuleChecking = false;
            this.BusinessRules.CheckRules();
        }
    }


 
}
