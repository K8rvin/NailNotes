﻿using LisokasNail.Models;
using LizokasNail.Client.Di;
using LizokasNail.Contract.Enum;
using System;
using System.Windows.Forms;

namespace LizokasNail.Client.Forms.Edit
{
    public partial class EditUserForm : Form
    {
        private readonly IUserRepo _repo;
        private UserBl _item;

        public EditUserForm(IUserRepo repo, UserBl item = null)
        {
            InitializeComponent();
            _repo = repo;
            _item = item;

            if (item != null)
            {
                Text = "Редактирование клиента";
            }
            else
            {
                Text = "Новый клиент";
                _item = new UserBl();
            }

            textEditName.DataBindings.Add("EditValue", _item, nameof(_item.Name));
            textEditPhone.DataBindings.Add("EditValue", _item, nameof(_item.Phone));
            textEditComment.DataBindings.Add("EditValue", _item, nameof(_item.Comment));
            checkEditVip.DataBindings.Add("Checked", _item, nameof(_item.Vip));

            imageComboBoxEditCommunication.Properties.Items.AddEnum<CommunicationType>();
            imageComboBoxEditCommunication.DataBindings.Add("EditValue", _item, nameof(_item.CommunicationType));
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void simpleButtonSave_Click(object sender, EventArgs e)
        {
            ProcessTabKey(true);

            if (_item.Id == 0)
            {
                _repo.Add(_item);
            }
            else
            {
                _repo.Update(_item);
            }

            DialogResult = DialogResult.OK;
        }
    }
}
