﻿using LisokasNail.Models;
using LizokasNail.Client.Di;
using System;
using System.Windows.Forms;

namespace LizokasNail.Client.Forms.Edit
{
    public partial class EditUserForm : Form
    {
        private readonly IUserRepo _repo;
        private UserBl _user;

        public EditUserForm(IUserRepo repo, UserBl user = null)
        {
            InitializeComponent();
            _repo = repo;
            _user = user;

            if (user != null)
            {
                Text = "Редактирование клиента";
            }
            else
            {
                Text = "Новый клиент";
                _user = new UserBl();
            }

            textEditName.DataBindings.Add("EditValue", _user, nameof(_user.Name));
            textEditPhone.DataBindings.Add("EditValue", _user, nameof(_user.Phone));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (_user.Id == 0)
            {
                _repo.Add(_user);
            }
            else
            {
                _repo.Update(_user);
            }

            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}