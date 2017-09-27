using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.EmployeePortal.Shared
{
    public class ValidationConstants
    {
        //public const string PasswordRegEx = @"^[a-zA-Z0-9!@#$%^&*~?.]$";

        public static class NoticeMessages
        {
            public const string NoticeCommon = "Common";

            public const string TitleMandatory = "Title should not be empty.";
            public const string TitleLength = "Title should be less than 100 characters";

            public const string DescriptionMandatory = "Description should not be empty.";
            public const string DescriptionLength = "Description should be less than 500 characters";

            public const string StartDateMandatory = "Start Date should not be empty.";

        }

        public static class IssueMessages
        {
            public const string IssueCommon = "Common";
            public const string UpdateByAdmin = "UpdateByAdmin";

            public const string TitleMandatory = "Title should not be empty.";
            public const string TitleLength = "Title should be less than 100 characters";

            public const string DescriptionMandatory = "Description should not be empty.";
            public const string DescriptionLength = "Description should be less than 500 characters";

            public const string CommentsLength = "Comments should be less than 500 characters";

            public const string PriorityMandatory = "Priority can't be unselected";

            public const string AssignedToMandatory = "AssignedTo property cannot be empty";

            public const string StatusMandatory = "Status cannot be unselected";


          
        }

        public static class UsersMessages
        {
            public const string UserCommon = "Common";

            public const string FirstNameMandatory = "First Name should not be empty.";
            public const string FirstNameLength = "First Name should be less than 50 characters";

            public const string LastNameMandatory = "Last Name should not be empty.";
            public const string LastNameLength = "Last Name should be less than 50 characters";

            public const string EmailMandatory = "Email should not be empty.";
            public const string EmailLength = "Email should be less than 100 characters";
            public const string EmailValidation = "Not a valid e-mail";
            public const string EmailExistence = "This Email id already exits";

            public const string DateOfJoiningMandatory = "Date of joining must not be empty.";
            public const string DepartmentIdMandatory = "Department id should not be empty";

            public const string UserIdMandatory = "UserId should not be empty.";
        }


        public static class Names
        {
            public const string Email = "Email";
            public const string DateOfJoining = "DateOfJoining";
            public const string FirstName = "FirstName";
            public const string LastName = "LastName";
            public const string DepartmentId = "DepartmentId";
            public const string Update = "Update";
            public const string Title = "Title";
            public const string Description = "Description";
            public const string StartDate = "StartDate";
            public const string ExpirationDate = "ExpirationDate";
            public const string Comments = "Comments";
            public const string Priority = "Priority";
            public const string AssignedTo = "AssignedTo";
            public const string Status = "Status";
        }
    }
}
