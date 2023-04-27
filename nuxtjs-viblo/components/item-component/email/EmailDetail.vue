<template>
    <div class="email-detail">
        <div class="email-detail-navbar-block">

            <div class="email-detail-navbar-title">Chỉnh sửa {{ emailItem.title }}</div>
            <div class="email-detail-navbar-line"></div>

            <div class="email-detail-navbar-content-title-block">
                <div class="email-detail-navbar-content-title">Tiêu đề</div>
                <div class="email-detail-navbar-content-input">
                    <input type="text" width="100%" v-model="emailItem.name">
                </div>

            </div>
            <div class="email-detail-navbar-content-description-block">
                <div class="email-detail-navbar-content-title">Mô tả</div>
                <div class="email-detail-navbar-description-input">
                    <textarea name="" id="" cols="30" rows="6" style="width: 100%;"
                        v-model="emailItem.description"></textarea>
                </div>

            </div>
            <div class="email-detail-navbar-content-status-block">
                <div class="email-detail-navbar-content-title">Bắt buộc</div>
                <div class="email-detail-navbar-status-input"></div>

            </div>
            <div class="email-detail-navbar-content-status-block">
                <div class="email-detail-navbar-content-title">Xác thực OTP</div>
                <div class="email-detail-navbar-status-input"></div>

            </div>
            <div class="email-detail-navbar-line-2"></div>
            <div class="email-detail-navbar-footer-block">
                <div class="email-detail-navbar-cancel-btn" @click="goBack">Hủy</div>
                <div class="email-detail-navbar-save-btn" @click="save">Lưu chỉnh sửa</div>

            </div>


        </div>
        <div class="email-detail-form-block">
            <div class="email-detail-form-content-block">
                <div class="email-detail-form-content-center-block">
                    <div class="email-detail-form-content-center-title-block">
                        <div class="email-detail-form-content-center-title">{{ emailItem.name }}</div>
                        <div class="email-detail-form-content-center-description">{{ emailItem.description }}</div>
                    </div>
                    <div class="email-detail-form-content-center-input-block"></div>

                </div>
            </div>
        </div>
    </div>
</template>
<script>
import { v4 as uuidv4 } from 'uuid'

export default {
    components: {

    },
    props: {
        item: Object,
        groupIndex: Number,
    },
    data() {
        return {
            groups: [],
            emailItem: this.item,
            activeGroupIndex: null,
        };
    },
    mounted() {

        if (this.item.is_create == true) {
            this.emailItem = this.item;
            // this.emailItem.is_create=false;
            this.loadFromLocalStorage();


        } else {

            this.loadFromLocalStorage();
            this.findItem();
        }

    },
    methods: {
        goBack() {
            this.$router.go(-1);
        },
        create() {
            debugger
            this.emailItem.is_create = false;
            console.log(this.groups[this.groupIndex]);
            this.groups[this.groupIndex].items.push(this.emailItem);

        },
        update() {
            const a = this.groups.filter(row => {
                return row
            });
            const b = this.item.id;
                a[this.groupIndex].items.forEach(element => {
                    if (element.id == b) {
                        console.log(element);
                        element = this.emailItem;
                    }
        });
           
        },
        save() {
            if (this.emailItem.is_create == true) {
                this.create();
            } else {
                this.update();
            }
            localStorage.setItem("myObject", JSON.stringify(this.groups));
        },
        loadFromLocalStorage() {
            const savedObject = localStorage.getItem("myObject");
            if (savedObject) {
                this.groups = JSON.parse(savedObject);

               
            }

        },
        findItem(){
            const a = this.groups.filter(row => {
                    return row
                });
                const b = this.item.id;
                for (var i = 0; i < a.length; i++) {
                    a[i].items.forEach(element => {
                        if (element.id == b) {
                            console.log(element);
                            this.emailItem = element;
                        }
                    });
                }
        }
    }
}

</script>
<style scoped>
.email-detail {
    box-sizing: border-box;

    /* Auto layout */

    display: flex;
    flex-direction: row;
    align-items: flex-start;
    padding: 20px 16px 20px 20px;
    gap: 24px;

    width: 468px;
    height: 1008px;

    background: #FFFFFF;
    /* grey / 05 */

    border-right: 1px solid #D0D5DD;

    /* Inside auto layout */

    flex: none;
    order: 0;
    flex-grow: 0;
}

.email-detail-navbar-block {
    display: flex;
    flex-direction: column;
    align-items: flex-start;
    padding: 0px;
    gap: 32px;

    width: 400px;
    height: 634px;


    /* Inside auto layout */

    flex: none;
    order: 0;
    flex-grow: 1;
}

.email-detail-navbar-title {
    width: 273px;
    height: 29px;

    font-family: 'Inter';
    font-style: normal;
    font-weight: 600;
    font-size: 24px;
    line-height: 29px;
    /* identical to box height */

    /* text-align: center; */

    /* grey / 10 */

    color: #1D2939;


    /* Inside auto layout */

    flex: none;
    order: 0;
    flex-grow: 0;
}

.email-detail-navbar-line {
    width: 400px;
    height: 0px;

    /* grey / 05 */

    border: 1px solid #D0D5DD;

    /* Inside auto layout */

    flex: none;
    order: 1;
    align-self: stretch;
    flex-grow: 0;
}

.email-detail-navbar-line-2 {
    width: 400px;
    height: 0px;

    /* grey / 05 */

    border: 1px solid #D0D5DD;

    /* Inside auto layout */

    flex: none;
    order: 7;
    align-self: stretch;
    flex-grow: 0;
}

.email-detail-navbar-content-title-block {
    display: flex;
    flex-direction: column;
    align-items: flex-start;
    padding: 0px;
    gap: 16px;

    width: 400px;
    height: 108px;


    /* Inside auto layout */

    flex: none;
    order: 2;
    align-self: stretch;
    flex-grow: 0;
}

.email-detail-navbar-content-title {
    width: 65px;
    height: 22px;

    font-family: 'Inter';
    font-style: normal;
    font-weight: 600;
    font-size: 18px;
    line-height: 22px;
    /* identical to box height */
    white-space: nowrap;

    /* text-align: center; */

    /* grey / 11 */

    color: #101828;


    /* Inside auto layout */

    flex: none;
    order: 0;
    flex-grow: 0;
}

.email-detail-navbar-content-input {
    box-sizing: border-box;

    /* Auto layout */

    display: flex;
    flex-direction: row;
    justify-content: space-between;
    align-items: center;
    padding: 13px 16px;

    width: 400px;
    height: 70px;

    background: #F3FAFF;
    /* Dark / Variant 5 */

    border: 1px solid #C1D6E9;
    border-radius: 6px;

    /* Inside auto layout */

    flex: none;
    order: 1;
    align-self: stretch;
    flex-grow: 0;
}

.email-detail-navbar-content-description-block {
    display: flex;
    flex-direction: column;
    align-items: flex-start;
    padding: 0px;
    gap: 16px;

    width: 100%;
    height: 177px;


    /* Inside auto layout */

    flex: none;
    order: 3;
    align-self: stretch;
    flex-grow: 0;
}

.email-detail-navbar-content-status-block {
    display: flex;
    flex-direction: row;
    justify-content: space-between;
    align-items: center;
    padding: 0px;
    gap: 8px;

    width: 400px;
    height: 26px;


    /* Inside auto layout */

    flex: none;
    order: 4;
    align-self: stretch;
    flex-grow: 0;
}

.email-detail-navbar-footer-block {


    /* Auto layout */
    display: flex;
    flex-direction: row;
    align-items: flex-start;
    padding: 0px;
    gap: 24px;

    width: 400px;
    height: 44px;


    /* Inside auto layout */

    flex: none;
    order: 8;
    align-self: stretch;
    flex-grow: 0;
}

.email-detail-navbar-cancel-btn {
    box-sizing: border-box;

    /* Auto layout */
    cursor: pointer;
    display: flex;
    flex-direction: row;
    justify-content: center;
    align-items: center;
    padding: 12px 24px;
    gap: 10px;

    width: 188px;
    height: 44px;

    /* grey / 07 */

    border: 1px solid #667085;
    border-radius: 4px;

    /* Inside auto layout */

    flex: none;
    order: 0;
    flex-grow: 1;
}

.email-detail-navbar-save-btn {
    display: flex;
    flex-direction: row;
    justify-content: center;
    align-items: center;
    padding: 12px 24px;
    gap: 10px;

    width: 188px;
    height: 44px;

    /* g2 */
    cursor: pointer;

    background: linear-gradient(90deg, #6782DF 0%, #29B8E9 100%);
    border-radius: 4px;

    /* Inside auto layout */

    flex: none;
    order: 1;
    flex-grow: 1;
}

.email-detail-form-block {
    display: flex;
    flex-direction: column;
    align-items: flex-start;
    padding: 60px 112px;
    gap: 10px;

    width: 1452px;
    height: 1016px;


    /* Inside auto layout */

    flex: none;
    order: 1;
    align-self: stretch;
    flex-grow: 1;
}

.email-detail-form-content-block {
    display: flex;
    flex-direction: column;
    align-items: center;
    padding: 48px;
    gap: 40px;

    width: 1228px;
    height: 896px;

    background: #FFFFFF;
    box-shadow: 0px 20px 40px rgba(0, 0, 0, 0.1);

    /* Inside auto layout */

    flex: none;
    order: 0;
    align-self: stretch;
    flex-grow: 1;
}

.email-detail-form-content-center-block {
    display: flex;
    flex-direction: column;
    align-items: flex-start;
    padding: 0px;
    gap: 24px;

    width: 1132px;
    height: 128px;


    /* Inside auto layout */

    flex: none;
    order: 0;
    align-self: stretch;
    flex-grow: 0;
}

.email-detail-form-content-center-title-block {
    display: flex;
    flex-direction: column;
    align-items: flex-start;
    padding: 0px;
    gap: 8px;

    width: 100%;
    height: 51px;


    /* Inside auto layout */

    flex: none;
    order: 0;
    flex-grow: 0;
}

.email-detail-form-content-center-title {
    width: 114px;
    height: 22px;

    font-family: 'Inter';
    font-style: normal;
    font-weight: 600;
    font-size: 18px;
    line-height: 22px;
    /* identical to box height */

    /* text-align: center; */

    /* grey / 11 */

    color: #101828;
    white-space: nowrap;


    /* Inside auto layout */

    flex: none;
    order: 0;
    flex-grow: 0;
}

.email-detail-form-content-center-description {
    width: 100%;
    height: 21px;

    font-family: 'Inter';
    font-style: normal;
    font-weight: 300;
    font-size: 16px;
    line-height: 21px;
    /* identical to box height, or 131% */
    /* white-space: nowrap; */


    /* grey / 08 */

    color: #475467;


    /* Inside auto layout */

    flex: none;
    order: 1;
    flex-grow: 0;
}

.email-detail-form-content-center-input-block {
    box-sizing: border-box;

    /* Auto layout */

    display: flex;
    flex-direction: column;
    align-items: flex-start;
    padding: 16px;
    gap: 8px;

    width: 1132px;
    height: 53px;

    background: #F5FAFF;
    /* Blue / 04 */

    border: 1px solid #B2DDFF;
    border-radius: 8px;

    /* Inside auto layout */

    flex: none;
    order: 1;
    align-self: stretch;
    flex-grow: 0;
}</style>