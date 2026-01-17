// ===== Проверка, что файл подключился =====
console.log("contact.js loaded");

// ===== CREATE MODAL =====
function openCreateModal() {
    document.getElementById("createModal").style.display = "block";
}

function closeCreateModal() {
    document.getElementById("createModal").style.display = "none";
}

// ===== EDIT MODAL =====
function openEditModal(id, name, phone, job, birthDate) {
    document.getElementById("editId").value = id;
    document.getElementById("editName").value = name;
    document.getElementById("editMobile").value = phone;
    document.getElementById("editJob").value = job;
    document.getElementById("editBirthDate").value = birthDate;

    document.getElementById("editModal").style.display = "block";
}

function closeEditModal() {
    document.getElementById("editModal").style.display = "none";
}

// ===== VALIDATION =====
function validateContactForm(formId) {
    const form = document.getElementById(formId);

    const name = form.querySelector("input[name='Name']").value;
    const phone = form.querySelector("input[name='MobilePhone']").value;

    if (name.trim().length < 2) {
        alert("Name must be at least 2 characters");
        return false;
    }

    const phoneRegex = /^\+?\d{10,15}$/;
    if (!phoneRegex.test(phone)) {
        alert("Invalid phone number");
        return false;
    }

    return true;
}
