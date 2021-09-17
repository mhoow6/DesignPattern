using System;

namespace DesignPattern_Composite
{
    // 컴포지트 패턴
    // - 포함하는 것들과 포함되는 것들이 같은 방식으로 다루도록 하는 패턴
    
    class Program
    {
        static void Main(string[] args)
        {
            CustomFolder schoolFolder = new CustomFolder("학교");
            CustomFolder grade1Folder = new CustomFolder("1학년");
            CustomFolder grade2Folder = new CustomFolder("2학년");

            schoolFolder.Add(grade1Folder);
            schoolFolder.Add(grade2Folder);

            CustomFile enterPhoto = new CustomFile("입학사진", 256);
            grade1Folder.Add(enterPhoto);

            CustomFolder sem1Folder = new CustomFolder("1학기");
            CustomFolder sem2Folder = new CustomFolder("2학기");

            grade2Folder.Add(sem1Folder);
            grade2Folder.Add(sem2Folder);

            CustomFile lecturePlan = new CustomFile("강의계획서", 120);
            sem1Folder.Add(lecturePlan);

            CustomFolder projFolder = new CustomFolder("프로젝트");
            sem2Folder.Add(projFolder);

            CustomFile draft = new CustomFile("드래프트", 488);
            CustomFile finalResult = new CustomFile("결과물", 560);

            projFolder.Add(draft);
            projFolder.Add(finalResult);

            schoolFolder.GetSize();
        }
    }
}
