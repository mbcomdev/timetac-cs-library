namespace TimeTac_Libary.Tasks
{
    public class TaskModel
    {
        public int Id { get; set; }
        public int Mother_id { get; set; }
        public string Name { get; set; }
        public string Node_path { get; set; }
        public string View_id { get; set; }
        public int? Jira_id { get; set; }
        public int? Sort_order { get; set; }
        public int? Ultimate_mother_id { get; set; }
        public bool? Is_done { get; set; }
        public int? View_order { get; set; }
        public string Icon_name { get; set; }
        public int? Initial_duration { get; set; }
        public int? Target_duration { get; set; }
        public string Begin { get; set; }
        public string Deadline { get; set; }
        public string Object_type { get; set; }
        public string Notes { get; set; }
        public int? Client_id { get; set; }
        public string T_iv_1 { get; set; }
        public string T_iv_2 { get; set; }
        public string T_iv_3 { get; set; }
        public string T_iv_4 { get; set; }
        public string T_iv_5 { get; set; }
        public string T_iv_6 { get; set; }
        public bool? Approve_by_project_leader { get; set; }
        public bool? Is_blocked { get; set; }
        public bool? Is_hidden { get; set; }
        public bool? Restrict_tracking_from_to { get; set; }
        public int? Duration { get; set; }
        public bool? Is_startable { get; set; }
        public bool? Is_paid_non_working { get; set; }
    }
}
