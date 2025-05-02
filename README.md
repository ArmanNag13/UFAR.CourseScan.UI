# **UFAR CourseScan UI 📚**

**UFAR CourseScan UI** is the frontend component of the **UFAR CourseScan** platform developed during the **Project S4** course at **Université Française en Arménie (UFAR)**. It provides the user interface for managing and viewing course syllabuses, making it easy to upload, parse, and view detailed course data.

---

## **Project Description**

The **UFAR CourseScan UI** is the client-side part of the **UFAR CourseScan** platform. It communicates with the **backend** to allow users to:
- **Upload PDF syllabuses**
- **View course details** including learning outcomes, assessments, syllabus topics, and references
- **Search and filter** courses based on specific criteria like language, academic year, and course title

The frontend is built using **Blazor**, ensuring a modern, interactive experience for users.

---

## **Key Features**

- **Course Management Dashboard**: View, search, and filter courses with detailed information on course content, learning outcomes, and assessments.
- **PDF Upload**: Upload course syllabuses in PDF format and view the extracted course details.
- **Multi-language Support**: Support for syllabuses in **English**, **Armenian**, and **French**.
- **Interactive Components**: Built using **Blazor** to provide a rich, interactive user experience.
- **Responsive Design**: The UI is designed to be responsive, providing a seamless experience across different devices and screen sizes.

---

## **Tools & Technologies**

- **Frontend Framework**: **Blazor** for building interactive web components.
- **Backend**: **C# (.NET Core)** API for server-side logic and data management (connected to the [UFAR CourseScan Backend](https://github.com/ArmanNag13/UFAR.CourseScan.Backend)).
- **UI Framework**: **Bootstrap** for responsive layout and styling.
- **Version Control**: **Git** (with **GitHub**) for source code management.
- **Project Management**: **Asana** for tracking tasks and project progress.

---

## **Installation & Setup**

Follow these steps to set up the **UFAR CourseScan UI** on your local machine:

### **Prerequisites**
Ensure you have the following installed:
- **.NET SDK**: [Download here](https://dotnet.microsoft.com/)
- **Visual Studio**: [Download here](https://visualstudio.microsoft.com/)

### **Setup Instructions**
1. **Clone the repository:**
    ```bash
    git clone https://github.com/ArmanNag13/UFAR.CourseScan.UI.git
    cd UFAR.CourseScan.UI
    ```

2. **Open the solution in Visual Studio**:
    - Open the `.sln` solution file in **Visual Studio**.
    - Restore NuGet packages by right-clicking on the solution and selecting **Restore NuGet Packages**.

3. **Connect to the backend**:
    - Ensure the **UFAR CourseScan Backend** is running locally or remotely.
    - Update the connection settings in `appsettings.json` if needed to point to the backend API.

4. **Run the application**:
    - Press **F5** or click **Start** in Visual Studio to run the frontend.
    - The UI will be available at `http://localhost:5000` or the URL you configured for the backend.

---

## **Related Repositories**

- [UFAR CourseScan Backend](https://github.com/ArmanNag13/UFAR.CourseScan.Backend)

---

## **Team Members & Roles**

| Name               | Role                            |
|--------------------|----------------------------------|
| **Vahe Mirzoyan**   | Project Manager & Tester         |
| **Arman Nagdalyan** | Parsing Expert                   |
| **Arsen Martirosyan** | Frontend Developer               |
| **Artur Babayan**   | Database Developer               |
| **Artur Gevorgyan** | Data Extraction Specialist       |

---

## **Contributing**

If you'd like to contribute to **UFAR CourseScan UI**, feel free to fork the repository and submit a pull request. Contributions can include:
- Bug fixes
- New features
- UI improvements

Please ensure that any changes you make align with the project's goals and provide sufficient testing for the new features.

---

## **License**

This project is licensed under the MIT License – see the [LICENSE](LICENSE) file for details.

---

## **Acknowledgements**

- **Université Française en Arménie (UFAR)** for supporting this project as part of the Project S4 course.
- The **.NET Core** and **Blazor** communities for their powerful frameworks.
