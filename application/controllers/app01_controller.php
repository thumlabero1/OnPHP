<?php if ( ! defined('BASEPATH')) exit('No direct script access allowed');

class app01_controller extends CI_Controller {

	public function __construct()
	{
		parent::__construct();
	}

	public function index()
	{
		echo "controller";
		$this->load->view('app01_views');

	}

}

/* End of file app01.controller.php */
/* Location: ./application/controllers/app01.controller.php */