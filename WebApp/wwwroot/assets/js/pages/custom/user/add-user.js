"use strict";

// Class Definition
var KTAddUser = function () {
	// Private Variables
	var _wizardEl;
	var _formEl;
	var _wizard;
	var _avatar;
	var _validations = [];

	// Private Functions
	var _initWizard = function () {
		// Initialize form wizard
		_wizard = new KTWizard(_wizardEl, {
			startStep: 1, // initial active step number
			clickableSteps: true  // allow step clicking
		});

		// Validation before going to next page
		_wizard.on('beforeNext', function (wizard) {
			// Don't go to the next step yet
			_wizard.stop();

			// Validate form
			var validator = _validations[wizard.getStep() - 1]; // get validator for currnt step
			validator.validate().then(function (status) {
		        if (status == 'Valid') {
					_wizard.goNext();
					KTUtil.scrollTop();
				} else {
					Swal.fire({
						text: "Uzgunuz, bir yada birkac hata ile karsilasildi, lutfen tekrar deneyin.",
		                icon: "error",
		                buttonsStyling: false,
						confirmButtonText: "Tamam, anladim!",
						customClass: {
							confirmButton: "btn font-weight-bold btn-light"
						}
		            }).then(function() {
						KTUtil.scrollTop();
					});
				}
		    });
		});

		// Change Event
		_wizard.on('change', function (wizard) {
			KTUtil.scrollTop();
		});
	}

	var _initValidations = function () {
		// Init form validation rules. For more info check the FormValidation plugin's official documentation:https://formvalidation.io/

		// Validation Rules For Step 1
		_validations.push(FormValidation.formValidation(
			_formEl,
			{
				fields: {
					txtName: {
						validators: {
							notEmpty: {
								message: 'Adi Bos Olamaz !'
							}
						}
					},
					txtSurname: {
						validators: {
							notEmpty: {
								message: 'Soyadi Bos Olamaz !'
							}
						}
					},
					txtPhone1: {
						validators: {
							notEmpty: {
								message: 'Telefon 1 Bilgisi Bos Olamaz !'
							}
						}
					}
				},
				plugins: {
					trigger: new FormValidation.plugins.Trigger(),
					bootstrap: new FormValidation.plugins.Bootstrap()
				}
			}
		));

		_validations.push(FormValidation.formValidation(
			_formEl,
			{
				fields: {
					txtAddress1: {
						validators: {
							notEmpty: {
								message: 'Adres Satiri Bos Olamaz !'
							}
						}
					},
					txtCity: {
						validators: {
							notEmpty: {
								message: 'Il Bos Olamaz !'
							}
						}
					},
					txtCounty: {
						validators: {
							notEmpty: {
								message: 'Ilce Bos Olamaz !'
							}
						}
					}
				},
				plugins: {
					trigger: new FormValidation.plugins.Trigger(),
					bootstrap: new FormValidation.plugins.Bootstrap()
				}
			}
		));

		_validations.push(FormValidation.formValidation(
			_formEl,
			{
				//fields: {
				//	// Step 2
				//	communication: {
				//		validators: {
				//			choice: {
				//				min: 1,
				//				message: 'Please select at least 1 option'
				//			}
				//		}
				//	},
				//	language: {
				//		validators: {
				//			notEmpty: {
				//				message: 'Please select a language'
				//			}
				//		}
				//	}
				//},

				//fields: {
				//	txtCourseFee: {
				//		validators: {
				//			notEmpty: {
				//				message: 'Kurs Ucreti Bos Olamaz !'
				//			}
				//		}
				//	}
				//},
				plugins: {
					trigger: new FormValidation.plugins.Trigger(),
					bootstrap: new FormValidation.plugins.Bootstrap()
				}
			}
		));
		
	}

	var _initAvatar = function () {
		_avatar = new KTImageInput('kt_user_add_avatar');
	}

	return {
		// public functions
		init: function () {
			_wizardEl = KTUtil.getById('kt_wizard');
			_formEl = KTUtil.getById('kt_form');

			_initWizard();
			_initValidations();
			_initAvatar();
		}
	};
}();

jQuery(document).ready(function () {
	KTAddUser.init();
});
