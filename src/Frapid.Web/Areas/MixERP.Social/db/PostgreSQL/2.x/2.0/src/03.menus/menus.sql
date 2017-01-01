﻿DELETE FROM auth.menu_access_policy
WHERE menu_id IN
(
 SELECT menu_id FROM core.menus
 WHERE app_name = 'Social'
);

DELETE FROM auth.group_menu_access_policy
WHERE menu_id IN
(
 SELECT menu_id FROM core.menus
 WHERE app_name = 'Social'
);

DELETE FROM core.menus
WHERE app_name = 'Social';


SELECT * FROM core.create_app('Social', 'Social', '1.0', 'MixERP Inc.', 'December 1, 2015', 'orange users', '/dashboard/social', NULL);

SELECT * FROM core.create_menu('Social', 'Tasks', '', 'lightning', '');
SELECT * FROM core.create_menu( 'Social', 'Social', '/dashboard/social', 'users', 'Tasks');





SELECT * FROM auth.create_app_menu_policy
(
    'Admin', 
    core.get_office_id_by_office_name('Default'), 
    'Social',
    '{*}'::text[]
);