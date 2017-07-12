
using System.Collections.Generic;

namespace EnigmaSharp
{
    public static class SyntaxHighlightData
    {
        public static readonly HashSet<string> Constants = new HashSet<string>
        {
			"true",
			"false",
			"pi",
			"async_load",
			"ev_create",
			"ev_destroy",
			"ev_step",
			"ev_alarm",
			"ev_keyboard",
			"ev_mouse",
			"ev_collision",
			"ev_other",
			"ev_draw",
			"ev_gui",
			"ev_keypress",
			"ev_keyrelease",
			"ev_left_button",
			"ev_right_button",
			"ev_middle_button",
			"ev_no_button",
			"ev_left_press",
			"ev_right_press",
			"ev_middle_press",
			"ev_left_release",
			"ev_right_release",
			"ev_middle_release",
			"ev_mouse_enter",
			"ev_mouse_leave",
			"ev_mouse_wheel_up",
			"ev_mouse_wheel_down",
			"ev_global_left_button",
			"ev_global_right_button",
			"ev_global_middle_button",
			"ev_global_left_press",
			"ev_global_right_press",
			"ev_global_middle_press",
			"ev_global_left_release",
			"ev_global_right_release",
			"ev_global_middle_release",
			"ev_joystick1_left",
			"ev_joystick1_right",
			"ev_joystick1_up",
			"ev_joystick1_down",
			"ev_joystick1_button1",
			"ev_joystick1_button2",
			"ev_joystick1_button3",
			"ev_joystick1_button4",
			"ev_joystick1_button5",
			"ev_joystick1_button6",
			"ev_joystick1_button7",
			"ev_joystick1_button8",
			"ev_joystick2_left",
			"ev_joystick2_right",
			"ev_joystick2_up",
			"ev_joystick2_down",
			"ev_joystick2_button1",
			"ev_joystick2_button2",
			"ev_joystick2_button3",
			"ev_joystick2_button4",
			"ev_joystick2_button5",
			"ev_joystick2_button6",
			"ev_joystick2_button7",
			"ev_joystick2_button8",
			"ev_outside",
			"ev_boundary",
			"ev_game_start",
			"ev_game_end",
			"ev_room_start",
			"ev_room_end",
			"ev_no_more_lives",
			"ev_animation_end",
			"ev_end_of_path",
			"ev_no_more_health",
			"ev_user0",
			"ev_user1",
			"ev_user2",
			"ev_user3",
			"ev_user4",
			"ev_user5",
			"ev_user6",
			"ev_user7",
			"ev_user8",
			"ev_user9",
			"ev_user10",
			"ev_user11",
			"ev_user12",
			"ev_user13",
			"ev_user14",
			"ev_user15",
			"ev_step_normal",
			"ev_step_begin",
			"ev_step_end",
			"vk_nokey",
			"vk_anykey",
			"vk_enter",
			"vk_return",
			"vk_shift",
			"vk_control",
			"vk_alt",
			"vk_escape",
			"vk_space",
			"vk_backspace",
			"vk_tab",
			"vk_pause",
			"vk_printscreen",
			"vk_left",
			"vk_right",
			"vk_up",
			"vk_down",
			"vk_home",
			"vk_end",
			"vk_delete",
			"vk_insert",
			"vk_pageup",
			"vk_pagedown",
			"vk_f1",
			"vk_f2",
			"vk_f3",
			"vk_f4",
			"vk_f5",
			"vk_f6",
			"vk_f7",
			"vk_f8",
			"vk_f9",
			"vk_f10",
			"vk_f11",
			"vk_f12",
			"vk_numpad0",
			"vk_numpad1",
			"vk_numpad2",
			"vk_numpad3",
			"vk_numpad4",
			"vk_numpad5",
			"vk_numpad6",
			"vk_numpad7",
			"vk_numpad8",
			"vk_numpad9",
			"vk_divide",
			"vk_multiply",
			"vk_subtract",
			"vk_add",
			"vk_decimal",
			"vk_lshift",
			"vk_lcontrol",
			"vk_lalt",
			"vk_rshift",
			"vk_rcontrol",
			"vk_ralt",
			"mb_any",
			"mb_none",
			"mb_left",
			"mb_right",
			"mb_middle",
			"c_aqua",
			"c_black",
			"c_blue",
			"c_dkgray",
			"c_fuchsia",
			"c_gray",
			"c_green",
			"c_lime",
			"c_ltgray",
			"c_maroon",
			"c_navy",
			"c_olive",
			"c_purple",
			"c_red",
			"c_silver",
			"c_teal",
			"c_white",
			"c_yellow",
			"fa_left",
			"fa_center",
			"fa_right",
			"fa_top",
			"fa_middle",
			"fa_bottom",
			"pr_pointlist",
			"pr_linelist",
			"pr_linestrip",
			"pr_trianglelist",
			"pr_trianglestrip",
			"pr_trianglefan",
			"bm_normal",
			"bm_add",
			"bm_max",
			"bm_subtract",
			"bm_zero",
			"bm_one",
			"bm_src_color",
			"bm_inv_src_color",
			"bm_src_alpha",
			"bm_inv_src_alpha",
			"bm_dest_alpha",
			"bm_inv_dest_alpha",
			"bm_dest_color",
			"bm_inv_dest_color",
			"bm_src_alpha_sat",
			"cr_default",
			"cr_none",
			"cr_arrow",
			"cr_cross",
			"cr_beam",
			"cr_size_nesw",
			"cr_size_ns",
			"cr_size_nwse",
			"cr_size_we",
			"cr_uparrow",
			"cr_hourglass",
			"cr_drag",
			"cr_nodrop",
			"cr_hsplit",
			"cr_vsplit",
			"cr_multidrag",
			"cr_sqlwait",
			"cr_no",
			"cr_appstart",
			"cr_help",
			"cr_handpoint",
			"cr_size_all",
			"se_none",
			"se_chorus",
			"se_echo",
			"se_flanger",
			"se_gargle",
			"se_reverb",
			"se_compressor",
			"se_equalizer",
			"fa_readonly",
			"fa_hidden",
			"fa_sysfile",
			"fa_volumeid",
			"fa_directory",
			"fa_archive",
			"ef_explosion",
			"ef_ring",
			"ef_ellipse",
			"ef_firework",
			"ef_smoke",
			"ef_smokeup",
			"ef_star",
			"ef_spark",
			"ef_flare",
			"ef_cloud",
			"ef_rain",
			"ef_snow",
			"pt_shape_pixel",
			"pt_shape_disk",
			"pt_shape_square",
			"pt_shape_line",
			"pt_shape_star",
			"pt_shape_circle",
			"pt_shape_ring",
			"pt_shape_sphere",
			"pt_shape_flare",
			"pt_shape_spark",
			"pt_shape_explosion",
			"pt_shape_cloud",
			"pt_shape_smoke",
			"ps_distr_linear",
			"ps_distr_gaussian",
			"ps_shape_rectangle",
			"ps_shape_ellipse",
			"ps_shape_diamond",
			"ps_shape_line",
			"ps_force_constant",
			"ps_force_linear",
			"ps_force_quadratic",
			"ps_deflect_vertical",
			"ps_deflect_horizontal",
			"ps_change_all",
			"ps_change_shape",
			"ps_change_motion",
			"ty_real",
			"ty_string",
			"dll_cdecl",
			"dll_stdcall",
			"vertex_usage_position",
			"vertex_usage_colour",
			"vertex_usage_normal",
			"vertex_usage_textcoord",
			"vertex_usage_blendweight",
			"vertex_usage_blendindices",
			"vertex_usage_depth",
			"vertex_usage_tangent",
			"vertex_usage_binormal",
			"vertex_usage_fog",
			"vertex_usage_sample",
			"vertex_type_float1",
			"vertex_type_float2",
			"vertex_type_float3",
			"vertex_type_float4",
			"vertex_type_colour",
			"vertex_type_ubyte4",
			"phy_joint_anchor_1_x",
			"phy_joint_anchor_1_y",
			"phy_joint_anchor_2_x",
			"phy_joint_anchor_2_y",
			"phy_joint_reaction_force_x",
			"phy_joint_reaction_force_y",
			"phy_joint_reaction_torque",
			"phy_joint_max_motor_force",
			"phy_joint_max_motor_torque",
			"phy_joint_motor_force",
			"phy_joint_motor_speed",
			"phy_joint_motor_torque",
			"phy_joint_angle",
			"phy_joint_angle_limits",
			"phy_joint_upper_angle_limit",
			"phy_joint_lower_angle_limit",
			"phy_joint_translation",
			"phy_joint_speed",
			"phy_joint_length_1",
			"phy_joint_length_2",
			"phy_joint_damping_ratio",
			"phy_joint_frequency",
			"gp_face1",
			"gp_face2",
			"gp_face3",
			"gp_face4",
			"gp_shoulderl",
			"gp_shoulderr",
			"gp_shoulderlb",
			"gp_shoulderrb",
			"gp_select",
			"gp_start",
			"gp_stickl",
			"gp_stickr",
			"gp_padu",
			"gp_padd",
			"gp_padl",
			"gp_padr",
			"gp_axislh",
			"gp_axislv",
			"gp_axisrh",
			"gp_axisrv",
			"buffer_generalerror",
			"buffer_invalidtype",
			"buffer_outofbounds",
			"buffer_outofspace",
			"buffer_vbuffer",
			"buffer_seek_start",
			"buffer_seek_end",
			"buffer_seek_relative",
			"buffer_surface_copy",
			"buffer_surface_grayscale",
			"buffer_surface_mask",
			"buffer_fast",
			"buffer_fixed",
			"buffer_grow",
			"buffer_wrap",
			"buffer_u8",
			"buffer_s8",
			"buffer_u16",
			"buffer_s16",
			"buffer_u32",
			"buffer_s32",
			"buffer_f16",
			"buffer_f32",
			"buffer_f64",
			"buffer_bool",
			"buffer_string",
			"network_socket_bluetooth",
			"network_socket_tcp",
			"network_socket_udp",
			"display_landscape",
			"display_landscape_flipped",
			"display_portrait",
			"display_portrait_flipped",
			"os_windows",
			"os_win8native",
			"os_win32",
			"os_winphone",
			"os_linux",
			"os_macosx",
			"os_ios",
			"os_android",
			"os_unknown",
			"network_type_connect",
			"network_type_disconnect",
			"network_type_data",
			"browser_not_a_browser",
			"browser_unknown",
			"browser_ie",
			"browser_firefox",
			"browser_chrome",
			"browser_safari",
			"browser_opera",
			"browser_safari_mobile",
			"browser_windows_store",
			"achievement_achievement_info",
			"achievement_challenge_received",
			"achievement_challenge_completed",
			"achievement_challenge_completed_by_remote",
			"achievement_challenge_launched",
			"achievement_type_score_challenge",
			"achievement_type_achievement_challenge",
			"achievement_our_info",
			"achievement_friends_info",
			"device_ios_ipad",
			"device_ios_ipad_retina",
			"device_ios_iphone5",
			"device_ios_iphone",
			"device_ios_iphone_retina",
			"device_emulator",
			"device_tablet",
			"device_ios_unknown",
			"ov_friends",
			"ov_community",
			"ov_players",
			"ov_settings",
			"ov_gamegroup",
			"ov_achievements",
			"lb_sort_none",
			"lb_sort_ascending",
			"lb_sort_descending",
			"lb_disp_none",
			"lb_disp_numeric",
			"lb_disp_time_sec",
			"lb_disp_time_ms",
			"ANSI_CHARSET",
			"DEFAULT_CHARSET",
			"EASTEUROPE_CHARSET",
			"RUSSIAN_CHARSET",
			"SYMBOL_CHARSET",
			"SHIFTJIS_CHARSET",
			"HANGEUL_CHARSET",
			"GB2312_CHARSET",
			"CHINESEBIG5_CHARSET",
			"JOHAB_CHARSET",
			"HEBREW_CHARSET",
			"ARABIC_CHARSET",
			"GREEK_CHARSET",
			"TURKISH_CHARSET",
			"VIETNAMESE_CHARSET",
			"THAI_CHARSET",
			"MAC_CHARSET",
			"BALTIC_CHARSET",
			"OEM_CHARSET",
			"text_type",
			"button_type",
			"input_type",
			"audio_old_system",
			"audio_new_system",
			"audio_falloff_exponent_distance",
			"audio_falloff_exponent_distance_clamped",
			"audio_falloff_inverse_distance",
			"audio_falloff_inverse_distance_clamped",
			"audio_falloff_linear_distance",
			"audio_falloff_linear_distance_clamped",
			"audio_falloff_none",
			"matrix_view",
			"matrix_projection",
			"matrix_world",

        };

        public static readonly HashSet<string> Constructs = new HashSet<string>
        {
			"if",
			"repeat",
			"while",
			"do",
			"for",
			"switch",
			"break",
			"continue",
			"exit",
			"var",
			"else",
			"until",
			"case",
			"default",
			"return",
			"with",
			"then",
			"begin",
			"end",
			"self",
			"other",
			"all",
			"noone",
			"global",
			"globalvar",
			"local",

        };

        public static readonly HashSet<string> Variables = new HashSet<string>
        {
			"argument_relative",
			"argument",
			"argument0",
			"argument1",
			"argument2",
			"argument3",
			"argument4",
			"argument5",
			"argument6",
			"argument7",
			"argument8",
			"argument9",
			"argument10",
			"argument11",
			"argument12",
			"argument13",
			"argument14",
			"argument15",
			"x",
			"y",
			"xprevious",
			"yprevious",
			"xstart",
			"ystart",
			"hspeed",
			"vspeed",
			"direction",
			"speed",
			"friction",
			"gravity",
			"gravity_direction",
			"path_index",
			"path_position",
			"path_positionprevious",
			"path_speed",
			"path_scale",
			"path_orientation",
			"path_endaction",
			"object_index",
			"id",
			"solid",
			"persistent",
			"mask_index",
			"instance_count",
			"instance_id",
			"room_speed",
			"fps",
			"delta_time",
			"current_time",
			"current_year",
			"current_month",
			"current_day",
			"current_weekday",
			"current_hour",
			"current_minute",
			"current_second",
			"alarm[12]",
			"timeline_index",
			"timeline_position",
			"timeline_speed",
			"room",
			"room_first",
			"room_last",
			"room_width",
			"room_height",
			"room_caption",
			"room_persistent",
			"score",
			"lives",
			"health",
			"show_score",
			"show_lives",
			"show_health",
			"caption_score",
			"caption_lives",
			"caption_health",
			"event_type",
			"event_number",
			"event_object",
			"event_action",
			"error_occurred",
			"error_last",
			"gamemaker_registered",
			"keyboard_key",
			"keyboard_lastkey",
			"keyboard_lastchar",
			"keyboard_string",
			"mouse_x",
			"mouse_y",
			"mouse_button",
			"mouse_lastbutton",
			"visible",
			"sprite_index",
			"sprite_width",
			"sprite_height",
			"sprite_xoffset",
			"sprite_yoffset",
			"image_number",
			"image_index",
			"image_speed",
			"depth",
			"image_xscale",
			"image_yscale",
			"image_angle",
			"image_alpha",
			"image_blend",
			"bbox_left",
			"bbox_right",
			"bbox_top",
			"bbox_bottom",
			"background_color",
			"background_showcolor",
			"background_visible",
			"background_foreground",
			"background_index",
			"background_x",
			"background_y",
			"background_width",
			"background_height",
			"background_htiled",
			"background_vtiled",
			"background_xscale",
			"background_yscale",
			"background_hspeed",
			"background_vspeed",
			"background_blend",
			"background_alpha",
			"view_enabled",
			"view_current",
			"view_visible",
			"view_xview",
			"view_yview",
			"view_wview",
			"view_hview",
			"view_xport",
			"view_yport",
			"view_wport",
			"view_hport",
			"view_angle",
			"view_hborder",
			"view_vborder",
			"view_hspeed",
			"view_vspeed",
			"view_object",
			"transition_kind",
			"game_id",
			"working_directory",
			"program_directory",
			"temp_directory",
			"secure_mode",
			"phy_active",
			"phy_angular_velocity",
			"phy_linear_velocity_x",
			"phy_linear_velocity_y",
			"phy_speed_x",
			"phy_speed_y",
			"phy_position_x",
			"phy_position_y",
			"phy_rotation",
			"phy_fixed_rotation",
			"phy_bullet",
			"phy_com_x",
			"phy_com_y",
			"phy_dynamic",
			"phy_kinematic",
			"phy_inertia",
			"phy_mass",
			"phy_sleeping",
			"phy_collision_points",
			"phy_collision_x",
			"phy_collision_y",
			"phy_col_normal_x",
			"phy_col_normal_y",
			"display_aa",
			"os_type",
			"os_version",

        };

        public static readonly HashSet<string> Operators = new HashSet<string>
        {
			"not",
			"and",
			"or",
			"xor",
			"div",
			"mod",

        };

        public static readonly HashSet<string> Functions = new HashSet<string>
        {
			"abs",
			"achievement_available",
			"achievement_filter_all_players",
			"achievement_filter_friends_only",
			"achievement_get_challenges",
			"achievement_get_pic",
			"achievement_leaderboards_info",
			"achievement_load_friends",
			"achievement_load_leaderboard",
			"achievement_load_progress",
			"achievement_login",
			"achievement_login_status",
			"achievement_logout",
			"achievement_pic_loaded",
			"achievement_post",
			"achievement_post_score",
			"achievement_reset",
			"achievement_send_challenge",
			"achievement_show_achievements",
			"achievement_show_challenge_notifications",
			"achievement_show_leaderboards",
			"ads_disable",
			"ads_enable",
			"ads_engagement_active",
			"ads_engagement_available",
			"ads_engagement_launch",
			"ads_event",
			"ads_event_preload",
			"ads_get_display_width",
			"ads_get_display_height",
			"ads_interstitial_available",
			"ads_interstitial_display",
			"ads_move",
			"ads_setup",
			"ads_set_reward_callback",
			"angle_difference",
			"ansi_char",
			"array_height_2d",
			"array_length_1d",
			"array_length_2d",
			"arccos",
			"arcsin",
			"arctan2",
			"arctan",
			"audio_system",
			"audio_exists",
			"audio_get_type",
			"audio_play_music",
			"audio_pause_music",
			"audio_stop_music",
			"audio_play_sound",
			"audio_play_sound_at",
			"audio_pause_sound",
			"audio_pause_all",
			"audio_resume_sound",
			"audio_resume_music",
			"audio_resume_all",
			"audio_stop_sound",
			"audio_stop_all",
			"audio_is_playing",
			"audio_music_is_playing",
			"audio_sound_length",
			"audio_sound_pitch",
			"audio_falloff_set_model",
			"audio_music_gain",
			"audio_sound_gain",
			"audio_master_gain",
			"audio_channel_num",
			"audio_emitter_create",
			"audio_emitter_exists",
			"audio_emitter_position",
			"audio_emitter_velocity",
			"audio_emitter_falloff",
			"audio_emitter_gain",
			"audio_emitter_pitch",
			"audio_emitter_free",
			"audio_play_sound_on",
			"audio_listener_position",
			"audio_listener_velocity",
			"audio_listener_orientation",
			"background_add_alpha",
			"background_add",
			"background_assign",
			"background_create_color",
			"background_create_from_screen",
			"background_create_from_surface",
			"background_create_gradient",
			"background_delete",
			"background_duplicate",
			"background_exists",
			"background_get_height",
			"background_get_name",
			"background_get_preload",
			"background_get_smooth",
			"background_get_texture",
			"background_get_uvs",
			"background_get_transparent",
			"background_get_width",
			"background_replace_alpha",
			"background_replace",
			"background_save",
			"background_set_alpha_from_background",
			"base64_decode",
			"base64_encode",
			"buffer_create",
			"buffer_delete",
			"buffer_read",
			"buffer_write",
			"buffer_fill",
			"buffer_seek",
			"buffer_tell",
			"buffer_peek",
			"buffer_poke",
			"buffer_save",
			"buffer_save_ext",
			"buffer_load",
			"buffer_load_ext",
			"buffer_copy",
			"buffer_get_size",
			"buffer_resize",
			"buffer_sizeof",
			"buffer_md5",
			"buffer_sha1",
			"buffer_base64_encode",
			"buffer_base64_decode",
			"buffer_base64_decode_ext",
			"cd_close_door",
			"cd_init",
			"cd_length",
			"cd_number",
			"cd_open_door",
			"cd_paused",
			"cd_pause",
			"cd_playing",
			"cd_play",
			"cd_position",
			"cd_present",
			"cd_resume",
			"cd_set_position",
			"cd_set_track_position",
			"cd_stop",
			"cd_track_length",
			"cd_track_position",
			"cd_track",
			"clamp",
			"cloud_synchronise",
			"cloud_string_save",
			"cloud_file_save",
			"ceil",
			"choose",
			"chr",
			"clipboard_get_text",
			"clipboard_has_text",
			"clipboard_set_text",
			"collision_circle",
			"collision_ellipse",
			"collision_line",
			"collision_point",
			"collision_rectangle",
			"color_get_blue",
			"color_get_green",
			"color_get_hue",
			"color_get_red",
			"color_get_saturation",
			"color_get_value",
			"cos",
			"d3d_draw_block",
			"d3d_draw_cone",
			"d3d_draw_cylinder",
			"d3d_draw_ellipsoid",
			"d3d_draw_floor",
			"d3d_draw_wall",
			"d3d_end",
			"d3d_light_define_ambient",
			"d3d_light_define_direction",
			"d3d_light_define_point",
			"d3d_light_enable",
			"d3d_model_block",
			"d3d_model_clear",
			"d3d_model_cone",
			"d3d_model_create",
			"d3d_model_cylinder",
			"d3d_model_destroy",
			"d3d_model_draw",
			"d3d_model_ellipsoid",
			"d3d_model_floor",
			"d3d_model_load",
			"d3d_model_primitive_begin",
			"d3d_model_primitive_end",
			"d3d_model_save",
			"d3d_model_vertex_color",
			"d3d_model_vertex_normal_color",
			"d3d_model_vertex_normal_texture_color",
			"d3d_model_vertex_normal_texture",
			"d3d_model_vertex_normal",
			"d3d_model_vertex_texture_color",
			"d3d_model_vertex_texture",
			"d3d_model_vertex",
			"d3d_model_wall",
			"d3d_primitive_begin_texture",
			"d3d_primitive_begin",
			"d3d_primitive_end",
			"d3d_set_culling",
			"d3d_set_depth",
			"d3d_set_zwriteenable",
			"d3d_set_fog",
			"d3d_set_hidden",
			"d3d_set_lighting",
			"d3d_set_perspective",
			"d3d_set_projection_ext",
			"d3d_set_projection_ortho",
			"d3d_set_projection_perspective",
			"d3d_set_projection",
			"d3d_set_shading",
			"d3d_start",
			"d3d_transform_add_rotation_axis",
			"d3d_transform_add_rotation_x",
			"d3d_transform_add_rotation_y",
			"d3d_transform_add_rotation_z",
			"d3d_transform_add_scaling",
			"d3d_transform_add_translation",
			"d3d_transform_set_identity",
			"d3d_transform_set_rotation_axis",
			"d3d_transform_set_rotation_x",
			"d3d_transform_set_rotation_y",
			"d3d_transform_set_rotation_z",
			"d3d_transform_set_scaling",
			"d3d_transform_set_translation",
			"d3d_transform_stack_clear",
			"d3d_transform_stack_discard",
			"d3d_transform_stack_empty",
			"d3d_transform_stack_pop",
			"d3d_transform_stack_push",
			"d3d_transform_stack_top",
			"d3d_vertex_color",
			"d3d_vertex_normal(x,y,z,nx,ny,nz) Add vertex",
			"d3d_vertex_normal_color",
			"d3d_vertex_normal_texture_color",
			"d3d_vertex_normal_texture",
			"d3d_vertex_texture_color",
			"d3d_vertex_texture",
			"d3d_vertex",
			"date_compare_datetime",
			"date_compare_date",
			"date_compare_time",
			"date_create_datetime",
			"date_create_date",
			"date_create_time",
			"date_current_datetime",
			"date_current_date",
			"date_current_time",
			"date_datetime_string",
			"date_date_of",
			"date_date_string",
			"date_days_in_month",
			"date_days_in_year",
			"date_day_span",
			"date_get_day_of_year",
			"date_get_day",
			"date_get_hour_of_year",
			"date_get_hour",
			"date_get_minute_of_year",
			"date_get_minute",
			"date_get_month",
			"date_get_second_of_year",
			"date_get_second",
			"date_get_weekday",
			"date_get_week",
			"date_get_year",
			"date_hour_span",
			"date_inc_day",
			"date_inc_hour",
			"date_inc_minute",
			"date_inc_month",
			"date_inc_second",
			"date_inc_week",
			"date_inc_year",
			"date_is_today",
			"date_leap_year",
			"date_minute_span",
			"date_month_span",
			"date_second_span",
			"date_time_of",
			"date_time_string",
			"date_valid_datetime",
			"date_valid_date",
			"date_valid_time",
			"date_week_span",
			"date_year_span",
			"degtorad",
			"device_mouse_check_button",
			"device_mouse_check_button_pressed",
			"device_mouse_check_button_released",
			"device_mouse_dbclick_enable",
			"device_mouse_x",
			"device_mouse_y",
			"device_mouse_raw_x",
			"device_mouse_raw_y",
			"device_is_keypad_open",
			"device_get_tilt_x",
			"device_get_tilt_y",
			"device_get_tilt_z",
			"directory_create",
			"directory_exists",
			"discard_include_file",
			"display_get_colordepth",
			"display_get_frequency",
			"display_get_height",
			"display_get_orientation",
			"display_get_width",
			"display_get_dpi_x",
			"display_get_dpi_y",
			"display_get_gui_width",
			"display_get_gui_height",
			"display_mouse_get_x",
			"display_mouse_get_y",
			"display_mouse_set",
			"display_reset",
			"display_set_all",
			"display_set_colordepth",
			"display_set_frequency",
			"display_set_size",
			"display_set_gui_size",
			"display_test_all",
			"distance_to_object",
			"distance_to_point",
			"dot_product",
			"dot_product_3d",
			"dot_product_normalised",
			"dot_product_normalised_3d",
			"draw_arrow",
			"draw_background_ext",
			"draw_background_general",
			"draw_background_part",
			"draw_background_part_ext",
			"draw_background_stretched_ext",
			"draw_background_stretched",
			"draw_background_tiled_ext",
			"draw_background_tiled",
			"draw_background",
			"draw_button",
			"draw_circle_color",
			"draw_circle",
			"draw_clear_alpha",
			"draw_clear",
			"draw_ellipse_color",
			"draw_ellipse",
			"draw_enable_alphablend",
			"draw_enable_drawevent",
			"draw_getpixel",
			"draw_getpixel_ext",
			"draw_get_alpha",
			"draw_get_color",
			"draw_healthbar",
			"draw_highscore",
			"draw_line_color",
			"draw_line_width_color",
			"draw_line_width",
			"draw_line",
			"draw_path",
			"draw_point_color",
			"draw_point",
			"draw_primitive_begin_texture",
			"draw_primitive_begin",
			"draw_primitive_end",
			"draw_rectangle_color",
			"draw_rectangle",
			"draw_roundrect_color",
			"draw_roundrect",
			"draw_self",
			"draw_set_alpha",
			"draw_set_alpha_test",
			"draw_set_alpha_test_ref_value",
			"draw_set_blend_mode_ext",
			"draw_set_blend_mode",
			"draw_set_circle_precision",
			"draw_set_color",
			"draw_set_color_rgb",
			"draw_set_color_rgba",
			"draw_set_color_write_enable",
			"draw_set_font",
			"draw_set_halign",
			"draw_set_valign",
			"draw_sprite_ext",
			"draw_sprite_general",
			"draw_sprite_part_ext",
			"draw_sprite_part",
			"draw_sprite_pos",
			"draw_sprite_stretched_ext",
			"draw_sprite_stretched",
			"draw_sprite_tiled_ext",
			"draw_sprite_tiled",
			"draw_sprite",
			"draw_surface",
			"draw_surface_ext",
			"draw_surface_general",
			"draw_surface_part_ext",
			"draw_surface_part",
			"draw_surface_stretched_ext",
			"draw_surface_stretched",
			"draw_surface_tiled_ext",
			"draw_surface_tiled",
			"draw_text_color",
			"draw_text_ext_color",
			"draw_text_ext_transformed_color",
			"draw_text_ext_transformed",
			"draw_text_ext",
			"draw_text_transformed_color",
			"draw_text_transformed",
			"draw_text",
			"draw_triangle_color",
			"draw_triangle",
			"draw_vertex_color",
			"draw_vertex_texture_color",
			"draw_vertex_texture",
			"draw_vertex",
			"ds_grid_add_disk",
			"ds_grid_add_grid_region",
			"ds_grid_add_region",
			"ds_grid_add",
			"ds_grid_clear",
			"ds_grid_copy",
			"ds_grid_create",
			"ds_grid_destroy",
			"ds_grid_get_disk_max",
			"ds_grid_get_disk_mean",
			"ds_grid_get_disk_min",
			"ds_grid_get_disk_sum",
			"ds_grid_get_max",
			"ds_grid_get_mean",
			"ds_grid_get_min",
			"ds_grid_get_sum",
			"ds_grid_get",
			"ds_grid_height",
			"ds_grid_multiply_disk",
			"ds_grid_multiply_grid_region",
			"ds_grid_multiply_region",
			"ds_grid_multiply",
			"ds_grid_read",
			"ds_grid_resize",
			"ds_grid_set_disk",
			"ds_grid_set_grid_region",
			"ds_grid_set_region",
			"ds_grid_set",
			"ds_grid_shuffle",
			"ds_grid_value_disk_exists",
			"ds_grid_value_disk_x",
			"ds_grid_value_disk_y",
			"ds_grid_value_exists",
			"ds_grid_value_x",
			"ds_grid_value_y",
			"ds_grid_width",
			"ds_grid_write",
			"ds_list_add",
			"ds_list_clear",
			"ds_list_copy",
			"ds_list_create",
			"ds_list_delete",
			"ds_list_destroy",
			"ds_list_empty",
			"ds_list_find_index",
			"ds_list_find_value",
			"ds_list_insert",
			"ds_list_read",
			"ds_list_replace",
			"ds_list_shuffle",
			"ds_list_size",
			"ds_list_sort",
			"ds_list_write",
			"ds_map_add",
			"ds_map_clear",
			"ds_map_copy",
			"ds_map_create",
			"ds_map_delete",
			"ds_map_destroy",
			"ds_map_empty",
			"ds_map_exists",
			"ds_map_find_first",
			"ds_map_find_last",
			"ds_map_find_next",
			"ds_map_find_previous",
			"ds_map_find_value",
			"ds_map_read",
			"ds_map_replace",
			"ds_map_size",
			"ds_map_write",
			"ds_priority_add",
			"ds_priority_change_priority",
			"ds_priority_clear",
			"ds_priority_copy",
			"ds_priority_create",
			"ds_priority_delete_max",
			"ds_priority_delete_min",
			"ds_priority_delete_value",
			"ds_priority_destroy",
			"ds_priority_empty",
			"ds_priority_find_max",
			"ds_priority_find_min",
			"ds_priority_find_priority",
			"ds_priority_read",
			"ds_priority_size",
			"ds_priority_write",
			"ds_queue_clear",
			"ds_queue_copy",
			"ds_queue_create",
			"ds_queue_dequeue",
			"ds_queue_destroy",
			"ds_queue_empty",
			"ds_queue_enqueue",
			"ds_queue_head",
			"ds_queue_read",
			"ds_queue_size",
			"ds_queue_tail",
			"ds_queue_write",
			"ds_stack_clear",
			"ds_stack_copy",
			"ds_stack_create",
			"ds_stack_destroy",
			"ds_stack_empty",
			"ds_stack_pop",
			"ds_stack_push",
			"ds_stack_read",
			"ds_stack_size",
			"ds_stack_top",
			"ds_stack_write",
			"effect_clear",
			"effect_create_above",
			"effect_create_below",
			"environment_get_variable",
			"event_inherited",
			"event_perform_object",
			"event_perform",
			"event_user",
			"execute_file",
			"execute_program",
			"execute_shell",
			"execute_string",
			"export_include_file_location",
			"export_include_file",
			"exp",
			"external_call",
			"external_define",
			"external_free",
			"filename_change_ext",
			"filename_dir",
			"filename_drive",
			"filename_ext",
			"filename_name",
			"filename_path",
			"file_attributes",
			"file_bin_close",
			"file_bin_open",
			"file_bin_position",
			"file_bin_read_byte",
			"file_bin_rewrite",
			"file_bin_seek",
			"file_bin_size",
			"file_bin_write_byte",
			"file_copy",
			"file_delete",
			"file_exists",
			"file_find_close",
			"file_find_first",
			"file_find_next",
			"file_rename",
			"file_text_close",
			"file_text_eof",
			"file_text_open_append",
			"file_text_open_read",
			"file_text_open_write",
			"file_text_readln",
			"file_text_read_real",
			"file_text_read_string",
			"file_text_writeln",
			"file_text_write_real",
			"file_text_write_string",
			"floor",
			"font_add_sprite",
			"font_add",
			"font_delete",
			"font_exists",
			"font_get_bold",
			"font_get_first",
			"font_get_fontname",
			"font_get_italic",
			"font_get_last",
			"font_get_name",
			"font_get_texture",
			"font_get_uvs",
			"font_replace_sprite",
			"font_replace",
			"frac",
			"game_end",
			"game_load",
			"game_load_buffer",
			"game_restart",
			"game_save",
			"game_save_buffer",
			"gamepad_is_supported",
			"gamepad_get_device_count",
			"gamepad_is_connected",
			"gamepad_get_description",
			"gamepad_get_button_threshold",
			"gamepad_set_button_threshold",
			"gamepad_axis_count",
			"gamepad_axis_value",
			"gamepad_button_check",
			"gamepad_button_check_pressed",
			"gamepad_button_check_released",
			"gamepad_button_count",
			"gamepad_button_value",
			"gamepad_set_vibration",
			"get_color",
			"get_directory_alt",
			"get_directory",
			"get_integer",
			"get_integer_async",
			"get_login_async",
			"get_open_filename",
			"get_open_filename_ext",
			"get_save_filename",
			"get_save_filename_ext",
			"get_string",
			"get_string_async",
			"get_timer",
			"highscore_add_current",
			"highscore_add",
			"highscore_clear",
			"highscore_name",
			"highscore_set_background",
			"highscore_set_border",
			"highscore_set_colors",
			"highscore_set_font",
			"highscore_set_strings",
			"highscore_show_ext",
			"highscore_show",
			"highscore_value",
			"iap_activate",
			"iap_status",
			"iap_store_status",
			"iap_acquire",
			"iap_consume",
			"iap_event_queue",
			"iap_is_downloaded",
			"iap_is_purchased",
			"iap_product_status",
			"iap_product_details",
			"iap_product_files",
			"iap_files_purchased",
			"iap_restore_all",
			"ini_close",
			"ini_key_delete",
			"ini_key_exists",
			"ini_open",
			"ini_read_real",
			"ini_read_string",
			"ini_section_delete",
			"ini_section_exists",
			"ini_write_real",
			"ini_write_string",
			"instance_activate_all",
			"instance_activate_object",
			"instance_activate_region",
			"instance_change",
			"instance_copy",
			"instance_create",
			"instance_deactivate_all",
			"instance_deactivate_object",
			"instance_deactivate_region",
			"instance_destroy",
			"instance_exists",
			"instance_find",
			"instance_furthest",
			"instance_nearest",
			"instance_number",
			"instance_place",
			"instance_position",
			"io_clear",
			"io_handle",
			"irandom",
			"irandom_range",
			"is_array",
			"is_real",
			"is_string",
			"joystick_axes",
			"joystick_buttons",
			"joystick_check_button",
			"joystick_direction",
			"joystick_exists",
			"joystick_has_pov",
			"joystick_name",
			"joystick_pov",
			"joystick_rpos",
			"joystick_upos",
			"joystick_vpos",
			"joystick_xpos",
			"joystick_ypos",
			"joystick_zpos",
			"json_encode",
			"json_decode",
			"keyboard_check_direct",
			"keyboard_check_pressed",
			"keyboard_check_released",
			"keyboard_check",
			"keyboard_clear",
			"keyboard_get_map",
			"keyboard_get_numlock",
			"keyboard_key_press",
			"keyboard_key_release",
			"keyboard_set_map",
			"keyboard_set_numlock",
			"keyboard_unset_map",
			"keyboard_wait",
			"lengthdir_x",
			"lengthdir_y",
			"lerp",
			"ln",
			"log10",
			"log2",
			"logn",
			"make_color_hsv",
			"make_color_rgb",
			"matrix_get",
			"matrix_set",
			"matrix_build",
			"matrix_multiply",
			"max",
			"MCI_command",
			"md5_file",
			"md5_string_unicode",
			"md5_string_utf8",
			"mean",
			"median",
			"merge_color",
			"message_alpha",
			"message_background",
			"message_button_font",
			"message_button",
			"message_caption",
			"message_input_color",
			"message_input_font",
			"message_mouse_color",
			"message_position",
			"message_size",
			"message_text_font",
			"message_text_charset",
			"min",
			"motion_set",
			"motion_add",
			"mouse_check_button_pressed",
			"mouse_check_button_released",
			"mouse_check_button",
			"mouse_clear",
			"move_bounce_all",
			"move_bounce_solid",
			"move_contact_all",
			"move_contact_solid",
			"move_outside_all",
			"move_outside_solid",
			"move_random",
			"move_snap",
			"move_towards_point",
			"move_wrap",
			"mplay_connect_status",
			"mplay_data_mode",
			"mplay_data_read",
			"mplay_data_write",
			"mplay_end",
			"mplay_init_ipx",
			"mplay_init_modem",
			"mplay_init_serial",
			"mplay_init_tcpip",
			"mplay_ipaddress",
			"mplay_message_clear",
			"mplay_message_count",
			"mplay_message_id",
			"mplay_message_name",
			"mplay_message_player",
			"mplay_message_receive",
			"mplay_message_send_guaranteed",
			"mplay_message_send",
			"mplay_message_value",
			"mplay_player_find",
			"mplay_player_id",
			"mplay_player_name",
			"mplay_session_create",
			"mplay_session_end",
			"mplay_session_find",
			"mplay_session_join",
			"mplay_session_mode",
			"mplay_session_name",
			"mplay_session_status",
			"mp_grid_add_cell",
			"mp_grid_add_instances",
			"mp_grid_add_rectangle",
			"mp_grid_clear_all",
			"mp_grid_clear_cell",
			"mp_grid_clear_rectangle",
			"mp_grid_create",
			"mp_grid_destroy",
			"mp_grid_draw",
			"mp_grid_path",
			"mp_linear_path_object",
			"mp_linear_path",
			"mp_linear_step",
			"mp_potential_path_object",
			"mp_potential_path",
			"mp_potential_settings",
			"mp_potential_step_object",
			"mp_potential_step",
			"network_create_server",
			"network_create_socket",
			"network_connect",
			"network_connect_raw",
			"network_resolve",
			"network_set_timeout",
			"network_send_broadcast",
			"network_send_packet",
			"network_send_raw",
			"network_send_udp",
			"network_destroy",
			"object_add",
			"object_delete",
			"object_event_add",
			"object_event_clear",
			"object_exists",
			"object_get_depth",
			"object_get_mask",
			"object_get_name",
			"object_get_parent",
			"object_get_persistent",
			"object_get_solid",
			"object_get_sprite",
			"object_get_visible",
			"object_is_ancestor",
			"object_set_depth",
			"object_set_mask",
			"object_set_parent",
			"object_set_persistent",
			"object_set_solid",
			"object_set_sprite",
			"object_set_visible",
			"ord",
			"os_is_paused",
			"os_is_network_connected",
			"os_lock_orientation",
			"os_get_language",
			"os_get_config",
			"os_powersave_enable",
			"parameter_count",
			"parameter_string",
			"part_attractor_clear",
			"part_attractor_create",
			"part_attractor_destroy_all",
			"part_attractor_destroy",
			"part_attractor_exists",
			"part_attractor_force",
			"part_attractor_position",
			"part_changer_clear",
			"part_changer_create",
			"part_changer_destroy_all",
			"part_changer_destroy",
			"part_changer_exists",
			"part_changer_kind",
			"part_changer_region",
			"part_changer_types",
			"part_deflector_clear",
			"part_deflector_create",
			"part_deflector_destroy_all",
			"part_deflector_destroy",
			"part_deflector_exists",
			"part_deflector_friction",
			"part_deflector_kind",
			"part_deflector_region",
			"part_destroyer_clear",
			"part_destroyer_create",
			"part_destroyer_destroy_all",
			"part_destroyer_destroy",
			"part_destroyer_exists",
			"part_destroyer_region",
			"part_emitter_burst",
			"part_emitter_clear",
			"part_emitter_create",
			"part_emitter_destroy_all",
			"part_emitter_destroy",
			"part_emitter_exists",
			"part_emitter_region",
			"part_emitter_stream",
			"part_particles_clear",
			"part_particles_count",
			"part_particles_create_color",
			"part_particles_create",
			"part_system_automatic_draw",
			"part_system_automatic_update",
			"part_system_clear",
			"part_system_create",
			"part_system_depth Sets th",
			"part_system_destroy",
			"part_system_drawit",
			"part_system_draw_order",
			"part_system_exists",
			"part_system_position",
			"part_system_update",
			"part_type_alpha1",
			"part_type_alpha2",
			"part_type_alpha3",
			"part_type_blend",
			"part_type_clear",
			"part_type_color1",
			"part_type_color2",
			"part_type_color3",
			"part_type_color_hsv",
			"part_type_color_mix",
			"part_type_color_rgb",
			"part_type_create",
			"part_type_death",
			"part_type_destroy",
			"part_type_direction",
			"part_type_exists",
			"part_type_gravity",
			"part_type_life",
			"part_type_orientation",
			"part_type_scale",
			"part_type_shape",
			"part_type_size",
			"part_type_speed",
			"part_type_sprite",
			"part_type_step",
			"path_add_point",
			"path_add",
			"path_append",
			"path_assign",
			"path_change_point",
			"path_clear_points",
			"path_delete_point",
			"path_delete",
			"path_duplicate",
			"path_end",
			"path_exists",
			"path_flip",
			"path_get_closed",
			"path_get_kind",
			"path_get_length",
			"path_get_name",
			"path_get_number",
			"path_get_point_speed",
			"path_get_point_x",
			"path_get_point_y",
			"path_get_precision",
			"path_get_speed",
			"path_get_x",
			"path_get_y",
			"path_insert_point",
			"path_mirror",
			"path_reverse",
			"path_rotate",
			"path_scale",
			"path_set_closed",
			"path_set_kind",
			"path_set_precision",
			"path_shift",
			"path_start",
			"physics_apply_force",
			"physics_apply_impulse",
			"physics_apply_local_force",
			"physics_apply_local_impulse",
			"physics_apply_torque",
			"physics_fixture_create",
			"physics_fixture_bind",
			"physics_fixture_set_collision_group",
			"physics_fixture_delete",
			"physics_fixture_set_box_shape",
			"physics_fixture_set_circle_shape",
			"physics_fixture_set_edge_shape",
			"physics_fixture_set_polygon_shape",
			"physics_fixture_add_point",
			"physics_fixture_set_density",
			"physics_fixture_set_friction",
			"physics_fixture_set_linear_damping",
			"physics_fixture_set_angular_damping",
			"physics_fixture_set_restitution",
			"physics_fixture_set_sensor",
			"physics_fixture_set_kinematic",
			"physics_fixture_set_awake",
			"physics_joint_distance_create",
			"physics_joint_revolute_create",
			"physics_joint_prismatic_create",
			"physics_joint_pulley_create",
			"physics_joint_gear_create",
			"physics_joint_delete",
			"physics_joint_enable_motor",
			"physics_joint_get_value",
			"physics_joint_set_value",
			"physics_test_overlap",
			"physics_mass_properties",
			"place_empty",
			"place_free",
			"place_meeting",
			"place_snapped",
			"point_direction",
			"point_distance",
			"point_distance_3d",
			"point_in_rectangle",
			"point_in_triangle",
			"point_in_circle",
			"position_change",
			"position_destroy",
			"position_empty",
			"position_meeting",
			"power",
			"radtodeg",
			"randomize",
			"random_get_seed",
			"random_set_seed",
			"random",
			"random_range",
			"real",
			"rectangle_in_rectangle",
			"rectangle_in_triangle",
			"rectangle_in_circle",
			"registry_exists_ext",
			"registry_exists",
			"registry_read_real_ext",
			"registry_read_real",
			"registry_read_string_ext",
			"registry_read_string",
			"registry_set_root",
			"registry_write_real_ext",
			"registry_write_real",
			"registry_write_string_ext",
			"registry_write_string",
			"room_add",
			"room_assign",
			"room_duplicate",
			"room_exists",
			"room_get_name",
			"room_goto_next",
			"room_goto_previous",
			"room_goto",
			"room_instance_add",
			"room_instance_clear",
			"room_next",
			"room_previous",
			"room_restart",
			"room_set_background_color",
			"room_set_background",
			"room_set_caption",
			"room_set_code",
			"room_set_height",
			"room_set_persistent",
			"room_set_view_enabled",
			"room_set_view",
			"room_set_width",
			"room_tile_add_ext",
			"room_tile_add",
			"room_tile_clear",
			"round",
			"screen_redraw",
			"screen_refresh",
			"screen_save_part",
			"screen_save",
			"screen_wait_vsync",
			"script_execute",
			"script_exists",
			"script_get_name",
			"script_get_text",
			"set_automatic_draw",
			"set_program_priority",
			"set_synchronization",
			"sha1_string_utf8",
			"sha1_string_unicode",
			"sha1_file",
			"shader_set",
			"shader_get_uniform",
			"shader_get_sampler_index",
			"shader_set_uniform_f",
			"shader_set_uniform_f_array",
			"shader_set_uniform_i",
			"shader_set_uniform_i_array",
			"shader_set_uniform_matrix",
			"shader_set_uniform_matrix_array",
			"shader_reset",
			"shader_is_compiled",
			"shaders_are_supported",
			"shader_enable_corner_id",
			"show_debug_message",
			"show_error",
			"show_menu_pos",
			"show_menu",
			"show_message_ext",
			"show_message",
			"show_message_async",
			"show_question",
			"show_question_async",
			"sign",
			"sin",
			"sleep",
			"sound_3d_set_sound_cone",
			"sound_3d_set_sound_distance",
			"sound_3d_set_sound_position",
			"sound_3d_set_sound_velocity",
			"sound_add",
			"sound_background_tempo",
			"sound_delete",
			"sound_discard",
			"sound_effect_chorus",
			"sound_effect_compressor",
			"sound_effect_echo",
			"sound_effect_equalizer",
			"sound_effect_flanger",
			"sound_effect_gargle",
			"sound_effect_reverb",
			"sound_effect_set",
			"sound_exists",
			"sound_fade",
			"sound_get_kind",
			"sound_get_name",
			"sound_get_preload",
			"sound_global_volume",
			"sound_isplaying",
			"sound_loop",
			"sound_pan",
			"sound_play",
			"sound_replace",
			"sound_restore",
			"sound_set_search_directory",
			"sound_stop_all",
			"sound_stop",
			"sound_volume",
			"splash_show_image",
			"splash_show_text",
			"splash_show_video",
			"sprite_add_alpha",
			"sprite_add_from_screen",
			"sprite_add_from_surface",
			"sprite_add",
			"sprite_assign",
			"sprite_create_from_screen",
			"sprite_create_from_surface",
			"sprite_delete",
			"sprite_duplicate",
			"sprite_exists",
			"sprite_get_bbox_bottom",
			"sprite_get_bbox_left",
			"sprite_get_bbox_mode",
			"sprite_get_bbox_right",
			"sprite_get_bbox_top",
			"sprite_get_height",
			"sprite_get_name",
			"sprite_get_number",
			"sprite_get_precise",
			"sprite_get_preload",
			"sprite_get_smooth",
			"sprite_get_texture",
			"sprite_get_uvs",
			"sprite_get_transparent",
			"sprite_get_width",
			"sprite_get_xoffset",
			"sprite_get_yoffset",
			"sprite_merge",
			"sprite_replace_alpha",
			"sprite_replace",
			"sprite_save",
			"sprite_set_alpha_from_sprite",
			"sprite_set_bbox_mode",
			"sprite_set_bbox",
			"sprite_set_offset",
			"sprite_set_precise",
			"sqrt",
			"sqr",
			"steam_initialised",
			"steam_stats_ready",
			"steam_is_overlay_enabled",
			"steam_get_persona_name",
			"steam_get_user_steam_id",
			"steam_is_user_logged_on",
			"steam_activate_overlay",
			"steam_is_overlay_activated",
			"steam_create_leaderboard",
			"steam_upload_score",
			"steam_download_scores",
			"steam_download_scores_around_user",
			"steam_download_friends_scores",
			"steam_set_achievement",
			"steam_get_achievement",
			"steam_clear_achievement",
			"steam_set_stat_int",
			"steam_set_stat_float",
			"steam_set_stat_avg_rate",
			"steam_get_stat_int",
			"steam_get_stat_float",
			"steam_get_stat_avg_rate",
			"steam_reset_all_stats",
			"steam_reset_all_stats_achievements",
			"steam_is_cloud_enabled_for_app",
			"steam_is_cloud_enabled_for_account",
			"steam_get_quota_total",
			"steam_get_quota_free",
			"steam_file_exists",
			"steam_file_size",
			"steam_file_persisted",
			"steam_file_write",
			"steam_file_write_file",
			"steam_file_read",
			"steam_file_share",
			"steam_file_delete",
			"steam_publish_workshop_file",
			"steam_is_screenshot_requested",
			"steam_send_screenshot",
			"steam_user_owns_dlc",
			"steam_user_installed_dlc",
			"string_byte_at",
			"string_byte_length",
			"string_char_at",
			"string_copy",
			"string_count",
			"string_delete",
			"string_digits",
			"string_format",
			"string_height_ext",
			"string_height",
			"string_insert",
			"string_length",
			"string_letters",
			"string_lower",
			"string_pos",
			"string_repeat",
			"string_replace",
			"string_replace_all",
			"string_set_byte_at",
			"string_upper",
			"string_width_ext",
			"string_width",
			"string",
			"surface_create",
			"surface_copy_part",
			"surface_copy",
			"surface_exists",
			"surface_free",
			"surface_getpixel",
			"surface_getpixel_ext",
			"surface_get_height",
			"surface_get_width",
			"surface_get_texture",
			"surface_set_target",
			"surface_reset_target",
			"surface_save_part",
			"surface_save",
			"tan",
			"texture_get_height",
			"texture_get_width",
			"texture_get_texel_width",
			"texture_get_texel_height",
			"texture_preload",
			"texture_set_blending",
			"texture_set_interpolation",
			"texture_set_interpolation_ext",
			"texture_set_priority",
			"texture_set_repeat",
			"texture_set_repeat_ext",
			"texture_set_stage",
			"tile_add",
			"tile_delete",
			"tile_exists",
			"tile_get_alpha",
			"tile_get_background",
			"tile_get_blend",
			"tile_get_depth",
			"tile_get_height",
			"tile_get_left",
			"tile_get_top",
			"tile_get_visible",
			"tile_get_width",
			"tile_get_xscale",
			"tile_get_x",
			"tile_get_yscale",
			"tile_get_y",
			"tile_layer_delete_at",
			"tile_layer_delete",
			"tile_layer_depth",
			"tile_layer_find",
			"tile_layer_hide",
			"tile_layer_shift",
			"tile_layer_show",
			"tile_set_alpha",
			"tile_set_background",
			"tile_set_blend",
			"tile_set_depth",
			"tile_set_position",
			"tile_set_region S",
			"tile_set_scale",
			"tile_set_visible",
			"timeline_add",
			"timeline_delete",
			"timeline_exists",
			"timeline_get_name",
			"timeline_moment_add",
			"timeline_moment_clear",
			"transition_define",
			"transition_exists",
			"variable_global_array2_get",
			"variable_global_array2_set",
			"variable_global_array_get",
			"variable_global_array_set",
			"variable_global_exists",
			"variable_global_get",
			"variable_global_set",
			"variable_local_array2_get",
			"variable_local_array_get",
			"variable_local_array_set",
			"variable_local_exists",
			"variable_local_get",
			"variable_local_set",
			"vertex_create_buffer",
			"vertex_create_buffer_ext",
			"vertex_delete_buffer",
			"vertex_begin",
			"vertex_colour",
			"vertex_normal",
			"vertex_position",
			"vertex_position_3d",
			"vertex_argb",
			"vertex_texcoord",
			"vertex_float1",
			"vertex_float2",
			"vertex_float3",
			"vertex_float4",
			"vertex_ubyte4",
			"vertex_end",
			"vertex_freeze",
			"vertex_submit",
			"vertex_delete",
			"vertex_format_begin",
			"vertex_format_add_colour",
			"vertex_format_add_position",
			"vertex_format_add_position_3d",
			"vertex_format_add_textcoord",
			"vertex_format_add_normal",
			"vertex_format_add_custom",
			"vertex_format_end",
			"win8_device_touchscreen_available",
			"win8_livetile_notification_begin",
			"win8_livetile_notification_secondary_begin",
			"win8_livetile_notification_expiry",
			"win8_livetile_notification_tag",
			"win8_livetile_notification_text_add",
			"win8_livetile_notification_image_add",
			"win8_livetile_notification_end",
			"win8_livetile_tile_notification",
			"win8_livetile_tile_clear",
			"win8_livetile_badge_notification",
			"win8_livetile_badge_clear",
			"win8_livetile_queue_enable",
			"win8_secondarytile_pin",
			"win8_secondarytile_badge_notification",
			"win8_secondarytile_delete",
			"win8_appbar_enable",
			"win8_appbar_add_element",
			"win8_appbar_remove_element",
			"win8_settingscharm_add_entry",
			"win8_settingscharm_add_html_entry",
			"win8_settingscharm_remove_entry",
			"win8_share_image",
			"win8_share_screenshot",
			"win8_share_file",
			"win8_share_url",
			"win8_share_text",
			"win8_search_enable",
			"win8_search_add_suggestions",
			"win8_search_disable",
			"win8_license_trial_version",
			"win8_license_initialize_sandbox",
			"window_center",
			"window_default",
			"window_get_caption",
			"window_get_color",
			"window_get_cursor",
			"window_get_fullscreen",
			"window_get_height",
			"window_get_region_height",
			"window_get_region_scale",
			"window_get_region_width",
			"window_get_showborder",
			"window_get_showicons",
			"window_get_sizeable",
			"window_get_stayontop",
			"window_get_visible",
			"window_get_width",
			"window_get_x",
			"window_get_y",
			"window_handle",
			"window_mouse_get_x",
			"window_mouse_get_y",
			"window_mouse_set",
			"window_set_caption",
			"window_set_color",
			"window_set_cursor",
			"window_set_fullscreen",
			"window_set_position",
			"window_set_rectangle",
			"window_set_region_scale",
			"window_set_region_size",
			"window_set_showborder",
			"window_set_showicons",
			"window_set_sizeable",
			"window_set_size",
			"window_set_stayontop",
			"window_set_visible",
			"window_views_mouse_get_x",
			"window_views_mouse_get_y",
			"window_views_mouse_set",
			"window_view_mouse_get_x",
			"window_view_mouse_get_y",
			"window_view_mouse_set",
			"winphone_license_trial_version",
			"winphone_tile_back_content",
			"winphone_tile_back_content_wide",
			"winphone_tile_back_image",
			"winphone_tile_back_image_wide",
			"winphone_tile_back_title",
			"winphone_tile_background_color",
			"winphone_tile_count",
			"winphone_tile_cycle_images",
			"winphone_tile_front_image",
			"winphone_tile_front_image_small",
			"winphone_tile_front_image_width",
			"winphone_tile_icon_image",
			"winphone_tile_small_background_image",
			"winphone_tile_small_icon_image",
			"winphone_tile_title",
			"winphone_tile_wide_content",

        };

        public static readonly Dictionary<string, string[][]> Parameters = new Dictionary<string, string[][]>
        {
			{
				"abs",
				new string[][]
				{
					new string[] {
						"x",
					},
				}
			},
			{
				"achievement_available",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"achievement_filter_all_players",
				new string[][]
				{
					new string[] {
						"ident",
						"minindex",
						"maxindex",
						"filter",
					},
				}
			},
			{
				"achievement_filter_friends_only",
				new string[][]
				{
					new string[] {
						"ident",
						"minindex",
						"maxindex",
						"filter",
					},
				}
			},
			{
				"achievement_get_challenges",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"achievement_get_pic",
				new string[][]
				{
					new string[] {
						"char",
					},
				}
			},
			{
				"achievement_leaderboards_info",
				new string[][]
				{
					new string[] {
						"ident",
						"minindex",
						"maxindex",
						"filter",
					},
				}
			},
			{
				"achievement_load_friends",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"achievement_load_leaderboard",
				new string[][]
				{
					new string[] {
						"ident",
						"minindex",
						"maxindex",
						"filter",
					},
				}
			},
			{
				"achievement_load_progress",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"achievement_login",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"achievement_login_status",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"achievement_logout",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"achievement_pic_loaded",
				new string[][]
				{
					new string[] {
						"char",
					},
				}
			},
			{
				"achievement_post",
				new string[][]
				{
					new string[] {
						"achievement",
						"percent",
					},
				}
			},
			{
				"achievement_post_score",
				new string[][]
				{
					new string[] {
						"name",
						"score",
					},
				}
			},
			{
				"achievement_reset",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"achievement_send_challenge",
				new string[][]
				{
					new string[] {
						"player",
						"challenge",
						"score",
						"type",
						"message",
					},
				}
			},
			{
				"achievement_show_achievements",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"achievement_show_challenge_notifications",
				new string[][]
				{
					new string[] {
						"receive",
						"local",
						"remote",
					},
				}
			},
			{
				"achievement_show_leaderboards",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"ads_disable",
				new string[][]
				{
					new string[] {
						"num",
					},
				}
			},
			{
				"ads_enable",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"num",
					},
				}
			},
			{
				"ads_engagement_active",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"ads_engagement_available",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"ads_engagement_launch",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"ads_event",
				new string[][]
				{
					new string[] {
						"placement",
					},
				}
			},
			{
				"ads_event_preload",
				new string[][]
				{
					new string[] {
						"placement",
					},
				}
			},
			{
				"ads_get_display_width",
				new string[][]
				{
					new string[] {
						"num",
					},
				}
			},
			{
				"ads_get_display_height",
				new string[][]
				{
					new string[] {
						"num",
					},
				}
			},
			{
				"ads_interstitial_available",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"ads_interstitial_display",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"ads_move",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"num",
					},
				}
			},
			{
				"ads_setup",
				new string[][]
				{
					new string[] {
						"user_uuid",
						"ad_app_key",
					},
				}
			},
			{
				"ads_set_reward_callback",
				new string[][]
				{
					new string[] {
						"placement",
					},
				}
			},
			{
				"angle_difference",
				new string[][]
				{
					new string[] {
						"ang1",
						"ang2",
					},
				}
			},
			{
				"ansi_char",
				new string[][]
				{
					new string[] {
						"byte",
					},
				}
			},
			{
				"array_height_2d",
				new string[][]
				{
					new string[] {
						"array",
						"n",
					},
				}
			},
			{
				"array_length_1d",
				new string[][]
				{
					new string[] {
						"array",
					},
				}
			},
			{
				"array_length_2d",
				new string[][]
				{
					new string[] {
						"array",
						"n",
					},
				}
			},
			{
				"arccos",
				new string[][]
				{
					new string[] {
						"x",
					},
				}
			},
			{
				"arcsin",
				new string[][]
				{
					new string[] {
						"x",
					},
				}
			},
			{
				"arctan2",
				new string[][]
				{
					new string[] {
						"y",
						"x",
					},
				}
			},
			{
				"arctan",
				new string[][]
				{
					new string[] {
						"x",
					},
				}
			},
			{
				"audio_system",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"audio_exists",
				new string[][]
				{
					new string[] {
						"index",
					},
				}
			},
			{
				"audio_get_type",
				new string[][]
				{
					new string[] {
						"index",
					},
				}
			},
			{
				"audio_play_music",
				new string[][]
				{
					new string[] {
						"index",
						"loop",
					},
				}
			},
			{
				"audio_pause_music",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"audio_stop_music",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"audio_play_sound",
				new string[][]
				{
					new string[] {
						"index",
						"priority",
						"loop",
					},
				}
			},
			{
				"audio_play_sound_at",
				new string[][]
				{
					new string[] {
						"index",
						"x",
						"y",
						"z",
						"falloff_ref",
						"falloff_max",
						"falloff_factor",
						"loop",
						"priority",
					},
				}
			},
			{
				"audio_pause_sound",
				new string[][]
				{
					new string[] {
						"index",
					},
				}
			},
			{
				"audio_pause_all",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"audio_resume_sound",
				new string[][]
				{
					new string[] {
						"index",
					},
				}
			},
			{
				"audio_resume_music",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"audio_resume_all",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"audio_stop_sound",
				new string[][]
				{
					new string[] {
						"index",
					},
				}
			},
			{
				"audio_stop_all",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"audio_is_playing",
				new string[][]
				{
					new string[] {
						"index",
					},
				}
			},
			{
				"audio_music_is_playing",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"audio_sound_length",
				new string[][]
				{
					new string[] {
						"index",
					},
				}
			},
			{
				"audio_sound_pitch",
				new string[][]
				{
					new string[] {
						"index",
						"pitch",
					},
				}
			},
			{
				"audio_falloff_set_model",
				new string[][]
				{
					new string[] {
						"model",
					},
				}
			},
			{
				"audio_music_gain",
				new string[][]
				{
					new string[] {
						"volume",
						"time",
					},
				}
			},
			{
				"audio_sound_gain",
				new string[][]
				{
					new string[] {
						"index",
						"volume",
						"time",
					},
				}
			},
			{
				"audio_master_gain",
				new string[][]
				{
					new string[] {
						"gain",
					},
				}
			},
			{
				"audio_channel_num",
				new string[][]
				{
					new string[] {
						"num",
					},
				}
			},
			{
				"audio_emitter_create",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"audio_emitter_exists",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"audio_emitter_position",
				new string[][]
				{
					new string[] {
						"ind",
						"x",
						"y",
						"z",
					},
				}
			},
			{
				"audio_emitter_velocity",
				new string[][]
				{
					new string[] {
						"ind",
						"vx",
						"vy",
						"vz",
					},
				}
			},
			{
				"audio_emitter_falloff",
				new string[][]
				{
					new string[] {
						"ind",
						"ref",
						"max",
						"factor",
					},
				}
			},
			{
				"audio_emitter_gain",
				new string[][]
				{
					new string[] {
						"ind",
						"gain",
					},
				}
			},
			{
				"audio_emitter_pitch",
				new string[][]
				{
					new string[] {
						"ind",
						"pitch",
					},
				}
			},
			{
				"audio_emitter_free",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"audio_play_sound_on",
				new string[][]
				{
					new string[] {
						"ind",
						"sound",
						"loop",
						"priority",
					},
				}
			},
			{
				"audio_listener_position",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"z",
					},
				}
			},
			{
				"audio_listener_velocity",
				new string[][]
				{
					new string[] {
						"vx",
						"vy",
						"vz",
					},
				}
			},
			{
				"audio_listener_orientation",
				new string[][]
				{
					new string[] {
						"lookat_x",
						"lookat_y",
						"lookat_z",
						"up_x",
						"up_y",
						"up_z",
					},
				}
			},
			{
				"background_add_alpha",
				new string[][]
				{
					new string[] {
						"fname",
						"preload",
					},
				}
			},
			{
				"background_add",
				new string[][]
				{
					new string[] {
						"fname",
						"transparent",
						"smooth",
					},
					new string[] {
						"fname",
						"transparent",
						"smooth",
						"preload",
					},
				}
			},
			{
				"background_assign",
				new string[][]
				{
					new string[] {
						"ind",
						"back",
					},
				}
			},
			{
				"background_create_color",
				new string[][]
				{
					new string[] {
						"w",
						"h",
						"col",
					},
					new string[] {
						"w",
						"h",
						"col",
						"preload",
					},
				}
			},
			{
				"background_create_from_screen",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"w",
						"h",
						"transparent",
						"smooth",
					},
					new string[] {
						"x",
						"y",
						"w",
						"h",
						"transparent",
						"smooth",
						"preload",
					},
				}
			},
			{
				"background_create_from_surface",
				new string[][]
				{
					new string[] {
						"id",
						"x",
						"y",
						"w",
						"h",
						"transparent",
						"smooth",
					},
					new string[] {
						"id",
						"x",
						"y",
						"w",
						"h",
						"transparent",
						"smooth",
						"preload",
					},
				}
			},
			{
				"background_create_gradient",
				new string[][]
				{
					new string[] {
						"w",
						"h",
						"col1",
						"col2",
						"kind",
					},
					new string[] {
						"w",
						"h",
						"col1",
						"col2",
						"kind",
						"preload",
					},
				}
			},
			{
				"background_delete",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"background_duplicate",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"background_exists",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"background_get_height",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"background_get_name",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"background_get_preload",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"background_get_smooth",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"background_get_texture",
				new string[][]
				{
					new string[] {
						"back",
					},
				}
			},
			{
				"background_get_uvs",
				new string[][]
				{
					new string[] {
						"back",
					},
				}
			},
			{
				"background_get_transparent",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"background_get_width",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"background_replace_alpha",
				new string[][]
				{
					new string[] {
						"ind",
						"fname",
						"preload",
					},
				}
			},
			{
				"background_replace",
				new string[][]
				{
					new string[] {
						"ind",
						"fname",
						"transparent",
						"smooth",
					},
					new string[] {
						"ind",
						"fname",
						"transparent",
						"smooth",
						"preload",
					},
				}
			},
			{
				"background_save",
				new string[][]
				{
					new string[] {
						"ind",
						"fname",
					},
				}
			},
			{
				"background_set_alpha_from_background",
				new string[][]
				{
					new string[] {
						"ind",
						"back",
					},
				}
			},
			{
				"base64_decode",
				new string[][]
				{
					new string[] {
						"string",
					},
				}
			},
			{
				"base64_encode",
				new string[][]
				{
					new string[] {
						"string",
					},
				}
			},
			{
				"buffer_create",
				new string[][]
				{
					new string[] {
						"size",
						"type",
						"alignment",
					},
				}
			},
			{
				"buffer_delete",
				new string[][]
				{
					new string[] {
						"buffer",
					},
				}
			},
			{
				"buffer_read",
				new string[][]
				{
					new string[] {
						"buffer",
						"type",
					},
				}
			},
			{
				"buffer_write",
				new string[][]
				{
					new string[] {
						"buffer",
						"type",
						"value",
					},
				}
			},
			{
				"buffer_fill",
				new string[][]
				{
					new string[] {
						"buffer",
						"offset",
						"type",
						"value",
						"size",
					},
				}
			},
			{
				"buffer_seek",
				new string[][]
				{
					new string[] {
						"buffer",
						"base",
						"offset",
					},
				}
			},
			{
				"buffer_tell",
				new string[][]
				{
					new string[] {
						"buffer",
					},
				}
			},
			{
				"buffer_peek",
				new string[][]
				{
					new string[] {
						"buffer",
						"offset",
						"type",
					},
				}
			},
			{
				"buffer_poke",
				new string[][]
				{
					new string[] {
						"buffer",
						"offset",
						"type",
						"value",
					},
				}
			},
			{
				"buffer_save",
				new string[][]
				{
					new string[] {
						"buffer",
						"filename",
					},
				}
			},
			{
				"buffer_save_ext",
				new string[][]
				{
					new string[] {
						"buffer",
						"filename",
						"offset",
						"size",
					},
				}
			},
			{
				"buffer_load",
				new string[][]
				{
					new string[] {
						"filename",
					},
				}
			},
			{
				"buffer_load_ext",
				new string[][]
				{
					new string[] {
						"buffer",
						"filename",
						"offset",
					},
				}
			},
			{
				"buffer_copy",
				new string[][]
				{
					new string[] {
						"src_buffer",
						"src_offset",
						"size",
						"dest_buffer",
						"dest_offset",
					},
				}
			},
			{
				"buffer_get_size",
				new string[][]
				{
					new string[] {
						"index",
					},
				}
			},
			{
				"buffer_resize",
				new string[][]
				{
					new string[] {
						"buffer",
						"newsize",
					},
				}
			},
			{
				"buffer_sizeof",
				new string[][]
				{
					new string[] {
						"type",
					},
				}
			},
			{
				"buffer_md5",
				new string[][]
				{
					new string[] {
						"buffer",
						"offset",
						"size",
					},
				}
			},
			{
				"buffer_sha1",
				new string[][]
				{
					new string[] {
						"buffer",
						"offset",
						"size",
					},
				}
			},
			{
				"buffer_base64_encode",
				new string[][]
				{
					new string[] {
						"buffer",
						"offset",
						"size",
					},
				}
			},
			{
				"buffer_base64_decode",
				new string[][]
				{
					new string[] {
						"string",
					},
				}
			},
			{
				"buffer_base64_decode_ext",
				new string[][]
				{
					new string[] {
						"buffer",
						"string",
						"offset",
					},
				}
			},
			{
				"cd_close_door",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"cd_init",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"cd_length",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"cd_number",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"cd_open_door",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"cd_paused",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"cd_pause",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"cd_playing",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"cd_play",
				new string[][]
				{
					new string[] {
						"first",
						"last",
					},
				}
			},
			{
				"cd_position",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"cd_present",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"cd_resume",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"cd_set_position",
				new string[][]
				{
					new string[] {
						"pos",
					},
				}
			},
			{
				"cd_set_track_position",
				new string[][]
				{
					new string[] {
						"pos",
					},
				}
			},
			{
				"cd_stop",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"cd_track_length",
				new string[][]
				{
					new string[] {
						"n",
					},
				}
			},
			{
				"cd_track_position",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"cd_track",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"clamp",
				new string[][]
				{
					new string[] {
						"val",
						"min",
						"max",
					},
				}
			},
			{
				"cloud_synchronise",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"cloud_string_save",
				new string[][]
				{
					new string[] {
						"string",
						" description",
					},
				}
			},
			{
				"cloud_file_save",
				new string[][]
				{
					new string[] {
						"file",
						"description",
					},
				}
			},
			{
				"ceil",
				new string[][]
				{
					new string[] {
						"x",
					},
				}
			},
			{
				"choose",
				new string[][]
				{
					new string[] {
						"val1",
						"val2",
						"val3",
						"...",
					},
				}
			},
			{
				"chr",
				new string[][]
				{
					new string[] {
						"val",
					},
				}
			},
			{
				"clipboard_get_text",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"clipboard_has_text",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"clipboard_set_text",
				new string[][]
				{
					new string[] {
						"str",
					},
				}
			},
			{
				"collision_circle",
				new string[][]
				{
					new string[] {
						"xc",
						"yc",
						"radius",
						"obj",
						"prec",
						"notme",
					},
				}
			},
			{
				"collision_ellipse",
				new string[][]
				{
					new string[] {
						"x1",
						"y1",
						"x2",
						"y2",
						"obj",
						"prec",
						"notme",
					},
				}
			},
			{
				"collision_line",
				new string[][]
				{
					new string[] {
						"x1",
						"y1",
						"x2",
						"y2",
						"obj",
						"prec",
						"notme",
					},
				}
			},
			{
				"collision_point",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"obj",
						"prec",
						"notme",
					},
				}
			},
			{
				"collision_rectangle",
				new string[][]
				{
					new string[] {
						"x1",
						"y1",
						"x2",
						"y2",
						"obj",
						"prec",
						"notme",
					},
				}
			},
			{
				"color_get_blue",
				new string[][]
				{
					new string[] {
						"col",
					},
				}
			},
			{
				"color_get_green",
				new string[][]
				{
					new string[] {
						"col",
					},
				}
			},
			{
				"color_get_hue",
				new string[][]
				{
					new string[] {
						"col",
					},
				}
			},
			{
				"color_get_red",
				new string[][]
				{
					new string[] {
						"col",
					},
				}
			},
			{
				"color_get_saturation",
				new string[][]
				{
					new string[] {
						"col",
					},
				}
			},
			{
				"color_get_value",
				new string[][]
				{
					new string[] {
						"col",
					},
				}
			},
			{
				"cos",
				new string[][]
				{
					new string[] {
						"x",
					},
				}
			},
			{
				"d3d_draw_block",
				new string[][]
				{
					new string[] {
						"x1",
						"y1",
						"z1",
						"x2",
						"y2",
						"z2",
						"texid",
						"hrepeat",
						"vrepeat",
					},
				}
			},
			{
				"d3d_draw_cone",
				new string[][]
				{
					new string[] {
						"x1",
						"y1",
						"z1",
						"x2",
						"y2",
						"z2",
						"texid",
						"hrepeat",
						"vrepeat",
						"closed",
						"steps",
					},
				}
			},
			{
				"d3d_draw_cylinder",
				new string[][]
				{
					new string[] {
						"x1",
						"y1",
						"z1",
						"x2",
						"y2",
						"z2",
						"texid",
						"hrepeat",
						"vrepeat",
						"closed",
						"steps",
					},
				}
			},
			{
				"d3d_draw_ellipsoid",
				new string[][]
				{
					new string[] {
						"x1",
						"y1",
						"z1",
						"x2",
						"y2",
						"z2",
						"texid",
						"hrepeat",
						"vrepeat",
						"steps",
					},
				}
			},
			{
				"d3d_draw_floor",
				new string[][]
				{
					new string[] {
						"x1",
						"y1",
						"z1",
						"x2",
						"y2",
						"z2",
						"texid",
						"hrepeat",
						"vrepeat",
					},
				}
			},
			{
				"d3d_draw_wall",
				new string[][]
				{
					new string[] {
						"x1",
						"y1",
						"z1",
						"x2",
						"y2",
						"z2",
						"texid",
						"hrepeat",
						"vrepeat",
					},
				}
			},
			{
				"d3d_end",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"d3d_light_define_ambient",
				new string[][]
				{
					new string[] {
						"col",
					},
				}
			},
			{
				"d3d_light_define_direction",
				new string[][]
				{
					new string[] {
						"ind",
						"dx",
						"dy",
						"dz",
						"col",
					},
				}
			},
			{
				"d3d_light_define_point",
				new string[][]
				{
					new string[] {
						"ind",
						"x",
						"y",
						"z",
						"range",
						"col",
					},
				}
			},
			{
				"d3d_light_enable",
				new string[][]
				{
					new string[] {
						"ind",
						"enable",
					},
				}
			},
			{
				"d3d_model_block",
				new string[][]
				{
					new string[] {
						"ind",
						"x1",
						"y1",
						"z1",
						"x2",
						"y2",
						"z2",
						"hrepeat",
						"vrepeat",
					},
				}
			},
			{
				"d3d_model_clear",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"d3d_model_cone",
				new string[][]
				{
					new string[] {
						"ind",
						"x1",
						"y1",
						"z1",
						"x2",
						"y2",
						"z2",
						"hrepeat",
						"vrepeat",
						"closed",
						"steps",
					},
				}
			},
			{
				"d3d_model_create",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"d3d_model_cylinder",
				new string[][]
				{
					new string[] {
						"ind",
						"x1",
						"y1",
						"z1",
						"x2",
						"y2",
						"z2",
						"hrepeat",
						"vrepeat",
						"closed",
						"steps",
					},
				}
			},
			{
				"d3d_model_destroy",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"d3d_model_draw",
				new string[][]
				{
					new string[] {
						"ind",
						"x",
						"y",
						"z",
						"texid",
					},
				}
			},
			{
				"d3d_model_ellipsoid",
				new string[][]
				{
					new string[] {
						"ind",
						"x1",
						"y1",
						"z1",
						"x2",
						"y2",
						"z2",
						"hrepeat",
						"vrepeat",
						"steps",
					},
				}
			},
			{
				"d3d_model_floor",
				new string[][]
				{
					new string[] {
						"ind",
						"x1",
						"y1",
						"z1",
						"x2",
						"y2",
						"z2",
						"hrepeat",
						"vrepeat",
					},
				}
			},
			{
				"d3d_model_load",
				new string[][]
				{
					new string[] {
						"ind",
						"fname",
					},
				}
			},
			{
				"d3d_model_primitive_begin",
				new string[][]
				{
					new string[] {
						"ind",
						"kind",
					},
				}
			},
			{
				"d3d_model_primitive_end",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"d3d_model_save",
				new string[][]
				{
					new string[] {
						"ind",
						"fname",
					},
				}
			},
			{
				"d3d_model_vertex_color",
				new string[][]
				{
					new string[] {
						"ind",
						"x",
						"y",
						"z",
						"col",
						"alpha",
					},
				}
			},
			{
				"d3d_model_vertex_normal_color",
				new string[][]
				{
					new string[] {
						"ind",
						"x",
						"y",
						"z",
						"nx",
						"ny",
						"nz",
						"col",
						"alpha",
					},
				}
			},
			{
				"d3d_model_vertex_normal_texture_color",
				new string[][]
				{
					new string[] {
						"ind",
						"x",
						"y",
						"z",
						"nx",
						"ny",
						"nz",
						"xtex",
						"ytex",
						"col",
						"alpha",
					},
				}
			},
			{
				"d3d_model_vertex_normal_texture",
				new string[][]
				{
					new string[] {
						"ind",
						"x",
						"y",
						"z",
						"nx",
						"ny",
						"nz",
						"xtex",
						"ytex",
					},
				}
			},
			{
				"d3d_model_vertex_normal",
				new string[][]
				{
					new string[] {
						"ind",
						"x",
						"y",
						"z",
						"nx",
						"ny",
						"nz",
					},
				}
			},
			{
				"d3d_model_vertex_texture_color",
				new string[][]
				{
					new string[] {
						"ind",
						"x",
						"y",
						"z",
						"xtex",
						"ytex",
						"col",
						"alpha",
					},
				}
			},
			{
				"d3d_model_vertex_texture",
				new string[][]
				{
					new string[] {
						"ind",
						"x",
						"y",
						"z",
						"xtex",
						"ytex",
					},
				}
			},
			{
				"d3d_model_vertex",
				new string[][]
				{
					new string[] {
						"ind",
						"x",
						"y",
						"z",
					},
				}
			},
			{
				"d3d_model_wall",
				new string[][]
				{
					new string[] {
						"ind",
						"x1",
						"y1",
						"z1",
						"x2",
						"y2",
						"z2",
						"hrepeat",
						"vrepeat",
					},
				}
			},
			{
				"d3d_primitive_begin_texture",
				new string[][]
				{
					new string[] {
						"kind",
						"texid",
					},
				}
			},
			{
				"d3d_primitive_begin",
				new string[][]
				{
					new string[] {
						"kind",
					},
				}
			},
			{
				"d3d_primitive_end",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"d3d_set_culling",
				new string[][]
				{
					new string[] {
						"cull",
					},
				}
			},
			{
				"d3d_set_depth",
				new string[][]
				{
					new string[] {
						"depth",
					},
				}
			},
			{
				"d3d_set_zwriteenable",
				new string[][]
				{
					new string[] {
						"enable",
					},
				}
			},
			{
				"d3d_set_fog",
				new string[][]
				{
					new string[] {
						"enable",
						"color",
						"start",
						"end",
					},
				}
			},
			{
				"d3d_set_hidden",
				new string[][]
				{
					new string[] {
						"enable",
					},
				}
			},
			{
				"d3d_set_lighting",
				new string[][]
				{
					new string[] {
						"enable",
					},
				}
			},
			{
				"d3d_set_perspective",
				new string[][]
				{
					new string[] {
						"enable",
					},
				}
			},
			{
				"d3d_set_projection_ext",
				new string[][]
				{
					new string[] {
						"xfrom",
						"yfrom",
						"zfrom",
						"xto",
						"yto",
						"zto",
						"xup",
						"yup",
						"zup",
						"angle",
						"aspect",
						"znear",
						"zfar",
					},
				}
			},
			{
				"d3d_set_projection_ortho",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"w",
						"h",
						"angle",
					},
				}
			},
			{
				"d3d_set_projection_perspective",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"w",
						"h",
						"angle",
					},
				}
			},
			{
				"d3d_set_projection",
				new string[][]
				{
					new string[] {
						"xfrom",
						"yfrom",
						"zfrom",
						"xto",
						"yto",
						"zto",
						"xup",
						"yup",
						"zup",
					},
				}
			},
			{
				"d3d_set_shading",
				new string[][]
				{
					new string[] {
						"smooth",
					},
				}
			},
			{
				"d3d_start",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"d3d_transform_add_rotation_axis",
				new string[][]
				{
					new string[] {
						"xa",
						"ya",
						"za",
						"angle",
					},
				}
			},
			{
				"d3d_transform_add_rotation_x",
				new string[][]
				{
					new string[] {
						"angle",
					},
				}
			},
			{
				"d3d_transform_add_rotation_y",
				new string[][]
				{
					new string[] {
						"angle",
					},
				}
			},
			{
				"d3d_transform_add_rotation_z",
				new string[][]
				{
					new string[] {
						"angle",
					},
				}
			},
			{
				"d3d_transform_add_scaling",
				new string[][]
				{
					new string[] {
						"xs",
						"ys",
						"zs",
					},
				}
			},
			{
				"d3d_transform_add_translation",
				new string[][]
				{
					new string[] {
						"xt",
						"yt",
						"zt",
					},
				}
			},
			{
				"d3d_transform_set_identity",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"d3d_transform_set_rotation_axis",
				new string[][]
				{
					new string[] {
						"xa",
						"ya",
						"za",
						"angle",
					},
				}
			},
			{
				"d3d_transform_set_rotation_x",
				new string[][]
				{
					new string[] {
						"angle",
					},
				}
			},
			{
				"d3d_transform_set_rotation_y",
				new string[][]
				{
					new string[] {
						"angle",
					},
				}
			},
			{
				"d3d_transform_set_rotation_z",
				new string[][]
				{
					new string[] {
						"angle",
					},
				}
			},
			{
				"d3d_transform_set_scaling",
				new string[][]
				{
					new string[] {
						"xs",
						"ys",
						"zs",
					},
				}
			},
			{
				"d3d_transform_set_translation",
				new string[][]
				{
					new string[] {
						"xt",
						"yt",
						"zt",
					},
				}
			},
			{
				"d3d_transform_stack_clear",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"d3d_transform_stack_discard",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"d3d_transform_stack_empty",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"d3d_transform_stack_pop",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"d3d_transform_stack_push",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"d3d_transform_stack_top",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"d3d_vertex_color",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"z",
						"col",
						"alpha",
					},
				}
			},
			{
				"d3d_vertex_normal(x,y,z,nx,ny,nz) Add vertex",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"z",
					},
				}
			},
			{
				"d3d_vertex_normal_color",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"z",
						"nx",
						"ny",
						"nz",
						"col",
						"alpha",
					},
				}
			},
			{
				"d3d_vertex_normal_texture_color",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"z",
						"nx",
						"ny",
						"nz",
						"xtex",
						"ytex",
						"col",
						"alpha",
					},
				}
			},
			{
				"d3d_vertex_normal_texture",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"z",
						"nx",
						"ny",
						"nz",
						"xtex",
						"ytex",
					},
				}
			},
			{
				"d3d_vertex_texture_color",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"z",
						"xtex",
						"ytex",
						"col",
						"alpha",
					},
				}
			},
			{
				"d3d_vertex_texture",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"z",
						"xtex",
						"ytex",
					},
				}
			},
			{
				"d3d_vertex",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"z",
					},
				}
			},
			{
				"date_compare_datetime",
				new string[][]
				{
					new string[] {
						"date1",
						"date2",
					},
				}
			},
			{
				"date_compare_date",
				new string[][]
				{
					new string[] {
						"date1",
						"date2",
					},
				}
			},
			{
				"date_compare_time",
				new string[][]
				{
					new string[] {
						"date1",
						"date2",
					},
				}
			},
			{
				"date_create_datetime",
				new string[][]
				{
					new string[] {
						"year",
						"month",
						"day",
						"hour",
						"minute",
						"second",
					},
				}
			},
			{
				"date_create_date",
				new string[][]
				{
					new string[] {
						"year",
						"month",
						"day",
					},
				}
			},
			{
				"date_create_time",
				new string[][]
				{
					new string[] {
						"hour",
						"minute",
						"second",
					},
				}
			},
			{
				"date_current_datetime",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"date_current_date",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"date_current_time",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"date_datetime_string",
				new string[][]
				{
					new string[] {
						"date",
					},
				}
			},
			{
				"date_date_of",
				new string[][]
				{
					new string[] {
						"date",
					},
				}
			},
			{
				"date_date_string",
				new string[][]
				{
					new string[] {
						"date",
					},
				}
			},
			{
				"date_days_in_month",
				new string[][]
				{
					new string[] {
						"date",
					},
				}
			},
			{
				"date_days_in_year",
				new string[][]
				{
					new string[] {
						"date",
					},
				}
			},
			{
				"date_day_span",
				new string[][]
				{
					new string[] {
						"date1",
						"date2",
					},
				}
			},
			{
				"date_get_day_of_year",
				new string[][]
				{
					new string[] {
						"date",
					},
				}
			},
			{
				"date_get_day",
				new string[][]
				{
					new string[] {
						"date",
					},
				}
			},
			{
				"date_get_hour_of_year",
				new string[][]
				{
					new string[] {
						"date",
					},
				}
			},
			{
				"date_get_hour",
				new string[][]
				{
					new string[] {
						"date",
					},
				}
			},
			{
				"date_get_minute_of_year",
				new string[][]
				{
					new string[] {
						"date",
					},
				}
			},
			{
				"date_get_minute",
				new string[][]
				{
					new string[] {
						"date",
					},
				}
			},
			{
				"date_get_month",
				new string[][]
				{
					new string[] {
						"date",
					},
				}
			},
			{
				"date_get_second_of_year",
				new string[][]
				{
					new string[] {
						"date",
					},
				}
			},
			{
				"date_get_second",
				new string[][]
				{
					new string[] {
						"date",
					},
				}
			},
			{
				"date_get_weekday",
				new string[][]
				{
					new string[] {
						"date",
					},
				}
			},
			{
				"date_get_week",
				new string[][]
				{
					new string[] {
						"date",
					},
				}
			},
			{
				"date_get_year",
				new string[][]
				{
					new string[] {
						"date",
					},
				}
			},
			{
				"date_hour_span",
				new string[][]
				{
					new string[] {
						"date1",
						"date2",
					},
				}
			},
			{
				"date_inc_day",
				new string[][]
				{
					new string[] {
						"date",
						"amount",
					},
				}
			},
			{
				"date_inc_hour",
				new string[][]
				{
					new string[] {
						"date",
						"amount",
					},
				}
			},
			{
				"date_inc_minute",
				new string[][]
				{
					new string[] {
						"date",
						"amount",
					},
				}
			},
			{
				"date_inc_month",
				new string[][]
				{
					new string[] {
						"date",
						"amount",
					},
				}
			},
			{
				"date_inc_second",
				new string[][]
				{
					new string[] {
						"date",
						"amount",
					},
				}
			},
			{
				"date_inc_week",
				new string[][]
				{
					new string[] {
						"date",
						"amount",
					},
				}
			},
			{
				"date_inc_year",
				new string[][]
				{
					new string[] {
						"date",
						"amount",
					},
				}
			},
			{
				"date_is_today",
				new string[][]
				{
					new string[] {
						"date",
					},
				}
			},
			{
				"date_leap_year",
				new string[][]
				{
					new string[] {
						"date",
					},
				}
			},
			{
				"date_minute_span",
				new string[][]
				{
					new string[] {
						"date1",
						"date2",
					},
				}
			},
			{
				"date_month_span",
				new string[][]
				{
					new string[] {
						"date1",
						"date2",
					},
				}
			},
			{
				"date_second_span",
				new string[][]
				{
					new string[] {
						"date1",
						"date2",
					},
				}
			},
			{
				"date_time_of",
				new string[][]
				{
					new string[] {
						"date",
					},
				}
			},
			{
				"date_time_string",
				new string[][]
				{
					new string[] {
						"date",
					},
				}
			},
			{
				"date_valid_datetime",
				new string[][]
				{
					new string[] {
						"year",
						"month",
						"day",
						"hour",
						"minute",
						"second",
					},
				}
			},
			{
				"date_valid_date",
				new string[][]
				{
					new string[] {
						"year",
						"month",
						"day",
					},
				}
			},
			{
				"date_valid_time",
				new string[][]
				{
					new string[] {
						"hour",
						"minute",
						"second",
					},
				}
			},
			{
				"date_week_span",
				new string[][]
				{
					new string[] {
						"date1",
						"date2",
					},
				}
			},
			{
				"date_year_span",
				new string[][]
				{
					new string[] {
						"date1",
						"date2",
					},
				}
			},
			{
				"degtorad",
				new string[][]
				{
					new string[] {
						"x",
					},
				}
			},
			{
				"device_mouse_check_button",
				new string[][]
				{
					new string[] {
						"device",
						"button",
					},
				}
			},
			{
				"device_mouse_check_button_pressed",
				new string[][]
				{
					new string[] {
						"device",
						"button",
					},
				}
			},
			{
				"device_mouse_check_button_released",
				new string[][]
				{
					new string[] {
						"device",
						"button",
					},
				}
			},
			{
				"device_mouse_dbclick_enable",
				new string[][]
				{
					new string[] {
						"enable",
					},
				}
			},
			{
				"device_mouse_x",
				new string[][]
				{
					new string[] {
						"device",
					},
				}
			},
			{
				"device_mouse_y",
				new string[][]
				{
					new string[] {
						"device",
					},
				}
			},
			{
				"device_mouse_raw_x",
				new string[][]
				{
					new string[] {
						"device",
					},
				}
			},
			{
				"device_mouse_raw_y",
				new string[][]
				{
					new string[] {
						"device",
					},
				}
			},
			{
				"device_is_keypad_open",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"device_get_tilt_x",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"device_get_tilt_y",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"device_get_tilt_z",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"directory_create",
				new string[][]
				{
					new string[] {
						"dname",
					},
				}
			},
			{
				"directory_exists",
				new string[][]
				{
					new string[] {
						"dname",
					},
				}
			},
			{
				"discard_include_file",
				new string[][]
				{
					new string[] {
						"fname",
					},
				}
			},
			{
				"display_get_colordepth",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"display_get_frequency",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"display_get_height",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"display_get_orientation",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"display_get_width",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"display_get_dpi_x",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"display_get_dpi_y",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"display_get_gui_width",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"display_get_gui_height",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"display_mouse_get_x",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"display_mouse_get_y",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"display_mouse_set",
				new string[][]
				{
					new string[] {
						"x",
						"y",
					},
				}
			},
			{
				"display_reset",
				new string[][]
				{
					new string[] {
						"aa",
						"vsync",
					},
				}
			},
			{
				"display_set_all",
				new string[][]
				{
					new string[] {
						"w",
						"h",
						"frequency",
						"coldepth",
					},
				}
			},
			{
				"display_set_colordepth",
				new string[][]
				{
					new string[] {
						"coldepth",
					},
				}
			},
			{
				"display_set_frequency",
				new string[][]
				{
					new string[] {
						"frequency",
					},
				}
			},
			{
				"display_set_size",
				new string[][]
				{
					new string[] {
						"w",
						"h",
					},
				}
			},
			{
				"display_set_gui_size",
				new string[][]
				{
					new string[] {
						"w",
						"h",
					},
				}
			},
			{
				"display_test_all",
				new string[][]
				{
					new string[] {
						"w",
						"h",
						"frequency",
						"coldepth",
					},
				}
			},
			{
				"distance_to_object",
				new string[][]
				{
					new string[] {
						"obj",
					},
				}
			},
			{
				"distance_to_point",
				new string[][]
				{
					new string[] {
						"x",
						"y",
					},
				}
			},
			{
				"dot_product",
				new string[][]
				{
					new string[] {
						"x1",
						"y1",
						"x2",
						"y2",
					},
				}
			},
			{
				"dot_product_3d",
				new string[][]
				{
					new string[] {
						"x1",
						"y1",
						"z1",
						"x2",
						"y2",
						"z2",
					},
				}
			},
			{
				"dot_product_normalised",
				new string[][]
				{
					new string[] {
						"x1",
						"y1",
						"x2",
						"y2",
					},
				}
			},
			{
				"dot_product_normalised_3d",
				new string[][]
				{
					new string[] {
						"x1",
						"y1",
						"z1",
						"x2",
						"y2",
						"z2",
					},
				}
			},
			{
				"draw_arrow",
				new string[][]
				{
					new string[] {
						"x1",
						"y1",
						"x2",
						"y2",
						"size",
					},
				}
			},
			{
				"draw_background_ext",
				new string[][]
				{
					new string[] {
						"back",
						"x",
						"y",
						"xscale",
						"yscale",
						"rot",
						"color",
						"alpha",
					},
				}
			},
			{
				"draw_background_general",
				new string[][]
				{
					new string[] {
						"back",
						"left",
						"top",
						"width",
						"height",
						"x",
						"y",
						"xscale",
						"yscale",
						"rot",
						"c1",
						"c2",
						"c3",
						"c4",
						"alpha",
					},
				}
			},
			{
				"draw_background_part",
				new string[][]
				{
					new string[] {
						"back",
						"left",
						"top",
						"width",
						"height",
						"x",
						"y",
					},
				}
			},
			{
				"draw_background_part_ext",
				new string[][]
				{
					new string[] {
						"back",
						"left",
						"top",
						"width",
						"height",
						"x",
						"y",
						"xscale",
						"yscale",
						"color",
						"alpha",
					},
				}
			},
			{
				"draw_background_stretched_ext",
				new string[][]
				{
					new string[] {
						"back",
						"x",
						"y",
						"w",
						"h",
						"color",
						"alpha",
					},
				}
			},
			{
				"draw_background_stretched",
				new string[][]
				{
					new string[] {
						"back",
						"x",
						"y",
						"w",
						"h",
					},
				}
			},
			{
				"draw_background_tiled_ext",
				new string[][]
				{
					new string[] {
						"back",
						"x",
						"y",
						"xscale",
						"yscale",
						"color",
						"alpha",
					},
				}
			},
			{
				"draw_background_tiled",
				new string[][]
				{
					new string[] {
						"back",
						"x",
						"y",
					},
				}
			},
			{
				"draw_background",
				new string[][]
				{
					new string[] {
						"back",
						"x",
						"y",
					},
				}
			},
			{
				"draw_button",
				new string[][]
				{
					new string[] {
						"x1",
						"y1",
						"x2",
						"y2",
						"up",
					},
				}
			},
			{
				"draw_circle_color",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"r",
						"col1",
						"col2",
						"outline",
					},
				}
			},
			{
				"draw_circle",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"r",
						"outline",
					},
				}
			},
			{
				"draw_clear_alpha",
				new string[][]
				{
					new string[] {
						"col",
						"alpha",
					},
				}
			},
			{
				"draw_clear",
				new string[][]
				{
					new string[] {
						"col",
					},
				}
			},
			{
				"draw_ellipse_color",
				new string[][]
				{
					new string[] {
						"x1",
						"y1",
						"x2",
						"y2",
						"col1",
						"col2",
						"outline",
					},
				}
			},
			{
				"draw_ellipse",
				new string[][]
				{
					new string[] {
						"x1",
						"y1",
						"x2",
						"y2",
						"outline",
					},
				}
			},
			{
				"draw_enable_alphablend",
				new string[][]
				{
					new string[] {
						"enable",
					},
				}
			},
			{
				"draw_enable_drawevent",
				new string[][]
				{
					new string[] {
						"enable",
					},
				}
			},
			{
				"draw_getpixel",
				new string[][]
				{
					new string[] {
						"x",
						"y",
					},
				}
			},
			{
				"draw_getpixel_ext",
				new string[][]
				{
					new string[] {
						"x",
						"y",
					},
				}
			},
			{
				"draw_get_alpha",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"draw_get_color",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"draw_healthbar",
				new string[][]
				{
					new string[] {
						"x1",
						"y1",
						"x2",
						"y2",
						"amount",
						"backcol",
						"mincol",
						"maxcol",
						"direction",
						"showback",
						"showborder",
					},
				}
			},
			{
				"draw_highscore",
				new string[][]
				{
					new string[] {
						"x1",
						"y1",
						"x2",
						"y2",
					},
				}
			},
			{
				"draw_line_color",
				new string[][]
				{
					new string[] {
						"x1",
						"y1",
						"x2",
						"y2",
						"col1",
						"col2",
					},
				}
			},
			{
				"draw_line_width_color",
				new string[][]
				{
					new string[] {
						"x1",
						"y1",
						"x2",
						"y2",
						"w",
						"col1",
						"col2",
					},
				}
			},
			{
				"draw_line_width",
				new string[][]
				{
					new string[] {
						"x1",
						"y1",
						"x2",
						"y2",
						"w",
					},
				}
			},
			{
				"draw_line",
				new string[][]
				{
					new string[] {
						"x1",
						"y1",
						"x2",
						"y2",
					},
				}
			},
			{
				"draw_path",
				new string[][]
				{
					new string[] {
						"path",
						"x",
						"y",
						"absolute",
					},
				}
			},
			{
				"draw_point_color",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"col1",
					},
				}
			},
			{
				"draw_point",
				new string[][]
				{
					new string[] {
						"x",
						"y",
					},
				}
			},
			{
				"draw_primitive_begin_texture",
				new string[][]
				{
					new string[] {
						"kind",
						"texid",
					},
				}
			},
			{
				"draw_primitive_begin",
				new string[][]
				{
					new string[] {
						"kind",
					},
				}
			},
			{
				"draw_primitive_end",
				new string[][]
				{
					new string[] {
					},
					new string[] {
					},
				}
			},
			{
				"draw_rectangle_color",
				new string[][]
				{
					new string[] {
						"x1",
						"y1",
						"x2",
						"y2",
						"col1",
						"col2",
						"col3",
						"col4",
						"outline",
					},
				}
			},
			{
				"draw_rectangle",
				new string[][]
				{
					new string[] {
						"x1",
						"y1",
						"x2",
						"y2",
						"outline",
					},
				}
			},
			{
				"draw_roundrect_color",
				new string[][]
				{
					new string[] {
						"x1",
						"y1",
						"x2",
						"y2",
						"col1",
						"col2",
						"outline",
					},
				}
			},
			{
				"draw_roundrect",
				new string[][]
				{
					new string[] {
						"x1",
						"y1",
						"x2",
						"y2",
						"outline",
					},
				}
			},
			{
				"draw_self",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"draw_set_alpha",
				new string[][]
				{
					new string[] {
						"alpha",
					},
				}
			},
			{
				"draw_set_alpha_test",
				new string[][]
				{
					new string[] {
						"enable",
					},
				}
			},
			{
				"draw_set_alpha_test_ref_value",
				new string[][]
				{
					new string[] {
						"value",
					},
				}
			},
			{
				"draw_set_blend_mode_ext",
				new string[][]
				{
					new string[] {
						"src",
						"dest",
					},
				}
			},
			{
				"draw_set_blend_mode",
				new string[][]
				{
					new string[] {
						"mode",
					},
				}
			},
			{
				"draw_set_circle_precision",
				new string[][]
				{
					new string[] {
						"precision",
					},
				}
			},
			{
				"draw_set_color",
				new string[][]
				{
					new string[] {
						"col",
					},
				}
			},
			{
				"draw_set_color_rgb",
				new string[][]
				{
					new string[] {
						"red",
						"green",
						"blue",
					},
				}
			},
			{
				"draw_set_color_rgba",
				new string[][]
				{
					new string[] {
						"red",
						"green",
						"blue",
						"alpha",
					},
				}
			},
			{
				"draw_set_color_write_enable",
				new string[][]
				{
					new string[] {
						"red",
						"green",
						"blue",
						"alpha",
					},
				}
			},
			{
				"draw_set_font",
				new string[][]
				{
					new string[] {
						"font",
					},
				}
			},
			{
				"draw_set_halign",
				new string[][]
				{
					new string[] {
						"halign",
					},
				}
			},
			{
				"draw_set_valign",
				new string[][]
				{
					new string[] {
						"valign",
					},
				}
			},
			{
				"draw_sprite_ext",
				new string[][]
				{
					new string[] {
						"sprite",
						"subimg",
						"x",
						"y",
						"xscale",
						"yscale",
						"rot",
						"color",
						"alpha",
					},
				}
			},
			{
				"draw_sprite_general",
				new string[][]
				{
					new string[] {
						"sprite",
						"subimg",
						"left",
						"top",
						"width",
						"height",
						"x",
						"y",
						"xscale",
						"yscale",
						"rot",
						"c1",
						"c2",
						"c3",
						"c4",
						"alpha",
					},
				}
			},
			{
				"draw_sprite_part_ext",
				new string[][]
				{
					new string[] {
						"sprite",
						"subimg",
						"left",
						"top",
						"width",
						"height",
						"x",
						"y",
						"xscale",
						"yscale",
						"color",
						"alpha",
					},
				}
			},
			{
				"draw_sprite_part",
				new string[][]
				{
					new string[] {
						"sprite",
						"subimg",
						"left",
						"top",
						"width",
						"height",
						"x",
						"y",
					},
				}
			},
			{
				"draw_sprite_pos",
				new string[][]
				{
					new string[] {
						"sprite",
						"subimg",
						"x1",
						"y1",
						"x2",
						"y2",
						"x3",
						"y3",
						"x4",
						"y4",
						"alpha",
					},
				}
			},
			{
				"draw_sprite_stretched_ext",
				new string[][]
				{
					new string[] {
						"sprite",
						"subimg",
						"x",
						"y",
						"w",
						"h",
						"color",
						"alpha",
					},
				}
			},
			{
				"draw_sprite_stretched",
				new string[][]
				{
					new string[] {
						"sprite",
						"subimg",
						"x",
						"y",
						"w",
						"h",
					},
				}
			},
			{
				"draw_sprite_tiled_ext",
				new string[][]
				{
					new string[] {
						"sprite",
						"subimg",
						"x",
						"y",
						"xscale",
						"yscale",
						"color",
						"alpha",
					},
				}
			},
			{
				"draw_sprite_tiled",
				new string[][]
				{
					new string[] {
						"sprite",
						"subimg",
						"x",
						"y",
					},
				}
			},
			{
				"draw_sprite",
				new string[][]
				{
					new string[] {
						"sprite",
						"subimg",
						"x",
						"y",
					},
				}
			},
			{
				"draw_surface",
				new string[][]
				{
					new string[] {
						"id",
						"x",
						"y",
					},
				}
			},
			{
				"draw_surface_ext",
				new string[][]
				{
					new string[] {
						"id",
						"x",
						"y",
						"xscale",
						"yscale",
						"rot",
						"color",
						"alpha",
					},
				}
			},
			{
				"draw_surface_general",
				new string[][]
				{
					new string[] {
						"id",
						"left",
						"top",
						"width",
						"height",
						"x",
						"y",
						"xscale",
						"yscale",
						"rot",
						"c1",
						"c2",
						"c3",
						"c4",
						"alpha",
					},
				}
			},
			{
				"draw_surface_part_ext",
				new string[][]
				{
					new string[] {
						"id",
						"left",
						"top",
						"width",
						"height",
						"x",
						"y",
						"xscale",
						"yscale",
						"color",
						"alpha",
					},
				}
			},
			{
				"draw_surface_part",
				new string[][]
				{
					new string[] {
						"id",
						"left",
						"top",
						"width",
						"height",
						"x",
						"y",
					},
				}
			},
			{
				"draw_surface_stretched_ext",
				new string[][]
				{
					new string[] {
						"id",
						"x",
						"y",
						"w",
						"h",
						"color",
						"alpha",
					},
				}
			},
			{
				"draw_surface_stretched",
				new string[][]
				{
					new string[] {
						"id",
						"x",
						"y",
						"w",
						"h",
					},
				}
			},
			{
				"draw_surface_tiled_ext",
				new string[][]
				{
					new string[] {
						"id",
						"x",
						"y",
						"xscale",
						"yscale",
						"color",
						"alpha",
					},
				}
			},
			{
				"draw_surface_tiled",
				new string[][]
				{
					new string[] {
						"id",
						"x",
						"y",
					},
				}
			},
			{
				"draw_text_color",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"string",
						"c1",
						"c2",
						"c3",
						"c4",
						"alpha",
					},
				}
			},
			{
				"draw_text_ext_color",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"string",
						"sep",
						"w",
						"c1",
						"c2",
						"c3",
						"c4",
						"alpha",
					},
				}
			},
			{
				"draw_text_ext_transformed_color",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"string",
						"sep",
						"w",
						"xscale",
						"yscale",
						"angle",
						"c1",
						"c2",
						"c3",
						"c4",
						"alpha",
					},
				}
			},
			{
				"draw_text_ext_transformed",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"string",
						"sep",
						"w",
						"xscale",
						"yscale",
						"angle",
					},
				}
			},
			{
				"draw_text_ext",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"string",
						"sep",
						"w",
					},
				}
			},
			{
				"draw_text_transformed_color",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"string",
						"xscale",
						"yscale",
						"angle",
						"c1",
						"c2",
						"c3",
						"c4",
						"alpha",
					},
				}
			},
			{
				"draw_text_transformed",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"string",
						"xscale",
						"yscale",
						"angle",
					},
				}
			},
			{
				"draw_text",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"string",
					},
				}
			},
			{
				"draw_triangle_color",
				new string[][]
				{
					new string[] {
						"x1",
						"y1",
						"x2",
						"y2",
						"x3",
						"y3",
						"col1",
						"col2",
						"col3",
						"outline",
					},
				}
			},
			{
				"draw_triangle",
				new string[][]
				{
					new string[] {
						"x1",
						"y1",
						"x2",
						"y2",
						"x3",
						"y3",
						"outline",
					},
				}
			},
			{
				"draw_vertex_color",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"col",
						"alpha",
					},
				}
			},
			{
				"draw_vertex_texture_color",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"xtex",
						"ytex",
						"col",
						"alpha",
					},
				}
			},
			{
				"draw_vertex_texture",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"xtex",
						"ytex",
					},
				}
			},
			{
				"draw_vertex",
				new string[][]
				{
					new string[] {
						"x",
						"y",
					},
				}
			},
			{
				"ds_grid_add_disk",
				new string[][]
				{
					new string[] {
						"id",
						"xm",
						"ym",
						"r",
						"val",
					},
				}
			},
			{
				"ds_grid_add_grid_region",
				new string[][]
				{
					new string[] {
						"id",
						"source",
						"x1",
						"y1",
						"x2",
						"y2",
						"xpos",
						"ypos",
					},
				}
			},
			{
				"ds_grid_add_region",
				new string[][]
				{
					new string[] {
						"id",
						"x1",
						"y1",
						"x2",
						"y2",
						"val",
					},
				}
			},
			{
				"ds_grid_add",
				new string[][]
				{
					new string[] {
						"id",
						"x",
						"y",
						"val",
					},
				}
			},
			{
				"ds_grid_clear",
				new string[][]
				{
					new string[] {
						"id",
						"val",
					},
				}
			},
			{
				"ds_grid_copy",
				new string[][]
				{
					new string[] {
						"id",
						"source",
					},
				}
			},
			{
				"ds_grid_create",
				new string[][]
				{
					new string[] {
						"w",
						"h",
					},
				}
			},
			{
				"ds_grid_destroy",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_grid_get_disk_max",
				new string[][]
				{
					new string[] {
						"id",
						"xm",
						"ym",
						"r",
					},
				}
			},
			{
				"ds_grid_get_disk_mean",
				new string[][]
				{
					new string[] {
						"id",
						"xm",
						"ym",
						"r",
					},
				}
			},
			{
				"ds_grid_get_disk_min",
				new string[][]
				{
					new string[] {
						"id",
						"xm",
						"ym",
						"r",
					},
				}
			},
			{
				"ds_grid_get_disk_sum",
				new string[][]
				{
					new string[] {
						"id",
						"xm",
						"ym",
						"r",
					},
				}
			},
			{
				"ds_grid_get_max",
				new string[][]
				{
					new string[] {
						"id",
						"x1",
						"y1",
						"x2",
						"y2",
					},
				}
			},
			{
				"ds_grid_get_mean",
				new string[][]
				{
					new string[] {
						"id",
						"x1",
						"y1",
						"x2",
						"y2",
					},
				}
			},
			{
				"ds_grid_get_min",
				new string[][]
				{
					new string[] {
						"id",
						"x1",
						"y1",
						"x2",
						"y2",
					},
				}
			},
			{
				"ds_grid_get_sum",
				new string[][]
				{
					new string[] {
						"id",
						"x1",
						"y1",
						"x2",
						"y2",
					},
				}
			},
			{
				"ds_grid_get",
				new string[][]
				{
					new string[] {
						"id",
						"x",
						"y",
					},
				}
			},
			{
				"ds_grid_height",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_grid_multiply_disk",
				new string[][]
				{
					new string[] {
						"id",
						"xm",
						"ym",
						"r",
						"val",
					},
				}
			},
			{
				"ds_grid_multiply_grid_region",
				new string[][]
				{
					new string[] {
						"id",
						"source",
						"x1",
						"y1",
						"x2",
						"y2",
						"xpos",
						"ypos",
					},
				}
			},
			{
				"ds_grid_multiply_region",
				new string[][]
				{
					new string[] {
						"id",
						"x1",
						"y1",
						"x2",
						"y2",
						"val",
					},
				}
			},
			{
				"ds_grid_multiply",
				new string[][]
				{
					new string[] {
						"id",
						"x",
						"y",
						"val",
					},
				}
			},
			{
				"ds_grid_read",
				new string[][]
				{
					new string[] {
						"id",
						"str",
					},
				}
			},
			{
				"ds_grid_resize",
				new string[][]
				{
					new string[] {
						"id",
						"w",
						"h",
					},
				}
			},
			{
				"ds_grid_set_disk",
				new string[][]
				{
					new string[] {
						"id",
						"xm",
						"ym",
						"r",
						"val",
					},
				}
			},
			{
				"ds_grid_set_grid_region",
				new string[][]
				{
					new string[] {
						"id",
						"source",
						"x1",
						"y1",
						"x2",
						"y2",
						"xpos",
						"ypos",
					},
				}
			},
			{
				"ds_grid_set_region",
				new string[][]
				{
					new string[] {
						"id",
						"x1",
						"y1",
						"x2",
						"y2",
						"val",
					},
				}
			},
			{
				"ds_grid_set",
				new string[][]
				{
					new string[] {
						"id",
						"x",
						"y",
						"val",
					},
				}
			},
			{
				"ds_grid_shuffle",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_grid_value_disk_exists",
				new string[][]
				{
					new string[] {
						"id",
						"xm",
						"ym",
						"r",
						"val",
					},
				}
			},
			{
				"ds_grid_value_disk_x",
				new string[][]
				{
					new string[] {
						"id",
						"xm",
						"ym",
						"r",
						"val",
					},
				}
			},
			{
				"ds_grid_value_disk_y",
				new string[][]
				{
					new string[] {
						"id",
						"xm",
						"ym",
						"r",
						"val",
					},
				}
			},
			{
				"ds_grid_value_exists",
				new string[][]
				{
					new string[] {
						"id",
						"x1",
						"y1",
						"x2",
						"y2",
						"val",
					},
				}
			},
			{
				"ds_grid_value_x",
				new string[][]
				{
					new string[] {
						"id",
						"x1",
						"y1",
						"x2",
						"y2",
						"val",
					},
				}
			},
			{
				"ds_grid_value_y",
				new string[][]
				{
					new string[] {
						"id",
						"x1",
						"y1",
						"x2",
						"y2",
						"val",
					},
				}
			},
			{
				"ds_grid_width",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_grid_write",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_list_add",
				new string[][]
				{
					new string[] {
						"id",
						"val",
					},
				}
			},
			{
				"ds_list_clear",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_list_copy",
				new string[][]
				{
					new string[] {
						"id",
						"source",
					},
				}
			},
			{
				"ds_list_create",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"ds_list_delete",
				new string[][]
				{
					new string[] {
						"id",
						"pos",
					},
				}
			},
			{
				"ds_list_destroy",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_list_empty",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_list_find_index",
				new string[][]
				{
					new string[] {
						"id",
						"val",
					},
				}
			},
			{
				"ds_list_find_value",
				new string[][]
				{
					new string[] {
						"id",
						"pos",
					},
				}
			},
			{
				"ds_list_insert",
				new string[][]
				{
					new string[] {
						"id",
						"pos",
						"val",
					},
				}
			},
			{
				"ds_list_read",
				new string[][]
				{
					new string[] {
						"id",
						"str",
					},
				}
			},
			{
				"ds_list_replace",
				new string[][]
				{
					new string[] {
						"id",
						"pos",
						"val",
					},
				}
			},
			{
				"ds_list_shuffle",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_list_size",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_list_sort",
				new string[][]
				{
					new string[] {
						"id",
						"ascend",
					},
				}
			},
			{
				"ds_list_write",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_map_add",
				new string[][]
				{
					new string[] {
						"id",
						"key",
						"val",
					},
				}
			},
			{
				"ds_map_clear",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_map_copy",
				new string[][]
				{
					new string[] {
						"id",
						"source",
					},
				}
			},
			{
				"ds_map_create",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"ds_map_delete",
				new string[][]
				{
					new string[] {
						"id",
						"key",
					},
				}
			},
			{
				"ds_map_destroy",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_map_empty",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_map_exists",
				new string[][]
				{
					new string[] {
						"id",
						"key",
					},
				}
			},
			{
				"ds_map_find_first",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_map_find_last",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_map_find_next",
				new string[][]
				{
					new string[] {
						"id",
						"key",
					},
				}
			},
			{
				"ds_map_find_previous",
				new string[][]
				{
					new string[] {
						"id",
						"key",
					},
				}
			},
			{
				"ds_map_find_value",
				new string[][]
				{
					new string[] {
						"id",
						"key",
					},
				}
			},
			{
				"ds_map_read",
				new string[][]
				{
					new string[] {
						"id",
						"str",
					},
				}
			},
			{
				"ds_map_replace",
				new string[][]
				{
					new string[] {
						"id",
						"key",
						"val",
					},
				}
			},
			{
				"ds_map_size",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_map_write",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_priority_add",
				new string[][]
				{
					new string[] {
						"id",
						"val",
						"prio",
					},
				}
			},
			{
				"ds_priority_change_priority",
				new string[][]
				{
					new string[] {
						"id",
						"val",
						"prio",
					},
				}
			},
			{
				"ds_priority_clear",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_priority_copy",
				new string[][]
				{
					new string[] {
						"id",
						"source",
					},
				}
			},
			{
				"ds_priority_create",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"ds_priority_delete_max",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_priority_delete_min",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_priority_delete_value",
				new string[][]
				{
					new string[] {
						"id",
						"val",
					},
				}
			},
			{
				"ds_priority_destroy",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_priority_empty",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_priority_find_max",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_priority_find_min",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_priority_find_priority",
				new string[][]
				{
					new string[] {
						"id",
						"val",
					},
				}
			},
			{
				"ds_priority_read",
				new string[][]
				{
					new string[] {
						"id",
						"str",
					},
				}
			},
			{
				"ds_priority_size",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_priority_write",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_queue_clear",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_queue_copy",
				new string[][]
				{
					new string[] {
						"id",
						"source",
					},
				}
			},
			{
				"ds_queue_create",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"ds_queue_dequeue",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_queue_destroy",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_queue_empty",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_queue_enqueue",
				new string[][]
				{
					new string[] {
						"id",
						"val",
					},
				}
			},
			{
				"ds_queue_head",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_queue_read",
				new string[][]
				{
					new string[] {
						"id",
						"str",
					},
				}
			},
			{
				"ds_queue_size",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_queue_tail",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_queue_write",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_stack_clear",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_stack_copy",
				new string[][]
				{
					new string[] {
						"id",
						"source",
					},
				}
			},
			{
				"ds_stack_create",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"ds_stack_destroy",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_stack_empty",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_stack_pop",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_stack_push",
				new string[][]
				{
					new string[] {
						"id",
						"val",
					},
				}
			},
			{
				"ds_stack_read",
				new string[][]
				{
					new string[] {
						"id",
						"str",
					},
				}
			},
			{
				"ds_stack_size",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_stack_top",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"ds_stack_write",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"effect_clear",
				new string[][]
				{
					new string[] {
						"",
					},
				}
			},
			{
				"effect_create_above",
				new string[][]
				{
					new string[] {
						"kind",
						"x",
						"y",
						"size",
						"color",
					},
				}
			},
			{
				"effect_create_below",
				new string[][]
				{
					new string[] {
						"kind",
						"x",
						"y",
						"size",
						"color",
					},
				}
			},
			{
				"environment_get_variable",
				new string[][]
				{
					new string[] {
						"name",
					},
				}
			},
			{
				"event_inherited",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"event_perform_object",
				new string[][]
				{
					new string[] {
						"obj",
						"type",
						"numb",
					},
				}
			},
			{
				"event_perform",
				new string[][]
				{
					new string[] {
						"type",
						"numb",
					},
				}
			},
			{
				"event_user",
				new string[][]
				{
					new string[] {
						"numb",
					},
				}
			},
			{
				"execute_file",
				new string[][]
				{
					new string[] {
						"fname",
					},
					new string[] {
						"fname",
						"arg0",
						"arg1",
						"...",
					},
				}
			},
			{
				"execute_program",
				new string[][]
				{
					new string[] {
						"prog",
						"arg",
						"wait",
					},
				}
			},
			{
				"execute_shell",
				new string[][]
				{
					new string[] {
						"prog",
						"arg",
					},
				}
			},
			{
				"execute_string",
				new string[][]
				{
					new string[] {
						"str",
						"arg0",
						"arg1",
						"...",
					},
					new string[] {
						"str",
						"arg0",
						"arg1",
						"...",
					},
				}
			},
			{
				"export_include_file_location",
				new string[][]
				{
					new string[] {
						"fname",
						"location",
					},
				}
			},
			{
				"export_include_file",
				new string[][]
				{
					new string[] {
						"fname",
					},
				}
			},
			{
				"exp",
				new string[][]
				{
					new string[] {
						"x",
					},
				}
			},
			{
				"external_call",
				new string[][]
				{
					new string[] {
						"id",
						"arg1",
						"arg2",
						"...",
					},
				}
			},
			{
				"external_define",
				new string[][]
				{
					new string[] {
						"dll",
						"name",
						"calltype",
						"restype",
						"argnumb",
						"arg1type",
						"arg2type",
						" ...",
					},
				}
			},
			{
				"external_free",
				new string[][]
				{
					new string[] {
						"dll",
					},
				}
			},
			{
				"filename_change_ext",
				new string[][]
				{
					new string[] {
						"fname",
						"newext",
					},
				}
			},
			{
				"filename_dir",
				new string[][]
				{
					new string[] {
						"fname",
					},
				}
			},
			{
				"filename_drive",
				new string[][]
				{
					new string[] {
						"fname",
					},
				}
			},
			{
				"filename_ext",
				new string[][]
				{
					new string[] {
						"fname",
					},
				}
			},
			{
				"filename_name",
				new string[][]
				{
					new string[] {
						"fname",
					},
				}
			},
			{
				"filename_path",
				new string[][]
				{
					new string[] {
						"fname",
					},
				}
			},
			{
				"file_attributes",
				new string[][]
				{
					new string[] {
						"fname",
						"attr",
					},
				}
			},
			{
				"file_bin_close",
				new string[][]
				{
					new string[] {
						"fileid",
					},
				}
			},
			{
				"file_bin_open",
				new string[][]
				{
					new string[] {
						"fname",
						"mod",
					},
				}
			},
			{
				"file_bin_position",
				new string[][]
				{
					new string[] {
						"fileid",
					},
				}
			},
			{
				"file_bin_read_byte",
				new string[][]
				{
					new string[] {
						"fileid",
					},
				}
			},
			{
				"file_bin_rewrite",
				new string[][]
				{
					new string[] {
						"fileid",
					},
				}
			},
			{
				"file_bin_seek",
				new string[][]
				{
					new string[] {
						"fileid",
						"pos",
					},
				}
			},
			{
				"file_bin_size",
				new string[][]
				{
					new string[] {
						"fileid",
					},
				}
			},
			{
				"file_bin_write_byte",
				new string[][]
				{
					new string[] {
						"fileid",
						"byte",
					},
				}
			},
			{
				"file_copy",
				new string[][]
				{
					new string[] {
						"fname",
						"newname",
					},
				}
			},
			{
				"file_delete",
				new string[][]
				{
					new string[] {
						"fname",
					},
				}
			},
			{
				"file_exists",
				new string[][]
				{
					new string[] {
						"fname",
					},
				}
			},
			{
				"file_find_close",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"file_find_first",
				new string[][]
				{
					new string[] {
						"mask",
						"attr",
					},
				}
			},
			{
				"file_find_next",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"file_rename",
				new string[][]
				{
					new string[] {
						"oldname",
						"newname",
					},
				}
			},
			{
				"file_text_close",
				new string[][]
				{
					new string[] {
						"fileid",
					},
				}
			},
			{
				"file_text_eof",
				new string[][]
				{
					new string[] {
						"fileid",
					},
				}
			},
			{
				"file_text_open_append",
				new string[][]
				{
					new string[] {
						"fname",
					},
				}
			},
			{
				"file_text_open_read",
				new string[][]
				{
					new string[] {
						"fname",
					},
				}
			},
			{
				"file_text_open_write",
				new string[][]
				{
					new string[] {
						"fname",
					},
				}
			},
			{
				"file_text_readln",
				new string[][]
				{
					new string[] {
						"fileid",
					},
				}
			},
			{
				"file_text_read_real",
				new string[][]
				{
					new string[] {
						"fileid",
					},
				}
			},
			{
				"file_text_read_string",
				new string[][]
				{
					new string[] {
						"fileid",
					},
				}
			},
			{
				"file_text_writeln",
				new string[][]
				{
					new string[] {
						"fileid",
					},
				}
			},
			{
				"file_text_write_real",
				new string[][]
				{
					new string[] {
						"fileid",
						"x",
					},
				}
			},
			{
				"file_text_write_string",
				new string[][]
				{
					new string[] {
						"fileid",
						"str",
					},
				}
			},
			{
				"floor",
				new string[][]
				{
					new string[] {
						"x",
					},
				}
			},
			{
				"font_add_sprite",
				new string[][]
				{
					new string[] {
						"spr",
						"first",
						"prop",
						"sep",
					},
				}
			},
			{
				"font_add",
				new string[][]
				{
					new string[] {
						"name",
						"size",
						"bold",
						"italic",
						"first",
						"last",
					},
				}
			},
			{
				"font_delete",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"font_exists",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"font_get_bold",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"font_get_first",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"font_get_fontname",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"font_get_italic",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"font_get_last",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"font_get_name",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"font_get_texture",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"font_get_uvs",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"font_replace_sprite",
				new string[][]
				{
					new string[] {
						"ind",
						"spr",
						"first",
						"prop",
						"sep",
					},
				}
			},
			{
				"font_replace",
				new string[][]
				{
					new string[] {
						"ind",
						"name",
						"size",
						"bold",
						"italic",
						"first",
						"last",
					},
				}
			},
			{
				"frac",
				new string[][]
				{
					new string[] {
						"x",
					},
				}
			},
			{
				"game_end",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"game_load",
				new string[][]
				{
					new string[] {
						"string",
					},
				}
			},
			{
				"game_load_buffer",
				new string[][]
				{
					new string[] {
						"buffer",
					},
				}
			},
			{
				"game_restart",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"game_save",
				new string[][]
				{
					new string[] {
						"string",
					},
				}
			},
			{
				"game_save_buffer",
				new string[][]
				{
					new string[] {
						"buffer",
					},
				}
			},
			{
				"gamepad_is_supported",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"gamepad_get_device_count",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"gamepad_is_connected",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"gamepad_get_description",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"gamepad_get_button_threshold",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"gamepad_set_button_threshold",
				new string[][]
				{
					new string[] {
						"id",
						"threshold",
					},
				}
			},
			{
				"gamepad_axis_count",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"gamepad_axis_value",
				new string[][]
				{
					new string[] {
						"id",
						"axis",
					},
				}
			},
			{
				"gamepad_button_check",
				new string[][]
				{
					new string[] {
						"id",
						"button",
					},
				}
			},
			{
				"gamepad_button_check_pressed",
				new string[][]
				{
					new string[] {
						"id",
						"button",
					},
				}
			},
			{
				"gamepad_button_check_released",
				new string[][]
				{
					new string[] {
						"id",
						"button",
					},
				}
			},
			{
				"gamepad_button_count",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"gamepad_button_value",
				new string[][]
				{
					new string[] {
						"id",
						"button",
					},
				}
			},
			{
				"gamepad_set_vibration",
				new string[][]
				{
					new string[] {
						"id",
						"left_motor",
						"right_motor",
					},
				}
			},
			{
				"get_color",
				new string[][]
				{
					new string[] {
						"defcol",
					},
				}
			},
			{
				"get_directory_alt",
				new string[][]
				{
					new string[] {
						"capt",
						"root",
					},
				}
			},
			{
				"get_directory",
				new string[][]
				{
					new string[] {
						"dname",
					},
				}
			},
			{
				"get_integer",
				new string[][]
				{
					new string[] {
						"str",
						"def",
					},
				}
			},
			{
				"get_integer_async",
				new string[][]
				{
					new string[] {
						"str",
						"def",
					},
				}
			},
			{
				"get_login_async",
				new string[][]
				{
					new string[] {
						"name",
						"password",
					},
				}
			},
			{
				"get_open_filename",
				new string[][]
				{
					new string[] {
						"filter",
						"fname",
					},
				}
			},
			{
				"get_open_filename_ext",
				new string[][]
				{
					new string[] {
						"filter",
						"fname",
						"directory",
						"caption",
					},
				}
			},
			{
				"get_save_filename",
				new string[][]
				{
					new string[] {
						"filter",
						"fname",
					},
				}
			},
			{
				"get_save_filename_ext",
				new string[][]
				{
					new string[] {
						"filter",
						"fname",
						"directory",
						"caption",
					},
				}
			},
			{
				"get_string",
				new string[][]
				{
					new string[] {
						"str",
						"def",
					},
				}
			},
			{
				"get_string_async",
				new string[][]
				{
					new string[] {
						"str",
						"def",
					},
				}
			},
			{
				"get_timer",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"highscore_add_current",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"highscore_add",
				new string[][]
				{
					new string[] {
						"str",
						"numb",
					},
				}
			},
			{
				"highscore_clear",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"highscore_name",
				new string[][]
				{
					new string[] {
						"place",
					},
				}
			},
			{
				"highscore_set_background",
				new string[][]
				{
					new string[] {
						"back",
					},
				}
			},
			{
				"highscore_set_border",
				new string[][]
				{
					new string[] {
						"show",
					},
				}
			},
			{
				"highscore_set_colors",
				new string[][]
				{
					new string[] {
						"back",
						"new",
						"other",
					},
				}
			},
			{
				"highscore_set_font",
				new string[][]
				{
					new string[] {
						"name",
						"size",
						"style",
					},
				}
			},
			{
				"highscore_set_strings",
				new string[][]
				{
					new string[] {
						"caption",
						"nobody",
						"escape",
					},
				}
			},
			{
				"highscore_show_ext",
				new string[][]
				{
					new string[] {
						"numb",
						"back",
						"border",
						"col1",
						"col2",
						"name",
						"size",
					},
				}
			},
			{
				"highscore_show",
				new string[][]
				{
					new string[] {
						"numb",
					},
				}
			},
			{
				"highscore_value",
				new string[][]
				{
					new string[] {
						"place",
					},
				}
			},
			{
				"iap_activate",
				new string[][]
				{
					new string[] {
						"product",
					},
				}
			},
			{
				"iap_status",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"iap_store_status",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"iap_acquire",
				new string[][]
				{
					new string[] {
						"purchase",
					},
				}
			},
			{
				"iap_consume",
				new string[][]
				{
					new string[] {
						"purchase",
					},
				}
			},
			{
				"iap_event_queue",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"iap_is_downloaded",
				new string[][]
				{
					new string[] {
						"purchase",
					},
				}
			},
			{
				"iap_is_purchased",
				new string[][]
				{
					new string[] {
						"product",
					},
				}
			},
			{
				"iap_product_status",
				new string[][]
				{
					new string[] {
						"product",
					},
				}
			},
			{
				"iap_product_details",
				new string[][]
				{
					new string[] {
						"purchase",
						"map",
					},
				}
			},
			{
				"iap_product_files",
				new string[][]
				{
					new string[] {
						"purchase",
						"list",
					},
				}
			},
			{
				"iap_files_purchased",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"iap_restore_all",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"ini_close",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"ini_key_delete",
				new string[][]
				{
					new string[] {
						"section",
						"key",
					},
				}
			},
			{
				"ini_key_exists",
				new string[][]
				{
					new string[] {
						"section",
						"key",
					},
				}
			},
			{
				"ini_open",
				new string[][]
				{
					new string[] {
						"name",
					},
				}
			},
			{
				"ini_read_real",
				new string[][]
				{
					new string[] {
						"section",
						"key",
						"default",
					},
				}
			},
			{
				"ini_read_string",
				new string[][]
				{
					new string[] {
						"section",
						"key",
						"default",
					},
				}
			},
			{
				"ini_section_delete",
				new string[][]
				{
					new string[] {
						"section",
					},
				}
			},
			{
				"ini_section_exists",
				new string[][]
				{
					new string[] {
						"section",
					},
				}
			},
			{
				"ini_write_real",
				new string[][]
				{
					new string[] {
						"section",
						"key",
						"value",
					},
				}
			},
			{
				"ini_write_string",
				new string[][]
				{
					new string[] {
						"section",
						"key",
						"value",
					},
				}
			},
			{
				"instance_activate_all",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"instance_activate_object",
				new string[][]
				{
					new string[] {
						"obj",
					},
				}
			},
			{
				"instance_activate_region",
				new string[][]
				{
					new string[] {
						"left",
						"top",
						"width",
						"height",
						"inside",
					},
				}
			},
			{
				"instance_change",
				new string[][]
				{
					new string[] {
						"obj",
						"perf",
					},
				}
			},
			{
				"instance_copy",
				new string[][]
				{
					new string[] {
						"performevent",
					},
				}
			},
			{
				"instance_create",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"obj",
					},
				}
			},
			{
				"instance_deactivate_all",
				new string[][]
				{
					new string[] {
						"notme",
					},
				}
			},
			{
				"instance_deactivate_object",
				new string[][]
				{
					new string[] {
						"obj",
					},
				}
			},
			{
				"instance_deactivate_region",
				new string[][]
				{
					new string[] {
						"left",
						"top",
						"width",
						"height",
						"inside",
						"notme",
					},
				}
			},
			{
				"instance_destroy",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"instance_exists",
				new string[][]
				{
					new string[] {
						"obj",
					},
				}
			},
			{
				"instance_find",
				new string[][]
				{
					new string[] {
						"obj",
						"n",
					},
				}
			},
			{
				"instance_furthest",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"obj",
					},
				}
			},
			{
				"instance_nearest",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"obj",
					},
				}
			},
			{
				"instance_number",
				new string[][]
				{
					new string[] {
						"obj",
					},
				}
			},
			{
				"instance_place",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"obj",
					},
				}
			},
			{
				"instance_position",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"obj",
					},
				}
			},
			{
				"io_clear",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"io_handle",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"irandom",
				new string[][]
				{
					new string[] {
						"n",
					},
				}
			},
			{
				"irandom_range",
				new string[][]
				{
					new string[] {
						"n1",
						"n2",
					},
				}
			},
			{
				"is_array",
				new string[][]
				{
					new string[] {
						"x",
					},
				}
			},
			{
				"is_real",
				new string[][]
				{
					new string[] {
						"x",
					},
				}
			},
			{
				"is_string",
				new string[][]
				{
					new string[] {
						"x",
					},
				}
			},
			{
				"joystick_axes",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"joystick_buttons",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"joystick_check_button",
				new string[][]
				{
					new string[] {
						"id",
						"numb",
					},
				}
			},
			{
				"joystick_direction",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"joystick_exists",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"joystick_has_pov",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"joystick_name",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"joystick_pov",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"joystick_rpos",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"joystick_upos",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"joystick_vpos",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"joystick_xpos",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"joystick_ypos",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"joystick_zpos",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"json_encode",
				new string[][]
				{
					new string[] {
						"map",
					},
				}
			},
			{
				"json_decode",
				new string[][]
				{
					new string[] {
						"string",
					},
				}
			},
			{
				"keyboard_check_direct",
				new string[][]
				{
					new string[] {
						"key",
					},
				}
			},
			{
				"keyboard_check_pressed",
				new string[][]
				{
					new string[] {
						"key",
					},
				}
			},
			{
				"keyboard_check_released",
				new string[][]
				{
					new string[] {
						"key",
					},
				}
			},
			{
				"keyboard_check",
				new string[][]
				{
					new string[] {
						"key",
					},
				}
			},
			{
				"keyboard_clear",
				new string[][]
				{
					new string[] {
						"key",
					},
				}
			},
			{
				"keyboard_get_map",
				new string[][]
				{
					new string[] {
						"key",
					},
				}
			},
			{
				"keyboard_get_numlock",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"keyboard_key_press",
				new string[][]
				{
					new string[] {
						"key",
					},
				}
			},
			{
				"keyboard_key_release",
				new string[][]
				{
					new string[] {
						"key",
					},
				}
			},
			{
				"keyboard_set_map",
				new string[][]
				{
					new string[] {
						"key1",
						"key2",
					},
				}
			},
			{
				"keyboard_set_numlock",
				new string[][]
				{
					new string[] {
						"on",
					},
				}
			},
			{
				"keyboard_unset_map",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"keyboard_wait",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"lengthdir_x",
				new string[][]
				{
					new string[] {
						"len",
						"dir",
					},
				}
			},
			{
				"lengthdir_y",
				new string[][]
				{
					new string[] {
						"len",
						"dir",
					},
				}
			},
			{
				"lerp",
				new string[][]
				{
					new string[] {
						"a",
						"b",
						"amount",
					},
				}
			},
			{
				"ln",
				new string[][]
				{
					new string[] {
						"x",
					},
				}
			},
			{
				"log10",
				new string[][]
				{
					new string[] {
						"x",
					},
				}
			},
			{
				"log2",
				new string[][]
				{
					new string[] {
						"x",
					},
				}
			},
			{
				"logn",
				new string[][]
				{
					new string[] {
						"n",
						"x",
					},
				}
			},
			{
				"make_color_hsv",
				new string[][]
				{
					new string[] {
						"hue",
						"saturation",
						"value",
					},
				}
			},
			{
				"make_color_rgb",
				new string[][]
				{
					new string[] {
						"red",
						"green",
						"blue",
					},
				}
			},
			{
				"matrix_get",
				new string[][]
				{
					new string[] {
						"type",
					},
				}
			},
			{
				"matrix_set",
				new string[][]
				{
					new string[] {
						"type",
						"matrix",
					},
				}
			},
			{
				"matrix_build",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"z",
						"xrotation",
						"yrotation",
						"zrotation",
						"xscale",
						"yscale",
						"zscale",
					},
				}
			},
			{
				"matrix_multiply",
				new string[][]
				{
					new string[] {
						"matrix",
					},
				}
			},
			{
				"max",
				new string[][]
				{
					new string[] {
						"val1",
						"val2",
						"val3",
						"...",
					},
				}
			},
			{
				"MCI_command",
				new string[][]
				{
					new string[] {
						"str",
					},
				}
			},
			{
				"md5_file",
				new string[][]
				{
					new string[] {
						"filename",
					},
				}
			},
			{
				"md5_string_unicode",
				new string[][]
				{
					new string[] {
						"string",
					},
				}
			},
			{
				"md5_string_utf8",
				new string[][]
				{
					new string[] {
						"string",
					},
				}
			},
			{
				"mean",
				new string[][]
				{
					new string[] {
						"val1",
						"val2",
						"val3",
						"...",
					},
				}
			},
			{
				"median",
				new string[][]
				{
					new string[] {
						"val1",
						"val2",
						"val3",
						"...",
					},
				}
			},
			{
				"merge_color",
				new string[][]
				{
					new string[] {
						"col1",
						"col2",
						"amount",
					},
				}
			},
			{
				"message_alpha",
				new string[][]
				{
					new string[] {
						"alpha",
					},
				}
			},
			{
				"message_background",
				new string[][]
				{
					new string[] {
						"back",
					},
				}
			},
			{
				"message_button_font",
				new string[][]
				{
					new string[] {
						"name",
						"size",
						"color",
						"style",
					},
				}
			},
			{
				"message_button",
				new string[][]
				{
					new string[] {
						"spr",
					},
				}
			},
			{
				"message_caption",
				new string[][]
				{
					new string[] {
						"show",
						"str",
					},
				}
			},
			{
				"message_input_color",
				new string[][]
				{
					new string[] {
						"col",
					},
				}
			},
			{
				"message_input_font",
				new string[][]
				{
					new string[] {
						"name",
						"size",
						"color",
						"style",
					},
				}
			},
			{
				"message_mouse_color",
				new string[][]
				{
					new string[] {
						"col",
					},
				}
			},
			{
				"message_position",
				new string[][]
				{
					new string[] {
						"x",
						"y",
					},
				}
			},
			{
				"message_size",
				new string[][]
				{
					new string[] {
						"w",
						"h",
					},
				}
			},
			{
				"message_text_font",
				new string[][]
				{
					new string[] {
						"name",
						"size",
						"color",
						"style",
					},
				}
			},
			{
				"message_text_charset",
				new string[][]
				{
					new string[] {
						"type",
						"charset",
					},
				}
			},
			{
				"min",
				new string[][]
				{
					new string[] {
						"val1",
						"val2",
						"val3",
						"...",
					},
				}
			},
			{
				"motion_set",
				new string[][]
				{
					new string[] {
						"dir",
						"speed",
					},
				}
			},
			{
				"motion_add",
				new string[][]
				{
					new string[] {
						"dir",
						"speed",
					},
				}
			},
			{
				"mouse_check_button_pressed",
				new string[][]
				{
					new string[] {
						"numb",
					},
				}
			},
			{
				"mouse_check_button_released",
				new string[][]
				{
					new string[] {
						"numb",
					},
				}
			},
			{
				"mouse_check_button",
				new string[][]
				{
					new string[] {
						"numb",
					},
				}
			},
			{
				"mouse_clear",
				new string[][]
				{
					new string[] {
						"button",
					},
				}
			},
			{
				"move_bounce_all",
				new string[][]
				{
					new string[] {
						"adv",
					},
				}
			},
			{
				"move_bounce_solid",
				new string[][]
				{
					new string[] {
						"adv",
					},
				}
			},
			{
				"move_contact_all",
				new string[][]
				{
					new string[] {
						"dir",
						"maxdist",
					},
				}
			},
			{
				"move_contact_solid",
				new string[][]
				{
					new string[] {
						"dir",
						"maxdist",
					},
				}
			},
			{
				"move_outside_all",
				new string[][]
				{
					new string[] {
						"dir",
						"maxdist",
					},
				}
			},
			{
				"move_outside_solid",
				new string[][]
				{
					new string[] {
						"dir",
						"maxdist",
					},
				}
			},
			{
				"move_random",
				new string[][]
				{
					new string[] {
						"hsnap",
						"vsnap",
					},
				}
			},
			{
				"move_snap",
				new string[][]
				{
					new string[] {
						"hsnap",
						"vsnap",
					},
				}
			},
			{
				"move_towards_point",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"sp",
					},
				}
			},
			{
				"move_wrap",
				new string[][]
				{
					new string[] {
						"hor",
						"vert",
						"margin",
					},
				}
			},
			{
				"mplay_connect_status",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"mplay_data_mode",
				new string[][]
				{
					new string[] {
						"guar",
					},
				}
			},
			{
				"mplay_data_read",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"mplay_data_write",
				new string[][]
				{
					new string[] {
						"ind",
						"val",
					},
				}
			},
			{
				"mplay_end",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"mplay_init_ipx",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"mplay_init_modem",
				new string[][]
				{
					new string[] {
						"initstr",
						"phonenr",
					},
				}
			},
			{
				"mplay_init_serial",
				new string[][]
				{
					new string[] {
						"portno",
						"baudrate",
						"stopbits",
						"parity",
						"flow",
					},
				}
			},
			{
				"mplay_init_tcpip",
				new string[][]
				{
					new string[] {
						"addr",
					},
				}
			},
			{
				"mplay_ipaddress",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"mplay_message_clear",
				new string[][]
				{
					new string[] {
						"player",
					},
				}
			},
			{
				"mplay_message_count",
				new string[][]
				{
					new string[] {
						"player",
					},
				}
			},
			{
				"mplay_message_id",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"mplay_message_name",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"mplay_message_player",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"mplay_message_receive",
				new string[][]
				{
					new string[] {
						"player",
					},
				}
			},
			{
				"mplay_message_send_guaranteed",
				new string[][]
				{
					new string[] {
						"player",
						"id",
						"val",
					},
				}
			},
			{
				"mplay_message_send",
				new string[][]
				{
					new string[] {
						"player",
						"id",
						"val",
					},
				}
			},
			{
				"mplay_message_value",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"mplay_player_find",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"mplay_player_id",
				new string[][]
				{
					new string[] {
						"numb",
					},
				}
			},
			{
				"mplay_player_name",
				new string[][]
				{
					new string[] {
						"numb",
					},
				}
			},
			{
				"mplay_session_create",
				new string[][]
				{
					new string[] {
						"sesname",
						"playnumb",
						"playername",
					},
				}
			},
			{
				"mplay_session_end",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"mplay_session_find",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"mplay_session_join",
				new string[][]
				{
					new string[] {
						"numb",
						"playername",
					},
				}
			},
			{
				"mplay_session_mode",
				new string[][]
				{
					new string[] {
						"move",
					},
				}
			},
			{
				"mplay_session_name",
				new string[][]
				{
					new string[] {
						"numb",
					},
				}
			},
			{
				"mplay_session_status",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"mp_grid_add_cell",
				new string[][]
				{
					new string[] {
						"id",
						"h",
						"v",
					},
				}
			},
			{
				"mp_grid_add_instances",
				new string[][]
				{
					new string[] {
						"id",
						"obj",
						"prec",
					},
				}
			},
			{
				"mp_grid_add_rectangle",
				new string[][]
				{
					new string[] {
						"id",
						"left",
						"top",
						"right",
						"bottom",
					},
				}
			},
			{
				"mp_grid_clear_all",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"mp_grid_clear_cell",
				new string[][]
				{
					new string[] {
						"id",
						"h",
						"v",
					},
				}
			},
			{
				"mp_grid_clear_rectangle",
				new string[][]
				{
					new string[] {
						"id",
						"left",
						"top",
						"right",
						"bottom",
					},
				}
			},
			{
				"mp_grid_create",
				new string[][]
				{
					new string[] {
						"left",
						"top",
						"hcells",
						"vcells",
						"cellwidth",
						"cellheight",
					},
				}
			},
			{
				"mp_grid_destroy",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"mp_grid_draw",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"mp_grid_path",
				new string[][]
				{
					new string[] {
						"id",
						"path",
						"xstart",
						"ystart",
						"xgoal",
						"ygoal",
						"allowdiag",
					},
				}
			},
			{
				"mp_linear_path_object",
				new string[][]
				{
					new string[] {
						"path",
						"xg",
						"yg",
						"stepsize",
						"obj",
					},
				}
			},
			{
				"mp_linear_path",
				new string[][]
				{
					new string[] {
						"path",
						"xg",
						"yg",
						"stepsize",
						"checkall",
					},
				}
			},
			{
				"mp_linear_step",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"stepsize",
						"checkall",
					},
				}
			},
			{
				"mp_potential_path_object",
				new string[][]
				{
					new string[] {
						"path",
						"xg",
						"yg",
						"stepsize",
						"factor",
						"obj",
					},
				}
			},
			{
				"mp_potential_path",
				new string[][]
				{
					new string[] {
						"path",
						"xg",
						"yg",
						"stepsize",
						"factor",
						"checkall",
					},
				}
			},
			{
				"mp_potential_settings",
				new string[][]
				{
					new string[] {
						"maxrot",
						"rotstep",
						"ahead",
						"onspot",
					},
				}
			},
			{
				"mp_potential_step_object",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"stepsize",
						"obj",
					},
				}
			},
			{
				"mp_potential_step",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"stepsize",
						"checkall",
					},
				}
			},
			{
				"network_create_server",
				new string[][]
				{
					new string[] {
						"type",
						"port",
						"max_client",
					},
				}
			},
			{
				"network_create_socket",
				new string[][]
				{
					new string[] {
						"type",
					},
				}
			},
			{
				"network_connect",
				new string[][]
				{
					new string[] {
						"socket",
						"url",
						"port",
					},
				}
			},
			{
				"network_connect_raw",
				new string[][]
				{
					new string[] {
						"socket",
						"url",
						"port",
					},
				}
			},
			{
				"network_resolve",
				new string[][]
				{
					new string[] {
						"url",
					},
				}
			},
			{
				"network_set_timeout",
				new string[][]
				{
					new string[] {
						"socket",
						"read_timeout",
						"write_timeout",
					},
				}
			},
			{
				"network_send_broadcast",
				new string[][]
				{
					new string[] {
						"socket",
						"port",
						"buffer",
						"size",
					},
				}
			},
			{
				"network_send_packet",
				new string[][]
				{
					new string[] {
						"socket",
						"buffer",
						"size",
					},
				}
			},
			{
				"network_send_raw",
				new string[][]
				{
					new string[] {
						"socket",
						"buffer",
						"size",
					},
				}
			},
			{
				"network_send_udp",
				new string[][]
				{
					new string[] {
						"socket",
						"url",
						"port",
						"buffer",
						"size",
					},
				}
			},
			{
				"network_destroy",
				new string[][]
				{
					new string[] {
						"socket",
					},
				}
			},
			{
				"object_add",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"object_delete",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"object_event_add",
				new string[][]
				{
					new string[] {
						"ind",
						"evtype",
						"evnumb",
						"codestr",
					},
				}
			},
			{
				"object_event_clear",
				new string[][]
				{
					new string[] {
						"ind",
						"evtype",
						"evnumb",
					},
				}
			},
			{
				"object_exists",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"object_get_depth",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"object_get_mask",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"object_get_name",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"object_get_parent",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"object_get_persistent",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"object_get_solid",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"object_get_sprite",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"object_get_visible",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"object_is_ancestor",
				new string[][]
				{
					new string[] {
						"ind1",
						"ind2",
					},
				}
			},
			{
				"object_set_depth",
				new string[][]
				{
					new string[] {
						"ind",
						"depth",
					},
				}
			},
			{
				"object_set_mask",
				new string[][]
				{
					new string[] {
						"ind",
						"spr",
					},
				}
			},
			{
				"object_set_parent",
				new string[][]
				{
					new string[] {
						"ind",
						"obj",
					},
				}
			},
			{
				"object_set_persistent",
				new string[][]
				{
					new string[] {
						"ind",
						"pers",
					},
				}
			},
			{
				"object_set_solid",
				new string[][]
				{
					new string[] {
						"ind",
						"solid",
					},
				}
			},
			{
				"object_set_sprite",
				new string[][]
				{
					new string[] {
						"ind",
						"spr",
					},
				}
			},
			{
				"object_set_visible",
				new string[][]
				{
					new string[] {
						"ind",
						"vis",
					},
				}
			},
			{
				"ord",
				new string[][]
				{
					new string[] {
						"str",
					},
				}
			},
			{
				"os_is_paused",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"os_is_network_connected",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"os_lock_orientation",
				new string[][]
				{
					new string[] {
						"enable",
					},
				}
			},
			{
				"os_get_language",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"os_get_config",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"os_powersave_enable",
				new string[][]
				{
					new string[] {
						"enable",
					},
				}
			},
			{
				"parameter_count",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"parameter_string",
				new string[][]
				{
					new string[] {
						"n",
					},
				}
			},
			{
				"part_attractor_clear",
				new string[][]
				{
					new string[] {
						"ps",
						"ind",
					},
				}
			},
			{
				"part_attractor_create",
				new string[][]
				{
					new string[] {
						"ps",
					},
				}
			},
			{
				"part_attractor_destroy_all",
				new string[][]
				{
					new string[] {
						"ps",
					},
				}
			},
			{
				"part_attractor_destroy",
				new string[][]
				{
					new string[] {
						"ps",
						"ind",
					},
				}
			},
			{
				"part_attractor_exists",
				new string[][]
				{
					new string[] {
						"ps",
						"ind",
					},
				}
			},
			{
				"part_attractor_force",
				new string[][]
				{
					new string[] {
						"ps",
						"ind",
						"force",
						"dist",
						"kind",
						"aditive",
					},
				}
			},
			{
				"part_attractor_position",
				new string[][]
				{
					new string[] {
						"ps",
						"ind",
						"x",
						"y",
					},
				}
			},
			{
				"part_changer_clear",
				new string[][]
				{
					new string[] {
						"ps",
						"ind",
					},
				}
			},
			{
				"part_changer_create",
				new string[][]
				{
					new string[] {
						"ps",
					},
				}
			},
			{
				"part_changer_destroy_all",
				new string[][]
				{
					new string[] {
						"ps",
					},
				}
			},
			{
				"part_changer_destroy",
				new string[][]
				{
					new string[] {
						"ps",
						"ind",
					},
				}
			},
			{
				"part_changer_exists",
				new string[][]
				{
					new string[] {
						"ps",
						"ind",
					},
				}
			},
			{
				"part_changer_kind",
				new string[][]
				{
					new string[] {
						"ps",
						"ind",
						"kind",
					},
				}
			},
			{
				"part_changer_region",
				new string[][]
				{
					new string[] {
						"ps",
						"ind",
						"xmin",
						"xmax",
						"ymin",
						"ymax",
						"shape",
					},
				}
			},
			{
				"part_changer_types",
				new string[][]
				{
					new string[] {
						"ps",
						"ind",
						"parttype1",
						"parttype2",
					},
				}
			},
			{
				"part_deflector_clear",
				new string[][]
				{
					new string[] {
						"ps",
						"ind",
					},
				}
			},
			{
				"part_deflector_create",
				new string[][]
				{
					new string[] {
						"ps",
					},
				}
			},
			{
				"part_deflector_destroy_all",
				new string[][]
				{
					new string[] {
						"ps",
					},
				}
			},
			{
				"part_deflector_destroy",
				new string[][]
				{
					new string[] {
						"ps",
						"ind",
					},
				}
			},
			{
				"part_deflector_exists",
				new string[][]
				{
					new string[] {
						"ps",
						"ind",
					},
				}
			},
			{
				"part_deflector_friction",
				new string[][]
				{
					new string[] {
						"ps",
						"ind",
						"friction",
					},
				}
			},
			{
				"part_deflector_kind",
				new string[][]
				{
					new string[] {
						"ps",
						"ind",
						"kind",
					},
				}
			},
			{
				"part_deflector_region",
				new string[][]
				{
					new string[] {
						"ps",
						"ind",
						"xmin",
						"xmax",
						"ymin",
						"ymax",
					},
				}
			},
			{
				"part_destroyer_clear",
				new string[][]
				{
					new string[] {
						"ps",
						"ind",
					},
				}
			},
			{
				"part_destroyer_create",
				new string[][]
				{
					new string[] {
						"ps",
					},
				}
			},
			{
				"part_destroyer_destroy_all",
				new string[][]
				{
					new string[] {
						"ps",
					},
				}
			},
			{
				"part_destroyer_destroy",
				new string[][]
				{
					new string[] {
						"ps",
						"ind",
					},
				}
			},
			{
				"part_destroyer_exists",
				new string[][]
				{
					new string[] {
						"ps",
						"ind",
					},
				}
			},
			{
				"part_destroyer_region",
				new string[][]
				{
					new string[] {
						"ps",
						"ind",
						"xmin",
						"xmax",
						"ymin",
						"ymax",
						"shape",
					},
				}
			},
			{
				"part_emitter_burst",
				new string[][]
				{
					new string[] {
						"ps",
						"ind",
						"parttype",
						"number",
					},
				}
			},
			{
				"part_emitter_clear",
				new string[][]
				{
					new string[] {
						"ps",
						"ind",
					},
				}
			},
			{
				"part_emitter_create",
				new string[][]
				{
					new string[] {
						"ps",
					},
				}
			},
			{
				"part_emitter_destroy_all",
				new string[][]
				{
					new string[] {
						"ps",
					},
				}
			},
			{
				"part_emitter_destroy",
				new string[][]
				{
					new string[] {
						"ps",
						"ind",
					},
				}
			},
			{
				"part_emitter_exists",
				new string[][]
				{
					new string[] {
						"ps",
						"ind",
					},
				}
			},
			{
				"part_emitter_region",
				new string[][]
				{
					new string[] {
						"ps",
						"ind",
						"xmin",
						"xmax",
						"ymin",
						"ymax",
						"shape",
						"distribution",
					},
				}
			},
			{
				"part_emitter_stream",
				new string[][]
				{
					new string[] {
						"ps",
						"ind",
						"parttype",
						"number",
					},
				}
			},
			{
				"part_particles_clear",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"part_particles_count",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"part_particles_create_color",
				new string[][]
				{
					new string[] {
						"ind",
						"x",
						"y",
						"parttype",
						"color",
						"number",
					},
				}
			},
			{
				"part_particles_create",
				new string[][]
				{
					new string[] {
						"ind",
						"x",
						"y",
						"parttype",
						"number",
					},
				}
			},
			{
				"part_system_automatic_draw",
				new string[][]
				{
					new string[] {
						"ind",
						"automatic",
					},
				}
			},
			{
				"part_system_automatic_update",
				new string[][]
				{
					new string[] {
						"ind",
						"automatic",
					},
				}
			},
			{
				"part_system_clear",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"part_system_create",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"part_system_depth Sets th",
				new string[][]
				{
					new string[] {
						"ind",
						"depth Sets th",
					},
				}
			},
			{
				"part_system_destroy",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"part_system_drawit",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"part_system_draw_order",
				new string[][]
				{
					new string[] {
						"ind",
						"oldtonew",
					},
				}
			},
			{
				"part_system_exists",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"part_system_position",
				new string[][]
				{
					new string[] {
						"ind",
						"x",
						"y",
					},
				}
			},
			{
				"part_system_update",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"part_type_alpha1",
				new string[][]
				{
					new string[] {
						"ind",
						"alpha1",
					},
				}
			},
			{
				"part_type_alpha2",
				new string[][]
				{
					new string[] {
						"ind",
						"alpha1",
						"alpha2",
					},
				}
			},
			{
				"part_type_alpha3",
				new string[][]
				{
					new string[] {
						"ind",
						"alpha1",
						"alpha2",
						"alpha3",
					},
				}
			},
			{
				"part_type_blend",
				new string[][]
				{
					new string[] {
						"ind",
						"additive",
					},
				}
			},
			{
				"part_type_clear",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"part_type_color1",
				new string[][]
				{
					new string[] {
						"ind",
						"color1",
					},
				}
			},
			{
				"part_type_color2",
				new string[][]
				{
					new string[] {
						"ind",
						"color1",
						"color2",
					},
				}
			},
			{
				"part_type_color3",
				new string[][]
				{
					new string[] {
						"ind",
						"color1",
						"color2",
						"color3",
					},
				}
			},
			{
				"part_type_color_hsv",
				new string[][]
				{
					new string[] {
						"ind",
						"hmin",
						"hmax",
						"smin",
						"smax",
						"vmin",
						"vmax",
					},
				}
			},
			{
				"part_type_color_mix",
				new string[][]
				{
					new string[] {
						"ind",
						"color1",
						"color2",
					},
				}
			},
			{
				"part_type_color_rgb",
				new string[][]
				{
					new string[] {
						"ind",
						"rmin",
						"rmax",
						"gmin",
						"gmax",
						"bmin",
						"bmax",
					},
				}
			},
			{
				"part_type_create",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"part_type_death",
				new string[][]
				{
					new string[] {
						"ind",
						"death_number",
						"death_type",
					},
				}
			},
			{
				"part_type_destroy",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"part_type_direction",
				new string[][]
				{
					new string[] {
						"ind",
						"dir_min",
						"dir_max",
						"dir_incr",
						"dir_wiggle",
					},
				}
			},
			{
				"part_type_exists",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"part_type_gravity",
				new string[][]
				{
					new string[] {
						"ind",
						"grav_amount",
						"grav_dir",
					},
				}
			},
			{
				"part_type_life",
				new string[][]
				{
					new string[] {
						"ind",
						"life_min",
						"life_max",
					},
				}
			},
			{
				"part_type_orientation",
				new string[][]
				{
					new string[] {
						"ind",
						"ang_min",
						"ang_max",
						"ang_incr",
						"ang_wiggle",
						"ang_relative",
					},
				}
			},
			{
				"part_type_scale",
				new string[][]
				{
					new string[] {
						"ind",
						"xscale",
						"yscale",
					},
				}
			},
			{
				"part_type_shape",
				new string[][]
				{
					new string[] {
						"ind",
						"shape",
					},
				}
			},
			{
				"part_type_size",
				new string[][]
				{
					new string[] {
						"ind",
						"size_min",
						"size_max",
						"size_incr",
						"size_wiggle",
					},
				}
			},
			{
				"part_type_speed",
				new string[][]
				{
					new string[] {
						"ind",
						"speed_min",
						"speed_max",
						"speed_incr",
						"speed_wiggle",
					},
				}
			},
			{
				"part_type_sprite",
				new string[][]
				{
					new string[] {
						"ind",
						"sprite",
						"animat",
						"stretch",
						"random",
					},
				}
			},
			{
				"part_type_step",
				new string[][]
				{
					new string[] {
						"ind",
						"step_number",
						"step_type",
					},
				}
			},
			{
				"path_add_point",
				new string[][]
				{
					new string[] {
						"ind",
						"x",
						"y",
						"speed",
					},
				}
			},
			{
				"path_add",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"path_append",
				new string[][]
				{
					new string[] {
						"ind",
						"path",
					},
				}
			},
			{
				"path_assign",
				new string[][]
				{
					new string[] {
						"ind",
						"path",
					},
				}
			},
			{
				"path_change_point",
				new string[][]
				{
					new string[] {
						"ind",
						"n",
						"x",
						"y",
						"speed",
					},
				}
			},
			{
				"path_clear_points",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"path_delete_point",
				new string[][]
				{
					new string[] {
						"ind",
						"n",
					},
				}
			},
			{
				"path_delete",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"path_duplicate",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"path_end",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"path_exists",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"path_flip",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"path_get_closed",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"path_get_kind",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"path_get_length",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"path_get_name",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"path_get_number",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"path_get_point_speed",
				new string[][]
				{
					new string[] {
						"ind",
						"n",
					},
				}
			},
			{
				"path_get_point_x",
				new string[][]
				{
					new string[] {
						"ind",
						"n",
					},
				}
			},
			{
				"path_get_point_y",
				new string[][]
				{
					new string[] {
						"ind",
						"n",
					},
				}
			},
			{
				"path_get_precision",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"path_get_speed",
				new string[][]
				{
					new string[] {
						"ind",
						"pos",
					},
				}
			},
			{
				"path_get_x",
				new string[][]
				{
					new string[] {
						"ind",
						"pos",
					},
				}
			},
			{
				"path_get_y",
				new string[][]
				{
					new string[] {
						"ind",
						"pos",
					},
				}
			},
			{
				"path_insert_point",
				new string[][]
				{
					new string[] {
						"ind",
						"n",
						"x",
						"y",
						"speed",
					},
				}
			},
			{
				"path_mirror",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"path_reverse",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"path_rotate",
				new string[][]
				{
					new string[] {
						"ind",
						"angle",
					},
				}
			},
			{
				"path_scale",
				new string[][]
				{
					new string[] {
						"ind",
						"xscale",
						"yscale",
					},
				}
			},
			{
				"path_set_closed",
				new string[][]
				{
					new string[] {
						"ind",
						"closed",
					},
				}
			},
			{
				"path_set_kind",
				new string[][]
				{
					new string[] {
						"ind",
						"val",
					},
				}
			},
			{
				"path_set_precision",
				new string[][]
				{
					new string[] {
						"ind",
						"prec",
					},
				}
			},
			{
				"path_shift",
				new string[][]
				{
					new string[] {
						"ind",
						"xshift",
						"yshift",
					},
				}
			},
			{
				"path_start",
				new string[][]
				{
					new string[] {
						"path",
						"speed",
						"endaction",
						"absolute",
					},
				}
			},
			{
				"physics_apply_force",
				new string[][]
				{
					new string[] {
						"xpos",
						"ypos",
						"xforce",
						"yforce",
					},
				}
			},
			{
				"physics_apply_impulse",
				new string[][]
				{
					new string[] {
						"xpos",
						"ypos",
						"ximpulse",
						"yimpulse",
					},
				}
			},
			{
				"physics_apply_local_force",
				new string[][]
				{
					new string[] {
						"xlocal",
						"ylocal",
						"xforce",
						"yforce",
					},
				}
			},
			{
				"physics_apply_local_impulse",
				new string[][]
				{
					new string[] {
						"xpos",
						"ypos",
						"ximpulse",
						"yimpulse",
					},
				}
			},
			{
				"physics_apply_torque",
				new string[][]
				{
					new string[] {
						"torque",
					},
				}
			},
			{
				"physics_fixture_create",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"physics_fixture_bind",
				new string[][]
				{
					new string[] {
						"fixture",
						"target",
					},
				}
			},
			{
				"physics_fixture_set_collision_group",
				new string[][]
				{
					new string[] {
						"fixture",
						"group",
					},
				}
			},
			{
				"physics_fixture_delete",
				new string[][]
				{
					new string[] {
						"fixture",
					},
				}
			},
			{
				"physics_fixture_set_box_shape",
				new string[][]
				{
					new string[] {
						"fixture",
						"halfWidth",
						"halfHeight",
					},
				}
			},
			{
				"physics_fixture_set_circle_shape",
				new string[][]
				{
					new string[] {
						"fixture",
						"radius",
					},
				}
			},
			{
				"physics_fixture_set_edge_shape",
				new string[][]
				{
					new string[] {
						"fixture",
						"x1",
						"y1",
						"x2",
						"y2",
					},
				}
			},
			{
				"physics_fixture_set_polygon_shape",
				new string[][]
				{
					new string[] {
						"fixture",
					},
				}
			},
			{
				"physics_fixture_add_point",
				new string[][]
				{
					new string[] {
						"fixture",
						"x",
						"y",
					},
				}
			},
			{
				"physics_fixture_set_density",
				new string[][]
				{
					new string[] {
						"fixture",
						"density",
					},
				}
			},
			{
				"physics_fixture_set_friction",
				new string[][]
				{
					new string[] {
						"fixture",
						"friction",
					},
				}
			},
			{
				"physics_fixture_set_linear_damping",
				new string[][]
				{
					new string[] {
						"fixture",
						"damping",
					},
				}
			},
			{
				"physics_fixture_set_angular_damping",
				new string[][]
				{
					new string[] {
						"fixture",
						"damping",
					},
				}
			},
			{
				"physics_fixture_set_restitution",
				new string[][]
				{
					new string[] {
						"fixture",
						"restitution",
					},
				}
			},
			{
				"physics_fixture_set_sensor",
				new string[][]
				{
					new string[] {
						"fixture",
						"state",
					},
				}
			},
			{
				"physics_fixture_set_kinematic",
				new string[][]
				{
					new string[] {
						"fixture",
					},
				}
			},
			{
				"physics_fixture_set_awake",
				new string[][]
				{
					new string[] {
						"fixture",
						"state",
					},
				}
			},
			{
				"physics_joint_distance_create",
				new string[][]
				{
					new string[] {
						"inst1",
						"inst2",
						"w_anchor1_x",
						"w_anchor1_y",
						"w_anchor2_x",
						"w_anchor2_y",
						"col",
					},
				}
			},
			{
				"physics_joint_revolute_create",
				new string[][]
				{
					new string[] {
						"inst1",
						"inst2",
						"w_anchor_x",
						"w_anchor_y",
						"ang_min_limt",
						"ang_max_limit",
						"ang_limit",
						"max_motor_torque",
						"motor_speed",
						"motor",
						"col",
					},
				}
			},
			{
				"physics_joint_prismatic_create",
				new string[][]
				{
					new string[] {
						"inst1",
						"inst2",
						"w_anchor_x",
						"w_anchor_y",
						"w_axis_x",
						"lower_trans_limit",
						"upper_trans_limit",
						"limit",
						"max_motor_force",
						"motor_speed",
						"motor",
						"col",
					},
				}
			},
			{
				"physics_joint_pulley_create",
				new string[][]
				{
					new string[] {
						"inst1",
						"inst2",
						"w_anchor1_x",
						"w_anchor1_y",
						"w_anchor2_x",
						"w_anchor2_y",
						"l_anchor1_x",
						"l_anchor1_y",
						"l_anchor2_x",
						"l_anchor2_y",
						"ratio",
						"max_len1",
						"max_len2",
						"col",
					},
				}
			},
			{
				"physics_joint_gear_create",
				new string[][]
				{
					new string[] {
						"inst1",
						"inst2",
						"joint_1",
						"joint_2",
						"ratio",
					},
				}
			},
			{
				"physics_joint_delete",
				new string[][]
				{
					new string[] {
						"joint",
					},
				}
			},
			{
				"physics_joint_enable_motor",
				new string[][]
				{
					new string[] {
						"joint",
						"motor",
					},
				}
			},
			{
				"physics_joint_get_value",
				new string[][]
				{
					new string[] {
						"joint",
						"field",
					},
				}
			},
			{
				"physics_joint_set_value",
				new string[][]
				{
					new string[] {
						"joint",
						"field",
						"value",
					},
				}
			},
			{
				"physics_test_overlap",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"angle",
						"object",
					},
				}
			},
			{
				"physics_mass_properties",
				new string[][]
				{
					new string[] {
						"mass",
						"local_center_x",
						"local_center_y",
						"inertia",
					},
				}
			},
			{
				"place_empty",
				new string[][]
				{
					new string[] {
						"x",
						"y",
					},
				}
			},
			{
				"place_free",
				new string[][]
				{
					new string[] {
						"x",
						"y",
					},
				}
			},
			{
				"place_meeting",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"obj",
					},
				}
			},
			{
				"place_snapped",
				new string[][]
				{
					new string[] {
						"hsnap",
						"vsnap",
					},
				}
			},
			{
				"point_direction",
				new string[][]
				{
					new string[] {
						"x1",
						"y1",
						"x2",
						"y2",
					},
				}
			},
			{
				"point_distance",
				new string[][]
				{
					new string[] {
						"x1",
						"y1",
						"x2",
						"y2",
					},
				}
			},
			{
				"point_distance_3d",
				new string[][]
				{
					new string[] {
						"x1",
						"y1",
						"z1",
						"x2",
						"y2",
						"z2",
					},
				}
			},
			{
				"point_in_rectangle",
				new string[][]
				{
					new string[] {
						"px",
						"py",
						"x1",
						"y1",
						"x2",
						"y2",
					},
				}
			},
			{
				"point_in_triangle",
				new string[][]
				{
					new string[] {
						"px",
						"py",
						"x1",
						"y1",
						"x2",
						"y2",
						"x3",
						"y3",
					},
				}
			},
			{
				"point_in_circle",
				new string[][]
				{
					new string[] {
						"px",
						"py",
						"cx",
						"cy",
						"rad",
					},
				}
			},
			{
				"position_change",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"obj",
						"perf",
					},
				}
			},
			{
				"position_destroy",
				new string[][]
				{
					new string[] {
						"x",
						"y",
					},
				}
			},
			{
				"position_empty",
				new string[][]
				{
					new string[] {
						"x",
						"y",
					},
				}
			},
			{
				"position_meeting",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"obj",
					},
				}
			},
			{
				"power",
				new string[][]
				{
					new string[] {
						"x",
						"n",
					},
				}
			},
			{
				"radtodeg",
				new string[][]
				{
					new string[] {
						"x",
					},
				}
			},
			{
				"randomize",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"random_get_seed",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"random_set_seed",
				new string[][]
				{
					new string[] {
						"seed",
					},
				}
			},
			{
				"random",
				new string[][]
				{
					new string[] {
						"x",
					},
				}
			},
			{
				"random_range",
				new string[][]
				{
					new string[] {
						"n1",
						"n2",
					},
				}
			},
			{
				"real",
				new string[][]
				{
					new string[] {
						"str",
					},
				}
			},
			{
				"rectangle_in_rectangle",
				new string[][]
				{
					new string[] {
						"sx1",
						"sy1",
						"sx2",
						"sy2",
						"dx1",
						"dy1",
						"dx2",
						"dy2",
					},
				}
			},
			{
				"rectangle_in_triangle",
				new string[][]
				{
					new string[] {
						"sx1",
						"sy1",
						"sx2",
						"sy2",
						"dx1",
						"dy1",
						"dx2",
						"dy2",
						"dx3",
						"dy3",
					},
				}
			},
			{
				"rectangle_in_circle",
				new string[][]
				{
					new string[] {
						"x1",
						"y1",
						"x2",
						"y2",
						"cx",
						"cy",
						"rad",
					},
				}
			},
			{
				"registry_exists_ext",
				new string[][]
				{
					new string[] {
						"key",
						"name",
					},
				}
			},
			{
				"registry_exists",
				new string[][]
				{
					new string[] {
						"name",
					},
				}
			},
			{
				"registry_read_real_ext",
				new string[][]
				{
					new string[] {
						"key",
						"name",
					},
				}
			},
			{
				"registry_read_real",
				new string[][]
				{
					new string[] {
						"name",
					},
				}
			},
			{
				"registry_read_string_ext",
				new string[][]
				{
					new string[] {
						"key",
						"name",
					},
				}
			},
			{
				"registry_read_string",
				new string[][]
				{
					new string[] {
						"name",
					},
				}
			},
			{
				"registry_set_root",
				new string[][]
				{
					new string[] {
						"root",
					},
				}
			},
			{
				"registry_write_real_ext",
				new string[][]
				{
					new string[] {
						"key",
						"name",
						"x",
					},
				}
			},
			{
				"registry_write_real",
				new string[][]
				{
					new string[] {
						"name",
						"x",
					},
				}
			},
			{
				"registry_write_string_ext",
				new string[][]
				{
					new string[] {
						"key",
						"name",
						"str",
					},
				}
			},
			{
				"registry_write_string",
				new string[][]
				{
					new string[] {
						"name",
						"str",
					},
				}
			},
			{
				"room_add",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"room_assign",
				new string[][]
				{
					new string[] {
						"ind",
						"room",
					},
				}
			},
			{
				"room_duplicate",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"room_exists",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"room_get_name",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"room_goto_next",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"room_goto_previous",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"room_goto",
				new string[][]
				{
					new string[] {
						"numb",
					},
				}
			},
			{
				"room_instance_add",
				new string[][]
				{
					new string[] {
						"ind",
						"x",
						"y",
						"obj",
					},
				}
			},
			{
				"room_instance_clear",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"room_next",
				new string[][]
				{
					new string[] {
						"numb",
					},
				}
			},
			{
				"room_previous",
				new string[][]
				{
					new string[] {
						"numb",
					},
				}
			},
			{
				"room_restart",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"room_set_background_color",
				new string[][]
				{
					new string[] {
						"ind",
						"col",
						"show",
					},
				}
			},
			{
				"room_set_background",
				new string[][]
				{
					new string[] {
						"ind",
						"bind",
						"vis",
						"fore",
						"back",
						"x",
						"y",
						"htiled",
						"vtiled",
						"hspeed",
						"vspeed",
						"alpha",
					},
				}
			},
			{
				"room_set_caption",
				new string[][]
				{
					new string[] {
						"ind",
						"str",
					},
				}
			},
			{
				"room_set_code",
				new string[][]
				{
					new string[] {
						"ind",
						"str",
					},
				}
			},
			{
				"room_set_height",
				new string[][]
				{
					new string[] {
						"ind",
						"h",
					},
				}
			},
			{
				"room_set_persistent",
				new string[][]
				{
					new string[] {
						"ind",
						"val",
					},
				}
			},
			{
				"room_set_view_enabled",
				new string[][]
				{
					new string[] {
						"ind",
						"val",
					},
				}
			},
			{
				"room_set_view",
				new string[][]
				{
					new string[] {
						"ind",
						"vind",
						"vis",
						"xview",
						"yview",
						"wview",
						"hview",
						"xport",
						"yport",
						"wport",
						"hport",
						"hborder",
						"vborder",
						"hspeed",
						"vspeed",
						"obj",
					},
				}
			},
			{
				"room_set_width",
				new string[][]
				{
					new string[] {
						"ind",
						"w",
					},
				}
			},
			{
				"room_tile_add_ext",
				new string[][]
				{
					new string[] {
						"ind",
						"back",
						"left",
						"top",
						"width",
						"height",
						"x",
						"y",
						"depth",
						"xscale",
						"yscale",
						"alpha",
					},
				}
			},
			{
				"room_tile_add",
				new string[][]
				{
					new string[] {
						"ind",
						"back",
						"left",
						"top",
						"width",
						"height",
						"x",
						"y",
						"depth",
					},
				}
			},
			{
				"room_tile_clear",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"round",
				new string[][]
				{
					new string[] {
						"x",
					},
				}
			},
			{
				"screen_redraw",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"screen_refresh",
				new string[][]
				{
					new string[] {
						"",
					},
				}
			},
			{
				"screen_save_part",
				new string[][]
				{
					new string[] {
						"fname",
						"x",
						"y",
						"w",
						"h",
					},
				}
			},
			{
				"screen_save",
				new string[][]
				{
					new string[] {
						"fname",
					},
				}
			},
			{
				"screen_wait_vsync",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"script_execute",
				new string[][]
				{
					new string[] {
						"scr",
						"arg0",
						"arg1",
						"...",
					},
				}
			},
			{
				"script_exists",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"script_get_name",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"script_get_text",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"set_automatic_draw",
				new string[][]
				{
					new string[] {
						"value",
					},
				}
			},
			{
				"set_program_priority",
				new string[][]
				{
					new string[] {
						"priority",
					},
				}
			},
			{
				"set_synchronization",
				new string[][]
				{
					new string[] {
						"value",
					},
				}
			},
			{
				"sha1_string_utf8",
				new string[][]
				{
					new string[] {
						"string",
					},
				}
			},
			{
				"sha1_string_unicode",
				new string[][]
				{
					new string[] {
						"string",
					},
				}
			},
			{
				"sha1_file",
				new string[][]
				{
					new string[] {
						"filename",
					},
				}
			},
			{
				"shader_set",
				new string[][]
				{
					new string[] {
						"shader",
					},
				}
			},
			{
				"shader_get_uniform",
				new string[][]
				{
					new string[] {
						"shader",
						"uniform",
					},
				}
			},
			{
				"shader_get_sampler_index",
				new string[][]
				{
					new string[] {
						"shader",
						"uniform",
					},
				}
			},
			{
				"shader_set_uniform_f",
				new string[][]
				{
					new string[] {
						"handle",
						"value1",
						"value2 - value4",
					},
				}
			},
			{
				"shader_set_uniform_f_array",
				new string[][]
				{
					new string[] {
						"handle",
						"array",
					},
				}
			},
			{
				"shader_set_uniform_i",
				new string[][]
				{
					new string[] {
						"handle",
						"value1",
						"value2 - value4",
					},
				}
			},
			{
				"shader_set_uniform_i_array",
				new string[][]
				{
					new string[] {
						"handle",
						"array",
					},
				}
			},
			{
				"shader_set_uniform_matrix",
				new string[][]
				{
					new string[] {
						"handle",
					},
				}
			},
			{
				"shader_set_uniform_matrix_array",
				new string[][]
				{
					new string[] {
						"handle",
						"array",
					},
				}
			},
			{
				"shader_reset",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"shader_is_compiled",
				new string[][]
				{
					new string[] {
						"shader",
					},
				}
			},
			{
				"shaders_are_supported",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"shader_enable_corner_id",
				new string[][]
				{
					new string[] {
						"enable",
					},
				}
			},
			{
				"show_debug_message",
				new string[][]
				{
					new string[] {
						"str",
					},
				}
			},
			{
				"show_error",
				new string[][]
				{
					new string[] {
						"str",
						"abort",
					},
				}
			},
			{
				"show_menu_pos",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"str",
						"def",
					},
				}
			},
			{
				"show_menu",
				new string[][]
				{
					new string[] {
						"str",
						"def",
					},
				}
			},
			{
				"show_message_ext",
				new string[][]
				{
					new string[] {
						"str",
						"but1",
						"but2",
						"but3",
					},
				}
			},
			{
				"show_message",
				new string[][]
				{
					new string[] {
						"str",
					},
				}
			},
			{
				"show_message_async",
				new string[][]
				{
					new string[] {
						"str",
					},
				}
			},
			{
				"show_question",
				new string[][]
				{
					new string[] {
						"str",
					},
				}
			},
			{
				"show_question_async",
				new string[][]
				{
					new string[] {
						"str",
					},
				}
			},
			{
				"sign",
				new string[][]
				{
					new string[] {
						"x",
					},
				}
			},
			{
				"sin",
				new string[][]
				{
					new string[] {
						"x",
					},
				}
			},
			{
				"sleep",
				new string[][]
				{
					new string[] {
						"numb",
					},
				}
			},
			{
				"sound_3d_set_sound_cone",
				new string[][]
				{
					new string[] {
						"snd",
						"x",
						"y",
						"z",
						"anglein",
						"angleout",
						"voloutside",
					},
				}
			},
			{
				"sound_3d_set_sound_distance",
				new string[][]
				{
					new string[] {
						"snd",
						"mindist",
						"maxdist",
					},
				}
			},
			{
				"sound_3d_set_sound_position",
				new string[][]
				{
					new string[] {
						"snd",
						"x",
						"y",
						"z",
					},
				}
			},
			{
				"sound_3d_set_sound_velocity",
				new string[][]
				{
					new string[] {
						"snd",
						"x",
						"y",
						"z",
					},
				}
			},
			{
				"sound_add",
				new string[][]
				{
					new string[] {
						"fname",
						"kind",
						"preload",
					},
				}
			},
			{
				"sound_background_tempo",
				new string[][]
				{
					new string[] {
						"factor",
					},
				}
			},
			{
				"sound_delete",
				new string[][]
				{
					new string[] {
						"index",
					},
				}
			},
			{
				"sound_discard",
				new string[][]
				{
					new string[] {
						"index",
					},
				}
			},
			{
				"sound_effect_chorus",
				new string[][]
				{
					new string[] {
						"snd",
						"wetdry",
						"depth",
						"feedback",
						"frequency",
						"wave",
						"delay",
						"phase",
					},
				}
			},
			{
				"sound_effect_compressor",
				new string[][]
				{
					new string[] {
						"snd",
						"gain",
						"attack",
						"release",
						"threshold",
						"ratio",
						"delay",
					},
				}
			},
			{
				"sound_effect_echo",
				new string[][]
				{
					new string[] {
						"snd",
						"wetdry",
						"feedback",
						"leftdelay",
						"rightdelay",
						"pandelay",
					},
				}
			},
			{
				"sound_effect_equalizer",
				new string[][]
				{
					new string[] {
						"snd",
						"center",
						"bandwidth",
						"gain",
					},
				}
			},
			{
				"sound_effect_flanger",
				new string[][]
				{
					new string[] {
						"snd",
						"wetdry",
						"depth",
						"feedback",
						"frequency",
						"wave",
						"delay",
						"phase",
					},
				}
			},
			{
				"sound_effect_gargle",
				new string[][]
				{
					new string[] {
						"snd",
						"rate",
						"wave",
					},
				}
			},
			{
				"sound_effect_reverb",
				new string[][]
				{
					new string[] {
						"snd",
						"gain",
						"mix",
						"time",
						"ratio",
					},
				}
			},
			{
				"sound_effect_set",
				new string[][]
				{
					new string[] {
						"snd",
						"effect",
					},
				}
			},
			{
				"sound_exists",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"sound_fade",
				new string[][]
				{
					new string[] {
						"index",
						"value",
						"time",
					},
				}
			},
			{
				"sound_get_kind",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"sound_get_name",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"sound_get_preload",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"sound_global_volume",
				new string[][]
				{
					new string[] {
						"value",
					},
				}
			},
			{
				"sound_isplaying",
				new string[][]
				{
					new string[] {
						"index",
					},
				}
			},
			{
				"sound_loop",
				new string[][]
				{
					new string[] {
						"index",
					},
				}
			},
			{
				"sound_pan",
				new string[][]
				{
					new string[] {
						"index",
						"value",
					},
				}
			},
			{
				"sound_play",
				new string[][]
				{
					new string[] {
						"index",
					},
				}
			},
			{
				"sound_replace",
				new string[][]
				{
					new string[] {
						"index",
						"fname",
						"kind",
						"preload",
					},
				}
			},
			{
				"sound_restore",
				new string[][]
				{
					new string[] {
						"index",
					},
				}
			},
			{
				"sound_set_search_directory",
				new string[][]
				{
					new string[] {
						"dir",
					},
				}
			},
			{
				"sound_stop_all",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"sound_stop",
				new string[][]
				{
					new string[] {
						"index",
					},
				}
			},
			{
				"sound_volume",
				new string[][]
				{
					new string[] {
						"index",
						"value",
					},
				}
			},
			{
				"splash_show_image",
				new string[][]
				{
					new string[] {
						"fname",
						"delay",
					},
				}
			},
			{
				"splash_show_text",
				new string[][]
				{
					new string[] {
						"fname",
						"delay",
					},
				}
			},
			{
				"splash_show_video",
				new string[][]
				{
					new string[] {
						"fname",
						"loop",
					},
				}
			},
			{
				"sprite_add_alpha",
				new string[][]
				{
					new string[] {
						"fname",
						"imgnumb",
						"precise",
						"preload",
						"xorig",
						"yorig",
					},
				}
			},
			{
				"sprite_add_from_screen",
				new string[][]
				{
					new string[] {
						"ind",
						"x",
						"y",
						"w",
						"h",
					},
				}
			},
			{
				"sprite_add_from_surface",
				new string[][]
				{
					new string[] {
						"ind",
						"id",
						"x",
						"y",
						"w",
						"h",
					},
				}
			},
			{
				"sprite_add",
				new string[][]
				{
					new string[] {
						"fname",
						"imgnumb",
						"transparent",
						"smooth",
						"xorig",
						"yorig",
					},
					new string[] {
						"fname",
						"imgnumb",
						"precise",
						"transparent",
						"smooth",
						"preload",
						"xorig",
						"yorig",
					},
				}
			},
			{
				"sprite_assign",
				new string[][]
				{
					new string[] {
						"ind",
						"spr",
					},
				}
			},
			{
				"sprite_create_from_screen",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"w",
						"h",
						"precise",
						"transparent",
						"smooth",
						"xorig",
						"yorig",
					},
					new string[] {
						"x",
						"y",
						"w",
						"h",
						"precise",
						"transparent",
						"smooth",
						"preload",
						"xorig",
						"yorig",
					},
				}
			},
			{
				"sprite_create_from_surface",
				new string[][]
				{
					new string[] {
						"id",
						"x",
						"y",
						"w",
						"h",
						"precise",
						"transparent",
						"smooth",
						"xorig",
						"yorig",
					},
					new string[] {
						"id",
						"x",
						"y",
						"w",
						"h",
						"precise",
						"transparent",
						"smooth",
						"preload",
						"xorig",
						"yorig",
					},
				}
			},
			{
				"sprite_delete",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"sprite_duplicate",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"sprite_exists",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"sprite_get_bbox_bottom",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"sprite_get_bbox_left",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"sprite_get_bbox_mode",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"sprite_get_bbox_right",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"sprite_get_bbox_top",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"sprite_get_height",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"sprite_get_name",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"sprite_get_number",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"sprite_get_precise",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"sprite_get_preload",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"sprite_get_smooth",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"sprite_get_texture",
				new string[][]
				{
					new string[] {
						"spr",
						"subimg",
					},
				}
			},
			{
				"sprite_get_uvs",
				new string[][]
				{
					new string[] {
						"spr",
						"subimg",
					},
				}
			},
			{
				"sprite_get_transparent",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"sprite_get_width",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"sprite_get_xoffset",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"sprite_get_yoffset",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"sprite_merge",
				new string[][]
				{
					new string[] {
						"ind1",
						"ind2",
					},
				}
			},
			{
				"sprite_replace_alpha",
				new string[][]
				{
					new string[] {
						"ind",
						"fname",
						"imgnumb",
						"precise",
						"preload",
						"xorig",
						"yorig",
					},
				}
			},
			{
				"sprite_replace",
				new string[][]
				{
					new string[] {
						"ind",
						"fname",
						"imgnumb",
						"precise",
						"transparent",
						"smooth",
						"xorig",
						"yorig",
					},
					new string[] {
						"ind",
						"fname",
						"imgnumb",
						"precise",
						"transparent",
						"smooth",
						"preload",
						"xorig",
						"yorig",
					},
				}
			},
			{
				"sprite_save",
				new string[][]
				{
					new string[] {
						"ind",
						"subimg",
						"fname",
					},
				}
			},
			{
				"sprite_set_alpha_from_sprite",
				new string[][]
				{
					new string[] {
						"ind",
						"spr",
					},
				}
			},
			{
				"sprite_set_bbox_mode",
				new string[][]
				{
					new string[] {
						"ind",
						"mode",
					},
				}
			},
			{
				"sprite_set_bbox",
				new string[][]
				{
					new string[] {
						"ind",
						"left",
						"top",
						"right",
						"bottom",
					},
				}
			},
			{
				"sprite_set_offset",
				new string[][]
				{
					new string[] {
						"ind",
						"xoff",
						"yoff",
					},
				}
			},
			{
				"sprite_set_precise",
				new string[][]
				{
					new string[] {
						"ind",
						"mode",
					},
				}
			},
			{
				"sqrt",
				new string[][]
				{
					new string[] {
						"x",
					},
				}
			},
			{
				"sqr",
				new string[][]
				{
					new string[] {
						"x",
					},
				}
			},
			{
				"steam_initialised",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"steam_stats_ready",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"steam_is_overlay_enabled",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"steam_get_persona_name",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"steam_get_user_steam_id",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"steam_is_user_logged_on",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"steam_activate_overlay",
				new string[][]
				{
					new string[] {
						"overlay",
					},
				}
			},
			{
				"steam_is_overlay_activated",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"steam_create_leaderboard",
				new string[][]
				{
					new string[] {
						"lb_name",
						"sort_method",
						"display_type",
					},
				}
			},
			{
				"steam_upload_score",
				new string[][]
				{
					new string[] {
						"lb_name",
						"score",
					},
				}
			},
			{
				"steam_download_scores",
				new string[][]
				{
					new string[] {
						"lb_name",
						"start_idx",
						"end_idx",
					},
				}
			},
			{
				"steam_download_scores_around_user",
				new string[][]
				{
					new string[] {
						"lb_name",
						"range_start",
						"range_end",
					},
				}
			},
			{
				"steam_download_friends_scores",
				new string[][]
				{
					new string[] {
						"lb_name",
					},
				}
			},
			{
				"steam_set_achievement",
				new string[][]
				{
					new string[] {
						"ach_name",
					},
				}
			},
			{
				"steam_get_achievement",
				new string[][]
				{
					new string[] {
						"ach_name",
					},
				}
			},
			{
				"steam_clear_achievement",
				new string[][]
				{
					new string[] {
						"ach_name",
					},
				}
			},
			{
				"steam_set_stat_int",
				new string[][]
				{
					new string[] {
						"stat_name",
						"value",
					},
				}
			},
			{
				"steam_set_stat_float",
				new string[][]
				{
					new string[] {
						"stat_name",
						"value",
					},
				}
			},
			{
				"steam_set_stat_avg_rate",
				new string[][]
				{
					new string[] {
						"stat_name",
						"session_count",
						"session_length",
					},
				}
			},
			{
				"steam_get_stat_int",
				new string[][]
				{
					new string[] {
						"stat_name",
					},
				}
			},
			{
				"steam_get_stat_float",
				new string[][]
				{
					new string[] {
						"stat_name",
					},
				}
			},
			{
				"steam_get_stat_avg_rate",
				new string[][]
				{
					new string[] {
						"stat_name",
					},
				}
			},
			{
				"steam_reset_all_stats",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"steam_reset_all_stats_achievements",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"steam_is_cloud_enabled_for_app",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"steam_is_cloud_enabled_for_account",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"steam_get_quota_total",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"steam_get_quota_free",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"steam_file_exists",
				new string[][]
				{
					new string[] {
						"filename",
					},
				}
			},
			{
				"steam_file_size",
				new string[][]
				{
					new string[] {
						"filename",
					},
				}
			},
			{
				"steam_file_persisted",
				new string[][]
				{
					new string[] {
						"filename",
					},
				}
			},
			{
				"steam_file_write",
				new string[][]
				{
					new string[] {
						"filename",
						"data",
						"size",
					},
				}
			},
			{
				"steam_file_write_file",
				new string[][]
				{
					new string[] {
						"steam_filename",
						"local_filename",
					},
				}
			},
			{
				"steam_file_read",
				new string[][]
				{
					new string[] {
						"filename",
					},
				}
			},
			{
				"steam_file_share",
				new string[][]
				{
					new string[] {
						"filename",
					},
				}
			},
			{
				"steam_file_delete",
				new string[][]
				{
					new string[] {
						"filename",
					},
				}
			},
			{
				"steam_publish_workshop_file",
				new string[][]
				{
					new string[] {
						"filename",
						"preview_image",
						"title",
						"description",
					},
				}
			},
			{
				"steam_is_screenshot_requested",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"steam_send_screenshot",
				new string[][]
				{
					new string[] {
						"filename",
						"width",
						"height",
					},
				}
			},
			{
				"steam_user_owns_dlc",
				new string[][]
				{
					new string[] {
						"dlc_id",
					},
				}
			},
			{
				"steam_user_installed_dlc",
				new string[][]
				{
					new string[] {
						"dlc_id",
					},
				}
			},
			{
				"string_byte_at",
				new string[][]
				{
					new string[] {
						"str",
						"index",
					},
				}
			},
			{
				"string_byte_length",
				new string[][]
				{
					new string[] {
						"str",
					},
				}
			},
			{
				"string_char_at",
				new string[][]
				{
					new string[] {
						"str",
						"index",
					},
				}
			},
			{
				"string_copy",
				new string[][]
				{
					new string[] {
						"str",
						"index",
						"count",
					},
				}
			},
			{
				"string_count",
				new string[][]
				{
					new string[] {
						"substr",
						"str",
					},
				}
			},
			{
				"string_delete",
				new string[][]
				{
					new string[] {
						"str",
						"index",
						"count",
					},
				}
			},
			{
				"string_digits",
				new string[][]
				{
					new string[] {
						"str",
					},
				}
			},
			{
				"string_format",
				new string[][]
				{
					new string[] {
						"val",
						"tot",
						"dec",
					},
				}
			},
			{
				"string_height_ext",
				new string[][]
				{
					new string[] {
						"string",
						"sep",
						"w",
					},
				}
			},
			{
				"string_height",
				new string[][]
				{
					new string[] {
						"string",
					},
				}
			},
			{
				"string_insert",
				new string[][]
				{
					new string[] {
						"substr",
						"str",
						"index",
					},
				}
			},
			{
				"string_length",
				new string[][]
				{
					new string[] {
						"str",
					},
				}
			},
			{
				"string_letters",
				new string[][]
				{
					new string[] {
						"str",
					},
				}
			},
			{
				"string_lower",
				new string[][]
				{
					new string[] {
						"str",
					},
				}
			},
			{
				"string_pos",
				new string[][]
				{
					new string[] {
						"substr",
						"str",
					},
				}
			},
			{
				"string_repeat",
				new string[][]
				{
					new string[] {
						"str",
						"count",
					},
				}
			},
			{
				"string_replace",
				new string[][]
				{
					new string[] {
						"str",
						"substr",
						"newstr",
					},
				}
			},
			{
				"string_replace_all",
				new string[][]
				{
					new string[] {
						"str",
						"substr",
						"newstr",
					},
				}
			},
			{
				"string_set_byte_at",
				new string[][]
				{
					new string[] {
						"str",
						"pos",
						"byte",
					},
				}
			},
			{
				"string_upper",
				new string[][]
				{
					new string[] {
						"str",
					},
				}
			},
			{
				"string_width_ext",
				new string[][]
				{
					new string[] {
						"string",
						"sep",
						"w",
					},
				}
			},
			{
				"string_width",
				new string[][]
				{
					new string[] {
						"string",
					},
				}
			},
			{
				"string",
				new string[][]
				{
					new string[] {
						"val",
					},
				}
			},
			{
				"surface_create",
				new string[][]
				{
					new string[] {
						"width",
						"height",
					},
				}
			},
			{
				"surface_copy_part",
				new string[][]
				{
					new string[] {
						"destination",
						"x",
						"y",
						"source",
						"xs",
						"ys",
						"ws",
						"hs",
					},
				}
			},
			{
				"surface_copy",
				new string[][]
				{
					new string[] {
						"destination",
						"x",
						"y",
						"source",
					},
				}
			},
			{
				"surface_exists",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"surface_free",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"surface_getpixel",
				new string[][]
				{
					new string[] {
						"id",
						"x",
						"y",
					},
				}
			},
			{
				"surface_getpixel_ext",
				new string[][]
				{
					new string[] {
						"id",
						"x",
						"y",
					},
				}
			},
			{
				"surface_get_height",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"surface_get_width",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"surface_get_texture",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"surface_set_target",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"surface_reset_target",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"surface_save_part",
				new string[][]
				{
					new string[] {
						"id",
						"fname",
						"x",
						"y",
						"w",
						"h",
					},
				}
			},
			{
				"surface_save",
				new string[][]
				{
					new string[] {
						"id",
						"fname",
					},
				}
			},
			{
				"tan",
				new string[][]
				{
					new string[] {
						"x",
					},
				}
			},
			{
				"texture_get_height",
				new string[][]
				{
					new string[] {
						"texid",
					},
				}
			},
			{
				"texture_get_width",
				new string[][]
				{
					new string[] {
						"texid",
					},
				}
			},
			{
				"texture_get_texel_width",
				new string[][]
				{
					new string[] {
						"texid",
					},
				}
			},
			{
				"texture_get_texel_height",
				new string[][]
				{
					new string[] {
						"texid",
					},
				}
			},
			{
				"texture_preload",
				new string[][]
				{
					new string[] {
						"texid",
					},
				}
			},
			{
				"texture_set_blending",
				new string[][]
				{
					new string[] {
						"blend",
					},
				}
			},
			{
				"texture_set_interpolation",
				new string[][]
				{
					new string[] {
						"linear",
					},
				}
			},
			{
				"texture_set_interpolation_ext",
				new string[][]
				{
					new string[] {
						"sampler_id",
						"linear",
					},
				}
			},
			{
				"texture_set_priority",
				new string[][]
				{
					new string[] {
						"texid",
						"prio",
					},
				}
			},
			{
				"texture_set_repeat",
				new string[][]
				{
					new string[] {
						"repeat",
					},
				}
			},
			{
				"texture_set_repeat_ext",
				new string[][]
				{
					new string[] {
						"sampler_id",
						"repeat",
					},
				}
			},
			{
				"texture_set_stage",
				new string[][]
				{
					new string[] {
						"stage",
						"texid",
					},
				}
			},
			{
				"tile_add",
				new string[][]
				{
					new string[] {
						"background",
						"left",
						"top",
						"width",
						"height",
						"x",
						"y",
						"depth",
					},
				}
			},
			{
				"tile_delete",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"tile_exists",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"tile_get_alpha",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"tile_get_background",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"tile_get_blend",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"tile_get_depth",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"tile_get_height",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"tile_get_left",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"tile_get_top",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"tile_get_visible",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"tile_get_width",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"tile_get_xscale",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"tile_get_x",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"tile_get_yscale",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"tile_get_y",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"tile_layer_delete_at",
				new string[][]
				{
					new string[] {
						"depth",
						"x",
						"y",
					},
				}
			},
			{
				"tile_layer_delete",
				new string[][]
				{
					new string[] {
						"depth",
					},
				}
			},
			{
				"tile_layer_depth",
				new string[][]
				{
					new string[] {
						"depth",
						"newdepth",
					},
				}
			},
			{
				"tile_layer_find",
				new string[][]
				{
					new string[] {
						"depth",
						"x",
						"y",
					},
				}
			},
			{
				"tile_layer_hide",
				new string[][]
				{
					new string[] {
						"depth",
					},
				}
			},
			{
				"tile_layer_shift",
				new string[][]
				{
					new string[] {
						"depth",
						"x",
						"y",
					},
				}
			},
			{
				"tile_layer_show",
				new string[][]
				{
					new string[] {
						"depth",
					},
				}
			},
			{
				"tile_set_alpha",
				new string[][]
				{
					new string[] {
						"id",
						"alpha",
					},
				}
			},
			{
				"tile_set_background",
				new string[][]
				{
					new string[] {
						"id",
						"background",
					},
				}
			},
			{
				"tile_set_blend",
				new string[][]
				{
					new string[] {
						"id",
						"color",
					},
				}
			},
			{
				"tile_set_depth",
				new string[][]
				{
					new string[] {
						"id",
						"depth",
					},
				}
			},
			{
				"tile_set_position",
				new string[][]
				{
					new string[] {
						"id",
						"x",
						"y",
					},
				}
			},
			{
				"tile_set_region S",
				new string[][]
				{
					new string[] {
						"id",
						"left",
						"right",
						"width",
						"height S",
					},
				}
			},
			{
				"tile_set_scale",
				new string[][]
				{
					new string[] {
						"id",
						"xscale",
						"yscale",
					},
				}
			},
			{
				"tile_set_visible",
				new string[][]
				{
					new string[] {
						"id",
						"visible",
					},
				}
			},
			{
				"timeline_add",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"timeline_delete",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"timeline_exists",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"timeline_get_name",
				new string[][]
				{
					new string[] {
						"ind",
					},
				}
			},
			{
				"timeline_moment_add",
				new string[][]
				{
					new string[] {
						"ind",
						"step",
						"codestr",
					},
				}
			},
			{
				"timeline_moment_clear",
				new string[][]
				{
					new string[] {
						"ind",
						"step",
					},
				}
			},
			{
				"transition_define",
				new string[][]
				{
					new string[] {
						"kind",
						"name",
					},
				}
			},
			{
				"transition_exists",
				new string[][]
				{
					new string[] {
						"kind",
					},
				}
			},
			{
				"variable_global_array2_get",
				new string[][]
				{
					new string[] {
						"name",
						"ind1",
						"ind2",
					},
				}
			},
			{
				"variable_global_array2_set",
				new string[][]
				{
					new string[] {
						"name",
						"ind1",
						"ind2",
						"value",
					},
				}
			},
			{
				"variable_global_array_get",
				new string[][]
				{
					new string[] {
						"name",
						"ind",
					},
				}
			},
			{
				"variable_global_array_set",
				new string[][]
				{
					new string[] {
						"name",
						"ind",
						"value",
					},
				}
			},
			{
				"variable_global_exists",
				new string[][]
				{
					new string[] {
						"name",
					},
				}
			},
			{
				"variable_global_get",
				new string[][]
				{
					new string[] {
						"name",
					},
				}
			},
			{
				"variable_global_set",
				new string[][]
				{
					new string[] {
						"name",
						"value",
					},
				}
			},
			{
				"variable_local_array2_get",
				new string[][]
				{
					new string[] {
						"name",
						"ind1",
						"ind2",
					},
				}
			},
			{
				"variable_local_array_get",
				new string[][]
				{
					new string[] {
						"name",
						"ind",
					},
				}
			},
			{
				"variable_local_array_set",
				new string[][]
				{
					new string[] {
						"name",
						"ind",
						"value",
					},
				}
			},
			{
				"variable_local_exists",
				new string[][]
				{
					new string[] {
						"name",
					},
				}
			},
			{
				"variable_local_get",
				new string[][]
				{
					new string[] {
						"name",
					},
				}
			},
			{
				"variable_local_set",
				new string[][]
				{
					new string[] {
						"name",
						"value",
					},
				}
			},
			{
				"vertex_create_buffer",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"vertex_create_buffer_ext",
				new string[][]
				{
					new string[] {
						"size",
					},
				}
			},
			{
				"vertex_delete_buffer",
				new string[][]
				{
					new string[] {
						"buffer",
					},
				}
			},
			{
				"vertex_begin",
				new string[][]
				{
					new string[] {
						"buffer",
						"format",
					},
				}
			},
			{
				"vertex_colour",
				new string[][]
				{
					new string[] {
						"buffer",
						"colour",
						"alpha",
					},
				}
			},
			{
				"vertex_normal",
				new string[][]
				{
					new string[] {
						"buffer",
						"nx",
						"ny",
						"nz",
					},
				}
			},
			{
				"vertex_position",
				new string[][]
				{
					new string[] {
						"buffer",
						"x",
						"y",
					},
				}
			},
			{
				"vertex_position_3d",
				new string[][]
				{
					new string[] {
						"buffer",
						"x",
						"y",
						"z",
					},
				}
			},
			{
				"vertex_argb",
				new string[][]
				{
					new string[] {
						"buffer",
						"a",
						"r",
						"g",
						"b",
					},
				}
			},
			{
				"vertex_texcoord",
				new string[][]
				{
					new string[] {
						"buffer",
						"u",
						"v",
					},
				}
			},
			{
				"vertex_float1",
				new string[][]
				{
					new string[] {
						"buffer",
						"f1",
					},
				}
			},
			{
				"vertex_float2",
				new string[][]
				{
					new string[] {
						"buffer",
						"f1",
						"f2",
					},
				}
			},
			{
				"vertex_float3",
				new string[][]
				{
					new string[] {
						"buffer",
						"f1",
						"f2",
						"f3",
					},
				}
			},
			{
				"vertex_float4",
				new string[][]
				{
					new string[] {
						"buffer",
						"f1",
						"f2",
						"f3",
						"f4",
					},
				}
			},
			{
				"vertex_ubyte4",
				new string[][]
				{
					new string[] {
						"buffer",
						"b1",
						"b2",
						"b3",
						"b4",
					},
				}
			},
			{
				"vertex_end",
				new string[][]
				{
					new string[] {
						"buffer",
					},
				}
			},
			{
				"vertex_freeze",
				new string[][]
				{
					new string[] {
						"buffer",
					},
				}
			},
			{
				"vertex_submit",
				new string[][]
				{
					new string[] {
						"buffer",
						"primitive",
						"texture",
					},
				}
			},
			{
				"vertex_delete",
				new string[][]
				{
					new string[] {
						"buffer",
					},
				}
			},
			{
				"vertex_format_begin",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"vertex_format_add_colour",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"vertex_format_add_position",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"vertex_format_add_position_3d",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"vertex_format_add_textcoord",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"vertex_format_add_normal",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"vertex_format_add_custom",
				new string[][]
				{
					new string[] {
						"type",
						"usage",
					},
				}
			},
			{
				"vertex_format_end",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"win8_device_touchscreen_available",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"win8_livetile_notification_begin",
				new string[][]
				{
					new string[] {
						"template",
					},
				}
			},
			{
				"win8_livetile_notification_secondary_begin",
				new string[][]
				{
					new string[] {
						"template",
						"tile_id",
					},
				}
			},
			{
				"win8_livetile_notification_expiry",
				new string[][]
				{
					new string[] {
						"expiry_time",
					},
				}
			},
			{
				"win8_livetile_notification_tag",
				new string[][]
				{
					new string[] {
						"tag",
					},
				}
			},
			{
				"win8_livetile_notification_text_add",
				new string[][]
				{
					new string[] {
						"text",
					},
				}
			},
			{
				"win8_livetile_notification_image_add",
				new string[][]
				{
					new string[] {
						"image",
					},
				}
			},
			{
				"win8_livetile_notification_end",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"win8_livetile_tile_notification",
				new string[][]
				{
					new string[] {
						"template",
						" ds_map",
						" expiry",
						" tag",
					},
				}
			},
			{
				"win8_livetile_tile_clear",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"win8_livetile_badge_notification",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"win8_livetile_badge_clear",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"win8_livetile_queue_enable",
				new string[][]
				{
					new string[] {
						"enabled",
					},
				}
			},
			{
				"win8_secondarytile_pin",
				new string[][]
				{
					new string[] {
						"tile_id",
						"short_name",
						"display_name",
						"cmd_line_args",
						"ds_list_options",
						"image",
						"wide_image",
						"text_col",
					},
				}
			},
			{
				"win8_secondarytile_badge_notification",
				new string[][]
				{
					new string[] {
						"data",
						"tile_id",
					},
				}
			},
			{
				"win8_secondarytile_delete",
				new string[][]
				{
					new string[] {
						"tile_id",
					},
				}
			},
			{
				"win8_appbar_enable",
				new string[][]
				{
					new string[] {
						"enabled",
					},
				}
			},
			{
				"win8_appbar_add_element",
				new string[][]
				{
					new string[] {
						"type",
						"icon",
						"label",
						"section",
						"tooltip",
						"callback",
					},
				}
			},
			{
				"win8_appbar_remove_element",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"win8_settingscharm_add_entry",
				new string[][]
				{
					new string[] {
						"name",
						"callback",
					},
				}
			},
			{
				"win8_settingscharm_add_html_entry",
				new string[][]
				{
					new string[] {
						"id",
						"name",
						"htmlpath",
					},
				}
			},
			{
				"win8_settingscharm_remove_entry",
				new string[][]
				{
					new string[] {
						"name",
					},
				}
			},
			{
				"win8_share_image",
				new string[][]
				{
					new string[] {
						"filename",
						"title",
						"description",
						"immediate",
					},
				}
			},
			{
				"win8_share_screenshot",
				new string[][]
				{
					new string[] {
						"title",
						"description",
						"immediate",
					},
				}
			},
			{
				"win8_share_file",
				new string[][]
				{
					new string[] {
						"filename",
						"title",
						"description",
						"immediate",
					},
				}
			},
			{
				"win8_share_url",
				new string[][]
				{
					new string[] {
						"URL",
						"title",
						"description",
						"immediate",
					},
				}
			},
			{
				"win8_share_text",
				new string[][]
				{
					new string[] {
						"text",
						"title",
						"description",
						"immediate",
					},
				}
			},
			{
				"win8_search_enable",
				new string[][]
				{
					new string[] {
						"callback",
					},
				}
			},
			{
				"win8_search_add_suggestions",
				new string[][]
				{
					new string[] {
						"list",
					},
				}
			},
			{
				"win8_search_disable",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"win8_license_trial_version",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"win8_license_initialize_sandbox",
				new string[][]
				{
					new string[] {
						"xml",
					},
				}
			},
			{
				"window_center",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"window_default",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"window_get_caption",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"window_get_color",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"window_get_cursor",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"window_get_fullscreen",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"window_get_height",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"window_get_region_height",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"window_get_region_scale",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"window_get_region_width",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"window_get_showborder",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"window_get_showicons",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"window_get_sizeable",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"window_get_stayontop",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"window_get_visible",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"window_get_width",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"window_get_x",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"window_get_y",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"window_handle",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"window_mouse_get_x",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"window_mouse_get_y",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"window_mouse_set",
				new string[][]
				{
					new string[] {
						"x",
						"y",
					},
				}
			},
			{
				"window_set_caption",
				new string[][]
				{
					new string[] {
						"caption",
					},
				}
			},
			{
				"window_set_color",
				new string[][]
				{
					new string[] {
						"color",
					},
				}
			},
			{
				"window_set_cursor",
				new string[][]
				{
					new string[] {
						"curs",
					},
				}
			},
			{
				"window_set_fullscreen",
				new string[][]
				{
					new string[] {
						"full",
					},
				}
			},
			{
				"window_set_position",
				new string[][]
				{
					new string[] {
						"x",
						"y",
					},
				}
			},
			{
				"window_set_rectangle",
				new string[][]
				{
					new string[] {
						"x",
						"y",
						"w",
						"h",
					},
				}
			},
			{
				"window_set_region_scale",
				new string[][]
				{
					new string[] {
						"scale",
						"adaptwindow",
					},
				}
			},
			{
				"window_set_region_size",
				new string[][]
				{
					new string[] {
						"w",
						"h",
						"adaptwindow",
					},
				}
			},
			{
				"window_set_showborder",
				new string[][]
				{
					new string[] {
						"show",
					},
				}
			},
			{
				"window_set_showicons",
				new string[][]
				{
					new string[] {
						"show",
					},
				}
			},
			{
				"window_set_sizeable",
				new string[][]
				{
					new string[] {
						"sizeable",
					},
				}
			},
			{
				"window_set_size",
				new string[][]
				{
					new string[] {
						"w",
						"h",
					},
				}
			},
			{
				"window_set_stayontop",
				new string[][]
				{
					new string[] {
						"stay",
					},
				}
			},
			{
				"window_set_visible",
				new string[][]
				{
					new string[] {
						"visible",
					},
				}
			},
			{
				"window_views_mouse_get_x",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"window_views_mouse_get_y",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"window_views_mouse_set",
				new string[][]
				{
					new string[] {
						"x",
						"y",
					},
				}
			},
			{
				"window_view_mouse_get_x",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"window_view_mouse_get_y",
				new string[][]
				{
					new string[] {
						"id",
					},
				}
			},
			{
				"window_view_mouse_set",
				new string[][]
				{
					new string[] {
						"id",
						"x",
						"y",
					},
				}
			},
			{
				"winphone_license_trial_version",
				new string[][]
				{
					new string[] {
					},
				}
			},
			{
				"winphone_tile_back_content",
				new string[][]
				{
					new string[] {
						"string",
					},
				}
			},
			{
				"winphone_tile_back_content_wide",
				new string[][]
				{
					new string[] {
						"string",
					},
				}
			},
			{
				"winphone_tile_back_image",
				new string[][]
				{
					new string[] {
						"img",
					},
				}
			},
			{
				"winphone_tile_back_image_wide",
				new string[][]
				{
					new string[] {
						"img",
					},
				}
			},
			{
				"winphone_tile_back_title",
				new string[][]
				{
					new string[] {
						"title",
					},
				}
			},
			{
				"winphone_tile_background_color",
				new string[][]
				{
					new string[] {
						"color",
					},
				}
			},
			{
				"winphone_tile_count",
				new string[][]
				{
					new string[] {
						"num",
					},
				}
			},
			{
				"winphone_tile_cycle_images",
				new string[][]
				{
					new string[] {
						"fname0",
						"fname1",
						"...",
					},
				}
			},
			{
				"winphone_tile_front_image",
				new string[][]
				{
					new string[] {
						"img",
					},
				}
			},
			{
				"winphone_tile_front_image_small",
				new string[][]
				{
					new string[] {
						"img",
					},
				}
			},
			{
				"winphone_tile_front_image_width",
				new string[][]
				{
					new string[] {
						"img",
					},
				}
			},
			{
				"winphone_tile_icon_image",
				new string[][]
				{
					new string[] {
						"fname",
					},
				}
			},
			{
				"winphone_tile_small_background_image",
				new string[][]
				{
					new string[] {
						"img",
					},
				}
			},
			{
				"winphone_tile_small_icon_image",
				new string[][]
				{
					new string[] {
						"fname",
					},
				}
			},
			{
				"winphone_tile_title",
				new string[][]
				{
					new string[] {
						"title",
					},
				}
			},
			{
				"winphone_tile_wide_content",
				new string[][]
				{
					new string[] {
						"string",
						"index",
					},
				}
			},

        };
    }
}