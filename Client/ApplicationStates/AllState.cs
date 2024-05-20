namespace Client.ApplicationStates
{
    public class AllState
    {
        public Action? Action { get; set; }
        //General Department
        public bool ShowGeneralDepartment { get; set; }
        public void GeneralDepartmentClicked()
        {
            ResetAllDepartment();
            ShowGeneralDepartment = true;
            Action?.Invoke();
        }
        //Department
        public bool ShowDepartment { get; set; }
        public void DepartmentClicked()
        {
            ResetAllDepartment();
            ShowDepartment = true;
            Action?.Invoke();
        }
        //Branch
        public bool ShowBranch { get; set; }
        public void BranchClicked()
        {
            ResetAllDepartment();
            ShowBranch = true;
            Action?.Invoke();
        }
        //Country
        public bool ShowCountry { get; set; }
        public void CountryClicked()
        {
            ResetAllDepartment();
            ShowCountry = true;
            Action?.Invoke();
        }
        //City
        public bool ShowCity { get; set; }
        public void CityClicked()
        {
            ResetAllDepartment();
            ShowCity = true;
            Action?.Invoke();
        }
        //Town
        public bool ShowTown { get; set; }
        public void TownClicked()
        {
            ResetAllDepartment();
            ShowTown = true;
            Action?.Invoke();
        }

        //User
        public bool ShowUser { get; set; }
        public void UserClicked()
        {
            ResetAllDepartment();
            ShowUser = true;
            Action?.Invoke();
        }
        //Employee
        public bool ShowEmployee { get; set; }
        public void EmployeeClicked()
        {
            ResetAllDepartment();
            ShowEmployee = true;
            Action?.Invoke();
        }
        //Doctor
        public bool ShowHealth { get; set; }
        public void DoctorClicked()
        {
            ResetAllDepartment();
            ShowHealth = true;
            Action?.Invoke();
        }
        //Overtime Type
        public bool ShowOvertime { get; set; }
        public void OvertimeClicked()
        {
            ResetAllDepartment();
            ShowOvertime = true;
            Action?.Invoke();
        }
        public bool ShowOvertimeType { get; set; }
        public void OvertimeTypeClicked()
        {
            ResetAllDepartment();
            ShowOvertimeType = true;
            Action?.Invoke();
        }
        //Sanction Type
        public bool ShowSanctionType { get; set; }
        public void SanctionTypeClicked()
        {
            ResetAllDepartment();
            ShowSanctionType = true;
            Action?.Invoke();
        }
        public bool ShowSanction { get; set; }
        public void SanctionClicked()
        {
            ResetAllDepartment();
            ShowSanction = true;
            Action?.Invoke();
        }
        //Vacation Type
        public bool ShowVacationType { get; set; }
        public void VacationTypeClicked()
        {
            ResetAllDepartment();
            ShowVacationType = true;
            Action?.Invoke();
        }
        public bool ShowVacation { get; set; }
        public void VacationClicked()
        {
            ResetAllDepartment();
            ShowVacation = true;
            Action?.Invoke();
        }
        private void ResetAllDepartment()
        {
            ShowGeneralDepartment= false;
            ShowDepartment = false;
            ShowBranch = false;
            ShowCountry = false;
            ShowCity = false;
            ShowTown = false;
            ShowUser = false;
            ShowEmployee = false;
            ShowHealth = false;
            ShowOvertime = false;
            ShowOvertimeType = false;
            ShowSanction = false;
            ShowSanctionType = false;
            ShowVacation = false;
            ShowVacationType = false;
        }
    }
}
