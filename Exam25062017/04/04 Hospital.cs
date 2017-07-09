using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class _04Hospital
    {
        class Patient
        {
            public string Name { get; set; }
            public string DoctorName { get; set; }
            public int Room { get; set; }
            public string Department { get; set; }
        }

        static void Main(string[] args)
        {
            var departments = new Dictionary<string, List<Patient>>();
            var departmentsCapacity = new Dictionary<string, int>();

            var input = string.Empty;
            while ((input = Console.ReadLine()) != "Output")
            {
                //Cardiology Petar Petrov Ventsi
                var tokens = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                var departmentName = tokens[0];
                var doctorName = tokens[1] + " " + tokens[2];
                var patientName = tokens[3];

                if (departmentsCapacity.ContainsKey(departmentName))
                {
                    if (departmentsCapacity[departmentName] == 60) { continue; }

                    departmentsCapacity[departmentName]++;
                }
                else
                {
                    departmentsCapacity.Add(departmentName, 1);
                }

                var newPatient = new Patient()
                {
                    Department = departmentName,
                    DoctorName = doctorName,
                    Name = patientName,
                    Room = ((departmentsCapacity[departmentName] - 1) / 3) + 1
                    //1 / 4 = 0 ..1
                    //2 / 4 = 0 ..1
                    // 3 / 4 = 1 ..1
                };

                if (departments.ContainsKey(departmentName))
                {
                    departments[departmentName].Add(newPatient);

                }
                else
                {
                    departments.Add(departmentName, new List<Patient>() { newPatient });
                }
            }


            var stringsToPrint = new List<string>();

            while ((input = Console.ReadLine()) != "End")
            {
                var commands = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                string wantedDepartment = commands[0];

                if (commands.Length == 1)
                {
                    stringsToPrint = departments[wantedDepartment].Select(p => p.Name).ToList();
                }
                else
                {
                    int wantedRoomNumber;
                    bool isRoomWanted = int.TryParse(commands[1], out wantedRoomNumber);
                    if (isRoomWanted)
                    {
                        stringsToPrint = departments[wantedDepartment].Where(p => p.Room == wantedRoomNumber).Select(p => p.Name).OrderBy(p => p).ToList();
                    }
                    else
                    {
                        string wantedDoctor = commands[0] + " " + commands[1];
                        stringsToPrint = departments.Values.SelectMany(x => x).ToList().Where(p => p.DoctorName == wantedDoctor).Select(p => p.Name).OrderBy(p => p).ToList();
                    }
                }
            }

            Console.WriteLine(String.Join("\n", stringsToPrint));

        }
    }
}
